// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
ES void Freer_physx_PxMat44Ptr(PxMat44Ptr ptr){
    delete ptr;
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_(){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type();
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxIDENTITY(physx::PxIDENTITY wrp_r){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(wrp_r);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxZERO(physx::PxZERO wrp_r){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(wrp_r);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxVec4Ptr_physx_PxVec4Ptr_physx_PxVec4Ptr_physx_PxVec4Ptr(PxVec4Ptr wrp_col0, PxVec4Ptr wrp_col1, PxVec4Ptr wrp_col2, PxVec4Ptr wrp_col3){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(*wrp_col0, *wrp_col1, *wrp_col2, *wrp_col3);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_float(float wrp_r){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(wrp_r);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxVec3Ptr_physx_PxVec3Ptr_physx_PxVec3Ptr_physx_PxVec3Ptr(PxVec3Ptr wrp_col0, PxVec3Ptr wrp_col1, PxVec3Ptr wrp_col2, PxVec3Ptr wrp_col3){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(*wrp_col0, *wrp_col1, *wrp_col2, *wrp_col3);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxQuatPtr(PxQuatPtr wrp_q){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(*wrp_q);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxVec4Ptr(PxVec4Ptr wrp_diagonal){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(*wrp_diagonal);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxMat33Ptr_physx_PxVec3Ptr(PxMat33Ptr wrp_axes, PxVec3Ptr wrp_position){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(*wrp_axes, *wrp_position);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxTransformPtr(PxTransformPtr wrp_t){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(*wrp_t);
}

ES PxMat44Ptr Ctor_physx_PxMat44Ptr_physx_PxMat44Ptr(PxMat44Ptr wrp_other){
    return (PxMat44Ptr) new std::remove_pointer<PxMat44Ptr>::type(*wrp_other);
}

ES PxVec4Ptr PxMat44_GET_column0(PxMat44Ptr cls) {return (PxVec4Ptr)&cls->column0;}
ES void PxMat44_SET_column0(PxMat44Ptr cls, PxVec4Ptr value) {cls->column0 = *value;}

ES PxVec4Ptr PxMat44_GET_column1(PxMat44Ptr cls) {return (PxVec4Ptr)&cls->column1;}
ES void PxMat44_SET_column1(PxMat44Ptr cls, PxVec4Ptr value) {cls->column1 = *value;}

ES PxVec4Ptr PxMat44_GET_column2(PxMat44Ptr cls) {return (PxVec4Ptr)&cls->column2;}
ES void PxMat44_SET_column2(PxMat44Ptr cls, PxVec4Ptr value) {cls->column2 = *value;}

ES PxVec4Ptr PxMat44_GET_column3(PxMat44Ptr cls) {return (PxVec4Ptr)&cls->column3;}
ES void PxMat44_SET_column3(PxMat44Ptr cls, PxVec4Ptr value) {cls->column3 = *value;}

ES bool bool_const_physx_PxMat44_operator_EqualEqual_physx_PxMat44Ptr_(PxMat44Ptr wrp_lhs, PxMat44Ptr wrp_m){
    return (bool) wrp_lhs->operator==(*wrp_m);
}

ES PxMat44Ptr physx_PxMat44Ptr_const_physx_PxMat44_getTranspose(PxMat44Ptr wrp_this){
    auto ret = wrp_this->getTranspose();
    auto heap = new char[sizeof PxMat44];
    std::memcpy(heap, &ret, sizeof PxMat44);
    return (PxMat44Ptr) heap;
}

ES PxMat44Ptr physx_PxMat44Ptr_const_physx_PxMat44_operator_Minus(PxMat44Ptr wrp_lhs){
    auto ret = wrp_lhs->operator-();
    auto heap = new char[sizeof PxMat44];
    std::memcpy(heap, &ret, sizeof PxMat44);
    return (PxMat44Ptr) heap;
}

ES PxMat44Ptr physx_PxMat44Ptr_const_physx_PxMat44_operator_Plus_physx_PxMat44Ptr_(PxMat44Ptr wrp_lhs, PxMat44Ptr wrp_other){
    auto ret = wrp_lhs->operator+(*wrp_other);
    auto heap = new char[sizeof PxMat44];
    std::memcpy(heap, &ret, sizeof PxMat44);
    return (PxMat44Ptr) heap;
}

ES PxMat44Ptr physx_PxMat44Ptr_const_physx_PxMat44_operator_Minus_physx_PxMat44Ptr_(PxMat44Ptr wrp_lhs, PxMat44Ptr wrp_other){
    auto ret = wrp_lhs->operator-(*wrp_other);
    auto heap = new char[sizeof PxMat44];
    std::memcpy(heap, &ret, sizeof PxMat44);
    return (PxMat44Ptr) heap;
}

ES PxMat44Ptr physx_PxMat44Ptr_const_physx_PxMat44_operator_Star_float_(PxMat44Ptr wrp_lhs, float wrp_scalar){
    auto ret = wrp_lhs->operator*(wrp_scalar);
    auto heap = new char[sizeof PxMat44];
    std::memcpy(heap, &ret, sizeof PxMat44);
    return (PxMat44Ptr) heap;
}

ES PxMat44Ptr physx_PxMat44Ptr_const_physx_PxMat44_operator_Star_physx_PxMat44Ptr_(PxMat44Ptr wrp_lhs, PxMat44Ptr wrp_other){
    auto ret = wrp_lhs->operator*(*wrp_other);
    auto heap = new char[sizeof PxMat44];
    std::memcpy(heap, &ret, sizeof PxMat44);
    return (PxMat44Ptr) heap;
}

ES PxVec4Ptr physx_PxVec4Ptr_const_physx_PxMat44_transform_physx_PxVec4Ptr_(PxMat44Ptr wrp_this, PxVec4Ptr wrp_other){
    auto ret = wrp_this->transform(*wrp_other);
    auto heap = new char[sizeof PxVec4];
    std::memcpy(heap, &ret, sizeof PxVec4);
    return (PxVec4Ptr) heap;
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMat44_transform_physx_PxVec3Ptr_(PxMat44Ptr wrp_this, PxVec3Ptr wrp_other){
    auto ret = wrp_this->transform(*wrp_other);
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES PxVec4Ptr physx_PxVec4Ptr_const_physx_PxMat44_rotate_physx_PxVec4Ptr_(PxMat44Ptr wrp_this, PxVec4Ptr wrp_other){
    auto ret = wrp_this->rotate(*wrp_other);
    auto heap = new char[sizeof PxVec4];
    std::memcpy(heap, &ret, sizeof PxVec4);
    return (PxVec4Ptr) heap;
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMat44_rotate_physx_PxVec3Ptr_(PxMat44Ptr wrp_this, PxVec3Ptr wrp_other){
    auto ret = wrp_this->rotate(*wrp_other);
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMat44_getBasis_int_(PxMat44Ptr wrp_this, int wrp_num){
    auto ret = wrp_this->getBasis(wrp_num);
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES PxVec3Ptr physx_PxVec3Ptr_const_physx_PxMat44_getPosition(PxMat44Ptr wrp_this){
    auto ret = wrp_this->getPosition();
    auto heap = new char[sizeof PxVec3];
    std::memcpy(heap, &ret, sizeof PxVec3);
    return (PxVec3Ptr) heap;
}

ES void void_physx_PxMat44_setPosition_physx_PxVec3Ptr_(PxMat44Ptr wrp_this, PxVec3Ptr wrp_position){
    wrp_this->setPosition(*wrp_position);
}

ES float* float_const_physx_PxMat44_front(PxMat44Ptr wrp_this){
    return (float*) wrp_this->front();
}

ES void void_physx_PxMat44_scale_physx_PxVec4Ptr_(PxMat44Ptr wrp_this, PxVec4Ptr wrp_p){
    wrp_this->scale(*wrp_p);
}

ES PxMat44Ptr physx_PxMat44Ptr_const_physx_PxMat44_inverseRT(PxMat44Ptr wrp_this){
    auto ret = wrp_this->inverseRT();
    auto heap = new char[sizeof PxMat44];
    std::memcpy(heap, &ret, sizeof PxMat44);
    return (PxMat44Ptr) heap;
}

ES bool bool_const_physx_PxMat44_isFinite(PxMat44Ptr wrp_this){
    return (bool) wrp_this->isFinite();
}