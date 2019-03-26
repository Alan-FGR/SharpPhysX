#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
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
#endif //enum

#if !NATIVE //functions holder
public partial struct PxRigidBodyPtr {
#endif

//================================================================================
//#       operator|(PxRigidBodyFlag a, PxRigidBodyFlag b)                        #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char> -> PxFlags_PxRigidBodyFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag_P_PxRigidBodyFlag(physx::PxRigidBodyFlag::Enum a, physx::PxRigidBodyFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag_P_PxRigidBodyFlag(PxRigidBodyFlag a, PxRigidBodyFlag b);

public static UNPARSED_TYPE operator|(PxRigidBodyFlag a, PxRigidBodyFlag b){
    PxRigidBodyFlag pvk_in_a = (a);
    PxRigidBodyFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag_P_PxRigidBodyFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxRigidBodyFlag a, PxRigidBodyFlag b)                        #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char> -> PxFlags_PxRigidBodyFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag_P_PxRigidBodyFlag(physx::PxRigidBodyFlag::Enum a, physx::PxRigidBodyFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag_P_PxRigidBodyFlag(PxRigidBodyFlag a, PxRigidBodyFlag b);

public static UNPARSED_TYPE operator&(PxRigidBodyFlag a, PxRigidBodyFlag b){
    PxRigidBodyFlag pvk_in_a = (a);
    PxRigidBodyFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag_P_PxRigidBodyFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxRigidBodyFlag a)                                           #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char> -> PxFlags_PxRigidBodyFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag(physx::PxRigidBodyFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag(PxRigidBodyFlag a);

public static UNPARSED_TYPE operator~(PxRigidBodyFlag a){
    PxRigidBodyFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxRigidBodyFlag_byte_P_PxRigidBodyFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxRigidBodyPtr
#endif


#if !NATIVE //interface
public unsafe interface IPxRigidBodyPtr {
     void setCMassLocalPose(PxTransform pose);
     PxTransform getCMassLocalPose();
     void setMass(float mass);
     float getMass();
     float getInvMass();
     void setMassSpaceInertiaTensor(PxVec3 m);
     PxVec3 getMassSpaceInertiaTensor();
     PxVec3 getMassSpaceInvInertiaTensor();
     void setLinearDamping(float linDamp);
     float getLinearDamping();
     void setAngularDamping(float angDamp);
     float getAngularDamping();
     PxVec3 getLinearVelocity();
     void setLinearVelocity(PxVec3 linVel);
     void setLinearVelocity(PxVec3 linVel, bool autowake);
     PxVec3 getAngularVelocity();
     void setAngularVelocity(PxVec3 angVel);
     void setAngularVelocity(PxVec3 angVel, bool autowake);
     void setMaxAngularVelocity(float maxAngVel);
     float getMaxAngularVelocity();
     void setMaxLinearVelocity(float maxLinVel);
     float getMaxLinearVelocity();
     void addForce(PxVec3 force, PxForceMode mode);
     void addForce(PxVec3 force);
     void addForce(PxVec3 force, PxForceMode mode, bool autowake);
     void addTorque(PxVec3 torque, PxForceMode mode);
     void addTorque(PxVec3 torque);
     void addTorque(PxVec3 torque, PxForceMode mode, bool autowake);
     void clearForce();
     void clearForce(PxForceMode mode);
     void clearTorque();
     void clearTorque(PxForceMode mode);
     void setForceAndTorque(PxVec3 force, PxVec3 torque);
     void setForceAndTorque(PxVec3 force, PxVec3 torque, PxForceMode mode);
     void setRigidBodyFlag(PxRigidBodyFlag flag, bool value);
    // void setRigidBodyFlags( inFlags);
    // UNPARSED_TYPE getRigidBodyFlags();
     void setMinCCDAdvanceCoefficient(float advanceCoefficient);
     float getMinCCDAdvanceCoefficient();
     void setMaxDepenetrationVelocity(float biasClamp);
     float getMaxDepenetrationVelocity();
     void setMaxContactImpulse(float maxImpulse);
     float getMaxContactImpulse();
     uint getInternalIslandNodeIndex();
    // static PxRigidBodyPtr New(/*NULLPARS*/);
    // static PxRigidBodyPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxRigidBody(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // static PxRigidBodyPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxRigidBodyPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxRigidBodyPtr : IPxActorPtr, IPxRigidActorPtr, IPxRigidBodyPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxRigidBodyPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxActorPtr, PxRigidActorPtr, PxRigidBodyPtr
    public static implicit operator PxActorPtr(PxRigidBodyPtr obj){return *(PxActorPtr*)&obj;}
    public static explicit operator PxRigidBodyPtr(PxActorPtr obj){return *(PxRigidBodyPtr*)&obj;}
    public static implicit operator PxRigidActorPtr(PxRigidBodyPtr obj){return *(PxRigidActorPtr*)&obj;}
    public static explicit operator PxRigidBodyPtr(PxRigidActorPtr obj){return *(PxRigidBodyPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxRigidActorPtr
    public  void release(){((PxRigidActorPtr)this).release();}
    public  PxTransform getGlobalPose(){return ((PxRigidActorPtr)this).getGlobalPose();}
    public  void setGlobalPose(PxTransform pose){((PxRigidActorPtr)this).setGlobalPose(pose);}
    public  void setGlobalPose(PxTransform pose, bool autowake){((PxRigidActorPtr)this).setGlobalPose(pose, autowake);}
    public  bool attachShape(PxShapePtr shape){return ((PxRigidActorPtr)this).attachShape(shape);}
    public  void detachShape(PxShapePtr shape){((PxRigidActorPtr)this).detachShape(shape);}
    public  void detachShape(PxShapePtr shape, bool wakeOnLostTouch){((PxRigidActorPtr)this).detachShape(shape, wakeOnLostTouch);}
    public  uint getNbShapes(){return ((PxRigidActorPtr)this).getNbShapes();}
    //public  uint getShapes( userBuffer, uint bufferSize){return ((PxRigidActorPtr)this).getShapes(userBuffer, bufferSize);}
    //public  uint getShapes( userBuffer, uint bufferSize, uint startIndex){return ((PxRigidActorPtr)this).getShapes(userBuffer, bufferSize, startIndex);}
    public  uint getNbConstraints(){return ((PxRigidActorPtr)this).getNbConstraints();}
    //public  uint getConstraints( userBuffer, uint bufferSize){return ((PxRigidActorPtr)this).getConstraints(userBuffer, bufferSize);}
    //public  uint getConstraints( userBuffer, uint bufferSize, uint startIndex){return ((PxRigidActorPtr)this).getConstraints(userBuffer, bufferSize, startIndex);}
    //public  static PxRigidActorPtr New(/*NULLPARS*/){((PxRigidActorPtr)this).PxRigidActor(/*NULLARGS*/);}
    //public  static PxRigidActorPtr New(/*NULLPARS*/){((PxRigidActorPtr)this).PxRigidActor(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxRigidActor(/*NULLPARS*/){((PxRigidActorPtr)this).~PxRigidActor(/*NULLARGS*/);}
    //public  static PxRigidActorPtr New(/*NULLPARS*/){((PxRigidActorPtr)this).PxRigidActor(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxRigidActorPtr lhs, /*NULLPARS*/){return ((PxRigidActorPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxActorPtr
    public  PxActorType getType(){return ((PxRigidActorPtr)this).getType();}
    public  PxScenePtr getScene(){return ((PxRigidActorPtr)this).getScene();}
    public  void setName(string name){((PxRigidActorPtr)this).setName(name);}
    public  string getName(){return ((PxRigidActorPtr)this).getName();}
    public  PxBounds3 getWorldBounds(){return ((PxRigidActorPtr)this).getWorldBounds();}
    public  PxBounds3 getWorldBounds(float inflation){return ((PxRigidActorPtr)this).getWorldBounds(inflation);}
    public  void setActorFlag(PxActorFlag flag, bool value){((PxRigidActorPtr)this).setActorFlag(flag, value);}
    //public  void setActorFlags( inFlags){((PxRigidActorPtr)this).setActorFlags(inFlags);}
    //public  UNPARSED_TYPE getActorFlags(){return ((PxRigidActorPtr)this).getActorFlags();}
    public  void setDominanceGroup(byte dominanceGroup){((PxRigidActorPtr)this).setDominanceGroup(dominanceGroup);}
    public  byte getDominanceGroup(){return ((PxRigidActorPtr)this).getDominanceGroup();}
    public  void setOwnerClient(byte inClient){((PxRigidActorPtr)this).setOwnerClient(inClient);}
    public  byte getOwnerClient(){return ((PxRigidActorPtr)this).getOwnerClient();}
    //public  PxAggregatePtr getAggregate(){return ((PxRigidActorPtr)this).getAggregate();}
    //public  static PxActorPtr New(/*NULLPARS*/){((PxRigidActorPtr)this).PxActor(/*NULLARGS*/);}
    //public  static PxActorPtr New(/*NULLPARS*/){((PxRigidActorPtr)this).PxActor(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActor(/*NULLPARS*/){((PxRigidActorPtr)this).~PxActor(/*NULLARGS*/);}
    //public  static PxActorPtr New(/*NULLPARS*/){((PxRigidActorPtr)this).PxActor(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorPtr lhs, /*NULLPARS*/){return ((PxRigidActorPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       setCMassLocalPose(PxTransformPtr pose)                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_setCMassLocalPose_R_void_P_PxTransform_C_PxRigidBody(physx::PxRigidBody* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setCMassLocalPose(nat_in_pose);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setCMassLocalPose_R_void_P_PxTransform_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxTransform pose);
    
    public  void setCMassLocalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setCMassLocalPose_R_void_P_PxTransform_C_PxRigidBody(this, pvk_in_pose);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getCMassLocalPose()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_getCMassLocalPose_R_PxTransform_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getCMassLocalPose;
        return *(PxTransformPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getCMassLocalPose_R_PxTransform_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  PxTransform getCMassLocalPose(){
        PxTransform retVal = W_getCMassLocalPose_R_PxTransform_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMass(float mass)                                                    #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMass_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal mass){
        auto nat_in_mass = (mass);
        self->setMass(nat_in_mass);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMass_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float mass);
    
    public  void setMass(float mass){
        float pvk_in_mass = (mass);
        W_setMass_R_void_P_float_C_PxRigidBody(this, pvk_in_mass);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMass()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMass_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMass();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMass_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getMass(){
        float retVal = W_getMass_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getInvMass()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getInvMass_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getInvMass();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getInvMass_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getInvMass(){
        float retVal = W_getInvMass_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMassSpaceInertiaTensor(PxVec3Ptr m)                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMassSpaceInertiaTensor_R_void_P_PxVec3_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 m){
        auto nat_in_m = (m);
        self->setMassSpaceInertiaTensor(nat_in_m);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMassSpaceInertiaTensor_R_void_P_PxVec3_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 m);
    
    public  void setMassSpaceInertiaTensor(PxVec3 m){
        PxVec3 pvk_in_m = (m);
        W_setMassSpaceInertiaTensor_R_void_P_PxVec3_C_PxRigidBody(this, pvk_in_m);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMassSpaceInertiaTensor()                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getMassSpaceInertiaTensor_R_PxVec3_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMassSpaceInertiaTensor;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getMassSpaceInertiaTensor_R_PxVec3_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  PxVec3 getMassSpaceInertiaTensor(){
        PxVec3 retVal = W_getMassSpaceInertiaTensor_R_PxVec3_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMassSpaceInvInertiaTensor()                                         #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getMassSpaceInvInertiaTensor_R_PxVec3_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMassSpaceInvInertiaTensor;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getMassSpaceInvInertiaTensor_R_PxVec3_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  PxVec3 getMassSpaceInvInertiaTensor(){
        PxVec3 retVal = W_getMassSpaceInvInertiaTensor_R_PxVec3_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setLinearDamping(float linDamp)                                        #
    //================================================================================
    #if NATIVE //function start
    ES void W_setLinearDamping_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal linDamp){
        auto nat_in_linDamp = (linDamp);
        self->setLinearDamping(nat_in_linDamp);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearDamping_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float linDamp);
    
    public  void setLinearDamping(float linDamp){
        float pvk_in_linDamp = (linDamp);
        W_setLinearDamping_R_void_P_float_C_PxRigidBody(this, pvk_in_linDamp);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getLinearDamping()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getLinearDamping_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getLinearDamping();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getLinearDamping_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getLinearDamping(){
        float retVal = W_getLinearDamping_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setAngularDamping(float angDamp)                                       #
    //================================================================================
    #if NATIVE //function start
    ES void W_setAngularDamping_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal angDamp){
        auto nat_in_angDamp = (angDamp);
        self->setAngularDamping(nat_in_angDamp);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularDamping_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float angDamp);
    
    public  void setAngularDamping(float angDamp){
        float pvk_in_angDamp = (angDamp);
        W_setAngularDamping_R_void_P_float_C_PxRigidBody(this, pvk_in_angDamp);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getAngularDamping()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getAngularDamping_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getAngularDamping();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getAngularDamping_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getAngularDamping(){
        float retVal = W_getAngularDamping_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getLinearVelocity()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getLinearVelocity_R_PxVec3_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getLinearVelocity;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getLinearVelocity_R_PxVec3_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  PxVec3 getLinearVelocity(){
        PxVec3 retVal = W_getLinearVelocity_R_PxVec3_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setLinearVelocity(PxVec3Ptr linVel, bool autowake)                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_setLinearVelocity_R_void_P_PxVec3_P_bool_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 linVel, bool autowake){
        auto nat_in_linVel = (linVel);
        auto nat_in_autowake = (autowake);
        self->setLinearVelocity(nat_in_linVel, nat_in_autowake);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearVelocity_R_void_P_PxVec3_P_bool_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 linVel, bool autowake);
    
    public  void setLinearVelocity(PxVec3 linVel, bool autowake){
        PxVec3 pvk_in_linVel = (linVel);
        bool pvk_in_autowake = (autowake);
        W_setLinearVelocity_R_void_P_PxVec3_P_bool_C_PxRigidBody(this, pvk_in_linVel, pvk_in_autowake);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_setLinearVelocity_R_void_P_PxVec3_OL1_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 linVel){
        auto nat_in_linVel = (linVel);
        self->setLinearVelocity(nat_in_linVel);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLinearVelocity_R_void_P_PxVec3_OL1_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 linVel);
    
    public  void setLinearVelocity(PxVec3 linVel){
        PxVec3 pvk_in_linVel = (linVel);
        W_setLinearVelocity_R_void_P_PxVec3_OL1_C_PxRigidBody(this, pvk_in_linVel);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       getAngularVelocity()                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getAngularVelocity_R_PxVec3_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getAngularVelocity;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getAngularVelocity_R_PxVec3_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  PxVec3 getAngularVelocity(){
        PxVec3 retVal = W_getAngularVelocity_R_PxVec3_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setAngularVelocity(PxVec3Ptr angVel, bool autowake)                    #
    //================================================================================
    #if NATIVE //function start
    ES void W_setAngularVelocity_R_void_P_PxVec3_P_bool_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 angVel, bool autowake){
        auto nat_in_angVel = (angVel);
        auto nat_in_autowake = (autowake);
        self->setAngularVelocity(nat_in_angVel, nat_in_autowake);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularVelocity_R_void_P_PxVec3_P_bool_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 angVel, bool autowake);
    
    public  void setAngularVelocity(PxVec3 angVel, bool autowake){
        PxVec3 pvk_in_angVel = (angVel);
        bool pvk_in_autowake = (autowake);
        W_setAngularVelocity_R_void_P_PxVec3_P_bool_C_PxRigidBody(this, pvk_in_angVel, pvk_in_autowake);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_setAngularVelocity_R_void_P_PxVec3_OL1_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 angVel){
        auto nat_in_angVel = (angVel);
        self->setAngularVelocity(nat_in_angVel);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setAngularVelocity_R_void_P_PxVec3_OL1_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 angVel);
    
    public  void setAngularVelocity(PxVec3 angVel){
        PxVec3 pvk_in_angVel = (angVel);
        W_setAngularVelocity_R_void_P_PxVec3_OL1_C_PxRigidBody(this, pvk_in_angVel);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       setMaxAngularVelocity(float maxAngVel)                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMaxAngularVelocity_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal maxAngVel){
        auto nat_in_maxAngVel = (maxAngVel);
        self->setMaxAngularVelocity(nat_in_maxAngVel);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxAngularVelocity_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float maxAngVel);
    
    public  void setMaxAngularVelocity(float maxAngVel){
        float pvk_in_maxAngVel = (maxAngVel);
        W_setMaxAngularVelocity_R_void_P_float_C_PxRigidBody(this, pvk_in_maxAngVel);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMaxAngularVelocity()                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMaxAngularVelocity_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMaxAngularVelocity();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxAngularVelocity_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getMaxAngularVelocity(){
        float retVal = W_getMaxAngularVelocity_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMaxLinearVelocity(float maxLinVel)                                  #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMaxLinearVelocity_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal maxLinVel){
        auto nat_in_maxLinVel = (maxLinVel);
        self->setMaxLinearVelocity(nat_in_maxLinVel);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxLinearVelocity_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float maxLinVel);
    
    public  void setMaxLinearVelocity(float maxLinVel){
        float pvk_in_maxLinVel = (maxLinVel);
        W_setMaxLinearVelocity_R_void_P_float_C_PxRigidBody(this, pvk_in_maxLinVel);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMaxLinearVelocity()                                                 #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMaxLinearVelocity_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMaxLinearVelocity();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxLinearVelocity_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getMaxLinearVelocity(){
        float retVal = W_getMaxLinearVelocity_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       addForce(PxVec3Ptr force, PxForceMode mode, bool autowake)             #
    //================================================================================
    #if NATIVE //function start
    ES void W_addForce_R_void_P_PxVec3_P_PxForceMode_P_bool_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxForceMode::Enum mode, bool autowake){
        auto nat_in_force = (force);
        auto nat_in_mode = (mode);
        auto nat_in_autowake = (autowake);
        self->addForce(nat_in_force, nat_in_mode, nat_in_autowake);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addForce_R_void_P_PxVec3_P_PxForceMode_P_bool_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 force, PxForceMode mode, bool autowake);
    
    public  void addForce(PxVec3 force, PxForceMode mode, bool autowake){
        PxVec3 pvk_in_force = (force);
        PxForceMode pvk_in_mode = (mode);
        bool pvk_in_autowake = (autowake);
        W_addForce_R_void_P_PxVec3_P_PxForceMode_P_bool_C_PxRigidBody(this, pvk_in_force, pvk_in_mode, pvk_in_autowake);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_addForce_R_void_P_PxVec3_P_PxForceMode_OL1_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxForceMode::Enum mode){
        auto nat_in_force = (force);
        auto nat_in_mode = (mode);
        self->addForce(nat_in_force, nat_in_mode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addForce_R_void_P_PxVec3_P_PxForceMode_OL1_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 force, PxForceMode mode);
    
    public  void addForce(PxVec3 force, PxForceMode mode){
        PxVec3 pvk_in_force = (force);
        PxForceMode pvk_in_mode = (mode);
        W_addForce_R_void_P_PxVec3_P_PxForceMode_OL1_C_PxRigidBody(this, pvk_in_force, pvk_in_mode);
    }
    #endif //function end
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_addForce_R_void_P_PxVec3_OL2_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 force){
        auto nat_in_force = (force);
        self->addForce(nat_in_force);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addForce_R_void_P_PxVec3_OL2_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 force);
    
    public  void addForce(PxVec3 force){
        PxVec3 pvk_in_force = (force);
        W_addForce_R_void_P_PxVec3_OL2_C_PxRigidBody(this, pvk_in_force);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       addTorque(PxVec3Ptr torque, PxForceMode mode, bool autowake)           #
    //================================================================================
    #if NATIVE //function start
    ES void W_addTorque_R_void_P_PxVec3_P_PxForceMode_P_bool_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 torque, physx::PxForceMode::Enum mode, bool autowake){
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        auto nat_in_autowake = (autowake);
        self->addTorque(nat_in_torque, nat_in_mode, nat_in_autowake);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addTorque_R_void_P_PxVec3_P_PxForceMode_P_bool_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 torque, PxForceMode mode, bool autowake);
    
    public  void addTorque(PxVec3 torque, PxForceMode mode, bool autowake){
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        bool pvk_in_autowake = (autowake);
        W_addTorque_R_void_P_PxVec3_P_PxForceMode_P_bool_C_PxRigidBody(this, pvk_in_torque, pvk_in_mode, pvk_in_autowake);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_addTorque_R_void_P_PxVec3_P_PxForceMode_OL1_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 torque, physx::PxForceMode::Enum mode){
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        self->addTorque(nat_in_torque, nat_in_mode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addTorque_R_void_P_PxVec3_P_PxForceMode_OL1_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 torque, PxForceMode mode);
    
    public  void addTorque(PxVec3 torque, PxForceMode mode){
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        W_addTorque_R_void_P_PxVec3_P_PxForceMode_OL1_C_PxRigidBody(this, pvk_in_torque, pvk_in_mode);
    }
    #endif //function end
    
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_addTorque_R_void_P_PxVec3_OL2_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 torque){
        auto nat_in_torque = (torque);
        self->addTorque(nat_in_torque);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addTorque_R_void_P_PxVec3_OL2_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 torque);
    
    public  void addTorque(PxVec3 torque){
        PxVec3 pvk_in_torque = (torque);
        W_addTorque_R_void_P_PxVec3_OL2_C_PxRigidBody(this, pvk_in_torque);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       clearForce(PxForceMode mode)                                           #
    //================================================================================
    #if NATIVE //function start
    ES void W_clearForce_R_void_P_PxForceMode_C_PxRigidBody(physx::PxRigidBody* self, physx::PxForceMode::Enum mode){
        auto nat_in_mode = (mode);
        self->clearForce(nat_in_mode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearForce_R_void_P_PxForceMode_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxForceMode mode);
    
    public  void clearForce(PxForceMode mode){
        PxForceMode pvk_in_mode = (mode);
        W_clearForce_R_void_P_PxForceMode_C_PxRigidBody(this, pvk_in_mode);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_clearForce_R_void_OL1_C_PxRigidBody(physx::PxRigidBody* self){
        self->clearForce();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearForce_R_void_OL1_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  void clearForce(){
        W_clearForce_R_void_OL1_C_PxRigidBody(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       clearTorque(PxForceMode mode)                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_clearTorque_R_void_P_PxForceMode_C_PxRigidBody(physx::PxRigidBody* self, physx::PxForceMode::Enum mode){
        auto nat_in_mode = (mode);
        self->clearTorque(nat_in_mode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearTorque_R_void_P_PxForceMode_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxForceMode mode);
    
    public  void clearTorque(PxForceMode mode){
        PxForceMode pvk_in_mode = (mode);
        W_clearTorque_R_void_P_PxForceMode_C_PxRigidBody(this, pvk_in_mode);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_clearTorque_R_void_OL1_C_PxRigidBody(physx::PxRigidBody* self){
        self->clearTorque();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clearTorque_R_void_OL1_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  void clearTorque(){
        W_clearTorque_R_void_OL1_C_PxRigidBody(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       setForceAndTorque(PxVec3Ptr force, PxVec3Ptr torque, PxForceMode mode) #
    //================================================================================
    #if NATIVE //function start
    ES void W_setForceAndTorque_R_void_P_PxVec3_P_PxVec3_P_PxForceMode_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxVec3 torque, physx::PxForceMode::Enum mode){
        auto nat_in_force = (force);
        auto nat_in_torque = (torque);
        auto nat_in_mode = (mode);
        self->setForceAndTorque(nat_in_force, nat_in_torque, nat_in_mode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setForceAndTorque_R_void_P_PxVec3_P_PxVec3_P_PxForceMode_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 force, PxVec3 torque, PxForceMode mode);
    
    public  void setForceAndTorque(PxVec3 force, PxVec3 torque, PxForceMode mode){
        PxVec3 pvk_in_force = (force);
        PxVec3 pvk_in_torque = (torque);
        PxForceMode pvk_in_mode = (mode);
        W_setForceAndTorque_R_void_P_PxVec3_P_PxVec3_P_PxForceMode_C_PxRigidBody(this, pvk_in_force, pvk_in_torque, pvk_in_mode);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_setForceAndTorque_R_void_P_PxVec3_P_PxVec3_OL1_C_PxRigidBody(physx::PxRigidBody* self, physx::PxVec3 force, physx::PxVec3 torque){
        auto nat_in_force = (force);
        auto nat_in_torque = (torque);
        self->setForceAndTorque(nat_in_force, nat_in_torque);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setForceAndTorque_R_void_P_PxVec3_P_PxVec3_OL1_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxVec3 force, PxVec3 torque);
    
    public  void setForceAndTorque(PxVec3 force, PxVec3 torque){
        PxVec3 pvk_in_force = (force);
        PxVec3 pvk_in_torque = (torque);
        W_setForceAndTorque_R_void_P_PxVec3_P_PxVec3_OL1_C_PxRigidBody(this, pvk_in_force, pvk_in_torque);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       setRigidBodyFlag(PxRigidBodyFlag flag, bool value)                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_setRigidBodyFlag_R_void_P_PxRigidBodyFlag_P_bool_C_PxRigidBody(physx::PxRigidBody* self, physx::PxRigidBodyFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setRigidBodyFlag(nat_in_flag, nat_in_value);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidBodyFlag_R_void_P_PxRigidBodyFlag_P_bool_C_PxRigidBody(PxRigidBodyPtr selfPtr, PxRigidBodyFlag flag, bool value);
    
    public  void setRigidBodyFlag(PxRigidBodyFlag flag, bool value){
        PxRigidBodyFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setRigidBodyFlag_R_void_P_PxRigidBodyFlag_P_bool_C_PxRigidBody(this, pvk_in_flag, pvk_in_value);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setRigidBodyFlags(Enum, byte> inFlags)                                 #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxRigidBodyFlags
    // NATIVE SIG: void				setRigidBodyFlags(PxRigidBodyFlags inFlags) = 0
    #if NATIVE //function start
    ES void W_setRigidBodyFlags_R_void_P__C_PxRigidBody(physx::PxRigidBody* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setRigidBodyFlags(nat_in_inFlags);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRigidBodyFlags_R_void_P__C_PxRigidBody(PxRigidBodyPtr selfPtr,  inFlags);
    
    public  void setRigidBodyFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setRigidBodyFlags_R_void_P__C_PxRigidBody(this, pvk_in_inFlags);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getRigidBodyFlags()                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidBodyFlags -> Enum, byte>
    // NATIVE SIG: PxRigidBodyFlags	getRigidBodyFlags()	const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getRigidBodyFlags_R_Enum, byte>_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getRigidBodyFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getRigidBodyFlags_R_Enum, byte>_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  UNPARSED_TYPE getRigidBodyFlags(){
        UNPARSED_TYPE retVal = W_getRigidBodyFlags_R_Enum, byte>_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setMinCCDAdvanceCoefficient(float advanceCoefficient)                  #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMinCCDAdvanceCoefficient_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal advanceCoefficient){
        auto nat_in_advanceCoefficient = (advanceCoefficient);
        self->setMinCCDAdvanceCoefficient(nat_in_advanceCoefficient);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinCCDAdvanceCoefficient_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float advanceCoefficient);
    
    public  void setMinCCDAdvanceCoefficient(float advanceCoefficient){
        float pvk_in_advanceCoefficient = (advanceCoefficient);
        W_setMinCCDAdvanceCoefficient_R_void_P_float_C_PxRigidBody(this, pvk_in_advanceCoefficient);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMinCCDAdvanceCoefficient()                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMinCCDAdvanceCoefficient_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMinCCDAdvanceCoefficient();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinCCDAdvanceCoefficient_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getMinCCDAdvanceCoefficient(){
        float retVal = W_getMinCCDAdvanceCoefficient_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMaxDepenetrationVelocity(float biasClamp)                           #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMaxDepenetrationVelocity_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal biasClamp){
        auto nat_in_biasClamp = (biasClamp);
        self->setMaxDepenetrationVelocity(nat_in_biasClamp);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxDepenetrationVelocity_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float biasClamp);
    
    public  void setMaxDepenetrationVelocity(float biasClamp){
        float pvk_in_biasClamp = (biasClamp);
        W_setMaxDepenetrationVelocity_R_void_P_float_C_PxRigidBody(this, pvk_in_biasClamp);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMaxDepenetrationVelocity()                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMaxDepenetrationVelocity_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMaxDepenetrationVelocity();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxDepenetrationVelocity_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getMaxDepenetrationVelocity(){
        float retVal = W_getMaxDepenetrationVelocity_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMaxContactImpulse(float maxImpulse)                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMaxContactImpulse_R_void_P_float_C_PxRigidBody(physx::PxRigidBody* self, physx::PxReal maxImpulse){
        auto nat_in_maxImpulse = (maxImpulse);
        self->setMaxContactImpulse(nat_in_maxImpulse);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaxContactImpulse_R_void_P_float_C_PxRigidBody(PxRigidBodyPtr selfPtr, float maxImpulse);
    
    public  void setMaxContactImpulse(float maxImpulse){
        float pvk_in_maxImpulse = (maxImpulse);
        W_setMaxContactImpulse_R_void_P_float_C_PxRigidBody(this, pvk_in_maxImpulse);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMaxContactImpulse()                                                 #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMaxContactImpulse_R_float_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getMaxContactImpulse();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMaxContactImpulse_R_float_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  float getMaxContactImpulse(){
        float retVal = W_getMaxContactImpulse_R_float_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getInternalIslandNodeIndex()                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getInternalIslandNodeIndex_R_uint_C_PxRigidBody(physx::PxRigidBody* self){
        auto retVal = self->getInternalIslandNodeIndex();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getInternalIslandNodeIndex_R_uint_C_PxRigidBody(PxRigidBodyPtr selfPtr);
    
    public  uint getInternalIslandNodeIndex(){
        uint retVal = W_getInternalIslandNodeIndex_R_uint_C_PxRigidBody(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxRigidBody
    
    //Skipped protected: PxRigidBody
    
    //Skipped protected: ~PxRigidBody
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxRigidBody
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxRigidBodyFlag is enum namespace