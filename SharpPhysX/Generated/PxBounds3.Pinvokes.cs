// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_PxBounds3Ptr_Ctor(physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_PxBounds3Ptr_Ctor_PxVec3_PxVec3_(physx.PxBounds3* pvk_this, physx.PxVec3* pvk_minimum, physx.PxVec3* pvk_maximum);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_emptyPtr(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_boundsOfPointsPtr_PxVec3_PxVec3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxVec3* pvk_v0, physx.PxVec3* pvk_v1);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_centerExtentsPtr_PxVec3_PxVec3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxVec3* pvk_center, physx.PxVec3* pvk_extent);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_basisExtentPtr_PxVec3_PxMat33_PxVec3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxVec3* pvk_center, physx.PxMat33* pvk_basis, physx.PxVec3* pvk_extent);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_poseExtentPtr_PxTransform_PxVec3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxTransform* pvk_pose, physx.PxVec3* pvk_extent);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_transformSafePtr_PxMat33_PxBounds3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxMat33* pvk_matrix, physx.PxBounds3* pvk_bounds);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_transformFastPtr_PxMat33_PxBounds3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxMat33* pvk_matrix, physx.PxBounds3* pvk_bounds);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_transformSafePtr_PxTransform_PxBounds3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxTransform* pvk_transform, physx.PxBounds3* pvk_bounds);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxBounds3_PxBounds3_transformFastPtr_PxTransform_PxBounds3_(physx.PxBounds3* pvk_RetRef, physx.PxBounds3* pvk_this, physx.PxTransform* pvk_transform, physx.PxBounds3* pvk_bounds);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_setEmptyPtr(physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_setMaximalPtr(physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_includePtr_PxVec3_(physx.PxBounds3* pvk_this, physx.PxVec3* pvk_v);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_includePtr_PxBounds3_(physx.PxBounds3* pvk_this, physx.PxBounds3* pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBounds3_isEmptyPtr(physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBounds3_intersectsPtr_PxBounds3_(physx.PxBounds3* pvk_this, physx.PxBounds3* pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBounds3_intersects1DPtr_PxBounds3_uint_(physx.PxBounds3* pvk_this, physx.PxBounds3* pvk_a, uint pvk_axis);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBounds3_containsPtr_PxVec3_(physx.PxBounds3* pvk_this, physx.PxVec3* pvk_v);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBounds3_isInsidePtr_PxBounds3_(physx.PxBounds3* pvk_this, physx.PxBounds3* pvk_box);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxBounds3_getCenterPtr(physx.PxVec3* pvk_RetRef, physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxBounds3_getCenterPtr_uint_(physx.PxBounds3* pvk_this, uint pvk_axis);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxBounds3_getExtentsPtr_uint_(physx.PxBounds3* pvk_this, uint pvk_axis);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxBounds3_getDimensionsPtr(physx.PxVec3* pvk_RetRef, physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxBounds3_getExtentsPtr(physx.PxVec3* pvk_RetRef, physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_scaleSafePtr_float_(physx.PxBounds3* pvk_this, float pvk_scale);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_scaleFastPtr_float_(physx.PxBounds3* pvk_this, float pvk_scale);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_fattenSafePtr_float_(physx.PxBounds3* pvk_this, float pvk_distance);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBounds3_fattenFastPtr_float_(physx.PxBounds3* pvk_this, float pvk_distance);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBounds3_isFinitePtr(physx.PxBounds3* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBounds3_isValidPtr(physx.PxBounds3* pvk_this);

}
