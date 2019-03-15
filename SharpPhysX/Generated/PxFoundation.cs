#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxFoundation {

//================================================================================
//#       PxCreateFoundation                                                     #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxAllocatorCallback
Forbidden parameter type: PxErrorCallback
// NATIVE SIG: physx::PxFoundation* PX_CALL_CONV
PxCreateFoundation(physx::PxU32 version, physx::PxAllocatorCallback& allocator, physx::PxErrorCallback& errorCallback)
// SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L120~121
#if NATIVE
ES physx::PxFoundation* W_PxCreateFoundation(physx::PxU32 version, physx::PxAllocatorCallback* allocator, physx::PxErrorCallback* errorCallback){
    auto nat_in_version = (version);
    auto nat_in_allocator = (allocator);
    auto nat_in_errorCallback = (errorCallback);
    auto retVal = PxCreateFoundation(nat_in_version, *nat_in_allocator, *nat_in_errorCallback);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundation W_PxCreateFoundation(uint version, PxAllocatorCallback allocator, PxErrorCallback errorCallback);

public static PxFoundation PxCreateFoundation(uint version, PxAllocatorCallback allocator, PxErrorCallback errorCallback){
    uint pvk_in_version = (version);
    PxAllocatorCallback pvk_in_allocator = (allocator);
    PxErrorCallback pvk_in_errorCallback = (errorCallback);
    PxFoundation retVal = W_PxCreateFoundation(pvk_in_version, pvk_in_allocator, pvk_in_errorCallback);
    return retVal;
}
#endif*/


//================================================================================
//#       PxGetFoundation                                                        #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L135~135
#if NATIVE
ES physx::PxFoundation* W_PxGetFoundation(){
    auto retVal = &PxGetFoundation();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundation W_PxGetFoundation();

public static PxFoundation PxGetFoundation(){
    PxFoundation retVal = W_PxGetFoundation();
    return retVal;
}
#endif


//================================================================================
//#       PxGetProfilerCallback                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L150~150
#if NATIVE
ES physx::PxProfilerCallback* W_PxGetProfilerCallback(){
    auto retVal = PxGetProfilerCallback();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxProfilerCallback W_PxGetProfilerCallback();

public static PxProfilerCallback PxGetProfilerCallback(){
    PxProfilerCallback retVal = W_PxGetProfilerCallback();
    return retVal;
}
#endif


//================================================================================
//#       PxSetProfilerCallback                                                  #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L155~155
#if NATIVE
ES void W_PxSetProfilerCallback(physx::PxProfilerCallback* profiler){
    auto nat_in_profiler = (profiler);
    PxSetProfilerCallback(nat_in_profiler);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxSetProfilerCallback(PxProfilerCallback profiler);

public static void PxSetProfilerCallback(PxProfilerCallback profiler){
    PxProfilerCallback pvk_in_profiler = (profiler);
    W_PxSetProfilerCallback(pvk_in_profiler);
}
#endif

} // End PxFoundation


#if !NATIVE
public unsafe partial struct PxFoundation { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L62~62
    #if NATIVE
    ES void W_release(physx::PxFoundation* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxFoundation selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getErrorCallback                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxErrorCallback& getErrorCallback() = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L67~67
    #if NATIVE
    ES physx::PxErrorCallback* W_getErrorCallback(physx::PxFoundation* self){
        auto retVal = &self->getErrorCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxErrorCallback W_getErrorCallback(PxFoundation selfPtr);
    
    public PxErrorCallback getErrorCallback(){
        PxErrorCallback retVal = W_getErrorCallback(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setErrorLevel                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L72~72
    #if NATIVE
    ES void W_setErrorLevel(physx::PxFoundation* self, physx::PxErrorCode::Enum mask){
        auto nat_in_mask = (mask);
        self->setErrorLevel(nat_in_mask);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setErrorLevel(PxFoundation selfPtr, PxErrorCode mask);
    
    public void setErrorLevel(PxErrorCode mask){
        PxErrorCode pvk_in_mask = (mask);
        W_setErrorLevel(this, pvk_in_mask);
    }
    #endif
    
    
    //================================================================================
    //#       getErrorLevel                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L77~77
    #if NATIVE
    ES physx::PxErrorCode::Enum W_getErrorLevel(physx::PxFoundation* self){
        auto retVal = self->getErrorLevel();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxErrorCode W_getErrorLevel(PxFoundation selfPtr);
    
    public PxErrorCode getErrorLevel(){
        PxErrorCode retVal = W_getErrorLevel(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getAllocatorCallback                                                   #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxAllocatorCallback& getAllocatorCallback() = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L82~82
    #if NATIVE
    ES physx::PxAllocatorCallback* W_getAllocatorCallback(physx::PxFoundation* self){
        auto retVal = &self->getAllocatorCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAllocatorCallback W_getAllocatorCallback(PxFoundation selfPtr);
    
    public PxAllocatorCallback getAllocatorCallback(){
        PxAllocatorCallback retVal = W_getAllocatorCallback(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getReportAllocationNames                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L87~87
    #if NATIVE
    ES bool W_getReportAllocationNames(physx::PxFoundation* self){
        auto retVal = self->getReportAllocationNames();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getReportAllocationNames(PxFoundation selfPtr);
    
    public bool getReportAllocationNames(){
        bool retVal = W_getReportAllocationNames(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setReportAllocationNames                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L93~93
    #if NATIVE
    ES void W_setReportAllocationNames(physx::PxFoundation* self, bool value){
        auto nat_in_value = (value);
        self->setReportAllocationNames(nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setReportAllocationNames(PxFoundation selfPtr, bool value);
    
    public void setReportAllocationNames(bool value){
        bool pvk_in_value = (value);
        W_setReportAllocationNames(this, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       ~PxFoundation                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxFoundation()
    	{
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L96~98
    #if NATIVE
    ES void W_~PxFoundation(physx::PxFoundation* self){
        self->~PxFoundation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxFoundation(PxFoundation selfPtr);
    
    public void ~PxFoundation(){
        W_~PxFoundation(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxFoundation
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L50~50
    #if NATIVE
    ES physx::PxFoundation* W_operator=(physx::PxFoundation* self, physx::PxFoundation* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFoundation W_operator=(PxFoundation selfPtr, PxFoundation );
    
    public static PxFoundation operator=(PxFoundation lhs, PxFoundation ){
        PxFoundation pvk_in_ = ();
        PxFoundation retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFoundation                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PxFoundation
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE W_PxFoundation_ctor(){
        self->PxFoundation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFoundation_ctor();
    
    public PxFoundation(){
        var _new = W_PxFoundation_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFoundation                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxFoundation
    // SOURCE: C:\Projects\PhysX\physx\include\PxFoundation.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE W_PxFoundation_ctor(physx::PxFoundation* ){
        auto nat_in_ = ();
        self->PxFoundation(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFoundation_ctor(PxFoundation );
    
    public PxFoundation(PxFoundation ){
        PxFoundation pvk_in_ = ();
        var _new = W_PxFoundation_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

