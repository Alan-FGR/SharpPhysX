#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



// Class physx::PxBVHStructure Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxRigidActorPtr {
     void release();
     PxTransform getGlobalPose();
     void setGlobalPose(PxTransform pose);
     void setGlobalPose(PxTransform pose, bool autowake);
     bool attachShape(PxShapePtr shape);
     void detachShape(PxShapePtr shape);
     void detachShape(PxShapePtr shape, bool wakeOnLostTouch);
     uint getNbShapes();
    // uint getShapes( userBuffer, uint bufferSize);
    // uint getShapes( userBuffer, uint bufferSize, uint startIndex);
     uint getNbConstraints();
    // uint getConstraints( userBuffer, uint bufferSize);
    // uint getConstraints( userBuffer, uint bufferSize, uint startIndex);
    // static PxRigidActorPtr New(/*NULLPARS*/);
    // static PxRigidActorPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxRigidActor(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // static PxRigidActorPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxRigidActorPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxRigidActorPtr : IPxBasePtr, IPxActorPtr, IPxRigidActorPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxRigidActorPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxActorPtr, PxRigidActorPtr
    public static implicit operator PxBasePtr(PxRigidActorPtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxRigidActorPtr(PxBasePtr obj){return *(PxRigidActorPtr*)&obj;}
    public static implicit operator PxActorPtr(PxRigidActorPtr obj){return *(PxActorPtr*)&obj;}
    public static explicit operator PxRigidActorPtr(PxActorPtr obj){return *(PxRigidActorPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxActorPtr
    public  PxActorType getType(){return ((PxActorPtr)this).getType();}
    public  PxScenePtr getScene(){return ((PxActorPtr)this).getScene();}
    public  void setName(string name){((PxActorPtr)this).setName(name);}
    public  string getName(){return ((PxActorPtr)this).getName();}
    public  PxBounds3 getWorldBounds(){return ((PxActorPtr)this).getWorldBounds();}
    public  PxBounds3 getWorldBounds(float inflation){return ((PxActorPtr)this).getWorldBounds(inflation);}
    public  void setActorFlag(PxActorFlag flag, bool value){((PxActorPtr)this).setActorFlag(flag, value);}
    //public  void setActorFlags( inFlags){((PxActorPtr)this).setActorFlags(inFlags);}
    //public  UNPARSED_TYPE getActorFlags(){return ((PxActorPtr)this).getActorFlags();}
    public  void setDominanceGroup(byte dominanceGroup){((PxActorPtr)this).setDominanceGroup(dominanceGroup);}
    public  byte getDominanceGroup(){return ((PxActorPtr)this).getDominanceGroup();}
    public  void setOwnerClient(byte inClient){((PxActorPtr)this).setOwnerClient(inClient);}
    public  byte getOwnerClient(){return ((PxActorPtr)this).getOwnerClient();}
    //public  PxAggregatePtr getAggregate(){return ((PxActorPtr)this).getAggregate();}
    //public  static PxActorPtr New(/*NULLPARS*/){((PxActorPtr)this).PxActor(/*NULLARGS*/);}
    //public  static PxActorPtr New(/*NULLPARS*/){((PxActorPtr)this).PxActor(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActor(/*NULLPARS*/){((PxActorPtr)this).~PxActor(/*NULLARGS*/);}
    //public  static PxActorPtr New(/*NULLPARS*/){((PxActorPtr)this).PxActor(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorPtr lhs, /*NULLPARS*/){return ((PxActorPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxBasePtr
    public  string getConcreteTypeName(){return ((PxActorPtr)this).getConcreteTypeName();}
    //public  UNPARSED_TYPE is(){return ((PxActorPtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxActorPtr)this).is();}
    public  ushort getConcreteType(){return ((PxActorPtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxActorPtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxActorPtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxActorPtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxActorPtr)this).isReleasable();}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxActorPtr)this).PxBase(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxActorPtr)this).PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxBase(/*NULLPARS*/){((PxActorPtr)this).~PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE typeMatch(/*NULLPARS*/){return ((PxActorPtr)this).typeMatch(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxActorPtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxActorPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       release()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxRigidActor(physx::PxRigidActor* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxRigidActor(PxRigidActorPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxRigidActor(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getGlobalPose()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_getGlobalPose_R_PxTransform_C_PxRigidActor(physx::PxRigidActor* self){
        auto retVal = self->getGlobalPose;
        return *(PxTransformPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getGlobalPose_R_PxTransform_C_PxRigidActor(PxRigidActorPtr selfPtr);
    
    public  PxTransform getGlobalPose(){
        PxTransform retVal = W_getGlobalPose_R_PxTransform_C_PxRigidActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setGlobalPose(PxTransformPtr pose, bool autowake)                      #
    //================================================================================
    #if NATIVE //function start
    ES void W_setGlobalPose_R_void_P_PxTransform_P_bool_C_PxRigidActor(physx::PxRigidActor* self, physx::PxTransform pose, bool autowake){
        auto nat_in_pose = (pose);
        auto nat_in_autowake = (autowake);
        self->setGlobalPose(nat_in_pose, nat_in_autowake);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGlobalPose_R_void_P_PxTransform_P_bool_C_PxRigidActor(PxRigidActorPtr selfPtr, PxTransform pose, bool autowake);
    
    public  void setGlobalPose(PxTransform pose, bool autowake){
        PxTransform pvk_in_pose = (pose);
        bool pvk_in_autowake = (autowake);
        W_setGlobalPose_R_void_P_PxTransform_P_bool_C_PxRigidActor(this, pvk_in_pose, pvk_in_autowake);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_setGlobalPose_R_void_P_PxTransform_OL1_C_PxRigidActor(physx::PxRigidActor* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setGlobalPose(nat_in_pose);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGlobalPose_R_void_P_PxTransform_OL1_C_PxRigidActor(PxRigidActorPtr selfPtr, PxTransform pose);
    
    public  void setGlobalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setGlobalPose_R_void_P_PxTransform_OL1_C_PxRigidActor(this, pvk_in_pose);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       attachShape(PxShapePtr shape)                                          #
    //================================================================================
    #if NATIVE //function start
    ES bool W_attachShape_R_bool_P_PxShapePtr_C_PxRigidActor(physx::PxRigidActor* self, physx::PxShape* shape){
        auto nat_in_shape = (shape);
        auto retVal = self->attachShape(*nat_in_shape);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_attachShape_R_bool_P_PxShapePtr_C_PxRigidActor(PxRigidActorPtr selfPtr, PxShapePtr shape);
    
    public  bool attachShape(PxShapePtr shape){
        PxShapePtr pvk_in_shape = (shape);
        bool retVal = W_attachShape_R_bool_P_PxShapePtr_C_PxRigidActor(this, pvk_in_shape);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       detachShape(PxShapePtr shape, bool wakeOnLostTouch)                    #
    //================================================================================
    #if NATIVE //function start
    ES void W_detachShape_R_void_P_PxShapePtr_P_bool_C_PxRigidActor(physx::PxRigidActor* self, physx::PxShape* shape, bool wakeOnLostTouch){
        auto nat_in_shape = (shape);
        auto nat_in_wakeOnLostTouch = (wakeOnLostTouch);
        self->detachShape(*nat_in_shape, nat_in_wakeOnLostTouch);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_detachShape_R_void_P_PxShapePtr_P_bool_C_PxRigidActor(PxRigidActorPtr selfPtr, PxShapePtr shape, bool wakeOnLostTouch);
    
    public  void detachShape(PxShapePtr shape, bool wakeOnLostTouch){
        PxShapePtr pvk_in_shape = (shape);
        bool pvk_in_wakeOnLostTouch = (wakeOnLostTouch);
        W_detachShape_R_void_P_PxShapePtr_P_bool_C_PxRigidActor(this, pvk_in_shape, pvk_in_wakeOnLostTouch);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_detachShape_R_void_P_PxShapePtr_OL1_C_PxRigidActor(physx::PxRigidActor* self, physx::PxShape* shape){
        auto nat_in_shape = (shape);
        self->detachShape(*nat_in_shape);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_detachShape_R_void_P_PxShapePtr_OL1_C_PxRigidActor(PxRigidActorPtr selfPtr, PxShapePtr shape);
    
    public  void detachShape(PxShapePtr shape){
        PxShapePtr pvk_in_shape = (shape);
        W_detachShape_R_void_P_PxShapePtr_OL1_C_PxRigidActor(this, pvk_in_shape);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       getNbShapes()                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbShapes_R_uint_C_PxRigidActor(physx::PxRigidActor* self){
        auto retVal = self->getNbShapes();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbShapes_R_uint_C_PxRigidActor(PxRigidActorPtr selfPtr);
    
    public  uint getNbShapes(){
        uint retVal = W_getNbShapes_R_uint_C_PxRigidActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getShapes(PxShape userBuffer, uint bufferSize, uint startIndex)        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: PxU32			getShapes(PxShape** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)			const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getShapes_R_uint_P__P_uint_P_uint_C_PxRigidActor(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getShapes_R_uint_P__P_uint_P_uint_C_PxRigidActor(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getShapes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getShapes_R_uint_P__P_uint_P_uint_C_PxRigidActor(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: PxU32			getShapes(PxShape** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)			const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getShapes_R_uint_P__P_uint_OL1_C_PxRigidActor(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getShapes_R_uint_P__P_uint_OL1_C_PxRigidActor(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getShapes( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getShapes_R_uint_P__P_uint_OL1_C_PxRigidActor(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       getNbConstraints()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbConstraints_R_uint_C_PxRigidActor(physx::PxRigidActor* self){
        auto retVal = self->getNbConstraints();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbConstraints_R_uint_C_PxRigidActor(PxRigidActorPtr selfPtr);
    
    public  uint getNbConstraints(){
        uint retVal = W_getNbConstraints_R_uint_C_PxRigidActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConstraints(PxConstraint userBuffer, uint bufferSize, uint startIndex) #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConstraint*
    // NATIVE SIG: PxU32			getConstraints(PxConstraint** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)		const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getConstraints_R_uint_P__P_uint_P_uint_C_PxRigidActor(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getConstraints(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConstraints_R_uint_P__P_uint_P_uint_C_PxRigidActor(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getConstraints( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getConstraints_R_uint_P__P_uint_P_uint_C_PxRigidActor(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConstraint*
    // NATIVE SIG: PxU32			getConstraints(PxConstraint** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)		const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getConstraints_R_uint_P__P_uint_OL1_C_PxRigidActor(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getConstraints(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConstraints_R_uint_P__P_uint_OL1_C_PxRigidActor(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getConstraints( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getConstraints_R_uint_P__P_uint_OL1_C_PxRigidActor(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //Skipped protected: PxRigidActor
    
    //Skipped protected: PxRigidActor
    
    //Skipped protected: ~PxRigidActor
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxRigidActor
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
