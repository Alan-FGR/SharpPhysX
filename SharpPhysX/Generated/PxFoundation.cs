#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxFoundation {
#endif

//================================================================================
//#       PxCreateFoundation                                                     #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxAllocatorCallbackPtr
Forbidden parameter type: PxErrorCallbackPtr
// NATIVE SIG: physx::PxFoundation* PX_CALL_CONV
PxCreateFoundation(physx::PxU32 version, physx::PxAllocatorCallback& allocator, physx::PxErrorCallback& errorCallback)
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
static extern PxFoundationPtr W_PxCreateFoundation(uint version, PxAllocatorCallbackPtr allocator, PxErrorCallbackPtr errorCallback);

public static PxFoundationPtr PxCreateFoundation(uint version, PxAllocatorCallbackPtr allocator, PxErrorCallbackPtr errorCallback){
    uint pvk_in_version = (version);
    PxAllocatorCallbackPtr pvk_in_allocator = (allocator);
    PxErrorCallbackPtr pvk_in_errorCallback = (errorCallback);
    PxFoundationPtr retVal = W_PxCreateFoundation(pvk_in_version, pvk_in_allocator, pvk_in_errorCallback);
    return retVal;
}
#endif*/


//================================================================================
//#       PxGetFoundation                                                        #
//================================================================================
#if NATIVE
ES physx::PxFoundation* W_PxGetFoundation(){
    auto retVal = &PxGetFoundation();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundationPtr W_PxGetFoundation();

public static PxFoundationPtr PxGetFoundation(){
    PxFoundationPtr retVal = W_PxGetFoundation();
    return retVal;
}
#endif


//================================================================================
//#       PxGetProfilerCallback                                                  #
//================================================================================
/* ERRORS OCCURED: Forbidden return type
// NATIVE SIG: physx::PxProfilerCallback* PX_CALL_CONV PxGetProfilerCallback()
#if NATIVE
ES physx::PxProfilerCallback* W_PxGetProfilerCallback(){
    auto retVal = PxGetProfilerCallback();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxProfilerCallbackPtr W_PxGetProfilerCallback();

public static PxProfilerCallbackPtr PxGetProfilerCallback(){
    PxProfilerCallbackPtr retVal = W_PxGetProfilerCallback();
    return retVal;
}
#endif*/


//================================================================================
//#       PxSetProfilerCallback                                                  #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxProfilerCallbackPtr
// NATIVE SIG: void PX_CALL_CONV PxSetProfilerCallback(physx::PxProfilerCallback* profiler)
#if NATIVE
ES void W_PxSetProfilerCallback(physx::PxProfilerCallback* profiler){
    auto nat_in_profiler = (profiler);
    PxSetProfilerCallback(nat_in_profiler);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxSetProfilerCallback(PxProfilerCallbackPtr profiler);

public static void PxSetProfilerCallback(PxProfilerCallbackPtr profiler){
    PxProfilerCallbackPtr pvk_in_profiler = (profiler);
    W_PxSetProfilerCallback(pvk_in_profiler);
}
#endif*/

#if !NATIVE
} // End PxFoundation
#endif


#if !NATIVE
public unsafe partial struct PxFoundationPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxFoundation* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxFoundationPtr selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getErrorCallback                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxErrorCallback& getErrorCallback() = 0
    #if NATIVE
    ES physx::PxErrorCallback* W_getErrorCallback(physx::PxFoundation* self){
        auto retVal = &self->getErrorCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxErrorCallbackPtr W_getErrorCallback(PxFoundationPtr selfPtr);
    
    public PxErrorCallbackPtr getErrorCallback(){
        PxErrorCallbackPtr retVal = W_getErrorCallback(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setErrorLevel                                                          #
    //================================================================================
    #if NATIVE
    ES void W_setErrorLevel(physx::PxFoundation* self, physx::PxErrorCode::Enum mask){
        auto nat_in_mask = (mask);
        self->setErrorLevel(nat_in_mask);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setErrorLevel(PxFoundationPtr selfPtr, PxErrorCode mask);
    
    public void setErrorLevel(PxErrorCode mask){
        PxErrorCode pvk_in_mask = (mask);
        W_setErrorLevel(this, pvk_in_mask);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_setErrorLevel_OL1(physx::PxFoundation* self){
        self->setErrorLevel();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setErrorLevel_OL1(PxFoundationPtr selfPtr);
    
    public void setErrorLevel(){
        W_setErrorLevel_OL1(this);
    }
    #endif
    
    
    
    //================================================================================
    //#       getErrorLevel                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxErrorCode::Enum W_getErrorLevel(physx::PxFoundation* self){
        auto retVal = self->getErrorLevel();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxErrorCode W_getErrorLevel(PxFoundationPtr selfPtr);
    
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
    #if NATIVE
    ES physx::PxAllocatorCallback* W_getAllocatorCallback(physx::PxFoundation* self){
        auto retVal = &self->getAllocatorCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAllocatorCallbackPtr W_getAllocatorCallback(PxFoundationPtr selfPtr);
    
    public PxAllocatorCallbackPtr getAllocatorCallback(){
        PxAllocatorCallbackPtr retVal = W_getAllocatorCallback(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getReportAllocationNames                                               #
    //================================================================================
    #if NATIVE
    ES bool W_getReportAllocationNames(physx::PxFoundation* self){
        auto retVal = self->getReportAllocationNames();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getReportAllocationNames(PxFoundationPtr selfPtr);
    
    public bool getReportAllocationNames(){
        bool retVal = W_getReportAllocationNames(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setReportAllocationNames                                               #
    //================================================================================
    #if NATIVE
    ES void W_setReportAllocationNames(physx::PxFoundation* self, bool value){
        auto nat_in_value = (value);
        self->setReportAllocationNames(nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setReportAllocationNames(PxFoundationPtr selfPtr, bool value);
    
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
    #if NATIVE
    ES void W_~PxFoundation(physx::PxFoundation* self){
        self->~PxFoundation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxFoundation(PxFoundationPtr selfPtr);
    
    public void ~PxFoundation(){
        W_~PxFoundation(this);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxFoundation
    
    //Skipped generated implicit entry: PxFoundation
    

#if !NATIVE
}
#endif

// Class physx::PxProfilerCallback Manually Ignored