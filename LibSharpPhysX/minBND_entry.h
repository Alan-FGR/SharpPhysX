#pragma once
#include "minBND_confs.h"

//includes
#include "PxFoundation.h";
#include "PxPhysicsVersion.h"
#include "PxPhysics.h"
#include "PxScene.h"
#include "PxMaterial.h"
#include "PxRigidDynamic.h"
#include "PxRigidStatic.h"
#include "geometry/PxHeightField.h"
#include "geometry/PxTriangleMesh.h"
#include "PxAggregate.h"
#include "PxArticulation.h"
#include "PxConstraint.h"
#include "PxConstraintDesc.h"
#include "PxContact.h"
#include "PxArticulationLink.h"
#include "PxArticulationBase.h"
#include "PxArticulationReducedCoordinate.h"
#include "foundation/PxMat44.h"
#include "foundation/PxVec2.h"
#include "geometry/PxHeightFieldDesc.h"

#include "extensions/PxDefaultAllocator.h"
#include "extensions/PxDefaultCpuDispatcher.h"
#include "extensions/PxDefaultSimulationFilterShader.h"
#include "extensions/PxSimpleFactory.h"
#include "extensions/PxRigidBodyExt.h"

#include "common/PxRenderBuffer.h"

#include "Error.h"

using namespace physx;
using namespace pvdsdk;

namespace SharpPhysX_internal {

	inline PxU32 GetPhysicsVersion()
	{
		return PX_PHYSICS_VERSION;
	}

	inline PxSimulationFilterShader GetDefaultSimulationFilterShader()
	{
		return PxDefaultSimulationFilterShader;
	}
}

namespace SharpPhysX {

	inline PxFoundation* CreateFoundation(SharpPhysXErrorFptr managedErrorCallback = nullptr, unsigned version = PX_PHYSICS_VERSION)
	{
		return PxCreateFoundation(version, *new PxDefaultAllocator(), *new ShPxErrorCallbackWrapper(managedErrorCallback));
	}

	inline PxPhysics* CreatePhysics(PxFoundation* foundation)
	{
		return PxCreatePhysics(PX_PHYSICS_VERSION, *foundation, PxTolerancesScale(), false);
	}

	inline PxSceneDesc* CreateSceneDesc()
	{
		return new PxSceneDesc(PxTolerancesScale());
	}

	
}

//manual typedefs
using Ptr = void*;
using physx_Px1DConstraint_ANONYMOUS_unionPtr = decltype(physx::Px1DConstraint::mods)*;
using RestitutionModifiersPtr = decltype(physx::Px1DConstraint::mods.bounce)*;
using SpringModifiersPtr = decltype(physx::Px1DConstraint::mods.spring)*;

using physx_PxGeometryHolder_ANONYMOUS_unionPtr = void*;

using PxBitAndBytePtr  = PxBitAndByte*;
using PxBitAndDwordPtr = PxBitAndWord*;
using PxBitAndWordPtr  = PxBitAndDword*;
using PxPadding_intVal3Ptr = PxPadding<3>*;
using PxGpuCopyDescPtr = PxGpuCopyDesc*;

//configs

ManualDecls(PxSimulationFilterShader)

ForcedStaticClasses(PxRigidBodyExt)

ForbiddenTypes(
	ShPxErrorCallbackWrapper,

	//HIGH PRIORITY API
	//  callbacks
	PxErrorCallback,
	PxAllocatorCallback,
	PxDefaultAllocator,
	// PxDeletionListener,
	PxPhysicsInsertionCallback,
	PxSimulationEventCallback,
	PxContactModifyCallback,
	PxCCDContactModifyCallback,
	// //  complex ownership
	// PxHeightField,
	// PxHeightFieldGeometry,
	// PxConvexMesh,
	// PxConvexMeshGeometry,
	// PxTriangleMeshGeometry,
	// PxArticulation,
	// PxArticulationBase,
	// PxArticulationReducedCoordinate,
	PxArticulationDriveCache,
	// PxGeometryHolder,
	// //  streams and io
	PxOutputStream,
	PxInputStream,
	// //  other
	// //MEDIUM PRIORITY (UNECESSARY?)
	// //Px1DConstraint,
	// //PxTolerancesScale,
	// PxCollection,
	// PxConstraintShaderTable,
	// PxCpuDispatcher,
	PxContactPairHeader,
	PxSerializer,
	PxRepXSerializer,
	PxArticulationImpl,
	PxArticulationJointImpl,
	physx::Cm::SpatialVector,
	// PxGpuDispatcher,
	PxCudaContextManager,
	// //MULTITHREADING
	// PxBaseTask,
	// PxTaskManager,
	// //LOW-LEVEL (VERY LOW PRIORITY)
	PxAllocatorCallback,
	PxAssertHandler,
	// PxAggregate,
	PxBVHStructure,
	PxPruningStructure,
	PxBatchQuery,
	// PxBroadPhaseCallback,
	// PxBroadPhaseType,
	// PxBroadPhaseRegion,
	// PxBroadPhaseRegionInfo,
	// //UNSUPPORTED
	PxProfilerCallback,
	PxPvdSceneClient,
	PvdDataStream,
	PvdClient,
	PvdDebugLine,
	PvdDebugPoint,
	PvdDebugText,
	PvdDebugTriangle,
	PxPvd,
	// PxVisualizationParameter,
	// PxSimulationStatistics,
	//PxPvdSceneClient
	//EXTENSIONS
	PxJoint
)

ForbidSignature(operator*, PxMat33, float, const PxMat33&)
ForbidSignature(operator*, PxMat44, float, const PxMat44&)

BlittableTypes(
	PxTolerancesScale,
	// Math
	PxVec2, PxVec3, PxVec4,
	PxQuat, PxMat33, PxMat44,
	PxTransform,
	PxBounds3,
	PxPlane,
	// Geom
	PxGeometry, PxBoxGeometry, PxCapsuleGeometry, PxConvexMeshGeometry,
	PxHeightFieldGeometry, PxPlaneGeometry, PxSphereGeometry, PxTriangleMeshGeometry,
	// Debug
	PxDebugLine, PxDebugPoint, PxDebugTriangle//, PxDebugText
)