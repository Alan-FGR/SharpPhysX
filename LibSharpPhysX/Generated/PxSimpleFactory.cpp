// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR

ES PxRigidDynamicPtr PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, physx::PxGeometry* wrp_geometry, PxMaterialPtr wrp_material, PxReal wrp_density){
    return (PxRigidDynamicPtr) ::physx::PxCreateDynamic(*wrp_sdk, *wrp_transform, *wrp_geometry, *wrp_material, wrp_density);
}

ES PxRigidDynamicPtr PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_PxTransform_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, physx::PxGeometry* wrp_geometry, PxMaterialPtr wrp_material, PxReal wrp_density, physx::PxTransform* wrp_shapeOffset){
    return (PxRigidDynamicPtr) ::physx::PxCreateDynamic(*wrp_sdk, *wrp_transform, *wrp_geometry, *wrp_material, wrp_density, *wrp_shapeOffset);
}

ES PxRigidDynamicPtr PxRigidDynamicPtr_PxCreateDynamicPtr_PxPhysicsPtr_PxTransform_PxShapePtr_float_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, PxShapePtr wrp_shape, PxReal wrp_density){
    return (PxRigidDynamicPtr) ::physx::PxCreateDynamic(*wrp_sdk, *wrp_transform, *wrp_shape, wrp_density);
}

ES PxRigidDynamicPtr PxRigidDynamicPtr_PxCreateKinematicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, physx::PxGeometry* wrp_geometry, PxMaterialPtr wrp_material, PxReal wrp_density){
    return (PxRigidDynamicPtr) ::physx::PxCreateKinematic(*wrp_sdk, *wrp_transform, *wrp_geometry, *wrp_material, wrp_density);
}

ES PxRigidDynamicPtr PxRigidDynamicPtr_PxCreateKinematicPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_float_PxTransform_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, physx::PxGeometry* wrp_geometry, PxMaterialPtr wrp_material, PxReal wrp_density, physx::PxTransform* wrp_shapeOffset){
    return (PxRigidDynamicPtr) ::physx::PxCreateKinematic(*wrp_sdk, *wrp_transform, *wrp_geometry, *wrp_material, wrp_density, *wrp_shapeOffset);
}

ES PxRigidDynamicPtr PxRigidDynamicPtr_PxCreateKinematicPtr_PxPhysicsPtr_PxTransform_PxShapePtr_float_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, PxShapePtr wrp_shape, PxReal wrp_density){
    return (PxRigidDynamicPtr) ::physx::PxCreateKinematic(*wrp_sdk, *wrp_transform, *wrp_shape, wrp_density);
}

ES PxRigidStaticPtr PxRigidStaticPtr_PxCreateStaticPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, physx::PxGeometry* wrp_geometry, PxMaterialPtr wrp_material){
    return (PxRigidStaticPtr) ::physx::PxCreateStatic(*wrp_sdk, *wrp_transform, *wrp_geometry, *wrp_material);
}

ES PxRigidStaticPtr PxRigidStaticPtr_PxCreateStaticPtr_PxPhysicsPtr_PxTransform_PxGeometry_PxMaterialPtr_PxTransform_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, physx::PxGeometry* wrp_geometry, PxMaterialPtr wrp_material, physx::PxTransform* wrp_shapeOffset){
    return (PxRigidStaticPtr) ::physx::PxCreateStatic(*wrp_sdk, *wrp_transform, *wrp_geometry, *wrp_material, *wrp_shapeOffset);
}

ES PxRigidStaticPtr PxRigidStaticPtr_PxCreateStaticPtr_PxPhysicsPtr_PxTransform_PxShapePtr_(PxPhysicsPtr wrp_sdk, physx::PxTransform* wrp_transform, PxShapePtr wrp_shape){
    return (PxRigidStaticPtr) ::physx::PxCreateStatic(*wrp_sdk, *wrp_transform, *wrp_shape);
}

ES PxShapePtr PxShapePtr_PxCloneShapePtr_PxPhysicsPtr_PxShapePtr_bool_(PxPhysicsPtr wrp_physicsSDK, PxShapePtr wrp_shape, bool wrp_isExclusive){
    return (PxShapePtr) ::physx::PxCloneShape(*wrp_physicsSDK, *wrp_shape, wrp_isExclusive);
}

ES PxRigidStaticPtr PxRigidStaticPtr_PxCloneStaticPtr_PxPhysicsPtr_PxTransform_PxRigidActorPtr_(PxPhysicsPtr wrp_physicsSDK, physx::PxTransform* wrp_transform, PxRigidActorPtr wrp_actor){
    return (PxRigidStaticPtr) ::physx::PxCloneStatic(*wrp_physicsSDK, *wrp_transform, *wrp_actor);
}

ES PxRigidDynamicPtr PxRigidDynamicPtr_PxCloneDynamicPtr_PxPhysicsPtr_PxTransform_PxRigidDynamicPtr_(PxPhysicsPtr wrp_physicsSDK, physx::PxTransform* wrp_transform, PxRigidDynamicPtr wrp_body){
    return (PxRigidDynamicPtr) ::physx::PxCloneDynamic(*wrp_physicsSDK, *wrp_transform, *wrp_body);
}

ES PxRigidStaticPtr PxRigidStaticPtr_PxCreatePlanePtr_PxPhysicsPtr_PxPlane_PxMaterialPtr_(PxPhysicsPtr wrp_sdk, physx::PxPlane* wrp_plane, PxMaterialPtr wrp_material){
    return (PxRigidStaticPtr) ::physx::PxCreatePlane(*wrp_sdk, *wrp_plane, *wrp_material);
}

ES void void_PxScaleRigidActorPtr_PxRigidActorPtr_float_(PxRigidActorPtr wrp_actor, PxReal wrp_scale){
    ::physx::PxScaleRigidActor(*wrp_actor, wrp_scale);
}

ES void void_PxScaleRigidActorPtr_PxRigidActorPtr_float_bool_(PxRigidActorPtr wrp_actor, PxReal wrp_scale, bool wrp_scaleMassProps){
    ::physx::PxScaleRigidActor(*wrp_actor, wrp_scale, wrp_scaleMassProps);
}
