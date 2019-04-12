// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
ES void* PxShape_GET_userData(PxShapePtr cls) {return (void*)cls->userData;}
ES void PxShape_SET_userData(PxShapePtr cls, void* value) {cls->userData = value;}

ES void void_physx_PxShape_release(PxShapePtr wrp_this){
    wrp_this->release();
}

ES unsigned int uint_const_physx_PxShape_getReferenceCount(PxShapePtr wrp_this){
    return (unsigned int) wrp_this->getReferenceCount();
}

ES void void_physx_PxShape_acquireReference(PxShapePtr wrp_this){
    wrp_this->acquireReference();
}

ES physx::PxGeometryType::Enum physx_PxGeometryTypeEnum_const_physx_PxShape_getGeometryType(PxShapePtr wrp_this){
    return (physx::PxGeometryType::Enum) wrp_this->getGeometryType();
}

ES void void_physx_PxShape_setGeometry_physx_PxGeometryPtr_(PxShapePtr wrp_this, PxGeometryPtr wrp_geometry){
    wrp_this->setGeometry(*wrp_geometry);
}

ES PxGeometryHolderPtr physx_PxGeometryHolderPtr_const_physx_PxShape_getGeometry(PxShapePtr wrp_this){
    auto ret = wrp_this->getGeometry();
    auto heap = new char[sizeof PxGeometryHolder];
    std::memcpy(heap, &ret, sizeof PxGeometryHolder);
    return (PxGeometryHolderPtr) heap;
}

ES bool bool_const_physx_PxShape_getBoxGeometry_physx_PxBoxGeometryPtr_(PxShapePtr wrp_this, PxBoxGeometryPtr wrp_geometry){
    return (bool) wrp_this->getBoxGeometry(*wrp_geometry);
}

ES bool bool_const_physx_PxShape_getSphereGeometry_physx_PxSphereGeometryPtr_(PxShapePtr wrp_this, PxSphereGeometryPtr wrp_geometry){
    return (bool) wrp_this->getSphereGeometry(*wrp_geometry);
}

ES bool bool_const_physx_PxShape_getCapsuleGeometry_physx_PxCapsuleGeometryPtr_(PxShapePtr wrp_this, PxCapsuleGeometryPtr wrp_geometry){
    return (bool) wrp_this->getCapsuleGeometry(*wrp_geometry);
}

ES bool bool_const_physx_PxShape_getPlaneGeometry_physx_PxPlaneGeometryPtr_(PxShapePtr wrp_this, PxPlaneGeometryPtr wrp_geometry){
    return (bool) wrp_this->getPlaneGeometry(*wrp_geometry);
}

ES bool bool_const_physx_PxShape_getConvexMeshGeometry_physx_PxConvexMeshGeometryPtr_(PxShapePtr wrp_this, PxConvexMeshGeometryPtr wrp_geometry){
    return (bool) wrp_this->getConvexMeshGeometry(*wrp_geometry);
}

ES bool bool_const_physx_PxShape_getTriangleMeshGeometry_physx_PxTriangleMeshGeometryPtr_(PxShapePtr wrp_this, PxTriangleMeshGeometryPtr wrp_geometry){
    return (bool) wrp_this->getTriangleMeshGeometry(*wrp_geometry);
}

ES bool bool_const_physx_PxShape_getHeightFieldGeometry_physx_PxHeightFieldGeometryPtr_(PxShapePtr wrp_this, PxHeightFieldGeometryPtr wrp_geometry){
    return (bool) wrp_this->getHeightFieldGeometry(*wrp_geometry);
}

ES PxRigidActorPtr physx_PxRigidActorPtr_const_physx_PxShape_getActor(PxShapePtr wrp_this){
    return (PxRigidActorPtr) wrp_this->getActor();
}

ES void void_physx_PxShape_setLocalPose_physx_PxTransformPtr_(PxShapePtr wrp_this, PxTransformPtr wrp_pose){
    wrp_this->setLocalPose(*wrp_pose);
}

ES PxTransformPtr physx_PxTransformPtr_const_physx_PxShape_getLocalPose(PxShapePtr wrp_this){
    auto ret = wrp_this->getLocalPose();
    auto heap = new char[sizeof PxTransform];
    std::memcpy(heap, &ret, sizeof PxTransform);
    return (PxTransformPtr) heap;
}

ES void void_physx_PxShape_setSimulationFilterData_physx_PxFilterDataPtr_(PxShapePtr wrp_this, PxFilterDataPtr wrp_data){
    wrp_this->setSimulationFilterData(*wrp_data);
}

ES PxFilterDataPtr physx_PxFilterDataPtr_const_physx_PxShape_getSimulationFilterData(PxShapePtr wrp_this){
    auto ret = wrp_this->getSimulationFilterData();
    auto heap = new char[sizeof PxFilterData];
    std::memcpy(heap, &ret, sizeof PxFilterData);
    return (PxFilterDataPtr) heap;
}

