#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



// Class physx::PxHeightField Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxHeightFieldDescPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxHeightFieldDescPtr : IPxHeightFieldDescPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxHeightFieldDescPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxHeightFieldDescPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close
