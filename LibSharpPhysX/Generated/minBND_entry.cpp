// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR

ES PxU32 uint_SharpPhysX_internal_GetPhysicsVersionPtr(){
    return (PxU32) ::SharpPhysX_internal::GetPhysicsVersion();
}

ES PxSimulationFilterShader PxSimulationFilterShader_SharpPhysX_internal_GetDefaultSimulationFilterShaderPtr(){
    return (PxSimulationFilterShader) ::SharpPhysX_internal::GetDefaultSimulationFilterShader();
}

ES PxFoundationPtr PxFoundationPtr_SharpPhysX_CreateFoundationPtr(){
    return (PxFoundationPtr) ::SharpPhysX::CreateFoundation();
}

ES PxFoundationPtr PxFoundationPtr_SharpPhysX_CreateFoundationPtr_SharpPhysXErrorFptr_(SharpPhysXErrorFptr wrp_managedErrorCallback){
    return (PxFoundationPtr) ::SharpPhysX::CreateFoundation(wrp_managedErrorCallback);
}

ES PxFoundationPtr PxFoundationPtr_SharpPhysX_CreateFoundationPtr_SharpPhysXErrorFptr_uint_(SharpPhysXErrorFptr wrp_managedErrorCallback, unsigned int wrp_version){
    return (PxFoundationPtr) ::SharpPhysX::CreateFoundation(wrp_managedErrorCallback, wrp_version);
}

ES PxPhysicsPtr PxPhysicsPtr_SharpPhysX_CreatePhysicsPtr_PxFoundationPtr_(PxFoundationPtr wrp_foundation){
    return (PxPhysicsPtr) ::SharpPhysX::CreatePhysics(wrp_foundation);
}

ES PxSceneDescPtr PxSceneDescPtr_SharpPhysX_CreateSceneDescPtr(){
    return (PxSceneDescPtr) ::SharpPhysX::CreateSceneDesc();
}

