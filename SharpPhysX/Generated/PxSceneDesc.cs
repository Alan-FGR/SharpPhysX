#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxSceneFlag : int {
    eENABLE_ACTIVE_ACTORS = 1,                     // eENABLE_ACTIVE_ACTORS = (1<<0)
    eENABLE_CCD = 2,                               // eENABLE_CCD = (1<<1)
    eDISABLE_CCD_RESWEEP = 4,                      // eDISABLE_CCD_RESWEEP = (1<<2)
    eADAPTIVE_FORCE = 8,                           // eADAPTIVE_FORCE = (1<<3)
    eENABLE_KINEMATIC_STATIC_PAIRS = 16,           // eENABLE_KINEMATIC_STATIC_PAIRS PX_DEPRECATED = (1<<4)
    eENABLE_KINEMATIC_PAIRS = 32,                  // eENABLE_KINEMATIC_PAIRS PX_DEPRECATED = (1<<5)
    eENABLE_PCM = 64,                              // eENABLE_PCM = (1 << 6)
    eDISABLE_CONTACT_REPORT_BUFFER_RESIZE = 128,   // eDISABLE_CONTACT_REPORT_BUFFER_RESIZE = (1 << 7)
    eDISABLE_CONTACT_CACHE = 256,                  // eDISABLE_CONTACT_CACHE = (1 << 8)
    eREQUIRE_RW_LOCK = 512,                        // eREQUIRE_RW_LOCK = (1 << 9)
    eENABLE_STABILIZATION = 1024,                  // eENABLE_STABILIZATION = (1 << 10)
    eENABLE_AVERAGE_POINT = 2048,                  // eENABLE_AVERAGE_POINT = (1 << 11)
    eEXCLUDE_KINEMATICS_FROM_ACTIVE_ACTORS = 4096, // eEXCLUDE_KINEMATICS_FROM_ACTIVE_ACTORS = (1 << 12)
    eENABLE_GPU_DYNAMICS = 8192,                   // eENABLE_GPU_DYNAMICS = (1 << 13)
    eENABLE_ENHANCED_DETERMINISM = 16384,          // eENABLE_ENHANCED_DETERMINISM = (1<<14)
    eENABLE_FRICTION_EVERY_ITERATION = 32768,      // eENABLE_FRICTION_EVERY_ITERATION = (1 << 15)
    eMUTABLE_FLAGS = 4097,                         // eMUTABLE_FLAGS = eENABLE_ACTIVE_ACTORS|eEXCLUDE_KINEMATICS_FROM_ACTIVE_ACTORS
}
#endif //enum

#if !NATIVE //enum
public enum PxFrictionType : int {
    ePATCH = 0,           // ePATCH
    eONE_DIRECTIONAL = 1, // eONE_DIRECTIONAL
    eTWO_DIRECTIONAL = 2, // eTWO_DIRECTIONAL
    eFRICTION_COUNT = 3,  // eFRICTION_COUNT
}
#endif //enum

#if !NATIVE //enum
public enum PxPruningStructureType : int {
    eNONE = 0,              // eNONE
    eDYNAMIC_AABB_TREE = 1, // eDYNAMIC_AABB_TREE
    eSTATIC_AABB_TREE = 2,  // eSTATIC_AABB_TREE
    eLAST = 3,              // eLAST
}
#endif //enum

#if !NATIVE //enum
public enum PxSceneQueryUpdateMode : int {
    eBUILD_ENABLED_COMMIT_ENABLED = 0,   // eBUILD_ENABLED_COMMIT_ENABLED
    eBUILD_ENABLED_COMMIT_DISABLED = 1,  // eBUILD_ENABLED_COMMIT_DISABLED
    eBUILD_DISABLED_COMMIT_DISABLED = 2, // eBUILD_DISABLED_COMMIT_DISABLED
}
#endif //enum

