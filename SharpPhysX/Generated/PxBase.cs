#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxBaseFlag : int {
    eOWNS_MEMORY = 1,   // eOWNS_MEMORY = (1<<0)
    eIS_RELEASABLE = 2, // eIS_RELEASABLE = (1<<1)
}
#endif

#if !NATIVE
public partial struct PxBase {
#endif

//================================================================================
//#       getBinaryMetaData_PxBase                                               #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxOutputStreamPtr
// NATIVE SIG: void				getBinaryMetaData_PxBase(PxOutputStream& stream)
#if NATIVE
ES void W_getBinaryMetaData_PxBase(physx::PxOutputStream* stream){
    auto nat_in_stream = (stream);
    physx::getBinaryMetaData_PxBase(*nat_in_stream);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_getBinaryMetaData_PxBase(PxOutputStreamPtr stream);

public static void getBinaryMetaData_PxBase(PxOutputStreamPtr stream){
    PxOutputStreamPtr pvk_in_stream = (stream);
    W_getBinaryMetaData_PxBase(pvk_in_stream);
}
#endif*/


//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxBaseFlag::Enum a, physx::PxBaseFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxBaseFlag a, PxBaseFlag b);

public static UNPARSED_TYPE operator|(PxBaseFlag a, PxBaseFlag b){
    PxBaseFlag pvk_in_a = (a);
    PxBaseFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxBaseFlag::Enum a, physx::PxBaseFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxBaseFlag a, PxBaseFlag b);

public static UNPARSED_TYPE operator&(PxBaseFlag a, PxBaseFlag b){
    PxBaseFlag pvk_in_a = (a);
    PxBaseFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxBaseFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxBaseFlag a);

public static UNPARSED_TYPE operator~(PxBaseFlag a){
    PxBaseFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxBase
#endif


#if !NATIVE
public unsafe partial struct PxBasePtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxBase* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxBasePtr selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxBase* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxBasePtr selfPtr);
    
    public IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       is                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*					is()
    #if NATIVE
    ES UNPARSED_TYPE W_is(physx::PxBase* self){
        auto retVal = self->is();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_is(PxBasePtr selfPtr);
    
    public UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = W_is(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       is                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				is() const
    #if NATIVE
    ES UNPARSED_TYPE W_is(physx::PxBase* self){
        auto retVal = self->is();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_is(PxBasePtr selfPtr);
    
    public UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = W_is(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConcreteType                                                        #
    //================================================================================
    #if NATIVE
    ES physx::PxType W_getConcreteType(physx::PxBase* self){
        auto retVal = self->getConcreteType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getConcreteType(PxBasePtr selfPtr);
    
    public ushort getConcreteType(){
        ushort retVal = W_getConcreteType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setBaseFlag                                                            #
    //================================================================================
    #if NATIVE
    ES void W_setBaseFlag(physx::PxBase* self, physx::PxBaseFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setBaseFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBaseFlag(PxBasePtr selfPtr, PxBaseFlag flag, bool value);
    
    public void setBaseFlag(PxBaseFlag flag, bool value){
        PxBaseFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setBaseFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setBaseFlags                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: void					setBaseFlags(PxBaseFlags inFlags)				{ mBaseFlags = inFlags; }
    #if NATIVE
    ES void W_setBaseFlags(physx::PxBase* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setBaseFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBaseFlags(PxBasePtr selfPtr,  inFlags);
    
    public void setBaseFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setBaseFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getBaseFlags                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBaseFlags
    // NATIVE SIG: PxBaseFlags				getBaseFlags() const							{ return mBaseFlags; }
    #if NATIVE
    ES UNPARSED_TYPE W_getBaseFlags(physx::PxBase* self){
        auto retVal = self->getBaseFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getBaseFlags(PxBasePtr selfPtr);
    
    public UNPARSED_TYPE getBaseFlags(){
        UNPARSED_TYPE retVal = W_getBaseFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isReleasable                                                           #
    //================================================================================
    #if NATIVE
    ES bool W_isReleasable(physx::PxBase* self){
        auto retVal = self->isReleasable();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isReleasable(PxBasePtr selfPtr);
    
    public bool isReleasable(){
        bool retVal = W_isReleasable(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxBase                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBase
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE								PxBase(PxType concreteType, PxBaseFlags baseFlags)
    												: mConcreteType(concreteType), mBaseFlags(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxBase_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxBase(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBase_ctor(ushort concreteType,  baseFlags);
    
    public PxBase(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxBase_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBase                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBase
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE								PxBase(PxBaseFlags baseFlags) : mBaseFlags(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxBase_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxBase(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBase_ctor( baseFlags);
    
    public PxBase( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxBase_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBase                                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual									~PxBase()										{}
    #if NATIVE
    ES void W_~PxBase(physx::PxBase* self){
        self->~PxBase();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBase(PxBasePtr selfPtr);
    
    public void ~PxBase(){
        W_~PxBase(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxBase* self, const char* superClass){
        auto nat_in_superClass = (superClass);
        auto retVal = self->isKindOf(nat_in_superClass);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxBasePtr selfPtr, string superClass);
    
    public bool isKindOf(string superClass){
        string pvk_in_superClass = (superClass);
        bool retVal = W_isKindOf(this, pvk_in_superClass);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       typeMatch                                                              #
    //================================================================================
    #if NATIVE
    ES bool W_typeMatch(physx::PxBase* self){
        auto retVal = self->typeMatch();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_typeMatch(PxBasePtr selfPtr);
    
    public bool typeMatch(){
        bool retVal = W_typeMatch(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxBase
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxBaseFlag is enum namespace