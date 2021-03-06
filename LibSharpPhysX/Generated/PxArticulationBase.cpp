// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void* PxArticulationBasePtr_GET_userData(PxArticulationBasePtr cls) {return (void*)cls->userData;}
ES void PxArticulationBasePtr_SET_userData(PxArticulationBasePtr cls, void* value) {cls->userData = value;}

ES PxScenePtr PxScenePtr_const_PxArticulationBasePtr_getScenePtr(PxArticulationBasePtr wrp_this){
    return (PxScenePtr) wrp_this->getScene();
}

ES void void_PxArticulationBasePtr_setSolverIterationCountsPtr_uint_uint_(PxArticulationBasePtr wrp_this, PxU32 wrp_minPositionIters, PxU32 wrp_minVelocityIters){
    wrp_this->setSolverIterationCounts(wrp_minPositionIters, wrp_minVelocityIters);
}

ES void void_const_PxArticulationBasePtr_getSolverIterationCountsPtr_uint_uint_(PxArticulationBasePtr wrp_this, PxU32* wrp_minPositionIters, PxU32* wrp_minVelocityIters){
    wrp_this->getSolverIterationCounts(*wrp_minPositionIters, *wrp_minVelocityIters);
}

ES bool bool_const_PxArticulationBasePtr_isSleepingPtr(PxArticulationBasePtr wrp_this){
    return (bool) wrp_this->isSleeping();
}

ES void void_PxArticulationBasePtr_setSleepThresholdPtr_float_(PxArticulationBasePtr wrp_this, PxReal wrp_threshold){
    wrp_this->setSleepThreshold(wrp_threshold);
}

ES PxReal float_const_PxArticulationBasePtr_getSleepThresholdPtr(PxArticulationBasePtr wrp_this){
    return (PxReal) wrp_this->getSleepThreshold();
}

ES void void_PxArticulationBasePtr_setStabilizationThresholdPtr_float_(PxArticulationBasePtr wrp_this, PxReal wrp_threshold){
    wrp_this->setStabilizationThreshold(wrp_threshold);
}

ES PxReal float_const_PxArticulationBasePtr_getStabilizationThresholdPtr(PxArticulationBasePtr wrp_this){
    return (PxReal) wrp_this->getStabilizationThreshold();
}

ES void void_PxArticulationBasePtr_setWakeCounterPtr_float_(PxArticulationBasePtr wrp_this, PxReal wrp_wakeCounterValue){
    wrp_this->setWakeCounter(wrp_wakeCounterValue);
}

ES PxReal float_const_PxArticulationBasePtr_getWakeCounterPtr(PxArticulationBasePtr wrp_this){
    return (PxReal) wrp_this->getWakeCounter();
}

ES void void_PxArticulationBasePtr_wakeUpPtr(PxArticulationBasePtr wrp_this){
    wrp_this->wakeUp();
}

ES void void_PxArticulationBasePtr_putToSleepPtr(PxArticulationBasePtr wrp_this){
    wrp_this->putToSleep();
}

ES PxArticulationLinkPtr PxArticulationLinkPtr_PxArticulationBasePtr_createLinkPtr_PxArticulationLinkPtr_PxTransform_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr wrp_parent, physx::PxTransform* wrp_pose){
    return (PxArticulationLinkPtr) wrp_this->createLink(wrp_parent, *wrp_pose);
}

ES PxU32 uint_const_PxArticulationBasePtr_getNbLinksPtr(PxArticulationBasePtr wrp_this){
    return (PxU32) wrp_this->getNbLinks();
}

ES PxU32 uint_const_PxArticulationBasePtr_getLinksPtr_PxArticulationLinkPtr_uint_uint_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr* wrp_userBuffer, PxU32 wrp_bufferSize, PxU32 wrp_startIndex){
    return (PxU32) wrp_this->getLinks(wrp_userBuffer, wrp_bufferSize, wrp_startIndex);
}

ES void void_PxArticulationBasePtr_setNamePtr_string_(PxArticulationBasePtr wrp_this, char* wrp_name){
    wrp_this->setName(wrp_name);
}

ES char* string_const_PxArticulationBasePtr_getNamePtr(PxArticulationBasePtr wrp_this){
    return (char*) wrp_this->getName();
}

ES void PxBounds3_const_PxArticulationBasePtr_getWorldBoundsPtr_float_(physx::PxBounds3* nRetRef, PxArticulationBasePtr wrp_this, float wrp_inflation){
    *nRetRef = wrp_this->getWorldBounds(wrp_inflation);
}

ES PxAggregatePtr PxAggregatePtr_const_PxArticulationBasePtr_getAggregatePtr(PxArticulationBasePtr wrp_this){
    return (PxAggregatePtr) wrp_this->getAggregate();
}

ES physx::PxArticulationBase::Enum PxArticulationBasePtr_Enum_const_PxArticulationBasePtr_getTypePtr(PxArticulationBasePtr wrp_this){
    return (physx::PxArticulationBase::Enum) wrp_this->getType();
}

ES PxArticulationJointBasePtr PxArticulationJointBasePtr_PxArticulationBasePtr_createArticulationJointPtr_PxArticulationLinkPtr_PxTransform_PxArticulationLinkPtr_PxTransform_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr wrp_parent, physx::PxTransform* wrp_parentFrame, PxArticulationLinkPtr wrp_child, physx::PxTransform* wrp_childFrame){
    return (PxArticulationJointBasePtr) wrp_this->createArticulationJoint(*wrp_parent, *wrp_parentFrame, *wrp_child, *wrp_childFrame);
}

ES void void_PxArticulationBasePtr_releaseArticulationJointPtr_PxArticulationJointBasePtr_(PxArticulationBasePtr wrp_this, PxArticulationJointBasePtr wrp_joint){
    wrp_this->releaseArticulationJoint(wrp_joint);
}

ES void void_PxArticulationBasePtr_setSolverIterationCountsPtr_uint_(PxArticulationBasePtr wrp_this, PxU32 wrp_minPositionIters){
    wrp_this->setSolverIterationCounts(wrp_minPositionIters);
}

ES PxU32 uint_const_PxArticulationBasePtr_getLinksPtr_PxArticulationLinkPtr_uint_(PxArticulationBasePtr wrp_this, PxArticulationLinkPtr* wrp_userBuffer, PxU32 wrp_bufferSize){
    return (PxU32) wrp_this->getLinks(wrp_userBuffer, wrp_bufferSize);
}

ES void PxBounds3_const_PxArticulationBasePtr_getWorldBoundsPtr(physx::PxBounds3* nRetRef, PxArticulationBasePtr wrp_this){
    *nRetRef = wrp_this->getWorldBounds();
}

