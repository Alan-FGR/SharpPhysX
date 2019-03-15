#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxConvexMeshGeometryFlag : int {
     eTIGHT_BOUNDS = (1<<0),
}
#endif

public partial struct PxConvexMeshGeometry {

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L67~67
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxConvexMeshGeometryFlag::Enum a, physx::PxConvexMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b);

public static UNPARSED_TYPE operator|(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    PxConvexMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L67~67
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxConvexMeshGeometryFlag::Enum a, physx::PxConvexMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b);

public static UNPARSED_TYPE operator&(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    PxConvexMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L67~67
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxConvexMeshGeometryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxConvexMeshGeometryFlag a);

public static UNPARSED_TYPE operator~(PxConvexMeshGeometryFlag a){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

} // End PxConvexMeshGeometry


#if !NATIVE
public unsafe partial struct PxConvexMeshGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxConvexMeshGeometry() :
    		PxGeometry	(PxGeometryType::eCONVEXMESH),
    		scale		(PxMeshScale(1.0f)),
    		convexMesh	(NULL),
    		meshFlags	(PxConvexMeshGeometryFlag::eTIGHT_BOUNDS)
    	{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L88~93
    #if NATIVE
    ES UNPARSED_TYPE W_PxConvexMeshGeometry_ctor(){
        self->PxConvexMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConvexMeshGeometry_ctor();
    
    public PxConvexMeshGeometry(){
        var _new = W_PxConvexMeshGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxConvexMeshGeometry::PxConvexMeshGeometry::flags
    // NATIVE SIG: PX_INLINE PxConvexMeshGeometry(	PxConvexMesh* mesh, 
    									const PxMeshScale& scaling = PxMeshScale(),
    									PxConvexMeshGeometryFlags flags = PxConvexMeshGeometryFlag::eTIGHT_BOUNDS) :
    		PxGeometry	(PxGeometryType::eCONVEXMESH),
    		scale		(scaling),
    		convexMesh	(mesh),
    		meshFlags	(flags)
    	{
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L102~110
    #if NATIVE
    ES UNPARSED_TYPE W_PxConvexMeshGeometry_ctor(physx::PxConvexMesh* mesh, physx::PxMeshScale* scaling,  flags){
        auto nat_in_mesh = (mesh);
        auto nat_in_scaling = (scaling);
        auto nat_in_flags = (flags);
        self->PxConvexMeshGeometry(nat_in_mesh, *nat_in_scaling, nat_in_flags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConvexMeshGeometry_ctor(PxConvexMesh mesh, PxMeshScale scaling,  flags);
    
    public PxConvexMeshGeometry(PxConvexMesh mesh, PxMeshScale scaling,  flags){
        PxConvexMesh pvk_in_mesh = (mesh);
        PxMeshScale pvk_in_scaling = (scaling);
         pvk_in_flags = (flags);
        var _new = W_PxConvexMeshGeometry_ctor(pvk_in_mesh, pvk_in_scaling, pvk_in_flags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L122~122
    #if NATIVE
    ES bool W_isValid(physx::PxConvexMeshGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxConvexMeshGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES UNPARSED_TYPE W_PxConvexMeshGeometry_ctor(physx::PxConvexMeshGeometry* ){
        auto nat_in_ = ();
        self->PxConvexMeshGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConvexMeshGeometry_ctor(PxConvexMeshGeometry );
    
    public PxConvexMeshGeometry(PxConvexMeshGeometry ){
        PxConvexMeshGeometry pvk_in_ = ();
        var _new = W_PxConvexMeshGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES UNPARSED_TYPE W_PxConvexMeshGeometry_ctor(physx::PxConvexMeshGeometry* ){
        auto nat_in_ = ();
        self->PxConvexMeshGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConvexMeshGeometry_ctor(PxConvexMeshGeometry );
    
    public PxConvexMeshGeometry(PxConvexMeshGeometry ){
        PxConvexMeshGeometry pvk_in_ = ();
        var _new = W_PxConvexMeshGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES physx::PxConvexMeshGeometry* W_operator=(physx::PxConvexMeshGeometry* self, physx::PxConvexMeshGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometry W_operator=(PxConvexMeshGeometry selfPtr, PxConvexMeshGeometry );
    
    public static PxConvexMeshGeometry operator=(PxConvexMeshGeometry lhs, PxConvexMeshGeometry ){
        PxConvexMeshGeometry pvk_in_ = ();
        PxConvexMeshGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES physx::PxConvexMeshGeometry* W_operator=(physx::PxConvexMeshGeometry* self, physx::PxConvexMeshGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometry W_operator=(PxConvexMeshGeometry selfPtr, PxConvexMeshGeometry );
    
    public static PxConvexMeshGeometry operator=(PxConvexMeshGeometry lhs, PxConvexMeshGeometry ){
        PxConvexMeshGeometry pvk_in_ = ();
        PxConvexMeshGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConvexMeshGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxConvexMeshGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES void W_~PxConvexMeshGeometry(physx::PxConvexMeshGeometry* self){
        self->~PxConvexMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConvexMeshGeometry(PxConvexMeshGeometry selfPtr);
    
    public void ~PxConvexMeshGeometry(){
        W_~PxConvexMeshGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxConvexMeshGeometryFlag { // blittable

#endif

    //================================================================================
    //#       PxConvexMeshGeometryFlag                                               #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag W_PxConvexMeshGeometryFlag_ctor(){
        self.PxConvexMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag W_PxConvexMeshGeometryFlag_ctor();
    
    public PxConvexMeshGeometryFlag(){
        var _new = W_PxConvexMeshGeometryFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometryFlag                                               #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag W_PxConvexMeshGeometryFlag_ctor(physx::PxConvexMeshGeometryFlag ){
        auto nat_in_ = ();
        self.PxConvexMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag W_PxConvexMeshGeometryFlag_ctor(PxConvexMeshGeometryFlag );
    
    public PxConvexMeshGeometryFlag(PxConvexMeshGeometryFlag ){
        PxConvexMeshGeometryFlag pvk_in_ = ();
        var _new = W_PxConvexMeshGeometryFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag* W_operator=(physx::PxConvexMeshGeometryFlag self, physx::PxConvexMeshGeometryFlag ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag W_operator=(PxConvexMeshGeometryFlag selfBlt, PxConvexMeshGeometryFlag );
    
    public static PxConvexMeshGeometryFlag operator=(PxConvexMeshGeometryFlag lhs, PxConvexMeshGeometryFlag ){
        PxConvexMeshGeometryFlag pvk_in_ = ();
        PxConvexMeshGeometryFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometryFlag                                               #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxConvexMeshGeometryFlag
    // NATIVE SIG: PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag W_PxConvexMeshGeometryFlag_ctor( ){
        auto nat_in_ = ();
        self.PxConvexMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag W_PxConvexMeshGeometryFlag_ctor( );
    
    public PxConvexMeshGeometryFlag( ){
         pvk_in_ = ();
        var _new = W_PxConvexMeshGeometryFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxConvexMeshGeometryFlag
    // NATIVE SIG: PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag* W_operator=(physx::PxConvexMeshGeometryFlag self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag W_operator=(PxConvexMeshGeometryFlag selfBlt);
    
    public static PxConvexMeshGeometryFlag operator=(PxConvexMeshGeometryFlag lhs,  ){
         pvk_in_ = ();
        PxConvexMeshGeometryFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConvexMeshGeometryFlag                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES void W_~PxConvexMeshGeometryFlag(physx::PxConvexMeshGeometryFlag self){
        self.~PxConvexMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConvexMeshGeometryFlag(PxConvexMeshGeometryFlag selfBlt);
    
    public void ~PxConvexMeshGeometryFlag(){
        W_~PxConvexMeshGeometryFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
