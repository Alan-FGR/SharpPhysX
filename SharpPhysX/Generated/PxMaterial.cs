#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxMaterialFlag : int {
    eDISABLE_FRICTION = 1,        // eDISABLE_FRICTION = 1 << 0
    eDISABLE_STRONG_FRICTION = 2, // eDISABLE_STRONG_FRICTION = 1 << 1
}
#endif

#if !NATIVE
public enum PxCombineMode : int {
    eAVERAGE = 0,         // eAVERAGE = 0
    eMIN = 1,             // eMIN = 1
    eMULTIPLY = 2,        // eMULTIPLY = 2
    eMAX = 3,             // eMAX = 3
    eN_VALUES = 4,        // eN_VALUES = 4
    ePAD_32 = 2147483647, // ePAD_32 = 0x7fffffff
}
#endif

#if !NATIVE
public partial struct PxMaterial {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxMaterialFlag::Enum a, physx::PxMaterialFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxMaterialFlag a, PxMaterialFlag b);

public static UNPARSED_TYPE operator|(PxMaterialFlag a, PxMaterialFlag b){
    PxMaterialFlag pvk_in_a = (a);
    PxMaterialFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxMaterialFlag::Enum a, physx::PxMaterialFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxMaterialFlag a, PxMaterialFlag b);

public static UNPARSED_TYPE operator&(PxMaterialFlag a, PxMaterialFlag b){
    PxMaterialFlag pvk_in_a = (a);
    PxMaterialFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxMaterialFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxMaterialFlag a);

