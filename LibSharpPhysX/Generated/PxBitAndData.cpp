// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR

ES void Freer_physx_PxBitAndBytePtr(PxBitAndBytePtr ptr){
    delete ptr;
}

ES PxBitAndBytePtr Ctor_PxBitAndBytePtr_PxEMPTY(physx::PxEMPTY wrp__){
    auto ret = *(new std::remove_pointer<PxBitAndBytePtr>::type(wrp__));
    auto heap = new char[sizeof PxBitAndByte];
    std::memcpy(heap, &ret, sizeof PxBitAndByte);
    return (PxBitAndBytePtr) heap;
}

ES PxBitAndBytePtr Ctor_PxBitAndBytePtr_(){
    auto ret = *(new std::remove_pointer<PxBitAndBytePtr>::type());
    auto heap = new char[sizeof PxBitAndByte];
    std::memcpy(heap, &ret, sizeof PxBitAndByte);
    return (PxBitAndBytePtr) heap;
}

ES PxBitAndBytePtr Ctor_PxBitAndBytePtr_byte_bool(unsigned char wrp_data, bool wrp_bit){
    auto ret = *(new std::remove_pointer<PxBitAndBytePtr>::type(wrp_data, wrp_bit));
    auto heap = new char[sizeof PxBitAndByte];
    std::memcpy(heap, &ret, sizeof PxBitAndByte);
    return (PxBitAndBytePtr) heap;
}

ES PxBitAndBytePtr Ctor_PxBitAndBytePtr_byte(unsigned char wrp_data){
    auto ret = *(new std::remove_pointer<PxBitAndBytePtr>::type(wrp_data));
    auto heap = new char[sizeof PxBitAndByte];
    std::memcpy(heap, &ret, sizeof PxBitAndByte);
    return (PxBitAndBytePtr) heap;
}

ES unsigned char byte_const_PxBitAndBytePtr_operator_unsigned_charPtr_Conversion(PxBitAndBytePtr wrp_lhs){
    return (unsigned char) wrp_lhs->PxBitAndDataT<unsigned char, 128>::operator unsigned char();
}

ES void void_PxBitAndBytePtr_setBitPtr(PxBitAndBytePtr wrp_this){
    wrp_this->setBit();
}

ES void void_PxBitAndBytePtr_clearBitPtr(PxBitAndBytePtr wrp_this){
    wrp_this->clearBit();
}

ES unsigned char byte_const_PxBitAndBytePtr_isBitSetPtr(PxBitAndBytePtr wrp_this){
    return (unsigned char) wrp_this->isBitSet();
}

ES void Freer_physx_PxBitAndWordPtr(PxBitAndWordPtr ptr){
    delete ptr;
}

ES void Freer_physx_PxBitAndDwordPtr(PxBitAndDwordPtr ptr){
    delete ptr;
}

