ES physx::PxU32 PxShape__getReferenceCount(physx::PxShape* cls) {
    return cls->getReferenceCount();
};ES void PxShape__acquireReference(physx::PxShape* cls) {
    return cls->acquireReference();
};ES physx::PxGeometryType::Enum PxShape__getGeometryType(physx::PxShape* cls) {
    return cls->getGeometryType();
};ES void PxShape__setGeometry(physx::PxShape* cls, physx::PxGeometry* geometry) {
    return cls->setGeometry(*geometry);
};ES physx::PxGeometryHolder PxShape__getGeometry(physx::PxShape* cls) {
    return cls->getGeometry();
};ES bool PxShape__getBoxGeometry(physx::PxShape* cls, physx::PxBoxGeometry* geometry) {
    return cls->getBoxGeometry(*geometry);
};ES bool PxShape__getSphereGeometry(physx::PxShape* cls, physx::PxSphereGeometry* geometry) {
    return cls->getSphereGeometry(*geometry);
};ES bool PxShape__getCapsuleGeometry(physx::PxShape* cls, physx::PxCapsuleGeometry* geometry) {
    return cls->getCapsuleGeometry(*geometry);
};ES bool PxShape__getPlaneGeometry(physx::PxShape* cls, physx::PxPlaneGeometry* geometry) {
    return cls->getPlaneGeometry(*geometry);
};ES bool PxShape__getConvexMeshGeometry(physx::PxShape* cls, physx::PxConvexMeshGeometry* geometry) {
    return cls->getConvexMeshGeometry(*geometry);
};ES bool PxShape__getTriangleMeshGeometry(physx::PxShape* cls, physx::PxTriangleMeshGeometry* geometry) {
    return cls->getTriangleMeshGeometry(*geometry);
};ES bool PxShape__getHeightFieldGeometry(physx::PxShape* cls, physx::PxHeightFieldGeometry* geometry) {
    return cls->getHeightFieldGeometry(*geometry);
};ES physx::PxRigidActor* PxShape__getActor(physx::PxShape* cls) {
    return cls->getActor();
};ES void PxShape__setLocalPose(physx::PxShape* cls, physx::PxTransform* pose) {
    return cls->setLocalPose(*pose);
};ES physx::PxTransform PxShape__getLocalPose(physx::PxShape* cls) {
    return cls->getLocalPose();
};ES void PxShape__setSimulationFilterData(physx::PxShape* cls, physx::PxFilterData* data) {
    return cls->setSimulationFilterData(*data);
};ES physx::PxFilterData PxShape__getSimulationFilterData(physx::PxShape* cls) {
    return cls->getSimulationFilterData();
};ES void PxShape__setQueryFilterData(physx::PxShape* cls, physx::PxFilterData* data) {
    return cls->setQueryFilterData(*data);
};ES physx::PxFilterData PxShape__getQueryFilterData(physx::PxShape* cls) {
    return cls->getQueryFilterData();
};ES void PxShape__setMaterials(physx::PxShape* cls, physx::PxMaterial** materials, physx::PxU16 materialCount) {
    return cls->setMaterials(materials, materialCount);
};ES physx::PxU16 PxShape__getNbMaterials(physx::PxShape* cls) {
    return cls->getNbMaterials();
};ES physx::PxU32 PxShape__getMaterials(physx::PxShape* cls, physx::PxMaterial** userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex) {
    return cls->getMaterials(userBuffer, bufferSize, startIndex);
};ES physx::PxMaterial* PxShape__getMaterialFromInternalFaceIndex(physx::PxShape* cls, physx::PxU32 faceIndex) {
    return cls->getMaterialFromInternalFaceIndex(faceIndex);
};ES void PxShape__setContactOffset(physx::PxShape* cls, physx::PxReal contactOffset) {
    return cls->setContactOffset(contactOffset);
};ES physx::PxReal PxShape__getContactOffset(physx::PxShape* cls) {
    return cls->getContactOffset();
};ES void PxShape__setRestOffset(physx::PxShape* cls, physx::PxReal restOffset) {
    return cls->setRestOffset(restOffset);
};ES physx::PxReal PxShape__getRestOffset(physx::PxShape* cls) {
    return cls->getRestOffset();
};ES void PxShape__setTorsionalPatchRadius(physx::PxShape* cls, physx::PxReal radius) {
    return cls->setTorsionalPatchRadius(radius);
};ES physx::PxReal PxShape__getTorsionalPatchRadius(physx::PxShape* cls) {
    return cls->getTorsionalPatchRadius();
};ES void PxShape__setMinTorsionalPatchRadius(physx::PxShape* cls, physx::PxReal radius) {
    return cls->setMinTorsionalPatchRadius(radius);
};ES physx::PxReal PxShape__getMinTorsionalPatchRadius(physx::PxShape* cls) {
    return cls->getMinTorsionalPatchRadius();
};ES void PxShape__setFlag(physx::PxShape* cls, physx::PxShapeFlag::Enum flag, bool value) {
    return cls->setFlag(flag, value);
};ES void PxShape__setFlags(physx::PxShape* cls, physx::PxShapeFlags inFlags) {
    return cls->setFlags(inFlags);
};ES physx::PxShapeFlags PxShape__getFlags(physx::PxShape* cls) {
    return cls->getFlags();
};ES bool PxShape__isExclusive(physx::PxShape* cls) {
    return cls->isExclusive();
};ES void PxShape__setName(physx::PxShape* cls, const char* name) {
    return cls->setName(name);
};ES const char* PxShape__getName(physx::PxShape* cls) {
    return cls->getName();
};