#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxVisualizationParameter : int {
    eSCALE = 0,                       // eSCALE
    eWORLD_AXES = 1,                  // eWORLD_AXES
    eBODY_AXES = 2,                   // eBODY_AXES
    eBODY_MASS_AXES = 3,              // eBODY_MASS_AXES
    eBODY_LIN_VELOCITY = 4,           // eBODY_LIN_VELOCITY
    eBODY_ANG_VELOCITY = 5,           // eBODY_ANG_VELOCITY
    eCONTACT_POINT = 6,               // eCONTACT_POINT
    eCONTACT_NORMAL = 7,              // eCONTACT_NORMAL
    eCONTACT_ERROR = 8,               // eCONTACT_ERROR
    eCONTACT_FORCE = 9,               // eCONTACT_FORCE
    eACTOR_AXES = 10,                 // eACTOR_AXES
    eCOLLISION_AABBS = 11,            // eCOLLISION_AABBS
    eCOLLISION_SHAPES = 12,           // eCOLLISION_SHAPES
    eCOLLISION_AXES = 13,             // eCOLLISION_AXES
    eCOLLISION_COMPOUNDS = 14,        // eCOLLISION_COMPOUNDS
    eCOLLISION_FNORMALS = 15,         // eCOLLISION_FNORMALS
    eCOLLISION_EDGES = 16,            // eCOLLISION_EDGES
    eCOLLISION_STATIC = 17,           // eCOLLISION_STATIC
    eCOLLISION_DYNAMIC = 18,          // eCOLLISION_DYNAMIC
    eDEPRECATED_COLLISION_PAIRS = 19, // eDEPRECATED_COLLISION_PAIRS
    eJOINT_LOCAL_FRAMES = 20,         // eJOINT_LOCAL_FRAMES
    eJOINT_LIMITS = 21,               // eJOINT_LIMITS
    eCULL_BOX = 22,                   // eCULL_BOX
    eMBP_REGIONS = 23,                // eMBP_REGIONS
    eNUM_VALUES = 24,                 // eNUM_VALUES
    eFORCE_DWORD = 2147483647,        // eFORCE_DWORD = 0x7fffffff
}
#endif //enum


// Class physx::PxVisualizationParameter Manually Ignored