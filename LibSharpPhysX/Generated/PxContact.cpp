// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES PxMassModificationPropsPtr Newer_physx_PxMassModificationPropsPtr(){
    return new std::remove_pointer<PxMassModificationPropsPtr>::type();
}
ES void Freer_physx_PxMassModificationPropsPtr(PxMassModificationPropsPtr ptr){
    delete ptr;
}

ES PxReal PxMassModificationPropsPtr_GET_mInvMassScale0(PxMassModificationPropsPtr cls) {return (PxReal)cls->mInvMassScale0;}
ES void PxMassModificationPropsPtr_SET_mInvMassScale0(PxMassModificationPropsPtr cls, PxReal value) {cls->mInvMassScale0 = value;}

ES PxReal PxMassModificationPropsPtr_GET_mInvInertiaScale0(PxMassModificationPropsPtr cls) {return (PxReal)cls->mInvInertiaScale0;}
ES void PxMassModificationPropsPtr_SET_mInvInertiaScale0(PxMassModificationPropsPtr cls, PxReal value) {cls->mInvInertiaScale0 = value;}

ES PxReal PxMassModificationPropsPtr_GET_mInvMassScale1(PxMassModificationPropsPtr cls) {return (PxReal)cls->mInvMassScale1;}
ES void PxMassModificationPropsPtr_SET_mInvMassScale1(PxMassModificationPropsPtr cls, PxReal value) {cls->mInvMassScale1 = value;}

ES PxReal PxMassModificationPropsPtr_GET_mInvInertiaScale1(PxMassModificationPropsPtr cls) {return (PxReal)cls->mInvInertiaScale1;}
ES void PxMassModificationPropsPtr_SET_mInvInertiaScale1(PxMassModificationPropsPtr cls, PxReal value) {cls->mInvInertiaScale1 = value;}

ES PxContactPatchPtr Newer_physx_PxContactPatchPtr(){
    return new std::remove_pointer<PxContactPatchPtr>::type();
}
ES void Freer_physx_PxContactPatchPtr(PxContactPatchPtr ptr){
    delete ptr;
}

ES PxMassModificationPropsPtr PxContactPatchPtr_GET_mMassModification(PxContactPatchPtr cls) {return (PxMassModificationPropsPtr)&cls->mMassModification;}
ES void PxContactPatchPtr_SET_mMassModification(PxContactPatchPtr cls, PxMassModificationPropsPtr value) {cls->mMassModification = *value;}

ES void PxContactPatchPtr_GET_normal(PxContactPatchPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->normal;}
ES void PxContactPatchPtr_SET_normal(PxContactPatchPtr cls, physx::PxVec3 value) {cls->normal = value;}

ES PxReal PxContactPatchPtr_GET_restitution(PxContactPatchPtr cls) {return (PxReal)cls->restitution;}
ES void PxContactPatchPtr_SET_restitution(PxContactPatchPtr cls, PxReal value) {cls->restitution = value;}

ES PxReal PxContactPatchPtr_GET_dynamicFriction(PxContactPatchPtr cls) {return (PxReal)cls->dynamicFriction;}
ES void PxContactPatchPtr_SET_dynamicFriction(PxContactPatchPtr cls, PxReal value) {cls->dynamicFriction = value;}

ES PxReal PxContactPatchPtr_GET_staticFriction(PxContactPatchPtr cls) {return (PxReal)cls->staticFriction;}
ES void PxContactPatchPtr_SET_staticFriction(PxContactPatchPtr cls, PxReal value) {cls->staticFriction = value;}

ES PxU8 PxContactPatchPtr_GET_startContactIndex(PxContactPatchPtr cls) {return (PxU8)cls->startContactIndex;}
ES void PxContactPatchPtr_SET_startContactIndex(PxContactPatchPtr cls, PxU8 value) {cls->startContactIndex = value;}

ES PxU8 PxContactPatchPtr_GET_nbContacts(PxContactPatchPtr cls) {return (PxU8)cls->nbContacts;}
ES void PxContactPatchPtr_SET_nbContacts(PxContactPatchPtr cls, PxU8 value) {cls->nbContacts = value;}

ES PxU8 PxContactPatchPtr_GET_materialFlags(PxContactPatchPtr cls) {return (PxU8)cls->materialFlags;}
ES void PxContactPatchPtr_SET_materialFlags(PxContactPatchPtr cls, PxU8 value) {cls->materialFlags = value;}

