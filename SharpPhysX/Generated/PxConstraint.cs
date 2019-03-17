#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxConstraintFlag : int {
    eBROKEN = 1,                   // eBROKEN = 1<<0
    ePROJECT_TO_ACTOR0 = 2,        // ePROJECT_TO_ACTOR0 = 1<<1
    ePROJECT_TO_ACTOR1 = 4,        // ePROJECT_TO_ACTOR1 = 1<<2
    ePROJECTION = 6,               // ePROJECTION = ePROJECT_TO_ACTOR0 | ePROJECT_TO_ACTOR1
    eCOLLISION_ENABLED = 8,        // eCOLLISION_ENABLED = 1<<3
    eVISUALIZATION = 16,           // eVISUALIZATION = 1<<4
    eDRIVE_LIMITS_ARE_FORCES = 32, // eDRIVE_LIMITS_ARE_FORCES = 1<<5
    eIMPROVED_SLERP = 128,         // eIMPROVED_SLERP = 1<<7
    eDISABLE_PREPROCESSING = 256,  // eDISABLE_PREPROCESSING = 1<<8
    eENABLE_EXTENDED_LIMITS = 512, // eENABLE_EXTENDED_LIMITS = 1<<9
    eGPU_COMPATIBLE = 1024,        // eGPU_COMPATIBLE = 1<<10
}
#endif

#if !NATIVE
public enum PxConstraintShaderTable_enum : int {
    eMAX_SOLVERPRPEP_DATASIZE = 400, // eMAX_SOLVERPRPEP_DATASIZE=400
}
#endif

#if !NATIVE
public partial struct PxConstraint {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxConstraintFlag::Enum a, physx::PxConstraintFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxConstraintFlag a, PxConstraintFlag b);

public static UNPARSED_TYPE operator|(PxConstraintFlag a, PxConstraintFlag b){
    PxConstraintFlag pvk_in_a = (a);
    PxConstraintFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxConstraintFlag::Enum a, physx::PxConstraintFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxConstraintFlag a, PxConstraintFlag b);

public static UNPARSED_TYPE operator&(PxConstraintFlag a, PxConstraintFlag b){
    PxConstraintFlag pvk_in_a = (a);
    PxConstraintFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxConstraintFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxConstraintFlag a);

