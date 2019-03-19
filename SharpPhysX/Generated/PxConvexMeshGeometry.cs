#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxConvexMeshGeometryFlag : int {
    eTIGHT_BOUNDS = 1, // eTIGHT_BOUNDS = (1<<0)
}
#endif //enum

#if !NATIVE
public partial struct PxConvexMeshGeometry {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag_P_PxConvexMeshGeometryFlag(physx::PxConvexMeshGeometryFlag::Enum a, physx::PxConvexMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag_P_PxConvexMeshGeometryFlag(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b);

public static UNPARSED_TYPE operator|(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    PxConvexMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag_P_PxConvexMeshGeometryFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag_P_PxConvexMeshGeometryFlag(physx::PxConvexMeshGeometryFlag::Enum a, physx::PxConvexMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag_P_PxConvexMeshGeometryFlag(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b);

public static UNPARSED_TYPE operator&(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    PxConvexMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag_P_PxConvexMeshGeometryFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag(physx::PxConvexMeshGeometryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag(PxConvexMeshGeometryFlag a);

public static UNPARSED_TYPE operator~(PxConvexMeshGeometryFlag a){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxConvexMeshGeometryFlag_byte_P_PxConvexMeshGeometryFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxConvexMeshGeometry
#endif


// Class physx::PxConvexMeshGeometry Manually Ignored
// Class physx::PxConvexMeshGeometryFlag is enum namespace