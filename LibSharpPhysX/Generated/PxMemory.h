ES void* __PxMemZero(void* dest, physx::PxU32 count) {
    return physx::PxMemZero(dest, count);
};ES void* __PxMemSet(void* dest, physx::PxI32 c, physx::PxU32 count) {
    return physx::PxMemSet(dest, c, count);
};ES void* __PxMemCopy(void* dest, void* src, physx::PxU32 count) {
    return physx::PxMemCopy(dest, src, count);
};ES void* __PxMemMove(void* dest, void* src, physx::PxU32 count) {
    return physx::PxMemMove(dest, src, count);
};