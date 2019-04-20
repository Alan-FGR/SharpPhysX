// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {
    //Subclasses using this: 2

    public unsafe partial struct PxBaseTaskPtr : physx.PxBaseTaskPtr.IPxBaseTaskPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxBaseTask physx::PxBaseTask L45-102

        //DBG: DeclNode  physx::PxBaseTask L101

        //DBG: MethodNode physx::PxBaseTask::~PxBaseTask L49
        //ERRORS in MethodNode: Destructor

        //DBG: MethodNode physx::PxBaseTask::release L81
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public void release() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_releasePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::addReference L69
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public void addReference() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_addReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::removeReference L71
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public void removeReference() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_removeReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::getReference L73
        //RET nat: int32_t, man: int, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public int getReference() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return int_const_PxBaseTaskPtr_getReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::run L57
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public void run() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            void_PxBaseTaskPtr_runPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::getName L66
        //RET nat: char*, man: string, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public string getName() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return string_const_PxBaseTaskPtr_getNamePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::getTaskManager L89-92
        //RET nat: PxTaskManagerPtr, man: physx.PxTaskManagerPtr, ret: True, kind: PtrStruct
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public physx.PxTaskManagerPtr getTaskManager() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return PxTaskManagerPtr_const_PxBaseTaskPtr_getTaskManagerPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::setContextId L94
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        //PAR nat: PxU64, man: ulong, kind: Value
        public void setContextId(ulong id) {
            physx.PxBaseTaskPtr pvk_in_this = this;
            ulong pvk_in_id = id;
            void_PxBaseTaskPtr_setContextIdPtr_ulong_(pvk_in_this, pvk_in_id);
        }

        //DBG: MethodNode physx::PxBaseTask::getContextId L95
        //RET nat: PxU64, man: ulong, ret: True, kind: Value
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public ulong getContextId() {
            physx.PxBaseTaskPtr pvk_in_this = this;
            return ulong_const_PxBaseTaskPtr_getContextIdPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBaseTask::operator= L45
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxBaseTask::operator= L45

        //INTERFACES
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

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxTaskPtr : physx.PxBaseTaskPtr.IPxBaseTaskPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxTask physx::PxTask L111-206Bases: PxBaseTaskPtr

        //DBG: DeclNode  physx::PxTask L204

        //DBG: MethodNode physx::PxTask::~PxTask L115
        //ERRORS in MethodNode: Destructor

        //DBG: MethodNode physx::PxTask::release L118-126
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        public void release() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_releasePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxTask::finishBefore L130-134
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        //PAR nat: PxTaskID, man: uint, kind: Value
        public void finishBefore(uint taskID) {
            physx.PxTaskPtr pvk_in_this = this;
            uint pvk_in_taskID = taskID;
            void_PxTaskPtr_finishBeforePtr_uint_(pvk_in_this, pvk_in_taskID);
        }

        //DBG: MethodNode physx::PxTask::startAfter L138-142
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        //PAR nat: PxTaskID, man: uint, kind: Value
        public void startAfter(uint taskID) {
            physx.PxTaskPtr pvk_in_this = this;
            uint pvk_in_taskID = taskID;
            void_PxTaskPtr_startAfterPtr_uint_(pvk_in_this, pvk_in_taskID);
        }

        //DBG: MethodNode physx::PxTask::addReference L148-152
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        public void addReference() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_addReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxTask::removeReference L158-162
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        public void removeReference() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_removeReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxTask::getReference L167-170
        //RET nat: int32_t, man: int, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        public int getReference() {
            physx.PxTaskPtr pvk_in_this = this;
            return int_const_PxTaskPtr_getReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxTask::getTaskID L175-178
        //RET nat: PxTaskID, man: uint, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        public uint getTaskID() {
            physx.PxTaskPtr pvk_in_this = this;
            return uint_const_PxTaskPtr_getTaskIDPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxTask::submitted L185-189
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        public void submitted() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_submittedPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxTask::requestSyncPoint L194-197
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxTaskPtr, man: physx.PxTaskPtr, kind: PtrStruct
        public void requestSyncPoint() {
            physx.PxTaskPtr pvk_in_this = this;
            void_PxTaskPtr_requestSyncPointPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxTask::operator= L111
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxTask::operator= L111
        public static implicit operator physx.PxBaseTaskPtr(PxTaskPtr obj) => *(physx.PxBaseTaskPtr*)&obj;
        public static explicit operator PxTaskPtr(physx.PxBaseTaskPtr obj) => *(PxTaskPtr*)&obj;

        //PIPING
        public void run(){((physx.PxBaseTaskPtr)this).run();}
        public string getName(){return((physx.PxBaseTaskPtr)this).getName();}
        public physx.PxTaskManagerPtr getTaskManager(){return((physx.PxBaseTaskPtr)this).getTaskManager();}
        public void setContextId(ulong id){((physx.PxBaseTaskPtr)this).setContextId(id);}
        public ulong getContextId(){return((physx.PxBaseTaskPtr)this).getContextId();}

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxLightCpuTaskPtr : physx.PxBaseTaskPtr.IPxBaseTaskPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxLightCpuTask physx::PxLightCpuTask L222-328Bases: PxBaseTaskPtr

        //DBG: DeclNode  physx::PxLightCpuTask L327

        //DBG: MethodNode physx::PxLightCpuTask::~PxLightCpuTask L230-233
        //ERRORS in MethodNode: Destructor

        //DBG: MethodNode physx::PxLightCpuTask::setContinuation L244-254
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxLightCpuTaskPtr, man: physx.PxLightCpuTaskPtr, kind: PtrStruct
        //PAR nat: PxTaskManagerPtr, man: physx.PxTaskManagerPtr, kind: PtrStruct
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public void setContinuation(physx.PxTaskManagerPtr tm, physx.PxBaseTaskPtr c) {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            physx.PxTaskManagerPtr pvk_in_tm = tm;
            physx.PxBaseTaskPtr pvk_in_c = c;
            void_PxLightCpuTaskPtr_setContinuationPtr_PxTaskManagerPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_tm, pvk_in_c);
        }

        //DBG: MethodNode physx::PxLightCpuTask::setContinuation L263-275
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxLightCpuTaskPtr, man: physx.PxLightCpuTaskPtr, kind: PtrStruct
        //PAR nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, kind: PtrStruct
        public void setContinuation(physx.PxBaseTaskPtr c) {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            physx.PxBaseTaskPtr pvk_in_c = c;
            void_PxLightCpuTaskPtr_setContinuationPtr_PxBaseTaskPtr_(pvk_in_this, pvk_in_c);
        }

        //DBG: MethodNode physx::PxLightCpuTask::getContinuation L280-283
        //RET nat: PxBaseTaskPtr, man: physx.PxBaseTaskPtr, ret: True, kind: PtrStruct
        //PAR nat: PxLightCpuTaskPtr, man: physx.PxLightCpuTaskPtr, kind: PtrStruct
        public physx.PxBaseTaskPtr getContinuation() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            return PxBaseTaskPtr_const_PxLightCpuTaskPtr_getContinuationPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxLightCpuTask::removeReference L289-292
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxLightCpuTaskPtr, man: physx.PxLightCpuTaskPtr, kind: PtrStruct
        public void removeReference() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            void_PxLightCpuTaskPtr_removeReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxLightCpuTask::getReference L295-298
        //RET nat: int32_t, man: int, ret: True, kind: Value
        //PAR nat: PxLightCpuTaskPtr, man: physx.PxLightCpuTaskPtr, kind: PtrStruct
        public int getReference() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            return int_const_PxLightCpuTaskPtr_getReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxLightCpuTask::addReference L304-307
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxLightCpuTaskPtr, man: physx.PxLightCpuTaskPtr, kind: PtrStruct
        public void addReference() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            void_PxLightCpuTaskPtr_addReferencePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxLightCpuTask::release L314-320
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxLightCpuTaskPtr, man: physx.PxLightCpuTaskPtr, kind: PtrStruct
        public void release() {
            physx.PxLightCpuTaskPtr pvk_in_this = this;
            void_PxLightCpuTaskPtr_releasePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxLightCpuTask::operator= L222
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxLightCpuTask::operator= L222
        public static implicit operator physx.PxBaseTaskPtr(PxLightCpuTaskPtr obj) => *(physx.PxBaseTaskPtr*)&obj;
        public static explicit operator PxLightCpuTaskPtr(physx.PxBaseTaskPtr obj) => *(PxLightCpuTaskPtr*)&obj;

        //PIPING
        public void run(){((physx.PxBaseTaskPtr)this).run();}
        public string getName(){return((physx.PxBaseTaskPtr)this).getName();}
        public physx.PxTaskManagerPtr getTaskManager(){return((physx.PxBaseTaskPtr)this).getTaskManager();}
        public void setContextId(ulong id){((physx.PxBaseTaskPtr)this).setContextId(id);}
        public ulong getContextId(){return((physx.PxBaseTaskPtr)this).getContextId();}

        //Operators
    }
}
