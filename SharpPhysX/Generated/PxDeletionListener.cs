#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxDeletionEventFlag : int {
    eUSER_RELEASE = 1,   // eUSER_RELEASE = (1<<0)
    eMEMORY_RELEASE = 2, // eMEMORY_RELEASE = (1<<1)
}
#endif

#if !NATIVE
public partial struct PxDeletionListener {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxDeletionEventFlag::Enum a, physx::PxDeletionEventFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxDeletionEventFlag a, PxDeletionEventFlag b);

public static UNPARSED_TYPE operator|(PxDeletionEventFlag a, PxDeletionEventFlag b){
    PxDeletionEventFlag pvk_in_a = (a);
    PxDeletionEventFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxDeletionEventFlag::Enum a, physx::PxDeletionEventFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxDeletionEventFlag a, PxDeletionEventFlag b);

public static UNPARSED_TYPE operator&(PxDeletionEventFlag a, PxDeletionEventFlag b){
    PxDeletionEventFlag pvk_in_a = (a);
    PxDeletionEventFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxDeletionEventFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxDeletionEventFlag a);

public static UNPARSED_TYPE operator~(PxDeletionEventFlag a){
    PxDeletionEventFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxDeletionListener
#endif


// Class physx::PxDeletionListener Manually Ignored
// Class physx::PxDeletionEventFlag is enum namespace