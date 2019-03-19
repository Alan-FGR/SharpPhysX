#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxMeshGeometryFlag : int {
    eDOUBLE_SIDED = 2, // eDOUBLE_SIDED = (1<<1)
}
#endif //enum

#if !NATIVE
public partial struct PxTriangleMeshGeometry {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag_P_PxMeshGeometryFlag(physx::PxMeshGeometryFlag::Enum a, physx::PxMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag_P_PxMeshGeometryFlag(PxMeshGeometryFlag a, PxMeshGeometryFlag b);

public static UNPARSED_TYPE operator|(PxMeshGeometryFlag a, PxMeshGeometryFlag b){
    PxMeshGeometryFlag pvk_in_a = (a);
    PxMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag_P_PxMeshGeometryFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag_P_PxMeshGeometryFlag(physx::PxMeshGeometryFlag::Enum a, physx::PxMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag_P_PxMeshGeometryFlag(PxMeshGeometryFlag a, PxMeshGeometryFlag b);

public static UNPARSED_TYPE operator&(PxMeshGeometryFlag a, PxMeshGeometryFlag b){
    PxMeshGeometryFlag pvk_in_a = (a);
    PxMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag_P_PxMeshGeometryFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag(physx::PxMeshGeometryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag(PxMeshGeometryFlag a);

public static UNPARSED_TYPE operator~(PxMeshGeometryFlag a){
    PxMeshGeometryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxMeshGeometryFlag_byte_P_PxMeshGeometryFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxTriangleMeshGeometry
#endif


// Class physx::PxTriangleMeshGeometry Manually Ignored
// Class physx::PxMeshGeometryFlag is enum namespace