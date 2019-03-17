#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
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
#endif

#if !NATIVE
public enum PxFrictionType : int {
    ePATCH = 0,           // ePATCH
    eONE_DIRECTIONAL = 1, // eONE_DIRECTIONAL
    eTWO_DIRECTIONAL = 2, // eTWO_DIRECTIONAL
    eFRICTION_COUNT = 3,  // eFRICTION_COUNT
}
#endif

#if !NATIVE
public enum PxPruningStructureType : int {
    eNONE = 0,              // eNONE
    eDYNAMIC_AABB_TREE = 1, // eDYNAMIC_AABB_TREE
    eSTATIC_AABB_TREE = 2,  // eSTATIC_AABB_TREE
    eLAST = 3,              // eLAST
}
#endif

#if !NATIVE
public enum PxSceneQueryUpdateMode : int {
    eBUILD_ENABLED_COMMIT_ENABLED = 0,   // eBUILD_ENABLED_COMMIT_ENABLED
    eBUILD_ENABLED_COMMIT_DISABLED = 1,  // eBUILD_ENABLED_COMMIT_DISABLED
    eBUILD_DISABLED_COMMIT_DISABLED = 2, // eBUILD_DISABLED_COMMIT_DISABLED
}
#endif

#if !NATIVE
public enum PxSolverType : int {
    ePGS = 0, // ePGS
    eTGS = 1, // eTGS
}
#endif

#if !NATIVE
public partial struct PxSceneDesc {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L385~385
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxSceneFlag::Enum a, physx::PxSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxSceneFlag a, PxSceneFlag b);

public static UNPARSED_TYPE operator|(PxSceneFlag a, PxSceneFlag b){
    PxSceneFlag pvk_in_a = (a);
    PxSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L385~385
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxSceneFlag::Enum a, physx::PxSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxSceneFlag a, PxSceneFlag b);

public static UNPARSED_TYPE operator&(PxSceneFlag a, PxSceneFlag b){
    PxSceneFlag pvk_in_a = (a);
    PxSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L385~385
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxSceneFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxSceneFlag a);

public static UNPARSED_TYPE operator~(PxSceneFlag a){
    PxSceneFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxSceneDesc
#endif


// Class physx::PxSceneFlag is enum namespace
#if !NATIVE
public unsafe partial struct PxSceneLimits { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxSceneLimits                                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxSceneLimits
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       setToDefault                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L421~421
    #if NATIVE
    ES void W_setToDefault(physx::PxSceneLimits* self){
        self->setToDefault();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setToDefault(PxSceneLimits selfPtr);
    
    public void setToDefault(){
        W_setToDefault(this);
    }
    #endif
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L427~427
    #if NATIVE
    ES bool W_isValid(physx::PxSceneLimits* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxSceneLimits selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxSceneLimits
    
    //Skipped generated implicit entry: PxSceneLimits
    
    //Skipped generated implicit entry: ~PxSceneLimits
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxSimulationEventCallback Manually Ignored
// Class physx::PxContactModifyCallback Manually Ignored
// Class physx::PxCCDContactModifyCallback Manually Ignored
// Class physx::PxFrictionType is enum namespace
// Class physx::PxPruningStructureType is enum namespace
// Class physx::PxSceneQueryUpdateMode is enum namespace
#if !NATIVE
public unsafe partial struct PxSceneDesc { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxSceneDesc                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxSceneDesc
    Forbidden parameter type: PxTolerancesScale
    // NATIVE SIG: PX_INLINE PxSceneDesc(const PxTolerancesScale& scale)
    // SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L912~912
    #if NATIVE
    ES UNPARSED_TYPE W_PxSceneDesc_ctor(physx::PxTolerancesScale* scale){
        auto nat_in_scale = (scale);
        self->PxSceneDesc(*nat_in_scale);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxSceneDesc_ctor(PxTolerancesScale scale);
    
    public PxSceneDesc(PxTolerancesScale scale){
        PxTolerancesScale pvk_in_scale = (scale);
        var _new = W_PxSceneDesc_ctor(pvk_in_scale);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       setToDefault                                                           #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScale
    // NATIVE SIG: void setToDefault(const PxTolerancesScale& scale)
    // SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L922~922
    #if NATIVE
    ES void W_setToDefault(physx::PxSceneDesc* self, physx::PxTolerancesScale* scale){
        auto nat_in_scale = (scale);
        self->setToDefault(*nat_in_scale);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setToDefault(PxSceneDesc selfPtr, PxTolerancesScale scale);
    
    public void setToDefault(PxTolerancesScale scale){
        PxTolerancesScale pvk_in_scale = (scale);
        W_setToDefault(this, pvk_in_scale);
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L928~928
    #if NATIVE
    ES bool W_isValid(physx::PxSceneDesc* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxSceneDesc selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTolerancesScale                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTolerancesScale& getTolerancesScale() const { return tolerancesScale; }
    // SOURCE: C:\Projects\PhysX\physx\include\PxSceneDesc.h L934~934
    #if NATIVE
    ES physx::PxTolerancesScale* W_getTolerancesScale(physx::PxSceneDesc* self){
        auto retVal = &self->getTolerancesScale();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTolerancesScale W_getTolerancesScale(PxSceneDesc selfPtr);
    
    public PxTolerancesScale getTolerancesScale(){
        PxTolerancesScale retVal = W_getTolerancesScale(this);
        return retVal;
    }
    #endif*/
    
    
    //Skipped generated implicit entry: PxSceneDesc
    
    //Skipped generated implicit entry: PxSceneDesc
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxSceneDesc
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxSolverType is enum namespace
#if !NATIVE
public unsafe partial struct PxgDynamicsMemoryConfig { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxgDynamicsMemoryConfig                                                #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxgDynamicsMemoryConfig
    Parameterless constructor not allowed
    */
    
    
    //Skipped generated implicit entry: PxgDynamicsMemoryConfig
    
    //Skipped generated implicit entry: PxgDynamicsMemoryConfig
    
    //Skipped generated implicit entry: ~PxgDynamicsMemoryConfig
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
