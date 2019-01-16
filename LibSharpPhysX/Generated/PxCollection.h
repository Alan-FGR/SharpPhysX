ES void PxCollection__add(physx::PxCollection* cls, physx::PxBase* object, physx::PxSerialObjectId id) {
    return cls->add(*object, id);
};ES void PxCollection__remove(physx::PxCollection* cls, physx::PxBase* object) {
    return cls->remove(*object);
};ES bool PxCollection__contains(physx::PxCollection* cls, physx::PxBase* object) {
    return cls->contains(*object);
};ES void PxCollection__addId(physx::PxCollection* cls, physx::PxBase* object, physx::PxSerialObjectId id) {
    return cls->addId(*object, id);
};ES void PxCollection__removeId(physx::PxCollection* cls, physx::PxSerialObjectId id) {
    return cls->removeId(id);
};ES void PxCollection__add(physx::PxCollection* cls, physx::PxCollection* collection) {
    return cls->add(*collection);
};ES void PxCollection__remove(physx::PxCollection* cls, physx::PxCollection* collection) {
    return cls->remove(*collection);
};ES physx::PxU32 PxCollection__getNbObjects(physx::PxCollection* cls) {
    return cls->getNbObjects();
};ES physx::PxBase* __REFPxCollection__getObject(physx::PxCollection* cls, physx::PxU32 index) {
    return cls->getObject(index);
};ES physx::PxU32 PxCollection__getObjects(physx::PxCollection* cls, physx::PxBase** userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex) {
    return cls->getObjects(userBuffer, bufferSize, startIndex);
};ES physx::PxBase* PxCollection__find(physx::PxCollection* cls, physx::PxSerialObjectId id) {
    return cls->find(id);
};ES physx::PxU32 PxCollection__getNbIds(physx::PxCollection* cls) {
    return cls->getNbIds();
};ES physx::PxU32 PxCollection__getIds(physx::PxCollection* cls, physx::PxSerialObjectId* userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex) {
    return cls->getIds(userBuffer, bufferSize, startIndex);
};ES physx::PxSerialObjectId PxCollection__getId(physx::PxCollection* cls, physx::PxBase* object) {
    return cls->getId(*object);
};ES void PxCollection__release(physx::PxCollection* cls) {
    return cls->release();
};ES physx::PxCollection* __PxCreateCollection() {
    return PxCreateCollection();
};