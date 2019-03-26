#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxZERO : int {
    PxZero = 0, // PxZero
}
#endif //enum

#if !NATIVE //enum
public enum PxIDENTITY : int {
    PxIdentity = 0, // PxIdentity
}
#endif //enum

#if !NATIVE //enum
public enum PxEMPTY : int {
    PxEmpty = 0, // PxEmpty
}
#endif //enum


// Class physx::PxInputStream Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxInputDataPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxInputDataPtr : IPxInputDataPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxInputDataPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxInputDataPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxOutputStream Manually Ignored