// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxPairFlagsPtr PxPairFlagsPtr_operator_Ptr_Pipe_PxPairFlagEnum_PxPairFlagEnum_(physx.PxPairFlagEnum pvk_a, physx.PxPairFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxPairFlagsPtr PxPairFlagsPtr_operator_Ptr_Amp_PxPairFlagEnum_PxPairFlagEnum_(physx.PxPairFlagEnum pvk_a, physx.PxPairFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxPairFlagsPtr PxPairFlagsPtr_operator_Ptr_Tilde_PxPairFlagEnum_(physx.PxPairFlagEnum pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterFlagsPtr PxFilterFlagsPtr_operator_Ptr_Pipe_PxFilterFlagEnum_PxFilterFlagEnum_(physx.PxFilterFlagEnum pvk_a, physx.PxFilterFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterFlagsPtr PxFilterFlagsPtr_operator_Ptr_Amp_PxFilterFlagEnum_PxFilterFlagEnum_(physx.PxFilterFlagEnum pvk_a, physx.PxFilterFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterFlagsPtr PxFilterFlagsPtr_operator_Ptr_Tilde_PxFilterFlagEnum_(physx.PxFilterFlagEnum pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterObjectTypeEnum PxFilterObjectTypeEnum_PxGetFilterObjectTypePtr_uint_(uint pvk_attr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxFilterObjectIsKinematicPtr_uint_(uint pvk_attr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxFilterObjectIsTriggerPtr_uint_(uint pvk_attr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxFilterDataPtr(physx.PxFilterDataPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterDataPtr Ctor_PxFilterDataPtr_PxEMPTY(physx.PxEMPTY pvk__);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterDataPtr Ctor_PxFilterDataPtr_();

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterDataPtr Ctor_PxFilterDataPtr_PxFilterDataPtr(physx.PxFilterDataPtr pvk_fd);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterDataPtr Ctor_PxFilterDataPtr_uint_uint_uint_uint(uint pvk_w0, uint pvk_w1, uint pvk_w2, uint pvk_w3);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxFilterDataPtr_GET_word0(physx.PxFilterDataPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxFilterDataPtr_SET_word0(physx.PxFilterDataPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxFilterDataPtr_GET_word1(physx.PxFilterDataPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxFilterDataPtr_SET_word1(physx.PxFilterDataPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxFilterDataPtr_GET_word2(physx.PxFilterDataPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxFilterDataPtr_SET_word2(physx.PxFilterDataPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxFilterDataPtr_GET_word3(physx.PxFilterDataPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxFilterDataPtr_SET_word3(physx.PxFilterDataPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxFilterDataPtr_setToDefaultPtr(physx.PxFilterDataPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxFilterDataPtr_operator_Ptr_Equal_PxFilterDataPtr_(physx.PxFilterDataPtr pvk_lhs, physx.PxFilterDataPtr pvk_fd);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxFilterDataPtr_operator_Ptr_EqualEqual_PxFilterDataPtr_(physx.PxFilterDataPtr pvk_lhs, physx.PxFilterDataPtr pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxFilterDataPtr_operator_Ptr_ExclaimEqual_PxFilterDataPtr_(physx.PxFilterDataPtr pvk_lhs, physx.PxFilterDataPtr pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterFlagsPtr PxFilterFlagsPtr_PxSimulationFilterCallbackPtr_pairFoundPtr_uint_uint_PxFilterDataPtr_PxActorPtr_PxShapePtr_uint_PxFilterDataPtr_PxActorPtr_PxShapePtr_PxPairFlagsPtr_(physx.PxSimulationFilterCallbackPtr pvk_this, uint pvk_pairID, uint pvk_attributes0, physx.PxFilterDataPtr pvk_filterData0, physx.PxActorPtr pvk_a0, physx.PxShapePtr pvk_s0, uint pvk_attributes1, physx.PxFilterDataPtr pvk_filterData1, physx.PxActorPtr pvk_a1, physx.PxShapePtr pvk_s1, physx.PxPairFlagsPtr pvk_pairFlags);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxSimulationFilterCallbackPtr_pairLostPtr_uint_uint_PxFilterDataPtr_uint_PxFilterDataPtr_bool_(physx.PxSimulationFilterCallbackPtr pvk_this, uint pvk_pairID, uint pvk_attributes0, physx.PxFilterDataPtr pvk_filterData0, uint pvk_attributes1, physx.PxFilterDataPtr pvk_filterData1, bool pvk_objectRemoved);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxSimulationFilterCallbackPtr_statusChangePtr_uint_PxPairFlagsPtr_PxFilterFlagsPtr_(physx.PxSimulationFilterCallbackPtr pvk_this, uint* pvk_pairID, physx.PxPairFlagsPtr pvk_pairFlags, physx.PxFilterFlagsPtr pvk_filterFlags);

}