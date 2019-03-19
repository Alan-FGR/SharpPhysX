#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxForceMode : int {
    eFORCE = 0,           // eFORCE
    eIMPULSE = 1,         // eIMPULSE
    eVELOCITY_CHANGE = 2, // eVELOCITY_CHANGE
    eACCELERATION = 3,    // eACCELERATION
}
#endif //enum


// Class physx::PxForceMode is enum namespace