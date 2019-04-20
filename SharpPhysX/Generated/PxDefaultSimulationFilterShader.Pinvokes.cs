// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

//DBG: FunctionNode physx::PxDefaultSimulationFilterShader L116-123
//RET nat: PxFilterFlagsPtr, man: physx.PxFilterFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: PxFilterObjectAttributes, man: uint, kind: Value
//PAR nat: PxFilterDataPtr, man: physx.PxFilterDataPtr, kind: PtrStruct
//PAR nat: PxFilterObjectAttributes, man: uint, kind: Value
//PAR nat: PxFilterDataPtr, man: physx.PxFilterDataPtr, kind: PtrStruct
//PAR nat: PxPairFlagsPtr, man: physx.PxPairFlagsPtr, kind: PtrStruct
//PAR nat: void*, man: IntPtr, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterFlagsPtr PxFilterFlagsPtr_PxDefaultSimulationFilterShaderPtr_uint_PxFilterDataPtr_uint_PxFilterDataPtr_PxPairFlagsPtr_IntPtr_uint_(uint pvk_attributes0, physx.PxFilterDataPtr pvk_filterData0, uint pvk_attributes1, physx.PxFilterDataPtr pvk_filterData1, physx.PxPairFlagsPtr pvk_pairFlags, IntPtr pvk_constantBlock, uint pvk_constantBlockSize);

//DBG: FunctionNode physx::PxGetGroupCollisionFlag L137
//RET nat: bool, man: bool, ret: True, kind: Value
//PAR nat: PxU16, man: ushort, kind: Value
//PAR nat: PxU16, man: ushort, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxGetGroupCollisionFlagPtr_ushort_ushortCC(ushort pvk_group1, ushort pvk_group2);

//DBG: FunctionNode physx::PxSetGroupCollisionFlag L150
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxU16, man: ushort, kind: Value
//PAR nat: PxU16, man: ushort, kind: Value
//PAR nat: bool, man: bool, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxSetGroupCollisionFlagPtr_ushort_ushort_boolCCC(ushort pvk_group1, ushort pvk_group2, bool pvk_enable);

//DBG: FunctionNode physx::PxGetGroup L163
//RET nat: PxU16, man: ushort, ret: True, kind: Value
//PAR nat: PxActorPtr, man: physx.PxActorPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort ushort_PxGetGroupPtr_PxActorPtr_(physx.PxActorPtr pvk_actor);

//DBG: FunctionNode physx::PxSetGroup L175
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxActorPtr, man: physx.PxActorPtr, kind: PtrStruct
//PAR nat: PxU16, man: ushort, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxSetGroupPtr_PxActorPtr_ushort_C(physx.PxActorPtr pvk_actor, ushort pvk_collisionGroup);

//DBG: FunctionNode physx::PxGetFilterOps L186
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: physx::PxFilterOp::Enum*, man: physx.PxFilterOpEnum*, kind: Value
//PAR nat: physx::PxFilterOp::Enum*, man: physx.PxFilterOpEnum*, kind: Value
//PAR nat: physx::PxFilterOp::Enum*, man: physx.PxFilterOpEnum*, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxGetFilterOpsPtr_PxFilterOpEnum_PxFilterOpEnum_PxFilterOpEnum_(physx.PxFilterOpEnum* pvk_op0, physx.PxFilterOpEnum* pvk_op1, physx.PxFilterOpEnum* pvk_op2);

//DBG: FunctionNode physx::PxSetFilterOps L197
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: physx::PxFilterOp::Enum*, man: physx.PxFilterOpEnum*, kind: Value
//PAR nat: physx::PxFilterOp::Enum*, man: physx.PxFilterOpEnum*, kind: Value
//PAR nat: physx::PxFilterOp::Enum*, man: physx.PxFilterOpEnum*, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxSetFilterOpsPtr_PxFilterOpEnum_PxFilterOpEnum_PxFilterOpEnum_(physx.PxFilterOpEnum* pvk_op0, physx.PxFilterOpEnum* pvk_op1, physx.PxFilterOpEnum* pvk_op2);

