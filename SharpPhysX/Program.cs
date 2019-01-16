using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

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

    static void Main(string[] args)
    {
        
        var mycb = new ErrorCallback((message, file, line) =>
        {
            Console.WriteLine($"{message} {file} {line}");
        });

        registerCallback(mycb);

        Console.ReadKey();

    }
}

