using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;
using Common;
using SharpBgfx;
using static SDL2.SDL;
using static physx;

[StructLayout(LayoutKind.Sequential)]
public struct PosColorVertex
{
    float x;
    float y;
    float z;
    uint abgr;

    public PosColorVertex(float x, float y, float z, uint abgr)
    {
        this.x = x;
        this.y = y;
        this.z = z;
        this.abgr = abgr;
    }

    public static readonly VertexLayout Layout = new VertexLayout().Begin()
        .Add(VertexAttributeUsage.Position, 3, VertexAttributeType.Float)
        .Add(VertexAttributeUsage.Color0, 4, VertexAttributeType.UInt8, true)
        .End();
}

abstract class DebugRenderer
{
    private readonly IntPtr sdlWindowPtr_;

    public bool HasMouseFocus => SDL_GetMouseFocus() == sdlWindowPtr_;
    public (int w, int h) FrameBufferSize { get; private set; }

    private readonly Program shaders_;
    private UnmanagedCollection<PosColorVertex> userLines_ = new UnmanagedCollection<PosColorVertex>();

    protected PxPhysicsPtr pxPhysics;
    protected PxScenePtr pxScene;

    private Vector3 cameraPosition = new Vector3(5.0f, 15.0f, -20.0f);

    #region Static Stuff

    private static DebugRenderer instance_;

    class ExternalDebugRenderer : DebugRenderer
    {
        protected override void OnInit() {}
        protected override void OnUpdate(double frameTime) {}
    }

    public static void InitFor(PxScenePtr scene, Vector3? camPos = null)
    {
        instance_ = new ExternalDebugRenderer();
        instance_.pxScene = scene;
        instance_.SetSceneDebugFlags();
        if (camPos != null) instance_.cameraPosition = camPos.Value;
    }

    public static void Update()
    {
        instance_.UpdateWindowSize();
        instance_.SetupView();
        instance_.SubmitLines();
        Bgfx.Frame();
    }

    public static void Shutdown()
    {
        instance_.Shutdown_();
    }

    #endregion

    public DebugRenderer(int width = 800, int height = 450, int x = 0, int y = 0)
    {
        if (SDL_Init(SDL_INIT_VIDEO) < 0)
            throw new Exception("SDL couldn't initialize");

        sdlWindowPtr_ = SDL_CreateWindow("SharpPhysX DebugRenderer", x, y, width, height,
            SDL_WindowFlags.SDL_WINDOW_SHOWN);
        if (sdlWindowPtr_ == IntPtr.Zero)
            throw new Exception("SDL couldn't create window");

        SDL_SetWindowResizable(sdlWindowPtr_, SDL_bool.SDL_TRUE);
        SDL_SetWindowPosition(sdlWindowPtr_, SDL_WINDOWPOS_CENTERED, SDL_WINDOWPOS_CENTERED);

        SDL_SysWMinfo sysWMinfo = new SDL_SysWMinfo();
        SDL_GetWindowWMInfo(sdlWindowPtr_, ref sysWMinfo);

        //todo: need to pass ndt for linux and mac

        Bgfx.SetWindowHandle(sysWMinfo.info.win.window);
        Bgfx.Init();
        Bgfx.SetDebugFeatures(DebugFeatures.DisplayText);
        Bgfx.SetViewClear(0, ClearTargets.Color | ClearTargets.Depth, 0x303030ff);

        shaders_ = ResourceLoader.LoadProgram("vs_cubes", "fs_cubes");

        UpdateWindowSize();

        InitPhysX();
    }

    protected abstract void OnInit();
    protected abstract void OnUpdate(double frameTime);

    void InitPhysX()
    {
        var foundation = SharpPhysX.CreateFoundation(SharpPhysX.DefaultErrorCallback);
        pxPhysics = PxPhysics.PxCreatePhysics(PX_PHYSICS_VERSION, foundation, PxTolerancesScale.Default());

        var sceneDesc = PxSceneDescPtr.New(PxTolerancesScale.Default());
        sceneDesc.gravity = new PxVec3(0, -9.81f, 0);
        sceneDesc.cpuDispatcher = PxDefaultCpuDispatcherCreate(2);
        sceneDesc.filterShader = PxDefaultSimulationFilterShader;

        pxScene = pxPhysics.createScene(sceneDesc);
        SetSceneDebugFlags();
        var material = pxPhysics.createMaterial(.5f, .5f, .6f);
        var groundPlane = PxCreatePlane(pxPhysics, new PxPlane(0, 1, 0, 0), material);
        pxScene.addActor(groundPlane);

        OnInit();
    }

    void SetSceneDebugFlags()
    {
        pxScene.setVisualizationParameter(PxVisualizationParameterEnum.eSCALE, 1);
        pxScene.setVisualizationParameter(PxVisualizationParameterEnum.eACTOR_AXES, 1);
        pxScene.setVisualizationParameter(PxVisualizationParameterEnum.eCOLLISION_SHAPES, 1);
        pxScene.setVisualizationParameter(PxVisualizationParameterEnum.eCOLLISION_STATIC, 1);
    }


