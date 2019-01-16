ES void* __platformAlignedAlloc(size_t size) {
    return physx::platformAlignedAlloc(size);
};
ES void __platformAlignedFree(void* ptr) {
    return physx::platformAlignedFree(ptr);
};
