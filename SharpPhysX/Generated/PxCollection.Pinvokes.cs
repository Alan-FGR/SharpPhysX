// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

//DBG: FunctionNode PxCreateCollection L275
//RET nat: PxCollectionPtr, man: physx.PxCollectionPtr, ret: True, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxCollectionPtr PxCollectionPtr_PxCreateCollectionPtr();
//Subclasses using this: 0

//DBG: ClassNode PxCollection physx::PxCollection L105-258

//DBG: MethodNode physx::PxCollection::add L122
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
//PAR nat: PxSerialObjectId, man: ulong, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addPtr_PxBasePtr_ulong_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object, ulong pvk_id);

//DBG: MethodNode physx::PxCollection::remove L131
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_removePtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

//DBG: MethodNode physx::PxCollection::contains L139
//RET nat: bool, man: bool, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxCollectionPtr_containsPtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

//DBG: MethodNode physx::PxCollection::addId L151
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
//PAR nat: PxSerialObjectId, man: ulong, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addIdPtr_PxBasePtr_ulong_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object, ulong pvk_id);

//DBG: MethodNode physx::PxCollection::removeId L160
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxSerialObjectId, man: ulong, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_removeIdPtr_ulong_(physx.PxCollectionPtr pvk_this, ulong pvk_id);

//DBG: MethodNode physx::PxCollection::add L170
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addPtr_PxCollectionPtr_(physx.PxCollectionPtr pvk_this, physx.PxCollectionPtr pvk_collection);

//DBG: MethodNode physx::PxCollection::remove L180
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_removePtr_PxCollectionPtr_(physx.PxCollectionPtr pvk_this, physx.PxCollectionPtr pvk_collection);

//DBG: MethodNode physx::PxCollection::getNbObjects L187
//RET nat: PxU32, man: uint, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getNbObjectsPtr(physx.PxCollectionPtr pvk_this);

//DBG: MethodNode physx::PxCollection::getObject L195
//RET nat: PxBasePtr, man: physx.PxBasePtr, ret: True, kind: PtrStruct
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxU32, man: uint, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBasePtr PxBasePtr_const_PxCollectionPtr_getObjectPtr_uint_(physx.PxCollectionPtr pvk_this, uint pvk_index);

//DBG: MethodNode physx::PxCollection::getObjects L205
//RET nat: PxU32, man: uint, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr*, man: physx.PxBasePtr*, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getObjectsPtr_PxBasePtr_uint_uint_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);

//DBG: MethodNode physx::PxCollection::find L215
//RET nat: PxBasePtr, man: physx.PxBasePtr, ret: True, kind: PtrStruct
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxSerialObjectId, man: ulong, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBasePtr PxBasePtr_const_PxCollectionPtr_findPtr_ulong_(physx.PxCollectionPtr pvk_this, ulong pvk_id);

//DBG: MethodNode physx::PxCollection::getNbIds L222
//RET nat: PxU32, man: uint, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getNbIdsPtr(physx.PxCollectionPtr pvk_this);

//DBG: MethodNode physx::PxCollection::getIds L232
//RET nat: PxU32, man: uint, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxSerialObjectId*, man: ulong*, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getIdsPtr_ulong_uint_uint_(physx.PxCollectionPtr pvk_this, ulong* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);

//DBG: MethodNode physx::PxCollection::getId L242
//RET nat: PxSerialObjectId, man: ulong, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ulong ulong_const_PxCollectionPtr_getIdPtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

//DBG: MethodNode physx::PxCollection::release L253
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_releasePtr(physx.PxCollectionPtr pvk_this);

//DBG: MethodNode physx::PxCollection::operator= L105
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxCollection::operator= L105

//DBG: MethodNode physx::PxCollection::add L122
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addPtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

//DBG: MethodNode physx::PxCollection::getObjects L205
//RET nat: PxU32, man: uint, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxBasePtr*, man: physx.PxBasePtr*, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getObjectsPtr_PxBasePtr_uint_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr* pvk_userBuffer, uint pvk_bufferSize);

//DBG: MethodNode physx::PxCollection::getIds L232
//RET nat: PxU32, man: uint, ret: True, kind: Value
//PAR nat: PxCollectionPtr, man: physx.PxCollectionPtr, kind: PtrStruct
//PAR nat: PxSerialObjectId*, man: ulong*, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getIdsPtr_ulong_uint_(physx.PxCollectionPtr pvk_this, ulong* pvk_userBuffer, uint pvk_bufferSize);

//Operators
}
