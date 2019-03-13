#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxPlane { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L56~58
    #if NATIVE
    ES UNPARSED_TYPE PxPlane_ctor(){
        self->PxPlane();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlane_ctor();
    
    public PxPlane(){
        var _new = PxPlane_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L63~65
    #if NATIVE
    ES UNPARSED_TYPE PxPlane_ctor(float nx, float ny, float nz, float distance){
        float nat_in_nx = (nx);
        float nat_in_ny = (ny);
        float nat_in_nz = (nz);
        float nat_in_distance = (distance);
        self->PxPlane(nat_in_nx, nat_in_ny, nat_in_nz, nat_in_distance);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlane_ctor(float nx, float ny, float nz, float distance);
    
    public PxPlane(float nx, float ny, float nz, float distance){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_distance = (distance);
        var _new = PxPlane_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_distance);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L70~72
    #if NATIVE
    ES UNPARSED_TYPE PxPlane_ctor(physx::PxVec3 normal, float distance){
        physx::PxVec3 nat_in_normal = (normal);
        float nat_in_distance = (distance);
        self->PxPlane(nat_in_normal, nat_in_distance);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlane_ctor(PxVec3 normal, float distance);
    
    public PxPlane(PxVec3 normal, float distance){
        PxVec3 pvk_in_normal = (normal);
        float pvk_in_distance = (distance);
        var _new = PxPlane_ctor(pvk_in_normal, pvk_in_distance);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L77~80
    #if NATIVE
    ES UNPARSED_TYPE PxPlane_ctor(physx::PxVec3 point, physx::PxVec3 normal){
        physx::PxVec3 nat_in_point = (point);
        physx::PxVec3 nat_in_normal = (normal);
        self->PxPlane(nat_in_point, nat_in_normal);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlane_ctor(PxVec3 point, PxVec3 normal);
    
    public PxPlane(PxVec3 point, PxVec3 normal){
        PxVec3 pvk_in_point = (point);
        PxVec3 pvk_in_normal = (normal);
        var _new = PxPlane_ctor(pvk_in_point, pvk_in_normal);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L85~89
    #if NATIVE
    ES UNPARSED_TYPE PxPlane_ctor(physx::PxVec3 p0, physx::PxVec3 p1, physx::PxVec3 p2){
        physx::PxVec3 nat_in_p0 = (p0);
        physx::PxVec3 nat_in_p1 = (p1);
        physx::PxVec3 nat_in_p2 = (p2);
        self->PxPlane(nat_in_p0, nat_in_p1, nat_in_p2);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlane_ctor(PxVec3 p0, PxVec3 p1, PxVec3 p2);
    
    public PxPlane(PxVec3 p0, PxVec3 p1, PxVec3 p2){
        PxVec3 pvk_in_p0 = (p0);
        PxVec3 pvk_in_p1 = (p1);
        PxVec3 pvk_in_p2 = (p2);
        var _new = PxPlane_ctor(pvk_in_p0, pvk_in_p1, pvk_in_p2);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L94~97
    #if NATIVE
    ES bool operator==(physx::PxPlane* self,  p){
         nat_in_p = (p);
        bool retVal = self->operator==(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxPlane selfPtr,  p);
    
    public bool operator==( p){
         pvk_in_p = (p);
        bool retVal = operator==(this, pvk_in_p);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       distance                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L99~102
    #if NATIVE
    ES float distance(physx::PxPlane* self, physx::PxVec3 p){
        physx::PxVec3 nat_in_p = (p);
        float retVal = self->distance(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float distance(PxPlane selfPtr, PxVec3 p);
    
    public float distance(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        float retVal = distance(this, pvk_in_p);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       contains                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L104~107
    #if NATIVE
    ES bool contains(physx::PxPlane* self, physx::PxVec3 p){
        physx::PxVec3 nat_in_p = (p);
        bool retVal = self->contains(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool contains(PxPlane selfPtr, PxVec3 p);
    
    public bool contains(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        bool retVal = contains(this, pvk_in_p);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       project                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L112~115
    #if NATIVE
    ES physx::PxVec3 project(physx::PxPlane* self, physx::PxVec3 p){
        physx::PxVec3 nat_in_p = (p);
        physx::PxVec3 retVal = self->project(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 project(PxPlane selfPtr, PxVec3 p);
    
    public PxVec3 project(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        PxVec3 retVal = project(this, pvk_in_p);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       pointInPlane                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L120~123
    #if NATIVE
    ES physx::PxVec3 pointInPlane(physx::PxPlane* self){
        physx::PxVec3 retVal = self->pointInPlane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 pointInPlane(PxPlane selfPtr);
    
    public PxVec3 pointInPlane(){
        PxVec3 retVal = pointInPlane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalize                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L129~134
    #if NATIVE
    ES void normalize(physx::PxPlane* self){
        self->normalize();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void normalize(PxPlane selfPtr);
    
    public void normalize(){
        normalize(this);
    }
    #endif
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE PxPlane_ctor( ){
         nat_in_ = ();
        self->PxPlane(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlane_ctor( );
    
    public PxPlane( ){
         pvk_in_ = ();
        var _new = PxPlane_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE PxPlane_ctor( ){
         nat_in_ = ();
        self->PxPlane(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlane_ctor( );
    
    public PxPlane( ){
         pvk_in_ = ();
        var _new = PxPlane_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxPlane* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxPlane selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxPlane                                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L50~50
    #if NATIVE
    ES void ~PxPlane(physx::PxPlane* self){
        self->~PxPlane();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxPlane(PxPlane selfPtr);
    
    public void ~PxPlane(){
        ~PxPlane(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxPlane* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxPlane selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
