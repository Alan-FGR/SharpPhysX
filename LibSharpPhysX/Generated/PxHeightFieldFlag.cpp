// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR

//DBG: FunctionNode physx::operator| L155
//physx::operator| static physx.PxHeightFieldFlagsPtr OpPipe_New(physx.PxHeightFieldFlagEnum a, physx.PxHeightFieldFlagEnum b) will also be bound as member operator
//RET nat: PxHeightFieldFlagsPtr, man: physx.PxHeightFieldFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxHeightFieldFlag::Enum, man: physx.PxHeightFieldFlagEnum, kind: Value
//PAR nat: physx::PxHeightFieldFlag::Enum, man: physx.PxHeightFieldFlagEnum, kind: Value
ES PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_operator_Ptr_Pipe_PxHeightFieldFlagEnum_PxHeightFieldFlagEnum_(physx::PxHeightFieldFlag::Enum wrp_a, physx::PxHeightFieldFlag::Enum wrp_b){
    auto ret = ::physx::operator|(wrp_a, wrp_b);
    auto heap = new char[sizeof PxHeightFieldFlags];
    std::memcpy(heap, &ret, sizeof PxHeightFieldFlags);
    return (PxHeightFieldFlagsPtr) heap;
}

//DBG: FunctionNode physx::operator& L155
//physx::operator& static physx.PxHeightFieldFlagsPtr OpAnd_New(physx.PxHeightFieldFlagEnum a, physx.PxHeightFieldFlagEnum b) will also be bound as member operator
//RET nat: PxHeightFieldFlagsPtr, man: physx.PxHeightFieldFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxHeightFieldFlag::Enum, man: physx.PxHeightFieldFlagEnum, kind: Value
//PAR nat: physx::PxHeightFieldFlag::Enum, man: physx.PxHeightFieldFlagEnum, kind: Value
ES PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_operator_Ptr_Amp_PxHeightFieldFlagEnum_PxHeightFieldFlagEnum_(physx::PxHeightFieldFlag::Enum wrp_a, physx::PxHeightFieldFlag::Enum wrp_b){
    auto ret = ::physx::operator&(wrp_a, wrp_b);
    auto heap = new char[sizeof PxHeightFieldFlags];
    std::memcpy(heap, &ret, sizeof PxHeightFieldFlags);
    return (PxHeightFieldFlagsPtr) heap;
}

//DBG: FunctionNode physx::operator~ L155
//physx::operator~ static physx.PxHeightFieldFlagsPtr OpTilde_New(physx.PxHeightFieldFlagEnum a) will also be bound as member operator
//RET nat: PxHeightFieldFlagsPtr, man: physx.PxHeightFieldFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxHeightFieldFlag::Enum, man: physx.PxHeightFieldFlagEnum, kind: Value
ES PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_operator_Ptr_Tilde_PxHeightFieldFlagEnum_(physx::PxHeightFieldFlag::Enum wrp_a){
    auto ret = ::physx::operator~(wrp_a);
    auto heap = new char[sizeof PxHeightFieldFlags];
    std::memcpy(heap, &ret, sizeof PxHeightFieldFlags);
    return (PxHeightFieldFlagsPtr) heap;
}

//DBG: ClassNode PxHeightFieldFormat physx::PxHeightFieldFormat L48-74

//DBG: ClassNode PxHeightFieldTessFlag physx::PxHeightFieldTessFlag L80-125

//DBG: ClassNode PxHeightFieldFlag physx::PxHeightFieldFlag L131-147

//DBG: DeclNode PxHeightFieldFlags physx::PxHeightFieldFlags L154
