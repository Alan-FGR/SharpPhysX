#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxSphereGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxSphereGeometry() :							PxGeometry(PxGeometryType::eSPHERE), radius(0) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L52~52
    #if NATIVE
    ES UNPARSED_TYPE W_PxSphereGeometry_ctor(){
        self->PxSphereGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxSphereGeometry_ctor();
    
    public PxSphereGeometry(){
        var _new = W_PxSphereGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PX_INLINE PxSphereGeometry(PxReal ir) :					PxGeometry(PxGeometryType::eSPHERE), radius(ir) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE W_PxSphereGeometry_ctor(physx::PxReal ir){
        auto nat_in_ir = (ir);
        self->PxSphereGeometry(nat_in_ir);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxSphereGeometry_ctor(float ir);
    
    public PxSphereGeometry(float ir){
        float pvk_in_ir = (ir);
        var _new = W_PxSphereGeometry_ctor(pvk_in_ir);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L65~65
    #if NATIVE
    ES bool W_isValid(physx::PxSphereGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxSphereGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxSphereGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES physx::PxSphereGeometry* W_operator=(physx::PxSphereGeometry* self, physx::PxSphereGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_operator=(PxSphereGeometry selfPtr, PxSphereGeometry );
    
    public static PxSphereGeometry operator=(PxSphereGeometry lhs, PxSphereGeometry ){
        PxSphereGeometry pvk_in_ = ();
        PxSphereGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxSphereGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES physx::PxSphereGeometry* W_operator=(physx::PxSphereGeometry* self, physx::PxSphereGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_operator=(PxSphereGeometry selfPtr, PxSphereGeometry );
    
    public static PxSphereGeometry operator=(PxSphereGeometry lhs, PxSphereGeometry ){
        PxSphereGeometry pvk_in_ = ();
        PxSphereGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxSphereGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES UNPARSED_TYPE W_PxSphereGeometry_ctor(physx::PxSphereGeometry* ){
        auto nat_in_ = ();
        self->PxSphereGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxSphereGeometry_ctor(PxSphereGeometry );
    
    public PxSphereGeometry(PxSphereGeometry ){
        PxSphereGeometry pvk_in_ = ();
        var _new = W_PxSphereGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxSphereGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES UNPARSED_TYPE W_PxSphereGeometry_ctor(physx::PxSphereGeometry* ){
        auto nat_in_ = ();
        self->PxSphereGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxSphereGeometry_ctor(PxSphereGeometry );
    
    public PxSphereGeometry(PxSphereGeometry ){
        PxSphereGeometry pvk_in_ = ();
        var _new = W_PxSphereGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxSphereGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxSphereGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxSphereGeometry.h L49~49
    #if NATIVE
    ES void W_~PxSphereGeometry(physx::PxSphereGeometry* self){
        self->~PxSphereGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxSphereGeometry(PxSphereGeometry selfPtr);
    
    public void ~PxSphereGeometry(){
        W_~PxSphereGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
