// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxArticulationBase
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    public unsafe partial struct PxArticulationBasePtr : physx.PxBasePtr.IPxBasePtr{
        private System.IntPtr nativePtr_;
        
    public enum Enum : int {
            eReducedCoordinate = 0, // eReducedCoordinate = 0
            eMaximumCoordinate = 1, // eMaximumCoordinate = 1
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr PxArticulationBase_GET_userData(PxArticulationBasePtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxArticulationBase_SET_userData(PxArticulationBasePtr cls, IntPtr value);
        
        public IntPtr userData {
            get => PxArticulationBase_GET_userData(this);
            set => PxArticulationBase_SET_userData(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxScenePtr physx_PxScenePtr_const_physx_PxArticulationBase_getScene(physx.PxArticulationBasePtr pvk_this);
        
        public physx.PxScenePtr getScene() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return physx_PxScenePtr_const_physx_PxArticulationBase_getScene(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_setSolverIterationCounts_uint_uint_(physx.PxArticulationBasePtr pvk_this, uint pvk_minPositionIters, uint pvk_minVelocityIters);
        
        public void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters=1) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            uint pvk_in_minPositionIters = minPositionIters;
            uint pvk_in_minVelocityIters = minVelocityIters;
            void_physx_PxArticulationBase_setSolverIterationCounts_uint_uint_(pvk_in_this, pvk_in_minPositionIters, pvk_in_minVelocityIters);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_setSolverIterationCounts_uint_(physx.PxArticulationBasePtr pvk_this, uint pvk_minPositionIters);
        
        public void setSolverIterationCounts(uint minPositionIters) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            uint pvk_in_minPositionIters = minPositionIters;
            void_physx_PxArticulationBase_setSolverIterationCounts_uint_(pvk_in_this, pvk_in_minPositionIters);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_const_physx_PxArticulationBase_getSolverIterationCounts_uint_uint_(physx.PxArticulationBasePtr pvk_this, uint* pvk_minPositionIters, uint* pvk_minVelocityIters);
        
        public void getSolverIterationCounts(uint* minPositionIters, uint* minVelocityIters) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            uint* pvk_in_minPositionIters = minPositionIters;
            uint* pvk_in_minVelocityIters = minVelocityIters;
            void_const_physx_PxArticulationBase_getSolverIterationCounts_uint_uint_(pvk_in_this, pvk_in_minPositionIters, pvk_in_minVelocityIters);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxArticulationBase_isSleeping(physx.PxArticulationBasePtr pvk_this);
        
        public bool isSleeping() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return bool_const_physx_PxArticulationBase_isSleeping(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_setSleepThreshold_float_(physx.PxArticulationBasePtr pvk_this, float pvk_threshold);
        
        public void setSleepThreshold(float threshold) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_threshold = threshold;
            void_physx_PxArticulationBase_setSleepThreshold_float_(pvk_in_this, pvk_in_threshold);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxArticulationBase_getSleepThreshold(physx.PxArticulationBasePtr pvk_this);
        
        public float getSleepThreshold() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return float_const_physx_PxArticulationBase_getSleepThreshold(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_setStabilizationThreshold_float_(physx.PxArticulationBasePtr pvk_this, float pvk_threshold);
        
        public void setStabilizationThreshold(float threshold) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_threshold = threshold;
            void_physx_PxArticulationBase_setStabilizationThreshold_float_(pvk_in_this, pvk_in_threshold);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxArticulationBase_getStabilizationThreshold(physx.PxArticulationBasePtr pvk_this);
        
        public float getStabilizationThreshold() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return float_const_physx_PxArticulationBase_getStabilizationThreshold(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_setWakeCounter_float_(physx.PxArticulationBasePtr pvk_this, float pvk_wakeCounterValue);
        
        public void setWakeCounter(float wakeCounterValue) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_wakeCounterValue = wakeCounterValue;
            void_physx_PxArticulationBase_setWakeCounter_float_(pvk_in_this, pvk_in_wakeCounterValue);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxArticulationBase_getWakeCounter(physx.PxArticulationBasePtr pvk_this);
        
        public float getWakeCounter() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return float_const_physx_PxArticulationBase_getWakeCounter(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_wakeUp(physx.PxArticulationBasePtr pvk_this);
        
        public void wakeUp() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            void_physx_PxArticulationBase_wakeUp(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_putToSleep(physx.PxArticulationBasePtr pvk_this);
        
        public void putToSleep() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            void_physx_PxArticulationBase_putToSleep(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxArticulationLinkPtr physx_PxArticulationLinkPtr_physx_PxArticulationBase_createLink_physx_PxArticulationLinkPtr_physx_PxTransformPtr_(physx.PxArticulationBasePtr pvk_this, physx.PxArticulationLinkPtr pvk_parent, physx.PxTransformPtr pvk_pose);
        
        public physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransformPtr pose) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr pvk_in_parent = parent;
            physx.PxTransformPtr pvk_in_pose = pose;
            return physx_PxArticulationLinkPtr_physx_PxArticulationBase_createLink_physx_PxArticulationLinkPtr_physx_PxTransformPtr_(pvk_in_this, pvk_in_parent, pvk_in_pose);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxArticulationBase_getNbLinks(physx.PxArticulationBasePtr pvk_this);
        
        public uint getNbLinks() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return uint_const_physx_PxArticulationBase_getNbLinks(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_uint_(physx.PxArticulationBasePtr pvk_this, physx.PxArticulationLinkPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_(physx.PxArticulationBasePtr pvk_this, physx.PxArticulationLinkPtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxArticulationBase_getLinks_physx_PxArticulationLinkPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_setName_string_(physx.PxArticulationBasePtr pvk_this, string pvk_name);
        
        public void setName(string name) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            string pvk_in_name = name;
            void_physx_PxArticulationBase_setName_string_(pvk_in_this, pvk_in_name);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern string string_const_physx_PxArticulationBase_getName(physx.PxArticulationBasePtr pvk_this);
        
        public string getName() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return string_const_physx_PxArticulationBase_getName(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBounds3Ptr physx_PxBounds3Ptr_const_physx_PxArticulationBase_getWorldBounds_float_(physx.PxArticulationBasePtr pvk_this, float pvk_inflation);
        
        public physx.PxBounds3Ptr getWorldBounds_New(float inflation=1.01f) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            float pvk_in_inflation = inflation;
            return physx_PxBounds3Ptr_const_physx_PxArticulationBase_getWorldBounds_float_(pvk_in_this, pvk_in_inflation);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBounds3Ptr physx_PxBounds3Ptr_const_physx_PxArticulationBase_getWorldBounds(physx.PxArticulationBasePtr pvk_this);
        
        public physx.PxBounds3Ptr getWorldBounds_New() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return physx_PxBounds3Ptr_const_physx_PxArticulationBase_getWorldBounds(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxAggregatePtr physx_PxAggregatePtr_const_physx_PxArticulationBase_getAggregate(physx.PxArticulationBasePtr pvk_this);
        
        public physx.PxAggregatePtr getAggregate() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return physx_PxAggregatePtr_const_physx_PxArticulationBase_getAggregate(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxArticulationBasePtr.Enum physx_PxArticulationBasePtr_Enum_const_physx_PxArticulationBase_getType(physx.PxArticulationBasePtr pvk_this);
        
        public physx.PxArticulationBasePtr.Enum getType() {
            physx.PxArticulationBasePtr pvk_in_this = this;
            return physx_PxArticulationBasePtr_Enum_const_physx_PxArticulationBase_getType(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxArticulationJointBasePtr physx_PxArticulationJointBasePtr_physx_PxArticulationBase_createArticulationJoint_physx_PxArticulationLinkPtr_physx_PxTransformPtr_physx_PxArticulationLinkPtr_physx_PxTransformPtr_(physx.PxArticulationBasePtr pvk_this, physx.PxArticulationLinkPtr pvk_parent, physx.PxTransformPtr pvk_parentFrame, physx.PxArticulationLinkPtr pvk_child, physx.PxTransformPtr pvk_childFrame);
        
        public physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransformPtr parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransformPtr childFrame) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationLinkPtr pvk_in_parent = parent;
            physx.PxTransformPtr pvk_in_parentFrame = parentFrame;
            physx.PxArticulationLinkPtr pvk_in_child = child;
            physx.PxTransformPtr pvk_in_childFrame = childFrame;
            return physx_PxArticulationJointBasePtr_physx_PxArticulationBase_createArticulationJoint_physx_PxArticulationLinkPtr_physx_PxTransformPtr_physx_PxArticulationLinkPtr_physx_PxTransformPtr_(pvk_in_this, pvk_in_parent, pvk_in_parentFrame, pvk_in_child, pvk_in_childFrame);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxArticulationBase_releaseArticulationJoint_physx_PxArticulationJointBasePtr_(physx.PxArticulationBasePtr pvk_this, physx.PxArticulationJointBasePtr pvk_joint);
        
        public void releaseArticulationJoint(physx.PxArticulationJointBasePtr joint) {
            physx.PxArticulationBasePtr pvk_in_this = this;
            physx.PxArticulationJointBasePtr pvk_in_joint = joint;
            void_physx_PxArticulationBase_releaseArticulationJoint_physx_PxArticulationJointBasePtr_(pvk_in_this, pvk_in_joint);
        }
        public static implicit operator physx.PxBasePtr(PxArticulationBasePtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxArticulationBasePtr(physx.PxBasePtr obj) => *(PxArticulationBasePtr*)&obj;
    
        // PIPING
        public void release(){((physx.PxBasePtr)this).release();}
        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    
        public unsafe interface IPxArticulationBasePtr {
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
            physx.PxArticulationLinkPtr createLink(physx.PxArticulationLinkPtr parent, physx.PxTransformPtr pose);
            uint getNbLinks();
            uint getLinks(physx.PxArticulationLinkPtr* userBuffer, uint bufferSize, uint startIndex=0);
            void setName(string name);
            string getName();
            physx.PxBounds3Ptr getWorldBounds_New(float inflation=1.01f);
            physx.PxAggregatePtr getAggregate();
            //////Type PxArticulationImplPtr explicitly forbidden by user configuration | physx.PxArticulationImplPtr getImpl();
            //////Type PxArticulationImplPtr explicitly forbidden by user configuration | physx.PxArticulationImplPtr getImplConst();
            physx.PxArticulationBasePtr.Enum getType();
            physx.PxArticulationJointBasePtr createArticulationJoint(physx.PxArticulationLinkPtr parent, physx.PxTransformPtr parentFrame, physx.PxArticulationLinkPtr child, physx.PxTransformPtr childFrame);
            void releaseArticulationJoint(physx.PxArticulationJointBasePtr joint);
        }
    }
    
}