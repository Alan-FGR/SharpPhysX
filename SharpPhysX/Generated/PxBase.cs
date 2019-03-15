#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxBaseFlag : int {
     eOWNS_MEMORY			= (1<<0),
     eIS_RELEASABLE			= (1<<1),
}
#endif

public partial struct PxBase {

//================================================================================
//#       getBinaryMetaData_PxBase                                               #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxOutputStream
// NATIVE SIG: void				getBinaryMetaData_PxBase(PxOutputStream& stream)
// SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L188~188
#if NATIVE
ES void W_getBinaryMetaData_PxBase(physx::PxOutputStream* stream){
    auto nat_in_stream = (stream);
    physx::getBinaryMetaData_PxBase(*nat_in_stream);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_getBinaryMetaData_PxBase(PxOutputStream stream);

public static void getBinaryMetaData_PxBase(PxOutputStream stream){
    PxOutputStream pvk_in_stream = (stream);
    W_getBinaryMetaData_PxBase(pvk_in_stream);
}
#endif*/


//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L64~64
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
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L64~64
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
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L64~64
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

} // End PxBase


#if !NATIVE
public unsafe partial struct PxBase { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L85~85
    #if NATIVE
    ES void W_release(physx::PxBase* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxBase selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L91~91
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxBase* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxBase selfPtr);
    
    public IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       is                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    // NATIVE SIG: T*					is()
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L101~101
    #if NATIVE
    ES UNPARSED_TYPE W_is(physx::PxBase* self){
        auto retVal = self->is();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_is(PxBase selfPtr);
    
    public UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = W_is(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       is                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    // NATIVE SIG: T*				is() const
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L111~111
    #if NATIVE
    ES UNPARSED_TYPE W_is(physx::PxBase* self){
        auto retVal = self->is();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_is(PxBase selfPtr);
    
    public UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = W_is(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConcreteType                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L119~119
    #if NATIVE
    ES physx::PxType W_getConcreteType(physx::PxBase* self){
        auto retVal = self->getConcreteType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getConcreteType(PxBase selfPtr);
    
    public ushort getConcreteType(){
        ushort retVal = W_getConcreteType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setBaseFlag                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L127~127
    #if NATIVE
    ES void W_setBaseFlag(physx::PxBase* self, physx::PxBaseFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setBaseFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBaseFlag(PxBase selfPtr, PxBaseFlag flag, bool value);
    
    public void setBaseFlag(PxBaseFlag flag, bool value){
        PxBaseFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setBaseFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setBaseFlags                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxBase::setBaseFlags::inFlags
    // NATIVE SIG: void					setBaseFlags(PxBaseFlags inFlags)				{ mBaseFlags = inFlags; }
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L136~136
    #if NATIVE
    ES void W_setBaseFlags(physx::PxBase* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setBaseFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBaseFlags(PxBase selfPtr,  inFlags);
    
    public void setBaseFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setBaseFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getBaseFlags                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxBaseFlags				getBaseFlags() const							{ return mBaseFlags; }
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L145~145
    #if NATIVE
    ES UNPARSED_TYPE W_getBaseFlags(physx::PxBase* self){
        auto retVal = self->getBaseFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getBaseFlags(PxBase selfPtr);
    
    public UNPARSED_TYPE getBaseFlags(){
        UNPARSED_TYPE retVal = W_getBaseFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isReleasable                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L156~156
    #if NATIVE
    ES bool W_isReleasable(physx::PxBase* self){
        auto retVal = self->isReleasable();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isReleasable(PxBase selfPtr);
    
    public bool isReleasable(){
        bool retVal = W_isReleasable(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxBase                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxBase::PxBase::baseFlags
    // NATIVE SIG: PX_INLINE								PxBase(PxType concreteType, PxBaseFlags baseFlags)
    												: mConcreteType(concreteType), mBaseFlags(baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L162~163
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
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxBase::PxBase::baseFlags
    // NATIVE SIG: PX_INLINE								PxBase(PxBaseFlags baseFlags) : mBaseFlags(baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L168~168
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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L173~173
    #if NATIVE
    ES void W_~PxBase(physx::PxBase* self){
        self->~PxBase();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBase(PxBase selfPtr);
    
    public void ~PxBase(){
        W_~PxBase(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L178~178
    #if NATIVE
    ES bool W_isKindOf(physx::PxBase* self, const char* superClass){
        auto nat_in_superClass = (superClass);
        auto retVal = self->isKindOf(nat_in_superClass);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxBase selfPtr, string superClass);
    
    public bool isKindOf(string superClass){
        string pvk_in_superClass = (superClass);
        bool retVal = W_isKindOf(this, pvk_in_superClass);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       typeMatch                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L180~180
    #if NATIVE
    ES bool W_typeMatch(physx::PxBase* self){
        auto retVal = self->typeMatch();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_typeMatch(PxBase selfPtr);
    
    public bool typeMatch(){
        bool retVal = W_typeMatch(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxBase                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxBase
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L73~73
    #if NATIVE
    ES UNPARSED_TYPE W_PxBase_ctor(physx::PxBase* ){
        auto nat_in_ = ();
        self->PxBase(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBase_ctor(PxBase );
    
    public PxBase(PxBase ){
        PxBase pvk_in_ = ();
        var _new = W_PxBase_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxBase
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L73~73
    #if NATIVE
    ES physx::PxBase* W_operator=(physx::PxBase* self, physx::PxBase* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBase W_operator=(PxBase selfPtr, PxBase );
    
    public static PxBase operator=(PxBase lhs, PxBase ){
        PxBase pvk_in_ = ();
        PxBase retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

// Class physx::PxBaseFlag Manually Ignored