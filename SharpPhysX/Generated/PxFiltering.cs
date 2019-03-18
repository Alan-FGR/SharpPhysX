#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxFilterFlag : int {
    eKILL = 1,     // eKILL = (1<<0)
    eSUPPRESS = 2, // eSUPPRESS = (1<<1)
    eCALLBACK = 4, // eCALLBACK = (1<<2)
    eNOTIFY = 12,  // eNOTIFY = (1<<3) | eCALLBACK
    eDEFAULT = 0,  // eDEFAULT = 0
}
#endif

#if !NATIVE
public enum PxPairFlag : int {
    eSOLVE_CONTACT = 1,                     // eSOLVE_CONTACT = (1<<0)
    eMODIFY_CONTACTS = 2,                   // eMODIFY_CONTACTS = (1<<1)
    eNOTIFY_TOUCH_FOUND = 4,                // eNOTIFY_TOUCH_FOUND = (1<<2)
    eNOTIFY_TOUCH_PERSISTS = 8,             // eNOTIFY_TOUCH_PERSISTS = (1<<3)
    eNOTIFY_TOUCH_LOST = 16,                // eNOTIFY_TOUCH_LOST = (1<<4)
    eNOTIFY_TOUCH_CCD = 32,                 // eNOTIFY_TOUCH_CCD = (1<<5)
    eNOTIFY_THRESHOLD_FORCE_FOUND = 64,     // eNOTIFY_THRESHOLD_FORCE_FOUND = (1<<6)
    eNOTIFY_THRESHOLD_FORCE_PERSISTS = 128, // eNOTIFY_THRESHOLD_FORCE_PERSISTS = (1<<7)
    eNOTIFY_THRESHOLD_FORCE_LOST = 256,     // eNOTIFY_THRESHOLD_FORCE_LOST = (1<<8)
    eNOTIFY_CONTACT_POINTS = 512,           // eNOTIFY_CONTACT_POINTS = (1<<9)
    eDETECT_DISCRETE_CONTACT = 1024,        // eDETECT_DISCRETE_CONTACT = (1<<10)
    eDETECT_CCD_CONTACT = 2048,             // eDETECT_CCD_CONTACT = (1<<11)
    ePRE_SOLVER_VELOCITY = 4096,            // ePRE_SOLVER_VELOCITY = (1<<12)
    ePOST_SOLVER_VELOCITY = 8192,           // ePOST_SOLVER_VELOCITY = (1<<13)
    eCONTACT_EVENT_POSE = 16384,            // eCONTACT_EVENT_POSE = (1<<14)
    eNEXT_FREE = 32768,                     // eNEXT_FREE = (1<<15)
    eCONTACT_DEFAULT = 1025,                // eCONTACT_DEFAULT = eSOLVE_CONTACT | eDETECT_DISCRETE_CONTACT
    eTRIGGER_DEFAULT = 1044,                // eTRIGGER_DEFAULT = eNOTIFY_TOUCH_FOUND | eNOTIFY_TOUCH_LOST | eDETECT_DISCRETE_CONTACT
}
#endif

#if !NATIVE
public enum PxPairFilteringMode : int {
    eKEEP = 0,     // eKEEP
    eSUPPRESS = 1, // eSUPPRESS
    eKILL = 2,     // eKILL
    eDEFAULT = 3,  // eDEFAULT
}
#endif

#if !NATIVE
public enum PxFilterObjectType : int {
    eRIGID_STATIC = 0,    // eRIGID_STATIC
    eRIGID_DYNAMIC = 1,   // eRIGID_DYNAMIC
    eARTICULATION = 2,    // eARTICULATION
    eMAX_TYPE_COUNT = 16, // eMAX_TYPE_COUNT = 16
    eUNDEFINED = 15,      // eUNDEFINED = eMAX_TYPE_COUNT-1
}
#endif

#if !NATIVE
public enum PxFilterObjectFlag : int {
    eKINEMATIC = 16, // eKINEMATIC = (1<<4)
    eTRIGGER = 32,   // eTRIGGER = (1<<5)
}
#endif

