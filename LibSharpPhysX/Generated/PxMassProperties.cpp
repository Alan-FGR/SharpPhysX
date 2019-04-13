// Generated by minBND 5.1.81.43 - © github.com/Alan-FGR
ES void Freer_physx_PxMassPropertiesPtr(PxMassPropertiesPtr ptr){
    delete ptr;
}

ES PxMassPropertiesPtr Ctor_physx_PxMassPropertiesPtr_(){
    return (PxMassPropertiesPtr) new std::remove_pointer<PxMassPropertiesPtr>::type();
}

ES PxMassPropertiesPtr Ctor_physx_PxMassPropertiesPtr_float_physx_PxMat33_physx_PxVec3_(float wrp_m, physx::PxMat33* wrp_inertiaT, physx::PxVec3* wrp_com){
    return (PxMassPropertiesPtr) new std::remove_pointer<PxMassPropertiesPtr>::type(wrp_m, *wrp_inertiaT, *wrp_com);
}

ES PxMassPropertiesPtr Ctor_physx_PxMassPropertiesPtr_physx_PxGeometryPtr(PxGeometryPtr wrp_geometry){
    return (PxMassPropertiesPtr) new std::remove_pointer<PxMassPropertiesPtr>::type(*wrp_geometry);
}

ES void PxMassProperties_GET_inertiaTensor(PxMassPropertiesPtr cls, physx::PxMat33* GetRetRef) {*GetRetRef = cls->inertiaTensor;}
ES void PxMassProperties_SET_inertiaTensor(PxMassPropertiesPtr cls, physx::PxMat33 value) {cls->inertiaTensor = value;}

ES void PxMassProperties_GET_centerOfMass(PxMassPropertiesPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->centerOfMass;}
ES void PxMassProperties_SET_centerOfMass(PxMassPropertiesPtr cls, physx::PxVec3 value) {cls->centerOfMass = value;}

ES float PxMassProperties_GET_mass(PxMassPropertiesPtr cls) {return (float)cls->mass;}
ES void PxMassProperties_SET_mass(PxMassPropertiesPtr cls, float value) {cls->mass = value;}

ES PxMassPropertiesPtr physx_PxMassPropertiesPtr_const_physx_PxMassProperties_operator_Star_floatC(PxMassPropertiesPtr wrp_lhs, float wrp_scale){
    auto ret = wrp_lhs->operator*(wrp_scale);
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

ES void void_physx_PxMassProperties_translate_physx_PxVec3_(PxMassPropertiesPtr wrp_this, physx::PxVec3* wrp_t){
    wrp_this->translate(*wrp_t);
}

ES void physx_PxVec3_physx_PxMassProperties_getMassSpaceInertia_physx_PxMat33_physx_PxQuat_(physx::PxVec3* RetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_massFrame){
    *RetRef = physx::PxMassProperties::getMassSpaceInertia(*wrp_inertia, *wrp_massFrame);
}

ES void physx_PxMat33_physx_PxMassProperties_translateInertia_physx_PxMat33_float_physx_PxVec3_C_(physx::PxMat33* RetRef, physx::PxMat33* wrp_inertia, float wrp_mass, physx::PxVec3* wrp_t){
    *RetRef = physx::PxMassProperties::translateInertia(*wrp_inertia, wrp_mass, *wrp_t);
}

ES void physx_PxMat33_physx_PxMassProperties_rotateInertia_physx_PxMat33_physx_PxQuat_(physx::PxMat33* RetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_q){
    *RetRef = physx::PxMassProperties::rotateInertia(*wrp_inertia, *wrp_q);
}

ES void physx_PxMat33_physx_PxMassProperties_scaleInertia_physx_PxMat33_physx_PxQuat_physx_PxVec3_(physx::PxMat33* RetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_scaleRotation, physx::PxVec3* wrp_scale){
    *RetRef = physx::PxMassProperties::scaleInertia(*wrp_inertia, *wrp_scaleRotation, *wrp_scale);
}

ES PxMassPropertiesPtr physx_PxMassPropertiesPtr_physx_PxMassProperties_sum_physx_PxMassPropertiesPtr_physx_PxTransform_uint_C(PxMassPropertiesPtr wrp_props, physx::PxTransform* wrp_transforms, unsigned int wrp_count){
    auto ret = physx::PxMassProperties::sum(wrp_props, wrp_transforms, wrp_count);
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}
