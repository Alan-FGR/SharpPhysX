// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_operator_Ptr_Pipe_PxBaseFlagEnum_PxBaseFlagEnum_(physx.PxBaseFlagEnum pvk_a, physx.PxBaseFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_operator_Ptr_Amp_PxBaseFlagEnum_PxBaseFlagEnum_(physx.PxBaseFlagEnum pvk_a, physx.PxBaseFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_operator_Ptr_Tilde_PxBaseFlagEnum_(physx.PxBaseFlagEnum pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBasePtr_releasePtr(physx.PxBasePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern string string_const_PxBasePtr_getConcreteTypeNamePtr(physx.PxBasePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort ushort_const_PxBasePtr_getConcreteTypePtr(physx.PxBasePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBasePtr_setBaseFlagPtr_PxBaseFlagEnum_bool_(physx.PxBasePtr pvk_this, physx.PxBaseFlagEnum pvk_flag, bool pvk_value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBasePtr_setBaseFlagsPtr_PxBaseFlagsPtr_(physx.PxBasePtr pvk_this, physx.PxBaseFlagsPtr pvk_inFlags);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_const_PxBasePtr_getBaseFlagsPtr(physx.PxBasePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBasePtr_isReleasablePtr(physx.PxBasePtr pvk_this);

}
