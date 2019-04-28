// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR

ES void Default_PxTransform_(physx::PxTransform* nRetRef){
    *nRetRef = PxTransform();
}

ES void void_PxTransform_PxTransformPtr_Ctor_PxVec3_(physx::PxTransform* wrp_this, physx::PxVec3* wrp_position){
    *wrp_this = ::physx::PxTransform::PxTransform(*wrp_position);
}

ES void void_PxTransform_PxTransformPtr_Ctor_PxIDENTITY_(physx::PxTransform* wrp_this, physx::PxIDENTITY wrp_r){
    *wrp_this = ::physx::PxTransform::PxTransform(wrp_r);
}

ES void void_PxTransform_PxTransformPtr_Ctor_PxQuat_(physx::PxTransform* wrp_this, physx::PxQuat* wrp_orientation){
    *wrp_this = ::physx::PxTransform::PxTransform(*wrp_orientation);
}

ES void void_PxTransform_PxTransformPtr_Ctor_float_float_float_(physx::PxTransform* wrp_this, float wrp_x, float wrp_y, float wrp_z){
    *wrp_this = ::physx::PxTransform::PxTransform(wrp_x, wrp_y, wrp_z);
}

ES void void_PxTransform_PxTransformPtr_Ctor_float_float_float_PxQuat_(physx::PxTransform* wrp_this, float wrp_x, float wrp_y, float wrp_z, char wrp_aQ[sizeof(physx::PxQuat)]){
    *wrp_this = ::physx::PxTransform::PxTransform(wrp_x, wrp_y, wrp_z, *(physx::PxQuat*)&wrp_aQ);
}

ES void void_PxTransform_PxTransformPtr_Ctor_PxVec3_PxQuat_(physx::PxTransform* wrp_this, physx::PxVec3* wrp_p0, physx::PxQuat* wrp_q0){
    *wrp_this = ::physx::PxTransform::PxTransform(*wrp_p0, *wrp_q0);
}

ES void void_PxTransform_PxTransformPtr_Ctor_PxMat44_(physx::PxTransform* wrp_this, physx::PxMat44* wrp_m){
    *wrp_this = ::physx::PxTransform::PxTransform(*wrp_m);
}

ES bool bool_const_PxTransform_operator_Ptr_EqualEqual_PxTransform_(physx::PxTransform* wrp_lhs, physx::PxTransform* wrp_t){
    return (bool) wrp_lhs->::physx::PxTransform::operator==(*wrp_t);
}

ES void PxTransform_const_PxTransform_operator_Ptr_Star_PxTransform_(physx::PxTransform* nRetRef, physx::PxTransform* wrp_lhs, physx::PxTransform* wrp_x){
    *nRetRef = wrp_lhs->::physx::PxTransform::operator*(*wrp_x);
}

ES physx::PxTransform* PxTransform_PxTransform_operator_Ptr_StarEqual_PxTransform_(physx::PxTransform* wrp_lhs, physx::PxTransform* wrp_other){
    return (physx::PxTransform*) &wrp_lhs->::physx::PxTransform::operator*=(*wrp_other);
}

ES void PxTransform_const_PxTransform_getInversePtr(physx::PxTransform* nRetRef, physx::PxTransform* wrp_this){
    *nRetRef = wrp_this->getInverse();
}

ES void PxVec3_const_PxTransform_transformPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxTransform* wrp_this, physx::PxVec3* wrp_input){
    *nRetRef = wrp_this->transform(*wrp_input);
}

ES void PxVec3_const_PxTransform_transformInvPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxTransform* wrp_this, physx::PxVec3* wrp_input){
    *nRetRef = wrp_this->transformInv(*wrp_input);
}

ES void PxVec3_const_PxTransform_rotatePtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxTransform* wrp_this, physx::PxVec3* wrp_input){
    *nRetRef = wrp_this->rotate(*wrp_input);
}

ES void PxVec3_const_PxTransform_rotateInvPtr_PxVec3_(physx::PxVec3* nRetRef, physx::PxTransform* wrp_this, physx::PxVec3* wrp_input){
    *nRetRef = wrp_this->rotateInv(*wrp_input);
}

ES void PxTransform_const_PxTransform_transformPtr_PxTransform_(physx::PxTransform* nRetRef, physx::PxTransform* wrp_this, physx::PxTransform* wrp_src){
    *nRetRef = wrp_this->transform(*wrp_src);
}

ES bool bool_const_PxTransform_isValidPtr(physx::PxTransform* wrp_this){
    return (bool) wrp_this->isValid();
}

ES bool bool_const_PxTransform_isSanePtr(physx::PxTransform* wrp_this){
    return (bool) wrp_this->isSane();
}

ES bool bool_const_PxTransform_isFinitePtr(physx::PxTransform* wrp_this){
    return (bool) wrp_this->isFinite();
}

ES void PxTransform_const_PxTransform_transformInvPtr_PxTransform_(physx::PxTransform* nRetRef, physx::PxTransform* wrp_this, physx::PxTransform* wrp_src){
    *nRetRef = wrp_this->transformInv(*wrp_src);
}

ES void PxPlane_const_PxTransform_transformPtr_PxPlane_(physx::PxPlane* nRetRef, physx::PxTransform* wrp_this, physx::PxPlane* wrp_plane){
    *nRetRef = wrp_this->transform(*wrp_plane);
}

ES void PxPlane_const_PxTransform_inverseTransformPtr_PxPlane_(physx::PxPlane* nRetRef, physx::PxTransform* wrp_this, physx::PxPlane* wrp_plane){
    *nRetRef = wrp_this->inverseTransform(*wrp_plane);
}

ES void PxTransform_const_PxTransform_getNormalizedPtr(physx::PxTransform* nRetRef, physx::PxTransform* wrp_this){
    *nRetRef = wrp_this->getNormalized();
}

