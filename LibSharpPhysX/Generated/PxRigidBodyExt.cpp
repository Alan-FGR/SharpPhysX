// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//DEBUG: NamespaceNode physx - 44-456
//DEBUG: ClassNode physx::PxRigidBodyExt - 58-453
//DEBUG: NewerFreerNode physx::PxRigidBodyExt - 58-453
ES PxRigidBodyExtPtr Newer_physx_PxRigidBodyExtPtr(){
    return new std::remove_pointer<PxRigidBodyExtPtr>::type();
}

ES void Freer_physx_PxRigidBodyExtPtr(PxRigidBodyExtPtr ptr){
    delete ptr;
}

//DEBUG: PtrStructCtorNode physx::PxRigidBodyExt::PxRigidBodyExt - 58
//ERRORS OCCURED IN physx::PxRigidBodyExt::PxRigidBodyExt
//Implicit Function/Method

//DEBUG: PtrStructCtorNode physx::PxRigidBodyExt::PxRigidBodyExt - 58
//ERRORS OCCURED IN physx::PxRigidBodyExt::PxRigidBodyExt
//Implicit Function/Method

//DEBUG: PtrStructCtorNode physx::PxRigidBodyExt::PxRigidBodyExt - 58
//ERRORS OCCURED IN physx::PxRigidBodyExt::PxRigidBodyExt
//Implicit Function/Method

//DEBUG: MethodNode physx::PxRigidBodyExt::operator= - 58
//ERRORS OCCURED IN physx::PxRigidBodyExt::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxRigidBodyExt::operator= - 58
//ERRORS OCCURED IN physx::PxRigidBodyExt::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxRigidBodyExt::~PxRigidBodyExt - 58
//ERRORS OCCURED IN physx::PxRigidBodyExt::~PxRigidBodyExt
//Implicit Function/Method
//Destructor

