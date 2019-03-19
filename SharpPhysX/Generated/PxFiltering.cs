#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxFilterFlag : int {
    eKILL = 1,     // eKILL = (1<<0)
    eSUPPRESS = 2, // eSUPPRESS = (1<<1)
    eCALLBACK = 4, // eCALLBACK = (1<<2)
    eNOTIFY = 12,  // eNOTIFY = (1<<3) | eCALLBACK
    eDEFAULT = 0,  // eDEFAULT = 0
}
#endif //enum

#if !NATIVE //enum
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
#endif //enum

#if !NATIVE //enum
public enum PxPairFilteringMode : int {
    eKEEP = 0,     // eKEEP
    eSUPPRESS = 1, // eSUPPRESS
    eKILL = 2,     // eKILL
    eDEFAULT = 3,  // eDEFAULT
}
#endif //enum

#if !NATIVE //enum
public enum PxFilterObjectType : int {
    eRIGID_STATIC = 0,    // eRIGID_STATIC
    eRIGID_DYNAMIC = 1,   // eRIGID_DYNAMIC
    eARTICULATION = 2,    // eARTICULATION
    eMAX_TYPE_COUNT = 16, // eMAX_TYPE_COUNT = 16
    eUNDEFINED = 15,      // eUNDEFINED = eMAX_TYPE_COUNT-1
}
#endif //enum

#if !NATIVE //enum
public enum PxFilterObjectFlag : int {
    eKINEMATIC = 16, // eKINEMATIC = (1<<4)
    eTRIGGER = 32,   // eTRIGGER = (1<<5)
}
#endif //enum

