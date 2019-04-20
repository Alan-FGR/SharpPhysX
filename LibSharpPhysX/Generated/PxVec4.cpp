// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR

ES void PxVec4_operator_Ptr_Star_float_PxVec4_(physx::PxVec4* nRetRef, float wrp_f, physx::PxVec4* wrp_v){
    *nRetRef = ::physx::operator*(wrp_f, *wrp_v);
}

ES void Default_PxVec4_(physx::PxVec4* nRetRef){
    *nRetRef = PxVec4();
}

ES void void_PxVec4_PxVec4Ptr_Ctor_PxZERO_(physx::PxVec4* wrp_this, physx::PxZERO wrp_r){
    *wrp_this = ::physx::PxVec4::PxVec4(wrp_r);
}

ES void void_PxVec4_PxVec4Ptr_Ctor_float_(physx::PxVec4* wrp_this, float wrp_a){
    *wrp_this = ::physx::PxVec4::PxVec4(wrp_a);
}

ES void void_PxVec4_PxVec4Ptr_Ctor_float_float_float_float_(physx::PxVec4* wrp_this, float wrp_nx, float wrp_ny, float wrp_nz, float wrp_nw){
    *wrp_this = ::physx::PxVec4::PxVec4(wrp_nx, wrp_ny, wrp_nz, wrp_nw);
}

ES void void_PxVec4_PxVec4Ptr_Ctor_PxVec3_float_(physx::PxVec4* wrp_this, physx::PxVec3* wrp_v, float wrp_nw){
    *wrp_this = ::physx::PxVec4::PxVec4(*wrp_v, wrp_nw);
}

ES void void_PxVec4_PxVec4Ptr_Ctor_PxVec4_(physx::PxVec4* wrp_this, physx::PxVec4* wrp_v){
    *wrp_this = ::physx::PxVec4::PxVec4(*wrp_v);
}

ES physx::PxVec4* PxVec4_PxVec4_operator_Ptr_Equal_PxVec4_(physx::PxVec4* wrp_lhs, physx::PxVec4* wrp_p){
    return (physx::PxVec4*) &wrp_lhs->::physx::PxVec4::operator=(*wrp_p);
}

ES float* float_PxVec4_operator_Ptr_Subscript_uint_(physx::PxVec4* wrp_lhs, unsigned int wrp_index){
    return (float*) &wrp_lhs->::physx::PxVec4::operator[](wrp_index);
}

ES float* float_const_PxVec4_operator_Ptr_Subscript_uint_(physx::PxVec4* wrp_lhs, unsigned int wrp_index){
    return (float*) &wrp_lhs->::physx::PxVec4::operator[](wrp_index);
}

ES bool bool_const_PxVec4_operator_Ptr_EqualEqual_PxVec4_(physx::PxVec4* wrp_lhs, physx::PxVec4* wrp_v){
    return (bool) wrp_lhs->::physx::PxVec4::operator==(*wrp_v);
}

ES bool bool_const_PxVec4_operator_Ptr_ExclaimEqual_PxVec4_(physx::PxVec4* wrp_lhs, physx::PxVec4* wrp_v){
    return (bool) wrp_lhs->::physx::PxVec4::operator!=(*wrp_v);
}

ES bool bool_const_PxVec4_isZeroPtr(physx::PxVec4* wrp_this){
    return (bool) wrp_this->isZero();
}

ES bool bool_const_PxVec4_isFinitePtr(physx::PxVec4* wrp_this){
    return (bool) wrp_this->isFinite();
}

ES bool bool_const_PxVec4_isNormalizedPtr(physx::PxVec4* wrp_this){
    return (bool) wrp_this->isNormalized();
}

ES float float_const_PxVec4_magnitudeSquaredPtr(physx::PxVec4* wrp_this){
    return (float) wrp_this->magnitudeSquared();
}

ES float float_const_PxVec4_magnitudePtr(physx::PxVec4* wrp_this){
    return (float) wrp_this->magnitude();
}

ES void PxVec4_const_PxVec4_operator_Ptr_Minus(physx::PxVec4* nRetRef, physx::PxVec4* wrp_lhs){
    *nRetRef = wrp_lhs->::physx::PxVec4::operator-();
}

