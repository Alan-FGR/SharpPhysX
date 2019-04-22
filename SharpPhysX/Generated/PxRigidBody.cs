// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxRigidBodyFlagsPtr OpPipe_New(physx.PxRigidBodyFlagEnum a, physx.PxRigidBodyFlagEnum b) {
        physx.PxRigidBodyFlagEnum pvk_in_a = a;
        physx.PxRigidBodyFlagEnum pvk_in_b = b;
        return PxRigidBodyFlagsPtr_operator_Ptr_Pipe_PxRigidBodyFlagEnum_PxRigidBodyFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxRigidBodyFlagsPtr OpAnd_New(physx.PxRigidBodyFlagEnum a, physx.PxRigidBodyFlagEnum b) {
        physx.PxRigidBodyFlagEnum pvk_in_a = a;
        physx.PxRigidBodyFlagEnum pvk_in_b = b;
        return PxRigidBodyFlagsPtr_operator_Ptr_Amp_PxRigidBodyFlagEnum_PxRigidBodyFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxRigidBodyFlagsPtr OpTilde_New(physx.PxRigidBodyFlagEnum a) {
        physx.PxRigidBodyFlagEnum pvk_in_a = a;
        return PxRigidBodyFlagsPtr_operator_Ptr_Tilde_PxRigidBodyFlagEnum_(pvk_in_a);
    }

    public enum PxRigidBodyFlagEnum : int {
        eKINEMATIC = 1,                              // eKINEMATIC = (1<<0)
        eUSE_KINEMATIC_TARGET_FOR_SCENE_QUERIES = 2, // eUSE_KINEMATIC_TARGET_FOR_SCENE_QUERIES = (1<<1)
        eENABLE_CCD = 4,                             // eENABLE_CCD = (1<<2)
        eENABLE_CCD_FRICTION = 8,                    // eENABLE_CCD_FRICTION = (1<<3)
        eENABLE_POSE_INTEGRATION_PREVIEW = 16,       // eENABLE_POSE_INTEGRATION_PREVIEW = (1 << 4)
        eENABLE_SPECULATIVE_CCD = 32,                // eENABLE_SPECULATIVE_CCD = (1 << 5)
        eENABLE_CCD_MAX_CONTACT_IMPULSE = 64,        // eENABLE_CCD_MAX_CONTACT_IMPULSE = (1 << 6)
        eRETAIN_ACCELERATIONS = 128,                 // eRETAIN_ACCELERATIONS = (1<<7)
    }

    public unsafe partial struct PxRigidBodyPtr : physx.PxRigidBodyPtr.IPxRigidBodyPtr, physx.PxRigidActorPtr.IPxRigidActorPtr, physx.PxActorPtr.IPxActorPtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public void setCMassLocalPose(physx.PxTransform* pose) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxTransform* pvk_in_pose = pose;
            void_PxRigidBodyPtr_setCMassLocalPosePtr_PxTransform_(pvk_in_this, pvk_in_pose);
        }

        public physx.PxTransform getCMassLocalPose() {
            physx.PxTransform RetRef;
            physx.PxRigidBodyPtr pvk_in_this = this;
            PxTransform_const_PxRigidBodyPtr_getCMassLocalPosePtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public void setMass(float mass) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_mass = mass;
            void_PxRigidBodyPtr_setMassPtr_float_(pvk_in_this, pvk_in_mass);
        }

        public float getMass() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getMassPtr(pvk_in_this);
        }

        public float getInvMass() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getInvMassPtr(pvk_in_this);
        }

        public void setMassSpaceInertiaTensor(physx.PxVec3* m) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_m = m;
            void_PxRigidBodyPtr_setMassSpaceInertiaTensorPtr_PxVec3_(pvk_in_this, pvk_in_m);
        }

        public physx.PxVec3 getMassSpaceInertiaTensor() {
            physx.PxVec3 RetRef;
            physx.PxRigidBodyPtr pvk_in_this = this;
            PxVec3_const_PxRigidBodyPtr_getMassSpaceInertiaTensorPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public physx.PxVec3 getMassSpaceInvInertiaTensor() {
            physx.PxVec3 RetRef;
            physx.PxRigidBodyPtr pvk_in_this = this;
            PxVec3_const_PxRigidBodyPtr_getMassSpaceInvInertiaTensorPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public void setLinearDamping(float linDamp) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_linDamp = linDamp;
            void_PxRigidBodyPtr_setLinearDampingPtr_float_(pvk_in_this, pvk_in_linDamp);
        }

        public float getLinearDamping() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getLinearDampingPtr(pvk_in_this);
        }

        public void setAngularDamping(float angDamp) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_angDamp = angDamp;
            void_PxRigidBodyPtr_setAngularDampingPtr_float_(pvk_in_this, pvk_in_angDamp);
        }

        public float getAngularDamping() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getAngularDampingPtr(pvk_in_this);
        }

        public physx.PxVec3 getLinearVelocity() {
            physx.PxVec3 RetRef;
            physx.PxRigidBodyPtr pvk_in_this = this;
            PxVec3_const_PxRigidBodyPtr_getLinearVelocityPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public void setLinearVelocity(physx.PxVec3* linVel, bool autowake=true) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_linVel = linVel;
            bool pvk_in_autowake = autowake;
            void_PxRigidBodyPtr_setLinearVelocityPtr_PxVec3_bool_(pvk_in_this, pvk_in_linVel, pvk_in_autowake);
        }

        public physx.PxVec3 getAngularVelocity() {
            physx.PxVec3 RetRef;
            physx.PxRigidBodyPtr pvk_in_this = this;
            PxVec3_const_PxRigidBodyPtr_getAngularVelocityPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public void setAngularVelocity(physx.PxVec3* angVel, bool autowake=true) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_angVel = angVel;
            bool pvk_in_autowake = autowake;
            void_PxRigidBodyPtr_setAngularVelocityPtr_PxVec3_bool_(pvk_in_this, pvk_in_angVel, pvk_in_autowake);
        }

        public void setMaxAngularVelocity(float maxAngVel) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_maxAngVel = maxAngVel;
            void_PxRigidBodyPtr_setMaxAngularVelocityPtr_float_(pvk_in_this, pvk_in_maxAngVel);
        }

        public float getMaxAngularVelocity() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getMaxAngularVelocityPtr(pvk_in_this);
        }

        public void setMaxLinearVelocity(float maxLinVel) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_maxLinVel = maxLinVel;
            void_PxRigidBodyPtr_setMaxLinearVelocityPtr_float_(pvk_in_this, pvk_in_maxLinVel);
        }

        public float getMaxLinearVelocity() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getMaxLinearVelocityPtr(pvk_in_this);
        }

        public void addForce(physx.PxVec3* force, physx.PxForceModeEnum mode, bool autowake=true) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_force = force;
            physx.PxForceModeEnum pvk_in_mode = mode;
            bool pvk_in_autowake = autowake;
            void_PxRigidBodyPtr_addForcePtr_PxVec3_PxForceModeEnum_bool_(pvk_in_this, pvk_in_force, pvk_in_mode, pvk_in_autowake);
        }

        public void addTorque(physx.PxVec3* torque, physx.PxForceModeEnum mode, bool autowake=true) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_torque = torque;
            physx.PxForceModeEnum pvk_in_mode = mode;
            bool pvk_in_autowake = autowake;
            void_PxRigidBodyPtr_addTorquePtr_PxVec3_PxForceModeEnum_bool_(pvk_in_this, pvk_in_torque, pvk_in_mode, pvk_in_autowake);
        }

        public void clearForce(physx.PxForceModeEnum mode) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxForceModeEnum pvk_in_mode = mode;
            void_PxRigidBodyPtr_clearForcePtr_PxForceModeEnum_(pvk_in_this, pvk_in_mode);
        }

        public void clearTorque(physx.PxForceModeEnum mode) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxForceModeEnum pvk_in_mode = mode;
            void_PxRigidBodyPtr_clearTorquePtr_PxForceModeEnum_(pvk_in_this, pvk_in_mode);
        }

        public void setForceAndTorque(physx.PxVec3* force, physx.PxVec3* torque, physx.PxForceModeEnum mode) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_force = force;
            physx.PxVec3* pvk_in_torque = torque;
            physx.PxForceModeEnum pvk_in_mode = mode;
            void_PxRigidBodyPtr_setForceAndTorquePtr_PxVec3_PxVec3_PxForceModeEnum_(pvk_in_this, pvk_in_force, pvk_in_torque, pvk_in_mode);
        }

        public void setRigidBodyFlag(physx.PxRigidBodyFlagEnum flag, bool value) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxRigidBodyFlagEnum pvk_in_flag = flag;
            bool pvk_in_value = value;
            void_PxRigidBodyPtr_setRigidBodyFlagPtr_PxRigidBodyFlagEnum_bool_(pvk_in_this, pvk_in_flag, pvk_in_value);
        }

        public void setRigidBodyFlags(physx.PxRigidBodyFlagsPtr inFlags) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxRigidBodyFlagsPtr pvk_in_inFlags = inFlags;
            void_PxRigidBodyPtr_setRigidBodyFlagsPtr_PxRigidBodyFlagsPtr_(pvk_in_this, pvk_in_inFlags);
        }

        public physx.PxRigidBodyFlagsPtr getRigidBodyFlags_New() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return PxRigidBodyFlagsPtr_const_PxRigidBodyPtr_getRigidBodyFlagsPtr(pvk_in_this);
        }

        public void setMinCCDAdvanceCoefficient(float advanceCoefficient) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_advanceCoefficient = advanceCoefficient;
            void_PxRigidBodyPtr_setMinCCDAdvanceCoefficientPtr_float_(pvk_in_this, pvk_in_advanceCoefficient);
        }

        public float getMinCCDAdvanceCoefficient() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getMinCCDAdvanceCoefficientPtr(pvk_in_this);
        }

        public void setMaxDepenetrationVelocity(float biasClamp) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_biasClamp = biasClamp;
            void_PxRigidBodyPtr_setMaxDepenetrationVelocityPtr_float_(pvk_in_this, pvk_in_biasClamp);
        }

        public float getMaxDepenetrationVelocity() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getMaxDepenetrationVelocityPtr(pvk_in_this);
        }

        public void setMaxContactImpulse(float maxImpulse) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            float pvk_in_maxImpulse = maxImpulse;
            void_PxRigidBodyPtr_setMaxContactImpulsePtr_float_(pvk_in_this, pvk_in_maxImpulse);
        }

        public float getMaxContactImpulse() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return float_const_PxRigidBodyPtr_getMaxContactImpulsePtr(pvk_in_this);
        }

        public uint getInternalIslandNodeIndex() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            return uint_const_PxRigidBodyPtr_getInternalIslandNodeIndexPtr(pvk_in_this);
        }

        public void setCMassLocalPose(physx.PxTransform pose) {
            setCMassLocalPose((physx.PxTransform*)&pose);
        }

        public void setCMassLocalPose(physx.PxTransform.Ref pose) {
            setCMassLocalPose((physx.PxTransform*)(*((IntPtr*)(&pose))));
        }

        public void setMassSpaceInertiaTensor(physx.PxVec3 m) {
            setMassSpaceInertiaTensor((physx.PxVec3*)&m);
        }

        public void setMassSpaceInertiaTensor(physx.PxVec3.Ref m) {
            setMassSpaceInertiaTensor((physx.PxVec3*)(*((IntPtr*)(&m))));
        }

        public void setLinearVelocity(physx.PxVec3 linVel) {
            setLinearVelocity((physx.PxVec3*)&linVel);
        }

        public void setLinearVelocity(physx.PxVec3.Ref linVel) {
            setLinearVelocity((physx.PxVec3*)(*((IntPtr*)(&linVel))));
        }

        public void setLinearVelocity(physx.PxVec3* linVel) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_linVel = linVel;
            void_PxRigidBodyPtr_setLinearVelocityPtr_PxVec3_(pvk_in_this, pvk_in_linVel);
        }

        public void setLinearVelocity(physx.PxVec3 linVel, bool autowake=true) {
            setLinearVelocity((physx.PxVec3*)&linVel, autowake);
        }

        public void setLinearVelocity(physx.PxVec3.Ref linVel, bool autowake=true) {
            setLinearVelocity((physx.PxVec3*)(*((IntPtr*)(&linVel))), autowake);
        }

        public void setAngularVelocity(physx.PxVec3 angVel) {
            setAngularVelocity((physx.PxVec3*)&angVel);
        }

        public void setAngularVelocity(physx.PxVec3.Ref angVel) {
            setAngularVelocity((physx.PxVec3*)(*((IntPtr*)(&angVel))));
        }

        public void setAngularVelocity(physx.PxVec3* angVel) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_angVel = angVel;
            void_PxRigidBodyPtr_setAngularVelocityPtr_PxVec3_(pvk_in_this, pvk_in_angVel);
        }

        public void setAngularVelocity(physx.PxVec3 angVel, bool autowake=true) {
            setAngularVelocity((physx.PxVec3*)&angVel, autowake);
        }

        public void setAngularVelocity(physx.PxVec3.Ref angVel, bool autowake=true) {
            setAngularVelocity((physx.PxVec3*)(*((IntPtr*)(&angVel))), autowake);
        }

        public void addForce(physx.PxVec3 force) {
            addForce((physx.PxVec3*)&force);
        }

        public void addForce(physx.PxVec3.Ref force) {
            addForce((physx.PxVec3*)(*((IntPtr*)(&force))));
        }

        public void addForce(physx.PxVec3* force) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_force = force;
            void_PxRigidBodyPtr_addForcePtr_PxVec3_(pvk_in_this, pvk_in_force);
        }

        public void addForce(physx.PxVec3 force, physx.PxForceModeEnum mode) {
            addForce((physx.PxVec3*)&force, mode);
        }

        public void addForce(physx.PxVec3.Ref force, physx.PxForceModeEnum mode) {
            addForce((physx.PxVec3*)(*((IntPtr*)(&force))), mode);
        }

        public void addForce(physx.PxVec3* force, physx.PxForceModeEnum mode) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_force = force;
            physx.PxForceModeEnum pvk_in_mode = mode;
            void_PxRigidBodyPtr_addForcePtr_PxVec3_PxForceModeEnum_(pvk_in_this, pvk_in_force, pvk_in_mode);
        }

        public void addForce(physx.PxVec3 force, physx.PxForceModeEnum mode, bool autowake=true) {
            addForce((physx.PxVec3*)&force, mode, autowake);
        }

        public void addForce(physx.PxVec3.Ref force, physx.PxForceModeEnum mode, bool autowake=true) {
            addForce((physx.PxVec3*)(*((IntPtr*)(&force))), mode, autowake);
        }

        public void addTorque(physx.PxVec3 torque) {
            addTorque((physx.PxVec3*)&torque);
        }

        public void addTorque(physx.PxVec3.Ref torque) {
            addTorque((physx.PxVec3*)(*((IntPtr*)(&torque))));
        }

        public void addTorque(physx.PxVec3* torque) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_torque = torque;
            void_PxRigidBodyPtr_addTorquePtr_PxVec3_(pvk_in_this, pvk_in_torque);
        }

        public void addTorque(physx.PxVec3 torque, physx.PxForceModeEnum mode) {
            addTorque((physx.PxVec3*)&torque, mode);
        }

        public void addTorque(physx.PxVec3.Ref torque, physx.PxForceModeEnum mode) {
            addTorque((physx.PxVec3*)(*((IntPtr*)(&torque))), mode);
        }

        public void addTorque(physx.PxVec3* torque, physx.PxForceModeEnum mode) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_torque = torque;
            physx.PxForceModeEnum pvk_in_mode = mode;
            void_PxRigidBodyPtr_addTorquePtr_PxVec3_PxForceModeEnum_(pvk_in_this, pvk_in_torque, pvk_in_mode);
        }

        public void addTorque(physx.PxVec3 torque, physx.PxForceModeEnum mode, bool autowake=true) {
            addTorque((physx.PxVec3*)&torque, mode, autowake);
        }

        public void addTorque(physx.PxVec3.Ref torque, physx.PxForceModeEnum mode, bool autowake=true) {
            addTorque((physx.PxVec3*)(*((IntPtr*)(&torque))), mode, autowake);
        }

        public void clearForce() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            void_PxRigidBodyPtr_clearForcePtr(pvk_in_this);
        }

        public void clearTorque() {
            physx.PxRigidBodyPtr pvk_in_this = this;
            void_PxRigidBodyPtr_clearTorquePtr(pvk_in_this);
        }

        public void setForceAndTorque(physx.PxVec3 force, physx.PxVec3 torque) {
            setForceAndTorque((physx.PxVec3*)&force, (physx.PxVec3*)&torque);
        }

        public void setForceAndTorque(physx.PxVec3.Ref force, physx.PxVec3.Ref torque) {
            setForceAndTorque((physx.PxVec3*)(*((IntPtr*)(&force))), (physx.PxVec3*)(*((IntPtr*)(&torque))));
        }

        public void setForceAndTorque(physx.PxVec3* force, physx.PxVec3* torque) {
            physx.PxRigidBodyPtr pvk_in_this = this;
            physx.PxVec3* pvk_in_force = force;
            physx.PxVec3* pvk_in_torque = torque;
            void_PxRigidBodyPtr_setForceAndTorquePtr_PxVec3_PxVec3_(pvk_in_this, pvk_in_force, pvk_in_torque);
        }

        public void setForceAndTorque(physx.PxVec3 force, physx.PxVec3 torque, physx.PxForceModeEnum mode) {
            setForceAndTorque((physx.PxVec3*)&force, (physx.PxVec3*)&torque, mode);
        }

        public void setForceAndTorque(physx.PxVec3.Ref force, physx.PxVec3.Ref torque, physx.PxForceModeEnum mode) {
            setForceAndTorque((physx.PxVec3*)(*((IntPtr*)(&force))), (physx.PxVec3*)(*((IntPtr*)(&torque))), mode);
        }
        public static implicit operator physx.PxRigidActorPtr(PxRigidBodyPtr obj) => *(physx.PxRigidActorPtr*)&obj;
        public static explicit operator PxRigidBodyPtr(physx.PxRigidActorPtr obj) => *(PxRigidBodyPtr*)&obj;
        public static implicit operator physx.PxActorPtr(PxRigidBodyPtr obj) => *(physx.PxActorPtr*)&obj;
        public static explicit operator PxRigidBodyPtr(physx.PxActorPtr obj) => *(PxRigidBodyPtr*)&obj;
        public static implicit operator physx.PxBasePtr(PxRigidBodyPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxRigidBodyPtr(physx.PxBasePtr obj) => *(PxRigidBodyPtr*)&obj;

        public IntPtr userData {
            get => PxActorPtr_GET_userData(this);
            set => PxActorPtr_SET_userData(this, value);
        }

        public void release(){((physx.PxRigidActorPtr)this).release();}
        public physx.PxTransform getGlobalPose(){return((physx.PxRigidActorPtr)this).getGlobalPose();}
        public void setGlobalPose(physx.PxTransform* pose, bool autowake=true){((physx.PxRigidActorPtr)this).setGlobalPose(pose, autowake);}
        public bool attachShape(physx.PxShapePtr shape){return((physx.PxRigidActorPtr)this).attachShape(shape);}
        public void detachShape(physx.PxShapePtr shape, bool wakeOnLostTouch=true){((physx.PxRigidActorPtr)this).detachShape(shape, wakeOnLostTouch);}
        public uint getNbShapes(){return((physx.PxRigidActorPtr)this).getNbShapes();}
        public uint getShapes(physx.PxShapePtr* userBuffer, uint bufferSize, uint startIndex=0){return((physx.PxRigidActorPtr)this).getShapes(userBuffer, bufferSize, startIndex);}
        public uint getNbConstraints(){return((physx.PxRigidActorPtr)this).getNbConstraints();}
        public uint getConstraints(physx.PxConstraintPtr* userBuffer, uint bufferSize, uint startIndex=0){return((physx.PxRigidActorPtr)this).getConstraints(userBuffer, bufferSize, startIndex);}
        public void setGlobalPose(physx.PxTransform pose){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)&pose);}
        public void setGlobalPose(physx.PxTransform.Ref pose){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)(*((IntPtr*)(&pose))));}
        public void setGlobalPose(physx.PxTransform* pose){((physx.PxRigidActorPtr)this).setGlobalPose(pose);}
        public void setGlobalPose(physx.PxTransform pose, bool autowake=true){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)&pose, autowake);}
        public void setGlobalPose(physx.PxTransform.Ref pose, bool autowake=true){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)(*((IntPtr*)(&pose))), autowake);}
        public void detachShape(physx.PxShapePtr shape){((physx.PxRigidActorPtr)this).detachShape(shape);}
        public uint getShapes(physx.PxShapePtr* userBuffer, uint bufferSize){return((physx.PxRigidActorPtr)this).getShapes(userBuffer, bufferSize);}
        public uint getConstraints(physx.PxConstraintPtr* userBuffer, uint bufferSize){return((physx.PxRigidActorPtr)this).getConstraints(userBuffer, bufferSize);}
        public physx.PxActorTypeEnum getType(){return((physx.PxActorPtr)this).getType();}
        public physx.PxScenePtr getScene(){return((physx.PxActorPtr)this).getScene();}
        public void setName(string name){((physx.PxActorPtr)this).setName(name);}
        public string getName(){return((physx.PxActorPtr)this).getName();}
        public physx.PxBounds3 getWorldBounds(float inflation=1.01f){return((physx.PxActorPtr)this).getWorldBounds(inflation);}
        public void setActorFlag(physx.PxActorFlagEnum flag, bool value){((physx.PxActorPtr)this).setActorFlag(flag, value);}
        public void setActorFlags(physx.PxActorFlagsPtr inFlags){((physx.PxActorPtr)this).setActorFlags(inFlags);}
        public physx.PxActorFlagsPtr getActorFlags_New(){return((physx.PxActorPtr)this).getActorFlags_New();}
        public void setDominanceGroup(byte dominanceGroup){((physx.PxActorPtr)this).setDominanceGroup(dominanceGroup);}
        public byte getDominanceGroup(){return((physx.PxActorPtr)this).getDominanceGroup();}
        public void setOwnerClient(byte inClient){((physx.PxActorPtr)this).setOwnerClient(inClient);}
        public byte getOwnerClient(){return((physx.PxActorPtr)this).getOwnerClient();}
        public physx.PxAggregatePtr getAggregate(){return((physx.PxActorPtr)this).getAggregate();}
        public physx.PxBounds3 getWorldBounds(){return((physx.PxActorPtr)this).getWorldBounds();}
        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}

        public unsafe interface IPxRigidBodyPtr {
            void setCMassLocalPose(physx.PxTransform* pose);
            physx.PxTransform getCMassLocalPose();
            void setMass(float mass);
            float getMass();
            float getInvMass();
            void setMassSpaceInertiaTensor(physx.PxVec3* m);
            physx.PxVec3 getMassSpaceInertiaTensor();
            physx.PxVec3 getMassSpaceInvInertiaTensor();
            void setLinearDamping(float linDamp);
            float getLinearDamping();
            void setAngularDamping(float angDamp);
            float getAngularDamping();
            physx.PxVec3 getLinearVelocity();
            void setLinearVelocity(physx.PxVec3* linVel, bool autowake=true);
            physx.PxVec3 getAngularVelocity();
            void setAngularVelocity(physx.PxVec3* angVel, bool autowake=true);
            void setMaxAngularVelocity(float maxAngVel);
            float getMaxAngularVelocity();
            void setMaxLinearVelocity(float maxLinVel);
            float getMaxLinearVelocity();
            void addForce(physx.PxVec3* force, physx.PxForceModeEnum mode, bool autowake=true);
            void addTorque(physx.PxVec3* torque, physx.PxForceModeEnum mode, bool autowake=true);
            void clearForce(physx.PxForceModeEnum mode);
            void clearTorque(physx.PxForceModeEnum mode);
            void setForceAndTorque(physx.PxVec3* force, physx.PxVec3* torque, physx.PxForceModeEnum mode);
            void setRigidBodyFlag(physx.PxRigidBodyFlagEnum flag, bool value);
            void setRigidBodyFlags(physx.PxRigidBodyFlagsPtr inFlags);
            physx.PxRigidBodyFlagsPtr getRigidBodyFlags_New();
            void setMinCCDAdvanceCoefficient(float advanceCoefficient);
            float getMinCCDAdvanceCoefficient();
            void setMaxDepenetrationVelocity(float biasClamp);
            float getMaxDepenetrationVelocity();
            void setMaxContactImpulse(float maxImpulse);
            float getMaxContactImpulse();
            uint getInternalIslandNodeIndex();
            void setCMassLocalPose(physx.PxTransform pose);
            void setCMassLocalPose(physx.PxTransform.Ref pose);
            void setMassSpaceInertiaTensor(physx.PxVec3 m);
            void setMassSpaceInertiaTensor(physx.PxVec3.Ref m);
            void setLinearVelocity(physx.PxVec3 linVel);
            void setLinearVelocity(physx.PxVec3.Ref linVel);
            void setLinearVelocity(physx.PxVec3* linVel);
            void setLinearVelocity(physx.PxVec3 linVel, bool autowake=true);
            void setLinearVelocity(physx.PxVec3.Ref linVel, bool autowake=true);
            void setAngularVelocity(physx.PxVec3 angVel);
            void setAngularVelocity(physx.PxVec3.Ref angVel);
            void setAngularVelocity(physx.PxVec3* angVel);
            void setAngularVelocity(physx.PxVec3 angVel, bool autowake=true);
            void setAngularVelocity(physx.PxVec3.Ref angVel, bool autowake=true);
            void addForce(physx.PxVec3 force);
            void addForce(physx.PxVec3.Ref force);
            void addForce(physx.PxVec3* force);
            void addForce(physx.PxVec3 force, physx.PxForceModeEnum mode);
            void addForce(physx.PxVec3.Ref force, physx.PxForceModeEnum mode);
            void addForce(physx.PxVec3* force, physx.PxForceModeEnum mode);
            void addForce(physx.PxVec3 force, physx.PxForceModeEnum mode, bool autowake=true);
            void addForce(physx.PxVec3.Ref force, physx.PxForceModeEnum mode, bool autowake=true);
            void addTorque(physx.PxVec3 torque);
            void addTorque(physx.PxVec3.Ref torque);
            void addTorque(physx.PxVec3* torque);
            void addTorque(physx.PxVec3 torque, physx.PxForceModeEnum mode);
            void addTorque(physx.PxVec3.Ref torque, physx.PxForceModeEnum mode);
            void addTorque(physx.PxVec3* torque, physx.PxForceModeEnum mode);
            void addTorque(physx.PxVec3 torque, physx.PxForceModeEnum mode, bool autowake=true);
            void addTorque(physx.PxVec3.Ref torque, physx.PxForceModeEnum mode, bool autowake=true);
            void clearForce();
            void clearTorque();
            void setForceAndTorque(physx.PxVec3 force, physx.PxVec3 torque);
            void setForceAndTorque(physx.PxVec3.Ref force, physx.PxVec3.Ref torque);
            void setForceAndTorque(physx.PxVec3* force, physx.PxVec3* torque);
            void setForceAndTorque(physx.PxVec3 force, physx.PxVec3 torque, physx.PxForceModeEnum mode);
            void setForceAndTorque(physx.PxVec3.Ref force, physx.PxVec3.Ref torque, physx.PxForceModeEnum mode);
        }
    }

}
