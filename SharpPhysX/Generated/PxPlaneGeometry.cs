#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxPlaneGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxPlaneGeometry                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L61~61
    #if NATIVE
    ES UNPARSED_TYPE PxPlaneGeometry_ctor(){
        self->PxPlaneGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlaneGeometry_ctor();
    
    public PxPlaneGeometry(){
        var _new = PxPlaneGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L68~68
    #if NATIVE
    ES bool isValid(physx::PxPlaneGeometry* self){
        bool retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxPlaneGeometry selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxPlaneGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxPlaneGeometry selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxPlaneGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxPlaneGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlaneGeometry                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES UNPARSED_TYPE PxPlaneGeometry_ctor( ){
         nat_in_ = ();
        self->PxPlaneGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlaneGeometry_ctor( );
    
    public PxPlaneGeometry( ){
         pvk_in_ = ();
        var _new = PxPlaneGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlaneGeometry                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES UNPARSED_TYPE PxPlaneGeometry_ctor( ){
         nat_in_ = ();
        self->PxPlaneGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPlaneGeometry_ctor( );
    
    public PxPlaneGeometry( ){
         pvk_in_ = ();
        var _new = PxPlaneGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxPlaneGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES void ~PxPlaneGeometry(physx::PxPlaneGeometry* self){
        self->~PxPlaneGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxPlaneGeometry(PxPlaneGeometry selfPtr);
    
    public void ~PxPlaneGeometry(){
        ~PxPlaneGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