//DBG: FunctionNode physx::PxGetFilterBool L206
//RET nat: bool, man: bool, ret: True, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxGetFilterBoolPtr();

//DBG: FunctionNode physx::PxSetFilterBool L215
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: bool, man: bool, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxSetFilterBoolPtr_boolC(bool pvk_enable);

//DBG: FunctionNode physx::PxGetFilterConstants L225
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGroupsMaskPtr, man: physx.PxGroupsMaskPtr, kind: PtrStruct
//PAR nat: PxGroupsMaskPtr, man: physx.PxGroupsMaskPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxGetFilterConstantsPtr_PxGroupsMaskPtr_PxGroupsMaskPtr_(physx.PxGroupsMaskPtr pvk_c0, physx.PxGroupsMaskPtr pvk_c1);

//DBG: FunctionNode physx::PxSetFilterConstants L235
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGroupsMaskPtr, man: physx.PxGroupsMaskPtr, kind: PtrStruct
//PAR nat: PxGroupsMaskPtr, man: physx.PxGroupsMaskPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxSetFilterConstantsPtr_PxGroupsMaskPtr_PxGroupsMaskPtr_(physx.PxGroupsMaskPtr pvk_c0, physx.PxGroupsMaskPtr pvk_c1);

//DBG: FunctionNode physx::PxGetGroupsMask L246
//RET nat: PxGroupsMaskPtr, man: physx.PxGroupsMaskPtr, ret: True, kind: PtrStruct
//PAR nat: PxActorPtr, man: physx.PxActorPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGroupsMaskPtr PxGroupsMaskPtr_PxGetGroupsMaskPtr_PxActorPtr_(physx.PxActorPtr pvk_actor);

//DBG: FunctionNode physx::PxSetGroupsMask L256
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxActorPtr, man: physx.PxActorPtr, kind: PtrStruct
//PAR nat: PxGroupsMaskPtr, man: physx.PxGroupsMaskPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxSetGroupsMaskPtr_PxActorPtr_PxGroupsMaskPtr_(physx.PxActorPtr pvk_actor, physx.PxGroupsMaskPtr pvk_mask);
//Subclasses using this: 0

//DBG: ClassNode PxGroupsMask physx::PxGroupsMask L70-77

//DBG: NewerFreerNode PxGroupsMask physx::PxGroupsMask L70-77
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxGroupsMaskPtr(physx.PxGroupsMaskPtr ptr);

//DBG: PtrWrapperCtorNode physx::PxGroupsMask::PxGroupsMask L73
//RET nat: PxGroupsMaskPtr, man: physx.PxGroupsMaskPtr, ret: True, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGroupsMaskPtr Ctor_PxGroupsMaskPtr_();

//DBG: PtrWrapperCtorNode physx::PxGroupsMask::PxGroupsMask L70
//ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxGroupsMask::PxGroupsMask L70

//DBG: Field: bits0 - 76-76
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxGroupsMaskPtr_GET_bits0(physx.PxGroupsMaskPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxGroupsMaskPtr_SET_bits0(physx.PxGroupsMaskPtr cls, ushort value);

//DBG: Field: bits1 - 76-76
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxGroupsMaskPtr_GET_bits1(physx.PxGroupsMaskPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxGroupsMaskPtr_SET_bits1(physx.PxGroupsMaskPtr cls, ushort value);

//DBG: Field: bits2 - 76-76
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxGroupsMaskPtr_GET_bits2(physx.PxGroupsMaskPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxGroupsMaskPtr_SET_bits2(physx.PxGroupsMaskPtr cls, ushort value);

//DBG: Field: bits3 - 76-76
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxGroupsMaskPtr_GET_bits3(physx.PxGroupsMaskPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxGroupsMaskPtr_SET_bits3(physx.PxGroupsMaskPtr cls, ushort value);

//DBG: MethodNode physx::PxGroupsMask::~PxGroupsMask L74
//ERRORS in MethodNode: Destructor

//DBG: MethodNode physx::PxGroupsMask::operator= L70
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxGroupsMask::operator= L70

//Operators

//DBG: ClassNode PxFilterOp physx::PxFilterOp L84-96
}
