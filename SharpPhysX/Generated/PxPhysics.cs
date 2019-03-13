#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxPhysics { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxPhysics                                                             #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L79~79
    #if NATIVE
    ES void ~PxPhysics(physx::PxPhysics* self){
        self->~PxPhysics();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxPhysics(PxPhysics selfPtr);
    
    public void ~PxPhysics(){
        ~PxPhysics(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L99~99
    #if NATIVE
    ES void release(physx::PxPhysics* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void release(PxPhysics selfPtr);
    
    public void release(){
        release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getFoundation                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L105~105
    #if NATIVE
    ES UNPARSED_TYPE getFoundation(physx::PxPhysics* self){
        UNPARSED_TYPE retVal = self->getFoundation();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getFoundation(PxPhysics selfPtr);
    
    public UNPARSED_TYPE getFoundation(){
        UNPARSED_TYPE retVal = getFoundation(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createAggregate                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L116~116
    #if NATIVE
    ES UNPARSED_TYPE createAggregate(physx::PxPhysics* self, physx::PxU32 maxSize, bool enableSelfCollision){
        physx::PxU32 nat_in_maxSize = (maxSize);
        bool nat_in_enableSelfCollision = (enableSelfCollision);
        UNPARSED_TYPE retVal = self->createAggregate(nat_in_maxSize, nat_in_enableSelfCollision);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createAggregate(PxPhysics selfPtr, uint maxSize, bool enableSelfCollision);
    
    public UNPARSED_TYPE createAggregate(uint maxSize, bool enableSelfCollision){
        uint pvk_in_maxSize = (maxSize);
        bool pvk_in_enableSelfCollision = (enableSelfCollision);
        UNPARSED_TYPE retVal = createAggregate(this, pvk_in_maxSize, pvk_in_enableSelfCollision);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTolerancesScale                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L122~122
    #if NATIVE
    ES UNPARSED_TYPE getTolerancesScale(physx::PxPhysics* self){
        UNPARSED_TYPE retVal = self->getTolerancesScale();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getTolerancesScale(PxPhysics selfPtr);
    
    public UNPARSED_TYPE getTolerancesScale(){
        UNPARSED_TYPE retVal = getTolerancesScale(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createTriangleMesh                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L139~139
    #if NATIVE
    ES UNPARSED_TYPE createTriangleMesh(physx::PxPhysics* self,  stream){
         nat_in_stream = (stream);
        UNPARSED_TYPE retVal = self->createTriangleMesh(nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createTriangleMesh(PxPhysics selfPtr,  stream);
    
    public UNPARSED_TYPE createTriangleMesh( stream){
         pvk_in_stream = (stream);
        UNPARSED_TYPE retVal = createTriangleMesh(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbTriangleMeshes                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L148~148
    #if NATIVE
    ES physx::PxU32 getNbTriangleMeshes(physx::PxPhysics* self){
        physx::PxU32 retVal = self->getNbTriangleMeshes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbTriangleMeshes(PxPhysics selfPtr);
    
    public uint getNbTriangleMeshes(){
        uint retVal = getNbTriangleMeshes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTriangleMeshes                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxTriangleMesh*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L164~164
    #if NATIVE
    ES physx::PxU32 getTriangleMeshes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getTriangleMeshes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getTriangleMeshes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getTriangleMeshes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getTriangleMeshes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createHeightField                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L176~176
    #if NATIVE
    ES UNPARSED_TYPE createHeightField(physx::PxPhysics* self,  stream){
         nat_in_stream = (stream);
        UNPARSED_TYPE retVal = self->createHeightField(nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createHeightField(PxPhysics selfPtr,  stream);
    
    public UNPARSED_TYPE createHeightField( stream){
         pvk_in_stream = (stream);
        UNPARSED_TYPE retVal = createHeightField(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbHeightFields                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L185~185
    #if NATIVE
    ES physx::PxU32 getNbHeightFields(physx::PxPhysics* self){
        physx::PxU32 retVal = self->getNbHeightFields();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbHeightFields(PxPhysics selfPtr);
    
    public uint getNbHeightFields(){
        uint retVal = getNbHeightFields(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getHeightFields                                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxHeightField*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L201~201
    #if NATIVE
    ES physx::PxU32 getHeightFields(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getHeightFields(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getHeightFields(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getHeightFields( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getHeightFields(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createConvexMesh                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L213~213
    #if NATIVE
    ES UNPARSED_TYPE createConvexMesh(physx::PxPhysics* self,  stream){
         nat_in_stream = (stream);
        UNPARSED_TYPE retVal = self->createConvexMesh(nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createConvexMesh(PxPhysics selfPtr,  stream);
    
    public UNPARSED_TYPE createConvexMesh( stream){
         pvk_in_stream = (stream);
        UNPARSED_TYPE retVal = createConvexMesh(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbConvexMeshes                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L222~222
    #if NATIVE
    ES physx::PxU32 getNbConvexMeshes(physx::PxPhysics* self){
        physx::PxU32 retVal = self->getNbConvexMeshes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbConvexMeshes(PxPhysics selfPtr);
    
    public uint getNbConvexMeshes(){
        uint retVal = getNbConvexMeshes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConvexMeshes                                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConvexMesh*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L238~238
    #if NATIVE
    ES physx::PxU32 getConvexMeshes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getConvexMeshes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getConvexMeshes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getConvexMeshes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getConvexMeshes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createBVHStructure                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L248~248
    #if NATIVE
    ES UNPARSED_TYPE createBVHStructure(physx::PxPhysics* self,  stream){
         nat_in_stream = (stream);
        UNPARSED_TYPE retVal = self->createBVHStructure(nat_in_stream);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createBVHStructure(PxPhysics selfPtr,  stream);
    
    public UNPARSED_TYPE createBVHStructure( stream){
         pvk_in_stream = (stream);
        UNPARSED_TYPE retVal = createBVHStructure(this, pvk_in_stream);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbBVHStructures                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L257~257
    #if NATIVE
    ES physx::PxU32 getNbBVHStructures(physx::PxPhysics* self){
        physx::PxU32 retVal = self->getNbBVHStructures();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbBVHStructures(PxPhysics selfPtr);
    
    public uint getNbBVHStructures(){
        uint retVal = getNbBVHStructures(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBVHStructures                                                       #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxBVHStructure*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L273~273
    #if NATIVE
    ES physx::PxU32 getBVHStructures(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getBVHStructures(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getBVHStructures(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getBVHStructures( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getBVHStructures(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createScene                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L291~291
    #if NATIVE
    ES UNPARSED_TYPE createScene(physx::PxPhysics* self,  sceneDesc){
         nat_in_sceneDesc = (sceneDesc);
        UNPARSED_TYPE retVal = self->createScene(nat_in_sceneDesc);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createScene(PxPhysics selfPtr,  sceneDesc);
    
    public UNPARSED_TYPE createScene( sceneDesc){
         pvk_in_sceneDesc = (sceneDesc);
        UNPARSED_TYPE retVal = createScene(this, pvk_in_sceneDesc);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbScenes                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L300~300
    #if NATIVE
    ES physx::PxU32 getNbScenes(physx::PxPhysics* self){
        physx::PxU32 retVal = self->getNbScenes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbScenes(PxPhysics selfPtr);
    
    public uint getNbScenes(){
        uint retVal = getNbScenes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getScenes                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxScene*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L316~316
    #if NATIVE
    ES physx::PxU32 getScenes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getScenes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getScenes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getScenes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getScenes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createRigidStatic                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L331~331
    #if NATIVE
    ES UNPARSED_TYPE createRigidStatic(physx::PxPhysics* self, physx::PxTransform pose){
        physx::PxTransform nat_in_pose = (pose);
        UNPARSED_TYPE retVal = self->createRigidStatic(nat_in_pose);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createRigidStatic(PxPhysics selfPtr, PxTransform pose);
    
    public UNPARSED_TYPE createRigidStatic(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        UNPARSED_TYPE retVal = createRigidStatic(this, pvk_in_pose);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createRigidDynamic                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L341~341
    #if NATIVE
    ES UNPARSED_TYPE createRigidDynamic(physx::PxPhysics* self, physx::PxTransform pose){
        physx::PxTransform nat_in_pose = (pose);
        UNPARSED_TYPE retVal = self->createRigidDynamic(nat_in_pose);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createRigidDynamic(PxPhysics selfPtr, PxTransform pose);
    
    public UNPARSED_TYPE createRigidDynamic(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        UNPARSED_TYPE retVal = createRigidDynamic(this, pvk_in_pose);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createPruningStructure                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter pointee physx::PxRigidActor*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L356~356
    #if NATIVE
    ES UNPARSED_TYPE createPruningStructure(physx::PxPhysics* self,  actors, physx::PxU32 nbActors){
         nat_in_actors = (actors);
        physx::PxU32 nat_in_nbActors = (nbActors);
        UNPARSED_TYPE retVal = self->createPruningStructure(nat_in_actors, nat_in_nbActors);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createPruningStructure(PxPhysics selfPtr,  actors, uint nbActors);
    
    public UNPARSED_TYPE createPruningStructure( actors, uint nbActors){
         pvk_in_actors = (actors);
        uint pvk_in_nbActors = (nbActors);
        UNPARSED_TYPE retVal = createPruningStructure(this, pvk_in_actors, pvk_in_nbActors);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createShape                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    , fsdfasdf
    , Unresolved parameter type physx::PxPhysics::createShape::shapeFlags
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L377~384
    #if NATIVE
    ES UNPARSED_TYPE createShape(physx::PxPhysics* self,  geometry,  material, bool isExclusive,  shapeFlags){
         nat_in_geometry = (geometry);
         nat_in_material = (material);
        bool nat_in_isExclusive = (isExclusive);
         nat_in_shapeFlags = (shapeFlags);
        UNPARSED_TYPE retVal = self->createShape(nat_in_geometry, nat_in_material, nat_in_isExclusive, nat_in_shapeFlags);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createShape(PxPhysics selfPtr,  geometry,  material, bool isExclusive,  shapeFlags);
    
    public UNPARSED_TYPE createShape( geometry,  material, bool isExclusive,  shapeFlags){
         pvk_in_geometry = (geometry);
         pvk_in_material = (material);
        bool pvk_in_isExclusive = (isExclusive);
         pvk_in_shapeFlags = (shapeFlags);
        UNPARSED_TYPE retVal = createShape(this, pvk_in_geometry, pvk_in_material, pvk_in_isExclusive, pvk_in_shapeFlags);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createShape                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    , Unresolved parameter pointee physx::PxMaterial*
    , Unresolved parameter type physx::PxPhysics::createShape::shapeFlags
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L401~405
    #if NATIVE
    ES UNPARSED_TYPE createShape(physx::PxPhysics* self,  geometry,  materials, physx::PxU16 materialCount, bool isExclusive,  shapeFlags){
         nat_in_geometry = (geometry);
         nat_in_materials = (materials);
        physx::PxU16 nat_in_materialCount = (materialCount);
        bool nat_in_isExclusive = (isExclusive);
         nat_in_shapeFlags = (shapeFlags);
        UNPARSED_TYPE retVal = self->createShape(nat_in_geometry, nat_in_materials, nat_in_materialCount, nat_in_isExclusive, nat_in_shapeFlags);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createShape(PxPhysics selfPtr,  geometry,  materials, ushort materialCount, bool isExclusive,  shapeFlags);
    
    public UNPARSED_TYPE createShape( geometry,  materials, ushort materialCount, bool isExclusive,  shapeFlags){
         pvk_in_geometry = (geometry);
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        bool pvk_in_isExclusive = (isExclusive);
         pvk_in_shapeFlags = (shapeFlags);
        UNPARSED_TYPE retVal = createShape(this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount, pvk_in_isExclusive, pvk_in_shapeFlags);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbShapes                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L414~414
    #if NATIVE
    ES physx::PxU32 getNbShapes(physx::PxPhysics* self){
        physx::PxU32 retVal = self->getNbShapes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbShapes(PxPhysics selfPtr);
    
    public uint getNbShapes(){
        uint retVal = getNbShapes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getShapes                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L430~430
    #if NATIVE
    ES physx::PxU32 getShapes(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getShapes(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getShapes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getShapes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createConstraint                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    , fsdfasdf
    , fsdfasdf
    , fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L453~453
    #if NATIVE
    ES UNPARSED_TYPE createConstraint(physx::PxPhysics* self,  actor0,  actor1,  connector,  shaders, physx::PxU32 dataSize){
         nat_in_actor0 = (actor0);
         nat_in_actor1 = (actor1);
         nat_in_connector = (connector);
         nat_in_shaders = (shaders);
        physx::PxU32 nat_in_dataSize = (dataSize);
        UNPARSED_TYPE retVal = self->createConstraint(nat_in_actor0, nat_in_actor1, nat_in_connector, nat_in_shaders, nat_in_dataSize);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createConstraint(PxPhysics selfPtr,  actor0,  actor1,  connector,  shaders, uint dataSize);
    
    public UNPARSED_TYPE createConstraint( actor0,  actor1,  connector,  shaders, uint dataSize){
         pvk_in_actor0 = (actor0);
         pvk_in_actor1 = (actor1);
         pvk_in_connector = (connector);
         pvk_in_shaders = (shaders);
        uint pvk_in_dataSize = (dataSize);
        UNPARSED_TYPE retVal = createConstraint(this, pvk_in_actor0, pvk_in_actor1, pvk_in_connector, pvk_in_shaders, pvk_in_dataSize);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createArticulation                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L462~462
    #if NATIVE
    ES UNPARSED_TYPE createArticulation(physx::PxPhysics* self){
        UNPARSED_TYPE retVal = self->createArticulation();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createArticulation(PxPhysics selfPtr);
    
    public UNPARSED_TYPE createArticulation(){
        UNPARSED_TYPE retVal = createArticulation(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createArticulationReducedCoordinate                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L471~471
    #if NATIVE
    ES UNPARSED_TYPE createArticulationReducedCoordinate(physx::PxPhysics* self){
        UNPARSED_TYPE retVal = self->createArticulationReducedCoordinate();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createArticulationReducedCoordinate(PxPhysics selfPtr);
    
    public UNPARSED_TYPE createArticulationReducedCoordinate(){
        UNPARSED_TYPE retVal = createArticulationReducedCoordinate(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createMaterial                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L490~490
    #if NATIVE
    ES UNPARSED_TYPE createMaterial(physx::PxPhysics* self, physx::PxReal staticFriction, physx::PxReal dynamicFriction, physx::PxReal restitution){
        physx::PxReal nat_in_staticFriction = (staticFriction);
        physx::PxReal nat_in_dynamicFriction = (dynamicFriction);
        physx::PxReal nat_in_restitution = (restitution);
        UNPARSED_TYPE retVal = self->createMaterial(nat_in_staticFriction, nat_in_dynamicFriction, nat_in_restitution);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE createMaterial(PxPhysics selfPtr, float staticFriction, float dynamicFriction, float restitution);
    
    public UNPARSED_TYPE createMaterial(float staticFriction, float dynamicFriction, float restitution){
        float pvk_in_staticFriction = (staticFriction);
        float pvk_in_dynamicFriction = (dynamicFriction);
        float pvk_in_restitution = (restitution);
        UNPARSED_TYPE retVal = createMaterial(this, pvk_in_staticFriction, pvk_in_dynamicFriction, pvk_in_restitution);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbMaterials                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L500~500
    #if NATIVE
    ES physx::PxU32 getNbMaterials(physx::PxPhysics* self){
        physx::PxU32 retVal = self->getNbMaterials();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbMaterials(PxPhysics selfPtr);
    
    public uint getNbMaterials(){
        uint retVal = getNbMaterials(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L516~516
    #if NATIVE
    ES physx::PxU32 getMaterials(physx::PxPhysics* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getMaterials(PxPhysics selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getMaterials( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getMaterials(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       registerDeletionListener                                               #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    , fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L538~538
    #if NATIVE
    ES void registerDeletionListener(physx::PxPhysics* self,  observer,  deletionEvents, bool restrictedObjectSet){
         nat_in_observer = (observer);
         nat_in_deletionEvents = (deletionEvents);
        bool nat_in_restrictedObjectSet = (restrictedObjectSet);
        self->registerDeletionListener(nat_in_observer, nat_in_deletionEvents, nat_in_restrictedObjectSet);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void registerDeletionListener(PxPhysics selfPtr,  observer,  deletionEvents, bool restrictedObjectSet);
    
    public void registerDeletionListener( observer,  deletionEvents, bool restrictedObjectSet){
         pvk_in_observer = (observer);
         pvk_in_deletionEvents = (deletionEvents);
        bool pvk_in_restrictedObjectSet = (restrictedObjectSet);
        registerDeletionListener(this, pvk_in_observer, pvk_in_deletionEvents, pvk_in_restrictedObjectSet);
    }
    #endif*/
    
    
    //================================================================================
    //#       unregisterDeletionListener                                             #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L549~549
    #if NATIVE
    ES void unregisterDeletionListener(physx::PxPhysics* self,  observer){
         nat_in_observer = (observer);
        self->unregisterDeletionListener(nat_in_observer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void unregisterDeletionListener(PxPhysics selfPtr,  observer);
    
    public void unregisterDeletionListener( observer){
         pvk_in_observer = (observer);
        unregisterDeletionListener(this, pvk_in_observer);
    }
    #endif*/
    
    
    //================================================================================
    //#       registerDeletionListenerObjects                                        #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    , Unresolved parameter pointee const physx::PxBase*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L566~566
    #if NATIVE
    ES void registerDeletionListenerObjects(physx::PxPhysics* self,  observer,  observables, physx::PxU32 observableCount){
         nat_in_observer = (observer);
         nat_in_observables = (observables);
        physx::PxU32 nat_in_observableCount = (observableCount);
        self->registerDeletionListenerObjects(nat_in_observer, nat_in_observables, nat_in_observableCount);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void registerDeletionListenerObjects(PxPhysics selfPtr,  observer,  observables, uint observableCount);
    
    public void registerDeletionListenerObjects( observer,  observables, uint observableCount){
         pvk_in_observer = (observer);
         pvk_in_observables = (observables);
        uint pvk_in_observableCount = (observableCount);
        registerDeletionListenerObjects(this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
    }
    #endif*/
    
    
    //================================================================================
    //#       unregisterDeletionListenerObjects                                      #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    , Unresolved parameter pointee const physx::PxBase*
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L583~583
    #if NATIVE
    ES void unregisterDeletionListenerObjects(physx::PxPhysics* self,  observer,  observables, physx::PxU32 observableCount){
         nat_in_observer = (observer);
         nat_in_observables = (observables);
        physx::PxU32 nat_in_observableCount = (observableCount);
        self->unregisterDeletionListenerObjects(nat_in_observer, nat_in_observables, nat_in_observableCount);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void unregisterDeletionListenerObjects(PxPhysics selfPtr,  observer,  observables, uint observableCount);
    
    public void unregisterDeletionListenerObjects( observer,  observables, uint observableCount){
         pvk_in_observer = (observer);
         pvk_in_observables = (observables);
        uint pvk_in_observableCount = (observableCount);
        unregisterDeletionListenerObjects(this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
    }
    #endif*/
    
    
    //================================================================================
    //#       getPhysicsInsertionCallback                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L593~593
    #if NATIVE
    ES UNPARSED_TYPE getPhysicsInsertionCallback(physx::PxPhysics* self){
        UNPARSED_TYPE retVal = self->getPhysicsInsertionCallback();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getPhysicsInsertionCallback(PxPhysics selfPtr);
    
    public UNPARSED_TYPE getPhysicsInsertionCallback(){
        UNPARSED_TYPE retVal = getPhysicsInsertionCallback(this);
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L71~71
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxPhysics* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxPhysics selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPhysics                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L71~71
    #if NATIVE
    ES UNPARSED_TYPE PxPhysics_ctor(){
        self->PxPhysics();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPhysics_ctor();
    
    public PxPhysics(){
        var _new = PxPhysics_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPhysics                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxPhysics.h L71~71
    #if NATIVE
    ES UNPARSED_TYPE PxPhysics_ctor( ){
         nat_in_ = ();
        self->PxPhysics(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPhysics_ctor( );
    
    public PxPhysics( ){
         pvk_in_ = ();
        var _new = PxPhysics_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif







