#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxRigidDynamicLockFlag : int {
    eLOCK_LINEAR_X = 1,   // eLOCK_LINEAR_X = (1 << 0)
    eLOCK_LINEAR_Y = 2,   // eLOCK_LINEAR_Y = (1 << 1)
    eLOCK_LINEAR_Z = 4,   // eLOCK_LINEAR_Z = (1 << 2)
    eLOCK_ANGULAR_X = 8,  // eLOCK_ANGULAR_X = (1 << 3)
    eLOCK_ANGULAR_Y = 16, // eLOCK_ANGULAR_Y = (1 << 4)
    eLOCK_ANGULAR_Z = 32, // eLOCK_ANGULAR_Z = (1 << 5)
}
#endif

#if !NATIVE
public partial struct PxRigidDynamic {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidDynamicLockFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxRigidDynamicLockFlag::Enum a, physx::PxRigidDynamicLockFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxRigidDynamicLockFlag a, PxRigidDynamicLockFlag b);

public static UNPARSED_TYPE operator|(PxRigidDynamicLockFlag a, PxRigidDynamicLockFlag b){
    PxRigidDynamicLockFlag pvk_in_a = (a);
    PxRigidDynamicLockFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidDynamicLockFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxRigidDynamicLockFlag::Enum a, physx::PxRigidDynamicLockFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxRigidDynamicLockFlag a, PxRigidDynamicLockFlag b);

public static UNPARSED_TYPE operator&(PxRigidDynamicLockFlag a, PxRigidDynamicLockFlag b){
    PxRigidDynamicLockFlag pvk_in_a = (a);
    PxRigidDynamicLockFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidDynamicLockFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxRigidDynamicLockFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxRigidDynamicLockFlag a);

public static UNPARSED_TYPE operator~(PxRigidDynamicLockFlag a){
    PxRigidDynamicLockFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxRigidDynamic
#endif


#if !NATIVE
public unsafe interface IPxRigidDynamicPtr {
     void setKinematicTarget(PxTransform destination);
    // bool getKinematicTarget( target);
     bool isSleeping();
     void setSleepThreshold(float threshold);
     float getSleepThreshold();
     void setStabilizationThreshold(float threshold);
     float getStabilizationThreshold();
    // UNPARSED_TYPE getRigidDynamicLockFlags();
     void setRigidDynamicLockFlag(PxRigidDynamicLockFlag flag, bool value);
    // void setRigidDynamicLockFlags( flags);
     void setWakeCounter(float wakeCounterValue);
     float getWakeCounter();
     void wakeUp();
     void putToSleep();
     void setSolverIterationCounts(uint minPositionIters);
     void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters);
     void getSolverIterationCounts(uint* minPositionIters, uint* minVelocityIters);
     float getContactReportThreshold();
     void setContactReportThreshold(float threshold);
     IntPtr getConcreteTypeName();
    // PxRigidDynamic(ushort concreteType,  baseFlags);
    // PxRigidDynamic( baseFlags);
    // void ~PxRigidDynamic();
     bool isKindOf(string name);
    // PxRigidDynamic(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxRigidDynamicPtr lhs, /*NULLPARS*/);
    
}

