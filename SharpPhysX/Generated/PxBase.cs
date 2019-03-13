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

#if !NATIVE
public unsafe partial struct PxBase { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L85~85
    #if NATIVE
    ES void release(physx::PxBase* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void release(PxBase selfPtr);
    
    public void release(){
        release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L91~91
    #if NATIVE
    ES UNPARSED_TYPE getConcreteTypeName(physx::PxBase* self){
        UNPARSED_TYPE retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getConcreteTypeName(PxBase selfPtr);
    
    public UNPARSED_TYPE getConcreteTypeName(){
        UNPARSED_TYPE retVal = getConcreteTypeName(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       is                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L101~101
    #if NATIVE
    ES UNPARSED_TYPE is(physx::PxBase* self){
        UNPARSED_TYPE retVal = self->is();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE is(PxBase selfPtr);
    
    public UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = is(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       is                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L111~111
    #if NATIVE
    ES UNPARSED_TYPE is(physx::PxBase* self){
        UNPARSED_TYPE retVal = self->is();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE is(PxBase selfPtr);
    
    public UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = is(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConcreteType                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L119~119
    #if NATIVE
    ES physx::PxType getConcreteType(physx::PxBase* self){
        physx::PxType retVal = self->getConcreteType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort getConcreteType(PxBase selfPtr);
    
    public ushort getConcreteType(){
        ushort retVal = getConcreteType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setBaseFlag                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L127~127
    #if NATIVE
    ES void setBaseFlag(physx::PxBase* self, physx::PxBaseFlag::Enum flag, bool value){
        physx::PxBaseFlag::Enum nat_in_flag = (flag);
        bool nat_in_value = (value);
        self->setBaseFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setBaseFlag(PxBase selfPtr, PxBaseFlag flag, bool value);
    
    public void setBaseFlag(PxBaseFlag flag, bool value){
        PxBaseFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        setBaseFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setBaseFlags                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxBase::setBaseFlags::inFlags
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L136~136
    #if NATIVE
    ES void setBaseFlags(physx::PxBase* self,  inFlags){
         nat_in_inFlags = (inFlags);
        self->setBaseFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setBaseFlags(PxBase selfPtr,  inFlags);
    
    public void setBaseFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        setBaseFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getBaseFlags                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L145~145
    #if NATIVE
    ES UNPARSED_TYPE getBaseFlags(physx::PxBase* self){
        UNPARSED_TYPE retVal = self->getBaseFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getBaseFlags(PxBase selfPtr);
    
    public UNPARSED_TYPE getBaseFlags(){
        UNPARSED_TYPE retVal = getBaseFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isReleasable                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L156~156
    #if NATIVE
    ES bool isReleasable(physx::PxBase* self){
        bool retVal = self->isReleasable();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isReleasable(PxBase selfPtr);
    
    public bool isReleasable(){
        bool retVal = isReleasable(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxBase                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxBase::PxBase::baseFlags
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L162~163
    #if NATIVE
    ES UNPARSED_TYPE PxBase_ctor(physx::PxType concreteType,  baseFlags){
        physx::PxType nat_in_concreteType = (concreteType);
         nat_in_baseFlags = (baseFlags);
        self->PxBase(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBase_ctor(ushort concreteType,  baseFlags);
    
    public PxBase(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = PxBase_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBase                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxBase::PxBase::baseFlags
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L168~168
    #if NATIVE
    ES UNPARSED_TYPE PxBase_ctor( baseFlags){
         nat_in_baseFlags = (baseFlags);
        self->PxBase(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBase_ctor( baseFlags);
    
    public PxBase( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = PxBase_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBase                                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L173~173
    #if NATIVE
    ES void ~PxBase(physx::PxBase* self){
        self->~PxBase();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxBase(PxBase selfPtr);
    
    public void ~PxBase(){
        ~PxBase(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L178~178
    #if NATIVE
    ES bool isKindOf(physx::PxBase* self, char superClass){
        char nat_in_superClass = (superClass);
        bool retVal = self->isKindOf(nat_in_superClass);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isKindOf(PxBase selfPtr, sbyte superClass);
    
    public bool isKindOf(sbyte superClass){
        sbyte pvk_in_superClass = (superClass);
        bool retVal = isKindOf(this, pvk_in_superClass);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       typeMatch                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L180~180
    #if NATIVE
    ES bool typeMatch(physx::PxBase* self){
        bool retVal = self->typeMatch();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool typeMatch(PxBase selfPtr);
    
    public bool typeMatch(){
        bool retVal = typeMatch(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxBase                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L73~73
    #if NATIVE
    ES UNPARSED_TYPE PxBase_ctor( ){
         nat_in_ = ();
        self->PxBase(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBase_ctor( );
    
    public PxBase( ){
         pvk_in_ = ();
        var _new = PxBase_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L73~73
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxBase* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxBase selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxBaseFlag { // blittable

#endif

    //================================================================================
    //#       PxBaseFlag                                                             #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L54~54
    #if NATIVE
    ES physx::PxBaseFlag PxBaseFlag_ctor(){
        self.PxBaseFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBaseFlag PxBaseFlag_ctor();
    
    public PxBaseFlag(){
        var _new = PxBaseFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBaseFlag                                                             #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L54~54
    #if NATIVE
    ES physx::PxBaseFlag PxBaseFlag_ctor(physx::PxBaseFlag ){
        physx::PxBaseFlag nat_in_ = ();
        self.PxBaseFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBaseFlag PxBaseFlag_ctor(PxBaseFlag );
    
    public PxBaseFlag(PxBaseFlag ){
        PxBaseFlag pvk_in_ = ();
        var _new = PxBaseFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxBaseFlag self, physx::PxBaseFlag ){
        physx::PxBaseFlag nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxBaseFlag selfBlt, PxBaseFlag );
    
    public UNPARSED_TYPE operator=(PxBaseFlag ){
        PxBaseFlag pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBaseFlag                                                             #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxBaseFlag
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L54~54
    #if NATIVE
    ES physx::PxBaseFlag PxBaseFlag_ctor( ){
         nat_in_ = ();
        self.PxBaseFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBaseFlag PxBaseFlag_ctor( );
    
    public PxBaseFlag( ){
         pvk_in_ = ();
        var _new = PxBaseFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxBaseFlag
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxBaseFlag self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxBaseFlag selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBaseFlag                                                            #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxBase.h L54~54
    #if NATIVE
    ES void ~PxBaseFlag(physx::PxBaseFlag self){
        self.~PxBaseFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxBaseFlag(PxBaseFlag selfBlt);
    
    public void ~PxBaseFlag(){
        ~PxBaseFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
