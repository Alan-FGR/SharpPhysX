#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



// Class physx::PxBaseTask Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxTaskPtr {
    // static PxTaskPtr New();
    // void ~PxTask();
     void release();
     void finishBefore(uint taskID);
     void startAfter(uint taskID);
     void addReference();
     void removeReference();
     int getReference();
     uint getTaskID();
     void submitted();
     void requestSyncPoint();
    // static PxTaskPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxTaskPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxTaskPtr : IPxBaseTaskPtr, IPxTaskPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxTaskPtrPOD{
    physx::PxTaskID mTaskID;
    ::uint32_t mStreamIndex;
    bool mPreSyncRequired;
};
#endif //struct start


    // ### Auto generated getters for fields
    //Skipped non-public field: mTaskID
    //Skipped non-public field: mStreamIndex
    //Skipped non-public field: mPreSyncRequired

    #if !NATIVE //hierarchy
    // Hierarchy: PxBaseTaskPtr, PxTaskPtr
    public static implicit operator PxBaseTaskPtr(PxTaskPtr obj){return *(PxBaseTaskPtr*)&obj;}
    public static explicit operator PxTaskPtr(PxBaseTaskPtr obj){return *(PxTaskPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxBaseTaskPtr
    //public  void ~PxBaseTask(){((PxBaseTaskPtr)this).~PxBaseTask();}
    public  void run(){((PxBaseTaskPtr)this).run();}
    public  string getName(){return ((PxBaseTaskPtr)this).getName();}
    //public  static PxBaseTaskPtr New(){((PxBaseTaskPtr)this).PxBaseTask();}
    //public  PxTaskManagerPtr getTaskManager(){return ((PxBaseTaskPtr)this).getTaskManager();}
    public  void setContextId(ulong id){((PxBaseTaskPtr)this).setContextId(id);}
    public  ulong getContextId(){return ((PxBaseTaskPtr)this).getContextId();}
    //public static UNPARSED_TYPE operator=(PxBaseTaskPtr lhs, /*NULLPARS*/){return ((PxBaseTaskPtr)this).operator=(/*NULLARGS*/);}
    //public  static PxBaseTaskPtr New(/*NULLPARS*/){((PxBaseTaskPtr)this).PxBaseTask(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxTask()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES PxTaskPtrPOD W_PxTask_R_PxTaskPtr_C_PxTask_ctor(){
        auto val = new PxTask();
        return *(PxTaskPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTaskPtr W_PxTask_R_PxTaskPtr_C_PxTask_ctor();
    
    public  static PxTaskPtr New(){
        var _new = W_PxTask_R_PxTaskPtr_C_PxTask_ctor();
        PxTaskPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       ~PxTask()                                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxTask() {}
    #if NATIVE //function start
    ES void W_~PxTask_R_void_C_PxTask(physx::PxTask* self){
        self->~PxTask();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxTask_R_void_C_PxTask(PxTaskPtr selfPtr);
    
    public  void ~PxTask(){
        W_~PxTask_R_void_C_PxTask(this);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       release()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxTask(physx::PxTask* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxTask(PxTaskPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxTask(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       finishBefore(uint taskID)                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_finishBefore_R_void_P_uint_C_PxTask(physx::PxTask* self, physx::PxTaskID taskID){
        auto nat_in_taskID = (taskID);
        self->finishBefore(nat_in_taskID);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_finishBefore_R_void_P_uint_C_PxTask(PxTaskPtr selfPtr, uint taskID);
    
    public  void finishBefore(uint taskID){
        uint pvk_in_taskID = (taskID);
        W_finishBefore_R_void_P_uint_C_PxTask(this, pvk_in_taskID);
    }
    #endif //function end
    
    
    //================================================================================
    //#       startAfter(uint taskID)                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_startAfter_R_void_P_uint_C_PxTask(physx::PxTask* self, physx::PxTaskID taskID){
        auto nat_in_taskID = (taskID);
        self->startAfter(nat_in_taskID);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_startAfter_R_void_P_uint_C_PxTask(PxTaskPtr selfPtr, uint taskID);
    
    public  void startAfter(uint taskID){
        uint pvk_in_taskID = (taskID);
        W_startAfter_R_void_P_uint_C_PxTask(this, pvk_in_taskID);
    }
    #endif //function end
    
    
    //================================================================================
    //#       addReference()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES void W_addReference_R_void_C_PxTask(physx::PxTask* self){
        self->addReference();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addReference_R_void_C_PxTask(PxTaskPtr selfPtr);
    
    public  void addReference(){
        W_addReference_R_void_C_PxTask(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       removeReference()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES void W_removeReference_R_void_C_PxTask(physx::PxTask* self){
        self->removeReference();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeReference_R_void_C_PxTask(PxTaskPtr selfPtr);
    
    public  void removeReference(){
        W_removeReference_R_void_C_PxTask(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getReference()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES ::int32_t W_getReference_R_int_C_PxTask(physx::PxTask* self){
        auto retVal = self->getReference();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern int W_getReference_R_int_C_PxTask(PxTaskPtr selfPtr);
    
    public  int getReference(){
        int retVal = W_getReference_R_int_C_PxTask(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTaskID()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxTaskID W_getTaskID_R_uint_C_PxTask(physx::PxTask* self){
        auto retVal = self->getTaskID();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getTaskID_R_uint_C_PxTask(PxTaskPtr selfPtr);
    
    public  uint getTaskID(){
        uint retVal = W_getTaskID_R_uint_C_PxTask(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       submitted()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void W_submitted_R_void_C_PxTask(physx::PxTask* self){
        self->submitted();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_submitted_R_void_C_PxTask(PxTaskPtr selfPtr);
    
    public  void submitted(){
        W_submitted_R_void_C_PxTask(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       requestSyncPoint()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_requestSyncPoint_R_void_C_PxTask(physx::PxTask* self){
        self->requestSyncPoint();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_requestSyncPoint_R_void_C_PxTask(PxTaskPtr selfPtr);
    
    public  void requestSyncPoint(){
        W_requestSyncPoint_R_void_C_PxTask(this);
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxTask
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxLightCpuTaskPtr {
    // static PxLightCpuTaskPtr New();
    // void ~PxLightCpuTask();
    // void setContinuation(PxTaskManagerPtr tm, PxBaseTaskPtr c);
    // void setContinuation(PxBaseTaskPtr c);
    // PxBaseTaskPtr getContinuation();
     void removeReference();
     int getReference();
     void addReference();
     void release();
    // static PxLightCpuTaskPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxLightCpuTaskPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxLightCpuTaskPtr : IPxBaseTaskPtr, IPxLightCpuTaskPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxLightCpuTaskPtrPOD{
    physx::PxBaseTask* mCont;
    ::int32_t mRefCount;
};
#endif //struct start


    // ### Auto generated getters for fields
    //Skipped non-public field: mCont
    //Skipped non-public field: mRefCount

    #if !NATIVE //hierarchy
    // Hierarchy: PxBaseTaskPtr, PxLightCpuTaskPtr
    public static implicit operator PxBaseTaskPtr(PxLightCpuTaskPtr obj){return *(PxBaseTaskPtr*)&obj;}
    public static explicit operator PxLightCpuTaskPtr(PxBaseTaskPtr obj){return *(PxLightCpuTaskPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxBaseTaskPtr
    //public  void ~PxBaseTask(){((PxBaseTaskPtr)this).~PxBaseTask();}
    public  void run(){((PxBaseTaskPtr)this).run();}
    public  string getName(){return ((PxBaseTaskPtr)this).getName();}
    //public  static PxBaseTaskPtr New(){((PxBaseTaskPtr)this).PxBaseTask();}
    //public  PxTaskManagerPtr getTaskManager(){return ((PxBaseTaskPtr)this).getTaskManager();}
    public  void setContextId(ulong id){((PxBaseTaskPtr)this).setContextId(id);}
    public  ulong getContextId(){return ((PxBaseTaskPtr)this).getContextId();}
    //public static UNPARSED_TYPE operator=(PxBaseTaskPtr lhs, /*NULLPARS*/){return ((PxBaseTaskPtr)this).operator=(/*NULLARGS*/);}
    //public  static PxBaseTaskPtr New(/*NULLPARS*/){((PxBaseTaskPtr)this).PxBaseTask(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxLightCpuTask()                                                       #
    //================================================================================
    #if NATIVE //function start
    ES PxLightCpuTaskPtrPOD W_PxLightCpuTask_R_PxLightCpuTaskPtr_C_PxLightCpuTask_ctor(){
        auto val = new PxLightCpuTask();
        return *(PxLightCpuTaskPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxLightCpuTaskPtr W_PxLightCpuTask_R_PxLightCpuTaskPtr_C_PxLightCpuTask_ctor();
    
    public  static PxLightCpuTaskPtr New(){
        var _new = W_PxLightCpuTask_R_PxLightCpuTaskPtr_C_PxLightCpuTask_ctor();
        PxLightCpuTaskPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       ~PxLightCpuTask()                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxLightCpuTask()
    	{
    		mTm = NULL;
    	}
    #if NATIVE //function start
    ES void W_~PxLightCpuTask_R_void_C_PxLightCpuTask(physx::PxLightCpuTask* self){
        self->~PxLightCpuTask();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxLightCpuTask_R_void_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr);
    
    public  void ~PxLightCpuTask(){
        W_~PxLightCpuTask_R_void_C_PxLightCpuTask(this);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setContinuation(PxTaskManagerPtr tm, PxBaseTaskPtr c)                  #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxTaskManagerPtr
    Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void setContinuation(PxTaskManager& tm, PxBaseTask* c)
    	{
    		PX_ASSERT( mRefCount == 0 );
    		mRefCount = 1;
    		mCont = c;
    		mTm = &tm;
    		if( mCont )
    		{
    			mCont->addReference();
    	    }
    	}
    #if NATIVE //function start
    ES void W_setContinuation_R_void_P_PxTaskManagerPtr_P_PxBaseTaskPtr_C_PxLightCpuTask(physx::PxLightCpuTask* self, physx::PxTaskManager* tm, physx::PxBaseTask* c){
        auto nat_in_tm = (tm);
        auto nat_in_c = (c);
        self->setContinuation(*nat_in_tm, nat_in_c);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContinuation_R_void_P_PxTaskManagerPtr_P_PxBaseTaskPtr_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr, PxTaskManagerPtr tm, PxBaseTaskPtr c);
    
    public  void setContinuation(PxTaskManagerPtr tm, PxBaseTaskPtr c){
        PxTaskManagerPtr pvk_in_tm = (tm);
        PxBaseTaskPtr pvk_in_c = (c);
        W_setContinuation_R_void_P_PxTaskManagerPtr_P_PxBaseTaskPtr_C_PxLightCpuTask(this, pvk_in_tm, pvk_in_c);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setContinuation(PxBaseTaskPtr c)                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void setContinuation( PxBaseTask* c )
    	{
    		PX_ASSERT( c );
    		PX_ASSERT( mRefCount == 0 );
    		mRefCount = 1;
    		mCont = c;
    		if( mCont )
    		{
    			mCont->addReference();
    			mTm = mCont->getTaskManager();
    			PX_ASSERT( mTm );
    		}
    	}
    #if NATIVE //function start
    ES void W_setContinuation_R_void_P_PxBaseTaskPtr_C_PxLightCpuTask(physx::PxLightCpuTask* self, physx::PxBaseTask* c){
        auto nat_in_c = (c);
        self->setContinuation(nat_in_c);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContinuation_R_void_P_PxBaseTaskPtr_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr, PxBaseTaskPtr c);
    
    public  void setContinuation(PxBaseTaskPtr c){
        PxBaseTaskPtr pvk_in_c = (c);
        W_setContinuation_R_void_P_PxBaseTaskPtr_C_PxLightCpuTask(this, pvk_in_c);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getContinuation()                                                      #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxBaseTask*	getContinuation()	const
    	{
    		return mCont;
    	}
    #if NATIVE //function start
    ES const physx::PxBaseTask* W_getContinuation_R_PxBaseTaskPtr_C_PxLightCpuTask(physx::PxLightCpuTask* self){
        auto retVal = self->getContinuation();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBaseTaskPtr W_getContinuation_R_PxBaseTaskPtr_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr);
    
    public  PxBaseTaskPtr getContinuation(){
        PxBaseTaskPtr retVal = W_getContinuation_R_PxBaseTaskPtr_C_PxLightCpuTask(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       removeReference()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES void W_removeReference_R_void_C_PxLightCpuTask(physx::PxLightCpuTask* self){
        self->removeReference();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeReference_R_void_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr);
    
    public  void removeReference(){
        W_removeReference_R_void_C_PxLightCpuTask(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getReference()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES ::int32_t W_getReference_R_int_C_PxLightCpuTask(physx::PxLightCpuTask* self){
        auto retVal = self->getReference();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern int W_getReference_R_int_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr);
    
    public  int getReference(){
        int retVal = W_getReference_R_int_C_PxLightCpuTask(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       addReference()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES void W_addReference_R_void_C_PxLightCpuTask(physx::PxLightCpuTask* self){
        self->addReference();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addReference_R_void_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr);
    
    public  void addReference(){
        W_addReference_R_void_C_PxLightCpuTask(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       release()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxLightCpuTask(physx::PxLightCpuTask* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxLightCpuTask(PxLightCpuTaskPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxLightCpuTask(this);
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxLightCpuTask
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
