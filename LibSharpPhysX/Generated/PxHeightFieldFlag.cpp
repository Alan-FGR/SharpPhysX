// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_operator_Ptr_Pipe_PxHeightFieldFlag_PxHeightFieldFlag_(physx::PxHeightFieldFlag::Enum wrp_a, physx::PxHeightFieldFlag::Enum wrp_b){
    auto ret = ::physx::operator|(wrp_a, wrp_b);
    auto heap = new char[sizeof PxHeightFieldFlags];
    std::memcpy(heap, &ret, sizeof PxHeightFieldFlags);
    return (PxHeightFieldFlagsPtr) heap;
}

ES PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_operator_Ptr_Amp_PxHeightFieldFlag_PxHeightFieldFlag_(physx::PxHeightFieldFlag::Enum wrp_a, physx::PxHeightFieldFlag::Enum wrp_b){
    auto ret = ::physx::operator&(wrp_a, wrp_b);
    auto heap = new char[sizeof PxHeightFieldFlags];
    std::memcpy(heap, &ret, sizeof PxHeightFieldFlags);
    return (PxHeightFieldFlagsPtr) heap;
}

ES PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_operator_Ptr_Tilde_PxHeightFieldFlag_(physx::PxHeightFieldFlag::Enum wrp_a){
    auto ret = ::physx::operator~(wrp_a);
    auto heap = new char[sizeof PxHeightFieldFlags];
    std::memcpy(heap, &ret, sizeof PxHeightFieldFlags);
    return (PxHeightFieldFlagsPtr) heap;
}

