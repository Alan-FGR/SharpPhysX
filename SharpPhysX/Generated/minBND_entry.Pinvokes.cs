// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_SharpPhysX_internal_GetPhysicsVersionPtr();

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern PxSimulationFilterShader PxSimulationFilterShader_SharpPhysX_internal_GetDefaultSimulationFilterShaderPtr();

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFoundationPtr PxFoundationPtr_SharpPhysX_CreateFoundationPtr();

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFoundationPtr PxFoundationPtr_SharpPhysX_CreateFoundationPtr_SharpPhysXErrorFptr_(SharpPhysXErrorFptr pvk_managedErrorCallback);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFoundationPtr PxFoundationPtr_SharpPhysX_CreateFoundationPtr_SharpPhysXErrorFptr_uint_(SharpPhysXErrorFptr pvk_managedErrorCallback, uint pvk_version);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxPhysicsPtr PxPhysicsPtr_SharpPhysX_CreatePhysicsPtr_PxFoundationPtr_(physx.PxFoundationPtr pvk_foundation);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxSceneDescPtr PxSceneDescPtr_SharpPhysX_CreateSceneDescPtr();

}