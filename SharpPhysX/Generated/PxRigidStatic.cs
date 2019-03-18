#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe interface IPxRigidStaticPtr {
     IntPtr getConcreteTypeName();
    // PxRigidStatic(ushort concreteType,  baseFlags);
    // PxRigidStatic( baseFlags);
    // void ~PxRigidStatic();
     bool isKindOf(string name);
    // PxRigidStatic(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxRigidStaticPtr lhs, /*NULLPARS*/);
    
}

public unsafe partial struct PxRigidStaticPtr : IPxActorPtr, IPxRigidActorPtr, IPxRigidStaticPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxActorPtr, PxRigidActorPtr, PxRigidStaticPtr
    public static implicit operator PxActorPtr(PxRigidStaticPtr obj){return *(PxActorPtr*)&obj;}
    public static explicit operator PxRigidStaticPtr(PxActorPtr obj){return *(PxRigidStaticPtr*)&obj;}
    public static implicit operator PxRigidActorPtr(PxRigidStaticPtr obj){return *(PxRigidActorPtr*)&obj;}
    public static explicit operator PxRigidStaticPtr(PxRigidActorPtr obj){return *(PxRigidStaticPtr*)&obj;}
    
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
    //public  PxRigidActor(ushort concreteType,  baseFlags){((PxRigidActorPtr)this).PxRigidActor(concreteType, baseFlags);}
    //public  PxRigidActor( baseFlags){((PxRigidActorPtr)this).PxRigidActor(baseFlags);}
    //public  void ~PxRigidActor(){((PxRigidActorPtr)this).~PxRigidActor();}
    //public  PxRigidActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxRigidActor(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxRigidActorPtr lhs, /*NULLPARS*/){return ((PxRigidActorPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxActorPtr
    public  PxActorType getType(){return ((PxRigidActorPtr)this).getType();}
    public  PxScenePtr getScene(){return ((PxRigidActorPtr)this).getScene();}
    public  void setName(string name){((PxRigidActorPtr)this).setName(name);}
    public  IntPtr getName(){return ((PxRigidActorPtr)this).getName();}
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
    //public  PxActor(ushort concreteType,  baseFlags){((PxRigidActorPtr)this).PxActor(concreteType, baseFlags);}
    //public  PxActor( baseFlags){((PxRigidActorPtr)this).PxActor(baseFlags);}
    //public  void ~PxActor(){((PxRigidActorPtr)this).~PxActor();}
    //public  PxActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxActor(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorPtr lhs, /*NULLPARS*/){return ((PxRigidActorPtr)this).operator=(/*NULLARGS*/);}
    

    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxRigidStatic* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxRigidStaticPtr selfPtr);
    
    public  IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxRigidStatic                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidStatic
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidStatic(PxType concreteType, PxBaseFlags baseFlags) : PxRigidActor(concreteType, baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidStatic_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidStatic(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidStatic_ctor(ushort concreteType,  baseFlags);
    
    public  PxRigidStatic(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidStatic_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxRigidStatic                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidStatic
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidStatic(PxBaseFlags baseFlags) : PxRigidActor(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidStatic_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidStatic(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidStatic_ctor( baseFlags);
    
    public  PxRigidStatic( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidStatic_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxRigidStatic                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxRigidStatic() {}
    #if NATIVE
    ES void W_~PxRigidStatic(physx::PxRigidStatic* self){
        self->~PxRigidStatic();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxRigidStatic(PxRigidStaticPtr selfPtr);
    
    public  void ~PxRigidStatic(){
        W_~PxRigidStatic(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxRigidStatic* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxRigidStaticPtr selfPtr, string name);
    
    public  bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxRigidStatic
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
