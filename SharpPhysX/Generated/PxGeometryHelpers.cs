#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe interface IPxGeometryHolderPtr {
     PxGeometryType getType();
     PxGeometryPtr any();
     PxGeometryPtr any();
     PxSphereGeometry sphere();
     PxSphereGeometry sphere();
     PxPlaneGeometryPtr plane();
     PxPlaneGeometryPtr plane();
     PxCapsuleGeometry capsule();
     PxCapsuleGeometry capsule();
     PxBoxGeometry box();
     PxBoxGeometry box();
    // PxConvexMeshGeometryPtr convexMesh();
    // PxConvexMeshGeometryPtr convexMesh();
    // PxTriangleMeshGeometryPtr triangleMesh();
    // PxTriangleMeshGeometryPtr triangleMesh();
    // PxHeightFieldGeometryPtr heightField();
    // PxHeightFieldGeometryPtr heightField();
     void storeAny(PxGeometryPtr geometry);
    // PxGeometryHolder();
    // PxGeometryHolder(PxGeometryPtr geometry);
     void put(PxGeometryPtr geometry);
    // UNPARSED_TYPE get();
    // UNPARSED_TYPE get();
    // PxGeometryHolder(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxGeometryHolderPtr lhs, /*NULLPARS*/);
    // PxGeometryHolder(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxGeometryHolderPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxGeometryHolder(/*NULLPARS*/);
    
}

