#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxSphereGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L52~52
    #if NATIVE
    ES UNPARSED_TYPE PxSphereGeometry_ctor(){
        self->PxSphereGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSphereGeometry_ctor();
    
    public PxSphereGeometry(){
        var _new = PxSphereGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE PxSphereGeometry_ctor(physx::PxReal ir){
        physx::PxReal nat_in_ir = (ir);
        self->PxSphereGeometry(nat_in_ir);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSphereGeometry_ctor(float ir);
    
    public PxSphereGeometry(float ir){
        float pvk_in_ir = (ir);
        var _new = PxSphereGeometry_ctor(pvk_in_ir);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L65~65
    #if NATIVE
    ES bool isValid(physx::PxSphereGeometry* self){
        bool retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxSphereGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxSphereGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxSphereGeometry selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxSphereGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxSphereGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES UNPARSED_TYPE PxSphereGeometry_ctor( ){
         nat_in_ = ();
        self->PxSphereGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSphereGeometry_ctor( );
    
    public PxSphereGeometry( ){
         pvk_in_ = ();
        var _new = PxSphereGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES UNPARSED_TYPE PxSphereGeometry_ctor( ){
         nat_in_ = ();
        self->PxSphereGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSphereGeometry_ctor( );
    
    public PxSphereGeometry( ){
         pvk_in_ = ();
        var _new = PxSphereGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxSphereGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES void ~PxSphereGeometry(physx::PxSphereGeometry* self){
        self->~PxSphereGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxSphereGeometry(PxSphereGeometry selfPtr);
    
    public void ~PxSphereGeometry(){
        ~PxSphereGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
