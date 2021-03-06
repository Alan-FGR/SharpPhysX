// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public enum PxBroadPhaseType : int {
        eSAP = 0,  // eSAP
        eMBP = 1,  // eMBP
        eABP = 2,  // eABP
        eGPU = 3,  // eGPU
        eLAST = 4, // eLAST
    }

    public unsafe partial struct PxBroadPhaseCallbackPtr {
        private System.IntPtr nativePtr_;

        public void onObjectOutOfBounds(physx.PxShapePtr shape, physx.PxActorPtr actor) {
            physx.PxBroadPhaseCallbackPtr pvk_in_this = this;
            physx.PxShapePtr pvk_in_shape = shape;
            physx.PxActorPtr pvk_in_actor = actor;
            void_PxBroadPhaseCallbackPtr_onObjectOutOfBoundsPtr_PxShapePtr_PxActorPtr_(pvk_in_this, pvk_in_shape, pvk_in_actor);
        }

        public void onObjectOutOfBounds(physx.PxAggregatePtr aggregate) {
            physx.PxBroadPhaseCallbackPtr pvk_in_this = this;
            physx.PxAggregatePtr pvk_in_aggregate = aggregate;
            void_PxBroadPhaseCallbackPtr_onObjectOutOfBoundsPtr_PxAggregatePtr_(pvk_in_this, pvk_in_aggregate);
        }

    }

    public unsafe partial struct PxBroadPhaseRegionPtr {
        private System.IntPtr nativePtr_;

        public static physx.PxBroadPhaseRegionPtr New(){
            return Newer_physx_PxBroadPhaseRegionPtr();
        }
        public static void Free(physx.PxBroadPhaseRegionPtr ptr){
            Freer_physx_PxBroadPhaseRegionPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxBroadPhaseRegionPtr(this);
        }

        public physx.PxBounds3 bounds {
            get { physx.PxBounds3 GetRetRef; PxBroadPhaseRegionPtr_GET_bounds(this, &GetRetRef); return GetRetRef; }
            set => PxBroadPhaseRegionPtr_SET_bounds(this, value);
        }

        public IntPtr userData {
            get => PxBroadPhaseRegionPtr_GET_userData(this);
            set => PxBroadPhaseRegionPtr_SET_userData(this, value);
        }

    }

    public unsafe partial struct PxBroadPhaseRegionInfoPtr {
        private System.IntPtr nativePtr_;

        public static physx.PxBroadPhaseRegionInfoPtr New(){
            return Newer_physx_PxBroadPhaseRegionInfoPtr();
        }
        public static void Free(physx.PxBroadPhaseRegionInfoPtr ptr){
            Freer_physx_PxBroadPhaseRegionInfoPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxBroadPhaseRegionInfoPtr(this);
        }

        public physx.PxBroadPhaseRegionPtr region {
            get => PxBroadPhaseRegionInfoPtr_GET_region(this);
            set => PxBroadPhaseRegionInfoPtr_SET_region(this, value);
        }

        public uint nbStaticObjects {
            get => PxBroadPhaseRegionInfoPtr_GET_nbStaticObjects(this);
            set => PxBroadPhaseRegionInfoPtr_SET_nbStaticObjects(this, value);
        }

        public uint nbDynamicObjects {
            get => PxBroadPhaseRegionInfoPtr_GET_nbDynamicObjects(this);
            set => PxBroadPhaseRegionInfoPtr_SET_nbDynamicObjects(this, value);
        }

        public bool active {
            get => PxBroadPhaseRegionInfoPtr_GET_active(this);
            set => PxBroadPhaseRegionInfoPtr_SET_active(this, value);
        }

        public bool overlap {
            get => PxBroadPhaseRegionInfoPtr_GET_overlap(this);
            set => PxBroadPhaseRegionInfoPtr_SET_overlap(this, value);
        }

    }

    public unsafe partial struct PxBroadPhaseCapsPtr {
        private System.IntPtr nativePtr_;

        public static physx.PxBroadPhaseCapsPtr New(){
            return Newer_physx_PxBroadPhaseCapsPtr();
        }
        public static void Free(physx.PxBroadPhaseCapsPtr ptr){
            Freer_physx_PxBroadPhaseCapsPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxBroadPhaseCapsPtr(this);
        }

        public uint maxNbRegions {
            get => PxBroadPhaseCapsPtr_GET_maxNbRegions(this);
            set => PxBroadPhaseCapsPtr_SET_maxNbRegions(this, value);
        }

        public uint maxNbObjects {
            get => PxBroadPhaseCapsPtr_GET_maxNbObjects(this);
            set => PxBroadPhaseCapsPtr_SET_maxNbObjects(this, value);
        }

        public bool needsPredefinedBounds {
            get => PxBroadPhaseCapsPtr_GET_needsPredefinedBounds(this);
            set => PxBroadPhaseCapsPtr_SET_needsPredefinedBounds(this, value);
        }

    }
}