//DEBUG: FunctionNode physx::PxRigidBodyExt::updateMassAndInertia - 94
ES bool bool_physx_PxRigidBodyExt_updateMassAndInertia_physx_PxRigidBodyPtr_float_uint_physx_PxVec3_bool_(PxRigidBodyPtr wrp_body, float* wrp_shapeDensities, unsigned int wrp_shapeDensityCount, physx::PxVec3* wrp_massLocalPose, bool wrp_includeNonSimShapes){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float*, man: float*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    return (bool) physx::PxRigidBodyExt::updateMassAndInertia(*wrp_body, wrp_shapeDensities, wrp_shapeDensityCount, wrp_massLocalPose, wrp_includeNonSimShapes);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::updateMassAndInertia - 94
ES bool bool_physx_PxRigidBodyExt_updateMassAndInertia_physx_PxRigidBodyPtr_float_uint_physx_PxVec3_(PxRigidBodyPtr wrp_body, float* wrp_shapeDensities, unsigned int wrp_shapeDensityCount, physx::PxVec3* wrp_massLocalPose){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float*, man: float*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    return (bool) physx::PxRigidBodyExt::updateMassAndInertia(*wrp_body, wrp_shapeDensities, wrp_shapeDensityCount, wrp_massLocalPose);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::updateMassAndInertia - 94
ES bool bool_physx_PxRigidBodyExt_updateMassAndInertia_physx_PxRigidBodyPtr_float_uint_(PxRigidBodyPtr wrp_body, float* wrp_shapeDensities, unsigned int wrp_shapeDensityCount){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float*, man: float*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    return (bool) physx::PxRigidBodyExt::updateMassAndInertia(*wrp_body, wrp_shapeDensities, wrp_shapeDensityCount);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::updateMassAndInertia - 110
ES bool bool_physx_PxRigidBodyExt_updateMassAndInertia_physx_PxRigidBodyPtr_float_physx_PxVec3_bool_(PxRigidBodyPtr wrp_body, float wrp_density, physx::PxVec3* wrp_massLocalPose, bool wrp_includeNonSimShapes){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    return (bool) physx::PxRigidBodyExt::updateMassAndInertia(*wrp_body, wrp_density, wrp_massLocalPose, wrp_includeNonSimShapes);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::updateMassAndInertia - 110
ES bool bool_physx_PxRigidBodyExt_updateMassAndInertia_physx_PxRigidBodyPtr_float_physx_PxVec3_(PxRigidBodyPtr wrp_body, float wrp_density, physx::PxVec3* wrp_massLocalPose){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    return (bool) physx::PxRigidBodyExt::updateMassAndInertia(*wrp_body, wrp_density, wrp_massLocalPose);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::updateMassAndInertia - 110
ES bool bool_physx_PxRigidBodyExt_updateMassAndInertia_physx_PxRigidBodyPtr_float_(PxRigidBodyPtr wrp_body, float wrp_density){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    return (bool) physx::PxRigidBodyExt::updateMassAndInertia(*wrp_body, wrp_density);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::setMassAndUpdateInertia - 134
ES bool bool_physx_PxRigidBodyExt_setMassAndUpdateInertia_physx_PxRigidBodyPtr_float_uint_physx_PxVec3_bool_(PxRigidBodyPtr wrp_body, float* wrp_shapeMasses, unsigned int wrp_shapeMassCount, physx::PxVec3* wrp_massLocalPose, bool wrp_includeNonSimShapes){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float*, man: float*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    return (bool) physx::PxRigidBodyExt::setMassAndUpdateInertia(*wrp_body, wrp_shapeMasses, wrp_shapeMassCount, wrp_massLocalPose, wrp_includeNonSimShapes);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::setMassAndUpdateInertia - 134
ES bool bool_physx_PxRigidBodyExt_setMassAndUpdateInertia_physx_PxRigidBodyPtr_float_uint_physx_PxVec3_(PxRigidBodyPtr wrp_body, float* wrp_shapeMasses, unsigned int wrp_shapeMassCount, physx::PxVec3* wrp_massLocalPose){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float*, man: float*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    return (bool) physx::PxRigidBodyExt::setMassAndUpdateInertia(*wrp_body, wrp_shapeMasses, wrp_shapeMassCount, wrp_massLocalPose);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::setMassAndUpdateInertia - 134
ES bool bool_physx_PxRigidBodyExt_setMassAndUpdateInertia_physx_PxRigidBodyPtr_float_uint_(PxRigidBodyPtr wrp_body, float* wrp_shapeMasses, unsigned int wrp_shapeMassCount){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float*, man: float*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    return (bool) physx::PxRigidBodyExt::setMassAndUpdateInertia(*wrp_body, wrp_shapeMasses, wrp_shapeMassCount);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::setMassAndUpdateInertia - 155
ES bool bool_physx_PxRigidBodyExt_setMassAndUpdateInertia_physx_PxRigidBodyPtr_float_physx_PxVec3_bool_(PxRigidBodyPtr wrp_body, float wrp_mass, physx::PxVec3* wrp_massLocalPose, bool wrp_includeNonSimShapes){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    return (bool) physx::PxRigidBodyExt::setMassAndUpdateInertia(*wrp_body, wrp_mass, wrp_massLocalPose, wrp_includeNonSimShapes);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::setMassAndUpdateInertia - 155
ES bool bool_physx_PxRigidBodyExt_setMassAndUpdateInertia_physx_PxRigidBodyPtr_float_physx_PxVec3_(PxRigidBodyPtr wrp_body, float wrp_mass, physx::PxVec3* wrp_massLocalPose){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    return (bool) physx::PxRigidBodyExt::setMassAndUpdateInertia(*wrp_body, wrp_mass, wrp_massLocalPose);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::setMassAndUpdateInertia - 155
ES bool bool_physx_PxRigidBodyExt_setMassAndUpdateInertia_physx_PxRigidBodyPtr_float_(PxRigidBodyPtr wrp_body, float wrp_mass){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    return (bool) physx::PxRigidBodyExt::setMassAndUpdateInertia(*wrp_body, wrp_mass);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::computeMassPropertiesFromShapes - 167
ES PxMassPropertiesPtr physx_PxMassPropertiesPtr_physx_PxRigidBodyExt_computeMassPropertiesFromShapes_physx_PxShapePtr_uint_(const PxShapePtr* wrp_shapes, unsigned int wrp_shapeCount){
    //RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
    //PAR nat: PxShapePtr*, man: physx.PxShapePtr*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    auto ret = physx::PxRigidBodyExt::computeMassPropertiesFromShapes(wrp_shapes, wrp_shapeCount);
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addForceAtPos - 196
ES void void_physx_PxRigidBodyExt_addForceAtPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_bool_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode, bool wrp_wakeup){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    physx::PxRigidBodyExt::addForceAtPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode, wrp_wakeup);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addForceAtPos - 196
ES void void_physx_PxRigidBodyExt_addForceAtPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    physx::PxRigidBodyExt::addForceAtPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addForceAtPos - 196
ES void void_physx_PxRigidBodyExt_addForceAtPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    physx::PxRigidBodyExt::addForceAtPos(*wrp_body, *wrp_force, *wrp_pos);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addForceAtLocalPos - 224
ES void void_physx_PxRigidBodyExt_addForceAtLocalPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_bool_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode, bool wrp_wakeup){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    physx::PxRigidBodyExt::addForceAtLocalPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode, wrp_wakeup);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addForceAtLocalPos - 224
ES void void_physx_PxRigidBodyExt_addForceAtLocalPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    physx::PxRigidBodyExt::addForceAtLocalPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addForceAtLocalPos - 224
ES void void_physx_PxRigidBodyExt_addForceAtLocalPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    physx::PxRigidBodyExt::addForceAtLocalPos(*wrp_body, *wrp_force, *wrp_pos);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addLocalForceAtPos - 252
ES void void_physx_PxRigidBodyExt_addLocalForceAtPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_bool_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode, bool wrp_wakeup){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    physx::PxRigidBodyExt::addLocalForceAtPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode, wrp_wakeup);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addLocalForceAtPos - 252
ES void void_physx_PxRigidBodyExt_addLocalForceAtPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    physx::PxRigidBodyExt::addLocalForceAtPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addLocalForceAtPos - 252
ES void void_physx_PxRigidBodyExt_addLocalForceAtPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    physx::PxRigidBodyExt::addLocalForceAtPos(*wrp_body, *wrp_force, *wrp_pos);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addLocalForceAtLocalPos - 280
ES void void_physx_PxRigidBodyExt_addLocalForceAtLocalPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_bool_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode, bool wrp_wakeup){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    //PAR nat: bool, man: bool, kind: Value
    physx::PxRigidBodyExt::addLocalForceAtLocalPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode, wrp_wakeup);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addLocalForceAtLocalPos - 280
ES void void_physx_PxRigidBodyExt_addLocalForceAtLocalPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxForceModeEnum_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos, physx::PxForceMode::Enum wrp_mode){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxForceMode::Enum, man: physx.PxForceModeEnum, kind: Value
    physx::PxRigidBodyExt::addLocalForceAtLocalPos(*wrp_body, *wrp_force, *wrp_pos, wrp_mode);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::addLocalForceAtLocalPos - 280
ES void void_physx_PxRigidBodyExt_addLocalForceAtLocalPos_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_force, physx::PxVec3* wrp_pos){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    physx::PxRigidBodyExt::addLocalForceAtLocalPos(*wrp_body, *wrp_force, *wrp_pos);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::getVelocityAtPos - 292
ES void physx_PxVec3_physx_PxRigidBodyExt_getVelocityAtPos_physx_PxRigidBodyPtr_physx_PxVec3_(physx::PxVec3* RetRef, PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_pos){
    //RET nat: physx::PxVec3, man: physx.PxVec3, ret: False, kind: Blittable
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    *RetRef = physx::PxRigidBodyExt::getVelocityAtPos(*wrp_body, *wrp_pos);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::getLocalVelocityAtLocalPos - 304
ES void physx_PxVec3_physx_PxRigidBodyExt_getLocalVelocityAtLocalPos_physx_PxRigidBodyPtr_physx_PxVec3_(physx::PxVec3* RetRef, PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_pos){
    //RET nat: physx::PxVec3, man: physx.PxVec3, ret: False, kind: Blittable
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    *RetRef = physx::PxRigidBodyExt::getLocalVelocityAtLocalPos(*wrp_body, *wrp_pos);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::getVelocityAtOffset - 316
ES void physx_PxVec3_physx_PxRigidBodyExt_getVelocityAtOffset_physx_PxRigidBodyPtr_physx_PxVec3_(physx::PxVec3* RetRef, PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_pos){
    //RET nat: physx::PxVec3, man: physx.PxVec3, ret: False, kind: Blittable
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    *RetRef = physx::PxRigidBodyExt::getVelocityAtOffset(*wrp_body, *wrp_pos);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepSingle - 347-354
ES bool bool_physx_PxRigidBodyExt_linearSweepSingle_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_physx_PxQueryFilterDataPtr_physx_PxQueryFilterCallbackPtr_physx_PxQueryCachePtr_float_C_C(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_closestHit, unsigned int* wrp_shapeIndex, PxQueryFilterDataPtr wrp_filterData, PxQueryFilterCallbackPtr wrp_filterCall, PxQueryCachePtr wrp_cache, float wrp_inflation){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    //PAR nat: PxQueryFilterCallbackPtr, man: physx.PxQueryFilterCallbackPtr, kind: PtrStruct
    //PAR nat: PxQueryCachePtr, man: physx.PxQueryCachePtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    return (bool) physx::PxRigidBodyExt::linearSweepSingle(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, *wrp_closestHit, *wrp_shapeIndex, *wrp_filterData, wrp_filterCall, wrp_cache, wrp_inflation);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepSingle - 347-354
ES bool bool_physx_PxRigidBodyExt_linearSweepSingle_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_physx_PxQueryFilterDataPtr_physx_PxQueryFilterCallbackPtr_physx_PxQueryCachePtr_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_closestHit, unsigned int* wrp_shapeIndex, PxQueryFilterDataPtr wrp_filterData, PxQueryFilterCallbackPtr wrp_filterCall, PxQueryCachePtr wrp_cache){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    //PAR nat: PxQueryFilterCallbackPtr, man: physx.PxQueryFilterCallbackPtr, kind: PtrStruct
    //PAR nat: PxQueryCachePtr, man: physx.PxQueryCachePtr, kind: PtrStruct
    return (bool) physx::PxRigidBodyExt::linearSweepSingle(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, *wrp_closestHit, *wrp_shapeIndex, *wrp_filterData, wrp_filterCall, wrp_cache);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepSingle - 347-354
ES bool bool_physx_PxRigidBodyExt_linearSweepSingle_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_physx_PxQueryFilterDataPtr_physx_PxQueryFilterCallbackPtr_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_closestHit, unsigned int* wrp_shapeIndex, PxQueryFilterDataPtr wrp_filterData, PxQueryFilterCallbackPtr wrp_filterCall){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    //PAR nat: PxQueryFilterCallbackPtr, man: physx.PxQueryFilterCallbackPtr, kind: PtrStruct
    return (bool) physx::PxRigidBodyExt::linearSweepSingle(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, *wrp_closestHit, *wrp_shapeIndex, *wrp_filterData, wrp_filterCall);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepSingle - 347-354
ES bool bool_physx_PxRigidBodyExt_linearSweepSingle_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_physx_PxQueryFilterDataPtr_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_closestHit, unsigned int* wrp_shapeIndex, PxQueryFilterDataPtr wrp_filterData){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    return (bool) physx::PxRigidBodyExt::linearSweepSingle(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, *wrp_closestHit, *wrp_shapeIndex, *wrp_filterData);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepSingle - 347-354
ES bool bool_physx_PxRigidBodyExt_linearSweepSingle_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_closestHit, unsigned int* wrp_shapeIndex){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    return (bool) physx::PxRigidBodyExt::linearSweepSingle(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, *wrp_closestHit, *wrp_shapeIndex);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepMultiple - 388-395
ES unsigned int uint_physx_PxRigidBodyExt_linearSweepMultiple_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_uint_physx_PxSweepHitPtr_int_bool_physx_PxQueryFilterDataPtr_physx_PxQueryFilterCallbackPtr_physx_PxQueryCachePtr_float_C_C(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_touchHitBuffer, unsigned int* wrp_touchHitShapeIndices, unsigned int wrp_touchHitBufferSize, PxSweepHitPtr wrp_block, int* wrp_blockingShapeIndex, bool* wrp_overflow, PxQueryFilterDataPtr wrp_filterData, PxQueryFilterCallbackPtr wrp_filterCall, PxQueryCachePtr wrp_cache, float wrp_inflation){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: int*, man: int*, kind: Value
    //PAR nat: bool*, man: bool*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    //PAR nat: PxQueryFilterCallbackPtr, man: physx.PxQueryFilterCallbackPtr, kind: PtrStruct
    //PAR nat: PxQueryCachePtr, man: physx.PxQueryCachePtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    return (unsigned int) physx::PxRigidBodyExt::linearSweepMultiple(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, wrp_touchHitBuffer, wrp_touchHitShapeIndices, wrp_touchHitBufferSize, *wrp_block, *wrp_blockingShapeIndex, *wrp_overflow, *wrp_filterData, wrp_filterCall, wrp_cache, wrp_inflation);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepMultiple - 388-395
ES unsigned int uint_physx_PxRigidBodyExt_linearSweepMultiple_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_uint_physx_PxSweepHitPtr_int_bool_physx_PxQueryFilterDataPtr_physx_PxQueryFilterCallbackPtr_physx_PxQueryCachePtr_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_touchHitBuffer, unsigned int* wrp_touchHitShapeIndices, unsigned int wrp_touchHitBufferSize, PxSweepHitPtr wrp_block, int* wrp_blockingShapeIndex, bool* wrp_overflow, PxQueryFilterDataPtr wrp_filterData, PxQueryFilterCallbackPtr wrp_filterCall, PxQueryCachePtr wrp_cache){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: int*, man: int*, kind: Value
    //PAR nat: bool*, man: bool*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    //PAR nat: PxQueryFilterCallbackPtr, man: physx.PxQueryFilterCallbackPtr, kind: PtrStruct
    //PAR nat: PxQueryCachePtr, man: physx.PxQueryCachePtr, kind: PtrStruct
    return (unsigned int) physx::PxRigidBodyExt::linearSweepMultiple(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, wrp_touchHitBuffer, wrp_touchHitShapeIndices, wrp_touchHitBufferSize, *wrp_block, *wrp_blockingShapeIndex, *wrp_overflow, *wrp_filterData, wrp_filterCall, wrp_cache);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepMultiple - 388-395
ES unsigned int uint_physx_PxRigidBodyExt_linearSweepMultiple_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_uint_physx_PxSweepHitPtr_int_bool_physx_PxQueryFilterDataPtr_physx_PxQueryFilterCallbackPtr_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_touchHitBuffer, unsigned int* wrp_touchHitShapeIndices, unsigned int wrp_touchHitBufferSize, PxSweepHitPtr wrp_block, int* wrp_blockingShapeIndex, bool* wrp_overflow, PxQueryFilterDataPtr wrp_filterData, PxQueryFilterCallbackPtr wrp_filterCall){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: int*, man: int*, kind: Value
    //PAR nat: bool*, man: bool*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    //PAR nat: PxQueryFilterCallbackPtr, man: physx.PxQueryFilterCallbackPtr, kind: PtrStruct
    return (unsigned int) physx::PxRigidBodyExt::linearSweepMultiple(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, wrp_touchHitBuffer, wrp_touchHitShapeIndices, wrp_touchHitBufferSize, *wrp_block, *wrp_blockingShapeIndex, *wrp_overflow, *wrp_filterData, wrp_filterCall);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepMultiple - 388-395
ES unsigned int uint_physx_PxRigidBodyExt_linearSweepMultiple_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_uint_physx_PxSweepHitPtr_int_bool_physx_PxQueryFilterDataPtr_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_touchHitBuffer, unsigned int* wrp_touchHitShapeIndices, unsigned int wrp_touchHitBufferSize, PxSweepHitPtr wrp_block, int* wrp_blockingShapeIndex, bool* wrp_overflow, PxQueryFilterDataPtr wrp_filterData){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: int*, man: int*, kind: Value
    //PAR nat: bool*, man: bool*, kind: Value
    //PAR nat: PxQueryFilterDataPtr, man: physx.PxQueryFilterDataPtr, kind: PtrStruct
    return (unsigned int) physx::PxRigidBodyExt::linearSweepMultiple(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, wrp_touchHitBuffer, wrp_touchHitShapeIndices, wrp_touchHitBufferSize, *wrp_block, *wrp_blockingShapeIndex, *wrp_overflow, *wrp_filterData);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::linearSweepMultiple - 388-395
ES unsigned int uint_physx_PxRigidBodyExt_linearSweepMultiple_physx_PxRigidBodyPtr_physx_PxScenePtr_physx_PxVec3_float_PxHitFlagsPtr_physx_PxSweepHitPtr_uint_uint_physx_PxSweepHitPtr_int_bool_C_(PxRigidBodyPtr wrp_body, PxScenePtr wrp_scene, physx::PxVec3* wrp_unitDir, float wrp_distance, PxHitFlagsPtr wrp_outputFlags, PxSweepHitPtr wrp_touchHitBuffer, unsigned int* wrp_touchHitShapeIndices, unsigned int wrp_touchHitBufferSize, PxSweepHitPtr wrp_block, int* wrp_blockingShapeIndex, bool* wrp_overflow){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: PxScenePtr, man: physx.PxScenePtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: PxHitFlagsPtr, man: PxHitFlagsPtr, kind: PtrStruct
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: PxSweepHitPtr, man: physx.PxSweepHitPtr, kind: PtrStruct
    //PAR nat: int*, man: int*, kind: Value
    //PAR nat: bool*, man: bool*, kind: Value
    return (unsigned int) physx::PxRigidBodyExt::linearSweepMultiple(*wrp_body, *wrp_scene, *wrp_unitDir, wrp_distance, *wrp_outputFlags, wrp_touchHitBuffer, wrp_touchHitShapeIndices, wrp_touchHitBufferSize, *wrp_block, *wrp_blockingShapeIndex, *wrp_overflow);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::computeVelocityDeltaFromImpulse - 413
ES void void_physx_PxRigidBodyExt_computeVelocityDeltaFromImpulse_physx_PxRigidBodyPtr_physx_PxVec3_physx_PxVec3_physx_PxVec3_physx_PxVec3_(PxRigidBodyPtr wrp_body, physx::PxVec3* wrp_impulsiveForce, physx::PxVec3* wrp_impulsiveTorque, physx::PxVec3* wrp_deltaLinearVelocity, physx::PxVec3* wrp_deltaAngularVelocity){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    physx::PxRigidBodyExt::computeVelocityDeltaFromImpulse(*wrp_body, *wrp_impulsiveForce, *wrp_impulsiveTorque, *wrp_deltaLinearVelocity, *wrp_deltaAngularVelocity);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::computeVelocityDeltaFromImpulse - 432-433
ES void void_physx_PxRigidBodyExt_computeVelocityDeltaFromImpulse_physx_PxRigidBodyPtr_physx_PxTransform_physx_PxVec3_physx_PxVec3_float_float_physx_PxVec3_physx_PxVec3_CC_(PxRigidBodyPtr wrp_body, physx::PxTransform* wrp_globalPose, physx::PxVec3* wrp_point, physx::PxVec3* wrp_impulse, float wrp_invMassScale, float wrp_invInertiaScale, physx::PxVec3* wrp_deltaLinearVelocity, physx::PxVec3* wrp_deltaAngularVelocity){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxTransform*, man: physx.PxTransform*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    physx::PxRigidBodyExt::computeVelocityDeltaFromImpulse(*wrp_body, *wrp_globalPose, *wrp_point, *wrp_impulse, wrp_invMassScale, wrp_invInertiaScale, *wrp_deltaLinearVelocity, *wrp_deltaAngularVelocity);
}

//DEBUG: FunctionNode physx::PxRigidBodyExt::computeLinearAngularImpulse - 449-450
ES void void_physx_PxRigidBodyExt_computeLinearAngularImpulse_physx_PxRigidBodyPtr_physx_PxTransform_physx_PxVec3_physx_PxVec3_float_float_physx_PxVec3_physx_PxVec3_CC_(PxRigidBodyPtr wrp_body, physx::PxTransform* wrp_globalPose, physx::PxVec3* wrp_point, physx::PxVec3* wrp_impulse, float wrp_invMassScale, float wrp_invInertiaScale, physx::PxVec3* wrp_linearImpulse, physx::PxVec3* wrp_angularImpulse){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxRigidBodyPtr, man: physx.PxRigidBodyPtr, kind: PtrStruct
    //PAR nat: physx::PxTransform*, man: physx.PxTransform*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: float, man: float, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    physx::PxRigidBodyExt::computeLinearAngularImpulse(*wrp_body, *wrp_globalPose, *wrp_point, *wrp_impulse, wrp_invMassScale, wrp_invInertiaScale, *wrp_linearImpulse, *wrp_angularImpulse);
}
