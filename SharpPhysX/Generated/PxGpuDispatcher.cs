#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



// Class physx::PxGpuDispatcher Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxCudaContextManagerPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxCudaContextManagerPtr : IPxCudaContextManagerPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxCudaContextManagerPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxCudaContextManagerPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxGpuCopyDescPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxGpuCopyDescPtr : IPxGpuCopyDescPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxGpuCopyDescPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxGpuCopyDescPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface ICUstream_stPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct CUstream_stPtr : ICUstream_stPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct CUstream_stPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: CUstream_stPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close
