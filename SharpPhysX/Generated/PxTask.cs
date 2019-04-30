// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxBaseTaskPtr : physx.PxBaseTaskPtr.IPxBaseTaskPtr {
        private System.IntPtr nativePtr_;

        public void release() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_releasePtr(pvk_in_this);
        }

        public void addReference() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_addReferencePtr(pvk_in_this);
        }

        public void removeReference() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_removeReferencePtr(pvk_in_this);
        }

        public int getReference() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return int_const_PxBaseTaskPtr_getReferencePtr(pvk_in_this);
        }

        public void run() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_runPtr(pvk_in_this);
        }

        public string getName() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return string_const_PxBaseTaskPtr_getNamePtr(pvk_in_this);
        }

        public physx.PxTaskManagerPtr getTaskManager() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return PxTaskManagerPtr_const_PxBaseTaskPtr_getTaskManagerPtr(pvk_in_this);
        }

        public void setContextId(ulong id) {
            physx.PxBaseTaskPtr pvk_in_this = this;
            ulong pvk_in_id = id;
            void_PxBaseTaskPtr_setContextIdPtr_ulong_(pvk_in_this, pvk_in_id);
        }

        public ulong getContextId() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return ulong_const_PxBaseTaskPtr_getContextIdPtr(pvk_in_this);
        }

        public unsafe interface IPxBaseTaskPtr {
            void release();
            void addReference();
            void removeReference();
            int getReference();
            void run();
            string getName();
            physx.PxTaskManagerPtr getTaskManager();
            void setContextId(ulong id);
            ulong getContextId();
        }
    }

    public unsafe partial struct PxTaskPtr : physx.PxBaseTaskPtr.IPxBaseTaskPtr {
        private System.IntPtr nativePtr_;

        public void release() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_releasePtr(pvk_in_this);
        }

        public void finishBefore(uint taskID) {
            physx.PxTaskPtr pvk_in_this = this;
            uint pvk_in_taskID = taskID;
            void_PxTaskPtr_finishBeforePtr_uint_(pvk_in_this, pvk_in_taskID);
        }

        public void startAfter(uint taskID) {
            physx.PxTaskPtr pvk_in_this = this;
            uint pvk_in_taskID = taskID;
            void_PxTaskPtr_startAfterPtr_uint_(pvk_in_this, pvk_in_taskID);
        }

        public void addReference() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_addReferencePtr(pvk_in_this);
        }

        public void removeReference() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_removeReferencePtr(pvk_in_this);
        }

        public int getReference() {
            physx.PxTaskPtr pvk_in_this = this;
            return int_const_PxTaskPtr_getReferencePtr(pvk_in_this);
        }

        public uint getTaskID() {
            physx.PxTaskPtr pvk_in_this = this;
            return uint_const_PxTaskPtr_getTaskIDPtr(pvk_in_this);
        }

        public void submitted() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_submittedPtr(pvk_in_this);
        }

        public void requestSyncPoint() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_requestSyncPointPtr(pvk_in_this);
        }

        public static implicit operator physx.PxBaseTaskPtr(PxTaskPtr obj) => *(physx.PxBaseTaskPtr*)&obj;
        public static explicit operator PxTaskPtr(physx.PxBaseTaskPtr obj) => *(PxTaskPtr*)&obj;

        public void run(){((physx.PxBaseTaskPtr)this).run();}
        public string getName(){return((physx.PxBaseTaskPtr)this).getName();}
        public physx.PxTaskManagerPtr getTaskManager(){return((physx.PxBaseTaskPtr)this).getTaskManager();}
        public void setContextId(ulong id){((physx.PxBaseTaskPtr)this).setContextId(id);}
        public ulong getContextId(){return((physx.PxBaseTaskPtr)this).getContextId();}
    }

    public unsafe partial struct PxLightCpuTaskPtr : physx.PxBaseTaskPtr.IPxBaseTaskPtr {
        private System.IntPtr nativePtr_;

        public void setContinuation(physx.PxTaskManagerPtr tm, physx.PxBaseTaskPtr c) {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            physx.PxTaskManagerPtr pvk_in_tm = tm;
            physx.PxBaseTaskPtr pvk_in_c = c;
            void_PxLightCpuTaskPtr_setContinuationPtr_PxTaskManagerPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_tm, pvk_in_c);
        }

        public void setContinuation(physx.PxBaseTaskPtr c) {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            physx.PxBaseTaskPtr pvk_in_c = c;
            void_PxLightCpuTaskPtr_setContinuationPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_c);
        }

        public physx.PxBaseTaskPtr getContinuation() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            return PxBaseTaskPtr_const_PxLightCpuTaskPtr_getContinuationPtr(pvk_in_this);
        }

        public void removeReference() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            void_PxLightCpuTaskPtr_removeReferencePtr(pvk_in_this);
        }

        public int getReference() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            return int_const_PxLightCpuTaskPtr_getReferencePtr(pvk_in_this);
        }

        public void addReference() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            void_PxLightCpuTaskPtr_addReferencePtr(pvk_in_this);
        }

        public void release() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            void_PxLightCpuTaskPtr_releasePtr(pvk_in_this);
        }

        public static implicit operator physx.PxBaseTaskPtr(PxLightCpuTaskPtr obj) => *(physx.PxBaseTaskPtr*)&obj;
        public static explicit operator PxLightCpuTaskPtr(physx.PxBaseTaskPtr obj) => *(PxLightCpuTaskPtr*)&obj;

        public void run(){((physx.PxBaseTaskPtr)this).run();}
        public string getName(){return((physx.PxBaseTaskPtr)this).getName();}
        public physx.PxTaskManagerPtr getTaskManager(){return((physx.PxBaseTaskPtr)this).getTaskManager();}
        public void setContextId(ulong id){((physx.PxBaseTaskPtr)this).setContextId(id);}
        public ulong getContextId(){return((physx.PxBaseTaskPtr)this).getContextId();}
    }
}
