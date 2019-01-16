ES void PxErrorCallback__reportError(physx::PxErrorCallback* cls, physx::PxErrorCode::Enum code, const char* message, const char* file, int line) {
    return cls->reportError(code, message, file, line);
};
