// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_PxTransformFromPlaneEquationPtr_PxPlane_(physx.PxTransform* pvk_RetRef, physx.PxPlane* pvk_plane);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxPlane_PxPlaneEquationFromTransformPtr_PxTransform_(physx.PxPlane* pvk_RetRef, physx.PxTransform* pvk_transform);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Default_PxPlaneGeometry_(physx.PxPlaneGeometry* pvk_RetRef);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxPlaneGeometry_isValidPtr(physx.PxPlaneGeometry* pvk_this);

}
