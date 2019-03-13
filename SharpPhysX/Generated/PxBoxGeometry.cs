#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxBoxGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE PxBoxGeometry_ctor(){
        self->PxBoxGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoxGeometry_ctor();
    
    public PxBoxGeometry(){
        var _new = PxBoxGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE PxBoxGeometry_ctor(physx::PxReal hx, physx::PxReal hy, physx::PxReal hz){
        physx::PxReal nat_in_hx = (hx);
        physx::PxReal nat_in_hy = (hy);
        physx::PxReal nat_in_hz = (hz);
        self->PxBoxGeometry(nat_in_hx, nat_in_hy, nat_in_hz);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoxGeometry_ctor(float hx, float hy, float hz);
    
    public PxBoxGeometry(float hx, float hy, float hz){
        float pvk_in_hx = (hx);
        float pvk_in_hy = (hy);
        float pvk_in_hz = (hz);
        var _new = PxBoxGeometry_ctor(pvk_in_hx, pvk_in_hy, pvk_in_hz);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L70~70
    #if NATIVE
    ES UNPARSED_TYPE PxBoxGeometry_ctor(physx::PxVec3 halfExtents_){
        physx::PxVec3 nat_in_halfExtents_ = (halfExtents_);
        self->PxBoxGeometry(nat_in_halfExtents_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoxGeometry_ctor(PxVec3 halfExtents_);
    
    public PxBoxGeometry(PxVec3 halfExtents_){
        PxVec3 pvk_in_halfExtents_ = (halfExtents_);
        var _new = PxBoxGeometry_ctor(pvk_in_halfExtents_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L82~82
    #if NATIVE
    ES bool isValid(physx::PxBoxGeometry* self){
        bool retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxBoxGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE PxBoxGeometry_ctor( ){
         nat_in_ = ();
        self->PxBoxGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoxGeometry_ctor( );
    
    public PxBoxGeometry( ){
         pvk_in_ = ();
        var _new = PxBoxGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE PxBoxGeometry_ctor( ){
         nat_in_ = ();
        self->PxBoxGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoxGeometry_ctor( );
    
    public PxBoxGeometry( ){
         pvk_in_ = ();
        var _new = PxBoxGeometry_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxBoxGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxBoxGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxBoxGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxBoxGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBoxGeometry                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES void ~PxBoxGeometry(physx::PxBoxGeometry* self){
        self->~PxBoxGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxBoxGeometry(PxBoxGeometry selfPtr);
    
    public void ~PxBoxGeometry(){
        ~PxBoxGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
