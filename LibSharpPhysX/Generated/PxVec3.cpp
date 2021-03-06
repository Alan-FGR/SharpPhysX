// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void PxVec3_operator_Ptr_Star_float_PxVec3_(physx::PxVec3* nRetRef, float wrp_f, physx::PxVec3* wrp_v){
    *nRetRef = ::physx::operator*(wrp_f, *wrp_v);
}

ES void void_PxVec3_PxVec3Ptr_Ctor(physx::PxVec3* wrp_this){
    *wrp_this = ::physx::PxVec3::PxVec3();
}

ES void void_PxVec3_PxVec3Ptr_Ctor_PxZERO_(physx::PxVec3* wrp_this, physx::PxZERO wrp_r){
    *wrp_this = ::physx::PxVec3::PxVec3(wrp_r);
}

ES void void_PxVec3_PxVec3Ptr_Ctor_float_(physx::PxVec3* wrp_this, float wrp_a){
    *wrp_this = ::physx::PxVec3::PxVec3(wrp_a);
}

ES void void_PxVec3_PxVec3Ptr_Ctor_float_float_float_(physx::PxVec3* wrp_this, float wrp_nx, float wrp_ny, float wrp_nz){
    *wrp_this = ::physx::PxVec3::PxVec3(wrp_nx, wrp_ny, wrp_nz);
}

ES void void_PxVec3_PxVec3Ptr_Ctor_PxVec3_(physx::PxVec3* wrp_this, physx::PxVec3* wrp_v){
    *wrp_this = ::physx::PxVec3::PxVec3(*wrp_v);
}

ES physx::PxVec3* PxVec3_PxVec3_operator_Ptr_Equal_PxVec3_(physx::PxVec3* wrp_lhs, physx::PxVec3* wrp_p){
    return (physx::PxVec3*) &wrp_lhs->::physx::PxVec3::operator=(*wrp_p);
}

ES float* float_PxVec3_operator_Ptr_Subscript_uint_(physx::PxVec3* wrp_lhs, unsigned int wrp_index){
    return (float*) &wrp_lhs->::physx::PxVec3::operator[](wrp_index);
}

ES float* float_const_PxVec3_operator_Ptr_Subscript_uint_(physx::PxVec3* wrp_lhs, unsigned int wrp_index){
    return (float*) &wrp_lhs->::physx::PxVec3::operator[](wrp_index);
}

ES bool bool_const_PxVec3_operator_Ptr_EqualEqual_PxVec3_(physx::PxVec3* wrp_lhs, physx::PxVec3* wrp_v){
    return (bool) wrp_lhs->::physx::PxVec3::operator==(*wrp_v);
}

ES bool bool_const_PxVec3_operator_Ptr_ExclaimEqual_PxVec3_(physx::PxVec3* wrp_lhs, physx::PxVec3* wrp_v){
    return (bool) wrp_lhs->::physx::PxVec3::operator!=(*wrp_v);
}

ES bool bool_const_PxVec3_isZeroPtr(physx::PxVec3* wrp_this){
    return (bool) wrp_this->isZero();
}

ES bool bool_const_PxVec3_isFinitePtr(physx::PxVec3* wrp_this){
    return (bool) wrp_this->isFinite();
}

ES bool bool_const_PxVec3_isNormalizedPtr(physx::PxVec3* wrp_this){
    return (bool) wrp_this->isNormalized();
}

ES float float_const_PxVec3_magnitudeSquaredPtr(physx::PxVec3* wrp_this){
    return (float) wrp_this->magnitudeSquared();
}

ES float float_const_PxVec3_magnitudePtr(physx::PxVec3* wrp_this){
    return (float) wrp_this->magnitude();
}

ES void PxVec3_const_PxVec3_operator_Ptr_Minus(physx::PxVec3* nRetRef, physx::PxVec3* wrp_lhs){
    *nRetRef = wrp_lhs->::physx::PxVec3::operator-();
}

