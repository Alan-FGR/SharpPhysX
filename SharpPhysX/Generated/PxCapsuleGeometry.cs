#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxCapsuleGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L60~60
    #if NATIVE
    ES UNPARSED_TYPE PxCapsuleGeometry_ctor(){
        self->PxCapsuleGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxCapsuleGeometry_ctor();
    
    public PxCapsuleGeometry(){
        var _new = PxCapsuleGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L65~65
    #if NATIVE
    ES UNPARSED_TYPE PxCapsuleGeometry_ctor(physx::PxReal radius_, physx::PxReal halfHeight_){
        physx::PxReal nat_in_radius_ = (radius_);
        physx::PxReal nat_in_halfHeight_ = (halfHeight_);
        self->PxCapsuleGeometry(nat_in_radius_, nat_in_halfHeight_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxCapsuleGeometry_ctor(float radius_, float halfHeight_);
    
    public PxCapsuleGeometry(float radius_, float halfHeight_){
        float pvk_in_radius_ = (radius_);
        float pvk_in_halfHeight_ = (halfHeight_);
        var _new = PxCapsuleGeometry_ctor(pvk_in_radius_, pvk_in_halfHeight_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L77~77
    #if NATIVE
    ES bool isValid(physx::PxCapsuleGeometry* self){
        bool retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxCapsuleGeometry selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxCapsuleGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxCapsuleGeometry selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxCapsuleGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxCapsuleGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE PxCapsuleGeometry_ctor( ){
         nat_in_ = ();
        self->PxCapsuleGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxCapsuleGeometry_ctor( );
    
    public PxCapsuleGeometry( ){
         pvk_in_ = ();
        var _new = PxCapsuleGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE PxCapsuleGeometry_ctor( ){
         nat_in_ = ();
        self->PxCapsuleGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxCapsuleGeometry_ctor( );
    
    public PxCapsuleGeometry( ){
         pvk_in_ = ();
        var _new = PxCapsuleGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxCapsuleGeometry                                                     #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES void ~PxCapsuleGeometry(physx::PxCapsuleGeometry* self){
        self->~PxCapsuleGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxCapsuleGeometry(PxCapsuleGeometry selfPtr);
    
    public void ~PxCapsuleGeometry(){
        ~PxCapsuleGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
