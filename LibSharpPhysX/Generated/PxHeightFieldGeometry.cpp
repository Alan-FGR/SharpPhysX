// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void void_PxHeightFieldGeometry_PxHeightFieldGeometryPtr_Ctor(physx::PxHeightFieldGeometry* wrp_this){
    *wrp_this = ::physx::PxHeightFieldGeometry::PxHeightFieldGeometry();
}

ES void void_PxHeightFieldGeometry_PxHeightFieldGeometryPtr_Ctor_PxHeightFieldPtr_PxMeshGeometryFlagsPtr_float_float_float_(physx::PxHeightFieldGeometry* wrp_this, PxHeightFieldPtr wrp_hf, PxMeshGeometryFlagsPtr wrp_flags, PxReal wrp_heightScale_, PxReal wrp_rowScale_, PxReal wrp_columnScale_){
    *wrp_this = ::physx::PxHeightFieldGeometry::PxHeightFieldGeometry(wrp_hf, *wrp_flags, wrp_heightScale_, wrp_rowScale_, wrp_columnScale_);
}

ES bool bool_const_PxHeightFieldGeometry_isValidPtr(physx::PxHeightFieldGeometry* wrp_this){
    return (bool) wrp_this->isValid();
}

