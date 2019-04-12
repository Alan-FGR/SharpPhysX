// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
ES void Freer_physx_PxMat33Ptr(PxMat33Ptr ptr){
    delete ptr;
}

ES PxMat33Ptr Ctor_physx_PxMat33Ptr_(){
    return (PxMat33Ptr) new std::remove_pointer<PxMat33Ptr>::type();
}

ES PxMat33Ptr Ctor_physx_PxMat33Ptr_physx_PxIDENTITY(physx::PxIDENTITY wrp_r){
    return (PxMat33Ptr) new std::remove_pointer<PxMat33Ptr>::type(wrp_r);
}

ES PxMat33Ptr Ctor_physx_PxMat33Ptr_physx_PxZERO(physx::PxZERO wrp_r){
    return (PxMat33Ptr) new std::remove_pointer<PxMat33Ptr>::type(wrp_r);
}

ES PxMat33Ptr Ctor_physx_PxMat33Ptr_physx_PxVec3Ptr_physx_PxVec3Ptr_physx_PxVec3Ptr(PxVec3Ptr wrp_col0, PxVec3Ptr wrp_col1, PxVec3Ptr wrp_col2){
    return (PxMat33Ptr) new std::remove_pointer<PxMat33Ptr>::type(*wrp_col0, *wrp_col1, *wrp_col2);
}

ES PxMat33Ptr Ctor_physx_PxMat33Ptr_float(float wrp_r){
    return (PxMat33Ptr) new std::remove_pointer<PxMat33Ptr>::type(wrp_r);
}

ES PxMat33Ptr Ctor_physx_PxMat33Ptr_physx_PxQuatPtr(PxQuatPtr wrp_q){
    return (PxMat33Ptr) new std::remove_pointer<PxMat33Ptr>::type(*wrp_q);
}

ES PxMat33Ptr Ctor_physx_PxMat33Ptr_physx_PxMat33Ptr(PxMat33Ptr wrp_other){
    return (PxMat33Ptr) new std::remove_pointer<PxMat33Ptr>::type(*wrp_other);
}

ES PxVec3Ptr PxMat33_GET_column0(PxMat33Ptr cls) {return (PxVec3Ptr)&cls->column0;}
ES void PxMat33_SET_column0(PxMat33Ptr cls, PxVec3Ptr value) {cls->column0 = *value;}

ES PxVec3Ptr PxMat33_GET_column1(PxMat33Ptr cls) {return (PxVec3Ptr)&cls->column1;}
ES void PxMat33_SET_column1(PxMat33Ptr cls, PxVec3Ptr value) {cls->column1 = *value;}

ES PxVec3Ptr PxMat33_GET_column2(PxMat33Ptr cls) {return (PxVec3Ptr)&cls->column2;}
ES void PxMat33_SET_column2(PxMat33Ptr cls, PxVec3Ptr value) {cls->column2 = *value;}

ES bool bool_const_physx_PxMat33_operator_EqualEqual_physx_PxMat33Ptr_(PxMat33Ptr wrp_lhs, PxMat33Ptr wrp_m){
    return (bool) wrp_lhs->operator==(*wrp_m);
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMat33_getTranspose(PxMat33Ptr wrp_this){
    auto ret = wrp_this->getTranspose();
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMat33_getInverse(PxMat33Ptr wrp_this){
    auto ret = wrp_this->getInverse();
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES float float_const_physx_PxMat33_getDeterminant(PxMat33Ptr wrp_this){
    return (float) wrp_this->getDeterminant();
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMat33_operator_Minus(PxMat33Ptr wrp_lhs){
    auto ret = wrp_lhs->operator-();
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMat33_operator_Plus_physx_PxMat33Ptr_(PxMat33Ptr wrp_lhs, PxMat33Ptr wrp_other){
    auto ret = wrp_lhs->operator+(*wrp_other);
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMat33_operator_Minus_physx_PxMat33Ptr_(PxMat33Ptr wrp_lhs, PxMat33Ptr wrp_other){
    auto ret = wrp_lhs->operator-(*wrp_other);
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMat33_operator_Star_float_(PxMat33Ptr wrp_lhs, float wrp_scalar){
    auto ret = wrp_lhs->operator*(wrp_scalar);
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMat33_operator_Star_physx_PxVec3Ptr_(PxMat33Ptr wrp_lhs, PxVec3Ptr wrp_vec){
    auto ret = wrp_lhs->operator*(*wrp_vec);
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES PxMat33Ptr physx_PxMat33Ptr_const_physx_PxMat33_operator_Star_physx_PxMat33Ptr_(PxMat33Ptr wrp_lhs, PxMat33Ptr wrp_other){
    auto ret = wrp_lhs->operator*(*wrp_other);
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMat33_transform_physx_PxVec3Ptr_(PxMat33Ptr wrp_this, PxVec3Ptr wrp_other){
    auto ret = wrp_this->transform(*wrp_other);
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMat33_transformTranspose_physx_PxVec3Ptr_(PxMat33Ptr wrp_this, PxVec3Ptr wrp_other){
    auto ret = wrp_this->transformTranspose(*wrp_other);
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES float* float_const_physx_PxMat33_front(PxMat33Ptr wrp_this){
    return (float*) wrp_this->front();
}

ES PxMat33Ptr physx_PxMat33Ptr_physx_PxMat33_createDiagonal_physx_PxVec3Ptr_(PxVec3Ptr wrp_d){
    auto ret = physx::PxMat33::createDiagonal(*wrp_d);
    auto heap = new char[sizeof PxMat33];
    std::memcpy(heap, &ret, sizeof PxMat33);
    return (PxMat33Ptr) heap;
}
