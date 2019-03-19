#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxPvdUpdateType : int {
    CREATE_INSTANCE = 0,       // CREATE_INSTANCE
    RELEASE_INSTANCE = 1,      // RELEASE_INSTANCE
    UPDATE_ALL_PROPERTIES = 2, // UPDATE_ALL_PROPERTIES
    UPDATE_SIM_PROPERTIES = 3, // UPDATE_SIM_PROPERTIES
}
#endif //enum

#if !NATIVE //enum
public enum Type : int {
    eSPRING = 1,              // eSPRING = 1<<0
    eACCELERATION_SPRING = 2, // eACCELERATION_SPRING = 1<<1
    eRESTITUTION = 4,         // eRESTITUTION = 1<<2
    eKEEPBIAS = 8,            // eKEEPBIAS = 1<<3
    eOUTPUT_FORCE = 16,       // eOUTPUT_FORCE = 1<<4
    eHAS_DRIVE_LIMIT = 32,    // eHAS_DRIVE_LIMIT = 1<<5
    eANGULAR_CONSTRAINT = 64, // eANGULAR_CONSTRAINT = 1 << 6
    eDRIVE_ROW = 128,         // eDRIVE_ROW = 1 << 7
}
#endif //enum

#if !NATIVE //enum
public enum PxConstraintSolveHint : int {
    eNONE = 0,                     // eNONE = 0
    eACCELERATION1 = 256,          // eACCELERATION1 = 256
    eSLERP_SPRING = 258,           // eSLERP_SPRING = 258
    eACCELERATION2 = 512,          // eACCELERATION2 = 512
    eACCELERATION3 = 768,          // eACCELERATION3 = 768
    eROTATIONAL_EQUALITY = 1024,   // eROTATIONAL_EQUALITY = 1024
    eROTATIONAL_INEQUALITY = 1025, // eROTATIONAL_INEQUALITY = 1025
    eEQUALITY = 2048,              // eEQUALITY = 2048
    eINEQUALITY = 2049,            // eINEQUALITY = 2049
}
#endif //enum

#if !NATIVE //enum
public enum PxConstraintVisualizationFlag : int {
    eLOCAL_FRAMES = 1, // eLOCAL_FRAMES = 1
    eLIMITS = 2,       // eLIMITS = 2
}
#endif //enum

