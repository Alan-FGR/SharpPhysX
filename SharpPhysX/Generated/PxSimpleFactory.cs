// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxRigidDynamicPtr PxCreateDynamic<T3>(physx.PxPhysicsPtr sdk, physx.PxTransform transform, T3 geometry, physx.PxMaterialPtr material, float density) where T3 : unmanaged, physx.PxGeometry.IPxGeometry {
        return PxCreateDynamic(sdk, (physx.PxTransform*)&transform, (physx.PxGeometry*)&geometry, material, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxGeometry.Ref geometry, physx.PxMaterialPtr material, float density) {
        return PxCreateDynamic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxGeometry*)(*((IntPtr*)(&geometry))), material, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxGeometry* geometry, physx.PxMaterialPtr material, float density) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxGeometry* pvk_in_geometry = geometry;
        physx.PxMaterialPtr pvk_in_material = material;
        float pvk_in_density = density;
        return PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_(pvk_in_sdk, pvk_in_transform, pvk_in_geometry, pvk_in_material, pvk_in_density);
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic<T3>(physx.PxPhysicsPtr sdk, physx.PxTransform transform, T3 geometry, physx.PxMaterialPtr material, float density, physx.PxTransform shapeOffset) where T3 : unmanaged, physx.PxGeometry.IPxGeometry {
        return PxCreateDynamic(sdk, (physx.PxTransform*)&transform, (physx.PxGeometry*)&geometry, material, density, (physx.PxTransform*)&shapeOffset);
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxGeometry.Ref geometry, physx.PxMaterialPtr material, float density, physx.PxTransform.Ref shapeOffset) {
        return PxCreateDynamic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxGeometry*)(*((IntPtr*)(&geometry))), material, density, (physx.PxTransform*)(*((IntPtr*)(&shapeOffset))));
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxGeometry* geometry, physx.PxMaterialPtr material, float density, physx.PxTransform* shapeOffset) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxGeometry* pvk_in_geometry = geometry;
        physx.PxMaterialPtr pvk_in_material = material;
        float pvk_in_density = density;
        physx.PxTransform* pvk_in_shapeOffset = shapeOffset;
        return PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_PxTransform_(pvk_in_sdk, pvk_in_transform, pvk_in_geometry, pvk_in_material, pvk_in_density, pvk_in_shapeOffset);
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform transform, physx.PxShapePtr shape, float density) {
        return PxCreateDynamic(sdk, (physx.PxTransform*)&transform, shape, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxShapePtr shape, float density) {
        return PxCreateDynamic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), shape, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateDynamic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxShapePtr shape, float density) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxShapePtr pvk_in_shape = shape;
        float pvk_in_density = density;
        return PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxShapePtr_float_(pvk_in_sdk, pvk_in_transform, pvk_in_shape, pvk_in_density);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic<T3>(physx.PxPhysicsPtr sdk, physx.PxTransform transform, T3 geometry, physx.PxMaterialPtr material, float density) where T3 : unmanaged, physx.PxGeometry.IPxGeometry {
        return PxCreateKinematic(sdk, (physx.PxTransform*)&transform, (physx.PxGeometry*)&geometry, material, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxGeometry.Ref geometry, physx.PxMaterialPtr material, float density) {
        return PxCreateKinematic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxGeometry*)(*((IntPtr*)(&geometry))), material, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxGeometry* geometry, physx.PxMaterialPtr material, float density) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxGeometry* pvk_in_geometry = geometry;
        physx.PxMaterialPtr pvk_in_material = material;
        float pvk_in_density = density;
        return PxRigidDynamicPtr_PxCreateKinematicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_(pvk_in_sdk, pvk_in_transform, pvk_in_geometry, pvk_in_material, pvk_in_density);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic<T3>(physx.PxPhysicsPtr sdk, physx.PxTransform transform, T3 geometry, physx.PxMaterialPtr material, float density, physx.PxTransform shapeOffset) where T3 : unmanaged, physx.PxGeometry.IPxGeometry {
        return PxCreateKinematic(sdk, (physx.PxTransform*)&transform, (physx.PxGeometry*)&geometry, material, density, (physx.PxTransform*)&shapeOffset);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxGeometry.Ref geometry, physx.PxMaterialPtr material, float density, physx.PxTransform.Ref shapeOffset) {
        return PxCreateKinematic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxGeometry*)(*((IntPtr*)(&geometry))), material, density, (physx.PxTransform*)(*((IntPtr*)(&shapeOffset))));
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxGeometry* geometry, physx.PxMaterialPtr material, float density, physx.PxTransform* shapeOffset) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxGeometry* pvk_in_geometry = geometry;
        physx.PxMaterialPtr pvk_in_material = material;
        float pvk_in_density = density;
        physx.PxTransform* pvk_in_shapeOffset = shapeOffset;
        return PxRigidDynamicPtr_PxCreateKinematicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_PxTransform_(pvk_in_sdk, pvk_in_transform, pvk_in_geometry, pvk_in_material, pvk_in_density, pvk_in_shapeOffset);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic(physx.PxPhysicsPtr sdk, physx.PxTransform transform, physx.PxShapePtr shape, float density) {
        return PxCreateKinematic(sdk, (physx.PxTransform*)&transform, shape, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxShapePtr shape, float density) {
        return PxCreateKinematic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), shape, density);
    }

    public static physx.PxRigidDynamicPtr PxCreateKinematic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxShapePtr shape, float density) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxShapePtr pvk_in_shape = shape;
        float pvk_in_density = density;
        return PxRigidDynamicPtr_PxCreateKinematicPtr_PxPhysicsPtr_PxTransform_PxShapePtr_float_(pvk_in_sdk, pvk_in_transform, pvk_in_shape, pvk_in_density);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic<T3>(physx.PxPhysicsPtr sdk, physx.PxTransform transform, T3 geometry, physx.PxMaterialPtr material) where T3 : unmanaged, physx.PxGeometry.IPxGeometry {
        return PxCreateStatic(sdk, (physx.PxTransform*)&transform, (physx.PxGeometry*)&geometry, material);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxGeometry.Ref geometry, physx.PxMaterialPtr material) {
        return PxCreateStatic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxGeometry*)(*((IntPtr*)(&geometry))), material);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxGeometry* geometry, physx.PxMaterialPtr material) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxGeometry* pvk_in_geometry = geometry;
        physx.PxMaterialPtr pvk_in_material = material;
        return PxRigidStaticPtr_PxCreateStaticPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_(pvk_in_sdk, pvk_in_transform, pvk_in_geometry, pvk_in_material);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic<T3>(physx.PxPhysicsPtr sdk, physx.PxTransform transform, T3 geometry, physx.PxMaterialPtr material, physx.PxTransform shapeOffset) where T3 : unmanaged, physx.PxGeometry.IPxGeometry {
        return PxCreateStatic(sdk, (physx.PxTransform*)&transform, (physx.PxGeometry*)&geometry, material, (physx.PxTransform*)&shapeOffset);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxGeometry.Ref geometry, physx.PxMaterialPtr material, physx.PxTransform.Ref shapeOffset) {
        return PxCreateStatic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxGeometry*)(*((IntPtr*)(&geometry))), material, (physx.PxTransform*)(*((IntPtr*)(&shapeOffset))));
    }

    public static physx.PxRigidStaticPtr PxCreateStatic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxGeometry* geometry, physx.PxMaterialPtr material, physx.PxTransform* shapeOffset) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxGeometry* pvk_in_geometry = geometry;
        physx.PxMaterialPtr pvk_in_material = material;
        physx.PxTransform* pvk_in_shapeOffset = shapeOffset;
        return PxRigidStaticPtr_PxCreateStaticPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_PxTransform_(pvk_in_sdk, pvk_in_transform, pvk_in_geometry, pvk_in_material, pvk_in_shapeOffset);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic(physx.PxPhysicsPtr sdk, physx.PxTransform transform, physx.PxShapePtr shape) {
        return PxCreateStatic(sdk, (physx.PxTransform*)&transform, shape);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic(physx.PxPhysicsPtr sdk, physx.PxTransform.Ref transform, physx.PxShapePtr shape) {
        return PxCreateStatic(sdk, (physx.PxTransform*)(*((IntPtr*)(&transform))), shape);
    }

    public static physx.PxRigidStaticPtr PxCreateStatic(physx.PxPhysicsPtr sdk, physx.PxTransform* transform, physx.PxShapePtr shape) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxShapePtr pvk_in_shape = shape;
        return PxRigidStaticPtr_PxCreateStaticPtr_PxPhysicsPtr_PxTransform_PxShapePtr_(pvk_in_sdk, pvk_in_transform, pvk_in_shape);
    }

    public static physx.PxShapePtr PxCloneShape(physx.PxPhysicsPtr physicsSDK, physx.PxShapePtr shape, bool isExclusive) {
        physx.PxPhysicsPtr pvk_in_physicsSDK = physicsSDK;
        physx.PxShapePtr pvk_in_shape = shape;
        bool pvk_in_isExclusive = isExclusive;
        return PxShapePtr_PxCloneShapePtr_PxPhysicsPtr_PxShapePtr_bool_(pvk_in_physicsSDK, pvk_in_shape, pvk_in_isExclusive);
    }

    public static physx.PxRigidStaticPtr PxCloneStatic(physx.PxPhysicsPtr physicsSDK, physx.PxTransform transform, physx.PxRigidActorPtr actor) {
        return PxCloneStatic(physicsSDK, (physx.PxTransform*)&transform, actor);
    }

    public static physx.PxRigidStaticPtr PxCloneStatic(physx.PxPhysicsPtr physicsSDK, physx.PxTransform.Ref transform, physx.PxRigidActorPtr actor) {
        return PxCloneStatic(physicsSDK, (physx.PxTransform*)(*((IntPtr*)(&transform))), actor);
    }

    public static physx.PxRigidStaticPtr PxCloneStatic(physx.PxPhysicsPtr physicsSDK, physx.PxTransform* transform, physx.PxRigidActorPtr actor) {
        physx.PxPhysicsPtr pvk_in_physicsSDK = physicsSDK;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxRigidActorPtr pvk_in_actor = actor;
        return PxRigidStaticPtr_PxCloneStaticPtr_PxPhysicsPtr_PxTransform_PxRigidActorPtr_(pvk_in_physicsSDK, pvk_in_transform, pvk_in_actor);
    }

    public static physx.PxRigidDynamicPtr PxCloneDynamic(physx.PxPhysicsPtr physicsSDK, physx.PxTransform transform, physx.PxRigidDynamicPtr body) {
        return PxCloneDynamic(physicsSDK, (physx.PxTransform*)&transform, body);
    }

    public static physx.PxRigidDynamicPtr PxCloneDynamic(physx.PxPhysicsPtr physicsSDK, physx.PxTransform.Ref transform, physx.PxRigidDynamicPtr body) {
        return PxCloneDynamic(physicsSDK, (physx.PxTransform*)(*((IntPtr*)(&transform))), body);
    }

    public static physx.PxRigidDynamicPtr PxCloneDynamic(physx.PxPhysicsPtr physicsSDK, physx.PxTransform* transform, physx.PxRigidDynamicPtr body) {
        physx.PxPhysicsPtr pvk_in_physicsSDK = physicsSDK;
        physx.PxTransform* pvk_in_transform = transform;
        physx.PxRigidDynamicPtr pvk_in_body = body;
        return PxRigidDynamicPtr_PxCloneDynamicPtr_PxPhysicsPtr_PxTransform_PxRigidDynamicPtr_(pvk_in_physicsSDK, pvk_in_transform, pvk_in_body);
    }

    public static physx.PxRigidStaticPtr PxCreatePlane(physx.PxPhysicsPtr sdk, physx.PxPlane plane, physx.PxMaterialPtr material) {
        return PxCreatePlane(sdk, (physx.PxPlane*)&plane, material);
    }

    public static physx.PxRigidStaticPtr PxCreatePlane(physx.PxPhysicsPtr sdk, physx.PxPlane.Ref plane, physx.PxMaterialPtr material) {
        return PxCreatePlane(sdk, (physx.PxPlane*)(*((IntPtr*)(&plane))), material);
    }

    public static physx.PxRigidStaticPtr PxCreatePlane(physx.PxPhysicsPtr sdk, physx.PxPlane* plane, physx.PxMaterialPtr material) {
        physx.PxPhysicsPtr pvk_in_sdk = sdk;
        physx.PxPlane* pvk_in_plane = plane;
        physx.PxMaterialPtr pvk_in_material = material;
        return PxRigidStaticPtr_PxCreatePlanePtr_PxPhysicsPtr_PxPlane_PxMaterialPtr_(pvk_in_sdk, pvk_in_plane, pvk_in_material);
    }

    public static void PxScaleRigidActor(physx.PxRigidActorPtr actor, float scale) {
        physx.PxRigidActorPtr pvk_in_actor = actor;
        float pvk_in_scale = scale;
        void_PxScaleRigidActorPtr_PxRigidActorPtr_float_(pvk_in_actor, pvk_in_scale);
    }

    public static void PxScaleRigidActor(physx.PxRigidActorPtr actor, float scale, bool scaleMassProps=true) {
        physx.PxRigidActorPtr pvk_in_actor = actor;
        float pvk_in_scale = scale;
        bool pvk_in_scaleMassProps = scaleMassProps;
        void_PxScaleRigidActorPtr_PxRigidActorPtr_float_bool_(pvk_in_actor, pvk_in_scale, pvk_in_scaleMassProps);
    }
}
