// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void void_PxProcessPxBaseCallbackPtr_processPtr_PxBasePtr_(PxProcessPxBaseCallbackPtr wrp_this, PxBasePtr wrp__){
    wrp_this->process(*wrp__);
}

ES void void_PxSerializationContextPtr_registerReferencePtr_PxBasePtr_uint_ulong_(PxSerializationContextPtr wrp_this, PxBasePtr wrp_base, PxU32 wrp_kind, size_t wrp_reference){
    wrp_this->registerReference(*wrp_base, wrp_kind, wrp_reference);
}

ES PxCollectionPtr PxCollectionPtr_const_PxSerializationContextPtr_getCollectionPtr(PxSerializationContextPtr wrp_this){
    return (PxCollectionPtr) &wrp_this->getCollection();
}

ES void void_PxSerializationContextPtr_writeDataPtr_IntPtr_uint_(PxSerializationContextPtr wrp_this, void* wrp_data, PxU32 wrp_size){
    wrp_this->writeData(wrp_data, wrp_size);
}

ES void void_PxSerializationContextPtr_alignDataPtr_uint_(PxSerializationContextPtr wrp_this, PxU32 wrp_alignment){
    wrp_this->alignData(wrp_alignment);
}

ES void void_PxSerializationContextPtr_writeNamePtr_string_(PxSerializationContextPtr wrp_this, char* wrp_name){
    wrp_this->writeName(wrp_name);
}

ES void void_PxSerializationContextPtr_alignDataPtr(PxSerializationContextPtr wrp_this){
    wrp_this->alignData();
}

ES PxBasePtr PxBasePtr_const_PxDeserializationContextPtr_resolveReferencePtr_uint_ulong_(PxDeserializationContextPtr wrp_this, PxU32 wrp_kind, size_t wrp_reference){
    return (PxBasePtr) wrp_this->resolveReference(wrp_kind, wrp_reference);
}

ES void void_PxDeserializationContextPtr_readNamePtr_sbyte_(PxDeserializationContextPtr wrp_this, const char** wrp_name){
    wrp_this->readName(*wrp_name);
}

ES void void_PxDeserializationContextPtr_alignExtraDataPtr_uint_(PxDeserializationContextPtr wrp_this, PxU32 wrp_alignment){
    wrp_this->alignExtraData(wrp_alignment);
}

ES PxU32 uint_const_PxDeserializationContextPtr_getPhysXVersionPtr(PxDeserializationContextPtr wrp_this){
    return (PxU32) wrp_this->getPhysXVersion();
}

ES void void_PxDeserializationContextPtr_alignExtraDataPtr(PxDeserializationContextPtr wrp_this){
    wrp_this->alignExtraData();
}

ES void void_PxSerializationRegistryPtr_registerBinaryMetaDataCallbackPtr_PxBinaryMetaDataCallback_(PxSerializationRegistryPtr wrp_this, PxBinaryMetaDataCallback wrp_callback){
    wrp_this->registerBinaryMetaDataCallback(wrp_callback);
}

ES void void_PxSerializationRegistryPtr_releasePtr(PxSerializationRegistryPtr wrp_this){
    wrp_this->release();
}

