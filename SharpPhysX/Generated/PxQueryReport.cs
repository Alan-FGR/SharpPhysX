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

#if !NATIVE
public partial struct PxQueryReport {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short>
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
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short>
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
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short>
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

#if !NATIVE
} // End PxQueryReport
#endif


#if !NATIVE //interface
public unsafe interface IPxHitCallbackPtr {
    // PxHitCallback<HitType>( aTouches, uint aMaxNbTouches);
    // bool processTouches( buffer, uint nbHits);
     void finalizeQuery();
    // void ~PxHitCallback<HitType>();
     bool hasAnyHits();
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxHitCallbackPtr : IPxHitCallbackPtr { // pointer
    private IntPtr nativePtr_;
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
    //#       PxHitCallback<HitType>                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxHitCallback
    Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitCallback(HitType* aTouches, PxU32 aMaxNbTouches)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxHitCallback<HitType>_R_PxHitCallbackPtr_P__P_uint_C_PxHitCallback_ctor( aTouches, physx::PxU32 aMaxNbTouches){
        auto nat_in_aTouches = (aTouches);
        auto nat_in_aMaxNbTouches = (aMaxNbTouches);
        return PxHitCallback<HitType>(nat_in_aTouches, nat_in_aMaxNbTouches);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHitCallback<HitType>_R_PxHitCallbackPtr_P__P_uint_C_PxHitCallback_ctor( aTouches, uint aMaxNbTouches);
    
    public  PxHitCallback<HitType>( aTouches, uint aMaxNbTouches){
         pvk_in_aTouches = (aTouches);
        uint pvk_in_aMaxNbTouches = (aMaxNbTouches);
        var _new = W_PxHitCallback<HitType>_R_PxHitCallbackPtr_P__P_uint_C_PxHitCallback_ctor(pvk_in_aTouches, pvk_in_aMaxNbTouches);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       processTouches                                                         #
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
    //#       finalizeQuery                                                          #
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
    //#       ~PxHitCallback<HitType>                                                #
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
    //#       hasAnyHits                                                             #
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
    // PxRaycastHit();
    //static UNPARSED_TYPE operator=(PxRaycastHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxRaycastHitPtr lhs, /*NULLPARS*/);
    // PxRaycastHit(/*NULLPARS*/);
    // PxRaycastHit(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxRaycastHit(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxRaycastHitPtr : IPxQueryHitPtr, IPxLocationHitPtr, IPxRaycastHitPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxLocationHit(){((PxLocationHitPtr)this).PxLocationHit();}
    public  bool hadInitialOverlap(){return ((PxLocationHitPtr)this).hadInitialOverlap();}
    //public  PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public  PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxLocationHit(/*NULLARGS*/);}
    
    // --- PxQueryHitPtr
    //public  PxQueryHit(){((PxLocationHitPtr)this).PxQueryHit();}
    //public  PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxRaycastHit                                                           #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxRaycastHit
    Parameterless constructor not allowed
    */
    
    
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
    // PxLocationHit();
     bool hadInitialOverlap();
    // PxLocationHit(/*NULLPARS*/);
    // PxLocationHit(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxLocationHit(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxLocationHitPtr : IPxActorShapePtr, IPxQueryHitPtr, IPxLocationHitPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxQueryHit(){((PxQueryHitPtr)this).PxQueryHit();}
    //public  PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxActorShapePtr
    //public  PxActorShape(){((PxQueryHitPtr)this).PxActorShape();}
    //public  PxActorShape(PxRigidActorPtr a, PxShapePtr s){((PxQueryHitPtr)this).PxActorShape(a, s);}
    //public  PxActorShape(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
    //public  PxActorShape(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActorShape(/*NULLPARS*/){((PxQueryHitPtr)this).~PxActorShape(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxLocationHit                                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxLocationHit
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       hadInitialOverlap                                                      #
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
    // PxQueryHit();
    // PxQueryHit(/*NULLPARS*/);
    // PxQueryHit(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxQueryHitPtr : IPxActorShapePtr, IPxQueryHitPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxActorShape(){((PxActorShapePtr)this).PxActorShape();}
    //public  PxActorShape(PxRigidActorPtr a, PxShapePtr s){((PxActorShapePtr)this).PxActorShape(a, s);}
    //public  PxActorShape(/*NULLPARS*/){((PxActorShapePtr)this).PxActorShape(/*NULLARGS*/);}
    //public  PxActorShape(/*NULLPARS*/){((PxActorShapePtr)this).PxActorShape(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActorShape(/*NULLPARS*/){((PxActorShapePtr)this).~PxActorShape(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxActorShapePtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/){return ((PxActorShapePtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxQueryHit                                                             #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxQueryHit
    Parameterless constructor not allowed
    */
    
    
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
    // PxActorShape();
    // PxActorShape(PxRigidActorPtr a, PxShapePtr s);
    // PxActorShape(/*NULLPARS*/);
    // PxActorShape(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxActorShape(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxActorShapePtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxActorShapePtr : IPxActorShapePtr { // pointer
    private IntPtr nativePtr_;
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
    //#       PxActorShape                                                           #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxActorShape
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxActorShape                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxActorShape
    // NATIVE SIG: PX_INLINE PxActorShape(PxRigidActor* a, PxShape* s) : actor(a), shape(s) {}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxActorShape_R_PxActorShapePtr_P_PxRigidActorPtr_P_PxShapePtr_C_PxActorShape_ctor(physx::PxRigidActor* a, physx::PxShape* s){
        auto nat_in_a = (a);
        auto nat_in_s = (s);
        return PxActorShape(nat_in_a, nat_in_s);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxActorShape_R_PxActorShapePtr_P_PxRigidActorPtr_P_PxShapePtr_C_PxActorShape_ctor(PxRigidActorPtr a, PxShapePtr s);
    
    public  PxActorShape(PxRigidActorPtr a, PxShapePtr s){
        PxRigidActorPtr pvk_in_a = (a);
        PxShapePtr pvk_in_s = (s);
        var _new = W_PxActorShape_R_PxActorShapePtr_P_PxRigidActorPtr_P_PxShapePtr_C_PxActorShape_ctor(pvk_in_a, pvk_in_s);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
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
    // PxSweepHit();
    //static UNPARSED_TYPE operator=(PxSweepHitPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSweepHitPtr lhs, /*NULLPARS*/);
    // PxSweepHit(/*NULLPARS*/);
    // PxSweepHit(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxSweepHit(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxSweepHitPtr : IPxQueryHitPtr, IPxLocationHitPtr, IPxSweepHitPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxLocationHit(){((PxLocationHitPtr)this).PxLocationHit();}
    public  bool hadInitialOverlap(){return ((PxLocationHitPtr)this).hadInitialOverlap();}
    //public  PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public  PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxLocationHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxLocationHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxLocationHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxLocationHit(/*NULLARGS*/);}
    
    // --- PxQueryHitPtr
    //public  PxQueryHit(){((PxLocationHitPtr)this).PxQueryHit();}
    //public  PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxLocationHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxLocationHitPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxSweepHit                                                             #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxSweepHit
    Parameterless constructor not allowed
    */
    
    
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
    // PxOverlapHit(/*NULLPARS*/);
    // PxOverlapHit(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxOverlapHit(/*NULLPARS*/);
    // PxOverlapHit(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxOverlapHitPtr : IPxActorShapePtr, IPxQueryHitPtr, IPxOverlapHitPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxQueryHit(){((PxQueryHitPtr)this).PxQueryHit();}
    //public  PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).PxQueryHit(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxQueryHit(/*NULLPARS*/){((PxQueryHitPtr)this).~PxQueryHit(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxQueryHitPtr lhs, /*NULLPARS*/){return ((PxQueryHitPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxActorShapePtr
    //public  PxActorShape(){((PxQueryHitPtr)this).PxActorShape();}
    //public  PxActorShape(PxRigidActorPtr a, PxShapePtr s){((PxQueryHitPtr)this).PxActorShape(a, s);}
    //public  PxActorShape(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
    //public  PxActorShape(/*NULLPARS*/){((PxQueryHitPtr)this).PxActorShape(/*NULLARGS*/);}
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
    // PxHitBuffer<HitType>( aTouches);
    // PxHitBuffer<HitType>();
    // PxHitBuffer<HitType>( aTouches, uint aMaxNbTouches);
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

#if !NATIVE //struct start
public unsafe partial struct PxHitBufferPtr : IPxHitCallbackPtr, IPxHitBufferPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxHitCallbackPtr, PxHitBufferPtr
    public static implicit operator PxHitCallbackPtr(PxHitBufferPtr obj){return *(PxHitCallbackPtr*)&obj;}
    public static explicit operator PxHitBufferPtr(PxHitCallbackPtr obj){return *(PxHitBufferPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxHitCallbackPtr
    //public  PxHitCallback<HitType>( aTouches, uint aMaxNbTouches){((PxHitCallbackPtr)this).PxHitCallback<HitType>(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitCallbackPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitCallbackPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback<HitType>(){((PxHitCallbackPtr)this).~PxHitCallback<HitType>();}
    public  bool hasAnyHits(){return ((PxHitCallbackPtr)this).hasAnyHits();}
    
    #endif //piping
    
    //================================================================================
    //#       PxHitBuffer<HitType>                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxHitBuffer
    Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitBuffer(HitType* aTouches = NULL, PxU32 aMaxNbTouches = 0)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__P_uint_C_PxHitBuffer_ctor( aTouches, physx::PxU32 aMaxNbTouches){
        auto nat_in_aTouches = (aTouches);
        auto nat_in_aMaxNbTouches = (aMaxNbTouches);
        return PxHitBuffer<HitType>(nat_in_aTouches, nat_in_aMaxNbTouches);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__P_uint_C_PxHitBuffer_ctor( aTouches, uint aMaxNbTouches);
    
    public  PxHitBuffer<HitType>( aTouches, uint aMaxNbTouches){
         pvk_in_aTouches = (aTouches);
        uint pvk_in_aMaxNbTouches = (aMaxNbTouches);
        var _new = W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__P_uint_C_PxHitBuffer_ctor(pvk_in_aTouches, pvk_in_aMaxNbTouches);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: unhandled return type: physx::PxHitBuffer
    Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitBuffer(HitType* aTouches = NULL, PxU32 aMaxNbTouches = 0)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__OL1_C_PxHitBuffer_ctor( aTouches){
        auto nat_in_aTouches = (aTouches);
        return PxHitBuffer<HitType>(nat_in_aTouches);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__OL1_C_PxHitBuffer_ctor( aTouches);
    
    public  PxHitBuffer<HitType>( aTouches){
         pvk_in_aTouches = (aTouches);
        var _new = W_PxHitBuffer<HitType>_R_PxHitBufferPtr_P__OL1_C_PxHitBuffer_ctor(pvk_in_aTouches);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxHitBuffer
    Parameterless constructor not allowed
    */
    
    
    
    
    //================================================================================
    //#       getNbAnyHits                                                           #
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
    //#       getAnyHit                                                              #
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
    //#       getNbTouches                                                           #
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
    //#       getTouches                                                             #
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
    //#       getTouch                                                               #
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
    //#       getMaxNbTouches                                                        #
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
    //#       ~PxHitBuffer<HitType>                                                  #
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
    // PxRaycastBufferN<N>();
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxRaycastBufferNPtr : IPxHitCallbackPtr, IPxHitBufferPtr, IPxRaycastBufferNPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxHitBuffer( aTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches);}
    //public  PxHitBuffer(){((PxHitBufferPtr)this).PxHitBuffer();}
    //public  PxHitBuffer( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches, aMaxNbTouches);}
    public  uint getNbAnyHits(){return ((PxHitBufferPtr)this).getNbAnyHits();}
    //public  UNPARSED_TYPE getAnyHit(uint index){return ((PxHitBufferPtr)this).getAnyHit(index);}
    public  uint getNbTouches(){return ((PxHitBufferPtr)this).getNbTouches();}
    //public  UNPARSED_TYPE getTouches(){return ((PxHitBufferPtr)this).getTouches();}
    //public  UNPARSED_TYPE getTouch(uint index){return ((PxHitBufferPtr)this).getTouch(index);}
    public  uint getMaxNbTouches(){return ((PxHitBufferPtr)this).getMaxNbTouches();}
    //public  void ~PxHitBuffer(){((PxHitBufferPtr)this).~PxHitBuffer();}
    //public  UNPARSED_TYPE processTouches(/*NULLPARS*/){return ((PxHitBufferPtr)this).processTouches(/*NULLARGS*/);}
    //public  PxHitBuffer(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitBuffer(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxHitBufferPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxHitCallbackPtr
    //public  PxHitCallback( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitCallback(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitBufferPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitBufferPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback(){((PxHitBufferPtr)this).~PxHitCallback();}
    public  bool hasAnyHits(){return ((PxHitBufferPtr)this).hasAnyHits();}
    //public static UNPARSED_TYPE operator=(PxHitCallbackPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    //public  PxHitCallback(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxRaycastBufferN<N>                                                    #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxRaycastBufferN
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxOverlapBufferNPtr {
    // PxOverlapBufferN<N>();
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxOverlapBufferNPtr : IPxHitCallbackPtr, IPxHitBufferPtr, IPxOverlapBufferNPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxHitBuffer( aTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches);}
    //public  PxHitBuffer(){((PxHitBufferPtr)this).PxHitBuffer();}
    //public  PxHitBuffer( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches, aMaxNbTouches);}
    public  uint getNbAnyHits(){return ((PxHitBufferPtr)this).getNbAnyHits();}
    //public  UNPARSED_TYPE getAnyHit(uint index){return ((PxHitBufferPtr)this).getAnyHit(index);}
    public  uint getNbTouches(){return ((PxHitBufferPtr)this).getNbTouches();}
    //public  UNPARSED_TYPE getTouches(){return ((PxHitBufferPtr)this).getTouches();}
    //public  UNPARSED_TYPE getTouch(uint index){return ((PxHitBufferPtr)this).getTouch(index);}
    public  uint getMaxNbTouches(){return ((PxHitBufferPtr)this).getMaxNbTouches();}
    //public  void ~PxHitBuffer(){((PxHitBufferPtr)this).~PxHitBuffer();}
    //public  UNPARSED_TYPE processTouches(/*NULLPARS*/){return ((PxHitBufferPtr)this).processTouches(/*NULLARGS*/);}
    //public  PxHitBuffer(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitBuffer(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxHitBufferPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxHitCallbackPtr
    //public  PxHitCallback( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitCallback(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitBufferPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitBufferPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback(){((PxHitBufferPtr)this).~PxHitCallback();}
    public  bool hasAnyHits(){return ((PxHitBufferPtr)this).hasAnyHits();}
    //public static UNPARSED_TYPE operator=(PxHitCallbackPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    //public  PxHitCallback(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxOverlapBufferN<N>                                                    #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxOverlapBufferN
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxSweepBufferNPtr {
    // PxSweepBufferN<N>();
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxSweepBufferNPtr : IPxHitCallbackPtr, IPxHitBufferPtr, IPxSweepBufferNPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxHitBuffer( aTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches);}
    //public  PxHitBuffer(){((PxHitBufferPtr)this).PxHitBuffer();}
    //public  PxHitBuffer( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitBuffer(aTouches, aMaxNbTouches);}
    public  uint getNbAnyHits(){return ((PxHitBufferPtr)this).getNbAnyHits();}
    //public  UNPARSED_TYPE getAnyHit(uint index){return ((PxHitBufferPtr)this).getAnyHit(index);}
    public  uint getNbTouches(){return ((PxHitBufferPtr)this).getNbTouches();}
    //public  UNPARSED_TYPE getTouches(){return ((PxHitBufferPtr)this).getTouches();}
    //public  UNPARSED_TYPE getTouch(uint index){return ((PxHitBufferPtr)this).getTouch(index);}
    public  uint getMaxNbTouches(){return ((PxHitBufferPtr)this).getMaxNbTouches();}
    //public  void ~PxHitBuffer(){((PxHitBufferPtr)this).~PxHitBuffer();}
    //public  UNPARSED_TYPE processTouches(/*NULLPARS*/){return ((PxHitBufferPtr)this).processTouches(/*NULLARGS*/);}
    //public  PxHitBuffer(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitBuffer(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxHitBufferPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxHitCallbackPtr
    //public  PxHitCallback( aTouches, uint aMaxNbTouches){((PxHitBufferPtr)this).PxHitCallback(aTouches, aMaxNbTouches);}
    //public  bool processTouches( buffer, uint nbHits){return ((PxHitBufferPtr)this).processTouches(buffer, nbHits);}
    public  void finalizeQuery(){((PxHitBufferPtr)this).finalizeQuery();}
    //public  void ~PxHitCallback(){((PxHitBufferPtr)this).~PxHitCallback();}
    public  bool hasAnyHits(){return ((PxHitBufferPtr)this).hasAnyHits();}
    //public static UNPARSED_TYPE operator=(PxHitCallbackPtr lhs, /*NULLPARS*/){return ((PxHitBufferPtr)this).operator=(/*NULLARGS*/);}
    //public  PxHitCallback(/*NULLPARS*/){((PxHitBufferPtr)this).PxHitCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxSweepBufferN<N>                                                      #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxSweepBufferN
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE //struct close
}
#endif //struct close
