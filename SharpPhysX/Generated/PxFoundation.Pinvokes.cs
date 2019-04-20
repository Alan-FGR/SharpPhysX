// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

//DBG: FunctionNode PxCreateFoundation L120-121

//DBG: FunctionNode PxGetFoundation L135
//RET nat: PxFoundationPtr, man: physx.PxFoundationPtr, ret: True, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFoundationPtr PxFoundationPtr_PxGetFoundationPtr();

//DBG: FunctionNode PxGetProfilerCallback L150

//DBG: FunctionNode PxSetProfilerCallback L155

//DBG: DeclTree PxProfilerCallback physx::PxProfilerCallback L144
//Skipping DeclTree PxProfilerCallback physx::PxProfilerCallback L144...
//Subclasses using this: 0

//DBG: ClassNode PxFoundation physx::PxFoundation L50-99

//DBG: MethodNode physx::PxFoundation::release L62
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxFoundationPtr, man: physx.PxFoundationPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxFoundationPtr_releasePtr(physx.PxFoundationPtr pvk_this);

//DBG: MethodNode physx::PxFoundation::getErrorCallback L67

//DBG: MethodNode physx::PxFoundation::setErrorLevel L72
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxFoundationPtr, man: physx.PxFoundationPtr, kind: PtrStruct
//PAR nat: physx::PxErrorCode::Enum, man: physx.PxErrorCodeEnum, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxFoundationPtr_setErrorLevelPtr_PxErrorCodeEnum_(physx.PxFoundationPtr pvk_this, physx.PxErrorCodeEnum pvk_mask);

//DBG: MethodNode physx::PxFoundation::getErrorLevel L77
//RET nat: physx::PxErrorCode::Enum, man: physx.PxErrorCodeEnum, ret: True, kind: Value
//PAR nat: PxFoundationPtr, man: physx.PxFoundationPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxErrorCodeEnum PxErrorCodeEnum_const_PxFoundationPtr_getErrorLevelPtr(physx.PxFoundationPtr pvk_this);

//DBG: MethodNode physx::PxFoundation::getAllocatorCallback L82

//DBG: MethodNode physx::PxFoundation::getReportAllocationNames L87
//RET nat: bool, man: bool, ret: True, kind: Value
//PAR nat: PxFoundationPtr, man: physx.PxFoundationPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxFoundationPtr_getReportAllocationNamesPtr(physx.PxFoundationPtr pvk_this);

//DBG: MethodNode physx::PxFoundation::setReportAllocationNames L93
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxFoundationPtr, man: physx.PxFoundationPtr, kind: PtrStruct
//PAR nat: bool, man: bool, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxFoundationPtr_setReportAllocationNamesPtr_bool_(physx.PxFoundationPtr pvk_this, bool pvk_value);

//DBG: MethodNode physx::PxFoundation::operator= L50
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxFoundation::operator= L50

//DBG: MethodNode physx::PxFoundation::setErrorLevel L72
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxFoundationPtr, man: physx.PxFoundationPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxFoundationPtr_setErrorLevelPtr(physx.PxFoundationPtr pvk_this);

//Operators
}
