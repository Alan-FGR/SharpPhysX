ES bool PxVec3__isZero(physx::PxVec3* cls) {
    return cls->isZero();
};ES bool PxVec3__isFinite(physx::PxVec3* cls) {
    return cls->isFinite();
};ES bool PxVec3__isNormalized(physx::PxVec3* cls) {
    return cls->isNormalized();
};ES float PxVec3__magnitudeSquared(physx::PxVec3* cls) {
    return cls->magnitudeSquared();
};ES float PxVec3__magnitude(physx::PxVec3* cls) {
    return cls->magnitude();
};ES float PxVec3__dot(physx::PxVec3* cls, physx::PxVec3* v) {
    return cls->dot(*v);
};ES physx::PxVec3 PxVec3__cross(physx::PxVec3* cls, physx::PxVec3* v) {
    return cls->cross(*v);
};ES physx::PxVec3 PxVec3__getNormalized(physx::PxVec3* cls) {
    return cls->getNormalized();
};ES float PxVec3__normalize(physx::PxVec3* cls) {
    return cls->normalize();
};ES float PxVec3__normalizeSafe(physx::PxVec3* cls) {
    return cls->normalizeSafe();
};ES float PxVec3__normalizeFast(physx::PxVec3* cls) {
    return cls->normalizeFast();
};ES physx::PxVec3 PxVec3__multiply(physx::PxVec3* cls, physx::PxVec3* a) {
    return cls->multiply(*a);
};ES physx::PxVec3 PxVec3__minimum(physx::PxVec3* cls, physx::PxVec3* v) {
    return cls->minimum(*v);
};ES float PxVec3__minElement(physx::PxVec3* cls) {
    return cls->minElement();
};ES physx::PxVec3 PxVec3__maximum(physx::PxVec3* cls, physx::PxVec3* v) {
    return cls->maximum(*v);
};ES float PxVec3__maxElement(physx::PxVec3* cls) {
    return cls->maxElement();
};ES physx::PxVec3 PxVec3__abs(physx::PxVec3* cls) {
    return cls->abs();
};