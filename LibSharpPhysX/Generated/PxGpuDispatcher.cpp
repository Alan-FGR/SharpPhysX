// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//DEBUG: NamespaceNode physx - 37-245
//DEBUG: ClassNode physx::PxGpuDispatcher - 71-241
//DEBUG: MethodNode physx::PxGpuDispatcher::startSimulation - 80
ES void void_physx_PxGpuDispatcher_startSimulation(PxGpuDispatcherPtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    wrp_this->startSimulation();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::startGroup - 91
ES void void_physx_PxGpuDispatcher_startGroup(PxGpuDispatcherPtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    wrp_this->startGroup();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::submitTask - 100
ES void void_physx_PxGpuDispatcher_submitTask_physx_PxTaskPtr_(PxGpuDispatcherPtr wrp_this, PxTaskPtr wrp_task){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
    wrp_this->submitTask(*wrp_task);
}

//DEBUG: MethodNode physx::PxGpuDispatcher::finishGroup - 110
ES void void_physx_PxGpuDispatcher_finishGroup(PxGpuDispatcherPtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    wrp_this->finishGroup();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::addCompletionPrereq - 135
ES void void_physx_PxGpuDispatcher_addCompletionPrereq_physx_PxBaseTaskPtr_(PxGpuDispatcherPtr wrp_this, PxBaseTaskPtr wrp_task){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
    wrp_this->addCompletionPrereq(*wrp_task);
}

//DEBUG: MethodNode physx::PxGpuDispatcher::getCudaContextManager - 143
//ERRORS OCCURED IN physx::PxGpuDispatcher::getCudaContextManager
////Type PxCudaContextManagerPtr explicitly forbidden by user configuration

//DEBUG: MethodNode physx::PxGpuDispatcher::stopSimulation - 151
ES void void_physx_PxGpuDispatcher_stopSimulation(PxGpuDispatcherPtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    wrp_this->stopSimulation();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::failureDetected - 172
ES bool bool_const_physx_PxGpuDispatcher_failureDetected(PxGpuDispatcherPtr wrp_this){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    return (bool) wrp_this->failureDetected();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::forceFailureMode - 180
ES void void_physx_PxGpuDispatcher_forceFailureMode(PxGpuDispatcherPtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    wrp_this->forceFailureMode();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::launchCopyKernel - 201
ES void void_physx_PxGpuDispatcher_launchCopyKernel_physx_PxGpuCopyDescPtr_uint_CUstream_(PxGpuDispatcherPtr wrp_this, PxGpuCopyDescPtr wrp_desc, unsigned int wrp_count, CUstream wrp_stream){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    //PAR nat: PxGpuCopyDescPtr, man: physx.PxGpuCopyDescPtr, kind: PtrStruct
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: CUstream, man: CUstream, kind: Value
    wrp_this->launchCopyKernel(wrp_desc, wrp_count, wrp_stream);
}

//DEBUG: MethodNode physx::PxGpuDispatcher::getPreLaunchTask - 209
ES PxBaseTaskPtr physx_PxBaseTaskPtr_physx_PxGpuDispatcher_getPreLaunchTask(PxGpuDispatcherPtr wrp_this){
    //RET nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, ret: True, kind: PtrStruct
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    return (PxBaseTaskPtr) &wrp_this->getPreLaunchTask();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::addPreLaunchDependent - 217
ES void void_physx_PxGpuDispatcher_addPreLaunchDependent_physx_PxBaseTaskPtr_(PxGpuDispatcherPtr wrp_this, PxBaseTaskPtr wrp_dependent){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
    wrp_this->addPreLaunchDependent(*wrp_dependent);
}

//DEBUG: MethodNode physx::PxGpuDispatcher::getPostLaunchTask - 225
ES PxBaseTaskPtr physx_PxBaseTaskPtr_physx_PxGpuDispatcher_getPostLaunchTask(PxGpuDispatcherPtr wrp_this){
    //RET nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, ret: True, kind: PtrStruct
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    return (PxBaseTaskPtr) &wrp_this->getPostLaunchTask();
}

//DEBUG: MethodNode physx::PxGpuDispatcher::addPostLaunchDependent - 233
ES void void_physx_PxGpuDispatcher_addPostLaunchDependent_physx_PxBaseTaskPtr_(PxGpuDispatcherPtr wrp_this, PxBaseTaskPtr wrp_dependent){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
    //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
    wrp_this->addPostLaunchDependent(*wrp_dependent);
}

//DEBUG: MethodNode physx::PxGpuDispatcher::operator= - 71
//ERRORS OCCURED IN physx::PxGpuDispatcher::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: DeclNode CUstream - 35
// TODO DeclNode.GenWrapper()
