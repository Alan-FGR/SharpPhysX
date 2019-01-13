using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("LibSharpPhysX", CallingConvention = CallingConvention.Cdecl)]
    static extern int add(int x, int y);

    static void Main(string[] args)
    {
        var sw = Stopwatch.StartNew();

        var count = 100000000;
        var z = 0;

        for (int i = 0; i < count; i++)
            z = add(z, 1);

        var time = sw.Elapsed.TotalMilliseconds;
        var perCall = time / count;

        Console.WriteLine($"elapsed ms: {time:F4}, per call µs: {perCall*1000:F4}, val: {z}");

        Console.ReadKey();

    }
}

