using System;
using SharpBgfx;
using static SDL2.SDL;
using System.Numerics;

class DebugRenderer
{
    private readonly IntPtr sdlWindowPtr_;

    public bool HasMouseFocus => SDL_GetMouseFocus() == sdlWindowPtr_;
    public (int w, int h) FrameBufferSize { get; private set; }

    private readonly Program shaders_;

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

        shaders_ = Common.ResourceLoader.LoadProgram("vs_cubes", "fs_cubes");

        UpdateWindowSize();
    }

    public unsafe void Run()
    {
        bool quit = false;
        while (!quit)
        {
            while (SDL_PollEvent(out SDL_Event sdlEvent) != 0)
            {
                if (sdlEvent.type == SDL_EventType.SDL_QUIT) quit = true;
                if (sdlEvent.type == SDL_EventType.SDL_WINDOWEVENT &&
                    sdlEvent.window.windowEvent == SDL_WindowEventID.SDL_WINDOWEVENT_SIZE_CHANGED)
                    UpdateWindowSize();
            }

            Bgfx.SetViewRect(0, 0, 0, FrameBufferSize.w, FrameBufferSize.h);
            Bgfx.Touch(0);

            var viewMatrix = Matrix4x4.CreateLookAt(new Vector3(0.0f, 0.0f, -35.0f), Vector3.Zero, Vector3.UnitY);
            var projMatrix = Matrix4x4.CreatePerspectiveFieldOfView((float) Math.PI / 3, (float) FrameBufferSize.w / FrameBufferSize.h, 0.1f, 100.0f);
            Bgfx.SetViewTransform(0, &viewMatrix.M11, &projMatrix.M11);

            Bgfx.DebugTextClear();
            Bgfx.DebugTextWrite(0, 0, DebugColor.Black, DebugColor.LightGreen, "SharpPhysX DebugRenderer");

            Bgfx.Frame();
        }

        Shutdown();
    }

    public void Shutdown()
    {
        shaders_.Dispose();
        Bgfx.Shutdown();
        SDL_DestroyWindow(sdlWindowPtr_);
        SDL_Quit();
    }

    private void UpdateWindowSize()
    {
        SDL_GetWindowSize(sdlWindowPtr_, out int x, out int y);
        FrameBufferSize = (x, y);
        Bgfx.Reset(x, y, ResetFlags.Vsync);
    }
}

class MainEntry
{
    static void Main() => new DebugRenderer().Run();
}