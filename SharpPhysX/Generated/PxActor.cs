#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxActorType : int {
    eRIGID_STATIC = 0,               // eRIGID_STATIC
    eRIGID_DYNAMIC = 1,              // eRIGID_DYNAMIC
    eARTICULATION_LINK = 2,          // eARTICULATION_LINK
    eACTOR_COUNT = 3,                // eACTOR_COUNT
    eACTOR_FORCE_DWORD = 2147483647, // eACTOR_FORCE_DWORD = 0x7fffffff
}
#endif

#if !NATIVE
public enum PxActorFlag : int {
    eVISUALIZATION = 1,       // eVISUALIZATION = (1<<0)
    eDISABLE_GRAVITY = 2,     // eDISABLE_GRAVITY = (1<<1)
    eSEND_SLEEP_NOTIFIES = 4, // eSEND_SLEEP_NOTIFIES = (1<<2)
    eDISABLE_SIMULATION = 8,  // eDISABLE_SIMULATION = (1<<3)
}
#endif

#if !NATIVE
public partial struct PxActor {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L113~113
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxActorFlag::Enum a, physx::PxActorFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxActorFlag a, PxActorFlag b);

public static UNPARSED_TYPE operator|(PxActorFlag a, PxActorFlag b){
    PxActorFlag pvk_in_a = (a);
    PxActorFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L113~113
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxActorFlag::Enum a, physx::PxActorFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxActorFlag a, PxActorFlag b);

public static UNPARSED_TYPE operator&(PxActorFlag a, PxActorFlag b){
    PxActorFlag pvk_in_a = (a);
    PxActorFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L113~113
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxActorFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxActorFlag a);

