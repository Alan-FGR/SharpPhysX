// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxArticulationDriveCachePtr {
        private System.IntPtr nativePtr_;

    }

    public unsafe partial struct PxArticulationPtr : physx.PxArticulationBasePtr.IPxArticulationBasePtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public void release() {
            physx.PxArticulationPtr pvk_in_this = this;
            void_PxArticulationPtr_releasePtr(pvk_in_this);
        }

        public void setMaxProjectionIterations(uint iterations) {
            physx.PxArticulationPtr pvk_in_this = this;
            uint pvk_in_iterations = iterations;
            void_PxArticulationPtr_setMaxProjectionIterationsPtr_uint_(pvk_in_this, pvk_in_iterations);
        }

        public uint getMaxProjectionIterations() {
            physx.PxArticulationPtr pvk_in_this = this;
            return uint_const_PxArticulationPtr_getMaxProjectionIterationsPtr(pvk_in_this);
        }

        public void setSeparationTolerance(float tolerance) {
            physx.PxArticulationPtr pvk_in_this = this;
            float pvk_in_tolerance = tolerance;
            void_PxArticulationPtr_setSeparationTolerancePtr_float_(pvk_in_this, pvk_in_tolerance);
        }

        public float getSeparationTolerance() {
            physx.PxArticulationPtr pvk_in_this = this;
            return float_const_PxArticulationPtr_getSeparationTolerancePtr(pvk_in_this);
        }

        public void setInternalDriveIterations(uint iterations) {
            physx.PxArticulationPtr pvk_in_this = this;
            uint pvk_in_iterations = iterations;
            void_PxArticulationPtr_setInternalDriveIterationsPtr_uint_(pvk_in_this, pvk_in_iterations);
        }

        public uint getInternalDriveIterations() {
            physx.PxArticulationPtr pvk_in_this = this;
            return uint_const_PxArticulationPtr_getInternalDriveIterationsPtr(pvk_in_this);
        }

        public void setExternalDriveIterations(uint iterations) {
            physx.PxArticulationPtr pvk_in_this = this;
            uint pvk_in_iterations = iterations;
            void_PxArticulationPtr_setExternalDriveIterationsPtr_uint_(pvk_in_this, pvk_in_iterations);
        }

        public uint getExternalDriveIterations() {
            physx.PxArticulationPtr pvk_in_this = this;
            return uint_const_PxArticulationPtr_getExternalDriveIterationsPtr(pvk_in_this);
        }

        public static implicit operator physx.PxArticulationBasePtr(PxArticulationPtr obj) => *(physx.PxArticulationBasePtr*)&obj;
        public static explicit operator PxArticulationPtr(physx.PxArticulationBasePtr obj) => *(PxArticulationPtr*)&obj;
        public static implicit operator physx.PxBasePtr(PxArticulationPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxArticulationPtr(physx.PxBasePtr obj) => *(PxArticulationPtr*)&obj;

        public IntPtr userData {
            get => PxArticulationBasePtr_GET_userData(this);
            set => PxArticulationBasePtr_SET_userData(this, value);
        }

        public physx.PxScenePtr getScene(){return((physx.PxArticulationBasePtr)this).getScene();}
        public void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters=1){((physx.PxArticulationBasePtr)this).setSolverIterationCounts(minPositionIters, minVelocityIters);}
        public void getSolverIterationCounts(uint* minPositionIters, uint* minVelocityIters){((physx.PxArticulationBasePtr)this).getSolverIterationCounts(minPositionIters, minVelocityIters);}
        public bool isSleeping(){return((physx.PxArticulationBasePtr)this).isSleeping();}
        public void setSleepThreshold(float threshold){((physx.PxArticulationBasePtr)this).setSleepThreshold(threshold);}
        public float getSleepThreshold(){return((physx.PxArticulationBasePtr)this).getSleepThreshold();}
        public void setStabilizationThreshold(float threshold){((physx.PxArticulationBasePtr)this).setStabilizationThreshold(threshold);}
        public float getStabilizationThreshold(){return((physx.PxArticulationBasePtr)this).getStabilizationThreshold();}
        public void setWakeCounter(float wakeCounterValue){((physx.PxArticulationBasePtr)this).setWakeCounter(wakeCounterValue);}
        public float getWakeCounter(){return((physx.PxArticulationBasePtr)this).getWakeCounter();}
        public void wakeUp(){((physx.PxArticulationBasePtr)this).wakeUp();}
        public void putToSleep(){((physx.PxArticulationBasePtr)this).putToSleep();}
        public physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform* pose){return((physx.PxArticulationBasePtr)this).createLink(parent, pose);}
        public uint getNbLinks(){return((physx.PxArticulationBasePtr)this).getNbLinks();}
        public uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize, uint startIndex=0){return((physx.PxArticulationBasePtr)this).getLinks(userBuffer, bufferSize, startIndex);}
        public void setName(string name){((physx.PxArticulationBasePtr)this).setName(name);}
        public string getName(){return((physx.PxArticulationBasePtr)this).getName();}
        public physx.PxBounds3 getWorldBounds(float inflation=1.01f){return((physx.PxArticulationBasePtr)this).getWorldBounds(inflation);}
        public physx.PxAggregatePtr getAggregate(){return((physx.PxArticulationBasePtr)this).getAggregate();}
        public physx.PxArticulationBasePtr.Enum getType(){return((physx.PxArticulationBasePtr)this).getType();}
        public physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform* parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform* childFrame){return((physx.PxArticulationBasePtr)this).createArticulationJoint(parent, parentFrame, child, childFrame);}
        public void releaseArticulationJoint(physx.PxArticulationJointBasePtr joint){((physx.PxArticulationBasePtr)this).releaseArticulationJoint(joint);}
        public void setSolverIterationCounts(uint minPositionIters){((physx.PxArticulationBasePtr)this).setSolverIterationCounts(minPositionIters);}
        public physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform pose){return((physx.PxArticulationBasePtr)this).createLink(parent, (physx.PxTransform*)&pose);}
        public physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransform.Ref pose){return((physx.PxArticulationBasePtr)this).createLink(parent, (physx.PxTransform*)(*((IntPtr*)(&pose))));}
        public uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize){return((physx.PxArticulationBasePtr)this).getLinks(userBuffer, bufferSize);}
        public physx.PxBounds3 getWorldBounds(){return((physx.PxArticulationBasePtr)this).getWorldBounds();}
        public physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform childFrame){return((physx.PxArticulationBasePtr)this).createArticulationJoint(parent, (physx.PxTransform*)&parentFrame, child, (physx.PxTransform*)&childFrame);}
        public physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransform.Ref parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransform.Ref childFrame){return((physx.PxArticulationBasePtr)this).createArticulationJoint(parent, (physx.PxTransform*)(*((IntPtr*)(&parentFrame))), child, (physx.PxTransform*)(*((IntPtr*)(&childFrame))));}
        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlag flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }
}
