#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxConvexMeshGeometryFlag : int {
    eTIGHT_BOUNDS = 1, // eTIGHT_BOUNDS = (1<<0)
}
#endif

#if !NATIVE
public partial struct PxConvexMeshGeometry {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L67~67
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxConvexMeshGeometryFlag::Enum a, physx::PxConvexMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b);

public static UNPARSED_TYPE operator|(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    PxConvexMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L67~67
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxConvexMeshGeometryFlag::Enum a, physx::PxConvexMeshGeometryFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b);

public static UNPARSED_TYPE operator&(PxConvexMeshGeometryFlag a, PxConvexMeshGeometryFlag b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    PxConvexMeshGeometryFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMeshGeometry.h L67~67
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxConvexMeshGeometryFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxConvexMeshGeometryFlag a);

public static UNPARSED_TYPE operator~(PxConvexMeshGeometryFlag a){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxConvexMeshGeometry
#endif


// Class physx::PxConvexMeshGeometry Manually Ignored
// Class physx::PxConvexMeshGeometryFlag is enum namespace