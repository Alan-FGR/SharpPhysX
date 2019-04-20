// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxArticulationBasePtr : physx.PxArticulationBasePtr.IPxArticulationBasePtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public enum Enum : int {
            eReducedCoordinate = 0, // eReducedCoordinate = 0
            eMaximumCoordinate = 1, // eMaximumCoordinate = 1
        }

        public IntPtr userData {
            get => PxArticulationBasePtr_GET_userData(this);
            set => PxArticulationBasePtr_SET_userData(this, value);
        }

        public physx.PxScenePtr getScene() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return PxScenePtr_const_PxArticulationBasePtr_getScenePtr(pvk_in_this);
        }

        public void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters=1) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            uint pvk_in_minPositionIters = minPositionIters;
            uint pvk_in_minVelocityIters = minVelocityIters;
            void_PxArticulationBasePtr_setSolverIterationCountsPtr_uint_uint_(pvk_in_this, pvk_in_minPositionIters, pvk_in_minVelocityIters);
        }

        public void getSolverIterationCounts(uint* minPositionIters, uint* minVelocityIters) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            uint* pvk_in_minPositionIters = minPositionIters;
            uint* pvk_in_minVelocityIters = minVelocityIters;
            void_const_PxArticulationBasePtr_getSolverIterationCountsPtr_uint_uint_(pvk_in_this, pvk_in_minPositionIters, pvk_in_minVelocityIters);
        }

        public bool isSleeping() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return bool_const_PxArticulationBasePtr_isSleepingPtr(pvk_in_this);
        }

        public void setSleepThreshold(float threshold) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_threshold = threshold;
            void_PxArticulationBasePtr_setSleepThresholdPtr_float_(pvk_in_this, pvk_in_threshold);
        }

        public float getSleepThreshold() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return float_const_PxArticulationBasePtr_getSleepThresholdPtr(pvk_in_this);
        }

        public void setStabilizationThreshold(float threshold) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_threshold = threshold;
            void_PxArticulationBasePtr_setStabilizationThresholdPtr_float_(pvk_in_this, pvk_in_threshold);
        }

        public float getStabilizationThreshold() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return float_const_PxArticulationBasePtr_getStabilizationThresholdPtr(pvk_in_this);
        }

        public void setWakeCounter(float wakeCounterValue) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_wakeCounterValue = wakeCounterValue;
            void_PxArticulationBasePtr_setWakeCounterPtr_float_(pvk_in_this, pvk_in_wakeCounterValue);
        }

        public float getWakeCounter() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return float_const_PxArticulationBasePtr_getWakeCounterPtr(pvk_in_this);
        }

        public void wakeUp() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            void_PxArticulationBasePtr_wakeUpPtr(pvk_in_this);
        }

        public void putToSleep() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            void_PxArticulationBasePtr_putToSleepPtr(pvk_in_this);
        }

        public physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform* pose) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr pvk_in_parent = parent;
            physx.PxTransform* pvk_in_pose = pose;
            return PxArticulationLinkPtr_PxArticulationBasePtr_createLinkPtr_PxArticulationLinkPtr_PxTransform_(pvk_in_this, pvk_in_parent, pvk_in_pose);
        }

        public uint getNbLinks() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return uint_const_PxArticulationBasePtr_getNbLinksPtr(pvk_in_this);
        }

        public uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_PxArticulationBasePtr_getLinksPtr_PxArticulationLinkPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }

        public void setName(string name) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            string pvk_in_name = name;
            void_PxArticulationBasePtr_setNamePtr_string_(pvk_in_this, pvk_in_name);
        }

        public string getName() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return string_const_PxArticulationBasePtr_getNamePtr(pvk_in_this);
        }

        public physx.PxBounds3 getWorldBounds(float inflation=1.01f) {
            physx.PxBounds3 RetRef;
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_inflation = inflation;
            PxBounds3_const_PxArticulationBasePtr_getWorldBoundsPtr_float_(&RetRef, pvk_in_this, pvk_in_inflation);
            return RetRef;
        }

        public physx.PxAggregatePtr getAggregate() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return PxAggregatePtr_const_PxArticulationBasePtr_getAggregatePtr(pvk_in_this);
        }

        public physx.PxArticulationBasePtr.Enum getType() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return PxArticulationBasePtr_Enum_const_PxArticulationBasePtr_getTypePtr(pvk_in_this);
        }

        public physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform* parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform* childFrame) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr pvk_in_parent = parent;
            physx.PxTransform* pvk_in_parentFrame = parentFrame;
            physx.PxArticulationLinkPtr pvk_in_child = child;
            physx.PxTransform* pvk_in_childFrame = childFrame;
            return PxArticulationJointBasePtr_PxArticulationBasePtr_createArticulationJointPtr_PxArticulationLinkPtr_PxTransform_PxArticulationLinkPtr_PxTransform_(pvk_in_this, pvk_in_parent, pvk_in_parentFrame, pvk_in_child, pvk_in_childFrame);
        }

        public void releaseArticulationJoint(physx.PxArticulationJointBasePtr joint) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationJointBasePtr pvk_in_joint = joint;
            void_PxArticulationBasePtr_releaseArticulationJointPtr_PxArticulationJointBasePtr_(pvk_in_this, pvk_in_joint);
        }

        public void setSolverIterationCounts(uint minPositionIters) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            uint pvk_in_minPositionIters = minPositionIters;
            void_PxArticulationBasePtr_setSolverIterationCountsPtr_uint_(pvk_in_this, pvk_in_minPositionIters);
        }

        public physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform pose) {
            return createLink(parent, (physx.PxTransform*)&pose);
        }

        public physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform.Ref pose) {
            return createLink(parent, (physx.PxTransform*)(*((IntPtr*)(&pose))));
        }

        public uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_PxArticulationBasePtr_getLinksPtr_PxArticulationLinkPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }

        public physx.PxBounds3 getWorldBounds() {
            physx.PxBounds3 RetRef;
            physx.PxArticulationBasePtr pvk_in_this = this;
            PxBounds3_const_PxArticulationBasePtr_getWorldBoundsPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform childFrame) {
            return createArticulationJoint(parent, (physx.PxTransform*)&parentFrame, child, (physx.PxTransform*)&childFrame);
        }

        public physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform.Ref parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform.Ref childFrame) {
            return createArticulationJoint(parent, (physx.PxTransform*)(*((IntPtr*)(&parentFrame))), child, (physx.PxTransform*)(*((IntPtr*)(&childFrame))));
        }
        public static implicit operator physx.PxBasePtr(PxArticulationBasePtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxArticulationBasePtr(physx.PxBasePtr obj) => *(PxArticulationBasePtr*)&obj;

        public void release(){((physx.PxBasePtr)this).release();}
        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}

        public unsafe interface IPxArticulationBasePtr {
            IntPtr userData {get;set;}
            physx.PxScenePtr getScene();
            void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters=1);
            void getSolverIterationCounts(uint* minPositionIters, uint* minVelocityIters);
            bool isSleeping();
            void setSleepThreshold(float threshold);
            float getSleepThreshold();
            void setStabilizationThreshold(float threshold);
            float getStabilizationThreshold();
            void setWakeCounter(float wakeCounterValue);
            float getWakeCounter();
            void wakeUp();
            void putToSleep();
            physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform* pose);
            uint getNbLinks();
            uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize, uint startIndex=0);
            void setName(string name);
            string getName();
            physx.PxBounds3 getWorldBounds(float inflation=1.01f);
            physx.PxAggregatePtr getAggregate();
            physx.PxArticulationBasePtr.Enum getType();
            physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform* parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform* childFrame);
            void releaseArticulationJoint(physx.PxArticulationJointBasePtr joint);
            void setSolverIterationCounts(uint minPositionIters);
            physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform pose);
            physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform.Ref pose);
            uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize);
            physx.PxBounds3 getWorldBounds();
            physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform childFrame);
            physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform.Ref parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform.Ref childFrame);
        }
    }
}
