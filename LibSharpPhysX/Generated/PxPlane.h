ES float PxPlane__distance(physx::PxPlane* cls, physx::PxVec3* p) {
    return cls->distance(*p);
};ES bool PxPlane__contains(physx::PxPlane* cls, physx::PxVec3* p) {
    return cls->contains(*p);
};ES physx::PxVec3 PxPlane__project(physx::PxPlane* cls, physx::PxVec3* p) {
    return cls->project(*p);
};ES physx::PxVec3 PxPlane__pointInPlane(physx::PxPlane* cls) {
    return cls->pointInPlane();
};ES void PxPlane__normalize(physx::PxPlane* cls) {
    return cls->normalize();
};