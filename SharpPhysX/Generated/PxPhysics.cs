#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxPhysics {
#endif

//================================================================================
//#       PxRegisterArticulations                                                #
//================================================================================
#if NATIVE //function start
ES void W_PxRegisterArticulations_R_void_P_PxPhysicsPtr(physx::PxPhysics* physics){
    auto nat_in_physics = (physics);
    PxRegisterArticulations(*nat_in_physics);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxRegisterArticulations_R_void_P_PxPhysicsPtr(PxPhysicsPtr physics);

public static void PxRegisterArticulations(PxPhysicsPtr physics){
    PxPhysicsPtr pvk_in_physics = (physics);
    W_PxRegisterArticulations_R_void_P_PxPhysicsPtr(pvk_in_physics);
}
#endif //function end


//================================================================================
//#       PxRegisterArticulationsReducedCoordinate                               #
//================================================================================
#if NATIVE //function start
ES void W_PxRegisterArticulationsReducedCoordinate_R_void_P_PxPhysicsPtr(physx::PxPhysics* physics){
    auto nat_in_physics = (physics);
    PxRegisterArticulationsReducedCoordinate(*nat_in_physics);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxRegisterArticulationsReducedCoordinate_R_void_P_PxPhysicsPtr(PxPhysicsPtr physics);

public static void PxRegisterArticulationsReducedCoordinate(PxPhysicsPtr physics){
    PxPhysicsPtr pvk_in_physics = (physics);
    W_PxRegisterArticulationsReducedCoordinate_R_void_P_PxPhysicsPtr(pvk_in_physics);
}
#endif //function end


//================================================================================
//#       PxRegisterHeightFields                                                 #
//================================================================================
#if NATIVE //function start
ES void W_PxRegisterHeightFields_R_void_P_PxPhysicsPtr(physx::PxPhysics* physics){
    auto nat_in_physics = (physics);
    PxRegisterHeightFields(*nat_in_physics);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxRegisterHeightFields_R_void_P_PxPhysicsPtr(PxPhysicsPtr physics);

public static void PxRegisterHeightFields(PxPhysicsPtr physics){
    PxPhysicsPtr pvk_in_physics = (physics);
    W_PxRegisterHeightFields_R_void_P_PxPhysicsPtr(pvk_in_physics);
}
#endif //function end


//================================================================================
//#       PxCreateBasePhysics                                                    #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScalePtr
// NATIVE SIG: physx::PxPhysics* PX_CALL_CONV PxCreateBasePhysics(physx::PxU32 version,
																			     physx::PxFoundation& foundation,
																			     const physx::PxTolerancesScale& scale,																				 
																			     bool trackOutstandingAllocations = false,
																				 physx::PxPvd* pvd = NULL)
#if NATIVE //function start
ES physx::PxPhysics* W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_P_PxPvdPtr(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale, bool trackOutstandingAllocations, physx::PxPvd* pvd){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto nat_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    auto nat_in_pvd = (pvd);
    auto retVal = PxCreateBasePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale, nat_in_trackOutstandingAllocations, nat_in_pvd);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_P_PxPvdPtr(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations, PxPvdPtr pvd);

public static PxPhysicsPtr PxCreateBasePhysics(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations, PxPvdPtr pvd){
    uint pvk_in_version = (version);
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxTolerancesScalePtr pvk_in_scale = (scale);
    bool pvk_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    PxPvdPtr pvk_in_pvd = (pvd);
    PxPhysicsPtr retVal = W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_P_PxPvdPtr(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations, pvk_in_pvd);
    return retVal;
}
#endif //function end*/

// ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScalePtr
// NATIVE SIG: physx::PxPhysics* PX_CALL_CONV PxCreateBasePhysics(physx::PxU32 version,
																			     physx::PxFoundation& foundation,
																			     const physx::PxTolerancesScale& scale,																				 
																			     bool trackOutstandingAllocations = false,
																				 physx::PxPvd* pvd = NULL)
#if NATIVE //function start
ES physx::PxPhysics* W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_OL1(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale, bool trackOutstandingAllocations){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto nat_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    auto retVal = PxCreateBasePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale, nat_in_trackOutstandingAllocations);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_OL1(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations);

public static PxPhysicsPtr PxCreateBasePhysics(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations){
    uint pvk_in_version = (version);
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxTolerancesScalePtr pvk_in_scale = (scale);
    bool pvk_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    PxPhysicsPtr retVal = W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_OL1(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations);
    return retVal;
}
#endif //function end*/



// ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScalePtr
// NATIVE SIG: physx::PxPhysics* PX_CALL_CONV PxCreateBasePhysics(physx::PxU32 version,
																			     physx::PxFoundation& foundation,
																			     const physx::PxTolerancesScale& scale,																				 
																			     bool trackOutstandingAllocations = false,
																				 physx::PxPvd* pvd = NULL)
#if NATIVE //function start
ES physx::PxPhysics* W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_OL2(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto retVal = PxCreateBasePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_OL2(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale);

public static PxPhysicsPtr PxCreateBasePhysics(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale){
    uint pvk_in_version = (version);
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxTolerancesScalePtr pvk_in_scale = (scale);
    PxPhysicsPtr retVal = W_PxCreateBasePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_OL2(pvk_in_version, pvk_in_foundation, pvk_in_scale);
    return retVal;
}
#endif //function end*/




//================================================================================
//#       PxCreatePhysics                                                        #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScalePtr
// NATIVE SIG: physx::PxPhysics* PxCreatePhysics(physx::PxU32 version,
											physx::PxFoundation& foundation,
											const physx::PxTolerancesScale& scale,											
											bool trackOutstandingAllocations = false,
											physx::PxPvd* pvd = NULL )
{
	physx::PxPhysics* physics = PxCreateBasePhysics(version, foundation, scale, trackOutstandingAllocations, pvd);
	if(!physics)
		return NULL;

	PxRegisterArticulations(*physics);
	PxRegisterArticulationsReducedCoordinate(*physics);
	PxRegisterHeightFields(*physics);

	return physics;
}
#if NATIVE //function start
ES physx::PxPhysics* W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_P_PxPvdPtr(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale, bool trackOutstandingAllocations, physx::PxPvd* pvd){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto nat_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    auto nat_in_pvd = (pvd);
    auto retVal = PxCreatePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale, nat_in_trackOutstandingAllocations, nat_in_pvd);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_P_PxPvdPtr(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations, PxPvdPtr pvd);

