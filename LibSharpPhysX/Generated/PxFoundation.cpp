// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR

ES PxFoundationPtr PxFoundationPtr_PxGetFoundationPtr(){
    return (PxFoundationPtr) &::PxGetFoundation();
}

ES void void_PxFoundationPtr_releasePtr(PxFoundationPtr wrp_this){
    wrp_this->release();
}

ES void void_PxFoundationPtr_setErrorLevelPtr_PxErrorCodeEnum_(PxFoundationPtr wrp_this, physx::PxErrorCode::Enum wrp_mask){
    wrp_this->setErrorLevel(wrp_mask);
}

ES physx::PxErrorCode::Enum PxErrorCodeEnum_const_PxFoundationPtr_getErrorLevelPtr(PxFoundationPtr wrp_this){
    return (physx::PxErrorCode::Enum) wrp_this->getErrorLevel();
}

ES bool bool_const_PxFoundationPtr_getReportAllocationNamesPtr(PxFoundationPtr wrp_this){
    return (bool) wrp_this->getReportAllocationNames();
}

ES void void_PxFoundationPtr_setReportAllocationNamesPtr_bool_(PxFoundationPtr wrp_this, bool wrp_value){
    wrp_this->setReportAllocationNames(wrp_value);
}

ES void void_PxFoundationPtr_setErrorLevelPtr(PxFoundationPtr wrp_this){
    wrp_this->setErrorLevel();
}