ES void PxVec4_const_PxVec4_operator_Ptr_Plus_PxVec4_(physx::PxVec4* nRetRef, physx::PxVec4* wrp_lhs, physx::PxVec4* wrp_v){
    *nRetRef = wrp_lhs->::physx::PxVec4::operator+(*wrp_v);
}

ES void PxVec4_const_PxVec4_operator_Ptr_Minus_PxVec4_(physx::PxVec4* nRetRef, physx::PxVec4* wrp_lhs, physx::PxVec4* wrp_v){
    *nRetRef = wrp_lhs->::physx::PxVec4::operator-(*wrp_v);
}

ES void PxVec4_const_PxVec4_operator_Ptr_Star_float_(physx::PxVec4* nRetRef, physx::PxVec4* wrp_lhs, float wrp_f){
    *nRetRef = wrp_lhs->::physx::PxVec4::operator*(wrp_f);
}

ES void PxVec4_const_PxVec4_operator_Ptr_Slash_float_(physx::PxVec4* nRetRef, physx::PxVec4* wrp_lhs, float wrp_f){
    *nRetRef = wrp_lhs->::physx::PxVec4::operator/(wrp_f);
}

ES physx::PxVec4* PxVec4_PxVec4_operator_Ptr_PlusEqual_PxVec4_(physx::PxVec4* wrp_lhs, physx::PxVec4* wrp_v){
    return (physx::PxVec4*) &wrp_lhs->::physx::PxVec4::operator+=(*wrp_v);
}

ES physx::PxVec4* PxVec4_PxVec4_operator_Ptr_MinusEqual_PxVec4_(physx::PxVec4* wrp_lhs, physx::PxVec4* wrp_v){
    return (physx::PxVec4*) &wrp_lhs->::physx::PxVec4::operator-=(*wrp_v);
}

ES physx::PxVec4* PxVec4_PxVec4_operator_Ptr_StarEqual_float_(physx::PxVec4* wrp_lhs, float wrp_f){
    return (physx::PxVec4*) &wrp_lhs->::physx::PxVec4::operator*=(wrp_f);
}

ES physx::PxVec4* PxVec4_PxVec4_operator_Ptr_SlashEqual_float_(physx::PxVec4* wrp_lhs, float wrp_f){
    return (physx::PxVec4*) &wrp_lhs->::physx::PxVec4::operator/=(wrp_f);
}

ES float float_const_PxVec4_dotPtr_PxVec4_(physx::PxVec4* wrp_this, physx::PxVec4* wrp_v){
    return (float) wrp_this->dot(*wrp_v);
}

ES void PxVec4_const_PxVec4_getNormalizedPtr(physx::PxVec4* nRetRef, physx::PxVec4* wrp_this){
    *nRetRef = wrp_this->getNormalized();
}

ES float float_PxVec4_normalizePtr(physx::PxVec4* wrp_this){
    return (float) wrp_this->normalize();
}

ES void PxVec4_const_PxVec4_multiplyPtr_PxVec4_(physx::PxVec4* nRetRef, physx::PxVec4* wrp_this, physx::PxVec4* wrp_a){
    *nRetRef = wrp_this->multiply(*wrp_a);
}

ES void PxVec4_const_PxVec4_minimumPtr_PxVec4_(physx::PxVec4* nRetRef, physx::PxVec4* wrp_this, physx::PxVec4* wrp_v){
    *nRetRef = wrp_this->minimum(*wrp_v);
}

ES void PxVec4_const_PxVec4_maximumPtr_PxVec4_(physx::PxVec4* nRetRef, physx::PxVec4* wrp_this, physx::PxVec4* wrp_v){
    *nRetRef = wrp_this->maximum(*wrp_v);
}

ES void PxVec3_const_PxVec4_getXYZPtr(physx::PxVec3* nRetRef, physx::PxVec4* wrp_this){
    *nRetRef = wrp_this->getXYZ();
}

ES void void_PxVec4_setZeroPtr(physx::PxVec4* wrp_this){
    wrp_this->setZero();
}

