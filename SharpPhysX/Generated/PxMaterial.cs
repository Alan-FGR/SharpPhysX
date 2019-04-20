// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxMaterialFlagsPtr OpPipe_New(physx.PxMaterialFlagEnum a, physx.PxMaterialFlagEnum b) {
        physx.PxMaterialFlagEnum pvk_in_a = a;
        physx.PxMaterialFlagEnum pvk_in_b = b;
        return PxMaterialFlagsPtr_operator_Ptr_Pipe_PxMaterialFlagEnum_PxMaterialFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxMaterialFlagsPtr OpAnd_New(physx.PxMaterialFlagEnum a, physx.PxMaterialFlagEnum b) {
        physx.PxMaterialFlagEnum pvk_in_a = a;
        physx.PxMaterialFlagEnum pvk_in_b = b;
        return PxMaterialFlagsPtr_operator_Ptr_Amp_PxMaterialFlagEnum_PxMaterialFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxMaterialFlagsPtr OpTilde_New(physx.PxMaterialFlagEnum a) {
        physx.PxMaterialFlagEnum pvk_in_a = a;
        return PxMaterialFlagsPtr_operator_Ptr_Tilde_PxMaterialFlagEnum_(pvk_in_a);
    }

    public enum PxMaterialFlagEnum : int {
        eDISABLE_FRICTION = 1,        // eDISABLE_FRICTION = 1 << 0
        eDISABLE_STRONG_FRICTION = 2, // eDISABLE_STRONG_FRICTION = 1 << 1
    }

    public enum PxCombineModeEnum : int {
        eAVERAGE = 0,         // eAVERAGE = 0
        eMIN = 1,             // eMIN = 1
        eMULTIPLY = 2,        // eMULTIPLY = 2
        eMAX = 3,             // eMAX = 3
        eN_VALUES = 4,        // eN_VALUES = 4
        ePAD_32 = 2147483647, // ePAD_32 = 0x7fffffff
    }

    public unsafe partial struct PxMaterialPtr : physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public IntPtr userData {
            get => PxMaterialPtr_GET_userData(this);
            set => PxMaterialPtr_SET_userData(this, value);
        }

        public void release() {
            physx.PxMaterialPtr pvk_in_this = this;
            void_PxMaterialPtr_releasePtr(pvk_in_this);
        }

        public uint getReferenceCount() {
            physx.PxMaterialPtr pvk_in_this = this;
            return uint_const_PxMaterialPtr_getReferenceCountPtr(pvk_in_this);
        }

        public void acquireReference() {
            physx.PxMaterialPtr pvk_in_this = this;
            void_PxMaterialPtr_acquireReferencePtr(pvk_in_this);
        }

        public void setDynamicFriction(float coef) {
            physx.PxMaterialPtr pvk_in_this = this;
            float pvk_in_coef = coef;
            void_PxMaterialPtr_setDynamicFrictionPtr_float_(pvk_in_this, pvk_in_coef);
        }

        public float getDynamicFriction() {
            physx.PxMaterialPtr pvk_in_this = this;
            return float_const_PxMaterialPtr_getDynamicFrictionPtr(pvk_in_this);
        }

        public void setStaticFriction(float coef) {
            physx.PxMaterialPtr pvk_in_this = this;
            float pvk_in_coef = coef;
            void_PxMaterialPtr_setStaticFrictionPtr_float_(pvk_in_this, pvk_in_coef);
        }

        public float getStaticFriction() {
            physx.PxMaterialPtr pvk_in_this = this;
            return float_const_PxMaterialPtr_getStaticFrictionPtr(pvk_in_this);
        }

        public void setRestitution(float rest) {
            physx.PxMaterialPtr pvk_in_this = this;
            float pvk_in_rest = rest;
            void_PxMaterialPtr_setRestitutionPtr_float_(pvk_in_this, pvk_in_rest);
        }

        public float getRestitution() {
            physx.PxMaterialPtr pvk_in_this = this;
            return float_const_PxMaterialPtr_getRestitutionPtr(pvk_in_this);
        }

        public void setFlag(physx.PxMaterialFlagEnum flag, bool _2) {
            physx.PxMaterialPtr pvk_in_this = this;
            physx.PxMaterialFlagEnum pvk_in_flag = flag;
            bool pvk_in__2 = _2;
            void_PxMaterialPtr_setFlagPtr_PxMaterialFlagEnum_bool_(pvk_in_this, pvk_in_flag, pvk_in__2);
        }

        public void setFlags(physx.PxMaterialFlagsPtr inFlags) {
            physx.PxMaterialPtr pvk_in_this = this;
            physx.PxMaterialFlagsPtr pvk_in_inFlags = inFlags;
            void_PxMaterialPtr_setFlagsPtr_PxMaterialFlagsPtr_(pvk_in_this, pvk_in_inFlags);
        }

        public physx.PxMaterialFlagsPtr getFlags_New() {
            physx.PxMaterialPtr pvk_in_this = this;
            return PxMaterialFlagsPtr_const_PxMaterialPtr_getFlagsPtr(pvk_in_this);
        }

        public void setFrictionCombineMode(physx.PxCombineModeEnum combMode) {
            physx.PxMaterialPtr pvk_in_this = this;
            physx.PxCombineModeEnum pvk_in_combMode = combMode;
            void_PxMaterialPtr_setFrictionCombineModePtr_PxCombineModeEnum_(pvk_in_this, pvk_in_combMode);
        }

        public physx.PxCombineModeEnum getFrictionCombineMode() {
            physx.PxMaterialPtr pvk_in_this = this;
            return PxCombineModeEnum_const_PxMaterialPtr_getFrictionCombineModePtr(pvk_in_this);
        }

        public void setRestitutionCombineMode(physx.PxCombineModeEnum combMode) {
            physx.PxMaterialPtr pvk_in_this = this;
            physx.PxCombineModeEnum pvk_in_combMode = combMode;
            void_PxMaterialPtr_setRestitutionCombineModePtr_PxCombineModeEnum_(pvk_in_this, pvk_in_combMode);
        }

        public physx.PxCombineModeEnum getRestitutionCombineMode() {
            physx.PxMaterialPtr pvk_in_this = this;
            return PxCombineModeEnum_const_PxMaterialPtr_getRestitutionCombineModePtr(pvk_in_this);
        }

        public string getConcreteTypeName() {
            physx.PxMaterialPtr pvk_in_this = this;
            return string_const_PxMaterialPtr_getConcreteTypeNamePtr(pvk_in_this);
        }

        public static implicit operator physx.PxBasePtr(PxMaterialPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxMaterialPtr(physx.PxBasePtr obj) => *(PxMaterialPtr*)&obj;

        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }

}
