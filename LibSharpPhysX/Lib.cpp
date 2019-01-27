#include <cstdio>

#include "PxPhysicsAPI.h"

#define ES extern "C" __declspec(dllexport) inline // Export Symbol

//directly replace functions we want to rewrap since there's no overload

//#include "Generated/PxFoundation.h"
//
//#include "Generated/PxVec3.h"
//#include "Generated/PxBase.h"
//#include "Generated/PxBoxGeometry.h"
//#include "Generated/PxGeometry.h"

//Manual

static physx::PxDefaultAllocator allocator_;

typedef void(__stdcall *SharpPhysXErrorCallback)
(physx::PxErrorCode::Enum code, const char* message, const char* file, int line);

class ShPxErrorCallbackWrapper : public physx::PxErrorCallback
{
    SharpPhysXErrorCallback managedErrorCallback_ {nullptr};
public:
    explicit ShPxErrorCallbackWrapper(SharpPhysXErrorCallback managedErrorCallback)
        : managedErrorCallback_(managedErrorCallback)
    {}

    void reportError(physx::PxErrorCode::Enum code, const char* message, const char* file, int line) override
    {
        managedErrorCallback_(code, message, file, line);
    }
};

ES physx::PxFoundation* PxCreateFoundation(SharpPhysXErrorCallback* managedErrorCallback)
{
    return PxCreateFoundation(PX_PHYSICS_VERSION, allocator_, *new ShPxErrorCallbackWrapper(*managedErrorCallback));
}






//callback tests
using namespace physx;

typedef void (__stdcall *ErrorCallback)(const char* message, const char* file, int line);

ES void registerCallback(ErrorCallback callback)
{
    printf("calling callback from native...\n");

    callback("MESSAGE!", "FILE!", 1337);

    printf("finished calling\n");
}


//blittable tests

ES float PxVec3__magnitude(PxVec3 cls)
{
    return cls.magnitude();
};

ES PxVec3 PxVec3__OP_plus(PxVec3 a, PxVec3 b)
{
    return a.operator+(b);
}



//
//PxDefaultAllocator allocator;
//PxDefaultErrorCallback errorCallback;
//
//PxFoundation* foundation;
//
//ES PxFoundation* _PxCreateFoundation(int version, PxDefaultAllocator* allocator, PxDefaultErrorCallback* errorCallback)
//{
//    return PxCreateFoundation(version, *allocator, *errorCallback);
//}
//
//ES void _PxFoundation__release(PxFoundation* foundation)
//{
//    foundation->release();
//}