// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxMathUtils
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxQuatPtr physx_PxQuatPtr_physx_PxShortestRotation_physx_PxVec3Ptr_physx_PxVec3Ptr_(physx.PxVec3Ptr pvk_from, physx.PxVec3Ptr pvk_target);
    
    public static physx.PxQuatPtr PxShortestRotation_New(physx.PxVec3Ptr from, physx.PxVec3Ptr target) {
        physx.PxVec3Ptr pvk_in_from = from;
        physx.PxVec3Ptr pvk_in_target = target;
        return physx_PxQuatPtr_physx_PxShortestRotation_physx_PxVec3Ptr_physx_PxVec3Ptr_(pvk_in_from, pvk_in_target);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxVec3Ptr physx_PxVec3Ptr_physx_PxDiagonalize_physx_PxMat33Ptr_physx_PxQuatPtr_(physx.PxMat33Ptr pvk_m, physx.PxQuatPtr pvk_axes);
    
    public static physx.PxVec3Ptr PxDiagonalize_New(physx.PxMat33Ptr m, physx.PxQuatPtr axes) {
        physx.PxMat33Ptr pvk_in_m = m;
        physx.PxQuatPtr pvk_in_axes = axes;
        return physx_PxVec3Ptr_physx_PxDiagonalize_physx_PxMat33Ptr_physx_PxQuatPtr_(pvk_in_m, pvk_in_axes);
    }
    
}