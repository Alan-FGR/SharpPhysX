ES void PxBase__release(physx::PxBase* cls) {
    return cls->release();
};ES const char* PxBase__getConcreteTypeName(physx::PxBase* cls) {
    return cls->getConcreteTypeName();
};ES * PxBase__is(physx::PxBase* cls) {
    return cls->is();
};ES * PxBase__is(physx::PxBase* cls) {
    return cls->is();
};ES physx::PxType PxBase__getConcreteType(physx::PxBase* cls) {
    return cls->getConcreteType();
};ES void PxBase__setBaseFlag(physx::PxBase* cls, physx::PxBaseFlag::Enum flag, bool value) {
    return cls->setBaseFlag(flag, value);
};ES void PxBase__setBaseFlags(physx::PxBase* cls, physx::PxBaseFlags inFlags) {
    return cls->setBaseFlags(inFlags);
};ES physx::PxBaseFlags PxBase__getBaseFlags(physx::PxBase* cls) {
    return cls->getBaseFlags();
};ES bool PxBase__isReleasable(physx::PxBase* cls) {
    return cls->isReleasable();
};ES bool PxBase__isKindOf(physx::PxBase* cls, const char* superClass) {
    return cls->isKindOf(superClass);
};ES bool PxBase__typeMatch(physx::PxBase* cls) {
    return cls->typeMatch();
};