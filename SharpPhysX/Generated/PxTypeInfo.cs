#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
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
#endif //enum


// Class physx::PxHeightField Manually Ignored
// Class physx::PxAggregate Manually Ignored
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

// Class physx::PxPruningStructure Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxArticulationJointPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxArticulationJointPtr : IPxArticulationJointPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxArticulationJointPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxArticulationJointPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxConcreteType is enum namespace
#if !NATIVE //interface
public unsafe interface IPxTypeInfo {
    
}
#endif //interface

#if !NATIVE //struct start POD:True
public unsafe partial struct PxTypeInfo : IPxTypeInfo { // blittable

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxTypeInfo
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close
