ES void* PxAllocatorCallback__allocate(physx::PxAllocatorCallback* cls, size_t size, const char* typeName, const char* filename, int line) {
    return cls->allocate(size, typeName, filename, line);
};
ES void PxAllocatorCallback__deallocate(physx::PxAllocatorCallback* cls, void* ptr) {
    return cls->deallocate(ptr);
};
