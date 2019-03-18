#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxArticulationBase : int {
    eReducedCoordinate = 0, // eReducedCoordinate = 0
    eMaximumCoordinate = 1, // eMaximumCoordinate = 1
}
#endif


// Class physx::PxArticulationBase Manually Ignored
#if !NATIVE
public unsafe interface IPxArticulationImplPtr {
    
}

public unsafe partial struct PxArticulationImplPtr : IPxArticulationImplPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxArticulationImplPtr

#if !NATIVE
}
#endif
