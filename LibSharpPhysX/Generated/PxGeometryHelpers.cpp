// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
ES void Freer_physx_PxGeometryHolderPtr_physx_PxGeometryHolder_ANONYMOUS_unionPtr(physx_PxGeometryHolder_ANONYMOUS_unionPtr ptr){
    delete ptr;
}

ES void Freer_physx_PxGeometryHolderPtr(PxGeometryHolderPtr ptr){
    delete ptr;
}

ES PxGeometryHolderPtr Ctor_physx_PxGeometryHolderPtr_(){
    return (PxGeometryHolderPtr) new std::remove_pointer<PxGeometryHolderPtr>::type();
}

ES PxGeometryHolderPtr Ctor_physx_PxGeometryHolderPtr_physx_PxGeometryPtr(PxGeometryPtr wrp_geometry){
    return (PxGeometryHolderPtr) new std::remove_pointer<PxGeometryHolderPtr>::type(*wrp_geometry);
}

ES physx::PxGeometryType::Enum physx_PxGeometryTypeEnum_const_physx_PxGeometryHolder_getType(PxGeometryHolderPtr wrp_this){
    return (physx::PxGeometryType::Enum) wrp_this->getType();
}

ES PxGeometryPtr physx_PxGeometryPtr_physx_PxGeometryHolder_any(PxGeometryHolderPtr wrp_this){
    return (PxGeometryPtr) &wrp_this->any();
}

ES PxGeometryPtr physx_PxGeometryPtr_const_physx_PxGeometryHolder_any(PxGeometryHolderPtr wrp_this){
    return (PxGeometryPtr) &wrp_this->any();
}

ES PxSphereGeometryPtr physx_PxSphereGeometryPtr_physx_PxGeometryHolder_sphere(PxGeometryHolderPtr wrp_this){
    return (PxSphereGeometryPtr) &wrp_this->sphere();
}

ES PxSphereGeometryPtr physx_PxSphereGeometryPtr_const_physx_PxGeometryHolder_sphere(PxGeometryHolderPtr wrp_this){
    return (PxSphereGeometryPtr) &wrp_this->sphere();
}

ES PxPlaneGeometryPtr physx_PxPlaneGeometryPtr_physx_PxGeometryHolder_plane(PxGeometryHolderPtr wrp_this){
    return (PxPlaneGeometryPtr) &wrp_this->plane();
}

ES PxPlaneGeometryPtr physx_PxPlaneGeometryPtr_const_physx_PxGeometryHolder_plane(PxGeometryHolderPtr wrp_this){
    return (PxPlaneGeometryPtr) &wrp_this->plane();
}

ES PxCapsuleGeometryPtr physx_PxCapsuleGeometryPtr_physx_PxGeometryHolder_capsule(PxGeometryHolderPtr wrp_this){
    return (PxCapsuleGeometryPtr) &wrp_this->capsule();
}

ES PxCapsuleGeometryPtr physx_PxCapsuleGeometryPtr_const_physx_PxGeometryHolder_capsule(PxGeometryHolderPtr wrp_this){
    return (PxCapsuleGeometryPtr) &wrp_this->capsule();
}

ES PxBoxGeometryPtr physx_PxBoxGeometryPtr_physx_PxGeometryHolder_box(PxGeometryHolderPtr wrp_this){
    return (PxBoxGeometryPtr) &wrp_this->box();
}

ES PxBoxGeometryPtr physx_PxBoxGeometryPtr_const_physx_PxGeometryHolder_box(PxGeometryHolderPtr wrp_this){
    return (PxBoxGeometryPtr) &wrp_this->box();
}

ES PxConvexMeshGeometryPtr physx_PxConvexMeshGeometryPtr_physx_PxGeometryHolder_convexMesh(PxGeometryHolderPtr wrp_this){
    return (PxConvexMeshGeometryPtr) &wrp_this->convexMesh();
}

ES PxConvexMeshGeometryPtr physx_PxConvexMeshGeometryPtr_const_physx_PxGeometryHolder_convexMesh(PxGeometryHolderPtr wrp_this){
    return (PxConvexMeshGeometryPtr) &wrp_this->convexMesh();
}

ES PxTriangleMeshGeometryPtr physx_PxTriangleMeshGeometryPtr_physx_PxGeometryHolder_triangleMesh(PxGeometryHolderPtr wrp_this){
    return (PxTriangleMeshGeometryPtr) &wrp_this->triangleMesh();
}

ES PxTriangleMeshGeometryPtr physx_PxTriangleMeshGeometryPtr_const_physx_PxGeometryHolder_triangleMesh(PxGeometryHolderPtr wrp_this){
    return (PxTriangleMeshGeometryPtr) &wrp_this->triangleMesh();
}

ES PxHeightFieldGeometryPtr physx_PxHeightFieldGeometryPtr_physx_PxGeometryHolder_heightField(PxGeometryHolderPtr wrp_this){
    return (PxHeightFieldGeometryPtr) &wrp_this->heightField();
}

ES PxHeightFieldGeometryPtr physx_PxHeightFieldGeometryPtr_const_physx_PxGeometryHolder_heightField(PxGeometryHolderPtr wrp_this){
    return (PxHeightFieldGeometryPtr) &wrp_this->heightField();
}

ES void void_physx_PxGeometryHolder_storeAny_physx_PxGeometryPtr_(PxGeometryHolderPtr wrp_this, PxGeometryPtr wrp_geometry){
    wrp_this->storeAny(*wrp_geometry);
}