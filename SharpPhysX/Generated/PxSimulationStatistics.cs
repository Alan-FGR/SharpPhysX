#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum RbPairStatsType : int {
    eDISCRETE_CONTACT_PAIRS = 0, // eDISCRETE_CONTACT_PAIRS
    eCCD_PAIRS = 1,              // eCCD_PAIRS
    eMODIFIED_CONTACT_PAIRS = 2, // eMODIFIED_CONTACT_PAIRS
    eTRIGGER_PAIRS = 3,          // eTRIGGER_PAIRS
}
#endif


// Class physx::PxSimulationStatistics Manually Ignored