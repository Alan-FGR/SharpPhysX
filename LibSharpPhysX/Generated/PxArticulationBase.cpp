// Generated by minBND 5.1.81.43 - © github.com/Alan-FGR
ES void* PxArticulationBase_GET_userData(PxArticulationBasePtr cls) {return (void*)cls->userData;}
ES void PxArticulationBase_SET_userData(PxArticulationBasePtr cls, void* value) {cls->userData = value;}

ES PxScenePtr physx_PxScenePtr_const_physx_PxArticulationBase_getScene(PxArticulationBasePtr wrp_this){
    return (PxScenePtr) wrp_this->getScene();
}

ES void void_physx_PxArticulationBase_setSolverIterationCounts_uint_uint_(PxArticulationBasePtr wrp_this, unsigned int wrp_minPositionIters, unsigned int wrp_minVelocityIters){
    wrp_this->setSolverIterationCounts(wrp_minPositionIters, wrp_minVelocityIters);
}

ES void void_const_physx_PxArticulationBase_getSolverIterationCounts_uint_uint_(PxArticulationBasePtr wrp_this, unsigned int* wrp_minPositionIters, unsigned int* wrp_minVelocityIters){
    wrp_this->getSolverIterationCounts(*wrp_minPositionIters, *wrp_minVelocityIters);
}

ES bool bool_const_physx_PxArticulationBase_isSleeping(PxArticulationBasePtr wrp_this){
    return (bool) wrp_this->isSleeping();
}

ES void void_physx_PxArticulationBase_setSleepThreshold_float_(PxArticulationBasePtr wrp_this, float wrp_threshold){
    wrp_this->setSleepThreshold(wrp_threshold);
}

ES float float_const_physx_PxArticulationBase_getSleepThreshold(PxArticulationBasePtr wrp_this){
    return (float) wrp_this->getSleepThreshold();
}

ES void void_physx_PxArticulationBase_setStabilizationThreshold_float_(PxArticulationBasePtr wrp_this, float wrp_threshold){
    wrp_this->setStabilizationThreshold(wrp_threshold);
}

ES float float_const_physx_PxArticulationBase_getStabilizationThreshold(PxArticulationBasePtr wrp_this){
    return (float) wrp_this->getStabilizationThreshold();
}

ES void void_physx_PxArticulationBase_setWakeCounter_float_(PxArticulationBasePtr wrp_this, float wrp_wakeCounterValue){
    wrp_this->setWakeCounter(wrp_wakeCounterValue);
}

ES float float_const_physx_PxArticulationBase_getWakeCounter(PxArticulationBasePtr wrp_this){
    return (float) wrp_this->getWakeCounter();
}

ES void void_physx_PxArticulationBase_wakeUp(PxArticulationBasePtr wrp_this){
    wrp_this->wakeUp();
}

ES void void_physx_PxArticulationBase_putToSleep(PxArticulationBasePtr wrp_this){
    wrp_this->putToSleep();
}

ES PxArticulationLinkPtr physx_PxArticulationLinkPtr_physx_PxArticulationBase_createLink_physx_PxArticulationLinkPtr_physx_PxTransform_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr wrp_parent, physx::PxTransform* wrp_pose){
    return (PxArticulationLinkPtr) wrp_this->createLink(wrp_parent, *wrp_pose);
}

ES unsigned int uint_const_physx_PxArticulationBase_getNbLinks(PxArticulationBasePtr wrp_this){
    return (unsigned int) wrp_this->getNbLinks();
}

ES unsigned int uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_uint_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr* wrp_userBuffer, unsigned int wrp_bufferSize, unsigned int wrp_startIndex){
    return (unsigned int) wrp_this->getLinks(wrp_userBuffer, wrp_bufferSize, wrp_startIndex);
}

ES void void_physx_PxArticulationBase_setName_string_(PxArticulationBasePtr wrp_this, char* wrp_name){
    wrp_this->setName(wrp_name);
}

ES char* string_const_physx_PxArticulationBase_getName(PxArticulationBasePtr wrp_this){
    return (char*) wrp_this->getName();
}

ES void physx_PxBounds3_const_physx_PxArticulationBase_getWorldBounds_float_(physx::PxBounds3* RetRef, PxArticulationBasePtr wrp_this, float wrp_inflation){
    *RetRef = wrp_this->getWorldBounds(wrp_inflation);
}

ES PxAggregatePtr physx_PxAggregatePtr_const_physx_PxArticulationBase_getAggregate(PxArticulationBasePtr wrp_this){
    return (PxAggregatePtr) wrp_this->getAggregate();
}

ES physx::PxArticulationBase::Enum physx_PxArticulationBasePtr_Enum_const_physx_PxArticulationBase_getType(PxArticulationBasePtr wrp_this){
    return (physx::PxArticulationBase::Enum) wrp_this->getType();
}

ES PxArticulationJointBasePtr physx_PxArticulationJointBasePtr_physx_PxArticulationBase_createArticulationJoint_physx_PxArticulationLinkPtr_physx_PxTransform_physx_PxArticulationLinkPtr_physx_PxTransform_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr wrp_parent, physx::PxTransform* wrp_parentFrame, PxArticulationLinkPtr wrp_child, physx::PxTransform* wrp_childFrame){
    return (PxArticulationJointBasePtr) wrp_this->createArticulationJoint(*wrp_parent, *wrp_parentFrame, *wrp_child, *wrp_childFrame);
}

ES void void_physx_PxArticulationBase_releaseArticulationJoint_physx_PxArticulationJointBasePtr_(PxArticulationBasePtr wrp_this, PxArticulationJointBasePtr wrp_joint){
    wrp_this->releaseArticulationJoint(wrp_joint);
}

ES void void_physx_PxArticulationBase_setSolverIterationCounts_uint_(PxArticulationBasePtr wrp_this, unsigned int wrp_minPositionIters){
    wrp_this->setSolverIterationCounts(wrp_minPositionIters);
}

ES unsigned int uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr* wrp_userBuffer, unsigned int wrp_bufferSize){
    return (unsigned int) wrp_this->getLinks(wrp_userBuffer, wrp_bufferSize);
}

ES void physx_PxBounds3_const_physx_PxArticulationBase_getWorldBounds(physx::PxBounds3* RetRef, PxArticulationBasePtr wrp_this){
    *RetRef = wrp_this->getWorldBounds();
}
