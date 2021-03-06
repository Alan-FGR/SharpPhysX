// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxGpuDispatcherPtr {
        private System.IntPtr nativePtr_;

        public void startSimulation() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_PxGpuDispatcherPtr_startSimulationPtr(pvk_in_this);
        }

        public void startGroup() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_PxGpuDispatcherPtr_startGroupPtr(pvk_in_this);
        }

        public void submitTask(physx.PxTaskPtr task) {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            physx.PxTaskPtr pvk_in_task = task;
            void_PxGpuDispatcherPtr_submitTaskPtr_PxTaskPtr_(pvk_in_this, pvk_in_task);
        }

        public void finishGroup() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_PxGpuDispatcherPtr_finishGroupPtr(pvk_in_this);
        }

        public void addCompletionPrereq(physx.PxBaseTaskPtr task) {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            physx.PxBaseTaskPtr pvk_in_task = task;
            void_PxGpuDispatcherPtr_addCompletionPrereqPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_task);
        }

        public void stopSimulation() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_PxGpuDispatcherPtr_stopSimulationPtr(pvk_in_this);
        }

        public bool failureDetected() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            return bool_const_PxGpuDispatcherPtr_failureDetectedPtr(pvk_in_this);
        }

        public void forceFailureMode() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_PxGpuDispatcherPtr_forceFailureModePtr(pvk_in_this);
        }

        public void launchCopyKernel(physx.PxGpuCopyDescPtr desc, uint count, CUstream stream) {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            physx.PxGpuCopyDescPtr pvk_in_desc = desc;
            uint pvk_in_count = count;
            CUstream pvk_in_stream = stream;
            void_PxGpuDispatcherPtr_launchCopyKernelPtr_PxGpuCopyDescPtr_uint_CUstream_(pvk_in_this, pvk_in_desc, pvk_in_count, pvk_in_stream);
        }

        public physx.PxBaseTaskPtr getPreLaunchTask() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            return PxBaseTaskPtr_PxGpuDispatcherPtr_getPreLaunchTaskPtr(pvk_in_this);
        }

        public void addPreLaunchDependent(physx.PxBaseTaskPtr dependent) {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            physx.PxBaseTaskPtr pvk_in_dependent = dependent;
            void_PxGpuDispatcherPtr_addPreLaunchDependentPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_dependent);
        }

        public physx.PxBaseTaskPtr getPostLaunchTask() {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            return PxBaseTaskPtr_PxGpuDispatcherPtr_getPostLaunchTaskPtr(pvk_in_this);
        }

        public void addPostLaunchDependent(physx.PxBaseTaskPtr dependent) {
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            physx.PxBaseTaskPtr pvk_in_dependent = dependent;
            void_PxGpuDispatcherPtr_addPostLaunchDependentPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_dependent);
        }

    }
}

