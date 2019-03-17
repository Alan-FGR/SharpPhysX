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
// SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L149~149
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
// SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L149~149
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
// SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L149~149
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
public unsafe partial struct PxRigidBody { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       setCMassLocalPose                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L180~180
    #if NATIVE
    ES void W_setCMassLocalPose(physx::PxRigidBody* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setCMassLocalPose(nat_in_pose);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setCMassLocalPose(PxRigidBody selfPtr, PxTransform pose);
    
    public void setCMassLocalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setCMassLocalPose(this, pvk_in_pose);
    }
    #endif
    
    
    //================================================================================
    //#       getCMassLocalPose                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L190~190
    #if NATIVE
    ES physx::PxTransform W_getCMassLocalPose(physx::PxRigidBody* self){
        auto retVal = self->getCMassLocalPose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getCMassLocalPose(PxRigidBody selfPtr);
    
    public PxTransform getCMassLocalPose(){
        PxTransform retVal = W_getCMassLocalPose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMass                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L212~212
    #if NATIVE
    ES void W_setMass(physx::PxRigidBody* self, physx::PxReal mass){
        auto nat_in_mass = (mass);
        self->setMass(nat_in_mass);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMass(PxRigidBody selfPtr, float mass);
    
    public void setMass(float mass){
        float pvk_in_mass = (mass);
        W_setMass(this, pvk_in_mass);
    }
    #endif
    
    
    //================================================================================
    //#       getMass                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L223~223
    #if NATIVE
    ES physx::PxReal W_getMass(physx::PxRigidBody* self){
        auto retVal = self->getMass();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMass(PxRigidBody selfPtr);
    
    public float getMass(){
        float retVal = W_getMass(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInvMass                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L232~232
    #if NATIVE
    ES physx::PxReal W_getInvMass(physx::PxRigidBody* self){
        auto retVal = self->getInvMass();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getInvMass(PxRigidBody selfPtr);
    
    public float getInvMass(){
        float retVal = W_getInvMass(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMassSpaceInertiaTensor                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L255~255
    #if NATIVE
    ES void W_setMassSpaceInertiaTensor(physx::PxRigidBody* self, physx::PxVec3 m){
        auto nat_in_m = (m);
        self->setMassSpaceInertiaTensor(nat_in_m);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMassSpaceInertiaTensor(PxRigidBody selfPtr, PxVec3 m);
    
    public void setMassSpaceInertiaTensor(PxVec3 m){
        PxVec3 pvk_in_m = (m);
        W_setMassSpaceInertiaTensor(this, pvk_in_m);
    }
    #endif
    
    
    //================================================================================
    //#       getMassSpaceInertiaTensor                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L268~268
    #if NATIVE
    ES physx::PxVec3 W_getMassSpaceInertiaTensor(physx::PxRigidBody* self){
        auto retVal = self->getMassSpaceInertiaTensor();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getMassSpaceInertiaTensor(PxRigidBody selfPtr);
    
    public PxVec3 getMassSpaceInertiaTensor(){
        PxVec3 retVal = W_getMassSpaceInertiaTensor(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getMassSpaceInvInertiaTensor                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L281~281
    #if NATIVE
    ES physx::PxVec3 W_getMassSpaceInvInertiaTensor(physx::PxRigidBody* self){
        auto retVal = self->getMassSpaceInvInertiaTensor();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getMassSpaceInvInertiaTensor(PxRigidBody selfPtr);
    
    public PxVec3 getMassSpaceInvInertiaTensor(){
        PxVec3 retVal = W_getMassSpaceInvInertiaTensor(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setLinearDamping                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L298~298
    #if NATIVE
    ES void W_setLinearDamping(physx::PxRigidBody* self, physx::PxReal linDamp){
        auto nat_in_linDamp = (linDamp);
        self->setLinearDamping(nat_in_linDamp);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearDamping(PxRigidBody selfPtr, float linDamp);
    
    public void setLinearDamping(float linDamp){
        float pvk_in_linDamp = (linDamp);
        W_setLinearDamping(this, pvk_in_linDamp);
    }
    #endif
    
    
    //================================================================================
    //#       getLinearDamping                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L307~307
    #if NATIVE
    ES physx::PxReal W_getLinearDamping(physx::PxRigidBody* self){
        auto retVal = self->getLinearDamping();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getLinearDamping(PxRigidBody selfPtr);
    
    public float getLinearDamping(){
        float retVal = W_getLinearDamping(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setAngularDamping                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L322~322
    #if NATIVE
    ES void W_setAngularDamping(physx::PxRigidBody* self, physx::PxReal angDamp){
        auto nat_in_angDamp = (angDamp);
        self->setAngularDamping(nat_in_angDamp);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularDamping(PxRigidBody selfPtr, float angDamp);
    
    public void setAngularDamping(float angDamp){
        float pvk_in_angDamp = (angDamp);
        W_setAngularDamping(this, pvk_in_angDamp);
    }
    #endif
    
    
    //================================================================================
    //#       getAngularDamping                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L331~331
    #if NATIVE
    ES physx::PxReal W_getAngularDamping(physx::PxRigidBody* self){
        auto retVal = self->getAngularDamping();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getAngularDamping(PxRigidBody selfPtr);
    
    public float getAngularDamping(){
        float retVal = W_getAngularDamping(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getLinearVelocity                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L346~346
    #if NATIVE
    ES physx::PxVec3 W_getLinearVelocity(physx::PxRigidBody* self){
        auto retVal = self->getLinearVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getLinearVelocity(PxRigidBody selfPtr);
    
    public PxVec3 getLinearVelocity(){
        PxVec3 retVal = W_getLinearVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setLinearVelocity                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L367~367
    #if NATIVE
    ES void W_setLinearVelocity(physx::PxRigidBody* self, physx::PxVec3 linVel, bool autowake){
        auto nat_in_linVel = (linVel);
        auto nat_in_autowake = (autowake);
        self->setLinearVelocity(nat_in_linVel, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearVelocity(PxRigidBody selfPtr, PxVec3 linVel, bool autowake);
    
    public void setLinearVelocity(PxVec3 linVel, bool autowake){
        PxVec3 pvk_in_linVel = (linVel);
        bool pvk_in_autowake = (autowake);
        W_setLinearVelocity(this, pvk_in_linVel, pvk_in_autowake);
    }
    #endif
    
    
    //================================================================================
    //#       getAngularVelocity                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L378~378
    #if NATIVE
    ES physx::PxVec3 W_getAngularVelocity(physx::PxRigidBody* self){
        auto retVal = self->getAngularVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getAngularVelocity(PxRigidBody selfPtr);
    
    public PxVec3 getAngularVelocity(){
        PxVec3 retVal = W_getAngularVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setAngularVelocity                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L400~400
    #if NATIVE
    ES void W_setAngularVelocity(physx::PxRigidBody* self, physx::PxVec3 angVel, bool autowake){
        auto nat_in_angVel = (angVel);
        auto nat_in_autowake = (autowake);
        self->setAngularVelocity(nat_in_angVel, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularVelocity(PxRigidBody selfPtr, PxVec3 angVel, bool autowake);
    
    public void setAngularVelocity(PxVec3 angVel, bool autowake){
        PxVec3 pvk_in_angVel = (angVel);
        bool pvk_in_autowake = (autowake);
        W_setAngularVelocity(this, pvk_in_angVel, pvk_in_autowake);
    }
    #endif
    
    
    //================================================================================
    //#       setMaxAngularVelocity                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L420~420
    #if NATIVE
    ES void W_setMaxAngularVelocity(physx::PxRigidBody* self, physx::PxReal maxAngVel){
        auto nat_in_maxAngVel = (maxAngVel);
        self->setMaxAngularVelocity(nat_in_maxAngVel);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxAngularVelocity(PxRigidBody selfPtr, float maxAngVel);
    
    public void setMaxAngularVelocity(float maxAngVel){
        float pvk_in_maxAngVel = (maxAngVel);
        W_setMaxAngularVelocity(this, pvk_in_maxAngVel);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxAngularVelocity                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L429~429
    #if NATIVE
    ES physx::PxReal W_getMaxAngularVelocity(physx::PxRigidBody* self){
        auto retVal = self->getMaxAngularVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxAngularVelocity(PxRigidBody selfPtr);
    
    public float getMaxAngularVelocity(){
        float retVal = W_getMaxAngularVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMaxLinearVelocity                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L447~447
    #if NATIVE
    ES void W_setMaxLinearVelocity(physx::PxRigidBody* self, physx::PxReal maxLinVel){
        auto nat_in_maxLinVel = (maxLinVel);
        self->setMaxLinearVelocity(nat_in_maxLinVel);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxLinearVelocity(PxRigidBody selfPtr, float maxLinVel);
    
    public void setMaxLinearVelocity(float maxLinVel){
        float pvk_in_maxLinVel = (maxLinVel);
        W_setMaxLinearVelocity(this, pvk_in_maxLinVel);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxLinearVelocity                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L456~456
    #if NATIVE
    ES physx::PxReal W_getMaxLinearVelocity(physx::PxRigidBody* self){
        auto retVal = self->getMaxLinearVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxLinearVelocity(PxRigidBody selfPtr);
    
    public float getMaxLinearVelocity(){
        float retVal = W_getMaxLinearVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       addForce                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L493~493
    #if NATIVE
    ES void W_addForce(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxForceMode::Enum mode, bool autowake){
        auto nat_in_force = (force);
        auto nat_in_mode = (mode);
        auto nat_in_autowake = (autowake);
        self->addForce(nat_in_force, nat_in_mode, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addForce(PxRigidBody selfPtr, PxVec3 force, PxForceMode mode, bool autowake);
    
    public void addForce(PxVec3 force, PxForceMode mode, bool autowake){
        PxVec3 pvk_in_force = (force);
        PxForceMode pvk_in_mode = (mode);
        bool pvk_in_autowake = (autowake);
        W_addForce(this, pvk_in_force, pvk_in_mode, pvk_in_autowake);
    }
    #endif
    
    
    //================================================================================
    //#       addTorque                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L523~523
    #if NATIVE
    ES void W_addTorque(physx::PxRigidBody* self, physx::PxVec3 torque, physx::PxForceMode::Enum mode, bool autowake){
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        auto nat_in_autowake = (autowake);
        self->addTorque(nat_in_torque, nat_in_mode, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addTorque(PxRigidBody selfPtr, PxVec3 torque, PxForceMode mode, bool autowake);
    
    public void addTorque(PxVec3 torque, PxForceMode mode, bool autowake){
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        bool pvk_in_autowake = (autowake);
        W_addTorque(this, pvk_in_torque, pvk_in_mode, pvk_in_autowake);
    }
    #endif
    
    
    //================================================================================
    //#       clearForce                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L544~544
    #if NATIVE
    ES void W_clearForce(physx::PxRigidBody* self, physx::PxForceMode::Enum mode){
        auto nat_in_mode = (mode);
        self->clearForce(nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearForce(PxRigidBody selfPtr, PxForceMode mode);
    
    public void clearForce(PxForceMode mode){
        PxForceMode pvk_in_mode = (mode);
        W_clearForce(this, pvk_in_mode);
    }
    #endif
    
    
    //================================================================================
    //#       clearTorque                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L565~565
    #if NATIVE
    ES void W_clearTorque(physx::PxRigidBody* self, physx::PxForceMode::Enum mode){
        auto nat_in_mode = (mode);
        self->clearTorque(nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearTorque(PxRigidBody selfPtr, PxForceMode mode);
    
    public void clearTorque(PxForceMode mode){
        PxForceMode pvk_in_mode = (mode);
        W_clearTorque(this, pvk_in_mode);
    }
    #endif
    
    
    //================================================================================
    //#       setForceAndTorque                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L579~579
    #if NATIVE
    ES void W_setForceAndTorque(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxVec3 torque, physx::PxForceMode::Enum mode){
        auto nat_in_force = (force);
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        self->setForceAndTorque(nat_in_force, nat_in_torque, nat_in_mode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setForceAndTorque(PxRigidBody selfPtr, PxVec3 force, PxVec3 torque, PxForceMode mode);
    
    public void setForceAndTorque(PxVec3 force, PxVec3 torque, PxForceMode mode){
        PxVec3 pvk_in_force = (force);
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        W_setForceAndTorque(this, pvk_in_force, pvk_in_torque, pvk_in_mode);
    }
    #endif
    
    
    //================================================================================
    //#       setRigidBodyFlag                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L596~596
    #if NATIVE
    ES void W_setRigidBodyFlag(physx::PxRigidBody* self, physx::PxRigidBodyFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setRigidBodyFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidBodyFlag(PxRigidBody selfPtr, PxRigidBodyFlag flag, bool value);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L597~597
    #if NATIVE
    ES void W_setRigidBodyFlags(physx::PxRigidBody* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setRigidBodyFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidBodyFlags(PxRigidBody selfPtr,  inFlags);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L608~608
    #if NATIVE
    ES UNPARSED_TYPE W_getRigidBodyFlags(physx::PxRigidBody* self){
        auto retVal = self->getRigidBodyFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getRigidBodyFlags(PxRigidBody selfPtr);
    
    public UNPARSED_TYPE getRigidBodyFlags(){
        UNPARSED_TYPE retVal = W_getRigidBodyFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setMinCCDAdvanceCoefficient                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L631~631
    #if NATIVE
    ES void W_setMinCCDAdvanceCoefficient(physx::PxRigidBody* self, physx::PxReal advanceCoefficient){
        auto nat_in_advanceCoefficient = (advanceCoefficient);
        self->setMinCCDAdvanceCoefficient(nat_in_advanceCoefficient);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinCCDAdvanceCoefficient(PxRigidBody selfPtr, float advanceCoefficient);
    
    public void setMinCCDAdvanceCoefficient(float advanceCoefficient){
        float pvk_in_advanceCoefficient = (advanceCoefficient);
        W_setMinCCDAdvanceCoefficient(this, pvk_in_advanceCoefficient);
    }
    #endif
    
    
    //================================================================================
    //#       getMinCCDAdvanceCoefficient                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L642~642
    #if NATIVE
    ES physx::PxReal W_getMinCCDAdvanceCoefficient(physx::PxRigidBody* self){
        auto retVal = self->getMinCCDAdvanceCoefficient();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinCCDAdvanceCoefficient(PxRigidBody selfPtr);
    
    public float getMinCCDAdvanceCoefficient(){
        float retVal = W_getMinCCDAdvanceCoefficient(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMaxDepenetrationVelocity                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L650~650
    #if NATIVE
    ES void W_setMaxDepenetrationVelocity(physx::PxRigidBody* self, physx::PxReal biasClamp){
        auto nat_in_biasClamp = (biasClamp);
        self->setMaxDepenetrationVelocity(nat_in_biasClamp);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxDepenetrationVelocity(PxRigidBody selfPtr, float biasClamp);
    
    public void setMaxDepenetrationVelocity(float biasClamp){
        float pvk_in_biasClamp = (biasClamp);
        W_setMaxDepenetrationVelocity(this, pvk_in_biasClamp);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxDepenetrationVelocity                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L657~657
    #if NATIVE
    ES physx::PxReal W_getMaxDepenetrationVelocity(physx::PxRigidBody* self){
        auto retVal = self->getMaxDepenetrationVelocity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxDepenetrationVelocity(PxRigidBody selfPtr);
    
    public float getMaxDepenetrationVelocity(){
        float retVal = W_getMaxDepenetrationVelocity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMaxContactImpulse                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L669~669
    #if NATIVE
    ES void W_setMaxContactImpulse(physx::PxRigidBody* self, physx::PxReal maxImpulse){
        auto nat_in_maxImpulse = (maxImpulse);
        self->setMaxContactImpulse(nat_in_maxImpulse);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxContactImpulse(PxRigidBody selfPtr, float maxImpulse);
    
    public void setMaxContactImpulse(float maxImpulse){
        float pvk_in_maxImpulse = (maxImpulse);
        W_setMaxContactImpulse(this, pvk_in_maxImpulse);
    }
    #endif
    
    
    //================================================================================
    //#       getMaxContactImpulse                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L678~678
    #if NATIVE
    ES physx::PxReal W_getMaxContactImpulse(physx::PxRigidBody* self){
        auto retVal = self->getMaxContactImpulse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxContactImpulse(PxRigidBody selfPtr);
    
    public float getMaxContactImpulse(){
        float retVal = W_getMaxContactImpulse(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInternalIslandNodeIndex                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L685~685
    #if NATIVE
    ES physx::PxU32 W_getInternalIslandNodeIndex(physx::PxRigidBody* self){
        auto retVal = self->getInternalIslandNodeIndex();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getInternalIslandNodeIndex(PxRigidBody selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L689~689
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L690~690
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L691~691
    #if NATIVE
    ES void W_~PxRigidBody(physx::PxRigidBody* self){
        self->~PxRigidBody();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxRigidBody(PxRigidBody selfPtr);
    
    public void ~PxRigidBody(){
        W_~PxRigidBody(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidBody.h L692~692
    #if NATIVE
    ES bool W_isKindOf(physx::PxRigidBody* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxRigidBody selfPtr, string name);
    
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