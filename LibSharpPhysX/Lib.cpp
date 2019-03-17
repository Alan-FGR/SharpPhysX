// START COMMON MINBINDER STUFF
#define ES extern "C" __declspec(dllexport) inline // Export Symbol
#define NATIVE true
template<typename...> struct TypeList {};
// END COMMON MINBINDER STUFF

//#include "PxPhysicsAPI.h"

#include "extensions/PxDefaultAllocator.h"

#include "foundation/Px.h"
//#include "foundation/PxAllocatorCallback.h"
//#include "foundation/PxAssert.h"
//#include "foundation/PxBitAndData.h"
//#include "foundation/PxBounds3.h"
//#include "foundation/PxErrorCallback.h"
//#include "foundation/PxErrors.h"
//#include "foundation/PxFlags.h"
//#include "foundation/PxIntrinsics.h"
//#include "foundation/PxIO.h"
//#include "foundation/PxMat33.h"
#include "foundation/PxMat44.h"
//#include "foundation/PxMath.h"
//#include "foundation/PxMathUtils.h"
//#include "foundation/PxPlane.h"
//#include "foundation/PxPreprocessor.h"
//#include "foundation/PxQuat.h"
//#include "foundation/PxSimpleTypes.h"
//#include "foundation/PxStrideIterator.h"
//#include "foundation/PxTransform.h"
//#include "foundation/PxUnionCast.h"
//#include "foundation/PxVec2.h"
//#include "foundation/PxVec3.h"
//#include "foundation/PxVec4.h"


#include "PxFoundation.h"
#include "PxPhysicsVersion.h"
#include "PxPhysics.h"
#include "PxScene.h"

#include "PxRigidActor.h"
#include "PxRigidStatic.h"
#include "PxRigidDynamic.h"
#include "PxRigidBody.h"
#include "PxMaterial.h"
#include "PxArticulation.h"
#include "PxConstraint.h"
#include "geometry/PxTriangleMesh.h"
#include "PxFiltering.h"

//#include "PxAggregate.h"

// We only include the generated wrapper when actually building otherwise we have feedback loop when parsing
#ifdef BUILD_LIB
#include "../Generated/PxFoundation.cs"
#endif


using namespace physx;

TypeList<
    PxVec2,
    PxVec3,
    PxVec4,
    PxQuat,
    PxMat33,
    PxMat44,
    PxTransform,
	PxPlane,
	PxBounds3,
	Px1DConstraint,
	PxBoxGeometry,
	PxPlaneGeometry,
	PxCapsuleGeometry,
	PxSphereGeometry
>
BlittableTypes;



//Manual

#include "Error.h"

static PxDefaultAllocator allocator_;

ES PxFoundation* MAN_PxCreateFoundation(SharpPhysXError* managedErrorCallback)
{
    return PxCreateFoundation(PX_PHYSICS_VERSION, allocator_, *new ShPxErrorCallbackWrapper(*managedErrorCallback));
}

ES PxPhysics* MAN_PxCreatePhysics(PxFoundation* foundation)
{
	return PxCreatePhysics(PX_PHYSICS_VERSION, *foundation, PxTolerancesScale(), false);
}

// //callback tests
//
// typedef void (__stdcall *ErrorCallback)(const char* message, const char* file, int line);
//
// ES void registerCallback(ErrorCallback callback)
// {
//     //printf("calling callback from native...\n");
//
//     callback("MESSAGE!", "FILE!", 1337);
//
//     //printf("finished calling\n");
// }
//
//
// //blittable tests
//
// ES float PxVec3__magnitude(PxVec3 cls)
// {
//     return cls.magnitude();
// };
//
// ES PxVec3 PxVec3__cross(PxVec3 cls, PxVec3 otr)
// {
//     PxVec3 par1 = otr;
//     PxVec3 retVal = cls.cross(par1);
//     return retVal;
// };
//
// ES PxVec3 PxVec3__OP_plus(PxVec3 a, PxVec3 b)
// {
//     return a.operator+(b);
// }



//
//PxDefaultAllocator allocator;
//PxDefaultErrorCallback errorCallback;
//
//PxFoundation* foundation;
//
//ES PxFoundation* _PxCreateFoundation(int version, PxDefaultAllocator* allocator, PxDefaultErrorCallback* errorCallback)
//{
//    return PxCreateFoundation(version, *allocator, *errorCallback);
//}
//
//ES void _PxFoundation__release(PxFoundation* foundation)
//{
//    foundation->release();
//}