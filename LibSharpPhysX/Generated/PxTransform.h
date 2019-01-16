ES physx::PxTransform PxTransform__getInverse(physx::PxTransform* cls) {
    return cls->getInverse();
};ES physx::PxVec3 PxTransform__transform(physx::PxTransform* cls, physx::PxVec3* input) {
    return cls->transform(*input);
};ES physx::PxVec3 PxTransform__transformInv(physx::PxTransform* cls, physx::PxVec3* input) {
    return cls->transformInv(*input);
};ES physx::PxVec3 PxTransform__rotate(physx::PxTransform* cls, physx::PxVec3* input) {
    return cls->rotate(*input);
};ES physx::PxVec3 PxTransform__rotateInv(physx::PxTransform* cls, physx::PxVec3* input) {
    return cls->rotateInv(*input);
};ES physx::PxTransform PxTransform__transform(physx::PxTransform* cls, physx::PxTransform* src) {
    return cls->transform(*src);
};ES bool PxTransform__isValid(physx::PxTransform* cls) {
    return cls->isValid();
};ES bool PxTransform__isSane(physx::PxTransform* cls) {
    return cls->isSane();
};ES bool PxTransform__isFinite(physx::PxTransform* cls) {
    return cls->isFinite();
};ES physx::PxTransform PxTransform__transformInv(physx::PxTransform* cls, physx::PxTransform* src) {
    return cls->transformInv(*src);
};ES physx::PxPlane PxTransform__transform(physx::PxTransform* cls, physx::PxPlane* plane) {
    return cls->transform(*plane);
};ES physx::PxPlane PxTransform__inverseTransform(physx::PxTransform* cls, physx::PxPlane* plane) {
    return cls->inverseTransform(*plane);
};ES physx::PxTransform PxTransform__getNormalized(physx::PxTransform* cls) {
    return cls->getNormalized();
};