//Generated by MinBinder.
using System;
using System.Runtime.InteropServices;
using PxBaseFlags = System.UInt32;
using PxActorFlags = System.UInt32;

public static partial class intrinsics{
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_abs(float a);
    public static float abs(float a){
        return C_abs(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_fsel(float a,float b,float c);
    public static float fsel(float a,float b,float c){
        return C_fsel(a,b,c);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_sign(float a);
    public static float sign(float a){
        return C_sign(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_recip(float a);
    public static float recip(float a){
        return C_recip(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_recipFast(float a);
    public static float recipFast(float a){
        return C_recipFast(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_sqrt(float a);
    public static float sqrt(float a){
        return C_sqrt(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_recipSqrt(float a);
    public static float recipSqrt(float a){
        return C_recipSqrt(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_recipSqrtFast(float a);
    public static float recipSqrtFast(float a){
        return C_recipSqrtFast(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_sin(float a);
    public static float sin(float a){
        return C_sin(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_cos(float a);
    public static float cos(float a){
        return C_cos(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_selectMin(float a,float b);
    public static float selectMin(float a,float b){
        return C_selectMin(a,b);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_selectMax(float a,float b);
    public static float selectMax(float a,float b){
        return C_selectMax(a,b);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool C_isFinite(float a);
    public static bool isFinite(float a){
        return C_isFinite(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool C_isFinite_2(double a);
    public static bool isFinite(double a){
        return C_isFinite_2(a);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_memZero(void dest,uint count);
    public static void memZero(void dest,uint count){
         C_memZero(dest,count);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_memSet(void dest,int c,uint count);
    public static void memSet(void dest,int c,uint count){
         C_memSet(dest,c,count);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_memCopy(void dest,void src,uint count);
    public static void memCopy(void dest,void src,uint count){
         C_memCopy(dest,src,count);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_memMove(void dest,void src,uint count);
    public static void memMove(void dest,void src,uint count){
         C_memMove(dest,src,count);    
    }


    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_memZero128(void dest,uint offset);
    public static void memZero128(void dest,uint offset){
         C_memZero128(dest,offset);    
    }


}

