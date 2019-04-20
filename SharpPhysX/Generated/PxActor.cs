// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxActorFlagsPtr OpPipe_New(physx.PxActorFlagEnum a, physx.PxActorFlagEnum b) {
        physx.PxActorFlagEnum pvk_in_a = a;
        physx.PxActorFlagEnum pvk_in_b = b;
        return PxActorFlagsPtr_operator_Ptr_Pipe_PxActorFlagEnum_PxActorFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxActorFlagsPtr OpAnd_New(physx.PxActorFlagEnum a, physx.PxActorFlagEnum b) {
        physx.PxActorFlagEnum pvk_in_a = a;
        physx.PxActorFlagEnum pvk_in_b = b;
        return PxActorFlagsPtr_operator_Ptr_Amp_PxActorFlagEnum_PxActorFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxActorFlagsPtr OpTilde_New(physx.PxActorFlagEnum a) {
        physx.PxActorFlagEnum pvk_in_a = a;
        return PxActorFlagsPtr_operator_Ptr_Tilde_PxActorFlagEnum_(pvk_in_a);
    }

    public enum PxActorFlagEnum : int {
        eVISUALIZATION = 1,       // eVISUALIZATION = (1<<0)
        eDISABLE_GRAVITY = 2,     // eDISABLE_GRAVITY = (1<<1)
        eSEND_SLEEP_NOTIFIES = 4, // eSEND_SLEEP_NOTIFIES = (1<<2)
        eDISABLE_SIMULATION = 8,  // eDISABLE_SIMULATION = (1<<3)
    }

    public enum PxActorTypeEnum : int {
        eRIGID_STATIC = 0,               // eRIGID_STATIC
        eRIGID_DYNAMIC = 1,              // eRIGID_DYNAMIC
        eARTICULATION_LINK = 2,          // eARTICULATION_LINK
        eACTOR_COUNT = 3,                // eACTOR_COUNT
        eACTOR_FORCE_DWORD = 2147483647, // eACTOR_FORCE_DWORD = 0x7fffffff
    }

    public unsafe partial struct PxActorPtr : physx.PxActorPtr.IPxActorPtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public IntPtr userData {
            get => PxActorPtr_GET_userData(this);
            set => PxActorPtr_SET_userData(this, value);
        }

        public void release() {
            physx.PxActorPtr pvk_in_this = this;
            void_PxActorPtr_releasePtr(pvk_in_this);
        }

        public physx.PxActorTypeEnum getType() {
            physx.PxActorPtr pvk_in_this = this;
            return PxActorTypeEnum_const_PxActorPtr_getTypePtr(pvk_in_this);
        }

        public physx.PxScenePtr getScene() {
            physx.PxActorPtr pvk_in_this = this;
            return PxScenePtr_const_PxActorPtr_getScenePtr(pvk_in_this);
        }

        public void setName(string name) {
            physx.PxActorPtr pvk_in_this = this;
            string pvk_in_name = name;
            void_PxActorPtr_setNamePtr_string_(pvk_in_this, pvk_in_name);
        }

        public string getName() {
            physx.PxActorPtr pvk_in_this = this;
            return string_const_PxActorPtr_getNamePtr(pvk_in_this);
        }

        public physx.PxBounds3 getWorldBounds(float inflation=1.01f) {
            physx.PxBounds3 RetRef;
            physx.PxActorPtr pvk_in_this = this;
            float pvk_in_inflation = inflation;
            PxBounds3_const_PxActorPtr_getWorldBoundsPtr_float_(&RetRef, pvk_in_this, pvk_in_inflation);
            return RetRef;
        }

        public void setActorFlag(physx.PxActorFlagEnum flag, bool value) {
            physx.PxActorPtr pvk_in_this = this;
            physx.PxActorFlagEnum pvk_in_flag = flag;
            bool pvk_in_value = value;
            void_PxActorPtr_setActorFlagPtr_PxActorFlagEnum_bool_(pvk_in_this, pvk_in_flag, pvk_in_value);
        }

        public void setActorFlags(physx.PxActorFlagsPtr inFlags) {
            physx.PxActorPtr pvk_in_this = this;
            physx.PxActorFlagsPtr pvk_in_inFlags = inFlags;
            void_PxActorPtr_setActorFlagsPtr_PxActorFlagsPtr_(pvk_in_this, pvk_in_inFlags);
        }

        public physx.PxActorFlagsPtr getActorFlags_New() {
            physx.PxActorPtr pvk_in_this = this;
            return PxActorFlagsPtr_const_PxActorPtr_getActorFlagsPtr(pvk_in_this);
        }

        public void setDominanceGroup(byte dominanceGroup) {
            physx.PxActorPtr pvk_in_this = this;
            byte pvk_in_dominanceGroup = dominanceGroup;
            void_PxActorPtr_setDominanceGroupPtr_byte_(pvk_in_this, pvk_in_dominanceGroup);
        }

        public byte getDominanceGroup() {
            physx.PxActorPtr pvk_in_this = this;
            return byte_const_PxActorPtr_getDominanceGroupPtr(pvk_in_this);
        }

        public void setOwnerClient(byte inClient) {
            physx.PxActorPtr pvk_in_this = this;
            byte pvk_in_inClient = inClient;
            void_PxActorPtr_setOwnerClientPtr_byte_(pvk_in_this, pvk_in_inClient);
        }

        public byte getOwnerClient() {
            physx.PxActorPtr pvk_in_this = this;
            return byte_const_PxActorPtr_getOwnerClientPtr(pvk_in_this);
        }

        public physx.PxAggregatePtr getAggregate() {
            physx.PxActorPtr pvk_in_this = this;
            return PxAggregatePtr_const_PxActorPtr_getAggregatePtr(pvk_in_this);
        }

        public physx.PxBounds3 getWorldBounds() {
            physx.PxBounds3 RetRef;
            physx.PxActorPtr pvk_in_this = this;
            PxBounds3_const_PxActorPtr_getWorldBoundsPtr(&RetRef, pvk_in_this);
            return RetRef;
        }
        public static implicit operator physx.PxBasePtr(PxActorPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxActorPtr(physx.PxBasePtr obj) => *(PxActorPtr*)&obj;

        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}

        public unsafe interface IPxActorPtr {
            IntPtr userData {get;set;}
            void release();
            physx.PxActorTypeEnum getType();
            physx.PxScenePtr getScene();
            void setName(string name);
            string getName();
            physx.PxBounds3 getWorldBounds(float inflation=1.01f);
            void setActorFlag(physx.PxActorFlagEnum flag, bool value);
            void setActorFlags(physx.PxActorFlagsPtr inFlags);
            physx.PxActorFlagsPtr getActorFlags_New();
            void setDominanceGroup(byte dominanceGroup);
            byte getDominanceGroup();
            void setOwnerClient(byte inClient);
            byte getOwnerClient();
            physx.PxAggregatePtr getAggregate();
            physx.PxBounds3 getWorldBounds();
        }
    }

}
