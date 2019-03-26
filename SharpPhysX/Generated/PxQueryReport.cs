#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxHitFlag : int {
    ePOSITION = 1,                   // ePOSITION = (1<<0)
    eNORMAL = 2,                     // eNORMAL = (1<<1)
    eUV = 8,                         // eUV = (1<<3)
    eASSUME_NO_INITIAL_OVERLAP = 16, // eASSUME_NO_INITIAL_OVERLAP = (1<<4)
    eMESH_MULTIPLE = 32,             // eMESH_MULTIPLE = (1<<5)
    eMESH_ANY = 64,                  // eMESH_ANY = (1<<6)
    eMESH_BOTH_SIDES = 128,          // eMESH_BOTH_SIDES = (1<<7)
    ePRECISE_SWEEP = 256,            // ePRECISE_SWEEP = (1<<8)
    eMTD = 512,                      // eMTD = (1<<9)
    eFACE_INDEX = 1024,              // eFACE_INDEX = (1<<10)
    eDEFAULT = 1027,                 // eDEFAULT = ePOSITION|eNORMAL|eFACE_INDEX
    eMODIFIABLE_FLAGS = 432,         // eMODIFIABLE_FLAGS = eMESH_MULTIPLE|eMESH_BOTH_SIDES|eASSUME_NO_INITIAL_OVERLAP|ePRECISE_SWEEP
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxQueryReport {
#endif

//================================================================================
//#       operator|(PxHitFlag a, PxHitFlag b)                                    #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short> -> PxFlags_PxHitFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag_P_PxHitFlag(physx::PxHitFlag::Enum a, physx::PxHitFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag_P_PxHitFlag(PxHitFlag a, PxHitFlag b);

public static UNPARSED_TYPE operator|(PxHitFlag a, PxHitFlag b){
    PxHitFlag pvk_in_a = (a);
    PxHitFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag_P_PxHitFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxHitFlag a, PxHitFlag b)                                    #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short> -> PxFlags_PxHitFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag_P_PxHitFlag(physx::PxHitFlag::Enum a, physx::PxHitFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag_P_PxHitFlag(PxHitFlag a, PxHitFlag b);

public static UNPARSED_TYPE operator&(PxHitFlag a, PxHitFlag b){
    PxHitFlag pvk_in_a = (a);
    PxHitFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag_P_PxHitFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxHitFlag a)                                                 #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short> -> PxFlags_PxHitFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag(physx::PxHitFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag(PxHitFlag a);

public static UNPARSED_TYPE operator~(PxHitFlag a){
    PxHitFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxHitFlag_ushort_P_PxHitFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxQueryReport
#endif


#if !NATIVE //interface
public unsafe interface IPxHitCallbackPtr {
    // static PxHitCallbackPtr New( aTouches, uint aMaxNbTouches);
    // bool processTouches( buffer, uint nbHits);
     void finalizeQuery();
    // void ~PxHitCallback<HitType>();
     bool hasAnyHits();
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxHitCallbackPtr : IPxHitCallbackPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxHitCallbackPtrPOD{
    HitType block;
    bool hasBlock;
    HitType* touches;
    physx::PxU32 maxNbTouches;
    physx::PxU32 nbTouches;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type HitType
    */

    // ### HASBLOCK getter/setter
    #if NATIVE //getter
    ES bool PxHitCallback_GET_hasBlock(PxHitCallback* self) {return self->hasBlock;}
    ES void PxHitCallback_SET_hasBlock(PxHitCallback* self, bool value) {self->hasBlock = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool PxHitCallback_GET_hasBlock(PxHitCallbackPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxHitCallback_SET_hasBlock(PxHitCallbackPtr selfPtr, bool value);

    public bool hasBlock {
        get => PxHitCallback_GET_hasBlock(this);
        set => PxHitCallback_SET_hasBlock(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Unresolved parameter pointee HitType
    */

    // ### MAXNBTOUCHES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxHitCallback_GET_maxNbTouches(PxHitCallback* self) {return self->maxNbTouches;}
    ES void PxHitCallback_SET_maxNbTouches(PxHitCallback* self, physx::PxU32 value) {self->maxNbTouches = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxHitCallback_GET_maxNbTouches(PxHitCallbackPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxHitCallback_SET_maxNbTouches(PxHitCallbackPtr selfPtr, uint value);

    public uint maxNbTouches {
        get => PxHitCallback_GET_maxNbTouches(this);
        set => PxHitCallback_SET_maxNbTouches(this, value);
    }
    #endif //getter

    // ### NBTOUCHES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxHitCallback_GET_nbTouches(PxHitCallback* self) {return self->nbTouches;}
    ES void PxHitCallback_SET_nbTouches(PxHitCallback* self, physx::PxU32 value) {self->nbTouches = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxHitCallback_GET_nbTouches(PxHitCallbackPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxHitCallback_SET_nbTouches(PxHitCallbackPtr selfPtr, uint value);

    public uint nbTouches {
        get => PxHitCallback_GET_nbTouches(this);
        set => PxHitCallback_SET_nbTouches(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxHitCallbackPtr
    #endif //hierarchy
    //================================================================================
    //#       PxHitCallback<HitType>(HitType aTouches, uint aMaxNbTouches)           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitCallback(HitType* aTouches, PxU32 aMaxNbTouches)
    #if NATIVE //function start
    ES PxHitCallbackPtrPOD W_PxHitCallback<HitType>_R_PxHitCallbackPtr_P__P_uint_C_PxHitCallback_ctor( aTouches, physx::PxU32 aMaxNbTouches){
        auto nat_in_aTouches = (aTouches);
        auto nat_in_aMaxNbTouches = (aMaxNbTouches);
        auto val = new PxHitCallback<HitType>();
        return *(PxHitCallbackPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHitCallbackPtr W_PxHitCallback<HitType>_R_PxHitCallbackPtr_P__P_uint_C_PxHitCallback_ctor( aTouches, uint aMaxNbTouches);
    
    public  static PxHitCallbackPtr New( aTouches, uint aMaxNbTouches){
         pvk_in_aTouches = (aTouches);
        uint pvk_in_aMaxNbTouches = (aMaxNbTouches);
        var _new = W_PxHitCallback<HitType>_R_PxHitCallbackPtr_P__P_uint_C_PxHitCallback_ctor(pvk_in_aTouches, pvk_in_aMaxNbTouches);
        PxHitCallbackPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       processTouches(HitType buffer, uint nbHits)                            #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee HitType
    // NATIVE SIG: PxAgain processTouches(const HitType* buffer, PxU32 nbHits) = 0
    #if NATIVE //function start
    ES physx::PxAgain W_processTouches_R_bool_P__P_uint_C_PxHitCallback(physx::PxHitCallback* self,  buffer, physx::PxU32 nbHits){
        auto nat_in_buffer = (buffer);
        auto nat_in_nbHits = (nbHits);
        auto retVal = self->processTouches(nat_in_buffer, nat_in_nbHits);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_processTouches_R_bool_P__P_uint_C_PxHitCallback(PxHitCallbackPtr selfPtr,  buffer, uint nbHits);
    
    public  bool processTouches( buffer, uint nbHits){
         pvk_in_buffer = (buffer);
        uint pvk_in_nbHits = (nbHits);
        bool retVal = W_processTouches_R_bool_P__P_uint_C_PxHitCallback(this, pvk_in_buffer, pvk_in_nbHits);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       finalizeQuery()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES void W_finalizeQuery_R_void_C_PxHitCallback(physx::PxHitCallback* self){
        self->finalizeQuery();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_finalizeQuery_R_void_C_PxHitCallback(PxHitCallbackPtr selfPtr);
    
    public  void finalizeQuery(){
        W_finalizeQuery_R_void_C_PxHitCallback(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       ~PxHitCallback<HitType>()                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxHitCallback()
    #if NATIVE //function start
    ES void W_~PxHitCallback<HitType>_R_void_C_PxHitCallback(physx::PxHitCallback* self){
        self->~PxHitCallback<HitType>();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxHitCallback<HitType>_R_void_C_PxHitCallback(PxHitCallbackPtr selfPtr);
    
    public  void ~PxHitCallback<HitType>(){
        W_~PxHitCallback<HitType>_R_void_C_PxHitCallback(this);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       hasAnyHits()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_hasAnyHits_R_bool_C_PxHitCallback(physx::PxHitCallback* self){
        auto retVal = self->hasAnyHits();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_hasAnyHits_R_bool_C_PxHitCallback(PxHitCallbackPtr selfPtr);
    
    public  bool hasAnyHits(){
        bool retVal = W_hasAnyHits_R_bool_C_PxHitCallback(this);
        return retVal;
    }
    #endif //function end
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxRaycastHitPtr {
    // static PxRaycastHitPtr New();
    //static UNPARSED_TYPE operator=(PxRaycastHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxRaycastHitPtr lhs, /*NULLPARS*/);
    // static PxRaycastHitPtr New(/*NULLPARS*/);
    // static PxRaycastHitPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxRaycastHit(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxRaycastHitPtr : IPxQueryHitPtr, IPxLocationHitPtr, IPxRaycastHitPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxRaycastHitPtrPOD{
    physx::PxReal u;
    physx::PxReal v;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### U getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxRaycastHit_GET_u(PxRaycastHit* self) {return self->u;}
    ES void PxRaycastHit_SET_u(PxRaycastHit* self, physx::PxReal value) {self->u = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxRaycastHit_GET_u(PxRaycastHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxRaycastHit_SET_u(PxRaycastHitPtr selfPtr, float value);

    public float u {
        get => PxRaycastHit_GET_u(this);
        set => PxRaycastHit_SET_u(this, value);
    }
    #endif //getter

    // ### V getter/setter
    #if NATIVE //getter
    ES physx::PxReal PxRaycastHit_GET_v(PxRaycastHit* self) {return self->v;}
    ES void PxRaycastHit_SET_v(PxRaycastHit* self, physx::PxReal value) {self->v = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxRaycastHit_GET_v(PxRaycastHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxRaycastHit_SET_v(PxRaycastHitPtr selfPtr, float value);

    public float v {
        get => PxRaycastHit_GET_v(this);
        set => PxRaycastHit_SET_v(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxQueryHitPtr, PxLocationHitPtr, PxRaycastHitPtr
    public static implicit operator PxQueryHitPtr(PxRaycastHitPtr obj){return *(PxQueryHitPtr*)&obj;}
    public static explicit operator PxRaycastHitPtr(PxQueryHitPtr obj){return *(PxRaycastHitPtr*)&obj;}
    public static implicit operator PxLocationHitPtr(PxRaycastHitPtr obj){return *(PxLocationHitPtr*)&obj;}
    public static explicit operator PxRaycastHitPtr(PxLocationHitPtr obj){return *(PxRaycastHitPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxLocationHitPtr
    public  static PxLocationHitPtr New(){((PxLocationHitPtr)this).PxLocationHit();}
    public  bool hadInitialOverlap(){return ((PxLocationHitPtr)this).hadInitialOverlap();}
    //public  static PxLocationHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public  static PxLocationHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxLocationHit(/*NULLARGS*/);}
    
    // --- PxQueryHitPtr
    public  static PxQueryHitPtr New(){((PxLocationHitPtr)this).PxQueryHit();}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxRaycastHit()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES PxRaycastHitPtrPOD W_PxRaycastHit_R_PxRaycastHitPtr_C_PxRaycastHit_ctor(){
        auto val = new PxRaycastHit();
        return *(PxRaycastHitPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRaycastHitPtr W_PxRaycastHit_R_PxRaycastHitPtr_C_PxRaycastHit_ctor();
    
    public  static PxRaycastHitPtr New(){
        var _new = W_PxRaycastHit_R_PxRaycastHitPtr_C_PxRaycastHit_ctor();
        PxRaycastHitPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxRaycastHit
    
    //Skipped generated implicit entry: PxRaycastHit
    
    //Skipped generated implicit entry: ~PxRaycastHit
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxLocationHitPtr {
    // static PxLocationHitPtr New();
     bool hadInitialOverlap();
    // static PxLocationHitPtr New(/*NULLPARS*/);
    // static PxLocationHitPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxLocationHit(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxLocationHitPtr : IPxActorShapePtr, IPxQueryHitPtr, IPxLocationHitPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxLocationHitPtrPOD{
    physx::PxHitFlags flags;
    physx::PxVec3 position;
    physx::PxVec3 normal;
    physx::PxF32 distance;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxHitFlags
    */

    // ### POSITION getter/setter
    #if NATIVE //getter
    ES physx::PxVec3 PxLocationHit_GET_position(PxLocationHit* self) {return self->position;}
    ES void PxLocationHit_SET_position(PxLocationHit* self, physx::PxVec3 value) {self->position = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 PxLocationHit_GET_position(PxLocationHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxLocationHit_SET_position(PxLocationHitPtr selfPtr, PxVec3 value);

    public PxVec3 position {
        get => PxLocationHit_GET_position(this);
        set => PxLocationHit_SET_position(this, value);
    }
    #endif //getter

    // ### NORMAL getter/setter
    #if NATIVE //getter
    ES physx::PxVec3 PxLocationHit_GET_normal(PxLocationHit* self) {return self->normal;}
    ES void PxLocationHit_SET_normal(PxLocationHit* self, physx::PxVec3 value) {self->normal = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 PxLocationHit_GET_normal(PxLocationHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxLocationHit_SET_normal(PxLocationHitPtr selfPtr, PxVec3 value);

    public PxVec3 normal {
        get => PxLocationHit_GET_normal(this);
        set => PxLocationHit_SET_normal(this, value);
    }
    #endif //getter

    // ### DISTANCE getter/setter
    #if NATIVE //getter
    ES physx::PxF32 PxLocationHit_GET_distance(PxLocationHit* self) {return self->distance;}
    ES void PxLocationHit_SET_distance(PxLocationHit* self, physx::PxF32 value) {self->distance = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxLocationHit_GET_distance(PxLocationHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxLocationHit_SET_distance(PxLocationHitPtr selfPtr, float value);

    public float distance {
        get => PxLocationHit_GET_distance(this);
        set => PxLocationHit_SET_distance(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxActorShapePtr, PxQueryHitPtr, PxLocationHitPtr
    public static implicit operator PxActorShapePtr(PxLocationHitPtr obj){return *(PxActorShapePtr*)&obj;}
    public static explicit operator PxLocationHitPtr(PxActorShapePtr obj){return *(PxLocationHitPtr*)&obj;}
    public static implicit operator PxQueryHitPtr(PxLocationHitPtr obj){return *(PxQueryHitPtr*)&obj;}
    public static explicit operator PxLocationHitPtr(PxQueryHitPtr obj){return *(PxLocationHitPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxQueryHitPtr
    public  static PxQueryHitPtr New(){((PxQueryHitPtr)this).PxQueryHit();}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxActorShapePtr
    public  static PxActorShapePtr New(){((PxQueryHitPtr)this).PxActorShape();}
    public  static PxActorShapePtr New(PxRigidActorPtr a, PxShapePtr s){((PxQueryHitPtr)this).PxActorShape(a, s);}
    //public  static PxActorShapePtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
    //public  static PxActorShapePtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActorShape(/*NULLPARS*/){((PxQueryHitPtr)this).~PxActorShape(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxLocationHit()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxLocationHitPtrPOD W_PxLocationHit_R_PxLocationHitPtr_C_PxLocationHit_ctor(){
        auto val = new PxLocationHit();
        return *(PxLocationHitPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxLocationHitPtr W_PxLocationHit_R_PxLocationHitPtr_C_PxLocationHit_ctor();
    
    public  static PxLocationHitPtr New(){
        var _new = W_PxLocationHit_R_PxLocationHitPtr_C_PxLocationHit_ctor();
        PxLocationHitPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       hadInitialOverlap()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES bool W_hadInitialOverlap_R_bool_C_PxLocationHit(physx::PxLocationHit* self){
        auto retVal = self->hadInitialOverlap();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_hadInitialOverlap_R_bool_C_PxLocationHit(PxLocationHitPtr selfPtr);
    
    public  bool hadInitialOverlap(){
        bool retVal = W_hadInitialOverlap_R_bool_C_PxLocationHit(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxLocationHit
    
    //Skipped generated implicit entry: PxLocationHit
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxLocationHit
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxQueryHitPtr {
    // static PxQueryHitPtr New();
    // static PxQueryHitPtr New(/*NULLPARS*/);
    // static PxQueryHitPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxQueryHitPtr : IPxActorShapePtr, IPxQueryHitPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxQueryHitPtrPOD{
    physx::PxU32 faceIndex;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### FACEINDEX getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxQueryHit_GET_faceIndex(PxQueryHit* self) {return self->faceIndex;}
    ES void PxQueryHit_SET_faceIndex(PxQueryHit* self, physx::PxU32 value) {self->faceIndex = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxQueryHit_GET_faceIndex(PxQueryHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxQueryHit_SET_faceIndex(PxQueryHitPtr selfPtr, uint value);

    public uint faceIndex {
        get => PxQueryHit_GET_faceIndex(this);
        set => PxQueryHit_SET_faceIndex(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxActorShapePtr, PxQueryHitPtr
    public static implicit operator PxActorShapePtr(PxQueryHitPtr obj){return *(PxActorShapePtr*)&obj;}
    public static explicit operator PxQueryHitPtr(PxActorShapePtr obj){return *(PxQueryHitPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxActorShapePtr
    public  static PxActorShapePtr New(){((PxActorShapePtr)this).PxActorShape();}
    public  static PxActorShapePtr New(PxRigidActorPtr a, PxShapePtr s){((PxActorShapePtr)this).PxActorShape(a, s);}
    //public  static PxActorShapePtr New(/*NULLPARS*/){((PxActorShapePtr)this).PxActorShape(/*NULLARGS*/);}
    //public  static PxActorShapePtr New(/*NULLPARS*/){((PxActorShapePtr)this).PxActorShape(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActorShape(/*NULLPARS*/){((PxActorShapePtr)this).~PxActorShape(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxActorShapePtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxActorShapePtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxQueryHit()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES PxQueryHitPtrPOD W_PxQueryHit_R_PxQueryHitPtr_C_PxQueryHit_ctor(){
        auto val = new PxQueryHit();
        return *(PxQueryHitPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryHitPtr W_PxQueryHit_R_PxQueryHitPtr_C_PxQueryHit_ctor();
    
    public  static PxQueryHitPtr New(){
        var _new = W_PxQueryHit_R_PxQueryHitPtr_C_PxQueryHit_ctor();
        PxQueryHitPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxQueryHit
    
    //Skipped generated implicit entry: PxQueryHit
    
    //Skipped generated implicit entry: ~PxQueryHit
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxActorShapePtr {
    // static PxActorShapePtr New();
    // static PxActorShapePtr New(PxRigidActorPtr a, PxShapePtr s);
    // static PxActorShapePtr New(/*NULLPARS*/);
    // static PxActorShapePtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxActorShape(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxActorShapePtr : IPxActorShapePtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxActorShapePtrPOD{
    physx::PxRigidActor* actor;
    physx::PxShape* shape;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### ACTOR getter/setter
    #if NATIVE //getter
    ES physx::PxRigidActor* PxActorShape_GET_actor(PxActorShape* self) {return self->actor;}
    ES void PxActorShape_SET_actor(PxActorShape* self, physx::PxRigidActor* value) {self->actor = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidActorPtr PxActorShape_GET_actor(PxActorShapePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxActorShape_SET_actor(PxActorShapePtr selfPtr, PxRigidActorPtr value);

    public PxRigidActorPtr actor {
        get => PxActorShape_GET_actor(this);
        set => PxActorShape_SET_actor(this, value);
    }
    #endif //getter

    // ### SHAPE getter/setter
    #if NATIVE //getter
    ES physx::PxShape* PxActorShape_GET_shape(PxActorShape* self) {return self->shape;}
    ES void PxActorShape_SET_shape(PxActorShape* self, physx::PxShape* value) {self->shape = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr PxActorShape_GET_shape(PxActorShapePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxActorShape_SET_shape(PxActorShapePtr selfPtr, PxShapePtr value);

    public PxShapePtr shape {
        get => PxActorShape_GET_shape(this);
        set => PxActorShape_SET_shape(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxActorShapePtr
    #endif //hierarchy
    //================================================================================
    //#       PxActorShape()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES PxActorShapePtrPOD W_PxActorShape_R_PxActorShapePtr_C_PxActorShape_ctor(){
        auto val = new PxActorShape();
        return *(PxActorShapePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxActorShapePtr W_PxActorShape_R_PxActorShapePtr_C_PxActorShape_ctor();
    
    public  static PxActorShapePtr New(){
        var _new = W_PxActorShape_R_PxActorShapePtr_C_PxActorShape_ctor();
        PxActorShapePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxActorShape(PxRigidActorPtr a, PxShapePtr s)                          #
    //================================================================================
    #if NATIVE //function start
    ES PxActorShapePtrPOD W_PxActorShape_R_PxActorShapePtr_P_PxRigidActorPtr_P_PxShapePtr_C_PxActorShape_ctor(physx::PxRigidActor* a, physx::PxShape* s){
        auto nat_in_a = (a);
        auto nat_in_s = (s);
        auto val = new PxActorShape();
        return *(PxActorShapePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxActorShapePtr W_PxActorShape_R_PxActorShapePtr_P_PxRigidActorPtr_P_PxShapePtr_C_PxActorShape_ctor(PxRigidActorPtr a, PxShapePtr s);
    
    public  static PxActorShapePtr New(PxRigidActorPtr a, PxShapePtr s){
        PxRigidActorPtr pvk_in_a = (a);
        PxShapePtr pvk_in_s = (s);
        var _new = W_PxActorShape_R_PxActorShapePtr_P_PxRigidActorPtr_P_PxShapePtr_C_PxActorShape_ctor(pvk_in_a, pvk_in_s);
        PxActorShapePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxActorShape
    
    //Skipped generated implicit entry: PxActorShape
    
    //Skipped generated implicit entry: ~PxActorShape
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxHitFlag is enum namespace
#if !NATIVE //interface
public unsafe interface IPxSweepHitPtr {
    // static PxSweepHitPtr New();
    //static UNPARSED_TYPE operator=(PxSweepHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSweepHitPtr lhs, /*NULLPARS*/);
    // static PxSweepHitPtr New(/*NULLPARS*/);
    // static PxSweepHitPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxSweepHit(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSweepHitPtr : IPxQueryHitPtr, IPxLocationHitPtr, IPxSweepHitPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSweepHitPtrPOD{
    physx::PxU32 padTo16Bytes;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### PADTO16BYTES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxSweepHit_GET_padTo16Bytes(PxSweepHit* self) {return self->padTo16Bytes;}
    ES void PxSweepHit_SET_padTo16Bytes(PxSweepHit* self, physx::PxU32 value) {self->padTo16Bytes = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxSweepHit_GET_padTo16Bytes(PxSweepHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxSweepHit_SET_padTo16Bytes(PxSweepHitPtr selfPtr, uint value);

    public uint padTo16Bytes {
        get => PxSweepHit_GET_padTo16Bytes(this);
        set => PxSweepHit_SET_padTo16Bytes(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxQueryHitPtr, PxLocationHitPtr, PxSweepHitPtr
    public static implicit operator PxQueryHitPtr(PxSweepHitPtr obj){return *(PxQueryHitPtr*)&obj;}
    public static explicit operator PxSweepHitPtr(PxQueryHitPtr obj){return *(PxSweepHitPtr*)&obj;}
    public static implicit operator PxLocationHitPtr(PxSweepHitPtr obj){return *(PxLocationHitPtr*)&obj;}
    public static explicit operator PxSweepHitPtr(PxLocationHitPtr obj){return *(PxSweepHitPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxLocationHitPtr
    public  static PxLocationHitPtr New(){((PxLocationHitPtr)this).PxLocationHit();}
    public  bool hadInitialOverlap(){return ((PxLocationHitPtr)this).hadInitialOverlap();}
    //public  static PxLocationHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public  static PxLocationHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxLocationHit(/*NULLARGS*/);}
    
    // --- PxQueryHitPtr
    public  static PxQueryHitPtr New(){((PxLocationHitPtr)this).PxQueryHit();}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxSweepHit()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES PxSweepHitPtrPOD W_PxSweepHit_R_PxSweepHitPtr_C_PxSweepHit_ctor(){
        auto val = new PxSweepHit();
        return *(PxSweepHitPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSweepHitPtr W_PxSweepHit_R_PxSweepHitPtr_C_PxSweepHit_ctor();
    
    public  static PxSweepHitPtr New(){
        var _new = W_PxSweepHit_R_PxSweepHitPtr_C_PxSweepHit_ctor();
        PxSweepHitPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSweepHit
    
    //Skipped generated implicit entry: PxSweepHit
    
    //Skipped generated implicit entry: ~PxSweepHit
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxOverlapHitPtr {
    //static UNPARSED_TYPE operator=(PxOverlapHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxOverlapHitPtr lhs, /*NULLPARS*/);
    // static PxOverlapHitPtr New(/*NULLPARS*/);
    // static PxOverlapHitPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxOverlapHit(/*NULLPARS*/);
    // static PxOverlapHitPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxOverlapHitPtr : IPxActorShapePtr, IPxQueryHitPtr, IPxOverlapHitPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxOverlapHitPtrPOD{
    physx::PxU32 padTo16Bytes;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### PADTO16BYTES getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxOverlapHit_GET_padTo16Bytes(PxOverlapHit* self) {return self->padTo16Bytes;}
    ES void PxOverlapHit_SET_padTo16Bytes(PxOverlapHit* self, physx::PxU32 value) {self->padTo16Bytes = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxOverlapHit_GET_padTo16Bytes(PxOverlapHitPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxOverlapHit_SET_padTo16Bytes(PxOverlapHitPtr selfPtr, uint value);

    public uint padTo16Bytes {
        get => PxOverlapHit_GET_padTo16Bytes(this);
        set => PxOverlapHit_SET_padTo16Bytes(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxActorShapePtr, PxQueryHitPtr, PxOverlapHitPtr
    public static implicit operator PxActorShapePtr(PxOverlapHitPtr obj){return *(PxActorShapePtr*)&obj;}
    public static explicit operator PxOverlapHitPtr(PxActorShapePtr obj){return *(PxOverlapHitPtr*)&obj;}
    public static implicit operator PxQueryHitPtr(PxOverlapHitPtr obj){return *(PxQueryHitPtr*)&obj;}
    public static explicit operator PxOverlapHitPtr(PxQueryHitPtr obj){return *(PxOverlapHitPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxQueryHitPtr
    public  static PxQueryHitPtr New(){((PxQueryHitPtr)this).PxQueryHit();}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  static PxQueryHitPtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxActorShapePtr
    public  static PxActorShapePtr New(){((PxQueryHitPtr)this).PxActorShape();}
    public  static PxActorShapePtr New(PxRigidActorPtr a, PxShapePtr s){((PxQueryHitPtr)this).PxActorShape(a, s);}
    //public  static PxActorShapePtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
    //public  static PxActorShapePtr New(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActorShape(/*NULLPARS*/){((PxQueryHitPtr)this).~PxActorShape(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxOverlapHit
    
    //Skipped generated implicit entry: PxOverlapHit
    
    //Skipped generated implicit entry: ~PxOverlapHit
    
    //Skipped generated implicit entry: PxOverlapHit
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxHitBufferPtr {
    // static PxHitBufferPtr New( aTouches);
    // static PxHitBufferPtr New();
    // static PxHitBufferPtr New( aTouches, uint aMaxNbTouches);
     uint getNbAnyHits();
    // UNPARSED_TYPE getAnyHit(uint index);
     uint getNbTouches();
    // UNPARSED_TYPE getTouches();
    // UNPARSED_TYPE getTouch(uint index);
     uint getMaxNbTouches();
    // void ~PxHitBuffer<HitType>();
    // UNPARSED_TYPE processTouches(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxHitBufferPtr : IPxHitCallbackPtr, IPxHitBufferPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxHitBufferPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxHitCallbackPtr, PxHitBufferPtr
    public static implicit operator PxHitCallbackPtr(PxHitBufferPtr obj){return *(PxHitCallbackPtr*)&obj;}
    public static explicit operator PxHitBufferPtr(PxHitCallbackPtr obj){return *(PxHitBufferPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxHitCallbackPtr
    //public  static PxHitCallbackPtr New( aTouches, uint aMaxNbTouches){((PxHitCallbackPtr)this).PxHitCallback<HitType>(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitCallbackPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitCallbackPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback<HitType>(){((PxHitCallbackPtr)this).~PxHitCallback<HitType>();}
    public  bool hasAnyHits(){return ((PxHitCallbackPtr)this).hasAnyHits();}
    
    #endif //piping
    
    //================================================================================
    //#       PxHitBuffer<HitType>(HitType aTouches, uint aMaxNbTouches)             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitBuffer(HitType* aTouches = NULL, PxU32 aMaxNbTouches = 0)
    #if NATIVE //function start
    ES PxHitBufferPtrPOD W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__P_uint_C_PxHitBuffer_ctor( aTouches, physx::PxU32 aMaxNbTouches){
        auto nat_in_aTouches = (aTouches);
        auto nat_in_aMaxNbTouches = (aMaxNbTouches);
        auto val = new PxHitBuffer<HitType>();
        return *(PxHitBufferPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHitBufferPtr W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__P_uint_C_PxHitBuffer_ctor( aTouches, uint aMaxNbTouches);
    
    public  static PxHitBufferPtr New( aTouches, uint aMaxNbTouches){
         pvk_in_aTouches = (aTouches);
        uint pvk_in_aMaxNbTouches = (aMaxNbTouches);
        var _new = W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__P_uint_C_PxHitBuffer_ctor(pvk_in_aTouches, pvk_in_aMaxNbTouches);
        PxHitBufferPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitBuffer(HitType* aTouches = NULL, PxU32 aMaxNbTouches = 0)
    #if NATIVE //function start
    ES PxHitBufferPtrPOD W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__OL1_C_PxHitBuffer_ctor( aTouches){
        auto nat_in_aTouches = (aTouches);
        auto val = new PxHitBuffer<HitType>();
        return *(PxHitBufferPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHitBufferPtr W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__OL1_C_PxHitBuffer_ctor( aTouches);
    
    public  static PxHitBufferPtr New( aTouches){
         pvk_in_aTouches = (aTouches);
        var _new = W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__OL1_C_PxHitBuffer_ctor(pvk_in_aTouches);
        PxHitBufferPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES PxHitBufferPtrPOD W_PxHitBuffer<HitType>_R_PxHitBufferPtr_OL2_C_PxHitBuffer_ctor(){
        auto val = new PxHitBuffer<HitType>();
        return *(PxHitBufferPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHitBufferPtr W_PxHitBuffer<HitType>_R_PxHitBufferPtr_OL2_C_PxHitBuffer_ctor();
    
    public  static PxHitBufferPtr New(){
        var _new = W_PxHitBuffer<HitType>_R_PxHitBufferPtr_OL2_C_PxHitBuffer_ctor();
        PxHitBufferPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    
    
    //================================================================================
    //#       getNbAnyHits()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbAnyHits_R_uint_C_PxHitBuffer(physx::PxHitBuffer* self){
        auto retVal = self->getNbAnyHits();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbAnyHits_R_uint_C_PxHitBuffer(PxHitBufferPtr selfPtr);
    
    public  uint getNbAnyHits(){
        uint retVal = W_getNbAnyHits_R_uint_C_PxHitBuffer(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getAnyHit(uint index)                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: HitType
    // NATIVE SIG: HitType&	getAnyHit(const PxU32 index) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getAnyHit_R_HitType_P_uint_C_PxHitBuffer(physx::PxHitBuffer* self, physx::PxU32 index){
        auto nat_in_index = (index);
        auto retVal = self->getAnyHit(nat_in_index);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getAnyHit_R_HitType_P_uint_C_PxHitBuffer(PxHitBufferPtr selfPtr, uint index);
    
    public  UNPARSED_TYPE getAnyHit(uint index){
        uint pvk_in_index = (index);
        UNPARSED_TYPE retVal = W_getAnyHit_R_HitType_P_uint_C_PxHitBuffer(this, pvk_in_index);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbTouches()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbTouches_R_uint_C_PxHitBuffer(physx::PxHitBuffer* self){
        auto retVal = self->getNbTouches();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbTouches_R_uint_C_PxHitBuffer(PxHitBufferPtr selfPtr);
    
    public  uint getNbTouches(){
        uint retVal = W_getNbTouches_R_uint_C_PxHitBuffer(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTouches()                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: HitType
    // NATIVE SIG: HitType*	getTouches() const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getTouches_R_HitType_C_PxHitBuffer(physx::PxHitBuffer* self){
        auto retVal = self->getTouches();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getTouches_R_HitType_C_PxHitBuffer(PxHitBufferPtr selfPtr);
    
    public  UNPARSED_TYPE getTouches(){
        UNPARSED_TYPE retVal = W_getTouches_R_HitType_C_PxHitBuffer(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getTouch(uint index)                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: HitType
    // NATIVE SIG: HitType&	getTouch(const PxU32 index) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getTouch_R_HitType_P_uint_C_PxHitBuffer(physx::PxHitBuffer* self, physx::PxU32 index){
        auto nat_in_index = (index);
        auto retVal = self->getTouch(nat_in_index);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getTouch_R_HitType_P_uint_C_PxHitBuffer(PxHitBufferPtr selfPtr, uint index);
    
    public  UNPARSED_TYPE getTouch(uint index){
        uint pvk_in_index = (index);
        UNPARSED_TYPE retVal = W_getTouch_R_HitType_P_uint_C_PxHitBuffer(this, pvk_in_index);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getMaxNbTouches()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getMaxNbTouches_R_uint_C_PxHitBuffer(physx::PxHitBuffer* self){
        auto retVal = self->getMaxNbTouches();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaxNbTouches_R_uint_C_PxHitBuffer(PxHitBufferPtr selfPtr);
    
    public  uint getMaxNbTouches(){
        uint retVal = W_getMaxNbTouches_R_uint_C_PxHitBuffer(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       ~PxHitBuffer<HitType>()                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxHitBuffer()
    #if NATIVE //function start
    ES void W_~PxHitBuffer<HitType>_R_void_C_PxHitBuffer(physx::PxHitBuffer* self){
        self->~PxHitBuffer<HitType>();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxHitBuffer<HitType>_R_void_C_PxHitBuffer(PxHitBufferPtr selfPtr);
    
    public  void ~PxHitBuffer<HitType>(){
        W_~PxHitBuffer<HitType>_R_void_C_PxHitBuffer(this);
    }
    #endif //function end*/
    
    
    //Skipped protected: processTouches
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxRaycastBufferNPtr {
    // static PxRaycastBufferNPtr New();
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxRaycastBufferNPtr : IPxHitCallbackPtr, IPxHitBufferPtr, IPxRaycastBufferNPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxRaycastBufferNPtrPOD{
    physx::PxRaycastHit[] hits;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxRaycastHit[]
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxHitCallbackPtr, PxHitBufferPtr, PxRaycastBufferNPtr
    public static implicit operator PxHitCallbackPtr(PxRaycastBufferNPtr obj){return *(PxHitCallbackPtr*)&obj;}
    public static explicit operator PxRaycastBufferNPtr(PxHitCallbackPtr obj){return *(PxRaycastBufferNPtr*)&obj;}
    public static implicit operator PxHitBufferPtr(PxRaycastBufferNPtr obj){return *(PxHitBufferPtr*)&obj;}
    public static explicit operator PxRaycastBufferNPtr(PxHitBufferPtr obj){return *(PxRaycastBufferNPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxHitBufferPtr
    //public  static PxHitBufferPtr New( aTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches);}
    //public  static PxHitBufferPtr New(){((PxHitBufferPtr)this).PxHitBuffer();}
    //public  static PxHitBufferPtr New( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches, aMaxNbTouches);}
    public  uint getNbAnyHits(){return ((PxHitBufferPtr)this).getNbAnyHits();}
    //public  UNPARSED_TYPE getAnyHit(uint index){return ((PxHitBufferPtr)this).getAnyHit(index);}
    public  uint getNbTouches(){return ((PxHitBufferPtr)this).getNbTouches();}
    //public  UNPARSED_TYPE getTouches(){return ((PxHitBufferPtr)this).getTouches();}
    //public  UNPARSED_TYPE getTouch(uint index){return ((PxHitBufferPtr)this).getTouch(index);}
    public  uint getMaxNbTouches(){return ((PxHitBufferPtr)this).getMaxNbTouches();}
    //public  void ~PxHitBuffer(){((PxHitBufferPtr)this).~PxHitBuffer();}
    //public  UNPARSED_TYPE processTouches(/*NULLPARS*/){return ((PxHitBufferPtr)this).processTouches(/*NULLARGS*/);}
    //public  static PxHitBufferPtr New(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitBuffer(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxHitBufferPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxHitCallbackPtr
    //public  static PxHitCallbackPtr New( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitCallback(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitBufferPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitBufferPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback(){((PxHitBufferPtr)this).~PxHitCallback();}
    public  bool hasAnyHits(){return ((PxHitBufferPtr)this).hasAnyHits();}
    //public static UNPARSED_TYPE operator=(PxHitCallbackPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    //public  static PxHitCallbackPtr New(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxRaycastBufferN<N>()                                                  #
    //================================================================================
    #if NATIVE //function start
    ES PxRaycastBufferNPtrPOD W_PxRaycastBufferN<N>_R_PxRaycastBufferNPtr_C_PxRaycastBufferN_ctor(){
        auto val = new PxRaycastBufferN<N>();
        return *(PxRaycastBufferNPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRaycastBufferNPtr W_PxRaycastBufferN<N>_R_PxRaycastBufferNPtr_C_PxRaycastBufferN_ctor();
    
    public  static PxRaycastBufferNPtr New(){
        var _new = W_PxRaycastBufferN<N>_R_PxRaycastBufferNPtr_C_PxRaycastBufferN_ctor();
        PxRaycastBufferNPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxOverlapBufferNPtr {
    // static PxOverlapBufferNPtr New();
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxOverlapBufferNPtr : IPxHitCallbackPtr, IPxHitBufferPtr, IPxOverlapBufferNPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxOverlapBufferNPtrPOD{
    physx::PxOverlapHit[] hits;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxOverlapHit[]
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxHitCallbackPtr, PxHitBufferPtr, PxOverlapBufferNPtr
    public static implicit operator PxHitCallbackPtr(PxOverlapBufferNPtr obj){return *(PxHitCallbackPtr*)&obj;}
    public static explicit operator PxOverlapBufferNPtr(PxHitCallbackPtr obj){return *(PxOverlapBufferNPtr*)&obj;}
    public static implicit operator PxHitBufferPtr(PxOverlapBufferNPtr obj){return *(PxHitBufferPtr*)&obj;}
    public static explicit operator PxOverlapBufferNPtr(PxHitBufferPtr obj){return *(PxOverlapBufferNPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxHitBufferPtr
    //public  static PxHitBufferPtr New( aTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches);}
    //public  static PxHitBufferPtr New(){((PxHitBufferPtr)this).PxHitBuffer();}
    //public  static PxHitBufferPtr New( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches, aMaxNbTouches);}
    public  uint getNbAnyHits(){return ((PxHitBufferPtr)this).getNbAnyHits();}
    //public  UNPARSED_TYPE getAnyHit(uint index){return ((PxHitBufferPtr)this).getAnyHit(index);}
    public  uint getNbTouches(){return ((PxHitBufferPtr)this).getNbTouches();}
    //public  UNPARSED_TYPE getTouches(){return ((PxHitBufferPtr)this).getTouches();}
    //public  UNPARSED_TYPE getTouch(uint index){return ((PxHitBufferPtr)this).getTouch(index);}
    public  uint getMaxNbTouches(){return ((PxHitBufferPtr)this).getMaxNbTouches();}
    //public  void ~PxHitBuffer(){((PxHitBufferPtr)this).~PxHitBuffer();}
    //public  UNPARSED_TYPE processTouches(/*NULLPARS*/){return ((PxHitBufferPtr)this).processTouches(/*NULLARGS*/);}
    //public  static PxHitBufferPtr New(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitBuffer(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxHitBufferPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxHitCallbackPtr
    //public  static PxHitCallbackPtr New( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitCallback(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitBufferPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitBufferPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback(){((PxHitBufferPtr)this).~PxHitCallback();}
    public  bool hasAnyHits(){return ((PxHitBufferPtr)this).hasAnyHits();}
    //public static UNPARSED_TYPE operator=(PxHitCallbackPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    //public  static PxHitCallbackPtr New(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxOverlapBufferN<N>()                                                  #
    //================================================================================
    #if NATIVE //function start
    ES PxOverlapBufferNPtrPOD W_PxOverlapBufferN<N>_R_PxOverlapBufferNPtr_C_PxOverlapBufferN_ctor(){
        auto val = new PxOverlapBufferN<N>();
        return *(PxOverlapBufferNPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxOverlapBufferNPtr W_PxOverlapBufferN<N>_R_PxOverlapBufferNPtr_C_PxOverlapBufferN_ctor();
    
    public  static PxOverlapBufferNPtr New(){
        var _new = W_PxOverlapBufferN<N>_R_PxOverlapBufferNPtr_C_PxOverlapBufferN_ctor();
        PxOverlapBufferNPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxSweepBufferNPtr {
    // static PxSweepBufferNPtr New();
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSweepBufferNPtr : IPxHitCallbackPtr, IPxHitBufferPtr, IPxSweepBufferNPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSweepBufferNPtrPOD{
    physx::PxSweepHit[] hits;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxSweepHit[]
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxHitCallbackPtr, PxHitBufferPtr, PxSweepBufferNPtr
    public static implicit operator PxHitCallbackPtr(PxSweepBufferNPtr obj){return *(PxHitCallbackPtr*)&obj;}
    public static explicit operator PxSweepBufferNPtr(PxHitCallbackPtr obj){return *(PxSweepBufferNPtr*)&obj;}
    public static implicit operator PxHitBufferPtr(PxSweepBufferNPtr obj){return *(PxHitBufferPtr*)&obj;}
    public static explicit operator PxSweepBufferNPtr(PxHitBufferPtr obj){return *(PxSweepBufferNPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxHitBufferPtr
    //public  static PxHitBufferPtr New( aTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches);}
    //public  static PxHitBufferPtr New(){((PxHitBufferPtr)this).PxHitBuffer();}
    //public  static PxHitBufferPtr New( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches, aMaxNbTouches);}
    public  uint getNbAnyHits(){return ((PxHitBufferPtr)this).getNbAnyHits();}
    //public  UNPARSED_TYPE getAnyHit(uint index){return ((PxHitBufferPtr)this).getAnyHit(index);}
    public  uint getNbTouches(){return ((PxHitBufferPtr)this).getNbTouches();}
    //public  UNPARSED_TYPE getTouches(){return ((PxHitBufferPtr)this).getTouches();}
    //public  UNPARSED_TYPE getTouch(uint index){return ((PxHitBufferPtr)this).getTouch(index);}
    public  uint getMaxNbTouches(){return ((PxHitBufferPtr)this).getMaxNbTouches();}
    //public  void ~PxHitBuffer(){((PxHitBufferPtr)this).~PxHitBuffer();}
    //public  UNPARSED_TYPE processTouches(/*NULLPARS*/){return ((PxHitBufferPtr)this).processTouches(/*NULLARGS*/);}
    //public  static PxHitBufferPtr New(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitBuffer(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxHitBufferPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxHitCallbackPtr
    //public  static PxHitCallbackPtr New( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitCallback(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitBufferPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitBufferPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback(){((PxHitBufferPtr)this).~PxHitCallback();}
    public  bool hasAnyHits(){return ((PxHitBufferPtr)this).hasAnyHits();}
    //public static UNPARSED_TYPE operator=(PxHitCallbackPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    //public  static PxHitCallbackPtr New(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxSweepBufferN<N>()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxSweepBufferNPtrPOD W_PxSweepBufferN<N>_R_PxSweepBufferNPtr_C_PxSweepBufferN_ctor(){
        auto val = new PxSweepBufferN<N>();
        return *(PxSweepBufferNPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSweepBufferNPtr W_PxSweepBufferN<N>_R_PxSweepBufferNPtr_C_PxSweepBufferN_ctor();
    
    public  static PxSweepBufferNPtr New(){
        var _new = W_PxSweepBufferN<N>_R_PxSweepBufferNPtr_C_PxSweepBufferN_ctor();
        PxSweepBufferNPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    

#if !NATIVE //struct close
}
#endif //struct close
