using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static physx;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SharpPhysXErrorFptr(
    PxErrorCodeEnum code,
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