ES PxU8 PxContactPatchPtr_GET_internalFlags(PxContactPatchPtr cls) {return (PxU8)cls->internalFlags;}
ES void PxContactPatchPtr_SET_internalFlags(PxContactPatchPtr cls, PxU8 value) {cls->internalFlags = value;}

ES PxU16 PxContactPatchPtr_GET_materialIndex0(PxContactPatchPtr cls) {return (PxU16)cls->materialIndex0;}
ES void PxContactPatchPtr_SET_materialIndex0(PxContactPatchPtr cls, PxU16 value) {cls->materialIndex0 = value;}

ES PxU16 PxContactPatchPtr_GET_materialIndex1(PxContactPatchPtr cls) {return (PxU16)cls->materialIndex1;}
ES void PxContactPatchPtr_SET_materialIndex1(PxContactPatchPtr cls, PxU16 value) {cls->materialIndex1 = value;}

ES PxContactPtr Newer_physx_PxContactPtr(){
    return new std::remove_pointer<PxContactPtr>::type();
}
ES void Freer_physx_PxContactPtr(PxContactPtr ptr){
    delete ptr;
}

ES void PxContactPtr_GET_contact(PxContactPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->contact;}
ES void PxContactPtr_SET_contact(PxContactPtr cls, physx::PxVec3 value) {cls->contact = value;}

ES PxReal PxContactPtr_GET_separation(PxContactPtr cls) {return (PxReal)cls->separation;}
ES void PxContactPtr_SET_separation(PxContactPtr cls, PxReal value) {cls->separation = value;}

ES PxExtendedContactPtr Newer_physx_PxExtendedContactPtr(){
    return new std::remove_pointer<PxExtendedContactPtr>::type();
}
ES void Freer_physx_PxExtendedContactPtr(PxExtendedContactPtr ptr){
    delete ptr;
}

ES void PxExtendedContactPtr_GET_targetVelocity(PxExtendedContactPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->targetVelocity;}
ES void PxExtendedContactPtr_SET_targetVelocity(PxExtendedContactPtr cls, physx::PxVec3 value) {cls->targetVelocity = value;}

ES PxReal PxExtendedContactPtr_GET_maxImpulse(PxExtendedContactPtr cls) {return (PxReal)cls->maxImpulse;}
ES void PxExtendedContactPtr_SET_maxImpulse(PxExtendedContactPtr cls, PxReal value) {cls->maxImpulse = value;}

ES PxModifiableContactPtr Newer_physx_PxModifiableContactPtr(){
    return new std::remove_pointer<PxModifiableContactPtr>::type();
}
ES void Freer_physx_PxModifiableContactPtr(PxModifiableContactPtr ptr){
    delete ptr;
}

ES void PxModifiableContactPtr_GET_normal(PxModifiableContactPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->normal;}
ES void PxModifiableContactPtr_SET_normal(PxModifiableContactPtr cls, physx::PxVec3 value) {cls->normal = value;}

ES PxReal PxModifiableContactPtr_GET_restitution(PxModifiableContactPtr cls) {return (PxReal)cls->restitution;}
ES void PxModifiableContactPtr_SET_restitution(PxModifiableContactPtr cls, PxReal value) {cls->restitution = value;}

ES PxU32 PxModifiableContactPtr_GET_materialFlags(PxModifiableContactPtr cls) {return (PxU32)cls->materialFlags;}
ES void PxModifiableContactPtr_SET_materialFlags(PxModifiableContactPtr cls, PxU32 value) {cls->materialFlags = value;}

ES PxU16 PxModifiableContactPtr_GET_materialIndex0(PxModifiableContactPtr cls) {return (PxU16)cls->materialIndex0;}
ES void PxModifiableContactPtr_SET_materialIndex0(PxModifiableContactPtr cls, PxU16 value) {cls->materialIndex0 = value;}

ES PxU16 PxModifiableContactPtr_GET_materialIndex1(PxModifiableContactPtr cls) {return (PxU16)cls->materialIndex1;}
ES void PxModifiableContactPtr_SET_materialIndex1(PxModifiableContactPtr cls, PxU16 value) {cls->materialIndex1 = value;}

ES PxReal PxModifiableContactPtr_GET_staticFriction(PxModifiableContactPtr cls) {return (PxReal)cls->staticFriction;}
ES void PxModifiableContactPtr_SET_staticFriction(PxModifiableContactPtr cls, PxReal value) {cls->staticFriction = value;}

ES PxReal PxModifiableContactPtr_GET_dynamicFriction(PxModifiableContactPtr cls) {return (PxReal)cls->dynamicFriction;}
ES void PxModifiableContactPtr_SET_dynamicFriction(PxModifiableContactPtr cls, PxReal value) {cls->dynamicFriction = value;}

