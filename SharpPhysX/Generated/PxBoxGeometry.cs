#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxBoxGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxBoxGeometry() :									PxGeometry(PxGeometryType::eBOX), halfExtents(0,0,0)		{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoxGeometry_ctor(){
        self->PxBoxGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoxGeometry_ctor();
    
    public PxBoxGeometry(){
        var _new = W_PxBoxGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PX_INLINE PxBoxGeometry(PxReal hx, PxReal hy, PxReal hz) :	PxGeometry(PxGeometryType::eBOX), halfExtents(hx, hy, hz)	{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoxGeometry_ctor(physx::PxReal hx, physx::PxReal hy, physx::PxReal hz){
        auto nat_in_hx = (hx);
        auto nat_in_hy = (hy);
        auto nat_in_hz = (hz);
        self->PxBoxGeometry(nat_in_hx, nat_in_hy, nat_in_hz);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoxGeometry_ctor(float hx, float hy, float hz);
    
    public PxBoxGeometry(float hx, float hy, float hz){
        float pvk_in_hx = (hx);
        float pvk_in_hy = (hy);
        float pvk_in_hz = (hz);
        var _new = W_PxBoxGeometry_ctor(pvk_in_hx, pvk_in_hy, pvk_in_hz);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PX_INLINE PxBoxGeometry(PxVec3 halfExtents_) :				PxGeometry(PxGeometryType::eBOX), halfExtents(halfExtents_)	{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L70~70
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoxGeometry_ctor(physx::PxVec3 halfExtents_){
        auto nat_in_halfExtents_ = (halfExtents_);
        self->PxBoxGeometry(nat_in_halfExtents_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoxGeometry_ctor(PxVec3 halfExtents_);
    
    public PxBoxGeometry(PxVec3 halfExtents_){
        PxVec3 pvk_in_halfExtents_ = (halfExtents_);
        var _new = W_PxBoxGeometry_ctor(pvk_in_halfExtents_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L82~82
    #if NATIVE
    ES bool W_isValid(physx::PxBoxGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxBoxGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoxGeometry_ctor(physx::PxBoxGeometry* ){
        auto nat_in_ = ();
        self->PxBoxGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoxGeometry_ctor(PxBoxGeometry );
    
    public PxBoxGeometry(PxBoxGeometry ){
        PxBoxGeometry pvk_in_ = ();
        var _new = W_PxBoxGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoxGeometry_ctor(physx::PxBoxGeometry* ){
        auto nat_in_ = ();
        self->PxBoxGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoxGeometry_ctor(PxBoxGeometry );
    
    public PxBoxGeometry(PxBoxGeometry ){
        PxBoxGeometry pvk_in_ = ();
        var _new = W_PxBoxGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES physx::PxBoxGeometry* W_operator=(physx::PxBoxGeometry* self, physx::PxBoxGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_operator=(PxBoxGeometry selfPtr, PxBoxGeometry );
    
    public static PxBoxGeometry operator=(PxBoxGeometry lhs, PxBoxGeometry ){
        PxBoxGeometry pvk_in_ = ();
        PxBoxGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES physx::PxBoxGeometry* W_operator=(physx::PxBoxGeometry* self, physx::PxBoxGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_operator=(PxBoxGeometry selfPtr, PxBoxGeometry );
    
    public static PxBoxGeometry operator=(PxBoxGeometry lhs, PxBoxGeometry ){
        PxBoxGeometry pvk_in_ = ();
        PxBoxGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBoxGeometry                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxBoxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxBoxGeometry.h L50~50
    #if NATIVE
    ES void W_~PxBoxGeometry(physx::PxBoxGeometry* self){
        self->~PxBoxGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBoxGeometry(PxBoxGeometry selfPtr);
    
    public void ~PxBoxGeometry(){
        W_~PxBoxGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
