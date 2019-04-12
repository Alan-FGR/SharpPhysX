// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
ES void Freer_physx_PxMeshScalePtr(PxMeshScalePtr ptr){
    delete ptr;
}

ES PxMeshScalePtr Ctor_physx_PxMeshScalePtr_(){
    return (PxMeshScalePtr) new std::remove_pointer<PxMeshScalePtr>::type();
}

ES PxMeshScalePtr Ctor_physx_PxMeshScalePtr_float(float wrp_r){
    return (PxMeshScalePtr) new std::remove_pointer<PxMeshScalePtr>::type(wrp_r);
}

ES PxMeshScalePtr Ctor_physx_PxMeshScalePtr_physx_PxVec3Ptr(PxVec3Ptr wrp_s){
    return (PxMeshScalePtr) new std::remove_pointer<PxMeshScalePtr>::type(*wrp_s);
}

ES PxMeshScalePtr Ctor_physx_PxMeshScalePtr_physx_PxVec3Ptr_physx_PxQuatPtr(PxVec3Ptr wrp_s, PxQuatPtr wrp_r){
    return (PxMeshScalePtr) new std::remove_pointer<PxMeshScalePtr>::type(*wrp_s, *wrp_r);
}

ES PxVec3Ptr PxMeshScale_GET_scale(PxMeshScalePtr cls) {return (PxVec3Ptr)&cls->scale;}
ES void PxMeshScale_SET_scale(PxMeshScalePtr cls, PxVec3Ptr value) {cls->scale = *value;}

ES PxQuatPtr PxMeshScale_GET_rotation(PxMeshScalePtr cls) {return (PxQuatPtr)&cls->rotation;}
ES void PxMeshScale_SET_rotation(PxMeshScalePtr cls, PxQuatPtr value) {cls->rotation = *value;}

ES bool bool_const_physx_PxMeshScale_isIdentity(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->isIdentity();
}

ES PxMeshScalePtr physx_PxMeshScalePtr_const_physx_PxMeshScale_getInverse(PxMeshScalePtr wrp_this){
    auto ret = wrp_this->getInverse();
    auto heap = new char[sizeof PxMeshScale];
    std::memcpy(heap, &ret, sizeof PxMeshScale);
    return (PxMeshScalePtr) heap;
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMeshScale_toMat33(PxMeshScalePtr wrp_this){
    auto ret = wrp_this->toMat33();
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES bool bool_const_physx_PxMeshScale_hasNegativeDeterminant(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->hasNegativeDeterminant();
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMeshScale_transform_physx_PxVec3Ptr_(PxMeshScalePtr wrp_this, PxVec3Ptr wrp_v){
    auto ret = wrp_this->transform(*wrp_v);
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES bool bool_const_physx_PxMeshScale_isValidForTriangleMesh(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->isValidForTriangleMesh();
}

ES bool bool_const_physx_PxMeshScale_isValidForConvexMesh(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->isValidForConvexMesh();
}
