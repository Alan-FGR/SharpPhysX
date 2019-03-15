#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxGeometryHolder { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       getType                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L67~70
    #if NATIVE
    ES physx::PxGeometryType::Enum W_getType(physx::PxGeometryHolder* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getType(PxGeometryHolder selfPtr);
    
    public PxGeometryType getType(){
        PxGeometryType retVal = W_getType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L72~75
    #if NATIVE
    ES physx::PxGeometry* W_any(physx::PxGeometryHolder* self){
        auto retVal = &self->any();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometry W_any(PxGeometryHolder selfPtr);
    
    public PxGeometry any(){
        PxGeometry retVal = W_any(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L77~80
    #if NATIVE
    ES physx::PxGeometry* W_any(physx::PxGeometryHolder* self){
        auto retVal = &self->any();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometry W_any(PxGeometryHolder selfPtr);
    
    public PxGeometry any(){
        PxGeometry retVal = W_any(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L82~85
    #if NATIVE
    ES physx::PxSphereGeometry* W_sphere(physx::PxGeometryHolder* self){
        auto retVal = &self->sphere();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_sphere(PxGeometryHolder selfPtr);
    
    public PxSphereGeometry sphere(){
        PxSphereGeometry retVal = W_sphere(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L87~90
    #if NATIVE
    ES physx::PxSphereGeometry* W_sphere(physx::PxGeometryHolder* self){
        auto retVal = &self->sphere();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_sphere(PxGeometryHolder selfPtr);
    
    public PxSphereGeometry sphere(){
        PxSphereGeometry retVal = W_sphere(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L92~95
    #if NATIVE
    ES physx::PxPlaneGeometry* W_plane(physx::PxGeometryHolder* self){
        auto retVal = &self->plane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometry W_plane(PxGeometryHolder selfPtr);
    
    public PxPlaneGeometry plane(){
        PxPlaneGeometry retVal = W_plane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L97~100
    #if NATIVE
    ES physx::PxPlaneGeometry* W_plane(physx::PxGeometryHolder* self){
        auto retVal = &self->plane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometry W_plane(PxGeometryHolder selfPtr);
    
    public PxPlaneGeometry plane(){
        PxPlaneGeometry retVal = W_plane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L102~105
    #if NATIVE
    ES physx::PxCapsuleGeometry* W_capsule(physx::PxGeometryHolder* self){
        auto retVal = &self->capsule();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_capsule(PxGeometryHolder selfPtr);
    
    public PxCapsuleGeometry capsule(){
        PxCapsuleGeometry retVal = W_capsule(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L107~110
    #if NATIVE
    ES physx::PxCapsuleGeometry* W_capsule(physx::PxGeometryHolder* self){
        auto retVal = &self->capsule();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_capsule(PxGeometryHolder selfPtr);
    
    public PxCapsuleGeometry capsule(){
        PxCapsuleGeometry retVal = W_capsule(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L112~115
    #if NATIVE
    ES physx::PxBoxGeometry* W_box(physx::PxGeometryHolder* self){
        auto retVal = &self->box();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_box(PxGeometryHolder selfPtr);
    
    public PxBoxGeometry box(){
        PxBoxGeometry retVal = W_box(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L117~120
    #if NATIVE
    ES physx::PxBoxGeometry* W_box(physx::PxGeometryHolder* self){
        auto retVal = &self->box();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_box(PxGeometryHolder selfPtr);
    
    public PxBoxGeometry box(){
        PxBoxGeometry retVal = W_box(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L122~125
    #if NATIVE
    ES physx::PxConvexMeshGeometry* W_convexMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->convexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometry W_convexMesh(PxGeometryHolder selfPtr);
    
    public PxConvexMeshGeometry convexMesh(){
        PxConvexMeshGeometry retVal = W_convexMesh(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L127~130
    #if NATIVE
    ES physx::PxConvexMeshGeometry* W_convexMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->convexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometry W_convexMesh(PxGeometryHolder selfPtr);
    
    public PxConvexMeshGeometry convexMesh(){
        PxConvexMeshGeometry retVal = W_convexMesh(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L132~135
    #if NATIVE
    ES physx::PxTriangleMeshGeometry* W_triangleMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->triangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometry W_triangleMesh(PxGeometryHolder selfPtr);
    
    public PxTriangleMeshGeometry triangleMesh(){
        PxTriangleMeshGeometry retVal = W_triangleMesh(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L137~140
    #if NATIVE
    ES physx::PxTriangleMeshGeometry* W_triangleMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->triangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometry W_triangleMesh(PxGeometryHolder selfPtr);
    
    public PxTriangleMeshGeometry triangleMesh(){
        PxTriangleMeshGeometry retVal = W_triangleMesh(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L142~145
    #if NATIVE
    ES physx::PxHeightFieldGeometry* W_heightField(physx::PxGeometryHolder* self){
        auto retVal = &self->heightField();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometry W_heightField(PxGeometryHolder selfPtr);
    
    public PxHeightFieldGeometry heightField(){
        PxHeightFieldGeometry retVal = W_heightField(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L147~150
    #if NATIVE
    ES physx::PxHeightFieldGeometry* W_heightField(physx::PxGeometryHolder* self){
        auto retVal = &self->heightField();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometry W_heightField(PxGeometryHolder selfPtr);
    
    public PxHeightFieldGeometry heightField(){
        PxHeightFieldGeometry retVal = W_heightField(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       storeAny                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L152~170
    #if NATIVE
    ES void W_storeAny(physx::PxGeometryHolder* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->storeAny(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_storeAny(PxGeometryHolder selfPtr, PxGeometry geometry);
    
    public void storeAny(PxGeometry geometry){
        PxGeometry pvk_in_geometry = (geometry);
        W_storeAny(this, pvk_in_geometry);
    }
    #endif
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_FORCE_INLINE	PxGeometryHolder()							{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L172~172
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometryHolder_ctor(){
        self->PxGeometryHolder();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometryHolder_ctor();
    
    public PxGeometryHolder(){
        var _new = W_PxGeometryHolder_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PX_FORCE_INLINE	PxGeometryHolder(const PxGeometry& geometry){ storeAny(geometry);	}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L173~173
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometryHolder_ctor(physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->PxGeometryHolder(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometryHolder_ctor(PxGeometry geometry);
    
    public PxGeometryHolder(PxGeometry geometry){
        PxGeometry pvk_in_geometry = (geometry);
        var _new = W_PxGeometryHolder_ctor(pvk_in_geometry);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       put                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L176~179
    #if NATIVE
    ES void W_put(physx::PxGeometryHolder* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->put(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_put(PxGeometryHolder selfPtr, PxGeometry geometry);
    
    public void put(PxGeometry geometry){
        PxGeometry pvk_in_geometry = (geometry);
        W_put(this, pvk_in_geometry);
    }
    #endif
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    // NATIVE SIG: T& get()
    		{
    			PX_ASSERT(getType() == type);
    			return static_cast<T&>(any());
    		}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L181~185
    #if NATIVE
    ES UNPARSED_TYPE W_get(physx::PxGeometryHolder* self){
        auto retVal = self->get();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_get(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = W_get(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    // NATIVE SIG: T& get() const
    		{
    			PX_ASSERT(getType() == type);
    			return static_cast<T&>(any());
    		}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L187~191
    #if NATIVE
    ES UNPARSED_TYPE W_get(physx::PxGeometryHolder* self){
        auto retVal = self->get();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_get(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = W_get(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometryHolder
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometryHolder_ctor(physx::PxGeometryHolder* ){
        auto nat_in_ = ();
        self->PxGeometryHolder(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometryHolder_ctor(PxGeometryHolder );
    
    public PxGeometryHolder(PxGeometryHolder ){
        PxGeometryHolder pvk_in_ = ();
        var _new = W_PxGeometryHolder_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometryHolder
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES physx::PxGeometryHolder* W_operator=(physx::PxGeometryHolder* self, physx::PxGeometryHolder* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryHolder W_operator=(PxGeometryHolder selfPtr, PxGeometryHolder );
    
    public static PxGeometryHolder operator=(PxGeometryHolder lhs, PxGeometryHolder ){
        PxGeometryHolder pvk_in_ = ();
        PxGeometryHolder retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometryHolder
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometryHolder_ctor(physx::PxGeometryHolder* ){
        auto nat_in_ = ();
        self->PxGeometryHolder(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometryHolder_ctor(PxGeometryHolder );
    
    public PxGeometryHolder(PxGeometryHolder ){
        PxGeometryHolder pvk_in_ = ();
        var _new = W_PxGeometryHolder_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometryHolder
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES physx::PxGeometryHolder* W_operator=(physx::PxGeometryHolder* self, physx::PxGeometryHolder* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryHolder W_operator=(PxGeometryHolder selfPtr, PxGeometryHolder );
    
    public static PxGeometryHolder operator=(PxGeometryHolder lhs, PxGeometryHolder ){
        PxGeometryHolder pvk_in_ = ();
        PxGeometryHolder retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxGeometryHolder                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxGeometryHolder
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES void W_~PxGeometryHolder(physx::PxGeometryHolder* self){
        self->~PxGeometryHolder();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxGeometryHolder(PxGeometryHolder selfPtr);
    
    public void ~PxGeometryHolder(){
        W_~PxGeometryHolder(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct  { // blittable
    // Unblittable fields: byte[] geometry, byte[] box, byte[] sphere, byte[] capsule, byte[] plane, byte[] convex, byte[] mesh, byte[] heightfield
    // FIELDS COULDN'T BE RESOLVED AUTOMATICALLY. YOU MAY HANDLE THAT MANUALLY AS TEMPLATE BELOW:
    private byte[] HND_geometry => geometry;
    private byte[] HND_box => box;
    private byte[] HND_sphere => sphere;
    private byte[] HND_capsule => capsule;
    private byte[] HND_plane => plane;
    private byte[] HND_convex => convex;
    private byte[] HND_mesh => mesh;
    private byte[] HND_heightfield => heightfield;

#endif

    //================================================================================
    //#                                                                              #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: union
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder:: W__ctor(){
        self.();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  W__ctor();
    
    public (){
        var _new = W__ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#                                                                              #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: union
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder:: W__ctor(physx::PxGeometryHolder:: ){
        auto nat_in_ = ();
        self.(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  W__ctor( );
    
    public ( ){
         pvk_in_ = ();
        var _new = W__ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#                                                                              #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxGeometryHolder.
    // NATIVE SIG: union
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder:: W__ctor( ){
        auto nat_in_ = ();
        self.(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  W__ctor( );
    
    public ( ){
         pvk_in_ = ();
        var _new = W__ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~                                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: union
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES void W_~(physx::PxGeometryHolder self){
        self.~();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~( selfBlt);
    
    public void ~(){
        W_~(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: union
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder::* W_operator=(physx::PxGeometryHolder self, physx::PxGeometryHolder:: ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  W_operator=( selfBlt);
    
    public static  operator=( lhs,  ){
         pvk_in_ = ();
         retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxGeometryHolder.
    // NATIVE SIG: union
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder::* W_operator=(physx::PxGeometryHolder self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  W_operator=( selfBlt);
    
    public static  operator=( lhs,  ){
         pvk_in_ = ();
         retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