#if !NATIVE //enum
public enum PxSolverType : int {
    ePGS = 0, // ePGS
    eTGS = 1, // eTGS
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxSceneDescPtr {
#endif

//================================================================================
//#       operator|(PxSceneFlag a, PxSceneFlag b)                                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int> -> PxFlags_PxSceneFlag_uint
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag_P_PxSceneFlag(physx::PxSceneFlag::Enum a, physx::PxSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag_P_PxSceneFlag(PxSceneFlag a, PxSceneFlag b);

public static UNPARSED_TYPE operator|(PxSceneFlag a, PxSceneFlag b){
    PxSceneFlag pvk_in_a = (a);
    PxSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag_P_PxSceneFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxSceneFlag a, PxSceneFlag b)                                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int> -> PxFlags_PxSceneFlag_uint
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag_P_PxSceneFlag(physx::PxSceneFlag::Enum a, physx::PxSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag_P_PxSceneFlag(PxSceneFlag a, PxSceneFlag b);

public static UNPARSED_TYPE operator&(PxSceneFlag a, PxSceneFlag b){
    PxSceneFlag pvk_in_a = (a);
    PxSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag_P_PxSceneFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxSceneFlag a)                                               #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int> -> PxFlags_PxSceneFlag_uint
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag(physx::PxSceneFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag(PxSceneFlag a);

public static UNPARSED_TYPE operator~(PxSceneFlag a){
    PxSceneFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxSceneFlag_uint_P_PxSceneFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxSceneDescPtr
#endif


// Class physx::PxSceneFlag is enum namespace
#if !NATIVE //interface
public unsafe interface IPxSceneLimitsPtr {
    // static PxSceneLimitsPtr New();
     void setToDefault();
     bool isValid();
    // static PxSceneLimitsPtr New(/*NULLPARS*/);
    // static PxSceneLimitsPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxSceneLimits(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSceneLimitsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSceneLimitsPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSceneLimitsPtr : IPxSceneLimitsPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSceneLimitsPtrPOD{
    physx::PxU32 maxNbActors;
    physx::PxU32 maxNbBodies;
    physx::PxU32 maxNbStaticShapes;
    physx::PxU32 maxNbDynamicShapes;
    physx::PxU32 maxNbAggregates;
    physx::PxU32 maxNbConstraints;
    physx::PxU32 maxNbRegions;
    physx::PxU32 maxNbBroadPhaseOverlaps;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### MAXNBACTORS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbActors(PxSceneLimits* self) {return self->maxNbActors;}
    ES void PxSceneLimits_SET_maxNbActors(PxSceneLimits* self, physx::PxU32 value) {self->maxNbActors = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbActors(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbActors(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbActors {
        get => PxSceneLimits_GET_maxNbActors(this);
        set => PxSceneLimits_SET_maxNbActors(this, value);
    }
    #endif //getter

    // ### MAXNBBODIES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbBodies(PxSceneLimits* self) {return self->maxNbBodies;}
    ES void PxSceneLimits_SET_maxNbBodies(PxSceneLimits* self, physx::PxU32 value) {self->maxNbBodies = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbBodies(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbBodies(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbBodies {
        get => PxSceneLimits_GET_maxNbBodies(this);
        set => PxSceneLimits_SET_maxNbBodies(this, value);
    }
    #endif //getter

    // ### MAXNBSTATICSHAPES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbStaticShapes(PxSceneLimits* self) {return self->maxNbStaticShapes;}
    ES void PxSceneLimits_SET_maxNbStaticShapes(PxSceneLimits* self, physx::PxU32 value) {self->maxNbStaticShapes = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbStaticShapes(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbStaticShapes(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbStaticShapes {
        get => PxSceneLimits_GET_maxNbStaticShapes(this);
        set => PxSceneLimits_SET_maxNbStaticShapes(this, value);
    }
    #endif //getter

    // ### MAXNBDYNAMICSHAPES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbDynamicShapes(PxSceneLimits* self) {return self->maxNbDynamicShapes;}
    ES void PxSceneLimits_SET_maxNbDynamicShapes(PxSceneLimits* self, physx::PxU32 value) {self->maxNbDynamicShapes = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbDynamicShapes(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbDynamicShapes(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbDynamicShapes {
        get => PxSceneLimits_GET_maxNbDynamicShapes(this);
        set => PxSceneLimits_SET_maxNbDynamicShapes(this, value);
    }
    #endif //getter

    // ### MAXNBAGGREGATES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbAggregates(PxSceneLimits* self) {return self->maxNbAggregates;}
    ES void PxSceneLimits_SET_maxNbAggregates(PxSceneLimits* self, physx::PxU32 value) {self->maxNbAggregates = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbAggregates(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbAggregates(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbAggregates {
        get => PxSceneLimits_GET_maxNbAggregates(this);
        set => PxSceneLimits_SET_maxNbAggregates(this, value);
    }
    #endif //getter

    // ### MAXNBCONSTRAINTS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbConstraints(PxSceneLimits* self) {return self->maxNbConstraints;}
    ES void PxSceneLimits_SET_maxNbConstraints(PxSceneLimits* self, physx::PxU32 value) {self->maxNbConstraints = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbConstraints(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbConstraints(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbConstraints {
        get => PxSceneLimits_GET_maxNbConstraints(this);
        set => PxSceneLimits_SET_maxNbConstraints(this, value);
    }
    #endif //getter

    // ### MAXNBREGIONS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbRegions(PxSceneLimits* self) {return self->maxNbRegions;}
    ES void PxSceneLimits_SET_maxNbRegions(PxSceneLimits* self, physx::PxU32 value) {self->maxNbRegions = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbRegions(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbRegions(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbRegions {
        get => PxSceneLimits_GET_maxNbRegions(this);
        set => PxSceneLimits_SET_maxNbRegions(this, value);
    }
    #endif //getter

    // ### MAXNBBROADPHASEOVERLAPS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneLimits_GET_maxNbBroadPhaseOverlaps(PxSceneLimits* self) {return self->maxNbBroadPhaseOverlaps;}
    ES void PxSceneLimits_SET_maxNbBroadPhaseOverlaps(PxSceneLimits* self, physx::PxU32 value) {self->maxNbBroadPhaseOverlaps = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneLimits_GET_maxNbBroadPhaseOverlaps(PxSceneLimitsPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneLimits_SET_maxNbBroadPhaseOverlaps(PxSceneLimitsPtr selfPtr, uint value);

    public uint maxNbBroadPhaseOverlaps {
        get => PxSceneLimits_GET_maxNbBroadPhaseOverlaps(this);
        set => PxSceneLimits_SET_maxNbBroadPhaseOverlaps(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxSceneLimitsPtr
    #endif //hierarchy
    //================================================================================
    //#       PxSceneLimits()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxSceneLimitsPtrPOD W_PxSceneLimits_R_PxSceneLimitsPtr_C_PxSceneLimits_ctor(){
        auto val = new PxSceneLimits();
        return *(PxSceneLimitsPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSceneLimitsPtr W_PxSceneLimits_R_PxSceneLimitsPtr_C_PxSceneLimits_ctor();
    
    public  static PxSceneLimitsPtr New(){
        var _new = W_PxSceneLimits_R_PxSceneLimitsPtr_C_PxSceneLimits_ctor();
        PxSceneLimitsPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setToDefault()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES void W_setToDefault_R_void_C_PxSceneLimits(physx::PxSceneLimits* self){
        self->setToDefault();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setToDefault_R_void_C_PxSceneLimits(PxSceneLimitsPtr selfPtr);
    
    public  void setToDefault(){
        W_setToDefault_R_void_C_PxSceneLimits(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxSceneLimits(physx::PxSceneLimits* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxSceneLimits(PxSceneLimitsPtr selfPtr);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxSceneLimits(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxSceneLimits
    
    //Skipped generated implicit entry: PxSceneLimits
    
    //Skipped generated implicit entry: ~PxSceneLimits
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxSimulationEventCallback Manually Ignored
// Class physx::PxContactModifyCallback Manually Ignored
// Class physx::PxCCDContactModifyCallback Manually Ignored
// Class physx::PxFrictionType is enum namespace
// Class physx::PxPruningStructureType is enum namespace
// Class physx::PxSceneQueryUpdateMode is enum namespace
#if !NATIVE //interface
public unsafe interface IPxSceneDescPtr {
    // static PxSceneDescPtr New(PxTolerancesScale scale);
     void setToDefault(PxTolerancesScale scale);
     bool isValid();
     PxTolerancesScale getTolerancesScale();
    // static PxSceneDescPtr New(/*NULLPARS*/);
    // static PxSceneDescPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSceneDescPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxSceneDesc(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSceneDescPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSceneDescPtr : IPxSceneDescPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSceneDescPtrPOD{
    physx::PxVec3 gravity;
    physx::PxSimulationEventCallback* simulationEventCallback;
    physx::PxContactModifyCallback* contactModifyCallback;
    physx::PxCCDContactModifyCallback* ccdContactModifyCallback;
    const void* filterShaderData;
    physx::PxU32 filterShaderDataSize;
    physx::PxSimulationFilterShader filterShader;
    physx::PxSimulationFilterCallback* filterCallback;
    physx::PxPairFilteringMode::Enum kineKineFilteringMode;
    physx::PxPairFilteringMode::Enum staticKineFilteringMode;
    physx::PxBroadPhaseType::Enum broadPhaseType;
    physx::PxBroadPhaseCallback* broadPhaseCallback;
    physx::PxSceneLimits limits;
    physx::PxFrictionType::Enum frictionType;
    physx::PxSolverType::Enum solverType;
    physx::PxReal bounceThresholdVelocity;
    physx::PxReal frictionOffsetThreshold;
    physx::PxReal ccdMaxSeparation;
    physx::PxReal solverOffsetSlop;
    physx::PxSceneFlags flags;
    physx::PxCpuDispatcher* cpuDispatcher;
    physx::PxGpuDispatcher* gpuDispatcher;
    physx::PxPruningStructureType::Enum staticStructure;
    physx::PxPruningStructureType::Enum dynamicStructure;
    physx::PxU32 dynamicTreeRebuildRateHint;
    physx::PxSceneQueryUpdateMode::Enum sceneQueryUpdateMode;
    void* userData;
    physx::PxU32 solverBatchSize;
    physx::PxU32 nbContactDataBlocks;
    physx::PxU32 maxNbContactDataBlocks;
    physx::PxReal maxBiasCoefficient;
    physx::PxU32 contactReportStreamBufferSize;
    physx::PxU32 ccdMaxPasses;
    physx::PxReal wakeCounterResetValue;
    physx::PxBounds3 sanityBounds;
    physx::PxgDynamicsMemoryConfig gpuDynamicsConfig;
    physx::PxU32 gpuMaxNumPartitions;
    physx::PxU32 gpuComputeVersion;
    physx::PxTolerancesScale tolerancesScale;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### GRAVITY getter/setter
    #if NATIVE //getter
    ES physx::PxVec3 PxSceneDesc_GET_gravity(PxSceneDesc* self) {return self->gravity;}
    ES void PxSceneDesc_SET_gravity(PxSceneDesc* self, physx::PxVec3 value) {self->gravity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 PxSceneDesc_GET_gravity(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_gravity(PxSceneDescPtr selfPtr, PxVec3 value);

    public PxVec3 gravity {
        get => PxSceneDesc_GET_gravity(this);
        set => PxSceneDesc_SET_gravity(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Forbidden parameter type: PxSimulationEventCallbackPtr
    */
    
    /*Error generating getter/setter: Forbidden parameter type: PxContactModifyCallbackPtr
    */
    
    /*Error generating getter/setter: Forbidden parameter type: PxCCDContactModifyCallbackPtr
    */

    // ### FILTERSHADERDATA getter/setter
    #if NATIVE //getter
    ES const void* PxSceneDesc_GET_filterShaderData(PxSceneDesc* self) {return self->filterShaderData;}
    ES void PxSceneDesc_SET_filterShaderData(PxSceneDesc* self, const void* value) {self->filterShaderData = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr PxSceneDesc_GET_filterShaderData(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_filterShaderData(PxSceneDescPtr selfPtr, IntPtr value);

    public IntPtr filterShaderData {
        get => PxSceneDesc_GET_filterShaderData(this);
        set => PxSceneDesc_SET_filterShaderData(this, value);
    }
    #endif //getter

    // ### FILTERSHADERDATASIZE getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_filterShaderDataSize(PxSceneDesc* self) {return self->filterShaderDataSize;}
    ES void PxSceneDesc_SET_filterShaderDataSize(PxSceneDesc* self, physx::PxU32 value) {self->filterShaderDataSize = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_filterShaderDataSize(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_filterShaderDataSize(PxSceneDescPtr selfPtr, uint value);

    public uint filterShaderDataSize {
        get => PxSceneDesc_GET_filterShaderDataSize(this);
        set => PxSceneDesc_SET_filterShaderDataSize(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxSimulationFilterShader
    */

    // ### FILTERCALLBACK getter/setter
    #if NATIVE //getter
    ES physx::PxSimulationFilterCallback* PxSceneDesc_GET_filterCallback(PxSceneDesc* self) {return self->filterCallback;}
    ES void PxSceneDesc_SET_filterCallback(PxSceneDesc* self, physx::PxSimulationFilterCallback* value) {self->filterCallback = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSimulationFilterCallbackPtr PxSceneDesc_GET_filterCallback(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_filterCallback(PxSceneDescPtr selfPtr, PxSimulationFilterCallbackPtr value);

    public PxSimulationFilterCallbackPtr filterCallback {
        get => PxSceneDesc_GET_filterCallback(this);
        set => PxSceneDesc_SET_filterCallback(this, value);
    }
    #endif //getter

    // ### KINEKINEFILTERINGMODE getter/setter
    #if NATIVE //getter
    ES physx::PxPairFilteringMode::Enum PxSceneDesc_GET_kineKineFilteringMode(PxSceneDesc* self) {return self->kineKineFilteringMode;}
    ES void PxSceneDesc_SET_kineKineFilteringMode(PxSceneDesc* self, physx::PxPairFilteringMode::Enum value) {self->kineKineFilteringMode = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPairFilteringMode PxSceneDesc_GET_kineKineFilteringMode(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_kineKineFilteringMode(PxSceneDescPtr selfPtr, PxPairFilteringMode value);

    public PxPairFilteringMode kineKineFilteringMode {
        get => PxSceneDesc_GET_kineKineFilteringMode(this);
        set => PxSceneDesc_SET_kineKineFilteringMode(this, value);
    }
    #endif //getter

    // ### STATICKINEFILTERINGMODE getter/setter
    #if NATIVE //getter
    ES physx::PxPairFilteringMode::Enum PxSceneDesc_GET_staticKineFilteringMode(PxSceneDesc* self) {return self->staticKineFilteringMode;}
    ES void PxSceneDesc_SET_staticKineFilteringMode(PxSceneDesc* self, physx::PxPairFilteringMode::Enum value) {self->staticKineFilteringMode = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPairFilteringMode PxSceneDesc_GET_staticKineFilteringMode(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_staticKineFilteringMode(PxSceneDescPtr selfPtr, PxPairFilteringMode value);

    public PxPairFilteringMode staticKineFilteringMode {
        get => PxSceneDesc_GET_staticKineFilteringMode(this);
        set => PxSceneDesc_SET_staticKineFilteringMode(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Forbidden parameter type: PxBroadPhaseType
    */
    
    /*Error generating getter/setter: Forbidden parameter type: PxBroadPhaseCallbackPtr
    */
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxSceneLimits
    */

    // ### FRICTIONTYPE getter/setter
    #if NATIVE //getter
    ES physx::PxFrictionType::Enum PxSceneDesc_GET_frictionType(PxSceneDesc* self) {return self->frictionType;}
    ES void PxSceneDesc_SET_frictionType(PxSceneDesc* self, physx::PxFrictionType::Enum value) {self->frictionType = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFrictionType PxSceneDesc_GET_frictionType(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_frictionType(PxSceneDescPtr selfPtr, PxFrictionType value);

    public PxFrictionType frictionType {
        get => PxSceneDesc_GET_frictionType(this);
        set => PxSceneDesc_SET_frictionType(this, value);
    }
    #endif //getter

    // ### SOLVERTYPE getter/setter
    #if NATIVE //getter
    ES physx::PxSolverType::Enum PxSceneDesc_GET_solverType(PxSceneDesc* self) {return self->solverType;}
    ES void PxSceneDesc_SET_solverType(PxSceneDesc* self, physx::PxSolverType::Enum value) {self->solverType = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSolverType PxSceneDesc_GET_solverType(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_solverType(PxSceneDescPtr selfPtr, PxSolverType value);

    public PxSolverType solverType {
        get => PxSceneDesc_GET_solverType(this);
        set => PxSceneDesc_SET_solverType(this, value);
    }
    #endif //getter

    // ### BOUNCETHRESHOLDVELOCITY getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxSceneDesc_GET_bounceThresholdVelocity(PxSceneDesc* self) {return self->bounceThresholdVelocity;}
    ES void PxSceneDesc_SET_bounceThresholdVelocity(PxSceneDesc* self, physx::PxReal value) {self->bounceThresholdVelocity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxSceneDesc_GET_bounceThresholdVelocity(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_bounceThresholdVelocity(PxSceneDescPtr selfPtr, float value);

    public float bounceThresholdVelocity {
        get => PxSceneDesc_GET_bounceThresholdVelocity(this);
        set => PxSceneDesc_SET_bounceThresholdVelocity(this, value);
    }
    #endif //getter

    // ### FRICTIONOFFSETTHRESHOLD getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxSceneDesc_GET_frictionOffsetThreshold(PxSceneDesc* self) {return self->frictionOffsetThreshold;}
    ES void PxSceneDesc_SET_frictionOffsetThreshold(PxSceneDesc* self, physx::PxReal value) {self->frictionOffsetThreshold = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxSceneDesc_GET_frictionOffsetThreshold(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_frictionOffsetThreshold(PxSceneDescPtr selfPtr, float value);

    public float frictionOffsetThreshold {
        get => PxSceneDesc_GET_frictionOffsetThreshold(this);
        set => PxSceneDesc_SET_frictionOffsetThreshold(this, value);
    }
    #endif //getter

    // ### CCDMAXSEPARATION getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxSceneDesc_GET_ccdMaxSeparation(PxSceneDesc* self) {return self->ccdMaxSeparation;}
    ES void PxSceneDesc_SET_ccdMaxSeparation(PxSceneDesc* self, physx::PxReal value) {self->ccdMaxSeparation = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxSceneDesc_GET_ccdMaxSeparation(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_ccdMaxSeparation(PxSceneDescPtr selfPtr, float value);

    public float ccdMaxSeparation {
        get => PxSceneDesc_GET_ccdMaxSeparation(this);
        set => PxSceneDesc_SET_ccdMaxSeparation(this, value);
    }
    #endif //getter

    // ### SOLVEROFFSETSLOP getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxSceneDesc_GET_solverOffsetSlop(PxSceneDesc* self) {return self->solverOffsetSlop;}
    ES void PxSceneDesc_SET_solverOffsetSlop(PxSceneDesc* self, physx::PxReal value) {self->solverOffsetSlop = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxSceneDesc_GET_solverOffsetSlop(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_solverOffsetSlop(PxSceneDescPtr selfPtr, float value);

    public float solverOffsetSlop {
        get => PxSceneDesc_GET_solverOffsetSlop(this);
        set => PxSceneDesc_SET_solverOffsetSlop(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxSceneFlags
    */
    
    /*Error generating getter/setter: Forbidden parameter type: PxCpuDispatcherPtr
    */
    
    /*Error generating getter/setter: Forbidden parameter type: PxGpuDispatcherPtr
    */

    // ### STATICSTRUCTURE getter/setter
    #if NATIVE //getter
    ES physx::PxPruningStructureType::Enum PxSceneDesc_GET_staticStructure(PxSceneDesc* self) {return self->staticStructure;}
    ES void PxSceneDesc_SET_staticStructure(PxSceneDesc* self, physx::PxPruningStructureType::Enum value) {self->staticStructure = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPruningStructureType PxSceneDesc_GET_staticStructure(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_staticStructure(PxSceneDescPtr selfPtr, PxPruningStructureType value);

    public PxPruningStructureType staticStructure {
        get => PxSceneDesc_GET_staticStructure(this);
        set => PxSceneDesc_SET_staticStructure(this, value);
    }
    #endif //getter

    // ### DYNAMICSTRUCTURE getter/setter
    #if NATIVE //getter
    ES physx::PxPruningStructureType::Enum PxSceneDesc_GET_dynamicStructure(PxSceneDesc* self) {return self->dynamicStructure;}
    ES void PxSceneDesc_SET_dynamicStructure(PxSceneDesc* self, physx::PxPruningStructureType::Enum value) {self->dynamicStructure = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPruningStructureType PxSceneDesc_GET_dynamicStructure(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_dynamicStructure(PxSceneDescPtr selfPtr, PxPruningStructureType value);

    public PxPruningStructureType dynamicStructure {
        get => PxSceneDesc_GET_dynamicStructure(this);
        set => PxSceneDesc_SET_dynamicStructure(this, value);
    }
    #endif //getter

    // ### DYNAMICTREEREBUILDRATEHINT getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_dynamicTreeRebuildRateHint(PxSceneDesc* self) {return self->dynamicTreeRebuildRateHint;}
    ES void PxSceneDesc_SET_dynamicTreeRebuildRateHint(PxSceneDesc* self, physx::PxU32 value) {self->dynamicTreeRebuildRateHint = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_dynamicTreeRebuildRateHint(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_dynamicTreeRebuildRateHint(PxSceneDescPtr selfPtr, uint value);

    public uint dynamicTreeRebuildRateHint {
        get => PxSceneDesc_GET_dynamicTreeRebuildRateHint(this);
        set => PxSceneDesc_SET_dynamicTreeRebuildRateHint(this, value);
    }
    #endif //getter

    // ### SCENEQUERYUPDATEMODE getter/setter
    #if NATIVE //getter
    ES physx::PxSceneQueryUpdateMode::Enum PxSceneDesc_GET_sceneQueryUpdateMode(PxSceneDesc* self) {return self->sceneQueryUpdateMode;}
    ES void PxSceneDesc_SET_sceneQueryUpdateMode(PxSceneDesc* self, physx::PxSceneQueryUpdateMode::Enum value) {self->sceneQueryUpdateMode = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSceneQueryUpdateMode PxSceneDesc_GET_sceneQueryUpdateMode(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_sceneQueryUpdateMode(PxSceneDescPtr selfPtr, PxSceneQueryUpdateMode value);

    public PxSceneQueryUpdateMode sceneQueryUpdateMode {
        get => PxSceneDesc_GET_sceneQueryUpdateMode(this);
        set => PxSceneDesc_SET_sceneQueryUpdateMode(this, value);
    }
    #endif //getter

    // ### USERDATA getter/setter
    #if NATIVE //getter
    ES void* PxSceneDesc_GET_userData(PxSceneDesc* self) {return self->userData;}
    ES void PxSceneDesc_SET_userData(PxSceneDesc* self, void* value) {self->userData = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr PxSceneDesc_GET_userData(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_userData(PxSceneDescPtr selfPtr, IntPtr value);

    public IntPtr userData {
        get => PxSceneDesc_GET_userData(this);
        set => PxSceneDesc_SET_userData(this, value);
    }
    #endif //getter

    // ### SOLVERBATCHSIZE getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_solverBatchSize(PxSceneDesc* self) {return self->solverBatchSize;}
    ES void PxSceneDesc_SET_solverBatchSize(PxSceneDesc* self, physx::PxU32 value) {self->solverBatchSize = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_solverBatchSize(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_solverBatchSize(PxSceneDescPtr selfPtr, uint value);

    public uint solverBatchSize {
        get => PxSceneDesc_GET_solverBatchSize(this);
        set => PxSceneDesc_SET_solverBatchSize(this, value);
    }
    #endif //getter

    // ### NBCONTACTDATABLOCKS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_nbContactDataBlocks(PxSceneDesc* self) {return self->nbContactDataBlocks;}
    ES void PxSceneDesc_SET_nbContactDataBlocks(PxSceneDesc* self, physx::PxU32 value) {self->nbContactDataBlocks = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_nbContactDataBlocks(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_nbContactDataBlocks(PxSceneDescPtr selfPtr, uint value);

    public uint nbContactDataBlocks {
        get => PxSceneDesc_GET_nbContactDataBlocks(this);
        set => PxSceneDesc_SET_nbContactDataBlocks(this, value);
    }
    #endif //getter

    // ### MAXNBCONTACTDATABLOCKS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_maxNbContactDataBlocks(PxSceneDesc* self) {return self->maxNbContactDataBlocks;}
    ES void PxSceneDesc_SET_maxNbContactDataBlocks(PxSceneDesc* self, physx::PxU32 value) {self->maxNbContactDataBlocks = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_maxNbContactDataBlocks(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_maxNbContactDataBlocks(PxSceneDescPtr selfPtr, uint value);

    public uint maxNbContactDataBlocks {
        get => PxSceneDesc_GET_maxNbContactDataBlocks(this);
        set => PxSceneDesc_SET_maxNbContactDataBlocks(this, value);
    }
    #endif //getter

    // ### MAXBIASCOEFFICIENT getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxSceneDesc_GET_maxBiasCoefficient(PxSceneDesc* self) {return self->maxBiasCoefficient;}
    ES void PxSceneDesc_SET_maxBiasCoefficient(PxSceneDesc* self, physx::PxReal value) {self->maxBiasCoefficient = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxSceneDesc_GET_maxBiasCoefficient(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_maxBiasCoefficient(PxSceneDescPtr selfPtr, float value);

    public float maxBiasCoefficient {
        get => PxSceneDesc_GET_maxBiasCoefficient(this);
        set => PxSceneDesc_SET_maxBiasCoefficient(this, value);
    }
    #endif //getter

    // ### CONTACTREPORTSTREAMBUFFERSIZE getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_contactReportStreamBufferSize(PxSceneDesc* self) {return self->contactReportStreamBufferSize;}
    ES void PxSceneDesc_SET_contactReportStreamBufferSize(PxSceneDesc* self, physx::PxU32 value) {self->contactReportStreamBufferSize = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_contactReportStreamBufferSize(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_contactReportStreamBufferSize(PxSceneDescPtr selfPtr, uint value);

    public uint contactReportStreamBufferSize {
        get => PxSceneDesc_GET_contactReportStreamBufferSize(this);
        set => PxSceneDesc_SET_contactReportStreamBufferSize(this, value);
    }
    #endif //getter

    // ### CCDMAXPASSES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_ccdMaxPasses(PxSceneDesc* self) {return self->ccdMaxPasses;}
    ES void PxSceneDesc_SET_ccdMaxPasses(PxSceneDesc* self, physx::PxU32 value) {self->ccdMaxPasses = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_ccdMaxPasses(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_ccdMaxPasses(PxSceneDescPtr selfPtr, uint value);

    public uint ccdMaxPasses {
        get => PxSceneDesc_GET_ccdMaxPasses(this);
        set => PxSceneDesc_SET_ccdMaxPasses(this, value);
    }
    #endif //getter

    // ### WAKECOUNTERRESETVALUE getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxSceneDesc_GET_wakeCounterResetValue(PxSceneDesc* self) {return self->wakeCounterResetValue;}
    ES void PxSceneDesc_SET_wakeCounterResetValue(PxSceneDesc* self, physx::PxReal value) {self->wakeCounterResetValue = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxSceneDesc_GET_wakeCounterResetValue(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_wakeCounterResetValue(PxSceneDescPtr selfPtr, float value);

    public float wakeCounterResetValue {
        get => PxSceneDesc_GET_wakeCounterResetValue(this);
        set => PxSceneDesc_SET_wakeCounterResetValue(this, value);
    }
    #endif //getter

    // ### SANITYBOUNDS getter/setter
    #if NATIVE //getter
    ES physx::PxBounds3 PxSceneDesc_GET_sanityBounds(PxSceneDesc* self) {return self->sanityBounds;}
    ES void PxSceneDesc_SET_sanityBounds(PxSceneDesc* self, physx::PxBounds3 value) {self->sanityBounds = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 PxSceneDesc_GET_sanityBounds(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_sanityBounds(PxSceneDescPtr selfPtr, PxBounds3 value);

    public PxBounds3 sanityBounds {
        get => PxSceneDesc_GET_sanityBounds(this);
        set => PxSceneDesc_SET_sanityBounds(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxgDynamicsMemoryConfig
    */

    // ### GPUMAXNUMPARTITIONS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_gpuMaxNumPartitions(PxSceneDesc* self) {return self->gpuMaxNumPartitions;}
    ES void PxSceneDesc_SET_gpuMaxNumPartitions(PxSceneDesc* self, physx::PxU32 value) {self->gpuMaxNumPartitions = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_gpuMaxNumPartitions(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_gpuMaxNumPartitions(PxSceneDescPtr selfPtr, uint value);

    public uint gpuMaxNumPartitions {
        get => PxSceneDesc_GET_gpuMaxNumPartitions(this);
        set => PxSceneDesc_SET_gpuMaxNumPartitions(this, value);
    }
    #endif //getter

    // ### GPUCOMPUTEVERSION getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSceneDesc_GET_gpuComputeVersion(PxSceneDesc* self) {return self->gpuComputeVersion;}
    ES void PxSceneDesc_SET_gpuComputeVersion(PxSceneDesc* self, physx::PxU32 value) {self->gpuComputeVersion = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSceneDesc_GET_gpuComputeVersion(PxSceneDescPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSceneDesc_SET_gpuComputeVersion(PxSceneDescPtr selfPtr, uint value);

    public uint gpuComputeVersion {
        get => PxSceneDesc_GET_gpuComputeVersion(this);
        set => PxSceneDesc_SET_gpuComputeVersion(this, value);
    }
    #endif //getter
    //Skipped non-public field: tolerancesScale

    #if !NATIVE //hierarchy
    // Hierarchy: PxSceneDescPtr
    #endif //hierarchy
    //================================================================================
    //#       PxSceneDesc(PxTolerancesScalePtr scale)                                #
    //================================================================================
    #if NATIVE //function start
    ES PxSceneDescPtrPOD W_PxSceneDesc_R_PxSceneDescPtr_P_PxTolerancesScale_C_PxSceneDesc_ctor(physx::PxTolerancesScale scale){
        auto nat_in_scale = (scale);
        auto val = new PxSceneDesc();
        return *(PxSceneDescPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSceneDescPtr W_PxSceneDesc_R_PxSceneDescPtr_P_PxTolerancesScale_C_PxSceneDesc_ctor(PxTolerancesScale scale);
    
    public  static PxSceneDescPtr New(PxTolerancesScale scale){
        PxTolerancesScale pvk_in_scale = (scale);
        var _new = W_PxSceneDesc_R_PxSceneDescPtr_P_PxTolerancesScale_C_PxSceneDesc_ctor(pvk_in_scale);
        PxSceneDescPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setToDefault(PxTolerancesScalePtr scale)                               #
    //================================================================================
    #if NATIVE //function start
    ES void W_setToDefault_R_void_P_PxTolerancesScale_C_PxSceneDesc(physx::PxSceneDesc* self, physx::PxTolerancesScale scale){
        auto nat_in_scale = (scale);
        self->setToDefault(nat_in_scale);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setToDefault_R_void_P_PxTolerancesScale_C_PxSceneDesc(PxSceneDescPtr selfPtr, PxTolerancesScale scale);
    
    public  void setToDefault(PxTolerancesScale scale){
        PxTolerancesScale pvk_in_scale = (scale);
        W_setToDefault_R_void_P_PxTolerancesScale_C_PxSceneDesc(this, pvk_in_scale);
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxSceneDesc(physx::PxSceneDesc* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxSceneDesc(PxSceneDescPtr selfPtr);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxSceneDesc(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTolerancesScale()                                                   #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxTolerancesScale* W_getTolerancesScale_R_PxTolerancesScalePtr_C_PxSceneDesc(physx::PxSceneDesc* self){
        auto retVal = &self->getTolerancesScale();
    //TODO check if it's returning addr of local
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTolerancesScale W_getTolerancesScale_R_PxTolerancesScalePtr_C_PxSceneDesc(PxSceneDescPtr selfPtr);
    
    public  PxTolerancesScale getTolerancesScale(){
        PxTolerancesScale retVal = W_getTolerancesScale_R_PxTolerancesScalePtr_C_PxSceneDesc(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxSceneDesc
    
    //Skipped generated implicit entry: PxSceneDesc
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxSceneDesc
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxSolverType is enum namespace
#if !NATIVE //interface
public unsafe interface IPxgDynamicsMemoryConfigPtr {
    // static PxgDynamicsMemoryConfigPtr New();
    // static PxgDynamicsMemoryConfigPtr New(/*NULLPARS*/);
    // static PxgDynamicsMemoryConfigPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxgDynamicsMemoryConfig(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxgDynamicsMemoryConfigPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxgDynamicsMemoryConfigPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxgDynamicsMemoryConfigPtr : IPxgDynamicsMemoryConfigPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxgDynamicsMemoryConfigPtrPOD{
    physx::PxU32 constraintBufferCapacity;
    physx::PxU32 contactBufferCapacity;
    physx::PxU32 tempBufferCapacity;
    physx::PxU32 contactStreamSize;
    physx::PxU32 patchStreamSize;
    physx::PxU32 forceStreamCapacity;
    physx::PxU32 heapCapacity;
    physx::PxU32 foundLostPairsCapacity;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### CONSTRAINTBUFFERCAPACITY getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_constraintBufferCapacity(PxgDynamicsMemoryConfig* self) {return self->constraintBufferCapacity;}
    ES void PxgDynamicsMemoryConfig_SET_constraintBufferCapacity(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->constraintBufferCapacity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_constraintBufferCapacity(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_constraintBufferCapacity(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint constraintBufferCapacity {
        get => PxgDynamicsMemoryConfig_GET_constraintBufferCapacity(this);
        set => PxgDynamicsMemoryConfig_SET_constraintBufferCapacity(this, value);
    }
    #endif //getter

    // ### CONTACTBUFFERCAPACITY getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_contactBufferCapacity(PxgDynamicsMemoryConfig* self) {return self->contactBufferCapacity;}
    ES void PxgDynamicsMemoryConfig_SET_contactBufferCapacity(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->contactBufferCapacity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_contactBufferCapacity(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_contactBufferCapacity(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint contactBufferCapacity {
        get => PxgDynamicsMemoryConfig_GET_contactBufferCapacity(this);
        set => PxgDynamicsMemoryConfig_SET_contactBufferCapacity(this, value);
    }
    #endif //getter

    // ### TEMPBUFFERCAPACITY getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_tempBufferCapacity(PxgDynamicsMemoryConfig* self) {return self->tempBufferCapacity;}
    ES void PxgDynamicsMemoryConfig_SET_tempBufferCapacity(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->tempBufferCapacity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_tempBufferCapacity(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_tempBufferCapacity(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint tempBufferCapacity {
        get => PxgDynamicsMemoryConfig_GET_tempBufferCapacity(this);
        set => PxgDynamicsMemoryConfig_SET_tempBufferCapacity(this, value);
    }
    #endif //getter

    // ### CONTACTSTREAMSIZE getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_contactStreamSize(PxgDynamicsMemoryConfig* self) {return self->contactStreamSize;}
    ES void PxgDynamicsMemoryConfig_SET_contactStreamSize(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->contactStreamSize = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_contactStreamSize(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_contactStreamSize(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint contactStreamSize {
        get => PxgDynamicsMemoryConfig_GET_contactStreamSize(this);
        set => PxgDynamicsMemoryConfig_SET_contactStreamSize(this, value);
    }
    #endif //getter

    // ### PATCHSTREAMSIZE getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_patchStreamSize(PxgDynamicsMemoryConfig* self) {return self->patchStreamSize;}
    ES void PxgDynamicsMemoryConfig_SET_patchStreamSize(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->patchStreamSize = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_patchStreamSize(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_patchStreamSize(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint patchStreamSize {
        get => PxgDynamicsMemoryConfig_GET_patchStreamSize(this);
        set => PxgDynamicsMemoryConfig_SET_patchStreamSize(this, value);
    }
    #endif //getter

    // ### FORCESTREAMCAPACITY getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_forceStreamCapacity(PxgDynamicsMemoryConfig* self) {return self->forceStreamCapacity;}
    ES void PxgDynamicsMemoryConfig_SET_forceStreamCapacity(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->forceStreamCapacity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_forceStreamCapacity(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_forceStreamCapacity(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint forceStreamCapacity {
        get => PxgDynamicsMemoryConfig_GET_forceStreamCapacity(this);
        set => PxgDynamicsMemoryConfig_SET_forceStreamCapacity(this, value);
    }
    #endif //getter

    // ### HEAPCAPACITY getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_heapCapacity(PxgDynamicsMemoryConfig* self) {return self->heapCapacity;}
    ES void PxgDynamicsMemoryConfig_SET_heapCapacity(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->heapCapacity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_heapCapacity(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_heapCapacity(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint heapCapacity {
        get => PxgDynamicsMemoryConfig_GET_heapCapacity(this);
        set => PxgDynamicsMemoryConfig_SET_heapCapacity(this, value);
    }
    #endif //getter

    // ### FOUNDLOSTPAIRSCAPACITY getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxgDynamicsMemoryConfig_GET_foundLostPairsCapacity(PxgDynamicsMemoryConfig* self) {return self->foundLostPairsCapacity;}
    ES void PxgDynamicsMemoryConfig_SET_foundLostPairsCapacity(PxgDynamicsMemoryConfig* self, physx::PxU32 value) {self->foundLostPairsCapacity = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxgDynamicsMemoryConfig_GET_foundLostPairsCapacity(PxgDynamicsMemoryConfigPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxgDynamicsMemoryConfig_SET_foundLostPairsCapacity(PxgDynamicsMemoryConfigPtr selfPtr, uint value);

    public uint foundLostPairsCapacity {
        get => PxgDynamicsMemoryConfig_GET_foundLostPairsCapacity(this);
        set => PxgDynamicsMemoryConfig_SET_foundLostPairsCapacity(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxgDynamicsMemoryConfigPtr
    #endif //hierarchy
    //================================================================================
    //#       PxgDynamicsMemoryConfig()                                              #
    //================================================================================
    #if NATIVE //function start
    ES PxgDynamicsMemoryConfigPtrPOD W_PxgDynamicsMemoryConfig_R_PxgDynamicsMemoryConfigPtr_C_PxgDynamicsMemoryConfig_ctor(){
        auto val = new PxgDynamicsMemoryConfig();
        return *(PxgDynamicsMemoryConfigPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxgDynamicsMemoryConfigPtr W_PxgDynamicsMemoryConfig_R_PxgDynamicsMemoryConfigPtr_C_PxgDynamicsMemoryConfig_ctor();
    
    public  static PxgDynamicsMemoryConfigPtr New(){
        var _new = W_PxgDynamicsMemoryConfig_R_PxgDynamicsMemoryConfigPtr_C_PxgDynamicsMemoryConfig_ctor();
        PxgDynamicsMemoryConfigPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxgDynamicsMemoryConfig
    
    //Skipped generated implicit entry: PxgDynamicsMemoryConfig
    
    //Skipped generated implicit entry: ~PxgDynamicsMemoryConfig
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
