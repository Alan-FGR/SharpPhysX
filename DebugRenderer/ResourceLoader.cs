using SharpBgfx;
using System;
using System.IO;
using System.Reflection;

namespace Common
{
    public static class ResourceLoader
    {
        static readonly string ExePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        static string GetShaderPath()
        {
            switch (Bgfx.GetCurrentBackend())
            {
                case RendererBackend.Direct3D11:
                case RendererBackend.Direct3D12:
                    return Path.Combine(ExePath, "bin", "dx11");

                case RendererBackend.OpenGL:
                    return Path.Combine(ExePath, "bin", "glsl");

                default:
                    throw new InvalidOperationException("Unsupported renderer backend.");
            }
        }

        public static Shader LoadShader(string name)
        {
            var path = Path.Combine(GetShaderPath(), name) + ".bin";
            var mem = MemoryBlock.FromArray(File.ReadAllBytes(path));
            return new Shader(mem);
        }

        public static Program LoadProgram(string vsName, string fsName)
        {
            var vsh = LoadShader(vsName);
            var fsh = LoadShader(fsName);

            return new Program(vsh, fsh, true);
        }
    }
}