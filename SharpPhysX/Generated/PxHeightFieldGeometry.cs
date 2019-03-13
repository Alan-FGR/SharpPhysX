#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxHeightFieldGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L59~66
    #if NATIVE
    ES UNPARSED_TYPE PxHeightFieldGeometry_ctor(){
        self->PxHeightFieldGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxHeightFieldGeometry_ctor();
    
    public PxHeightFieldGeometry(){
        var _new = PxHeightFieldGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    , Unresolved parameter type physx::PxHeightFieldGeometry::PxHeightFieldGeometry::flags
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L68~80
    #if NATIVE
    ES UNPARSED_TYPE PxHeightFieldGeometry_ctor( hf,  flags, physx::PxReal heightScale_, physx::PxReal rowScale_, physx::PxReal columnScale_){
         nat_in_hf = (hf);
         nat_in_flags = (flags);
        physx::PxReal nat_in_heightScale_ = (heightScale_);
        physx::PxReal nat_in_rowScale_ = (rowScale_);
        physx::PxReal nat_in_columnScale_ = (columnScale_);
        self->PxHeightFieldGeometry(nat_in_hf, nat_in_flags, nat_in_heightScale_, nat_in_rowScale_, nat_in_columnScale_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxHeightFieldGeometry_ctor( hf,  flags, float heightScale_, float rowScale_, float columnScale_);
    
    public PxHeightFieldGeometry( hf,  flags, float heightScale_, float rowScale_, float columnScale_){
         pvk_in_hf = (hf);
         pvk_in_flags = (flags);
        float pvk_in_heightScale_ = (heightScale_);
        float pvk_in_rowScale_ = (rowScale_);
        float pvk_in_columnScale_ = (columnScale_);
        var _new = PxHeightFieldGeometry_ctor(pvk_in_hf, pvk_in_flags, pvk_in_heightScale_, pvk_in_rowScale_, pvk_in_columnScale_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L92~92
    #if NATIVE
    ES bool isValid(physx::PxHeightFieldGeometry* self){
        bool retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxHeightFieldGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE PxHeightFieldGeometry_ctor( ){
         nat_in_ = ();
        self->PxHeightFieldGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxHeightFieldGeometry_ctor( );
    
    public PxHeightFieldGeometry( ){
         pvk_in_ = ();
        var _new = PxHeightFieldGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE PxHeightFieldGeometry_ctor( ){
         nat_in_ = ();
        self->PxHeightFieldGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxHeightFieldGeometry_ctor( );
    
    public PxHeightFieldGeometry( ){
         pvk_in_ = ();
        var _new = PxHeightFieldGeometry_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxHeightFieldGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxHeightFieldGeometry selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxHeightFieldGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxHeightFieldGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxHeightFieldGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES void ~PxHeightFieldGeometry(physx::PxHeightFieldGeometry* self){
        self->~PxHeightFieldGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxHeightFieldGeometry(PxHeightFieldGeometry selfPtr);
    
    public void ~PxHeightFieldGeometry(){
        ~PxHeightFieldGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
