#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxFlags { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L78~78
    #if NATIVE
    ES UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor(physx::PxEMPTY ){
        physx::PxEMPTY nat_in_ = ();
        self->PxFlags<enumtype, storagetype>(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor(PxEMPTY );
    
    public PxFlags<enumtype, storagetype>(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = PxFlags<enumtype, storagetype>_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L81~81
    #if NATIVE
    ES UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor(){
        self->PxFlags<enumtype, storagetype>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor();
    
    public PxFlags<enumtype, storagetype>(){
        var _new = PxFlags<enumtype, storagetype>_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::PxFlags<enumtype, storagetype>::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor( e){
         nat_in_e = (e);
        self->PxFlags<enumtype, storagetype>(nat_in_e);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor( e);
    
    public PxFlags<enumtype, storagetype>( e){
         pvk_in_e = (e);
        var _new = PxFlags<enumtype, storagetype>_ctor(pvk_in_e);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor( f){
         nat_in_f = (f);
        self->PxFlags<enumtype, storagetype>(nat_in_f);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor( f);
    
    public PxFlags<enumtype, storagetype>( f){
         pvk_in_f = (f);
        var _new = PxFlags<enumtype, storagetype>_ctor(pvk_in_f);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::PxFlags<enumtype, storagetype>::b
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L84~84
    #if NATIVE
    ES UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor( b){
         nat_in_b = (b);
        self->PxFlags<enumtype, storagetype>(nat_in_b);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFlags<enumtype, storagetype>_ctor( b);
    
    public PxFlags<enumtype, storagetype>( b){
         pvk_in_b = (b);
        var _new = PxFlags<enumtype, storagetype>_ctor(pvk_in_b);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isSet                                                                  #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxFlags::isSet::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L86~86
    #if NATIVE
    ES bool isSet(physx::PxFlags* self,  e){
         nat_in_e = (e);
        bool retVal = self->isSet(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isSet(PxFlags selfPtr,  e);
    
    public bool isSet( e){
         pvk_in_e = (e);
        bool retVal = isSet(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       set                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::set::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L87~87
    #if NATIVE
    ES UNPARSED_TYPE set(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->set(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE set(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE set( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = set(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Unresolved parameter type physx::PxFlags::operator==::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L88~88
    #if NATIVE
    ES bool operator==(physx::PxFlags* self,  e){
         nat_in_e = (e);
        bool retVal = self->operator==(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxFlags selfPtr,  e);
    
    public bool operator==( e){
         pvk_in_e = (e);
        bool retVal = operator==(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L89~89
    #if NATIVE
    ES bool operator==(physx::PxFlags* self,  f){
         nat_in_f = (f);
        bool retVal = self->operator==(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxFlags selfPtr,  f);
    
    public bool operator==( f){
         pvk_in_f = (f);
        bool retVal = operator==(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L90~90
    #if NATIVE
    ES bool operator==(physx::PxFlags* self, bool b){
        bool nat_in_b = (b);
        bool retVal = self->operator==(nat_in_b);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxFlags selfPtr, bool b);
    
    public bool operator==(bool b){
        bool pvk_in_b = (b);
        bool retVal = operator==(this, pvk_in_b);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Unresolved parameter type physx::PxFlags::operator!=::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L91~91
    #if NATIVE
    ES bool operator!=(physx::PxFlags* self,  e){
         nat_in_e = (e);
        bool retVal = self->operator!=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator!=(PxFlags selfPtr,  e);
    
    public bool operator!=( e){
         pvk_in_e = (e);
        bool retVal = operator!=(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L92~92
    #if NATIVE
    ES bool operator!=(physx::PxFlags* self,  f){
         nat_in_f = (f);
        bool retVal = self->operator!=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator!=(PxFlags selfPtr,  f);
    
    public bool operator!=( f){
         pvk_in_f = (f);
        bool retVal = operator!=(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L94~94
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxFlags* self,  f){
         nat_in_f = (f);
        UNPARSED_TYPE retVal = self->operator=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxFlags selfPtr,  f);
    
    public UNPARSED_TYPE operator=( f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator=(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Unresolved parameter type physx::PxFlags::operator=::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L95~95
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->operator=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE operator=( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = operator=(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Unresolved parameter type physx::PxFlags::operator|=::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L97~97
    #if NATIVE
    ES UNPARSED_TYPE operator|=(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->operator|=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator|=(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE operator|=( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = operator|=(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L98~98
    #if NATIVE
    ES UNPARSED_TYPE operator|=(physx::PxFlags* self,  f){
         nat_in_f = (f);
        UNPARSED_TYPE retVal = self->operator|=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator|=(PxFlags selfPtr,  f);
    
    public UNPARSED_TYPE operator|=( f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator|=(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Unresolved parameter type physx::PxFlags::operator|::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L99~99
    #if NATIVE
    ES UNPARSED_TYPE operator|(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->operator|(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator|(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE operator|( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = operator|(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L100~100
    #if NATIVE
    ES UNPARSED_TYPE operator|(physx::PxFlags* self,  f){
         nat_in_f = (f);
        UNPARSED_TYPE retVal = self->operator|(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator|(PxFlags selfPtr,  f);
    
    public UNPARSED_TYPE operator|( f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator|(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Unresolved parameter type physx::PxFlags::operator&=::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L102~102
    #if NATIVE
    ES UNPARSED_TYPE operator&=(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->operator&=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator&=(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE operator&=( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = operator&=(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L103~103
    #if NATIVE
    ES UNPARSED_TYPE operator&=(physx::PxFlags* self,  f){
         nat_in_f = (f);
        UNPARSED_TYPE retVal = self->operator&=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator&=(PxFlags selfPtr,  f);
    
    public UNPARSED_TYPE operator&=( f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator&=(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Unresolved parameter type physx::PxFlags::operator&::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L104~104
    #if NATIVE
    ES UNPARSED_TYPE operator&(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->operator&(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator&(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE operator&( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = operator&(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L105~105
    #if NATIVE
    ES UNPARSED_TYPE operator&(physx::PxFlags* self,  f){
         nat_in_f = (f);
        UNPARSED_TYPE retVal = self->operator&(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator&(PxFlags selfPtr,  f);
    
    public UNPARSED_TYPE operator&( f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator&(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Unresolved parameter type physx::PxFlags::operator^=::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L107~107
    #if NATIVE
    ES UNPARSED_TYPE operator^=(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->operator^=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator^=(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE operator^=( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = operator^=(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L108~108
    #if NATIVE
    ES UNPARSED_TYPE operator^=(physx::PxFlags* self,  f){
         nat_in_f = (f);
        UNPARSED_TYPE retVal = self->operator^=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator^=(PxFlags selfPtr,  f);
    
    public UNPARSED_TYPE operator^=( f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator^=(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Unresolved parameter type physx::PxFlags::operator^::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L109~109
    #if NATIVE
    ES UNPARSED_TYPE operator^(physx::PxFlags* self,  e){
         nat_in_e = (e);
        UNPARSED_TYPE retVal = self->operator^(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator^(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE operator^( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = operator^(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L110~110
    #if NATIVE
    ES UNPARSED_TYPE operator^(physx::PxFlags* self,  f){
         nat_in_f = (f);
        UNPARSED_TYPE retVal = self->operator^(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator^(PxFlags selfPtr,  f);
    
    public UNPARSED_TYPE operator^( f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator^(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator~                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L112~112
    #if NATIVE
    ES UNPARSED_TYPE operator~(physx::PxFlags* self){
        UNPARSED_TYPE retVal = self->operator~();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator~(PxFlags selfPtr);
    
    public UNPARSED_TYPE operator~(){
        UNPARSED_TYPE retVal = operator~(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator bool                                                          #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L114~114
    #if NATIVE
    ES bool operator bool(physx::PxFlags* self){
        bool retVal = self->operator bool();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator bool(PxFlags selfPtr);
    
    public bool operator bool(){
        bool retVal = operator bool(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator unsigned char                                                 #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L115~115
    #if NATIVE
    ES ::uint8_t operator unsigned char(physx::PxFlags* self){
        ::uint8_t retVal = self->operator unsigned char();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte operator unsigned char(PxFlags selfPtr);
    
    public byte operator unsigned char(){
        byte retVal = operator unsigned char(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator unsigned short                                                #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L116~116
    #if NATIVE
    ES ::uint16_t operator unsigned short(physx::PxFlags* self){
        ::uint16_t retVal = self->operator unsigned short();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort operator unsigned short(PxFlags selfPtr);
    
    public ushort operator unsigned short(){
        ushort retVal = operator unsigned short(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator unsigned int                                                  #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L117~117
    #if NATIVE
    ES ::uint32_t operator unsigned int(physx::PxFlags* self){
        ::uint32_t retVal = self->operator unsigned int();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint operator unsigned int(PxFlags selfPtr);
    
    public uint operator unsigned int(){
        uint retVal = operator unsigned int(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       clear                                                                  #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxFlags::clear::e
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L119~119
    #if NATIVE
    ES void clear(physx::PxFlags* self,  e){
         nat_in_e = (e);
        self->clear(nat_in_e);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void clear(PxFlags selfPtr,  e);
    
    public void clear( e){
         pvk_in_e = (e);
        clear(this, pvk_in_e);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