ES void Freer_physx_PxContactStreamIteratorPtr(PxContactStreamIteratorPtr ptr){
    delete ptr;
}

ES PxContactStreamIteratorPtr Ctor_PxContactStreamIteratorPtr_byte_byte_uint_uint_uint(PxU8* wrp_contactPatches, PxU8* wrp_contactPoints, PxU32* wrp_contactFaceIndices, PxU32 wrp_nbPatches, PxU32 wrp_nbContacts){
    auto ret = *(new std::remove_pointer<PxContactStreamIteratorPtr>::type(wrp_contactPatches, wrp_contactPoints, wrp_contactFaceIndices, wrp_nbPatches, wrp_nbContacts));
    auto heap = new char[sizeof PxContactStreamIterator];
    std::memcpy(heap, &ret, sizeof PxContactStreamIterator);
    return (PxContactStreamIteratorPtr) heap;
}

ES void PxContactStreamIteratorPtr_GET_zero(PxContactStreamIteratorPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->zero;}
ES void PxContactStreamIteratorPtr_SET_zero(PxContactStreamIteratorPtr cls, physx::PxVec3 value) {cls->zero = value;}

ES PxContactPatchPtr PxContactStreamIteratorPtr_GET_patch(PxContactStreamIteratorPtr cls) {return (PxContactPatchPtr)cls->patch;}
ES void PxContactStreamIteratorPtr_SET_patch(PxContactStreamIteratorPtr cls, PxContactPatchPtr value) {cls->patch = value;}

ES PxContactPtr PxContactStreamIteratorPtr_GET_contact(PxContactStreamIteratorPtr cls) {return (PxContactPtr)cls->contact;}
ES void PxContactStreamIteratorPtr_SET_contact(PxContactStreamIteratorPtr cls, PxContactPtr value) {cls->contact = value;}

