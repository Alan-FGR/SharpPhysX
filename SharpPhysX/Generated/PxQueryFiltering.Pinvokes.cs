// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryFlagsPtr PxQueryFlagsPtr_operator_Ptr_Pipe_PxQueryFlagEnum_PxQueryFlagEnum_(physx.PxQueryFlagEnum pvk_a, physx.PxQueryFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryFlagsPtr PxQueryFlagsPtr_operator_Ptr_Amp_PxQueryFlagEnum_PxQueryFlagEnum_(physx.PxQueryFlagEnum pvk_a, physx.PxQueryFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryFlagsPtr PxQueryFlagsPtr_operator_Ptr_Tilde_PxQueryFlagEnum_(physx.PxQueryFlagEnum pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxQueryFilterDataPtr(physx.PxQueryFilterDataPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryFilterDataPtr Ctor_PxQueryFilterDataPtr_();

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryFilterDataPtr Ctor_PxQueryFilterDataPtr_PxFilterDataPtr_PxQueryFlagsPtr(physx.PxFilterDataPtr pvk_fd, physx.PxQueryFlagsPtr pvk_f);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryFilterDataPtr Ctor_PxQueryFilterDataPtr_PxQueryFlagsPtr(physx.PxQueryFlagsPtr pvk_f);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterDataPtr PxQueryFilterDataPtr_GET_data(physx.PxQueryFilterDataPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQueryFilterDataPtr_SET_data(physx.PxQueryFilterDataPtr cls, physx.PxFilterDataPtr value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryFlagsPtr PxQueryFilterDataPtr_GET_flags(physx.PxQueryFilterDataPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxQueryFilterDataPtr_SET_flags(physx.PxQueryFilterDataPtr cls, physx.PxQueryFlagsPtr value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryHitTypeEnum PxQueryHitTypeEnum_PxQueryFilterCallbackPtr_preFilterPtr_PxFilterDataPtr_PxShapePtr_PxRigidActorPtr_PxHitFlagsPtr_(physx.PxQueryFilterCallbackPtr pvk_this, physx.PxFilterDataPtr pvk_filterData, physx.PxShapePtr pvk_shape, physx.PxRigidActorPtr pvk_actor, physx.PxHitFlagsPtr pvk_queryFlags);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxQueryHitTypeEnum PxQueryHitTypeEnum_PxQueryFilterCallbackPtr_postFilterPtr_PxFilterDataPtr_PxQueryHitPtr_(physx.PxQueryFilterCallbackPtr pvk_this, physx.PxFilterDataPtr pvk_filterData, physx.PxQueryHitPtr pvk_hit);

}
