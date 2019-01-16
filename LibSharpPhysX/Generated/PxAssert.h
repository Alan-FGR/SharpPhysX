ES physx::PxAssertHandler* __REF___PxGetAssertHandler() {
    return &physx::PxGetAssertHandler();
};
ES void __PxSetAssertHandler(physx::PxAssertHandler* handler) {
    return physx::PxSetAssertHandler(*handler);
};