#if !NATIVE
public partial struct PxFiltering {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag_P_PxPairFlag(physx::PxPairFlag::Enum a, physx::PxPairFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag_P_PxPairFlag(PxPairFlag a, PxPairFlag b);

public static UNPARSED_TYPE operator|(PxPairFlag a, PxPairFlag b){
    PxPairFlag pvk_in_a = (a);
    PxPairFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag_P_PxPairFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag_P_PxPairFlag(physx::PxPairFlag::Enum a, physx::PxPairFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag_P_PxPairFlag(PxPairFlag a, PxPairFlag b);

public static UNPARSED_TYPE operator&(PxPairFlag a, PxPairFlag b){
    PxPairFlag pvk_in_a = (a);
    PxPairFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag_P_PxPairFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag(physx::PxPairFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag(PxPairFlag a);

public static UNPARSED_TYPE operator~(PxPairFlag a){
    PxPairFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxPairFlag_ushort_P_PxPairFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag_P_PxFilterFlag(physx::PxFilterFlag::Enum a, physx::PxFilterFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag_P_PxFilterFlag(PxFilterFlag a, PxFilterFlag b);

public static UNPARSED_TYPE operator|(PxFilterFlag a, PxFilterFlag b){
    PxFilterFlag pvk_in_a = (a);
    PxFilterFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag_P_PxFilterFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag_P_PxFilterFlag(physx::PxFilterFlag::Enum a, physx::PxFilterFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag_P_PxFilterFlag(PxFilterFlag a, PxFilterFlag b);

public static UNPARSED_TYPE operator&(PxFilterFlag a, PxFilterFlag b){
    PxFilterFlag pvk_in_a = (a);
    PxFilterFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag_P_PxFilterFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag(physx::PxFilterFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag(PxFilterFlag a);

public static UNPARSED_TYPE operator~(PxFilterFlag a){
    PxFilterFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxFilterFlag_ushort_P_PxFilterFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       PxGetFilterObjectType                                                  #
//================================================================================
#if NATIVE //function start
ES physx::PxFilterObjectType::Enum W_PxGetFilterObjectType_R_PxFilterObjectType_P_uint(physx::PxFilterObjectAttributes attr){
    auto nat_in_attr = (attr);
    auto retVal = physx::PxGetFilterObjectType(nat_in_attr);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFilterObjectType W_PxGetFilterObjectType_R_PxFilterObjectType_P_uint(uint attr);

public static PxFilterObjectType PxGetFilterObjectType(uint attr){
    uint pvk_in_attr = (attr);
    PxFilterObjectType retVal = W_PxGetFilterObjectType_R_PxFilterObjectType_P_uint(pvk_in_attr);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxFilterObjectIsKinematic                                              #
//================================================================================
#if NATIVE //function start
ES bool W_PxFilterObjectIsKinematic_R_bool_P_uint(physx::PxFilterObjectAttributes attr){
    auto nat_in_attr = (attr);
    auto retVal = physx::PxFilterObjectIsKinematic(nat_in_attr);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxFilterObjectIsKinematic_R_bool_P_uint(uint attr);

public static bool PxFilterObjectIsKinematic(uint attr){
    uint pvk_in_attr = (attr);
    bool retVal = W_PxFilterObjectIsKinematic_R_bool_P_uint(pvk_in_attr);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxFilterObjectIsTrigger                                                #
//================================================================================
#if NATIVE //function start
ES bool W_PxFilterObjectIsTrigger_R_bool_P_uint(physx::PxFilterObjectAttributes attr){
    auto nat_in_attr = (attr);
    auto retVal = physx::PxFilterObjectIsTrigger(nat_in_attr);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern bool W_PxFilterObjectIsTrigger_R_bool_P_uint(uint attr);

public static bool PxFilterObjectIsTrigger(uint attr){
    uint pvk_in_attr = (attr);
    bool retVal = W_PxFilterObjectIsTrigger_R_bool_P_uint(pvk_in_attr);
    return retVal;
}
#endif //function end

#if !NATIVE
} // End PxFiltering
#endif


#if !NATIVE //interface
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
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxFilterDataPtr : IPxFilterDataPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields

    // ### WORD0 getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxFilterData_GET_word0(PxFilterData* self) {return self->word0;}
    ES void PxFilterData_SET_word0(PxFilterData* self, physx::PxU32 value) {self->word0 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxFilterData_GET_word0(PxFilterDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxFilterData_SET_word0(PxFilterDataPtr selfPtr, uint value);

    public uint word0 {
        get => PxFilterData_GET_word0(this);
        set => PxFilterData_SET_word0(this, value);
    }
    #endif //getter

    // ### WORD1 getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxFilterData_GET_word1(PxFilterData* self) {return self->word1;}
    ES void PxFilterData_SET_word1(PxFilterData* self, physx::PxU32 value) {self->word1 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxFilterData_GET_word1(PxFilterDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxFilterData_SET_word1(PxFilterDataPtr selfPtr, uint value);

    public uint word1 {
        get => PxFilterData_GET_word1(this);
        set => PxFilterData_SET_word1(this, value);
    }
    #endif //getter

    // ### WORD2 getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxFilterData_GET_word2(PxFilterData* self) {return self->word2;}
    ES void PxFilterData_SET_word2(PxFilterData* self, physx::PxU32 value) {self->word2 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxFilterData_GET_word2(PxFilterDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxFilterData_SET_word2(PxFilterDataPtr selfPtr, uint value);

    public uint word2 {
        get => PxFilterData_GET_word2(this);
        set => PxFilterData_SET_word2(this, value);
    }
    #endif //getter

    // ### WORD3 getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxFilterData_GET_word3(PxFilterData* self) {return self->word3;}
    ES void PxFilterData_SET_word3(PxFilterData* self, physx::PxU32 value) {self->word3 = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxFilterData_GET_word3(PxFilterDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxFilterData_SET_word3(PxFilterDataPtr selfPtr, uint value);

    public uint word3 {
        get => PxFilterData_GET_word3(this);
        set => PxFilterData_SET_word3(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxFilterDataPtr
    #endif //hierarchy
    //================================================================================
    //#       PxFilterData                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    Invalid parameter name (empty)
    // NATIVE SIG: PX_INLINE PxFilterData(const PxEMPTY)
    	{
    	}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxFilterData_R_PxFilterDataPtr_P_PxEMPTY_C_PxFilterData_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        return PxFilterData(nat_in_);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFilterData_R_PxFilterDataPtr_P_PxEMPTY_C_PxFilterData_ctor(PxEMPTY );
    
    public  PxFilterData(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFilterData_R_PxFilterDataPtr_P_PxEMPTY_C_PxFilterData_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
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
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxFilterData_R_PxFilterDataPtr_P_PxFilterDataPtr_C_PxFilterData_ctor(physx::PxFilterData* fd){
        auto nat_in_fd = (fd);
        return PxFilterData(*nat_in_fd);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFilterData_R_PxFilterDataPtr_P_PxFilterDataPtr_C_PxFilterData_ctor(PxFilterDataPtr fd);
    
    public  PxFilterData(PxFilterDataPtr fd){
        PxFilterDataPtr pvk_in_fd = (fd);
        var _new = W_PxFilterData_R_PxFilterDataPtr_P_PxFilterDataPtr_C_PxFilterData_ctor(pvk_in_fd);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxFilterData                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    // NATIVE SIG: PX_INLINE PxFilterData(PxU32 w0, PxU32 w1, PxU32 w2, PxU32 w3) : word0(w0), word1(w1), word2(w2), word3(w3) {}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxFilterData_R_PxFilterDataPtr_P_uint_P_uint_P_uint_P_uint_C_PxFilterData_ctor(physx::PxU32 w0, physx::PxU32 w1, physx::PxU32 w2, physx::PxU32 w3){
        auto nat_in_w0 = (w0);
        auto nat_in_w1 = (w1);
        auto nat_in_w2 = (w2);
        auto nat_in_w3 = (w3);
        return PxFilterData(nat_in_w0, nat_in_w1, nat_in_w2, nat_in_w3);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFilterData_R_PxFilterDataPtr_P_uint_P_uint_P_uint_P_uint_C_PxFilterData_ctor(uint w0, uint w1, uint w2, uint w3);
    
    public  PxFilterData(uint w0, uint w1, uint w2, uint w3){
        uint pvk_in_w0 = (w0);
        uint pvk_in_w1 = (w1);
        uint pvk_in_w2 = (w2);
        uint pvk_in_w3 = (w3);
        var _new = W_PxFilterData_R_PxFilterDataPtr_P_uint_P_uint_P_uint_P_uint_C_PxFilterData_ctor(pvk_in_w0, pvk_in_w1, pvk_in_w2, pvk_in_w3);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setToDefault                                                           #
    //================================================================================
    #if NATIVE //function start
    ES void W_setToDefault_R_void_C_PxFilterData(physx::PxFilterData* self){
        self->setToDefault();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setToDefault_R_void_C_PxFilterData(PxFilterDataPtr selfPtr);
    
    public  void setToDefault(){
        W_setToDefault_R_void_C_PxFilterData(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxFilterDataPtr_C_PxFilterData(physx::PxFilterData* self, physx::PxFilterData* a){
        auto nat_in_a = (a);
        auto retVal = self->operator==(*nat_in_a);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxFilterDataPtr_C_PxFilterData(PxFilterDataPtr selfPtr, PxFilterDataPtr a);
    
    public static bool operator==(PxFilterDataPtr lhs, PxFilterDataPtr a){
        PxFilterDataPtr pvk_in_a = (a);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxFilterDataPtr_C_PxFilterData(lhs, pvk_in_a);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_ExclaimEqual_R_bool_P_PxFilterDataPtr_C_PxFilterData(physx::PxFilterData* self, physx::PxFilterData* a){
        auto nat_in_a = (a);
        auto retVal = self->operator!=(*nat_in_a);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual_R_bool_P_PxFilterDataPtr_C_PxFilterData(PxFilterDataPtr selfPtr, PxFilterDataPtr a);
    
    public static bool operator!=(PxFilterDataPtr lhs, PxFilterDataPtr a){
        PxFilterDataPtr pvk_in_a = (a);
        bool retVal = W_OP_ExclaimEqual_R_bool_P_PxFilterDataPtr_C_PxFilterData(lhs, pvk_in_a);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: ~PxFilterData
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxFilterFlag is enum namespace
// Class physx::PxPairFlag is enum namespace
#if !NATIVE //interface
public unsafe interface IPxSimulationFilterCallbackPtr {
    // UNPARSED_TYPE pairFound(uint pairID, uint attributes0,  filterData0, PxActorPtr a0, PxShapePtr s0, uint attributes1,  filterData1, PxActorPtr a1, PxShapePtr s1,  pairFlags);
    // void pairLost(uint pairID, uint attributes0,  filterData0, uint attributes1,  filterData1, bool objectRemoved);
    // bool statusChange(uint* pairID,  pairFlags,  filterFlags);
    // UNPARSED_TYPE ~PxSimulationFilterCallback(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSimulationFilterCallbackPtr lhs, /*NULLPARS*/);
    // PxSimulationFilterCallback(/*NULLPARS*/);
    // PxSimulationFilterCallback(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxSimulationFilterCallbackPtr : IPxSimulationFilterCallbackPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxSimulationFilterCallbackPtr
    #endif //hierarchy
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
    #if NATIVE //function start
    ES UNPARSED_TYPE W_pairFound_R_Enum, ushort>_P_uint_P_uint_P__P_PxActorPtr_P_PxShapePtr_P_uint_P__P_PxActorPtr_P_PxShapePtr_P__C_PxSimulationFilterCallback(physx::PxSimulationFilterCallback* self, physx::PxU32 pairID, physx::PxFilterObjectAttributes attributes0,  filterData0, physx::PxActor* a0, physx::PxShape* s0, physx::PxFilterObjectAttributes attributes1,  filterData1, physx::PxActor* a1, physx::PxShape* s1,  pairFlags){
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
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_pairFound_R_Enum, ushort>_P_uint_P_uint_P__P_PxActorPtr_P_PxShapePtr_P_uint_P__P_PxActorPtr_P_PxShapePtr_P__C_PxSimulationFilterCallback(PxSimulationFilterCallbackPtr selfPtr, uint pairID, uint attributes0,  filterData0, PxActorPtr a0, PxShapePtr s0, uint attributes1,  filterData1, PxActorPtr a1, PxShapePtr s1,  pairFlags);
    
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
        UNPARSED_TYPE retVal = W_pairFound_R_Enum, ushort>_P_uint_P_uint_P__P_PxActorPtr_P_PxShapePtr_P_uint_P__P_PxActorPtr_P_PxShapePtr_P__C_PxSimulationFilterCallback(this, pvk_in_pairID, pvk_in_attributes0, pvk_in_filterData0, pvk_in_a0, pvk_in_s0, pvk_in_attributes1, pvk_in_filterData1, pvk_in_a1, pvk_in_s1, pvk_in_pairFlags);
        return retVal;
    }
    #endif //function end*/
    
    
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
    #if NATIVE //function start
    ES void W_pairLost_R_void_P_uint_P_uint_P__P_uint_P__P_bool_C_PxSimulationFilterCallback(physx::PxSimulationFilterCallback* self, physx::PxU32 pairID, physx::PxFilterObjectAttributes attributes0,  filterData0, physx::PxFilterObjectAttributes attributes1,  filterData1, bool objectRemoved){
        auto nat_in_pairID = (pairID);
        auto nat_in_attributes0 = (attributes0);
        auto nat_in_filterData0 = (filterData0);
        auto nat_in_attributes1 = (attributes1);
        auto nat_in_filterData1 = (filterData1);
        auto nat_in_objectRemoved = (objectRemoved);
        self->pairLost(nat_in_pairID, nat_in_attributes0, nat_in_filterData0, nat_in_attributes1, nat_in_filterData1, nat_in_objectRemoved);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_pairLost_R_void_P_uint_P_uint_P__P_uint_P__P_bool_C_PxSimulationFilterCallback(PxSimulationFilterCallbackPtr selfPtr, uint pairID, uint attributes0,  filterData0, uint attributes1,  filterData1, bool objectRemoved);
    
    public  void pairLost(uint pairID, uint attributes0,  filterData0, uint attributes1,  filterData1, bool objectRemoved){
        uint pvk_in_pairID = (pairID);
        uint pvk_in_attributes0 = (attributes0);
         pvk_in_filterData0 = (filterData0);
        uint pvk_in_attributes1 = (attributes1);
         pvk_in_filterData1 = (filterData1);
        bool pvk_in_objectRemoved = (objectRemoved);
        W_pairLost_R_void_P_uint_P_uint_P__P_uint_P__P_bool_C_PxSimulationFilterCallback(this, pvk_in_pairID, pvk_in_attributes0, pvk_in_filterData0, pvk_in_attributes1, pvk_in_filterData1, pvk_in_objectRemoved);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       statusChange                                                           #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    fsdfasdf
    // NATIVE SIG: bool			statusChange(PxU32& pairID, PxPairFlags& pairFlags, PxFilterFlags& filterFlags) = 0
    #if NATIVE //function start
    ES bool W_statusChange_R_bool_P_uintPtr_P__P__C_PxSimulationFilterCallback(physx::PxSimulationFilterCallback* self, physx::PxU32& pairID,  pairFlags,  filterFlags){
        auto nat_in_pairID = (pairID);
        auto nat_in_pairFlags = (pairFlags);
        auto nat_in_filterFlags = (filterFlags);
        auto retVal = self->statusChange(nat_in_pairID, nat_in_pairFlags, nat_in_filterFlags);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_statusChange_R_bool_P_uintPtr_P__P__C_PxSimulationFilterCallback(PxSimulationFilterCallbackPtr selfPtr, uint* pairID,  pairFlags,  filterFlags);
    
    public  bool statusChange(uint* pairID,  pairFlags,  filterFlags){
        uint* pvk_in_pairID = (pairID);
         pvk_in_pairFlags = (pairFlags);
         pvk_in_filterFlags = (filterFlags);
        bool retVal = W_statusChange_R_bool_P_uintPtr_P__P__C_PxSimulationFilterCallback(this, pvk_in_pairID, pvk_in_pairFlags, pvk_in_filterFlags);
        return retVal;
    }
    #endif //function end*/
    
    
    //Skipped protected: ~PxSimulationFilterCallback
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSimulationFilterCallback
    
    //Skipped generated implicit entry: PxSimulationFilterCallback
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxPairFilteringMode is enum namespace
// Class physx::PxFilterObjectType is enum namespace
// Class physx::PxFilterObjectFlag is enum namespace