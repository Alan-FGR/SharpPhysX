#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxMaterialFlag : int {
    eDISABLE_FRICTION = 1,        // eDISABLE_FRICTION = 1 << 0
    eDISABLE_STRONG_FRICTION = 2, // eDISABLE_STRONG_FRICTION = 1 << 1
}
#endif //enum

#if !NATIVE //enum
public enum PxCombineMode : int {
    eAVERAGE = 0,         // eAVERAGE = 0
    eMIN = 1,             // eMIN = 1
    eMULTIPLY = 2,        // eMULTIPLY = 2
    eMAX = 3,             // eMAX = 3
    eN_VALUES = 4,        // eN_VALUES = 4
    ePAD_32 = 2147483647, // ePAD_32 = 0x7fffffff
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxMaterialPtr {
#endif

//================================================================================
//#       operator|(PxMaterialFlag a, PxMaterialFlag b)                          #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short> -> PxFlags_PxMaterialFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag_P_PxMaterialFlag(physx::PxMaterialFlag::Enum a, physx::PxMaterialFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag_P_PxMaterialFlag(PxMaterialFlag a, PxMaterialFlag b);

public static UNPARSED_TYPE operator|(PxMaterialFlag a, PxMaterialFlag b){
    PxMaterialFlag pvk_in_a = (a);
    PxMaterialFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag_P_PxMaterialFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxMaterialFlag a, PxMaterialFlag b)                          #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short> -> PxFlags_PxMaterialFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag_P_PxMaterialFlag(physx::PxMaterialFlag::Enum a, physx::PxMaterialFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag_P_PxMaterialFlag(PxMaterialFlag a, PxMaterialFlag b);

public static UNPARSED_TYPE operator&(PxMaterialFlag a, PxMaterialFlag b){
    PxMaterialFlag pvk_in_a = (a);
    PxMaterialFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag_P_PxMaterialFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxMaterialFlag a)                                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short> -> PxFlags_PxMaterialFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag(physx::PxMaterialFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag(PxMaterialFlag a);

public static UNPARSED_TYPE operator~(PxMaterialFlag a){
    PxMaterialFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxMaterialFlag_ushort_P_PxMaterialFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxMaterialPtr
#endif


#if !NATIVE //interface
public unsafe interface IPxMaterialPtr {
     void release();
     uint getReferenceCount();
     void acquireReference();
     void setDynamicFriction(float coef);
     float getDynamicFriction();
     void setStaticFriction(float coef);
     float getStaticFriction();
     void setRestitution(float rest);
     float getRestitution();
    // void setFlag(PxMaterialFlag flag, bool );
    // void setFlags( inFlags);
    // UNPARSED_TYPE getFlags();
     void setFrictionCombineMode(PxCombineMode combMode);
     PxCombineMode getFrictionCombineMode();
     void setRestitutionCombineMode(PxCombineMode combMode);
     PxCombineMode getRestitutionCombineMode();
     string getConcreteTypeName();
    // static PxMaterialPtr New(/*NULLPARS*/);
    // static PxMaterialPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxMaterial(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // static PxMaterialPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxMaterialPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxMaterialPtr : IPxBasePtr, IPxMaterialPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxMaterialPtrPOD{
    void* userData;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### USERDATA getter/setter
    #if NATIVE //getter
    ES void* PxMaterial_GET_userData(PxMaterial* self) {return self->userData;}
    ES void PxMaterial_SET_userData(PxMaterial* self, void* value) {self->userData = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr PxMaterial_GET_userData(PxMaterialPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxMaterial_SET_userData(PxMaterialPtr selfPtr, IntPtr value);

    public IntPtr userData {
        get => PxMaterial_GET_userData(this);
        set => PxMaterial_SET_userData(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxMaterialPtr
    public static implicit operator PxBasePtr(PxMaterialPtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxMaterialPtr(PxBasePtr obj){return *(PxMaterialPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxBasePtr
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
    ES void W_release_R_void_C_PxMaterial(physx::PxMaterial* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxMaterial(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getReferenceCount()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getReferenceCount_R_uint_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount_R_uint_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  uint getReferenceCount(){
        uint retVal = W_getReferenceCount_R_uint_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       acquireReference()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_acquireReference_R_void_C_PxMaterial(physx::PxMaterial* self){
        self->acquireReference();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference_R_void_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  void acquireReference(){
        W_acquireReference_R_void_C_PxMaterial(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setDynamicFriction(float coef)                                         #
    //================================================================================
    #if NATIVE //function start
    ES void W_setDynamicFriction_R_void_P_float_C_PxMaterial(physx::PxMaterial* self, physx::PxReal coef){
        auto nat_in_coef = (coef);
        self->setDynamicFriction(nat_in_coef);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setDynamicFriction_R_void_P_float_C_PxMaterial(PxMaterialPtr selfPtr, float coef);
    
    public  void setDynamicFriction(float coef){
        float pvk_in_coef = (coef);
        W_setDynamicFriction_R_void_P_float_C_PxMaterial(this, pvk_in_coef);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getDynamicFriction()                                                   #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getDynamicFriction_R_float_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getDynamicFriction();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getDynamicFriction_R_float_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  float getDynamicFriction(){
        float retVal = W_getDynamicFriction_R_float_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setStaticFriction(float coef)                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_setStaticFriction_R_void_P_float_C_PxMaterial(physx::PxMaterial* self, physx::PxReal coef){
        auto nat_in_coef = (coef);
        self->setStaticFriction(nat_in_coef);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setStaticFriction_R_void_P_float_C_PxMaterial(PxMaterialPtr selfPtr, float coef);
    
    public  void setStaticFriction(float coef){
        float pvk_in_coef = (coef);
        W_setStaticFriction_R_void_P_float_C_PxMaterial(this, pvk_in_coef);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getStaticFriction()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getStaticFriction_R_float_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getStaticFriction();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getStaticFriction_R_float_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  float getStaticFriction(){
        float retVal = W_getStaticFriction_R_float_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setRestitution(float rest)                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_setRestitution_R_void_P_float_C_PxMaterial(physx::PxMaterial* self, physx::PxReal rest){
        auto nat_in_rest = (rest);
        self->setRestitution(nat_in_rest);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRestitution_R_void_P_float_C_PxMaterial(PxMaterialPtr selfPtr, float rest);
    
    public  void setRestitution(float rest){
        float pvk_in_rest = (rest);
        W_setRestitution_R_void_P_float_C_PxMaterial(this, pvk_in_rest);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getRestitution()                                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getRestitution_R_float_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getRestitution();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getRestitution_R_float_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  float getRestitution(){
        float retVal = W_getRestitution_R_float_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setFlag(PxMaterialFlag flag, bool )                                    #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: void			setFlag(PxMaterialFlag::Enum flag, bool) = 0
    #if NATIVE //function start
    ES void W_setFlag_R_void_P_PxMaterialFlag_P_bool_C_PxMaterial(physx::PxMaterial* self, physx::PxMaterialFlag::Enum flag, bool ){
        auto nat_in_flag = (flag);
        auto nat_in_ = ();
        self->setFlag(nat_in_flag, nat_in_);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag_R_void_P_PxMaterialFlag_P_bool_C_PxMaterial(PxMaterialPtr selfPtr, PxMaterialFlag flag, bool );
    
    public  void setFlag(PxMaterialFlag flag, bool ){
        PxMaterialFlag pvk_in_flag = (flag);
        bool pvk_in_ = ();
        W_setFlag_R_void_P_PxMaterialFlag_P_bool_C_PxMaterial(this, pvk_in_flag, pvk_in_);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setFlags(Enum, ushort> inFlags)                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxMaterialFlags
    // NATIVE SIG: void 			setFlags( PxMaterialFlags inFlags ) = 0
    #if NATIVE //function start
    ES void W_setFlags_R_void_P__C_PxMaterial(physx::PxMaterial* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setFlags(nat_in_inFlags);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlags_R_void_P__C_PxMaterial(PxMaterialPtr selfPtr,  inFlags);
    
    public  void setFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setFlags_R_void_P__C_PxMaterial(this, pvk_in_inFlags);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getFlags()                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMaterialFlags -> Enum, ushort>
    // NATIVE SIG: PxMaterialFlags	getFlags() const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getFlags_R_Enum, ushort>_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags_R_Enum, ushort>_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags_R_Enum, ushort>_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setFrictionCombineMode(PxCombineMode combMode)                         #
    //================================================================================
    #if NATIVE //function start
    ES void W_setFrictionCombineMode_R_void_P_PxCombineMode_C_PxMaterial(physx::PxMaterial* self, physx::PxCombineMode::Enum combMode){
        auto nat_in_combMode = (combMode);
        self->setFrictionCombineMode(nat_in_combMode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFrictionCombineMode_R_void_P_PxCombineMode_C_PxMaterial(PxMaterialPtr selfPtr, PxCombineMode combMode);
    
    public  void setFrictionCombineMode(PxCombineMode combMode){
        PxCombineMode pvk_in_combMode = (combMode);
        W_setFrictionCombineMode_R_void_P_PxCombineMode_C_PxMaterial(this, pvk_in_combMode);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getFrictionCombineMode()                                               #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxCombineMode::Enum W_getFrictionCombineMode_R_PxCombineMode_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getFrictionCombineMode();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCombineMode W_getFrictionCombineMode_R_PxCombineMode_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  PxCombineMode getFrictionCombineMode(){
        PxCombineMode retVal = W_getFrictionCombineMode_R_PxCombineMode_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setRestitutionCombineMode(PxCombineMode combMode)                      #
    //================================================================================
    #if NATIVE //function start
    ES void W_setRestitutionCombineMode_R_void_P_PxCombineMode_C_PxMaterial(physx::PxMaterial* self, physx::PxCombineMode::Enum combMode){
        auto nat_in_combMode = (combMode);
        self->setRestitutionCombineMode(nat_in_combMode);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRestitutionCombineMode_R_void_P_PxCombineMode_C_PxMaterial(PxMaterialPtr selfPtr, PxCombineMode combMode);
    
    public  void setRestitutionCombineMode(PxCombineMode combMode){
        PxCombineMode pvk_in_combMode = (combMode);
        W_setRestitutionCombineMode_R_void_P_PxCombineMode_C_PxMaterial(this, pvk_in_combMode);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getRestitutionCombineMode()                                            #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxCombineMode::Enum W_getRestitutionCombineMode_R_PxCombineMode_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getRestitutionCombineMode();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCombineMode W_getRestitutionCombineMode_R_PxCombineMode_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  PxCombineMode getRestitutionCombineMode(){
        PxCombineMode retVal = W_getRestitutionCombineMode_R_PxCombineMode_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConcreteTypeName()                                                  #
    //================================================================================
    #if NATIVE //function start
    ES const char* W_getConcreteTypeName_R_string_C_PxMaterial(physx::PxMaterial* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string W_getConcreteTypeName_R_string_C_PxMaterial(PxMaterialPtr selfPtr);
    
    public  string getConcreteTypeName(){
        string retVal = W_getConcreteTypeName_R_string_C_PxMaterial(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxMaterial
    
    //Skipped protected: PxMaterial
    
    //Skipped protected: ~PxMaterial
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxMaterial
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxMaterialFlag is enum namespace
// Class physx::PxCombineMode is enum namespace