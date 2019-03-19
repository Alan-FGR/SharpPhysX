#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
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
#endif //enum

#if !NATIVE //enum
public enum PxConstraintShaderTable_enum : int {
    eMAX_SOLVERPRPEP_DATASIZE = 400, // eMAX_SOLVERPRPEP_DATASIZE=400
}
#endif //enum

#if !NATIVE
public partial struct PxConstraint {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag_P_PxConstraintFlag(physx::PxConstraintFlag::Enum a, physx::PxConstraintFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag_P_PxConstraintFlag(PxConstraintFlag a, PxConstraintFlag b);

public static UNPARSED_TYPE operator|(PxConstraintFlag a, PxConstraintFlag b){
    PxConstraintFlag pvk_in_a = (a);
    PxConstraintFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag_P_PxConstraintFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag_P_PxConstraintFlag(physx::PxConstraintFlag::Enum a, physx::PxConstraintFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag_P_PxConstraintFlag(PxConstraintFlag a, PxConstraintFlag b);

public static UNPARSED_TYPE operator&(PxConstraintFlag a, PxConstraintFlag b){
    PxConstraintFlag pvk_in_a = (a);
    PxConstraintFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag_P_PxConstraintFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag(physx::PxConstraintFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag(PxConstraintFlag a);

public static UNPARSED_TYPE operator~(PxConstraintFlag a){
    PxConstraintFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxConstraintFlag_ushort_P_PxConstraintFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxConstraint
#endif


#if !NATIVE //interface
public unsafe interface IPxConstraintPtr {
     void release();
     PxScenePtr getScene();
    // void getActors( actor0,  actor1);
     void setActors(PxRigidActorPtr actor0, PxRigidActorPtr actor1);
     void markDirty();
    // void setFlags( flags);
    // UNPARSED_TYPE getFlags();
     void setFlag(PxConstraintFlag flag, bool value);
    // void getForce( linear,  angular);
     bool isValid();
     void setBreakForce(float linear, float angular);
     void getBreakForce(float* linear, float* angular);
     void setMinResponseThreshold(float threshold);
     float getMinResponseThreshold();
     IntPtr getExternalReference(uint* typeID);
    // void setConstraintFunctions(PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders);
     string getConcreteTypeName();
    // PxConstraint(/*NULLPARS*/);
    // PxConstraint(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxConstraint(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // PxConstraint(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxConstraintPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxConstraintPtr : IPxBasePtr, IPxConstraintPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxConstraintPtr
    public static implicit operator PxBasePtr(PxConstraintPtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxConstraintPtr(PxBasePtr obj){return *(PxConstraintPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxBasePtr
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    public  ushort getConcreteType(){return ((PxBasePtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxBasePtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxBasePtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxBasePtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxBasePtr)this).isReleasable();}
    //public  PxBase(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  PxBase(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxBase(/*NULLPARS*/){((PxBasePtr)this).~PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE typeMatch(/*NULLPARS*/){return ((PxBasePtr)this).typeMatch(/*NULLARGS*/);}
    //public  PxBase(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxBasePtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxConstraint(physx::PxConstraint* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxConstraint(PxConstraintPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxConstraint(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getScene                                                               #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxScene* W_getScene_R_PxScenePtr_C_PxConstraint(physx::PxConstraint* self){
        auto retVal = self->getScene();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxScenePtr W_getScene_R_PxScenePtr_C_PxConstraint(PxConstraintPtr selfPtr);
    
    public  PxScenePtr getScene(){
        PxScenePtr retVal = W_getScene_R_PxScenePtr_C_PxConstraint(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getActors                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxRigidActor*
    Unresolved parameter pointee physx::PxRigidActor*
    // NATIVE SIG: void				getActors(PxRigidActor*& actor0, PxRigidActor*& actor1)	const	= 0
    #if NATIVE //function start
    ES void W_getActors_R_void_P__P__C_PxConstraint(physx::PxConstraint* self,  actor0,  actor1){
        auto nat_in_actor0 = (actor0);
        auto nat_in_actor1 = (actor1);
        self->getActors(nat_in_actor0, nat_in_actor1);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getActors_R_void_P__P__C_PxConstraint(PxConstraintPtr selfPtr,  actor0,  actor1);
    
    public  void getActors( actor0,  actor1){
         pvk_in_actor0 = (actor0);
         pvk_in_actor1 = (actor1);
        W_getActors_R_void_P__P__C_PxConstraint(this, pvk_in_actor0, pvk_in_actor1);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setActors                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_setActors_R_void_P_PxRigidActorPtr_P_PxRigidActorPtr_C_PxConstraint(physx::PxConstraint* self, physx::PxRigidActor* actor0, physx::PxRigidActor* actor1){
        auto nat_in_actor0 = (actor0);
        auto nat_in_actor1 = (actor1);
        self->setActors(nat_in_actor0, nat_in_actor1);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setActors_R_void_P_PxRigidActorPtr_P_PxRigidActorPtr_C_PxConstraint(PxConstraintPtr selfPtr, PxRigidActorPtr actor0, PxRigidActorPtr actor1);
    
    public  void setActors(PxRigidActorPtr actor0, PxRigidActorPtr actor1){
        PxRigidActorPtr pvk_in_actor0 = (actor0);
        PxRigidActorPtr pvk_in_actor1 = (actor1);
        W_setActors_R_void_P_PxRigidActorPtr_P_PxRigidActorPtr_C_PxConstraint(this, pvk_in_actor0, pvk_in_actor1);
    }
    #endif //function end
    
    
    //================================================================================
    //#       markDirty                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_markDirty_R_void_C_PxConstraint(physx::PxConstraint* self){
        self->markDirty();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_markDirty_R_void_C_PxConstraint(PxConstraintPtr selfPtr);
    
    public  void markDirty(){
        W_markDirty_R_void_C_PxConstraint(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxConstraintFlags
    // NATIVE SIG: void				setFlags(PxConstraintFlags flags)								= 0
    #if NATIVE //function start
    ES void W_setFlags_R_void_P__C_PxConstraint(physx::PxConstraint* self,  flags){
        auto nat_in_flags = (flags);
        self->setFlags(nat_in_flags);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlags_R_void_P__C_PxConstraint(PxConstraintPtr selfPtr,  flags);
    
    public  void setFlags( flags){
         pvk_in_flags = (flags);
        W_setFlags_R_void_P__C_PxConstraint(this, pvk_in_flags);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraintFlags
    // NATIVE SIG: PxConstraintFlags	getFlags()												const	= 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getFlags_R_Enum, ushort>_C_PxConstraint(physx::PxConstraint* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags_R_Enum, ushort>_C_PxConstraint(PxConstraintPtr selfPtr);
    
    public  UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags_R_Enum, ushort>_C_PxConstraint(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setFlag_R_void_P_PxConstraintFlag_P_bool_C_PxConstraint(physx::PxConstraint* self, physx::PxConstraintFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setFlag(nat_in_flag, nat_in_value);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag_R_void_P_PxConstraintFlag_P_bool_C_PxConstraint(PxConstraintPtr selfPtr, PxConstraintFlag flag, bool value);
    
    public  void setFlag(PxConstraintFlag flag, bool value){
        PxConstraintFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setFlag_R_void_P_PxConstraintFlag_P_bool_C_PxConstraint(this, pvk_in_flag, pvk_in_value);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getForce                                                               #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxVec3
    Non const pointer/reference global::PhysX.physx.PxVec3
    // NATIVE SIG: void				getForce(PxVec3& linear, PxVec3& angular)				const	= 0
    #if NATIVE //function start
    ES void W_getForce_R_void_P__P__C_PxConstraint(physx::PxConstraint* self,  linear,  angular){
        auto nat_in_linear = (linear);
        auto nat_in_angular = (angular);
        self->getForce(nat_in_linear, nat_in_angular);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getForce_R_void_P__P__C_PxConstraint(PxConstraintPtr selfPtr,  linear,  angular);
    
    public  void getForce( linear,  angular){
         pvk_in_linear = (linear);
         pvk_in_angular = (angular);
        W_getForce_R_void_P__P__C_PxConstraint(this, pvk_in_linear, pvk_in_angular);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxConstraint(physx::PxConstraint* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxConstraint(PxConstraintPtr selfPtr);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxConstraint(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setBreakForce                                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_setBreakForce_R_void_P_float_P_float_C_PxConstraint(physx::PxConstraint* self, physx::PxReal linear, physx::PxReal angular){
        auto nat_in_linear = (linear);
        auto nat_in_angular = (angular);
        self->setBreakForce(nat_in_linear, nat_in_angular);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBreakForce_R_void_P_float_P_float_C_PxConstraint(PxConstraintPtr selfPtr, float linear, float angular);
    
    public  void setBreakForce(float linear, float angular){
        float pvk_in_linear = (linear);
        float pvk_in_angular = (angular);
        W_setBreakForce_R_void_P_float_P_float_C_PxConstraint(this, pvk_in_linear, pvk_in_angular);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBreakForce                                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_getBreakForce_R_void_P_floatPtr_P_floatPtr_C_PxConstraint(physx::PxConstraint* self, physx::PxReal& linear, physx::PxReal& angular){
        auto nat_in_linear = (linear);
        auto nat_in_angular = (angular);
        self->getBreakForce(nat_in_linear, nat_in_angular);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getBreakForce_R_void_P_floatPtr_P_floatPtr_C_PxConstraint(PxConstraintPtr selfPtr, float* linear, float* angular);
    
    public  void getBreakForce(float* linear, float* angular){
        float* pvk_in_linear = (linear);
        float* pvk_in_angular = (angular);
        W_getBreakForce_R_void_P_floatPtr_P_floatPtr_C_PxConstraint(this, pvk_in_linear, pvk_in_angular);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMinResponseThreshold                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMinResponseThreshold_R_void_P_float_C_PxConstraint(physx::PxConstraint* self, physx::PxReal threshold){
        auto nat_in_threshold = (threshold);
        self->setMinResponseThreshold(nat_in_threshold);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinResponseThreshold_R_void_P_float_C_PxConstraint(PxConstraintPtr selfPtr, float threshold);
    
    public  void setMinResponseThreshold(float threshold){
        float pvk_in_threshold = (threshold);
        W_setMinResponseThreshold_R_void_P_float_C_PxConstraint(this, pvk_in_threshold);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMinResponseThreshold                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMinResponseThreshold_R_float_C_PxConstraint(physx::PxConstraint* self){
        auto retVal = self->getMinResponseThreshold();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinResponseThreshold_R_float_C_PxConstraint(PxConstraintPtr selfPtr);
    
    public  float getMinResponseThreshold(){
        float retVal = W_getMinResponseThreshold_R_float_C_PxConstraint(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getExternalReference                                                   #
    //================================================================================
    #if NATIVE //function start
    ES void* W_getExternalReference_R_IntPtr_P_uintPtr_C_PxConstraint(physx::PxConstraint* self, physx::PxU32& typeID){
        auto nat_in_typeID = (typeID);
        auto retVal = self->getExternalReference(nat_in_typeID);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getExternalReference_R_IntPtr_P_uintPtr_C_PxConstraint(PxConstraintPtr selfPtr, uint* typeID);
    
    public  IntPtr getExternalReference(uint* typeID){
        uint* pvk_in_typeID = (typeID);
        IntPtr retVal = W_getExternalReference_R_IntPtr_P_uintPtr_C_PxConstraint(this, pvk_in_typeID);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setConstraintFunctions                                                 #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxConstraintShaderTablePtr
    // NATIVE SIG: void				setConstraintFunctions(PxConstraintConnector& connector,
    													   const PxConstraintShaderTable& shaders)		= 0
    #if NATIVE //function start
    ES void W_setConstraintFunctions_R_void_P_PxConstraintConnectorPtr_P_PxConstraintShaderTable_C_PxConstraint(physx::PxConstraint* self, physx::PxConstraintConnector* connector, physx::PxConstraintShaderTable shaders){
        auto nat_in_connector = (connector);
        auto nat_in_shaders = (shaders);
        self->setConstraintFunctions(*nat_in_connector, nat_in_shaders);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setConstraintFunctions_R_void_P_PxConstraintConnectorPtr_P_PxConstraintShaderTable_C_PxConstraint(PxConstraintPtr selfPtr, PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders);
    
    public  void setConstraintFunctions(PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders){
        PxConstraintConnectorPtr pvk_in_connector = (connector);
        PxConstraintShaderTable pvk_in_shaders = (shaders);
        W_setConstraintFunctions_R_void_P_PxConstraintConnectorPtr_P_PxConstraintShaderTable_C_PxConstraint(this, pvk_in_connector, pvk_in_shaders);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE //function start
    ES const char* W_getConcreteTypeName_R_string_C_PxConstraint(physx::PxConstraint* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string W_getConcreteTypeName_R_string_C_PxConstraint(PxConstraintPtr selfPtr);
    
    public  string getConcreteTypeName(){
        string retVal = W_getConcreteTypeName_R_string_C_PxConstraint(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxConstraint
    
    //Skipped protected: PxConstraint
    
    //Skipped protected: ~PxConstraint
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxConstraint
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxConstraintFlag is enum namespace
// Class physx::PxConstraintShaderTable Manually Ignored