// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES PxPairFlagsPtr PxPairFlagsPtr_operator_Ptr_Pipe_PxPairFlag_PxPairFlag_(physx::PxPairFlag::Enum wrp_a, physx::PxPairFlag::Enum wrp_b){
    auto ret = ::physx::operator|(wrp_a, wrp_b);
    auto heap = new char[sizeof PxPairFlags];
    std::memcpy(heap, &ret, sizeof PxPairFlags);
    return (PxPairFlagsPtr) heap;
}

ES PxPairFlagsPtr PxPairFlagsPtr_operator_Ptr_Amp_PxPairFlag_PxPairFlag_(physx::PxPairFlag::Enum wrp_a, physx::PxPairFlag::Enum wrp_b){
    auto ret = ::physx::operator&(wrp_a, wrp_b);
    auto heap = new char[sizeof PxPairFlags];
    std::memcpy(heap, &ret, sizeof PxPairFlags);
    return (PxPairFlagsPtr) heap;
}

ES PxPairFlagsPtr PxPairFlagsPtr_operator_Ptr_Tilde_PxPairFlag_(physx::PxPairFlag::Enum wrp_a){
    auto ret = ::physx::operator~(wrp_a);
    auto heap = new char[sizeof PxPairFlags];
    std::memcpy(heap, &ret, sizeof PxPairFlags);
    return (PxPairFlagsPtr) heap;
}

ES PxFilterFlagsPtr PxFilterFlagsPtr_operator_Ptr_Pipe_PxFilterFlag_PxFilterFlag_(physx::PxFilterFlag::Enum wrp_a, physx::PxFilterFlag::Enum wrp_b){
    auto ret = ::physx::operator|(wrp_a, wrp_b);
    auto heap = new char[sizeof PxFilterFlags];
    std::memcpy(heap, &ret, sizeof PxFilterFlags);
    return (PxFilterFlagsPtr) heap;
}

ES PxFilterFlagsPtr PxFilterFlagsPtr_operator_Ptr_Amp_PxFilterFlag_PxFilterFlag_(physx::PxFilterFlag::Enum wrp_a, physx::PxFilterFlag::Enum wrp_b){
    auto ret = ::physx::operator&(wrp_a, wrp_b);
    auto heap = new char[sizeof PxFilterFlags];
    std::memcpy(heap, &ret, sizeof PxFilterFlags);
    return (PxFilterFlagsPtr) heap;
}

ES PxFilterFlagsPtr PxFilterFlagsPtr_operator_Ptr_Tilde_PxFilterFlag_(physx::PxFilterFlag::Enum wrp_a){
    auto ret = ::physx::operator~(wrp_a);
    auto heap = new char[sizeof PxFilterFlags];
    std::memcpy(heap, &ret, sizeof PxFilterFlags);
    return (PxFilterFlagsPtr) heap;
}

ES physx::PxFilterObjectType::Enum PxFilterObjectType_PxGetFilterObjectTypePtr_uint_(PxFilterObjectAttributes wrp_attr){
    return (physx::PxFilterObjectType::Enum) ::physx::PxGetFilterObjectType(wrp_attr);
}

ES bool bool_PxFilterObjectIsKinematicPtr_uint_(PxFilterObjectAttributes wrp_attr){
    return (bool) ::physx::PxFilterObjectIsKinematic(wrp_attr);
}

ES bool bool_PxFilterObjectIsTriggerPtr_uint_(PxFilterObjectAttributes wrp_attr){
    return (bool) ::physx::PxFilterObjectIsTrigger(wrp_attr);
}

ES void Freer_physx_PxFilterDataPtr(PxFilterDataPtr ptr){
    delete ptr;
}

ES PxFilterDataPtr Ctor_PxFilterDataPtr_PxEMPTY(physx::PxEMPTY wrp__){
    auto ret = *(new std::remove_pointer<PxFilterDataPtr>::type(wrp__));
    auto heap = new char[sizeof PxFilterData];
    std::memcpy(heap, &ret, sizeof PxFilterData);
    return (PxFilterDataPtr) heap;
}

ES PxFilterDataPtr Ctor_PxFilterDataPtr_(){
    auto ret = *(new std::remove_pointer<PxFilterDataPtr>::type());
    auto heap = new char[sizeof PxFilterData];
    std::memcpy(heap, &ret, sizeof PxFilterData);
    return (PxFilterDataPtr) heap;
}

ES PxFilterDataPtr Ctor_PxFilterDataPtr_PxFilterDataPtr(PxFilterDataPtr wrp_fd){
    auto ret = *(new std::remove_pointer<PxFilterDataPtr>::type(*wrp_fd));
    auto heap = new char[sizeof PxFilterData];
    std::memcpy(heap, &ret, sizeof PxFilterData);
    return (PxFilterDataPtr) heap;
}

