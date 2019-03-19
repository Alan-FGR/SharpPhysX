#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxArticulationBase : int {
    eReducedCoordinate = 0, // eReducedCoordinate = 0
    eMaximumCoordinate = 1, // eMaximumCoordinate = 1
}
#endif //enum


// Class physx::PxArticulationBase Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxArticulationImplPtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxArticulationImplPtr : IPxArticulationImplPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxArticulationImplPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close
