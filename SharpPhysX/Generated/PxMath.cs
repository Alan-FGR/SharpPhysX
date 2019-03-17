#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


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
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L70~73
#if NATIVE
ES UNPARSED_TYPE W_PxMax( a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMax(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxMax( a,  b);

public static UNPARSED_TYPE PxMax( a,  b){
     pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_PxMax(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       PxMax                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L76~80
#if NATIVE
ES float W_PxMax(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMax(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxMax(float a, float b);

public static float PxMax(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_PxMax(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif


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
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L86~89
#if NATIVE
ES UNPARSED_TYPE W_PxMin( a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMin(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxMin( a,  b);

public static UNPARSED_TYPE PxMin( a,  b){
     pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_PxMin(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       PxMin                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L91~96
#if NATIVE
ES float W_PxMin(float a, float b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::PxMin(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxMin(float a, float b);

public static float PxMin(float a, float b){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float retVal = W_PxMin(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif


//================================================================================
//#       PxAbs                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L107~110
#if NATIVE
ES float W_PxAbs(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAbs(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAbs(float a);

public static float PxAbs(float a){
    float pvk_in_a = (a);
    float retVal = W_PxAbs(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxEquals                                                               #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L112~115
#if NATIVE
ES bool W_PxEquals(float a, float b, float eps){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto nat_in_eps = (eps);
    auto retVal = physx::PxEquals(nat_in_a, nat_in_b, nat_in_eps);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxEquals(float a, float b, float eps);

public static bool PxEquals(float a, float b, float eps){
    float pvk_in_a = (a);
    float pvk_in_b = (b);
    float pvk_in_eps = (eps);
    bool retVal = W_PxEquals(pvk_in_a, pvk_in_b, pvk_in_eps);
    return retVal;
}
#endif


//================================================================================
//#       PxAbs                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L120~123
#if NATIVE
ES double W_PxAbs(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAbs(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAbs(double a);

public static double PxAbs(double a){
    double pvk_in_a = (a);
    double retVal = W_PxAbs(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxAbs                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L128~131
#if NATIVE
ES ::int32_t W_PxAbs(::int32_t a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAbs(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern int W_PxAbs(int a);

public static int PxAbs(int a){
    int pvk_in_a = (a);
    int retVal = W_PxAbs(pvk_in_a);
    return retVal;
}
#endif


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
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L137~141
#if NATIVE
ES UNPARSED_TYPE W_PxClamp( v,  lo,  hi){
    auto nat_in_v = (v);
    auto nat_in_lo = (lo);
    auto nat_in_hi = (hi);
    auto retVal = physx::PxClamp(nat_in_v, nat_in_lo, nat_in_hi);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxClamp( v,  lo,  hi);

public static UNPARSED_TYPE PxClamp( v,  lo,  hi){
     pvk_in_v = (v);
     pvk_in_lo = (lo);
     pvk_in_hi = (hi);
    UNPARSED_TYPE retVal = W_PxClamp(pvk_in_v, pvk_in_lo, pvk_in_hi);
    return retVal;
}
#endif*/


//================================================================================
//#       PxSqrt                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L144~147
#if NATIVE
ES float W_PxSqrt(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSqrt(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxSqrt(float a);

public static float PxSqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_PxSqrt(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxSqrt                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L150~153
#if NATIVE
ES double W_PxSqrt(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSqrt(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxSqrt(double a);

public static double PxSqrt(double a){
    double pvk_in_a = (a);
    double retVal = W_PxSqrt(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxRecipSqrt                                                            #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L156~159
#if NATIVE
ES float W_PxRecipSqrt(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxRecipSqrt(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxRecipSqrt(float a);

public static float PxRecipSqrt(float a){
    float pvk_in_a = (a);
    float retVal = W_PxRecipSqrt(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxRecipSqrt                                                            #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L162~165
#if NATIVE
ES double W_PxRecipSqrt(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxRecipSqrt(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxRecipSqrt(double a);

public static double PxRecipSqrt(double a){
    double pvk_in_a = (a);
    double retVal = W_PxRecipSqrt(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxSin                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L170~173
#if NATIVE
ES float W_PxSin(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSin(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxSin(float a);

public static float PxSin(float a){
    float pvk_in_a = (a);
    float retVal = W_PxSin(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxSin                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L176~179
#if NATIVE
ES double W_PxSin(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSin(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxSin(double a);

public static double PxSin(double a){
    double pvk_in_a = (a);
    double retVal = W_PxSin(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxCos                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L182~185
#if NATIVE
ES float W_PxCos(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxCos(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxCos(float a);

public static float PxCos(float a){
    float pvk_in_a = (a);
    float retVal = W_PxCos(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxCos                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L188~191
#if NATIVE
ES double W_PxCos(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxCos(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxCos(double a);

public static double PxCos(double a){
    double pvk_in_a = (a);
    double retVal = W_PxCos(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxTan                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L197~200
#if NATIVE
ES float W_PxTan(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxTan(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxTan(float a);

public static float PxTan(float a){
    float pvk_in_a = (a);
    float retVal = W_PxTan(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxTan                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L206~209
#if NATIVE
ES double W_PxTan(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxTan(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxTan(double a);

public static double PxTan(double a){
    double pvk_in_a = (a);
    double retVal = W_PxTan(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxAsin                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L216~219
#if NATIVE
ES float W_PxAsin(float f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAsin(nat_in_f);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAsin(float f);

public static float PxAsin(float f){
    float pvk_in_f = (f);
    float retVal = W_PxAsin(pvk_in_f);
    return retVal;
}
#endif


//================================================================================
//#       PxAsin                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L226~229
#if NATIVE
ES double W_PxAsin(double f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAsin(nat_in_f);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAsin(double f);

public static double PxAsin(double f){
    double pvk_in_f = (f);
    double retVal = W_PxAsin(pvk_in_f);
    return retVal;
}
#endif


//================================================================================
//#       PxAcos                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L236~239
#if NATIVE
ES float W_PxAcos(float f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAcos(nat_in_f);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAcos(float f);

public static float PxAcos(float f){
    float pvk_in_f = (f);
    float retVal = W_PxAcos(pvk_in_f);
    return retVal;
}
#endif


//================================================================================
//#       PxAcos                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L246~249
#if NATIVE
ES double W_PxAcos(double f){
    auto nat_in_f = (f);
    auto retVal = physx::PxAcos(nat_in_f);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAcos(double f);

public static double PxAcos(double f){
    double pvk_in_f = (f);
    double retVal = W_PxAcos(pvk_in_f);
    return retVal;
}
#endif


//================================================================================
//#       PxAtan                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L256~259
#if NATIVE
ES float W_PxAtan(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAtan(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAtan(float a);

public static float PxAtan(float a){
    float pvk_in_a = (a);
    float retVal = W_PxAtan(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxAtan                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L266~269
#if NATIVE
ES double W_PxAtan(double a){
    auto nat_in_a = (a);
    auto retVal = physx::PxAtan(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAtan(double a);

public static double PxAtan(double a){
    double pvk_in_a = (a);
    double retVal = W_PxAtan(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxAtan2                                                                #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L276~279
#if NATIVE
ES float W_PxAtan2(float x, float y){
    auto nat_in_x = (x);
    auto nat_in_y = (y);
    auto retVal = physx::PxAtan2(nat_in_x, nat_in_y);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxAtan2(float x, float y);

public static float PxAtan2(float x, float y){
    float pvk_in_x = (x);
    float pvk_in_y = (y);
    float retVal = W_PxAtan2(pvk_in_x, pvk_in_y);
    return retVal;
}
#endif


//================================================================================
//#       PxAtan2                                                                #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L286~289
#if NATIVE
ES double W_PxAtan2(double x, double y){
    auto nat_in_x = (x);
    auto nat_in_y = (y);
    auto retVal = physx::PxAtan2(nat_in_x, nat_in_y);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern double W_PxAtan2(double x, double y);

public static double PxAtan2(double x, double y){
    double pvk_in_x = (x);
    double pvk_in_y = (y);
    double retVal = W_PxAtan2(pvk_in_x, pvk_in_y);
    return retVal;
}
#endif


//================================================================================
//#       PxIsFinite                                                             #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L292~295
#if NATIVE
ES bool W_PxIsFinite(float f){
    auto nat_in_f = (f);
    auto retVal = physx::PxIsFinite(nat_in_f);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxIsFinite(float f);

public static bool PxIsFinite(float f){
    float pvk_in_f = (f);
    bool retVal = W_PxIsFinite(pvk_in_f);
    return retVal;
}
#endif


//================================================================================
//#       PxIsFinite                                                             #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L298~301
#if NATIVE
ES bool W_PxIsFinite(double f){
    auto nat_in_f = (f);
    auto retVal = physx::PxIsFinite(nat_in_f);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxIsFinite(double f);

public static bool PxIsFinite(double f){
    double pvk_in_f = (f);
    bool retVal = W_PxIsFinite(pvk_in_f);
    return retVal;
}
#endif


//================================================================================
//#       PxFloor                                                                #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L303~306
#if NATIVE
ES float W_PxFloor(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxFloor(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxFloor(float a);

public static float PxFloor(float a){
    float pvk_in_a = (a);
    float retVal = W_PxFloor(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxExp                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L308~311
#if NATIVE
ES float W_PxExp(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxExp(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxExp(float a);

public static float PxExp(float a){
    float pvk_in_a = (a);
    float retVal = W_PxExp(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxCeil                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L313~316
#if NATIVE
ES float W_PxCeil(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxCeil(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxCeil(float a);

public static float PxCeil(float a){
    float pvk_in_a = (a);
    float retVal = W_PxCeil(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxSign                                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L318~321
#if NATIVE
ES float W_PxSign(float a){
    auto nat_in_a = (a);
    auto retVal = physx::PxSign(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxSign(float a);

public static float PxSign(float a){
    float pvk_in_a = (a);
    float retVal = W_PxSign(pvk_in_a);
    return retVal;
}
#endif


//================================================================================
//#       PxPow                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L323~326
#if NATIVE
ES float W_PxPow(float x, float y){
    auto nat_in_x = (x);
    auto nat_in_y = (y);
    auto retVal = physx::PxPow(nat_in_x, nat_in_y);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxPow(float x, float y);

public static float PxPow(float x, float y){
    float pvk_in_x = (x);
    float pvk_in_y = (y);
    float retVal = W_PxPow(pvk_in_x, pvk_in_y);
    return retVal;
}
#endif


//================================================================================
//#       PxLog                                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMath.h L328~331
#if NATIVE
ES float W_PxLog(float x){
    auto nat_in_x = (x);
    auto retVal = physx::PxLog(nat_in_x);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern float W_PxLog(float x);

public static float PxLog(float x){
    float pvk_in_x = (x);
    float retVal = W_PxLog(pvk_in_x);
    return retVal;
}
#endif

#if !NATIVE
} // End PxMath
#endif


