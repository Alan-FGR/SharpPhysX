#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxBroadPhaseType : int {
    eSAP = 0,  // eSAP
    eMBP = 1,  // eMBP
    eABP = 2,  // eABP
    eGPU = 3,  // eGPU
    eLAST = 4, // eLAST
}
#endif //enum


// Class physx::PxBroadPhaseCallback Manually Ignored
// Class physx::PxBroadPhaseType Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxBroadPhaseCaps {
    // PxBroadPhaseCaps(/*NULLPARS*/);
    // PxBroadPhaseCaps(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBroadPhaseCaps lhs, /*NULLPARS*/);
    // PxBroadPhaseCaps(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBroadPhaseCaps lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxBroadPhaseCaps(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:True
public unsafe partial struct PxBroadPhaseCaps : IPxBroadPhaseCaps { // blittable
    public uint maxNbRegions;
    public uint maxNbObjects;
    public bool needsPredefinedBounds;

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBroadPhaseCaps
    #endif //hierarchy
    //Skipped generated implicit entry: PxBroadPhaseCaps
    
    //Skipped generated implicit entry: PxBroadPhaseCaps
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxBroadPhaseCaps
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBroadPhaseCaps
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxBroadPhaseRegionInfo Manually Ignored
// Class physx::PxBroadPhaseRegion Manually Ignored