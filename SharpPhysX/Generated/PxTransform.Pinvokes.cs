// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Default_PxTransform_(physx.PxTransform* pvk_RetRef);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTransform_PxTransformPtr_Ctor_PxVec3_(physx.PxTransform* pvk_this, physx.PxVec3* pvk_position);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTransform_PxTransformPtr_Ctor_PxIDENTITY_(physx.PxTransform* pvk_this, physx.PxIDENTITY pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTransform_PxTransformPtr_Ctor_PxQuat_(physx.PxTransform* pvk_this, physx.PxQuat* pvk_orientation);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTransform_PxTransformPtr_Ctor_float_float_float_(physx.PxTransform* pvk_this, float pvk_x, float pvk_y, float pvk_z);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTransform_PxTransformPtr_Ctor_float_float_float_PxQuat_(physx.PxTransform* pvk_this, float pvk_x, float pvk_y, float pvk_z, physx.PxQuat pvk_aQ);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTransform_PxTransformPtr_Ctor_PxVec3_PxQuat_(physx.PxTransform* pvk_this, physx.PxVec3* pvk_p0, physx.PxQuat* pvk_q0);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxTransform_PxTransformPtr_Ctor_PxMat44_(physx.PxTransform* pvk_this, physx.PxMat44* pvk_m);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxTransform_operator_Ptr_EqualEqual_PxTransform_(physx.PxTransform* pvk_lhs, physx.PxTransform* pvk_t);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_const_PxTransform_operator_Ptr_Star_PxTransform_(physx.PxTransform* pvk_RetRef, physx.PxTransform* pvk_lhs, physx.PxTransform* pvk_x);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxTransform* PxTransform_PxTransform_operator_Ptr_StarEqual_PxTransform_(physx.PxTransform* pvk_lhs, physx.PxTransform* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_const_PxTransform_getInversePtr(physx.PxTransform* pvk_RetRef, physx.PxTransform* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxTransform_transformPtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxVec3* pvk_input);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxTransform_transformInvPtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxVec3* pvk_input);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxTransform_rotatePtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxVec3* pvk_input);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxTransform_rotateInvPtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxVec3* pvk_input);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_const_PxTransform_transformPtr_PxTransform_(physx.PxTransform* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxTransform* pvk_src);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxTransform_isValidPtr(physx.PxTransform* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxTransform_isSanePtr(physx.PxTransform* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxTransform_isFinitePtr(physx.PxTransform* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_const_PxTransform_transformInvPtr_PxTransform_(physx.PxTransform* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxTransform* pvk_src);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxPlane_const_PxTransform_transformPtr_PxPlane_(physx.PxPlane* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxPlane* pvk_plane);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxPlane_const_PxTransform_inverseTransformPtr_PxPlane_(physx.PxPlane* pvk_RetRef, physx.PxTransform* pvk_this, physx.PxPlane* pvk_plane);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_const_PxTransform_getNormalizedPtr(physx.PxTransform* pvk_RetRef, physx.PxTransform* pvk_this);

}