public static UNPARSED_TYPE operator~(PxMaterialFlag a){
    PxMaterialFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxMaterial
#endif


#if !NATIVE
public unsafe partial struct PxMaterialPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxMaterial* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxMaterialPtr selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getReferenceCount(physx::PxMaterial* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount(PxMaterialPtr selfPtr);
    
    public uint getReferenceCount(){
        uint retVal = W_getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    #if NATIVE
    ES void W_acquireReference(physx::PxMaterial* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference(PxMaterialPtr selfPtr);
    
    public void acquireReference(){
        W_acquireReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       setDynamicFriction                                                     #
    //================================================================================
    #if NATIVE
    ES void W_setDynamicFriction(physx::PxMaterial* self, physx::PxReal coef){
        auto nat_in_coef = (coef);
        self->setDynamicFriction(nat_in_coef);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setDynamicFriction(PxMaterialPtr selfPtr, float coef);
    
    public void setDynamicFriction(float coef){
        float pvk_in_coef = (coef);
        W_setDynamicFriction(this, pvk_in_coef);
    }
    #endif
    
    
    //================================================================================
    //#       getDynamicFriction                                                     #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getDynamicFriction(physx::PxMaterial* self){
        auto retVal = self->getDynamicFriction();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getDynamicFriction(PxMaterialPtr selfPtr);
    
    public float getDynamicFriction(){
        float retVal = W_getDynamicFriction(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setStaticFriction                                                      #
    //================================================================================
    #if NATIVE
    ES void W_setStaticFriction(physx::PxMaterial* self, physx::PxReal coef){
        auto nat_in_coef = (coef);
        self->setStaticFriction(nat_in_coef);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setStaticFriction(PxMaterialPtr selfPtr, float coef);
    
    public void setStaticFriction(float coef){
        float pvk_in_coef = (coef);
        W_setStaticFriction(this, pvk_in_coef);
    }
    #endif
    
    
    //================================================================================
    //#       getStaticFriction                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getStaticFriction(physx::PxMaterial* self){
        auto retVal = self->getStaticFriction();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getStaticFriction(PxMaterialPtr selfPtr);
    
    public float getStaticFriction(){
        float retVal = W_getStaticFriction(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setRestitution                                                         #
    //================================================================================
    #if NATIVE
    ES void W_setRestitution(physx::PxMaterial* self, physx::PxReal rest){
        auto nat_in_rest = (rest);
        self->setRestitution(nat_in_rest);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRestitution(PxMaterialPtr selfPtr, float rest);
    
    public void setRestitution(float rest){
        float pvk_in_rest = (rest);
        W_setRestitution(this, pvk_in_rest);
    }
    #endif
    
    
    //================================================================================
    //#       getRestitution                                                         #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getRestitution(physx::PxMaterial* self){
        auto retVal = self->getRestitution();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getRestitution(PxMaterialPtr selfPtr);
    
    public float getRestitution(){
        float retVal = W_getRestitution(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: void			setFlag(PxMaterialFlag::Enum flag, bool) = 0
    #if NATIVE
    ES void W_setFlag(physx::PxMaterial* self, physx::PxMaterialFlag::Enum flag, bool ){
        auto nat_in_flag = (flag);
        auto nat_in_ = ();
        self->setFlag(nat_in_flag, nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag(PxMaterialPtr selfPtr, PxMaterialFlag flag, bool );
    
    public void setFlag(PxMaterialFlag flag, bool ){
        PxMaterialFlag pvk_in_flag = (flag);
        bool pvk_in_ = ();
        W_setFlag(this, pvk_in_flag, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       setFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxMaterialFlags
    // NATIVE SIG: void 			setFlags( PxMaterialFlags inFlags ) = 0
    #if NATIVE
    ES void W_setFlags(physx::PxMaterial* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlags(PxMaterialPtr selfPtr,  inFlags);
    
    public void setFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMaterialFlags
    // NATIVE SIG: PxMaterialFlags	getFlags() const = 0
    #if NATIVE
    ES UNPARSED_TYPE W_getFlags(physx::PxMaterial* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags(PxMaterialPtr selfPtr);
    
    public UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setFrictionCombineMode                                                 #
    //================================================================================
    #if NATIVE
    ES void W_setFrictionCombineMode(physx::PxMaterial* self, physx::PxCombineMode::Enum combMode){
        auto nat_in_combMode = (combMode);
        self->setFrictionCombineMode(nat_in_combMode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFrictionCombineMode(PxMaterialPtr selfPtr, PxCombineMode combMode);
    
    public void setFrictionCombineMode(PxCombineMode combMode){
        PxCombineMode pvk_in_combMode = (combMode);
        W_setFrictionCombineMode(this, pvk_in_combMode);
    }
    #endif
    
    
    //================================================================================
    //#       getFrictionCombineMode                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxCombineMode::Enum W_getFrictionCombineMode(physx::PxMaterial* self){
        auto retVal = self->getFrictionCombineMode();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCombineMode W_getFrictionCombineMode(PxMaterialPtr selfPtr);
    
    public PxCombineMode getFrictionCombineMode(){
        PxCombineMode retVal = W_getFrictionCombineMode(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setRestitutionCombineMode                                              #
    //================================================================================
    #if NATIVE
    ES void W_setRestitutionCombineMode(physx::PxMaterial* self, physx::PxCombineMode::Enum combMode){
        auto nat_in_combMode = (combMode);
        self->setRestitutionCombineMode(nat_in_combMode);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRestitutionCombineMode(PxMaterialPtr selfPtr, PxCombineMode combMode);
    
    public void setRestitutionCombineMode(PxCombineMode combMode){
        PxCombineMode pvk_in_combMode = (combMode);
        W_setRestitutionCombineMode(this, pvk_in_combMode);
    }
    #endif
    
    
    //================================================================================
    //#       getRestitutionCombineMode                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxCombineMode::Enum W_getRestitutionCombineMode(physx::PxMaterial* self){
        auto retVal = self->getRestitutionCombineMode();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCombineMode W_getRestitutionCombineMode(PxMaterialPtr selfPtr);
    
    public PxCombineMode getRestitutionCombineMode(){
        PxCombineMode retVal = W_getRestitutionCombineMode(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxMaterial* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxMaterialPtr selfPtr);
    
    public IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxMaterial                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMaterial
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxMaterial(PxType concreteType, PxBaseFlags baseFlags) : PxBase(concreteType, baseFlags), userData(NULL) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxMaterial_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxMaterial(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxMaterial_ctor(ushort concreteType,  baseFlags);
    
    public PxMaterial(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxMaterial_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMaterial                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMaterial
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxMaterial(PxBaseFlags baseFlags) : PxBase(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxMaterial_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxMaterial(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxMaterial_ctor( baseFlags);
    
    public PxMaterial( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxMaterial_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxMaterial                                                            #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxMaterial() {}
    #if NATIVE
    ES void W_~PxMaterial(physx::PxMaterial* self){
        self->~PxMaterial();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxMaterial(PxMaterialPtr selfPtr);
    
    public void ~PxMaterial(){
        W_~PxMaterial(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxMaterial* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxMaterialPtr selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxMaterial
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxMaterialFlag is enum namespace
// Class physx::PxCombineMode is enum namespace