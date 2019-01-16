ES physx::PxTransform __PxTransformFromSegment(physx::PxVec3* p0, physx::PxVec3* p1, physx::PxReal* halfHeight) {
    return physx::PxTransformFromSegment(*p0, *p1, halfHeight);
};ES bool PxCapsuleGeometry__isValid(physx::PxCapsuleGeometry* cls) {
    return cls->isValid();
};