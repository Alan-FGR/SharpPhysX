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

public abstract class DebugRenderer
{
    private readonly IntPtr sdlWindowPtr_;

    public bool HasMouseFocus => SDL_GetMouseFocus() == sdlWindowPtr_;
    public (int w, int h) FrameBufferSize { get; private set; }

    private readonly Program shaders_;
    private UnmanagedCollection<PosColorVertex> userLines_ = new UnmanagedCollection<PosColorVertex>();

    protected PxPhysicsPtr pxPhysics;
    protected PxScenePtr pxScene;

    private (float yaw, float pitch, float dist) cameraPosition = (45, 30, 30);
    private float targetHeight = 5;

    #region Static Stuff

    private static DebugRenderer instance_;

    class ExternalDebugRenderer : DebugRenderer
    {
        protected override void OnInit() {}
        protected override void OnUpdate(double frameTime) {}
    }

    public static void InitFor(PxScenePtr scene, (int yaw, int pitch, int dist)? camPos = null)
    {
        instance_ = new ExternalDebugRenderer();
        instance_.pxScene = scene;
        instance_.SetSceneDebugFlags();
        if (camPos != null) instance_.cameraPosition = camPos.Value;
    }

    public static void Update()
    {
        if (instance_ == null)
        {
            Console.WriteLine("Static instance not initialized. " +
                              "Call DebugRenderer.InitFor() and pass your scene.");
            return;
        }
        instance_.UpdateWindowSize();
        instance_.SetupView();
        instance_.SubmitLines();
        Bgfx.Frame();
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

        shaders_ = ResourceLoader.LoadProgram("vs_lines", "fs_lines");

        UpdateWindowSize();

        if (!(this is ExternalDebugRenderer))
        {
            InitPhysX();
            Run();
        }
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

    private unsafe void Run()
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
                    if (sdlEvent.type == SDL_EventType.SDL_MOUSEMOTION &&
                        (SDL_GetMouseState(IntPtr.Zero, IntPtr.Zero) & SDL_BUTTON(SDL_BUTTON_RIGHT)) != 0)
                    {
                        const float mSens = 0.5f;
                        cameraPosition.yaw   += sdlEvent.motion.xrel * -mSens;
                        cameraPosition.pitch += sdlEvent.motion.yrel * mSens;
                    }

                    if (sdlEvent.type == SDL_EventType.SDL_MOUSEWHEEL)
                    {
                        cameraPosition.dist *= 1 + sdlEvent.wheel.y * -0.1f;
                    }

                    byte* state = (byte*)SDL_GetKeyboardState(out var numkeys);

                    if (state[(int)SDL_GetScancodeFromKey(SDL_Keycode.SDLK_w)] != 0)
                        targetHeight += 1;
                    if (state[(int)SDL_GetScancodeFromKey(SDL_Keycode.SDLK_s)] != 0)
                        targetHeight -= 1;

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

        ShutdownPhysX();
        ShutdownRenderer();
    }

    private unsafe void SetupView()
    {
        Bgfx.SetViewRect(0, 0, 0, FrameBufferSize.w, FrameBufferSize.h);
        Bgfx.Touch(0);

        var viewMatrix = Matrix4x4.CreateLookAt(
            Vector3.Transform(cameraPosition.dist * -Vector3.UnitZ,
                Matrix4x4.CreateRotationX((float)(Math.PI / 180 * cameraPosition.pitch)) *
                Matrix4x4.CreateRotationY((float)(Math.PI / 180 * cameraPosition.yaw))),
            Vector3.UnitY*targetHeight, Vector3.UnitY);
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

    private bool wasShutdown_ = false;
    private void ShutdownRenderer()
    {
        wasShutdown_ = true;
        shaders_.Dispose();
        Bgfx.Frame();
        Bgfx.Shutdown();
        SDL_DestroyWindow(sdlWindowPtr_);
        SDL_Quit();
    }

    private void ShutdownPhysX()
    {
        pxScene.release();
        var foundation = pxPhysics.getFoundation();
        pxPhysics.release();
        foundation.release();
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

    ~DebugRenderer()
    {
        if (!wasShutdown_)
        {
            Console.WriteLine("Shutting DebugRenderer down in the finalizer.");
            ShutdownRenderer();
        }
    }
}
