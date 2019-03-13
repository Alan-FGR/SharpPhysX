#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxMeshGeometryFlag : int {
     eDOUBLE_SIDED = (1<<1),
}
#endif


#if !NATIVE
public unsafe partial struct PxTriangleMeshGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L90~93
    #if NATIVE
    ES UNPARSED_TYPE PxTriangleMeshGeometry_ctor(){
        self->PxTriangleMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxTriangleMeshGeometry_ctor();
    
    public PxTriangleMeshGeometry(){
        var _new = PxTriangleMeshGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    , fsdfasdf
    , Unresolved parameter type physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry::flags
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L102~109
    #if NATIVE
    ES UNPARSED_TYPE PxTriangleMeshGeometry_ctor( mesh,  scaling,  flags){
         nat_in_mesh = (mesh);
         nat_in_scaling = (scaling);
         nat_in_flags = (flags);
        self->PxTriangleMeshGeometry(nat_in_mesh, nat_in_scaling, nat_in_flags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxTriangleMeshGeometry_ctor( mesh,  scaling,  flags);
    
    public PxTriangleMeshGeometry( mesh,  scaling,  flags){
         pvk_in_mesh = (mesh);
         pvk_in_scaling = (scaling);
         pvk_in_flags = (flags);
        var _new = PxTriangleMeshGeometry_ctor(pvk_in_mesh, pvk_in_scaling, pvk_in_flags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L121~121
    #if NATIVE
    ES bool isValid(physx::PxTriangleMeshGeometry* self){
        bool retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxTriangleMeshGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE PxTriangleMeshGeometry_ctor( ){
         nat_in_ = ();
        self->PxTriangleMeshGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxTriangleMeshGeometry_ctor( );
    
    public PxTriangleMeshGeometry( ){
         pvk_in_ = ();
        var _new = PxTriangleMeshGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxTriangleMeshGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE PxTriangleMeshGeometry_ctor( ){
         nat_in_ = ();
        self->PxTriangleMeshGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxTriangleMeshGeometry_ctor( );
    
    public PxTriangleMeshGeometry( ){
         pvk_in_ = ();
        var _new = PxTriangleMeshGeometry_ctor(pvk_in_);
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
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxTriangleMeshGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxTriangleMeshGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxTriangleMeshGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxTriangleMeshGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxTriangleMeshGeometry                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L82~82
    #if NATIVE
    ES void ~PxTriangleMeshGeometry(physx::PxTriangleMeshGeometry* self){
        self->~PxTriangleMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxTriangleMeshGeometry(PxTriangleMeshGeometry selfPtr);
    
    public void ~PxTriangleMeshGeometry(){
        ~PxTriangleMeshGeometry(this);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag PxMeshGeometryFlag_ctor(){
        self.PxMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag PxMeshGeometryFlag_ctor();
    
    public PxMeshGeometryFlag(){
        var _new = PxMeshGeometryFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshGeometryFlag                                                     #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag PxMeshGeometryFlag_ctor(physx::PxMeshGeometryFlag ){
        physx::PxMeshGeometryFlag nat_in_ = ();
        self.PxMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag PxMeshGeometryFlag_ctor(PxMeshGeometryFlag );
    
    public PxMeshGeometryFlag(PxMeshGeometryFlag ){
        PxMeshGeometryFlag pvk_in_ = ();
        var _new = PxMeshGeometryFlag_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxMeshGeometryFlag self, physx::PxMeshGeometryFlag ){
        physx::PxMeshGeometryFlag nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxMeshGeometryFlag selfBlt, PxMeshGeometryFlag );
    
    public UNPARSED_TYPE operator=(PxMeshGeometryFlag ){
        PxMeshGeometryFlag pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshGeometryFlag                                                     #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxMeshGeometryFlag PxMeshGeometryFlag_ctor( ){
         nat_in_ = ();
        self.PxMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshGeometryFlag PxMeshGeometryFlag_ctor( );
    
    public PxMeshGeometryFlag( ){
         pvk_in_ = ();
        var _new = PxMeshGeometryFlag_ctor(pvk_in_);
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
    Non const pointer/reference global::PhysX.physx.PxMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxMeshGeometryFlag self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxMeshGeometryFlag selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxMeshGeometryFlag                                                    #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L53~53
    #if NATIVE
    ES void ~PxMeshGeometryFlag(physx::PxMeshGeometryFlag self){
        self.~PxMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxMeshGeometryFlag(PxMeshGeometryFlag selfBlt);
    
    public void ~PxMeshGeometryFlag(){
        ~PxMeshGeometryFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
