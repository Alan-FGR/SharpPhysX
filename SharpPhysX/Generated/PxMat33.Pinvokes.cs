// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Default_PxMat33_(physx.PxMat33* pvk_RetRef);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat33_PxMat33Ptr_Ctor_PxIDENTITY_(physx.PxMat33* pvk_this, physx.PxIDENTITY pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat33_PxMat33Ptr_Ctor_PxZERO_(physx.PxMat33* pvk_this, physx.PxZERO pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat33_PxMat33Ptr_Ctor_PxVec3_PxVec3_PxVec3_(physx.PxMat33* pvk_this, physx.PxVec3* pvk_col0, physx.PxVec3* pvk_col1, physx.PxVec3* pvk_col2);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat33_PxMat33Ptr_Ctor_float_(physx.PxMat33* pvk_this, float pvk_r);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat33_PxMat33Ptr_Ctor_PxQuat_(physx.PxMat33* pvk_this, physx.PxQuat* pvk_q);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMat33_PxMat33Ptr_Ctor_PxMat33_(physx.PxMat33* pvk_this, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat33* PxMat33_PxMat33_operator_Ptr_Equal_PxMat33_(physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_PxMat33_createDiagonalPtr_PxVec3_(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_this, physx.PxVec3* pvk_d);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxMat33_operator_Ptr_EqualEqual_PxMat33_(physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_m);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_const_PxMat33_getTransposePtr(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_const_PxMat33_getInversePtr(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxMat33_getDeterminantPtr(physx.PxMat33* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_const_PxMat33_operator_Ptr_Minus(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_lhs);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_const_PxMat33_operator_Ptr_Plus_PxMat33_(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_const_PxMat33_operator_Ptr_Minus_PxMat33_(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_const_PxMat33_operator_Ptr_Star_float_(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_lhs, float pvk_scalar);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxMat33_operator_Ptr_Star_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxMat33* pvk_lhs, physx.PxVec3* pvk_vec);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMat33_const_PxMat33_operator_Ptr_Star_PxMat33_(physx.PxMat33* pvk_RetRef, physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat33* PxMat33_PxMat33_operator_Ptr_PlusEqual_PxMat33_(physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat33* PxMat33_PxMat33_operator_Ptr_MinusEqual_PxMat33_(physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat33* PxMat33_PxMat33_operator_Ptr_StarEqual_float_(physx.PxMat33* pvk_lhs, float pvk_scalar);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMat33* PxMat33_PxMat33_operator_Ptr_StarEqual_PxMat33_(physx.PxMat33* pvk_lhs, physx.PxMat33* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxMat33_operator_Ptr_Call_uint_uint_(physx.PxMat33* pvk_lhs, uint pvk_row, uint pvk_col);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float* float_PxMat33_operator_Ptr_Call_uint_uint_(physx.PxMat33* pvk_lhs, uint pvk_row, uint pvk_col);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxMat33_transformPtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxMat33* pvk_this, physx.PxVec3* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxVec3_const_PxMat33_transformTransposePtr_PxVec3_(physx.PxVec3* pvk_RetRef, physx.PxMat33* pvk_this, physx.PxVec3* pvk_other);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float* float_const_PxMat33_frontPtr(physx.PxMat33* pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec3* PxVec3_PxMat33_operator_Ptr_Subscript_uint_(physx.PxMat33* pvk_lhs, uint pvk_num);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec3* PxVec3_const_PxMat33_operator_Ptr_Subscript_uint_(physx.PxMat33* pvk_lhs, uint pvk_num);

}
