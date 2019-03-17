#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxQueryFlag : int {
    eSTATIC = 1,       // eSTATIC = (1<<0)
    eDYNAMIC = 2,      // eDYNAMIC = (1<<1)
    ePREFILTER = 4,    // ePREFILTER = (1<<2)
    ePOSTFILTER = 8,   // ePOSTFILTER = (1<<3)
    eANY_HIT = 16,     // eANY_HIT = (1<<4)
    eNO_BLOCK = 32,    // eNO_BLOCK = (1<<5)
    eRESERVED = 32768, // eRESERVED = (1<<15)
}
#endif

#if !NATIVE
public enum PxQueryHitType : int {
    eNONE = 0,  // eNONE = 0
    eTOUCH = 1, // eTOUCH = 1
    eBLOCK = 2, // eBLOCK = 2
}
#endif

#if !NATIVE
public partial struct PxQueryFiltering {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L86~86
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxQueryFlag::Enum a, physx::PxQueryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxQueryFlag a, PxQueryFlag b);

public static UNPARSED_TYPE operator|(PxQueryFlag a, PxQueryFlag b){
    PxQueryFlag pvk_in_a = (a);
    PxQueryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L86~86
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxQueryFlag::Enum a, physx::PxQueryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxQueryFlag a, PxQueryFlag b);

public static UNPARSED_TYPE operator&(PxQueryFlag a, PxQueryFlag b){
    PxQueryFlag pvk_in_a = (a);
    PxQueryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L86~86
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxQueryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxQueryFlag a);

public static UNPARSED_TYPE operator~(PxQueryFlag a){
    PxQueryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxQueryFiltering
#endif


#if !NATIVE
public unsafe partial struct PxQueryFilterData { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxQueryFilterData                                                      #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxQueryFilterData
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxQueryFilterData                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxQueryFilterData
    Unresolved parameter type physx::PxQueryFlags
    // NATIVE SIG: explicit PX_INLINE PxQueryFilterData(const PxFilterData& fd, PxQueryFlags f) : data(fd), flags(f)	{}
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L138~138
    #if NATIVE
    ES UNPARSED_TYPE W_PxQueryFilterData_ctor(physx::PxFilterData* fd,  f){
        auto nat_in_fd = (fd);
        auto nat_in_f = (f);
        self->PxQueryFilterData(*nat_in_fd, nat_in_f);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxQueryFilterData_ctor(PxFilterData fd,  f);
    
    public PxQueryFilterData(PxFilterData fd,  f){
        PxFilterData pvk_in_fd = (fd);
         pvk_in_f = (f);
        var _new = W_PxQueryFilterData_ctor(pvk_in_fd, pvk_in_f);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxQueryFilterData                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxQueryFilterData
    Unresolved parameter type physx::PxQueryFlags
    // NATIVE SIG: explicit PX_INLINE PxQueryFilterData(PxQueryFlags f) : flags(f)										{}
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L141~141
    #if NATIVE
    ES UNPARSED_TYPE W_PxQueryFilterData_ctor( f){
        auto nat_in_f = (f);
        self->PxQueryFilterData(nat_in_f);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxQueryFilterData_ctor( f);
    
    public PxQueryFilterData( f){
         pvk_in_f = (f);
        var _new = W_PxQueryFilterData_ctor(pvk_in_f);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //Skipped generated implicit entry: PxQueryFilterData
    
    //Skipped generated implicit entry: PxQueryFilterData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxQueryFilterData
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxQueryFlag is enum namespace
#if !NATIVE
public unsafe partial struct PxQueryFilterCallback { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       preFilter                                                              #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: PxQueryHitType::Enum preFilter(
    		const PxFilterData& filterData, const PxShape* shape, const PxRigidActor* actor, PxHitFlags& queryFlags) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L182~183
    #if NATIVE
    ES physx::PxQueryHitType::Enum W_preFilter(physx::PxQueryFilterCallback* self, physx::PxFilterData* filterData, physx::PxShape* shape, physx::PxRigidActor* actor,  queryFlags){
        auto nat_in_filterData = (filterData);
        auto nat_in_shape = (shape);
        auto nat_in_actor = (actor);
        auto nat_in_queryFlags = (queryFlags);
        auto retVal = self->preFilter(*nat_in_filterData, nat_in_shape, nat_in_actor, nat_in_queryFlags);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryHitType W_preFilter(PxQueryFilterCallback selfPtr, PxFilterData filterData, PxShape shape, PxRigidActor actor,  queryFlags);
    
    public PxQueryHitType preFilter(PxFilterData filterData, PxShape shape, PxRigidActor actor,  queryFlags){
        PxFilterData pvk_in_filterData = (filterData);
        PxShape pvk_in_shape = (shape);
        PxRigidActor pvk_in_actor = (actor);
         pvk_in_queryFlags = (queryFlags);
        PxQueryHitType retVal = W_preFilter(this, pvk_in_filterData, pvk_in_shape, pvk_in_actor, pvk_in_queryFlags);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       postFilter                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L192~192
    #if NATIVE
    ES physx::PxQueryHitType::Enum W_postFilter(physx::PxQueryFilterCallback* self, physx::PxFilterData* filterData, physx::PxQueryHit* hit){
        auto nat_in_filterData = (filterData);
        auto nat_in_hit = (hit);
        auto retVal = self->postFilter(*nat_in_filterData, *nat_in_hit);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQueryHitType W_postFilter(PxQueryFilterCallback selfPtr, PxFilterData filterData, PxQueryHit hit);
    
    public PxQueryHitType postFilter(PxFilterData filterData, PxQueryHit hit){
        PxFilterData pvk_in_filterData = (filterData);
        PxQueryHit pvk_in_hit = (hit);
        PxQueryHitType retVal = W_postFilter(this, pvk_in_filterData, pvk_in_hit);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       ~PxQueryFilterCallback                                                 #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxQueryFilterCallback() {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryFiltering.h L197~197
    #if NATIVE
    ES void W_~PxQueryFilterCallback(physx::PxQueryFilterCallback* self){
        self->~PxQueryFilterCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxQueryFilterCallback(PxQueryFilterCallback selfPtr);
    
    public void ~PxQueryFilterCallback(){
        W_~PxQueryFilterCallback(this);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxQueryFilterCallback
    
    //Skipped generated implicit entry: PxQueryFilterCallback
    

#if !NATIVE
}
#endif

// Class physx::PxQueryHitType is enum namespace