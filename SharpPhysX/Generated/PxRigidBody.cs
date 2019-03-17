#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxRigidBodyFlag : int {
    eKINEMATIC = 1,                              // eKINEMATIC = (1<<0)
    eUSE_KINEMATIC_TARGET_FOR_SCENE_QUERIES = 2, // eUSE_KINEMATIC_TARGET_FOR_SCENE_QUERIES = (1<<1)
    eENABLE_CCD = 4,                             // eENABLE_CCD = (1<<2)
    eENABLE_CCD_FRICTION = 8,                    // eENABLE_CCD_FRICTION = (1<<3)
    eENABLE_POSE_INTEGRATION_PREVIEW = 16,       // eENABLE_POSE_INTEGRATION_PREVIEW = (1 << 4)
    eENABLE_SPECULATIVE_CCD = 32,                // eENABLE_SPECULATIVE_CCD = (1 << 5)
    eENABLE_CCD_MAX_CONTACT_IMPULSE = 64,        // eENABLE_CCD_MAX_CONTACT_IMPULSE = (1 << 6)
    eRETAIN_ACCELERATIONS = 128,                 // eRETAIN_ACCELERATIONS = (1<<7)
}
#endif

#if !NATIVE
public partial struct PxRigidBody {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxRigidBodyFlag::Enum a, physx::PxRigidBodyFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxRigidBodyFlag a, PxRigidBodyFlag b);

public static UNPARSED_TYPE operator|(PxRigidBodyFlag a, PxRigidBodyFlag b){
    PxRigidBodyFlag pvk_in_a = (a);
    PxRigidBodyFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxRigidBodyFlag::Enum a, physx::PxRigidBodyFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxRigidBodyFlag a, PxRigidBodyFlag b);

public static UNPARSED_TYPE operator&(PxRigidBodyFlag a, PxRigidBodyFlag b){
    PxRigidBodyFlag pvk_in_a = (a);
    PxRigidBodyFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxRigidBodyFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxRigidBodyFlag a);

