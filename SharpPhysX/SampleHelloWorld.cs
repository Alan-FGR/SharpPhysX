﻿//using namespace physx;

public class SampleHelloWorld
{

//PxDefaultAllocator		gAllocator;
//PxDefaultErrorCallback	gErrorCallback;

//PxFoundation*			gFoundation = NULL;
//PxPhysics*				gPhysics	= NULL;

//PxDefaultCpuDispatcher*	gDispatcher = NULL;
//PxScene*				gScene		= NULL;

//PxMaterial*				gMaterial	= NULL;

//PxPvd*                  gPvd        = NULL;

//PxReal stackZ = 10.0f;

//PxRigidDynamic* createDynamic(const PxTransform& t, const PxGeometry& geometry, const PxVec3& velocity=PxVec3(0))
//{
//	PxRigidDynamic* dynamic = PxCreateDynamic(*gPhysics, t, geometry, *gMaterial, 10.0f);
//	dynamic->setAngularDamping(0.5f);
//	dynamic->setLinearVelocity(velocity);
//	gScene->addActor(*dynamic);
//	return dynamic;
//}

//void createStack(const PxTransform& t, PxU32 size, PxReal halfExtent)
//{
//	PxShape* shape = gPhysics->createShape(PxBoxGeometry(halfExtent, halfExtent, halfExtent), *gMaterial);
//	for(PxU32 i=0; i<size;i++)
//	{
//		for(PxU32 j=0;j<size-i;j++)
//		{
//			PxTransform localTm(PxVec3(PxReal(j*2) - PxReal(size-i), PxReal(i*2+1), 0) * halfExtent);
//			PxRigidDynamic* body = gPhysics->createRigidDynamic(t.transform(localTm));
//			body->attachShape(*shape);
//			PxRigidBodyExt::updateMassAndInertia(*body, 10.0f);
//			gScene->addActor(*body);
//		}
//	}
//	shape->release();
//}

    private PxFoundation foundation_;

    void initPhysics()
    {
        PhysX.
    }

//void initPhysics(bool interactive)
//{
//	gFoundation = PxCreateFoundation(PX_PHYSICS_VERSION, gAllocator, gErrorCallback);

//	gPvd = PxCreatePvd(*gFoundation);
//	PxPvdTransport* transport = PxDefaultPvdSocketTransportCreate(PVD_HOST, 5425, 10);
//	gPvd->connect(*transport,PxPvdInstrumentationFlag::eALL);

//	gPhysics = PxCreatePhysics(PX_PHYSICS_VERSION, *gFoundation, PxTolerancesScale(),true,gPvd);

//	PxSceneDesc sceneDesc(gPhysics->getTolerancesScale());
//	sceneDesc.gravity = PxVec3(0.0f, -9.81f, 0.0f);
//	gDispatcher = PxDefaultCpuDispatcherCreate(2);
//	sceneDesc.cpuDispatcher	= gDispatcher;
//	sceneDesc.filterShader	= PxDefaultSimulationFilterShader;
//	gScene = gPhysics->createScene(sceneDesc);

//	PxPvdSceneClient* pvdClient = gScene->getScenePvdClient();
//	if(pvdClient)
//	{
//		pvdClient->setScenePvdFlag(PxPvdSceneFlag::eTRANSMIT_CONSTRAINTS, true);
//		pvdClient->setScenePvdFlag(PxPvdSceneFlag::eTRANSMIT_CONTACTS, true);
//		pvdClient->setScenePvdFlag(PxPvdSceneFlag::eTRANSMIT_SCENEQUERIES, true);
//	}
//	gMaterial = gPhysics->createMaterial(0.5f, 0.5f, 0.6f);

//	PxRigidStatic* groundPlane = PxCreatePlane(*gPhysics, PxPlane(0,1,0,0), *gMaterial);
//	gScene->addActor(*groundPlane);

//	for(PxU32 i=0;i<5;i++)
//		createStack(PxTransform(PxVec3(0,0,stackZ-=10.0f)), 10, 2.0f);

//	if(!interactive)
//		createDynamic(PxTransform(PxVec3(0,40,100)), PxSphereGeometry(10), PxVec3(0,-50,-100));
//}

//void stepPhysics(bool interactive)
//{
//	PX_UNUSED(interactive);
//	gScene->simulate(1.0f/60.0f);
//	gScene->fetchResults(true);
//}

//void cleanupPhysics(bool interactive)
//{
//	PX_UNUSED(interactive);
//	gScene->release();
//	gDispatcher->release();
//	gPhysics->release();	
//	PxPvdTransport* transport = gPvd->getTransport();
//	gPvd->release();
//	transport->release();

//	gFoundation->release();

//	printf("SnippetHelloWorld done.\n");
//}

//void keyPress(unsigned char key, const PxTransform& camera)
//{
//	switch(toupper(key))
//	{
//	case 'B':	createStack(PxTransform(PxVec3(0,0,stackZ-=10.0f)), 10, 2.0f);						break;
//	case ' ':	createDynamic(camera, PxSphereGeometry(3.0f), camera.rotate(PxVec3(0,0,-1))*200);	break;
//	}
//}

//int snippetMain(int, const char*const*)
//{
//#ifdef RENDER_SNIPPET
//	extern void renderLoop();
//	renderLoop();
//#else
//	static const PxU32 frameCount = 100;
//	initPhysics(false);
//	for(PxU32 i=0; i<frameCount; i++)
//		stepPhysics(false);
//	cleanupPhysics(false);
//#endif

//	return 0;
//}
}