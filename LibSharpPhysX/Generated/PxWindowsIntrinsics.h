ES float __abs(float a) {
    return physx::intrinsics::abs(a);
};ES float __fsel(float a, float b, float c) {
    return physx::intrinsics::fsel(a, b, c);
};ES float __sign(float a) {
    return physx::intrinsics::sign(a);
};ES float __recip(float a) {
    return physx::intrinsics::recip(a);
};ES float __recipFast(float a) {
    return physx::intrinsics::recipFast(a);
};ES float __sqrt(float a) {
    return physx::intrinsics::sqrt(a);
};ES float __recipSqrt(float a) {
    return physx::intrinsics::recipSqrt(a);
};ES float __recipSqrtFast(float a) {
    return physx::intrinsics::recipSqrtFast(a);
};ES float __sin(float a) {
    return physx::intrinsics::sin(a);
};ES float __cos(float a) {
    return physx::intrinsics::cos(a);
};ES float __selectMin(float a, float b) {
    return physx::intrinsics::selectMin(a, b);
};ES float __selectMax(float a, float b) {
    return physx::intrinsics::selectMax(a, b);
};ES bool __isFinite(float a) {
    return physx::intrinsics::isFinite(a);
};ES bool __isFinite(double a) {
    return physx::intrinsics::isFinite(a);
};ES void* __memZero(void* dest, uint32_t count) {
    return physx::intrinsics::memZero(dest, count);
};ES void* __memSet(void* dest, int32_t c, uint32_t count) {
    return physx::intrinsics::memSet(dest, c, count);
};ES void* __memCopy(void* dest, void* src, uint32_t count) {
    return physx::intrinsics::memCopy(dest, src, count);
};ES void* __memMove(void* dest, void* src, uint32_t count) {
    return physx::intrinsics::memMove(dest, src, count);
};ES void __memZero128(void* dest, uint32_t offset) {
    return physx::intrinsics::memZero128(dest, offset);
};