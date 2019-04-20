#include "minBND_confs.h"

#include <cstdio>
#define CHECKREACH printf("REACHED %s L%d\n", __FILE__, __LINE__);getchar();
#define CHECK CHECKREACH
#define REACH CHECKREACH

#include "minBND_entry.h"

#include "Generated/minBND_typedefs.h"
#include "Generated/minBND_includes.h"

using namespace physx;

















// //callback tests
//
// typedef void (__stdcall *ErrorCallback)(const char* message, const char* file, int line);
//
// ES void registerCallback(ErrorCallback callback)
// {
//     //printf("calling callback from native...\n");
//
//     callback("MESSAGE!", "FILE!", 1337);
//
//     //printf("finished calling\n");
// }


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
