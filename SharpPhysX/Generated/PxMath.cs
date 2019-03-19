#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxMath {
#endif

//================================================================================
//#       PxMax                                                                  #
//================================================================================
/* ERRORS OCCURED: unhandled return type: T
Unresolved parameter type T
Unresolved parameter type T
// NATIVE SIG: T PxMax(T a, T b)
{
	return a < b ? b : a;
}
#if NATIVE //function start
ES UNPARSED_TYPE W_PxMax_R_T_P__P_( a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMax(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxMax_R_T_P__P_( a,  b);

public static UNPARSED_TYPE PxMax( a,  b){
     pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_PxMax_R_T_P__P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       PxMax                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxMax_R_float_P_float_P_float(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMax(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxMax_R_float_P_float_P_float(float a, float b);

public static float PxMax(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_PxMax_R_float_P_float_P_float(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxMin                                                                  #
//================================================================================
/* ERRORS OCCURED: unhandled return type: T
Unresolved parameter type T
Unresolved parameter type T
// NATIVE SIG: T PxMin(T a, T b)
{
	return a < b ? a : b;
}
#if NATIVE //function start
ES UNPARSED_TYPE W_PxMin_R_T_P__P_( a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMin(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxMin_R_T_P__P_( a,  b);

public static UNPARSED_TYPE PxMin( a,  b){
     pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_PxMin_R_T_P__P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       PxMin                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxMin_R_float_P_float_P_float(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMin(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxMin_R_float_P_float_P_float(float a, float b);

public static float PxMin(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_PxMin_R_float_P_float_P_float(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAbs                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxAbs_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAbs(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAbs_R_float_P_float(float a);

public static float PxAbs(float a){
    float pvk_in_a = (a);
    float retVal = W_PxAbs_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxEquals                                                               #
//================================================================================
#if NATIVE //function start
ES bool W_PxEquals_R_bool_P_float_P_float_P_float(float a, float b, float eps){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto nat_in_eps = (eps);
    auto retVal = physx::PxEquals(nat_in_a, nat_in_b, nat_in_eps);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxEquals_R_bool_P_float_P_float_P_float(float a, float b, float eps);

public static bool PxEquals(float a, float b, float eps){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float pvk_in_eps = (eps);
    bool retVal = W_PxEquals_R_bool_P_float_P_float_P_float(pvk_in_a, pvk_in_b, pvk_in_eps);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAbs                                                                  #
//================================================================================
#if NATIVE //function start
ES double W_PxAbs_R_double_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAbs(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAbs_R_double_P_double(double a);

public static double PxAbs(double a){
    double pvk_in_a = (a);
    double retVal = W_PxAbs_R_double_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAbs                                                                  #
//================================================================================
#if NATIVE //function start
ES ::int32_t W_PxAbs_R_int_P_int(::int32_t a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAbs(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern int W_PxAbs_R_int_P_int(int a);

public static int PxAbs(int a){
    int pvk_in_a = (a);
    int retVal = W_PxAbs_R_int_P_int(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxClamp                                                                #
//================================================================================
/* ERRORS OCCURED: unhandled return type: T
Unresolved parameter type T
Unresolved parameter type T
Unresolved parameter type T
// NATIVE SIG: T PxClamp(T v, T lo, T hi)
{
	PX_ASSERT(lo <= hi);
	return PxMin(hi, PxMax(lo, v));
}
#if NATIVE //function start
ES UNPARSED_TYPE W_PxClamp_R_T_P__P__P_( v,  lo,  hi){
    auto nat_in_v = (v);
    auto nat_in_lo = (lo);
    auto nat_in_hi = (hi);
    auto retVal = physx::PxClamp(nat_in_v, nat_in_lo, nat_in_hi);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxClamp_R_T_P__P__P_( v,  lo,  hi);

public static UNPARSED_TYPE PxClamp( v,  lo,  hi){
     pvk_in_v = (v);
     pvk_in_lo = (lo);
     pvk_in_hi = (hi);
    UNPARSED_TYPE retVal = W_PxClamp_R_T_P__P__P_(pvk_in_v, pvk_in_lo, pvk_in_hi);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       PxSqrt                                                                 #
//================================================================================
#if NATIVE //function start
ES float W_PxSqrt_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSqrt(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxSqrt_R_float_P_float(float a);

public static float PxSqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_PxSqrt_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxSqrt                                                                 #
//================================================================================
#if NATIVE //function start
ES double W_PxSqrt_R_double_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSqrt(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxSqrt_R_double_P_double(double a);

public static double PxSqrt(double a){
    double pvk_in_a = (a);
    double retVal = W_PxSqrt_R_double_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxRecipSqrt                                                            #
//================================================================================
#if NATIVE //function start
ES float W_PxRecipSqrt_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxRecipSqrt(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxRecipSqrt_R_float_P_float(float a);

public static float PxRecipSqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_PxRecipSqrt_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxRecipSqrt                                                            #
//================================================================================
#if NATIVE //function start
ES double W_PxRecipSqrt_R_double_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxRecipSqrt(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxRecipSqrt_R_double_P_double(double a);

public static double PxRecipSqrt(double a){
    double pvk_in_a = (a);
    double retVal = W_PxRecipSqrt_R_double_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxSin                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxSin_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSin(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxSin_R_float_P_float(float a);

public static float PxSin(float a){
    float pvk_in_a = (a);
    float retVal = W_PxSin_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxSin                                                                  #
//================================================================================
#if NATIVE //function start
ES double W_PxSin_R_double_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSin(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxSin_R_double_P_double(double a);

public static double PxSin(double a){
    double pvk_in_a = (a);
    double retVal = W_PxSin_R_double_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxCos                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxCos_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxCos(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxCos_R_float_P_float(float a);

public static float PxCos(float a){
    float pvk_in_a = (a);
    float retVal = W_PxCos_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxCos                                                                  #
//================================================================================
#if NATIVE //function start
ES double W_PxCos_R_double_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxCos(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxCos_R_double_P_double(double a);

public static double PxCos(double a){
    double pvk_in_a = (a);
    double retVal = W_PxCos_R_double_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxTan                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxTan_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxTan(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxTan_R_float_P_float(float a);

public static float PxTan(float a){
    float pvk_in_a = (a);
    float retVal = W_PxTan_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxTan                                                                  #
//================================================================================
#if NATIVE //function start
ES double W_PxTan_R_double_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxTan(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxTan_R_double_P_double(double a);

public static double PxTan(double a){
    double pvk_in_a = (a);
    double retVal = W_PxTan_R_double_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAsin                                                                 #
//================================================================================
#if NATIVE //function start
ES float W_PxAsin_R_float_P_float(float f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAsin(nat_in_f);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAsin_R_float_P_float(float f);

public static float PxAsin(float f){
    float pvk_in_f = (f);
    float retVal = W_PxAsin_R_float_P_float(pvk_in_f);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAsin                                                                 #
//================================================================================
#if NATIVE //function start
ES double W_PxAsin_R_double_P_double(double f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAsin(nat_in_f);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAsin_R_double_P_double(double f);

public static double PxAsin(double f){
    double pvk_in_f = (f);
    double retVal = W_PxAsin_R_double_P_double(pvk_in_f);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAcos                                                                 #
//================================================================================
#if NATIVE //function start
ES float W_PxAcos_R_float_P_float(float f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAcos(nat_in_f);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAcos_R_float_P_float(float f);

public static float PxAcos(float f){
    float pvk_in_f = (f);
    float retVal = W_PxAcos_R_float_P_float(pvk_in_f);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAcos                                                                 #
//================================================================================
#if NATIVE //function start
ES double W_PxAcos_R_double_P_double(double f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAcos(nat_in_f);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAcos_R_double_P_double(double f);

public static double PxAcos(double f){
    double pvk_in_f = (f);
    double retVal = W_PxAcos_R_double_P_double(pvk_in_f);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAtan                                                                 #
//================================================================================
#if NATIVE //function start
ES float W_PxAtan_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAtan(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAtan_R_float_P_float(float a);

public static float PxAtan(float a){
    float pvk_in_a = (a);
    float retVal = W_PxAtan_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAtan                                                                 #
//================================================================================
#if NATIVE //function start
ES double W_PxAtan_R_double_P_double(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAtan(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAtan_R_double_P_double(double a);

public static double PxAtan(double a){
    double pvk_in_a = (a);
    double retVal = W_PxAtan_R_double_P_double(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAtan2                                                                #
//================================================================================
#if NATIVE //function start
ES float W_PxAtan2_R_float_P_float_P_float(float x, float y){
    auto nat_in_x = (x);
    auto nat_in_y = (y);
    auto retVal = physx::PxAtan2(nat_in_x, nat_in_y);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAtan2_R_float_P_float_P_float(float x, float y);

public static float PxAtan2(float x, float y){
    float pvk_in_x = (x);
    float pvk_in_y = (y);
    float retVal = W_PxAtan2_R_float_P_float_P_float(pvk_in_x, pvk_in_y);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxAtan2                                                                #
//================================================================================
#if NATIVE //function start
ES double W_PxAtan2_R_double_P_double_P_double(double x, double y){
    auto nat_in_x = (x);
    auto nat_in_y = (y);
    auto retVal = physx::PxAtan2(nat_in_x, nat_in_y);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAtan2_R_double_P_double_P_double(double x, double y);

public static double PxAtan2(double x, double y){
    double pvk_in_x = (x);
    double pvk_in_y = (y);
    double retVal = W_PxAtan2_R_double_P_double_P_double(pvk_in_x, pvk_in_y);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxIsFinite                                                             #
//================================================================================
#if NATIVE //function start
ES bool W_PxIsFinite_R_bool_P_float(float f){
    auto nat_in_f = (f);
    auto retVal = physx::PxIsFinite(nat_in_f);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxIsFinite_R_bool_P_float(float f);

public static bool PxIsFinite(float f){
    float pvk_in_f = (f);
    bool retVal = W_PxIsFinite_R_bool_P_float(pvk_in_f);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxIsFinite                                                             #
//================================================================================
#if NATIVE //function start
ES bool W_PxIsFinite_R_bool_P_double(double f){
    auto nat_in_f = (f);
    auto retVal = physx::PxIsFinite(nat_in_f);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxIsFinite_R_bool_P_double(double f);

public static bool PxIsFinite(double f){
    double pvk_in_f = (f);
    bool retVal = W_PxIsFinite_R_bool_P_double(pvk_in_f);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxFloor                                                                #
//================================================================================
#if NATIVE //function start
ES float W_PxFloor_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxFloor(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxFloor_R_float_P_float(float a);

public static float PxFloor(float a){
    float pvk_in_a = (a);
    float retVal = W_PxFloor_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxExp                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxExp_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxExp(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxExp_R_float_P_float(float a);

public static float PxExp(float a){
    float pvk_in_a = (a);
    float retVal = W_PxExp_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxCeil                                                                 #
//================================================================================
#if NATIVE //function start
ES float W_PxCeil_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxCeil(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxCeil_R_float_P_float(float a);

public static float PxCeil(float a){
    float pvk_in_a = (a);
    float retVal = W_PxCeil_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxSign                                                                 #
//================================================================================
#if NATIVE //function start
ES float W_PxSign_R_float_P_float(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSign(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxSign_R_float_P_float(float a);

public static float PxSign(float a){
    float pvk_in_a = (a);
    float retVal = W_PxSign_R_float_P_float(pvk_in_a);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxPow                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxPow_R_float_P_float_P_float(float x, float y){
    auto nat_in_x = (x);
    auto nat_in_y = (y);
    auto retVal = physx::PxPow(nat_in_x, nat_in_y);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxPow_R_float_P_float_P_float(float x, float y);

public static float PxPow(float x, float y){
    float pvk_in_x = (x);
    float pvk_in_y = (y);
    float retVal = W_PxPow_R_float_P_float_P_float(pvk_in_x, pvk_in_y);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxLog                                                                  #
//================================================================================
#if NATIVE //function start
ES float W_PxLog_R_float_P_float(float x){
    auto nat_in_x = (x);
    auto retVal = physx::PxLog(nat_in_x);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxLog_R_float_P_float(float x);

public static float PxLog(float x){
    float pvk_in_x = (x);
    float retVal = W_PxLog_R_float_P_float(pvk_in_x);
    return retVal;
}
#endif //function end

#if !NATIVE
} // End PxMath
#endif