ES PxU32* PxContactStreamIteratorPtr_GET_faceIndice(PxContactStreamIteratorPtr cls) {return (PxU32*)cls->faceIndice;}
ES void PxContactStreamIteratorPtr_SET_faceIndice(PxContactStreamIteratorPtr cls, PxU32* value) {cls->faceIndice = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_totalPatches(PxContactStreamIteratorPtr cls) {return (PxU32)cls->totalPatches;}
ES void PxContactStreamIteratorPtr_SET_totalPatches(PxContactStreamIteratorPtr cls, PxU32 value) {cls->totalPatches = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_totalContacts(PxContactStreamIteratorPtr cls) {return (PxU32)cls->totalContacts;}
ES void PxContactStreamIteratorPtr_SET_totalContacts(PxContactStreamIteratorPtr cls, PxU32 value) {cls->totalContacts = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_nextContactIndex(PxContactStreamIteratorPtr cls) {return (PxU32)cls->nextContactIndex;}
ES void PxContactStreamIteratorPtr_SET_nextContactIndex(PxContactStreamIteratorPtr cls, PxU32 value) {cls->nextContactIndex = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_nextPatchIndex(PxContactStreamIteratorPtr cls) {return (PxU32)cls->nextPatchIndex;}
ES void PxContactStreamIteratorPtr_SET_nextPatchIndex(PxContactStreamIteratorPtr cls, PxU32 value) {cls->nextPatchIndex = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_contactPatchHeaderSize(PxContactStreamIteratorPtr cls) {return (PxU32)cls->contactPatchHeaderSize;}
ES void PxContactStreamIteratorPtr_SET_contactPatchHeaderSize(PxContactStreamIteratorPtr cls, PxU32 value) {cls->contactPatchHeaderSize = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_contactPointSize(PxContactStreamIteratorPtr cls) {return (PxU32)cls->contactPointSize;}
ES void PxContactStreamIteratorPtr_SET_contactPointSize(PxContactStreamIteratorPtr cls, PxU32 value) {cls->contactPointSize = value;}

ES physx::PxContactStreamIterator::StreamFormat PxContactStreamIteratorPtr_GET_mStreamFormat(PxContactStreamIteratorPtr cls) {return (physx::PxContactStreamIterator::StreamFormat)cls->mStreamFormat;}
ES void PxContactStreamIteratorPtr_SET_mStreamFormat(PxContactStreamIteratorPtr cls, physx::PxContactStreamIterator::StreamFormat value) {cls->mStreamFormat = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_forceNoResponse(PxContactStreamIteratorPtr cls) {return (PxU32)cls->forceNoResponse;}
ES void PxContactStreamIteratorPtr_SET_forceNoResponse(PxContactStreamIteratorPtr cls, PxU32 value) {cls->forceNoResponse = value;}

ES bool PxContactStreamIteratorPtr_GET_pointStepped(PxContactStreamIteratorPtr cls) {return (bool)cls->pointStepped;}
ES void PxContactStreamIteratorPtr_SET_pointStepped(PxContactStreamIteratorPtr cls, bool value) {cls->pointStepped = value;}

ES PxU32 PxContactStreamIteratorPtr_GET_hasFaceIndices(PxContactStreamIteratorPtr cls) {return (PxU32)cls->hasFaceIndices;}
ES void PxContactStreamIteratorPtr_SET_hasFaceIndices(PxContactStreamIteratorPtr cls, PxU32 value) {cls->hasFaceIndices = value;}

ES bool bool_const_PxContactStreamIteratorPtr_hasNextPatchPtr(PxContactStreamIteratorPtr wrp_this){
    return (bool) wrp_this->hasNextPatch();
}

ES PxU32 uint_const_PxContactStreamIteratorPtr_getTotalContactCountPtr(PxContactStreamIteratorPtr wrp_this){
    return (PxU32) wrp_this->getTotalContactCount();
}

ES PxU32 uint_const_PxContactStreamIteratorPtr_getTotalPatchCountPtr(PxContactStreamIteratorPtr wrp_this){
    return (PxU32) wrp_this->getTotalPatchCount();
}

ES void void_PxContactStreamIteratorPtr_nextPatchPtr(PxContactStreamIteratorPtr wrp_this){
    wrp_this->nextPatch();
}

ES bool bool_const_PxContactStreamIteratorPtr_hasNextContactPtr(PxContactStreamIteratorPtr wrp_this){
    return (bool) wrp_this->hasNextContact();
}

ES void void_PxContactStreamIteratorPtr_nextContactPtr(PxContactStreamIteratorPtr wrp_this){
    wrp_this->nextContact();
}

ES physx::PxVec3* PxVec3_const_PxContactStreamIteratorPtr_getContactNormalPtr(PxContactStreamIteratorPtr wrp_this){
    return (physx::PxVec3*) &wrp_this->getContactNormal();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getInvMassScale0Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getInvMassScale0();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getInvMassScale1Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getInvMassScale1();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getInvInertiaScale0Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getInvInertiaScale0();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getInvInertiaScale1Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getInvInertiaScale1();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getMaxImpulsePtr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getMaxImpulse();
}

ES physx::PxVec3* PxVec3_const_PxContactStreamIteratorPtr_getTargetVelPtr(PxContactStreamIteratorPtr wrp_this){
    return (physx::PxVec3*) &wrp_this->getTargetVel();
}

ES physx::PxVec3* PxVec3_const_PxContactStreamIteratorPtr_getContactPointPtr(PxContactStreamIteratorPtr wrp_this){
    return (physx::PxVec3*) &wrp_this->getContactPoint();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getSeparationPtr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getSeparation();
}

ES PxU32 uint_const_PxContactStreamIteratorPtr_getFaceIndex0Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxU32) wrp_this->getFaceIndex0();
}

ES PxU32 uint_const_PxContactStreamIteratorPtr_getFaceIndex1Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxU32) wrp_this->getFaceIndex1();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getStaticFrictionPtr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getStaticFriction();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getDynamicFrictionPtr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getDynamicFriction();
}

ES PxReal float_const_PxContactStreamIteratorPtr_getRestitutionPtr(PxContactStreamIteratorPtr wrp_this){
    return (PxReal) wrp_this->getRestitution();
}

ES PxU32 uint_const_PxContactStreamIteratorPtr_getMaterialFlagsPtr(PxContactStreamIteratorPtr wrp_this){
    return (PxU32) wrp_this->getMaterialFlags();
}

ES PxU16 ushort_const_PxContactStreamIteratorPtr_getMaterialIndex0Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxU16) wrp_this->getMaterialIndex0();
}

ES PxU16 ushort_const_PxContactStreamIteratorPtr_getMaterialIndex1Ptr(PxContactStreamIteratorPtr wrp_this){
    return (PxU16) wrp_this->getMaterialIndex1();
}

ES bool bool_PxContactStreamIteratorPtr_advanceToIndexPtr_uintC(PxContactStreamIteratorPtr wrp_this, PxU32 wrp_initialIndex){
    return (bool) wrp_this->advanceToIndex(wrp_initialIndex);
}

