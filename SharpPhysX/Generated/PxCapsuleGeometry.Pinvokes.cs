// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_PxTransformFromSegmentPtr_PxVec3_PxVec3_(physx.PxTransform* pvk_RetRef, physx.PxVec3* pvk_p0, physx.PxVec3* pvk_p1);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_PxTransformFromSegmentPtr_PxVec3_PxVec3_float_(physx.PxTransform* pvk_RetRef, physx.PxVec3* pvk_p0, physx.PxVec3* pvk_p1, float* pvk_halfHeight);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Default_PxCapsuleGeometry_(physx.PxCapsuleGeometry* pvk_RetRef);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCapsuleGeometry_PxCapsuleGeometryPtr_Ctor_float_float_(physx.PxCapsuleGeometry* pvk_this, float pvk_radius_, float pvk_halfHeight_);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxCapsuleGeometry_isValidPtr(physx.PxCapsuleGeometry* pvk_this);

}