ES void void_physx_PxShape_setQueryFilterData_physx_PxFilterDataPtr_(PxShapePtr wrp_this, PxFilterDataPtr wrp_data){
    wrp_this->setQueryFilterData(*wrp_data);
}

ES PxFilterDataPtr physx_PxFilterDataPtr_const_physx_PxShape_getQueryFilterData(PxShapePtr wrp_this){
    auto ret = wrp_this->getQueryFilterData();
    auto heap = new char[sizeof PxFilterData];
    std::memcpy(heap, &ret, sizeof PxFilterData);
    return (PxFilterDataPtr) heap;
}

ES void void_physx_PxShape_setMaterials_physx_PxMaterialPtr_ushort_(PxShapePtr wrp_this, PxMaterialPtr* wrp_materials, unsigned short wrp_materialCount){
    wrp_this->setMaterials(wrp_materials, wrp_materialCount);
}

ES unsigned short ushort_const_physx_PxShape_getNbMaterials(PxShapePtr wrp_this){
    return (unsigned short) wrp_this->getNbMaterials();
}

ES unsigned int uint_const_physx_PxShape_getMaterials_physx_PxMaterialPtr_uint_uint_(PxShapePtr wrp_this, PxMaterialPtr* wrp_userBuffer, unsigned int wrp_bufferSize, unsigned int wrp_startIndex){
    return (unsigned int) wrp_this->getMaterials(wrp_userBuffer, wrp_bufferSize, wrp_startIndex);
}

ES unsigned int uint_const_physx_PxShape_getMaterials_physx_PxMaterialPtr_uint_(PxShapePtr wrp_this, PxMaterialPtr* wrp_userBuffer, unsigned int wrp_bufferSize){
    return (unsigned int) wrp_this->getMaterials(wrp_userBuffer, wrp_bufferSize);
}

ES PxMaterialPtr physx_PxMaterialPtr_const_physx_PxShape_getMaterialFromInternalFaceIndex_uint_(PxShapePtr wrp_this, unsigned int wrp_faceIndex){
    return (PxMaterialPtr) wrp_this->getMaterialFromInternalFaceIndex(wrp_faceIndex);
}

ES void void_physx_PxShape_setContactOffset_float_(PxShapePtr wrp_this, float wrp_contactOffset){
    wrp_this->setContactOffset(wrp_contactOffset);
}

ES float float_const_physx_PxShape_getContactOffset(PxShapePtr wrp_this){
    return (float) wrp_this->getContactOffset();
}

ES void void_physx_PxShape_setRestOffset_float_(PxShapePtr wrp_this, float wrp_restOffset){
    wrp_this->setRestOffset(wrp_restOffset);
}

ES float float_const_physx_PxShape_getRestOffset(PxShapePtr wrp_this){
    return (float) wrp_this->getRestOffset();
}

ES void void_physx_PxShape_setTorsionalPatchRadius_float_(PxShapePtr wrp_this, float wrp_radius){
    wrp_this->setTorsionalPatchRadius(wrp_radius);
}

ES float float_const_physx_PxShape_getTorsionalPatchRadius(PxShapePtr wrp_this){
    return (float) wrp_this->getTorsionalPatchRadius();
}

ES void void_physx_PxShape_setMinTorsionalPatchRadius_float_(PxShapePtr wrp_this, float wrp_radius){
    wrp_this->setMinTorsionalPatchRadius(wrp_radius);
}

ES float float_const_physx_PxShape_getMinTorsionalPatchRadius(PxShapePtr wrp_this){
    return (float) wrp_this->getMinTorsionalPatchRadius();
}

ES void void_physx_PxShape_setFlag_physx_PxShapeFlagEnum_bool_(PxShapePtr wrp_this, physx::PxShapeFlag::Enum wrp_flag, bool wrp_value){
    wrp_this->setFlag(wrp_flag, wrp_value);
}

ES void void_physx_PxShape_setFlags_PxShapeFlagsPtr_(PxShapePtr wrp_this, PxShapeFlagsPtr wrp_inFlags){
    wrp_this->setFlags(*wrp_inFlags);
}

ES PxShapeFlagsPtr PxShapeFlagsPtr_const_physx_PxShape_getFlags(PxShapePtr wrp_this){
    auto ret = wrp_this->getFlags();
    auto heap = new char[sizeof PxShapeFlags];
    std::memcpy(heap, &ret, sizeof PxShapeFlags);
    return (PxShapeFlagsPtr) heap;
}

ES bool bool_const_physx_PxShape_isExclusive(PxShapePtr wrp_this){
    return (bool) wrp_this->isExclusive();
}

ES void void_physx_PxShape_setName_string_(PxShapePtr wrp_this, char* wrp_name){
    wrp_this->setName(wrp_name);
}

ES char* string_const_physx_PxShape_getName(PxShapePtr wrp_this){
    return (char*) wrp_this->getName();
}

ES char* string_const_physx_PxShape_getConcreteTypeName(PxShapePtr wrp_this){
    return (char*) wrp_this->getConcreteTypeName();
}