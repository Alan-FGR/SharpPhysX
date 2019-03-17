#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxFlags {
#endif

//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: 
Unresolved parameter type enumtype
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp( a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp( a,  b);

public static UNPARSED_TYPE operator&( a,  b){
     pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxBaseFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxBaseFlag a,  b);

public static UNPARSED_TYPE operator&(PxBaseFlag a,  b){
    PxBaseFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxTriangleMeshFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxTriangleMeshFlag a,  b);

public static UNPARSED_TYPE operator&(PxTriangleMeshFlag a,  b){
    PxTriangleMeshFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxSceneFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxSceneFlag a,  b);

public static UNPARSED_TYPE operator&(PxSceneFlag a,  b){
    PxSceneFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxActorFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxActorFlag a,  b);

public static UNPARSED_TYPE operator&(PxActorFlag a,  b){
    PxActorFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxActorTypeFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxActorTypeFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxActorTypeFlag a,  b);

public static UNPARSED_TYPE operator&(PxActorTypeFlag a,  b){
    PxActorTypeFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxConvexMeshGeometryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxConvexMeshGeometryFlag a,  b);

public static UNPARSED_TYPE operator&(PxConvexMeshGeometryFlag a,  b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxMeshGeometryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxMeshGeometryFlag a,  b);

public static UNPARSED_TYPE operator&(PxMeshGeometryFlag a,  b){
    PxMeshGeometryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxMaterialFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxMaterialFlag a,  b);

public static UNPARSED_TYPE operator&(PxMaterialFlag a,  b){
    PxMaterialFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxShapeFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxShapeFlag a,  b);

public static UNPARSED_TYPE operator&(PxShapeFlag a,  b){
    PxShapeFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxConstraintFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxConstraintFlag a,  b);

public static UNPARSED_TYPE operator&(PxConstraintFlag a,  b){
    PxConstraintFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxFilterFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxFilterFlag a,  b);

public static UNPARSED_TYPE operator&(PxFilterFlag a,  b){
    PxFilterFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxPairFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxPairFlag a,  b);

public static UNPARSED_TYPE operator&(PxPairFlag a,  b){
    PxPairFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxHitFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxHitFlag a,  b);

public static UNPARSED_TYPE operator&(PxHitFlag a,  b){
    PxHitFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxQueryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxQueryFlag a,  b);

public static UNPARSED_TYPE operator&(PxQueryFlag a,  b){
    PxQueryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxPvdSceneFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxPvdSceneFlag a,  b);

public static UNPARSED_TYPE operator&(PxPvdSceneFlag a,  b){
    PxPvdSceneFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxRigidBodyFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxRigidBodyFlag a,  b);

public static UNPARSED_TYPE operator&(PxRigidBodyFlag a,  b){
    PxRigidBodyFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxRigidDynamicLockFlag::Enum, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxRigidDynamicLockFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxRigidDynamicLockFlag a,  b);

public static UNPARSED_TYPE operator&(PxRigidDynamicLockFlag a,  b){
    PxRigidDynamicLockFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxDeletionEventFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxDeletionEventFlag a,  b);

public static UNPARSED_TYPE operator&(PxDeletionEventFlag a,  b){
    PxDeletionEventFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short>
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L122~122
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::Px1DConstraintFlag::Type a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(Type a,  b);

public static UNPARSED_TYPE operator&(Type a,  b){
    Type pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxFlags
#endif


#if !NATIVE
public unsafe partial struct PxFlags { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFlags
    Invalid parameter name (empty)
    // NATIVE SIG: PX_INLINE explicit PxFlags(const PxEMPTY)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L78~78
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        self->PxFlags<enumtype, storagetype>(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor(PxEMPTY );
    
    public PxFlags<enumtype, storagetype>(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxFlags
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFlags
    Unresolved parameter type enumtype
    // NATIVE SIG: PX_INLINE PxFlags(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L82~82
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( e){
        auto nat_in_e = (e);
        self->PxFlags<enumtype, storagetype>(nat_in_e);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( e);
    
    public PxFlags<enumtype, storagetype>( e){
         pvk_in_e = (e);
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_e);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFlags
    fsdfasdf
    // NATIVE SIG: PX_INLINE PxFlags(const PxFlags<enumtype, storagetype>& f)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( f){
        auto nat_in_f = (f);
        self->PxFlags<enumtype, storagetype>(nat_in_f);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( f);
    
    public PxFlags<enumtype, storagetype>( f){
         pvk_in_f = (f);
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_f);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFlags
    Unresolved parameter type storagetype
    // NATIVE SIG: PX_INLINE explicit PxFlags(storagetype b)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L84~84
    #if NATIVE
    ES UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( b){
        auto nat_in_b = (b);
        self->PxFlags<enumtype, storagetype>(nat_in_b);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFlags<enumtype, storagetype>_ctor( b);
    
    public PxFlags<enumtype, storagetype>( b){
         pvk_in_b = (b);
        var _new = W_PxFlags<enumtype, storagetype>_ctor(pvk_in_b);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isSet                                                                  #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: bool isSet(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L86~86
    #if NATIVE
    ES bool W_isSet(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->isSet(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSet(PxFlags selfPtr,  e);
    
    public bool isSet( e){
         pvk_in_e = (e);
        bool retVal = W_isSet(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       set                                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: 
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype>& set(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L87~87
    #if NATIVE
    ES UNPARSED_TYPE W_set(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->set(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_set(PxFlags selfPtr,  e);
    
    public UNPARSED_TYPE set( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_set(this, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: bool operator==(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L88~88
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator==(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxFlags selfPtr,  e);
    
    public static bool operator==(PxFlags lhs,  e){
         pvk_in_e = (e);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool operator==(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L89~89
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator==(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxFlags selfPtr,  f);
    
    public static bool operator==(PxFlags lhs,  f){
         pvk_in_f = (f);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L90~90
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxFlags* self, bool b){
        auto nat_in_b = (b);
        auto retVal = self->operator==(nat_in_b);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxFlags selfPtr, bool b);
    
    public static bool operator==(PxFlags lhs, bool b){
        bool pvk_in_b = (b);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_b);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: bool operator!=(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L91~91
    #if NATIVE
    ES bool W_OP_ExclaimEqual(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator!=(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual(PxFlags selfPtr,  e);
    
    public static bool operator!=(PxFlags lhs,  e){
         pvk_in_e = (e);
        bool retVal = W_OP_ExclaimEqual(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool operator!=(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L92~92
    #if NATIVE
    ES bool W_OP_ExclaimEqual(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator!=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual(PxFlags selfPtr,  f);
    
    public static bool operator!=(PxFlags lhs,  f){
         pvk_in_f = (f);
        bool retVal = W_OP_ExclaimEqual(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator|=                                                             #
    //================================================================================
    //Skipped unsupported operator PipeEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator|=                                                             #
    //================================================================================
    //Skipped unsupported operator PipeEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator|                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: 
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator|(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L99~99
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Pipe(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator|(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Pipe(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator|(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Pipe(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator|                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: 
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator|(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L100~100
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Pipe(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator|(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Pipe(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator|(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Pipe(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&=                                                             #
    //================================================================================
    //Skipped unsupported operator AmpEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator&=                                                             #
    //================================================================================
    //Skipped unsupported operator AmpEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator&                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: 
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L104~104
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Amp(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator&(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Amp(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator&(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Amp(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator&                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: 
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator&(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L105~105
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Amp(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator&(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Amp(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator&(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Amp(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^=                                                             #
    //================================================================================
    //Skipped unsupported operator CaretEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator^=                                                             #
    //================================================================================
    //Skipped unsupported operator CaretEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator^                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: 
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator^(enumtype e) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L109~109
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Caret(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator^(nat_in_e);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Caret(PxFlags selfPtr,  e);
    
    public static UNPARSED_TYPE operator^(PxFlags lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Caret(lhs, pvk_in_e);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator^                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: 
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator^(const PxFlags<enumtype, storagetype>& f) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L110~110
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Caret(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator^(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Caret(PxFlags selfPtr,  f);
    
    public static UNPARSED_TYPE operator^(PxFlags lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Caret(lhs, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator~                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: 
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator~(void) const
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L112~112
    #if NATIVE
    ES UNPARSED_TYPE W_OP_Tilde(physx::PxFlags* self){
        auto retVal = self->operator~();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Tilde(PxFlags selfPtr);
    
    public static UNPARSED_TYPE operator~(PxFlags lhs){
        UNPARSED_TYPE retVal = W_OP_Tilde(lhs);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator bool                                                          #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator unsigned char                                                 #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator unsigned short                                                #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator unsigned int                                                  #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       clear                                                                  #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: void clear(enumtype e)
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxFlags.h L119~119
    #if NATIVE
    ES void W_clear(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        self->clear(nat_in_e);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clear(PxFlags selfPtr,  e);
    
    public void clear( e){
         pvk_in_e = (e);
        W_clear(this, pvk_in_e);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
