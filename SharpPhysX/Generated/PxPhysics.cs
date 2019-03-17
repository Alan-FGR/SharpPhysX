#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxPhysics {
#endif

//================================================================================
//#       PxRegisterArticulations                                                #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L609~609
#if NATIVE
ES void W_PxRegisterArticulations(physx::PxPhysics* physics){
    auto nat_in_physics = (physics);
    PxRegisterArticulations(*nat_in_physics);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxRegisterArticulations(PxPhysics physics);

public static void PxRegisterArticulations(PxPhysics physics){
    PxPhysics pvk_in_physics = (physics);
    W_PxRegisterArticulations(pvk_in_physics);
}
#endif


//================================================================================
//#       PxRegisterArticulationsReducedCoordinate                               #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L619~619
#if NATIVE
ES void W_PxRegisterArticulationsReducedCoordinate(physx::PxPhysics* physics){
    auto nat_in_physics = (physics);
    PxRegisterArticulationsReducedCoordinate(*nat_in_physics);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxRegisterArticulationsReducedCoordinate(PxPhysics physics);

public static void PxRegisterArticulationsReducedCoordinate(PxPhysics physics){
    PxPhysics pvk_in_physics = (physics);
    W_PxRegisterArticulationsReducedCoordinate(pvk_in_physics);
}
#endif


//================================================================================
//#       PxRegisterHeightFields                                                 #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L638~638
#if NATIVE
ES void W_PxRegisterHeightFields(physx::PxPhysics* physics){
    auto nat_in_physics = (physics);
    PxRegisterHeightFields(*nat_in_physics);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxRegisterHeightFields(PxPhysics physics);

public static void PxRegisterHeightFields(PxPhysics physics){
    PxPhysics pvk_in_physics = (physics);
    W_PxRegisterHeightFields(pvk_in_physics);
}
#endif


//================================================================================
//#       PxCreateBasePhysics                                                    #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScale
// NATIVE SIG: physx::PxPhysics* PX_CALL_CONV PxCreateBasePhysics(physx::PxU32 version,
																			     physx::PxFoundation& foundation,
																			     const physx::PxTolerancesScale& scale,																				 
																			     bool trackOutstandingAllocations = false,
																				 physx::PxPvd* pvd = NULL)
// SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L661~665
#if NATIVE
ES physx::PxPhysics* W_PxCreateBasePhysics(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale, bool trackOutstandingAllocations, physx::PxPvd* pvd){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto nat_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    auto nat_in_pvd = (pvd);
    auto retVal = PxCreateBasePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale, nat_in_trackOutstandingAllocations, nat_in_pvd);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysics W_PxCreateBasePhysics(uint version, PxFoundation foundation, PxTolerancesScale scale, bool trackOutstandingAllocations, PxPvd pvd);

public static PxPhysics PxCreateBasePhysics(uint version, PxFoundation foundation, PxTolerancesScale scale, bool trackOutstandingAllocations, PxPvd pvd){
    uint pvk_in_version = (version);
    PxFoundation pvk_in_foundation = (foundation);
    PxTolerancesScale pvk_in_scale = (scale);
    bool pvk_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    PxPvd pvk_in_pvd = (pvd);
    PxPhysics retVal = W_PxCreateBasePhysics(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations, pvk_in_pvd);
    return retVal;
}
#endif*/


//================================================================================
//#       PxCreatePhysics                                                        #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxTolerancesScale
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
// SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L692~707
#if NATIVE
ES physx::PxPhysics* W_PxCreatePhysics(physx::PxU32 version, physx::PxFoundation* foundation, physx::PxTolerancesScale* scale, bool trackOutstandingAllocations, physx::PxPvd* pvd){
    auto nat_in_version = (version);
    auto nat_in_foundation = (foundation);
    auto nat_in_scale = (scale);
    auto nat_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    auto nat_in_pvd = (pvd);
    auto retVal = PxCreatePhysics(nat_in_version, *nat_in_foundation, *nat_in_scale, nat_in_trackOutstandingAllocations, nat_in_pvd);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysics W_PxCreatePhysics(uint version, PxFoundation foundation, PxTolerancesScale scale, bool trackOutstandingAllocations, PxPvd pvd);

public static PxPhysics PxCreatePhysics(uint version, PxFoundation foundation, PxTolerancesScale scale, bool trackOutstandingAllocations, PxPvd pvd){
    uint pvk_in_version = (version);
    PxFoundation pvk_in_foundation = (foundation);
    PxTolerancesScale pvk_in_scale = (scale);
    bool pvk_in_trackOutstandingAllocations = (trackOutstandingAllocations);
    PxPvd pvk_in_pvd = (pvd);
    PxPhysics retVal = W_PxCreatePhysics(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations, pvk_in_pvd);
    return retVal;
}
#endif*/


//================================================================================
//#       PxGetPhysics                                                           #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L722~722
#if NATIVE
ES physx::PxPhysics* W_PxGetPhysics(){
    auto retVal = &PxGetPhysics();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysics W_PxGetPhysics();

public static PxPhysics PxGetPhysics(){
    PxPhysics retVal = W_PxGetPhysics();
    return retVal;
}
#endif

#if !NATIVE
} // End PxPhysics
#endif


#if !NATIVE
public unsafe partial struct PxPhysics { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxPhysics                                                             #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxPhysics() {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L79~79
    #if NATIVE
    ES void W_~PxPhysics(physx::PxPhysics* self){
        self->~PxPhysics();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxPhysics(PxPhysics selfPtr);
    
    public void ~PxPhysics(){
        W_~PxPhysics(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L99~99
    #if NATIVE
    ES void W_release(physx::PxPhysics* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxPhysics selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getFoundation                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L105~105
    #if NATIVE
    ES physx::PxFoundation* W_getFoundation(physx::PxPhysics* self){
        auto retVal = &self->getFoundation();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFoundation W_getFoundation(PxPhysics selfPtr);
    
    public PxFoundation getFoundation(){
        PxFoundation retVal = W_getFoundation(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       createAggregate                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxAggregate*		createAggregate(PxU32 maxSize, bool enableSelfCollision)	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L116~116
    #if NATIVE
    ES physx::PxAggregate* W_createAggregate(physx::PxPhysics* self, physx::PxU32 maxSize, bool enableSelfCollision){
        auto nat_in_maxSize = (maxSize);
        auto nat_in_enableSelfCollision = (enableSelfCollision);
        auto retVal = self->createAggregate(nat_in_maxSize, nat_in_enableSelfCollision);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAggregate W_createAggregate(PxPhysics selfPtr, uint maxSize, bool enableSelfCollision);
    
    public PxAggregate createAggregate(uint maxSize, bool enableSelfCollision){
        uint pvk_in_maxSize = (maxSize);
        bool pvk_in_enableSelfCollision = (enableSelfCollision);
        PxAggregate retVal = W_createAggregate(this, pvk_in_maxSize, pvk_in_enableSelfCollision);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTolerancesScale                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxTolerancesScale&		getTolerancesScale() const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L122~122
    #if NATIVE
    ES physx::PxTolerancesScale* W_getTolerancesScale(physx::PxPhysics* self){
        auto retVal = &self->getTolerancesScale();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTolerancesScale W_getTolerancesScale(PxPhysics selfPtr);
    
    public PxTolerancesScale getTolerancesScale(){
        PxTolerancesScale retVal = W_getTolerancesScale(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createTriangleMesh                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxInputStream
    // NATIVE SIG: PxTriangleMesh*    createTriangleMesh(PxInputStream& stream) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L139~139
    #if NATIVE
    ES physx::PxTriangleMesh* W_createTriangleMesh(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createTriangleMesh(*nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTriangleMesh W_createTriangleMesh(PxPhysics selfPtr, PxInputStream stream);
    
    public PxTriangleMesh createTriangleMesh(PxInputStream stream){
        PxInputStream pvk_in_stream = (stream);
        PxTriangleMesh retVal = W_createTriangleMesh(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbTriangleMeshes                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L148~148
    #if NATIVE
    ES physx::PxU32 W_getNbTriangleMeshes(physx::PxPhysics* self){
        auto retVal = self->getNbTriangleMeshes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbTriangleMeshes(PxPhysics selfPtr);
    
    public uint getNbTriangleMeshes(){
        uint retVal = W_getNbTriangleMeshes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTriangleMeshes                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxTriangleMesh*
    // NATIVE SIG: PxU32				getTriangleMeshes(PxTriangleMesh** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L164~164
    #if NATIVE
    ES physx::PxU32 W_getTriangleMeshes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getTriangleMeshes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getTriangleMeshes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getTriangleMeshes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getTriangleMeshes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createHeightField                                                      #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Forbidden parameter type: PxInputStream
    // NATIVE SIG: PxHeightField*		createHeightField(PxInputStream& stream) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L176~176
    #if NATIVE
    ES physx::PxHeightField* W_createHeightField(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createHeightField(*nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightField W_createHeightField(PxPhysics selfPtr, PxInputStream stream);
    
    public PxHeightField createHeightField(PxInputStream stream){
        PxInputStream pvk_in_stream = (stream);
        PxHeightField retVal = W_createHeightField(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbHeightFields                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L185~185
    #if NATIVE
    ES physx::PxU32 W_getNbHeightFields(physx::PxPhysics* self){
        auto retVal = self->getNbHeightFields();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbHeightFields(PxPhysics selfPtr);
    
    public uint getNbHeightFields(){
        uint retVal = W_getNbHeightFields(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getHeightFields                                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxHeightField*
    // NATIVE SIG: PxU32				getHeightFields(PxHeightField** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L201~201
    #if NATIVE
    ES physx::PxU32 W_getHeightFields(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getHeightFields(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getHeightFields(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getHeightFields( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getHeightFields(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createConvexMesh                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Forbidden parameter type: PxInputStream
    // NATIVE SIG: PxConvexMesh*		createConvexMesh(PxInputStream &stream)					= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L213~213
    #if NATIVE
    ES physx::PxConvexMesh* W_createConvexMesh(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createConvexMesh(*nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMesh W_createConvexMesh(PxPhysics selfPtr, PxInputStream stream);
    
    public PxConvexMesh createConvexMesh(PxInputStream stream){
        PxInputStream pvk_in_stream = (stream);
        PxConvexMesh retVal = W_createConvexMesh(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbConvexMeshes                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L222~222
    #if NATIVE
    ES physx::PxU32 W_getNbConvexMeshes(physx::PxPhysics* self){
        auto retVal = self->getNbConvexMeshes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbConvexMeshes(PxPhysics selfPtr);
    
    public uint getNbConvexMeshes(){
        uint retVal = W_getNbConvexMeshes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConvexMeshes                                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConvexMesh*
    // NATIVE SIG: PxU32				getConvexMeshes(PxConvexMesh** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L238~238
    #if NATIVE
    ES physx::PxU32 W_getConvexMeshes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getConvexMeshes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConvexMeshes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getConvexMeshes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getConvexMeshes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createBVHStructure                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Forbidden parameter type: PxInputStream
    // NATIVE SIG: PxBVHStructure*		createBVHStructure(PxInputStream &stream)					= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L248~248
    #if NATIVE
    ES physx::PxBVHStructure* W_createBVHStructure(physx::PxPhysics* self, physx::PxInputStream* stream){
        auto nat_in_stream = (stream);
        auto retVal = self->createBVHStructure(*nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBVHStructure W_createBVHStructure(PxPhysics selfPtr, PxInputStream stream);
    
    public PxBVHStructure createBVHStructure(PxInputStream stream){
        PxInputStream pvk_in_stream = (stream);
        PxBVHStructure retVal = W_createBVHStructure(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbBVHStructures                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L257~257
    #if NATIVE
    ES physx::PxU32 W_getNbBVHStructures(physx::PxPhysics* self){
        auto retVal = self->getNbBVHStructures();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbBVHStructures(PxPhysics selfPtr);
    
    public uint getNbBVHStructures(){
        uint retVal = W_getNbBVHStructures(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBVHStructures                                                       #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxBVHStructure*
    // NATIVE SIG: PxU32				getBVHStructures(PxBVHStructure** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L273~273
    #if NATIVE
    ES physx::PxU32 W_getBVHStructures(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getBVHStructures(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getBVHStructures(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getBVHStructures( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getBVHStructures(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createScene                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L291~291
    #if NATIVE
    ES physx::PxScene* W_createScene(physx::PxPhysics* self, physx::PxSceneDesc* sceneDesc){
        auto nat_in_sceneDesc = (sceneDesc);
        auto retVal = self->createScene(*nat_in_sceneDesc);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxScene W_createScene(PxPhysics selfPtr, PxSceneDesc sceneDesc);
    
    public PxScene createScene(PxSceneDesc sceneDesc){
        PxSceneDesc pvk_in_sceneDesc = (sceneDesc);
        PxScene retVal = W_createScene(this, pvk_in_sceneDesc);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbScenes                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L300~300
    #if NATIVE
    ES physx::PxU32 W_getNbScenes(physx::PxPhysics* self){
        auto retVal = self->getNbScenes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbScenes(PxPhysics selfPtr);
    
    public uint getNbScenes(){
        uint retVal = W_getNbScenes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getScenes                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxScene*
    // NATIVE SIG: PxU32				getScenes(PxScene** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L316~316
    #if NATIVE
    ES physx::PxU32 W_getScenes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getScenes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getScenes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getScenes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getScenes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createRigidStatic                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L331~331
    #if NATIVE
    ES physx::PxRigidStatic* W_createRigidStatic(physx::PxPhysics* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        auto retVal = self->createRigidStatic(nat_in_pose);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidStatic W_createRigidStatic(PxPhysics selfPtr, PxTransform pose);
    
    public PxRigidStatic createRigidStatic(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        PxRigidStatic retVal = W_createRigidStatic(this, pvk_in_pose);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       createRigidDynamic                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L341~341
    #if NATIVE
    ES physx::PxRigidDynamic* W_createRigidDynamic(physx::PxPhysics* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        auto retVal = self->createRigidDynamic(nat_in_pose);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidDynamic W_createRigidDynamic(PxPhysics selfPtr, PxTransform pose);
    
    public PxRigidDynamic createRigidDynamic(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        PxRigidDynamic retVal = W_createRigidDynamic(this, pvk_in_pose);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       createPruningStructure                                                 #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    Unresolved parameter pointee physx::PxRigidActor*
    // NATIVE SIG: PxPruningStructure*	createPruningStructure(PxRigidActor*const* actors, PxU32 nbActors)	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L356~356
    #if NATIVE
    ES physx::PxPruningStructure* W_createPruningStructure(physx::PxPhysics* self,  actors, physx::PxU32 nbActors){
        auto nat_in_actors = (actors);
        auto nat_in_nbActors = (nbActors);
        auto retVal = self->createPruningStructure(nat_in_actors, nat_in_nbActors);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPruningStructure W_createPruningStructure(PxPhysics selfPtr,  actors, uint nbActors);
    
    public PxPruningStructure createPruningStructure( actors, uint nbActors){
         pvk_in_actors = (actors);
        uint pvk_in_nbActors = (nbActors);
        PxPruningStructure retVal = W_createPruningStructure(this, pvk_in_actors, pvk_in_nbActors);
        return retVal;
    }
    #endif*/
    
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L377~384
    #if NATIVE
    ES physx::PxShape* W_createShape(physx::PxPhysics* self, physx::PxGeometry* geometry, physx::PxMaterial* material, bool isExclusive,  shapeFlags){
        auto nat_in_geometry = (geometry);
        auto nat_in_material = (material);
        auto nat_in_isExclusive = (isExclusive);
        auto nat_in_shapeFlags = (shapeFlags);
        auto retVal = self->createShape(*nat_in_geometry, *nat_in_material, nat_in_isExclusive, nat_in_shapeFlags);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShape W_createShape(PxPhysics selfPtr, PxGeometry geometry, PxMaterial material, bool isExclusive,  shapeFlags);
    
    public PxShape createShape(PxGeometry geometry, PxMaterial material, bool isExclusive,  shapeFlags){
        PxGeometry pvk_in_geometry = (geometry);
        PxMaterial pvk_in_material = (material);
        bool pvk_in_isExclusive = (isExclusive);
         pvk_in_shapeFlags = (shapeFlags);
        PxShape retVal = W_createShape(this, pvk_in_geometry, pvk_in_material, pvk_in_isExclusive, pvk_in_shapeFlags);
        return retVal;
    }
    #endif*/
    
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L401~405
    #if NATIVE
    ES physx::PxShape* W_createShape(physx::PxPhysics* self, physx::PxGeometry* geometry,  materials, physx::PxU16 materialCount, bool isExclusive,  shapeFlags){
        auto nat_in_geometry = (geometry);
        auto nat_in_materials = (materials);
        auto nat_in_materialCount = (materialCount);
        auto nat_in_isExclusive = (isExclusive);
        auto nat_in_shapeFlags = (shapeFlags);
        auto retVal = self->createShape(*nat_in_geometry, nat_in_materials, nat_in_materialCount, nat_in_isExclusive, nat_in_shapeFlags);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShape W_createShape(PxPhysics selfPtr, PxGeometry geometry,  materials, ushort materialCount, bool isExclusive,  shapeFlags);
    
    public PxShape createShape(PxGeometry geometry,  materials, ushort materialCount, bool isExclusive,  shapeFlags){
        PxGeometry pvk_in_geometry = (geometry);
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        bool pvk_in_isExclusive = (isExclusive);
         pvk_in_shapeFlags = (shapeFlags);
        PxShape retVal = W_createShape(this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount, pvk_in_isExclusive, pvk_in_shapeFlags);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbShapes                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L414~414
    #if NATIVE
    ES physx::PxU32 W_getNbShapes(physx::PxPhysics* self){
        auto retVal = self->getNbShapes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbShapes(PxPhysics selfPtr);
    
    public uint getNbShapes(){
        uint retVal = W_getNbShapes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getShapes                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: PxU32				getShapes(PxShape** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L430~430
    #if NATIVE
    ES physx::PxU32 W_getShapes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getShapes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getShapes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getShapes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createConstraint                                                       #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxConstraintShaderTable
    // NATIVE SIG: PxConstraint*      createConstraint(PxRigidActor* actor0, PxRigidActor* actor1, PxConstraintConnector& connector, const PxConstraintShaderTable& shaders, PxU32 dataSize)		= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L453~453
    #if NATIVE
    ES physx::PxConstraint* W_createConstraint(physx::PxPhysics* self, physx::PxRigidActor* actor0, physx::PxRigidActor* actor1, physx::PxConstraintConnector* connector, physx::PxConstraintShaderTable shaders, physx::PxU32 dataSize){
        auto nat_in_actor0 = (actor0);
        auto nat_in_actor1 = (actor1);
        auto nat_in_connector = (connector);
        auto nat_in_shaders = (shaders);
        auto nat_in_dataSize = (dataSize);
        auto retVal = self->createConstraint(nat_in_actor0, nat_in_actor1, *nat_in_connector, nat_in_shaders, nat_in_dataSize);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConstraint W_createConstraint(PxPhysics selfPtr, PxRigidActor actor0, PxRigidActor actor1, PxConstraintConnector connector, PxConstraintShaderTable shaders, uint dataSize);
    
    public PxConstraint createConstraint(PxRigidActor actor0, PxRigidActor actor1, PxConstraintConnector connector, PxConstraintShaderTable shaders, uint dataSize){
        PxRigidActor pvk_in_actor0 = (actor0);
        PxRigidActor pvk_in_actor1 = (actor1);
        PxConstraintConnector pvk_in_connector = (connector);
        PxConstraintShaderTable pvk_in_shaders = (shaders);
        uint pvk_in_dataSize = (dataSize);
        PxConstraint retVal = W_createConstraint(this, pvk_in_actor0, pvk_in_actor1, pvk_in_connector, pvk_in_shaders, pvk_in_dataSize);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createArticulation                                                     #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxArticulation*						createArticulation() = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L462~462
    #if NATIVE
    ES physx::PxArticulation* W_createArticulation(physx::PxPhysics* self){
        auto retVal = self->createArticulation();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxArticulation W_createArticulation(PxPhysics selfPtr);
    
    public PxArticulation createArticulation(){
        PxArticulation retVal = W_createArticulation(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createArticulationReducedCoordinate                                    #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxArticulationReducedCoordinate*	createArticulationReducedCoordinate() = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L471~471
    #if NATIVE
    ES physx::PxArticulationReducedCoordinate* W_createArticulationReducedCoordinate(physx::PxPhysics* self){
        auto retVal = self->createArticulationReducedCoordinate();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxArticulationReducedCoordinate W_createArticulationReducedCoordinate(PxPhysics selfPtr);
    
    public PxArticulationReducedCoordinate createArticulationReducedCoordinate(){
        PxArticulationReducedCoordinate retVal = W_createArticulationReducedCoordinate(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createMaterial                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L490~490
    #if NATIVE
    ES physx::PxMaterial* W_createMaterial(physx::PxPhysics* self, physx::PxReal staticFriction, physx::PxReal dynamicFriction, physx::PxReal restitution){
        auto nat_in_staticFriction = (staticFriction);
        auto nat_in_dynamicFriction = (dynamicFriction);
        auto nat_in_restitution = (restitution);
        auto retVal = self->createMaterial(nat_in_staticFriction, nat_in_dynamicFriction, nat_in_restitution);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMaterial W_createMaterial(PxPhysics selfPtr, float staticFriction, float dynamicFriction, float restitution);
    
    public PxMaterial createMaterial(float staticFriction, float dynamicFriction, float restitution){
        float pvk_in_staticFriction = (staticFriction);
        float pvk_in_dynamicFriction = (dynamicFriction);
        float pvk_in_restitution = (restitution);
        PxMaterial retVal = W_createMaterial(this, pvk_in_staticFriction, pvk_in_dynamicFriction, pvk_in_restitution);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbMaterials                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L500~500
    #if NATIVE
    ES physx::PxU32 W_getNbMaterials(physx::PxPhysics* self){
        auto retVal = self->getNbMaterials();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbMaterials(PxPhysics selfPtr);
    
    public uint getNbMaterials(){
        uint retVal = W_getNbMaterials(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32				getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L516~516
    #if NATIVE
    ES physx::PxU32 W_getMaterials(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaterials(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getMaterials( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getMaterials(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       registerDeletionListener                                               #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListener
    fsdfasdf
    // NATIVE SIG: void registerDeletionListener(PxDeletionListener& observer, const PxDeletionEventFlags& deletionEvents, bool restrictedObjectSet = false) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L538~538
    #if NATIVE
    ES void W_registerDeletionListener(physx::PxPhysics* self, physx::PxDeletionListener* observer,  deletionEvents, bool restrictedObjectSet){
        auto nat_in_observer = (observer);
        auto nat_in_deletionEvents = (deletionEvents);
        auto nat_in_restrictedObjectSet = (restrictedObjectSet);
        self->registerDeletionListener(*nat_in_observer, nat_in_deletionEvents, nat_in_restrictedObjectSet);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerDeletionListener(PxPhysics selfPtr, PxDeletionListener observer,  deletionEvents, bool restrictedObjectSet);
    
    public void registerDeletionListener(PxDeletionListener observer,  deletionEvents, bool restrictedObjectSet){
        PxDeletionListener pvk_in_observer = (observer);
         pvk_in_deletionEvents = (deletionEvents);
        bool pvk_in_restrictedObjectSet = (restrictedObjectSet);
        W_registerDeletionListener(this, pvk_in_observer, pvk_in_deletionEvents, pvk_in_restrictedObjectSet);
    }
    #endif*/
    
    
    //================================================================================
    //#       unregisterDeletionListener                                             #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListener
    // NATIVE SIG: void unregisterDeletionListener(PxDeletionListener& observer) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L549~549
    #if NATIVE
    ES void W_unregisterDeletionListener(physx::PxPhysics* self, physx::PxDeletionListener* observer){
        auto nat_in_observer = (observer);
        self->unregisterDeletionListener(*nat_in_observer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_unregisterDeletionListener(PxPhysics selfPtr, PxDeletionListener observer);
    
    public void unregisterDeletionListener(PxDeletionListener observer){
        PxDeletionListener pvk_in_observer = (observer);
        W_unregisterDeletionListener(this, pvk_in_observer);
    }
    #endif*/
    
    
    //================================================================================
    //#       registerDeletionListenerObjects                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListener
    Unresolved parameter pointee const physx::PxBase*
    // NATIVE SIG: void registerDeletionListenerObjects(PxDeletionListener& observer, const PxBase* const* observables, PxU32 observableCount) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L566~566
    #if NATIVE
    ES void W_registerDeletionListenerObjects(physx::PxPhysics* self, physx::PxDeletionListener* observer,  observables, physx::PxU32 observableCount){
        auto nat_in_observer = (observer);
        auto nat_in_observables = (observables);
        auto nat_in_observableCount = (observableCount);
        self->registerDeletionListenerObjects(*nat_in_observer, nat_in_observables, nat_in_observableCount);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerDeletionListenerObjects(PxPhysics selfPtr, PxDeletionListener observer,  observables, uint observableCount);
    
    public void registerDeletionListenerObjects(PxDeletionListener observer,  observables, uint observableCount){
        PxDeletionListener pvk_in_observer = (observer);
         pvk_in_observables = (observables);
        uint pvk_in_observableCount = (observableCount);
        W_registerDeletionListenerObjects(this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
    }
    #endif*/
    
    
    //================================================================================
    //#       unregisterDeletionListenerObjects                                      #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxDeletionListener
    Unresolved parameter pointee const physx::PxBase*
    // NATIVE SIG: void unregisterDeletionListenerObjects(PxDeletionListener& observer, const PxBase* const* observables, PxU32 observableCount) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L583~583
    #if NATIVE
    ES void W_unregisterDeletionListenerObjects(physx::PxPhysics* self, physx::PxDeletionListener* observer,  observables, physx::PxU32 observableCount){
        auto nat_in_observer = (observer);
        auto nat_in_observables = (observables);
        auto nat_in_observableCount = (observableCount);
        self->unregisterDeletionListenerObjects(*nat_in_observer, nat_in_observables, nat_in_observableCount);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_unregisterDeletionListenerObjects(PxPhysics selfPtr, PxDeletionListener observer,  observables, uint observableCount);
    
    public void unregisterDeletionListenerObjects(PxDeletionListener observer,  observables, uint observableCount){
        PxDeletionListener pvk_in_observer = (observer);
         pvk_in_observables = (observables);
        uint pvk_in_observableCount = (observableCount);
        W_unregisterDeletionListenerObjects(this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
    }
    #endif*/
    
    
    //================================================================================
    //#       getPhysicsInsertionCallback                                            #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxPhysicsInsertionCallback& getPhysicsInsertionCallback() = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L593~593
    #if NATIVE
    ES physx::PxPhysicsInsertionCallback* W_getPhysicsInsertionCallback(physx::PxPhysics* self){
        auto retVal = &self->getPhysicsInsertionCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPhysicsInsertionCallback W_getPhysicsInsertionCallback(PxPhysics selfPtr);
    
    public PxPhysicsInsertionCallback getPhysicsInsertionCallback(){
        PxPhysicsInsertionCallback retVal = W_getPhysicsInsertionCallback(this);
        return retVal;
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxPhysics
    
    //Skipped generated implicit entry: PxPhysics
    

#if !NATIVE
}
#endif

// Class physx::PxBVHStructure Manually Ignored
// Class physx::PxPruningStructure Manually Ignored
// Class physx::PxPhysicsInsertionCallback Manually Ignored
