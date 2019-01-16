ES physx::PxMat33 PxMat33__createDiagonal(physx::PxMat33* cls, physx::PxVec3* d) {
    return cls->createDiagonal(*d);
};ES physx::PxMat33 PxMat33__getTranspose(physx::PxMat33* cls) {
    return cls->getTranspose();
};ES physx::PxMat33 PxMat33__getInverse(physx::PxMat33* cls) {
    return cls->getInverse();
};ES float PxMat33__getDeterminant(physx::PxMat33* cls) {
    return cls->getDeterminant();
};ES physx::PxVec3 PxMat33__transform(physx::PxMat33* cls, physx::PxVec3* other) {
    return cls->transform(*other);
};ES physx::PxVec3 PxMat33__transformTranspose(physx::PxMat33* cls, physx::PxVec3* other) {
    return cls->transformTranspose(*other);
};ES float* PxMat33__front(physx::PxMat33* cls) {
    return cls->front();
};