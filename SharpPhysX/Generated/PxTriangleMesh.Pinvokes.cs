// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxTriangleMeshFlagsPtr PxTriangleMeshFlagsPtr_operator_Ptr_Pipe_PxTriangleMeshFlagEnum_PxTriangleMeshFlagEnum_(physx.PxTriangleMeshFlagEnum pvk_a, physx.PxTriangleMeshFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxTriangleMeshFlagsPtr PxTriangleMeshFlagsPtr_operator_Ptr_Amp_PxTriangleMeshFlagEnum_PxTriangleMeshFlagEnum_(physx.PxTriangleMeshFlagEnum pvk_a, physx.PxTriangleMeshFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxTriangleMeshFlagsPtr PxTriangleMeshFlagsPtr_operator_Ptr_Tilde_PxTriangleMeshFlagEnum_(physx.PxTriangleMeshFlagEnum pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxTriangleMeshPtr_getNbVerticesPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec3* PxVec3_const_PxTriangleMeshPtr_getVerticesPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec3* PxVec3_PxTriangleMeshPtr_getVerticesForModificationPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxTriangleMeshPtr_refitBVHPtr(physx.PxBounds3* pvk_RetRef, physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxTriangleMeshPtr_getNbTrianglesPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern IntPtr IntPtr_const_PxTriangleMeshPtr_getTrianglesPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxTriangleMeshFlagsPtr PxTriangleMeshFlagsPtr_const_PxTriangleMeshPtr_getTriangleMeshFlagsPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint* uint_const_PxTriangleMeshPtr_getTrianglesRemapPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTriangleMeshPtr_releasePtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort ushort_const_PxTriangleMeshPtr_getTriangleMaterialIndexPtr_uint_(physx.PxTriangleMeshPtr pvk_this, uint pvk_triangleIndex);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_const_PxTriangleMeshPtr_getLocalBoundsPtr(physx.PxBounds3* pvk_RetRef, physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxTriangleMeshPtr_getReferenceCountPtr(physx.PxTriangleMeshPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTriangleMeshPtr_acquireReferencePtr(physx.PxTriangleMeshPtr pvk_this);

}
