#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxConcreteType : int {
    eUNDEFINED = 0,                 // eUNDEFINED
    eHEIGHTFIELD = 1,               // eHEIGHTFIELD
    eCONVEX_MESH = 2,               // eCONVEX_MESH
    eTRIANGLE_MESH_BVH33 = 3,       // eTRIANGLE_MESH_BVH33
    eTRIANGLE_MESH_BVH34 = 4,       // eTRIANGLE_MESH_BVH34
    eRIGID_DYNAMIC = 5,             // eRIGID_DYNAMIC
    eRIGID_STATIC = 6,              // eRIGID_STATIC
    eSHAPE = 7,                     // eSHAPE
    eMATERIAL = 8,                  // eMATERIAL
    eCONSTRAINT = 9,                // eCONSTRAINT
    eAGGREGATE = 10,                // eAGGREGATE
    eARTICULATION = 11,             // eARTICULATION
    eARTICULATION_LINK = 12,        // eARTICULATION_LINK
    eARTICULATION_JOINT = 13,       // eARTICULATION_JOINT
    ePRUNING_STRUCTURE = 14,        // ePRUNING_STRUCTURE
    eBVH_STRUCTURE = 15,            // eBVH_STRUCTURE
    ePHYSX_CORE_COUNT = 16,         // ePHYSX_CORE_COUNT
    eFIRST_PHYSX_EXTENSION = 256,   // eFIRST_PHYSX_EXTENSION = 256
    eFIRST_VEHICLE_EXTENSION = 512, // eFIRST_VEHICLE_EXTENSION = 512
    eFIRST_USER_EXTENSION = 1024,   // eFIRST_USER_EXTENSION = 1024
}
#endif


// Class physx::PxHeightField Manually Ignored
// Class physx::PxAggregate Manually Ignored

// Class physx::PxPruningStructure Manually Ignored

// Class physx::PxConcreteType is enum namespace
