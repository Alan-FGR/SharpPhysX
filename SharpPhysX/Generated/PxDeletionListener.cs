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

#if !NATIVE
public unsafe partial struct PxDeletionListener { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       onRelease                                                              #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    , Non const pointer/reference global::System.IntPtr
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L93~93
    #if NATIVE
    ES void onRelease(physx::PxDeletionListener* self,  observed,  userData, physx::PxDeletionEventFlag::Enum deletionEvent){
         nat_in_observed = (observed);
         nat_in_userData = (userData);
        physx::PxDeletionEventFlag::Enum nat_in_deletionEvent = (deletionEvent);
        self->onRelease(nat_in_observed, nat_in_userData, nat_in_deletionEvent);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void onRelease(PxDeletionListener selfPtr,  observed,  userData, PxDeletionEventFlag deletionEvent);
    
    public void onRelease( observed,  userData, PxDeletionEventFlag deletionEvent){
         pvk_in_observed = (observed);
         pvk_in_userData = (userData);
        PxDeletionEventFlag pvk_in_deletionEvent = (deletionEvent);
        onRelease(this, pvk_in_observed, pvk_in_userData, pvk_in_deletionEvent);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeletionListener                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L96~96
    #if NATIVE
    ES UNPARSED_TYPE PxDeletionListener_ctor(){
        self->PxDeletionListener();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxDeletionListener_ctor();
    
    public PxDeletionListener(){
        var _new = PxDeletionListener_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxDeletionListener                                                    #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L97~97
    #if NATIVE
    ES void ~PxDeletionListener(physx::PxDeletionListener* self){
        self->~PxDeletionListener();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxDeletionListener(PxDeletionListener selfPtr);
    
    public void ~PxDeletionListener(){
        ~PxDeletionListener(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L73~73
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxDeletionListener* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxDeletionListener selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeletionListener                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L73~73
    #if NATIVE
    ES UNPARSED_TYPE PxDeletionListener_ctor( ){
         nat_in_ = ();
        self->PxDeletionListener(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxDeletionListener_ctor( );
    
    public PxDeletionListener( ){
         pvk_in_ = ();
        var _new = PxDeletionListener_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag PxDeletionEventFlag_ctor(){
        self.PxDeletionEventFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag PxDeletionEventFlag_ctor();
    
    public PxDeletionEventFlag(){
        var _new = PxDeletionEventFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeletionEventFlag                                                    #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag PxDeletionEventFlag_ctor(physx::PxDeletionEventFlag ){
        physx::PxDeletionEventFlag nat_in_ = ();
        self.PxDeletionEventFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag PxDeletionEventFlag_ctor(PxDeletionEventFlag );
    
    public PxDeletionEventFlag(PxDeletionEventFlag ){
        PxDeletionEventFlag pvk_in_ = ();
        var _new = PxDeletionEventFlag_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxDeletionEventFlag self, physx::PxDeletionEventFlag ){
        physx::PxDeletionEventFlag nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxDeletionEventFlag selfBlt, PxDeletionEventFlag );
    
    public UNPARSED_TYPE operator=(PxDeletionEventFlag ){
        PxDeletionEventFlag pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeletionEventFlag                                                    #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES physx::PxDeletionEventFlag PxDeletionEventFlag_ctor( ){
         nat_in_ = ();
        self.PxDeletionEventFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxDeletionEventFlag PxDeletionEventFlag_ctor( );
    
    public PxDeletionEventFlag( ){
         pvk_in_ = ();
        var _new = PxDeletionEventFlag_ctor(pvk_in_);
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
    Non const pointer/reference global::PhysX.physx.PxDeletionEventFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxDeletionEventFlag self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxDeletionEventFlag selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxDeletionEventFlag                                                   #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\PxDeletionListener.h L51~51
    #if NATIVE
    ES void ~PxDeletionEventFlag(physx::PxDeletionEventFlag self){
        self.~PxDeletionEventFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxDeletionEventFlag(PxDeletionEventFlag selfBlt);
    
    public void ~PxDeletionEventFlag(){
        ~PxDeletionEventFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
