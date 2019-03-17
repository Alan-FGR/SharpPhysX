#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
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
#endif

#if !NATIVE
public partial struct PxQueryReport {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L94~94
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxHitFlag::Enum a, physx::PxHitFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxHitFlag a, PxHitFlag b);

public static UNPARSED_TYPE operator|(PxHitFlag a, PxHitFlag b){
    PxHitFlag pvk_in_a = (a);
    PxHitFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L94~94
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxHitFlag::Enum a, physx::PxHitFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxHitFlag a, PxHitFlag b);

public static UNPARSED_TYPE operator&(PxHitFlag a, PxHitFlag b){
    PxHitFlag pvk_in_a = (a);
    PxHitFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L94~94
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxHitFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxHitFlag a);

public static UNPARSED_TYPE operator~(PxHitFlag a){
    PxHitFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxQueryReport
#endif


#if !NATIVE
public unsafe partial struct PxHitCallback { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxHitCallback<HitType>                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxHitCallback
    Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitCallback(HitType* aTouches, PxU32 aMaxNbTouches)
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L261~261
    #if NATIVE
    ES UNPARSED_TYPE W_PxHitCallback<HitType>_ctor( aTouches, physx::PxU32 aMaxNbTouches){
        auto nat_in_aTouches = (aTouches);
        auto nat_in_aMaxNbTouches = (aMaxNbTouches);
        self->PxHitCallback<HitType>(nat_in_aTouches, nat_in_aMaxNbTouches);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHitCallback<HitType>_ctor( aTouches, uint aMaxNbTouches);
    
    public PxHitCallback<HitType>( aTouches, uint aMaxNbTouches){
         pvk_in_aTouches = (aTouches);
        uint pvk_in_aMaxNbTouches = (aMaxNbTouches);
        var _new = W_PxHitCallback<HitType>_ctor(pvk_in_aTouches, pvk_in_aMaxNbTouches);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       processTouches                                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee HitType
    // NATIVE SIG: PxAgain processTouches(const HitType* buffer, PxU32 nbHits) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L285~285
    #if NATIVE
    ES physx::PxAgain W_processTouches(physx::PxHitCallback* self,  buffer, physx::PxU32 nbHits){
        auto nat_in_buffer = (buffer);
        auto nat_in_nbHits = (nbHits);
        auto retVal = self->processTouches(nat_in_buffer, nat_in_nbHits);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_processTouches(PxHitCallback selfPtr,  buffer, uint nbHits);
    
    public bool processTouches( buffer, uint nbHits){
         pvk_in_buffer = (buffer);
        uint pvk_in_nbHits = (nbHits);
        bool retVal = W_processTouches(this, pvk_in_buffer, pvk_in_nbHits);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       finalizeQuery                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L287~287
    #if NATIVE
    ES void W_finalizeQuery(physx::PxHitCallback* self){
        self->finalizeQuery();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_finalizeQuery(PxHitCallback selfPtr);
    
    public void finalizeQuery(){
        W_finalizeQuery(this);
    }
    #endif
    
    
    //================================================================================
    //#       ~PxHitCallback<HitType>                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxHitCallback()
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L289~289
    #if NATIVE
    ES void W_~PxHitCallback<HitType>(physx::PxHitCallback* self){
        self->~PxHitCallback<HitType>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxHitCallback<HitType>(PxHitCallback selfPtr);
    
    public void ~PxHitCallback<HitType>(){
        W_~PxHitCallback<HitType>(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       hasAnyHits                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L292~292
    #if NATIVE
    ES bool W_hasAnyHits(physx::PxHitCallback* self){
        auto retVal = self->hasAnyHits();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_hasAnyHits(PxHitCallback selfPtr);
    
    public bool hasAnyHits(){
        bool retVal = W_hasAnyHits(this);
        return retVal;
    }
    #endif
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxRaycastHit { // pointer
    private IntPtr nativePtr_;
#endif

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
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxLocationHit { // pointer
    private IntPtr nativePtr_;
#endif

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
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L147~147
    #if NATIVE
    ES bool W_hadInitialOverlap(physx::PxLocationHit* self){
        auto retVal = self->hadInitialOverlap();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_hadInitialOverlap(PxLocationHit selfPtr);
    
    public bool hadInitialOverlap(){
        bool retVal = W_hadInitialOverlap(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxLocationHit
    
    //Skipped generated implicit entry: PxLocationHit
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxLocationHit
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxQueryHit { // pointer
    private IntPtr nativePtr_;
#endif

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
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxActorShape { // pointer
    private IntPtr nativePtr_;
#endif

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
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L106~106
    #if NATIVE
    ES UNPARSED_TYPE W_PxActorShape_ctor(physx::PxRigidActor* a, physx::PxShape* s){
        auto nat_in_a = (a);
        auto nat_in_s = (s);
        self->PxActorShape(nat_in_a, nat_in_s);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxActorShape_ctor(PxRigidActor a, PxShape s);
    
    public PxActorShape(PxRigidActor a, PxShape s){
        PxRigidActor pvk_in_a = (a);
        PxShape pvk_in_s = (s);
        var _new = W_PxActorShape_ctor(pvk_in_a, pvk_in_s);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //Skipped generated implicit entry: PxActorShape
    
    //Skipped generated implicit entry: PxActorShape
    
    //Skipped generated implicit entry: ~PxActorShape
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxHitFlag is enum namespace
#if !NATIVE
public unsafe partial struct PxSweepHit { // pointer
    private IntPtr nativePtr_;
#endif

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
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxOverlapHit { // pointer
    private IntPtr nativePtr_;
#endif

    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxOverlapHit
    
    //Skipped generated implicit entry: PxOverlapHit
    
    //Skipped generated implicit entry: ~PxOverlapHit
    
    //Skipped generated implicit entry: PxOverlapHit
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxHitBuffer { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxHitBuffer<HitType>                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxHitBuffer
    Unresolved parameter pointee HitType
    // NATIVE SIG: PxHitBuffer(HitType* aTouches = NULL, PxU32 aMaxNbTouches = 0)
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L322~322
    #if NATIVE
    ES UNPARSED_TYPE W_PxHitBuffer<HitType>_ctor( aTouches, physx::PxU32 aMaxNbTouches){
        auto nat_in_aTouches = (aTouches);
        auto nat_in_aMaxNbTouches = (aMaxNbTouches);
        self->PxHitBuffer<HitType>(nat_in_aTouches, nat_in_aMaxNbTouches);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHitBuffer<HitType>_ctor( aTouches, uint aMaxNbTouches);
    
    public PxHitBuffer<HitType>( aTouches, uint aMaxNbTouches){
         pvk_in_aTouches = (aTouches);
        uint pvk_in_aMaxNbTouches = (aMaxNbTouches);
        var _new = W_PxHitBuffer<HitType>_ctor(pvk_in_aTouches, pvk_in_aMaxNbTouches);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbAnyHits                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L325~325
    #if NATIVE
    ES physx::PxU32 W_getNbAnyHits(physx::PxHitBuffer* self){
        auto retVal = self->getNbAnyHits();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbAnyHits(PxHitBuffer selfPtr);
    
    public uint getNbAnyHits(){
        uint retVal = W_getNbAnyHits(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getAnyHit                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: HitType
    // NATIVE SIG: HitType&	getAnyHit(const PxU32 index) const
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L327~327
    #if NATIVE
    ES UNPARSED_TYPE W_getAnyHit(physx::PxHitBuffer* self, physx::PxU32 index){
        auto nat_in_index = (index);
        auto retVal = self->getAnyHit(nat_in_index);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getAnyHit(PxHitBuffer selfPtr, uint index);
    
    public UNPARSED_TYPE getAnyHit(uint index){
        uint pvk_in_index = (index);
        UNPARSED_TYPE retVal = W_getAnyHit(this, pvk_in_index);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbTouches                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L330~330
    #if NATIVE
    ES physx::PxU32 W_getNbTouches(physx::PxHitBuffer* self){
        auto retVal = self->getNbTouches();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbTouches(PxHitBuffer selfPtr);
    
    public uint getNbTouches(){
        uint retVal = W_getNbTouches(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTouches                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: HitType
    // NATIVE SIG: HitType*	getTouches() const
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L331~331
    #if NATIVE
    ES UNPARSED_TYPE W_getTouches(physx::PxHitBuffer* self){
        auto retVal = self->getTouches();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getTouches(PxHitBuffer selfPtr);
    
    public UNPARSED_TYPE getTouches(){
        UNPARSED_TYPE retVal = W_getTouches(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTouch                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: HitType
    // NATIVE SIG: HitType&	getTouch(const PxU32 index) const
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L332~332
    #if NATIVE
    ES UNPARSED_TYPE W_getTouch(physx::PxHitBuffer* self, physx::PxU32 index){
        auto nat_in_index = (index);
        auto retVal = self->getTouch(nat_in_index);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getTouch(PxHitBuffer selfPtr, uint index);
    
    public UNPARSED_TYPE getTouch(uint index){
        uint pvk_in_index = (index);
        UNPARSED_TYPE retVal = W_getTouch(this, pvk_in_index);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getMaxNbTouches                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L333~333
    #if NATIVE
    ES physx::PxU32 W_getMaxNbTouches(physx::PxHitBuffer* self){
        auto retVal = self->getMaxNbTouches();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaxNbTouches(PxHitBuffer selfPtr);
    
    public uint getMaxNbTouches(){
        uint retVal = W_getMaxNbTouches(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       ~PxHitBuffer<HitType>                                                  #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxHitBuffer()
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L335~335
    #if NATIVE
    ES void W_~PxHitBuffer<HitType>(physx::PxHitBuffer* self){
        self->~PxHitBuffer<HitType>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxHitBuffer<HitType>(PxHitBuffer selfPtr);
    
    public void ~PxHitBuffer<HitType>(){
        W_~PxHitBuffer<HitType>(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       processTouches                                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee HitType
    // NATIVE SIG: PxAgain processTouches(const HitType* buffer, PxU32 nbHits)
    // SOURCE: C:\Projects\PhysX\physx\include\PxQueryReport.h L339~339
    #if NATIVE
    ES physx::PxAgain W_processTouches(physx::PxHitBuffer* self,  buffer, physx::PxU32 nbHits){
        auto nat_in_buffer = (buffer);
        auto nat_in_nbHits = (nbHits);
        auto retVal = self->processTouches(nat_in_buffer, nat_in_nbHits);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_processTouches(PxHitBuffer selfPtr,  buffer, uint nbHits);
    
    public bool processTouches( buffer, uint nbHits){
         pvk_in_buffer = (buffer);
        uint pvk_in_nbHits = (nbHits);
        bool retVal = W_processTouches(this, pvk_in_buffer, pvk_in_nbHits);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxRaycastBufferN { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxRaycastBufferN<N>                                                    #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxRaycastBufferN
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxOverlapBufferN { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxOverlapBufferN<N>                                                    #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxOverlapBufferN
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxSweepBufferN { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxSweepBufferN<N>                                                      #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxSweepBufferN
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE
}
#endif
