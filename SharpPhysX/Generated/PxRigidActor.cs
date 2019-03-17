#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



// Class physx::PxBVHStructure Manually Ignored
#if !NATIVE
public unsafe partial struct PxRigidActorPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxRigidActor* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxRigidActorPtr selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getGlobalPose                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_getGlobalPose(physx::PxRigidActor* self){
        auto retVal = self->getGlobalPose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getGlobalPose(PxRigidActorPtr selfPtr);
    
    public PxTransform getGlobalPose(){
        PxTransform retVal = W_getGlobalPose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setGlobalPose                                                          #
    //================================================================================
    #if NATIVE
    ES void W_setGlobalPose(physx::PxRigidActor* self, physx::PxTransform pose, bool autowake){
        auto nat_in_pose = (pose);
        auto nat_in_autowake = (autowake);
        self->setGlobalPose(nat_in_pose, nat_in_autowake);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGlobalPose(PxRigidActorPtr selfPtr, PxTransform pose, bool autowake);
    
    public void setGlobalPose(PxTransform pose, bool autowake){
        PxTransform pvk_in_pose = (pose);
        bool pvk_in_autowake = (autowake);
        W_setGlobalPose(this, pvk_in_pose, pvk_in_autowake);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_setGlobalPose_OL1(physx::PxRigidActor* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setGlobalPose(nat_in_pose);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGlobalPose_OL1(PxRigidActorPtr selfPtr, PxTransform pose);
    
    public void setGlobalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setGlobalPose_OL1(this, pvk_in_pose);
    }
    #endif
    
    
    
    //================================================================================
    //#       attachShape                                                            #
    //================================================================================
    #if NATIVE
    ES bool W_attachShape(physx::PxRigidActor* self, physx::PxShape* shape){
        auto nat_in_shape = (shape);
        auto retVal = self->attachShape(*nat_in_shape);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_attachShape(PxRigidActorPtr selfPtr, PxShapePtr shape);
    
    public bool attachShape(PxShapePtr shape){
        PxShapePtr pvk_in_shape = (shape);
        bool retVal = W_attachShape(this, pvk_in_shape);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       detachShape                                                            #
    //================================================================================
    #if NATIVE
    ES void W_detachShape(physx::PxRigidActor* self, physx::PxShape* shape, bool wakeOnLostTouch){
        auto nat_in_shape = (shape);
        auto nat_in_wakeOnLostTouch = (wakeOnLostTouch);
        self->detachShape(*nat_in_shape, nat_in_wakeOnLostTouch);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_detachShape(PxRigidActorPtr selfPtr, PxShapePtr shape, bool wakeOnLostTouch);
    
    public void detachShape(PxShapePtr shape, bool wakeOnLostTouch){
        PxShapePtr pvk_in_shape = (shape);
        bool pvk_in_wakeOnLostTouch = (wakeOnLostTouch);
        W_detachShape(this, pvk_in_shape, pvk_in_wakeOnLostTouch);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_detachShape_OL1(physx::PxRigidActor* self, physx::PxShape* shape){
        auto nat_in_shape = (shape);
        self->detachShape(*nat_in_shape);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_detachShape_OL1(PxRigidActorPtr selfPtr, PxShapePtr shape);
    
    public void detachShape(PxShapePtr shape){
        PxShapePtr pvk_in_shape = (shape);
        W_detachShape_OL1(this, pvk_in_shape);
    }
    #endif
    
    
    
    //================================================================================
    //#       getNbShapes                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getNbShapes(physx::PxRigidActor* self){
        auto retVal = self->getNbShapes();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbShapes(PxRigidActorPtr selfPtr);
    
    public uint getNbShapes(){
        uint retVal = W_getNbShapes(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getShapes                                                              #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: PxU32			getShapes(PxShape** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)			const	= 0
    #if NATIVE
    ES physx::PxU32 W_getShapes(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getShapes(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getShapes( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getShapes(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxShape*
    // NATIVE SIG: PxU32			getShapes(PxShape** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)			const	= 0
    #if NATIVE
    ES physx::PxU32 W_getShapes_OL1(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getShapes(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getShapes_OL1(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize);
    
    public uint getShapes( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getShapes_OL1(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif*/
    
    
    
    
    //================================================================================
    //#       getNbConstraints                                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getNbConstraints(physx::PxRigidActor* self){
        auto retVal = self->getNbConstraints();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbConstraints(PxRigidActorPtr selfPtr);
    
    public uint getNbConstraints(){
        uint retVal = W_getNbConstraints(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConstraints                                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConstraint*
    // NATIVE SIG: PxU32			getConstraints(PxConstraint** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)		const	= 0
    #if NATIVE
    ES physx::PxU32 W_getConstraints(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getConstraints(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConstraints(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getConstraints( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getConstraints(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxConstraint*
    // NATIVE SIG: PxU32			getConstraints(PxConstraint** userBuffer, PxU32 bufferSize, PxU32 startIndex=0)		const	= 0
    #if NATIVE
    ES physx::PxU32 W_getConstraints_OL1(physx::PxRigidActor* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getConstraints(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getConstraints_OL1(PxRigidActorPtr selfPtr,  userBuffer, uint bufferSize);
    
    public uint getConstraints( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getConstraints_OL1(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif*/
    
    
    
    
    //================================================================================
    //#       PxRigidActor                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidActor
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidActor(PxType concreteType, PxBaseFlags baseFlags) : PxActor(concreteType, baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidActor_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidActor(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidActor_ctor(ushort concreteType,  baseFlags);
    
    public PxRigidActor(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidActor_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxRigidActor                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidActor
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidActor(PxBaseFlags baseFlags) : PxActor(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidActor_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidActor(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidActor_ctor( baseFlags);
    
    public PxRigidActor( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidActor_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxRigidActor                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxRigidActor()	{}
    #if NATIVE
    ES void W_~PxRigidActor(physx::PxRigidActor* self){
        self->~PxRigidActor();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxRigidActor(PxRigidActorPtr selfPtr);
    
    public void ~PxRigidActor(){
        W_~PxRigidActor(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxRigidActor* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxRigidActorPtr selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxRigidActor
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
