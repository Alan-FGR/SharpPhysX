// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Default_PxQuat_(physx.PxQuat* pvk_RetRef);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxQuat_PxQuatPtr_Ctor_PxIDENTITY_(physx.PxQuat* pvk_this, physx.PxIDENTITY pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxQuat_PxQuatPtr_Ctor_float_(physx.PxQuat* pvk_this, float pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxQuat_PxQuatPtr_Ctor_float_float_float_float_(physx.PxQuat* pvk_this, float pvk_nx, float pvk_ny, float pvk_nz, float pvk_nw);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxQuat_PxQuatPtr_Ctor_float_PxVec3_(physx.PxQuat* pvk_this, float pvk_angleRadians, physx.PxVec3* pvk_unitAxis);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxQuat_PxQuatPtr_Ctor_PxQuat_(physx.PxQuat* pvk_this, physx.PxQuat* pvk_v);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxQuat_PxQuatPtr_Ctor_PxMat33_(physx.PxQuat* pvk_this, physx.PxMat33* pvk_m);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxQuat_isIdentityPtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxQuat_isFinitePtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxQuat_isUnitPtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxQuat_isSanePtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxQuat_operator_Ptr_EqualEqual_PxQuat_(physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_const_PxQuat_toRadiansAndUnitAxisPtr_float_PxVec3_(physx.PxQuat* pvk_this, float* pvk_angle, physx.PxVec3* pvk_axis);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxQuat_getAnglePtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxQuat_getAnglePtr_PxQuat_(physx.PxQuat* pvk_this, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxQuat_magnitudeSquaredPtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxQuat_dotPtr_PxQuat_(physx.PxQuat* pvk_this, physx.PxQuat* pvk_v);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_const_PxQuat_getNormalizedPtr(physx.PxQuat* pvk_RetRef, physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxQuat_magnitudePtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_PxQuat_normalizePtr(physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_const_PxQuat_getConjugatePtr(physx.PxQuat* pvk_RetRef, physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxQuat_getImaginaryPartPtr(physx.PxVec3* pvk_RetRef, physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxQuat_getBasisVector0Ptr(physx.PxVec3* pvk_RetRef, physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxQuat_getBasisVector1Ptr(physx.PxVec3* pvk_RetRef, physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxQuat_getBasisVector2Ptr(physx.PxVec3* pvk_RetRef, physx.PxQuat* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxQuat_rotatePtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxQuat* pvk_this, physx.PxVec3* pvk_v);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxQuat_rotateInvPtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxQuat* pvk_this, physx.PxVec3* pvk_v);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQuat* PxQuat_PxQuat_operator_Ptr_Equal_PxQuat_(physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_p);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQuat* PxQuat_PxQuat_operator_Ptr_StarEqual_PxQuat_(physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQuat* PxQuat_PxQuat_operator_Ptr_PlusEqual_PxQuat_(physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQuat* PxQuat_PxQuat_operator_Ptr_MinusEqual_PxQuat_(physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQuat* PxQuat_PxQuat_operator_Ptr_StarEqual_floatC(physx.PxQuat* pvk_lhs, float pvk_s);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_const_PxQuat_operator_Ptr_Star_PxQuat_(physx.PxQuat* pvk_RetRef, physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_const_PxQuat_operator_Ptr_Plus_PxQuat_(physx.PxQuat* pvk_RetRef, physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_const_PxQuat_operator_Ptr_Minus(physx.PxQuat* pvk_RetRef, physx.PxQuat* pvk_lhs);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_const_PxQuat_operator_Ptr_Minus_PxQuat_(physx.PxQuat* pvk_RetRef, physx.PxQuat* pvk_lhs, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQuat_const_PxQuat_operator_Ptr_Star_float_(physx.PxQuat* pvk_RetRef, physx.PxQuat* pvk_lhs, float pvk_r);

}