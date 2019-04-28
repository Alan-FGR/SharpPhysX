// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR

ES void void_PxHeightFieldPtr_releasePtr(PxHeightFieldPtr wrp_this){
    wrp_this->release();
}

ES PxU32 uint_const_PxHeightFieldPtr_saveCellsPtr_IntPtr_uint_(PxHeightFieldPtr wrp_this, void* wrp_destBuffer, PxU32 wrp_destBufferSize){
    return (PxU32) wrp_this->saveCells(wrp_destBuffer, wrp_destBufferSize);
}

ES bool bool_PxHeightFieldPtr_modifySamplesPtr_int_int_PxHeightFieldDescPtr_bool_(PxHeightFieldPtr wrp_this, PxI32 wrp_startCol, PxI32 wrp_startRow, PxHeightFieldDescPtr wrp_subfieldDesc, bool wrp_shrinkBounds){
    return (bool) wrp_this->modifySamples(wrp_startCol, wrp_startRow, *wrp_subfieldDesc, wrp_shrinkBounds);
}

ES PxU32 uint_const_PxHeightFieldPtr_getNbRowsPtr(PxHeightFieldPtr wrp_this){
    return (PxU32) wrp_this->getNbRows();
}

ES PxU32 uint_const_PxHeightFieldPtr_getNbColumnsPtr(PxHeightFieldPtr wrp_this){
    return (PxU32) wrp_this->getNbColumns();
}

ES physx::PxHeightFieldFormat::Enum PxHeightFieldFormatEnum_const_PxHeightFieldPtr_getFormatPtr(PxHeightFieldPtr wrp_this){
    return (physx::PxHeightFieldFormat::Enum) wrp_this->getFormat();
}

ES PxU32 uint_const_PxHeightFieldPtr_getSampleStridePtr(PxHeightFieldPtr wrp_this){
    return (PxU32) wrp_this->getSampleStride();
}

ES PxReal float_const_PxHeightFieldPtr_getConvexEdgeThresholdPtr(PxHeightFieldPtr wrp_this){
    return (PxReal) wrp_this->getConvexEdgeThreshold();
}

ES PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_const_PxHeightFieldPtr_getFlagsPtr(PxHeightFieldPtr wrp_this){
    auto ret = wrp_this->getFlags();
    auto heap = new char[sizeof PxHeightFieldFlags];
    std::memcpy(heap, &ret, sizeof PxHeightFieldFlags);
    return (PxHeightFieldFlagsPtr) heap;
}

ES PxReal float_const_PxHeightFieldPtr_getHeightPtr_float_float_(PxHeightFieldPtr wrp_this, PxReal wrp_x, PxReal wrp_z){
    return (PxReal) wrp_this->getHeight(wrp_x, wrp_z);
}

ES PxU32 uint_const_PxHeightFieldPtr_getReferenceCountPtr(PxHeightFieldPtr wrp_this){
    return (PxU32) wrp_this->getReferenceCount();
}

ES void void_PxHeightFieldPtr_acquireReferencePtr(PxHeightFieldPtr wrp_this){
    wrp_this->acquireReference();
}

ES PxMaterialTableIndex ushort_const_PxHeightFieldPtr_getTriangleMaterialIndexPtr_uint_(PxHeightFieldPtr wrp_this, PxTriangleID wrp_triangleIndex){
    return (PxMaterialTableIndex) wrp_this->getTriangleMaterialIndex(wrp_triangleIndex);
}

ES void PxVec3_const_PxHeightFieldPtr_getTriangleNormalPtr_uint_(physx::PxVec3* nRetRef, PxHeightFieldPtr wrp_this, PxTriangleID wrp_triangleIndex){
    *nRetRef = wrp_this->getTriangleNormal(wrp_triangleIndex);
}

ES PxHeightFieldSamplePtr PxHeightFieldSamplePtr_const_PxHeightFieldPtr_getSamplePtr_uint_uint_(PxHeightFieldPtr wrp_this, PxU32 wrp_row, PxU32 wrp_column){
    return (PxHeightFieldSamplePtr) &wrp_this->getSample(wrp_row, wrp_column);
}

ES PxU32 uint_const_PxHeightFieldPtr_getTimestampPtr(PxHeightFieldPtr wrp_this){
    return (PxU32) wrp_this->getTimestamp();
}

ES char* string_const_PxHeightFieldPtr_getConcreteTypeNamePtr(PxHeightFieldPtr wrp_this){
    return (char*) wrp_this->getConcreteTypeName();
}

ES bool bool_PxHeightFieldPtr_modifySamplesPtr_int_int_PxHeightFieldDescPtr_(PxHeightFieldPtr wrp_this, PxI32 wrp_startCol, PxI32 wrp_startRow, PxHeightFieldDescPtr wrp_subfieldDesc){
    return (bool) wrp_this->modifySamples(wrp_startCol, wrp_startRow, *wrp_subfieldDesc);
}
