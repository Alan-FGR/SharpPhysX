// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//DEBUG: NamespaceNode physx - 40-333
//DEBUG: ClassNode physx::PxArticulationBase - 57-330
//Bases: PxBasePtr
//DEBUG: EnumNode physx::PxArticulationBase::Enum - 61-65
// TODO EnumNode.GenWrapper()

//DEBUG: GetterSetterNode physx::PxArticulationBase - 57-330
//Field: userData - 317-317
ES void* PxArticulationBase_GET_userData(PxArticulationBasePtr cls) {return (void*)cls->userData;}
ES void PxArticulationBase_SET_userData(PxArticulationBasePtr cls, void* value) {cls->userData = value;}

//DEBUG: MethodNode physx::PxArticulationBase::getScene - 74
ES PxScenePtr physx_PxScenePtr_const_physx_PxArticulationBase_getScene(PxArticulationBasePtr wrp_this){
    //RET nat: PxScenePtr, man: physx.PxScenePtr, ret: True, kind: PtrStruct
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (PxScenePtr) wrp_this->getScene();
}

//DEBUG: MethodNode physx::PxArticulationBase::setSolverIterationCounts - 92
ES void void_physx_PxArticulationBase_setSolverIterationCounts_uint_uint_(PxArticulationBasePtr wrp_this, unsigned int wrp_minPositionIters, unsigned int wrp_minVelocityIters){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    wrp_this->setSolverIterationCounts(wrp_minPositionIters, wrp_minVelocityIters);
}

//DEBUG: MethodNode physx::PxArticulationBase::setSolverIterationCounts - 92
ES void void_physx_PxArticulationBase_setSolverIterationCounts_uint_(PxArticulationBasePtr wrp_this, unsigned int wrp_minPositionIters){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: unsigned int, man: uint, kind: Value
    wrp_this->setSolverIterationCounts(wrp_minPositionIters);
}

//DEBUG: MethodNode physx::PxArticulationBase::getSolverIterationCounts - 99
ES void void_const_physx_PxArticulationBase_getSolverIterationCounts_uint_uint_(PxArticulationBasePtr wrp_this, unsigned int* wrp_minPositionIters, unsigned int* wrp_minVelocityIters){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: unsigned int*, man: uint*, kind: Value
    //PAR nat: unsigned int*, man: uint*, kind: Value
    wrp_this->getSolverIterationCounts(*wrp_minPositionIters, *wrp_minVelocityIters);
}

//DEBUG: MethodNode physx::PxArticulationBase::isSleeping - 133
ES bool bool_const_physx_PxArticulationBase_isSleeping(PxArticulationBasePtr wrp_this){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (bool) wrp_this->isSleeping();
}

//DEBUG: MethodNode physx::PxArticulationBase::setSleepThreshold - 144
ES void void_physx_PxArticulationBase_setSleepThreshold_float_(PxArticulationBasePtr wrp_this, float wrp_threshold){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    wrp_this->setSleepThreshold(wrp_threshold);
}

//DEBUG: MethodNode physx::PxArticulationBase::getSleepThreshold - 153
ES float float_const_physx_PxArticulationBase_getSleepThreshold(PxArticulationBasePtr wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (float) wrp_this->getSleepThreshold();
}

//DEBUG: MethodNode physx::PxArticulationBase::setStabilizationThreshold - 168
ES void void_physx_PxArticulationBase_setStabilizationThreshold_float_(PxArticulationBasePtr wrp_this, float wrp_threshold){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    wrp_this->setStabilizationThreshold(wrp_threshold);
}

//DEBUG: MethodNode physx::PxArticulationBase::getStabilizationThreshold - 179
ES float float_const_physx_PxArticulationBase_getStabilizationThreshold(PxArticulationBasePtr wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (float) wrp_this->getStabilizationThreshold();
}

