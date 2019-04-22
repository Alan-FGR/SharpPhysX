//###################################################################
//
// This is a direct port of the official HelloWorldSnippet.cpp
// Commented lines are the original C++ code for reference
//
//###################################################################

//using namespace physx;
using static physx;

class SampleHelloWorld
{
    //PxDefaultErrorCallback gErrorCallback;
    SharpPhysXErrorFptr gErrorCallback = SharpPhysX.DefaultErrorCallback;

    //PxFoundation* gFoundation = NULL;
    //PxPhysics* gPhysics = NULL;
    PxFoundationPtr gFoundation;
    PxPhysicsPtr gPhysics;

    //PxDefaultCpuDispatcher* gDispatcher = NULL;
    //PxScene* gScene = NULL;
    PxDefaultCpuDispatcherPtr gDispatcher;
    PxScenePtr gScene;

    //PxMaterial* gMaterial = NULL;
    PxMaterialPtr gMaterial;

    //PxReal stackZ = 10.0f;
    float stackZ = 10;

    //PxRigidDynamic* createDynamic(const PxTransform& t, const PxGeometry& geometry, const PxVec3& velocity=PxVec3(0)){
    PxRigidDynamicPtr createDynamic(PxTransform t, PxGeometry.Ref geometry, PxVec3 velocity)
    {
        //PxRigidDynamic* dynamic = PxCreateDynamic(*gPhysics, t, geometry, *gMaterial, 10.0f);
        //dynamic->setAngularDamping(0.5f);
        //dynamic->setLinearVelocity(velocity);
        //gScene->addActor(*dynamic);
        //return dynamic;
        PxRigidDynamicPtr dynamic = PxCreateDynamic(gPhysics, t, geometry, gMaterial, 10);
        dynamic.setAngularDamping(.5f);
        dynamic.setLinearVelocity(velocity);
        gScene.addActor(dynamic);
        return dynamic;
    }

    //void createStack(const PxTransform& t, PxU32 size, PxReal halfExtent){
    void createStack(PxTransform t, uint size, float halfExtent)
    {
        //PxShape* shape = gPhysics->createShape(PxBoxGeometry(halfExtent, halfExtent, halfExtent), *gMaterial);
        PxShapePtr shape = gPhysics.createShape(new PxBoxGeometry(halfExtent, halfExtent, halfExtent), gMaterial);
        //for(PxU32 i=0; i<size;i++){
        // for(PxU32 j=0;j<size-i;j++){
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size-i; j++)
            {
                //PxTransform localTm(PxVec3(PxReal(j*2) - PxReal(size-i), PxReal(i*2+1), 0) * halfExtent);
                //PxRigidDynamic* body = gPhysics->createRigidDynamic(t.transform(localTm));
                //body->attachShape(*shape);
                //PxRigidBodyExt::updateMassAndInertia(*body, 10.0f);
                //gScene->addActor(*body);
                PxTransform localTm = new PxTransform(new PxVec3(((j * 2) - (size - i)) * halfExtent, (i * 2 + 1) * halfExtent, 0));
                PxRigidDynamicPtr body = gPhysics.createRigidDynamic(t.transform(localTm));
                body.attachShape(shape);
                PxRigidBodyExt.updateMassAndInertia(body, 10);
                gScene.addActor(body);
            }
        }
        //shape->release();
        shape.release();
    }

    //void initPhysics(bool interactive){
    void initPhysics(bool interactive)
    {
        //gFoundation = PxCreateFoundation(PX_PHYSICS_VERSION, gAllocator, gErrorCallback);
        gFoundation = SharpPhysX.CreateFoundation(gErrorCallback, PX_PHYSICS_VERSION);

        //gPhysics = PxCreatePhysics(PX_PHYSICS_VERSION, *gFoundation, PxTolerancesScale(),true,gPvd);
        gPhysics = PxPhysics.PxCreatePhysics(PX_PHYSICS_VERSION, gFoundation, PxTolerancesScale.Default());

        //PxSceneDesc sceneDesc(gPhysics->getTolerancesScale());
        //sceneDesc.gravity = PxVec3(0.0f, -9.81f, 0.0f);
        //gDispatcher = PxDefaultCpuDispatcherCreate(2);
        //sceneDesc.cpuDispatcher = gDispatcher;
        //sceneDesc.filterShader = PxDefaultSimulationFilterShader;
        //gScene = gPhysics->createScene(sceneDesc);
        var sceneDesc = PxSceneDescPtr.New(PxTolerancesScale.Default());
        sceneDesc.gravity = new PxVec3(0, -9.81f, 0);
        gDispatcher = PxDefaultCpuDispatcherCreate(2);
        sceneDesc.cpuDispatcher = gDispatcher;
        sceneDesc.filterShader = PxDefaultSimulationFilterShader;
        gScene = gPhysics.createScene(sceneDesc);

        //gMaterial = gPhysics->createMaterial(0.5f, 0.5f, 0.6f);
        gMaterial = gPhysics.createMaterial(.5f, .5f, .6f);

        //PxRigidStatic* groundPlane = PxCreatePlane(*gPhysics, PxPlane(0,1,0,0), *gMaterial);
        //gScene->addActor(*groundPlane);
        var groundPlane = PxCreatePlane(gPhysics, new PxPlane(0, 1, 0, 0), gMaterial);
        gScene.addActor(groundPlane);

        //for(PxU32 i=0;i<5;i++)
        // createStack(PxTransform(PxVec3(0,0,stackZ-=10.0f)), 10, 2.0f);
        for (int i = 0; i < 5; i++)
            createStack(new PxTransform(new PxVec3(0, 0, stackZ -= 10)), 10, 2);

        //if(!interactive)
        // createDynamic(PxTransform(PxVec3(0,40,100)), PxSphereGeometry(10), PxVec3(0,-50,-100));
        if (!interactive)
            DEBUG = createDynamic(new PxTransform(new PxVec3(0, 40, 100)), new PxSphereGeometry(10), new PxVec3(0, -50, -100));
    }

    PxRigidDynamicPtr DEBUG;

    //void stepPhysics(bool /*interactive*/){
    void stepPhysics(bool interactive)
    {
        //gScene->simulate(1.0f/60.0f);
        //gScene->fetchResults(true);
        gScene.simulate(1 / 60f);
        gScene.fetchResults(true);

        var p = DEBUG.getGlobalPose().p;
        System.Console.WriteLine($"{p.x}, {p.y}, {p.z}");
    }

    //void cleanupPhysics(bool /*interactive*/){
    void cleanupPhysics(bool interactive)
    {
        //PX_RELEASE(gScene);
        //PX_RELEASE(gDispatcher);
        //PX_RELEASE(gPhysics);
        //PX_RELEASE(gFoundation);
        gScene.release();
        gDispatcher.release();
        gPhysics.release();
        gFoundation.release();

        //printf("SnippetHelloWorld done.\n");
        System.Console.WriteLine("SnippetHelloWorld done.");
    }

    //int snippetMain(int, const char*const*)
    public SampleHelloWorld(bool render = false)
    {
        //static const PxU32 frameCount = 100;
        //initPhysics(false);
        const uint frameCount = 1;//100;
        initPhysics(false);

        //SharpPhysX Debug Renderer - no equivalent C++ line
        if (render) DebugRenderer.InitFor(gScene);

        //for(PxU32 i=0; i<frameCount; i++)
        // stepPhysics(false);
        //cleanupPhysics(false);
        for (int i = 0; i < frameCount; i++)
        {
            stepPhysics(false);
            if (render) DebugRenderer.Update(); //SharpPhysX Debug Renderer
        }

        cleanupPhysics(false);
    }
}


