// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR

ES void Freer_physx_PxHeightFieldDescPtr(PxHeightFieldDescPtr ptr){
    delete ptr;
}

ES PxHeightFieldDescPtr Ctor_PxHeightFieldDescPtr_(){
    auto ret = *(new std::remove_pointer<PxHeightFieldDescPtr>::type());
    auto heap = new char[sizeof PxHeightFieldDesc];
    std::memcpy(heap, &ret, sizeof PxHeightFieldDesc);
    return (PxHeightFieldDescPtr) heap;
}

ES PxU32 PxHeightFieldDescPtr_GET_nbRows(PxHeightFieldDescPtr cls) {return (PxU32)cls->nbRows;}
ES void PxHeightFieldDescPtr_SET_nbRows(PxHeightFieldDescPtr cls, PxU32 value) {cls->nbRows = value;}

ES PxU32 PxHeightFieldDescPtr_GET_nbColumns(PxHeightFieldDescPtr cls) {return (PxU32)cls->nbColumns;}
ES void PxHeightFieldDescPtr_SET_nbColumns(PxHeightFieldDescPtr cls, PxU32 value) {cls->nbColumns = value;}

ES physx::PxHeightFieldFormat::Enum PxHeightFieldDescPtr_GET_format(PxHeightFieldDescPtr cls) {return (physx::PxHeightFieldFormat::Enum)cls->format;}
ES void PxHeightFieldDescPtr_SET_format(PxHeightFieldDescPtr cls, physx::PxHeightFieldFormat::Enum value) {cls->format = value;}

ES PxStridedDataPtr PxHeightFieldDescPtr_GET_samples(PxHeightFieldDescPtr cls) {return (PxStridedDataPtr)&cls->samples;}
ES void PxHeightFieldDescPtr_SET_samples(PxHeightFieldDescPtr cls, PxStridedDataPtr value) {cls->samples = *value;}

ES PxReal PxHeightFieldDescPtr_GET_convexEdgeThreshold(PxHeightFieldDescPtr cls) {return (PxReal)cls->convexEdgeThreshold;}
ES void PxHeightFieldDescPtr_SET_convexEdgeThreshold(PxHeightFieldDescPtr cls, PxReal value) {cls->convexEdgeThreshold = value;}

ES PxHeightFieldFlagsPtr PxHeightFieldDescPtr_GET_flags(PxHeightFieldDescPtr cls) {return (PxHeightFieldFlagsPtr)&cls->flags;}
ES void PxHeightFieldDescPtr_SET_flags(PxHeightFieldDescPtr cls, PxHeightFieldFlagsPtr value) {cls->flags = *value;}

ES void void_PxHeightFieldDescPtr_setToDefaultPtr(PxHeightFieldDescPtr wrp_this){
    wrp_this->setToDefault();
}

ES bool bool_const_PxHeightFieldDescPtr_isValidPtr(PxHeightFieldDescPtr wrp_this){
    return (bool) wrp_this->isValid();
}

