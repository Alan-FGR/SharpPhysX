ES void PxFoundation__release(physx::PxFoundation* cls) {
    return cls->release();
};
ES physx::PxErrorCallback* __REF_PxFoundation__getErrorCallback(physx::PxFoundation* cls) {
    return &cls->getErrorCallback();
};
ES void PxFoundation__setErrorLevel(physx::PxFoundation* cls, physx::PxErrorCode::Enum mask) {
    return cls->setErrorLevel(mask);
};
ES physx::PxErrorCode::Enum PxFoundation__getErrorLevel(physx::PxFoundation* cls) {
    return cls->getErrorLevel();
};
ES physx::PxAllocatorCallback* __REF_PxFoundation__getAllocatorCallback(physx::PxFoundation* cls) {
    return &cls->getAllocatorCallback();
};
ES bool PxFoundation__getReportAllocationNames(physx::PxFoundation* cls) {
    return cls->getReportAllocationNames();
};
ES void PxFoundation__setReportAllocationNames(physx::PxFoundation* cls, bool value) {
    return cls->setReportAllocationNames(value);
};
ES physx::PxFoundation* __PxCreateFoundation(physx::PxU32 version, physx::PxAllocatorCallback* allocator, physx::PxErrorCallback* errorCallback) {
    return PxCreateFoundation(version, *allocator, *errorCallback);
};
ES physx::PxFoundation* __REF___PxGetFoundation() {
    return &PxGetFoundation();
};
ES physx::PxProfilerCallback* __PxGetProfilerCallback() {
    return PxGetProfilerCallback();
};
ES void __PxSetProfilerCallback(physx::PxProfilerCallback* profiler) {
    return PxSetProfilerCallback(profiler);
};
