// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxCollectionPtr PxCollectionPtr_PxCreateCollectionPtr();

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addPtr_PxBasePtr_ulong_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object, ulong pvk_id);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_removePtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxCollectionPtr_containsPtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addIdPtr_PxBasePtr_ulong_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object, ulong pvk_id);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_removeIdPtr_ulong_(physx.PxCollectionPtr pvk_this, ulong pvk_id);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addPtr_PxCollectionPtr_(physx.PxCollectionPtr pvk_this, physx.PxCollectionPtr pvk_collection);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_removePtr_PxCollectionPtr_(physx.PxCollectionPtr pvk_this, physx.PxCollectionPtr pvk_collection);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getNbObjectsPtr(physx.PxCollectionPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBasePtr PxBasePtr_const_PxCollectionPtr_getObjectPtr_uint_(physx.PxCollectionPtr pvk_this, uint pvk_index);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getObjectsPtr_PxBasePtr_uint_uint_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBasePtr PxBasePtr_const_PxCollectionPtr_findPtr_ulong_(physx.PxCollectionPtr pvk_this, ulong pvk_id);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getNbIdsPtr(physx.PxCollectionPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getIdsPtr_ulong_uint_uint_(physx.PxCollectionPtr pvk_this, ulong* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ulong ulong_const_PxCollectionPtr_getIdPtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_releasePtr(physx.PxCollectionPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxCollectionPtr_addPtr_PxBasePtr_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr pvk_object);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getObjectsPtr_PxBasePtr_uint_(physx.PxCollectionPtr pvk_this, physx.PxBasePtr* pvk_userBuffer, uint pvk_bufferSize);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxCollectionPtr_getIdsPtr_ulong_uint_(physx.PxCollectionPtr pvk_this, ulong* pvk_userBuffer, uint pvk_bufferSize);
}