//DEBUG: MethodNode physx::PxArticulationBase::setWakeCounter - 196
ES void void_physx_PxArticulationBase_setWakeCounter_float_(PxArticulationBasePtr wrp_this, float wrp_wakeCounterValue){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    wrp_this->setWakeCounter(wrp_wakeCounterValue);
}

//DEBUG: MethodNode physx::PxArticulationBase::getWakeCounter - 205
ES float float_const_physx_PxArticulationBase_getWakeCounter(PxArticulationBasePtr wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (float) wrp_this->getWakeCounter();
}

//DEBUG: MethodNode physx::PxArticulationBase::wakeUp - 218
ES void void_physx_PxArticulationBase_wakeUp(PxArticulationBasePtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    wrp_this->wakeUp();
}

//DEBUG: MethodNode physx::PxArticulationBase::putToSleep - 231
ES void void_physx_PxArticulationBase_putToSleep(PxArticulationBasePtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    wrp_this->putToSleep();
}

//DEBUG: MethodNode physx::PxArticulationBase::createLink - 245
ES PxArticulationLinkPtr physx_PxArticulationLinkPtr_physx_PxArticulationBase_createLink_physx_PxArticulationLinkPtr_physx_PxTransform_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr wrp_parent, physx::PxTransform* wrp_pose){
    //RET nat: PxArticulationLinkPtr, man: physx.PxArticulationLinkPtr, ret: True, kind: PtrStruct
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: PxArticulationLinkPtr, man: physx.PxArticulationLinkPtr, kind: PtrStruct
    //PAR nat: physx::PxTransform*, man: physx.PxTransform*, kind: Value
    return (PxArticulationLinkPtr) wrp_this->createLink(wrp_parent, *wrp_pose);
}

//DEBUG: MethodNode physx::PxArticulationBase::getNbLinks - 252
ES unsigned int uint_const_physx_PxArticulationBase_getNbLinks(PxArticulationBasePtr wrp_this){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (unsigned int) wrp_this->getNbLinks();
}

//DEBUG: MethodNode physx::PxArticulationBase::getLinks - 267
ES unsigned int uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_uint_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr* wrp_userBuffer, unsigned int wrp_bufferSize, unsigned int wrp_startIndex){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: PxArticulationLinkPtr*, man: physx.PxArticulationLinkPtr*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    return (unsigned int) wrp_this->getLinks(wrp_userBuffer, wrp_bufferSize, wrp_startIndex);
}

//DEBUG: MethodNode physx::PxArticulationBase::getLinks - 267
ES unsigned int uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr* wrp_userBuffer, unsigned int wrp_bufferSize){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: PxArticulationLinkPtr*, man: physx.PxArticulationLinkPtr*, kind: Value
    //PAR nat: unsigned int, man: uint, kind: Value
    return (unsigned int) wrp_this->getLinks(wrp_userBuffer, wrp_bufferSize);
}

//DEBUG: MethodNode physx::PxArticulationBase::setName - 280
ES void void_physx_PxArticulationBase_setName_string_(PxArticulationBasePtr wrp_this, char* wrp_name){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: char*, man: string, kind: Value
    wrp_this->setName(wrp_name);
}

//DEBUG: MethodNode physx::PxArticulationBase::getName - 289
ES char* string_const_physx_PxArticulationBase_getName(PxArticulationBasePtr wrp_this){
    //RET nat: char*, man: string, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (char*) wrp_this->getName();
}

//DEBUG: MethodNode physx::PxArticulationBase::getWorldBounds - 300
ES void physx_PxBounds3_const_physx_PxArticulationBase_getWorldBounds_float_(physx::PxBounds3* RetRef, PxArticulationBasePtr wrp_this, float wrp_inflation){
    //RET nat: physx::PxBounds3, man: physx.PxBounds3, ret: False, kind: Blittable
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: float, man: float, kind: Value
    *RetRef = wrp_this->getWorldBounds(wrp_inflation);
}