public static UNPARSED_TYPE operator~(PxActorFlag a){
    PxActorFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxActor
#endif



#if !NATIVE
public unsafe partial struct PxActor { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L166~166
    #if NATIVE
    ES void W_release(physx::PxActor* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxActor selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getType                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L175~175
    #if NATIVE
    ES physx::PxActorType::Enum W_getType(physx::PxActor* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxActorType W_getType(PxActor selfPtr);
    
    public PxActorType getType(){
        PxActorType retVal = W_getType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getScene                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L184~184
    #if NATIVE
    ES physx::PxScene* W_getScene(physx::PxActor* self){
        auto retVal = self->getScene();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxScene W_getScene(PxActor selfPtr);
    
    public PxScene getScene(){
        PxScene retVal = W_getScene(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setName                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L200~200
    #if NATIVE
    ES void W_setName(physx::PxActor* self, const char* name){
        auto nat_in_name = (name);
        self->setName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setName(PxActor selfPtr, string name);
    
    public void setName(string name){
        string pvk_in_name = (name);
        W_setName(this, pvk_in_name);
    }
    #endif
    
    
    //================================================================================
    //#       getName                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L209~209
    #if NATIVE
    ES sbyte* W_getName(physx::PxActor* self){
        auto retVal = self->getName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getName(PxActor selfPtr);
    
    public IntPtr getName(){
        IntPtr retVal = W_getName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getWorldBounds                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L220~220
    #if NATIVE
    ES physx::PxBounds3 W_getWorldBounds(physx::PxActor* self, float inflation){
        auto nat_in_inflation = (inflation);
        auto retVal = self->getWorldBounds(nat_in_inflation);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_getWorldBounds(PxActor selfPtr, float inflation);
    
    public PxBounds3 getWorldBounds(float inflation){
        float pvk_in_inflation = (inflation);
        PxBounds3 retVal = W_getWorldBounds(this, pvk_in_inflation);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setActorFlag                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L236~236
    #if NATIVE
    ES void W_setActorFlag(physx::PxActor* self, physx::PxActorFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setActorFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setActorFlag(PxActor selfPtr, PxActorFlag flag, bool value);
    
    public void setActorFlag(PxActorFlag flag, bool value){
        PxActorFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setActorFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setActorFlags                                                          #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxActorFlags
    // NATIVE SIG: void			setActorFlags( PxActorFlags inFlags ) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L243~243
    #if NATIVE
    ES void W_setActorFlags(physx::PxActor* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setActorFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setActorFlags(PxActor selfPtr,  inFlags);
    
    public void setActorFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setActorFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getActorFlags                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxActorFlags
    // NATIVE SIG: PxActorFlags	getActorFlags()	const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L254~254
    #if NATIVE
    ES UNPARSED_TYPE W_getActorFlags(physx::PxActor* self){
        auto retVal = self->getActorFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getActorFlags(PxActor selfPtr);
    
    public UNPARSED_TYPE getActorFlags(){
        UNPARSED_TYPE retVal = W_getActorFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setDominanceGroup                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L272~272
    #if NATIVE
    ES void W_setDominanceGroup(physx::PxActor* self, physx::PxDominanceGroup dominanceGroup){
        auto nat_in_dominanceGroup = (dominanceGroup);
        self->setDominanceGroup(nat_in_dominanceGroup);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setDominanceGroup(PxActor selfPtr, byte dominanceGroup);
    
    public void setDominanceGroup(byte dominanceGroup){
        byte pvk_in_dominanceGroup = (dominanceGroup);
        W_setDominanceGroup(this, pvk_in_dominanceGroup);
    }
    #endif
    
    
    //================================================================================
    //#       getDominanceGroup                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L281~281
    #if NATIVE
    ES physx::PxDominanceGroup W_getDominanceGroup(physx::PxActor* self){
        auto retVal = self->getDominanceGroup();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte W_getDominanceGroup(PxActor selfPtr);
    
    public byte getDominanceGroup(){
        byte retVal = W_getDominanceGroup(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setOwnerClient                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L293~293
    #if NATIVE
    ES void W_setOwnerClient(physx::PxActor* self, physx::PxClientID inClient){
        auto nat_in_inClient = (inClient);
        self->setOwnerClient(nat_in_inClient);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setOwnerClient(PxActor selfPtr, byte inClient);
    
    public void setOwnerClient(byte inClient){
        byte pvk_in_inClient = (inClient);
        W_setOwnerClient(this, pvk_in_inClient);
    }
    #endif
    
    
    //================================================================================
    //#       getOwnerClient                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L302~302
    #if NATIVE
    ES physx::PxClientID W_getOwnerClient(physx::PxActor* self){
        auto retVal = self->getOwnerClient();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte W_getOwnerClient(PxActor selfPtr);
    
    public byte getOwnerClient(){
        byte retVal = W_getOwnerClient(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getAggregate                                                           #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxAggregate*	getAggregate()	const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L311~311
    #if NATIVE
    ES physx::PxAggregate* W_getAggregate(physx::PxActor* self){
        auto retVal = self->getAggregate();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAggregate W_getAggregate(PxActor selfPtr);
    
    public PxAggregate getAggregate(){
        PxAggregate retVal = W_getAggregate(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxActor                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxActor
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxActor(PxType concreteType, PxBaseFlags baseFlags) : PxBase(concreteType, baseFlags), userData(NULL) {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L317~317
    #if NATIVE
    ES UNPARSED_TYPE W_PxActor_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxActor(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxActor_ctor(ushort concreteType,  baseFlags);
    
    public PxActor(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxActor_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxActor                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxActor
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxActor(PxBaseFlags baseFlags) : PxBase(baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L318~318
    #if NATIVE
    ES UNPARSED_TYPE W_PxActor_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxActor(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxActor_ctor( baseFlags);
    
    public PxActor( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxActor_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxActor                                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxActor()	{}
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L319~319
    #if NATIVE
    ES void W_~PxActor(physx::PxActor* self){
        self->~PxActor();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxActor(PxActor selfPtr);
    
    public void ~PxActor(){
        W_~PxActor(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxActor.h L320~320
    #if NATIVE
    ES bool W_isKindOf(physx::PxActor* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxActor selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxActor
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxActorType is enum namespace
// Class physx::PxActorFlag is enum namespace