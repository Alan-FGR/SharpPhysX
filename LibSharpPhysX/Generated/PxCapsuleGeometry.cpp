// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void PxTransform_PxTransformFromSegmentPtr_PxVec3_PxVec3_(physx::PxTransform* nRetRef, physx::PxVec3* wrp_p0, physx::PxVec3* wrp_p1){
    *nRetRef = ::physx::PxTransformFromSegment(*wrp_p0, *wrp_p1);
}

ES void PxTransform_PxTransformFromSegmentPtr_PxVec3_PxVec3_float_(physx::PxTransform* nRetRef, physx::PxVec3* wrp_p0, physx::PxVec3* wrp_p1, PxReal* wrp_halfHeight){
    *nRetRef = ::physx::PxTransformFromSegment(*wrp_p0, *wrp_p1, wrp_halfHeight);
}

ES void void_PxCapsuleGeometry_PxCapsuleGeometryPtr_Ctor(physx::PxCapsuleGeometry* wrp_this){
    *wrp_this = ::physx::PxCapsuleGeometry::PxCapsuleGeometry();
}

ES void void_PxCapsuleGeometry_PxCapsuleGeometryPtr_Ctor_float_float_(physx::PxCapsuleGeometry* wrp_this, PxReal wrp_radius_, PxReal wrp_halfHeight_){
    *wrp_this = ::physx::PxCapsuleGeometry::PxCapsuleGeometry(wrp_radius_, wrp_halfHeight_);
}

ES bool bool_const_PxCapsuleGeometry_isValidPtr(physx::PxCapsuleGeometry* wrp_this){
    return (bool) wrp_this->isValid();
}

