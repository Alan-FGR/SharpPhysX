#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxFlagsPtr {
#endif

//================================================================================
//#       operator&(enumtype a, PxFlags_enumtype_storagetypePtr b)               #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type:  -> PxFlags_enumtype_storagetype
Unresolved parameter type enumtype
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_enumtype_storagetype_P__P_( a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_enumtype_storagetype_P__P_( a,  b);

public static UNPARSED_TYPE operator&( a,  b){
     pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_enumtype_storagetype_P__P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxBaseFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxBaseFlag_P_(physx::PxBaseFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxBaseFlag_P_(PxBaseFlag a,  b);

public static UNPARSED_TYPE operator&(PxBaseFlag a,  b){
    PxBaseFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxBaseFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxTriangleMeshFlag_P_(physx::PxTriangleMeshFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxTriangleMeshFlag_P_(PxTriangleMeshFlag a,  b);

public static UNPARSED_TYPE operator&(PxTriangleMeshFlag a,  b){
    PxTriangleMeshFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxTriangleMeshFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_uintPtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxSceneFlag::Enum, unsigned int> -> PxFlags_Enum_uint
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_uint_P_PxSceneFlag_P_(physx::PxSceneFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_uint_P_PxSceneFlag_P_(PxSceneFlag a,  b);

public static UNPARSED_TYPE operator&(PxSceneFlag a,  b){
    PxSceneFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_uint_P_PxSceneFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxActorFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxActorFlag_P_(physx::PxActorFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxActorFlag_P_(PxActorFlag a,  b);

public static UNPARSED_TYPE operator&(PxActorFlag a,  b){
    PxActorFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxActorFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxActorTypeFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxActorTypeFlag_P_(physx::PxActorTypeFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxActorTypeFlag_P_(PxActorTypeFlag a,  b);

public static UNPARSED_TYPE operator&(PxActorTypeFlag a,  b){
    PxActorTypeFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxActorTypeFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxConvexMeshGeometryFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxConvexMeshGeometryFlag_P_(physx::PxConvexMeshGeometryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxConvexMeshGeometryFlag_P_(PxConvexMeshGeometryFlag a,  b);

public static UNPARSED_TYPE operator&(PxConvexMeshGeometryFlag a,  b){
    PxConvexMeshGeometryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxConvexMeshGeometryFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxMeshGeometryFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxMeshGeometryFlag_P_(physx::PxMeshGeometryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxMeshGeometryFlag_P_(PxMeshGeometryFlag a,  b);

public static UNPARSED_TYPE operator&(PxMeshGeometryFlag a,  b){
    PxMeshGeometryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxMeshGeometryFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxMaterialFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxMaterialFlag_P_(physx::PxMaterialFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxMaterialFlag_P_(PxMaterialFlag a,  b);

public static UNPARSED_TYPE operator&(PxMaterialFlag a,  b){
    PxMaterialFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxMaterialFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxShapeFlag_P_(physx::PxShapeFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxShapeFlag_P_(PxShapeFlag a,  b);

public static UNPARSED_TYPE operator&(PxShapeFlag a,  b){
    PxShapeFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxShapeFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxConstraintFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxConstraintFlag_P_(physx::PxConstraintFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxConstraintFlag_P_(PxConstraintFlag a,  b);

public static UNPARSED_TYPE operator&(PxConstraintFlag a,  b){
    PxConstraintFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxConstraintFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxFilterFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxFilterFlag_P_(physx::PxFilterFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxFilterFlag_P_(PxFilterFlag a,  b);

public static UNPARSED_TYPE operator&(PxFilterFlag a,  b){
    PxFilterFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxFilterFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxPairFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxPairFlag_P_(physx::PxPairFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxPairFlag_P_(PxPairFlag a,  b);

public static UNPARSED_TYPE operator&(PxPairFlag a,  b){
    PxPairFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxPairFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxHitFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxHitFlag_P_(physx::PxHitFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxHitFlag_P_(PxHitFlag a,  b);

public static UNPARSED_TYPE operator&(PxHitFlag a,  b){
    PxHitFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxHitFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxQueryFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxQueryFlag_P_(physx::PxQueryFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxQueryFlag_P_(PxQueryFlag a,  b);

public static UNPARSED_TYPE operator&(PxQueryFlag a,  b){
    PxQueryFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxQueryFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxPvdSceneFlag_P_(physx::PxPvdSceneFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxPvdSceneFlag_P_(PxPvdSceneFlag a,  b);

public static UNPARSED_TYPE operator&(PxPvdSceneFlag a,  b){
    PxPvdSceneFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxPvdSceneFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxRigidBodyFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxRigidBodyFlag_P_(physx::PxRigidBodyFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxRigidBodyFlag_P_(PxRigidBodyFlag a,  b);

public static UNPARSED_TYPE operator&(PxRigidBodyFlag a,  b){
    PxRigidBodyFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxRigidBodyFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxRigidDynamicLockFlag::Enum, unsigned short> -> PxFlags_Enum_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxRigidDynamicLockFlag_P_(physx::PxRigidDynamicLockFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_ushort_P_PxRigidDynamicLockFlag_P_(PxRigidDynamicLockFlag a,  b);

public static UNPARSED_TYPE operator&(PxRigidDynamicLockFlag a,  b){
    PxRigidDynamicLockFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_ushort_P_PxRigidDynamicLockFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Enum a, PxFlags_Enum_bytePtr b)                              #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxDeletionEventFlag::Enum, unsigned char> -> PxFlags_Enum_byte
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxDeletionEventFlag_P_(physx::PxDeletionEventFlag::Enum a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Enum_byte_P_PxDeletionEventFlag_P_(PxDeletionEventFlag a,  b);

public static UNPARSED_TYPE operator&(PxDeletionEventFlag a,  b){
    PxDeletionEventFlag pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Enum_byte_P_PxDeletionEventFlag_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(Type a, PxFlags_Type_ushortPtr b)                            #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short> -> PxFlags_Type_ushort
fsdfasdf
// NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype a, PxFlags<enumtype, storagetype>& b)
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_Type_ushort_P_Type_P_(physx::Px1DConstraintFlag::Type a,  b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_Type_ushort_P_Type_P_(Type a,  b);

public static UNPARSED_TYPE operator&(Type a,  b){
    Type pvk_in_a = (a);
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_Type_ushort_P_Type_P_(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxFlagsPtr
#endif


#if !NATIVE //interface
public unsafe interface IPxFlagsPtr {
    // static PxFlagsPtr New(PxEMPTY );
    // static PxFlagsPtr New();
    // static PxFlagsPtr New( e);
    // static PxFlagsPtr New( f);
    // static PxFlagsPtr New( b);
    // bool isSet( e);
    // UNPARSED_TYPE set( e);
    //static bool operator==(PxFlagsPtr lhs,  e);
    //static bool operator==(PxFlagsPtr lhs,  f);
    //static bool operator==(PxFlagsPtr lhs, bool b);
    //static bool operator!=(PxFlagsPtr lhs,  e);
    //static bool operator!=(PxFlagsPtr lhs,  f);
    //static UNPARSED_TYPE operator=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator|=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator|=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator|(PxFlagsPtr lhs,  e);
    //static UNPARSED_TYPE operator|(PxFlagsPtr lhs,  f);
    //static UNPARSED_TYPE operator&=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator&=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator&(PxFlagsPtr lhs,  e);
    //static UNPARSED_TYPE operator&(PxFlagsPtr lhs,  f);
    //static UNPARSED_TYPE operator^=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator^=(PxFlagsPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator^(PxFlagsPtr lhs,  e);
    //static UNPARSED_TYPE operator^(PxFlagsPtr lhs,  f);
    //static UNPARSED_TYPE operator~(PxFlagsPtr lhs);
    //static bool operator bool(PxFlagsPtr lhs, /*NULLPARS*/);
    //static byte operator unsigned char(PxFlagsPtr lhs, /*NULLPARS*/);
    //static ushort operator unsigned short(PxFlagsPtr lhs, /*NULLPARS*/);
    //static uint operator unsigned int(PxFlagsPtr lhs, /*NULLPARS*/);
    // void clear( e);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxFlagsPtr : IPxFlagsPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxFlagsPtrPOD{
    storagetype mBits;
};
#endif //struct start


    // ### Auto generated getters for fields
    //Skipped non-public field: mBits

    #if !NATIVE //hierarchy
    // Hierarchy: PxFlagsPtr
    #endif //hierarchy
    //================================================================================
    //#       PxFlags<enumtype, storagetype>(physx )                                 #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PX_INLINE explicit PxFlags(const PxEMPTY)
    #if NATIVE //function start
    ES PxFlagsPtrPOD W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P_PxEMPTY_C_PxFlags_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        auto val = new PxFlags<enumtype, storagetype>();
        return *(PxFlagsPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFlagsPtr W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P_PxEMPTY_C_PxFlags_ctor(PxEMPTY );
    
    public  static PxFlagsPtr New(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P_PxEMPTY_C_PxFlags_ctor(pvk_in_);
        PxFlagsPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>()                                       #
    //================================================================================
    #if NATIVE //function start
    ES PxFlagsPtrPOD W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_C_PxFlags_ctor(){
        auto val = new PxFlags<enumtype, storagetype>();
        return *(PxFlagsPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFlagsPtr W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_C_PxFlags_ctor();
    
    public  static PxFlagsPtr New(){
        var _new = W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_C_PxFlags_ctor();
        PxFlagsPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>(enumtype e)                             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: PX_INLINE PxFlags(enumtype e)
    #if NATIVE //function start
    ES PxFlagsPtrPOD W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor( e){
        auto nat_in_e = (e);
        auto val = new PxFlags<enumtype, storagetype>();
        return *(PxFlagsPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFlagsPtr W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor( e);
    
    public  static PxFlagsPtr New( e){
         pvk_in_e = (e);
        var _new = W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor(pvk_in_e);
        PxFlagsPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>(PxFlags_enumtype_storagetypePtr f)      #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: PX_INLINE PxFlags(const PxFlags<enumtype, storagetype>& f)
    #if NATIVE //function start
    ES PxFlagsPtrPOD W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor( f){
        auto nat_in_f = (f);
        auto val = new PxFlags<enumtype, storagetype>();
        return *(PxFlagsPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFlagsPtr W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor( f);
    
    public  static PxFlagsPtr New( f){
         pvk_in_f = (f);
        var _new = W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor(pvk_in_f);
        PxFlagsPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxFlags<enumtype, storagetype>(storagetype b)                          #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type storagetype
    // NATIVE SIG: PX_INLINE explicit PxFlags(storagetype b)
    #if NATIVE //function start
    ES PxFlagsPtrPOD W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor( b){
        auto nat_in_b = (b);
        auto val = new PxFlags<enumtype, storagetype>();
        return *(PxFlagsPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFlagsPtr W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor( b);
    
    public  static PxFlagsPtr New( b){
         pvk_in_b = (b);
        var _new = W_PxFlags<enumtype, storagetype>_R_PxFlagsPtr_P__C_PxFlags_ctor(pvk_in_b);
        PxFlagsPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       isSet(enumtype e)                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: bool isSet(enumtype e) const
    #if NATIVE //function start
    ES bool W_isSet_R_bool_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->isSet(nat_in_e);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSet_R_bool_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public  bool isSet( e){
         pvk_in_e = (e);
        bool retVal = W_isSet_R_bool_P__C_PxFlags(this, pvk_in_e);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       set(enumtype e)                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: 
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype>& set(enumtype e)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_set_R_PxFlags_enumtype_storagetypePtr_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->set(nat_in_e);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_set_R_PxFlags_enumtype_storagetypePtr_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public  UNPARSED_TYPE set( e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_set_R_PxFlags_enumtype_storagetypePtr_P__C_PxFlags(this, pvk_in_e);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator==(enumtype e)                                                 #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: bool operator==(enumtype e) const
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator==(nat_in_e);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public static bool operator==(PxFlagsPtr lhs,  e){
         pvk_in_e = (e);
        bool retVal = W_OP_EqualEqual_R_bool_P__C_PxFlags(lhs, pvk_in_e);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator==(PxFlags_enumtype_storagetypePtr f)                          #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool operator==(const PxFlags<enumtype, storagetype>& f) const
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P__C_PxFlags(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator==(nat_in_f);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P__C_PxFlags(PxFlagsPtr selfPtr,  f);
    
    public static bool operator==(PxFlagsPtr lhs,  f){
         pvk_in_f = (f);
        bool retVal = W_OP_EqualEqual_R_bool_P__C_PxFlags(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator==(bool b)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_bool_C_PxFlags(physx::PxFlags* self, bool b){
        auto nat_in_b = (b);
        auto retVal = self->operator==(nat_in_b);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_bool_C_PxFlags(PxFlagsPtr selfPtr, bool b);
    
    public static bool operator==(PxFlagsPtr lhs, bool b){
        bool pvk_in_b = (b);
        bool retVal = W_OP_EqualEqual_R_bool_P_bool_C_PxFlags(lhs, pvk_in_b);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator!=(enumtype e)                                                 #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: bool operator!=(enumtype e) const
    #if NATIVE //function start
    ES bool W_OP_ExclaimEqual_R_bool_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator!=(nat_in_e);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual_R_bool_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public static bool operator!=(PxFlagsPtr lhs,  e){
         pvk_in_e = (e);
        bool retVal = W_OP_ExclaimEqual_R_bool_P__C_PxFlags(lhs, pvk_in_e);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator!=(PxFlags_enumtype_storagetypePtr f)                          #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: bool operator!=(const PxFlags<enumtype, storagetype>& f) const
    #if NATIVE //function start
    ES bool W_OP_ExclaimEqual_R_bool_P__C_PxFlags(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator!=(nat_in_f);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual_R_bool_P__C_PxFlags(PxFlagsPtr selfPtr,  f);
    
    public static bool operator!=(PxFlagsPtr lhs,  f){
         pvk_in_f = (f);
        bool retVal = W_OP_ExclaimEqual_R_bool_P__C_PxFlags(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator=(PxFlags_enumtype_storagetypePtr f)                           #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator=(enumtype e)                                                  #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator|=(enumtype e)                                                 #
    //================================================================================
    //Skipped unsupported operator PipeEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator|=(PxFlags_enumtype_storagetypePtr f)                          #
    //================================================================================
    //Skipped unsupported operator PipeEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator|(enumtype e)                                                  #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    unhandled return type:  -> PxFlags_enumtype_storagetype
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator|(enumtype e) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_OP_Pipe_R_PxFlags_enumtype_storagetype_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator|(nat_in_e);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_enumtype_storagetype_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public static UNPARSED_TYPE operator|(PxFlagsPtr lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_enumtype_storagetype_P__C_PxFlags(lhs, pvk_in_e);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator|(PxFlags_enumtype_storagetypePtr f)                           #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    unhandled return type:  -> PxFlags_enumtype_storagetype
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator|(const PxFlags<enumtype, storagetype>& f) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_OP_Pipe_R_PxFlags_enumtype_storagetype_P__C_PxFlags(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator|(nat_in_f);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_enumtype_storagetype_P__C_PxFlags(PxFlagsPtr selfPtr,  f);
    
    public static UNPARSED_TYPE operator|(PxFlagsPtr lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_enumtype_storagetype_P__C_PxFlags(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator&=(enumtype e)                                                 #
    //================================================================================
    //Skipped unsupported operator AmpEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator&=(PxFlags_enumtype_storagetypePtr f)                          #
    //================================================================================
    //Skipped unsupported operator AmpEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator&(enumtype e)                                                  #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    unhandled return type:  -> PxFlags_enumtype_storagetype
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator&(enumtype e) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_OP_Amp_R_PxFlags_enumtype_storagetype_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator&(nat_in_e);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_enumtype_storagetype_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public static UNPARSED_TYPE operator&(PxFlagsPtr lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_enumtype_storagetype_P__C_PxFlags(lhs, pvk_in_e);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator&(PxFlags_enumtype_storagetypePtr f)                           #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    unhandled return type:  -> PxFlags_enumtype_storagetype
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator&(const PxFlags<enumtype, storagetype>& f) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_OP_Amp_R_PxFlags_enumtype_storagetype_P__C_PxFlags(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator&(nat_in_f);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_enumtype_storagetype_P__C_PxFlags(PxFlagsPtr selfPtr,  f);
    
    public static UNPARSED_TYPE operator&(PxFlagsPtr lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_enumtype_storagetype_P__C_PxFlags(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator^=(enumtype e)                                                 #
    //================================================================================
    //Skipped unsupported operator CaretEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator^=(PxFlags_enumtype_storagetypePtr f)                          #
    //================================================================================
    //Skipped unsupported operator CaretEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator^(enumtype e)                                                  #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    unhandled return type:  -> PxFlags_enumtype_storagetype
    Unresolved parameter type enumtype
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator^(enumtype e) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_OP_Caret_R_PxFlags_enumtype_storagetype_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        auto retVal = self->operator^(nat_in_e);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Caret_R_PxFlags_enumtype_storagetype_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public static UNPARSED_TYPE operator^(PxFlagsPtr lhs,  e){
         pvk_in_e = (e);
        UNPARSED_TYPE retVal = W_OP_Caret_R_PxFlags_enumtype_storagetype_P__C_PxFlags(lhs, pvk_in_e);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator^(PxFlags_enumtype_storagetypePtr f)                           #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    unhandled return type:  -> PxFlags_enumtype_storagetype
    fsdfasdf
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator^(const PxFlags<enumtype, storagetype>& f) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_OP_Caret_R_PxFlags_enumtype_storagetype_P__C_PxFlags(physx::PxFlags* self,  f){
        auto nat_in_f = (f);
        auto retVal = self->operator^(nat_in_f);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Caret_R_PxFlags_enumtype_storagetype_P__C_PxFlags(PxFlagsPtr selfPtr,  f);
    
    public static UNPARSED_TYPE operator^(PxFlagsPtr lhs,  f){
         pvk_in_f = (f);
        UNPARSED_TYPE retVal = W_OP_Caret_R_PxFlags_enumtype_storagetype_P__C_PxFlags(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator~()                                                            #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    unhandled return type:  -> PxFlags_enumtype_storagetype
    // NATIVE SIG: PxFlags<enumtype, storagetype> operator~(void) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_OP_Tilde_R_PxFlags_enumtype_storagetype_C_PxFlags(physx::PxFlags* self){
        auto retVal = self->operator~();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_enumtype_storagetype_C_PxFlags(PxFlagsPtr selfPtr);
    
    public static UNPARSED_TYPE operator~(PxFlagsPtr lhs){
        UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_enumtype_storagetype_C_PxFlags(lhs);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator bool()                                                        #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator unsigned char()                                               #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator unsigned short()                                              #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator unsigned int()                                                #
    //================================================================================
    //Skipped unsupported operator Conversion.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       clear(enumtype e)                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type enumtype
    // NATIVE SIG: void clear(enumtype e)
    #if NATIVE //function start
    ES void W_clear_R_void_P__C_PxFlags(physx::PxFlags* self,  e){
        auto nat_in_e = (e);
        self->clear(nat_in_e);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clear_R_void_P__C_PxFlags(PxFlagsPtr selfPtr,  e);
    
    public  void clear( e){
         pvk_in_e = (e);
        W_clear_R_void_P__C_PxFlags(this, pvk_in_e);
    }
    #endif //function end*/
    
    

#if !NATIVE //struct close
}
#endif //struct close
