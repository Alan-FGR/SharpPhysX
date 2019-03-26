#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxQuat {
    ///*No paramless ctor in C#*/ static PxQuat Default();
    // PxQuat(PxIDENTITY r);
    // PxQuat(float r);
    // PxQuat(float nx, float ny, float nz, float nw);
    // PxQuat(float angleRadians, PxVec3 unitAxis);
    // PxQuat(PxQuat v);
    // PxQuat(PxMat33 m);
     bool isIdentity();
     bool isFinite();
     bool isUnit();
     bool isSane();
    //static bool operator==(PxQuat lhs, PxQuat q);
    // void toRadiansAndUnitAxis(float* angle,  axis);
     float getAngle();
     float getAngle(PxQuat q);
     float magnitudeSquared();
     float dot(PxQuat v);
     PxQuat getNormalized();
     float magnitude();
     float normalize();
     PxQuat getConjugate();
     PxVec3 getImaginaryPart();
     PxVec3 getBasisVector0();
     PxVec3 getBasisVector1();
     PxVec3 getBasisVector2();
     PxVec3 rotate(PxVec3 v);
     PxVec3 rotateInv(PxVec3 v);
    //static PxQuat operator=(PxQuat lhs, /*NULLPARS*/);
    //static PxQuat operator*=(PxQuat lhs, /*NULLPARS*/);
    //static PxQuat operator+=(PxQuat lhs, /*NULLPARS*/);
    //static PxQuat operator-=(PxQuat lhs, /*NULLPARS*/);
    //static PxQuat operator*=(PxQuat lhs, /*NULLPARS*/);
    //static PxQuat operator*(PxQuat lhs, PxQuat q);
    //static PxQuat operator+(PxQuat lhs, PxQuat q);
    //static PxQuat operator-(PxQuat lhs);
    //static PxQuat operator-(PxQuat lhs, PxQuat q);
    //static PxQuat operator*(PxQuat lhs, float r);
    // UNPARSED_TYPE ~PxQuat(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxQuat : IPxQuat { // blittable
    public float x;
    public float y;
    public float z;
    public float w;

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxQuatPOD{
    float x;
    float y;
    float z;
    float w;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxQuat
    #endif //hierarchy
    //================================================================================
    //#       PxQuat()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_PxQuat_R_PxQuat_C_PxQuat_ctor(){
        auto val = PxQuat();
        return *(PxQuatPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_R_PxQuat_C_PxQuat_ctor();
    
    public /*No paramless ctor in C#*/ static PxQuat Default(){
        return (W_PxQuat_R_PxQuat_C_PxQuat_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxQuat(physx r)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_PxQuat_R_PxQuat_P_PxIDENTITY_C_PxQuat_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        auto val = PxQuat();
        return *(PxQuatPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_R_PxQuat_P_PxIDENTITY_C_PxQuat_ctor(PxIDENTITY r);
    
    public  PxQuat(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = (W_PxQuat_R_PxQuat_P_PxIDENTITY_C_PxQuat_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxQuat(float r)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_PxQuat_R_PxQuat_P_float_C_PxQuat_ctor(float r){
        auto nat_in_r = (r);
        auto val = PxQuat();
        return *(PxQuatPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_R_PxQuat_P_float_C_PxQuat_ctor(float r);
    
    public  PxQuat(float r){
        float pvk_in_r = (r);
        var _new = (W_PxQuat_R_PxQuat_P_float_C_PxQuat_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxQuat(float nx, float ny, float nz, float nw)                         #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_PxQuat_R_PxQuat_P_float_P_float_P_float_P_float_C_PxQuat_ctor(float nx, float ny, float nz, float nw){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        auto nat_in_nw = (nw);
        auto val = PxQuat();
        return *(PxQuatPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_R_PxQuat_P_float_P_float_P_float_P_float_C_PxQuat_ctor(float nx, float ny, float nz, float nw);
    
    public  PxQuat(float nx, float ny, float nz, float nw){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_nw = (nw);
        var _new = (W_PxQuat_R_PxQuat_P_float_P_float_P_float_P_float_C_PxQuat_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_nw));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxQuat(float angleRadians, PxVec3Ptr unitAxis)                         #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_PxQuat_R_PxQuat_P_float_P_PxVec3_C_PxQuat_ctor(float angleRadians, physx::PxVec3 unitAxis){
        auto nat_in_angleRadians = (angleRadians);
        auto nat_in_unitAxis = (unitAxis);
        auto val = PxQuat();
        return *(PxQuatPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_R_PxQuat_P_float_P_PxVec3_C_PxQuat_ctor(float angleRadians, PxVec3 unitAxis);
    
    public  PxQuat(float angleRadians, PxVec3 unitAxis){
        float pvk_in_angleRadians = (angleRadians);
        PxVec3 pvk_in_unitAxis = (unitAxis);
        var _new = (W_PxQuat_R_PxQuat_P_float_P_PxVec3_C_PxQuat_ctor(pvk_in_angleRadians, pvk_in_unitAxis));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxQuat(PxQuatPtr v)                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_PxQuat_R_PxQuat_P_PxQuat_C_PxQuat_ctor(physx::PxQuat v){
        auto nat_in_v = (v);
        auto val = PxQuat();
        return *(PxQuatPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_R_PxQuat_P_PxQuat_C_PxQuat_ctor(PxQuat v);
    
    public  PxQuat(PxQuat v){
        PxQuat pvk_in_v = (v);
        var _new = (W_PxQuat_R_PxQuat_P_PxQuat_C_PxQuat_ctor(pvk_in_v));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxQuat(PxMat33Ptr m)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_PxQuat_R_PxQuat_P_PxMat33_C_PxQuat_ctor(physx::PxMat33 m){
        auto nat_in_m = (m);
        auto val = PxQuat();
        return *(PxQuatPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_R_PxQuat_P_PxMat33_C_PxQuat_ctor(PxMat33 m);
    
    public  PxQuat(PxMat33 m){
        PxMat33 pvk_in_m = (m);
        var _new = (W_PxQuat_R_PxQuat_P_PxMat33_C_PxQuat_ctor(pvk_in_m));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       isIdentity()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isIdentity_R_bool_C_PxQuat(physx::PxQuat self){
        auto retVal = self.isIdentity();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isIdentity_R_bool_C_PxQuat(PxQuat selfBlt);
    
    public  bool isIdentity(){
        bool retVal = W_isIdentity_R_bool_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isFinite()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isFinite_R_bool_C_PxQuat(physx::PxQuat self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite_R_bool_C_PxQuat(PxQuat selfBlt);
    
    public  bool isFinite(){
        bool retVal = W_isFinite_R_bool_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isUnit()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isUnit_R_bool_C_PxQuat(physx::PxQuat self){
        auto retVal = self.isUnit();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isUnit_R_bool_C_PxQuat(PxQuat selfBlt);
    
    public  bool isUnit(){
        bool retVal = W_isUnit_R_bool_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isSane()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isSane_R_bool_C_PxQuat(physx::PxQuat self){
        auto retVal = self.isSane();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSane_R_bool_C_PxQuat(PxQuat selfBlt);
    
    public  bool isSane(){
        bool retVal = W_isSane_R_bool_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator==(PxQuatPtr q)                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxQuat_C_PxQuat(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator==(nat_in_q);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxQuat_C_PxQuat(PxQuat selfBlt, PxQuat q);
    
    public static bool operator==(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxQuat_C_PxQuat(lhs, pvk_in_q);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       toRadiansAndUnitAxis(float* angle, PxVec3Ptr axis)                     #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxVec3
    // NATIVE SIG: void toRadiansAndUnitAxis(float& angle, PxVec3& axis) const
    	{
    		const float quatEpsilon = 1.0e-8f;
    		const float s2 = x * x + y * y + z * z;
    		if(s2 < quatEpsilon * quatEpsilon) // can't extract a sensible axis
    		{
    			angle = 0.0f;
    			axis = PxVec3(1.0f, 0.0f, 0.0f);
    		}
    		else
    		{
    			const float s = PxRecipSqrt(s2);
    			axis = PxVec3(x, y, z) * s;
    			angle = PxAbs(w) < quatEpsilon ? PxPi : PxAtan2(s2 * s, w) * 2.0f;
    		}
    	}
    #if NATIVE //function start
    ES void W_toRadiansAndUnitAxis_R_void_P_floatPtr_P__C_PxQuat(physx::PxQuat self, float& angle,  axis){
        auto nat_in_angle = (angle);
        auto nat_in_axis = (axis);
        self.toRadiansAndUnitAxis(nat_in_angle, nat_in_axis);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_toRadiansAndUnitAxis_R_void_P_floatPtr_P__C_PxQuat(PxQuat selfBlt, float* angle,  axis);
    
    public  void toRadiansAndUnitAxis(float* angle,  axis){
        float* pvk_in_angle = (angle);
         pvk_in_axis = (axis);
        W_toRadiansAndUnitAxis_R_void_P_floatPtr_P__C_PxQuat(this, pvk_in_angle, pvk_in_axis);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getAngle()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES float W_getAngle_R_float_C_PxQuat(physx::PxQuat self){
        auto retVal = self.getAngle();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getAngle_R_float_C_PxQuat(PxQuat selfBlt);
    
    public  float getAngle(){
        float retVal = W_getAngle_R_float_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getAngle(PxQuatPtr q)                                                  #
    //================================================================================
    #if NATIVE //function start
    ES float W_getAngle_R_float_P_PxQuat_C_PxQuat(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.getAngle(nat_in_q);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getAngle_R_float_P_PxQuat_C_PxQuat(PxQuat selfBlt, PxQuat q);
    
    public  float getAngle(PxQuat q){
        PxQuat pvk_in_q = (q);
        float retVal = W_getAngle_R_float_P_PxQuat_C_PxQuat(this, pvk_in_q);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitudeSquared()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitudeSquared_R_float_C_PxQuat(physx::PxQuat self){
        auto retVal = self.magnitudeSquared();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitudeSquared_R_float_C_PxQuat(PxQuat selfBlt);
    
    public  float magnitudeSquared(){
        float retVal = W_magnitudeSquared_R_float_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       dot(PxQuatPtr v)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES float W_dot_R_float_P_PxQuat_C_PxQuat(physx::PxQuat self, physx::PxQuat v){
        auto nat_in_v = (v);
        auto retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_dot_R_float_P_PxQuat_C_PxQuat(PxQuat selfBlt, PxQuat v);
    
    public  float dot(PxQuat v){
        PxQuat pvk_in_v = (v);
        float retVal = W_dot_R_float_P_PxQuat_C_PxQuat(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNormalized()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_getNormalized_R_PxQuat_C_PxQuat(physx::PxQuat self){
        auto retVal = self.getNormalized;
        return *(PxQuatPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_getNormalized_R_PxQuat_C_PxQuat(PxQuat selfBlt);
    
    public  PxQuat getNormalized(){
        PxQuat retVal = W_getNormalized_R_PxQuat_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitude()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitude_R_float_C_PxQuat(physx::PxQuat self){
        auto retVal = self.magnitude();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitude_R_float_C_PxQuat(PxQuat selfBlt);
    
    public  float magnitude(){
        float retVal = W_magnitude_R_float_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       normalize()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_normalize_R_float_C_PxQuat(physx::PxQuat self){
        auto retVal = self.normalize();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalize_R_float_C_PxQuat(PxQuat selfBlt);
    
    public  float normalize(){
        float retVal = W_normalize_R_float_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConjugate()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_getConjugate_R_PxQuat_C_PxQuat(physx::PxQuat self){
        auto retVal = self.getConjugate;
        return *(PxQuatPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_getConjugate_R_PxQuat_C_PxQuat(PxQuat selfBlt);
    
    public  PxQuat getConjugate(){
        PxQuat retVal = W_getConjugate_R_PxQuat_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getImaginaryPart()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getImaginaryPart_R_PxVec3_C_PxQuat(physx::PxQuat self){
        auto retVal = self.getImaginaryPart;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getImaginaryPart_R_PxVec3_C_PxQuat(PxQuat selfBlt);
    
    public  PxVec3 getImaginaryPart(){
        PxVec3 retVal = W_getImaginaryPart_R_PxVec3_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBasisVector0()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getBasisVector0_R_PxVec3_C_PxQuat(physx::PxQuat self){
        auto retVal = self.getBasisVector0;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasisVector0_R_PxVec3_C_PxQuat(PxQuat selfBlt);
    
    public  PxVec3 getBasisVector0(){
        PxVec3 retVal = W_getBasisVector0_R_PxVec3_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBasisVector1()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getBasisVector1_R_PxVec3_C_PxQuat(physx::PxQuat self){
        auto retVal = self.getBasisVector1;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasisVector1_R_PxVec3_C_PxQuat(PxQuat selfBlt);
    
    public  PxVec3 getBasisVector1(){
        PxVec3 retVal = W_getBasisVector1_R_PxVec3_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBasisVector2()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getBasisVector2_R_PxVec3_C_PxQuat(physx::PxQuat self){
        auto retVal = self.getBasisVector2;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasisVector2_R_PxVec3_C_PxQuat(PxQuat selfBlt);
    
    public  PxVec3 getBasisVector2(){
        PxVec3 retVal = W_getBasisVector2_R_PxVec3_C_PxQuat(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       rotate(PxVec3Ptr v)                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_rotate_R_PxVec3_P_PxVec3_C_PxQuat(physx::PxQuat self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.rotate;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotate_R_PxVec3_P_PxVec3_C_PxQuat(PxQuat selfBlt, PxVec3 v);
    
    public  PxVec3 rotate(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_rotate_R_PxVec3_P_PxVec3_C_PxQuat(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       rotateInv(PxVec3Ptr v)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_rotateInv_R_PxVec3_P_PxVec3_C_PxQuat(physx::PxQuat self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.rotateInv;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotateInv_R_PxVec3_P_PxVec3_C_PxQuat(PxQuat selfBlt, PxVec3 v);
    
    public  PxVec3 rotateInv(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_rotateInv_R_PxVec3_P_PxVec3_C_PxQuat(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator=(PxQuatPtr p)                                                 #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=(PxQuatPtr q)                                                #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator+=(PxQuatPtr q)                                                #
    //================================================================================
    //Skipped unsupported operator PlusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator-=(PxQuatPtr q)                                                #
    //================================================================================
    //Skipped unsupported operator MinusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=(float s)                                                    #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*(PxQuatPtr q)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_OP_Star_R_PxQuat_P_PxQuat_C_PxQuat(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator*;
        return *(PxQuatPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Star_R_PxQuat_P_PxQuat_C_PxQuat(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator*(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_OP_Star_R_PxQuat_P_PxQuat_C_PxQuat(lhs, pvk_in_q);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+(PxQuatPtr q)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_OP_Plus_R_PxQuat_P_PxQuat_C_PxQuat(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator+;
        return *(PxQuatPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Plus_R_PxQuat_P_PxQuat_C_PxQuat(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator+(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_OP_Plus_R_PxQuat_P_PxQuat_C_PxQuat(lhs, pvk_in_q);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_OP_Minus_R_PxQuat_C_PxQuat(physx::PxQuat self){
        auto retVal = self.operator-;
        return *(PxQuatPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Minus_R_PxQuat_C_PxQuat(PxQuat selfBlt);
    
    public static PxQuat operator-(PxQuat lhs){
        PxQuat retVal = W_OP_Minus_R_PxQuat_C_PxQuat(lhs);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-(PxQuatPtr q)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_OP_Minus_R_PxQuat_P_PxQuat_C_PxQuat(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator-;
        return *(PxQuatPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Minus_R_PxQuat_P_PxQuat_C_PxQuat(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator-(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_OP_Minus_R_PxQuat_P_PxQuat_C_PxQuat(lhs, pvk_in_q);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*(float r)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxQuatPOD W_OP_Star_R_PxQuat_P_float_C_PxQuat(physx::PxQuat self, float r){
        auto nat_in_r = (r);
        auto retVal = self.operator*;
        return *(PxQuatPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Star_R_PxQuat_P_float_C_PxQuat(PxQuat selfBlt, float r);
    
    public static PxQuat operator*(PxQuat lhs, float r){
        float pvk_in_r = (r);
        PxQuat retVal = W_OP_Star_R_PxQuat_P_float_C_PxQuat(lhs, pvk_in_r);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: ~PxQuat
    

#if !NATIVE //struct close
}
#endif //struct close
