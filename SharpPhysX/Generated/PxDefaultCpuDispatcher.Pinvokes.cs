// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxDefaultCpuDispatcherPtr PxDefaultCpuDispatcherPtr_PxDefaultCpuDispatcherCreatePtr_uint_(uint pvk_numThreads);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxDefaultCpuDispatcherPtr PxDefaultCpuDispatcherPtr_PxDefaultCpuDispatcherCreatePtr_uint_uint_(uint pvk_numThreads, uint* pvk_affinityMasks);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxDefaultCpuDispatcherPtr_releasePtr(physx.PxDefaultCpuDispatcherPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxDefaultCpuDispatcherPtr_setRunProfiledPtr_bool_(physx.PxDefaultCpuDispatcherPtr pvk_this, bool pvk_runProfiled);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxDefaultCpuDispatcherPtr_getRunProfiledPtr(physx.PxDefaultCpuDispatcherPtr pvk_this);

}
