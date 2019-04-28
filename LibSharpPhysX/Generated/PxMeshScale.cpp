// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR

ES void Freer_physx_PxMeshScalePtr(PxMeshScalePtr ptr){
    delete ptr;
}

ES PxMeshScalePtr Ctor_PxMeshScalePtr_(){
    auto ret = *(new std::remove_pointer<PxMeshScalePtr>::type());
    auto heap = new char[sizeof PxMeshScale];
    std::memcpy(heap, &ret, sizeof PxMeshScale);
    return (PxMeshScalePtr) heap;
}

ES PxMeshScalePtr Ctor_PxMeshScalePtr_float(PxReal wrp_r){
    auto ret = *(new std::remove_pointer<PxMeshScalePtr>::type(wrp_r));
    auto heap = new char[sizeof PxMeshScale];
    std::memcpy(heap, &ret, sizeof PxMeshScale);
    return (PxMeshScalePtr) heap;
}

ES PxMeshScalePtr Ctor_PxMeshScalePtr_PxVec3_(physx::PxVec3* wrp_s){
    auto ret = *(new std::remove_pointer<PxMeshScalePtr>::type(*wrp_s));
    auto heap = new char[sizeof PxMeshScale];
    std::memcpy(heap, &ret, sizeof PxMeshScale);
    return (PxMeshScalePtr) heap;
}

ES PxMeshScalePtr Ctor_PxMeshScalePtr_PxVec3_PxQuat_(physx::PxVec3* wrp_s, physx::PxQuat* wrp_r){
    auto ret = *(new std::remove_pointer<PxMeshScalePtr>::type(*wrp_s, *wrp_r));
    auto heap = new char[sizeof PxMeshScale];
    std::memcpy(heap, &ret, sizeof PxMeshScale);
    return (PxMeshScalePtr) heap;
}

ES void PxMeshScalePtr_GET_scale(PxMeshScalePtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->scale;}
ES void PxMeshScalePtr_SET_scale(PxMeshScalePtr cls, physx::PxVec3 value) {cls->scale = value;}

ES void PxMeshScalePtr_GET_rotation(PxMeshScalePtr cls, physx::PxQuat* GetRetRef) {*GetRetRef = cls->rotation;}
ES void PxMeshScalePtr_SET_rotation(PxMeshScalePtr cls, physx::PxQuat value) {cls->rotation = value;}

ES bool bool_const_PxMeshScalePtr_isIdentityPtr(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->isIdentity();
}

ES PxMeshScalePtr PxMeshScalePtr_const_PxMeshScalePtr_getInversePtr(PxMeshScalePtr wrp_this){
    auto ret = wrp_this->getInverse();
    auto heap = new char[sizeof PxMeshScale];
    std::memcpy(heap, &ret, sizeof PxMeshScale);
    return (PxMeshScalePtr) heap;
}

ES void PxMat33_const_PxMeshScalePtr_toMat33Ptr(physx::PxMat33* nRetRef, PxMeshScalePtr wrp_this){
    *nRetRef = wrp_this->toMat33();
}

ES bool bool_const_PxMeshScalePtr_hasNegativeDeterminantPtr(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->hasNegativeDeterminant();
}

ES void PxVec3_const_PxMeshScalePtr_transformPtr_PxVec3_(physx::PxVec3* nRetRef, PxMeshScalePtr wrp_this, physx::PxVec3* wrp_v){
    *nRetRef = wrp_this->transform(*wrp_v);
}

ES bool bool_const_PxMeshScalePtr_isValidForTriangleMeshPtr(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->isValidForTriangleMesh();
}

ES bool bool_const_PxMeshScalePtr_isValidForConvexMeshPtr(PxMeshScalePtr wrp_this){
    return (bool) wrp_this->isValidForConvexMesh();
}

