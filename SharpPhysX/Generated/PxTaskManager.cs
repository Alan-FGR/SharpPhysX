#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxTaskType : int {
    TT_CPU = 0,         // TT_CPU
    TT_GPU = 1,         // TT_GPU
    TT_NOT_PRESENT = 2, // TT_NOT_PRESENT
    TT_COMPLETED = 3,   // TT_COMPLETED
}
#endif


// Class physx::PxTaskManager Manually Ignored
// Class physx::PxTaskType is enum namespace