ES PxFilterDataPtr Ctor_PxFilterDataPtr_uint_uint_uint_uint(PxU32 wrp_w0, PxU32 wrp_w1, PxU32 wrp_w2, PxU32 wrp_w3){
    auto ret = *(new std::remove_pointer<PxFilterDataPtr>::type(wrp_w0, wrp_w1, wrp_w2, wrp_w3));
    auto heap = new char[sizeof PxFilterData];
    std::memcpy(heap, &ret, sizeof PxFilterData);
    return (PxFilterDataPtr) heap;
}

ES PxU32 PxFilterDataPtr_GET_word0(PxFilterDataPtr cls) {return (PxU32)cls->word0;}
ES void PxFilterDataPtr_SET_word0(PxFilterDataPtr cls, PxU32 value) {cls->word0 = value;}

ES PxU32 PxFilterDataPtr_GET_word1(PxFilterDataPtr cls) {return (PxU32)cls->word1;}
ES void PxFilterDataPtr_SET_word1(PxFilterDataPtr cls, PxU32 value) {cls->word1 = value;}

ES PxU32 PxFilterDataPtr_GET_word2(PxFilterDataPtr cls) {return (PxU32)cls->word2;}
ES void PxFilterDataPtr_SET_word2(PxFilterDataPtr cls, PxU32 value) {cls->word2 = value;}

ES PxU32 PxFilterDataPtr_GET_word3(PxFilterDataPtr cls) {return (PxU32)cls->word3;}
ES void PxFilterDataPtr_SET_word3(PxFilterDataPtr cls, PxU32 value) {cls->word3 = value;}

ES void void_PxFilterDataPtr_setToDefaultPtr(PxFilterDataPtr wrp_this){
    wrp_this->setToDefault();
}

ES void void_PxFilterDataPtr_operator_Ptr_Equal_PxFilterDataPtr_(PxFilterDataPtr wrp_lhs, PxFilterDataPtr wrp_fd){
    wrp_lhs->::physx::PxFilterData::operator=(*wrp_fd);
}

ES bool bool_const_PxFilterDataPtr_operator_Ptr_EqualEqual_PxFilterDataPtr_(PxFilterDataPtr wrp_lhs, PxFilterDataPtr wrp_a){
    return (bool) wrp_lhs->::physx::PxFilterData::operator==(*wrp_a);
}

ES bool bool_const_PxFilterDataPtr_operator_Ptr_ExclaimEqual_PxFilterDataPtr_(PxFilterDataPtr wrp_lhs, PxFilterDataPtr wrp_a){
    return (bool) wrp_lhs->::physx::PxFilterData::operator!=(*wrp_a);
}

ES PxFilterFlagsPtr PxFilterFlagsPtr_PxSimulationFilterCallbackPtr_pairFoundPtr_uint_uint_PxFilterDataPtr_PxActorPtr_PxShapePtr_uint_PxFilterDataPtr_PxActorPtr_PxShapePtr_PxPairFlagsPtr_(PxSimulationFilterCallbackPtr wrp_this, PxU32 wrp_pairID, PxFilterObjectAttributes wrp_attributes0, PxFilterDataPtr wrp_filterData0, PxActorPtr wrp_a0, PxShapePtr wrp_s0, PxFilterObjectAttributes wrp_attributes1, PxFilterDataPtr wrp_filterData1, PxActorPtr wrp_a1, PxShapePtr wrp_s1, PxPairFlagsPtr wrp_pairFlags){
    auto ret = wrp_this->pairFound(wrp_pairID, wrp_attributes0, *wrp_filterData0, wrp_a0, wrp_s0, wrp_attributes1, *wrp_filterData1, wrp_a1, wrp_s1, *wrp_pairFlags);
    auto heap = new char[sizeof PxFilterFlags];
    std::memcpy(heap, &ret, sizeof PxFilterFlags);
    return (PxFilterFlagsPtr) heap;
}

ES void void_PxSimulationFilterCallbackPtr_pairLostPtr_uint_uint_PxFilterDataPtr_uint_PxFilterDataPtr_bool_(PxSimulationFilterCallbackPtr wrp_this, PxU32 wrp_pairID, PxFilterObjectAttributes wrp_attributes0, PxFilterDataPtr wrp_filterData0, PxFilterObjectAttributes wrp_attributes1, PxFilterDataPtr wrp_filterData1, bool wrp_objectRemoved){
    wrp_this->pairLost(wrp_pairID, wrp_attributes0, *wrp_filterData0, wrp_attributes1, *wrp_filterData1, wrp_objectRemoved);
}

ES bool bool_PxSimulationFilterCallbackPtr_statusChangePtr_uint_PxPairFlagsPtr_PxFilterFlagsPtr_(PxSimulationFilterCallbackPtr wrp_this, PxU32* wrp_pairID, PxPairFlagsPtr wrp_pairFlags, PxFilterFlagsPtr wrp_filterFlags){
    return (bool) wrp_this->statusChange(*wrp_pairID, *wrp_pairFlags, *wrp_filterFlags);
}

