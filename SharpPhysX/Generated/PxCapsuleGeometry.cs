#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxCapsuleGeometry {

//================================================================================
//#       PxTransformFromSegment                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L113~113
#if NATIVE
ES physx::PxTransform W_PxTransformFromSegment(physx::PxVec3 p0, physx::PxVec3 p1, physx::PxReal* halfHeight){
    auto nat_in_p0 = (p0);
    auto nat_in_p1 = (p1);
    auto nat_in_halfHeight = (halfHeight);
    auto retVal = physx::PxTransformFromSegment(nat_in_p0, nat_in_p1, nat_in_halfHeight);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxTransform W_PxTransformFromSegment(PxVec3 p0, PxVec3 p1, float* halfHeight);

public static PxTransform PxTransformFromSegment(PxVec3 p0, PxVec3 p1, float* halfHeight){
    PxVec3 pvk_in_p0 = (p0);
    PxVec3 pvk_in_p1 = (p1);
    float* pvk_in_halfHeight = (halfHeight);
    PxTransform retVal = W_PxTransformFromSegment(pvk_in_p0, pvk_in_p1, pvk_in_halfHeight);
    return retVal;
}
#endif

} // End PxCapsuleGeometry


#if !NATIVE
public unsafe partial struct PxCapsuleGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxCapsuleGeometry() :						PxGeometry(PxGeometryType::eCAPSULE), radius(0), halfHeight(0)		{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L60~60
    #if NATIVE
    ES UNPARSED_TYPE W_PxCapsuleGeometry_ctor(){
        self->PxCapsuleGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxCapsuleGeometry_ctor();
    
    public PxCapsuleGeometry(){
        var _new = W_PxCapsuleGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PX_INLINE PxCapsuleGeometry(PxReal radius_, PxReal halfHeight_) :	PxGeometry(PxGeometryType::eCAPSULE), radius(radius_), halfHeight(halfHeight_)	{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L65~65
    #if NATIVE
    ES UNPARSED_TYPE W_PxCapsuleGeometry_ctor(physx::PxReal radius_, physx::PxReal halfHeight_){
        auto nat_in_radius_ = (radius_);
        auto nat_in_halfHeight_ = (halfHeight_);
        self->PxCapsuleGeometry(nat_in_radius_, nat_in_halfHeight_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxCapsuleGeometry_ctor(float radius_, float halfHeight_);
    
    public PxCapsuleGeometry(float radius_, float halfHeight_){
        float pvk_in_radius_ = (radius_);
        float pvk_in_halfHeight_ = (halfHeight_);
        var _new = W_PxCapsuleGeometry_ctor(pvk_in_radius_, pvk_in_halfHeight_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L77~77
    #if NATIVE
    ES bool W_isValid(physx::PxCapsuleGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxCapsuleGeometry selfPtr);
    
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
    // NATIVE SIG: PxCapsuleGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES physx::PxCapsuleGeometry* W_operator=(physx::PxCapsuleGeometry* self, physx::PxCapsuleGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_operator=(PxCapsuleGeometry selfPtr, PxCapsuleGeometry );
    
    public static PxCapsuleGeometry operator=(PxCapsuleGeometry lhs, PxCapsuleGeometry ){
        PxCapsuleGeometry pvk_in_ = ();
        PxCapsuleGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxCapsuleGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES physx::PxCapsuleGeometry* W_operator=(physx::PxCapsuleGeometry* self, physx::PxCapsuleGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_operator=(PxCapsuleGeometry selfPtr, PxCapsuleGeometry );
    
    public static PxCapsuleGeometry operator=(PxCapsuleGeometry lhs, PxCapsuleGeometry ){
        PxCapsuleGeometry pvk_in_ = ();
        PxCapsuleGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxCapsuleGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE W_PxCapsuleGeometry_ctor(physx::PxCapsuleGeometry* ){
        auto nat_in_ = ();
        self->PxCapsuleGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxCapsuleGeometry_ctor(PxCapsuleGeometry );
    
    public PxCapsuleGeometry(PxCapsuleGeometry ){
        PxCapsuleGeometry pvk_in_ = ();
        var _new = W_PxCapsuleGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxCapsuleGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES UNPARSED_TYPE W_PxCapsuleGeometry_ctor(physx::PxCapsuleGeometry* ){
        auto nat_in_ = ();
        self->PxCapsuleGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxCapsuleGeometry_ctor(PxCapsuleGeometry );
    
    public PxCapsuleGeometry(PxCapsuleGeometry ){
        PxCapsuleGeometry pvk_in_ = ();
        var _new = W_PxCapsuleGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxCapsuleGeometry                                                     #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxCapsuleGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxCapsuleGeometry.h L54~54
    #if NATIVE
    ES void W_~PxCapsuleGeometry(physx::PxCapsuleGeometry* self){
        self->~PxCapsuleGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxCapsuleGeometry(PxCapsuleGeometry selfPtr);
    
    public void ~PxCapsuleGeometry(){
        W_~PxCapsuleGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
