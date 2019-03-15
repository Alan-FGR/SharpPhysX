#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxDeletionEventFlag : int {
     eUSER_RELEASE					= (1<<0),
     eMEMORY_RELEASE					= (1<<1),
}
#endif

public partial struct PxDeletionListener {

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L66~66
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxDeletionEventFlag::Enum a, physx::PxDeletionEventFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxDeletionEventFlag a, PxDeletionEventFlag b);

public static UNPARSED_TYPE operator|(PxDeletionEventFlag a, PxDeletionEventFlag b){
    PxDeletionEventFlag pvk_in_a = (a);
    PxDeletionEventFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L66~66
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxDeletionEventFlag::Enum a, physx::PxDeletionEventFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxDeletionEventFlag a, PxDeletionEventFlag b);

public static UNPARSED_TYPE operator&(PxDeletionEventFlag a, PxDeletionEventFlag b){
    PxDeletionEventFlag pvk_in_a = (a);
    PxDeletionEventFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L66~66
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxDeletionEventFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxDeletionEventFlag a);

public static UNPARSED_TYPE operator~(PxDeletionEventFlag a){
    PxDeletionEventFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

} // End PxDeletionListener


#if !NATIVE
public unsafe partial struct PxDeletionListener { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       onRelease                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L93~93
    #if NATIVE
    ES void W_onRelease(physx::PxDeletionListener* self, physx::PxBase* observed, void* userData, physx::PxDeletionEventFlag::Enum deletionEvent){
        auto nat_in_observed = (observed);
        auto nat_in_userData = (userData);
        auto nat_in_deletionEvent = (deletionEvent);
        self->onRelease(nat_in_observed, nat_in_userData, nat_in_deletionEvent);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_onRelease(PxDeletionListener selfPtr, PxBase observed, global::System.IntPtr userData, PxDeletionEventFlag deletionEvent);
    
    public void onRelease(PxBase observed, global::System.IntPtr userData, PxDeletionEventFlag deletionEvent){
        PxBase pvk_in_observed = (observed);
        global::System.IntPtr pvk_in_userData = (userData);
        PxDeletionEventFlag pvk_in_deletionEvent = (deletionEvent);
        W_onRelease(this, pvk_in_observed, pvk_in_userData, pvk_in_deletionEvent);
    }
    #endif
    
    
    //================================================================================
    //#       PxDeletionListener                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PxDeletionListener() {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L96~96
    #if NATIVE
    ES UNPARSED_TYPE W_PxDeletionListener_ctor(){
        self->PxDeletionListener();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxDeletionListener_ctor();
    
    public PxDeletionListener(){
        var _new = W_PxDeletionListener_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxDeletionListener                                                    #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxDeletionListener() {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L97~97
    #if NATIVE
    ES void W_~PxDeletionListener(physx::PxDeletionListener* self){
        self->~PxDeletionListener();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxDeletionListener(PxDeletionListener selfPtr);
    
    public void ~PxDeletionListener(){
        W_~PxDeletionListener(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxDeletionListener
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L73~73
    #if NATIVE
    ES physx::PxDeletionListener* W_operator=(physx::PxDeletionListener* self, physx::PxDeletionListener* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionListener W_operator=(PxDeletionListener selfPtr, PxDeletionListener );
    
    public static PxDeletionListener operator=(PxDeletionListener lhs, PxDeletionListener ){
        PxDeletionListener pvk_in_ = ();
        PxDeletionListener retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeletionListener                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxDeletionListener
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L73~73
    #if NATIVE
    ES UNPARSED_TYPE W_PxDeletionListener_ctor(physx::PxDeletionListener* ){
        auto nat_in_ = ();
        self->PxDeletionListener(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxDeletionListener_ctor(PxDeletionListener );
    
    public PxDeletionListener(PxDeletionListener ){
        PxDeletionListener pvk_in_ = ();
        var _new = W_PxDeletionListener_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxDeletionEventFlag { // blittable

#endif

    //================================================================================
    //#       PxDeletionEventFlag                                                    #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag W_PxDeletionEventFlag_ctor(){
        self.PxDeletionEventFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag W_PxDeletionEventFlag_ctor();
    
    public PxDeletionEventFlag(){
        var _new = W_PxDeletionEventFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeletionEventFlag                                                    #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag W_PxDeletionEventFlag_ctor(physx::PxDeletionEventFlag ){
        auto nat_in_ = ();
        self.PxDeletionEventFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag W_PxDeletionEventFlag_ctor(PxDeletionEventFlag );
    
    public PxDeletionEventFlag(PxDeletionEventFlag ){
        PxDeletionEventFlag pvk_in_ = ();
        var _new = W_PxDeletionEventFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag* W_operator=(physx::PxDeletionEventFlag self, physx::PxDeletionEventFlag ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag W_operator=(PxDeletionEventFlag selfBlt, PxDeletionEventFlag );
    
    public static PxDeletionEventFlag operator=(PxDeletionEventFlag lhs, PxDeletionEventFlag ){
        PxDeletionEventFlag pvk_in_ = ();
        PxDeletionEventFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeletionEventFlag                                                    #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxDeletionEventFlag
    // NATIVE SIG: PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag W_PxDeletionEventFlag_ctor( ){
        auto nat_in_ = ();
        self.PxDeletionEventFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag W_PxDeletionEventFlag_ctor( );
    
    public PxDeletionEventFlag( ){
         pvk_in_ = ();
        var _new = W_PxDeletionEventFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxDeletionEventFlag
    // NATIVE SIG: PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag* W_operator=(physx::PxDeletionEventFlag self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag W_operator=(PxDeletionEventFlag selfBlt);
    
    public static PxDeletionEventFlag operator=(PxDeletionEventFlag lhs,  ){
         pvk_in_ = ();
        PxDeletionEventFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxDeletionEventFlag                                                   #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES void W_~PxDeletionEventFlag(physx::PxDeletionEventFlag self){
        self.~PxDeletionEventFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxDeletionEventFlag(PxDeletionEventFlag selfBlt);
    
    public void ~PxDeletionEventFlag(){
        W_~PxDeletionEventFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
