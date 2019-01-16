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





//ES int add(int x, int y)
//{
//    return x + y;
//}
//
//using namespace physx;
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