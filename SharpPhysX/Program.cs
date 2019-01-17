using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

public static class PhysX {
    public const string Lib = "LibSharpPhysX";
}

//[StructLayout(LayoutKind.Sequential)]
//public struct PxVec3
//{
//    float x;
//    float y;
//    float z;

//    public PxVec3(float x, float y, float z)
//    {
//        this.x = x;
//        this.y = y;
//        this.z = z;
//    }

//    public static PxVec3 operator+(PxVec3 a, PxVec3 b)
//    {
//        return new PxVec3();
//    }

//}

class Program
{
    public delegate void ErrorCallback(
        [MarshalAs(UnmanagedType.LPStr)] string message,
        [MarshalAs(UnmanagedType.LPStr)] string file,
        int line
        );

    //[SuppressUnmanagedCodeSecurity]
    [DllImport("LibSharpPhysX", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void registerCallback(ErrorCallback callback);

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxVec3__magnitude(PxVec3 vec);

    static void Main(string[] args)
    {
        
        //test callback

        var mycb = new ErrorCallback((message, file, line) =>
        {
            Console.WriteLine($"{message} {file} {line}");
        });

        registerCallback(mycb);


        //test blittable

        var v1 = new PxVec3(1,0,1);

        Console.WriteLine(PxVec3__magnitude(v1));



        Console.ReadKey();

    }
}

