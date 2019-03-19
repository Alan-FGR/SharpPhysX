#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum RbPairStatsType : int {
    eDISCRETE_CONTACT_PAIRS = 0, // eDISCRETE_CONTACT_PAIRS
    eCCD_PAIRS = 1,              // eCCD_PAIRS
    eMODIFIED_CONTACT_PAIRS = 2, // eMODIFIED_CONTACT_PAIRS
    eTRIGGER_PAIRS = 3,          // eTRIGGER_PAIRS
}
#endif //enum


// Class physx::PxSimulationStatistics Manually Ignored