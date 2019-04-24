using System;
using System.Threading;

//###################################################################
//
// This is a direct port of the official SnippetMultiThreading.cpp
// Commented lines are the original C++ code for reference
//
//###################################################################

//using namespace physx;
using static physx;

class SampleMultiThreading
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

    //struct RaycastThread
    //{
    //    SnippetUtils::Sync*		mWorkReadySyncHandle;
    //    SnippetUtils::Thread*	mThreadHandle;
    //};
    struct RaycastThread
    {
        public SpinLock mWorkReadySyncHandle;
        public Thread 	mThreadHandle;
    }
    
    //const PxU32				 gNumThreads = 1;
    //RaycastThread			 gThreads[gNumThreads];
    const int gNumThreads = 1;
    RaycastThread[] gThreads = new RaycastThread[gNumThreads];
    
    //SnippetUtils::Sync*		 gWorkDoneSyncHandle;
    SpinLock gWorkDoneSyncHandle;

    //const PxI32				 gRayCount = 1024;
    //volatile PxI32			 gRaysAvailable;
    //volatile PxI32			 gRaysCompleted;
    const int gRayCount = 1024;
    volatile int gRaysAvailable;
    volatile int gRaysCompleted;
    
    //static PxVec3 randVec3() 
    //{
    //    return (PxVec3(float(rand())/RAND_MAX,
    //        float(rand())/RAND_MAX, 
    //        float(rand())/RAND_MAX)*2.0f - PxVec3(1.0f)).getNormalized(); 
    //}
    static Random rng = new Random();
    static PxVec3 randVec3()
    {
        return (new PxVec3((float)rng.Next()/int.MaxValue,
            (float)rng.Next()/int.MaxValue,
            (float)rng.Next()/int.MaxValue)*2 - new PxVec3(1)).getNormalized();
    }

    //static void threadExecute(void* data)
    static void threadExecute(RaycastThread data)
    {
        //RaycastThread* raycastThread = static_cast<RaycastThread*>(data);
        RaycastThread raycastThread = data;

        //// Perform random raycasts against the scene until stop.
        //for(;;)
        for (;;)
        {
            //// Wait here for the sync to be set then reset the sync
            //// to ensure that we only perform raycast work after the 
            //// sync has been set again.
            //SnippetUtils::syncWait(raycastThread->mWorkReadySyncHandle);
            //SnippetUtils::syncReset(raycastThread->mWorkReadySyncHandle);


            //// If the thread has been signaled to quit then exit this function.
            //if (SnippetUtils::threadQuitIsSignalled(raycastThread->mThreadHandle))
            //break;

            //// Perform a fixed number of random raycasts against the scene
            //// and share the work between multiple threads.
            //while (SnippetUtils::atomicDecrement(&gRaysAvailable) >= 0)
            {
                //PxVec3 dir = randVec3();

                //PxRaycastBuffer buf;
                //gScene->raycast(PxVec3(0.0f), dir.getNormalized(), 1000.0f, buf, PxHitFlag::eDEFAULT);

                //// If this is the last raycast then signal this to the main thread.
                //if (SnippetUtils::atomicIncrement(&gRaysCompleted) == gRayCount)

                {
                //	SnippetUtils::syncSet(gWorkDoneSyncHandle);
                }
            }
        }

        //// Quit the current thread.
        //SnippetUtils::threadQuit(raycastThread->mThreadHandle);
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

    //void createPhysicsAndScene()
    void createPhysicsAndScene()
    {
        //gFoundation = PxCreateFoundation(PX_PHYSICS_VERSION, gAllocator, gErrorCallback);
        gFoundation = SharpPhysX.CreateFoundation(gErrorCallback, PX_PHYSICS_VERSION);

        //gPhysics = PxCreatePhysics(PX_PHYSICS_VERSION, *gFoundation, PxTolerancesScale(),true,gPvd);
        gPhysics = PxPhysics.PxCreatePhysics(PX_PHYSICS_VERSION, gFoundation, PxTolerancesScale.Default());

        //gMaterial = gPhysics->createMaterial(0.5f, 0.5f, 0.6f);
        gMaterial = gPhysics.createMaterial(.5f, .5f, .6f);
        
        //PxSceneDesc sceneDesc(gPhysics->getTolerancesScale());
        //sceneDesc.gravity = PxVec3(0.0f, -9.81f, 0.0f);
        var sceneDesc = PxSceneDescPtr.New(PxTolerancesScale.Default());
        sceneDesc.gravity = new PxVec3(0, -9.81f, 0);
        
        //PxU32 numCores = SnippetUtils::getNbPhysicalCores();
        //gDispatcher = PxDefaultCpuDispatcherCreate(numCores == 0 ? 0 : numCores - 1);
        //sceneDesc.cpuDispatcher	= gDispatcher;
        //sceneDesc.filterShader	= PxDefaultSimulationFilterShader;
        uint numCores = 4; //TODO
        gDispatcher = PxDefaultCpuDispatcherCreate(numCores);
        sceneDesc.cpuDispatcher = gDispatcher;
        sceneDesc.filterShader = PxDefaultSimulationFilterShader;

        //gScene = gPhysics->createScene(sceneDesc);
        gScene = gPhysics.createScene(sceneDesc);

        //PxRigidStatic* groundPlane = PxCreatePlane(*gPhysics, PxPlane(0,1,0,0), *gMaterial);
        //gScene->addActor(*groundPlane);
        var groundPlane = PxCreatePlane(gPhysics, new PxPlane(0, 1, 0, 0), gMaterial);
        gScene.addActor(groundPlane);

        //for(PxU32 i=0;i<5;i++)
        //createStack(PxTransform(PxVec3(0,0,i*10.0f)), 10, 2.0f);
        for (int i = 0; i < 5; i++)
            createStack(new PxTransform(new PxVec3(0, 0, i*10)), 10, 2);
    }

    //void createRaycastThreads()
    void createRaycastThreads()
    {
        //// Create and start threads that will perform raycasts.
        //// Create a sync for each thread so that a signal may be sent
        //// from the main thread to the raycast thread that it can start 
        //// performing raycasts.
        //for (PxU32 i=0; i < gNumThreads; ++i)
        for (uint i = 0; i < gNumThreads; ++i)
        {
            ////Create a sync.
            //gThreads[i].mWorkReadySyncHandle = SnippetUtils::syncCreate();
            gThreads[i].mWorkReadySyncHandle = new SpinLock();

            ////Create and start a thread.
            //gThreads[i].mThreadHandle =  SnippetUtils::threadCreate(threadExecute, &gThreads[i]);
            //gThreads[i].mThreadHandle = new Thread();
        }

        //// Create another sync so that the raycast threads can signal to the main 
        //// thread that they have finished performing their raycasts.
        //gWorkDoneSyncHandle = SnippetUtils::syncCreate();
    }

    //void initPhysics()
    void initPhysics()
    {
        //createPhysicsAndScene();
        //createRaycastThreads();
        createPhysicsAndScene();

    }

    //void stepPhysics()
    void stepPhysics()
    {
        //// Start simulation
        //gScene->simulate(1.0f/60.0f);
        gScene.simulate(1/60f);

        //// Start ray-cast threads
        //gRaysAvailable = gRayCount;
        //gRaysCompleted = 0;
        gRaysAvailable = gRayCount;
        gRaysCompleted = 0;

        //// Signal to each raycast thread that they can start performing raycasts.
        //for (PxU32 i=0; i < gNumThreads; ++i)
        for (uint i=0; i < gNumThreads; ++i)
        {
            //SnippetUtils::syncSet(gThreads[i].mWorkReadySyncHandle);
        }

        //// Wait for raycast threads to finish.
        //SnippetUtils::syncWait(gWorkDoneSyncHandle);
        //SnippetUtils::syncReset(gWorkDoneSyncHandle);

        //// Fetch simulation results
        //gScene->fetchResults(true);
    }

    //void cleanupPhysics()
    //{
    //// Signal threads to quit.
    //for (PxU32 i=0; i < gNumThreads; ++i)
    //{
    //SnippetUtils::threadSignalQuit(gThreads[i].mThreadHandle);
    //SnippetUtils::syncSet(gThreads[i].mWorkReadySyncHandle);
    //}

    //// Clean up raycast threads and syncs.
    //for (PxU32 i=0; i < gNumThreads; ++i)
    //{
    //SnippetUtils::threadWaitForQuit(gThreads[i].mThreadHandle);
    //SnippetUtils::threadRelease(gThreads[i].mThreadHandle);
    //SnippetUtils::syncRelease(gThreads[i].mWorkReadySyncHandle);
    //}

    //// Clean up the sync for the main thread.
    //SnippetUtils::syncRelease(gWorkDoneSyncHandle);

    //PX_RELEASE(gScene);

    //PX_RELEASE(gDispatcher);

    //PX_RELEASE(gPhysics);
    //if(gPvd)
    //{
    //PxPvdTransport* transport = gPvd->getTransport();
    //gPvd->release();	gPvd = NULL;
    //PX_RELEASE(transport);
    //}

    //PX_RELEASE(gFoundation);

    //printf("SnippetMultiThreading done.\n");
    //}


    //int snippetMain(int, const char*const*)
    public SampleMultiThreading()
    {
        //initPhysics();

        //for(PxU32 i=0; i<100; ++i)
        //stepPhysics();

        //cleanupPhysics();
    }
}