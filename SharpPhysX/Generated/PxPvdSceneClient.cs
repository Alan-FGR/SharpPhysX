#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxPvdSceneFlag : int {
    eTRANSMIT_CONTACTS = 1,     // eTRANSMIT_CONTACTS = (1 << 0)
    eTRANSMIT_SCENEQUERIES = 2, // eTRANSMIT_SCENEQUERIES = (1 << 1)
    eTRANSMIT_CONSTRAINTS = 4,  // eTRANSMIT_CONSTRAINTS = (1 << 2)
}
#endif

#if !NATIVE
public partial struct PxPvdSceneClient {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\pvd\PxPvdSceneClient.h L75~75
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxPvdSceneFlag::Enum a, physx::PxPvdSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxPvdSceneFlag a, PxPvdSceneFlag b);

public static UNPARSED_TYPE operator|(PxPvdSceneFlag a, PxPvdSceneFlag b){
    PxPvdSceneFlag pvk_in_a = (a);
    PxPvdSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\pvd\PxPvdSceneClient.h L75~75
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxPvdSceneFlag::Enum a, physx::PxPvdSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxPvdSceneFlag a, PxPvdSceneFlag b);

public static UNPARSED_TYPE operator&(PxPvdSceneFlag a, PxPvdSceneFlag b){
    PxPvdSceneFlag pvk_in_a = (a);
    PxPvdSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\pvd\PxPvdSceneClient.h L75~75
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxPvdSceneFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxPvdSceneFlag a);

public static UNPARSED_TYPE operator~(PxPvdSceneFlag a){
    PxPvdSceneFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxPvdSceneClient
#endif







// Class physx::PxPvdSceneClient Manually Ignored
// Class physx::PxPvdSceneFlag is enum namespace