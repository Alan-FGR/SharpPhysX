#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxActorType : int {
    eRIGID_STATIC = 0,               // eRIGID_STATIC
    eRIGID_DYNAMIC = 1,              // eRIGID_DYNAMIC
    eARTICULATION_LINK = 2,          // eARTICULATION_LINK
    eACTOR_COUNT = 3,                // eACTOR_COUNT
    eACTOR_FORCE_DWORD = 2147483647, // eACTOR_FORCE_DWORD = 0x7fffffff
}
#endif //enum

#if !NATIVE //enum
public enum PxActorFlag : int {
    eVISUALIZATION = 1,       // eVISUALIZATION = (1<<0)
    eDISABLE_GRAVITY = 2,     // eDISABLE_GRAVITY = (1<<1)
    eSEND_SLEEP_NOTIFIES = 4, // eSEND_SLEEP_NOTIFIES = (1<<2)
    eDISABLE_SIMULATION = 8,  // eDISABLE_SIMULATION = (1<<3)
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxActorPtr {
#endif

//================================================================================
//#       operator|(PxActorFlag a, PxActorFlag b)                                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char> -> PxFlags_PxActorFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxActorFlag_byte_P_PxActorFlag_P_PxActorFlag(physx::PxActorFlag::Enum a, physx::PxActorFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxActorFlag_byte_P_PxActorFlag_P_PxActorFlag(PxActorFlag a, PxActorFlag b);

public static UNPARSED_TYPE operator|(PxActorFlag a, PxActorFlag b){
    PxActorFlag pvk_in_a = (a);
    PxActorFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxActorFlag_byte_P_PxActorFlag_P_PxActorFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxActorFlag a, PxActorFlag b)                                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char> -> PxFlags_PxActorFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxActorFlag_byte_P_PxActorFlag_P_PxActorFlag(physx::PxActorFlag::Enum a, physx::PxActorFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxActorFlag_byte_P_PxActorFlag_P_PxActorFlag(PxActorFlag a, PxActorFlag b);

public static UNPARSED_TYPE operator&(PxActorFlag a, PxActorFlag b){
    PxActorFlag pvk_in_a = (a);
    PxActorFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxActorFlag_byte_P_PxActorFlag_P_PxActorFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxActorFlag a)                                               #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char> -> PxFlags_PxActorFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxActorFlag_byte_P_PxActorFlag(physx::PxActorFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxActorFlag_byte_P_PxActorFlag(PxActorFlag a);

public static UNPARSED_TYPE operator~(PxActorFlag a){
    PxActorFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxActorFlag_byte_P_PxActorFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxActorPtr
#endif


#if !NATIVE //interface
public unsafe interface IPxArticulationLinkPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxArticulationLinkPtr : IPxArticulationLinkPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxArticulationLinkPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxArticulationLinkPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxActorPtr {
     void release();
     PxActorType getType();
     PxScenePtr getScene();
     void setName(string name);
     string getName();
     PxBounds3 getWorldBounds();
     PxBounds3 getWorldBounds(float inflation);
     void setActorFlag(PxActorFlag flag, bool value);
    // void setActorFlags( inFlags);
    // UNPARSED_TYPE getActorFlags();
     void setDominanceGroup(byte dominanceGroup);
     byte getDominanceGroup();
     void setOwnerClient(byte inClient);
     byte getOwnerClient();
    // PxAggregatePtr getAggregate();
    // static PxActorPtr New(/*NULLPARS*/);
    // static PxActorPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxActor(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // static PxActorPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxActorPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxActorPtr : IPxBasePtr, IPxActorPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxActorPtrPOD{
    void* userData;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### USERDATA getter/setter
    #if NATIVE //getter
    ES void* PxActor_GET_userData(PxActor* self) {return self->userData;}
    ES void PxActor_SET_userData(PxActor* self, void* value) {self->userData = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr PxActor_GET_userData(PxActorPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxActor_SET_userData(PxActorPtr selfPtr, IntPtr value);

    public IntPtr userData {
        get => PxActor_GET_userData(this);
        set => PxActor_SET_userData(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxActorPtr
    public static implicit operator PxBasePtr(PxActorPtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxActorPtr(PxBasePtr obj){return *(PxActorPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxBasePtr
    public  string getConcreteTypeName(){return ((PxBasePtr)this).getConcreteTypeName();}
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    public  ushort getConcreteType(){return ((PxBasePtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxBasePtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxBasePtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxBasePtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxBasePtr)this).isReleasable();}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxBase(/*NULLPARS*/){((PxBasePtr)this).~PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE typeMatch(/*NULLPARS*/){return ((PxBasePtr)this).typeMatch(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxBasePtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       release()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxActor(physx::PxActor* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxActor(PxActorPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxActor(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getType()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxActorType::Enum W_getType_R_PxActorType_C_PxActor(physx::PxActor* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxActorType W_getType_R_PxActorType_C_PxActor(PxActorPtr selfPtr);
    
    public  PxActorType getType(){
        PxActorType retVal = W_getType_R_PxActorType_C_PxActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getScene()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxScene* W_getScene_R_PxScenePtr_C_PxActor(physx::PxActor* self){
        auto retVal = self->getScene();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxScenePtr W_getScene_R_PxScenePtr_C_PxActor(PxActorPtr selfPtr);
    
    public  PxScenePtr getScene(){
        PxScenePtr retVal = W_getScene_R_PxScenePtr_C_PxActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setName(string name)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES void W_setName_R_void_P_string_C_PxActor(physx::PxActor* self, const char* name){
        auto nat_in_name = (name);
        self->setName(nat_in_name);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setName_R_void_P_string_C_PxActor(PxActorPtr selfPtr, string name);
    
    public  void setName(string name){
        string pvk_in_name = (name);
        W_setName_R_void_P_string_C_PxActor(this, pvk_in_name);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getName()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES const char* W_getName_R_string_C_PxActor(physx::PxActor* self){
        auto retVal = self->getName();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string W_getName_R_string_C_PxActor(PxActorPtr selfPtr);
    
    public  string getName(){
        string retVal = W_getName_R_string_C_PxActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getWorldBounds(float inflation)                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxBounds3POD W_getWorldBounds_R_PxBounds3_P_float_C_PxActor(physx::PxActor* self, float inflation){
        auto nat_in_inflation = (inflation);
        auto retVal = self->getWorldBounds;
        return *(PxBounds3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_getWorldBounds_R_PxBounds3_P_float_C_PxActor(PxActorPtr selfPtr, float inflation);
    
    public  PxBounds3 getWorldBounds(float inflation){
        float pvk_in_inflation = (inflation);
        PxBounds3 retVal = W_getWorldBounds_R_PxBounds3_P_float_C_PxActor(this, pvk_in_inflation);
        return retVal;
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES PxBounds3POD W_getWorldBounds_R_PxBounds3_OL1_C_PxActor(physx::PxActor* self){
        auto retVal = self->getWorldBounds;
        return *(PxBounds3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_getWorldBounds_R_PxBounds3_OL1_C_PxActor(PxActorPtr selfPtr);
    
    public  PxBounds3 getWorldBounds(){
        PxBounds3 retVal = W_getWorldBounds_R_PxBounds3_OL1_C_PxActor(this);
        return retVal;
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       setActorFlag(PxActorFlag flag, bool value)                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_setActorFlag_R_void_P_PxActorFlag_P_bool_C_PxActor(physx::PxActor* self, physx::PxActorFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setActorFlag(nat_in_flag, nat_in_value);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setActorFlag_R_void_P_PxActorFlag_P_bool_C_PxActor(PxActorPtr selfPtr, PxActorFlag flag, bool value);
    
    public  void setActorFlag(PxActorFlag flag, bool value){
        PxActorFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setActorFlag_R_void_P_PxActorFlag_P_bool_C_PxActor(this, pvk_in_flag, pvk_in_value);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setActorFlags(Enum, byte> inFlags)                                     #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxActorFlags
    // NATIVE SIG: void			setActorFlags( PxActorFlags inFlags ) = 0
    #if NATIVE //function start
    ES void W_setActorFlags_R_void_P__C_PxActor(physx::PxActor* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setActorFlags(nat_in_inFlags);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setActorFlags_R_void_P__C_PxActor(PxActorPtr selfPtr,  inFlags);
    
    public  void setActorFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setActorFlags_R_void_P__C_PxActor(this, pvk_in_inFlags);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getActorFlags()                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxActorFlags -> Enum, byte>
    // NATIVE SIG: PxActorFlags	getActorFlags()	const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getActorFlags_R_Enum, byte>_C_PxActor(physx::PxActor* self){
        auto retVal = self->getActorFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getActorFlags_R_Enum, byte>_C_PxActor(PxActorPtr selfPtr);
    
    public  UNPARSED_TYPE getActorFlags(){
        UNPARSED_TYPE retVal = W_getActorFlags_R_Enum, byte>_C_PxActor(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setDominanceGroup(byte dominanceGroup)                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_setDominanceGroup_R_void_P_byte_C_PxActor(physx::PxActor* self, physx::PxDominanceGroup dominanceGroup){
        auto nat_in_dominanceGroup = (dominanceGroup);
        self->setDominanceGroup(nat_in_dominanceGroup);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setDominanceGroup_R_void_P_byte_C_PxActor(PxActorPtr selfPtr, byte dominanceGroup);
    
    public  void setDominanceGroup(byte dominanceGroup){
        byte pvk_in_dominanceGroup = (dominanceGroup);
        W_setDominanceGroup_R_void_P_byte_C_PxActor(this, pvk_in_dominanceGroup);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getDominanceGroup()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxDominanceGroup W_getDominanceGroup_R_byte_C_PxActor(physx::PxActor* self){
        auto retVal = self->getDominanceGroup();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte W_getDominanceGroup_R_byte_C_PxActor(PxActorPtr selfPtr);
    
    public  byte getDominanceGroup(){
        byte retVal = W_getDominanceGroup_R_byte_C_PxActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setOwnerClient(byte inClient)                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_setOwnerClient_R_void_P_byte_C_PxActor(physx::PxActor* self, physx::PxClientID inClient){
        auto nat_in_inClient = (inClient);
        self->setOwnerClient(nat_in_inClient);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setOwnerClient_R_void_P_byte_C_PxActor(PxActorPtr selfPtr, byte inClient);
    
    public  void setOwnerClient(byte inClient){
        byte pvk_in_inClient = (inClient);
        W_setOwnerClient_R_void_P_byte_C_PxActor(this, pvk_in_inClient);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getOwnerClient()                                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxClientID W_getOwnerClient_R_byte_C_PxActor(physx::PxActor* self){
        auto retVal = self->getOwnerClient();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte W_getOwnerClient_R_byte_C_PxActor(PxActorPtr selfPtr);
    
    public  byte getOwnerClient(){
        byte retVal = W_getOwnerClient_R_byte_C_PxActor(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getAggregate()                                                         #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxAggregate*	getAggregate()	const = 0
    #if NATIVE //function start
    ES const physx::PxAggregate* W_getAggregate_R_PxAggregatePtr_C_PxActor(physx::PxActor* self){
        auto retVal = self->getAggregate();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAggregatePtr W_getAggregate_R_PxAggregatePtr_C_PxActor(PxActorPtr selfPtr);
    
    public  PxAggregatePtr getAggregate(){
        PxAggregatePtr retVal = W_getAggregate_R_PxAggregatePtr_C_PxActor(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //Skipped protected: PxActor
    
    //Skipped protected: PxActor
    
    //Skipped protected: ~PxActor
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxActor
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxActorType is enum namespace
// Class physx::PxActorFlag is enum namespace