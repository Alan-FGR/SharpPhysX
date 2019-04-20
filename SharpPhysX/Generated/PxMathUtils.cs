// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxQuat PxShortestRotation(physx.PxVec3 from, physx.PxVec3 target) {
        return PxShortestRotation((physx.PxVec3*)&from, (physx.PxVec3*)&target);
    }

    public static physx.PxQuat PxShortestRotation(physx.PxVec3.Ref from, physx.PxVec3.Ref target) {
        return PxShortestRotation((physx.PxVec3*)(*((IntPtr*)(&from))), (physx.PxVec3*)(*((IntPtr*)(&target))));
    }

    public static physx.PxQuat PxShortestRotation(physx.PxVec3* from, physx.PxVec3* target) {
        physx.PxQuat RetRef;
        physx.PxVec3* pvk_in_from = from;
        physx.PxVec3* pvk_in_target = target;
        PxQuat_PxShortestRotationPtr_PxVec3_PxVec3_(&RetRef, pvk_in_from, pvk_in_target);
        return RetRef;
    }

    public static physx.PxVec3 PxDiagonalize(physx.PxMat33 m, physx.PxQuat axes) {
        return PxDiagonalize((physx.PxMat33*)&m, (physx.PxQuat*)&axes);
    }

    public static physx.PxVec3 PxDiagonalize(physx.PxMat33.Ref m, physx.PxQuat.Ref axes) {
        return PxDiagonalize((physx.PxMat33*)(*((IntPtr*)(&m))), (physx.PxQuat*)(*((IntPtr*)(&axes))));
    }

    public static physx.PxVec3 PxDiagonalize(physx.PxMat33* m, physx.PxQuat* axes) {
        physx.PxVec3 RetRef;
        physx.PxMat33* pvk_in_m = m;
        physx.PxQuat* pvk_in_axes = axes;
        PxVec3_PxDiagonalizePtr_PxMat33_PxQuat_(&RetRef, pvk_in_m, pvk_in_axes);
        return RetRef;
    }
}
