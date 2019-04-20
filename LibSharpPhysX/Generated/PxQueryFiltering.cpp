// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR

ES PxQueryFlagsPtr PxQueryFlagsPtr_operator_Ptr_Pipe_PxQueryFlagEnum_PxQueryFlagEnum_(physx::PxQueryFlag::Enum wrp_a, physx::PxQueryFlag::Enum wrp_b){
    auto ret = ::physx::operator|(wrp_a, wrp_b);
    auto heap = new char[sizeof PxQueryFlags];
    std::memcpy(heap, &ret, sizeof PxQueryFlags);
    return (PxQueryFlagsPtr) heap;
}

ES PxQueryFlagsPtr PxQueryFlagsPtr_operator_Ptr_Amp_PxQueryFlagEnum_PxQueryFlagEnum_(physx::PxQueryFlag::Enum wrp_a, physx::PxQueryFlag::Enum wrp_b){
    auto ret = ::physx::operator&(wrp_a, wrp_b);
    auto heap = new char[sizeof PxQueryFlags];
    std::memcpy(heap, &ret, sizeof PxQueryFlags);
    return (PxQueryFlagsPtr) heap;
}

ES PxQueryFlagsPtr PxQueryFlagsPtr_operator_Ptr_Tilde_PxQueryFlagEnum_(physx::PxQueryFlag::Enum wrp_a){
    auto ret = ::physx::operator~(wrp_a);
    auto heap = new char[sizeof PxQueryFlags];
    std::memcpy(heap, &ret, sizeof PxQueryFlags);
    return (PxQueryFlagsPtr) heap;
}

ES void Freer_physx_PxQueryFilterDataPtr(PxQueryFilterDataPtr ptr){
    delete ptr;
}

ES PxQueryFilterDataPtr Ctor_PxQueryFilterDataPtr_(){
    auto ret = *(new std::remove_pointer<PxQueryFilterDataPtr>::type());
    auto heap = new char[sizeof PxQueryFilterData];
    std::memcpy(heap, &ret, sizeof PxQueryFilterData);
    return (PxQueryFilterDataPtr) heap;
}

ES PxQueryFilterDataPtr Ctor_PxQueryFilterDataPtr_PxFilterDataPtr_PxQueryFlagsPtr(PxFilterDataPtr wrp_fd, PxQueryFlagsPtr wrp_f){
    auto ret = *(new std::remove_pointer<PxQueryFilterDataPtr>::type(*wrp_fd, *wrp_f));
    auto heap = new char[sizeof PxQueryFilterData];
    std::memcpy(heap, &ret, sizeof PxQueryFilterData);
    return (PxQueryFilterDataPtr) heap;
}

ES PxQueryFilterDataPtr Ctor_PxQueryFilterDataPtr_PxQueryFlagsPtr(PxQueryFlagsPtr wrp_f){
    auto ret = *(new std::remove_pointer<PxQueryFilterDataPtr>::type(*wrp_f));
    auto heap = new char[sizeof PxQueryFilterData];
    std::memcpy(heap, &ret, sizeof PxQueryFilterData);
    return (PxQueryFilterDataPtr) heap;
}

ES PxFilterDataPtr PxQueryFilterDataPtr_GET_data(PxQueryFilterDataPtr cls) {return (PxFilterDataPtr)&cls->data;}
ES void PxQueryFilterDataPtr_SET_data(PxQueryFilterDataPtr cls, PxFilterDataPtr value) {cls->data = *value;}

ES PxQueryFlagsPtr PxQueryFilterDataPtr_GET_flags(PxQueryFilterDataPtr cls) {return (PxQueryFlagsPtr)&cls->flags;}
ES void PxQueryFilterDataPtr_SET_flags(PxQueryFilterDataPtr cls, PxQueryFlagsPtr value) {cls->flags = *value;}

ES physx::PxQueryHitType::Enum PxQueryHitTypeEnum_PxQueryFilterCallbackPtr_preFilterPtr_PxFilterDataPtr_PxShapePtr_PxRigidActorPtr_PxHitFlagsPtr_(PxQueryFilterCallbackPtr wrp_this, PxFilterDataPtr wrp_filterData, PxShapePtr wrp_shape, PxRigidActorPtr wrp_actor, PxHitFlagsPtr wrp_queryFlags){
    return (physx::PxQueryHitType::Enum) wrp_this->preFilter(*wrp_filterData, wrp_shape, wrp_actor, *wrp_queryFlags);
}

ES physx::PxQueryHitType::Enum PxQueryHitTypeEnum_PxQueryFilterCallbackPtr_postFilterPtr_PxFilterDataPtr_PxQueryHitPtr_(PxQueryFilterCallbackPtr wrp_this, PxFilterDataPtr wrp_filterData, PxQueryHitPtr wrp_hit){
    return (physx::PxQueryHitType::Enum) wrp_this->postFilter(*wrp_filterData, *wrp_hit);
}

