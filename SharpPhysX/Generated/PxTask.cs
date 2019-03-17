#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



// Class physx::PxBaseTask Manually Ignored
#if !NATIVE
public unsafe partial struct PxTask { // pointer
    private IntPtr nativePtr_;
#endif

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
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L115~115
    #if NATIVE
    ES void W_~PxTask(physx::PxTask* self){
        self->~PxTask();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxTask(PxTask selfPtr);
    
    public void ~PxTask(){
        W_~PxTask(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L118~126
    #if NATIVE
    ES void W_release(physx::PxTask* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxTask selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       finishBefore                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L130~134
    #if NATIVE
    ES void W_finishBefore(physx::PxTask* self, physx::PxTaskID taskID){
        auto nat_in_taskID = (taskID);
        self->finishBefore(nat_in_taskID);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_finishBefore(PxTask selfPtr, uint taskID);
    
    public void finishBefore(uint taskID){
        uint pvk_in_taskID = (taskID);
        W_finishBefore(this, pvk_in_taskID);
    }
    #endif
    
    
    //================================================================================
    //#       startAfter                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L138~142
    #if NATIVE
    ES void W_startAfter(physx::PxTask* self, physx::PxTaskID taskID){
        auto nat_in_taskID = (taskID);
        self->startAfter(nat_in_taskID);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_startAfter(PxTask selfPtr, uint taskID);
    
    public void startAfter(uint taskID){
        uint pvk_in_taskID = (taskID);
        W_startAfter(this, pvk_in_taskID);
    }
    #endif
    
    
    //================================================================================
    //#       addReference                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L148~152
    #if NATIVE
    ES void W_addReference(physx::PxTask* self){
        self->addReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addReference(PxTask selfPtr);
    
    public void addReference(){
        W_addReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       removeReference                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L158~162
    #if NATIVE
    ES void W_removeReference(physx::PxTask* self){
        self->removeReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeReference(PxTask selfPtr);
    
    public void removeReference(){
        W_removeReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReference                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L167~170
    #if NATIVE
    ES ::int32_t W_getReference(physx::PxTask* self){
        auto retVal = self->getReference();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern int W_getReference(PxTask selfPtr);
    
    public int getReference(){
        int retVal = W_getReference(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTaskID                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L175~178
    #if NATIVE
    ES physx::PxTaskID W_getTaskID(physx::PxTask* self){
        auto retVal = self->getTaskID();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getTaskID(PxTask selfPtr);
    
    public uint getTaskID(){
        uint retVal = W_getTaskID(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       submitted                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L185~189
    #if NATIVE
    ES void W_submitted(physx::PxTask* self){
        self->submitted();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_submitted(PxTask selfPtr);
    
    public void submitted(){
        W_submitted(this);
    }
    #endif
    
    
    //================================================================================
    //#       requestSyncPoint                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L194~197
    #if NATIVE
    ES void W_requestSyncPoint(physx::PxTask* self){
        self->requestSyncPoint();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_requestSyncPoint(PxTask selfPtr);
    
    public void requestSyncPoint(){
        W_requestSyncPoint(this);
    }
    #endif
    
    
    //Skipped generated implicit entry: PxTask
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxLightCpuTask { // pointer
    private IntPtr nativePtr_;
#endif

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
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L230~233
    #if NATIVE
    ES void W_~PxLightCpuTask(physx::PxLightCpuTask* self){
        self->~PxLightCpuTask();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxLightCpuTask(PxLightCpuTask selfPtr);
    
    public void ~PxLightCpuTask(){
        W_~PxLightCpuTask(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       setContinuation                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxTaskManager
    Forbidden parameter type: PxBaseTask
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
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L244~254
    #if NATIVE
    ES void W_setContinuation(physx::PxLightCpuTask* self, physx::PxTaskManager* tm, physx::PxBaseTask* c){
        auto nat_in_tm = (tm);
        auto nat_in_c = (c);
        self->setContinuation(*nat_in_tm, nat_in_c);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContinuation(PxLightCpuTask selfPtr, PxTaskManager tm, PxBaseTask c);
    
    public void setContinuation(PxTaskManager tm, PxBaseTask c){
        PxTaskManager pvk_in_tm = (tm);
        PxBaseTask pvk_in_c = (c);
        W_setContinuation(this, pvk_in_tm, pvk_in_c);
    }
    #endif*/
    
    
    //================================================================================
    //#       setContinuation                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTask
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
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L263~275
    #if NATIVE
    ES void W_setContinuation(physx::PxLightCpuTask* self, physx::PxBaseTask* c){
        auto nat_in_c = (c);
        self->setContinuation(nat_in_c);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContinuation(PxLightCpuTask selfPtr, PxBaseTask c);
    
    public void setContinuation(PxBaseTask c){
        PxBaseTask pvk_in_c = (c);
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
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L280~283
    #if NATIVE
    ES physx::PxBaseTask* W_getContinuation(physx::PxLightCpuTask* self){
        auto retVal = self->getContinuation();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBaseTask W_getContinuation(PxLightCpuTask selfPtr);
    
    public PxBaseTask getContinuation(){
        PxBaseTask retVal = W_getContinuation(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       removeReference                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L289~292
    #if NATIVE
    ES void W_removeReference(physx::PxLightCpuTask* self){
        self->removeReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeReference(PxLightCpuTask selfPtr);
    
    public void removeReference(){
        W_removeReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReference                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L295~298
    #if NATIVE
    ES ::int32_t W_getReference(physx::PxLightCpuTask* self){
        auto retVal = self->getReference();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern int W_getReference(PxLightCpuTask selfPtr);
    
    public int getReference(){
        int retVal = W_getReference(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       addReference                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L304~307
    #if NATIVE
    ES void W_addReference(physx::PxLightCpuTask* self){
        self->addReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addReference(PxLightCpuTask selfPtr);
    
    public void addReference(){
        W_addReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\task\PxTask.h L314~320
    #if NATIVE
    ES void W_release(physx::PxLightCpuTask* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxLightCpuTask selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //Skipped generated implicit entry: PxLightCpuTask
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
