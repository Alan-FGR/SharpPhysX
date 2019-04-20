// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {
    //Subclasses using this: 1

    public unsafe partial struct PxCpuDispatcherPtr : physx.PxCpuDispatcherPtr.IPxCpuDispatcherPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxCpuDispatcher physx::PxCpuDispatcher L49-75

        //DBG: MethodNode physx::PxCpuDispatcher::submitTask L63
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxCpuDispatcherPtr, man: physx.PxCpuDispatcherPtr, kind: PtrStruct
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public void submitTask(physx.PxBaseTaskPtr task) {
            physx.PxCpuDispatcherPtr pvk_in_this = this;
            physx.PxBaseTaskPtr pvk_in_task = task;
            void_PxCpuDispatcherPtr_submitTaskPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_task);
        }

        //DBG: MethodNode physx::PxCpuDispatcher::getWorkerCount L72
        //RET nat: uint32_t, man: uint, ret: True, kind: Value
        //PAR nat: PxCpuDispatcherPtr, man: physx.PxCpuDispatcherPtr, kind: PtrStruct
        public uint getWorkerCount() {
            physx.PxCpuDispatcherPtr pvk_in_this = this;
            return uint_const_PxCpuDispatcherPtr_getWorkerCountPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxCpuDispatcher::~PxCpuDispatcher L74
        //ERRORS in MethodNode: Destructor

        //DBG: MethodNode physx::PxCpuDispatcher::operator= L49
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxCpuDispatcher::operator= L49

        //INTERFACES
        public unsafe interface IPxCpuDispatcherPtr {
            void submitTask(physx.PxBaseTaskPtr task);
            uint getWorkerCount();
        }

        //Operators
    }
}
