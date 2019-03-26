#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxArticulationLinkPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxArticulationLinkPtr : IPxArticulationLinkPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxArticulationLinkPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxArticulationLinkPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxArticulation Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxArticulationDriveCachePtr {
    // static PxArticulationDriveCachePtr New(/*NULLPARS*/);
    // static PxArticulationDriveCachePtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxArticulationDriveCachePtr lhs, /*NULLPARS*/);
    // static PxArticulationDriveCachePtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxArticulationDriveCachePtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxArticulationDriveCache(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxArticulationDriveCachePtr : IPxArticulationDriveCachePtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxArticulationDriveCachePtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxArticulationDriveCachePtr
    #endif //hierarchy
    //Skipped protected: PxArticulationDriveCache
    
    //Skipped generated implicit entry: PxArticulationDriveCache
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxArticulationDriveCache
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxArticulationDriveCache
    

#if !NATIVE //struct close
}
#endif //struct close
