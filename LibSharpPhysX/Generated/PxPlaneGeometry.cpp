// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void PxTransform_PxTransformFromPlaneEquationPtr_PxPlane_(physx::PxTransform* nRetRef, physx::PxPlane* wrp_plane){
    *nRetRef = ::physx::PxTransformFromPlaneEquation(*wrp_plane);
}

ES void PxPlane_PxPlaneEquationFromTransformPtr_PxTransform_(physx::PxPlane* nRetRef, physx::PxTransform* wrp_transform){
    *nRetRef = ::physx::PxPlaneEquationFromTransform(*wrp_transform);
}

ES void void_PxPlaneGeometry_PxPlaneGeometryPtr_Ctor(physx::PxPlaneGeometry* wrp_this){
    *wrp_this = ::physx::PxPlaneGeometry::PxPlaneGeometry();
}

ES bool bool_const_PxPlaneGeometry_isValidPtr(physx::PxPlaneGeometry* wrp_this){
    return (bool) wrp_this->isValid();
}

