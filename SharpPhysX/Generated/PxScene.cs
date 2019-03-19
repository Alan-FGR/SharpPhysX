#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxActorTypeFlag : int {
    eRIGID_STATIC = 1,  // eRIGID_STATIC = (1 << 0)
    eRIGID_DYNAMIC = 2, // eRIGID_DYNAMIC = (1 << 1)
}
#endif //enum

#if !NATIVE
public partial struct PxScene {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorTypeFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag_P_PxActorTypeFlag(physx::PxActorTypeFlag::Enum a, physx::PxActorTypeFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag_P_PxActorTypeFlag(PxActorTypeFlag a, PxActorTypeFlag b);

public static UNPARSED_TYPE operator|(PxActorTypeFlag a, PxActorTypeFlag b){
    PxActorTypeFlag pvk_in_a = (a);
    PxActorTypeFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag_P_PxActorTypeFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorTypeFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag_P_PxActorTypeFlag(physx::PxActorTypeFlag::Enum a, physx::PxActorTypeFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag_P_PxActorTypeFlag(PxActorTypeFlag a, PxActorTypeFlag b);

public static UNPARSED_TYPE operator&(PxActorTypeFlag a, PxActorTypeFlag b){
    PxActorTypeFlag pvk_in_a = (a);
    PxActorTypeFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag_P_PxActorTypeFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorTypeFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag(physx::PxActorTypeFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag(PxActorTypeFlag a);

public static UNPARSED_TYPE operator~(PxActorTypeFlag a){
    PxActorTypeFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxActorTypeFlag_ushort_P_PxActorTypeFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxScene
#endif


// Class physx::PxAggregate Manually Ignored
// Class physx::PxBVHStructure Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxScenePtr {
    // PxScene(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxScene(/*NULLPARS*/);
     void release();
     void setFlag(PxSceneFlag flag, bool value);
    // UNPARSED_TYPE getFlags();
     void setLimits(PxSceneLimitsPtr limits);
    // UNPARSED_TYPE getLimits();
     PxPhysicsPtr getPhysics();
     uint getTimestamp();
    // void addArticulation(PxArticulationBasePtr articulation);
    // void removeArticulation(PxArticulationBasePtr articulation);
    // void removeArticulation(PxArticulationBasePtr articulation, bool wakeOnLostTouch);
     void addActor(PxActorPtr actor);
    // void addActor(PxActorPtr actor, PxBVHStructurePtr bvhStructure);
    // void addActors( actors, uint nbActors);
    // void addActors(PxPruningStructurePtr pruningStructure);
     void removeActor(PxActorPtr actor);
     void removeActor(PxActorPtr actor, bool wakeOnLostTouch);
    // void removeActors( actors, uint nbActors);
    // void removeActors( actors, uint nbActors, bool wakeOnLostTouch);
    // void addAggregate(PxAggregatePtr aggregate);
    // void removeAggregate(PxAggregatePtr aggregate);
    // void removeAggregate(PxAggregatePtr aggregate, bool wakeOnLostTouch);
    // void addCollection(PxCollectionPtr collection);
    // uint getNbActors( types);
    // uint getActors( types,  userBuffer, uint bufferSize);
    // uint getActors( types,  userBuffer, uint bufferSize, uint startIndex);
    // UNPARSED_TYPE getActiveActors(uint* nbActorsOut);
     uint getNbArticulations();
    // uint getArticulations( userBuffer, uint bufferSize);
    // uint getArticulations( userBuffer, uint bufferSize, uint startIndex);
     uint getNbConstraints();
    // uint getConstraints( userBuffer, uint bufferSize);
    // uint getConstraints( userBuffer, uint bufferSize, uint startIndex);
     uint getNbAggregates();
    // uint getAggregates( userBuffer, uint bufferSize);
    // uint getAggregates( userBuffer, uint bufferSize, uint startIndex);
     void setDominanceGroupPair(byte group1, byte group2, PxDominanceGroupPairPtr dominance);
    // UNPARSED_TYPE getDominanceGroupPair(byte group1, byte group2);
    // PxCpuDispatcherPtr getCpuDispatcher();
    // PxGpuDispatcherPtr getGpuDispatcher();
     byte createClient();
    // void setSimulationEventCallback(PxSimulationEventCallbackPtr callback);
    // PxSimulationEventCallbackPtr getSimulationEventCallback();
    // void setContactModifyCallback(PxContactModifyCallbackPtr callback);
    // void setCCDContactModifyCallback(PxCCDContactModifyCallbackPtr callback);
    // PxContactModifyCallbackPtr getContactModifyCallback();
    // PxCCDContactModifyCallbackPtr getCCDContactModifyCallback();
    // void setBroadPhaseCallback(PxBroadPhaseCallbackPtr callback);
    // PxBroadPhaseCallbackPtr getBroadPhaseCallback();
     void setFilterShaderData(IntPtr data, uint dataSize);
     IntPtr getFilterShaderData();
     uint getFilterShaderDataSize();
    // UNPARSED_TYPE getFilterShader();
     PxSimulationFilterCallbackPtr getFilterCallback();
     void resetFiltering(PxActorPtr actor);
    // void resetFiltering(PxRigidActorPtr actor,  shapes, uint shapeCount);
    // void simulate(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize);
    // void simulate(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock);
    // void simulate(float elapsedTime, PxBaseTaskPtr completionTask);
     void simulate(float elapsedTime);
    // void simulate(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize, bool controlSimulation);
     void advance();
    // void advance(PxBaseTaskPtr completionTask);
    // void collide(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize);
    // void collide(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock);
    // void collide(float elapsedTime, PxBaseTaskPtr completionTask);
     void collide(float elapsedTime);
    // void collide(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize, bool controlSimulation);
     bool checkResults();
     bool checkResults(bool block);
     bool fetchCollision();
     bool fetchCollision(bool block);
     bool fetchResults(bool block);
     bool fetchResults();
     bool fetchResults(bool block, uint* errorState);
    // bool fetchResultsStart( contactPairs, uint* nbContactPairs);
    // bool fetchResultsStart( contactPairs, uint* nbContactPairs, bool block);
    // void processCallbacks(PxBaseTaskPtr continuation);
     void fetchResultsFinish();
     void fetchResultsFinish(uint* errorState);
     void flushSimulation();
     void flushSimulation(bool sendPendingReports);
     void setGravity(PxVec3 vec);
     PxVec3 getGravity();
     void setBounceThresholdVelocity(float t);
     float getBounceThresholdVelocity();
     void setCCDMaxPasses(uint ccdMaxPasses);
     uint getCCDMaxPasses();
     float getFrictionOffsetThreshold();
     void setFrictionType(PxFrictionType frictionType);
     PxFrictionType getFrictionType();
    // bool setVisualizationParameter(PxVisualizationParameter param, float value);
    // float getVisualizationParameter(PxVisualizationParameter paramEnum);
     void setVisualizationCullingBox(PxBounds3 box);
     PxBounds3 getVisualizationCullingBox();
    // PxRenderBufferPtr getRenderBuffer();
    // void getSimulationStatistics(PxSimulationStatisticsPtr stats);
     PxPruningStructureType getStaticStructure();
     PxPruningStructureType getDynamicStructure();
     void flushQueryUpdates();
    // PxBatchQueryPtr createBatchQuery(PxBatchQueryDescPtr desc);
     void setDynamicTreeRebuildRateHint(uint dynamicTreeRebuildRateHint);
     uint getDynamicTreeRebuildRateHint();
     void forceDynamicTreeRebuild(bool rebuildStaticStructure, bool rebuildDynamicStructure);
     void setSceneQueryUpdateMode(PxSceneQueryUpdateMode updateMode);
     PxSceneQueryUpdateMode getSceneQueryUpdateMode();
    // void sceneQueriesUpdate(PxBaseTaskPtr completionTask);
     void sceneQueriesUpdate();
    // void sceneQueriesUpdate(PxBaseTaskPtr completionTask, bool controlSimulation);
     bool checkQueries();
     bool checkQueries(bool block);
     bool fetchQueries();
     bool fetchQueries(bool block);
    // bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall);
    // bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData);
    // bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags);
    // bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall);
    // bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache);
    // bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache);
    // bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall);
    // bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData);
    // bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags);
    // bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall);
    // bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache, float inflation);
    // bool overlap(PxGeometryPtr geometry, PxTransform pose,  hitCall, PxQueryFilterDataPtr filterData);
    // bool overlap(PxGeometryPtr geometry, PxTransform pose,  hitCall);
    // bool overlap(PxGeometryPtr geometry, PxTransform pose,  hitCall, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall);
     uint getSceneQueryStaticTimestamp();
    // PxBroadPhaseType getBroadPhaseType();
    // bool getBroadPhaseCaps( caps);
     uint getNbBroadPhaseRegions();
    // uint getBroadPhaseRegions(PxBroadPhaseRegionInfoPtr userBuffer, uint bufferSize);
    // uint getBroadPhaseRegions(PxBroadPhaseRegionInfoPtr userBuffer, uint bufferSize, uint startIndex);
    // uint addBroadPhaseRegion(PxBroadPhaseRegionPtr region);
    // uint addBroadPhaseRegion(PxBroadPhaseRegionPtr region, bool populateRegion);
     bool removeBroadPhaseRegion(uint handle);
    // PxTaskManagerPtr getTaskManager();
     void lockRead(string file);
     void lockRead();
     void lockRead(string file, uint line);
     void unlockRead();
     void lockWrite(string file);
     void lockWrite();
     void lockWrite(string file, uint line);
     void unlockWrite();
     void setNbContactDataBlocks(uint numBlocks);
     uint getNbContactDataBlocksUsed();
     uint getMaxNbContactDataBlocksUsed();
     uint getContactReportStreamBufferSize();
     void setSolverBatchSize(uint solverBatchSize);
     uint getSolverBatchSize();
     float getWakeCounterResetValue();
     void shiftOrigin(PxVec3 shift);
    // PxPvdSceneClientPtr getScenePvdClient();
    //static UNPARSED_TYPE operator=(PxScenePtr lhs, /*NULLPARS*/);
    // PxScene(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxScenePtr : IPxScenePtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields

    // ### USERDATA getter/setter
    #if NATIVE //getter
    ES void* PxScene_GET_userData(PxScene* self) {return self->userData;}
    ES void PxScene_SET_userData(PxScene* self, void* value) {self->userData = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr PxScene_GET_userData(PxScenePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxScene_SET_userData(PxScenePtr selfPtr, IntPtr value);

    public IntPtr userData {
        get => PxScene_GET_userData(this);
        set => PxScene_SET_userData(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxScenePtr
    #endif //hierarchy
    //Skipped protected: PxScene
    
    //Skipped protected: ~PxScene
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxScene(physx::PxScene* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxScene(PxScenePtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxScene(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setFlag_R_void_P_PxSceneFlag_P_bool_C_PxScene(physx::PxScene* self, physx::PxSceneFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setFlag(nat_in_flag, nat_in_value);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag_R_void_P_PxSceneFlag_P_bool_C_PxScene(PxScenePtr selfPtr, PxSceneFlag flag, bool value);
    
    public  void setFlag(PxSceneFlag flag, bool value){
        PxSceneFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setFlag_R_void_P_PxSceneFlag_P_bool_C_PxScene(this, pvk_in_flag, pvk_in_value);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxSceneFlags
    // NATIVE SIG: PxSceneFlags	getFlags() const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getFlags_R_Enum, uint>_C_PxScene(physx::PxScene* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags_R_Enum, uint>_C_PxScene(PxScenePtr selfPtr);
    
    public  UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags_R_Enum, uint>_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setLimits                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_setLimits_R_void_P_PxSceneLimitsPtr_C_PxScene(physx::PxScene* self, physx::PxSceneLimits* limits){
        auto nat_in_limits = (limits);
        self->setLimits(*nat_in_limits);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLimits_R_void_P_PxSceneLimitsPtr_C_PxScene(PxScenePtr selfPtr, PxSceneLimitsPtr limits);
    
    public  void setLimits(PxSceneLimitsPtr limits){
        PxSceneLimitsPtr pvk_in_limits = (limits);
        W_setLimits_R_void_P_PxSceneLimitsPtr_C_PxScene(this, pvk_in_limits);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getLimits                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxSceneLimits
    // NATIVE SIG: PxSceneLimits		getLimits() const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getLimits_R_PxSceneLimitsPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getLimits();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getLimits_R_PxSceneLimitsPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  UNPARSED_TYPE getLimits(){
        UNPARSED_TYPE retVal = W_getLimits_R_PxSceneLimitsPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getPhysics                                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxPhysics* W_getPhysics_R_PxPhysicsPtr_C_PxScene(physx::PxScene* self){
        auto retVal = &self->getPhysics();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPhysicsPtr W_getPhysics_R_PxPhysicsPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxPhysicsPtr getPhysics(){
        PxPhysicsPtr retVal = W_getPhysics_R_PxPhysicsPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTimestamp                                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getTimestamp_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getTimestamp();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getTimestamp_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getTimestamp(){
        uint retVal = W_getTimestamp_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       addArticulation                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxArticulationBasePtr
    // NATIVE SIG: void				addArticulation(PxArticulationBase& articulation) = 0
    #if NATIVE //function start
    ES void W_addArticulation_R_void_P_PxArticulationBasePtr_C_PxScene(physx::PxScene* self, physx::PxArticulationBase* articulation){
        auto nat_in_articulation = (articulation);
        self->addArticulation(*nat_in_articulation);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addArticulation_R_void_P_PxArticulationBasePtr_C_PxScene(PxScenePtr selfPtr, PxArticulationBasePtr articulation);
    
    public  void addArticulation(PxArticulationBasePtr articulation){
        PxArticulationBasePtr pvk_in_articulation = (articulation);
        W_addArticulation_R_void_P_PxArticulationBasePtr_C_PxScene(this, pvk_in_articulation);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       removeArticulation                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxArticulationBasePtr
    // NATIVE SIG: void				removeArticulation(PxArticulationBase& articulation, bool wakeOnLostTouch = true) = 0
    #if NATIVE //function start
    ES void W_removeArticulation_R_void_P_PxArticulationBasePtr_P_bool_C_PxScene(physx::PxScene* self, physx::PxArticulationBase* articulation, bool wakeOnLostTouch){
        auto nat_in_articulation = (articulation);
        auto nat_in_wakeOnLostTouch = (wakeOnLostTouch);
        self->removeArticulation(*nat_in_articulation, nat_in_wakeOnLostTouch);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeArticulation_R_void_P_PxArticulationBasePtr_P_bool_C_PxScene(PxScenePtr selfPtr, PxArticulationBasePtr articulation, bool wakeOnLostTouch);
    
    public  void removeArticulation(PxArticulationBasePtr articulation, bool wakeOnLostTouch){
        PxArticulationBasePtr pvk_in_articulation = (articulation);
        bool pvk_in_wakeOnLostTouch = (wakeOnLostTouch);
        W_removeArticulation_R_void_P_PxArticulationBasePtr_P_bool_C_PxScene(this, pvk_in_articulation, pvk_in_wakeOnLostTouch);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxArticulationBasePtr
    // NATIVE SIG: void				removeArticulation(PxArticulationBase& articulation, bool wakeOnLostTouch = true) = 0
    #if NATIVE //function start
    ES void W_removeArticulation_R_void_P_PxArticulationBasePtr_OL1_C_PxScene(physx::PxScene* self, physx::PxArticulationBase* articulation){
        auto nat_in_articulation = (articulation);
        self->removeArticulation(*nat_in_articulation);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeArticulation_R_void_P_PxArticulationBasePtr_OL1_C_PxScene(PxScenePtr selfPtr, PxArticulationBasePtr articulation);
    
    public  void removeArticulation(PxArticulationBasePtr articulation){
        PxArticulationBasePtr pvk_in_articulation = (articulation);
        W_removeArticulation_R_void_P_PxArticulationBasePtr_OL1_C_PxScene(this, pvk_in_articulation);
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       addActor                                                               #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBVHStructurePtr
    // NATIVE SIG: void				addActor(PxActor& actor, const PxBVHStructure* bvhStructure = NULL) = 0
    #if NATIVE //function start
    ES void W_addActor_R_void_P_PxActorPtr_P_PxBVHStructurePtr_C_PxScene(physx::PxScene* self, physx::PxActor* actor, physx::PxBVHStructure* bvhStructure){
        auto nat_in_actor = (actor);
        auto nat_in_bvhStructure = (bvhStructure);
        self->addActor(*nat_in_actor, nat_in_bvhStructure);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addActor_R_void_P_PxActorPtr_P_PxBVHStructurePtr_C_PxScene(PxScenePtr selfPtr, PxActorPtr actor, PxBVHStructurePtr bvhStructure);
    
    public  void addActor(PxActorPtr actor, PxBVHStructurePtr bvhStructure){
        PxActorPtr pvk_in_actor = (actor);
        PxBVHStructurePtr pvk_in_bvhStructure = (bvhStructure);
        W_addActor_R_void_P_PxActorPtr_P_PxBVHStructurePtr_C_PxScene(this, pvk_in_actor, pvk_in_bvhStructure);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_addActor_R_void_P_PxActorPtr_OL1_C_PxScene(physx::PxScene* self, physx::PxActor* actor){
        auto nat_in_actor = (actor);
        self->addActor(*nat_in_actor);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addActor_R_void_P_PxActorPtr_OL1_C_PxScene(PxScenePtr selfPtr, PxActorPtr actor);
    
    public  void addActor(PxActorPtr actor){
        PxActorPtr pvk_in_actor = (actor);
        W_addActor_R_void_P_PxActorPtr_OL1_C_PxScene(this, pvk_in_actor);
    }
    #endif //function end
    
    
    
    
    //================================================================================
    //#       addActors                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxActor*
    // NATIVE SIG: void				addActors(PxActor*const* actors, PxU32 nbActors) = 0
    #if NATIVE //function start
    ES void W_addActors_R_void_P__P_uint_C_PxScene(physx::PxScene* self,  actors, physx::PxU32 nbActors){
        auto nat_in_actors = (actors);
        auto nat_in_nbActors = (nbActors);
        self->addActors(nat_in_actors, nat_in_nbActors);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addActors_R_void_P__P_uint_C_PxScene(PxScenePtr selfPtr,  actors, uint nbActors);
    
    public  void addActors( actors, uint nbActors){
         pvk_in_actors = (actors);
        uint pvk_in_nbActors = (nbActors);
        W_addActors_R_void_P__P_uint_C_PxScene(this, pvk_in_actors, pvk_in_nbActors);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       addActors                                                              #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxPruningStructurePtr
    // NATIVE SIG: void				addActors(const PxPruningStructure& pruningStructure) = 0
    #if NATIVE //function start
    ES void W_addActors_R_void_P_PxPruningStructurePtr_C_PxScene(physx::PxScene* self, physx::PxPruningStructure* pruningStructure){
        auto nat_in_pruningStructure = (pruningStructure);
        self->addActors(*nat_in_pruningStructure);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addActors_R_void_P_PxPruningStructurePtr_C_PxScene(PxScenePtr selfPtr, PxPruningStructurePtr pruningStructure);
    
    public  void addActors(PxPruningStructurePtr pruningStructure){
        PxPruningStructurePtr pvk_in_pruningStructure = (pruningStructure);
        W_addActors_R_void_P_PxPruningStructurePtr_C_PxScene(this, pvk_in_pruningStructure);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       removeActor                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void W_removeActor_R_void_P_PxActorPtr_P_bool_C_PxScene(physx::PxScene* self, physx::PxActor* actor, bool wakeOnLostTouch){
        auto nat_in_actor = (actor);
        auto nat_in_wakeOnLostTouch = (wakeOnLostTouch);
        self->removeActor(*nat_in_actor, nat_in_wakeOnLostTouch);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeActor_R_void_P_PxActorPtr_P_bool_C_PxScene(PxScenePtr selfPtr, PxActorPtr actor, bool wakeOnLostTouch);
    
    public  void removeActor(PxActorPtr actor, bool wakeOnLostTouch){
        PxActorPtr pvk_in_actor = (actor);
        bool pvk_in_wakeOnLostTouch = (wakeOnLostTouch);
        W_removeActor_R_void_P_PxActorPtr_P_bool_C_PxScene(this, pvk_in_actor, pvk_in_wakeOnLostTouch);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_removeActor_R_void_P_PxActorPtr_OL1_C_PxScene(physx::PxScene* self, physx::PxActor* actor){
        auto nat_in_actor = (actor);
        self->removeActor(*nat_in_actor);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeActor_R_void_P_PxActorPtr_OL1_C_PxScene(PxScenePtr selfPtr, PxActorPtr actor);
    
    public  void removeActor(PxActorPtr actor){
        PxActorPtr pvk_in_actor = (actor);
        W_removeActor_R_void_P_PxActorPtr_OL1_C_PxScene(this, pvk_in_actor);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       removeActors                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxActor*
    // NATIVE SIG: void				removeActors(PxActor*const* actors, PxU32 nbActors, bool wakeOnLostTouch = true) = 0
    #if NATIVE //function start
    ES void W_removeActors_R_void_P__P_uint_P_bool_C_PxScene(physx::PxScene* self,  actors, physx::PxU32 nbActors, bool wakeOnLostTouch){
        auto nat_in_actors = (actors);
        auto nat_in_nbActors = (nbActors);
        auto nat_in_wakeOnLostTouch = (wakeOnLostTouch);
        self->removeActors(nat_in_actors, nat_in_nbActors, nat_in_wakeOnLostTouch);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeActors_R_void_P__P_uint_P_bool_C_PxScene(PxScenePtr selfPtr,  actors, uint nbActors, bool wakeOnLostTouch);
    
    public  void removeActors( actors, uint nbActors, bool wakeOnLostTouch){
         pvk_in_actors = (actors);
        uint pvk_in_nbActors = (nbActors);
        bool pvk_in_wakeOnLostTouch = (wakeOnLostTouch);
        W_removeActors_R_void_P__P_uint_P_bool_C_PxScene(this, pvk_in_actors, pvk_in_nbActors, pvk_in_wakeOnLostTouch);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxActor*
    // NATIVE SIG: void				removeActors(PxActor*const* actors, PxU32 nbActors, bool wakeOnLostTouch = true) = 0
    #if NATIVE //function start
    ES void W_removeActors_R_void_P__P_uint_OL1_C_PxScene(physx::PxScene* self,  actors, physx::PxU32 nbActors){
        auto nat_in_actors = (actors);
        auto nat_in_nbActors = (nbActors);
        self->removeActors(nat_in_actors, nat_in_nbActors);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeActors_R_void_P__P_uint_OL1_C_PxScene(PxScenePtr selfPtr,  actors, uint nbActors);
    
    public  void removeActors( actors, uint nbActors){
         pvk_in_actors = (actors);
        uint pvk_in_nbActors = (nbActors);
        W_removeActors_R_void_P__P_uint_OL1_C_PxScene(this, pvk_in_actors, pvk_in_nbActors);
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       addAggregate                                                           #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxAggregatePtr
    // NATIVE SIG: void				addAggregate(PxAggregate& aggregate)	= 0
    #if NATIVE //function start
    ES void W_addAggregate_R_void_P_PxAggregatePtr_C_PxScene(physx::PxScene* self, physx::PxAggregate* aggregate){
        auto nat_in_aggregate = (aggregate);
        self->addAggregate(*nat_in_aggregate);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addAggregate_R_void_P_PxAggregatePtr_C_PxScene(PxScenePtr selfPtr, PxAggregatePtr aggregate);
    
    public  void addAggregate(PxAggregatePtr aggregate){
        PxAggregatePtr pvk_in_aggregate = (aggregate);
        W_addAggregate_R_void_P_PxAggregatePtr_C_PxScene(this, pvk_in_aggregate);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       removeAggregate                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxAggregatePtr
    // NATIVE SIG: void				removeAggregate(PxAggregate& aggregate, bool wakeOnLostTouch = true)	= 0
    #if NATIVE //function start
    ES void W_removeAggregate_R_void_P_PxAggregatePtr_P_bool_C_PxScene(physx::PxScene* self, physx::PxAggregate* aggregate, bool wakeOnLostTouch){
        auto nat_in_aggregate = (aggregate);
        auto nat_in_wakeOnLostTouch = (wakeOnLostTouch);
        self->removeAggregate(*nat_in_aggregate, nat_in_wakeOnLostTouch);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeAggregate_R_void_P_PxAggregatePtr_P_bool_C_PxScene(PxScenePtr selfPtr, PxAggregatePtr aggregate, bool wakeOnLostTouch);
    
    public  void removeAggregate(PxAggregatePtr aggregate, bool wakeOnLostTouch){
        PxAggregatePtr pvk_in_aggregate = (aggregate);
        bool pvk_in_wakeOnLostTouch = (wakeOnLostTouch);
        W_removeAggregate_R_void_P_PxAggregatePtr_P_bool_C_PxScene(this, pvk_in_aggregate, pvk_in_wakeOnLostTouch);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxAggregatePtr
    // NATIVE SIG: void				removeAggregate(PxAggregate& aggregate, bool wakeOnLostTouch = true)	= 0
    #if NATIVE //function start
    ES void W_removeAggregate_R_void_P_PxAggregatePtr_OL1_C_PxScene(physx::PxScene* self, physx::PxAggregate* aggregate){
        auto nat_in_aggregate = (aggregate);
        self->removeAggregate(*nat_in_aggregate);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeAggregate_R_void_P_PxAggregatePtr_OL1_C_PxScene(PxScenePtr selfPtr, PxAggregatePtr aggregate);
    
    public  void removeAggregate(PxAggregatePtr aggregate){
        PxAggregatePtr pvk_in_aggregate = (aggregate);
        W_removeAggregate_R_void_P_PxAggregatePtr_OL1_C_PxScene(this, pvk_in_aggregate);
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       addCollection                                                          #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxCollectionPtr
    // NATIVE SIG: void				addCollection(const PxCollection& collection) = 0
    #if NATIVE //function start
    ES void W_addCollection_R_void_P_PxCollectionPtr_C_PxScene(physx::PxScene* self, physx::PxCollection* collection){
        auto nat_in_collection = (collection);
        self->addCollection(*nat_in_collection);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addCollection_R_void_P_PxCollectionPtr_C_PxScene(PxScenePtr selfPtr, PxCollectionPtr collection);
    
    public  void addCollection(PxCollectionPtr collection){
        PxCollectionPtr pvk_in_collection = (collection);
        W_addCollection_R_void_P_PxCollectionPtr_C_PxScene(this, pvk_in_collection);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbActors                                                            #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxActorTypeFlags
    // NATIVE SIG: PxU32				getNbActors(PxActorTypeFlags types) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getNbActors_R_uint_P__C_PxScene(physx::PxScene* self,  types){
        auto nat_in_types = (types);
        auto retVal = self->getNbActors(nat_in_types);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbActors_R_uint_P__C_PxScene(PxScenePtr selfPtr,  types);
    
    public  uint getNbActors( types){
         pvk_in_types = (types);
        uint retVal = W_getNbActors_R_uint_P__C_PxScene(this, pvk_in_types);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getActors                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxActorTypeFlags
    Unresolved parameter pointee physx::PxActor*
    // NATIVE SIG: PxU32				getActors(PxActorTypeFlags types, PxActor** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getActors_R_uint_P__P__P_uint_P_uint_C_PxScene(physx::PxScene* self,  types,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_types = (types);
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getActors(nat_in_types, nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getActors_R_uint_P__P__P_uint_P_uint_C_PxScene(PxScenePtr selfPtr,  types,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getActors( types,  userBuffer, uint bufferSize, uint startIndex){
         pvk_in_types = (types);
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getActors_R_uint_P__P__P_uint_P_uint_C_PxScene(this, pvk_in_types, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter type physx::PxActorTypeFlags
    Unresolved parameter pointee physx::PxActor*
    // NATIVE SIG: PxU32				getActors(PxActorTypeFlags types, PxActor** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getActors_R_uint_P__P__P_uint_OL1_C_PxScene(physx::PxScene* self,  types,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_types = (types);
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getActors(nat_in_types, nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getActors_R_uint_P__P__P_uint_OL1_C_PxScene(PxScenePtr selfPtr,  types,  userBuffer, uint bufferSize);
    
    public  uint getActors( types,  userBuffer, uint bufferSize){
         pvk_in_types = (types);
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getActors_R_uint_P__P__P_uint_OL1_C_PxScene(this, pvk_in_types, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       getActiveActors                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: ERR_PTR_TO_BLITTABLE TAGTYPE
    // NATIVE SIG: PxActor**		getActiveActors(PxU32& nbActorsOut) = 0
    #if NATIVE //function start
    ES UNPARSED_TYPE W_getActiveActors_R_PxActor_P_uintPtr_C_PxScene(physx::PxScene* self, physx::PxU32& nbActorsOut){
        auto nat_in_nbActorsOut = (nbActorsOut);
        auto retVal = self->getActiveActors(nat_in_nbActorsOut);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getActiveActors_R_PxActor_P_uintPtr_C_PxScene(PxScenePtr selfPtr, uint* nbActorsOut);
    
    public  UNPARSED_TYPE getActiveActors(uint* nbActorsOut){
        uint* pvk_in_nbActorsOut = (nbActorsOut);
        UNPARSED_TYPE retVal = W_getActiveActors_R_PxActor_P_uintPtr_C_PxScene(this, pvk_in_nbActorsOut);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbArticulations                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbArticulations_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getNbArticulations();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbArticulations_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getNbArticulations(){
        uint retVal = W_getNbArticulations_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getArticulations                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxArticulationBase
    Unresolved parameter pointee physx::PxArticulationBase*
    // NATIVE SIG: PxU32				getArticulations(PxArticulationBase** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getArticulations_R_uint_P__P_uint_P_uint_C_PxScene(physx::PxScene* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getArticulations(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getArticulations_R_uint_P__P_uint_P_uint_C_PxScene(PxScenePtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getArticulations( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getArticulations_R_uint_P__P_uint_P_uint_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxArticulationBase
    Unresolved parameter pointee physx::PxArticulationBase*
    // NATIVE SIG: PxU32				getArticulations(PxArticulationBase** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getArticulations_R_uint_P__P_uint_OL1_C_PxScene(physx::PxScene* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getArticulations(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getArticulations_R_uint_P__P_uint_OL1_C_PxScene(PxScenePtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getArticulations( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getArticulations_R_uint_P__P_uint_OL1_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       getNbConstraints                                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbConstraints_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getNbConstraints();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbConstraints_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getNbConstraints(){
        uint retVal = W_getNbConstraints_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConstraints                                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConstraint*
    // NATIVE SIG: PxU32				getConstraints(PxConstraint** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getConstraints_R_uint_P__P_uint_P_uint_C_PxScene(physx::PxScene* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getConstraints(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConstraints_R_uint_P__P_uint_P_uint_C_PxScene(PxScenePtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getConstraints( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getConstraints_R_uint_P__P_uint_P_uint_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConstraint*
    // NATIVE SIG: PxU32				getConstraints(PxConstraint** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getConstraints_R_uint_P__P_uint_OL1_C_PxScene(physx::PxScene* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getConstraints(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConstraints_R_uint_P__P_uint_OL1_C_PxScene(PxScenePtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getConstraints( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getConstraints_R_uint_P__P_uint_OL1_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       getNbAggregates                                                        #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbAggregates_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getNbAggregates();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbAggregates_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getNbAggregates(){
        uint retVal = W_getNbAggregates_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getAggregates                                                          #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxAggregate
    Unresolved parameter pointee physx::PxAggregate*
    // NATIVE SIG: PxU32		getAggregates(PxAggregate** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)	const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getAggregates_R_uint_P__P_uint_P_uint_C_PxScene(physx::PxScene* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getAggregates(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getAggregates_R_uint_P__P_uint_P_uint_C_PxScene(PxScenePtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getAggregates( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getAggregates_R_uint_P__P_uint_P_uint_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxAggregate
    Unresolved parameter pointee physx::PxAggregate*
    // NATIVE SIG: PxU32		getAggregates(PxAggregate** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)	const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getAggregates_R_uint_P__P_uint_OL1_C_PxScene(physx::PxScene* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getAggregates(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getAggregates_R_uint_P__P_uint_OL1_C_PxScene(PxScenePtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getAggregates( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getAggregates_R_uint_P__P_uint_OL1_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       setDominanceGroupPair                                                  #
    //================================================================================
    #if NATIVE //function start
    ES void W_setDominanceGroupPair_R_void_P_byte_P_byte_P_PxDominanceGroupPairPtr_C_PxScene(physx::PxScene* self, physx::PxDominanceGroup group1, physx::PxDominanceGroup group2, physx::PxDominanceGroupPair* dominance){
        auto nat_in_group1 = (group1);
        auto nat_in_group2 = (group2);
        auto nat_in_dominance = (dominance);
        self->setDominanceGroupPair(nat_in_group1, nat_in_group2, *nat_in_dominance);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setDominanceGroupPair_R_void_P_byte_P_byte_P_PxDominanceGroupPairPtr_C_PxScene(PxScenePtr selfPtr, byte group1, byte group2, PxDominanceGroupPairPtr dominance);
    
    public  void setDominanceGroupPair(byte group1, byte group2, PxDominanceGroupPairPtr dominance){
        byte pvk_in_group1 = (group1);
        byte pvk_in_group2 = (group2);
        PxDominanceGroupPairPtr pvk_in_dominance = (dominance);
        W_setDominanceGroupPair_R_void_P_byte_P_byte_P_PxDominanceGroupPairPtr_C_PxScene(this, pvk_in_group1, pvk_in_group2, pvk_in_dominance);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getDominanceGroupPair                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxDominanceGroupPair
    // NATIVE SIG: PxDominanceGroupPair getDominanceGroupPair(PxDominanceGroup group1, PxDominanceGroup group2) const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getDominanceGroupPair_R_PxDominanceGroupPairPtr_P_byte_P_byte_C_PxScene(physx::PxScene* self, physx::PxDominanceGroup group1, physx::PxDominanceGroup group2){
        auto nat_in_group1 = (group1);
        auto nat_in_group2 = (group2);
        auto retVal = self->getDominanceGroupPair(nat_in_group1, nat_in_group2);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getDominanceGroupPair_R_PxDominanceGroupPairPtr_P_byte_P_byte_C_PxScene(PxScenePtr selfPtr, byte group1, byte group2);
    
    public  UNPARSED_TYPE getDominanceGroupPair(byte group1, byte group2){
        byte pvk_in_group1 = (group1);
        byte pvk_in_group2 = (group2);
        UNPARSED_TYPE retVal = W_getDominanceGroupPair_R_PxDominanceGroupPairPtr_P_byte_P_byte_C_PxScene(this, pvk_in_group1, pvk_in_group2);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getCpuDispatcher                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxCpuDispatcher* getCpuDispatcher() const = 0
    #if NATIVE //function start
    ES const physx::PxCpuDispatcher* W_getCpuDispatcher_R_PxCpuDispatcherPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getCpuDispatcher();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCpuDispatcherPtr W_getCpuDispatcher_R_PxCpuDispatcherPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxCpuDispatcherPtr getCpuDispatcher(){
        PxCpuDispatcherPtr retVal = W_getCpuDispatcher_R_PxCpuDispatcherPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getGpuDispatcher                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxGpuDispatcher* getGpuDispatcher() const = 0
    #if NATIVE //function start
    ES const physx::PxGpuDispatcher* W_getGpuDispatcher_R_PxGpuDispatcherPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getGpuDispatcher();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGpuDispatcherPtr W_getGpuDispatcher_R_PxGpuDispatcherPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxGpuDispatcherPtr getGpuDispatcher(){
        PxGpuDispatcherPtr retVal = W_getGpuDispatcher_R_PxGpuDispatcherPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       createClient                                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxClientID W_createClient_R_byte_C_PxScene(physx::PxScene* self){
        auto retVal = self->createClient();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte W_createClient_R_byte_C_PxScene(PxScenePtr selfPtr);
    
    public  byte createClient(){
        byte retVal = W_createClient_R_byte_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setSimulationEventCallback                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxSimulationEventCallbackPtr
    // NATIVE SIG: void				setSimulationEventCallback(PxSimulationEventCallback* callback) = 0
    #if NATIVE //function start
    ES void W_setSimulationEventCallback_R_void_P_PxSimulationEventCallbackPtr_C_PxScene(physx::PxScene* self, physx::PxSimulationEventCallback* callback){
        auto nat_in_callback = (callback);
        self->setSimulationEventCallback(nat_in_callback);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSimulationEventCallback_R_void_P_PxSimulationEventCallbackPtr_C_PxScene(PxScenePtr selfPtr, PxSimulationEventCallbackPtr callback);
    
    public  void setSimulationEventCallback(PxSimulationEventCallbackPtr callback){
        PxSimulationEventCallbackPtr pvk_in_callback = (callback);
        W_setSimulationEventCallback_R_void_P_PxSimulationEventCallbackPtr_C_PxScene(this, pvk_in_callback);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getSimulationEventCallback                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxSimulationEventCallback*	getSimulationEventCallback() const = 0
    #if NATIVE //function start
    ES const physx::PxSimulationEventCallback* W_getSimulationEventCallback_R_PxSimulationEventCallbackPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getSimulationEventCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSimulationEventCallbackPtr W_getSimulationEventCallback_R_PxSimulationEventCallbackPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxSimulationEventCallbackPtr getSimulationEventCallback(){
        PxSimulationEventCallbackPtr retVal = W_getSimulationEventCallback_R_PxSimulationEventCallbackPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setContactModifyCallback                                               #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxContactModifyCallbackPtr
    // NATIVE SIG: void				setContactModifyCallback(PxContactModifyCallback* callback) = 0
    #if NATIVE //function start
    ES void W_setContactModifyCallback_R_void_P_PxContactModifyCallbackPtr_C_PxScene(physx::PxScene* self, physx::PxContactModifyCallback* callback){
        auto nat_in_callback = (callback);
        self->setContactModifyCallback(nat_in_callback);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContactModifyCallback_R_void_P_PxContactModifyCallbackPtr_C_PxScene(PxScenePtr selfPtr, PxContactModifyCallbackPtr callback);
    
    public  void setContactModifyCallback(PxContactModifyCallbackPtr callback){
        PxContactModifyCallbackPtr pvk_in_callback = (callback);
        W_setContactModifyCallback_R_void_P_PxContactModifyCallbackPtr_C_PxScene(this, pvk_in_callback);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setCCDContactModifyCallback                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxCCDContactModifyCallbackPtr
    // NATIVE SIG: void				setCCDContactModifyCallback(PxCCDContactModifyCallback* callback) = 0
    #if NATIVE //function start
    ES void W_setCCDContactModifyCallback_R_void_P_PxCCDContactModifyCallbackPtr_C_PxScene(physx::PxScene* self, physx::PxCCDContactModifyCallback* callback){
        auto nat_in_callback = (callback);
        self->setCCDContactModifyCallback(nat_in_callback);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setCCDContactModifyCallback_R_void_P_PxCCDContactModifyCallbackPtr_C_PxScene(PxScenePtr selfPtr, PxCCDContactModifyCallbackPtr callback);
    
    public  void setCCDContactModifyCallback(PxCCDContactModifyCallbackPtr callback){
        PxCCDContactModifyCallbackPtr pvk_in_callback = (callback);
        W_setCCDContactModifyCallback_R_void_P_PxCCDContactModifyCallbackPtr_C_PxScene(this, pvk_in_callback);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getContactModifyCallback                                               #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxContactModifyCallback*	getContactModifyCallback() const = 0
    #if NATIVE //function start
    ES const physx::PxContactModifyCallback* W_getContactModifyCallback_R_PxContactModifyCallbackPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getContactModifyCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxContactModifyCallbackPtr W_getContactModifyCallback_R_PxContactModifyCallbackPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxContactModifyCallbackPtr getContactModifyCallback(){
        PxContactModifyCallbackPtr retVal = W_getContactModifyCallback_R_PxContactModifyCallbackPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getCCDContactModifyCallback                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxCCDContactModifyCallback*	getCCDContactModifyCallback() const = 0
    #if NATIVE //function start
    ES const physx::PxCCDContactModifyCallback* W_getCCDContactModifyCallback_R_PxCCDContactModifyCallbackPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getCCDContactModifyCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCCDContactModifyCallbackPtr W_getCCDContactModifyCallback_R_PxCCDContactModifyCallbackPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxCCDContactModifyCallbackPtr getCCDContactModifyCallback(){
        PxCCDContactModifyCallbackPtr retVal = W_getCCDContactModifyCallback_R_PxCCDContactModifyCallbackPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setBroadPhaseCallback                                                  #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBroadPhaseCallbackPtr
    // NATIVE SIG: void				setBroadPhaseCallback(PxBroadPhaseCallback* callback) = 0
    #if NATIVE //function start
    ES void W_setBroadPhaseCallback_R_void_P_PxBroadPhaseCallbackPtr_C_PxScene(physx::PxScene* self, physx::PxBroadPhaseCallback* callback){
        auto nat_in_callback = (callback);
        self->setBroadPhaseCallback(nat_in_callback);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBroadPhaseCallback_R_void_P_PxBroadPhaseCallbackPtr_C_PxScene(PxScenePtr selfPtr, PxBroadPhaseCallbackPtr callback);
    
    public  void setBroadPhaseCallback(PxBroadPhaseCallbackPtr callback){
        PxBroadPhaseCallbackPtr pvk_in_callback = (callback);
        W_setBroadPhaseCallback_R_void_P_PxBroadPhaseCallbackPtr_C_PxScene(this, pvk_in_callback);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getBroadPhaseCallback                                                  #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxBroadPhaseCallback* getBroadPhaseCallback()	const = 0
    #if NATIVE //function start
    ES const physx::PxBroadPhaseCallback* W_getBroadPhaseCallback_R_PxBroadPhaseCallbackPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getBroadPhaseCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBroadPhaseCallbackPtr W_getBroadPhaseCallback_R_PxBroadPhaseCallbackPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxBroadPhaseCallbackPtr getBroadPhaseCallback(){
        PxBroadPhaseCallbackPtr retVal = W_getBroadPhaseCallback_R_PxBroadPhaseCallbackPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setFilterShaderData                                                    #
    //================================================================================
    #if NATIVE //function start
    ES void W_setFilterShaderData_R_void_P_IntPtr_P_uint_C_PxScene(physx::PxScene* self, const void* data, physx::PxU32 dataSize){
        auto nat_in_data = (data);
        auto nat_in_dataSize = (dataSize);
        self->setFilterShaderData(nat_in_data, nat_in_dataSize);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFilterShaderData_R_void_P_IntPtr_P_uint_C_PxScene(PxScenePtr selfPtr, IntPtr data, uint dataSize);
    
    public  void setFilterShaderData(IntPtr data, uint dataSize){
        IntPtr pvk_in_data = (data);
        uint pvk_in_dataSize = (dataSize);
        W_setFilterShaderData_R_void_P_IntPtr_P_uint_C_PxScene(this, pvk_in_data, pvk_in_dataSize);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFilterShaderData                                                    #
    //================================================================================
    #if NATIVE //function start
    ES const void* W_getFilterShaderData_R_IntPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getFilterShaderData();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getFilterShaderData_R_IntPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  IntPtr getFilterShaderData(){
        IntPtr retVal = W_getFilterShaderData_R_IntPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFilterShaderDataSize                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getFilterShaderDataSize_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getFilterShaderDataSize();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getFilterShaderDataSize_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getFilterShaderDataSize(){
        uint retVal = W_getFilterShaderDataSize_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFilterShader                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxSimulationFilterShader
    // NATIVE SIG: PxSimulationFilterShader
    								getFilterShader() const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getFilterShader_R_PxSimulationFilterShader_C_PxScene(physx::PxScene* self){
        auto retVal = self->getFilterShader();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFilterShader_R_PxSimulationFilterShader_C_PxScene(PxScenePtr selfPtr);
    
    public  UNPARSED_TYPE getFilterShader(){
        UNPARSED_TYPE retVal = W_getFilterShader_R_PxSimulationFilterShader_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getFilterCallback                                                      #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxSimulationFilterCallback* W_getFilterCallback_R_PxSimulationFilterCallbackPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getFilterCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSimulationFilterCallbackPtr W_getFilterCallback_R_PxSimulationFilterCallbackPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxSimulationFilterCallbackPtr getFilterCallback(){
        PxSimulationFilterCallbackPtr retVal = W_getFilterCallback_R_PxSimulationFilterCallbackPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       resetFiltering                                                         #
    //================================================================================
    #if NATIVE //function start
    ES void W_resetFiltering_R_void_P_PxActorPtr_C_PxScene(physx::PxScene* self, physx::PxActor* actor){
        auto nat_in_actor = (actor);
        self->resetFiltering(*nat_in_actor);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_resetFiltering_R_void_P_PxActorPtr_C_PxScene(PxScenePtr selfPtr, PxActorPtr actor);
    
    public  void resetFiltering(PxActorPtr actor){
        PxActorPtr pvk_in_actor = (actor);
        W_resetFiltering_R_void_P_PxActorPtr_C_PxScene(this, pvk_in_actor);
    }
    #endif //function end
    
    
    //================================================================================
    //#       resetFiltering                                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: void				resetFiltering(PxRigidActor& actor, PxShape*const* shapes, PxU32 shapeCount) = 0
    #if NATIVE //function start
    ES void W_resetFiltering_R_void_P_PxRigidActorPtr_P__P_uint_C_PxScene(physx::PxScene* self, physx::PxRigidActor* actor,  shapes, physx::PxU32 shapeCount){
        auto nat_in_actor = (actor);
        auto nat_in_shapes = (shapes);
        auto nat_in_shapeCount = (shapeCount);
        self->resetFiltering(*nat_in_actor, nat_in_shapes, nat_in_shapeCount);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_resetFiltering_R_void_P_PxRigidActorPtr_P__P_uint_C_PxScene(PxScenePtr selfPtr, PxRigidActorPtr actor,  shapes, uint shapeCount);
    
    public  void resetFiltering(PxRigidActorPtr actor,  shapes, uint shapeCount){
        PxRigidActorPtr pvk_in_actor = (actor);
         pvk_in_shapes = (shapes);
        uint pvk_in_shapeCount = (shapeCount);
        W_resetFiltering_R_void_P_PxRigidActorPtr_P__P_uint_C_PxScene(this, pvk_in_actor, pvk_in_shapes, pvk_in_shapeCount);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       simulate                                                               #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				simulate(PxReal elapsedTime, physx::PxBaseTask* completionTask = NULL,
    									void* scratchMemBlock = 0, PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_P_bool_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask, void* scratchMemBlock, physx::PxU32 scratchMemBlockSize, bool controlSimulation){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        auto nat_in_scratchMemBlock = (scratchMemBlock);
        auto nat_in_scratchMemBlockSize = (scratchMemBlockSize);
        auto nat_in_controlSimulation = (controlSimulation);
        self->simulate(nat_in_elapsedTime, nat_in_completionTask, nat_in_scratchMemBlock, nat_in_scratchMemBlockSize, nat_in_controlSimulation);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_P_bool_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize, bool controlSimulation);
    
    public  void simulate(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize, bool controlSimulation){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        IntPtr pvk_in_scratchMemBlock = (scratchMemBlock);
        uint pvk_in_scratchMemBlockSize = (scratchMemBlockSize);
        bool pvk_in_controlSimulation = (controlSimulation);
        W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_P_bool_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask, pvk_in_scratchMemBlock, pvk_in_scratchMemBlockSize, pvk_in_controlSimulation);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				simulate(PxReal elapsedTime, physx::PxBaseTask* completionTask = NULL,
    									void* scratchMemBlock = 0, PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_OL1_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask, void* scratchMemBlock, physx::PxU32 scratchMemBlockSize){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        auto nat_in_scratchMemBlock = (scratchMemBlock);
        auto nat_in_scratchMemBlockSize = (scratchMemBlockSize);
        self->simulate(nat_in_elapsedTime, nat_in_completionTask, nat_in_scratchMemBlock, nat_in_scratchMemBlockSize);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_OL1_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize);
    
    public  void simulate(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        IntPtr pvk_in_scratchMemBlock = (scratchMemBlock);
        uint pvk_in_scratchMemBlockSize = (scratchMemBlockSize);
        W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_OL1_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask, pvk_in_scratchMemBlock, pvk_in_scratchMemBlockSize);
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				simulate(PxReal elapsedTime, physx::PxBaseTask* completionTask = NULL,
    									void* scratchMemBlock = 0, PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_OL2_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask, void* scratchMemBlock){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        auto nat_in_scratchMemBlock = (scratchMemBlock);
        self->simulate(nat_in_elapsedTime, nat_in_completionTask, nat_in_scratchMemBlock);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_OL2_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock);
    
    public  void simulate(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        IntPtr pvk_in_scratchMemBlock = (scratchMemBlock);
        W_simulate_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_OL2_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask, pvk_in_scratchMemBlock);
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				simulate(PxReal elapsedTime, physx::PxBaseTask* completionTask = NULL,
    									void* scratchMemBlock = 0, PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_simulate_R_void_P_float_P_PxBaseTaskPtr_OL3_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        self->simulate(nat_in_elapsedTime, nat_in_completionTask);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_simulate_R_void_P_float_P_PxBaseTaskPtr_OL3_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask);
    
    public  void simulate(float elapsedTime, PxBaseTaskPtr completionTask){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        W_simulate_R_void_P_float_P_PxBaseTaskPtr_OL3_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask);
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_simulate_R_void_P_float_OL4_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime){
        auto nat_in_elapsedTime = (elapsedTime);
        self->simulate(nat_in_elapsedTime);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_simulate_R_void_P_float_OL4_C_PxScene(PxScenePtr selfPtr, float elapsedTime);
    
    public  void simulate(float elapsedTime){
        float pvk_in_elapsedTime = (elapsedTime);
        W_simulate_R_void_P_float_OL4_C_PxScene(this, pvk_in_elapsedTime);
    }
    #endif //function end
    
    
    
    
    //================================================================================
    //#       advance                                                                #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				advance(physx::PxBaseTask* completionTask = 0) = 0
    #if NATIVE //function start
    ES void W_advance_R_void_P_PxBaseTaskPtr_C_PxScene(physx::PxScene* self, physx::PxBaseTask* completionTask){
        auto nat_in_completionTask = (completionTask);
        self->advance(nat_in_completionTask);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_advance_R_void_P_PxBaseTaskPtr_C_PxScene(PxScenePtr selfPtr, PxBaseTaskPtr completionTask);
    
    public  void advance(PxBaseTaskPtr completionTask){
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        W_advance_R_void_P_PxBaseTaskPtr_C_PxScene(this, pvk_in_completionTask);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_advance_R_void_OL1_C_PxScene(physx::PxScene* self){
        self->advance();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_advance_R_void_OL1_C_PxScene(PxScenePtr selfPtr);
    
    public  void advance(){
        W_advance_R_void_OL1_C_PxScene(this);
    }
    #endif //function end
    
    
    
    
    //================================================================================
    //#       collide                                                                #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				collide(PxReal elapsedTime, physx::PxBaseTask* completionTask = 0, void* scratchMemBlock = 0,
    									PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_P_bool_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask, void* scratchMemBlock, physx::PxU32 scratchMemBlockSize, bool controlSimulation){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        auto nat_in_scratchMemBlock = (scratchMemBlock);
        auto nat_in_scratchMemBlockSize = (scratchMemBlockSize);
        auto nat_in_controlSimulation = (controlSimulation);
        self->collide(nat_in_elapsedTime, nat_in_completionTask, nat_in_scratchMemBlock, nat_in_scratchMemBlockSize, nat_in_controlSimulation);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_P_bool_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize, bool controlSimulation);
    
    public  void collide(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize, bool controlSimulation){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        IntPtr pvk_in_scratchMemBlock = (scratchMemBlock);
        uint pvk_in_scratchMemBlockSize = (scratchMemBlockSize);
        bool pvk_in_controlSimulation = (controlSimulation);
        W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_P_bool_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask, pvk_in_scratchMemBlock, pvk_in_scratchMemBlockSize, pvk_in_controlSimulation);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				collide(PxReal elapsedTime, physx::PxBaseTask* completionTask = 0, void* scratchMemBlock = 0,
    									PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_OL1_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask, void* scratchMemBlock, physx::PxU32 scratchMemBlockSize){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        auto nat_in_scratchMemBlock = (scratchMemBlock);
        auto nat_in_scratchMemBlockSize = (scratchMemBlockSize);
        self->collide(nat_in_elapsedTime, nat_in_completionTask, nat_in_scratchMemBlock, nat_in_scratchMemBlockSize);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_OL1_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize);
    
    public  void collide(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock, uint scratchMemBlockSize){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        IntPtr pvk_in_scratchMemBlock = (scratchMemBlock);
        uint pvk_in_scratchMemBlockSize = (scratchMemBlockSize);
        W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_P_uint_OL1_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask, pvk_in_scratchMemBlock, pvk_in_scratchMemBlockSize);
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				collide(PxReal elapsedTime, physx::PxBaseTask* completionTask = 0, void* scratchMemBlock = 0,
    									PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_OL2_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask, void* scratchMemBlock){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        auto nat_in_scratchMemBlock = (scratchMemBlock);
        self->collide(nat_in_elapsedTime, nat_in_completionTask, nat_in_scratchMemBlock);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_OL2_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock);
    
    public  void collide(float elapsedTime, PxBaseTaskPtr completionTask, IntPtr scratchMemBlock){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        IntPtr pvk_in_scratchMemBlock = (scratchMemBlock);
        W_collide_R_void_P_float_P_PxBaseTaskPtr_P_IntPtr_OL2_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask, pvk_in_scratchMemBlock);
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				collide(PxReal elapsedTime, physx::PxBaseTask* completionTask = 0, void* scratchMemBlock = 0,
    									PxU32 scratchMemBlockSize = 0, bool controlSimulation = true) = 0
    #if NATIVE //function start
    ES void W_collide_R_void_P_float_P_PxBaseTaskPtr_OL3_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime, physx::PxBaseTask* completionTask){
        auto nat_in_elapsedTime = (elapsedTime);
        auto nat_in_completionTask = (completionTask);
        self->collide(nat_in_elapsedTime, nat_in_completionTask);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_collide_R_void_P_float_P_PxBaseTaskPtr_OL3_C_PxScene(PxScenePtr selfPtr, float elapsedTime, PxBaseTaskPtr completionTask);
    
    public  void collide(float elapsedTime, PxBaseTaskPtr completionTask){
        float pvk_in_elapsedTime = (elapsedTime);
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        W_collide_R_void_P_float_P_PxBaseTaskPtr_OL3_C_PxScene(this, pvk_in_elapsedTime, pvk_in_completionTask);
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_collide_R_void_P_float_OL4_C_PxScene(physx::PxScene* self, physx::PxReal elapsedTime){
        auto nat_in_elapsedTime = (elapsedTime);
        self->collide(nat_in_elapsedTime);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_collide_R_void_P_float_OL4_C_PxScene(PxScenePtr selfPtr, float elapsedTime);
    
    public  void collide(float elapsedTime){
        float pvk_in_elapsedTime = (elapsedTime);
        W_collide_R_void_P_float_OL4_C_PxScene(this, pvk_in_elapsedTime);
    }
    #endif //function end
    
    
    
    
    //================================================================================
    //#       checkResults                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_checkResults_R_bool_P_bool_C_PxScene(physx::PxScene* self, bool block){
        auto nat_in_block = (block);
        auto retVal = self->checkResults(nat_in_block);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_checkResults_R_bool_P_bool_C_PxScene(PxScenePtr selfPtr, bool block);
    
    public  bool checkResults(bool block){
        bool pvk_in_block = (block);
        bool retVal = W_checkResults_R_bool_P_bool_C_PxScene(this, pvk_in_block);
        return retVal;
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES bool W_checkResults_R_bool_OL1_C_PxScene(physx::PxScene* self){
        auto retVal = self->checkResults();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_checkResults_R_bool_OL1_C_PxScene(PxScenePtr selfPtr);
    
    public  bool checkResults(){
        bool retVal = W_checkResults_R_bool_OL1_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       fetchCollision                                                         #
    //================================================================================
    #if NATIVE //function start
    ES bool W_fetchCollision_R_bool_P_bool_C_PxScene(physx::PxScene* self, bool block){
        auto nat_in_block = (block);
        auto retVal = self->fetchCollision(nat_in_block);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchCollision_R_bool_P_bool_C_PxScene(PxScenePtr selfPtr, bool block);
    
    public  bool fetchCollision(bool block){
        bool pvk_in_block = (block);
        bool retVal = W_fetchCollision_R_bool_P_bool_C_PxScene(this, pvk_in_block);
        return retVal;
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES bool W_fetchCollision_R_bool_OL1_C_PxScene(physx::PxScene* self){
        auto retVal = self->fetchCollision();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchCollision_R_bool_OL1_C_PxScene(PxScenePtr selfPtr);
    
    public  bool fetchCollision(){
        bool retVal = W_fetchCollision_R_bool_OL1_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       fetchResults                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_fetchResults_R_bool_P_bool_P_uintPtr_C_PxScene(physx::PxScene* self, bool block, physx::PxU32* errorState){
        auto nat_in_block = (block);
        auto nat_in_errorState = (errorState);
        auto retVal = self->fetchResults(nat_in_block, nat_in_errorState);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchResults_R_bool_P_bool_P_uintPtr_C_PxScene(PxScenePtr selfPtr, bool block, uint* errorState);
    
    public  bool fetchResults(bool block, uint* errorState){
        bool pvk_in_block = (block);
        uint* pvk_in_errorState = (errorState);
        bool retVal = W_fetchResults_R_bool_P_bool_P_uintPtr_C_PxScene(this, pvk_in_block, pvk_in_errorState);
        return retVal;
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES bool W_fetchResults_R_bool_P_bool_OL1_C_PxScene(physx::PxScene* self, bool block){
        auto nat_in_block = (block);
        auto retVal = self->fetchResults(nat_in_block);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchResults_R_bool_P_bool_OL1_C_PxScene(PxScenePtr selfPtr, bool block);
    
    public  bool fetchResults(bool block){
        bool pvk_in_block = (block);
        bool retVal = W_fetchResults_R_bool_P_bool_OL1_C_PxScene(this, pvk_in_block);
        return retVal;
    }
    #endif //function end
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES bool W_fetchResults_R_bool_OL2_C_PxScene(physx::PxScene* self){
        auto retVal = self->fetchResults();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchResults_R_bool_OL2_C_PxScene(PxScenePtr selfPtr);
    
    public  bool fetchResults(){
        bool retVal = W_fetchResults_R_bool_OL2_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       fetchResultsStart                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee const physx::PxContactPairHeader*
    // NATIVE SIG: bool				fetchResultsStart(const PxContactPairHeader*& contactPairs, PxU32& nbContactPairs, bool block = false) = 0
    #if NATIVE //function start
    ES bool W_fetchResultsStart_R_bool_P__P_uintPtr_P_bool_C_PxScene(physx::PxScene* self,  contactPairs, physx::PxU32& nbContactPairs, bool block){
        auto nat_in_contactPairs = (contactPairs);
        auto nat_in_nbContactPairs = (nbContactPairs);
        auto nat_in_block = (block);
        auto retVal = self->fetchResultsStart(nat_in_contactPairs, nat_in_nbContactPairs, nat_in_block);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchResultsStart_R_bool_P__P_uintPtr_P_bool_C_PxScene(PxScenePtr selfPtr,  contactPairs, uint* nbContactPairs, bool block);
    
    public  bool fetchResultsStart( contactPairs, uint* nbContactPairs, bool block){
         pvk_in_contactPairs = (contactPairs);
        uint* pvk_in_nbContactPairs = (nbContactPairs);
        bool pvk_in_block = (block);
        bool retVal = W_fetchResultsStart_R_bool_P__P_uintPtr_P_bool_C_PxScene(this, pvk_in_contactPairs, pvk_in_nbContactPairs, pvk_in_block);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee const physx::PxContactPairHeader*
    // NATIVE SIG: bool				fetchResultsStart(const PxContactPairHeader*& contactPairs, PxU32& nbContactPairs, bool block = false) = 0
    #if NATIVE //function start
    ES bool W_fetchResultsStart_R_bool_P__P_uintPtr_OL1_C_PxScene(physx::PxScene* self,  contactPairs, physx::PxU32& nbContactPairs){
        auto nat_in_contactPairs = (contactPairs);
        auto nat_in_nbContactPairs = (nbContactPairs);
        auto retVal = self->fetchResultsStart(nat_in_contactPairs, nat_in_nbContactPairs);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchResultsStart_R_bool_P__P_uintPtr_OL1_C_PxScene(PxScenePtr selfPtr,  contactPairs, uint* nbContactPairs);
    
    public  bool fetchResultsStart( contactPairs, uint* nbContactPairs){
         pvk_in_contactPairs = (contactPairs);
        uint* pvk_in_nbContactPairs = (nbContactPairs);
        bool retVal = W_fetchResultsStart_R_bool_P__P_uintPtr_OL1_C_PxScene(this, pvk_in_contactPairs, pvk_in_nbContactPairs);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       processCallbacks                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				processCallbacks(physx::PxBaseTask* continuation) = 0
    #if NATIVE //function start
    ES void W_processCallbacks_R_void_P_PxBaseTaskPtr_C_PxScene(physx::PxScene* self, physx::PxBaseTask* continuation){
        auto nat_in_continuation = (continuation);
        self->processCallbacks(nat_in_continuation);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_processCallbacks_R_void_P_PxBaseTaskPtr_C_PxScene(PxScenePtr selfPtr, PxBaseTaskPtr continuation);
    
    public  void processCallbacks(PxBaseTaskPtr continuation){
        PxBaseTaskPtr pvk_in_continuation = (continuation);
        W_processCallbacks_R_void_P_PxBaseTaskPtr_C_PxScene(this, pvk_in_continuation);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       fetchResultsFinish                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_fetchResultsFinish_R_void_P_uintPtr_C_PxScene(physx::PxScene* self, physx::PxU32* errorState){
        auto nat_in_errorState = (errorState);
        self->fetchResultsFinish(nat_in_errorState);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_fetchResultsFinish_R_void_P_uintPtr_C_PxScene(PxScenePtr selfPtr, uint* errorState);
    
    public  void fetchResultsFinish(uint* errorState){
        uint* pvk_in_errorState = (errorState);
        W_fetchResultsFinish_R_void_P_uintPtr_C_PxScene(this, pvk_in_errorState);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_fetchResultsFinish_R_void_OL1_C_PxScene(physx::PxScene* self){
        self->fetchResultsFinish();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_fetchResultsFinish_R_void_OL1_C_PxScene(PxScenePtr selfPtr);
    
    public  void fetchResultsFinish(){
        W_fetchResultsFinish_R_void_OL1_C_PxScene(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       flushSimulation                                                        #
    //================================================================================
    #if NATIVE //function start
    ES void W_flushSimulation_R_void_P_bool_C_PxScene(physx::PxScene* self, bool sendPendingReports){
        auto nat_in_sendPendingReports = (sendPendingReports);
        self->flushSimulation(nat_in_sendPendingReports);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_flushSimulation_R_void_P_bool_C_PxScene(PxScenePtr selfPtr, bool sendPendingReports);
    
    public  void flushSimulation(bool sendPendingReports){
        bool pvk_in_sendPendingReports = (sendPendingReports);
        W_flushSimulation_R_void_P_bool_C_PxScene(this, pvk_in_sendPendingReports);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_flushSimulation_R_void_OL1_C_PxScene(physx::PxScene* self){
        self->flushSimulation();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_flushSimulation_R_void_OL1_C_PxScene(PxScenePtr selfPtr);
    
    public  void flushSimulation(){
        W_flushSimulation_R_void_OL1_C_PxScene(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       setGravity                                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_setGravity_R_void_P_PxVec3_C_PxScene(physx::PxScene* self, physx::PxVec3 vec){
        auto nat_in_vec = (vec);
        self->setGravity(nat_in_vec);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGravity_R_void_P_PxVec3_C_PxScene(PxScenePtr selfPtr, PxVec3 vec);
    
    public  void setGravity(PxVec3 vec){
        PxVec3 pvk_in_vec = (vec);
        W_setGravity_R_void_P_PxVec3_C_PxScene(this, pvk_in_vec);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getGravity                                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3 W_getGravity_R_PxVec3_C_PxScene(physx::PxScene* self){
        auto retVal = self->getGravity();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getGravity_R_PxVec3_C_PxScene(PxScenePtr selfPtr);
    
    public  PxVec3 getGravity(){
        PxVec3 retVal = W_getGravity_R_PxVec3_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setBounceThresholdVelocity                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_setBounceThresholdVelocity_R_void_P_float_C_PxScene(physx::PxScene* self, physx::PxReal t){
        auto nat_in_t = (t);
        self->setBounceThresholdVelocity(nat_in_t);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBounceThresholdVelocity_R_void_P_float_C_PxScene(PxScenePtr selfPtr, float t);
    
    public  void setBounceThresholdVelocity(float t){
        float pvk_in_t = (t);
        W_setBounceThresholdVelocity_R_void_P_float_C_PxScene(this, pvk_in_t);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBounceThresholdVelocity                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getBounceThresholdVelocity_R_float_C_PxScene(physx::PxScene* self){
        auto retVal = self->getBounceThresholdVelocity();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getBounceThresholdVelocity_R_float_C_PxScene(PxScenePtr selfPtr);
    
    public  float getBounceThresholdVelocity(){
        float retVal = W_getBounceThresholdVelocity_R_float_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setCCDMaxPasses                                                        #
    //================================================================================
    #if NATIVE //function start
    ES void W_setCCDMaxPasses_R_void_P_uint_C_PxScene(physx::PxScene* self, physx::PxU32 ccdMaxPasses){
        auto nat_in_ccdMaxPasses = (ccdMaxPasses);
        self->setCCDMaxPasses(nat_in_ccdMaxPasses);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setCCDMaxPasses_R_void_P_uint_C_PxScene(PxScenePtr selfPtr, uint ccdMaxPasses);
    
    public  void setCCDMaxPasses(uint ccdMaxPasses){
        uint pvk_in_ccdMaxPasses = (ccdMaxPasses);
        W_setCCDMaxPasses_R_void_P_uint_C_PxScene(this, pvk_in_ccdMaxPasses);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getCCDMaxPasses                                                        #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getCCDMaxPasses_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getCCDMaxPasses();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getCCDMaxPasses_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getCCDMaxPasses(){
        uint retVal = W_getCCDMaxPasses_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFrictionOffsetThreshold                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getFrictionOffsetThreshold_R_float_C_PxScene(physx::PxScene* self){
        auto retVal = self->getFrictionOffsetThreshold();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getFrictionOffsetThreshold_R_float_C_PxScene(PxScenePtr selfPtr);
    
    public  float getFrictionOffsetThreshold(){
        float retVal = W_getFrictionOffsetThreshold_R_float_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setFrictionType                                                        #
    //================================================================================
    #if NATIVE //function start
    ES void W_setFrictionType_R_void_P_PxFrictionType_C_PxScene(physx::PxScene* self, physx::PxFrictionType::Enum frictionType){
        auto nat_in_frictionType = (frictionType);
        self->setFrictionType(nat_in_frictionType);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFrictionType_R_void_P_PxFrictionType_C_PxScene(PxScenePtr selfPtr, PxFrictionType frictionType);
    
    public  void setFrictionType(PxFrictionType frictionType){
        PxFrictionType pvk_in_frictionType = (frictionType);
        W_setFrictionType_R_void_P_PxFrictionType_C_PxScene(this, pvk_in_frictionType);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFrictionType                                                        #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxFrictionType::Enum W_getFrictionType_R_PxFrictionType_C_PxScene(physx::PxScene* self){
        auto retVal = self->getFrictionType();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFrictionType W_getFrictionType_R_PxFrictionType_C_PxScene(PxScenePtr selfPtr);
    
    public  PxFrictionType getFrictionType(){
        PxFrictionType retVal = W_getFrictionType_R_PxFrictionType_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setVisualizationParameter                                              #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxVisualizationParameter
    // NATIVE SIG: bool				setVisualizationParameter(PxVisualizationParameter::Enum param, PxReal value) = 0
    #if NATIVE //function start
    ES bool W_setVisualizationParameter_R_bool_P_PxVisualizationParameter_P_float_C_PxScene(physx::PxScene* self, physx::PxVisualizationParameter::Enum param, physx::PxReal value){
        auto nat_in_param = (param);
        auto nat_in_value = (value);
        auto retVal = self->setVisualizationParameter(nat_in_param, nat_in_value);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_setVisualizationParameter_R_bool_P_PxVisualizationParameter_P_float_C_PxScene(PxScenePtr selfPtr, PxVisualizationParameter param, float value);
    
    public  bool setVisualizationParameter(PxVisualizationParameter param, float value){
        PxVisualizationParameter pvk_in_param = (param);
        float pvk_in_value = (value);
        bool retVal = W_setVisualizationParameter_R_bool_P_PxVisualizationParameter_P_float_C_PxScene(this, pvk_in_param, pvk_in_value);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getVisualizationParameter                                              #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxVisualizationParameter
    // NATIVE SIG: PxReal				getVisualizationParameter(PxVisualizationParameter::Enum paramEnum) const = 0
    #if NATIVE //function start
    ES physx::PxReal W_getVisualizationParameter_R_float_P_PxVisualizationParameter_C_PxScene(physx::PxScene* self, physx::PxVisualizationParameter::Enum paramEnum){
        auto nat_in_paramEnum = (paramEnum);
        auto retVal = self->getVisualizationParameter(nat_in_paramEnum);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getVisualizationParameter_R_float_P_PxVisualizationParameter_C_PxScene(PxScenePtr selfPtr, PxVisualizationParameter paramEnum);
    
    public  float getVisualizationParameter(PxVisualizationParameter paramEnum){
        PxVisualizationParameter pvk_in_paramEnum = (paramEnum);
        float retVal = W_getVisualizationParameter_R_float_P_PxVisualizationParameter_C_PxScene(this, pvk_in_paramEnum);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setVisualizationCullingBox                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_setVisualizationCullingBox_R_void_P_PxBounds3_C_PxScene(physx::PxScene* self, physx::PxBounds3 box){
        auto nat_in_box = (box);
        self->setVisualizationCullingBox(nat_in_box);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setVisualizationCullingBox_R_void_P_PxBounds3_C_PxScene(PxScenePtr selfPtr, PxBounds3 box);
    
    public  void setVisualizationCullingBox(PxBounds3 box){
        PxBounds3 pvk_in_box = (box);
        W_setVisualizationCullingBox_R_void_P_PxBounds3_C_PxScene(this, pvk_in_box);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getVisualizationCullingBox                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_getVisualizationCullingBox_R_PxBounds3_C_PxScene(physx::PxScene* self){
        auto retVal = self->getVisualizationCullingBox();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_getVisualizationCullingBox_R_PxBounds3_C_PxScene(PxScenePtr selfPtr);
    
    public  PxBounds3 getVisualizationCullingBox(){
        PxBounds3 retVal = W_getVisualizationCullingBox_R_PxBounds3_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getRenderBuffer                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxRenderBuffer& getRenderBuffer() = 0
    #if NATIVE //function start
    ES physx::PxRenderBuffer* W_getRenderBuffer_R_PxRenderBufferPtr_C_PxScene(physx::PxScene* self){
        auto retVal = &self->getRenderBuffer();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRenderBufferPtr W_getRenderBuffer_R_PxRenderBufferPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxRenderBufferPtr getRenderBuffer(){
        PxRenderBufferPtr retVal = W_getRenderBuffer_R_PxRenderBufferPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getSimulationStatistics                                                #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxSimulationStatisticsPtr
    // NATIVE SIG: void				getSimulationStatistics(PxSimulationStatistics& stats) const = 0
    #if NATIVE //function start
    ES void W_getSimulationStatistics_R_void_P_PxSimulationStatisticsPtr_C_PxScene(physx::PxScene* self, physx::PxSimulationStatistics* stats){
        auto nat_in_stats = (stats);
        self->getSimulationStatistics(*nat_in_stats);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getSimulationStatistics_R_void_P_PxSimulationStatisticsPtr_C_PxScene(PxScenePtr selfPtr, PxSimulationStatisticsPtr stats);
    
    public  void getSimulationStatistics(PxSimulationStatisticsPtr stats){
        PxSimulationStatisticsPtr pvk_in_stats = (stats);
        W_getSimulationStatistics_R_void_P_PxSimulationStatisticsPtr_C_PxScene(this, pvk_in_stats);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getStaticStructure                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxPruningStructureType::Enum W_getStaticStructure_R_PxPruningStructureType_C_PxScene(physx::PxScene* self){
        auto retVal = self->getStaticStructure();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPruningStructureType W_getStaticStructure_R_PxPruningStructureType_C_PxScene(PxScenePtr selfPtr);
    
    public  PxPruningStructureType getStaticStructure(){
        PxPruningStructureType retVal = W_getStaticStructure_R_PxPruningStructureType_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getDynamicStructure                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxPruningStructureType::Enum W_getDynamicStructure_R_PxPruningStructureType_C_PxScene(physx::PxScene* self){
        auto retVal = self->getDynamicStructure();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPruningStructureType W_getDynamicStructure_R_PxPruningStructureType_C_PxScene(PxScenePtr selfPtr);
    
    public  PxPruningStructureType getDynamicStructure(){
        PxPruningStructureType retVal = W_getDynamicStructure_R_PxPruningStructureType_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       flushQueryUpdates                                                      #
    //================================================================================
    #if NATIVE //function start
    ES void W_flushQueryUpdates_R_void_C_PxScene(physx::PxScene* self){
        self->flushQueryUpdates();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_flushQueryUpdates_R_void_C_PxScene(PxScenePtr selfPtr);
    
    public  void flushQueryUpdates(){
        W_flushQueryUpdates_R_void_C_PxScene(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       createBatchQuery                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxBatchQuery*		createBatchQuery(const PxBatchQueryDesc& desc) = 0
    #if NATIVE //function start
    ES physx::PxBatchQuery* W_createBatchQuery_R_PxBatchQueryPtr_P_PxBatchQueryDescPtr_C_PxScene(physx::PxScene* self, physx::PxBatchQueryDesc* desc){
        auto nat_in_desc = (desc);
        auto retVal = self->createBatchQuery(*nat_in_desc);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBatchQueryPtr W_createBatchQuery_R_PxBatchQueryPtr_P_PxBatchQueryDescPtr_C_PxScene(PxScenePtr selfPtr, PxBatchQueryDescPtr desc);
    
    public  PxBatchQueryPtr createBatchQuery(PxBatchQueryDescPtr desc){
        PxBatchQueryDescPtr pvk_in_desc = (desc);
        PxBatchQueryPtr retVal = W_createBatchQuery_R_PxBatchQueryPtr_P_PxBatchQueryDescPtr_C_PxScene(this, pvk_in_desc);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setDynamicTreeRebuildRateHint                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_setDynamicTreeRebuildRateHint_R_void_P_uint_C_PxScene(physx::PxScene* self, physx::PxU32 dynamicTreeRebuildRateHint){
        auto nat_in_dynamicTreeRebuildRateHint = (dynamicTreeRebuildRateHint);
        self->setDynamicTreeRebuildRateHint(nat_in_dynamicTreeRebuildRateHint);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setDynamicTreeRebuildRateHint_R_void_P_uint_C_PxScene(PxScenePtr selfPtr, uint dynamicTreeRebuildRateHint);
    
    public  void setDynamicTreeRebuildRateHint(uint dynamicTreeRebuildRateHint){
        uint pvk_in_dynamicTreeRebuildRateHint = (dynamicTreeRebuildRateHint);
        W_setDynamicTreeRebuildRateHint_R_void_P_uint_C_PxScene(this, pvk_in_dynamicTreeRebuildRateHint);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getDynamicTreeRebuildRateHint                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getDynamicTreeRebuildRateHint_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getDynamicTreeRebuildRateHint();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getDynamicTreeRebuildRateHint_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getDynamicTreeRebuildRateHint(){
        uint retVal = W_getDynamicTreeRebuildRateHint_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       forceDynamicTreeRebuild                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_forceDynamicTreeRebuild_R_void_P_bool_P_bool_C_PxScene(physx::PxScene* self, bool rebuildStaticStructure, bool rebuildDynamicStructure){
        auto nat_in_rebuildStaticStructure = (rebuildStaticStructure);
        auto nat_in_rebuildDynamicStructure = (rebuildDynamicStructure);
        self->forceDynamicTreeRebuild(nat_in_rebuildStaticStructure, nat_in_rebuildDynamicStructure);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_forceDynamicTreeRebuild_R_void_P_bool_P_bool_C_PxScene(PxScenePtr selfPtr, bool rebuildStaticStructure, bool rebuildDynamicStructure);
    
    public  void forceDynamicTreeRebuild(bool rebuildStaticStructure, bool rebuildDynamicStructure){
        bool pvk_in_rebuildStaticStructure = (rebuildStaticStructure);
        bool pvk_in_rebuildDynamicStructure = (rebuildDynamicStructure);
        W_forceDynamicTreeRebuild_R_void_P_bool_P_bool_C_PxScene(this, pvk_in_rebuildStaticStructure, pvk_in_rebuildDynamicStructure);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setSceneQueryUpdateMode                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setSceneQueryUpdateMode_R_void_P_PxSceneQueryUpdateMode_C_PxScene(physx::PxScene* self, physx::PxSceneQueryUpdateMode::Enum updateMode){
        auto nat_in_updateMode = (updateMode);
        self->setSceneQueryUpdateMode(nat_in_updateMode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSceneQueryUpdateMode_R_void_P_PxSceneQueryUpdateMode_C_PxScene(PxScenePtr selfPtr, PxSceneQueryUpdateMode updateMode);
    
    public  void setSceneQueryUpdateMode(PxSceneQueryUpdateMode updateMode){
        PxSceneQueryUpdateMode pvk_in_updateMode = (updateMode);
        W_setSceneQueryUpdateMode_R_void_P_PxSceneQueryUpdateMode_C_PxScene(this, pvk_in_updateMode);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getSceneQueryUpdateMode                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxSceneQueryUpdateMode::Enum W_getSceneQueryUpdateMode_R_PxSceneQueryUpdateMode_C_PxScene(physx::PxScene* self){
        auto retVal = self->getSceneQueryUpdateMode();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSceneQueryUpdateMode W_getSceneQueryUpdateMode_R_PxSceneQueryUpdateMode_C_PxScene(PxScenePtr selfPtr);
    
    public  PxSceneQueryUpdateMode getSceneQueryUpdateMode(){
        PxSceneQueryUpdateMode retVal = W_getSceneQueryUpdateMode_R_PxSceneQueryUpdateMode_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       sceneQueriesUpdate                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				sceneQueriesUpdate(physx::PxBaseTask* completionTask = NULL, bool controlSimulation = true)	= 0
    #if NATIVE //function start
    ES void W_sceneQueriesUpdate_R_void_P_PxBaseTaskPtr_P_bool_C_PxScene(physx::PxScene* self, physx::PxBaseTask* completionTask, bool controlSimulation){
        auto nat_in_completionTask = (completionTask);
        auto nat_in_controlSimulation = (controlSimulation);
        self->sceneQueriesUpdate(nat_in_completionTask, nat_in_controlSimulation);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_sceneQueriesUpdate_R_void_P_PxBaseTaskPtr_P_bool_C_PxScene(PxScenePtr selfPtr, PxBaseTaskPtr completionTask, bool controlSimulation);
    
    public  void sceneQueriesUpdate(PxBaseTaskPtr completionTask, bool controlSimulation){
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        bool pvk_in_controlSimulation = (controlSimulation);
        W_sceneQueriesUpdate_R_void_P_PxBaseTaskPtr_P_bool_C_PxScene(this, pvk_in_completionTask, pvk_in_controlSimulation);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBaseTaskPtr
    // NATIVE SIG: void				sceneQueriesUpdate(physx::PxBaseTask* completionTask = NULL, bool controlSimulation = true)	= 0
    #if NATIVE //function start
    ES void W_sceneQueriesUpdate_R_void_P_PxBaseTaskPtr_OL1_C_PxScene(physx::PxScene* self, physx::PxBaseTask* completionTask){
        auto nat_in_completionTask = (completionTask);
        self->sceneQueriesUpdate(nat_in_completionTask);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_sceneQueriesUpdate_R_void_P_PxBaseTaskPtr_OL1_C_PxScene(PxScenePtr selfPtr, PxBaseTaskPtr completionTask);
    
    public  void sceneQueriesUpdate(PxBaseTaskPtr completionTask){
        PxBaseTaskPtr pvk_in_completionTask = (completionTask);
        W_sceneQueriesUpdate_R_void_P_PxBaseTaskPtr_OL1_C_PxScene(this, pvk_in_completionTask);
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_sceneQueriesUpdate_R_void_OL2_C_PxScene(physx::PxScene* self){
        self->sceneQueriesUpdate();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_sceneQueriesUpdate_R_void_OL2_C_PxScene(PxScenePtr selfPtr);
    
    public  void sceneQueriesUpdate(){
        W_sceneQueriesUpdate_R_void_OL2_C_PxScene(this);
    }
    #endif //function end
    
    
    
    
    //================================================================================
    //#       checkQueries                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_checkQueries_R_bool_P_bool_C_PxScene(physx::PxScene* self, bool block){
        auto nat_in_block = (block);
        auto retVal = self->checkQueries(nat_in_block);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_checkQueries_R_bool_P_bool_C_PxScene(PxScenePtr selfPtr, bool block);
    
    public  bool checkQueries(bool block){
        bool pvk_in_block = (block);
        bool retVal = W_checkQueries_R_bool_P_bool_C_PxScene(this, pvk_in_block);
        return retVal;
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES bool W_checkQueries_R_bool_OL1_C_PxScene(physx::PxScene* self){
        auto retVal = self->checkQueries();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_checkQueries_R_bool_OL1_C_PxScene(PxScenePtr selfPtr);
    
    public  bool checkQueries(){
        bool retVal = W_checkQueries_R_bool_OL1_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       fetchQueries                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_fetchQueries_R_bool_P_bool_C_PxScene(physx::PxScene* self, bool block){
        auto nat_in_block = (block);
        auto retVal = self->fetchQueries(nat_in_block);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchQueries_R_bool_P_bool_C_PxScene(PxScenePtr selfPtr, bool block);
    
    public  bool fetchQueries(bool block){
        bool pvk_in_block = (block);
        bool retVal = W_fetchQueries_R_bool_P_bool_C_PxScene(this, pvk_in_block);
        return retVal;
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES bool W_fetchQueries_R_bool_OL1_C_PxScene(physx::PxScene* self){
        auto retVal = self->fetchQueries();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_fetchQueries_R_bool_OL1_C_PxScene(PxScenePtr selfPtr);
    
    public  bool fetchQueries(){
        bool retVal = W_fetchQueries_R_bool_OL1_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       raycast                                                                #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				raycast(
    									const PxVec3& origin, const PxVec3& unitDir, const PxReal distance,
    									PxRaycastCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL) const = 0
    #if NATIVE //function start
    ES bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_C_PxScene(physx::PxScene* self, physx::PxVec3 origin, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags, physx::PxQueryFilterData* filterData, physx::PxQueryFilterCallback* filterCall, physx::PxQueryCache* cache){
        auto nat_in_origin = (origin);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto nat_in_filterData = (filterData);
        auto nat_in_filterCall = (filterCall);
        auto nat_in_cache = (cache);
        auto retVal = self->raycast(nat_in_origin, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags, *nat_in_filterData, nat_in_filterCall, nat_in_cache);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_C_PxScene(PxScenePtr selfPtr, PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache);
    
    public  bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache){
        PxVec3 pvk_in_origin = (origin);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        PxQueryFilterCallbackPtr pvk_in_filterCall = (filterCall);
        PxQueryCachePtr pvk_in_cache = (cache);
        bool retVal = W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_C_PxScene(this, pvk_in_origin, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags, pvk_in_filterData, pvk_in_filterCall, pvk_in_cache);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				raycast(
    									const PxVec3& origin, const PxVec3& unitDir, const PxReal distance,
    									PxRaycastCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL) const = 0
    #if NATIVE //function start
    ES bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_OL1_C_PxScene(physx::PxScene* self, physx::PxVec3 origin, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags, physx::PxQueryFilterData* filterData, physx::PxQueryFilterCallback* filterCall){
        auto nat_in_origin = (origin);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto nat_in_filterData = (filterData);
        auto nat_in_filterCall = (filterCall);
        auto retVal = self->raycast(nat_in_origin, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags, *nat_in_filterData, nat_in_filterCall);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_OL1_C_PxScene(PxScenePtr selfPtr, PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall);
    
    public  bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall){
        PxVec3 pvk_in_origin = (origin);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        PxQueryFilterCallbackPtr pvk_in_filterCall = (filterCall);
        bool retVal = W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_OL1_C_PxScene(this, pvk_in_origin, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags, pvk_in_filterData, pvk_in_filterCall);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				raycast(
    									const PxVec3& origin, const PxVec3& unitDir, const PxReal distance,
    									PxRaycastCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL) const = 0
    #if NATIVE //function start
    ES bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_OL2_C_PxScene(physx::PxScene* self, physx::PxVec3 origin, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags, physx::PxQueryFilterData* filterData){
        auto nat_in_origin = (origin);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto nat_in_filterData = (filterData);
        auto retVal = self->raycast(nat_in_origin, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags, *nat_in_filterData);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_OL2_C_PxScene(PxScenePtr selfPtr, PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData);
    
    public  bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData){
        PxVec3 pvk_in_origin = (origin);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        bool retVal = W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_OL2_C_PxScene(this, pvk_in_origin, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags, pvk_in_filterData);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				raycast(
    									const PxVec3& origin, const PxVec3& unitDir, const PxReal distance,
    									PxRaycastCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL) const = 0
    #if NATIVE //function start
    ES bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__OL3_C_PxScene(physx::PxScene* self, physx::PxVec3 origin, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags){
        auto nat_in_origin = (origin);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto retVal = self->raycast(nat_in_origin, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__OL3_C_PxScene(PxScenePtr selfPtr, PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags);
    
    public  bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall,  hitFlags){
        PxVec3 pvk_in_origin = (origin);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        bool retVal = W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__P__OL3_C_PxScene(this, pvk_in_origin, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool				raycast(
    									const PxVec3& origin, const PxVec3& unitDir, const PxReal distance,
    									PxRaycastCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL) const = 0
    #if NATIVE //function start
    ES bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__OL4_C_PxScene(physx::PxScene* self, physx::PxVec3 origin, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall){
        auto nat_in_origin = (origin);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto retVal = self->raycast(nat_in_origin, nat_in_unitDir, nat_in_distance, nat_in_hitCall);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__OL4_C_PxScene(PxScenePtr selfPtr, PxVec3 origin, PxVec3 unitDir, float distance,  hitCall);
    
    public  bool raycast(PxVec3 origin, PxVec3 unitDir, float distance,  hitCall){
        PxVec3 pvk_in_origin = (origin);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
        bool retVal = W_raycast_R_bool_P_PxVec3_P_PxVec3_P_float_P__OL4_C_PxScene(this, pvk_in_origin, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       sweep                                                                  #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				sweep(const PxGeometry& geometry, const PxTransform& pose, const PxVec3& unitDir, const PxReal distance,
    									PxSweepCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL, const PxReal inflation = 0.f) const = 0
    #if NATIVE //function start
    ES bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_P_float_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags, physx::PxQueryFilterData* filterData, physx::PxQueryFilterCallback* filterCall, physx::PxQueryCache* cache, physx::PxReal inflation){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto nat_in_filterData = (filterData);
        auto nat_in_filterCall = (filterCall);
        auto nat_in_cache = (cache);
        auto nat_in_inflation = (inflation);
        auto retVal = self->sweep(*nat_in_geometry, nat_in_pose, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags, *nat_in_filterData, nat_in_filterCall, nat_in_cache, nat_in_inflation);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_P_float_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache, float inflation);
    
    public  bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache, float inflation){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        PxQueryFilterCallbackPtr pvk_in_filterCall = (filterCall);
        PxQueryCachePtr pvk_in_cache = (cache);
        float pvk_in_inflation = (inflation);
        bool retVal = W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_P_float_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags, pvk_in_filterData, pvk_in_filterCall, pvk_in_cache, pvk_in_inflation);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				sweep(const PxGeometry& geometry, const PxTransform& pose, const PxVec3& unitDir, const PxReal distance,
    									PxSweepCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL, const PxReal inflation = 0.f) const = 0
    #if NATIVE //function start
    ES bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_OL1_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags, physx::PxQueryFilterData* filterData, physx::PxQueryFilterCallback* filterCall, physx::PxQueryCache* cache){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto nat_in_filterData = (filterData);
        auto nat_in_filterCall = (filterCall);
        auto nat_in_cache = (cache);
        auto retVal = self->sweep(*nat_in_geometry, nat_in_pose, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags, *nat_in_filterData, nat_in_filterCall, nat_in_cache);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_OL1_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache);
    
    public  bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall, PxQueryCachePtr cache){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        PxQueryFilterCallbackPtr pvk_in_filterCall = (filterCall);
        PxQueryCachePtr pvk_in_cache = (cache);
        bool retVal = W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_P_PxQueryCachePtr_OL1_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags, pvk_in_filterData, pvk_in_filterCall, pvk_in_cache);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				sweep(const PxGeometry& geometry, const PxTransform& pose, const PxVec3& unitDir, const PxReal distance,
    									PxSweepCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL, const PxReal inflation = 0.f) const = 0
    #if NATIVE //function start
    ES bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_OL2_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags, physx::PxQueryFilterData* filterData, physx::PxQueryFilterCallback* filterCall){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto nat_in_filterData = (filterData);
        auto nat_in_filterCall = (filterCall);
        auto retVal = self->sweep(*nat_in_geometry, nat_in_pose, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags, *nat_in_filterData, nat_in_filterCall);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_OL2_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall);
    
    public  bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        PxQueryFilterCallbackPtr pvk_in_filterCall = (filterCall);
        bool retVal = W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_OL2_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags, pvk_in_filterData, pvk_in_filterCall);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				sweep(const PxGeometry& geometry, const PxTransform& pose, const PxVec3& unitDir, const PxReal distance,
    									PxSweepCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL, const PxReal inflation = 0.f) const = 0
    #if NATIVE //function start
    ES bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_OL3_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags, physx::PxQueryFilterData* filterData){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto nat_in_filterData = (filterData);
        auto retVal = self->sweep(*nat_in_geometry, nat_in_pose, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags, *nat_in_filterData);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_OL3_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData);
    
    public  bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags, PxQueryFilterDataPtr filterData){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        bool retVal = W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__P_PxQueryFilterDataPtr_OL3_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags, pvk_in_filterData);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    Unresolved parameter type physx::PxHitFlags
    // NATIVE SIG: bool				sweep(const PxGeometry& geometry, const PxTransform& pose, const PxVec3& unitDir, const PxReal distance,
    									PxSweepCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL, const PxReal inflation = 0.f) const = 0
    #if NATIVE //function start
    ES bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__OL4_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall,  hitFlags){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_hitFlags = (hitFlags);
        auto retVal = self->sweep(*nat_in_geometry, nat_in_pose, nat_in_unitDir, nat_in_distance, nat_in_hitCall, nat_in_hitFlags);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__OL4_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags);
    
    public  bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall,  hitFlags){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
         pvk_in_hitFlags = (hitFlags);
        bool retVal = W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__P__OL4_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall, pvk_in_hitFlags);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool				sweep(const PxGeometry& geometry, const PxTransform& pose, const PxVec3& unitDir, const PxReal distance,
    									PxSweepCallback& hitCall, PxHitFlags hitFlags = PxHitFlags(PxHitFlag::eDEFAULT),
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL,
    									const PxQueryCache* cache = NULL, const PxReal inflation = 0.f) const = 0
    #if NATIVE //function start
    ES bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__OL5_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose, physx::PxVec3 unitDir, physx::PxReal distance,  hitCall){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_unitDir = (unitDir);
        auto nat_in_distance = (distance);
        auto nat_in_hitCall = (hitCall);
        auto retVal = self->sweep(*nat_in_geometry, nat_in_pose, nat_in_unitDir, nat_in_distance, nat_in_hitCall);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__OL5_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall);
    
    public  bool sweep(PxGeometryPtr geometry, PxTransform pose, PxVec3 unitDir, float distance,  hitCall){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_unitDir = (unitDir);
        float pvk_in_distance = (distance);
         pvk_in_hitCall = (hitCall);
        bool retVal = W_sweep_R_bool_P_PxGeometryPtr_P_PxTransform_P_PxVec3_P_float_P__OL5_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_unitDir, pvk_in_distance, pvk_in_hitCall);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       overlap                                                                #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool				overlap(const PxGeometry& geometry, const PxTransform& pose, PxOverlapCallback& hitCall,
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL
    									) const = 0
    #if NATIVE //function start
    ES bool W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose,  hitCall, physx::PxQueryFilterData* filterData, physx::PxQueryFilterCallback* filterCall){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_filterData = (filterData);
        auto nat_in_filterCall = (filterCall);
        auto retVal = self->overlap(*nat_in_geometry, nat_in_pose, nat_in_hitCall, *nat_in_filterData, nat_in_filterCall);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose,  hitCall, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall);
    
    public  bool overlap(PxGeometryPtr geometry, PxTransform pose,  hitCall, PxQueryFilterDataPtr filterData, PxQueryFilterCallbackPtr filterCall){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
         pvk_in_hitCall = (hitCall);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        PxQueryFilterCallbackPtr pvk_in_filterCall = (filterCall);
        bool retVal = W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__P_PxQueryFilterDataPtr_P_PxQueryFilterCallbackPtr_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_hitCall, pvk_in_filterData, pvk_in_filterCall);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool				overlap(const PxGeometry& geometry, const PxTransform& pose, PxOverlapCallback& hitCall,
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL
    									) const = 0
    #if NATIVE //function start
    ES bool W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__P_PxQueryFilterDataPtr_OL1_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose,  hitCall, physx::PxQueryFilterData* filterData){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_hitCall = (hitCall);
        auto nat_in_filterData = (filterData);
        auto retVal = self->overlap(*nat_in_geometry, nat_in_pose, nat_in_hitCall, *nat_in_filterData);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__P_PxQueryFilterDataPtr_OL1_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose,  hitCall, PxQueryFilterDataPtr filterData);
    
    public  bool overlap(PxGeometryPtr geometry, PxTransform pose,  hitCall, PxQueryFilterDataPtr filterData){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
         pvk_in_hitCall = (hitCall);
        PxQueryFilterDataPtr pvk_in_filterData = (filterData);
        bool retVal = W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__P_PxQueryFilterDataPtr_OL1_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_hitCall, pvk_in_filterData);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool				overlap(const PxGeometry& geometry, const PxTransform& pose, PxOverlapCallback& hitCall,
    									const PxQueryFilterData& filterData = PxQueryFilterData(), PxQueryFilterCallback* filterCall = NULL
    									) const = 0
    #if NATIVE //function start
    ES bool W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__OL2_C_PxScene(physx::PxScene* self, physx::PxGeometry* geometry, physx::PxTransform pose,  hitCall){
        auto nat_in_geometry = (geometry);
        auto nat_in_pose = (pose);
        auto nat_in_hitCall = (hitCall);
        auto retVal = self->overlap(*nat_in_geometry, nat_in_pose, nat_in_hitCall);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__OL2_C_PxScene(PxScenePtr selfPtr, PxGeometryPtr geometry, PxTransform pose,  hitCall);
    
    public  bool overlap(PxGeometryPtr geometry, PxTransform pose,  hitCall){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxTransform pvk_in_pose = (pose);
         pvk_in_hitCall = (hitCall);
        bool retVal = W_overlap_R_bool_P_PxGeometryPtr_P_PxTransform_P__OL2_C_PxScene(this, pvk_in_geometry, pvk_in_pose, pvk_in_hitCall);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       getSceneQueryStaticTimestamp                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getSceneQueryStaticTimestamp_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getSceneQueryStaticTimestamp();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getSceneQueryStaticTimestamp_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getSceneQueryStaticTimestamp(){
        uint retVal = W_getSceneQueryStaticTimestamp_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBroadPhaseType                                                      #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxBroadPhaseType::Enum	getBroadPhaseType()								const = 0
    #if NATIVE //function start
    ES physx::PxBroadPhaseType::Enum W_getBroadPhaseType_R_PxBroadPhaseType_C_PxScene(physx::PxScene* self){
        auto retVal = self->getBroadPhaseType();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBroadPhaseType W_getBroadPhaseType_R_PxBroadPhaseType_C_PxScene(PxScenePtr selfPtr);
    
    public  PxBroadPhaseType getBroadPhaseType(){
        PxBroadPhaseType retVal = W_getBroadPhaseType_R_PxBroadPhaseType_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getBroadPhaseCaps                                                      #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxBroadPhaseCaps
    // NATIVE SIG: bool					getBroadPhaseCaps(PxBroadPhaseCaps& caps)			const = 0
    #if NATIVE //function start
    ES bool W_getBroadPhaseCaps_R_bool_P__C_PxScene(physx::PxScene* self,  caps){
        auto nat_in_caps = (caps);
        auto retVal = self->getBroadPhaseCaps(nat_in_caps);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getBroadPhaseCaps_R_bool_P__C_PxScene(PxScenePtr selfPtr,  caps);
    
    public  bool getBroadPhaseCaps( caps){
         pvk_in_caps = (caps);
        bool retVal = W_getBroadPhaseCaps_R_bool_P__C_PxScene(this, pvk_in_caps);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbBroadPhaseRegions                                                 #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbBroadPhaseRegions_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getNbBroadPhaseRegions();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbBroadPhaseRegions_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getNbBroadPhaseRegions(){
        uint retVal = W_getNbBroadPhaseRegions_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBroadPhaseRegions                                                   #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBroadPhaseRegionInfoPtr
    // NATIVE SIG: PxU32					getBroadPhaseRegions(PxBroadPhaseRegionInfo* userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getBroadPhaseRegions_R_uint_P_PxBroadPhaseRegionInfoPtr_P_uint_P_uint_C_PxScene(physx::PxScene* self, physx::PxBroadPhaseRegionInfo* userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getBroadPhaseRegions(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getBroadPhaseRegions_R_uint_P_PxBroadPhaseRegionInfoPtr_P_uint_P_uint_C_PxScene(PxScenePtr selfPtr, PxBroadPhaseRegionInfoPtr userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getBroadPhaseRegions(PxBroadPhaseRegionInfoPtr userBuffer, uint bufferSize, uint startIndex){
        PxBroadPhaseRegionInfoPtr pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getBroadPhaseRegions_R_uint_P_PxBroadPhaseRegionInfoPtr_P_uint_P_uint_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBroadPhaseRegionInfoPtr
    // NATIVE SIG: PxU32					getBroadPhaseRegions(PxBroadPhaseRegionInfo* userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getBroadPhaseRegions_R_uint_P_PxBroadPhaseRegionInfoPtr_P_uint_OL1_C_PxScene(physx::PxScene* self, physx::PxBroadPhaseRegionInfo* userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getBroadPhaseRegions(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getBroadPhaseRegions_R_uint_P_PxBroadPhaseRegionInfoPtr_P_uint_OL1_C_PxScene(PxScenePtr selfPtr, PxBroadPhaseRegionInfoPtr userBuffer, uint bufferSize);
    
    public  uint getBroadPhaseRegions(PxBroadPhaseRegionInfoPtr userBuffer, uint bufferSize){
        PxBroadPhaseRegionInfoPtr pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getBroadPhaseRegions_R_uint_P_PxBroadPhaseRegionInfoPtr_P_uint_OL1_C_PxScene(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       addBroadPhaseRegion                                                    #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBroadPhaseRegionPtr
    // NATIVE SIG: PxU32					addBroadPhaseRegion(const PxBroadPhaseRegion& region, bool populateRegion=false)		= 0
    #if NATIVE //function start
    ES physx::PxU32 W_addBroadPhaseRegion_R_uint_P_PxBroadPhaseRegionPtr_P_bool_C_PxScene(physx::PxScene* self, physx::PxBroadPhaseRegion* region, bool populateRegion){
        auto nat_in_region = (region);
        auto nat_in_populateRegion = (populateRegion);
        auto retVal = self->addBroadPhaseRegion(*nat_in_region, nat_in_populateRegion);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_addBroadPhaseRegion_R_uint_P_PxBroadPhaseRegionPtr_P_bool_C_PxScene(PxScenePtr selfPtr, PxBroadPhaseRegionPtr region, bool populateRegion);
    
    public  uint addBroadPhaseRegion(PxBroadPhaseRegionPtr region, bool populateRegion){
        PxBroadPhaseRegionPtr pvk_in_region = (region);
        bool pvk_in_populateRegion = (populateRegion);
        uint retVal = W_addBroadPhaseRegion_R_uint_P_PxBroadPhaseRegionPtr_P_bool_C_PxScene(this, pvk_in_region, pvk_in_populateRegion);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBroadPhaseRegionPtr
    // NATIVE SIG: PxU32					addBroadPhaseRegion(const PxBroadPhaseRegion& region, bool populateRegion=false)		= 0
    #if NATIVE //function start
    ES physx::PxU32 W_addBroadPhaseRegion_R_uint_P_PxBroadPhaseRegionPtr_OL1_C_PxScene(physx::PxScene* self, physx::PxBroadPhaseRegion* region){
        auto nat_in_region = (region);
        auto retVal = self->addBroadPhaseRegion(*nat_in_region);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_addBroadPhaseRegion_R_uint_P_PxBroadPhaseRegionPtr_OL1_C_PxScene(PxScenePtr selfPtr, PxBroadPhaseRegionPtr region);
    
    public  uint addBroadPhaseRegion(PxBroadPhaseRegionPtr region){
        PxBroadPhaseRegionPtr pvk_in_region = (region);
        uint retVal = W_addBroadPhaseRegion_R_uint_P_PxBroadPhaseRegionPtr_OL1_C_PxScene(this, pvk_in_region);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       removeBroadPhaseRegion                                                 #
    //================================================================================
    #if NATIVE //function start
    ES bool W_removeBroadPhaseRegion_R_bool_P_uint_C_PxScene(physx::PxScene* self, physx::PxU32 handle){
        auto nat_in_handle = (handle);
        auto retVal = self->removeBroadPhaseRegion(nat_in_handle);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_removeBroadPhaseRegion_R_bool_P_uint_C_PxScene(PxScenePtr selfPtr, uint handle);
    
    public  bool removeBroadPhaseRegion(uint handle){
        uint pvk_in_handle = (handle);
        bool retVal = W_removeBroadPhaseRegion_R_bool_P_uint_C_PxScene(this, pvk_in_handle);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTaskManager                                                         #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTaskManager*			getTaskManager() const = 0
    #if NATIVE //function start
    ES const physx::PxTaskManager* W_getTaskManager_R_PxTaskManagerPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getTaskManager();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTaskManagerPtr W_getTaskManager_R_PxTaskManagerPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxTaskManagerPtr getTaskManager(){
        PxTaskManagerPtr retVal = W_getTaskManager_R_PxTaskManagerPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       lockRead                                                               #
    //================================================================================
    #if NATIVE //function start
    ES void W_lockRead_R_void_P_string_P_uint_C_PxScene(physx::PxScene* self, const char* file, physx::PxU32 line){
        auto nat_in_file = (file);
        auto nat_in_line = (line);
        self->lockRead(nat_in_file, nat_in_line);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_lockRead_R_void_P_string_P_uint_C_PxScene(PxScenePtr selfPtr, string file, uint line);
    
    public  void lockRead(string file, uint line){
        string pvk_in_file = (file);
        uint pvk_in_line = (line);
        W_lockRead_R_void_P_string_P_uint_C_PxScene(this, pvk_in_file, pvk_in_line);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_lockRead_R_void_P_string_OL1_C_PxScene(physx::PxScene* self, const char* file){
        auto nat_in_file = (file);
        self->lockRead(nat_in_file);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_lockRead_R_void_P_string_OL1_C_PxScene(PxScenePtr selfPtr, string file);
    
    public  void lockRead(string file){
        string pvk_in_file = (file);
        W_lockRead_R_void_P_string_OL1_C_PxScene(this, pvk_in_file);
    }
    #endif //function end
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_lockRead_R_void_OL2_C_PxScene(physx::PxScene* self){
        self->lockRead();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_lockRead_R_void_OL2_C_PxScene(PxScenePtr selfPtr);
    
    public  void lockRead(){
        W_lockRead_R_void_OL2_C_PxScene(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       unlockRead                                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_unlockRead_R_void_C_PxScene(physx::PxScene* self){
        self->unlockRead();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_unlockRead_R_void_C_PxScene(PxScenePtr selfPtr);
    
    public  void unlockRead(){
        W_unlockRead_R_void_C_PxScene(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       lockWrite                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_lockWrite_R_void_P_string_P_uint_C_PxScene(physx::PxScene* self, const char* file, physx::PxU32 line){
        auto nat_in_file = (file);
        auto nat_in_line = (line);
        self->lockWrite(nat_in_file, nat_in_line);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_lockWrite_R_void_P_string_P_uint_C_PxScene(PxScenePtr selfPtr, string file, uint line);
    
    public  void lockWrite(string file, uint line){
        string pvk_in_file = (file);
        uint pvk_in_line = (line);
        W_lockWrite_R_void_P_string_P_uint_C_PxScene(this, pvk_in_file, pvk_in_line);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_lockWrite_R_void_P_string_OL1_C_PxScene(physx::PxScene* self, const char* file){
        auto nat_in_file = (file);
        self->lockWrite(nat_in_file);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_lockWrite_R_void_P_string_OL1_C_PxScene(PxScenePtr selfPtr, string file);
    
    public  void lockWrite(string file){
        string pvk_in_file = (file);
        W_lockWrite_R_void_P_string_OL1_C_PxScene(this, pvk_in_file);
    }
    #endif //function end
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_lockWrite_R_void_OL2_C_PxScene(physx::PxScene* self){
        self->lockWrite();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_lockWrite_R_void_OL2_C_PxScene(PxScenePtr selfPtr);
    
    public  void lockWrite(){
        W_lockWrite_R_void_OL2_C_PxScene(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       unlockWrite                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void W_unlockWrite_R_void_C_PxScene(physx::PxScene* self){
        self->unlockWrite();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_unlockWrite_R_void_C_PxScene(PxScenePtr selfPtr);
    
    public  void unlockWrite(){
        W_unlockWrite_R_void_C_PxScene(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setNbContactDataBlocks                                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_setNbContactDataBlocks_R_void_P_uint_C_PxScene(physx::PxScene* self, physx::PxU32 numBlocks){
        auto nat_in_numBlocks = (numBlocks);
        self->setNbContactDataBlocks(nat_in_numBlocks);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setNbContactDataBlocks_R_void_P_uint_C_PxScene(PxScenePtr selfPtr, uint numBlocks);
    
    public  void setNbContactDataBlocks(uint numBlocks){
        uint pvk_in_numBlocks = (numBlocks);
        W_setNbContactDataBlocks_R_void_P_uint_C_PxScene(this, pvk_in_numBlocks);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNbContactDataBlocksUsed                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbContactDataBlocksUsed_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getNbContactDataBlocksUsed();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbContactDataBlocksUsed_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getNbContactDataBlocksUsed(){
        uint retVal = W_getNbContactDataBlocksUsed_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMaxNbContactDataBlocksUsed                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getMaxNbContactDataBlocksUsed_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getMaxNbContactDataBlocksUsed();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaxNbContactDataBlocksUsed_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getMaxNbContactDataBlocksUsed(){
        uint retVal = W_getMaxNbContactDataBlocksUsed_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getContactReportStreamBufferSize                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getContactReportStreamBufferSize_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getContactReportStreamBufferSize();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getContactReportStreamBufferSize_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getContactReportStreamBufferSize(){
        uint retVal = W_getContactReportStreamBufferSize_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setSolverBatchSize                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_setSolverBatchSize_R_void_P_uint_C_PxScene(physx::PxScene* self, physx::PxU32 solverBatchSize){
        auto nat_in_solverBatchSize = (solverBatchSize);
        self->setSolverBatchSize(nat_in_solverBatchSize);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSolverBatchSize_R_void_P_uint_C_PxScene(PxScenePtr selfPtr, uint solverBatchSize);
    
    public  void setSolverBatchSize(uint solverBatchSize){
        uint pvk_in_solverBatchSize = (solverBatchSize);
        W_setSolverBatchSize_R_void_P_uint_C_PxScene(this, pvk_in_solverBatchSize);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getSolverBatchSize                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getSolverBatchSize_R_uint_C_PxScene(physx::PxScene* self){
        auto retVal = self->getSolverBatchSize();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getSolverBatchSize_R_uint_C_PxScene(PxScenePtr selfPtr);
    
    public  uint getSolverBatchSize(){
        uint retVal = W_getSolverBatchSize_R_uint_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getWakeCounterResetValue                                               #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getWakeCounterResetValue_R_float_C_PxScene(physx::PxScene* self){
        auto retVal = self->getWakeCounterResetValue();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getWakeCounterResetValue_R_float_C_PxScene(PxScenePtr selfPtr);
    
    public  float getWakeCounterResetValue(){
        float retVal = W_getWakeCounterResetValue_R_float_C_PxScene(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       shiftOrigin                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void W_shiftOrigin_R_void_P_PxVec3_C_PxScene(physx::PxScene* self, physx::PxVec3 shift){
        auto nat_in_shift = (shift);
        self->shiftOrigin(nat_in_shift);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_shiftOrigin_R_void_P_PxVec3_C_PxScene(PxScenePtr selfPtr, PxVec3 shift);
    
    public  void shiftOrigin(PxVec3 shift){
        PxVec3 pvk_in_shift = (shift);
        W_shiftOrigin_R_void_P_PxVec3_C_PxScene(this, pvk_in_shift);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getScenePvdClient                                                      #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxPvdSceneClient*		getScenePvdClient() = 0
    #if NATIVE //function start
    ES physx::PxPvdSceneClient* W_getScenePvdClient_R_PxPvdSceneClientPtr_C_PxScene(physx::PxScene* self){
        auto retVal = self->getScenePvdClient();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPvdSceneClientPtr W_getScenePvdClient_R_PxPvdSceneClientPtr_C_PxScene(PxScenePtr selfPtr);
    
    public  PxPvdSceneClientPtr getScenePvdClient(){
        PxPvdSceneClientPtr retVal = W_getScenePvdClient_R_PxPvdSceneClientPtr_C_PxScene(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxScene
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxPruningStructure Manually Ignored
// Class physx::PxActorTypeFlag is enum namespace
#if !NATIVE //interface
public unsafe interface IPxDominanceGroupPairPtr {
    // PxDominanceGroupPair(byte a, byte b);
    // PxDominanceGroupPair(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxDominanceGroupPairPtr lhs, /*NULLPARS*/);
    // PxDominanceGroupPair(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxDominanceGroupPairPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxDominanceGroupPair(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxDominanceGroupPairPtr : IPxDominanceGroupPairPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields

    // ### DOMINANCE0 getter/setter
    #if NATIVE //getter
    ES physx::PxU8 PxDominanceGroupPair_GET_dominance0(PxDominanceGroupPair* self) {return self->dominance0;}
    ES void PxDominanceGroupPair_SET_dominance0(PxDominanceGroupPair* self, physx::PxU8 value) {self->dominance0 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte PxDominanceGroupPair_GET_dominance0(PxDominanceGroupPairPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxDominanceGroupPair_SET_dominance0(PxDominanceGroupPairPtr selfPtr, byte value);

    public byte dominance0 {
        get => PxDominanceGroupPair_GET_dominance0(this);
        set => PxDominanceGroupPair_SET_dominance0(this, value);
    }
    #endif //getter

    // ### DOMINANCE1 getter/setter
    #if NATIVE //getter
    ES physx::PxU8 PxDominanceGroupPair_GET_dominance1(PxDominanceGroupPair* self) {return self->dominance1;}
    ES void PxDominanceGroupPair_SET_dominance1(PxDominanceGroupPair* self, physx::PxU8 value) {self->dominance1 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte PxDominanceGroupPair_GET_dominance1(PxDominanceGroupPairPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxDominanceGroupPair_SET_dominance1(PxDominanceGroupPairPtr selfPtr, byte value);

    public byte dominance1 {
        get => PxDominanceGroupPair_GET_dominance1(this);
        set => PxDominanceGroupPair_SET_dominance1(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxDominanceGroupPairPtr
    #endif //hierarchy
    //================================================================================
    //#       PxDominanceGroupPair                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxDominanceGroupPair
    // NATIVE SIG: PxDominanceGroupPair(PxU8 a, PxU8 b) 
    		: dominance0(a), dominance1(b) {}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxDominanceGroupPair_R_PxDominanceGroupPairPtr_P_byte_P_byte_C_PxDominanceGroupPair_ctor(physx::PxU8 a, physx::PxU8 b){
        auto nat_in_a = (a);
        auto nat_in_b = (b);
        return PxDominanceGroupPair(nat_in_a, nat_in_b);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxDominanceGroupPair_R_PxDominanceGroupPairPtr_P_byte_P_byte_C_PxDominanceGroupPair_ctor(byte a, byte b);
    
    public  PxDominanceGroupPair(byte a, byte b){
        byte pvk_in_a = (a);
        byte pvk_in_b = (b);
        var _new = W_PxDominanceGroupPair_R_PxDominanceGroupPairPtr_P_byte_P_byte_C_PxDominanceGroupPair_ctor(pvk_in_a, pvk_in_b);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: PxDominanceGroupPair
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxDominanceGroupPair
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxDominanceGroupPair
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxSimulationEventCallback Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxContactPairHeaderPtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxContactPairHeaderPtr : IPxContactPairHeaderPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxContactPairHeaderPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxRenderBuffer Manually Ignored
// Class physx::PxBatchQuery Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxBatchQueryDescPtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxBatchQueryDescPtr : IPxBatchQueryDescPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBatchQueryDescPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxQueryCachePtr {
    // PxQueryCache();
    // PxQueryCache(PxShapePtr s, uint findex);
    // PxQueryCache(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryCachePtr lhs, /*NULLPARS*/);
    // PxQueryCache(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryCachePtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxQueryCache(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxQueryCachePtr : IPxQueryCachePtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields

    // ### SHAPE getter/setter
    #if NATIVE //getter
    ES physx::PxShape* PxQueryCache_GET_shape(PxQueryCache* self) {return self->shape;}
    ES void PxQueryCache_SET_shape(PxQueryCache* self, physx::PxShape* value) {self->shape = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr PxQueryCache_GET_shape(PxQueryCachePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxQueryCache_SET_shape(PxQueryCachePtr selfPtr, PxShapePtr value);

    public PxShapePtr shape {
        get => PxQueryCache_GET_shape(this);
        set => PxQueryCache_SET_shape(this, value);
    }
    #endif //getter

    // ### ACTOR getter/setter
    #if NATIVE //getter
    ES physx::PxRigidActor* PxQueryCache_GET_actor(PxQueryCache* self) {return self->actor;}
    ES void PxQueryCache_SET_actor(PxQueryCache* self, physx::PxRigidActor* value) {self->actor = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidActorPtr PxQueryCache_GET_actor(PxQueryCachePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxQueryCache_SET_actor(PxQueryCachePtr selfPtr, PxRigidActorPtr value);

    public PxRigidActorPtr actor {
        get => PxQueryCache_GET_actor(this);
        set => PxQueryCache_SET_actor(this, value);
    }
    #endif //getter

    // ### FACEINDEX getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxQueryCache_GET_faceIndex(PxQueryCache* self) {return self->faceIndex;}
    ES void PxQueryCache_SET_faceIndex(PxQueryCache* self, physx::PxU32 value) {self->faceIndex = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxQueryCache_GET_faceIndex(PxQueryCachePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxQueryCache_SET_faceIndex(PxQueryCachePtr selfPtr, uint value);

    public uint faceIndex {
        get => PxQueryCache_GET_faceIndex(this);
        set => PxQueryCache_SET_faceIndex(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxQueryCachePtr
    #endif //hierarchy
    //================================================================================
    //#       PxQueryCache                                                           #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxQueryCache
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxQueryCache                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxQueryCache
    // NATIVE SIG: PX_INLINE PxQueryCache(PxShape* s, PxU32 findex) : shape(s), actor(NULL), faceIndex(findex) {}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxQueryCache_R_PxQueryCachePtr_P_PxShapePtr_P_uint_C_PxQueryCache_ctor(physx::PxShape* s, physx::PxU32 findex){
        auto nat_in_s = (s);
        auto nat_in_findex = (findex);
        return PxQueryCache(nat_in_s, nat_in_findex);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxQueryCache_R_PxQueryCachePtr_P_PxShapePtr_P_uint_C_PxQueryCache_ctor(PxShapePtr s, uint findex);
    
    public  PxQueryCache(PxShapePtr s, uint findex){
        PxShapePtr pvk_in_s = (s);
        uint pvk_in_findex = (findex);
        var _new = W_PxQueryCache_R_PxQueryCachePtr_P_PxShapePtr_P_uint_C_PxQueryCache_ctor(pvk_in_s, pvk_in_findex);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: PxQueryCache
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxQueryCache
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxQueryCache
    

#if !NATIVE //struct close
}
#endif //struct close
