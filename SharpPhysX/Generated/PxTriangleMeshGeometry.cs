#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxMeshGeometryFlag : int {
     eDOUBLE_SIDED = (1<<1),
}
#endif

public partial struct PxTriangleMeshGeometry {

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L69~69
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxMeshGeometryFlag::Enum a, physx::PxMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxMeshGeometryFlag a, PxMeshGeometryFlag b);

public static UNPARSED_TYPE operator|(PxMeshGeometryFlag a, PxMeshGeometryFlag b){
    PxMeshGeometryFlag pvk_in_a = (a);
    PxMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L69~69
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxMeshGeometryFlag::Enum a, physx::PxMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxMeshGeometryFlag a, PxMeshGeometryFlag b);

public static UNPARSED_TYPE operator&(PxMeshGeometryFlag a, PxMeshGeometryFlag b){
    PxMeshGeometryFlag pvk_in_a = (a);
    PxMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L69~69
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxMeshGeometryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxMeshGeometryFlag a);

public static UNPARSED_TYPE operator~(PxMeshGeometryFlag a){
    PxMeshGeometryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

} // End PxTriangleMeshGeometry



#if !NATIVE
public unsafe partial struct PxTriangleMeshGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxTriangleMeshGeometry() : 
    		PxGeometry	(PxGeometryType::eTRIANGLEMESH), 
    		triangleMesh(NULL)
    	{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L90~93
    #if NATIVE
    ES UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor(){
        self->PxTriangleMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor();
    
    public PxTriangleMeshGeometry(){
        var _new = W_PxTriangleMeshGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry::flags
    // NATIVE SIG: PX_INLINE PxTriangleMeshGeometry(	PxTriangleMesh* mesh, 
    										const PxMeshScale& scaling = PxMeshScale(), 
    										PxMeshGeometryFlags flags = PxMeshGeometryFlags()) :
    		PxGeometry	(PxGeometryType::eTRIANGLEMESH), 
    		scale		(scaling), 
    		meshFlags	(flags), 
    		triangleMesh(mesh) 
    	{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L102~109
    #if NATIVE
    ES UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor(physx::PxTriangleMesh* mesh, physx::PxMeshScale* scaling,  flags){
        auto nat_in_mesh = (mesh);
        auto nat_in_scaling = (scaling);
        auto nat_in_flags = (flags);
        self->PxTriangleMeshGeometry(nat_in_mesh, *nat_in_scaling, nat_in_flags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor(PxTriangleMesh mesh, PxMeshScale scaling,  flags);
    
    public PxTriangleMeshGeometry(PxTriangleMesh mesh, PxMeshScale scaling,  flags){
        PxTriangleMesh pvk_in_mesh = (mesh);
        PxMeshScale pvk_in_scaling = (scaling);
         pvk_in_flags = (flags);
        var _new = W_PxTriangleMeshGeometry_ctor(pvk_in_mesh, pvk_in_scaling, pvk_in_flags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L121~121
    #if NATIVE
    ES bool W_isValid(physx::PxTriangleMeshGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxTriangleMeshGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxTriangleMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor(physx::PxTriangleMeshGeometry* ){
        auto nat_in_ = ();
        self->PxTriangleMeshGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor(PxTriangleMeshGeometry );
    
    public PxTriangleMeshGeometry(PxTriangleMeshGeometry ){
        PxTriangleMeshGeometry pvk_in_ = ();
        var _new = W_PxTriangleMeshGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxTriangleMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor(physx::PxTriangleMeshGeometry* ){
        auto nat_in_ = ();
        self->PxTriangleMeshGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxTriangleMeshGeometry_ctor(PxTriangleMeshGeometry );
    
    public PxTriangleMeshGeometry(PxTriangleMeshGeometry ){
        PxTriangleMeshGeometry pvk_in_ = ();
        var _new = W_PxTriangleMeshGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxTriangleMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES physx::PxTriangleMeshGeometry* W_operator=(physx::PxTriangleMeshGeometry* self, physx::PxTriangleMeshGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometry W_operator=(PxTriangleMeshGeometry selfPtr, PxTriangleMeshGeometry );
    
    public static PxTriangleMeshGeometry operator=(PxTriangleMeshGeometry lhs, PxTriangleMeshGeometry ){
        PxTriangleMeshGeometry pvk_in_ = ();
        PxTriangleMeshGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxTriangleMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES physx::PxTriangleMeshGeometry* W_operator=(physx::PxTriangleMeshGeometry* self, physx::PxTriangleMeshGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometry W_operator=(PxTriangleMeshGeometry selfPtr, PxTriangleMeshGeometry );
    
    public static PxTriangleMeshGeometry operator=(PxTriangleMeshGeometry lhs, PxTriangleMeshGeometry ){
        PxTriangleMeshGeometry pvk_in_ = ();
        PxTriangleMeshGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxTriangleMeshGeometry                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxTriangleMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES void W_~PxTriangleMeshGeometry(physx::PxTriangleMeshGeometry* self){
        self->~PxTriangleMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxTriangleMeshGeometry(PxTriangleMeshGeometry selfPtr);
    
    public void ~PxTriangleMeshGeometry(){
        W_~PxTriangleMeshGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxMeshGeometryFlag { // blittable

#endif

    //================================================================================
    //#       PxMeshGeometryFlag                                                     #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag W_PxMeshGeometryFlag_ctor(){
        self.PxMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag W_PxMeshGeometryFlag_ctor();
    
    public PxMeshGeometryFlag(){
        var _new = W_PxMeshGeometryFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshGeometryFlag                                                     #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag W_PxMeshGeometryFlag_ctor(physx::PxMeshGeometryFlag ){
        auto nat_in_ = ();
        self.PxMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag W_PxMeshGeometryFlag_ctor(PxMeshGeometryFlag );
    
    public PxMeshGeometryFlag(PxMeshGeometryFlag ){
        PxMeshGeometryFlag pvk_in_ = ();
        var _new = W_PxMeshGeometryFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag* W_operator=(physx::PxMeshGeometryFlag self, physx::PxMeshGeometryFlag ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag W_operator=(PxMeshGeometryFlag selfBlt, PxMeshGeometryFlag );
    
    public static PxMeshGeometryFlag operator=(PxMeshGeometryFlag lhs, PxMeshGeometryFlag ){
        PxMeshGeometryFlag pvk_in_ = ();
        PxMeshGeometryFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshGeometryFlag                                                     #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxMeshGeometryFlag
    // NATIVE SIG: PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag W_PxMeshGeometryFlag_ctor( ){
        auto nat_in_ = ();
        self.PxMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag W_PxMeshGeometryFlag_ctor( );
    
    public PxMeshGeometryFlag( ){
         pvk_in_ = ();
        var _new = W_PxMeshGeometryFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxMeshGeometryFlag
    // NATIVE SIG: PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag* W_operator=(physx::PxMeshGeometryFlag self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag W_operator=(PxMeshGeometryFlag selfBlt);
    
    public static PxMeshGeometryFlag operator=(PxMeshGeometryFlag lhs,  ){
         pvk_in_ = ();
        PxMeshGeometryFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxMeshGeometryFlag                                                    #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES void W_~PxMeshGeometryFlag(physx::PxMeshGeometryFlag self){
        self.~PxMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxMeshGeometryFlag(PxMeshGeometryFlag selfBlt);
    
    public void ~PxMeshGeometryFlag(){
        W_~PxMeshGeometryFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
