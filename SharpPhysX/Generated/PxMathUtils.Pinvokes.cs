// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_PxShortestRotationPtr_PxVec3_PxVec3_(physx.PxQuat* pvk_RetRef, physx.PxVec3* pvk_from, physx.PxVec3* pvk_target);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_PxDiagonalizePtr_PxMat33_PxQuat_(physx.PxVec3* pvk_RetRef, physx.PxMat33* pvk_m, physx.PxQuat* pvk_axes);
}
