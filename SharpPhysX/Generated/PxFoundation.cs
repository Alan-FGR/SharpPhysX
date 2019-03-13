#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxFoundation { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L62~62
    #if NATIVE
    ES void release(physx::PxFoundation* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void release(PxFoundation selfPtr);
    
    public void release(){
        release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getErrorCallback                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L67~67
    #if NATIVE
    ES UNPARSED_TYPE getErrorCallback(physx::PxFoundation* self){
        UNPARSED_TYPE retVal = self->getErrorCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getErrorCallback(PxFoundation selfPtr);
    
    public UNPARSED_TYPE getErrorCallback(){
        UNPARSED_TYPE retVal = getErrorCallback(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setErrorLevel                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L72~72
    #if NATIVE
    ES void setErrorLevel(physx::PxFoundation* self, physx::PxErrorCode::Enum mask){
        physx::PxErrorCode::Enum nat_in_mask = (mask);
        self->setErrorLevel(nat_in_mask);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setErrorLevel(PxFoundation selfPtr, PxErrorCode mask);
    
    public void setErrorLevel(PxErrorCode mask){
        PxErrorCode pvk_in_mask = (mask);
        setErrorLevel(this, pvk_in_mask);
    }
    #endif
    
    
    //================================================================================
    //#       getErrorLevel                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L77~77
    #if NATIVE
    ES physx::PxErrorCode::Enum getErrorLevel(physx::PxFoundation* self){
        physx::PxErrorCode::Enum retVal = self->getErrorLevel();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxErrorCode getErrorLevel(PxFoundation selfPtr);
    
    public PxErrorCode getErrorLevel(){
        PxErrorCode retVal = getErrorLevel(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getAllocatorCallback                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE getAllocatorCallback(physx::PxFoundation* self){
        UNPARSED_TYPE retVal = self->getAllocatorCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getAllocatorCallback(PxFoundation selfPtr);
    
    public UNPARSED_TYPE getAllocatorCallback(){
        UNPARSED_TYPE retVal = getAllocatorCallback(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getReportAllocationNames                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L87~87
    #if NATIVE
    ES bool getReportAllocationNames(physx::PxFoundation* self){
        bool retVal = self->getReportAllocationNames();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getReportAllocationNames(PxFoundation selfPtr);
    
    public bool getReportAllocationNames(){
        bool retVal = getReportAllocationNames(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setReportAllocationNames                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L93~93
    #if NATIVE
    ES void setReportAllocationNames(physx::PxFoundation* self, bool value){
        bool nat_in_value = (value);
        self->setReportAllocationNames(nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setReportAllocationNames(PxFoundation selfPtr, bool value);
    
    public void setReportAllocationNames(bool value){
        bool pvk_in_value = (value);
        setReportAllocationNames(this, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       ~PxFoundation                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L96~98
    #if NATIVE
    ES void ~PxFoundation(physx::PxFoundation* self){
        self->~PxFoundation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxFoundation(PxFoundation selfPtr);
    
    public void ~PxFoundation(){
        ~PxFoundation(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxFoundation* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxFoundation selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFoundation                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE PxFoundation_ctor(){
        self->PxFoundation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFoundation_ctor();
    
    public PxFoundation(){
        var _new = PxFoundation_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFoundation                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE PxFoundation_ctor( ){
         nat_in_ = ();
        self->PxFoundation(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFoundation_ctor( );
    
    public PxFoundation( ){
         pvk_in_ = ();
        var _new = PxFoundation_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

