#include <cstdio>
//#include "PxPhysicsAPI.h"

#define ES extern "C" __declspec(dllexport) inline // Export Symbol

//#include "Generated/PxFoundation.h"



//callback tests

typedef void (__stdcall *ErrorCallback)(const char* message, const char* file, int line);

ES void registerCallback(ErrorCallback callback)
{
    printf("calling callback from native...\n");

    callback("MESSAGE!", "FILE!", 1337);

    printf("finished calling\n");
}


//blittable tests
#include "foundation/PxVec3.h"
using namespace physx;

ES float PxVec3__magnitude(physx::PxVec3 cls)
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