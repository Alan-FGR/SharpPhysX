// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public enum PxTaskTypeEnum : int {
        TT_CPU = 0,         // TT_CPU
        TT_GPU = 1,         // TT_GPU
        TT_NOT_PRESENT = 2, // TT_NOT_PRESENT
        TT_COMPLETED = 3,   // TT_COMPLETED
    }

    public unsafe partial struct PxTaskManagerPtr {
        private System.IntPtr nativePtr_;

        public void setCpuDispatcher(physx.PxCpuDispatcherPtr ref_) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            physx.PxCpuDispatcherPtr pvk_in_ref = ref_;
            void_PxTaskManagerPtr_setCpuDispatcherPtr_PxCpuDispatcherPtr_(pvk_in_this, pvk_in_ref);
        }

        public void setGpuDispatcher(physx.PxGpuDispatcherPtr ref_) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            physx.PxGpuDispatcherPtr pvk_in_ref = ref_;
            void_PxTaskManagerPtr_setGpuDispatcherPtr_PxGpuDispatcherPtr_(pvk_in_this, pvk_in_ref);
        }

        public physx.PxCpuDispatcherPtr getCpuDispatcher() {
            physx.PxTaskManagerPtr pvk_in_this = this;
            return PxCpuDispatcherPtr_const_PxTaskManagerPtr_getCpuDispatcherPtr(pvk_in_this);
        }

        public physx.PxGpuDispatcherPtr getGpuDispatcher() {
            physx.PxTaskManagerPtr pvk_in_this = this;
            return PxGpuDispatcherPtr_const_PxTaskManagerPtr_getGpuDispatcherPtr(pvk_in_this);
        }

        public void resetDependencies() {
            physx.PxTaskManagerPtr pvk_in_this = this;
            void_PxTaskManagerPtr_resetDependenciesPtr(pvk_in_this);
        }

        public void startSimulation() {
            physx.PxTaskManagerPtr pvk_in_this = this;
            void_PxTaskManagerPtr_startSimulationPtr(pvk_in_this);
        }

        public void stopSimulation() {
            physx.PxTaskManagerPtr pvk_in_this = this;
            void_PxTaskManagerPtr_stopSimulationPtr(pvk_in_this);
        }

        public void taskCompleted(physx.PxTaskPtr task) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            physx.PxTaskPtr pvk_in_task = task;
            void_PxTaskManagerPtr_taskCompletedPtr_PxTaskPtr_(pvk_in_this, pvk_in_task);
        }

        public uint getNamedTask(string name) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            string pvk_in_name = name;
            return uint_PxTaskManagerPtr_getNamedTaskPtr_string_(pvk_in_this, pvk_in_name);
        }

        public uint submitNamedTask(physx.PxTaskPtr task, string name, physx.PxTaskTypeEnum type) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            physx.PxTaskPtr pvk_in_task = task;
            string pvk_in_name = name;
            physx.PxTaskTypeEnum pvk_in_type = type;
            return uint_PxTaskManagerPtr_submitNamedTaskPtr_PxTaskPtr_string_PxTaskTypeEnum_(pvk_in_this, pvk_in_task, pvk_in_name, pvk_in_type);
        }

        public uint submitUnnamedTask(physx.PxTaskPtr task, physx.PxTaskTypeEnum type) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            physx.PxTaskPtr pvk_in_task = task;
            physx.PxTaskTypeEnum pvk_in_type = type;
            return uint_PxTaskManagerPtr_submitUnnamedTaskPtr_PxTaskPtr_PxTaskTypeEnum_(pvk_in_this, pvk_in_task, pvk_in_type);
        }

        public physx.PxTaskPtr getTaskFromID(uint id) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            uint pvk_in_id = id;
            return PxTaskPtr_PxTaskManagerPtr_getTaskFromIDPtr_uint_(pvk_in_this, pvk_in_id);
        }

        public void release() {
            physx.PxTaskManagerPtr pvk_in_this = this;
            void_PxTaskManagerPtr_releasePtr(pvk_in_this);
        }

        public uint submitNamedTask(physx.PxTaskPtr task, string name) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            physx.PxTaskPtr pvk_in_task = task;
            string pvk_in_name = name;
            return uint_PxTaskManagerPtr_submitNamedTaskPtr_PxTaskPtr_string_(pvk_in_this, pvk_in_task, pvk_in_name);
        }

        public uint submitUnnamedTask(physx.PxTaskPtr task) {
            physx.PxTaskManagerPtr pvk_in_this = this;
            physx.PxTaskPtr pvk_in_task = task;
            return uint_PxTaskManagerPtr_submitUnnamedTaskPtr_PxTaskPtr_(pvk_in_this, pvk_in_task);
        }

    }

}
