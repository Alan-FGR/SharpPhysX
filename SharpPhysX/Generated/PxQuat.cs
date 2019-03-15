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
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PX_FORCE_INLINE PxQuat()
    	{
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L55~57
    #if NATIVE
    ES physx::PxQuat W_PxQuat_ctor(){
        self.PxQuat();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_PxQuat_ctor();
    
    public PxQuat(){
        var _new = W_PxQuat_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L60~63
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L68~70
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L75~77
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L88~97
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L102~104
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L111~111
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L116~119
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L124~127
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L132~136
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L142~146
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L151~154
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L159~174
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L181~184
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L191~194
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L199~202
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L207~210
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L212~216
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L218~221
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L227~240
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L247~250
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L255~258
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L261~266
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L269~274
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L277~282
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L287~296
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L301~310
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
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxQuat& operator=(const PxQuat& p)
    	{
    		x = p.x;
    		y = p.y;
    		z = p.z;
    		w = p.w;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L315~322
    #if NATIVE
    ES physx::PxQuat* W_operator=(physx::PxQuat self, physx::PxQuat p){
        auto nat_in_p = (p);
        auto retVal = &self.operator=(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_operator=(PxQuat selfBlt, PxQuat p);
    
    public static PxQuat operator=(PxQuat lhs, PxQuat p){
        PxQuat pvk_in_p = (p);
        PxQuat retVal = W_operator=(lhs, pvk_in_p);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxQuat& operator*=(const PxQuat& q)
    	{
    		const float tx = w * q.x + q.w * x + y * q.z - q.y * z;
    		const float ty = w * q.y + q.w * y + z * q.x - q.z * x;
    		const float tz = w * q.z + q.w * z + x * q.y - q.x * y;
    
    		w = w * q.w - q.x * x - y * q.y - q.z * z;
    		x = tx;
    		y = ty;
    		z = tz;
    
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L324~336
    #if NATIVE
    ES physx::PxQuat* W_operator*=(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = &self.operator*=(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_operator*=(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator*=(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_operator*=(lhs, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator+=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxQuat& operator+=(const PxQuat& q)
    	{
    		x += q.x;
    		y += q.y;
    		z += q.z;
    		w += q.w;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L338~345
    #if NATIVE
    ES physx::PxQuat* W_operator+=(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = &self.operator+=(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_operator+=(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator+=(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_operator+=(lhs, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxQuat& operator-=(const PxQuat& q)
    	{
    		x -= q.x;
    		y -= q.y;
    		z -= q.z;
    		w -= q.w;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L347~354
    #if NATIVE
    ES physx::PxQuat* W_operator-=(physx::PxQuat self, physx::PxQuat q){
        auto nat_in_q = (q);
        auto retVal = &self.operator-=(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_operator-=(PxQuat selfBlt, PxQuat q);
    
    public static PxQuat operator-=(PxQuat lhs, PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = W_operator-=(lhs, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxQuat& operator*=(const float s)
    	{
    		x *= s;
    		y *= s;
    		z *= s;
    		w *= s;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L356~363
    #if NATIVE
    ES physx::PxQuat* W_operator*=(physx::PxQuat self, float s){
        auto nat_in_s = (s);
        auto retVal = &self.operator*=(nat_in_s);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat W_operator*=(PxQuat selfBlt, float s);
    
    public static PxQuat operator*=(PxQuat lhs, float s){
        float pvk_in_s = (s);
        PxQuat retVal = W_operator*=(lhs, pvk_in_s);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L366~370
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L373~376
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L379~382
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L384~387
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L389~392
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
    
    
    //================================================================================
    //#       ~PxQuat                                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxQuat
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L49~49
    #if NATIVE
    ES void W_~PxQuat(physx::PxQuat self){
        self.~PxQuat();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxQuat(PxQuat selfBlt);
    
    public void ~PxQuat(){
        W_~PxQuat(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
