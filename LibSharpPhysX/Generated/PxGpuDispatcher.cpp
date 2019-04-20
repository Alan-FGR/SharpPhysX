// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR

//DBG: DeclTree PxCudaContextManager physx::PxCudaContextManager L41
//Skipping DeclTree PxCudaContextManager physx::PxCudaContextManager L41...

//DBG: DeclTree PxGpuCopyDesc physx::PxGpuCopyDesc L40
//Skipping DeclTree PxGpuCopyDesc physx::PxGpuCopyDesc L40...
//Subclasses using this: 0

//DBG: ClassNode PxGpuDispatcher physx::PxGpuDispatcher L71-241

//DBG: MethodNode physx::PxGpuDispatcher::startSimulation L80
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_startSimulationPtr(PxGpuDispatcherPtr wrp_this){
    wrp_this->startSimulation();
}

//DBG: MethodNode physx::PxGpuDispatcher::startGroup L91
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_startGroupPtr(PxGpuDispatcherPtr wrp_this){
    wrp_this->startGroup();
}

//DBG: MethodNode physx::PxGpuDispatcher::submitTask L100
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
//PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_submitTaskPtr_PxTaskPtr_(PxGpuDispatcherPtr wrp_this, PxTaskPtr wrp_task){
    wrp_this->submitTask(*wrp_task);
}

//DBG: MethodNode physx::PxGpuDispatcher::finishGroup L110
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_finishGroupPtr(PxGpuDispatcherPtr wrp_this){
    wrp_this->finishGroup();
}

//DBG: MethodNode physx::PxGpuDispatcher::addCompletionPrereq L135
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
//PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_addCompletionPrereqPtr_PxBaseTaskPtr_(PxGpuDispatcherPtr wrp_this, PxBaseTaskPtr wrp_task){
    wrp_this->addCompletionPrereq(*wrp_task);
}

//DBG: MethodNode physx::PxGpuDispatcher::getCudaContextManager L143

//DBG: MethodNode physx::PxGpuDispatcher::stopSimulation L151
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_stopSimulationPtr(PxGpuDispatcherPtr wrp_this){
    wrp_this->stopSimulation();
}

//DBG: MethodNode physx::PxGpuDispatcher::failureDetected L172
//RET nat: bool, man: bool, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES bool bool_const_PxGpuDispatcherPtr_failureDetectedPtr(PxGpuDispatcherPtr wrp_this){
    return (bool) wrp_this->failureDetected();
}

//DBG: MethodNode physx::PxGpuDispatcher::forceFailureMode L180
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_forceFailureModePtr(PxGpuDispatcherPtr wrp_this){
    wrp_this->forceFailureMode();
}

//DBG: MethodNode physx::PxGpuDispatcher::launchCopyKernel L201
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
//PAR nat: PxGpuCopyDescPtr, man: physx.PxGpuCopyDescPtr, kind: PtrStruct
//PAR nat: uint32_t, man: uint, kind: Value
//PAR nat: CUstream, man: CUstream, kind: Value
ES void void_PxGpuDispatcherPtr_launchCopyKernelPtr_PxGpuCopyDescPtr_uint_CUstream_(PxGpuDispatcherPtr wrp_this, PxGpuCopyDescPtr wrp_desc, uint32_t wrp_count, CUstream wrp_stream){
    wrp_this->launchCopyKernel(wrp_desc, wrp_count, wrp_stream);
}

//DBG: MethodNode physx::PxGpuDispatcher::getPreLaunchTask L209
//RET nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, ret: True, kind: PtrStruct
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES PxBaseTaskPtr PxBaseTaskPtr_PxGpuDispatcherPtr_getPreLaunchTaskPtr(PxGpuDispatcherPtr wrp_this){
    return (PxBaseTaskPtr) &wrp_this->getPreLaunchTask();
}

//DBG: MethodNode physx::PxGpuDispatcher::addPreLaunchDependent L217
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
//PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_addPreLaunchDependentPtr_PxBaseTaskPtr_(PxGpuDispatcherPtr wrp_this, PxBaseTaskPtr wrp_dependent){
    wrp_this->addPreLaunchDependent(*wrp_dependent);
}

//DBG: MethodNode physx::PxGpuDispatcher::getPostLaunchTask L225
//RET nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, ret: True, kind: PtrStruct
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
ES PxBaseTaskPtr PxBaseTaskPtr_PxGpuDispatcherPtr_getPostLaunchTaskPtr(PxGpuDispatcherPtr wrp_this){
    return (PxBaseTaskPtr) &wrp_this->getPostLaunchTask();
}

//DBG: MethodNode physx::PxGpuDispatcher::addPostLaunchDependent L233
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, kind: PtrStruct
//PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
ES void void_PxGpuDispatcherPtr_addPostLaunchDependentPtr_PxBaseTaskPtr_(PxGpuDispatcherPtr wrp_this, PxBaseTaskPtr wrp_dependent){
    wrp_this->addPostLaunchDependent(*wrp_dependent);
}

//DBG: MethodNode physx::PxGpuDispatcher::operator= L71
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxGpuDispatcher::operator= L71

//Operators

//DBG: DeclTree CUstream_st CUstream_st L35
//Skipping DeclTree CUstream_st CUstream_st L35...

//DBG: DeclNode CUstream CUstream L35
