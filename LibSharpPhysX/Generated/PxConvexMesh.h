ES physx::PxU32 PxConvexMesh__getNbVertices(physx::PxConvexMesh* cls) {
    return cls->getNbVertices();
};ES physx::PxVec3* PxConvexMesh__getVertices(physx::PxConvexMesh* cls) {
    return cls->getVertices();
};ES physx::PxU8* PxConvexMesh__getIndexBuffer(physx::PxConvexMesh* cls) {
    return cls->getIndexBuffer();
};ES physx::PxU32 PxConvexMesh__getNbPolygons(physx::PxConvexMesh* cls) {
    return cls->getNbPolygons();
};ES bool PxConvexMesh__getPolygonData(physx::PxConvexMesh* cls, physx::PxU32 index, physx::PxHullPolygon* data) {
    return cls->getPolygonData(index, *data);
};ES physx::PxU32 PxConvexMesh__getReferenceCount(physx::PxConvexMesh* cls) {
    return cls->getReferenceCount();
};ES void PxConvexMesh__acquireReference(physx::PxConvexMesh* cls) {
    return cls->acquireReference();
};ES void PxConvexMesh__getMassInformation(physx::PxConvexMesh* cls, physx::PxReal* mass, physx::PxMat33* localInertia, physx::PxVec3* localCenterOfMass) {
    return cls->getMassInformation(*mass, *localInertia, *localCenterOfMass);
};ES physx::PxBounds3 PxConvexMesh__getLocalBounds(physx::PxConvexMesh* cls) {
    return cls->getLocalBounds();
};ES bool PxConvexMesh__isGpuCompatible(physx::PxConvexMesh* cls) {
    return cls->isGpuCompatible();
};