    public unsafe void Run()
    {
        Stopwatch clock = new Stopwatch();
        bool quit = false;
        while (!quit)
        {
            var frameTime = clock.Elapsed.TotalMilliseconds;
            clock.Restart();

            while (SDL_PollEvent(out SDL_Event sdlEvent) != 0)
            {
                if (sdlEvent.type == SDL_EventType.SDL_QUIT) quit = true;
                if (sdlEvent.type == SDL_EventType.SDL_WINDOWEVENT &&
                    sdlEvent.window.windowEvent == SDL_WindowEventID.SDL_WINDOWEVENT_SIZE_CHANGED)
                    UpdateWindowSize();
                if (HasMouseFocus)
                {
                    (float camDeltaX, float camDeltaY, float camZoomDelta) camDeltas = default;

                    if (sdlEvent.type == SDL_EventType.SDL_MOUSEMOTION &&
                        (SDL_GetMouseState(IntPtr.Zero, IntPtr.Zero) & SDL_BUTTON(SDL_BUTTON_RIGHT)) != 0)
                    {
                        const float mSens = 0.01f;
                        camDeltas.camDeltaX = sdlEvent.motion.xrel * -mSens;
                        camDeltas.camDeltaY = sdlEvent.motion.yrel * mSens;
                    }

                    if (sdlEvent.type == SDL_EventType.SDL_MOUSEWHEEL)
                    {
                        camDeltas.camZoomDelta = sdlEvent.wheel.y * 0.1f;
                    }

                    cameraPosition = Vector3.TransformNormal(
                        cameraPosition,
                        Matrix4x4.CreateFromYawPitchRoll(
                            camDeltas.camDeltaX,
                            camDeltas.camDeltaY,
                            0) *
                        Matrix4x4.CreateScale(1 + camDeltas.camZoomDelta)
                    );
                }
            }

            OnUpdate(frameTime);

            pxScene.simulate(1/60f);
            pxScene.fetchResults(true);

            SetupView();
            SubmitLines();

            Bgfx.DebugTextClear();
            Bgfx.DebugTextWrite(0, 0, DebugColor.Blue, DebugColor.LightGreen, 
                $"SharpPhysX DebugRenderer. FPS: {(int)(1000/frameTime+0.5f)}, frame time: {frameTime:##.00}ms");

            Bgfx.Frame();
        }

        Shutdown_();
    }

    private unsafe void SetupView()
    {
        Bgfx.SetViewRect(0, 0, 0, FrameBufferSize.w, FrameBufferSize.h);
        Bgfx.Touch(0);

        var viewMatrix = Matrix4x4.CreateLookAt(cameraPosition, Vector3.Zero, Vector3.UnitY);
        var projMatrix = Matrix4x4.CreatePerspectiveFieldOfView((float)Math.PI / 3,
            (float)FrameBufferSize.w / FrameBufferSize.h, 0.1f, 1000.0f);
        Bgfx.SetViewTransform(0, &viewMatrix.M11, &projMatrix.M11);
        Bgfx.SetTransform(null);
    }

    private unsafe void SubmitLines()
    {
        // render physx debug lines
        var pxRenderBuffer = pxScene.getRenderBuffer();
        var pxLineCount = pxRenderBuffer.getNbLines();
        var pxLineBuffer = pxRenderBuffer.getLines();
        var pxLineBufferSize = pxLineCount * sizeof(PxDebugLine);

        var pxLinesTvb = new TransientVertexBuffer((int)(pxLineCount * 2), PosColorVertex.Layout);
        Buffer.MemoryCopy(pxLineBuffer, (void*)pxLinesTvb.Data, (ulong)pxLineBufferSize, (ulong)pxLineBufferSize);

        Bgfx.SetRenderState(RenderState.WriteRGB | RenderState.PrimitiveLines);
        Bgfx.SetVertexBuffer(0, pxLinesTvb, 0, (int)pxLineCount * 2);
        Bgfx.Submit(0, shaders_);


        // render user debug lines TODO addline and such
//            userLines_.Add(new PosColorVertex(0,0,0,0xffffffff));
//            userLines_.Add(new PosColorVertex(1,1,1,0xffffffff));
//
//            var tvb = new TransientVertexBuffer(userLines_.Count, PosColorVertex.Layout);
//            userLines_.CopyTo(tvb.Data);
//
//            Bgfx.SetRenderState(RenderState.WriteRGB|RenderState.PrimitiveLines);
//            Bgfx.SetVertexBuffer(0, tvb, 0, userLines_.Count);
//            Bgfx.Submit(0, shaders_);
//
//            userLines_.Clear();
    }

    private void Shutdown_()
    {
        shaders_.Dispose();
        Bgfx.Shutdown();
        SDL_DestroyWindow(sdlWindowPtr_);
        SDL_Quit();
    }

    private void UpdateWindowSize()
    {
        SDL_GetWindowSize(sdlWindowPtr_, out int x, out int y);
        var newSize = (x, y);
        if (newSize != FrameBufferSize)
        {
            FrameBufferSize = newSize;
            Bgfx.Reset(x, y, ResetFlags.Vsync);
        }
    }
}

class TestDebugRenderer : DebugRenderer
{
    protected override void OnInit()
    {
        var geometry = new PxBoxGeometry(0.5f,0.5f,0.5f);
        var material = pxPhysics.createMaterial(.5f, .5f, .5f);

        var wallSize = 32;
        for (int i = 0; i < wallSize; i++)
        {
            for (int j = 0; j < wallSize; j++)
            {
                var transform = new PxTransform(new PxVec3(i-wallSize/2, j, 0));
                PxRigidDynamicPtr dynamic = PxCreateDynamic(pxPhysics, transform, geometry, material, 10);
                dynamic.setAngularDamping(.5f);
                pxScene.addActor(dynamic);
            }
        }
    }

    protected override void OnUpdate(double frameTime)
    {
    }
}

class MainEntry
{
    static void Main() => new TestDebugRenderer().Run();
}