#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxZERO : int {
    PxZero = 0, // PxZero
}
#endif

#if !NATIVE
public enum PxIDENTITY : int {
    PxIdentity = 0, // PxIdentity
}
#endif

#if !NATIVE
public enum PxEMPTY : int {
    PxEmpty = 0, // PxEmpty
}
#endif


// Class physx::PxInputStream Manually Ignored
#if !NATIVE
public unsafe interface IPxInputDataPtr {
    
}

public unsafe partial struct PxInputDataPtr : IPxInputDataPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxInputDataPtr

#if !NATIVE
}
#endif

// Class physx::PxOutputStream Manually Ignored
#if !NATIVE
public unsafe interface IPxVec2 {
    
}

public unsafe partial struct PxVec2 : IPxVec2 { // blittable

#endif

    // Hierarchy: PxVec2

#if !NATIVE
}
#endif
