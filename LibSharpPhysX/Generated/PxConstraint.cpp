// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES PxConstraintFlagsPtr PxConstraintFlagsPtr_operator_Ptr_Pipe_PxConstraintFlag_PxConstraintFlag_(physx::PxConstraintFlag::Enum wrp_a, physx::PxConstraintFlag::Enum wrp_b){
    auto ret = ::physx::operator|(wrp_a, wrp_b);
    auto heap = new char[sizeof PxConstraintFlags];
    std::memcpy(heap, &ret, sizeof PxConstraintFlags);
    return (PxConstraintFlagsPtr) heap;
}

ES PxConstraintFlagsPtr PxConstraintFlagsPtr_operator_Ptr_Amp_PxConstraintFlag_PxConstraintFlag_(physx::PxConstraintFlag::Enum wrp_a, physx::PxConstraintFlag::Enum wrp_b){
    auto ret = ::physx::operator&(wrp_a, wrp_b);
    auto heap = new char[sizeof PxConstraintFlags];
    std::memcpy(heap, &ret, sizeof PxConstraintFlags);
    return (PxConstraintFlagsPtr) heap;
}

ES PxConstraintFlagsPtr PxConstraintFlagsPtr_operator_Ptr_Tilde_PxConstraintFlag_(physx::PxConstraintFlag::Enum wrp_a){
    auto ret = ::physx::operator~(wrp_a);
    auto heap = new char[sizeof PxConstraintFlags];
    std::memcpy(heap, &ret, sizeof PxConstraintFlags);
    return (PxConstraintFlagsPtr) heap;
}

ES PxConstraintShaderTablePtr Newer_physx_PxConstraintShaderTablePtr(){
    return new std::remove_pointer<PxConstraintShaderTablePtr>::type();
}
ES void Freer_physx_PxConstraintShaderTablePtr(PxConstraintShaderTablePtr ptr){
    delete ptr;
}

ES PxConstraintSolverPrep PxConstraintShaderTablePtr_GET_solverPrep(PxConstraintShaderTablePtr cls) {return (PxConstraintSolverPrep)cls->solverPrep;}
ES void PxConstraintShaderTablePtr_SET_solverPrep(PxConstraintShaderTablePtr cls, PxConstraintSolverPrep value) {cls->solverPrep = value;}

ES PxConstraintProject PxConstraintShaderTablePtr_GET_project(PxConstraintShaderTablePtr cls) {return (PxConstraintProject)cls->project;}
ES void PxConstraintShaderTablePtr_SET_project(PxConstraintShaderTablePtr cls, PxConstraintProject value) {cls->project = value;}

ES PxConstraintVisualize PxConstraintShaderTablePtr_GET_visualize(PxConstraintShaderTablePtr cls) {return (PxConstraintVisualize)cls->visualize;}
ES void PxConstraintShaderTablePtr_SET_visualize(PxConstraintShaderTablePtr cls, PxConstraintVisualize value) {cls->visualize = value;}

ES physx::PxConstraintFlag::Enum PxConstraintShaderTablePtr_GET_flag(PxConstraintShaderTablePtr cls) {return (physx::PxConstraintFlag::Enum)cls->flag;}
ES void PxConstraintShaderTablePtr_SET_flag(PxConstraintShaderTablePtr cls, physx::PxConstraintFlag::Enum value) {cls->flag = value;}

ES void void_PxConstraintPtr_releasePtr(PxConstraintPtr wrp_this){
    wrp_this->release();
}

ES PxScenePtr PxScenePtr_const_PxConstraintPtr_getScenePtr(PxConstraintPtr wrp_this){
    return (PxScenePtr) wrp_this->getScene();
}

ES void void_const_PxConstraintPtr_getActorsPtr_PxRigidActorPtr_PxRigidActorPtr_(PxConstraintPtr wrp_this, PxRigidActorPtr* wrp_actor0, PxRigidActorPtr* wrp_actor1){
    wrp_this->getActors(*wrp_actor0, *wrp_actor1);
}

ES void void_PxConstraintPtr_setActorsPtr_PxRigidActorPtr_PxRigidActorPtr_(PxConstraintPtr wrp_this, PxRigidActorPtr wrp_actor0, PxRigidActorPtr wrp_actor1){
    wrp_this->setActors(wrp_actor0, wrp_actor1);
}

ES void void_PxConstraintPtr_markDirtyPtr(PxConstraintPtr wrp_this){
    wrp_this->markDirty();
}

ES void void_PxConstraintPtr_setFlagsPtr_PxConstraintFlagsPtr_(PxConstraintPtr wrp_this, PxConstraintFlagsPtr wrp_flags){
    wrp_this->setFlags(*wrp_flags);
}

ES PxConstraintFlagsPtr PxConstraintFlagsPtr_const_PxConstraintPtr_getFlagsPtr(PxConstraintPtr wrp_this){
    auto ret = wrp_this->getFlags();
    auto heap = new char[sizeof PxConstraintFlags];
    std::memcpy(heap, &ret, sizeof PxConstraintFlags);
    return (PxConstraintFlagsPtr) heap;
}

ES void void_PxConstraintPtr_setFlagPtr_PxConstraintFlag_bool_(PxConstraintPtr wrp_this, physx::PxConstraintFlag::Enum wrp_flag, bool wrp_value){
    wrp_this->setFlag(wrp_flag, wrp_value);
}

ES void void_const_PxConstraintPtr_getForcePtr_PxVec3_PxVec3_(PxConstraintPtr wrp_this, physx::PxVec3* wrp_linear, physx::PxVec3* wrp_angular){
    wrp_this->getForce(*wrp_linear, *wrp_angular);
}

ES bool bool_const_PxConstraintPtr_isValidPtr(PxConstraintPtr wrp_this){
    return (bool) wrp_this->isValid();
}

ES void void_PxConstraintPtr_setBreakForcePtr_float_float_(PxConstraintPtr wrp_this, PxReal wrp_linear, PxReal wrp_angular){
    wrp_this->setBreakForce(wrp_linear, wrp_angular);
}

ES void void_const_PxConstraintPtr_getBreakForcePtr_float_float_(PxConstraintPtr wrp_this, PxReal* wrp_linear, PxReal* wrp_angular){
    wrp_this->getBreakForce(*wrp_linear, *wrp_angular);
}

ES void void_PxConstraintPtr_setMinResponseThresholdPtr_float_(PxConstraintPtr wrp_this, PxReal wrp_threshold){
    wrp_this->setMinResponseThreshold(wrp_threshold);
}

ES PxReal float_const_PxConstraintPtr_getMinResponseThresholdPtr(PxConstraintPtr wrp_this){
    return (PxReal) wrp_this->getMinResponseThreshold();
}

ES void* IntPtr_PxConstraintPtr_getExternalReferencePtr_uint_(PxConstraintPtr wrp_this, PxU32* wrp_typeID){
    return (void*) wrp_this->getExternalReference(*wrp_typeID);
}

ES void void_PxConstraintPtr_setConstraintFunctionsPtr_PxConstraintConnectorPtr_PxConstraintShaderTablePtr_(PxConstraintPtr wrp_this, PxConstraintConnectorPtr wrp_connector, PxConstraintShaderTablePtr wrp_shaders){
    wrp_this->setConstraintFunctions(*wrp_connector, *wrp_shaders);
}

ES char* string_const_PxConstraintPtr_getConcreteTypeNamePtr(PxConstraintPtr wrp_this){
    return (char*) wrp_this->getConcreteTypeName();
}

