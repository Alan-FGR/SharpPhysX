#pragma once

typedef void(__stdcall *SharpPhysXErrorFptr)
(physx::PxErrorCode::Enum code, const char* message, const char* file, int line);

class ShPxErrorCallbackWrapper : public physx::PxErrorCallback
{
    SharpPhysXErrorFptr managedErrorCallback_{ nullptr };
public:
    explicit ShPxErrorCallbackWrapper(SharpPhysXErrorFptr managedErrorCallback)
        : managedErrorCallback_(managedErrorCallback)
    {}

    void reportError(physx::PxErrorCode::Enum code, const char* message, const char* file, int line) override
    {
        managedErrorCallback_(code, message, file, line);
    }
};