//DEBUG: MethodNode physx::PxArticulationBase::getWorldBounds - 300
ES void physx_PxBounds3_const_physx_PxArticulationBase_getWorldBounds(physx::PxBounds3* RetRef, PxArticulationBasePtr wrp_this){
    //RET nat: physx::PxBounds3, man: physx.PxBounds3, ret: False, kind: Blittable
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    *RetRef = wrp_this->getWorldBounds();
}

//DEBUG: MethodNode physx::PxArticulationBase::getAggregate - 309
ES PxAggregatePtr physx_PxAggregatePtr_const_physx_PxArticulationBase_getAggregate(PxArticulationBasePtr wrp_this){
    //RET nat: PxAggregatePtr, man: physx.PxAggregatePtr, ret: True, kind: PtrStruct
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (PxAggregatePtr) wrp_this->getAggregate();
}

//DEBUG: MethodNode physx::PxArticulationBase::getImpl - 311
//ERRORS OCCURED IN physx::PxArticulationBase::getImpl
////Type PxArticulationImplPtr explicitly forbidden by user configuration

//DEBUG: MethodNode physx::PxArticulationBase::getImpl - 313
//ERRORS OCCURED IN physx::PxArticulationBase::getImpl
////Type PxArticulationImplPtr explicitly forbidden by user configuration

//DEBUG: MethodNode physx::PxArticulationBase::getType - 315
ES physx::PxArticulationBase::Enum physx_PxArticulationBasePtr_Enum_const_physx_PxArticulationBase_getType(PxArticulationBasePtr wrp_this){
    //RET nat: physx::PxArticulationBase::Enum, man: physx.PxArticulationBasePtr.Enum, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    return (physx::PxArticulationBase::Enum) wrp_this->getType();
}

//DEBUG: MethodNode physx::PxArticulationBase::~PxArticulationBase - 319
//ERRORS OCCURED IN physx::PxArticulationBase::~PxArticulationBase
//Destructor

//DEBUG: MethodNode physx::PxArticulationBase::createArticulationJoint - 325-328
ES PxArticulationJointBasePtr physx_PxArticulationJointBasePtr_physx_PxArticulationBase_createArticulationJoint_physx_PxArticulationLinkPtr_physx_PxTransform_physx_PxArticulationLinkPtr_physx_PxTransform_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr wrp_parent, physx::PxTransform* wrp_parentFrame, PxArticulationLinkPtr wrp_child, physx::PxTransform* wrp_childFrame){
    //RET nat: PxArticulationJointBasePtr, man: physx.PxArticulationJointBasePtr, ret: True, kind: PtrStruct
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: PxArticulationLinkPtr, man: physx.PxArticulationLinkPtr, kind: PtrStruct
    //PAR nat: physx::PxTransform*, man: physx.PxTransform*, kind: Value
    //PAR nat: PxArticulationLinkPtr, man: physx.PxArticulationLinkPtr, kind: PtrStruct
    //PAR nat: physx::PxTransform*, man: physx.PxTransform*, kind: Value
    return (PxArticulationJointBasePtr) wrp_this->createArticulationJoint(*wrp_parent, *wrp_parentFrame, *wrp_child, *wrp_childFrame);
}

//DEBUG: MethodNode physx::PxArticulationBase::releaseArticulationJoint - 329
ES void void_physx_PxArticulationBase_releaseArticulationJoint_physx_PxArticulationJointBasePtr_(PxArticulationBasePtr wrp_this, PxArticulationJointBasePtr wrp_joint){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxArticulationBasePtr, man: physx.PxArticulationBasePtr, kind: PtrStruct
    //PAR nat: PxArticulationJointBasePtr, man: physx.PxArticulationJointBasePtr, kind: PtrStruct
    wrp_this->releaseArticulationJoint(wrp_joint);
}

//DEBUG: MethodNode physx::PxArticulationBase::operator= - 57
//ERRORS OCCURED IN physx::PxArticulationBase::operator=
//Implicit Function/Method
//Unbindable Operator: Equal
