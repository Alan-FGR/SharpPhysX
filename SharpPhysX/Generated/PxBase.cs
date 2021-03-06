// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxBaseFlagsPtr OpPipe_New(physx.PxBaseFlag a, physx.PxBaseFlag b) {
        physx.PxBaseFlag pvk_in_a = a;
        physx.PxBaseFlag pvk_in_b = b;
        return PxBaseFlagsPtr_operator_Ptr_Pipe_PxBaseFlag_PxBaseFlag_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxBaseFlagsPtr OpAnd_New(physx.PxBaseFlag a, physx.PxBaseFlag b) {
        physx.PxBaseFlag pvk_in_a = a;
        physx.PxBaseFlag pvk_in_b = b;
        return PxBaseFlagsPtr_operator_Ptr_Amp_PxBaseFlag_PxBaseFlag_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxBaseFlagsPtr OpTilde_New(physx.PxBaseFlag a) {
        physx.PxBaseFlag pvk_in_a = a;
        return PxBaseFlagsPtr_operator_Ptr_Tilde_PxBaseFlag_(pvk_in_a);
    }

    public enum PxBaseFlag : int {
        eOWNS_MEMORY = 1,   // eOWNS_MEMORY = (1<<0)
        eIS_RELEASABLE = 2, // eIS_RELEASABLE = (1<<1)
    }

    public unsafe partial struct PxBasePtr : physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public void release() {
            physx.PxBasePtr pvk_in_this = this;
            void_PxBasePtr_releasePtr(pvk_in_this);
        }

        public string getConcreteTypeName() {
            physx.PxBasePtr pvk_in_this = this;
            return string_const_PxBasePtr_getConcreteTypeNamePtr(pvk_in_this);
        }

        public ushort getConcreteType() {
            physx.PxBasePtr pvk_in_this = this;
            return ushort_const_PxBasePtr_getConcreteTypePtr(pvk_in_this);
        }

        public void setBaseFlag(physx.PxBaseFlag flag, bool value) {
            physx.PxBasePtr pvk_in_this = this;
            physx.PxBaseFlag pvk_in_flag = flag;
            bool pvk_in_value = value;
            void_PxBasePtr_setBaseFlagPtr_PxBaseFlag_bool_(pvk_in_this, pvk_in_flag, pvk_in_value);
        }

        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags) {
            physx.PxBasePtr pvk_in_this = this;
            physx.PxBaseFlagsPtr pvk_in_inFlags = inFlags;
            void_PxBasePtr_setBaseFlagsPtr_PxBaseFlagsPtr_(pvk_in_this, pvk_in_inFlags);
        }

        public physx.PxBaseFlagsPtr getBaseFlags_New() {
            physx.PxBasePtr pvk_in_this = this;
            return PxBaseFlagsPtr_const_PxBasePtr_getBaseFlagsPtr(pvk_in_this);
        }

        public bool isReleasable() {
            physx.PxBasePtr pvk_in_this = this;
            return bool_const_PxBasePtr_isReleasablePtr(pvk_in_this);
        }

        public unsafe interface IPxBasePtr {
            void release();
            string getConcreteTypeName();
            ushort getConcreteType();
            void setBaseFlag(physx.PxBaseFlag flag, bool value);
            void setBaseFlags(physx.PxBaseFlagsPtr inFlags);
            physx.PxBaseFlagsPtr getBaseFlags_New();
            bool isReleasable();
        }
    }

}
