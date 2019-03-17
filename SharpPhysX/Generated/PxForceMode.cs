#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxForceMode : int {
    eFORCE = 0,           // eFORCE
    eIMPULSE = 1,         // eIMPULSE
    eVELOCITY_CHANGE = 2, // eVELOCITY_CHANGE
    eACCELERATION = 3,    // eACCELERATION
}
#endif


// Class physx::PxForceMode is enum namespace