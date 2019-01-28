#pragma once

typedef void(__stdcall *SharpPhysXError)
(physx::PxErrorCode::Enum code, const char* message, const char* file, int line);


class ShPxErrorCallbackWrapper : public physx::PxErrorCallback
{
    SharpPhysXError managedErrorCallback_{ nullptr };
public:
    explicit ShPxErrorCallbackWrapper(SharpPhysXError managedErrorCallback)
        : managedErrorCallback_(managedErrorCallback)
    {}

    void reportError(physx::PxErrorCode::Enum code, const char* message, const char* file, int line) override
    {
        managedErrorCallback_(code, message, file, line);
    }
};