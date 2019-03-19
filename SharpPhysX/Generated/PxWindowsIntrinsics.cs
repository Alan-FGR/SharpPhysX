#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxWindowsIntrinsics {
#endif

//================================================================================
//#       abs                                                                    #
//================================================================================
#if NATIVE //function start
ES float W_abs_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::abs(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_abs_R_float_P_float(float a);

public static float abs(float a){
    float pvk_in_a = (a);
    float retVal = W_abs_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       fsel                                                                   #
//================================================================================
#if NATIVE //function start
ES float W_fsel_R_float_P_float_P_float_P_float(float a, float b, float c){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto nat_in_c = (c);
    auto retVal = physx::intrinsics::fsel(nat_in_a, nat_in_b, nat_in_c);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_fsel_R_float_P_float_P_float_P_float(float a, float b, float c);

public static float fsel(float a, float b, float c){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float pvk_in_c = (c);
    float retVal = W_fsel_R_float_P_float_P_float_P_float(pvk_in_a, pvk_in_b, pvk_in_c);
    return retVal;
}
#endif //function end


//================================================================================
//#       sign                                                                   #
//================================================================================
#if NATIVE //function start
ES float W_sign_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::sign(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_sign_R_float_P_float(float a);

public static float sign(float a){
    float pvk_in_a = (a);
    float retVal = W_sign_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       recip                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_recip_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recip(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recip_R_float_P_float(float a);

public static float recip(float a){
    float pvk_in_a = (a);
    float retVal = W_recip_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       recipFast                                                              #
//================================================================================
#if NATIVE //function start
ES float W_recipFast_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recipFast(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recipFast_R_float_P_float(float a);

public static float recipFast(float a){
    float pvk_in_a = (a);
    float retVal = W_recipFast_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       sqrt                                                                   #
//================================================================================
#if NATIVE //function start
ES float W_sqrt_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::sqrt(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_sqrt_R_float_P_float(float a);

public static float sqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_sqrt_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       recipSqrt                                                              #
//================================================================================
#if NATIVE //function start
ES float W_recipSqrt_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recipSqrt(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recipSqrt_R_float_P_float(float a);

public static float recipSqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_recipSqrt_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       recipSqrtFast                                                          #
//================================================================================
#if NATIVE //function start
ES float W_recipSqrtFast_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::recipSqrtFast(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_recipSqrtFast_R_float_P_float(float a);

public static float recipSqrtFast(float a){
    float pvk_in_a = (a);
    float retVal = W_recipSqrtFast_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       sin                                                                    #
//================================================================================
#if NATIVE //function start
ES float W_sin_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::sin(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_sin_R_float_P_float(float a);

public static float sin(float a){
    float pvk_in_a = (a);
    float retVal = W_sin_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       cos                                                                    #
//================================================================================
#if NATIVE //function start
ES float W_cos_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::cos(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_cos_R_float_P_float(float a);

public static float cos(float a){
    float pvk_in_a = (a);
    float retVal = W_cos_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       selectMin                                                              #
//================================================================================
#if NATIVE //function start
ES float W_selectMin_R_float_P_float_P_float(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::intrinsics::selectMin(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_selectMin_R_float_P_float_P_float(float a, float b);

public static float selectMin(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_selectMin_R_float_P_float_P_float(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end


//================================================================================
//#       selectMax                                                              #
//================================================================================
#if NATIVE //function start
ES float W_selectMax_R_float_P_float_P_float(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::intrinsics::selectMax(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_selectMax_R_float_P_float_P_float(float a, float b);

public static float selectMax(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_selectMax_R_float_P_float_P_float(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end


//================================================================================
//#       isFinite                                                               #
//================================================================================
#if NATIVE //function start
ES bool W_isFinite_R_bool_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::isFinite(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_isFinite_R_bool_P_float(float a);

public static bool isFinite(float a){
    float pvk_in_a = (a);
    bool retVal = W_isFinite_R_bool_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       isFinite                                                               #
//================================================================================
#if NATIVE //function start
ES bool W_isFinite_R_bool_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::intrinsics::isFinite(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_isFinite_R_bool_P_double(double a);

public static bool isFinite(double a){
    double pvk_in_a = (a);
    bool retVal = W_isFinite_R_bool_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       memZero                                                                #
//================================================================================
#if NATIVE //function start
ES void* W_memZero_R_IntPtr_P_IntPtr_P_uint(void* dest, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memZero(nat_in_dest, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memZero_R_IntPtr_P_IntPtr_P_uint(IntPtr dest, uint count);

public static IntPtr memZero(IntPtr dest, uint count){
    IntPtr pvk_in_dest = (dest);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memZero_R_IntPtr_P_IntPtr_P_uint(pvk_in_dest, pvk_in_count);
    return retVal;
}
#endif //function end


//================================================================================
//#       memSet                                                                 #
//================================================================================
#if NATIVE //function start
ES void* W_memSet_R_IntPtr_P_IntPtr_P_int_P_uint(void* dest, ::int32_t c, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_c = (c);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memSet(nat_in_dest, nat_in_c, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memSet_R_IntPtr_P_IntPtr_P_int_P_uint(IntPtr dest, int c, uint count);

public static IntPtr memSet(IntPtr dest, int c, uint count){
    IntPtr pvk_in_dest = (dest);
    int pvk_in_c = (c);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memSet_R_IntPtr_P_IntPtr_P_int_P_uint(pvk_in_dest, pvk_in_c, pvk_in_count);
    return retVal;
}
#endif //function end


//================================================================================
//#       memCopy                                                                #
//================================================================================
#if NATIVE //function start
ES void* W_memCopy_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(void* dest, const void* src, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memCopy(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memCopy_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(IntPtr dest, IntPtr src, uint count);

public static IntPtr memCopy(IntPtr dest, IntPtr src, uint count){
    IntPtr pvk_in_dest = (dest);
    IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memCopy_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif //function end


//================================================================================
//#       memMove                                                                #
//================================================================================
#if NATIVE //function start
ES void* W_memMove_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(void* dest, const void* src, ::uint32_t count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::intrinsics::memMove(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_memMove_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(IntPtr dest, IntPtr src, uint count);

public static IntPtr memMove(IntPtr dest, IntPtr src, uint count){
    IntPtr pvk_in_dest = (dest);
    IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_memMove_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif //function end


//================================================================================
//#       memZero128                                                             #
//================================================================================
#if NATIVE //function start
ES void W_memZero128_R_void_P_IntPtr_P_uint(void* dest, ::uint32_t offset){
    auto nat_in_dest = (dest);
    auto nat_in_offset = (offset);
    physx::intrinsics::memZero128(nat_in_dest, nat_in_offset);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_memZero128_R_void_P_IntPtr_P_uint(IntPtr dest, uint offset);

public static void memZero128(IntPtr dest, uint offset){
    IntPtr pvk_in_dest = (dest);
    uint pvk_in_offset = (offset);
    W_memZero128_R_void_P_IntPtr_P_uint(pvk_in_dest, pvk_in_offset);
}
#endif //function end


// ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
#if NATIVE //function start
ES void W_memZero128_R_void_P_IntPtr_OL1(void* dest){
    auto nat_in_dest = (dest);
    physx::intrinsics::memZero128(nat_in_dest);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_memZero128_R_void_P_IntPtr_OL1(IntPtr dest);

public static void memZero128(IntPtr dest){
    IntPtr pvk_in_dest = (dest);
    W_memZero128_R_void_P_IntPtr_OL1(pvk_in_dest);
}
#endif //function end


#if !NATIVE
} // End PxWindowsIntrinsics
#endif


