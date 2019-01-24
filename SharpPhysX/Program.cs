using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

[StructLayout(LayoutKind.Sequential)]
public struct PxVec3t
{
    public float x;
    float y;
    float z;

    public PxVec3t(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public unsafe PxVec3t(PxVec3t toCopy) : this()
    {
        fixed (void* ptr = &this) {
            Buffer.MemoryCopy(&toCopy, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
        }
    }
}

interface IGeom
{
    void test(Box b);
}

interface IConfl
{
    void test(Box b);
}

struct Geom : IGeom, IConfl, IDisposable
{
    private IntPtr nativePtr_;

    public Geom(IntPtr nativePtr)
    {
        nativePtr_ = nativePtr;
    }

    public void Dispose()
    {}

    public void test(Box b)
    {
    }
}

struct Box : IDisposable
{
    private IntPtr nativePtr_;
    public int hikerData;

    public Box(IntPtr nativePtr)
    {
        this.nativePtr_ = nativePtr;
        hikerData = 666;
    }

    public static unsafe implicit operator Geom(Box obj) // upcast
    {
        return *(Geom*)&obj;
    }

    public static unsafe explicit operator Box(Geom obj) // downcast
    {
        return *(Box*)&obj;
    }

    public void Dispose()
    {}
}

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


    static unsafe void Main(string[] args)
    {
        
        //test callback

        var mycb = new ErrorCallback((message, file, line) =>
        {
            Console.WriteLine($"{message} {file} {line}");
        });

        registerCallback(mycb);


        //test blittable

        var v1 = new PxVec3t(1337,0,float.MinValue);
        var v2 = new PxVec3t(v1);

        Console.WriteLine(v2.x);

        //test castings

        Geom g = new Geom(new IntPtr(1337));
        Box b = new Box(new IntPtr(42));

        var up = (Geom) b;
        var down = (Box) g;

        var addrg = &g;
        var addrb = &b;
        var addrup = &up;
        var addrdown = &down;

        //test auto blittable

        var vec = new PxVec3(1,2,3);

        var sum = vec + vec;

        Console.ReadKey();

    }
}

