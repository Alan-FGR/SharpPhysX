// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxAggregatePtr : physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public void release() {
            physx.PxAggregatePtr pvk_in_this = this;
            void_PxAggregatePtr_releasePtr(pvk_in_this);
        }

        public bool removeActor(physx.PxActorPtr actor) {
            physx.PxAggregatePtr pvk_in_this = this;
            physx.PxActorPtr pvk_in_actor = actor;
            return bool_PxAggregatePtr_removeActorPtr_PxActorPtr_(pvk_in_this, pvk_in_actor);
        }

        public bool addArticulation(physx.PxArticulationBasePtr articulation) {
            physx.PxAggregatePtr pvk_in_this = this;
            physx.PxArticulationBasePtr pvk_in_articulation = articulation;
            return bool_PxAggregatePtr_addArticulationPtr_PxArticulationBasePtr_(pvk_in_this, pvk_in_articulation);
        }

        public bool removeArticulation(physx.PxArticulationBasePtr articulation) {
            physx.PxAggregatePtr pvk_in_this = this;
            physx.PxArticulationBasePtr pvk_in_articulation = articulation;
            return bool_PxAggregatePtr_removeArticulationPtr_PxArticulationBasePtr_(pvk_in_this, pvk_in_articulation);
        }

        public uint getNbActors() {
            physx.PxAggregatePtr pvk_in_this = this;
            return uint_const_PxAggregatePtr_getNbActorsPtr(pvk_in_this);
        }

        public uint getMaxNbActors() {
            physx.PxAggregatePtr pvk_in_this = this;
            return uint_const_PxAggregatePtr_getMaxNbActorsPtr(pvk_in_this);
        }

        public uint getActors(physx.PxActorPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxAggregatePtr pvk_in_this = this;
            physx.PxActorPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_PxAggregatePtr_getActorsPtr_PxActorPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }

        public physx.PxScenePtr getScene() {
            physx.PxAggregatePtr pvk_in_this = this;
            return PxScenePtr_PxAggregatePtr_getScenePtr(pvk_in_this);
        }

        public bool getSelfCollision() {
            physx.PxAggregatePtr pvk_in_this = this;
            return bool_const_PxAggregatePtr_getSelfCollisionPtr(pvk_in_this);
        }

        public string getConcreteTypeName() {
            physx.PxAggregatePtr pvk_in_this = this;
            return string_const_PxAggregatePtr_getConcreteTypeNamePtr(pvk_in_this);
        }

        public bool addActor(physx.PxActorPtr actor) {
            physx.PxAggregatePtr pvk_in_this = this;
            physx.PxActorPtr pvk_in_actor = actor;
            return bool_PxAggregatePtr_addActorPtr_PxActorPtr_(pvk_in_this, pvk_in_actor);
        }

        public uint getActors(physx.PxActorPtr* userBuffer, uint bufferSize) {
            physx.PxAggregatePtr pvk_in_this = this;
            physx.PxActorPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_PxAggregatePtr_getActorsPtr_PxActorPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        public static implicit operator physx.PxBasePtr(PxAggregatePtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxAggregatePtr(physx.PxBasePtr obj) => *(PxAggregatePtr*)&obj;

        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }
}
