// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxDefaultCpuDispatcher
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxDefaultCpuDispatcherPtr physx_PxDefaultCpuDispatcherPtr_physx_PxDefaultCpuDispatcherCreate_uint_uint_(uint pvk_numThreads, uint* pvk_affinityMasks);
    
    public static physx.PxDefaultCpuDispatcherPtr PxDefaultCpuDispatcherCreate(uint numThreads, uint* affinityMasks=default(uint*)) {
        uint pvk_in_numThreads = numThreads;
        uint* pvk_in_affinityMasks = affinityMasks;
        return physx_PxDefaultCpuDispatcherPtr_physx_PxDefaultCpuDispatcherCreate_uint_uint_(pvk_in_numThreads, pvk_in_affinityMasks);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxDefaultCpuDispatcherPtr physx_PxDefaultCpuDispatcherPtr_physx_PxDefaultCpuDispatcherCreate_uint_(uint pvk_numThreads);
    
    public static physx.PxDefaultCpuDispatcherPtr PxDefaultCpuDispatcherCreate(uint numThreads) {
        uint pvk_in_numThreads = numThreads;
        return physx_PxDefaultCpuDispatcherPtr_physx_PxDefaultCpuDispatcherCreate_uint_(pvk_in_numThreads);
    }
    
    public unsafe partial struct PxDefaultCpuDispatcherPtr : physx.PxCpuDispatcherPtr.IPxCpuDispatcherPtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxDefaultCpuDispatcher_release(physx.PxDefaultCpuDispatcherPtr pvk_this);
        
        public void release() {
            physx.PxDefaultCpuDispatcherPtr pvk_in_this = this;
            void_physx_PxDefaultCpuDispatcher_release(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxDefaultCpuDispatcher_setRunProfiled_bool_(physx.PxDefaultCpuDispatcherPtr pvk_this, bool pvk_runProfiled);
        
        public void setRunProfiled(bool runProfiled) {
            physx.PxDefaultCpuDispatcherPtr pvk_in_this = this;
            bool pvk_in_runProfiled = runProfiled;
            void_physx_PxDefaultCpuDispatcher_setRunProfiled_bool_(pvk_in_this, pvk_in_runProfiled);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxDefaultCpuDispatcher_getRunProfiled(physx.PxDefaultCpuDispatcherPtr pvk_this);
        
        public bool getRunProfiled() {
            physx.PxDefaultCpuDispatcherPtr pvk_in_this = this;
            return bool_const_physx_PxDefaultCpuDispatcher_getRunProfiled(pvk_in_this);
        }
        public static implicit operator physx.PxCpuDispatcherPtr(PxDefaultCpuDispatcherPtr obj) => *(physx.PxCpuDispatcherPtr*)&obj;
        public static explicit operator PxDefaultCpuDispatcherPtr(physx.PxCpuDispatcherPtr obj) => *(PxDefaultCpuDispatcherPtr*)&obj;
    
        // PIPING
        public void submitTask(physx.PxBaseTaskPtr task){((physx.PxCpuDispatcherPtr)this).submitTask(task);}
        public uint getWorkerCount(){return((physx.PxCpuDispatcherPtr)this).getWorkerCount();}
    }
    
}