public static UNPARSED_TYPE operator~(PxConstraintFlag a){
    PxConstraintFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxConstraint
#endif


#if !NATIVE
public unsafe partial struct PxConstraintPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxConstraint* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxConstraintPtr selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getScene                                                               #
    //================================================================================
    #if NATIVE
    ES physx::PxScene* W_getScene(physx::PxConstraint* self){
        auto retVal = self->getScene();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxScenePtr W_getScene(PxConstraintPtr selfPtr);
    
    public PxScenePtr getScene(){
        PxScenePtr retVal = W_getScene(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getActors                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxRigidActor*
    Unresolved parameter pointee physx::PxRigidActor*
    // NATIVE SIG: void				getActors(PxRigidActor*& actor0, PxRigidActor*& actor1)	const	= 0
    #if NATIVE
    ES void W_getActors(physx::PxConstraint* self,  actor0,  actor1){
        auto nat_in_actor0 = (actor0);
        auto nat_in_actor1 = (actor1);
        self->getActors(nat_in_actor0, nat_in_actor1);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getActors(PxConstraintPtr selfPtr,  actor0,  actor1);
    
    public void getActors( actor0,  actor1){
         pvk_in_actor0 = (actor0);
         pvk_in_actor1 = (actor1);
        W_getActors(this, pvk_in_actor0, pvk_in_actor1);
    }
    #endif*/
    
    
    //================================================================================
    //#       setActors                                                              #
    //================================================================================
    #if NATIVE
    ES void W_setActors(physx::PxConstraint* self, physx::PxRigidActor* actor0, physx::PxRigidActor* actor1){
        auto nat_in_actor0 = (actor0);
        auto nat_in_actor1 = (actor1);
        self->setActors(nat_in_actor0, nat_in_actor1);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setActors(PxConstraintPtr selfPtr, PxRigidActorPtr actor0, PxRigidActorPtr actor1);
    
    public void setActors(PxRigidActorPtr actor0, PxRigidActorPtr actor1){
        PxRigidActorPtr pvk_in_actor0 = (actor0);
        PxRigidActorPtr pvk_in_actor1 = (actor1);
        W_setActors(this, pvk_in_actor0, pvk_in_actor1);
    }
    #endif
    
    
    //================================================================================
    //#       markDirty                                                              #
    //================================================================================
    #if NATIVE
    ES void W_markDirty(physx::PxConstraint* self){
        self->markDirty();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_markDirty(PxConstraintPtr selfPtr);
    
    public void markDirty(){
        W_markDirty(this);
    }
    #endif
    
    
    //================================================================================
    //#       setFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxConstraintFlags
    // NATIVE SIG: void				setFlags(PxConstraintFlags flags)								= 0
    #if NATIVE
    ES void W_setFlags(physx::PxConstraint* self,  flags){
        auto nat_in_flags = (flags);
        self->setFlags(nat_in_flags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlags(PxConstraintPtr selfPtr,  flags);
    
    public void setFlags( flags){
         pvk_in_flags = (flags);
        W_setFlags(this, pvk_in_flags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraintFlags
    // NATIVE SIG: PxConstraintFlags	getFlags()												const	= 0
    #if NATIVE
    ES UNPARSED_TYPE W_getFlags(physx::PxConstraint* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags(PxConstraintPtr selfPtr);
    
    public UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    #if NATIVE
    ES void W_setFlag(physx::PxConstraint* self, physx::PxConstraintFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag(PxConstraintPtr selfPtr, PxConstraintFlag flag, bool value);
    
    public void setFlag(PxConstraintFlag flag, bool value){
        PxConstraintFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       getForce                                                               #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxVec3
    Non const pointer/reference global::PhysX.physx.PxVec3
    // NATIVE SIG: void				getForce(PxVec3& linear, PxVec3& angular)				const	= 0
    #if NATIVE
    ES void W_getForce(physx::PxConstraint* self,  linear,  angular){
        auto nat_in_linear = (linear);
        auto nat_in_angular = (angular);
        self->getForce(nat_in_linear, nat_in_angular);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getForce(PxConstraintPtr selfPtr,  linear,  angular);
    
    public void getForce( linear,  angular){
         pvk_in_linear = (linear);
         pvk_in_angular = (angular);
        W_getForce(this, pvk_in_linear, pvk_in_angular);
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE
    ES bool W_isValid(physx::PxConstraint* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxConstraintPtr selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setBreakForce                                                          #
    //================================================================================
    #if NATIVE
    ES void W_setBreakForce(physx::PxConstraint* self, physx::PxReal linear, physx::PxReal angular){
        auto nat_in_linear = (linear);
        auto nat_in_angular = (angular);
        self->setBreakForce(nat_in_linear, nat_in_angular);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBreakForce(PxConstraintPtr selfPtr, float linear, float angular);
    
    public void setBreakForce(float linear, float angular){
        float pvk_in_linear = (linear);
        float pvk_in_angular = (angular);
        W_setBreakForce(this, pvk_in_linear, pvk_in_angular);
    }
    #endif
    
    
    //================================================================================
    //#       getBreakForce                                                          #
    //================================================================================
    #if NATIVE
    ES void W_getBreakForce(physx::PxConstraint* self, physx::PxReal& linear, physx::PxReal& angular){
        auto nat_in_linear = (linear);
        auto nat_in_angular = (angular);
        self->getBreakForce(nat_in_linear, nat_in_angular);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getBreakForce(PxConstraintPtr selfPtr, float* linear, float* angular);
    
    public void getBreakForce(float* linear, float* angular){
        float* pvk_in_linear = (linear);
        float* pvk_in_angular = (angular);
        W_getBreakForce(this, pvk_in_linear, pvk_in_angular);
    }
    #endif
    
    
    //================================================================================
    //#       setMinResponseThreshold                                                #
    //================================================================================
    #if NATIVE
    ES void W_setMinResponseThreshold(physx::PxConstraint* self, physx::PxReal threshold){
        auto nat_in_threshold = (threshold);
        self->setMinResponseThreshold(nat_in_threshold);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinResponseThreshold(PxConstraintPtr selfPtr, float threshold);
    
    public void setMinResponseThreshold(float threshold){
        float pvk_in_threshold = (threshold);
        W_setMinResponseThreshold(this, pvk_in_threshold);
    }
    #endif
    
    
    //================================================================================
    //#       getMinResponseThreshold                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMinResponseThreshold(physx::PxConstraint* self){
        auto retVal = self->getMinResponseThreshold();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinResponseThreshold(PxConstraintPtr selfPtr);
    
    public float getMinResponseThreshold(){
        float retVal = W_getMinResponseThreshold(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getExternalReference                                                   #
    //================================================================================
    #if NATIVE
    ES void* W_getExternalReference(physx::PxConstraint* self, physx::PxU32& typeID){
        auto nat_in_typeID = (typeID);
        auto retVal = self->getExternalReference(nat_in_typeID);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getExternalReference(PxConstraintPtr selfPtr, uint* typeID);
    
    public IntPtr getExternalReference(uint* typeID){
        uint* pvk_in_typeID = (typeID);
        IntPtr retVal = W_getExternalReference(this, pvk_in_typeID);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setConstraintFunctions                                                 #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxConstraintShaderTablePtr
    // NATIVE SIG: void				setConstraintFunctions(PxConstraintConnector& connector,
    													   const PxConstraintShaderTable& shaders)		= 0
    #if NATIVE
    ES void W_setConstraintFunctions(physx::PxConstraint* self, physx::PxConstraintConnector* connector, physx::PxConstraintShaderTable shaders){
        auto nat_in_connector = (connector);
        auto nat_in_shaders = (shaders);
        self->setConstraintFunctions(*nat_in_connector, nat_in_shaders);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setConstraintFunctions(PxConstraintPtr selfPtr, PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders);
    
    public void setConstraintFunctions(PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders){
        PxConstraintConnectorPtr pvk_in_connector = (connector);
        PxConstraintShaderTable pvk_in_shaders = (shaders);
        W_setConstraintFunctions(this, pvk_in_connector, pvk_in_shaders);
    }
    #endif*/
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxConstraint* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxConstraintPtr selfPtr);
    
    public IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxConstraint                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraint
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxConstraint(PxType concreteType, PxBaseFlags baseFlags) : PxBase(concreteType, baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxConstraint_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxConstraint(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConstraint_ctor(ushort concreteType,  baseFlags);
    
    public PxConstraint(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxConstraint_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConstraint                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraint
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxConstraint(PxBaseFlags baseFlags) : PxBase(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxConstraint_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxConstraint(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConstraint_ctor( baseFlags);
    
    public PxConstraint( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxConstraint_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConstraint                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxConstraint() {}
    #if NATIVE
    ES void W_~PxConstraint(physx::PxConstraint* self){
        self->~PxConstraint();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConstraint(PxConstraintPtr selfPtr);
    
    public void ~PxConstraint(){
        W_~PxConstraint(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxConstraint* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxConstraintPtr selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxConstraint
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxConstraintFlag is enum namespace
// Class physx::PxConstraintShaderTable Manually Ignored