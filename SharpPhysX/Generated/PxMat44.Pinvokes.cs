// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor(physx.PxMat44* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxIDENTITY_(physx.PxMat44* pvk_this, physx.PxIDENTITY pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxZERO_(physx.PxMat44* pvk_this, physx.PxZERO pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxVec4_PxVec4_PxVec4_PxVec4_(physx.PxMat44* pvk_this, physx.PxVec4* pvk_col0, physx.PxVec4* pvk_col1, physx.PxVec4* pvk_col2, physx.PxVec4* pvk_col3);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_float_(physx.PxMat44* pvk_this, float pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxVec3_PxVec3_PxVec3_PxVec3_(physx.PxMat44* pvk_this, physx.PxVec3* pvk_col0, physx.PxVec3* pvk_col1, physx.PxVec3* pvk_col2, physx.PxVec3* pvk_col3);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxQuat_(physx.PxMat44* pvk_this, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxVec4_(physx.PxMat44* pvk_this, physx.PxVec4* pvk_diagonal);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxMat33_PxVec3_(physx.PxMat44* pvk_this, physx.PxMat33* pvk_axes, physx.PxVec3* pvk_position);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxTransform_(physx.PxMat44* pvk_this, physx.PxTransform* pvk_t);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxMat44_operator_Ptr_EqualEqual_PxMat44_(physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_m);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_PxMat44Ptr_Ctor_PxMat44_(physx.PxMat44* pvk_this, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat44* PxMat44_PxMat44_operator_Ptr_Equal_PxMat44_(physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat44_const_PxMat44_getTransposePtr(physx.PxMat44* pvk_RetRef, physx.PxMat44* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat44_const_PxMat44_operator_Ptr_Minus(physx.PxMat44* pvk_RetRef, physx.PxMat44* pvk_lhs);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat44_const_PxMat44_operator_Ptr_Plus_PxMat44_(physx.PxMat44* pvk_RetRef, physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat44_const_PxMat44_operator_Ptr_Minus_PxMat44_(physx.PxMat44* pvk_RetRef, physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat44_const_PxMat44_operator_Ptr_Star_float_(physx.PxMat44* pvk_RetRef, physx.PxMat44* pvk_lhs, float pvk_scalar);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat44_const_PxMat44_operator_Ptr_Star_PxMat44_(physx.PxMat44* pvk_RetRef, physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat44* PxMat44_PxMat44_operator_Ptr_PlusEqual_PxMat44_(physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat44* PxMat44_PxMat44_operator_Ptr_MinusEqual_PxMat44_(physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat44* PxMat44_PxMat44_operator_Ptr_StarEqual_float_(physx.PxMat44* pvk_lhs, float pvk_scalar);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat44* PxMat44_PxMat44_operator_Ptr_StarEqual_PxMat44_(physx.PxMat44* pvk_lhs, physx.PxMat44* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxMat44_operator_Ptr_Call_uint_uint_(physx.PxMat44* pvk_lhs, uint pvk_row, uint pvk_col);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float* float_PxMat44_operator_Ptr_Call_uint_uint_(physx.PxMat44* pvk_lhs, uint pvk_row, uint pvk_col);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec4_const_PxMat44_transformPtr_PxVec4_(physx.PxVec4* pvk_RetRef, physx.PxMat44* pvk_this, physx.PxVec4* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxMat44_transformPtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxMat44* pvk_this, physx.PxVec3* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec4_const_PxMat44_rotatePtr_PxVec4_(physx.PxVec4* pvk_RetRef, physx.PxMat44* pvk_this, physx.PxVec4* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxMat44_rotatePtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxMat44* pvk_this, physx.PxVec3* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxMat44_getBasisPtr_int_(physx.PxVec3* pvk_RetRef, physx.PxMat44* pvk_this, int pvk_num);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxMat44_getPositionPtr(physx.PxVec3* pvk_RetRef, physx.PxMat44* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_setPositionPtr_PxVec3_(physx.PxMat44* pvk_this, physx.PxVec3* pvk_position);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float* float_const_PxMat44_frontPtr(physx.PxMat44* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec4* PxVec4_PxMat44_operator_Ptr_Subscript_uint_(physx.PxMat44* pvk_lhs, uint pvk_num);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec4* PxVec4_const_PxMat44_operator_Ptr_Subscript_uint_(physx.PxMat44* pvk_lhs, uint pvk_num);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat44_scalePtr_PxVec4_(physx.PxMat44* pvk_this, physx.PxVec4* pvk_p);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat44_const_PxMat44_inverseRTPtr(physx.PxMat44* pvk_RetRef, physx.PxMat44* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxMat44_isFinitePtr(physx.PxMat44* pvk_this);

}
