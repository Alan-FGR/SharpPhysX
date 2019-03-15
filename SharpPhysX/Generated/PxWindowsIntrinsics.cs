#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxWindowsIntrinsics {

//================================================================================
//#       abs                                                                    #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L51~54
#if NATIVE
ES float W_abs(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::abs(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_abs(float a);

public static float abs(float a){
    float pvk_in_a = (a);
    float retVal = W_abs(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       fsel                                                                   #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L57~60
#if NATIVE
ES float W_fsel(float a, float b, float c){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto nat_in_c = (c);
    auto retVal = physx::intrinsics::fsel(nat_in_a, nat_in_b, nat_in_c);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_fsel(float a, float b, float c);

public static float fsel(float a, float b, float c){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float pvk_in_c = (c);
    float retVal = W_fsel(pvk_in_a, pvk_in_b, pvk_in_c);
    return retVal;
}
#endif


//================================================================================
//#       sign                                                                   #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L63~66
#if NATIVE
ES float W_sign(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::sign(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_sign(float a);

public static float sign(float a){
    float pvk_in_a = (a);
    float retVal = W_sign(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       recip                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L69~72
#if NATIVE
ES float W_recip(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recip(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recip(float a);

public static float recip(float a){
    float pvk_in_a = (a);
    float retVal = W_recip(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       recipFast                                                              #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L75~78
#if NATIVE
ES float W_recipFast(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recipFast(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recipFast(float a);

public static float recipFast(float a){
    float pvk_in_a = (a);
    float retVal = W_recipFast(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       sqrt                                                                   #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L81~84
#if NATIVE
ES float W_sqrt(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::sqrt(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_sqrt(float a);

public static float sqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_sqrt(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       recipSqrt                                                              #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L87~90
#if NATIVE
ES float W_recipSqrt(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recipSqrt(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recipSqrt(float a);

public static float recipSqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_recipSqrt(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       recipSqrtFast                                                          #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L93~96
#if NATIVE
ES float W_recipSqrtFast(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recipSqrtFast(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recipSqrtFast(float a);

public static float recipSqrtFast(float a){
    float pvk_in_a = (a);
    float retVal = W_recipSqrtFast(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       sin                                                                    #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L99~102
#if NATIVE
ES float W_sin(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::sin(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_sin(float a);

public static float sin(float a){
    float pvk_in_a = (a);
    float retVal = W_sin(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       cos                                                                    #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L105~108
#if NATIVE
ES float W_cos(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::cos(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_cos(float a);

public static float cos(float a){
    float pvk_in_a = (a);
    float retVal = W_cos(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       selectMin                                                              #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L111~114
#if NATIVE
ES float W_selectMin(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::intrinsics::selectMin(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_selectMin(float a, float b);

public static float selectMin(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_selectMin(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif


//================================================================================
//#       selectMax                                                              #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L117~120
#if NATIVE
ES float W_selectMax(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::intrinsics::selectMax(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_selectMax(float a, float b);

public static float selectMax(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_selectMax(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif


//================================================================================
//#       isFinite                                                               #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L123~130
#if NATIVE
ES bool W_isFinite(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::isFinite(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_isFinite(float a);

public static bool isFinite(float a){
    float pvk_in_a = (a);
    bool retVal = W_isFinite(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       isFinite                                                               #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L133~140
#if NATIVE
ES bool W_isFinite(double a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::isFinite(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_isFinite(double a);

public static bool isFinite(double a){
    double pvk_in_a = (a);
    bool retVal = W_isFinite(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       memZero                                                                #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L145~148
#if NATIVE
ES void* W_memZero(void* dest, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memZero(nat_in_dest, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memZero(global::System.IntPtr dest, uint count);

public static IntPtr memZero(global::System.IntPtr dest, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memZero(pvk_in_dest, pvk_in_count);
    return retVal;
}
#endif


//================================================================================
//#       memSet                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L153~156
#if NATIVE
ES void* W_memSet(void* dest, ::int32_t c, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_c = (c);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memSet(nat_in_dest, nat_in_c, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memSet(global::System.IntPtr dest, int c, uint count);

public static IntPtr memSet(global::System.IntPtr dest, int c, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    int pvk_in_c = (c);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memSet(pvk_in_dest, pvk_in_c, pvk_in_count);
    return retVal;
}
#endif


//================================================================================
//#       memCopy                                                                #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L161~164
#if NATIVE
ES void* W_memCopy(void* dest, const void* src, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memCopy(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memCopy(global::System.IntPtr dest, global::System.IntPtr src, uint count);

public static IntPtr memCopy(global::System.IntPtr dest, global::System.IntPtr src, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    global::System.IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memCopy(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif


//================================================================================
//#       memMove                                                                #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L169~172
#if NATIVE
ES void* W_memMove(void* dest, const void* src, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memMove(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memMove(global::System.IntPtr dest, global::System.IntPtr src, uint count);

public static IntPtr memMove(global::System.IntPtr dest, global::System.IntPtr src, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    global::System.IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memMove(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif


//================================================================================
//#       memZero128                                                             #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\windows\PxWindowsIntrinsics.h L177~181
#if NATIVE
ES void W_memZero128(void* dest, ::uint32_t offset){
    auto nat_in_dest = (dest);
    auto nat_in_offset = (offset);
    physx::intrinsics::memZero128(nat_in_dest, nat_in_offset);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_memZero128(global::System.IntPtr dest, uint offset);

public static void memZero128(global::System.IntPtr dest, uint offset){
    global::System.IntPtr pvk_in_dest = (dest);
    uint pvk_in_offset = (offset);
    W_memZero128(pvk_in_dest, pvk_in_offset);
}
#endif

} // End PxWindowsIntrinsics

