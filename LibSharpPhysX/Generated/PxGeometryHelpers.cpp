// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR

ES void Freer_physx_PxGeometryHolderPtr_physx_PxGeometryHolder_ANONYMOUS_unionPtr(physx_PxGeometryHolder_ANONYMOUS_unionPtr ptr){
    delete ptr;
}

ES void Freer_physx_PxGeometryHolderPtr(PxGeometryHolderPtr ptr){
    delete ptr;
}

ES PxGeometryHolderPtr Ctor_PxGeometryHolderPtr_(){
    auto ret = *(new std::remove_pointer<PxGeometryHolderPtr>::type());
    auto heap = new char[sizeof PxGeometryHolder];
    std::memcpy(heap, &ret, sizeof PxGeometryHolder);
    return (PxGeometryHolderPtr) heap;
}

ES PxGeometryHolderPtr Ctor_PxGeometryHolderPtr_PxGeometry_(physx::PxGeometry* wrp_geometry){
    auto ret = *(new std::remove_pointer<PxGeometryHolderPtr>::type(*wrp_geometry));
    auto heap = new char[sizeof PxGeometryHolder];
    std::memcpy(heap, &ret, sizeof PxGeometryHolder);
    return (PxGeometryHolderPtr) heap;
}

ES physx::PxGeometryType::Enum PxGeometryTypeEnum_const_PxGeometryHolderPtr_getTypePtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxGeometryType::Enum) wrp_this->getType();
}

ES physx::PxGeometry* PxGeometry_PxGeometryHolderPtr_anyPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxGeometry*) &wrp_this->any();
}

ES physx::PxGeometry* PxGeometry_const_PxGeometryHolderPtr_anyPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxGeometry*) &wrp_this->any();
}

ES physx::PxSphereGeometry* PxSphereGeometry_PxGeometryHolderPtr_spherePtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxSphereGeometry*) &wrp_this->sphere();
}

ES physx::PxSphereGeometry* PxSphereGeometry_const_PxGeometryHolderPtr_spherePtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxSphereGeometry*) &wrp_this->sphere();
}

ES physx::PxPlaneGeometry* PxPlaneGeometry_PxGeometryHolderPtr_planePtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxPlaneGeometry*) &wrp_this->plane();
}

ES physx::PxPlaneGeometry* PxPlaneGeometry_const_PxGeometryHolderPtr_planePtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxPlaneGeometry*) &wrp_this->plane();
}

ES physx::PxCapsuleGeometry* PxCapsuleGeometry_PxGeometryHolderPtr_capsulePtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxCapsuleGeometry*) &wrp_this->capsule();
}

ES physx::PxCapsuleGeometry* PxCapsuleGeometry_const_PxGeometryHolderPtr_capsulePtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxCapsuleGeometry*) &wrp_this->capsule();
}

ES physx::PxBoxGeometry* PxBoxGeometry_PxGeometryHolderPtr_boxPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxBoxGeometry*) &wrp_this->box();
}

ES physx::PxBoxGeometry* PxBoxGeometry_const_PxGeometryHolderPtr_boxPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxBoxGeometry*) &wrp_this->box();
}

ES physx::PxConvexMeshGeometry* PxConvexMeshGeometry_PxGeometryHolderPtr_convexMeshPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxConvexMeshGeometry*) &wrp_this->convexMesh();
}

ES physx::PxConvexMeshGeometry* PxConvexMeshGeometry_const_PxGeometryHolderPtr_convexMeshPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxConvexMeshGeometry*) &wrp_this->convexMesh();
}

ES physx::PxTriangleMeshGeometry* PxTriangleMeshGeometry_PxGeometryHolderPtr_triangleMeshPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxTriangleMeshGeometry*) &wrp_this->triangleMesh();
}

ES physx::PxTriangleMeshGeometry* PxTriangleMeshGeometry_const_PxGeometryHolderPtr_triangleMeshPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxTriangleMeshGeometry*) &wrp_this->triangleMesh();
}

ES physx::PxHeightFieldGeometry* PxHeightFieldGeometry_PxGeometryHolderPtr_heightFieldPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxHeightFieldGeometry*) &wrp_this->heightField();
}

ES physx::PxHeightFieldGeometry* PxHeightFieldGeometry_const_PxGeometryHolderPtr_heightFieldPtr(PxGeometryHolderPtr wrp_this){
    return (physx::PxHeightFieldGeometry*) &wrp_this->heightField();
}

ES void void_PxGeometryHolderPtr_storeAnyPtr_PxGeometry_(PxGeometryHolderPtr wrp_this, physx::PxGeometry* wrp_geometry){
    wrp_this->storeAny(*wrp_geometry);
}

