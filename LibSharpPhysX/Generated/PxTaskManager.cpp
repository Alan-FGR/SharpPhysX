// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void void_PxTaskManagerPtr_setCpuDispatcherPtr_PxCpuDispatcherPtr_(PxTaskManagerPtr wrp_this, PxCpuDispatcherPtr wrp_ref){
    wrp_this->setCpuDispatcher(*wrp_ref);
}

ES void void_PxTaskManagerPtr_setGpuDispatcherPtr_PxGpuDispatcherPtr_(PxTaskManagerPtr wrp_this, PxGpuDispatcherPtr wrp_ref){
    wrp_this->setGpuDispatcher(*wrp_ref);
}

ES PxCpuDispatcherPtr PxCpuDispatcherPtr_const_PxTaskManagerPtr_getCpuDispatcherPtr(PxTaskManagerPtr wrp_this){
    return (PxCpuDispatcherPtr) wrp_this->getCpuDispatcher();
}

ES PxGpuDispatcherPtr PxGpuDispatcherPtr_const_PxTaskManagerPtr_getGpuDispatcherPtr(PxTaskManagerPtr wrp_this){
    return (PxGpuDispatcherPtr) wrp_this->getGpuDispatcher();
}

ES void void_PxTaskManagerPtr_resetDependenciesPtr(PxTaskManagerPtr wrp_this){
    wrp_this->resetDependencies();
}

ES void void_PxTaskManagerPtr_startSimulationPtr(PxTaskManagerPtr wrp_this){
    wrp_this->startSimulation();
}

ES void void_PxTaskManagerPtr_stopSimulationPtr(PxTaskManagerPtr wrp_this){
    wrp_this->stopSimulation();
}

ES void void_PxTaskManagerPtr_taskCompletedPtr_PxTaskPtr_(PxTaskManagerPtr wrp_this, PxTaskPtr wrp_task){
    wrp_this->taskCompleted(*wrp_task);
}

ES PxTaskID uint_PxTaskManagerPtr_getNamedTaskPtr_string_(PxTaskManagerPtr wrp_this, char* wrp_name){
    return (PxTaskID) wrp_this->getNamedTask(wrp_name);
}

ES PxTaskID uint_PxTaskManagerPtr_submitNamedTaskPtr_PxTaskPtr_string_PxTaskType_(PxTaskManagerPtr wrp_this, PxTaskPtr wrp_task, char* wrp_name, physx::PxTaskType::Enum wrp_type){
    return (PxTaskID) wrp_this->submitNamedTask(wrp_task, wrp_name, wrp_type);
}

ES PxTaskID uint_PxTaskManagerPtr_submitUnnamedTaskPtr_PxTaskPtr_PxTaskType_(PxTaskManagerPtr wrp_this, PxTaskPtr wrp_task, physx::PxTaskType::Enum wrp_type){
    return (PxTaskID) wrp_this->submitUnnamedTask(*wrp_task, wrp_type);
}

ES PxTaskPtr PxTaskPtr_PxTaskManagerPtr_getTaskFromIDPtr_uint_(PxTaskManagerPtr wrp_this, PxTaskID wrp_id){
    return (PxTaskPtr) wrp_this->getTaskFromID(wrp_id);
}

ES void void_PxTaskManagerPtr_releasePtr(PxTaskManagerPtr wrp_this){
    wrp_this->release();
}

ES PxTaskID uint_PxTaskManagerPtr_submitNamedTaskPtr_PxTaskPtr_string_(PxTaskManagerPtr wrp_this, PxTaskPtr wrp_task, char* wrp_name){
    return (PxTaskID) wrp_this->submitNamedTask(wrp_task, wrp_name);
}

ES PxTaskID uint_PxTaskManagerPtr_submitUnnamedTaskPtr_PxTaskPtr_(PxTaskManagerPtr wrp_this, PxTaskPtr wrp_task){
    return (PxTaskID) wrp_this->submitUnnamedTask(*wrp_task);
}