public static UNPARSED_TYPE operator~(PxRigidBodyFlag a){
    PxRigidBodyFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxRigidBody
#endif


#if !NATIVE
public unsafe partial struct PxRigidBodyPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       setCMassLocalPose                                                      #
    //================================================================================
    #if NATIVE
    ES void W_setCMassLocalPose(physx::PxRigidBody* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setCMassLocalPose(nat_in_pose);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setCMassLocalPose(PxRigidBodyPtr selfPtr, PxTransform pose);
    
    public void setCMassLocalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setCMassLocalPose(this, pvk_in_pose);
    }
    #endif
    
    
    //================================================================================
    //#       getCMassLocalPose                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_getCMassLocalPose(physx::PxRigidBody* self){
        auto retVal = self->getCMassLocalPose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getCMassLocalPose(PxRigidBodyPtr selfPtr);
    
    public PxTransform getCMassLocalPose(){
        PxTransform retVal = W_getCMassLocalPose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMass                                                                #
    //================================================================================
    #if NATIVE
    ES void W_setMass(physx::PxRigidBody* self, physx::PxReal mass){
        auto nat_in_mass = (mass);
        self->setMass(nat_in_mass);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMass(PxRigidBodyPtr selfPtr, float mass);
    
    public void setMass(float mass){
        float pvk_in_mass = (mass);
        W_setMass(this, pvk_in_mass);
    }
    #endif
    
    
    //================================================================================
    //#       getMass                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMass(physx::PxRigidBody* self){
        auto retVal = self->getMass();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMass(PxRigidBodyPtr selfPtr);
    
    public float getMass(){
        float retVal = W_getMass(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInvMass                                                             #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getInvMass(physx::PxRigidBody* self){
        auto retVal = self->getInvMass();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getInvMass(PxRigidBodyPtr selfPtr);
    
    public float getInvMass(){
        float retVal = W_getInvMass(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMassSpaceInertiaTensor                                              #
    //================================================================================
    #if NATIVE
    ES void W_setMassSpaceInertiaTensor(physx::PxRigidBody* self, physx::PxVec3 m){
        auto nat_in_m = (m);
        self->setMassSpaceInertiaTensor(nat_in_m);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMassSpaceInertiaTensor(PxRigidBodyPtr selfPtr, PxVec3 m);
    
    public void setMassSpaceInertiaTensor(PxVec3 m){
        PxVec3 pvk_in_m = (m);
        W_setMassSpaceInertiaTensor(this, pvk_in_m);
    }
    #endif
    
    
    //================================================================================
    //#       getMassSpaceInertiaTensor                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getMassSpaceInertiaTensor(physx::PxRigidBody* self){
        auto retVal = self->getMassSpaceInertiaTensor();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getMassSpaceInertiaTensor(PxRigidBodyPtr selfPtr);
    
    public PxVec3 getMassSpaceInertiaTensor(){
        PxVec3 retVal = W_getMassSpaceInertiaTensor(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getMassSpaceInvInertiaTensor                                           #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getMassSpaceInvInertiaTensor(physx::PxRigidBody* self){
        auto retVal = self->getMassSpaceInvInertiaTensor();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getMassSpaceInvInertiaTensor(PxRigidBodyPtr selfPtr);
    
    public PxVec3 getMassSpaceInvInertiaTensor(){
        PxVec3 retVal = W_getMassSpaceInvInertiaTensor(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setLinearDamping                                                       #
    //================================================================================
    #if NATIVE
    ES void W_setLinearDamping(physx::PxRigidBody* self, physx::PxReal linDamp){
        auto nat_in_linDamp = (linDamp);
        self->setLinearDamping(nat_in_linDamp);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearDamping(PxRigidBodyPtr selfPtr, float linDamp);
    
    public void setLinearDamping(float linDamp){
        float pvk_in_linDamp = (linDamp);
        W_setLinearDamping(this, pvk_in_linDamp);
    }
    #endif
    
    
    //================================================================================
    //#       getLinearDamping                                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getLinearDamping(physx::PxRigidBody* self){
        auto retVal = self->getLinearDamping();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getLinearDamping(PxRigidBodyPtr selfPtr);
    
    public float getLinearDamping(){
        float retVal = W_getLinearDamping(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setAngularDamping                                                      #
    //================================================================================
    #if NATIVE
    ES void W_setAngularDamping(physx::PxRigidBody* self, physx::PxReal angDamp){
        auto nat_in_angDamp = (angDamp);
        self->setAngularDamping(nat_in_angDamp);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularDamping(PxRigidBodyPtr selfPtr, float angDamp);
    
    public void setAngularDamping(float angDamp){
        float pvk_in_angDamp = (angDamp);
        W_setAngularDamping(this, pvk_in_angDamp);
    }
    #endif
    
    
    //================================================================================
    //#       getAngularDamping                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getAngularDamping(physx::PxRigidBody* self){
        auto retVal = self->getAngularDamping();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getAngularDamping(PxRigidBodyPtr selfPtr);
    
    public float getAngularDamping(){
        float retVal = W_getAngularDamping(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getLinearVelocity                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getLinearVelocity(physx::PxRigidBody* self){
        auto retVal = self->getLinearVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getLinearVelocity(PxRigidBodyPtr selfPtr);
    
    public PxVec3 getLinearVelocity(){
        PxVec3 retVal = W_getLinearVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setLinearVelocity                                                      #
    //================================================================================
    #if NATIVE
    ES void W_setLinearVelocity(physx::PxRigidBody* self, physx::PxVec3 linVel, bool autowake){
        auto nat_in_linVel = (linVel);
        auto nat_in_autowake = (autowake);
        self->setLinearVelocity(nat_in_linVel, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearVelocity(PxRigidBodyPtr selfPtr, PxVec3 linVel, bool autowake);
    
    public void setLinearVelocity(PxVec3 linVel, bool autowake){
        PxVec3 pvk_in_linVel = (linVel);
        bool pvk_in_autowake = (autowake);
        W_setLinearVelocity(this, pvk_in_linVel, pvk_in_autowake);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_setLinearVelocity_OL1(physx::PxRigidBody* self, physx::PxVec3 linVel){
        auto nat_in_linVel = (linVel);
        self->setLinearVelocity(nat_in_linVel);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearVelocity_OL1(PxRigidBodyPtr selfPtr, PxVec3 linVel);
    
    public void setLinearVelocity(PxVec3 linVel){
        PxVec3 pvk_in_linVel = (linVel);
        W_setLinearVelocity_OL1(this, pvk_in_linVel);
    }
    #endif
    
    
    
    //================================================================================
    //#       getAngularVelocity                                                     #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getAngularVelocity(physx::PxRigidBody* self){
        auto retVal = self->getAngularVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getAngularVelocity(PxRigidBodyPtr selfPtr);
    
    public PxVec3 getAngularVelocity(){
        PxVec3 retVal = W_getAngularVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setAngularVelocity                                                     #
    //================================================================================
    #if NATIVE
    ES void W_setAngularVelocity(physx::PxRigidBody* self, physx::PxVec3 angVel, bool autowake){
        auto nat_in_angVel = (angVel);
        auto nat_in_autowake = (autowake);
        self->setAngularVelocity(nat_in_angVel, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularVelocity(PxRigidBodyPtr selfPtr, PxVec3 angVel, bool autowake);
    
    public void setAngularVelocity(PxVec3 angVel, bool autowake){
        PxVec3 pvk_in_angVel = (angVel);
        bool pvk_in_autowake = (autowake);
        W_setAngularVelocity(this, pvk_in_angVel, pvk_in_autowake);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_setAngularVelocity_OL1(physx::PxRigidBody* self, physx::PxVec3 angVel){
        auto nat_in_angVel = (angVel);
        self->setAngularVelocity(nat_in_angVel);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularVelocity_OL1(PxRigidBodyPtr selfPtr, PxVec3 angVel);
    
    public void setAngularVelocity(PxVec3 angVel){
        PxVec3 pvk_in_angVel = (angVel);
        W_setAngularVelocity_OL1(this, pvk_in_angVel);
    }
    #endif
    
    
    
    //================================================================================
    //#       setMaxAngularVelocity                                                  #
    //================================================================================
    #if NATIVE
    ES void W_setMaxAngularVelocity(physx::PxRigidBody* self, physx::PxReal maxAngVel){
        auto nat_in_maxAngVel = (maxAngVel);
        self->setMaxAngularVelocity(nat_in_maxAngVel);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxAngularVelocity(PxRigidBodyPtr selfPtr, float maxAngVel);
    
    public void setMaxAngularVelocity(float maxAngVel){
        float pvk_in_maxAngVel = (maxAngVel);
        W_setMaxAngularVelocity(this, pvk_in_maxAngVel);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxAngularVelocity                                                  #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMaxAngularVelocity(physx::PxRigidBody* self){
        auto retVal = self->getMaxAngularVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxAngularVelocity(PxRigidBodyPtr selfPtr);
    
    public float getMaxAngularVelocity(){
        float retVal = W_getMaxAngularVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMaxLinearVelocity                                                   #
    //================================================================================
    #if NATIVE
    ES void W_setMaxLinearVelocity(physx::PxRigidBody* self, physx::PxReal maxLinVel){
        auto nat_in_maxLinVel = (maxLinVel);
        self->setMaxLinearVelocity(nat_in_maxLinVel);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxLinearVelocity(PxRigidBodyPtr selfPtr, float maxLinVel);
    
    public void setMaxLinearVelocity(float maxLinVel){
        float pvk_in_maxLinVel = (maxLinVel);
        W_setMaxLinearVelocity(this, pvk_in_maxLinVel);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxLinearVelocity                                                   #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMaxLinearVelocity(physx::PxRigidBody* self){
        auto retVal = self->getMaxLinearVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxLinearVelocity(PxRigidBodyPtr selfPtr);
    
    public float getMaxLinearVelocity(){
        float retVal = W_getMaxLinearVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       addForce                                                               #
    //================================================================================
    #if NATIVE
    ES void W_addForce(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxForceMode::Enum mode, bool autowake){
        auto nat_in_force = (force);
        auto nat_in_mode = (mode);
        auto nat_in_autowake = (autowake);
        self->addForce(nat_in_force, nat_in_mode, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addForce(PxRigidBodyPtr selfPtr, PxVec3 force, PxForceMode mode, bool autowake);
    
    public void addForce(PxVec3 force, PxForceMode mode, bool autowake){
        PxVec3 pvk_in_force = (force);
        PxForceMode pvk_in_mode = (mode);
        bool pvk_in_autowake = (autowake);
        W_addForce(this, pvk_in_force, pvk_in_mode, pvk_in_autowake);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_addForce_OL1(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxForceMode::Enum mode){
        auto nat_in_force = (force);
        auto nat_in_mode = (mode);
        self->addForce(nat_in_force, nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addForce_OL1(PxRigidBodyPtr selfPtr, PxVec3 force, PxForceMode mode);
    
    public void addForce(PxVec3 force, PxForceMode mode){
        PxVec3 pvk_in_force = (force);
        PxForceMode pvk_in_mode = (mode);
        W_addForce_OL1(this, pvk_in_force, pvk_in_mode);
    }
    #endif
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_addForce_OL2(physx::PxRigidBody* self, physx::PxVec3 force){
        auto nat_in_force = (force);
        self->addForce(nat_in_force);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addForce_OL2(PxRigidBodyPtr selfPtr, PxVec3 force);
    
    public void addForce(PxVec3 force){
        PxVec3 pvk_in_force = (force);
        W_addForce_OL2(this, pvk_in_force);
    }
    #endif
    
    
    
    //================================================================================
    //#       addTorque                                                              #
    //================================================================================
    #if NATIVE
    ES void W_addTorque(physx::PxRigidBody* self, physx::PxVec3 torque, physx::PxForceMode::Enum mode, bool autowake){
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        auto nat_in_autowake = (autowake);
        self->addTorque(nat_in_torque, nat_in_mode, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addTorque(PxRigidBodyPtr selfPtr, PxVec3 torque, PxForceMode mode, bool autowake);
    
    public void addTorque(PxVec3 torque, PxForceMode mode, bool autowake){
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        bool pvk_in_autowake = (autowake);
        W_addTorque(this, pvk_in_torque, pvk_in_mode, pvk_in_autowake);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_addTorque_OL1(physx::PxRigidBody* self, physx::PxVec3 torque, physx::PxForceMode::Enum mode){
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        self->addTorque(nat_in_torque, nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addTorque_OL1(PxRigidBodyPtr selfPtr, PxVec3 torque, PxForceMode mode);
    
    public void addTorque(PxVec3 torque, PxForceMode mode){
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        W_addTorque_OL1(this, pvk_in_torque, pvk_in_mode);
    }
    #endif
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_addTorque_OL2(physx::PxRigidBody* self, physx::PxVec3 torque){
        auto nat_in_torque = (torque);
        self->addTorque(nat_in_torque);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addTorque_OL2(PxRigidBodyPtr selfPtr, PxVec3 torque);
    
    public void addTorque(PxVec3 torque){
        PxVec3 pvk_in_torque = (torque);
        W_addTorque_OL2(this, pvk_in_torque);
    }
    #endif
    
    
    
    //================================================================================
    //#       clearForce                                                             #
    //================================================================================
    #if NATIVE
    ES void W_clearForce(physx::PxRigidBody* self, physx::PxForceMode::Enum mode){
        auto nat_in_mode = (mode);
        self->clearForce(nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearForce(PxRigidBodyPtr selfPtr, PxForceMode mode);
    
    public void clearForce(PxForceMode mode){
        PxForceMode pvk_in_mode = (mode);
        W_clearForce(this, pvk_in_mode);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_clearForce_OL1(physx::PxRigidBody* self){
        self->clearForce();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearForce_OL1(PxRigidBodyPtr selfPtr);
    
    public void clearForce(){
        W_clearForce_OL1(this);
    }
    #endif
    
    
    
    //================================================================================
    //#       clearTorque                                                            #
    //================================================================================
    #if NATIVE
    ES void W_clearTorque(physx::PxRigidBody* self, physx::PxForceMode::Enum mode){
        auto nat_in_mode = (mode);
        self->clearTorque(nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearTorque(PxRigidBodyPtr selfPtr, PxForceMode mode);
    
    public void clearTorque(PxForceMode mode){
        PxForceMode pvk_in_mode = (mode);
        W_clearTorque(this, pvk_in_mode);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_clearTorque_OL1(physx::PxRigidBody* self){
        self->clearTorque();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearTorque_OL1(PxRigidBodyPtr selfPtr);
    
    public void clearTorque(){
        W_clearTorque_OL1(this);
    }
    #endif
    
    
    
    //================================================================================
    //#       setForceAndTorque                                                      #
    //================================================================================
    #if NATIVE
    ES void W_setForceAndTorque(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxVec3 torque, physx::PxForceMode::Enum mode){
        auto nat_in_force = (force);
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        self->setForceAndTorque(nat_in_force, nat_in_torque, nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setForceAndTorque(PxRigidBodyPtr selfPtr, PxVec3 force, PxVec3 torque, PxForceMode mode);
    
    public void setForceAndTorque(PxVec3 force, PxVec3 torque, PxForceMode mode){
        PxVec3 pvk_in_force = (force);
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        W_setForceAndTorque(this, pvk_in_force, pvk_in_torque, pvk_in_mode);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_setForceAndTorque_OL1(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxVec3 torque){
        auto nat_in_force = (force);
        auto nat_in_torque = (torque);
        self->setForceAndTorque(nat_in_force, nat_in_torque);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setForceAndTorque_OL1(PxRigidBodyPtr selfPtr, PxVec3 force, PxVec3 torque);
    
    public void setForceAndTorque(PxVec3 force, PxVec3 torque){
        PxVec3 pvk_in_force = (force);
        PxVec3 pvk_in_torque = (torque);
        W_setForceAndTorque_OL1(this, pvk_in_force, pvk_in_torque);
    }
    #endif
    
    
    
    //================================================================================
    //#       setRigidBodyFlag                                                       #
    //================================================================================
    #if NATIVE
    ES void W_setRigidBodyFlag(physx::PxRigidBody* self, physx::PxRigidBodyFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setRigidBodyFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidBodyFlag(PxRigidBodyPtr selfPtr, PxRigidBodyFlag flag, bool value);
    
    public void setRigidBodyFlag(PxRigidBodyFlag flag, bool value){
        PxRigidBodyFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setRigidBodyFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setRigidBodyFlags                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxRigidBodyFlags
    // NATIVE SIG: void				setRigidBodyFlags(PxRigidBodyFlags inFlags) = 0
    #if NATIVE
    ES void W_setRigidBodyFlags(physx::PxRigidBody* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setRigidBodyFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidBodyFlags(PxRigidBodyPtr selfPtr,  inFlags);
    
    public void setRigidBodyFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setRigidBodyFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getRigidBodyFlags                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidBodyFlags
    // NATIVE SIG: PxRigidBodyFlags	getRigidBodyFlags()	const = 0
    #if NATIVE
    ES UNPARSED_TYPE W_getRigidBodyFlags(physx::PxRigidBody* self){
        auto retVal = self->getRigidBodyFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getRigidBodyFlags(PxRigidBodyPtr selfPtr);
    
    public UNPARSED_TYPE getRigidBodyFlags(){
        UNPARSED_TYPE retVal = W_getRigidBodyFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setMinCCDAdvanceCoefficient                                            #
    //================================================================================
    #if NATIVE
    ES void W_setMinCCDAdvanceCoefficient(physx::PxRigidBody* self, physx::PxReal advanceCoefficient){
        auto nat_in_advanceCoefficient = (advanceCoefficient);
        self->setMinCCDAdvanceCoefficient(nat_in_advanceCoefficient);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinCCDAdvanceCoefficient(PxRigidBodyPtr selfPtr, float advanceCoefficient);
    
    public void setMinCCDAdvanceCoefficient(float advanceCoefficient){
        float pvk_in_advanceCoefficient = (advanceCoefficient);
        W_setMinCCDAdvanceCoefficient(this, pvk_in_advanceCoefficient);
    }
    #endif
    
    
    //================================================================================
    //#       getMinCCDAdvanceCoefficient                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMinCCDAdvanceCoefficient(physx::PxRigidBody* self){
        auto retVal = self->getMinCCDAdvanceCoefficient();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinCCDAdvanceCoefficient(PxRigidBodyPtr selfPtr);
    
    public float getMinCCDAdvanceCoefficient(){
        float retVal = W_getMinCCDAdvanceCoefficient(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMaxDepenetrationVelocity                                            #
    //================================================================================
    #if NATIVE
    ES void W_setMaxDepenetrationVelocity(physx::PxRigidBody* self, physx::PxReal biasClamp){
        auto nat_in_biasClamp = (biasClamp);
        self->setMaxDepenetrationVelocity(nat_in_biasClamp);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxDepenetrationVelocity(PxRigidBodyPtr selfPtr, float biasClamp);
    
    public void setMaxDepenetrationVelocity(float biasClamp){
        float pvk_in_biasClamp = (biasClamp);
        W_setMaxDepenetrationVelocity(this, pvk_in_biasClamp);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxDepenetrationVelocity                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMaxDepenetrationVelocity(physx::PxRigidBody* self){
        auto retVal = self->getMaxDepenetrationVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxDepenetrationVelocity(PxRigidBodyPtr selfPtr);
    
    public float getMaxDepenetrationVelocity(){
        float retVal = W_getMaxDepenetrationVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMaxContactImpulse                                                   #
    //================================================================================
    #if NATIVE
    ES void W_setMaxContactImpulse(physx::PxRigidBody* self, physx::PxReal maxImpulse){
        auto nat_in_maxImpulse = (maxImpulse);
        self->setMaxContactImpulse(nat_in_maxImpulse);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxContactImpulse(PxRigidBodyPtr selfPtr, float maxImpulse);
    
    public void setMaxContactImpulse(float maxImpulse){
        float pvk_in_maxImpulse = (maxImpulse);
        W_setMaxContactImpulse(this, pvk_in_maxImpulse);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxContactImpulse                                                   #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMaxContactImpulse(physx::PxRigidBody* self){
        auto retVal = self->getMaxContactImpulse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxContactImpulse(PxRigidBodyPtr selfPtr);
    
    public float getMaxContactImpulse(){
        float retVal = W_getMaxContactImpulse(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInternalIslandNodeIndex                                             #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getInternalIslandNodeIndex(physx::PxRigidBody* self){
        auto retVal = self->getInternalIslandNodeIndex();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getInternalIslandNodeIndex(PxRigidBodyPtr selfPtr);
    
    public uint getInternalIslandNodeIndex(){
        uint retVal = W_getInternalIslandNodeIndex(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxRigidBody                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidBody
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidBody(PxType concreteType, PxBaseFlags baseFlags) : PxRigidActor(concreteType, baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidBody_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidBody(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidBody_ctor(ushort concreteType,  baseFlags);
    
    public PxRigidBody(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidBody_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxRigidBody                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidBody
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidBody(PxBaseFlags baseFlags) : PxRigidActor(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidBody_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidBody(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidBody_ctor( baseFlags);
    
    public PxRigidBody( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidBody_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxRigidBody                                                           #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxRigidBody()	{}
    #if NATIVE
    ES void W_~PxRigidBody(physx::PxRigidBody* self){
        self->~PxRigidBody();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public void ~PxRigidBody(){
        W_~PxRigidBody(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxRigidBody* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxRigidBodyPtr selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxRigidBody
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxRigidBodyFlag is enum namespace