public unsafe partial struct PxRigidDynamicPtr : IPxRigidActorPtr, IPxRigidBodyPtr, IPxRigidDynamicPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxRigidActorPtr, PxRigidBodyPtr, PxRigidDynamicPtr
    public static implicit operator PxRigidActorPtr(PxRigidDynamicPtr obj){return *(PxRigidActorPtr*)&obj;}
    public static explicit operator PxRigidDynamicPtr(PxRigidActorPtr obj){return *(PxRigidDynamicPtr*)&obj;}
    public static implicit operator PxRigidBodyPtr(PxRigidDynamicPtr obj){return *(PxRigidBodyPtr*)&obj;}
    public static explicit operator PxRigidDynamicPtr(PxRigidBodyPtr obj){return *(PxRigidDynamicPtr*)&obj;}
    
    // ### Piping
    
    // --- PxRigidBodyPtr
    public  void setCMassLocalPose(PxTransform pose){((PxRigidBodyPtr)this).setCMassLocalPose(pose);}
    public  PxTransform getCMassLocalPose(){return ((PxRigidBodyPtr)this).getCMassLocalPose();}
    public  void setMass(float mass){((PxRigidBodyPtr)this).setMass(mass);}
    public  float getMass(){return ((PxRigidBodyPtr)this).getMass();}
    public  float getInvMass(){return ((PxRigidBodyPtr)this).getInvMass();}
    public  void setMassSpaceInertiaTensor(PxVec3 m){((PxRigidBodyPtr)this).setMassSpaceInertiaTensor(m);}
    public  PxVec3 getMassSpaceInertiaTensor(){return ((PxRigidBodyPtr)this).getMassSpaceInertiaTensor();}
    public  PxVec3 getMassSpaceInvInertiaTensor(){return ((PxRigidBodyPtr)this).getMassSpaceInvInertiaTensor();}
    public  void setLinearDamping(float linDamp){((PxRigidBodyPtr)this).setLinearDamping(linDamp);}
    public  float getLinearDamping(){return ((PxRigidBodyPtr)this).getLinearDamping();}
    public  void setAngularDamping(float angDamp){((PxRigidBodyPtr)this).setAngularDamping(angDamp);}
    public  float getAngularDamping(){return ((PxRigidBodyPtr)this).getAngularDamping();}
    public  PxVec3 getLinearVelocity(){return ((PxRigidBodyPtr)this).getLinearVelocity();}
    public  void setLinearVelocity(PxVec3 linVel){((PxRigidBodyPtr)this).setLinearVelocity(linVel);}
    public  void setLinearVelocity(PxVec3 linVel, bool autowake){((PxRigidBodyPtr)this).setLinearVelocity(linVel, autowake);}
    public  PxVec3 getAngularVelocity(){return ((PxRigidBodyPtr)this).getAngularVelocity();}
    public  void setAngularVelocity(PxVec3 angVel){((PxRigidBodyPtr)this).setAngularVelocity(angVel);}
    public  void setAngularVelocity(PxVec3 angVel, bool autowake){((PxRigidBodyPtr)this).setAngularVelocity(angVel, autowake);}
    public  void setMaxAngularVelocity(float maxAngVel){((PxRigidBodyPtr)this).setMaxAngularVelocity(maxAngVel);}
    public  float getMaxAngularVelocity(){return ((PxRigidBodyPtr)this).getMaxAngularVelocity();}
    public  void setMaxLinearVelocity(float maxLinVel){((PxRigidBodyPtr)this).setMaxLinearVelocity(maxLinVel);}
    public  float getMaxLinearVelocity(){return ((PxRigidBodyPtr)this).getMaxLinearVelocity();}
    public  void addForce(PxVec3 force, PxForceMode mode){((PxRigidBodyPtr)this).addForce(force, mode);}
    public  void addForce(PxVec3 force){((PxRigidBodyPtr)this).addForce(force);}
    public  void addForce(PxVec3 force, PxForceMode mode, bool autowake){((PxRigidBodyPtr)this).addForce(force, mode, autowake);}
    public  void addTorque(PxVec3 torque, PxForceMode mode){((PxRigidBodyPtr)this).addTorque(torque, mode);}
    public  void addTorque(PxVec3 torque){((PxRigidBodyPtr)this).addTorque(torque);}
    public  void addTorque(PxVec3 torque, PxForceMode mode, bool autowake){((PxRigidBodyPtr)this).addTorque(torque, mode, autowake);}
    public  void clearForce(){((PxRigidBodyPtr)this).clearForce();}
    public  void clearForce(PxForceMode mode){((PxRigidBodyPtr)this).clearForce(mode);}
    public  void clearTorque(){((PxRigidBodyPtr)this).clearTorque();}
    public  void clearTorque(PxForceMode mode){((PxRigidBodyPtr)this).clearTorque(mode);}
    public  void setForceAndTorque(PxVec3 force, PxVec3 torque){((PxRigidBodyPtr)this).setForceAndTorque(force, torque);}
    public  void setForceAndTorque(PxVec3 force, PxVec3 torque, PxForceMode mode){((PxRigidBodyPtr)this).setForceAndTorque(force, torque, mode);}
    public  void setRigidBodyFlag(PxRigidBodyFlag flag, bool value){((PxRigidBodyPtr)this).setRigidBodyFlag(flag, value);}
    //public  void setRigidBodyFlags( inFlags){((PxRigidBodyPtr)this).setRigidBodyFlags(inFlags);}
    //public  UNPARSED_TYPE getRigidBodyFlags(){return ((PxRigidBodyPtr)this).getRigidBodyFlags();}
    public  void setMinCCDAdvanceCoefficient(float advanceCoefficient){((PxRigidBodyPtr)this).setMinCCDAdvanceCoefficient(advanceCoefficient);}
    public  float getMinCCDAdvanceCoefficient(){return ((PxRigidBodyPtr)this).getMinCCDAdvanceCoefficient();}
    public  void setMaxDepenetrationVelocity(float biasClamp){((PxRigidBodyPtr)this).setMaxDepenetrationVelocity(biasClamp);}
    public  float getMaxDepenetrationVelocity(){return ((PxRigidBodyPtr)this).getMaxDepenetrationVelocity();}
    public  void setMaxContactImpulse(float maxImpulse){((PxRigidBodyPtr)this).setMaxContactImpulse(maxImpulse);}
    public  float getMaxContactImpulse(){return ((PxRigidBodyPtr)this).getMaxContactImpulse();}
    public  uint getInternalIslandNodeIndex(){return ((PxRigidBodyPtr)this).getInternalIslandNodeIndex();}
    //public  PxRigidBody(ushort concreteType,  baseFlags){((PxRigidBodyPtr)this).PxRigidBody(concreteType, baseFlags);}
    //public  PxRigidBody( baseFlags){((PxRigidBodyPtr)this).PxRigidBody(baseFlags);}
    //public  void ~PxRigidBody(){((PxRigidBodyPtr)this).~PxRigidBody();}
    //public  PxRigidBody(/*NULLPARS*/){((PxRigidBodyPtr)this).PxRigidBody(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxRigidBodyPtr lhs, /*NULLPARS*/){return ((PxRigidBodyPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxRigidActorPtr
    public  void release(){((PxRigidBodyPtr)this).release();}
    public  PxTransform getGlobalPose(){return ((PxRigidBodyPtr)this).getGlobalPose();}
    public  void setGlobalPose(PxTransform pose){((PxRigidBodyPtr)this).setGlobalPose(pose);}
    public  void setGlobalPose(PxTransform pose, bool autowake){((PxRigidBodyPtr)this).setGlobalPose(pose, autowake);}
    public  bool attachShape(PxShapePtr shape){return ((PxRigidBodyPtr)this).attachShape(shape);}
    public  void detachShape(PxShapePtr shape){((PxRigidBodyPtr)this).detachShape(shape);}
    public  void detachShape(PxShapePtr shape, bool wakeOnLostTouch){((PxRigidBodyPtr)this).detachShape(shape, wakeOnLostTouch);}
    public  uint getNbShapes(){return ((PxRigidBodyPtr)this).getNbShapes();}
    //public  uint getShapes( userBuffer, uint bufferSize){return ((PxRigidBodyPtr)this).getShapes(userBuffer, bufferSize);}
    //public  uint getShapes( userBuffer, uint bufferSize, uint startIndex){return ((PxRigidBodyPtr)this).getShapes(userBuffer, bufferSize, startIndex);}
    public  uint getNbConstraints(){return ((PxRigidBodyPtr)this).getNbConstraints();}
    //public  uint getConstraints( userBuffer, uint bufferSize){return ((PxRigidBodyPtr)this).getConstraints(userBuffer, bufferSize);}
    //public  uint getConstraints( userBuffer, uint bufferSize, uint startIndex){return ((PxRigidBodyPtr)this).getConstraints(userBuffer, bufferSize, startIndex);}
    //public  PxRigidActor(ushort concreteType,  baseFlags){((PxRigidBodyPtr)this).PxRigidActor(concreteType, baseFlags);}
    //public  PxRigidActor( baseFlags){((PxRigidBodyPtr)this).PxRigidActor(baseFlags);}
    //public  void ~PxRigidActor(){((PxRigidBodyPtr)this).~PxRigidActor();}
    //public  PxRigidActor(/*NULLPARS*/){((PxRigidBodyPtr)this).PxRigidActor(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxRigidActorPtr lhs, /*NULLPARS*/){return ((PxRigidBodyPtr)this).operator=(/*NULLARGS*/);}
    

    //================================================================================
    //#       setKinematicTarget                                                     #
    //================================================================================
    #if NATIVE
    ES void W_setKinematicTarget(physx::PxRigidDynamic* self, physx::PxTransform destination){
        auto nat_in_destination = (destination);
        self->setKinematicTarget(nat_in_destination);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setKinematicTarget(PxRigidDynamicPtr selfPtr, PxTransform destination);
    
    public  void setKinematicTarget(PxTransform destination){
        PxTransform pvk_in_destination = (destination);
        W_setKinematicTarget(this, pvk_in_destination);
    }
    #endif
    
    
    //================================================================================
    //#       getKinematicTarget                                                     #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxTransform
    // NATIVE SIG: bool				getKinematicTarget(PxTransform& target)	const	= 0
    #if NATIVE
    ES bool W_getKinematicTarget(physx::PxRigidDynamic* self,  target){
        auto nat_in_target = (target);
        auto retVal = self->getKinematicTarget(nat_in_target);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getKinematicTarget(PxRigidDynamicPtr selfPtr,  target);
    
    public  bool getKinematicTarget( target){
         pvk_in_target = (target);
        bool retVal = W_getKinematicTarget(this, pvk_in_target);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isSleeping                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_isSleeping(physx::PxRigidDynamic* self){
        auto retVal = self->isSleeping();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSleeping(PxRigidDynamicPtr selfPtr);
    
    public  bool isSleeping(){
        bool retVal = W_isSleeping(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setSleepThreshold                                                      #
    //================================================================================
    #if NATIVE
    ES void W_setSleepThreshold(physx::PxRigidDynamic* self, physx::PxReal threshold){
        auto nat_in_threshold = (threshold);
        self->setSleepThreshold(nat_in_threshold);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSleepThreshold(PxRigidDynamicPtr selfPtr, float threshold);
    
    public  void setSleepThreshold(float threshold){
        float pvk_in_threshold = (threshold);
        W_setSleepThreshold(this, pvk_in_threshold);
    }
    #endif
    
    
    //================================================================================
    //#       getSleepThreshold                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getSleepThreshold(physx::PxRigidDynamic* self){
        auto retVal = self->getSleepThreshold();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getSleepThreshold(PxRigidDynamicPtr selfPtr);
    
    public  float getSleepThreshold(){
        float retVal = W_getSleepThreshold(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setStabilizationThreshold                                              #
    //================================================================================
    #if NATIVE
    ES void W_setStabilizationThreshold(physx::PxRigidDynamic* self, physx::PxReal threshold){
        auto nat_in_threshold = (threshold);
        self->setStabilizationThreshold(nat_in_threshold);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setStabilizationThreshold(PxRigidDynamicPtr selfPtr, float threshold);
    
    public  void setStabilizationThreshold(float threshold){
        float pvk_in_threshold = (threshold);
        W_setStabilizationThreshold(this, pvk_in_threshold);
    }
    #endif
    
    
    //================================================================================
    //#       getStabilizationThreshold                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getStabilizationThreshold(physx::PxRigidDynamic* self){
        auto retVal = self->getStabilizationThreshold();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getStabilizationThreshold(PxRigidDynamicPtr selfPtr);
    
    public  float getStabilizationThreshold(){
        float retVal = W_getStabilizationThreshold(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getRigidDynamicLockFlags                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidDynamicLockFlags
    // NATIVE SIG: PxRigidDynamicLockFlags getRigidDynamicLockFlags() const = 0
    #if NATIVE
    ES UNPARSED_TYPE W_getRigidDynamicLockFlags(physx::PxRigidDynamic* self){
        auto retVal = self->getRigidDynamicLockFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getRigidDynamicLockFlags(PxRigidDynamicPtr selfPtr);
    
    public  UNPARSED_TYPE getRigidDynamicLockFlags(){
        UNPARSED_TYPE retVal = W_getRigidDynamicLockFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setRigidDynamicLockFlag                                                #
    //================================================================================
    #if NATIVE
    ES void W_setRigidDynamicLockFlag(physx::PxRigidDynamic* self, physx::PxRigidDynamicLockFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setRigidDynamicLockFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidDynamicLockFlag(PxRigidDynamicPtr selfPtr, PxRigidDynamicLockFlag flag, bool value);
    
    public  void setRigidDynamicLockFlag(PxRigidDynamicLockFlag flag, bool value){
        PxRigidDynamicLockFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setRigidDynamicLockFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setRigidDynamicLockFlags                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxRigidDynamicLockFlags
    // NATIVE SIG: void				setRigidDynamicLockFlags(PxRigidDynamicLockFlags flags) = 0
    #if NATIVE
    ES void W_setRigidDynamicLockFlags(physx::PxRigidDynamic* self,  flags){
        auto nat_in_flags = (flags);
        self->setRigidDynamicLockFlags(nat_in_flags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidDynamicLockFlags(PxRigidDynamicPtr selfPtr,  flags);
    
    public  void setRigidDynamicLockFlags( flags){
         pvk_in_flags = (flags);
        W_setRigidDynamicLockFlags(this, pvk_in_flags);
    }
    #endif*/
    
    
    //================================================================================
    //#       setWakeCounter                                                         #
    //================================================================================
    #if NATIVE
    ES void W_setWakeCounter(physx::PxRigidDynamic* self, physx::PxReal wakeCounterValue){
        auto nat_in_wakeCounterValue = (wakeCounterValue);
        self->setWakeCounter(nat_in_wakeCounterValue);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setWakeCounter(PxRigidDynamicPtr selfPtr, float wakeCounterValue);
    
    public  void setWakeCounter(float wakeCounterValue){
        float pvk_in_wakeCounterValue = (wakeCounterValue);
        W_setWakeCounter(this, pvk_in_wakeCounterValue);
    }
    #endif
    
    
    //================================================================================
    //#       getWakeCounter                                                         #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getWakeCounter(physx::PxRigidDynamic* self){
        auto retVal = self->getWakeCounter();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getWakeCounter(PxRigidDynamicPtr selfPtr);
    
    public  float getWakeCounter(){
        float retVal = W_getWakeCounter(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       wakeUp                                                                 #
    //================================================================================
    #if NATIVE
    ES void W_wakeUp(physx::PxRigidDynamic* self){
        self->wakeUp();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_wakeUp(PxRigidDynamicPtr selfPtr);
    
    public  void wakeUp(){
        W_wakeUp(this);
    }
    #endif
    
    
    //================================================================================
    //#       putToSleep                                                             #
    //================================================================================
    #if NATIVE
    ES void W_putToSleep(physx::PxRigidDynamic* self){
        self->putToSleep();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_putToSleep(PxRigidDynamicPtr selfPtr);
    
    public  void putToSleep(){
        W_putToSleep(this);
    }
    #endif
    
    
    //================================================================================
    //#       setSolverIterationCounts                                               #
    //================================================================================
    #if NATIVE
    ES void W_setSolverIterationCounts(physx::PxRigidDynamic* self, physx::PxU32 minPositionIters, physx::PxU32 minVelocityIters){
        auto nat_in_minPositionIters = (minPositionIters);
        auto nat_in_minVelocityIters = (minVelocityIters);
        self->setSolverIterationCounts(nat_in_minPositionIters, nat_in_minVelocityIters);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSolverIterationCounts(PxRigidDynamicPtr selfPtr, uint minPositionIters, uint minVelocityIters);
    
    public  void setSolverIterationCounts(uint minPositionIters, uint minVelocityIters){
        uint pvk_in_minPositionIters = (minPositionIters);
        uint pvk_in_minVelocityIters = (minVelocityIters);
        W_setSolverIterationCounts(this, pvk_in_minPositionIters, pvk_in_minVelocityIters);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_setSolverIterationCounts(physx::PxRigidDynamic* self, physx::PxU32 minPositionIters){
        auto nat_in_minPositionIters = (minPositionIters);
        self->setSolverIterationCounts(nat_in_minPositionIters);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSolverIterationCounts(PxRigidDynamicPtr selfPtr, uint minPositionIters);
    
    public  void setSolverIterationCounts(uint minPositionIters){
        uint pvk_in_minPositionIters = (minPositionIters);
        W_setSolverIterationCounts(this, pvk_in_minPositionIters);
    }
    #endif
    
    
    
    //================================================================================
    //#       getSolverIterationCounts                                               #
    //================================================================================
    #if NATIVE
    ES void W_getSolverIterationCounts(physx::PxRigidDynamic* self, physx::PxU32& minPositionIters, physx::PxU32& minVelocityIters){
        auto nat_in_minPositionIters = (minPositionIters);
        auto nat_in_minVelocityIters = (minVelocityIters);
        self->getSolverIterationCounts(nat_in_minPositionIters, nat_in_minVelocityIters);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getSolverIterationCounts(PxRigidDynamicPtr selfPtr, uint* minPositionIters, uint* minVelocityIters);
    
    public  void getSolverIterationCounts(uint* minPositionIters, uint* minVelocityIters){
        uint* pvk_in_minPositionIters = (minPositionIters);
        uint* pvk_in_minVelocityIters = (minVelocityIters);
        W_getSolverIterationCounts(this, pvk_in_minPositionIters, pvk_in_minVelocityIters);
    }
    #endif
    
    
    //================================================================================
    //#       getContactReportThreshold                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getContactReportThreshold(physx::PxRigidDynamic* self){
        auto retVal = self->getContactReportThreshold();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getContactReportThreshold(PxRigidDynamicPtr selfPtr);
    
    public  float getContactReportThreshold(){
        float retVal = W_getContactReportThreshold(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setContactReportThreshold                                              #
    //================================================================================
    #if NATIVE
    ES void W_setContactReportThreshold(physx::PxRigidDynamic* self, physx::PxReal threshold){
        auto nat_in_threshold = (threshold);
        self->setContactReportThreshold(nat_in_threshold);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContactReportThreshold(PxRigidDynamicPtr selfPtr, float threshold);
    
    public  void setContactReportThreshold(float threshold){
        float pvk_in_threshold = (threshold);
        W_setContactReportThreshold(this, pvk_in_threshold);
    }
    #endif
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxRigidDynamic* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxRigidDynamicPtr selfPtr);
    
    public  IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxRigidDynamic                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidDynamic
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxRigidDynamic(PxType concreteType, PxBaseFlags baseFlags) : PxRigidBody(concreteType, baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidDynamic_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidDynamic(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidDynamic_ctor(ushort concreteType,  baseFlags);
    
    public  PxRigidDynamic(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidDynamic_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxRigidDynamic                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidDynamic
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxRigidDynamic(PxBaseFlags baseFlags) : PxRigidBody(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidDynamic_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidDynamic(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidDynamic_ctor( baseFlags);
    
    public  PxRigidDynamic( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidDynamic_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxRigidDynamic                                                        #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual							~PxRigidDynamic() {}
    #if NATIVE
    ES void W_~PxRigidDynamic(physx::PxRigidDynamic* self){
        self->~PxRigidDynamic();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxRigidDynamic(PxRigidDynamicPtr selfPtr);
    
    public  void ~PxRigidDynamic(){
        W_~PxRigidDynamic(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxRigidDynamic* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxRigidDynamicPtr selfPtr, string name);
    
    public  bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxRigidDynamic
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxRigidDynamicLockFlag is enum namespace