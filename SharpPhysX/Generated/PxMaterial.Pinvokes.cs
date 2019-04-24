// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMaterialFlagsPtr PxMaterialFlagsPtr_operator_Ptr_Pipe_PxMaterialFlagEnum_PxMaterialFlagEnum_(physx.PxMaterialFlagEnum pvk_a, physx.PxMaterialFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMaterialFlagsPtr PxMaterialFlagsPtr_operator_Ptr_Amp_PxMaterialFlagEnum_PxMaterialFlagEnum_(physx.PxMaterialFlagEnum pvk_a, physx.PxMaterialFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMaterialFlagsPtr PxMaterialFlagsPtr_operator_Ptr_Tilde_PxMaterialFlagEnum_(physx.PxMaterialFlagEnum pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern IntPtr PxMaterialPtr_GET_userData(physx.PxMaterialPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMaterialPtr_SET_userData(physx.PxMaterialPtr cls, IntPtr value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_releasePtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxMaterialPtr_getReferenceCountPtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_acquireReferencePtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_setDynamicFrictionPtr_float_(physx.PxMaterialPtr pvk_this, float pvk_coef);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxMaterialPtr_getDynamicFrictionPtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_setStaticFrictionPtr_float_(physx.PxMaterialPtr pvk_this, float pvk_coef);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxMaterialPtr_getStaticFrictionPtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_setRestitutionPtr_float_(physx.PxMaterialPtr pvk_this, float pvk_rest);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxMaterialPtr_getRestitutionPtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_setFlagPtr_PxMaterialFlagEnum_bool_(physx.PxMaterialPtr pvk_this, physx.PxMaterialFlagEnum pvk_flag, bool pvk__2);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_setFlagsPtr_PxMaterialFlagsPtr_(physx.PxMaterialPtr pvk_this, physx.PxMaterialFlagsPtr pvk_inFlags);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMaterialFlagsPtr PxMaterialFlagsPtr_const_PxMaterialPtr_getFlagsPtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_setFrictionCombineModePtr_PxCombineModeEnum_(physx.PxMaterialPtr pvk_this, physx.PxCombineModeEnum pvk_combMode);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxCombineModeEnum PxCombineModeEnum_const_PxMaterialPtr_getFrictionCombineModePtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxMaterialPtr_setRestitutionCombineModePtr_PxCombineModeEnum_(physx.PxMaterialPtr pvk_this, physx.PxCombineModeEnum pvk_combMode);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxCombineModeEnum PxCombineModeEnum_const_PxMaterialPtr_getRestitutionCombineModePtr(physx.PxMaterialPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern string string_const_PxMaterialPtr_getConcreteTypeNamePtr(physx.PxMaterialPtr pvk_this);

}