// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxRigidDynamicLockFlagsPtr PxRigidDynamicLockFlagsPtr_operator_Ptr_Pipe_PxRigidDynamicLockFlagEnum_PxRigidDynamicLockFlagEnum_(physx.PxRigidDynamicLockFlagEnum pvk_a, physx.PxRigidDynamicLockFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxRigidDynamicLockFlagsPtr PxRigidDynamicLockFlagsPtr_operator_Ptr_Amp_PxRigidDynamicLockFlagEnum_PxRigidDynamicLockFlagEnum_(physx.PxRigidDynamicLockFlagEnum pvk_a, physx.PxRigidDynamicLockFlagEnum pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxRigidDynamicLockFlagsPtr PxRigidDynamicLockFlagsPtr_operator_Ptr_Tilde_PxRigidDynamicLockFlagEnum_(physx.PxRigidDynamicLockFlagEnum pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setKinematicTargetPtr_PxTransform_(physx.PxRigidDynamicPtr pvk_this, physx.PxTransform* pvk_destination);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxRigidDynamicPtr_getKinematicTargetPtr_PxTransform_(physx.PxRigidDynamicPtr pvk_this, physx.PxTransform* pvk_target);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxRigidDynamicPtr_isSleepingPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setSleepThresholdPtr_float_(physx.PxRigidDynamicPtr pvk_this, float pvk_threshold);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxRigidDynamicPtr_getSleepThresholdPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setStabilizationThresholdPtr_float_(physx.PxRigidDynamicPtr pvk_this, float pvk_threshold);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxRigidDynamicPtr_getStabilizationThresholdPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxRigidDynamicLockFlagsPtr PxRigidDynamicLockFlagsPtr_const_PxRigidDynamicPtr_getRigidDynamicLockFlagsPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setRigidDynamicLockFlagPtr_PxRigidDynamicLockFlagEnum_bool_(physx.PxRigidDynamicPtr pvk_this, physx.PxRigidDynamicLockFlagEnum pvk_flag, bool pvk_value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setRigidDynamicLockFlagsPtr_PxRigidDynamicLockFlagsPtr_(physx.PxRigidDynamicPtr pvk_this, physx.PxRigidDynamicLockFlagsPtr pvk_flags);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setWakeCounterPtr_float_(physx.PxRigidDynamicPtr pvk_this, float pvk_wakeCounterValue);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxRigidDynamicPtr_getWakeCounterPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_wakeUpPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_putToSleepPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setSolverIterationCountsPtr_uint_uint_(physx.PxRigidDynamicPtr pvk_this, uint pvk_minPositionIters, uint pvk_minVelocityIters);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_const_PxRigidDynamicPtr_getSolverIterationCountsPtr_uint_uint_(physx.PxRigidDynamicPtr pvk_this, uint* pvk_minPositionIters, uint* pvk_minVelocityIters);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxRigidDynamicPtr_getContactReportThresholdPtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setContactReportThresholdPtr_float_(physx.PxRigidDynamicPtr pvk_this, float pvk_threshold);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern string string_const_PxRigidDynamicPtr_getConcreteTypeNamePtr(physx.PxRigidDynamicPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxRigidDynamicPtr_setSolverIterationCountsPtr_uint_(physx.PxRigidDynamicPtr pvk_this, uint pvk_minPositionIters);

}
