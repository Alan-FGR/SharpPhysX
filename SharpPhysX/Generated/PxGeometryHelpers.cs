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
    ES physx::PxGeometryType::Enum getType(physx::PxGeometryHolder* self){
        physx::PxGeometryType::Enum retVal = self->getType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType getType(PxGeometryHolder selfPtr);
    
    public PxGeometryType getType(){
        PxGeometryType retVal = getType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L72~75
    #if NATIVE
    ES UNPARSED_TYPE any(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->any();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE any(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE any(){
        UNPARSED_TYPE retVal = any(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L77~80
    #if NATIVE
    ES UNPARSED_TYPE any(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->any();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE any(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE any(){
        UNPARSED_TYPE retVal = any(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L82~85
    #if NATIVE
    ES UNPARSED_TYPE sphere(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->sphere();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE sphere(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE sphere(){
        UNPARSED_TYPE retVal = sphere(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L87~90
    #if NATIVE
    ES UNPARSED_TYPE sphere(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->sphere();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE sphere(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE sphere(){
        UNPARSED_TYPE retVal = sphere(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L92~95
    #if NATIVE
    ES UNPARSED_TYPE plane(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->plane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE plane(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE plane(){
        UNPARSED_TYPE retVal = plane(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L97~100
    #if NATIVE
    ES UNPARSED_TYPE plane(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->plane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE plane(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE plane(){
        UNPARSED_TYPE retVal = plane(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L102~105
    #if NATIVE
    ES UNPARSED_TYPE capsule(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->capsule();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE capsule(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE capsule(){
        UNPARSED_TYPE retVal = capsule(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L107~110
    #if NATIVE
    ES UNPARSED_TYPE capsule(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->capsule();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE capsule(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE capsule(){
        UNPARSED_TYPE retVal = capsule(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L112~115
    #if NATIVE
    ES UNPARSED_TYPE box(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->box();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE box(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE box(){
        UNPARSED_TYPE retVal = box(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L117~120
    #if NATIVE
    ES UNPARSED_TYPE box(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->box();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE box(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE box(){
        UNPARSED_TYPE retVal = box(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L122~125
    #if NATIVE
    ES UNPARSED_TYPE convexMesh(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->convexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE convexMesh(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE convexMesh(){
        UNPARSED_TYPE retVal = convexMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L127~130
    #if NATIVE
    ES UNPARSED_TYPE convexMesh(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->convexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE convexMesh(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE convexMesh(){
        UNPARSED_TYPE retVal = convexMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L132~135
    #if NATIVE
    ES UNPARSED_TYPE triangleMesh(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->triangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE triangleMesh(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE triangleMesh(){
        UNPARSED_TYPE retVal = triangleMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L137~140
    #if NATIVE
    ES UNPARSED_TYPE triangleMesh(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->triangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE triangleMesh(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE triangleMesh(){
        UNPARSED_TYPE retVal = triangleMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L142~145
    #if NATIVE
    ES UNPARSED_TYPE heightField(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->heightField();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE heightField(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE heightField(){
        UNPARSED_TYPE retVal = heightField(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L147~150
    #if NATIVE
    ES UNPARSED_TYPE heightField(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->heightField();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE heightField(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE heightField(){
        UNPARSED_TYPE retVal = heightField(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       storeAny                                                               #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L152~170
    #if NATIVE
    ES void storeAny(physx::PxGeometryHolder* self,  geometry){
         nat_in_geometry = (geometry);
        self->storeAny(nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void storeAny(PxGeometryHolder selfPtr,  geometry);
    
    public void storeAny( geometry){
         pvk_in_geometry = (geometry);
        storeAny(this, pvk_in_geometry);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L172~172
    #if NATIVE
    ES UNPARSED_TYPE PxGeometryHolder_ctor(){
        self->PxGeometryHolder();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxGeometryHolder_ctor();
    
    public PxGeometryHolder(){
        var _new = PxGeometryHolder_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L173~173
    #if NATIVE
    ES UNPARSED_TYPE PxGeometryHolder_ctor( geometry){
         nat_in_geometry = (geometry);
        self->PxGeometryHolder(nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxGeometryHolder_ctor( geometry);
    
    public PxGeometryHolder( geometry){
         pvk_in_geometry = (geometry);
        var _new = PxGeometryHolder_ctor(pvk_in_geometry);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       put                                                                    #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L176~179
    #if NATIVE
    ES void put(physx::PxGeometryHolder* self,  geometry){
         nat_in_geometry = (geometry);
        self->put(nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void put(PxGeometryHolder selfPtr,  geometry);
    
    public void put( geometry){
         pvk_in_geometry = (geometry);
        put(this, pvk_in_geometry);
    }
    #endif*/
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L181~185
    #if NATIVE
    ES UNPARSED_TYPE get(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->get();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE get(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = get(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L187~191
    #if NATIVE
    ES UNPARSED_TYPE get(physx::PxGeometryHolder* self){
        UNPARSED_TYPE retVal = self->get();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE get(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = get(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE PxGeometryHolder_ctor( ){
         nat_in_ = ();
        self->PxGeometryHolder(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxGeometryHolder_ctor( );
    
    public PxGeometryHolder( ){
         pvk_in_ = ();
        var _new = PxGeometryHolder_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometryHolder* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE PxGeometryHolder_ctor( ){
         nat_in_ = ();
        self->PxGeometryHolder(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxGeometryHolder_ctor( );
    
    public PxGeometryHolder( ){
         pvk_in_ = ();
        var _new = PxGeometryHolder_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometryHolder* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxGeometryHolder selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxGeometryHolder                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L64~64
    #if NATIVE
    ES void ~PxGeometryHolder(physx::PxGeometryHolder* self){
        self->~PxGeometryHolder();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxGeometryHolder(PxGeometryHolder selfPtr);
    
    public void ~PxGeometryHolder(){
        ~PxGeometryHolder(this);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder:: _ctor(){
        self.();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  _ctor();
    
    public (){
        var _new = _ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#                                                                              #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder:: _ctor(physx::PxGeometryHolder:: ){
        physx::PxGeometryHolder:: nat_in_ = ();
        self.(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  _ctor( );
    
    public ( ){
         pvk_in_ = ();
        var _new = _ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#                                                                              #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxGeometryHolder.
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES physx::PxGeometryHolder:: _ctor( ){
         nat_in_ = ();
        self.(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  _ctor( );
    
    public ( ){
         pvk_in_ = ();
        var _new = _ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~                                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES void ~(physx::PxGeometryHolder self){
        self.~();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~( selfBlt);
    
    public void ~(){
        ~(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometryHolder self, physx::PxGeometryHolder:: ){
        physx::PxGeometryHolder:: nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=( selfBlt);
    
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
    Non const pointer/reference global::PhysX.physx.PxGeometryHolder.
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometryHelpers.h L193~193
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometryHolder self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=( selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
