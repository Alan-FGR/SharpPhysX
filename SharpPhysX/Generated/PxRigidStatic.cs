#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxRigidStaticPtr {
     string getConcreteTypeName();
    // PxRigidStatic(/*NULLPARS*/);
    // PxRigidStatic(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxRigidStatic(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // PxRigidStatic(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxRigidStaticPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxRigidStaticPtr : IPxActorPtr, IPxRigidActorPtr, IPxRigidStaticPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxActorPtr, PxRigidActorPtr, PxRigidStaticPtr
    public static implicit operator PxActorPtr(PxRigidStaticPtr obj){return *(PxActorPtr*)&obj;}
    public static explicit operator PxRigidStaticPtr(PxActorPtr obj){return *(PxRigidStaticPtr*)&obj;}
    public static implicit operator PxRigidActorPtr(PxRigidStaticPtr obj){return *(PxRigidActorPtr*)&obj;}
    public static explicit operator PxRigidStaticPtr(PxRigidActorPtr obj){return *(PxRigidStaticPtr*)&obj;}
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
    //public  PxRigidActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxRigidActor(/*NULLARGS*/);}
    //public  PxRigidActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxRigidActor(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxRigidActor(/*NULLPARS*/){((PxRigidActorPtr)this).~PxRigidActor(/*NULLARGS*/);}
    //public  PxRigidActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxRigidActor(/*NULLARGS*/);}
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
    //public  PxActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxActor(/*NULLARGS*/);}
    //public  PxActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxActor(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxActor(/*NULLPARS*/){((PxRigidActorPtr)this).~PxActor(/*NULLARGS*/);}
    //public  PxActor(/*NULLPARS*/){((PxRigidActorPtr)this).PxActor(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxActorPtr lhs, /*NULLPARS*/){return ((PxRigidActorPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE //function start
    ES const char* W_getConcreteTypeName_R_string_C_PxRigidStatic(physx::PxRigidStatic* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string W_getConcreteTypeName_R_string_C_PxRigidStatic(PxRigidStaticPtr selfPtr);
    
    public  string getConcreteTypeName(){
        string retVal = W_getConcreteTypeName_R_string_C_PxRigidStatic(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxRigidStatic
    
    //Skipped protected: PxRigidStatic
    
    //Skipped protected: ~PxRigidStatic
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxRigidStatic
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
