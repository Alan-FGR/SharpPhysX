// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR

ES void Default_PxMat44_(physx::PxMat44* nRetRef){
    *nRetRef = PxMat44();
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxIDENTITY_(physx::PxMat44* wrp_this, physx::PxIDENTITY wrp_r){
    *wrp_this = ::physx::PxMat44::PxMat44(wrp_r);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxZERO_(physx::PxMat44* wrp_this, physx::PxZERO wrp_r){
    *wrp_this = ::physx::PxMat44::PxMat44(wrp_r);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxVec4_PxVec4_PxVec4_PxVec4_(physx::PxMat44* wrp_this, physx::PxVec4* wrp_col0, physx::PxVec4* wrp_col1, physx::PxVec4* wrp_col2, physx::PxVec4* wrp_col3){
    *wrp_this = ::physx::PxMat44::PxMat44(*wrp_col0, *wrp_col1, *wrp_col2, *wrp_col3);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_float_(physx::PxMat44* wrp_this, float wrp_r){
    *wrp_this = ::physx::PxMat44::PxMat44(wrp_r);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxVec3_PxVec3_PxVec3_PxVec3_(physx::PxMat44* wrp_this, physx::PxVec3* wrp_col0, physx::PxVec3* wrp_col1, physx::PxVec3* wrp_col2, physx::PxVec3* wrp_col3){
    *wrp_this = ::physx::PxMat44::PxMat44(*wrp_col0, *wrp_col1, *wrp_col2, *wrp_col3);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxQuat_(physx::PxMat44* wrp_this, physx::PxQuat* wrp_q){
    *wrp_this = ::physx::PxMat44::PxMat44(*wrp_q);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxVec4_(physx::PxMat44* wrp_this, physx::PxVec4* wrp_diagonal){
    *wrp_this = ::physx::PxMat44::PxMat44(*wrp_diagonal);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxMat33_PxVec3_(physx::PxMat44* wrp_this, physx::PxMat33* wrp_axes, physx::PxVec3* wrp_position){
    *wrp_this = ::physx::PxMat44::PxMat44(*wrp_axes, *wrp_position);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxTransform_(physx::PxMat44* wrp_this, physx::PxTransform* wrp_t){
    *wrp_this = ::physx::PxMat44::PxMat44(*wrp_t);
}

ES bool bool_const_PxMat44_operator_Ptr_EqualEqual_PxMat44_(physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_m){
    return (bool) wrp_lhs->::physx::PxMat44::operator==(*wrp_m);
}

ES void void_PxMat44_PxMat44Ptr_Ctor_PxMat44_(physx::PxMat44* wrp_this, physx::PxMat44* wrp_other){
    *wrp_this = ::physx::PxMat44::PxMat44(*wrp_other);
}

ES physx::PxMat44* PxMat44_PxMat44_operator_Ptr_Equal_PxMat44_(physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_other){
    return (physx::PxMat44*) &wrp_lhs->::physx::PxMat44::operator=(*wrp_other);
}

ES void PxMat44_const_PxMat44_getTransposePtr(physx::PxMat44* nRetRef, physx::PxMat44* wrp_this){
    *nRetRef = wrp_this->getTranspose();
}

ES void PxMat44_const_PxMat44_operator_Ptr_Minus(physx::PxMat44* nRetRef, physx::PxMat44* wrp_lhs){
    *nRetRef = wrp_lhs->::physx::PxMat44::operator-();
}

ES void PxMat44_const_PxMat44_operator_Ptr_Plus_PxMat44_(physx::PxMat44* nRetRef, physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_other){
    *nRetRef = wrp_lhs->::physx::PxMat44::operator+(*wrp_other);
}

ES void PxMat44_const_PxMat44_operator_Ptr_Minus_PxMat44_(physx::PxMat44* nRetRef, physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_other){
    *nRetRef = wrp_lhs->::physx::PxMat44::operator-(*wrp_other);
}

ES void PxMat44_const_PxMat44_operator_Ptr_Star_float_(physx::PxMat44* nRetRef, physx::PxMat44* wrp_lhs, float wrp_scalar){
    *nRetRef = wrp_lhs->::physx::PxMat44::operator*(wrp_scalar);
}

ES void PxMat44_const_PxMat44_operator_Ptr_Star_PxMat44_(physx::PxMat44* nRetRef, physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_other){
    *nRetRef = wrp_lhs->::physx::PxMat44::operator*(*wrp_other);
}

ES physx::PxMat44* PxMat44_PxMat44_operator_Ptr_PlusEqual_PxMat44_(physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_other){
    return (physx::PxMat44*) &wrp_lhs->::physx::PxMat44::operator+=(*wrp_other);
}

ES physx::PxMat44* PxMat44_PxMat44_operator_Ptr_MinusEqual_PxMat44_(physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_other){
    return (physx::PxMat44*) &wrp_lhs->::physx::PxMat44::operator-=(*wrp_other);
}

ES physx::PxMat44* PxMat44_PxMat44_operator_Ptr_StarEqual_float_(physx::PxMat44* wrp_lhs, float wrp_scalar){
    return (physx::PxMat44*) &wrp_lhs->::physx::PxMat44::operator*=(wrp_scalar);
}

ES physx::PxMat44* PxMat44_PxMat44_operator_Ptr_StarEqual_PxMat44_(physx::PxMat44* wrp_lhs, physx::PxMat44* wrp_other){
    return (physx::PxMat44*) &wrp_lhs->::physx::PxMat44::operator*=(*wrp_other);
}

ES float float_const_PxMat44_operator_Ptr_Call_uint_uint_(physx::PxMat44* wrp_lhs, unsigned int wrp_row, unsigned int wrp_col){
    return (float) wrp_lhs->::physx::PxMat44::operator()(wrp_row, wrp_col);
}

ES float* float_PxMat44_operator_Ptr_Call_uint_uint_(physx::PxMat44* wrp_lhs, unsigned int wrp_row, unsigned int wrp_col){
    return (float*) &wrp_lhs->::physx::PxMat44::operator()(wrp_row, wrp_col);
}

ES void PxVec4_const_PxMat44_transformPtr_PxVec4_(physx::PxVec4* nRetRef, physx::PxMat44* wrp_this, physx::PxVec4* wrp_other){
    *nRetRef = wrp_this->transform(*wrp_other);
}

ES void PxVec3_const_PxMat44_transformPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxMat44* wrp_this, physx::PxVec3* wrp_other){
    *nRetRef = wrp_this->transform(*wrp_other);
}

ES void PxVec4_const_PxMat44_rotatePtr_PxVec4_(physx::PxVec4* nRetRef, physx::PxMat44* wrp_this, physx::PxVec4* wrp_other){
    *nRetRef = wrp_this->rotate(*wrp_other);
}

ES void PxVec3_const_PxMat44_rotatePtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxMat44* wrp_this, physx::PxVec3* wrp_other){
    *nRetRef = wrp_this->rotate(*wrp_other);
}

ES void PxVec3_const_PxMat44_getBasisPtr_int_(physx::PxVec3* nRetRef, physx::PxMat44* wrp_this, int wrp_num){
    *nRetRef = wrp_this->getBasis(wrp_num);
}

ES void PxVec3_const_PxMat44_getPositionPtr(physx::PxVec3* nRetRef, physx::PxMat44* wrp_this){
    *nRetRef = wrp_this->getPosition();
}

ES void void_PxMat44_setPositionPtr_PxVec3_(physx::PxMat44* wrp_this, physx::PxVec3* wrp_position){
    wrp_this->setPosition(*wrp_position);
}

ES float* float_const_PxMat44_frontPtr(physx::PxMat44* wrp_this){
    return (float*) wrp_this->front();
}

ES physx::PxVec4* PxVec4_PxMat44_operator_Ptr_Subscript_uint_(physx::PxMat44* wrp_lhs, unsigned int wrp_num){
    return (physx::PxVec4*) &wrp_lhs->::physx::PxMat44::operator[](wrp_num);
}

ES physx::PxVec4* PxVec4_const_PxMat44_operator_Ptr_Subscript_uint_(physx::PxMat44* wrp_lhs, unsigned int wrp_num){
    return (physx::PxVec4*) &wrp_lhs->::physx::PxMat44::operator[](wrp_num);
}

ES void void_PxMat44_scalePtr_PxVec4_(physx::PxMat44* wrp_this, physx::PxVec4* wrp_p){
    wrp_this->scale(*wrp_p);
}

ES void PxMat44_const_PxMat44_inverseRTPtr(physx::PxMat44* nRetRef, physx::PxMat44* wrp_this){
    *nRetRef = wrp_this->inverseRT();
}

ES bool bool_const_PxMat44_isFinitePtr(physx::PxMat44* wrp_this){
    return (bool) wrp_this->isFinite();
}

