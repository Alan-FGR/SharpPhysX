#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



// Class physx::PxBaseTask Manually Ignored
#if !NATIVE
public unsafe interface IPxTaskPtr {
    // PxTask();
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
    // PxTask(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxTaskPtr lhs, /*NULLPARS*/);
    
}

public unsafe partial struct PxTaskPtr : IPxBaseTaskPtr, IPxTaskPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxBaseTaskPtr, PxTaskPtr
    public static implicit operator PxBaseTaskPtr(PxTaskPtr obj){return *(PxBaseTaskPtr*)&obj;}
    public static explicit operator PxTaskPtr(PxBaseTaskPtr obj){return *(PxTaskPtr*)&obj;}
    
    // ### Piping
    
    // --- PxBaseTaskPtr
    //public  void ~PxBaseTask(){((PxBaseTaskPtr)this).~PxBaseTask();}
    public  void run(){((PxBaseTaskPtr)this).run();}
    public  IntPtr getName(){return ((PxBaseTaskPtr)this).getName();}
    //public  PxBaseTask(){((PxBaseTaskPtr)this).PxBaseTask();}
    //public  PxTaskManagerPtr getTaskManager(){return ((PxBaseTaskPtr)this).getTaskManager();}
    public  void setContextId(ulong id){((PxBaseTaskPtr)this).setContextId(id);}
    public  ulong getContextId(){return ((PxBaseTaskPtr)this).getContextId();}
    //public static UNPARSED_TYPE operator=(PxBaseTaskPtr lhs, /*NULLPARS*/){return ((PxBaseTaskPtr)this).operator=(/*NULLARGS*/);}
    //public  PxBaseTask(/*NULLPARS*/){((PxBaseTaskPtr)this).PxBaseTask(/*NULLARGS*/);}
    

    //================================================================================
    //#       PxTask                                                                 #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxTask
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       ~PxTask                                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxTask() {}
    #if NATIVE
    ES void W_~PxTask(physx::PxTask* self){
        self->~PxTask();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxTask(PxTaskPtr selfPtr);
    
    public  void ~PxTask(){
        W_~PxTask(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxTask* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxTaskPtr selfPtr);
    
    public  void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       finishBefore                                                           #
    //================================================================================
    #if NATIVE
    ES void W_finishBefore(physx::PxTask* self, physx::PxTaskID taskID){
        auto nat_in_taskID = (taskID);
        self->finishBefore(nat_in_taskID);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_finishBefore(PxTaskPtr selfPtr, uint taskID);
    
    public  void finishBefore(uint taskID){
        uint pvk_in_taskID = (taskID);
        W_finishBefore(this, pvk_in_taskID);
    }
    #endif
    
    
    //================================================================================
    //#       startAfter                                                             #
    //================================================================================
    #if NATIVE
    ES void W_startAfter(physx::PxTask* self, physx::PxTaskID taskID){
        auto nat_in_taskID = (taskID);
        self->startAfter(nat_in_taskID);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_startAfter(PxTaskPtr selfPtr, uint taskID);
    
    public  void startAfter(uint taskID){
        uint pvk_in_taskID = (taskID);
        W_startAfter(this, pvk_in_taskID);
    }
    #endif
    
    
    //================================================================================
    //#       addReference                                                           #
    //================================================================================
    #if NATIVE
    ES void W_addReference(physx::PxTask* self){
        self->addReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addReference(PxTaskPtr selfPtr);
    
    public  void addReference(){
        W_addReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       removeReference                                                        #
    //================================================================================
    #if NATIVE
    ES void W_removeReference(physx::PxTask* self){
        self->removeReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeReference(PxTaskPtr selfPtr);
    
    public  void removeReference(){
        W_removeReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReference                                                           #
    //================================================================================
    #if NATIVE
    ES ::int32_t W_getReference(physx::PxTask* self){
        auto retVal = self->getReference();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern int W_getReference(PxTaskPtr selfPtr);
    
    public  int getReference(){
        int retVal = W_getReference(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTaskID                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxTaskID W_getTaskID(physx::PxTask* self){
        auto retVal = self->getTaskID();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getTaskID(PxTaskPtr selfPtr);
    
    public  uint getTaskID(){
        uint retVal = W_getTaskID(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       submitted                                                              #
    //================================================================================
    #if NATIVE
    ES void W_submitted(physx::PxTask* self){
        self->submitted();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_submitted(PxTaskPtr selfPtr);
    
    public  void submitted(){
        W_submitted(this);
    }
    #endif
    
    
    //================================================================================
    //#       requestSyncPoint                                                       #
    //================================================================================
    #if NATIVE
    ES void W_requestSyncPoint(physx::PxTask* self){
        self->requestSyncPoint();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_requestSyncPoint(PxTaskPtr selfPtr);
    
    public  void requestSyncPoint(){
        W_requestSyncPoint(this);
    }
    #endif
    
    
    //Skipped generated implicit entry: PxTask
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe interface IPxLightCpuTaskPtr {
    // PxLightCpuTask();
    // void ~PxLightCpuTask();
    // void setContinuation(PxTaskManagerPtr tm, PxBaseTaskPtr c);
    // void setContinuation(PxBaseTaskPtr c);
    // PxBaseTaskPtr getContinuation();
     void removeReference();
     int getReference();
     void addReference();
     void release();
    // PxLightCpuTask(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxLightCpuTaskPtr lhs, /*NULLPARS*/);
    
}

public unsafe partial struct PxLightCpuTaskPtr : IPxBaseTaskPtr, IPxLightCpuTaskPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxBaseTaskPtr, PxLightCpuTaskPtr
    public static implicit operator PxBaseTaskPtr(PxLightCpuTaskPtr obj){return *(PxBaseTaskPtr*)&obj;}
    public static explicit operator PxLightCpuTaskPtr(PxBaseTaskPtr obj){return *(PxLightCpuTaskPtr*)&obj;}
    
    // ### Piping
    
    // --- PxBaseTaskPtr
    //public  void ~PxBaseTask(){((PxBaseTaskPtr)this).~PxBaseTask();}
    public  void run(){((PxBaseTaskPtr)this).run();}
    public  IntPtr getName(){return ((PxBaseTaskPtr)this).getName();}
    //public  PxBaseTask(){((PxBaseTaskPtr)this).PxBaseTask();}
    //public  PxTaskManagerPtr getTaskManager(){return ((PxBaseTaskPtr)this).getTaskManager();}
    public  void setContextId(ulong id){((PxBaseTaskPtr)this).setContextId(id);}
    public  ulong getContextId(){return ((PxBaseTaskPtr)this).getContextId();}
    //public static UNPARSED_TYPE operator=(PxBaseTaskPtr lhs, /*NULLPARS*/){return ((PxBaseTaskPtr)this).operator=(/*NULLARGS*/);}
    //public  PxBaseTask(/*NULLPARS*/){((PxBaseTaskPtr)this).PxBaseTask(/*NULLARGS*/);}
    

    //================================================================================
    //#       PxLightCpuTask                                                         #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxLightCpuTask
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       ~PxLightCpuTask                                                        #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxLightCpuTask()
    	{
    		mTm = NULL;
    	}
    #if NATIVE
    ES void W_~PxLightCpuTask(physx::PxLightCpuTask* self){
        self->~PxLightCpuTask();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxLightCpuTask(PxLightCpuTaskPtr selfPtr);
    
    public  void ~PxLightCpuTask(){
        W_~PxLightCpuTask(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       setContinuation                                                        #
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
    #if NATIVE
    ES void W_setContinuation(physx::PxLightCpuTask* self, physx::PxTaskManager* tm, physx::PxBaseTask* c){
        auto nat_in_tm = (tm);
        auto nat_in_c = (c);
        self->setContinuation(*nat_in_tm, nat_in_c);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContinuation(PxLightCpuTaskPtr selfPtr, PxTaskManagerPtr tm, PxBaseTaskPtr c);
    
    public  void setContinuation(PxTaskManagerPtr tm, PxBaseTaskPtr c){
        PxTaskManagerPtr pvk_in_tm = (tm);
        PxBaseTaskPtr pvk_in_c = (c);
        W_setContinuation(this, pvk_in_tm, pvk_in_c);
    }
    #endif*/
    
    
    //================================================================================
    //#       setContinuation                                                        #
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
    #if NATIVE
    ES void W_setContinuation(physx::PxLightCpuTask* self, physx::PxBaseTask* c){
        auto nat_in_c = (c);
        self->setContinuation(nat_in_c);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContinuation(PxLightCpuTaskPtr selfPtr, PxBaseTaskPtr c);
    
    public  void setContinuation(PxBaseTaskPtr c){
        PxBaseTaskPtr pvk_in_c = (c);
        W_setContinuation(this, pvk_in_c);
    }
    #endif*/
    
    
    //================================================================================
    //#       getContinuation                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxBaseTask*	getContinuation()	const
    	{
    		return mCont;
    	}
    #if NATIVE
    ES physx::PxBaseTask* W_getContinuation(physx::PxLightCpuTask* self){
        auto retVal = self->getContinuation();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBaseTaskPtr W_getContinuation(PxLightCpuTaskPtr selfPtr);
    
    public  PxBaseTaskPtr getContinuation(){
        PxBaseTaskPtr retVal = W_getContinuation(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       removeReference                                                        #
    //================================================================================
    #if NATIVE
    ES void W_removeReference(physx::PxLightCpuTask* self){
        self->removeReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeReference(PxLightCpuTaskPtr selfPtr);
    
    public  void removeReference(){
        W_removeReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReference                                                           #
    //================================================================================
    #if NATIVE
    ES ::int32_t W_getReference(physx::PxLightCpuTask* self){
        auto retVal = self->getReference();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern int W_getReference(PxLightCpuTaskPtr selfPtr);
    
    public  int getReference(){
        int retVal = W_getReference(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       addReference                                                           #
    //================================================================================
    #if NATIVE
    ES void W_addReference(physx::PxLightCpuTask* self){
        self->addReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addReference(PxLightCpuTaskPtr selfPtr);
    
    public  void addReference(){
        W_addReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxLightCpuTask* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxLightCpuTaskPtr selfPtr);
    
    public  void release(){
        W_release(this);
    }
    #endif
    
    
    //Skipped generated implicit entry: PxLightCpuTask
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
