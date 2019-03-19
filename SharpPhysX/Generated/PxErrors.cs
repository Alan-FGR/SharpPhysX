#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxErrorCode : int {
    eNO_ERROR = 0,                    // eNO_ERROR = 0
    eDEBUG_INFO = 1,                  // eDEBUG_INFO = 1
    eDEBUG_WARNING = 2,               // eDEBUG_WARNING = 2
    eINVALID_PARAMETER = 4,           // eINVALID_PARAMETER = 4
    eINVALID_OPERATION = 8,           // eINVALID_OPERATION = 8
    eOUT_OF_MEMORY = 16,              // eOUT_OF_MEMORY = 16
    eINTERNAL_ERROR = 32,             // eINTERNAL_ERROR = 32
    eABORT = 64,                      // eABORT = 64
    ePERF_WARNING = 128,              // ePERF_WARNING = 128
    eMASK_ALL = -1,                   // eMASK_ALL = -1
}
#endif //enum


// Class physx::PxErrorCode is enum namespace