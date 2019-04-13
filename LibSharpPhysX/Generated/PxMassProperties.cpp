// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//DEBUG: NamespaceNode physx - 52-330
//DEBUG: ClassNode physx::PxMassProperties - 63-327
//DEBUG: NewerFreerNode physx::PxMassProperties - 63-327
ES void Freer_physx_PxMassPropertiesPtr(PxMassPropertiesPtr ptr){
    delete ptr;
}

//DEBUG: PtrStructCtorNode physx::PxMassProperties::PxMassProperties - 69
ES PxMassPropertiesPtr Ctor_physx_PxMassPropertiesPtr_(){
    //RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
    return (PxMassPropertiesPtr) new std::remove_pointer<PxMassPropertiesPtr>::type();
}

//DEBUG: PtrStructCtorNode physx::PxMassProperties::PxMassProperties - 74
ES PxMassPropertiesPtr Ctor_physx_PxMassPropertiesPtr_float_physx_PxMat33_physx_PxVec3_(float wrp_m, physx::PxMat33* wrp_inertiaT, physx::PxVec3* wrp_com){
    //RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    return (PxMassPropertiesPtr) new std::remove_pointer<PxMassPropertiesPtr>::type(wrp_m, *wrp_inertiaT, *wrp_com);
}

//DEBUG: PtrStructCtorNode physx::PxMassProperties::PxMassProperties - 83-157
ES PxMassPropertiesPtr Ctor_physx_PxMassPropertiesPtr_physx_PxGeometryPtr(PxGeometryPtr wrp_geometry){
    //RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
    //PAR nat: PxGeometryPtr, man: physx.PxGeometryPtr, kind: PtrStruct
    return (PxMassPropertiesPtr) new std::remove_pointer<PxMassPropertiesPtr>::type(*wrp_geometry);
}

//DEBUG: PtrStructCtorNode physx::PxMassProperties::PxMassProperties - 63
//ERRORS OCCURED IN physx::PxMassProperties::PxMassProperties
//Implicit Function/Method

//DEBUG: PtrStructCtorNode physx::PxMassProperties::PxMassProperties - 63
//ERRORS OCCURED IN physx::PxMassProperties::PxMassProperties
//Implicit Function/Method

//DEBUG: GetterSetterNode physx::PxMassProperties - 63-327
//Field: inertiaTensor - 324-324
ES void PxMassProperties_GET_inertiaTensor(PxMassPropertiesPtr cls, physx::PxMat33* GetRetRef) {*GetRetRef = cls->inertiaTensor;}
ES void PxMassProperties_SET_inertiaTensor(PxMassPropertiesPtr cls, physx::PxMat33 value) {cls->inertiaTensor = value;}

//DEBUG: GetterSetterNode physx::PxMassProperties - 63-327
//Field: centerOfMass - 325-325
ES void PxMassProperties_GET_centerOfMass(PxMassPropertiesPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->centerOfMass;}
ES void PxMassProperties_SET_centerOfMass(PxMassPropertiesPtr cls, physx::PxVec3 value) {cls->centerOfMass = value;}

//DEBUG: GetterSetterNode physx::PxMassProperties - 63-327
//Field: mass - 326-326
ES float PxMassProperties_GET_mass(PxMassPropertiesPtr cls) {return (float)cls->mass;}
ES void PxMassProperties_SET_mass(PxMassPropertiesPtr cls, float value) {cls->mass = value;}

//DEBUG: MethodNode physx::PxMassProperties::operator* - 165-170
ES PxMassPropertiesPtr physx_PxMassPropertiesPtr_const_physx_PxMassProperties_operator_Star_floatC(PxMassPropertiesPtr wrp_lhs, float wrp_scale){
    //RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
    //PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    auto ret = wrp_lhs->operator*(wrp_scale);
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

//DEBUG: MethodNode physx::PxMassProperties::translate - 177-186
ES void void_physx_PxMassProperties_translate_physx_PxVec3_(PxMassPropertiesPtr wrp_this, physx::PxVec3* wrp_t){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    wrp_this->translate(*wrp_t);
}

//DEBUG: MethodNode physx::PxMassProperties::operator= - 63
//ERRORS OCCURED IN physx::PxMassProperties::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxMassProperties::~PxMassProperties - 63
//ERRORS OCCURED IN physx::PxMassProperties::~PxMassProperties
//Implicit Function/Method
//Destructor

//DEBUG: MethodNode physx::PxMassProperties::operator= - 63
//ERRORS OCCURED IN physx::PxMassProperties::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: FunctionNode physx::PxMassProperties::getMassSpaceInertia - 195-203
ES void physx_PxVec3_physx_PxMassProperties_getMassSpaceInertia_physx_PxMat33_physx_PxQuat_(physx::PxVec3* RetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_massFrame){
    //RET nat: physx::PxVec3, man: physx.PxVec3, ret: False, kind: Blittable
    //PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
    //PAR nat: physx::PxQuat*, man: physx.PxQuat*, kind: Value
    *RetRef = physx::PxMassProperties::getMassSpaceInertia(*wrp_inertia, *wrp_massFrame);
}

//DEBUG: FunctionNode physx::PxMassProperties::translateInertia - 213-226
ES void physx_PxMat33_physx_PxMassProperties_translateInertia_physx_PxMat33_float_physx_PxVec3_C_(physx::PxMat33* RetRef, physx::PxMat33* wrp_inertia, float wrp_mass, physx::PxVec3* wrp_t){
    //RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
    //PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    *RetRef = physx::PxMassProperties::translateInertia(*wrp_inertia, wrp_mass, *wrp_t);
}

//DEBUG: FunctionNode physx::PxMassProperties::rotateInertia - 235-244
ES void physx_PxMat33_physx_PxMassProperties_rotateInertia_physx_PxMat33_physx_PxQuat_(physx::PxMat33* RetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_q){
    //RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
    //PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
    //PAR nat: physx::PxQuat*, man: physx.PxQuat*, kind: Value
    *RetRef = physx::PxMassProperties::rotateInertia(*wrp_inertia, *wrp_q);
}

//DEBUG: FunctionNode physx::PxMassProperties::scaleInertia - 254-281
ES void physx_PxMat33_physx_PxMassProperties_scaleInertia_physx_PxMat33_physx_PxQuat_physx_PxVec3_(physx::PxMat33* RetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_scaleRotation, physx::PxVec3* wrp_scale){
    //RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
    //PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
    //PAR nat: physx::PxQuat*, man: physx.PxQuat*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    *RetRef = physx::PxMassProperties::scaleInertia(*wrp_inertia, *wrp_scaleRotation, *wrp_scale);
}

//DEBUG: FunctionNode physx::PxMassProperties::sum - 291-321
ES PxMassPropertiesPtr physx_PxMassPropertiesPtr_physx_PxMassProperties_sum_physx_PxMassPropertiesPtr_physx_PxTransform_uint_C(PxMassPropertiesPtr wrp_props, physx::PxTransform* wrp_transforms, unsigned int wrp_count){
    //RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
    //PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
    //PAR nat: physx::PxTransform*, man: physx.PxTransform*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    auto ret = physx::PxMassProperties::sum(wrp_props, wrp_transforms, wrp_count);
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}
