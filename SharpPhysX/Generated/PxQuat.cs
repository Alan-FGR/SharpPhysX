#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxQuat { // blittable
    public float x;
    public float y;
    public float z;
    public float w;

#endif

    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_PxQuat_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        self.PxQuat(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_ctor(PxIDENTITY r);
    
    public PxQuat(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = W_PxQuat_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_PxQuat_ctor(float r){
        auto nat_in_r = (r);
        self.PxQuat(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_ctor(float r);
    
    public PxQuat(float r){
        float pvk_in_r = (r);
        var _new = W_PxQuat_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_PxQuat_ctor(float nx, float ny, float nz, float nw){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        auto nat_in_nw = (nw);
        self.PxQuat(nat_in_nx, nat_in_ny, nat_in_nz, nat_in_nw);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_ctor(float nx, float ny, float nz, float nw);
    
    public PxQuat(float nx, float ny, float nz, float nw){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_nw = (nw);
        var _new = W_PxQuat_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_nw);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_PxQuat_ctor(float angleRadians, physx::PxVec3 unitAxis){
        auto nat_in_angleRadians = (angleRadians);
        auto nat_in_unitAxis = (unitAxis);
        self.PxQuat(nat_in_angleRadians, nat_in_unitAxis);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_ctor(float angleRadians, PxVec3 unitAxis);
    
    public PxQuat(float angleRadians, PxVec3 unitAxis){
        float pvk_in_angleRadians = (angleRadians);
        PxVec3 pvk_in_unitAxis = (unitAxis);
        var _new = W_PxQuat_ctor(pvk_in_angleRadians, pvk_in_unitAxis);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_PxQuat_ctor(physx::PxQuat v){
        auto nat_in_v = (v);
        self.PxQuat(nat_in_v);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_ctor(PxQuat v);
    
    public PxQuat(PxQuat v){
        PxQuat pvk_in_v = (v);
        var _new = W_PxQuat_ctor(pvk_in_v);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_PxQuat_ctor(physx::PxMat33 m){
        auto nat_in_m = (m);
        self.PxQuat(nat_in_m);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_ctor(PxMat33 m);
    
    public PxQuat(PxMat33 m){
        PxMat33 pvk_in_m = (m);
        var _new = W_PxQuat_ctor(pvk_in_m);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       isIdentity                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_isIdentity(physx::PxQuat self){
        auto retVal = self.isIdentity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isIdentity(PxQuat selfBlt);
    
    public bool isIdentity(){
        bool retVal = W_isIdentity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isFinite(physx::PxQuat self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite(PxQuat selfBlt);
    
    public bool isFinite(){
        bool retVal = W_isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isUnit                                                                 #
    //================================================================================
    #if NATIVE
    ES bool W_isUnit(physx::PxQuat self){
        auto retVal = self.isUnit();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isUnit(PxQuat selfBlt);
    
    public bool isUnit(){
        bool retVal = W_isUnit(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isSane                                                                 #
    //================================================================================
    #if NATIVE
    ES bool W_isSane(physx::PxQuat self){
        auto retVal = self.isSane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSane(PxQuat selfBlt);
    
    public bool isSane(){
        bool retVal = W_isSane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator==(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxQuat selfBlt, PxQuat q);
    
    public static bool operator==(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_q);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       toRadiansAndUnitAxis                                                   #
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
    #if NATIVE
    ES void W_toRadiansAndUnitAxis(physx::PxQuat self, float& angle,  axis){
        auto nat_in_angle = (angle);
        auto nat_in_axis = (axis);
        self.toRadiansAndUnitAxis(nat_in_angle, nat_in_axis);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_toRadiansAndUnitAxis(PxQuat selfBlt, float* angle,  axis);
    
    public void toRadiansAndUnitAxis(float* angle,  axis){
        float* pvk_in_angle = (angle);
         pvk_in_axis = (axis);
        W_toRadiansAndUnitAxis(this, pvk_in_angle, pvk_in_axis);
    }
    #endif*/
    
    
    //================================================================================
    //#       getAngle                                                               #
    //================================================================================
    #if NATIVE
    ES float W_getAngle(physx::PxQuat self){
        auto retVal = self.getAngle();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getAngle(PxQuat selfBlt);
    
    public float getAngle(){
        float retVal = W_getAngle(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getAngle                                                               #
    //================================================================================
    #if NATIVE
    ES float W_getAngle(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.getAngle(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getAngle(PxQuat selfBlt, PxQuat q);
    
    public float getAngle(PxQuat q){
        PxQuat pvk_in_q = (q);
        float retVal = W_getAngle(this, pvk_in_q);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitudeSquared                                                       #
    //================================================================================
    #if NATIVE
    ES float W_magnitudeSquared(physx::PxQuat self){
        auto retVal = self.magnitudeSquared();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitudeSquared(PxQuat selfBlt);
    
    public float magnitudeSquared(){
        float retVal = W_magnitudeSquared(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       dot                                                                    #
    //================================================================================
    #if NATIVE
    ES float W_dot(physx::PxQuat self, physx::PxQuat v){
        auto nat_in_v = (v);
        auto retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_dot(PxQuat selfBlt, PxQuat v);
    
    public float dot(PxQuat v){
        PxQuat pvk_in_v = (v);
        float retVal = W_dot(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNormalized                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_getNormalized(physx::PxQuat self){
        auto retVal = self.getNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_getNormalized(PxQuat selfBlt);
    
    public PxQuat getNormalized(){
        PxQuat retVal = W_getNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitude                                                              #
    //================================================================================
    #if NATIVE
    ES float W_magnitude(physx::PxQuat self){
        auto retVal = self.magnitude();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitude(PxQuat selfBlt);
    
    public float magnitude(){
        float retVal = W_magnitude(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalize                                                              #
    //================================================================================
    #if NATIVE
    ES float W_normalize(physx::PxQuat self){
        auto retVal = self.normalize();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalize(PxQuat selfBlt);
    
    public float normalize(){
        float retVal = W_normalize(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConjugate                                                           #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_getConjugate(physx::PxQuat self){
        auto retVal = self.getConjugate();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_getConjugate(PxQuat selfBlt);
    
    public PxQuat getConjugate(){
        PxQuat retVal = W_getConjugate(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getImaginaryPart                                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getImaginaryPart(physx::PxQuat self){
        auto retVal = self.getImaginaryPart();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getImaginaryPart(PxQuat selfBlt);
    
    public PxVec3 getImaginaryPart(){
        PxVec3 retVal = W_getImaginaryPart(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBasisVector0                                                        #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getBasisVector0(physx::PxQuat self){
        auto retVal = self.getBasisVector0();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasisVector0(PxQuat selfBlt);
    
    public PxVec3 getBasisVector0(){
        PxVec3 retVal = W_getBasisVector0(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBasisVector1                                                        #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getBasisVector1(physx::PxQuat self){
        auto retVal = self.getBasisVector1();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasisVector1(PxQuat selfBlt);
    
    public PxVec3 getBasisVector1(){
        PxVec3 retVal = W_getBasisVector1(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBasisVector2                                                        #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getBasisVector2(physx::PxQuat self){
        auto retVal = self.getBasisVector2();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasisVector2(PxQuat selfBlt);
    
    public PxVec3 getBasisVector2(){
        PxVec3 retVal = W_getBasisVector2(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotate                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_rotate(physx::PxQuat self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.rotate(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotate(PxQuat selfBlt, PxVec3 v);
    
    public PxVec3 rotate(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_rotate(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotateInv                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_rotateInv(physx::PxQuat self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.rotateInv(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotateInv(PxQuat selfBlt, PxVec3 v);
    
    public PxVec3 rotateInv(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_rotateInv(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator+=                                                             #
    //================================================================================
    //Skipped unsupported operator PlusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator-=                                                             #
    //================================================================================
    //Skipped unsupported operator MinusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_OP_Star(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator*(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Star(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator*(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_OP_Star(lhs, pvk_in_q);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_OP_Plus(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator+(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Plus(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator+(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_OP_Plus(lhs, pvk_in_q);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_OP_Minus(physx::PxQuat self){
        auto retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Minus(PxQuat selfBlt);
    
    public static PxQuat operator-(PxQuat lhs){
        PxQuat retVal = W_OP_Minus(lhs);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_OP_Minus(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = self.operator-(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Minus(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator-(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_OP_Minus(lhs, pvk_in_q);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxQuat W_OP_Star(physx::PxQuat self, float r){
        auto nat_in_r = (r);
        auto retVal = self.operator*(nat_in_r);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_OP_Star(PxQuat selfBlt, float r);
    
    public static PxQuat operator*(PxQuat lhs, float r){
        float pvk_in_r = (r);
        PxQuat retVal = W_OP_Star(lhs, pvk_in_r);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: ~PxQuat
    

#if !NATIVE
}
#endif