public static PxPhysicsPtr PxCreatePhysics(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations, PxPvdPtr pvd){
    uint pvk_in_version = (version);
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxTolerancesScalePtr pvk_in_scale = (scale);
    bool pvk_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    PxPvdPtr pvk_in_pvd = (pvd);
    PxPhysicsPtr retVal = W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_P_PxPvdPtr(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations, pvk_in_pvd);
    return retVal;
}
#endif //function end*/

// ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScalePtr
// NATIVE SIG: physx::PxPhysics* PxCreatePhysics(physx::PxU32 version,
											physx::PxFoundation& foundation,
											const physx::PxTolerancesScale& scale,											
											bool trackOutstandingAllocations = false,
											physx::PxPvd* pvd = NULL )
{
	physx::PxPhysics* physics = PxCreateBasePhysics(version, foundation, scale, trackOutstandingAllocations, pvd);
	if(!physics)
		return NULL;

	PxRegisterArticulations(*physics);
	PxRegisterArticulationsReducedCoordinate(*physics);
	PxRegisterHeightFields(*physics);

	return physics;
}
#if NATIVE //function start
ES physx::PxPhysics* W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_OL1(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale, bool trackOutstandingAllocations){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto nat_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    auto retVal = PxCreatePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale, nat_in_trackOutstandingAllocations);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_OL1(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations);

public static PxPhysicsPtr PxCreatePhysics(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale, bool trackOutstandingAllocations){
    uint pvk_in_version = (version);
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxTolerancesScalePtr pvk_in_scale = (scale);
    bool pvk_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    PxPhysicsPtr retVal = W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_P_bool_OL1(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations);
    return retVal;
}
#endif //function end*/



// ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScalePtr
// NATIVE SIG: physx::PxPhysics* PxCreatePhysics(physx::PxU32 version,
											physx::PxFoundation& foundation,
											const physx::PxTolerancesScale& scale,											
											bool trackOutstandingAllocations = false,
											physx::PxPvd* pvd = NULL )
{
	physx::PxPhysics* physics = PxCreateBasePhysics(version, foundation, scale, trackOutstandingAllocations, pvd);
	if(!physics)
		return NULL;

	PxRegisterArticulations(*physics);
	PxRegisterArticulationsReducedCoordinate(*physics);
	PxRegisterHeightFields(*physics);

	return physics;
}
#if NATIVE //function start
ES physx::PxPhysics* W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_OL2(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto retVal = PxCreatePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_OL2(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale);

public static PxPhysicsPtr PxCreatePhysics(uint version, PxFoundationPtr foundation, PxTolerancesScalePtr scale){
    uint pvk_in_version = (version);
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxTolerancesScalePtr pvk_in_scale = (scale);
    PxPhysicsPtr retVal = W_PxCreatePhysics_R_PxPhysicsPtr_P_uint_P_PxFoundationPtr_P_PxTolerancesScalePtr_OL2(pvk_in_version, pvk_in_foundation, pvk_in_scale);
    return retVal;
}
#endif //function end*/




//================================================================================
//#       PxGetPhysics                                                           #
//================================================================================
#if NATIVE //function start
ES physx::PxPhysics* W_PxGetPhysics_R_PxPhysicsPtr(){
    auto retVal = &PxGetPhysics();
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_PxGetPhysics_R_PxPhysicsPtr();

public static PxPhysicsPtr PxGetPhysics(){
    PxPhysicsPtr retVal = W_PxGetPhysics_R_PxPhysicsPtr();
    return retVal;
}
#endif //function end

#if !NATIVE
} // End PxPhysics
#endif


#if !NATIVE //interface
public unsafe interface IPxPhysicsPtr {
    // void ~PxPhysics();
     void release();
     PxFoundationPtr getFoundation();
    // PxAggregatePtr createAggregate(uint maxSize, bool enableSelfCollision);
    // PxTolerancesScalePtr getTolerancesScale();
    // PxTriangleMeshPtr createTriangleMesh(PxInputStreamPtr stream);
     uint getNbTriangleMeshes();
    // uint getTriangleMeshes( userBuffer, uint bufferSize);
    // uint getTriangleMeshes( userBuffer, uint bufferSize, uint startIndex);
    // PxHeightFieldPtr createHeightField(PxInputStreamPtr stream);
     uint getNbHeightFields();
    // uint getHeightFields( userBuffer, uint bufferSize);
    // uint getHeightFields( userBuffer, uint bufferSize, uint startIndex);
    // PxConvexMeshPtr createConvexMesh(PxInputStreamPtr stream);
     uint getNbConvexMeshes();
    // uint getConvexMeshes( userBuffer, uint bufferSize);
    // uint getConvexMeshes( userBuffer, uint bufferSize, uint startIndex);
    // PxBVHStructurePtr createBVHStructure(PxInputStreamPtr stream);
     uint getNbBVHStructures();
    // uint getBVHStructures( userBuffer, uint bufferSize);
    // uint getBVHStructures( userBuffer, uint bufferSize, uint startIndex);
     PxScenePtr createScene(PxSceneDescPtr sceneDesc);
     uint getNbScenes();
    // uint getScenes( userBuffer, uint bufferSize);
    // uint getScenes( userBuffer, uint bufferSize, uint startIndex);
     PxRigidStaticPtr createRigidStatic(PxTransform pose);
     PxRigidDynamicPtr createRigidDynamic(PxTransform pose);
    // PxPruningStructurePtr createPruningStructure( actors, uint nbActors);
     PxShapePtr createShape(PxGeometryPtr geometry, PxMaterialPtr material, bool isExclusive);
     PxShapePtr createShape(PxGeometryPtr geometry, PxMaterialPtr material);
    // PxShapePtr createShape(PxGeometryPtr geometry, PxMaterialPtr material, bool isExclusive,  shapeFlags);
    // PxShapePtr createShape(PxGeometryPtr geometry,  materials, ushort materialCount, bool isExclusive);
    // PxShapePtr createShape(PxGeometryPtr geometry,  materials, ushort materialCount);
    // PxShapePtr createShape(PxGeometryPtr geometry,  materials, ushort materialCount, bool isExclusive,  shapeFlags);
     uint getNbShapes();
    // uint getShapes( userBuffer, uint bufferSize);
    // uint getShapes( userBuffer, uint bufferSize, uint startIndex);
    // PxConstraintPtr createConstraint(PxRigidActorPtr actor0, PxRigidActorPtr actor1, PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders, uint dataSize);
    // PxArticulationPtr createArticulation();
    // PxArticulationReducedCoordinatePtr createArticulationReducedCoordinate();
     PxMaterialPtr createMaterial(float staticFriction, float dynamicFriction, float restitution);
     uint getNbMaterials();
    // uint getMaterials( userBuffer, uint bufferSize);
    // uint getMaterials( userBuffer, uint bufferSize, uint startIndex);
    // void registerDeletionListener(PxDeletionListenerPtr observer,  deletionEvents);
    // void registerDeletionListener(PxDeletionListenerPtr observer,  deletionEvents, bool restrictedObjectSet);
    // void unregisterDeletionListener(PxDeletionListenerPtr observer);
    // void registerDeletionListenerObjects(PxDeletionListenerPtr observer,  observables, uint observableCount);
    // void unregisterDeletionListenerObjects(PxDeletionListenerPtr observer,  observables, uint observableCount);
    // PxPhysicsInsertionCallbackPtr getPhysicsInsertionCallback();
    //static UNPARSED_TYPE operator=(PxPhysicsPtr lhs, /*NULLPARS*/);
    // PxPhysics(/*NULLPARS*/);
    // PxPhysics(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxPhysicsPtr : IPxPhysicsPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxPhysicsPtr
    #endif //hierarchy
    //================================================================================
    //#       ~PxPhysics                                                             #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxPhysics() {}
    #if NATIVE //function start
    ES void W_~PxPhysics_R_void_C_PxPhysics(physx::PxPhysics* self){
        self->~PxPhysics();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxPhysics_R_void_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  void ~PxPhysics(){
        W_~PxPhysics_R_void_C_PxPhysics(this);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxPhysics(physx::PxPhysics* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxPhysics(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFoundation                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxFoundation* W_getFoundation_R_PxFoundationPtr_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = &self->getFoundation();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFoundationPtr W_getFoundation_R_PxFoundationPtr_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  PxFoundationPtr getFoundation(){
        PxFoundationPtr retVal = W_getFoundation_R_PxFoundationPtr_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       createAggregate                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxAggregate*		createAggregate(PxU32 maxSize, bool enableSelfCollision)	= 0
    #if NATIVE //function start
    ES physx::PxAggregate* W_createAggregate_R_PxAggregatePtr_P_uint_P_bool_C_PxPhysics(physx::PxPhysics* self, physx::PxU32 maxSize, bool enableSelfCollision){
        auto nat_in_maxSize = (maxSize);
        auto nat_in_enableSelfCollision = (enableSelfCollision);
        auto retVal = self->createAggregate(nat_in_maxSize, nat_in_enableSelfCollision);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAggregatePtr W_createAggregate_R_PxAggregatePtr_P_uint_P_bool_C_PxPhysics(PxPhysicsPtr selfPtr, uint maxSize, bool enableSelfCollision);
    
    public  PxAggregatePtr createAggregate(uint maxSize, bool enableSelfCollision){
        uint pvk_in_maxSize = (maxSize);
        bool pvk_in_enableSelfCollision = (enableSelfCollision);
        PxAggregatePtr retVal = W_createAggregate_R_PxAggregatePtr_P_uint_P_bool_C_PxPhysics(this, pvk_in_maxSize, pvk_in_enableSelfCollision);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getTolerancesScale                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTolerancesScale&		getTolerancesScale() const = 0
    #if NATIVE //function start
    ES const physx::PxTolerancesScale* W_getTolerancesScale_R_PxTolerancesScalePtr_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = &self->getTolerancesScale();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTolerancesScalePtr W_getTolerancesScale_R_PxTolerancesScalePtr_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  PxTolerancesScalePtr getTolerancesScale(){
        PxTolerancesScalePtr retVal = W_getTolerancesScale_R_PxTolerancesScalePtr_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       createTriangleMesh                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxInputStreamPtr
    // NATIVE SIG: PxTriangleMesh*    createTriangleMesh(PxInputStream& stream) = 0
    #if NATIVE //function start
    ES physx::PxTriangleMesh* W_createTriangleMesh_R_PxTriangleMeshPtr_P_PxInputStreamPtr_C_PxPhysics(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createTriangleMesh(*nat_in_stream);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMeshPtr W_createTriangleMesh_R_PxTriangleMeshPtr_P_PxInputStreamPtr_C_PxPhysics(PxPhysicsPtr selfPtr, PxInputStreamPtr stream);
    
    public  PxTriangleMeshPtr createTriangleMesh(PxInputStreamPtr stream){
        PxInputStreamPtr pvk_in_stream = (stream);
        PxTriangleMeshPtr retVal = W_createTriangleMesh_R_PxTriangleMeshPtr_P_PxInputStreamPtr_C_PxPhysics(this, pvk_in_stream);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbTriangleMeshes                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbTriangleMeshes_R_uint_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->getNbTriangleMeshes();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbTriangleMeshes_R_uint_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  uint getNbTriangleMeshes(){
        uint retVal = W_getNbTriangleMeshes_R_uint_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTriangleMeshes                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxTriangleMesh*
    // NATIVE SIG: PxU32				getTriangleMeshes(PxTriangleMesh** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getTriangleMeshes_R_uint_P__P_uint_P_uint_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getTriangleMeshes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getTriangleMeshes_R_uint_P__P_uint_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getTriangleMeshes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getTriangleMeshes_R_uint_P__P_uint_P_uint_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxTriangleMesh*
    // NATIVE SIG: PxU32				getTriangleMeshes(PxTriangleMesh** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getTriangleMeshes_R_uint_P__P_uint_OL1_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getTriangleMeshes(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getTriangleMeshes_R_uint_P__P_uint_OL1_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getTriangleMeshes( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getTriangleMeshes_R_uint_P__P_uint_OL1_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       createHeightField                                                      #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Forbidden parameter type: PxInputStreamPtr
    // NATIVE SIG: PxHeightField*		createHeightField(PxInputStream& stream) = 0
    #if NATIVE //function start
    ES physx::PxHeightField* W_createHeightField_R_PxHeightFieldPtr_P_PxInputStreamPtr_C_PxPhysics(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createHeightField(*nat_in_stream);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldPtr W_createHeightField_R_PxHeightFieldPtr_P_PxInputStreamPtr_C_PxPhysics(PxPhysicsPtr selfPtr, PxInputStreamPtr stream);
    
    public  PxHeightFieldPtr createHeightField(PxInputStreamPtr stream){
        PxInputStreamPtr pvk_in_stream = (stream);
        PxHeightFieldPtr retVal = W_createHeightField_R_PxHeightFieldPtr_P_PxInputStreamPtr_C_PxPhysics(this, pvk_in_stream);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbHeightFields                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbHeightFields_R_uint_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->getNbHeightFields();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbHeightFields_R_uint_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  uint getNbHeightFields(){
        uint retVal = W_getNbHeightFields_R_uint_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getHeightFields                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxHeightField
    Unresolved parameter pointee physx::PxHeightField*
    // NATIVE SIG: PxU32				getHeightFields(PxHeightField** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getHeightFields_R_uint_P__P_uint_P_uint_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getHeightFields(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getHeightFields_R_uint_P__P_uint_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getHeightFields( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getHeightFields_R_uint_P__P_uint_P_uint_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxHeightField
    Unresolved parameter pointee physx::PxHeightField*
    // NATIVE SIG: PxU32				getHeightFields(PxHeightField** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getHeightFields_R_uint_P__P_uint_OL1_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getHeightFields(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getHeightFields_R_uint_P__P_uint_OL1_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getHeightFields( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getHeightFields_R_uint_P__P_uint_OL1_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       createConvexMesh                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Forbidden parameter type: PxInputStreamPtr
    // NATIVE SIG: PxConvexMesh*		createConvexMesh(PxInputStream &stream)					= 0
    #if NATIVE //function start
    ES physx::PxConvexMesh* W_createConvexMesh_R_PxConvexMeshPtr_P_PxInputStreamPtr_C_PxPhysics(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createConvexMesh(*nat_in_stream);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMeshPtr W_createConvexMesh_R_PxConvexMeshPtr_P_PxInputStreamPtr_C_PxPhysics(PxPhysicsPtr selfPtr, PxInputStreamPtr stream);
    
    public  PxConvexMeshPtr createConvexMesh(PxInputStreamPtr stream){
        PxInputStreamPtr pvk_in_stream = (stream);
        PxConvexMeshPtr retVal = W_createConvexMesh_R_PxConvexMeshPtr_P_PxInputStreamPtr_C_PxPhysics(this, pvk_in_stream);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbConvexMeshes                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbConvexMeshes_R_uint_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->getNbConvexMeshes();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbConvexMeshes_R_uint_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  uint getNbConvexMeshes(){
        uint retVal = W_getNbConvexMeshes_R_uint_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConvexMeshes                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxConvexMesh
    Unresolved parameter pointee physx::PxConvexMesh*
    // NATIVE SIG: PxU32				getConvexMeshes(PxConvexMesh** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getConvexMeshes_R_uint_P__P_uint_P_uint_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getConvexMeshes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConvexMeshes_R_uint_P__P_uint_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getConvexMeshes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getConvexMeshes_R_uint_P__P_uint_P_uint_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxConvexMesh
    Unresolved parameter pointee physx::PxConvexMesh*
    // NATIVE SIG: PxU32				getConvexMeshes(PxConvexMesh** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getConvexMeshes_R_uint_P__P_uint_OL1_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getConvexMeshes(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConvexMeshes_R_uint_P__P_uint_OL1_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getConvexMeshes( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getConvexMeshes_R_uint_P__P_uint_OL1_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       createBVHStructure                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Forbidden parameter type: PxInputStreamPtr
    // NATIVE SIG: PxBVHStructure*		createBVHStructure(PxInputStream &stream)					= 0
    #if NATIVE //function start
    ES physx::PxBVHStructure* W_createBVHStructure_R_PxBVHStructurePtr_P_PxInputStreamPtr_C_PxPhysics(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createBVHStructure(*nat_in_stream);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBVHStructurePtr W_createBVHStructure_R_PxBVHStructurePtr_P_PxInputStreamPtr_C_PxPhysics(PxPhysicsPtr selfPtr, PxInputStreamPtr stream);
    
    public  PxBVHStructurePtr createBVHStructure(PxInputStreamPtr stream){
        PxInputStreamPtr pvk_in_stream = (stream);
        PxBVHStructurePtr retVal = W_createBVHStructure_R_PxBVHStructurePtr_P_PxInputStreamPtr_C_PxPhysics(this, pvk_in_stream);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbBVHStructures                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbBVHStructures_R_uint_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->getNbBVHStructures();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbBVHStructures_R_uint_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  uint getNbBVHStructures(){
        uint retVal = W_getNbBVHStructures_R_uint_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBVHStructures                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxBVHStructure
    Unresolved parameter pointee physx::PxBVHStructure*
    // NATIVE SIG: PxU32				getBVHStructures(PxBVHStructure** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getBVHStructures_R_uint_P__P_uint_P_uint_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getBVHStructures(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getBVHStructures_R_uint_P__P_uint_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getBVHStructures( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getBVHStructures_R_uint_P__P_uint_P_uint_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxBVHStructure
    Unresolved parameter pointee physx::PxBVHStructure*
    // NATIVE SIG: PxU32				getBVHStructures(PxBVHStructure** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getBVHStructures_R_uint_P__P_uint_OL1_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getBVHStructures(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getBVHStructures_R_uint_P__P_uint_OL1_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getBVHStructures( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getBVHStructures_R_uint_P__P_uint_OL1_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       createScene                                                            #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxScene* W_createScene_R_PxScenePtr_P_PxSceneDescPtr_C_PxPhysics(physx::PxPhysics* self, physx::PxSceneDesc* sceneDesc){
        auto nat_in_sceneDesc = (sceneDesc);
        auto retVal = self->createScene(*nat_in_sceneDesc);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxScenePtr W_createScene_R_PxScenePtr_P_PxSceneDescPtr_C_PxPhysics(PxPhysicsPtr selfPtr, PxSceneDescPtr sceneDesc);
    
    public  PxScenePtr createScene(PxSceneDescPtr sceneDesc){
        PxSceneDescPtr pvk_in_sceneDesc = (sceneDesc);
        PxScenePtr retVal = W_createScene_R_PxScenePtr_P_PxSceneDescPtr_C_PxPhysics(this, pvk_in_sceneDesc);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNbScenes                                                            #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbScenes_R_uint_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->getNbScenes();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbScenes_R_uint_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  uint getNbScenes(){
        uint retVal = W_getNbScenes_R_uint_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getScenes                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxScene*
    // NATIVE SIG: PxU32				getScenes(PxScene** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getScenes_R_uint_P__P_uint_P_uint_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getScenes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getScenes_R_uint_P__P_uint_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getScenes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getScenes_R_uint_P__P_uint_P_uint_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxScene*
    // NATIVE SIG: PxU32				getScenes(PxScene** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getScenes_R_uint_P__P_uint_OL1_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getScenes(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getScenes_R_uint_P__P_uint_OL1_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getScenes( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getScenes_R_uint_P__P_uint_OL1_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       createRigidStatic                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxRigidStatic* W_createRigidStatic_R_PxRigidStaticPtr_P_PxTransform_C_PxPhysics(physx::PxPhysics* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        auto retVal = self->createRigidStatic(nat_in_pose);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidStaticPtr W_createRigidStatic_R_PxRigidStaticPtr_P_PxTransform_C_PxPhysics(PxPhysicsPtr selfPtr, PxTransform pose);
    
    public  PxRigidStaticPtr createRigidStatic(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        PxRigidStaticPtr retVal = W_createRigidStatic_R_PxRigidStaticPtr_P_PxTransform_C_PxPhysics(this, pvk_in_pose);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       createRigidDynamic                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxRigidDynamic* W_createRigidDynamic_R_PxRigidDynamicPtr_P_PxTransform_C_PxPhysics(physx::PxPhysics* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        auto retVal = self->createRigidDynamic(nat_in_pose);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidDynamicPtr W_createRigidDynamic_R_PxRigidDynamicPtr_P_PxTransform_C_PxPhysics(PxPhysicsPtr selfPtr, PxTransform pose);
    
    public  PxRigidDynamicPtr createRigidDynamic(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        PxRigidDynamicPtr retVal = W_createRigidDynamic_R_PxRigidDynamicPtr_P_PxTransform_C_PxPhysics(this, pvk_in_pose);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       createPruningStructure                                                 #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Unresolved parameter pointee physx::PxRigidActor*
    // NATIVE SIG: PxPruningStructure*	createPruningStructure(PxRigidActor*const* actors, PxU32 nbActors)	= 0
    #if NATIVE //function start
    ES physx::PxPruningStructure* W_createPruningStructure_R_PxPruningStructurePtr_P__P_uint_C_PxPhysics(physx::PxPhysics* self,  actors, physx::PxU32 nbActors){
        auto nat_in_actors = (actors);
        auto nat_in_nbActors = (nbActors);
        auto retVal = self->createPruningStructure(nat_in_actors, nat_in_nbActors);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPruningStructurePtr W_createPruningStructure_R_PxPruningStructurePtr_P__P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  actors, uint nbActors);
    
    public  PxPruningStructurePtr createPruningStructure( actors, uint nbActors){
         pvk_in_actors = (actors);
        uint pvk_in_nbActors = (nbActors);
        PxPruningStructurePtr retVal = W_createPruningStructure_R_PxPruningStructurePtr_P__P_uint_C_PxPhysics(this, pvk_in_actors, pvk_in_nbActors);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       createShape                                                            #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxShapeFlags
    // NATIVE SIG: PxShape*	createShape(	const PxGeometry& geometry, 
    												const PxMaterial& material, 
    												bool isExclusive = false, 
    												PxShapeFlags shapeFlags = PxShapeFlag::eVISUALIZATION | PxShapeFlag::eSCENE_QUERY_SHAPE | PxShapeFlag::eSIMULATION_SHAPE)
    	{
    		PxMaterial* materialPtr = const_cast<PxMaterial*>(&material);
    		return createShape(geometry, &materialPtr, 1, isExclusive, shapeFlags);
    	}
    #if NATIVE //function start
    ES physx::PxShape* W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_P_bool_P__C_PxPhysics(physx::PxPhysics* self, physx::PxGeometry* geometry, physx::PxMaterial* material, bool isExclusive,  shapeFlags){
        auto nat_in_geometry = (geometry);
        auto nat_in_material = (material);
        auto nat_in_isExclusive = (isExclusive);
        auto nat_in_shapeFlags = (shapeFlags);
        auto retVal = self->createShape(*nat_in_geometry, *nat_in_material, nat_in_isExclusive, nat_in_shapeFlags);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_P_bool_P__C_PxPhysics(PxPhysicsPtr selfPtr, PxGeometryPtr geometry, PxMaterialPtr material, bool isExclusive,  shapeFlags);
    
    public  PxShapePtr createShape(PxGeometryPtr geometry, PxMaterialPtr material, bool isExclusive,  shapeFlags){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxMaterialPtr pvk_in_material = (material);
        bool pvk_in_isExclusive = (isExclusive);
         pvk_in_shapeFlags = (shapeFlags);
        PxShapePtr retVal = W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_P_bool_P__C_PxPhysics(this, pvk_in_geometry, pvk_in_material, pvk_in_isExclusive, pvk_in_shapeFlags);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES physx::PxShape* W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_P_bool_OL1_C_PxPhysics(physx::PxPhysics* self, physx::PxGeometry* geometry, physx::PxMaterial* material, bool isExclusive){
        auto nat_in_geometry = (geometry);
        auto nat_in_material = (material);
        auto nat_in_isExclusive = (isExclusive);
        auto retVal = self->createShape(*nat_in_geometry, *nat_in_material, nat_in_isExclusive);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_P_bool_OL1_C_PxPhysics(PxPhysicsPtr selfPtr, PxGeometryPtr geometry, PxMaterialPtr material, bool isExclusive);
    
    public  PxShapePtr createShape(PxGeometryPtr geometry, PxMaterialPtr material, bool isExclusive){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxMaterialPtr pvk_in_material = (material);
        bool pvk_in_isExclusive = (isExclusive);
        PxShapePtr retVal = W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_P_bool_OL1_C_PxPhysics(this, pvk_in_geometry, pvk_in_material, pvk_in_isExclusive);
        return retVal;
    }
    #endif //function end
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES physx::PxShape* W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_OL2_C_PxPhysics(physx::PxPhysics* self, physx::PxGeometry* geometry, physx::PxMaterial* material){
        auto nat_in_geometry = (geometry);
        auto nat_in_material = (material);
        auto retVal = self->createShape(*nat_in_geometry, *nat_in_material);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_OL2_C_PxPhysics(PxPhysicsPtr selfPtr, PxGeometryPtr geometry, PxMaterialPtr material);
    
    public  PxShapePtr createShape(PxGeometryPtr geometry, PxMaterialPtr material){
        PxGeometryPtr pvk_in_geometry = (geometry);
        PxMaterialPtr pvk_in_material = (material);
        PxShapePtr retVal = W_createShape_R_PxShapePtr_P_PxGeometryPtr_P_PxMaterialPtr_OL2_C_PxPhysics(this, pvk_in_geometry, pvk_in_material);
        return retVal;
    }
    #endif //function end
    
    
    
    
    //================================================================================
    //#       createShape                                                            #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    Unresolved parameter type physx::PxShapeFlags
    // NATIVE SIG: PxShape*			createShape(const PxGeometry& geometry, 
    											PxMaterial*const * materials, 
    											PxU16 materialCount, 
    											bool isExclusive = false,
    											PxShapeFlags shapeFlags = PxShapeFlag::eVISUALIZATION | PxShapeFlag::eSCENE_QUERY_SHAPE | PxShapeFlag::eSIMULATION_SHAPE) = 0
    #if NATIVE //function start
    ES physx::PxShape* W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_P_bool_P__C_PxPhysics(physx::PxPhysics* self, physx::PxGeometry* geometry,  materials, physx::PxU16 materialCount, bool isExclusive,  shapeFlags){
        auto nat_in_geometry = (geometry);
        auto nat_in_materials = (materials);
        auto nat_in_materialCount = (materialCount);
        auto nat_in_isExclusive = (isExclusive);
        auto nat_in_shapeFlags = (shapeFlags);
        auto retVal = self->createShape(*nat_in_geometry, nat_in_materials, nat_in_materialCount, nat_in_isExclusive, nat_in_shapeFlags);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_P_bool_P__C_PxPhysics(PxPhysicsPtr selfPtr, PxGeometryPtr geometry,  materials, ushort materialCount, bool isExclusive,  shapeFlags);
    
    public  PxShapePtr createShape(PxGeometryPtr geometry,  materials, ushort materialCount, bool isExclusive,  shapeFlags){
        PxGeometryPtr pvk_in_geometry = (geometry);
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        bool pvk_in_isExclusive = (isExclusive);
         pvk_in_shapeFlags = (shapeFlags);
        PxShapePtr retVal = W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_P_bool_P__C_PxPhysics(this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount, pvk_in_isExclusive, pvk_in_shapeFlags);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxShape*			createShape(const PxGeometry& geometry, 
    											PxMaterial*const * materials, 
    											PxU16 materialCount, 
    											bool isExclusive = false,
    											PxShapeFlags shapeFlags = PxShapeFlag::eVISUALIZATION | PxShapeFlag::eSCENE_QUERY_SHAPE | PxShapeFlag::eSIMULATION_SHAPE) = 0
    #if NATIVE //function start
    ES physx::PxShape* W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_P_bool_OL1_C_PxPhysics(physx::PxPhysics* self, physx::PxGeometry* geometry,  materials, physx::PxU16 materialCount, bool isExclusive){
        auto nat_in_geometry = (geometry);
        auto nat_in_materials = (materials);
        auto nat_in_materialCount = (materialCount);
        auto nat_in_isExclusive = (isExclusive);
        auto retVal = self->createShape(*nat_in_geometry, nat_in_materials, nat_in_materialCount, nat_in_isExclusive);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_P_bool_OL1_C_PxPhysics(PxPhysicsPtr selfPtr, PxGeometryPtr geometry,  materials, ushort materialCount, bool isExclusive);
    
    public  PxShapePtr createShape(PxGeometryPtr geometry,  materials, ushort materialCount, bool isExclusive){
        PxGeometryPtr pvk_in_geometry = (geometry);
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        bool pvk_in_isExclusive = (isExclusive);
        PxShapePtr retVal = W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_P_bool_OL1_C_PxPhysics(this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount, pvk_in_isExclusive);
        return retVal;
    }
    #endif //function end*/
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxShape*			createShape(const PxGeometry& geometry, 
    											PxMaterial*const * materials, 
    											PxU16 materialCount, 
    											bool isExclusive = false,
    											PxShapeFlags shapeFlags = PxShapeFlag::eVISUALIZATION | PxShapeFlag::eSCENE_QUERY_SHAPE | PxShapeFlag::eSIMULATION_SHAPE) = 0
    #if NATIVE //function start
    ES physx::PxShape* W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_OL2_C_PxPhysics(physx::PxPhysics* self, physx::PxGeometry* geometry,  materials, physx::PxU16 materialCount){
        auto nat_in_geometry = (geometry);
        auto nat_in_materials = (materials);
        auto nat_in_materialCount = (materialCount);
        auto retVal = self->createShape(*nat_in_geometry, nat_in_materials, nat_in_materialCount);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapePtr W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_OL2_C_PxPhysics(PxPhysicsPtr selfPtr, PxGeometryPtr geometry,  materials, ushort materialCount);
    
    public  PxShapePtr createShape(PxGeometryPtr geometry,  materials, ushort materialCount){
        PxGeometryPtr pvk_in_geometry = (geometry);
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        PxShapePtr retVal = W_createShape_R_PxShapePtr_P_PxGeometryPtr_P__P_ushort_OL2_C_PxPhysics(this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       getNbShapes                                                            #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbShapes_R_uint_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->getNbShapes();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbShapes_R_uint_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  uint getNbShapes(){
        uint retVal = W_getNbShapes_R_uint_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getShapes                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: PxU32				getShapes(PxShape** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getShapes_R_uint_P__P_uint_P_uint_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getShapes_R_uint_P__P_uint_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getShapes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getShapes_R_uint_P__P_uint_P_uint_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: PxU32				getShapes(PxShape** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getShapes_R_uint_P__P_uint_OL1_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getShapes_R_uint_P__P_uint_OL1_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getShapes( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getShapes_R_uint_P__P_uint_OL1_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       createConstraint                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxConstraintShaderTablePtr
    // NATIVE SIG: PxConstraint*      createConstraint(PxRigidActor* actor0, PxRigidActor* actor1, PxConstraintConnector& connector, const PxConstraintShaderTable& shaders, PxU32 dataSize)		= 0
    #if NATIVE //function start
    ES physx::PxConstraint* W_createConstraint_R_PxConstraintPtr_P_PxRigidActorPtr_P_PxRigidActorPtr_P_PxConstraintConnectorPtr_P_PxConstraintShaderTable_P_uint_C_PxPhysics(physx::PxPhysics* self, physx::PxRigidActor* actor0, physx::PxRigidActor* actor1, physx::PxConstraintConnector* connector, physx::PxConstraintShaderTable shaders, physx::PxU32 dataSize){
        auto nat_in_actor0 = (actor0);
        auto nat_in_actor1 = (actor1);
        auto nat_in_connector = (connector);
        auto nat_in_shaders = (shaders);
        auto nat_in_dataSize = (dataSize);
        auto retVal = self->createConstraint(nat_in_actor0, nat_in_actor1, *nat_in_connector, nat_in_shaders, nat_in_dataSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConstraintPtr W_createConstraint_R_PxConstraintPtr_P_PxRigidActorPtr_P_PxRigidActorPtr_P_PxConstraintConnectorPtr_P_PxConstraintShaderTable_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr, PxRigidActorPtr actor0, PxRigidActorPtr actor1, PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders, uint dataSize);
    
    public  PxConstraintPtr createConstraint(PxRigidActorPtr actor0, PxRigidActorPtr actor1, PxConstraintConnectorPtr connector, PxConstraintShaderTable shaders, uint dataSize){
        PxRigidActorPtr pvk_in_actor0 = (actor0);
        PxRigidActorPtr pvk_in_actor1 = (actor1);
        PxConstraintConnectorPtr pvk_in_connector = (connector);
        PxConstraintShaderTable pvk_in_shaders = (shaders);
        uint pvk_in_dataSize = (dataSize);
        PxConstraintPtr retVal = W_createConstraint_R_PxConstraintPtr_P_PxRigidActorPtr_P_PxRigidActorPtr_P_PxConstraintConnectorPtr_P_PxConstraintShaderTable_P_uint_C_PxPhysics(this, pvk_in_actor0, pvk_in_actor1, pvk_in_connector, pvk_in_shaders, pvk_in_dataSize);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       createArticulation                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxArticulation*						createArticulation() = 0
    #if NATIVE //function start
    ES physx::PxArticulation* W_createArticulation_R_PxArticulationPtr_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->createArticulation();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxArticulationPtr W_createArticulation_R_PxArticulationPtr_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  PxArticulationPtr createArticulation(){
        PxArticulationPtr retVal = W_createArticulation_R_PxArticulationPtr_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       createArticulationReducedCoordinate                                    #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxArticulationReducedCoordinate*	createArticulationReducedCoordinate() = 0
    #if NATIVE //function start
    ES physx::PxArticulationReducedCoordinate* W_createArticulationReducedCoordinate_R_PxArticulationReducedCoordinatePtr_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->createArticulationReducedCoordinate();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxArticulationReducedCoordinatePtr W_createArticulationReducedCoordinate_R_PxArticulationReducedCoordinatePtr_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  PxArticulationReducedCoordinatePtr createArticulationReducedCoordinate(){
        PxArticulationReducedCoordinatePtr retVal = W_createArticulationReducedCoordinate_R_PxArticulationReducedCoordinatePtr_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       createMaterial                                                         #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMaterial* W_createMaterial_R_PxMaterialPtr_P_float_P_float_P_float_C_PxPhysics(physx::PxPhysics* self, physx::PxReal staticFriction, physx::PxReal dynamicFriction, physx::PxReal restitution){
        auto nat_in_staticFriction = (staticFriction);
        auto nat_in_dynamicFriction = (dynamicFriction);
        auto nat_in_restitution = (restitution);
        auto retVal = self->createMaterial(nat_in_staticFriction, nat_in_dynamicFriction, nat_in_restitution);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMaterialPtr W_createMaterial_R_PxMaterialPtr_P_float_P_float_P_float_C_PxPhysics(PxPhysicsPtr selfPtr, float staticFriction, float dynamicFriction, float restitution);
    
    public  PxMaterialPtr createMaterial(float staticFriction, float dynamicFriction, float restitution){
        float pvk_in_staticFriction = (staticFriction);
        float pvk_in_dynamicFriction = (dynamicFriction);
        float pvk_in_restitution = (restitution);
        PxMaterialPtr retVal = W_createMaterial_R_PxMaterialPtr_P_float_P_float_P_float_C_PxPhysics(this, pvk_in_staticFriction, pvk_in_dynamicFriction, pvk_in_restitution);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNbMaterials                                                         #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbMaterials_R_uint_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = self->getNbMaterials();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbMaterials_R_uint_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  uint getNbMaterials(){
        uint retVal = W_getNbMaterials_R_uint_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32				getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getMaterials_R_uint_P__P_uint_P_uint_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaterials_R_uint_P__P_uint_P_uint_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getMaterials( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getMaterials_R_uint_P__P_uint_P_uint_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32				getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    #if NATIVE //function start
    ES physx::PxU32 W_getMaterials_R_uint_P__P_uint_OL1_C_PxPhysics(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaterials_R_uint_P__P_uint_OL1_C_PxPhysics(PxPhysicsPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getMaterials( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getMaterials_R_uint_P__P_uint_OL1_C_PxPhysics(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       registerDeletionListener                                               #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListenerPtr
    fsdfasdf
    // NATIVE SIG: void registerDeletionListener(PxDeletionListener& observer, const PxDeletionEventFlags& deletionEvents, bool restrictedObjectSet = false) = 0
    #if NATIVE //function start
    ES void W_registerDeletionListener_R_void_P_PxDeletionListenerPtr_P__P_bool_C_PxPhysics(physx::PxPhysics* self, physx::PxDeletionListener* observer,  deletionEvents, bool restrictedObjectSet){
        auto nat_in_observer = (observer);
        auto nat_in_deletionEvents = (deletionEvents);
        auto nat_in_restrictedObjectSet = (restrictedObjectSet);
        self->registerDeletionListener(*nat_in_observer, nat_in_deletionEvents, nat_in_restrictedObjectSet);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerDeletionListener_R_void_P_PxDeletionListenerPtr_P__P_bool_C_PxPhysics(PxPhysicsPtr selfPtr, PxDeletionListenerPtr observer,  deletionEvents, bool restrictedObjectSet);
    
    public  void registerDeletionListener(PxDeletionListenerPtr observer,  deletionEvents, bool restrictedObjectSet){
        PxDeletionListenerPtr pvk_in_observer = (observer);
         pvk_in_deletionEvents = (deletionEvents);
        bool pvk_in_restrictedObjectSet = (restrictedObjectSet);
        W_registerDeletionListener_R_void_P_PxDeletionListenerPtr_P__P_bool_C_PxPhysics(this, pvk_in_observer, pvk_in_deletionEvents, pvk_in_restrictedObjectSet);
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListenerPtr
    fsdfasdf
    // NATIVE SIG: void registerDeletionListener(PxDeletionListener& observer, const PxDeletionEventFlags& deletionEvents, bool restrictedObjectSet = false) = 0
    #if NATIVE //function start
    ES void W_registerDeletionListener_R_void_P_PxDeletionListenerPtr_P__OL1_C_PxPhysics(physx::PxPhysics* self, physx::PxDeletionListener* observer,  deletionEvents){
        auto nat_in_observer = (observer);
        auto nat_in_deletionEvents = (deletionEvents);
        self->registerDeletionListener(*nat_in_observer, nat_in_deletionEvents);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerDeletionListener_R_void_P_PxDeletionListenerPtr_P__OL1_C_PxPhysics(PxPhysicsPtr selfPtr, PxDeletionListenerPtr observer,  deletionEvents);
    
    public  void registerDeletionListener(PxDeletionListenerPtr observer,  deletionEvents){
        PxDeletionListenerPtr pvk_in_observer = (observer);
         pvk_in_deletionEvents = (deletionEvents);
        W_registerDeletionListener_R_void_P_PxDeletionListenerPtr_P__OL1_C_PxPhysics(this, pvk_in_observer, pvk_in_deletionEvents);
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       unregisterDeletionListener                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListenerPtr
    // NATIVE SIG: void unregisterDeletionListener(PxDeletionListener& observer) = 0
    #if NATIVE //function start
    ES void W_unregisterDeletionListener_R_void_P_PxDeletionListenerPtr_C_PxPhysics(physx::PxPhysics* self, physx::PxDeletionListener* observer){
        auto nat_in_observer = (observer);
        self->unregisterDeletionListener(*nat_in_observer);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_unregisterDeletionListener_R_void_P_PxDeletionListenerPtr_C_PxPhysics(PxPhysicsPtr selfPtr, PxDeletionListenerPtr observer);
    
    public  void unregisterDeletionListener(PxDeletionListenerPtr observer){
        PxDeletionListenerPtr pvk_in_observer = (observer);
        W_unregisterDeletionListener_R_void_P_PxDeletionListenerPtr_C_PxPhysics(this, pvk_in_observer);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       registerDeletionListenerObjects                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListenerPtr
    Unresolved parameter pointee const physx::PxBase*
    // NATIVE SIG: void registerDeletionListenerObjects(PxDeletionListener& observer, const PxBase* const* observables, PxU32 observableCount) = 0
    #if NATIVE //function start
    ES void W_registerDeletionListenerObjects_R_void_P_PxDeletionListenerPtr_P__P_uint_C_PxPhysics(physx::PxPhysics* self, physx::PxDeletionListener* observer,  observables, physx::PxU32 observableCount){
        auto nat_in_observer = (observer);
        auto nat_in_observables = (observables);
        auto nat_in_observableCount = (observableCount);
        self->registerDeletionListenerObjects(*nat_in_observer, nat_in_observables, nat_in_observableCount);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerDeletionListenerObjects_R_void_P_PxDeletionListenerPtr_P__P_uint_C_PxPhysics(PxPhysicsPtr selfPtr, PxDeletionListenerPtr observer,  observables, uint observableCount);
    
    public  void registerDeletionListenerObjects(PxDeletionListenerPtr observer,  observables, uint observableCount){
        PxDeletionListenerPtr pvk_in_observer = (observer);
         pvk_in_observables = (observables);
        uint pvk_in_observableCount = (observableCount);
        W_registerDeletionListenerObjects_R_void_P_PxDeletionListenerPtr_P__P_uint_C_PxPhysics(this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       unregisterDeletionListenerObjects                                      #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListenerPtr
    Unresolved parameter pointee const physx::PxBase*
    // NATIVE SIG: void unregisterDeletionListenerObjects(PxDeletionListener& observer, const PxBase* const* observables, PxU32 observableCount) = 0
    #if NATIVE //function start
    ES void W_unregisterDeletionListenerObjects_R_void_P_PxDeletionListenerPtr_P__P_uint_C_PxPhysics(physx::PxPhysics* self, physx::PxDeletionListener* observer,  observables, physx::PxU32 observableCount){
        auto nat_in_observer = (observer);
        auto nat_in_observables = (observables);
        auto nat_in_observableCount = (observableCount);
        self->unregisterDeletionListenerObjects(*nat_in_observer, nat_in_observables, nat_in_observableCount);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_unregisterDeletionListenerObjects_R_void_P_PxDeletionListenerPtr_P__P_uint_C_PxPhysics(PxPhysicsPtr selfPtr, PxDeletionListenerPtr observer,  observables, uint observableCount);
    
    public  void unregisterDeletionListenerObjects(PxDeletionListenerPtr observer,  observables, uint observableCount){
        PxDeletionListenerPtr pvk_in_observer = (observer);
         pvk_in_observables = (observables);
        uint pvk_in_observableCount = (observableCount);
        W_unregisterDeletionListenerObjects_R_void_P_PxDeletionListenerPtr_P__P_uint_C_PxPhysics(this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getPhysicsInsertionCallback                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxPhysicsInsertionCallback& getPhysicsInsertionCallback() = 0
    #if NATIVE //function start
    ES physx::PxPhysicsInsertionCallback* W_getPhysicsInsertionCallback_R_PxPhysicsInsertionCallbackPtr_C_PxPhysics(physx::PxPhysics* self){
        auto retVal = &self->getPhysicsInsertionCallback();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPhysicsInsertionCallbackPtr W_getPhysicsInsertionCallback_R_PxPhysicsInsertionCallbackPtr_C_PxPhysics(PxPhysicsPtr selfPtr);
    
    public  PxPhysicsInsertionCallbackPtr getPhysicsInsertionCallback(){
        PxPhysicsInsertionCallbackPtr retVal = W_getPhysicsInsertionCallback_R_PxPhysicsInsertionCallbackPtr_C_PxPhysics(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxPhysics
    
    //Skipped generated implicit entry: PxPhysics
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxBVHStructure Manually Ignored
// Class physx::PxPruningStructure Manually Ignored
// Class physx::PxPhysicsInsertionCallback Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxPvdPtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxPvdPtr : IPxPvdPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxPvdPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close
