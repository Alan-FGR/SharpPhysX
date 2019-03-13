#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxConvexMeshGeometryFlag : int {
     eTIGHT_BOUNDS = (1<<0),
}
#endif

#if !NATIVE
public unsafe partial struct PxConvexMeshGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L88~93
    #if NATIVE
    ES UNPARSED_TYPE PxConvexMeshGeometry_ctor(){
        self->PxConvexMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxConvexMeshGeometry_ctor();
    
    public PxConvexMeshGeometry(){
        var _new = PxConvexMeshGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    , fsdfasdf
    , Unresolved parameter type physx::PxConvexMeshGeometry::PxConvexMeshGeometry::flags
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L102~110
    #if NATIVE
    ES UNPARSED_TYPE PxConvexMeshGeometry_ctor( mesh,  scaling,  flags){
         nat_in_mesh = (mesh);
         nat_in_scaling = (scaling);
         nat_in_flags = (flags);
        self->PxConvexMeshGeometry(nat_in_mesh, nat_in_scaling, nat_in_flags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxConvexMeshGeometry_ctor( mesh,  scaling,  flags);
    
    public PxConvexMeshGeometry( mesh,  scaling,  flags){
         pvk_in_mesh = (mesh);
         pvk_in_scaling = (scaling);
         pvk_in_flags = (flags);
        var _new = PxConvexMeshGeometry_ctor(pvk_in_mesh, pvk_in_scaling, pvk_in_flags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L122~122
    #if NATIVE
    ES bool isValid(physx::PxConvexMeshGeometry* self){
        bool retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxConvexMeshGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES UNPARSED_TYPE PxConvexMeshGeometry_ctor( ){
         nat_in_ = ();
        self->PxConvexMeshGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxConvexMeshGeometry_ctor( );
    
    public PxConvexMeshGeometry( ){
         pvk_in_ = ();
        var _new = PxConvexMeshGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometry                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES UNPARSED_TYPE PxConvexMeshGeometry_ctor( ){
         nat_in_ = ();
        self->PxConvexMeshGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxConvexMeshGeometry_ctor( );
    
    public PxConvexMeshGeometry( ){
         pvk_in_ = ();
        var _new = PxConvexMeshGeometry_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxConvexMeshGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxConvexMeshGeometry selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxConvexMeshGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxConvexMeshGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConvexMeshGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L80~80
    #if NATIVE
    ES void ~PxConvexMeshGeometry(physx::PxConvexMeshGeometry* self){
        self->~PxConvexMeshGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxConvexMeshGeometry(PxConvexMeshGeometry selfPtr);
    
    public void ~PxConvexMeshGeometry(){
        ~PxConvexMeshGeometry(this);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag PxConvexMeshGeometryFlag_ctor(){
        self.PxConvexMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag PxConvexMeshGeometryFlag_ctor();
    
    public PxConvexMeshGeometryFlag(){
        var _new = PxConvexMeshGeometryFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometryFlag                                               #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag PxConvexMeshGeometryFlag_ctor(physx::PxConvexMeshGeometryFlag ){
        physx::PxConvexMeshGeometryFlag nat_in_ = ();
        self.PxConvexMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag PxConvexMeshGeometryFlag_ctor(PxConvexMeshGeometryFlag );
    
    public PxConvexMeshGeometryFlag(PxConvexMeshGeometryFlag ){
        PxConvexMeshGeometryFlag pvk_in_ = ();
        var _new = PxConvexMeshGeometryFlag_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxConvexMeshGeometryFlag self, physx::PxConvexMeshGeometryFlag ){
        physx::PxConvexMeshGeometryFlag nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxConvexMeshGeometryFlag selfBlt, PxConvexMeshGeometryFlag );
    
    public UNPARSED_TYPE operator=(PxConvexMeshGeometryFlag ){
        PxConvexMeshGeometryFlag pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMeshGeometryFlag                                               #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES physx::PxConvexMeshGeometryFlag PxConvexMeshGeometryFlag_ctor( ){
         nat_in_ = ();
        self.PxConvexMeshGeometryFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryFlag PxConvexMeshGeometryFlag_ctor( );
    
    public PxConvexMeshGeometryFlag( ){
         pvk_in_ = ();
        var _new = PxConvexMeshGeometryFlag_ctor(pvk_in_);
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
    Non const pointer/reference global::PhysX.physx.PxConvexMeshGeometryFlag
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxConvexMeshGeometryFlag self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxConvexMeshGeometryFlag selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConvexMeshGeometryFlag                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L53~53
    #if NATIVE
    ES void ~PxConvexMeshGeometryFlag(physx::PxConvexMeshGeometryFlag self){
        self.~PxConvexMeshGeometryFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxConvexMeshGeometryFlag(PxConvexMeshGeometryFlag selfBlt);
    
    public void ~PxConvexMeshGeometryFlag(){
        ~PxConvexMeshGeometryFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
