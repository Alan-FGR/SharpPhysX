#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxQueryFlag : int {
    eSTATIC = 1,       // eSTATIC = (1<<0)
    eDYNAMIC = 2,      // eDYNAMIC = (1<<1)
    ePREFILTER = 4,    // ePREFILTER = (1<<2)
    ePOSTFILTER = 8,   // ePOSTFILTER = (1<<3)
    eANY_HIT = 16,     // eANY_HIT = (1<<4)
    eNO_BLOCK = 32,    // eNO_BLOCK = (1<<5)
    eRESERVED = 32768, // eRESERVED = (1<<15)
}
#endif //enum

#if !NATIVE //enum
public enum PxQueryHitType : int {
    eNONE = 0,  // eNONE = 0
    eTOUCH = 1, // eTOUCH = 1
    eBLOCK = 2, // eBLOCK = 2
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxQueryFiltering {
#endif

//================================================================================
//#       operator|(PxQueryFlag a, PxQueryFlag b)                                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short> -> PxFlags_PxQueryFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag_P_PxQueryFlag(physx::PxQueryFlag::Enum a, physx::PxQueryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag_P_PxQueryFlag(PxQueryFlag a, PxQueryFlag b);

public static UNPARSED_TYPE operator|(PxQueryFlag a, PxQueryFlag b){
    PxQueryFlag pvk_in_a = (a);
    PxQueryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag_P_PxQueryFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxQueryFlag a, PxQueryFlag b)                                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short> -> PxFlags_PxQueryFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag_P_PxQueryFlag(physx::PxQueryFlag::Enum a, physx::PxQueryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag_P_PxQueryFlag(PxQueryFlag a, PxQueryFlag b);

public static UNPARSED_TYPE operator&(PxQueryFlag a, PxQueryFlag b){
    PxQueryFlag pvk_in_a = (a);
    PxQueryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag_P_PxQueryFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxQueryFlag a)                                               #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short> -> PxFlags_PxQueryFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag(physx::PxQueryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag(PxQueryFlag a);

public static UNPARSED_TYPE operator~(PxQueryFlag a){
    PxQueryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxQueryFlag_ushort_P_PxQueryFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxQueryFiltering
#endif


#if !NATIVE //interface
public unsafe interface IPxQueryFilterDataPtr {
    // static PxQueryFilterDataPtr New();
    // static PxQueryFilterDataPtr New(PxFilterDataPtr fd,  f);
    // static PxQueryFilterDataPtr New( f);
    // static PxQueryFilterDataPtr New(/*NULLPARS*/);
    // static PxQueryFilterDataPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryFilterDataPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxQueryFilterData(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxQueryFilterDataPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxQueryFilterDataPtr : IPxQueryFilterDataPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxQueryFilterDataPtrPOD{
    physx::PxFilterData data;
    physx::PxQueryFlags flags;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxFilterData
    */
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxQueryFlags
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxQueryFilterDataPtr
    #endif //hierarchy
    //================================================================================
    //#       PxQueryFilterData()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxQueryFilterDataPtrPOD W_PxQueryFilterData_R_PxQueryFilterDataPtr_C_PxQueryFilterData_ctor(){
        auto val = new PxQueryFilterData();
        return *(PxQueryFilterDataPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryFilterDataPtr W_PxQueryFilterData_R_PxQueryFilterDataPtr_C_PxQueryFilterData_ctor();
    
    public  static PxQueryFilterDataPtr New(){
        var _new = W_PxQueryFilterData_R_PxQueryFilterDataPtr_C_PxQueryFilterData_ctor();
        PxQueryFilterDataPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxQueryFilterData(PxFilterDataPtr fd, Enum, ushort> f)                 #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxQueryFlags
    // NATIVE SIG: explicit PX_INLINE PxQueryFilterData(const PxFilterData& fd, PxQueryFlags f) : data(fd), flags(f)	{}
    #if NATIVE //function start
    ES PxQueryFilterDataPtrPOD W_PxQueryFilterData_R_PxQueryFilterDataPtr_P_PxFilterDataPtr_P__C_PxQueryFilterData_ctor(physx::PxFilterData* fd,  f){
        auto nat_in_fd = (fd);
        auto nat_in_f = (f);
        auto val = new PxQueryFilterData();
        return *(PxQueryFilterDataPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryFilterDataPtr W_PxQueryFilterData_R_PxQueryFilterDataPtr_P_PxFilterDataPtr_P__C_PxQueryFilterData_ctor(PxFilterDataPtr fd,  f);
    
    public  static PxQueryFilterDataPtr New(PxFilterDataPtr fd,  f){
        PxFilterDataPtr pvk_in_fd = (fd);
         pvk_in_f = (f);
        var _new = W_PxQueryFilterData_R_PxQueryFilterDataPtr_P_PxFilterDataPtr_P__C_PxQueryFilterData_ctor(pvk_in_fd, pvk_in_f);
        PxQueryFilterDataPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxQueryFilterData(Enum, ushort> f)                                     #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxQueryFlags
    // NATIVE SIG: explicit PX_INLINE PxQueryFilterData(PxQueryFlags f) : flags(f)										{}
    #if NATIVE //function start
    ES PxQueryFilterDataPtrPOD W_PxQueryFilterData_R_PxQueryFilterDataPtr_P__C_PxQueryFilterData_ctor( f){
        auto nat_in_f = (f);
        auto val = new PxQueryFilterData();
        return *(PxQueryFilterDataPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryFilterDataPtr W_PxQueryFilterData_R_PxQueryFilterDataPtr_P__C_PxQueryFilterData_ctor( f);
    
    public  static PxQueryFilterDataPtr New( f){
         pvk_in_f = (f);
        var _new = W_PxQueryFilterData_R_PxQueryFilterDataPtr_P__C_PxQueryFilterData_ctor(pvk_in_f);
        PxQueryFilterDataPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: PxQueryFilterData
    
    //Skipped generated implicit entry: PxQueryFilterData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxQueryFilterData
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxQueryFlag is enum namespace
#if !NATIVE //interface
public unsafe interface IPxQueryFilterCallbackPtr {
    // PxQueryHitType preFilter(PxFilterDataPtr filterData, PxShapePtr shape, PxRigidActorPtr actor,  queryFlags);
     PxQueryHitType postFilter(PxFilterDataPtr filterData, PxQueryHitPtr hit);
    // void ~PxQueryFilterCallback();
    //static UNPARSED_TYPE operator=(PxQueryFilterCallbackPtr lhs, /*NULLPARS*/);
    // static PxQueryFilterCallbackPtr New(/*NULLPARS*/);
    // static PxQueryFilterCallbackPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxQueryFilterCallbackPtr : IPxQueryFilterCallbackPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxQueryFilterCallbackPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxQueryFilterCallbackPtr
    #endif //hierarchy
    //================================================================================
    //#       preFilter(PxFilterDataPtr filterData, PxShapePtr shape, PxRigidActorPtr actor, Enum, ushort> queryFlags) #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: PxQueryHitType::Enum preFilter(
    		const PxFilterData& filterData, const PxShape* shape, const PxRigidActor* actor, PxHitFlags& queryFlags) = 0
    #if NATIVE //function start
    ES physx::PxQueryHitType::Enum W_preFilter_R_PxQueryHitType_P_PxFilterDataPtr_P_PxShapePtr_P_PxRigidActorPtr_P__C_PxQueryFilterCallback(physx::PxQueryFilterCallback* self, physx::PxFilterData* filterData, physx::PxShape* shape, physx::PxRigidActor* actor,  queryFlags){
        auto nat_in_filterData = (filterData);
        auto nat_in_shape = (shape);
        auto nat_in_actor = (actor);
        auto nat_in_queryFlags = (queryFlags);
        auto retVal = self->preFilter(*nat_in_filterData, nat_in_shape, nat_in_actor, nat_in_queryFlags);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryHitType W_preFilter_R_PxQueryHitType_P_PxFilterDataPtr_P_PxShapePtr_P_PxRigidActorPtr_P__C_PxQueryFilterCallback(PxQueryFilterCallbackPtr selfPtr, PxFilterDataPtr filterData, PxShapePtr shape, PxRigidActorPtr actor,  queryFlags);
    
    public  PxQueryHitType preFilter(PxFilterDataPtr filterData, PxShapePtr shape, PxRigidActorPtr actor,  queryFlags){
        PxFilterDataPtr pvk_in_filterData = (filterData);
        PxShapePtr pvk_in_shape = (shape);
        PxRigidActorPtr pvk_in_actor = (actor);
         pvk_in_queryFlags = (queryFlags);
        PxQueryHitType retVal = W_preFilter_R_PxQueryHitType_P_PxFilterDataPtr_P_PxShapePtr_P_PxRigidActorPtr_P__C_PxQueryFilterCallback(this, pvk_in_filterData, pvk_in_shape, pvk_in_actor, pvk_in_queryFlags);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       postFilter(PxFilterDataPtr filterData, PxQueryHitPtr hit)              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxQueryHitType::Enum W_postFilter_R_PxQueryHitType_P_PxFilterDataPtr_P_PxQueryHitPtr_C_PxQueryFilterCallback(physx::PxQueryFilterCallback* self, physx::PxFilterData* filterData, physx::PxQueryHit* hit){
        auto nat_in_filterData = (filterData);
        auto nat_in_hit = (hit);
        auto retVal = self->postFilter(*nat_in_filterData, *nat_in_hit);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryHitType W_postFilter_R_PxQueryHitType_P_PxFilterDataPtr_P_PxQueryHitPtr_C_PxQueryFilterCallback(PxQueryFilterCallbackPtr selfPtr, PxFilterDataPtr filterData, PxQueryHitPtr hit);
    
    public  PxQueryHitType postFilter(PxFilterDataPtr filterData, PxQueryHitPtr hit){
        PxFilterDataPtr pvk_in_filterData = (filterData);
        PxQueryHitPtr pvk_in_hit = (hit);
        PxQueryHitType retVal = W_postFilter_R_PxQueryHitType_P_PxFilterDataPtr_P_PxQueryHitPtr_C_PxQueryFilterCallback(this, pvk_in_filterData, pvk_in_hit);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       ~PxQueryFilterCallback()                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxQueryFilterCallback() {}
    #if NATIVE //function start
    ES void W_~PxQueryFilterCallback_R_void_C_PxQueryFilterCallback(physx::PxQueryFilterCallback* self){
        self->~PxQueryFilterCallback();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxQueryFilterCallback_R_void_C_PxQueryFilterCallback(PxQueryFilterCallbackPtr selfPtr);
    
    public  void ~PxQueryFilterCallback(){
        W_~PxQueryFilterCallback_R_void_C_PxQueryFilterCallback(this);
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxQueryFilterCallback
    
    //Skipped generated implicit entry: PxQueryFilterCallback
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxQueryHitType is enum namespace