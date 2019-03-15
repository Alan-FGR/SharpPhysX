#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxErrorCode : int {
     eNO_ERROR          = 0,
     eDEBUG_INFO        = 1,
     eDEBUG_WARNING     = 2,
     eINVALID_PARAMETER = 4,
     eINVALID_OPERATION = 8,
     eOUT_OF_MEMORY     = 16,
     eINTERNAL_ERROR    = 32,
     eABORT             = 64,
     ePERF_WARNING      = 128,
     eMASK_ALL          = -1,
}
#endif


// Class physx::PxErrorCode Manually Ignored