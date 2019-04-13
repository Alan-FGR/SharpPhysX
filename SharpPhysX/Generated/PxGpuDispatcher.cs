// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//Unit PxGpuDispatcher
using System;
using System.Runtime.InteropServices;

//DEBUG: NamespaceNode physx - 37-245
public static unsafe partial class physx {
    //DEBUG: ClassNode physx::PxGpuDispatcher - 71-241
    //Interface use count: 0
    public unsafe partial struct PxGpuDispatcherPtr{
        private System.IntPtr nativePtr_;
        
    //DEBUG: MethodNode physx::PxGpuDispatcher::startSimulation - 80
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_startSimulation(physx.PxGpuDispatcherPtr pvk_this);
        
        public void startSimulation() {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_physx_PxGpuDispatcher_startSimulation(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::startGroup - 91
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_startGroup(physx.PxGpuDispatcherPtr pvk_this);
        
        public void startGroup() {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_physx_PxGpuDispatcher_startGroup(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::submitTask - 100
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_submitTask_physx_PxTaskPtr_(physx.PxGpuDispatcherPtr pvk_this, physx.PxTaskPtr pvk_task);
        
        public void submitTask(physx.PxTaskPtr task) {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, stg: PtrStruct
            physx.PxTaskPtr pvk_in_task = task;
            void_physx_PxGpuDispatcher_submitTask_physx_PxTaskPtr_(pvk_in_this, pvk_in_task);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::finishGroup - 110
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_finishGroup(physx.PxGpuDispatcherPtr pvk_this);
        
        public void finishGroup() {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_physx_PxGpuDispatcher_finishGroup(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::addCompletionPrereq - 135
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_addCompletionPrereq_physx_PxBaseTaskPtr_(physx.PxGpuDispatcherPtr pvk_this, physx.PxBaseTaskPtr pvk_task);
        
        public void addCompletionPrereq(physx.PxBaseTaskPtr task) {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, stg: PtrStruct
            physx.PxBaseTaskPtr pvk_in_task = task;
            void_physx_PxGpuDispatcher_addCompletionPrereq_physx_PxBaseTaskPtr_(pvk_in_this, pvk_in_task);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::getCudaContextManager - 143
        //ERRORS OCCURED IN physx::PxGpuDispatcher::getCudaContextManager
        ////Type PxCudaContextManagerPtr explicitly forbidden by user configuration
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::stopSimulation - 151
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_stopSimulation(physx.PxGpuDispatcherPtr pvk_this);
        
        public void stopSimulation() {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_physx_PxGpuDispatcher_stopSimulation(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::failureDetected - 172
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxGpuDispatcher_failureDetected(physx.PxGpuDispatcherPtr pvk_this);
        
        public bool failureDetected() {
            //RET nat: bool, man: bool, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            return bool_const_physx_PxGpuDispatcher_failureDetected(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::forceFailureMode - 180
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_forceFailureMode(physx.PxGpuDispatcherPtr pvk_this);
        
        public void forceFailureMode() {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            void_physx_PxGpuDispatcher_forceFailureMode(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::launchCopyKernel - 201
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_launchCopyKernel_physx_PxGpuCopyDescPtr_uint_CUstream_(physx.PxGpuDispatcherPtr pvk_this, physx.PxGpuCopyDescPtr pvk_desc, uint pvk_count, CUstream pvk_stream);
        
        public void launchCopyKernel(physx.PxGpuCopyDescPtr desc, uint count, CUstream stream) {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            //PAR nat: PxGpuCopyDescPtr, man: physx.PxGpuCopyDescPtr, stg: PtrStruct
            physx.PxGpuCopyDescPtr pvk_in_desc = desc;
            //PAR nat: unsigned int, man: uint, stg: Value
            uint pvk_in_count = count;
            //PAR nat: CUstream, man: CUstream, stg: Value
            CUstream pvk_in_stream = stream;
            void_physx_PxGpuDispatcher_launchCopyKernel_physx_PxGpuCopyDescPtr_uint_CUstream_(pvk_in_this, pvk_in_desc, pvk_in_count, pvk_in_stream);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::getPreLaunchTask - 209
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBaseTaskPtr physx_PxBaseTaskPtr_physx_PxGpuDispatcher_getPreLaunchTask(physx.PxGpuDispatcherPtr pvk_this);
        
        public physx.PxBaseTaskPtr getPreLaunchTask() {
            //RET nat: physx.PxBaseTaskPtr, man: physx.PxBaseTaskPtr, stg: PtrStruct, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            return physx_PxBaseTaskPtr_physx_PxGpuDispatcher_getPreLaunchTask(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::addPreLaunchDependent - 217
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_addPreLaunchDependent_physx_PxBaseTaskPtr_(physx.PxGpuDispatcherPtr pvk_this, physx.PxBaseTaskPtr pvk_dependent);
        
        public void addPreLaunchDependent(physx.PxBaseTaskPtr dependent) {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, stg: PtrStruct
            physx.PxBaseTaskPtr pvk_in_dependent = dependent;
            void_physx_PxGpuDispatcher_addPreLaunchDependent_physx_PxBaseTaskPtr_(pvk_in_this, pvk_in_dependent);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::getPostLaunchTask - 225
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBaseTaskPtr physx_PxBaseTaskPtr_physx_PxGpuDispatcher_getPostLaunchTask(physx.PxGpuDispatcherPtr pvk_this);
        
        public physx.PxBaseTaskPtr getPostLaunchTask() {
            //RET nat: physx.PxBaseTaskPtr, man: physx.PxBaseTaskPtr, stg: PtrStruct, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            return physx_PxBaseTaskPtr_physx_PxGpuDispatcher_getPostLaunchTask(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::addPostLaunchDependent - 233
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxGpuDispatcher_addPostLaunchDependent_physx_PxBaseTaskPtr_(physx.PxGpuDispatcherPtr pvk_this, physx.PxBaseTaskPtr pvk_dependent);
        
        public void addPostLaunchDependent(physx.PxBaseTaskPtr dependent) {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxGpuDispatcherPtr, man: physx.PxGpuDispatcherPtr, stg: PtrStruct
            physx.PxGpuDispatcherPtr pvk_in_this = this;
            //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, stg: PtrStruct
            physx.PxBaseTaskPtr pvk_in_dependent = dependent;
            void_physx_PxGpuDispatcher_addPostLaunchDependent_physx_PxBaseTaskPtr_(pvk_in_this, pvk_in_dependent);
        }
        
        //DEBUG: MethodNode physx::PxGpuDispatcher::operator= - 71
        //ERRORS OCCURED IN physx::PxGpuDispatcher::operator=
        //Implicit Function/Method
        //Unbindable Operator: Equal
    }
    
}

//DEBUG: DeclNode CUstream - 35
// TODO DeclNode.GenBinding()
