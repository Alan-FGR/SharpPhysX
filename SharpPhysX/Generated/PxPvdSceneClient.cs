// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {
    public static unsafe partial class pvdsdk {

    }

    public static physx.PxPvdSceneFlagsPtr OpPipe_New(physx.PxPvdSceneFlag a, physx.PxPvdSceneFlag b) {
        physx.PxPvdSceneFlag pvk_in_a = a;
        physx.PxPvdSceneFlag pvk_in_b = b;
        return PxPvdSceneFlagsPtr_operator_Ptr_Pipe_PxPvdSceneFlag_PxPvdSceneFlag_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxPvdSceneFlagsPtr OpAnd_New(physx.PxPvdSceneFlag a, physx.PxPvdSceneFlag b) {
        physx.PxPvdSceneFlag pvk_in_a = a;
        physx.PxPvdSceneFlag pvk_in_b = b;
        return PxPvdSceneFlagsPtr_operator_Ptr_Amp_PxPvdSceneFlag_PxPvdSceneFlag_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxPvdSceneFlagsPtr OpTilde_New(physx.PxPvdSceneFlag a) {
        physx.PxPvdSceneFlag pvk_in_a = a;
        return PxPvdSceneFlagsPtr_operator_Ptr_Tilde_PxPvdSceneFlag_(pvk_in_a);
    }

    public enum PxPvdSceneFlag : int {
        eTRANSMIT_CONTACTS = 1,     // eTRANSMIT_CONTACTS = (1 << 0)
        eTRANSMIT_SCENEQUERIES = 2, // eTRANSMIT_SCENEQUERIES = (1 << 1)
        eTRANSMIT_CONSTRAINTS = 4,  // eTRANSMIT_CONSTRAINTS = (1 << 2)
    }

    public unsafe partial struct PxPvdSceneClientPtr {
        private System.IntPtr nativePtr_;

    }

}
