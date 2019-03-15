#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxPlaneGeometry {

//================================================================================
//#       PxTransformFromPlaneEquation                                           #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L87~87
#if NATIVE
ES physx::PxTransform W_PxTransformFromPlaneEquation(physx::PxPlane* plane){
    auto nat_in_plane = (plane);
    auto retVal = physx::PxTransformFromPlaneEquation(*nat_in_plane);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxTransform W_PxTransformFromPlaneEquation(PxPlane plane);

public static PxTransform PxTransformFromPlaneEquation(PxPlane plane){
    PxPlane pvk_in_plane = (plane);
    PxTransform retVal = W_PxTransformFromPlaneEquation(pvk_in_plane);
    return retVal;
}
#endif


//================================================================================
//#       PxPlaneEquationFromTransform                                           #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: PxPlane PxPlaneEquationFromTransform(const PxTransform& transform)
{
	return transform.transform(PxPlane(1.f,0.f,0.f,0.f));
}
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L96~99
#if NATIVE
ES UNPARSED_TYPE W_PxPlaneEquationFromTransform(physx::PxTransform transform){
    auto nat_in_transform = (transform);
    auto retVal = physx::PxPlaneEquationFromTransform(nat_in_transform);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxPlaneEquationFromTransform(PxTransform transform);

public static UNPARSED_TYPE PxPlaneEquationFromTransform(PxTransform transform){
    PxTransform pvk_in_transform = (transform);
    UNPARSED_TYPE retVal = W_PxPlaneEquationFromTransform(pvk_in_transform);
    return retVal;
}
#endif*/

} // End PxPlaneGeometry


#if !NATIVE
public unsafe partial struct PxPlaneGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxPlaneGeometry                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxPlaneGeometry() :	PxGeometry(PxGeometryType::ePLANE) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L61~61
    #if NATIVE
    ES UNPARSED_TYPE W_PxPlaneGeometry_ctor(){
        self->PxPlaneGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxPlaneGeometry_ctor();
    
    public PxPlaneGeometry(){
        var _new = W_PxPlaneGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L68~68
    #if NATIVE
    ES bool W_isValid(physx::PxPlaneGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxPlaneGeometry selfPtr);
    
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
    // NATIVE SIG: PxPlaneGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES physx::PxPlaneGeometry* W_operator=(physx::PxPlaneGeometry* self, physx::PxPlaneGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometry W_operator=(PxPlaneGeometry selfPtr, PxPlaneGeometry );
    
    public static PxPlaneGeometry operator=(PxPlaneGeometry lhs, PxPlaneGeometry ){
        PxPlaneGeometry pvk_in_ = ();
        PxPlaneGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxPlaneGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES physx::PxPlaneGeometry* W_operator=(physx::PxPlaneGeometry* self, physx::PxPlaneGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometry W_operator=(PxPlaneGeometry selfPtr, PxPlaneGeometry );
    
    public static PxPlaneGeometry operator=(PxPlaneGeometry lhs, PxPlaneGeometry ){
        PxPlaneGeometry pvk_in_ = ();
        PxPlaneGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlaneGeometry                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxPlaneGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES UNPARSED_TYPE W_PxPlaneGeometry_ctor(physx::PxPlaneGeometry* ){
        auto nat_in_ = ();
        self->PxPlaneGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxPlaneGeometry_ctor(PxPlaneGeometry );
    
    public PxPlaneGeometry(PxPlaneGeometry ){
        PxPlaneGeometry pvk_in_ = ();
        var _new = W_PxPlaneGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPlaneGeometry                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxPlaneGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES UNPARSED_TYPE W_PxPlaneGeometry_ctor(physx::PxPlaneGeometry* ){
        auto nat_in_ = ();
        self->PxPlaneGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxPlaneGeometry_ctor(PxPlaneGeometry );
    
    public PxPlaneGeometry(PxPlaneGeometry ){
        PxPlaneGeometry pvk_in_ = ();
        var _new = W_PxPlaneGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxPlaneGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxPlaneGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxPlaneGeometry.h L58~58
    #if NATIVE
    ES void W_~PxPlaneGeometry(physx::PxPlaneGeometry* self){
        self->~PxPlaneGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxPlaneGeometry(PxPlaneGeometry selfPtr);
    
    public void ~PxPlaneGeometry(){
        W_~PxPlaneGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
