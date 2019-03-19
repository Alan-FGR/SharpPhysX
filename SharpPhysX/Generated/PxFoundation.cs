#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


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
#if NATIVE //function start
ES physx::PxFoundation* W_PxCreateFoundation_R_PxFoundationPtr_P_uint_P_PxAllocatorCallbackPtr_P_PxErrorCallbackPtr(physx::PxU32 version, physx::PxAllocatorCallback* allocator, physx::PxErrorCallback* errorCallback){
    auto nat_in_version = (version);
    auto nat_in_allocator = (allocator);
    auto nat_in_errorCallback = (errorCallback);
    auto retVal = PxCreateFoundation(nat_in_version, *nat_in_allocator, *nat_in_errorCallback);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundationPtr W_PxCreateFoundation_R_PxFoundationPtr_P_uint_P_PxAllocatorCallbackPtr_P_PxErrorCallbackPtr(uint version, PxAllocatorCallbackPtr allocator, PxErrorCallbackPtr errorCallback);

public static PxFoundationPtr PxCreateFoundation(uint version, PxAllocatorCallbackPtr allocator, PxErrorCallbackPtr errorCallback){
    uint pvk_in_version = (version);
    PxAllocatorCallbackPtr pvk_in_allocator = (allocator);
    PxErrorCallbackPtr pvk_in_errorCallback = (errorCallback);
    PxFoundationPtr retVal = W_PxCreateFoundation_R_PxFoundationPtr_P_uint_P_PxAllocatorCallbackPtr_P_PxErrorCallbackPtr(pvk_in_version, pvk_in_allocator, pvk_in_errorCallback);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       PxGetFoundation                                                        #
//================================================================================
#if NATIVE //function start
ES physx::PxFoundation* W_PxGetFoundation_R_PxFoundationPtr(){
    auto retVal = &PxGetFoundation();
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundationPtr W_PxGetFoundation_R_PxFoundationPtr();

public static PxFoundationPtr PxGetFoundation(){
    PxFoundationPtr retVal = W_PxGetFoundation_R_PxFoundationPtr();
    return retVal;
}
#endif //function end


//================================================================================
//#       PxGetProfilerCallback                                                  #
//================================================================================
/* ERRORS OCCURED: Forbidden return type
// NATIVE SIG: physx::PxProfilerCallback* PX_CALL_CONV PxGetProfilerCallback()
#if NATIVE //function start
ES physx::PxProfilerCallback* W_PxGetProfilerCallback_R_PxProfilerCallbackPtr(){
    auto retVal = PxGetProfilerCallback();
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxProfilerCallbackPtr W_PxGetProfilerCallback_R_PxProfilerCallbackPtr();

public static PxProfilerCallbackPtr PxGetProfilerCallback(){
    PxProfilerCallbackPtr retVal = W_PxGetProfilerCallback_R_PxProfilerCallbackPtr();
    return retVal;
}
#endif //function end*/


//================================================================================
//#       PxSetProfilerCallback                                                  #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxProfilerCallbackPtr
// NATIVE SIG: void PX_CALL_CONV PxSetProfilerCallback(physx::PxProfilerCallback* profiler)
#if NATIVE //function start
ES void W_PxSetProfilerCallback_R_void_P_PxProfilerCallbackPtr(physx::PxProfilerCallback* profiler){
    auto nat_in_profiler = (profiler);
    PxSetProfilerCallback(nat_in_profiler);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxSetProfilerCallback_R_void_P_PxProfilerCallbackPtr(PxProfilerCallbackPtr profiler);

public static void PxSetProfilerCallback(PxProfilerCallbackPtr profiler){
    PxProfilerCallbackPtr pvk_in_profiler = (profiler);
    W_PxSetProfilerCallback_R_void_P_PxProfilerCallbackPtr(pvk_in_profiler);
}
#endif //function end*/

#if !NATIVE
} // End PxFoundation
#endif


#if !NATIVE //interface
public unsafe interface IPxFoundationPtr {
     void release();
    // PxErrorCallbackPtr getErrorCallback();
     void setErrorLevel();
     void setErrorLevel(PxErrorCode mask);
     PxErrorCode getErrorLevel();
    // PxAllocatorCallbackPtr getAllocatorCallback();
     bool getReportAllocationNames();
     void setReportAllocationNames(bool value);
    // UNPARSED_TYPE ~PxFoundation(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxFoundationPtr lhs, /*NULLPARS*/);
    // PxFoundation(/*NULLPARS*/);
    // PxFoundation(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxFoundationPtr : IPxFoundationPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxFoundationPtr
    #endif //hierarchy
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxFoundation(physx::PxFoundation* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxFoundation(PxFoundationPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxFoundation(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getErrorCallback                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxErrorCallback& getErrorCallback() = 0
    #if NATIVE //function start
    ES physx::PxErrorCallback* W_getErrorCallback_R_PxErrorCallbackPtr_C_PxFoundation(physx::PxFoundation* self){
        auto retVal = &self->getErrorCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxErrorCallbackPtr W_getErrorCallback_R_PxErrorCallbackPtr_C_PxFoundation(PxFoundationPtr selfPtr);
    
    public  PxErrorCallbackPtr getErrorCallback(){
        PxErrorCallbackPtr retVal = W_getErrorCallback_R_PxErrorCallbackPtr_C_PxFoundation(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setErrorLevel                                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_setErrorLevel_R_void_P_PxErrorCode_C_PxFoundation(physx::PxFoundation* self, physx::PxErrorCode::Enum mask){
        auto nat_in_mask = (mask);
        self->setErrorLevel(nat_in_mask);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setErrorLevel_R_void_P_PxErrorCode_C_PxFoundation(PxFoundationPtr selfPtr, PxErrorCode mask);
    
    public  void setErrorLevel(PxErrorCode mask){
        PxErrorCode pvk_in_mask = (mask);
        W_setErrorLevel_R_void_P_PxErrorCode_C_PxFoundation(this, pvk_in_mask);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_setErrorLevel_R_void_OL1_C_PxFoundation(physx::PxFoundation* self){
        self->setErrorLevel();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setErrorLevel_R_void_OL1_C_PxFoundation(PxFoundationPtr selfPtr);
    
    public  void setErrorLevel(){
        W_setErrorLevel_R_void_OL1_C_PxFoundation(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       getErrorLevel                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxErrorCode::Enum W_getErrorLevel_R_PxErrorCode_C_PxFoundation(physx::PxFoundation* self){
        auto retVal = self->getErrorLevel();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxErrorCode W_getErrorLevel_R_PxErrorCode_C_PxFoundation(PxFoundationPtr selfPtr);
    
    public  PxErrorCode getErrorLevel(){
        PxErrorCode retVal = W_getErrorLevel_R_PxErrorCode_C_PxFoundation(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getAllocatorCallback                                                   #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxAllocatorCallback& getAllocatorCallback() = 0
    #if NATIVE //function start
    ES physx::PxAllocatorCallback* W_getAllocatorCallback_R_PxAllocatorCallbackPtr_C_PxFoundation(physx::PxFoundation* self){
        auto retVal = &self->getAllocatorCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAllocatorCallbackPtr W_getAllocatorCallback_R_PxAllocatorCallbackPtr_C_PxFoundation(PxFoundationPtr selfPtr);
    
    public  PxAllocatorCallbackPtr getAllocatorCallback(){
        PxAllocatorCallbackPtr retVal = W_getAllocatorCallback_R_PxAllocatorCallbackPtr_C_PxFoundation(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getReportAllocationNames                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_getReportAllocationNames_R_bool_C_PxFoundation(physx::PxFoundation* self){
        auto retVal = self->getReportAllocationNames();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getReportAllocationNames_R_bool_C_PxFoundation(PxFoundationPtr selfPtr);
    
    public  bool getReportAllocationNames(){
        bool retVal = W_getReportAllocationNames_R_bool_C_PxFoundation(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setReportAllocationNames                                               #
    //================================================================================
    #if NATIVE //function start
    ES void W_setReportAllocationNames_R_void_P_bool_C_PxFoundation(physx::PxFoundation* self, bool value){
        auto nat_in_value = (value);
        self->setReportAllocationNames(nat_in_value);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setReportAllocationNames_R_void_P_bool_C_PxFoundation(PxFoundationPtr selfPtr, bool value);
    
    public  void setReportAllocationNames(bool value){
        bool pvk_in_value = (value);
        W_setReportAllocationNames_R_void_P_bool_C_PxFoundation(this, pvk_in_value);
    }
    #endif //function end
    
    
    //Skipped protected: ~PxFoundation
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxFoundation
    
    //Skipped generated implicit entry: PxFoundation
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxProfilerCallback Manually Ignored