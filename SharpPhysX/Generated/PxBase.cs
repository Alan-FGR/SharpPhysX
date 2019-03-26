#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxBaseFlag : int {
    eOWNS_MEMORY = 1,   // eOWNS_MEMORY = (1<<0)
    eIS_RELEASABLE = 2, // eIS_RELEASABLE = (1<<1)
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxBasePtr {
#endif

//================================================================================
//#       getBinaryMetaData_PxBase(PxOutputStreamPtr stream)                     #
//================================================================================
/* ERRORS OCCURED: Forbidden parameter type: PxOutputStreamPtr
// NATIVE SIG: void				getBinaryMetaData_PxBase(PxOutputStream& stream)
#if NATIVE //function start
ES void W_getBinaryMetaData_PxBase_R_void_P_PxOutputStreamPtr(physx::PxOutputStream* stream){
    auto nat_in_stream = (stream);
    physx::getBinaryMetaData_PxBase(*nat_in_stream);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_getBinaryMetaData_PxBase_R_void_P_PxOutputStreamPtr(PxOutputStreamPtr stream);

public static void getBinaryMetaData_PxBase(PxOutputStreamPtr stream){
    PxOutputStreamPtr pvk_in_stream = (stream);
    W_getBinaryMetaData_PxBase_R_void_P_PxOutputStreamPtr(pvk_in_stream);
}
#endif //function end*/


//================================================================================
//#       operator|(PxBaseFlag a, PxBaseFlag b)                                  #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short> -> PxFlags_PxBaseFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag_P_PxBaseFlag(physx::PxBaseFlag::Enum a, physx::PxBaseFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag_P_PxBaseFlag(PxBaseFlag a, PxBaseFlag b);

public static UNPARSED_TYPE operator|(PxBaseFlag a, PxBaseFlag b){
    PxBaseFlag pvk_in_a = (a);
    PxBaseFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag_P_PxBaseFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxBaseFlag a, PxBaseFlag b)                                  #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short> -> PxFlags_PxBaseFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag_P_PxBaseFlag(physx::PxBaseFlag::Enum a, physx::PxBaseFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag_P_PxBaseFlag(PxBaseFlag a, PxBaseFlag b);

public static UNPARSED_TYPE operator&(PxBaseFlag a, PxBaseFlag b){
    PxBaseFlag pvk_in_a = (a);
    PxBaseFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag_P_PxBaseFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxBaseFlag a)                                                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short> -> PxFlags_PxBaseFlag_ushort
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag(physx::PxBaseFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag(PxBaseFlag a);

public static UNPARSED_TYPE operator~(PxBaseFlag a){
    PxBaseFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxBaseFlag_ushort_P_PxBaseFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxBasePtr
#endif


#if !NATIVE //interface
public unsafe interface IPxBasePtr {
     void release();
     string getConcreteTypeName();
    // UNPARSED_TYPE is();
    // UNPARSED_TYPE is();
     ushort getConcreteType();
     void setBaseFlag(PxBaseFlag flag, bool value);
    // void setBaseFlags( inFlags);
    // UNPARSED_TYPE getBaseFlags();
     bool isReleasable();
    // static PxBasePtr New(/*NULLPARS*/);
    // static PxBasePtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxBase(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // UNPARSED_TYPE typeMatch(/*NULLPARS*/);
    // static PxBasePtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxBasePtr : IPxBasePtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxBasePtrPOD{
    physx::PxType mConcreteType;
    physx::PxBaseFlags mBaseFlags;
};
#endif //struct start


    // ### Auto generated getters for fields
    //Skipped non-public field: mConcreteType
    //Skipped non-public field: mBaseFlags

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr
    #endif //hierarchy
    //================================================================================
    //#       release()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxBase(physx::PxBase* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxBase(PxBasePtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxBase(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConcreteTypeName()                                                  #
    //================================================================================
    #if NATIVE //function start
    ES const char* W_getConcreteTypeName_R_string_C_PxBase(physx::PxBase* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string W_getConcreteTypeName_R_string_C_PxBase(PxBasePtr selfPtr);
    
    public  string getConcreteTypeName(){
        string retVal = W_getConcreteTypeName_R_string_C_PxBase(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       is()                                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*					is()
    #if NATIVE //function start
    ES UNPARSED_TYPE W_is_R_T_C_PxBase(physx::PxBase* self){
        auto retVal = self->is();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_is_R_T_C_PxBase(PxBasePtr selfPtr);
    
    public  UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = W_is_R_T_C_PxBase(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       is()                                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				is() const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_is_R_T_C_PxBase(physx::PxBase* self){
        auto retVal = self->is();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_is_R_T_C_PxBase(PxBasePtr selfPtr);
    
    public  UNPARSED_TYPE is(){
        UNPARSED_TYPE retVal = W_is_R_T_C_PxBase(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getConcreteType()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxType W_getConcreteType_R_ushort_C_PxBase(physx::PxBase* self){
        auto retVal = self->getConcreteType();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getConcreteType_R_ushort_C_PxBase(PxBasePtr selfPtr);
    
    public  ushort getConcreteType(){
        ushort retVal = W_getConcreteType_R_ushort_C_PxBase(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setBaseFlag(PxBaseFlag flag, bool value)                               #
    //================================================================================
    #if NATIVE //function start
    ES void W_setBaseFlag_R_void_P_PxBaseFlag_P_bool_C_PxBase(physx::PxBase* self, physx::PxBaseFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setBaseFlag(nat_in_flag, nat_in_value);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBaseFlag_R_void_P_PxBaseFlag_P_bool_C_PxBase(PxBasePtr selfPtr, PxBaseFlag flag, bool value);
    
    public  void setBaseFlag(PxBaseFlag flag, bool value){
        PxBaseFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setBaseFlag_R_void_P_PxBaseFlag_P_bool_C_PxBase(this, pvk_in_flag, pvk_in_value);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setBaseFlags(Enum, ushort> inFlags)                                    #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: void					setBaseFlags(PxBaseFlags inFlags)				{ mBaseFlags = inFlags; }
    #if NATIVE //function start
    ES void W_setBaseFlags_R_void_P__C_PxBase(physx::PxBase* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setBaseFlags(nat_in_inFlags);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setBaseFlags_R_void_P__C_PxBase(PxBasePtr selfPtr,  inFlags);
    
    public  void setBaseFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setBaseFlags_R_void_P__C_PxBase(this, pvk_in_inFlags);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getBaseFlags()                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBaseFlags -> Enum, ushort>
    // NATIVE SIG: PxBaseFlags				getBaseFlags() const							{ return mBaseFlags; }
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getBaseFlags_R_Enum, ushort>_C_PxBase(physx::PxBase* self){
        auto retVal = self->getBaseFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getBaseFlags_R_Enum, ushort>_C_PxBase(PxBasePtr selfPtr);
    
    public  UNPARSED_TYPE getBaseFlags(){
        UNPARSED_TYPE retVal = W_getBaseFlags_R_Enum, ushort>_C_PxBase(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       isReleasable()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isReleasable_R_bool_C_PxBase(physx::PxBase* self){
        auto retVal = self->isReleasable();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isReleasable_R_bool_C_PxBase(PxBasePtr selfPtr);
    
    public  bool isReleasable(){
        bool retVal = W_isReleasable_R_bool_C_PxBase(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxBase
    
    //Skipped protected: PxBase
    
    //Skipped protected: ~PxBase
    
    //Skipped protected: isKindOf
    
    //Skipped protected: typeMatch
    
    //Skipped generated implicit entry: PxBase
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxBaseFlag is enum namespace