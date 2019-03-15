#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxFlags {

//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
Unresolved parameter type physx::operator&::a
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp( a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp( a,  b);

public static UNPARSED_TYPE operator&( a,  b){
     pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxBaseFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxBaseFlag a,  b);

public static UNPARSED_TYPE operator&(PxBaseFlag a,  b){
    PxBaseFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxConvexMeshGeometryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxConvexMeshGeometryFlag a,  b);

public static UNPARSED_TYPE operator&(PxConvexMeshGeometryFlag a,  b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxMeshGeometryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxMeshGeometryFlag a,  b);

public static UNPARSED_TYPE operator&(PxMeshGeometryFlag a,  b){
    PxMeshGeometryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxShapeFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxShapeFlag a,  b);

public static UNPARSED_TYPE operator&(PxShapeFlag a,  b){
    PxShapeFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxDeletionEventFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxDeletionEventFlag a,  b);

public static UNPARSED_TYPE operator&(PxDeletionEventFlag a,  b){
    PxDeletionEventFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/

} // End PxFlags


#if !NATIVE
public unsafe partial struct PxFlags { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PX_INLINE explicit PxFlags(const PxEMPTY)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L78~78
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        self->PxFlags<enumtype, storagetype>(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor(PxEMPTY );
    
    public PxFlags<enumtype, storagetype>(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxFlags(void)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L81~81
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor(){
        self->PxFlags<enumtype, storagetype>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor();
    
    public PxFlags<enumtype, storagetype>(){
        var _new = W_PxFlags<enumtype, storagetype>_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::PxFlags<enumtype, storagetype>::e
    // NATIVE SIG: PX_INLINE PxFlags(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( e){
        auto nat_in_e = (e);
        self->PxFlags<enumtype, storagetype>(nat_in_e);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( e);
    
    public PxFlags<enumtype, storagetype>( e){
         pvk_in_e = (e);
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_e);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // NATIVE SIG: PX_INLINE PxFlags(const PxFlags<enumtype, storagetype>& f)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( f){
        auto nat_in_f = (f);
        self->PxFlags<enumtype, storagetype>(nat_in_f);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( f);
    
    public PxFlags<enumtype, storagetype>( f){
         pvk_in_f = (f);
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_f);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::PxFlags<enumtype, storagetype>::b
    // NATIVE SIG: PX_INLINE explicit PxFlags(storagetype b)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L84~84
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( b){
        auto nat_in_b = (b);
        self->PxFlags<enumtype, storagetype>(nat_in_b);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( b);
    
    public PxFlags<enumtype, storagetype>( b){
         pvk_in_b = (b);
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_b);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isSet                                                                  #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxFlags::isSet::e
    // NATIVE SIG: bool isSet(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L86~86
    #if NATIVE
    ES bool W_isSet(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->isSet(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSet(PxFlags selfPtr,  e);
    
    public bool isSet( e){
         pvk_in_e = (e);
        bool retVal = W_isSet(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       set                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Unresolved parameter type physx::PxFlags::set::e
    // NATIVE SIG: PxFlags<enumtype, storagetype>& set(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L87~87
    #if NATIVE
    ES UNPARSED_TYPE W_set(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->set(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_set(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE set( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_set(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxFlags::operator==::e
    // NATIVE SIG: bool operator==(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L88~88
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator==(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxFlags selfPtr,  e);
    
    public static bool operator==(PxFlags lhs,  e){
         pvk_in_e = (e);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool operator==(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L89~89
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator==(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxFlags selfPtr,  f);
    
    public static bool operator==(PxFlags lhs,  f){
         pvk_in_f = (f);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L90~90
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxFlags* self, bool b){
        auto nat_in_b = (b);
        auto retVal = self->operator==(nat_in_b);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxFlags selfPtr, bool b);
    
    public static bool operator==(PxFlags lhs, bool b){
        bool pvk_in_b = (b);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_b);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxFlags::operator!=::e
    // NATIVE SIG: bool operator!=(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L91~91
    #if NATIVE
    ES bool W_OP_ExclaimEqual(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator!=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual(PxFlags selfPtr,  e);
    
    public static bool operator!=(PxFlags lhs,  e){
         pvk_in_e = (e);
        bool retVal = W_OP_ExclaimEqual(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool operator!=(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L92~92
    #if NATIVE
    ES bool W_OP_ExclaimEqual(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator!=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual(PxFlags selfPtr,  f);
    
    public static bool operator!=(PxFlags lhs,  f){
         pvk_in_f = (f);
        bool retVal = W_OP_ExclaimEqual(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator=(const PxFlags<enumtype, storagetype>& f)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L94~94
    #if NATIVE
    ES UNPARSED_TYPE W_operator=(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator=(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator=(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_operator=(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    Unresolved parameter type physx::PxFlags::operator=::e
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator=(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L95~95
    #if NATIVE
    ES UNPARSED_TYPE W_operator=(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator=(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator=(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_operator=(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|=                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    Unresolved parameter type physx::PxFlags::operator|=::e
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator|=(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L97~97
    #if NATIVE
    ES UNPARSED_TYPE W_operator|=(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator|=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator|=(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator|=(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_operator|=(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|=                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator|=(const PxFlags<enumtype, storagetype>& f)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L98~98
    #if NATIVE
    ES UNPARSED_TYPE W_operator|=(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator|=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator|=(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator|=(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_operator|=(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::operator|::e
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator|(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L99~99
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Pipe(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator|(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Pipe(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator|(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Pipe(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator|(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L100~100
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Pipe(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator|(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Pipe(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator|(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Pipe(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&=                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    Unresolved parameter type physx::PxFlags::operator&=::e
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator&=(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L102~102
    #if NATIVE
    ES UNPARSED_TYPE W_operator&=(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator&=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator&=(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator&=(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_operator&=(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&=                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator&=(const PxFlags<enumtype, storagetype>& f)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L103~103
    #if NATIVE
    ES UNPARSED_TYPE W_operator&=(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator&=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator&=(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator&=(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_operator&=(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::operator&::e
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L104~104
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Amp(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator&(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Amp(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator&(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Amp(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator&(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L105~105
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Amp(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator&(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Amp(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator&(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Amp(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^=                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    Unresolved parameter type physx::PxFlags::operator^=::e
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator^=(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L107~107
    #if NATIVE
    ES UNPARSED_TYPE W_operator^=(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator^=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator^=(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator^=(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_operator^=(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^=                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype>& operator^=(const PxFlags<enumtype, storagetype>& f)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L108~108
    #if NATIVE
    ES UNPARSED_TYPE W_operator^=(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator^=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator^=(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator^=(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_operator^=(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxFlags::operator^::e
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator^(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L109~109
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Caret(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator^(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Caret(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator^(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Caret(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator^(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L110~110
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Caret(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator^(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Caret(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator^(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Caret(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator~                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator~(void) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L112~112
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Tilde(physx::PxFlags* self){
        auto retVal = self->operator~();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Tilde(PxFlags selfPtr);
    
    public static UNPARSED_TYPE operator~(PxFlags lhs){
        UNPARSED_TYPE retVal = W_OP_Tilde(lhs);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator bool                                                          #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: bool(void) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L114~114
    #if NATIVE
    ES bool W_operator bool(physx::PxFlags* self){
        auto retVal = self->operator bool();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_operator bool(PxFlags selfPtr);
    
    public static bool operator bool(PxFlags lhs){
        bool retVal = W_operator bool(lhs);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator unsigned char                                                 #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: uint8_t(void) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L115~115
    #if NATIVE
    ES ::uint8_t W_operator unsigned char(physx::PxFlags* self){
        auto retVal = self->operator unsigned char();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte W_operator unsigned char(PxFlags selfPtr);
    
    public static byte operator unsigned char(PxFlags lhs){
        byte retVal = W_operator unsigned char(lhs);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator unsigned short                                                #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: uint16_t(void) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L116~116
    #if NATIVE
    ES ::uint16_t W_operator unsigned short(physx::PxFlags* self){
        auto retVal = self->operator unsigned short();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_operator unsigned short(PxFlags selfPtr);
    
    public static ushort operator unsigned short(PxFlags lhs){
        ushort retVal = W_operator unsigned short(lhs);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator unsigned int                                                  #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: uint32_t(void) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L117~117
    #if NATIVE
    ES ::uint32_t W_operator unsigned int(physx::PxFlags* self){
        auto retVal = self->operator unsigned int();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_operator unsigned int(PxFlags selfPtr);
    
    public static uint operator unsigned int(PxFlags lhs){
        uint retVal = W_operator unsigned int(lhs);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       clear                                                                  #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxFlags::clear::e
    // NATIVE SIG: void clear(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L119~119
    #if NATIVE
    ES void W_clear(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        self->clear(nat_in_e);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clear(PxFlags selfPtr,  e);
    
    public void clear( e){
         pvk_in_e = (e);
        W_clear(this, pvk_in_e);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
