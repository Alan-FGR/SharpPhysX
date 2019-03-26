#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxDeletionEventFlag : int {
    eUSER_RELEASE = 1,   // eUSER_RELEASE = (1<<0)
    eMEMORY_RELEASE = 2, // eMEMORY_RELEASE = (1<<1)
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxDeletionListenerPtr {
#endif

//================================================================================
//#       operator|(PxDeletionEventFlag a, PxDeletionEventFlag b)                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char> -> PxFlags_PxDeletionEventFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag_P_PxDeletionEventFlag(physx::PxDeletionEventFlag::Enum a, physx::PxDeletionEventFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag_P_PxDeletionEventFlag(PxDeletionEventFlag a, PxDeletionEventFlag b);

public static UNPARSED_TYPE operator|(PxDeletionEventFlag a, PxDeletionEventFlag b){
    PxDeletionEventFlag pvk_in_a = (a);
    PxDeletionEventFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag_P_PxDeletionEventFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxDeletionEventFlag a, PxDeletionEventFlag b)                #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char> -> PxFlags_PxDeletionEventFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag_P_PxDeletionEventFlag(physx::PxDeletionEventFlag::Enum a, physx::PxDeletionEventFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag_P_PxDeletionEventFlag(PxDeletionEventFlag a, PxDeletionEventFlag b);

public static UNPARSED_TYPE operator&(PxDeletionEventFlag a, PxDeletionEventFlag b){
    PxDeletionEventFlag pvk_in_a = (a);
    PxDeletionEventFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag_P_PxDeletionEventFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxDeletionEventFlag a)                                       #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char> -> PxFlags_PxDeletionEventFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag(physx::PxDeletionEventFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag(PxDeletionEventFlag a);

public static UNPARSED_TYPE operator~(PxDeletionEventFlag a){
    PxDeletionEventFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxDeletionEventFlag_byte_P_PxDeletionEventFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxDeletionListenerPtr
#endif


// Class physx::PxDeletionListener Manually Ignored
// Class physx::PxDeletionEventFlag is enum namespace