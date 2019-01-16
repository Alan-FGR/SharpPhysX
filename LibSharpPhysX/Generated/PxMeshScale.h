ES bool PxMeshScale__isIdentity(physx::PxMeshScale* cls) {
    return cls->isIdentity();
};ES physx::PxMeshScale PxMeshScale__getInverse(physx::PxMeshScale* cls) {
    return cls->getInverse();
};ES physx::PxMat33 PxMeshScale__toMat33(physx::PxMeshScale* cls) {
    return cls->toMat33();
};ES bool PxMeshScale__hasNegativeDeterminant(physx::PxMeshScale* cls) {
    return cls->hasNegativeDeterminant();
};ES physx::PxVec3 PxMeshScale__transform(physx::PxMeshScale* cls, physx::PxVec3* v) {
    return cls->transform(*v);
};ES bool PxMeshScale__isValidForTriangleMesh(physx::PxMeshScale* cls) {
    return cls->isValidForTriangleMesh();
};ES bool PxMeshScale__isValidForConvexMesh(physx::PxMeshScale* cls) {
    return cls->isValidForConvexMesh();
};