// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR

ES void void_PxBaseTaskPtr_releasePtr(PxBaseTaskPtr wrp_this){
    wrp_this->release();
}

ES void void_PxBaseTaskPtr_addReferencePtr(PxBaseTaskPtr wrp_this){
    wrp_this->addReference();
}

ES void void_PxBaseTaskPtr_removeReferencePtr(PxBaseTaskPtr wrp_this){
    wrp_this->removeReference();
}

ES int32_t int_const_PxBaseTaskPtr_getReferencePtr(PxBaseTaskPtr wrp_this){
    return (int32_t) wrp_this->getReference();
}

ES void void_PxBaseTaskPtr_runPtr(PxBaseTaskPtr wrp_this){
    wrp_this->run();
}

ES char* string_const_PxBaseTaskPtr_getNamePtr(PxBaseTaskPtr wrp_this){
    return (char*) wrp_this->getName();
}

ES PxTaskManagerPtr PxTaskManagerPtr_const_PxBaseTaskPtr_getTaskManagerPtr(PxBaseTaskPtr wrp_this){
    return (PxTaskManagerPtr) wrp_this->getTaskManager();
}

ES void void_PxBaseTaskPtr_setContextIdPtr_ulong_(PxBaseTaskPtr wrp_this, PxU64 wrp_id){
    wrp_this->setContextId(wrp_id);
}

ES PxU64 ulong_const_PxBaseTaskPtr_getContextIdPtr(PxBaseTaskPtr wrp_this){
    return (PxU64) wrp_this->getContextId();
}

ES void void_PxTaskPtr_releasePtr(PxTaskPtr wrp_this){
    wrp_this->release();
}

ES void void_PxTaskPtr_finishBeforePtr_uint_(PxTaskPtr wrp_this, PxTaskID wrp_taskID){
    wrp_this->finishBefore(wrp_taskID);
}

ES void void_PxTaskPtr_startAfterPtr_uint_(PxTaskPtr wrp_this, PxTaskID wrp_taskID){
    wrp_this->startAfter(wrp_taskID);
}

ES void void_PxTaskPtr_addReferencePtr(PxTaskPtr wrp_this){
    wrp_this->addReference();
}

ES void void_PxTaskPtr_removeReferencePtr(PxTaskPtr wrp_this){
    wrp_this->removeReference();
}

ES int32_t int_const_PxTaskPtr_getReferencePtr(PxTaskPtr wrp_this){
    return (int32_t) wrp_this->getReference();
}

ES PxTaskID uint_const_PxTaskPtr_getTaskIDPtr(PxTaskPtr wrp_this){
    return (PxTaskID) wrp_this->getTaskID();
}

ES void void_PxTaskPtr_submittedPtr(PxTaskPtr wrp_this){
    wrp_this->submitted();
}

ES void void_PxTaskPtr_requestSyncPointPtr(PxTaskPtr wrp_this){
    wrp_this->requestSyncPoint();
}

ES void void_PxLightCpuTaskPtr_setContinuationPtr_PxTaskManagerPtr_PxBaseTaskPtr_(PxLightCpuTaskPtr wrp_this, PxTaskManagerPtr wrp_tm, PxBaseTaskPtr wrp_c){
    wrp_this->setContinuation(*wrp_tm, wrp_c);
}

ES void void_PxLightCpuTaskPtr_setContinuationPtr_PxBaseTaskPtr_(PxLightCpuTaskPtr wrp_this, PxBaseTaskPtr wrp_c){
    wrp_this->setContinuation(wrp_c);
}

ES PxBaseTaskPtr PxBaseTaskPtr_const_PxLightCpuTaskPtr_getContinuationPtr(PxLightCpuTaskPtr wrp_this){
    return (PxBaseTaskPtr) wrp_this->getContinuation();
}

ES void void_PxLightCpuTaskPtr_removeReferencePtr(PxLightCpuTaskPtr wrp_this){
    wrp_this->removeReference();
}

ES int32_t int_const_PxLightCpuTaskPtr_getReferencePtr(PxLightCpuTaskPtr wrp_this){
    return (int32_t) wrp_this->getReference();
}

ES void void_PxLightCpuTaskPtr_addReferencePtr(PxLightCpuTaskPtr wrp_this){
    wrp_this->addReference();
}

ES void void_PxLightCpuTaskPtr_releasePtr(PxLightCpuTaskPtr wrp_this){
    wrp_this->release();
}