#if !NATIVE
public partial struct PxConstraintDesc {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_Px1DConstraintFlag_ushort_P_Type_P_Type(physx::Px1DConstraintFlag::Type a, physx::Px1DConstraintFlag::Type b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_Px1DConstraintFlag_ushort_P_Type_P_Type(Type a, Type b);

public static UNPARSED_TYPE operator|(Type a, Type b){
    Type pvk_in_a = (a);
    Type pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_Px1DConstraintFlag_ushort_P_Type_P_Type(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Px1DConstraintFlag_ushort_P_Type_P_Type(physx::Px1DConstraintFlag::Type a, physx::Px1DConstraintFlag::Type b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Px1DConstraintFlag_ushort_P_Type_P_Type(Type a, Type b);

public static UNPARSED_TYPE operator&(Type a, Type b){
    Type pvk_in_a = (a);
    Type pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Px1DConstraintFlag_ushort_P_Type_P_Type(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_Px1DConstraintFlag_ushort_P_Type(physx::Px1DConstraintFlag::Type a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_Px1DConstraintFlag_ushort_P_Type(Type a);

public static UNPARSED_TYPE operator~(Type a){
    Type pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_Px1DConstraintFlag_ushort_P_Type(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxConstraintDesc
#endif


// Class physx::pvdsdk::PvdDataStream Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxConstraintConnectorPtr {
     IntPtr prepareData();
    // bool updatePvdProperties(PvdDataStreamPtr pvdConnection, PxConstraintPtr c, PxPvdUpdateType updateType);
     void onConstraintRelease();
     void onComShift(uint actor);
     void onOriginShift(PxVec3 shift);
     IntPtr getExternalReference(uint* typeID);
     PxBasePtr getSerializable();
    // UNPARSED_TYPE getPrep();
     IntPtr getConstantBlock();
    // void ~PxConstraintConnector();
    //static UNPARSED_TYPE operator=(PxConstraintConnectorPtr lhs, /*NULLPARS*/);
    // PxConstraintConnector(/*NULLPARS*/);
    // PxConstraintConnector(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxConstraintConnectorPtr : IPxConstraintConnectorPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxConstraintConnectorPtr
    #endif //hierarchy
    //================================================================================
    //#       prepareData                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void* W_prepareData_R_IntPtr_C_PxConstraintConnector(physx::PxConstraintConnector* self){
        auto retVal = self->prepareData();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_prepareData_R_IntPtr_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr);
    
    public  IntPtr prepareData(){
        IntPtr retVal = W_prepareData_R_IntPtr_C_PxConstraintConnector(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       updatePvdProperties                                                    #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PvdDataStreamPtr
    // NATIVE SIG: bool					updatePvdProperties(physx::pvdsdk::PvdDataStream& pvdConnection,
    												const PxConstraint* c,
    												PxPvdUpdateType::Enum updateType) const		= 0
    #if NATIVE //function start
    ES bool W_updatePvdProperties_R_bool_P_PvdDataStreamPtr_P_PxConstraintPtr_P_PxPvdUpdateType_C_PxConstraintConnector(physx::PxConstraintConnector* self, physx::pvdsdk::PvdDataStream* pvdConnection, physx::PxConstraint* c, physx::PxPvdUpdateType::Enum updateType){
        auto nat_in_pvdConnection = (pvdConnection);
        auto nat_in_c = (c);
        auto nat_in_updateType = (updateType);
        auto retVal = self->updatePvdProperties(*nat_in_pvdConnection, nat_in_c, nat_in_updateType);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_updatePvdProperties_R_bool_P_PvdDataStreamPtr_P_PxConstraintPtr_P_PxPvdUpdateType_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr, PvdDataStreamPtr pvdConnection, PxConstraintPtr c, PxPvdUpdateType updateType);
    
    public  bool updatePvdProperties(PvdDataStreamPtr pvdConnection, PxConstraintPtr c, PxPvdUpdateType updateType){
        PvdDataStreamPtr pvk_in_pvdConnection = (pvdConnection);
        PxConstraintPtr pvk_in_c = (c);
        PxPvdUpdateType pvk_in_updateType = (updateType);
        bool retVal = W_updatePvdProperties_R_bool_P_PvdDataStreamPtr_P_PxConstraintPtr_P_PxPvdUpdateType_C_PxConstraintConnector(this, pvk_in_pvdConnection, pvk_in_c, pvk_in_updateType);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       onConstraintRelease                                                    #
    //================================================================================
    #if NATIVE //function start
    ES void W_onConstraintRelease_R_void_C_PxConstraintConnector(physx::PxConstraintConnector* self){
        self->onConstraintRelease();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_onConstraintRelease_R_void_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr);
    
    public  void onConstraintRelease(){
        W_onConstraintRelease_R_void_C_PxConstraintConnector(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       onComShift                                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_onComShift_R_void_P_uint_C_PxConstraintConnector(physx::PxConstraintConnector* self, physx::PxU32 actor){
        auto nat_in_actor = (actor);
        self->onComShift(nat_in_actor);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_onComShift_R_void_P_uint_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr, uint actor);
    
    public  void onComShift(uint actor){
        uint pvk_in_actor = (actor);
        W_onComShift_R_void_P_uint_C_PxConstraintConnector(this, pvk_in_actor);
    }
    #endif //function end
    
    
    //================================================================================
    //#       onOriginShift                                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_onOriginShift_R_void_P_PxVec3_C_PxConstraintConnector(physx::PxConstraintConnector* self, physx::PxVec3 shift){
        auto nat_in_shift = (shift);
        self->onOriginShift(nat_in_shift);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_onOriginShift_R_void_P_PxVec3_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr, PxVec3 shift);
    
    public  void onOriginShift(PxVec3 shift){
        PxVec3 pvk_in_shift = (shift);
        W_onOriginShift_R_void_P_PxVec3_C_PxConstraintConnector(this, pvk_in_shift);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getExternalReference                                                   #
    //================================================================================
    #if NATIVE //function start
    ES void* W_getExternalReference_R_IntPtr_P_uintPtr_C_PxConstraintConnector(physx::PxConstraintConnector* self, physx::PxU32& typeID){
        auto nat_in_typeID = (typeID);
        auto retVal = self->getExternalReference(nat_in_typeID);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getExternalReference_R_IntPtr_P_uintPtr_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr, uint* typeID);
    
    public  IntPtr getExternalReference(uint* typeID){
        uint* pvk_in_typeID = (typeID);
        IntPtr retVal = W_getExternalReference_R_IntPtr_P_uintPtr_C_PxConstraintConnector(this, pvk_in_typeID);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getSerializable                                                        #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBase* W_getSerializable_R_PxBasePtr_C_PxConstraintConnector(physx::PxConstraintConnector* self){
        auto retVal = self->getSerializable();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBasePtr W_getSerializable_R_PxBasePtr_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr);
    
    public  PxBasePtr getSerializable(){
        PxBasePtr retVal = W_getSerializable_R_PxBasePtr_C_PxConstraintConnector(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getPrep                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraintSolverPrep
    // NATIVE SIG: PxConstraintSolverPrep getPrep()	const										= 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getPrep_R_PxConstraintSolverPrep_C_PxConstraintConnector(physx::PxConstraintConnector* self){
        auto retVal = self->getPrep();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getPrep_R_PxConstraintSolverPrep_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr);
    
    public  UNPARSED_TYPE getPrep(){
        UNPARSED_TYPE retVal = W_getPrep_R_PxConstraintSolverPrep_C_PxConstraintConnector(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getConstantBlock                                                       #
    //================================================================================
    #if NATIVE //function start
    ES const void* W_getConstantBlock_R_IntPtr_C_PxConstraintConnector(physx::PxConstraintConnector* self){
        auto retVal = self->getConstantBlock();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConstantBlock_R_IntPtr_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr);
    
    public  IntPtr getConstantBlock(){
        IntPtr retVal = W_getConstantBlock_R_IntPtr_C_PxConstraintConnector(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       ~PxConstraintConnector                                                 #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual							~PxConstraintConnector() {}
    #if NATIVE //function start
    ES void W_~PxConstraintConnector_R_void_C_PxConstraintConnector(physx::PxConstraintConnector* self){
        self->~PxConstraintConnector();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConstraintConnector_R_void_C_PxConstraintConnector(PxConstraintConnectorPtr selfPtr);
    
    public  void ~PxConstraintConnector(){
        W_~PxConstraintConnector_R_void_C_PxConstraintConnector(this);
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxConstraintConnector
    
    //Skipped generated implicit entry: PxConstraintConnector
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxPvdUpdateType is enum namespace
// Class physx::Px1DConstraint Manually Ignored
// Union physx::Px1DConstraint TODO
#if !NATIVE //interface
public unsafe interface ISpringModifiers {
    // SpringModifiers(/*NULLPARS*/);
    // SpringModifiers(/*NULLPARS*/);
    // UNPARSED_TYPE ~SpringModifiers(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(SpringModifiers lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(SpringModifiers lhs, /*NULLPARS*/);
    // SpringModifiers(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct SpringModifiers : ISpringModifiers { // blittable
    public float stiffness;
    public float damping;

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: SpringModifiers
    #endif //hierarchy
    //Skipped generated implicit entry: SpringModifiers
    
    //Skipped generated implicit entry: SpringModifiers
    
    //Skipped generated implicit entry: ~SpringModifiers
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: SpringModifiers
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IRestitutionModifiers {
    // RestitutionModifiers(/*NULLPARS*/);
    // RestitutionModifiers(/*NULLPARS*/);
    // UNPARSED_TYPE ~RestitutionModifiers(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(RestitutionModifiers lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(RestitutionModifiers lhs, /*NULLPARS*/);
    // RestitutionModifiers(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct RestitutionModifiers : IRestitutionModifiers { // blittable
    public float restitution;
    public float velocityThreshold;

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: RestitutionModifiers
    #endif //hierarchy
    //Skipped generated implicit entry: RestitutionModifiers
    
    //Skipped generated implicit entry: RestitutionModifiers
    
    //Skipped generated implicit entry: ~RestitutionModifiers
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: RestitutionModifiers
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxConstraintInvMassScalePtr {
    // PxConstraintInvMassScale();
    // PxConstraintInvMassScale(float lin0, float ang0, float lin1, float ang1);
    // PxConstraintInvMassScale(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxConstraintInvMassScalePtr lhs, /*NULLPARS*/);
    // PxConstraintInvMassScale(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxConstraintInvMassScalePtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxConstraintInvMassScale(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxConstraintInvMassScalePtr : IPxConstraintInvMassScalePtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields

    // ### LINEAR0 getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxConstraintInvMassScale_GET_linear0(PxConstraintInvMassScale* self) {return self->linear0;}
    ES void PxConstraintInvMassScale_SET_linear0(PxConstraintInvMassScale* self, physx::PxReal value) {self->linear0 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxConstraintInvMassScale_GET_linear0(PxConstraintInvMassScalePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxConstraintInvMassScale_SET_linear0(PxConstraintInvMassScalePtr selfPtr, float value);

    public float linear0 {
        get => PxConstraintInvMassScale_GET_linear0(this);
        set => PxConstraintInvMassScale_SET_linear0(this, value);
    }
    #endif //getter

    // ### ANGULAR0 getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxConstraintInvMassScale_GET_angular0(PxConstraintInvMassScale* self) {return self->angular0;}
    ES void PxConstraintInvMassScale_SET_angular0(PxConstraintInvMassScale* self, physx::PxReal value) {self->angular0 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxConstraintInvMassScale_GET_angular0(PxConstraintInvMassScalePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxConstraintInvMassScale_SET_angular0(PxConstraintInvMassScalePtr selfPtr, float value);

    public float angular0 {
        get => PxConstraintInvMassScale_GET_angular0(this);
        set => PxConstraintInvMassScale_SET_angular0(this, value);
    }
    #endif //getter

    // ### LINEAR1 getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxConstraintInvMassScale_GET_linear1(PxConstraintInvMassScale* self) {return self->linear1;}
    ES void PxConstraintInvMassScale_SET_linear1(PxConstraintInvMassScale* self, physx::PxReal value) {self->linear1 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxConstraintInvMassScale_GET_linear1(PxConstraintInvMassScalePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxConstraintInvMassScale_SET_linear1(PxConstraintInvMassScalePtr selfPtr, float value);

    public float linear1 {
        get => PxConstraintInvMassScale_GET_linear1(this);
        set => PxConstraintInvMassScale_SET_linear1(this, value);
    }
    #endif //getter

    // ### ANGULAR1 getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxConstraintInvMassScale_GET_angular1(PxConstraintInvMassScale* self) {return self->angular1;}
    ES void PxConstraintInvMassScale_SET_angular1(PxConstraintInvMassScale* self, physx::PxReal value) {self->angular1 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxConstraintInvMassScale_GET_angular1(PxConstraintInvMassScalePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxConstraintInvMassScale_SET_angular1(PxConstraintInvMassScalePtr selfPtr, float value);

    public float angular1 {
        get => PxConstraintInvMassScale_GET_angular1(this);
        set => PxConstraintInvMassScale_SET_angular1(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxConstraintInvMassScalePtr
    #endif //hierarchy
    //================================================================================
    //#       PxConstraintInvMassScale                                               #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxConstraintInvMassScale
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxConstraintInvMassScale                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraintInvMassScale
    // NATIVE SIG: PX_FORCE_INLINE PxConstraintInvMassScale(PxReal lin0, PxReal ang0, PxReal lin1, PxReal ang1) : linear0(lin0), angular0(ang0), linear1(lin1), angular1(ang1){}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxConstraintInvMassScale_R_PxConstraintInvMassScalePtr_P_float_P_float_P_float_P_float_C_PxConstraintInvMassScale_ctor(physx::PxReal lin0, physx::PxReal ang0, physx::PxReal lin1, physx::PxReal ang1){
        auto nat_in_lin0 = (lin0);
        auto nat_in_ang0 = (ang0);
        auto nat_in_lin1 = (lin1);
        auto nat_in_ang1 = (ang1);
        return PxConstraintInvMassScale(nat_in_lin0, nat_in_ang0, nat_in_lin1, nat_in_ang1);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConstraintInvMassScale_R_PxConstraintInvMassScalePtr_P_float_P_float_P_float_P_float_C_PxConstraintInvMassScale_ctor(float lin0, float ang0, float lin1, float ang1);
    
    public  PxConstraintInvMassScale(float lin0, float ang0, float lin1, float ang1){
        float pvk_in_lin0 = (lin0);
        float pvk_in_ang0 = (ang0);
        float pvk_in_lin1 = (lin1);
        float pvk_in_ang1 = (ang1);
        var _new = W_PxConstraintInvMassScale_R_PxConstraintInvMassScalePtr_P_float_P_float_P_float_P_float_C_PxConstraintInvMassScale_ctor(pvk_in_lin0, pvk_in_ang0, pvk_in_lin1, pvk_in_ang1);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: PxConstraintInvMassScale
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxConstraintInvMassScale
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxConstraintInvMassScale
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxConstraintVisualizerPtr {
    // UNPARSED_TYPE ~PxConstraintVisualizer(/*NULLPARS*/);
     void visualizeJointFrames(PxTransform parent, PxTransform child);
     void visualizeLinearLimit(PxTransform t0, PxTransform t1, float value, bool active);
     void visualizeAngularLimit(PxTransform t0, float lower, float upper, bool active);
     void visualizeLimitCone(PxTransform t, float tanQSwingY, float tanQSwingZ, bool active);
     void visualizeDoubleCone(PxTransform t, float angle, bool active);
     void visualizeLine(PxVec3 p0, PxVec3 p1, uint color);
    //static UNPARSED_TYPE operator=(PxConstraintVisualizerPtr lhs, /*NULLPARS*/);
    // PxConstraintVisualizer(/*NULLPARS*/);
    // PxConstraintVisualizer(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxConstraintVisualizerPtr : IPxConstraintVisualizerPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxConstraintVisualizerPtr
    #endif //hierarchy
    //Skipped protected: ~PxConstraintVisualizer
    
    //================================================================================
    //#       visualizeJointFrames                                                   #
    //================================================================================
    #if NATIVE //function start
    ES void W_visualizeJointFrames_R_void_P_PxTransform_P_PxTransform_C_PxConstraintVisualizer(physx::PxConstraintVisualizer* self, physx::PxTransform parent, physx::PxTransform child){
        auto nat_in_parent = (parent);
        auto nat_in_child = (child);
        self->visualizeJointFrames(nat_in_parent, nat_in_child);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeJointFrames_R_void_P_PxTransform_P_PxTransform_C_PxConstraintVisualizer(PxConstraintVisualizerPtr selfPtr, PxTransform parent, PxTransform child);
    
    public  void visualizeJointFrames(PxTransform parent, PxTransform child){
        PxTransform pvk_in_parent = (parent);
        PxTransform pvk_in_child = (child);
        W_visualizeJointFrames_R_void_P_PxTransform_P_PxTransform_C_PxConstraintVisualizer(this, pvk_in_parent, pvk_in_child);
    }
    #endif //function end
    
    
    //================================================================================
    //#       visualizeLinearLimit                                                   #
    //================================================================================
    #if NATIVE //function start
    ES void W_visualizeLinearLimit_R_void_P_PxTransform_P_PxTransform_P_float_P_bool_C_PxConstraintVisualizer(physx::PxConstraintVisualizer* self, physx::PxTransform t0, physx::PxTransform t1, physx::PxReal value, bool active){
        auto nat_in_t0 = (t0);
        auto nat_in_t1 = (t1);
        auto nat_in_value = (value);
        auto nat_in_active = (active);
        self->visualizeLinearLimit(nat_in_t0, nat_in_t1, nat_in_value, nat_in_active);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeLinearLimit_R_void_P_PxTransform_P_PxTransform_P_float_P_bool_C_PxConstraintVisualizer(PxConstraintVisualizerPtr selfPtr, PxTransform t0, PxTransform t1, float value, bool active);
    
    public  void visualizeLinearLimit(PxTransform t0, PxTransform t1, float value, bool active){
        PxTransform pvk_in_t0 = (t0);
        PxTransform pvk_in_t1 = (t1);
        float pvk_in_value = (value);
        bool pvk_in_active = (active);
        W_visualizeLinearLimit_R_void_P_PxTransform_P_PxTransform_P_float_P_bool_C_PxConstraintVisualizer(this, pvk_in_t0, pvk_in_t1, pvk_in_value, pvk_in_active);
    }
    #endif //function end
    
    
    //================================================================================
    //#       visualizeAngularLimit                                                  #
    //================================================================================
    #if NATIVE //function start
    ES void W_visualizeAngularLimit_R_void_P_PxTransform_P_float_P_float_P_bool_C_PxConstraintVisualizer(physx::PxConstraintVisualizer* self, physx::PxTransform t0, physx::PxReal lower, physx::PxReal upper, bool active){
        auto nat_in_t0 = (t0);
        auto nat_in_lower = (lower);
        auto nat_in_upper = (upper);
        auto nat_in_active = (active);
        self->visualizeAngularLimit(nat_in_t0, nat_in_lower, nat_in_upper, nat_in_active);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeAngularLimit_R_void_P_PxTransform_P_float_P_float_P_bool_C_PxConstraintVisualizer(PxConstraintVisualizerPtr selfPtr, PxTransform t0, float lower, float upper, bool active);
    
    public  void visualizeAngularLimit(PxTransform t0, float lower, float upper, bool active){
        PxTransform pvk_in_t0 = (t0);
        float pvk_in_lower = (lower);
        float pvk_in_upper = (upper);
        bool pvk_in_active = (active);
        W_visualizeAngularLimit_R_void_P_PxTransform_P_float_P_float_P_bool_C_PxConstraintVisualizer(this, pvk_in_t0, pvk_in_lower, pvk_in_upper, pvk_in_active);
    }
    #endif //function end
    
    
    //================================================================================
    //#       visualizeLimitCone                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_visualizeLimitCone_R_void_P_PxTransform_P_float_P_float_P_bool_C_PxConstraintVisualizer(physx::PxConstraintVisualizer* self, physx::PxTransform t, physx::PxReal tanQSwingY, physx::PxReal tanQSwingZ, bool active){
        auto nat_in_t = (t);
        auto nat_in_tanQSwingY = (tanQSwingY);
        auto nat_in_tanQSwingZ = (tanQSwingZ);
        auto nat_in_active = (active);
        self->visualizeLimitCone(nat_in_t, nat_in_tanQSwingY, nat_in_tanQSwingZ, nat_in_active);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeLimitCone_R_void_P_PxTransform_P_float_P_float_P_bool_C_PxConstraintVisualizer(PxConstraintVisualizerPtr selfPtr, PxTransform t, float tanQSwingY, float tanQSwingZ, bool active);
    
    public  void visualizeLimitCone(PxTransform t, float tanQSwingY, float tanQSwingZ, bool active){
        PxTransform pvk_in_t = (t);
        float pvk_in_tanQSwingY = (tanQSwingY);
        float pvk_in_tanQSwingZ = (tanQSwingZ);
        bool pvk_in_active = (active);
        W_visualizeLimitCone_R_void_P_PxTransform_P_float_P_float_P_bool_C_PxConstraintVisualizer(this, pvk_in_t, pvk_in_tanQSwingY, pvk_in_tanQSwingZ, pvk_in_active);
    }
    #endif //function end
    
    
    //================================================================================
    //#       visualizeDoubleCone                                                    #
    //================================================================================
    #if NATIVE //function start
    ES void W_visualizeDoubleCone_R_void_P_PxTransform_P_float_P_bool_C_PxConstraintVisualizer(physx::PxConstraintVisualizer* self, physx::PxTransform t, physx::PxReal angle, bool active){
        auto nat_in_t = (t);
        auto nat_in_angle = (angle);
        auto nat_in_active = (active);
        self->visualizeDoubleCone(nat_in_t, nat_in_angle, nat_in_active);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeDoubleCone_R_void_P_PxTransform_P_float_P_bool_C_PxConstraintVisualizer(PxConstraintVisualizerPtr selfPtr, PxTransform t, float angle, bool active);
    
    public  void visualizeDoubleCone(PxTransform t, float angle, bool active){
        PxTransform pvk_in_t = (t);
        float pvk_in_angle = (angle);
        bool pvk_in_active = (active);
        W_visualizeDoubleCone_R_void_P_PxTransform_P_float_P_bool_C_PxConstraintVisualizer(this, pvk_in_t, pvk_in_angle, pvk_in_active);
    }
    #endif //function end
    
    
    //================================================================================
    //#       visualizeLine                                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_visualizeLine_R_void_P_PxVec3_P_PxVec3_P_uint_C_PxConstraintVisualizer(physx::PxConstraintVisualizer* self, physx::PxVec3 p0, physx::PxVec3 p1, physx::PxU32 color){
        auto nat_in_p0 = (p0);
        auto nat_in_p1 = (p1);
        auto nat_in_color = (color);
        self->visualizeLine(nat_in_p0, nat_in_p1, nat_in_color);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeLine_R_void_P_PxVec3_P_PxVec3_P_uint_C_PxConstraintVisualizer(PxConstraintVisualizerPtr selfPtr, PxVec3 p0, PxVec3 p1, uint color);
    
    public  void visualizeLine(PxVec3 p0, PxVec3 p1, uint color){
        PxVec3 pvk_in_p0 = (p0);
        PxVec3 pvk_in_p1 = (p1);
        uint pvk_in_color = (color);
        W_visualizeLine_R_void_P_PxVec3_P_PxVec3_P_uint_C_PxConstraintVisualizer(this, pvk_in_p0, pvk_in_p1, pvk_in_color);
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxConstraintVisualizer
    
    //Skipped generated implicit entry: PxConstraintVisualizer
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxRenderBuffer Manually Ignored
#if !NATIVE //interface
public unsafe interface IPx1DConstraintFlagPtr {
    // Px1DConstraintFlag();
    // Px1DConstraintFlag(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(Px1DConstraintFlagPtr lhs, /*NULLPARS*/);
    // Px1DConstraintFlag(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(Px1DConstraintFlagPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~Px1DConstraintFlag(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct Px1DConstraintFlagPtr : IPx1DConstraintFlagPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: Px1DConstraintFlagPtr
    #endif //hierarchy
    //================================================================================
    //#       Px1DConstraintFlag                                                     #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::Px1DConstraintFlag
    Parameterless constructor not allowed
    */
    
    
    //Skipped generated implicit entry: Px1DConstraintFlag
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: Px1DConstraintFlag
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~Px1DConstraintFlag
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxConstraintSolveHint is enum namespace
// Class physx::PxConstraintVisualizationFlag is enum namespace