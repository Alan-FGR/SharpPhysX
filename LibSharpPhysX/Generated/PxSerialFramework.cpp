// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
ES void void_physx_PxProcessPxBaseCallback_process_physx_PxBasePtr_(PxProcessPxBaseCallbackPtr wrp_this, PxBasePtr wrp__){
    wrp_this->process(*wrp__);
}

ES void void_physx_PxSerializationContext_registerReference_physx_PxBasePtr_uint_ulong_(PxSerializationContextPtr wrp_this, PxBasePtr wrp_base, unsigned int wrp_kind, unsigned long long wrp_reference){
    wrp_this->registerReference(*wrp_base, wrp_kind, wrp_reference);
}

ES PxCollectionPtr physx_PxCollectionPtr_const_physx_PxSerializationContext_getCollection(PxSerializationContextPtr wrp_this){
    return (PxCollectionPtr) &wrp_this->getCollection();
}

ES void void_physx_PxSerializationContext_writeData_IntPtr_uint_(PxSerializationContextPtr wrp_this, void* wrp_data, unsigned int wrp_size){
    wrp_this->writeData(wrp_data, wrp_size);
}

ES void void_physx_PxSerializationContext_alignData_uint_(PxSerializationContextPtr wrp_this, unsigned int wrp_alignment){
    wrp_this->alignData(wrp_alignment);
}

ES void void_physx_PxSerializationContext_alignData(PxSerializationContextPtr wrp_this){
    wrp_this->alignData();
}

ES void void_physx_PxSerializationContext_writeName_string_(PxSerializationContextPtr wrp_this, char* wrp_name){
    wrp_this->writeName(wrp_name);
}

ES PxBasePtr physx_PxBasePtr_const_physx_PxDeserializationContext_resolveReference_uint_ulong_(PxDeserializationContextPtr wrp_this, unsigned int wrp_kind, unsigned long long wrp_reference){
    return (PxBasePtr) wrp_this->resolveReference(wrp_kind, wrp_reference);
}

ES void void_physx_PxDeserializationContext_readName_sbyte_(PxDeserializationContextPtr wrp_this, const char** wrp_name){
    wrp_this->readName(*wrp_name);
}

ES void void_physx_PxDeserializationContext_alignExtraData_uint_(PxDeserializationContextPtr wrp_this, unsigned int wrp_alignment){
    wrp_this->alignExtraData(wrp_alignment);
}

ES void void_physx_PxDeserializationContext_alignExtraData(PxDeserializationContextPtr wrp_this){
    wrp_this->alignExtraData();
}

ES unsigned int uint_const_physx_PxDeserializationContext_getPhysXVersion(PxDeserializationContextPtr wrp_this){
    return (unsigned int) wrp_this->getPhysXVersion();
}

ES void void_physx_PxSerializationRegistry_registerBinaryMetaDataCallback_PxBinaryMetaDataCallback_(PxSerializationRegistryPtr wrp_this, PxBinaryMetaDataCallback wrp_callback){
    wrp_this->registerBinaryMetaDataCallback(wrp_callback);
}

ES void void_physx_PxSerializationRegistry_release(PxSerializationRegistryPtr wrp_this){
    wrp_this->release();
}
