// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR

ES PxMeshGeometryFlagsPtr PxMeshGeometryFlagsPtr_operator_Ptr_Pipe_PxMeshGeometryFlagEnum_PxMeshGeometryFlagEnum_(physx::PxMeshGeometryFlag::Enum wrp_a, physx::PxMeshGeometryFlag::Enum wrp_b){
    auto ret = ::physx::operator|(wrp_a, wrp_b);
    auto heap = new char[sizeof PxMeshGeometryFlags];
    std::memcpy(heap, &ret, sizeof PxMeshGeometryFlags);
    return (PxMeshGeometryFlagsPtr) heap;
}

ES PxMeshGeometryFlagsPtr PxMeshGeometryFlagsPtr_operator_Ptr_Amp_PxMeshGeometryFlagEnum_PxMeshGeometryFlagEnum_(physx::PxMeshGeometryFlag::Enum wrp_a, physx::PxMeshGeometryFlag::Enum wrp_b){
    auto ret = ::physx::operator&(wrp_a, wrp_b);
    auto heap = new char[sizeof PxMeshGeometryFlags];
    std::memcpy(heap, &ret, sizeof PxMeshGeometryFlags);
    return (PxMeshGeometryFlagsPtr) heap;
}

ES PxMeshGeometryFlagsPtr PxMeshGeometryFlagsPtr_operator_Ptr_Tilde_PxMeshGeometryFlagEnum_(physx::PxMeshGeometryFlag::Enum wrp_a){
    auto ret = ::physx::operator~(wrp_a);
    auto heap = new char[sizeof PxMeshGeometryFlags];
    std::memcpy(heap, &ret, sizeof PxMeshGeometryFlags);
    return (PxMeshGeometryFlagsPtr) heap;
}

ES void Default_PxTriangleMeshGeometry_(physx::PxTriangleMeshGeometry* nRetRef){
    *nRetRef = PxTriangleMeshGeometry();
}

ES void void_PxTriangleMeshGeometry_PxTriangleMeshGeometryPtr_Ctor_PxTriangleMeshPtr_(physx::PxTriangleMeshGeometry* wrp_this, PxTriangleMeshPtr wrp_mesh){
    *wrp_this = ::physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry(wrp_mesh);
}

ES void void_PxTriangleMeshGeometry_PxTriangleMeshGeometryPtr_Ctor_PxTriangleMeshPtr_PxMeshScalePtr_(physx::PxTriangleMeshGeometry* wrp_this, PxTriangleMeshPtr wrp_mesh, PxMeshScalePtr wrp_scaling){
    *wrp_this = ::physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry(wrp_mesh, *wrp_scaling);
}

ES void void_PxTriangleMeshGeometry_PxTriangleMeshGeometryPtr_Ctor_PxTriangleMeshPtr_PxMeshScalePtr_PxMeshGeometryFlagsPtr_(physx::PxTriangleMeshGeometry* wrp_this, PxTriangleMeshPtr wrp_mesh, PxMeshScalePtr wrp_scaling, PxMeshGeometryFlagsPtr wrp_flags){
    *wrp_this = ::physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry(wrp_mesh, *wrp_scaling, *wrp_flags);
}

ES bool bool_const_PxTriangleMeshGeometry_isValidPtr(physx::PxTriangleMeshGeometry* wrp_this){
    return (bool) wrp_this->isValid();
}

