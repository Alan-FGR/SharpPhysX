#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxBroadPhaseType : int {
    eSAP = 0,  // eSAP
    eMBP = 1,  // eMBP
    eABP = 2,  // eABP
    eGPU = 3,  // eGPU
    eLAST = 4, // eLAST
}
#endif


// Class physx::PxBroadPhaseCallback Manually Ignored
// Class physx::PxBroadPhaseType Manually Ignored
#if !NATIVE
public unsafe interface IPxBroadPhaseCaps {
    // PxBroadPhaseCaps(/*NULLPARS*/);
    // PxBroadPhaseCaps(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBroadPhaseCaps lhs, /*NULLPARS*/);
    // PxBroadPhaseCaps(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBroadPhaseCaps lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxBroadPhaseCaps(/*NULLPARS*/);
    
}

public unsafe partial struct PxBroadPhaseCaps : IPxBroadPhaseCaps { // blittable
    public uint maxNbRegions;
    public uint maxNbObjects;
    public bool needsPredefinedBounds;

#endif

    // Hierarchy: PxBroadPhaseCaps
    //Skipped generated implicit entry: PxBroadPhaseCaps
    
    //Skipped generated implicit entry: PxBroadPhaseCaps
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxBroadPhaseCaps
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBroadPhaseCaps
    

#if !NATIVE
}
#endif

// Class physx::PxBroadPhaseRegionInfo Manually Ignored
// Class physx::PxBroadPhaseRegion Manually Ignored