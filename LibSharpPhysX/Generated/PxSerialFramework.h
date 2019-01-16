ES void PxSerializationContext__registerReference(physx::PxSerializationContext* cls, physx::PxBase* base, physx::PxU32 kind, size_t reference) {
    return cls->registerReference(*base, kind, reference);
};ES physx::PxCollection* __REFPxSerializationContext__getCollection(physx::PxSerializationContext* cls) {
    return cls->getCollection();
};ES void PxSerializationContext__writeData(physx::PxSerializationContext* cls, void* data, physx::PxU32 size) {
    return cls->writeData(data, size);
};ES void PxSerializationContext__alignData(physx::PxSerializationContext* cls, physx::PxU32 alignment) {
    return cls->alignData(alignment);
};ES void PxSerializationContext__writeName(physx::PxSerializationContext* cls, const char* name) {
    return cls->writeName(name);
};ES physx::PxBase* PxDeserializationContext__resolveReference(physx::PxDeserializationContext* cls, physx::PxU32 kind, size_t reference) {
    return cls->resolveReference(kind, reference);
};ES void PxDeserializationContext__translatePxBase(physx::PxDeserializationContext* cls, ** base) {
    return cls->translatePxBase(*base);
};ES void PxDeserializationContext__readName(physx::PxDeserializationContext* cls, const char** name) {
    return cls->readName(*name);
};ES * PxDeserializationContext__readExtraData(physx::PxDeserializationContext* cls, physx::PxU32 count) {
    return cls->readExtraData(count);
};ES * PxDeserializationContext__readExtraData(physx::PxDeserializationContext* cls, physx::PxU32 count) {
    return cls->readExtraData(count);
};ES void PxDeserializationContext__alignExtraData(physx::PxDeserializationContext* cls, physx::PxU32 alignment) {
    return cls->alignExtraData(alignment);
};ES physx::PxU32 PxDeserializationContext__getPhysXVersion(physx::PxDeserializationContext* cls) {
    return cls->getPhysXVersion();
};ES void PxSerializationRegistry__registerSerializer(physx::PxSerializationRegistry* cls, physx::PxType type, physx::PxSerializer* serializer) {
    return cls->registerSerializer(type, *serializer);
};ES physx::PxSerializer* PxSerializationRegistry__unregisterSerializer(physx::PxSerializationRegistry* cls, physx::PxType type) {
    return cls->unregisterSerializer(type);
};ES void PxSerializationRegistry__registerBinaryMetaDataCallback(physx::PxSerializationRegistry* cls, physx::PxBinaryMetaDataCallback callback) {
    return cls->registerBinaryMetaDataCallback(callback);
};ES physx::PxSerializer* PxSerializationRegistry__getSerializer(physx::PxSerializationRegistry* cls, physx::PxType type) {
    return cls->getSerializer(type);
};ES void PxSerializationRegistry__registerRepXSerializer(physx::PxSerializationRegistry* cls, physx::PxType type, physx::PxRepXSerializer* serializer) {
    return cls->registerRepXSerializer(type, *serializer);
};ES physx::PxRepXSerializer* PxSerializationRegistry__unregisterRepXSerializer(physx::PxSerializationRegistry* cls, physx::PxType type) {
    return cls->unregisterRepXSerializer(type);
};ES physx::PxRepXSerializer* PxSerializationRegistry__getRepXSerializer(physx::PxSerializationRegistry* cls, const char* typeName) {
    return cls->getRepXSerializer(typeName);
};ES void PxSerializationRegistry__release(physx::PxSerializationRegistry* cls) {
    return cls->release();
};