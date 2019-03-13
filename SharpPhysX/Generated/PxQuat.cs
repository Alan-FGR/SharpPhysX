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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L55~57
    #if NATIVE
    ES physx::PxQuat PxQuat_ctor(){
        self.PxQuat();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxQuat_ctor();
    
    public PxQuat(){
        var _new = PxQuat_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L60~63
    #if NATIVE
    ES physx::PxQuat PxQuat_ctor(physx::PxIDENTITY r){
        physx::PxIDENTITY nat_in_r = (r);
        self.PxQuat(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxQuat_ctor(PxIDENTITY r);
    
    public PxQuat(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = PxQuat_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L68~70
    #if NATIVE
    ES physx::PxQuat PxQuat_ctor(float r){
        float nat_in_r = (r);
        self.PxQuat(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxQuat_ctor(float r);
    
    public PxQuat(float r){
        float pvk_in_r = (r);
        var _new = PxQuat_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L75~77
    #if NATIVE
    ES physx::PxQuat PxQuat_ctor(float nx, float ny, float nz, float nw){
        float nat_in_nx = (nx);
        float nat_in_ny = (ny);
        float nat_in_nz = (nz);
        float nat_in_nw = (nw);
        self.PxQuat(nat_in_nx, nat_in_ny, nat_in_nz, nat_in_nw);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxQuat_ctor(float nx, float ny, float nz, float nw);
    
    public PxQuat(float nx, float ny, float nz, float nw){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_nw = (nw);
        var _new = PxQuat_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_nw);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L88~97
    #if NATIVE
    ES physx::PxQuat PxQuat_ctor(float angleRadians, physx::PxVec3 unitAxis){
        float nat_in_angleRadians = (angleRadians);
        physx::PxVec3 nat_in_unitAxis = (unitAxis);
        self.PxQuat(nat_in_angleRadians, nat_in_unitAxis);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxQuat_ctor(float angleRadians, PxVec3 unitAxis);
    
    public PxQuat(float angleRadians, PxVec3 unitAxis){
        float pvk_in_angleRadians = (angleRadians);
        PxVec3 pvk_in_unitAxis = (unitAxis);
        var _new = PxQuat_ctor(pvk_in_angleRadians, pvk_in_unitAxis);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L102~104
    #if NATIVE
    ES physx::PxQuat PxQuat_ctor(physx::PxQuat v){
        physx::PxQuat nat_in_v = (v);
        self.PxQuat(nat_in_v);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxQuat_ctor(PxQuat v);
    
    public PxQuat(PxQuat v){
        PxQuat pvk_in_v = (v);
        var _new = PxQuat_ctor(pvk_in_v);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxQuat                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L111~111
    #if NATIVE
    ES physx::PxQuat PxQuat_ctor(physx::PxMat33 m){
        physx::PxMat33 nat_in_m = (m);
        self.PxQuat(nat_in_m);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxQuat_ctor(PxMat33 m);
    
    public PxQuat(PxMat33 m){
        PxMat33 pvk_in_m = (m);
        var _new = PxQuat_ctor(pvk_in_m);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       isIdentity                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L116~119
    #if NATIVE
    ES bool isIdentity(physx::PxQuat self){
        bool retVal = self.isIdentity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isIdentity(PxQuat selfBlt);
    
    public bool isIdentity(){
        bool retVal = isIdentity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L124~127
    #if NATIVE
    ES bool isFinite(physx::PxQuat self){
        bool retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isFinite(PxQuat selfBlt);
    
    public bool isFinite(){
        bool retVal = isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isUnit                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L132~136
    #if NATIVE
    ES bool isUnit(physx::PxQuat self){
        bool retVal = self.isUnit();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isUnit(PxQuat selfBlt);
    
    public bool isUnit(){
        bool retVal = isUnit(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isSane                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L142~146
    #if NATIVE
    ES bool isSane(physx::PxQuat self){
        bool retVal = self.isSane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isSane(PxQuat selfBlt);
    
    public bool isSane(){
        bool retVal = isSane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L151~154
    #if NATIVE
    ES bool operator==(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        bool retVal = self.operator==(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxQuat selfBlt, PxQuat q);
    
    public bool operator==(PxQuat q){
        PxQuat pvk_in_q = (q);
        bool retVal = operator==(this, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       toRadiansAndUnitAxis                                                   #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference float*
    , Non const pointer/reference global::PhysX.physx.PxVec3
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L159~174
    #if NATIVE
    ES void toRadiansAndUnitAxis(physx::PxQuat self,  angle,  axis){
         nat_in_angle = (angle);
         nat_in_axis = (axis);
        self.toRadiansAndUnitAxis(nat_in_angle, nat_in_axis);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void toRadiansAndUnitAxis(PxQuat selfBlt,  angle,  axis);
    
    public void toRadiansAndUnitAxis( angle,  axis){
         pvk_in_angle = (angle);
         pvk_in_axis = (axis);
        toRadiansAndUnitAxis(this, pvk_in_angle, pvk_in_axis);
    }
    #endif*/
    
    
    //================================================================================
    //#       getAngle                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L181~184
    #if NATIVE
    ES float getAngle(physx::PxQuat self){
        float retVal = self.getAngle();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getAngle(PxQuat selfBlt);
    
    public float getAngle(){
        float retVal = getAngle(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getAngle                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L191~194
    #if NATIVE
    ES float getAngle(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        float retVal = self.getAngle(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getAngle(PxQuat selfBlt, PxQuat q);
    
    public float getAngle(PxQuat q){
        PxQuat pvk_in_q = (q);
        float retVal = getAngle(this, pvk_in_q);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitudeSquared                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L199~202
    #if NATIVE
    ES float magnitudeSquared(physx::PxQuat self){
        float retVal = self.magnitudeSquared();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float magnitudeSquared(PxQuat selfBlt);
    
    public float magnitudeSquared(){
        float retVal = magnitudeSquared(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       dot                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L207~210
    #if NATIVE
    ES float dot(physx::PxQuat self, physx::PxQuat v){
        physx::PxQuat nat_in_v = (v);
        float retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float dot(PxQuat selfBlt, PxQuat v);
    
    public float dot(PxQuat v){
        PxQuat pvk_in_v = (v);
        float retVal = dot(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNormalized                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L212~216
    #if NATIVE
    ES physx::PxQuat getNormalized(physx::PxQuat self){
        physx::PxQuat retVal = self.getNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat getNormalized(PxQuat selfBlt);
    
    public PxQuat getNormalized(){
        PxQuat retVal = getNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitude                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L218~221
    #if NATIVE
    ES float magnitude(physx::PxQuat self){
        float retVal = self.magnitude();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float magnitude(PxQuat selfBlt);
    
    public float magnitude(){
        float retVal = magnitude(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalize                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L227~240
    #if NATIVE
    ES float normalize(physx::PxQuat self){
        float retVal = self.normalize();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float normalize(PxQuat selfBlt);
    
    public float normalize(){
        float retVal = normalize(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConjugate                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L247~250
    #if NATIVE
    ES physx::PxQuat getConjugate(physx::PxQuat self){
        physx::PxQuat retVal = self.getConjugate();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat getConjugate(PxQuat selfBlt);
    
    public PxQuat getConjugate(){
        PxQuat retVal = getConjugate(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getImaginaryPart                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L255~258
    #if NATIVE
    ES physx::PxVec3 getImaginaryPart(physx::PxQuat self){
        physx::PxVec3 retVal = self.getImaginaryPart();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 getImaginaryPart(PxQuat selfBlt);
    
    public PxVec3 getImaginaryPart(){
        PxVec3 retVal = getImaginaryPart(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBasisVector0                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L261~266
    #if NATIVE
    ES physx::PxVec3 getBasisVector0(physx::PxQuat self){
        physx::PxVec3 retVal = self.getBasisVector0();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 getBasisVector0(PxQuat selfBlt);
    
    public PxVec3 getBasisVector0(){
        PxVec3 retVal = getBasisVector0(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBasisVector1                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L269~274
    #if NATIVE
    ES physx::PxVec3 getBasisVector1(physx::PxQuat self){
        physx::PxVec3 retVal = self.getBasisVector1();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 getBasisVector1(PxQuat selfBlt);
    
    public PxVec3 getBasisVector1(){
        PxVec3 retVal = getBasisVector1(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBasisVector2                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L277~282
    #if NATIVE
    ES physx::PxVec3 getBasisVector2(physx::PxQuat self){
        physx::PxVec3 retVal = self.getBasisVector2();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 getBasisVector2(PxQuat selfBlt);
    
    public PxVec3 getBasisVector2(){
        PxVec3 retVal = getBasisVector2(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotate                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L287~296
    #if NATIVE
    ES physx::PxVec3 rotate(physx::PxQuat self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self.rotate(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 rotate(PxQuat selfBlt, PxVec3 v);
    
    public PxVec3 rotate(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = rotate(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotateInv                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L301~310
    #if NATIVE
    ES physx::PxVec3 rotateInv(physx::PxQuat self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self.rotateInv(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 rotateInv(PxQuat selfBlt, PxVec3 v);
    
    public PxVec3 rotateInv(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = rotateInv(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L315~322
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxQuat self, physx::PxQuat p){
        physx::PxQuat nat_in_p = (p);
        UNPARSED_TYPE retVal = self.operator=(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxQuat selfBlt, PxQuat p);
    
    public UNPARSED_TYPE operator=(PxQuat p){
        PxQuat pvk_in_p = (p);
        UNPARSED_TYPE retVal = operator=(this, pvk_in_p);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L324~336
    #if NATIVE
    ES UNPARSED_TYPE operator*=(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        UNPARSED_TYPE retVal = self.operator*=(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator*=(PxQuat selfBlt, PxQuat q);
    
    public UNPARSED_TYPE operator*=(PxQuat q){
        PxQuat pvk_in_q = (q);
        UNPARSED_TYPE retVal = operator*=(this, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator+=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L338~345
    #if NATIVE
    ES UNPARSED_TYPE operator+=(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        UNPARSED_TYPE retVal = self.operator+=(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator+=(PxQuat selfBlt, PxQuat q);
    
    public UNPARSED_TYPE operator+=(PxQuat q){
        PxQuat pvk_in_q = (q);
        UNPARSED_TYPE retVal = operator+=(this, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L347~354
    #if NATIVE
    ES UNPARSED_TYPE operator-=(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        UNPARSED_TYPE retVal = self.operator-=(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator-=(PxQuat selfBlt, PxQuat q);
    
    public UNPARSED_TYPE operator-=(PxQuat q){
        PxQuat pvk_in_q = (q);
        UNPARSED_TYPE retVal = operator-=(this, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L356~363
    #if NATIVE
    ES UNPARSED_TYPE operator*=(physx::PxQuat self, float s){
        float nat_in_s = (s);
        UNPARSED_TYPE retVal = self.operator*=(nat_in_s);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator*=(PxQuat selfBlt, float s);
    
    public UNPARSED_TYPE operator*=(float s){
        float pvk_in_s = (s);
        UNPARSED_TYPE retVal = operator*=(this, pvk_in_s);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L366~370
    #if NATIVE
    ES physx::PxQuat operator*(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        physx::PxQuat retVal = self.operator*(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat operator*(PxQuat selfBlt, PxQuat q);
    
    public PxQuat operator*(PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = operator*(this, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L373~376
    #if NATIVE
    ES physx::PxQuat operator+(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        physx::PxQuat retVal = self.operator+(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat operator+(PxQuat selfBlt, PxQuat q);
    
    public PxQuat operator+(PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = operator+(this, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L379~382
    #if NATIVE
    ES physx::PxQuat operator-(physx::PxQuat self){
        physx::PxQuat retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat operator-(PxQuat selfBlt);
    
    public PxQuat operator-(){
        PxQuat retVal = operator-(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L384~387
    #if NATIVE
    ES physx::PxQuat operator-(physx::PxQuat self, physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        physx::PxQuat retVal = self.operator-(nat_in_q);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat operator-(PxQuat selfBlt, PxQuat q);
    
    public PxQuat operator-(PxQuat q){
        PxQuat pvk_in_q = (q);
        PxQuat retVal = operator-(this, pvk_in_q);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L389~392
    #if NATIVE
    ES physx::PxQuat operator*(physx::PxQuat self, float r){
        float nat_in_r = (r);
        physx::PxQuat retVal = self.operator*(nat_in_r);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat operator*(PxQuat selfBlt, float r);
    
    public PxQuat operator*(float r){
        float pvk_in_r = (r);
        PxQuat retVal = operator*(this, pvk_in_r);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxQuat                                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxQuat.h L49~49
    #if NATIVE
    ES void ~PxQuat(physx::PxQuat self){
        self.~PxQuat();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxQuat(PxQuat selfBlt);
    
    public void ~PxQuat(){
        ~PxQuat(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