#if !NATIVE
public partial struct PxFiltering {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxPairFlag::Enum a, physx::PxPairFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxPairFlag a, PxPairFlag b);

public static UNPARSED_TYPE operator|(PxPairFlag a, PxPairFlag b){
    PxPairFlag pvk_in_a = (a);
    PxPairFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxPairFlag::Enum a, physx::PxPairFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxPairFlag a, PxPairFlag b);

public static UNPARSED_TYPE operator&(PxPairFlag a, PxPairFlag b){
    PxPairFlag pvk_in_a = (a);
    PxPairFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxPairFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxPairFlag a);

public static UNPARSED_TYPE operator~(PxPairFlag a){
    PxPairFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/


//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxFilterFlag::Enum a, physx::PxFilterFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxFilterFlag a, PxFilterFlag b);

public static UNPARSED_TYPE operator|(PxFilterFlag a, PxFilterFlag b){
    PxFilterFlag pvk_in_a = (a);
    PxFilterFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxFilterFlag::Enum a, physx::PxFilterFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxFilterFlag a, PxFilterFlag b);

public static UNPARSED_TYPE operator&(PxFilterFlag a, PxFilterFlag b){
    PxFilterFlag pvk_in_a = (a);
    PxFilterFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxFilterFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxFilterFlag a);

public static UNPARSED_TYPE operator~(PxFilterFlag a){
    PxFilterFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/


//================================================================================
//#       PxGetFilterObjectType                                                  #
//================================================================================
#if NATIVE
ES physx::PxFilterObjectType::Enum W_PxGetFilterObjectType(physx::PxFilterObjectAttributes attr){
    auto nat_in_attr = (attr);
    auto retVal = physx::PxGetFilterObjectType(nat_in_attr);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFilterObjectType W_PxGetFilterObjectType(uint attr);

public static PxFilterObjectType PxGetFilterObjectType(uint attr){
    uint pvk_in_attr = (attr);
    PxFilterObjectType retVal = W_PxGetFilterObjectType(pvk_in_attr);
    return retVal;
}
#endif


//================================================================================
//#       PxFilterObjectIsKinematic                                              #
//================================================================================
#if NATIVE
ES bool W_PxFilterObjectIsKinematic(physx::PxFilterObjectAttributes attr){
    auto nat_in_attr = (attr);
    auto retVal = physx::PxFilterObjectIsKinematic(nat_in_attr);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxFilterObjectIsKinematic(uint attr);

public static bool PxFilterObjectIsKinematic(uint attr){
    uint pvk_in_attr = (attr);
    bool retVal = W_PxFilterObjectIsKinematic(pvk_in_attr);
    return retVal;
}
#endif


//================================================================================
//#       PxFilterObjectIsTrigger                                                #
//================================================================================
#if NATIVE
ES bool W_PxFilterObjectIsTrigger(physx::PxFilterObjectAttributes attr){
    auto nat_in_attr = (attr);
    auto retVal = physx::PxFilterObjectIsTrigger(nat_in_attr);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxFilterObjectIsTrigger(uint attr);

public static bool PxFilterObjectIsTrigger(uint attr){
    uint pvk_in_attr = (attr);
    bool retVal = W_PxFilterObjectIsTrigger(pvk_in_attr);
    return retVal;
}
#endif

#if !NATIVE
} // End PxFiltering
#endif


#if !NATIVE
public unsafe interface IPxFilterDataPtr {
    // PxFilterData(PxEMPTY );
    // PxFilterData();
    // PxFilterData(PxFilterDataPtr fd);
    // PxFilterData(uint w0, uint w1, uint w2, uint w3);
     void setToDefault();
    //static void operator=(PxFilterDataPtr lhs, /*NULLPARS*/);
    //static bool operator==(PxFilterDataPtr lhs, PxFilterDataPtr a);
    //static bool operator!=(PxFilterDataPtr lhs, PxFilterDataPtr a);
    // UNPARSED_TYPE ~PxFilterData(/*NULLPARS*/);
    
}

public unsafe partial struct PxFilterDataPtr : IPxFilterDataPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxFilterDataPtr
    //================================================================================
    //#       PxFilterData                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    Invalid parameter name (empty)
    // NATIVE SIG: PX_INLINE PxFilterData(const PxEMPTY)
    	{
    	}
    #if NATIVE
    ES UNPARSED_TYPE W_PxFilterData_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        self->PxFilterData(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFilterData_ctor(PxEMPTY );
    
    public  PxFilterData(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFilterData_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFilterData                                                           #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxFilterData
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxFilterData                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    // NATIVE SIG: PX_INLINE PxFilterData(const PxFilterData& fd) : word0(fd.word0), word1(fd.word1), word2(fd.word2), word3(fd.word3)	{}
    #if NATIVE
    ES UNPARSED_TYPE W_PxFilterData_ctor(physx::PxFilterData* fd){
        auto nat_in_fd = (fd);
        self->PxFilterData(*nat_in_fd);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFilterData_ctor(PxFilterDataPtr fd);
    
    public  PxFilterData(PxFilterDataPtr fd){
        PxFilterDataPtr pvk_in_fd = (fd);
        var _new = W_PxFilterData_ctor(pvk_in_fd);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFilterData                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    // NATIVE SIG: PX_INLINE PxFilterData(PxU32 w0, PxU32 w1, PxU32 w2, PxU32 w3) : word0(w0), word1(w1), word2(w2), word3(w3) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxFilterData_ctor(physx::PxU32 w0, physx::PxU32 w1, physx::PxU32 w2, physx::PxU32 w3){
        auto nat_in_w0 = (w0);
        auto nat_in_w1 = (w1);
        auto nat_in_w2 = (w2);
        auto nat_in_w3 = (w3);
        self->PxFilterData(nat_in_w0, nat_in_w1, nat_in_w2, nat_in_w3);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFilterData_ctor(uint w0, uint w1, uint w2, uint w3);
    
    public  PxFilterData(uint w0, uint w1, uint w2, uint w3){
        uint pvk_in_w0 = (w0);
        uint pvk_in_w1 = (w1);
        uint pvk_in_w2 = (w2);
        uint pvk_in_w3 = (w3);
        var _new = W_PxFilterData_ctor(pvk_in_w0, pvk_in_w1, pvk_in_w2, pvk_in_w3);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       setToDefault                                                           #
    //================================================================================
    #if NATIVE
    ES void W_setToDefault(physx::PxFilterData* self){
        self->setToDefault();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setToDefault(PxFilterDataPtr selfPtr);
    
    public  void setToDefault(){
        W_setToDefault(this);
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxFilterData* self, physx::PxFilterData* a){
        auto nat_in_a = (a);
        auto retVal = self->operator==(*nat_in_a);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxFilterDataPtr selfPtr, PxFilterDataPtr a);
    
    public static bool operator==(PxFilterDataPtr lhs, PxFilterDataPtr a){
        PxFilterDataPtr pvk_in_a = (a);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_a);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_OP_ExclaimEqual(physx::PxFilterData* self, physx::PxFilterData* a){
        auto nat_in_a = (a);
        auto retVal = self->operator!=(*nat_in_a);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual(PxFilterDataPtr selfPtr, PxFilterDataPtr a);
    
    public static bool operator!=(PxFilterDataPtr lhs, PxFilterDataPtr a){
        PxFilterDataPtr pvk_in_a = (a);
        bool retVal = W_OP_ExclaimEqual(lhs, pvk_in_a);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: ~PxFilterData
    

#if !NATIVE
}
#endif

// Class physx::PxFilterFlag is enum namespace
// Class physx::PxPairFlag is enum namespace
#if !NATIVE
public unsafe interface IPxSimulationFilterCallbackPtr {
    // UNPARSED_TYPE pairFound(uint pairID, uint attributes0,  filterData0, PxActorPtr a0, PxShapePtr s0, uint attributes1,  filterData1, PxActorPtr a1, PxShapePtr s1,  pairFlags);
    // void pairLost(uint pairID, uint attributes0,  filterData0, uint attributes1,  filterData1, bool objectRemoved);
    // bool statusChange(uint* pairID,  pairFlags,  filterFlags);
    // void ~PxSimulationFilterCallback();
    //static UNPARSED_TYPE operator=(PxSimulationFilterCallbackPtr lhs, /*NULLPARS*/);
    // PxSimulationFilterCallback(/*NULLPARS*/);
    // PxSimulationFilterCallback(/*NULLPARS*/);
    
}

public unsafe partial struct PxSimulationFilterCallbackPtr : IPxSimulationFilterCallbackPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxSimulationFilterCallbackPtr
    //================================================================================
    //#       pairFound                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterFlags
    Unresolved parameter type physx::PxFilterData
    Unresolved parameter type physx::PxFilterData
    fsdfasdf
    // NATIVE SIG: PxFilterFlags	pairFound(	PxU32 pairID,
    		PxFilterObjectAttributes attributes0, PxFilterData filterData0, const PxActor* a0, const PxShape* s0,
    		PxFilterObjectAttributes attributes1, PxFilterData filterData1, const PxActor* a1, const PxShape* s1,
    		PxPairFlags& pairFlags) = 0
    #if NATIVE
    ES UNPARSED_TYPE W_pairFound(physx::PxSimulationFilterCallback* self, physx::PxU32 pairID, physx::PxFilterObjectAttributes attributes0,  filterData0, physx::PxActor* a0, physx::PxShape* s0, physx::PxFilterObjectAttributes attributes1,  filterData1, physx::PxActor* a1, physx::PxShape* s1,  pairFlags){
        auto nat_in_pairID = (pairID);
        auto nat_in_attributes0 = (attributes0);
        auto nat_in_filterData0 = (filterData0);
        auto nat_in_a0 = (a0);
        auto nat_in_s0 = (s0);
        auto nat_in_attributes1 = (attributes1);
        auto nat_in_filterData1 = (filterData1);
        auto nat_in_a1 = (a1);
        auto nat_in_s1 = (s1);
        auto nat_in_pairFlags = (pairFlags);
        auto retVal = self->pairFound(nat_in_pairID, nat_in_attributes0, nat_in_filterData0, nat_in_a0, nat_in_s0, nat_in_attributes1, nat_in_filterData1, nat_in_a1, nat_in_s1, nat_in_pairFlags);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_pairFound(PxSimulationFilterCallbackPtr selfPtr, uint pairID, uint attributes0,  filterData0, PxActorPtr a0, PxShapePtr s0, uint attributes1,  filterData1, PxActorPtr a1, PxShapePtr s1,  pairFlags);
    
    public  UNPARSED_TYPE pairFound(uint pairID, uint attributes0,  filterData0, PxActorPtr a0, PxShapePtr s0, uint attributes1,  filterData1, PxActorPtr a1, PxShapePtr s1,  pairFlags){
        uint pvk_in_pairID = (pairID);
        uint pvk_in_attributes0 = (attributes0);
         pvk_in_filterData0 = (filterData0);
        PxActorPtr pvk_in_a0 = (a0);
        PxShapePtr pvk_in_s0 = (s0);
        uint pvk_in_attributes1 = (attributes1);
         pvk_in_filterData1 = (filterData1);
        PxActorPtr pvk_in_a1 = (a1);
        PxShapePtr pvk_in_s1 = (s1);
         pvk_in_pairFlags = (pairFlags);
        UNPARSED_TYPE retVal = W_pairFound(this, pvk_in_pairID, pvk_in_attributes0, pvk_in_filterData0, pvk_in_a0, pvk_in_s0, pvk_in_attributes1, pvk_in_filterData1, pvk_in_a1, pvk_in_s1, pvk_in_pairFlags);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       pairLost                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxFilterData
    Unresolved parameter type physx::PxFilterData
    // NATIVE SIG: void			pairLost(	PxU32 pairID,
    		PxFilterObjectAttributes attributes0,
    		PxFilterData filterData0,
    		PxFilterObjectAttributes attributes1,
    		PxFilterData filterData1,
    		bool objectRemoved) = 0
    #if NATIVE
    ES void W_pairLost(physx::PxSimulationFilterCallback* self, physx::PxU32 pairID, physx::PxFilterObjectAttributes attributes0,  filterData0, physx::PxFilterObjectAttributes attributes1,  filterData1, bool objectRemoved){
        auto nat_in_pairID = (pairID);
        auto nat_in_attributes0 = (attributes0);
        auto nat_in_filterData0 = (filterData0);
        auto nat_in_attributes1 = (attributes1);
        auto nat_in_filterData1 = (filterData1);
        auto nat_in_objectRemoved = (objectRemoved);
        self->pairLost(nat_in_pairID, nat_in_attributes0, nat_in_filterData0, nat_in_attributes1, nat_in_filterData1, nat_in_objectRemoved);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_pairLost(PxSimulationFilterCallbackPtr selfPtr, uint pairID, uint attributes0,  filterData0, uint attributes1,  filterData1, bool objectRemoved);
    
    public  void pairLost(uint pairID, uint attributes0,  filterData0, uint attributes1,  filterData1, bool objectRemoved){
        uint pvk_in_pairID = (pairID);
        uint pvk_in_attributes0 = (attributes0);
         pvk_in_filterData0 = (filterData0);
        uint pvk_in_attributes1 = (attributes1);
         pvk_in_filterData1 = (filterData1);
        bool pvk_in_objectRemoved = (objectRemoved);
        W_pairLost(this, pvk_in_pairID, pvk_in_attributes0, pvk_in_filterData0, pvk_in_attributes1, pvk_in_filterData1, pvk_in_objectRemoved);
    }
    #endif*/
    
    
    //================================================================================
    //#       statusChange                                                           #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    fsdfasdf
    // NATIVE SIG: bool			statusChange(PxU32& pairID, PxPairFlags& pairFlags, PxFilterFlags& filterFlags) = 0
    #if NATIVE
    ES bool W_statusChange(physx::PxSimulationFilterCallback* self, physx::PxU32& pairID,  pairFlags,  filterFlags){
        auto nat_in_pairID = (pairID);
        auto nat_in_pairFlags = (pairFlags);
        auto nat_in_filterFlags = (filterFlags);
        auto retVal = self->statusChange(nat_in_pairID, nat_in_pairFlags, nat_in_filterFlags);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_statusChange(PxSimulationFilterCallbackPtr selfPtr, uint* pairID,  pairFlags,  filterFlags);
    
    public  bool statusChange(uint* pairID,  pairFlags,  filterFlags){
        uint* pvk_in_pairID = (pairID);
         pvk_in_pairFlags = (pairFlags);
         pvk_in_filterFlags = (filterFlags);
        bool retVal = W_statusChange(this, pvk_in_pairID, pvk_in_pairFlags, pvk_in_filterFlags);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxSimulationFilterCallback                                            #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxSimulationFilterCallback() {}
    #if NATIVE
    ES void W_~PxSimulationFilterCallback(physx::PxSimulationFilterCallback* self){
        self->~PxSimulationFilterCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxSimulationFilterCallback(PxSimulationFilterCallbackPtr selfPtr);
    
    public  void ~PxSimulationFilterCallback(){
        W_~PxSimulationFilterCallback(this);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSimulationFilterCallback
    
    //Skipped generated implicit entry: PxSimulationFilterCallback
    

#if !NATIVE
}
#endif

// Class physx::PxPairFilteringMode is enum namespace
// Class physx::PxFilterObjectType is enum namespace
// Class physx::PxFilterObjectFlag is enum namespace