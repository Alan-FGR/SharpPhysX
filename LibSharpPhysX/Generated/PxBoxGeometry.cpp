// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR

ES void Default_PxBoxGeometry_(physx::PxBoxGeometry* nRetRef){
    *nRetRef = PxBoxGeometry();
}

ES void void_PxBoxGeometry_PxBoxGeometryPtr_Ctor_float_float_float_(physx::PxBoxGeometry* wrp_this, PxReal wrp_hx, PxReal wrp_hy, PxReal wrp_hz){
    *wrp_this = ::physx::PxBoxGeometry::PxBoxGeometry(wrp_hx, wrp_hy, wrp_hz);
}

ES void void_PxBoxGeometry_PxBoxGeometryPtr_Ctor_PxVec3_(physx::PxBoxGeometry* wrp_this, physx::PxVec3 wrp_halfExtents_){
    *wrp_this = ::physx::PxBoxGeometry::PxBoxGeometry(wrp_halfExtents_);
}

ES bool bool_const_PxBoxGeometry_isValidPtr(physx::PxBoxGeometry* wrp_this){
    return (bool) wrp_this->isValid();
}

