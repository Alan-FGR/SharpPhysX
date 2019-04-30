using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static physx;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SharpPhysXErrorFptr(
    PxErrorCode code,
    [MarshalAs(UnmanagedType.LPStr)] string message,
    [MarshalAs(UnmanagedType.LPStr)] string file,
    int line
);

public partial class SharpPhysX
{
    public static SharpPhysXErrorFptr DefaultErrorCallback =
    (code, message, file, line) =>
    {
        Console.WriteLine($"SharpPhysX Error Code: {code}, Message: {message}, File: {file}, Line: {line}");
    };
}

public partial class physx
{
    public static uint PX_PHYSICS_VERSION => SharpPhysX_internal.GetPhysicsVersion();

    public static PxSimulationFilterShader PxDefaultSimulationFilterShader =>
        SharpPhysX_internal.GetDefaultSimulationFilterShader();

    public struct PxGpuCopyDescPtr
    {
        private IntPtr intPtr_;
    }

    public partial struct PxVec3
    {
        public override string ToString()
        {
            return $"X: {x:f3}, Y: {y:f3}, Z: {z:f3}";
        }
    }

}


public partial class physx
{
    public enum PxHitFlags : ushort
    {
        ePOSITION                  = 1,    // ePOSITION = (1<<0)
        eNORMAL                    = 2,    // eNORMAL = (1<<1)
        eUV                        = 8,    // eUV = (1<<3)
        eASSUME_NO_INITIAL_OVERLAP = 16,   // eASSUME_NO_INITIAL_OVERLAP = (1<<4)
        eMESH_MULTIPLE             = 32,   // eMESH_MULTIPLE = (1<<5)
        eMESH_ANY                  = 64,   // eMESH_ANY = (1<<6)
        eMESH_BOTH_SIDES           = 128,  // eMESH_BOTH_SIDES = (1<<7)
        ePRECISE_SWEEP             = 256,  // ePRECISE_SWEEP = (1<<8)
        eMTD                       = 512,  // eMTD = (1<<9)
        eFACE_INDEX                = 1024, // eFACE_INDEX = (1<<10)
        eDEFAULT                   = 1027, // eDEFAULT = ePOSITION|eNORMAL|eFACE_INDEX
        eMODIFIABLE_FLAGS          = 432,  // eMODIFIABLE_FLAGS = eMESH_MULTIPLE|eMESH_BOTH_SIDES|eASSUME_NO_INITIAL_OVERLAP|ePRECISE_SWEEP
    }
}


//typedef struct CUstream_st* CUstream;
public unsafe struct CUstream
{
    private IntPtr CUstream_stPtr;
}


//typedef PxFilterFlags (*PxSimulationFilterShader)
//             (PxFilterObjectAttributes attributes0, PxFilterData filterData0, 
//             PxFilterObjectAttributes attributes1, PxFilterData filterData1,
//             PxPairFlags& pairFlags, const void* constantBlock, PxU32 constantBlockSize);
//[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
//public delegate uint PxSimulationFilterShader();
//UPDATE: this is too fine grained for interop costs, filter shaders should be implemented in native
public struct PxSimulationFilterShader { IntPtr ptr; }

//typedef PxU32 (*PxConstraintSolverPrep)(Px1DConstraint* constraints,
//                                        PxVec3& bodyAWorldOffset,
//                                        PxU32 maxConstraints,
//                                        PxConstraintInvMassScale& invMassScale,
//                                        const void* constantBlock,
//                                        const PxTransform& bodyAToWorld,
//                                        const PxTransform& bodyBToWorld,
//                                        bool useExtendedLimits,
//                                        PxVec3& cAtW,
//                                        PxVec3& cBtW);
public struct PxConstraintSolverPrep { IntPtr ptr; }

//typedef void (*PxConstraintProject)(const void* constantBlock,
//                                    PxTransform& bodyAToWorld,
//                                    PxTransform& bodyBToWorld,
//                                    bool projectToA);
public struct PxConstraintProject { IntPtr ptr; }

//typedef void (*PxConstraintVisualize)(PxConstraintVisualizer& visualizer,
//                                      const void* constantBlock,
//                                      const PxTransform& body0Transform,
//                                      const PxTransform& body1Transform,
//                                      PxU32 flags);
public struct PxConstraintVisualize { IntPtr ptr; }

//typedef void (*PxBinaryMetaDataCallback)(PxOutputStream& stream);
public struct PxBinaryMetaDataCallback { IntPtr ptr; }

public partial class PxFoundation
{
    
}


//public class PxRaycastBufferAuto : SafeHandle
//{
//    public readonly PxRaycastBufferPtr NativePtr;
//
//    public override bool IsInvalid => handle == IntPtr.Zero;
//
//    public PxRaycastBufferAuto() : base(PxRaycastBufferPtr.New().nativePtr_, true)
//    {
//        var addr = handle;
//        NativePtr = *(PxRaycastBufferPtr*)&addr;
//        #if DEBUG
//        Console.WriteLine($"Instantiating managed pointer of type {NativePtr.GetType()} at {handle}");
//        #endif
//    }
//
//    protected override bool ReleaseHandle()
//    {
//        Freer_physx_PxRaycastBufferPtr(NativePtr);
//        #if DEBUG
//        Console.WriteLine($"Freeing managed pointer of type {NativePtr.GetType()} at {handle}");
//        #endif
//        return true;
//    }
//}