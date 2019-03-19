#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
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
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxGeometryHolderPtr : IPxGeometryHolderPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields

    // ### BYTES getter/setter
    #if NATIVE //getter
    ES physx::PxGeometryHolder:: PxGeometryHolder_GET_bytes(PxGeometryHolder* self) {return self->bytes;}
    ES void PxGeometryHolder_SET_bytes(PxGeometryHolder* self, physx::PxGeometryHolder:: value) {self->bytes = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern  PxGeometryHolder_GET_bytes(PxGeometryHolderPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxGeometryHolder_SET_bytes(PxGeometryHolderPtr selfPtr,  value);

    public  bytes {
        get => PxGeometryHolder_GET_bytes(this);
        set => PxGeometryHolder_SET_bytes(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxGeometryHolderPtr
    #endif //hierarchy
    //================================================================================
    //#       getType                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxGeometryType::Enum W_getType_R_PxGeometryType_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getType_R_PxGeometryType_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxGeometryType getType(){
        PxGeometryType retVal = W_getType_R_PxGeometryType_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxGeometry* W_any_R_PxGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->any();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryPtr W_any_R_PxGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxGeometryPtr any(){
        PxGeometryPtr retVal = W_any_R_PxGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       any                                                                    #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxGeometry* W_any_R_PxGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->any();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryPtr W_any_R_PxGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxGeometryPtr any(){
        PxGeometryPtr retVal = W_any_R_PxGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxSphereGeometry* W_sphere_R_PxSphereGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->sphere();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_sphere_R_PxSphereGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxSphereGeometry sphere(){
        PxSphereGeometry retVal = W_sphere_R_PxSphereGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       sphere                                                                 #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxSphereGeometry* W_sphere_R_PxSphereGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->sphere();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_sphere_R_PxSphereGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxSphereGeometry sphere(){
        PxSphereGeometry retVal = W_sphere_R_PxSphereGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxPlaneGeometry* W_plane_R_PxPlaneGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->plane();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometryPtr W_plane_R_PxPlaneGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxPlaneGeometryPtr plane(){
        PxPlaneGeometryPtr retVal = W_plane_R_PxPlaneGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       plane                                                                  #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxPlaneGeometry* W_plane_R_PxPlaneGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->plane();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometryPtr W_plane_R_PxPlaneGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxPlaneGeometryPtr plane(){
        PxPlaneGeometryPtr retVal = W_plane_R_PxPlaneGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxCapsuleGeometry* W_capsule_R_PxCapsuleGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->capsule();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_capsule_R_PxCapsuleGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxCapsuleGeometry capsule(){
        PxCapsuleGeometry retVal = W_capsule_R_PxCapsuleGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       capsule                                                                #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxCapsuleGeometry* W_capsule_R_PxCapsuleGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->capsule();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_capsule_R_PxCapsuleGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxCapsuleGeometry capsule(){
        PxCapsuleGeometry retVal = W_capsule_R_PxCapsuleGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBoxGeometry* W_box_R_PxBoxGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->box();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_box_R_PxBoxGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxBoxGeometry box(){
        PxBoxGeometry retVal = W_box_R_PxBoxGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       box                                                                    #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxBoxGeometry* W_box_R_PxBoxGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->box();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_box_R_PxBoxGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxBoxGeometry box(){
        PxBoxGeometry retVal = W_box_R_PxBoxGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxConvexMeshGeometry& convexMesh()
    	{
    		return get<PxConvexMeshGeometry, PxGeometryType::eCONVEXMESH>();
    	}
    #if NATIVE //function start
    ES physx::PxConvexMeshGeometry* W_convexMesh_R_PxConvexMeshGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->convexMesh();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryPtr W_convexMesh_R_PxConvexMeshGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxConvexMeshGeometryPtr convexMesh(){
        PxConvexMeshGeometryPtr retVal = W_convexMesh_R_PxConvexMeshGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       convexMesh                                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxConvexMeshGeometry& convexMesh() const
    	{
    		return get<const PxConvexMeshGeometry, PxGeometryType::eCONVEXMESH>();
    	}
    #if NATIVE //function start
    ES const physx::PxConvexMeshGeometry* W_convexMesh_R_PxConvexMeshGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->convexMesh();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshGeometryPtr W_convexMesh_R_PxConvexMeshGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxConvexMeshGeometryPtr convexMesh(){
        PxConvexMeshGeometryPtr retVal = W_convexMesh_R_PxConvexMeshGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTriangleMeshGeometry& triangleMesh()
    	{
    		return get<PxTriangleMeshGeometry, PxGeometryType::eTRIANGLEMESH>();
    	}
    #if NATIVE //function start
    ES physx::PxTriangleMeshGeometry* W_triangleMesh_R_PxTriangleMeshGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->triangleMesh();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometryPtr W_triangleMesh_R_PxTriangleMeshGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxTriangleMeshGeometryPtr triangleMesh(){
        PxTriangleMeshGeometryPtr retVal = W_triangleMesh_R_PxTriangleMeshGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       triangleMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTriangleMeshGeometry& triangleMesh() const
    	{
    		return get<const PxTriangleMeshGeometry, PxGeometryType::eTRIANGLEMESH>();
    	}
    #if NATIVE //function start
    ES const physx::PxTriangleMeshGeometry* W_triangleMesh_R_PxTriangleMeshGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->triangleMesh();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshGeometryPtr W_triangleMesh_R_PxTriangleMeshGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxTriangleMeshGeometryPtr triangleMesh(){
        PxTriangleMeshGeometryPtr retVal = W_triangleMesh_R_PxTriangleMeshGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxHeightFieldGeometry& heightField()
    	{
    		return get<PxHeightFieldGeometry, PxGeometryType::eHEIGHTFIELD>();
    	}
    #if NATIVE //function start
    ES physx::PxHeightFieldGeometry* W_heightField_R_PxHeightFieldGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->heightField();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometryPtr W_heightField_R_PxHeightFieldGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxHeightFieldGeometryPtr heightField(){
        PxHeightFieldGeometryPtr retVal = W_heightField_R_PxHeightFieldGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       heightField                                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxHeightFieldGeometry& heightField() const
    	{
    		return get<const PxHeightFieldGeometry, PxGeometryType::eHEIGHTFIELD>();
    	}
    #if NATIVE //function start
    ES const physx::PxHeightFieldGeometry* W_heightField_R_PxHeightFieldGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = &self->heightField();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometryPtr W_heightField_R_PxHeightFieldGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  PxHeightFieldGeometryPtr heightField(){
        PxHeightFieldGeometryPtr retVal = W_heightField_R_PxHeightFieldGeometryPtr_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       storeAny                                                               #
    //================================================================================
    #if NATIVE //function start
    ES void W_storeAny_R_void_P_PxGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->storeAny(*nat_in_geometry);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_storeAny_R_void_P_PxGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr, PxGeometryPtr geometry);
    
    public  void storeAny(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        W_storeAny_R_void_P_PxGeometryPtr_C_PxGeometryHolder(this, pvk_in_geometry);
    }
    #endif //function end
    
    
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
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxGeometryHolder_R_PxGeometryHolderPtr_P_PxGeometryPtr_C_PxGeometryHolder_ctor(physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        return PxGeometryHolder(*nat_in_geometry);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometryHolder_R_PxGeometryHolderPtr_P_PxGeometryPtr_C_PxGeometryHolder_ctor(PxGeometryPtr geometry);
    
    public  PxGeometryHolder(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        var _new = W_PxGeometryHolder_R_PxGeometryHolderPtr_P_PxGeometryPtr_C_PxGeometryHolder_ctor(pvk_in_geometry);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       put                                                                    #
    //================================================================================
    #if NATIVE //function start
    ES void W_put_R_void_P_PxGeometryPtr_C_PxGeometryHolder(physx::PxGeometryHolder* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->put(*nat_in_geometry);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_put_R_void_P_PxGeometryPtr_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr, PxGeometryPtr geometry);
    
    public  void put(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        W_put_R_void_P_PxGeometryPtr_C_PxGeometryHolder(this, pvk_in_geometry);
    }
    #endif //function end
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T& get()
    		{
    			PX_ASSERT(getType() == type);
    			return static_cast<T&>(any());
    		}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_get_R_T_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = self->get();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_get_R_T_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = W_get_R_T_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       get                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T& get() const
    		{
    			PX_ASSERT(getType() == type);
    			return static_cast<T&>(any());
    		}
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_get_R_T_C_PxGeometryHolder(physx::PxGeometryHolder* self){
        auto retVal = self->get();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_get_R_T_C_PxGeometryHolder(PxGeometryHolderPtr selfPtr);
    
    public  UNPARSED_TYPE get(){
        UNPARSED_TYPE retVal = W_get_R_T_C_PxGeometryHolder(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: PxGeometryHolder
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxGeometryHolder
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxGeometryHolder
    

#if !NATIVE //struct close
}
#endif //struct close

// Union physx::PxGeometryHolder TODO