ES physx::PxTransform __PxTransformFromPlaneEquation(physx::PxPlane* plane) {
    return physx::PxTransformFromPlaneEquation(*plane);
};ES physx::PxPlane __PxPlaneEquationFromTransform(physx::PxTransform* transform) {
    return physx::PxPlaneEquationFromTransform(*transform);
};ES bool PxPlaneGeometry__isValid(physx::PxPlaneGeometry* cls) {
    return cls->isValid();
};