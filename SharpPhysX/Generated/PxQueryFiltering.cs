// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxQueryFlagsPtr OpPipe_New(physx.PxQueryFlagEnum a, physx.PxQueryFlagEnum b) {
        physx.PxQueryFlagEnum pvk_in_a = a;
        physx.PxQueryFlagEnum pvk_in_b = b;
        return PxQueryFlagsPtr_operator_Ptr_Pipe_PxQueryFlagEnum_PxQueryFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxQueryFlagsPtr OpAnd_New(physx.PxQueryFlagEnum a, physx.PxQueryFlagEnum b) {
        physx.PxQueryFlagEnum pvk_in_a = a;
        physx.PxQueryFlagEnum pvk_in_b = b;
        return PxQueryFlagsPtr_operator_Ptr_Amp_PxQueryFlagEnum_PxQueryFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxQueryFlagsPtr OpTilde_New(physx.PxQueryFlagEnum a) {
        physx.PxQueryFlagEnum pvk_in_a = a;
        return PxQueryFlagsPtr_operator_Ptr_Tilde_PxQueryFlagEnum_(pvk_in_a);
    }

    public enum PxQueryFlagEnum : int {
        eSTATIC = 1,       // eSTATIC = (1<<0)
        eDYNAMIC = 2,      // eDYNAMIC = (1<<1)
        ePREFILTER = 4,    // ePREFILTER = (1<<2)
        ePOSTFILTER = 8,   // ePOSTFILTER = (1<<3)
        eANY_HIT = 16,     // eANY_HIT = (1<<4)
        eNO_BLOCK = 32,    // eNO_BLOCK = (1<<5)
        eRESERVED = 32768, // eRESERVED = (1<<15)
    }

    public enum PxQueryHitTypeEnum : int {
        eNONE = 0,  // eNONE = 0
        eTOUCH = 1, // eTOUCH = 1
        eBLOCK = 2, // eBLOCK = 2
    }

    public unsafe partial struct PxQueryFilterDataPtr {
        private System.IntPtr nativePtr_;

        public static void Free(physx.PxQueryFilterDataPtr ptr){
            Freer_physx_PxQueryFilterDataPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxQueryFilterDataPtr(this);
        }

        public static physx.PxQueryFilterDataPtr New() {
            return Ctor_PxQueryFilterDataPtr_();
        }

        public static physx.PxQueryFilterDataPtr New(physx.PxFilterDataPtr fd, physx.PxQueryFlagsPtr f) {
            physx.PxFilterDataPtr pvk_in_fd = fd;
            physx.PxQueryFlagsPtr pvk_in_f = f;
            return Ctor_PxQueryFilterDataPtr_PxFilterDataPtr_PxQueryFlagsPtr(pvk_in_fd, pvk_in_f);
        }

        public static physx.PxQueryFilterDataPtr New(physx.PxQueryFlagsPtr f) {
            physx.PxQueryFlagsPtr pvk_in_f = f;
            return Ctor_PxQueryFilterDataPtr_PxQueryFlagsPtr(pvk_in_f);
        }

        public physx.PxFilterDataPtr data {
            get => PxQueryFilterDataPtr_GET_data(this);
            set => PxQueryFilterDataPtr_SET_data(this, value);
        }

        public physx.PxQueryFlagsPtr flags {
            get => PxQueryFilterDataPtr_GET_flags(this);
            set => PxQueryFilterDataPtr_SET_flags(this, value);
        }

    }

    public unsafe partial struct PxQueryFilterCallbackPtr {
        private System.IntPtr nativePtr_;

        public physx.PxQueryHitTypeEnum preFilter(physx.PxFilterDataPtr filterData, physx.PxShapePtr shape, physx.PxRigidActorPtr actor, physx.PxHitFlagsPtr queryFlags) {
            physx.PxQueryFilterCallbackPtr pvk_in_this = this;
            physx.PxFilterDataPtr pvk_in_filterData = filterData;
            physx.PxShapePtr pvk_in_shape = shape;
            physx.PxRigidActorPtr pvk_in_actor = actor;
            physx.PxHitFlagsPtr pvk_in_queryFlags = queryFlags;
            return PxQueryHitTypeEnum_PxQueryFilterCallbackPtr_preFilterPtr_PxFilterDataPtr_PxShapePtr_PxRigidActorPtr_PxHitFlagsPtr_(pvk_in_this, pvk_in_filterData, pvk_in_shape, pvk_in_actor, pvk_in_queryFlags);
        }

        public physx.PxQueryHitTypeEnum postFilter(physx.PxFilterDataPtr filterData, physx.PxQueryHitPtr hit) {
            physx.PxQueryFilterCallbackPtr pvk_in_this = this;
            physx.PxFilterDataPtr pvk_in_filterData = filterData;
            physx.PxQueryHitPtr pvk_in_hit = hit;
            return PxQueryHitTypeEnum_PxQueryFilterCallbackPtr_postFilterPtr_PxFilterDataPtr_PxQueryHitPtr_(pvk_in_this, pvk_in_filterData, pvk_in_hit);
        }

    }

}
