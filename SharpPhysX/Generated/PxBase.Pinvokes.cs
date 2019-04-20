// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

//DBG: FunctionNode physx::getBinaryMetaData_PxBase L188
//SKIPPING UNDECLARED FRIEND

//DBG: FunctionNode physx::operator| L64
//physx::operator| static physx.PxBaseFlagsPtr OpPipe_New(physx.PxBaseFlagEnum a, physx.PxBaseFlagEnum b) will also be bound as member operator
//RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
//PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_operator_Ptr_Pipe_PxBaseFlagEnum_PxBaseFlagEnum_(physx.PxBaseFlagEnum pvk_a, physx.PxBaseFlagEnum pvk_b);

//DBG: FunctionNode physx::operator& L64
//physx::operator& static physx.PxBaseFlagsPtr OpAnd_New(physx.PxBaseFlagEnum a, physx.PxBaseFlagEnum b) will also be bound as member operator
//RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
//PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_operator_Ptr_Amp_PxBaseFlagEnum_PxBaseFlagEnum_(physx.PxBaseFlagEnum pvk_a, physx.PxBaseFlagEnum pvk_b);

//DBG: FunctionNode physx::operator~ L64
//physx::operator~ static physx.PxBaseFlagsPtr OpTilde_New(physx.PxBaseFlagEnum a) will also be bound as member operator
//RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_operator_Ptr_Tilde_PxBaseFlagEnum_(physx.PxBaseFlagEnum pvk_a);

//DBG: ClassNode PxBaseFlag physx::PxBaseFlag L54-61
//Subclasses using this: 20

//DBG: ClassNode PxBase physx::PxBase L73-194

//DBG: DeclNode is physx::PxBase::is L101

//DBG: DeclNode is physx::PxBase::is L111

//DBG: DeclNode typeMatch physx::PxBase::typeMatch L180

//DBG: DeclNode  physx::PxBase L188

//DBG: MethodNode physx::PxBase::release L85
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBasePtr_releasePtr(physx.PxBasePtr pvk_this);

//DBG: MethodNode physx::PxBase::getConcreteTypeName L91
//RET nat: char*, man: string, ret: True, kind: Value
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern string string_const_PxBasePtr_getConcreteTypeNamePtr(physx.PxBasePtr pvk_this);

//DBG: MethodNode physx::PxBase::is L101

//DBG: MethodNode physx::PxBase::is L111

//DBG: MethodNode physx::PxBase::getConcreteType L119
//RET nat: PxType, man: ushort, ret: True, kind: Value
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort ushort_const_PxBasePtr_getConcreteTypePtr(physx.PxBasePtr pvk_this);

//DBG: MethodNode physx::PxBase::setBaseFlag L127
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
//PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
//PAR nat: bool, man: bool, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBasePtr_setBaseFlagPtr_PxBaseFlagEnum_bool_(physx.PxBasePtr pvk_this, physx.PxBaseFlagEnum pvk_flag, bool pvk_value);

//DBG: MethodNode physx::PxBase::setBaseFlags L136
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
//PAR nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxBasePtr_setBaseFlagsPtr_PxBaseFlagsPtr_(physx.PxBasePtr pvk_this, physx.PxBaseFlagsPtr pvk_inFlags);

//DBG: MethodNode physx::PxBase::getBaseFlags L145
//RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBaseFlagsPtr PxBaseFlagsPtr_const_PxBasePtr_getBaseFlagsPtr(physx.PxBasePtr pvk_this);

//DBG: MethodNode physx::PxBase::isReleasable L156
//RET nat: bool, man: bool, ret: True, kind: Value
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxBasePtr_isReleasablePtr(physx.PxBasePtr pvk_this);

//DBG: MethodNode physx::PxBase::operator= L73
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxBase::operator= L73
//INTERFACES
//Skipping UNPARSED* is(). Errors: 
//Skipping UNPARSED* isConst(). Errors: 

//Operators

//DBG: DeclNode PxType physx::PxType L49

//DBG: DeclNode PxBaseFlags physx::PxBaseFlags L63
}