public unsafe partial struct PxGeometryHolderPtr : IPxGeometryHolderPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxGeometryHolderPtr
    //================================================================================
    //#       getType                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxGeometryType::Enum W_getType(physx::PxGeometryHolder* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getType(PxGeometryHolderPtr selfPtr);
    
    public  PxGeometryType getType(){
        PxGeometryType retVal = W_getType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    #if NATIVE
    ES physx::PxGeometry* W_any(physx::PxGeometryHolder* self){
        auto retVal = &self->any();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryPtr W_any(PxGeometryHolderPtr selfPtr);
    
    public  PxGeometryPtr any(){
        PxGeometryPtr retVal = W_any(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    #if NATIVE
    ES physx::PxGeometry* W_any(physx::PxGeometryHolder* self){
        auto retVal = &self->any();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryPtr W_any(PxGeometryHolderPtr selfPtr);
    
    public  PxGeometryPtr any(){
        PxGeometryPtr retVal = W_any(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxSphereGeometry* W_sphere(physx::PxGeometryHolder* self){
        auto retVal = &self->sphere();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_sphere(PxGeometryHolderPtr selfPtr);
    
    public  PxSphereGeometry sphere(){
        PxSphereGeometry retVal = W_sphere(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxSphereGeometry* W_sphere(physx::PxGeometryHolder* self){
        auto retVal = &self->sphere();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_sphere(PxGeometryHolderPtr selfPtr);
    
    public  PxSphereGeometry sphere(){
        PxSphereGeometry retVal = W_sphere(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    #if NATIVE
    ES physx::PxPlaneGeometry* W_plane(physx::PxGeometryHolder* self){
        auto retVal = &self->plane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometryPtr W_plane(PxGeometryHolderPtr selfPtr);
    
    public  PxPlaneGeometryPtr plane(){
        PxPlaneGeometryPtr retVal = W_plane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    #if NATIVE
    ES physx::PxPlaneGeometry* W_plane(physx::PxGeometryHolder* self){
        auto retVal = &self->plane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometryPtr W_plane(PxGeometryHolderPtr selfPtr);
    
    public  PxPlaneGeometryPtr plane(){
        PxPlaneGeometryPtr retVal = W_plane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxCapsuleGeometry* W_capsule(physx::PxGeometryHolder* self){
        auto retVal = &self->capsule();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_capsule(PxGeometryHolderPtr selfPtr);
    
    public  PxCapsuleGeometry capsule(){
        PxCapsuleGeometry retVal = W_capsule(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxCapsuleGeometry* W_capsule(physx::PxGeometryHolder* self){
        auto retVal = &self->capsule();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_capsule(PxGeometryHolderPtr selfPtr);
    
    public  PxCapsuleGeometry capsule(){
        PxCapsuleGeometry retVal = W_capsule(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    #if NATIVE
    ES physx::PxBoxGeometry* W_box(physx::PxGeometryHolder* self){
        auto retVal = &self->box();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_box(PxGeometryHolderPtr selfPtr);
    
    public  PxBoxGeometry box(){
        PxBoxGeometry retVal = W_box(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    #if NATIVE
    ES physx::PxBoxGeometry* W_box(physx::PxGeometryHolder* self){
        auto retVal = &self->box();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_box(PxGeometryHolderPtr selfPtr);
    
    public  PxBoxGeometry box(){
        PxBoxGeometry retVal = W_box(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxConvexMeshGeometry& convexMesh()
    	{
    		return get<PxConvexMeshGeometry, PxGeometryType::eCONVEXMESH>();
    	}
    #if NATIVE
    ES physx::PxConvexMeshGeometry* W_convexMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->convexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryPtr W_convexMesh(PxGeometryHolderPtr selfPtr);
    
    public  PxConvexMeshGeometryPtr convexMesh(){
        PxConvexMeshGeometryPtr retVal = W_convexMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxConvexMeshGeometry& convexMesh() const
    	{
    		return get<const PxConvexMeshGeometry, PxGeometryType::eCONVEXMESH>();
    	}
    #if NATIVE
    ES physx::PxConvexMeshGeometry* W_convexMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->convexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryPtr W_convexMesh(PxGeometryHolderPtr selfPtr);
    
    public  PxConvexMeshGeometryPtr convexMesh(){
        PxConvexMeshGeometryPtr retVal = W_convexMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTriangleMeshGeometry& triangleMesh()
    	{
    		return get<PxTriangleMeshGeometry, PxGeometryType::eTRIANGLEMESH>();
    	}
    #if NATIVE
    ES physx::PxTriangleMeshGeometry* W_triangleMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->triangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometryPtr W_triangleMesh(PxGeometryHolderPtr selfPtr);
    
    public  PxTriangleMeshGeometryPtr triangleMesh(){
        PxTriangleMeshGeometryPtr retVal = W_triangleMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTriangleMeshGeometry& triangleMesh() const
    	{
    		return get<const PxTriangleMeshGeometry, PxGeometryType::eTRIANGLEMESH>();
    	}
    #if NATIVE
    ES physx::PxTriangleMeshGeometry* W_triangleMesh(physx::PxGeometryHolder* self){
        auto retVal = &self->triangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometryPtr W_triangleMesh(PxGeometryHolderPtr selfPtr);
    
    public  PxTriangleMeshGeometryPtr triangleMesh(){
        PxTriangleMeshGeometryPtr retVal = W_triangleMesh(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxHeightFieldGeometry& heightField()
    	{
    		return get<PxHeightFieldGeometry, PxGeometryType::eHEIGHTFIELD>();
    	}
    #if NATIVE
    ES physx::PxHeightFieldGeometry* W_heightField(physx::PxGeometryHolder* self){
        auto retVal = &self->heightField();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometryPtr W_heightField(PxGeometryHolderPtr selfPtr);
    
    public  PxHeightFieldGeometryPtr heightField(){
        PxHeightFieldGeometryPtr retVal = W_heightField(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxHeightFieldGeometry& heightField() const
    	{
    		return get<const PxHeightFieldGeometry, PxGeometryType::eHEIGHTFIELD>();
    	}
    #if NATIVE
    ES physx::PxHeightFieldGeometry* W_heightField(physx::PxGeometryHolder* self){
        auto retVal = &self->heightField();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometryPtr W_heightField(PxGeometryHolderPtr selfPtr);
    
    public  PxHeightFieldGeometryPtr heightField(){
        PxHeightFieldGeometryPtr retVal = W_heightField(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       storeAny                                                               #
    //================================================================================
    #if NATIVE
    ES void W_storeAny(physx::PxGeometryHolder* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->storeAny(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_storeAny(PxGeometryHolderPtr selfPtr, PxGeometryPtr geometry);
    
    public  void storeAny(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        W_storeAny(this, pvk_in_geometry);
    }
    #endif
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxGeometryHolder
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxGeometryHolder                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxGeometryHolder
    // NATIVE SIG: PX_FORCE_INLINE	PxGeometryHolder(const PxGeometry& geometry){ storeAny(geometry);	}
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometryHolder_ctor(physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->PxGeometryHolder(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometryHolder_ctor(PxGeometryPtr geometry);
    
    public  PxGeometryHolder(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        var _new = W_PxGeometryHolder_ctor(pvk_in_geometry);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       put                                                                    #
    //================================================================================
    #if NATIVE
    ES void W_put(physx::PxGeometryHolder* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->put(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_put(PxGeometryHolderPtr selfPtr, PxGeometryPtr geometry);
    
    public  void put(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        W_put(this, pvk_in_geometry);
    }
    #endif
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T& get()
    		{
    			PX_ASSERT(getType() == type);
    			return static_cast<T&>(any());
    		}
    #if NATIVE
    ES UNPARSED_TYPE W_get(physx::PxGeometryHolder* self){
        auto retVal = self->get();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_get(PxGeometryHolderPtr selfPtr);
    
    public  UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = W_get(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T& get() const
    		{
    			PX_ASSERT(getType() == type);
    			return static_cast<T&>(any());
    		}
    #if NATIVE
    ES UNPARSED_TYPE W_get(physx::PxGeometryHolder* self){
        auto retVal = self->get();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_get(PxGeometryHolderPtr selfPtr);
    
    public  UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = W_get(this);
        return retVal;
    }
    #endif*/
    
    
    //Skipped generated implicit entry: PxGeometryHolder
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxGeometryHolder
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxGeometryHolder
    

#if !NATIVE
}
#endif

// Union physx::PxGeometryHolder TODO