#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxMeshGeometryFlag : int {
    eDOUBLE_SIDED = 2, // eDOUBLE_SIDED = (1<<1)
}
#endif

#if !NATIVE
public partial struct PxTriangleMeshGeometry {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L69~69
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxMeshGeometryFlag::Enum a, physx::PxMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxMeshGeometryFlag a, PxMeshGeometryFlag b);

public static UNPARSED_TYPE operator|(PxMeshGeometryFlag a, PxMeshGeometryFlag b){
    PxMeshGeometryFlag pvk_in_a = (a);
    PxMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L69~69
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxMeshGeometryFlag::Enum a, physx::PxMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxMeshGeometryFlag a, PxMeshGeometryFlag b);

public static UNPARSED_TYPE operator&(PxMeshGeometryFlag a, PxMeshGeometryFlag b){
    PxMeshGeometryFlag pvk_in_a = (a);
    PxMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMeshGeometry.h L69~69
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxMeshGeometryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxMeshGeometryFlag a);

public static UNPARSED_TYPE operator~(PxMeshGeometryFlag a){
    PxMeshGeometryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxTriangleMeshGeometry
#endif


// Class physx::PxTriangleMeshGeometry Manually Ignored
// Class physx::PxMeshGeometryFlag is enum namespace