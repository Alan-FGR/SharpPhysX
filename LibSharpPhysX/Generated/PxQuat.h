ES bool PxQuat__isIdentity(physx::PxQuat* cls) {
    return cls->isIdentity();
};ES bool PxQuat__isFinite(physx::PxQuat* cls) {
    return cls->isFinite();
};ES bool PxQuat__isUnit(physx::PxQuat* cls) {
    return cls->isUnit();
};ES bool PxQuat__isSane(physx::PxQuat* cls) {
    return cls->isSane();
};ES void PxQuat__toRadiansAndUnitAxis(physx::PxQuat* cls, float* angle, physx::PxVec3* axis) {
    return cls->toRadiansAndUnitAxis(*angle, *axis);
};ES float PxQuat__getAngle(physx::PxQuat* cls) {
    return cls->getAngle();
};ES float PxQuat__getAngle(physx::PxQuat* cls, physx::PxQuat* q) {
    return cls->getAngle(*q);
};ES float PxQuat__magnitudeSquared(physx::PxQuat* cls) {
    return cls->magnitudeSquared();
};ES float PxQuat__dot(physx::PxQuat* cls, physx::PxQuat* v) {
    return cls->dot(*v);
};ES physx::PxQuat PxQuat__getNormalized(physx::PxQuat* cls) {
    return cls->getNormalized();
};ES float PxQuat__magnitude(physx::PxQuat* cls) {
    return cls->magnitude();
};ES float PxQuat__normalize(physx::PxQuat* cls) {
    return cls->normalize();
};ES physx::PxQuat PxQuat__getConjugate(physx::PxQuat* cls) {
    return cls->getConjugate();
};ES physx::PxVec3 PxQuat__getImaginaryPart(physx::PxQuat* cls) {
    return cls->getImaginaryPart();
};ES physx::PxVec3 PxQuat__getBasisVector0(physx::PxQuat* cls) {
    return cls->getBasisVector0();
};ES physx::PxVec3 PxQuat__getBasisVector1(physx::PxQuat* cls) {
    return cls->getBasisVector1();
};ES physx::PxVec3 PxQuat__getBasisVector2(physx::PxQuat* cls) {
    return cls->getBasisVector2();
};ES physx::PxVec3 PxQuat__rotate(physx::PxQuat* cls, physx::PxVec3* v) {
    return cls->rotate(*v);
};ES physx::PxVec3 PxQuat__rotateInv(physx::PxQuat* cls, physx::PxVec3* v) {
    return cls->rotateInv(*v);
};