ES void PxVec3_const_PxVec3_operator_Ptr_Plus_PxVec3_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_lhs, physx::PxVec3* wrp_v){
    *nRetRef = wrp_lhs->::physx::PxVec3::operator+(*wrp_v);
}

ES void PxVec3_const_PxVec3_operator_Ptr_Minus_PxVec3_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_lhs, physx::PxVec3* wrp_v){
    *nRetRef = wrp_lhs->::physx::PxVec3::operator-(*wrp_v);
}

ES void PxVec3_const_PxVec3_operator_Ptr_Star_float_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_lhs, float wrp_f){
    *nRetRef = wrp_lhs->::physx::PxVec3::operator*(wrp_f);
}

ES void PxVec3_const_PxVec3_operator_Ptr_Slash_float_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_lhs, float wrp_f){
    *nRetRef = wrp_lhs->::physx::PxVec3::operator/(wrp_f);
}

ES physx::PxVec3* PxVec3_PxVec3_operator_Ptr_PlusEqual_PxVec3_(physx::PxVec3* wrp_lhs, physx::PxVec3* wrp_v){
    return (physx::PxVec3*) &wrp_lhs->::physx::PxVec3::operator+=(*wrp_v);
}

ES physx::PxVec3* PxVec3_PxVec3_operator_Ptr_MinusEqual_PxVec3_(physx::PxVec3* wrp_lhs, physx::PxVec3* wrp_v){
    return (physx::PxVec3*) &wrp_lhs->::physx::PxVec3::operator-=(*wrp_v);
}

ES physx::PxVec3* PxVec3_PxVec3_operator_Ptr_StarEqual_float_(physx::PxVec3* wrp_lhs, float wrp_f){
    return (physx::PxVec3*) &wrp_lhs->::physx::PxVec3::operator*=(wrp_f);
}

ES physx::PxVec3* PxVec3_PxVec3_operator_Ptr_SlashEqual_float_(physx::PxVec3* wrp_lhs, float wrp_f){
    return (physx::PxVec3*) &wrp_lhs->::physx::PxVec3::operator/=(wrp_f);
}

ES float float_const_PxVec3_dotPtr_PxVec3_(physx::PxVec3* wrp_this, physx::PxVec3* wrp_v){
    return (float) wrp_this->dot(*wrp_v);
}

ES void PxVec3_const_PxVec3_crossPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_this, physx::PxVec3* wrp_v){
    *nRetRef = wrp_this->cross(*wrp_v);
}

ES void PxVec3_const_PxVec3_getNormalizedPtr(physx::PxVec3* nRetRef, physx::PxVec3* wrp_this){
    *nRetRef = wrp_this->getNormalized();
}

ES float float_PxVec3_normalizePtr(physx::PxVec3* wrp_this){
    return (float) wrp_this->normalize();
}

ES float float_PxVec3_normalizeSafePtr(physx::PxVec3* wrp_this){
    return (float) wrp_this->normalizeSafe();
}

ES float float_PxVec3_normalizeFastPtr(physx::PxVec3* wrp_this){
    return (float) wrp_this->normalizeFast();
}

ES void PxVec3_const_PxVec3_multiplyPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_this, physx::PxVec3* wrp_a){
    *nRetRef = wrp_this->multiply(*wrp_a);
}

ES void PxVec3_const_PxVec3_minimumPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_this, physx::PxVec3* wrp_v){
    *nRetRef = wrp_this->minimum(*wrp_v);
}

ES float float_const_PxVec3_minElementPtr(physx::PxVec3* wrp_this){
    return (float) wrp_this->minElement();
}

ES void PxVec3_const_PxVec3_maximumPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxVec3* wrp_this, physx::PxVec3* wrp_v){
    *nRetRef = wrp_this->maximum(*wrp_v);
}

ES float float_const_PxVec3_maxElementPtr(physx::PxVec3* wrp_this){
    return (float) wrp_this->maxElement();
}

ES void PxVec3_const_PxVec3_absPtr(physx::PxVec3* nRetRef, physx::PxVec3* wrp_this){
    *nRetRef = wrp_this->abs();
}

