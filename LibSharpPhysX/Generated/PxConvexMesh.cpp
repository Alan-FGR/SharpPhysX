// Generated by minBND 5.1.81.43 - © github.com/Alan-FGR
ES PxHullPolygonPtr Newer_physx_PxHullPolygonPtr(){
    return new std::remove_pointer<PxHullPolygonPtr>::type();
}

ES void Freer_physx_PxHullPolygonPtr(PxHullPolygonPtr ptr){
    delete ptr;
}

ES unsigned short PxHullPolygon_GET_mNbVerts(PxHullPolygonPtr cls) {return (unsigned short)cls->mNbVerts;}
ES void PxHullPolygon_SET_mNbVerts(PxHullPolygonPtr cls, unsigned short value) {cls->mNbVerts = value;}

ES unsigned short PxHullPolygon_GET_mIndexBase(PxHullPolygonPtr cls) {return (unsigned short)cls->mIndexBase;}
ES void PxHullPolygon_SET_mIndexBase(PxHullPolygonPtr cls, unsigned short value) {cls->mIndexBase = value;}

ES unsigned int uint_const_physx_PxConvexMesh_getNbVertices(PxConvexMeshPtr wrp_this){
    return (unsigned int) wrp_this->getNbVertices();
}

ES physx::PxVec3* physx_PxVec3_const_physx_PxConvexMesh_getVertices(PxConvexMeshPtr wrp_this){
    return (physx::PxVec3*) wrp_this->getVertices();
}

ES unsigned char* byte_const_physx_PxConvexMesh_getIndexBuffer(PxConvexMeshPtr wrp_this){
    return (unsigned char*) wrp_this->getIndexBuffer();
}

ES unsigned int uint_const_physx_PxConvexMesh_getNbPolygons(PxConvexMeshPtr wrp_this){
    return (unsigned int) wrp_this->getNbPolygons();
}

ES bool bool_const_physx_PxConvexMesh_getPolygonData_uint_physx_PxHullPolygonPtr_(PxConvexMeshPtr wrp_this, unsigned int wrp_index, PxHullPolygonPtr wrp_data){
    return (bool) wrp_this->getPolygonData(wrp_index, *wrp_data);
}

ES void void_physx_PxConvexMesh_release(PxConvexMeshPtr wrp_this){
    wrp_this->release();
}

ES unsigned int uint_const_physx_PxConvexMesh_getReferenceCount(PxConvexMeshPtr wrp_this){
    return (unsigned int) wrp_this->getReferenceCount();
}

ES void void_physx_PxConvexMesh_acquireReference(PxConvexMeshPtr wrp_this){
    wrp_this->acquireReference();
}

ES void void_const_physx_PxConvexMesh_getMassInformation_float_physx_PxMat33_physx_PxVec3_(PxConvexMeshPtr wrp_this, float* wrp_mass, physx::PxMat33* wrp_localInertia, physx::PxVec3* wrp_localCenterOfMass){
    wrp_this->getMassInformation(*wrp_mass, *wrp_localInertia, *wrp_localCenterOfMass);
}

ES void physx_PxBounds3_const_physx_PxConvexMesh_getLocalBounds(physx::PxBounds3* RetRef, PxConvexMeshPtr wrp_this){
    *RetRef = wrp_this->getLocalBounds();
}

ES char* string_const_physx_PxConvexMesh_getConcreteTypeName(PxConvexMeshPtr wrp_this){
    return (char*) wrp_this->getConcreteTypeName();
}

ES bool bool_const_physx_PxConvexMesh_isGpuCompatible(PxConvexMeshPtr wrp_this){
    return (bool) wrp_this->isGpuCompatible();
}
