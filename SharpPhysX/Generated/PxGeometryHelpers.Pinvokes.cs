// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

//Subclasses using this: 0

//DBG: ClassNode PxGeometryHolder physx::PxGeometryHolder L64-203
//Subclasses using this: 0

//DBG: ClassNode  physx::PxGeometryHolder L193-202

//DBG: NewerFreerNode  physx::PxGeometryHolder L193-202
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxGeometryHolderPtr_physx_PxGeometryHolder_ANONYMOUS_unionPtr(physx.PxGeometryHolderPtr.physx_PxGeometryHolder_ANONYMOUS_unionPtr ptr);

//DBG: Field: geometry - 194-194
//Errors in type geometryPtr, field physx::PxGeometryHolder::geometry

//DBG: Field: box - 195-195
//Errors in type boxPtr, field physx::PxGeometryHolder::box

//DBG: Field: sphere - 196-196
//Errors in type spherePtr, field physx::PxGeometryHolder::sphere

//DBG: Field: capsule - 197-197
//Errors in type capsulePtr, field physx::PxGeometryHolder::capsule

//DBG: Field: plane - 198-198
//Errors in type planePtr, field physx::PxGeometryHolder::plane

//DBG: Field: convex - 199-199
//Errors in type convexPtr, field physx::PxGeometryHolder::convex

//DBG: Field: mesh - 200-200
//Errors in type meshPtr, field physx::PxGeometryHolder::mesh

//DBG: Field: heightfield - 201-201
//Errors in type heightfieldPtr, field physx::PxGeometryHolder::heightfield

//Operators

//DBG: NewerFreerNode PxGeometryHolder physx::PxGeometryHolder L64-203
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxGeometryHolderPtr(physx.PxGeometryHolderPtr ptr);

//DBG: PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L172
//RET nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, ret: True, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGeometryHolderPtr Ctor_PxGeometryHolderPtr_();

//DBG: PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L173
//RET nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxGeometry*, man: physx.PxGeometry*, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGeometryHolderPtr Ctor_PxGeometryHolderPtr_PxGeometry_(physx.PxGeometry* pvk_geometry);

//DBG: PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L64
//ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L64

//DBG: PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L64
//ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L64

//DBG: PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L173
//Value Converter New
//RET nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxGeometry, man: physx.PxGeometry, kind: Blittable

//DBG: PtrWrapperCtorNode physx::PxGeometryHolder::PxGeometryHolder L173
//Value Converter New
//RET nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxGeometry, man: physx.PxGeometry, kind: Blittable

//DBG: MethodNode physx::PxGeometryHolder::getType L67-70
//RET nat: physx::PxGeometryType::Enum, man: physx.PxGeometryTypeEnum, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGeometryTypeEnum PxGeometryTypeEnum_const_PxGeometryHolderPtr_getTypePtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::any L72-75
//RET nat: physx::PxGeometry*, man: physx.PxGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGeometry* PxGeometry_PxGeometryHolderPtr_anyPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::any L77-80
//RET nat: physx::PxGeometry*, man: physx.PxGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGeometry* PxGeometry_const_PxGeometryHolderPtr_anyPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::sphere L82-85
//RET nat: physx::PxSphereGeometry*, man: physx.PxSphereGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxSphereGeometry* PxSphereGeometry_PxGeometryHolderPtr_spherePtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::sphere L87-90
//RET nat: physx::PxSphereGeometry*, man: physx.PxSphereGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxSphereGeometry* PxSphereGeometry_const_PxGeometryHolderPtr_spherePtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::plane L92-95
//RET nat: physx::PxPlaneGeometry*, man: physx.PxPlaneGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxPlaneGeometry* PxPlaneGeometry_PxGeometryHolderPtr_planePtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::plane L97-100
//RET nat: physx::PxPlaneGeometry*, man: physx.PxPlaneGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxPlaneGeometry* PxPlaneGeometry_const_PxGeometryHolderPtr_planePtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::capsule L102-105
//RET nat: physx::PxCapsuleGeometry*, man: physx.PxCapsuleGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxCapsuleGeometry* PxCapsuleGeometry_PxGeometryHolderPtr_capsulePtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::capsule L107-110
//RET nat: physx::PxCapsuleGeometry*, man: physx.PxCapsuleGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxCapsuleGeometry* PxCapsuleGeometry_const_PxGeometryHolderPtr_capsulePtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::box L112-115
//RET nat: physx::PxBoxGeometry*, man: physx.PxBoxGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBoxGeometry* PxBoxGeometry_PxGeometryHolderPtr_boxPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::box L117-120
//RET nat: physx::PxBoxGeometry*, man: physx.PxBoxGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxBoxGeometry* PxBoxGeometry_const_PxGeometryHolderPtr_boxPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::convexMesh L122-125
//RET nat: physx::PxConvexMeshGeometry*, man: physx.PxConvexMeshGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxConvexMeshGeometry* PxConvexMeshGeometry_PxGeometryHolderPtr_convexMeshPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::convexMesh L127-130
//RET nat: physx::PxConvexMeshGeometry*, man: physx.PxConvexMeshGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxConvexMeshGeometry* PxConvexMeshGeometry_const_PxGeometryHolderPtr_convexMeshPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::triangleMesh L132-135
//RET nat: physx::PxTriangleMeshGeometry*, man: physx.PxTriangleMeshGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxTriangleMeshGeometry* PxTriangleMeshGeometry_PxGeometryHolderPtr_triangleMeshPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::triangleMesh L137-140
//RET nat: physx::PxTriangleMeshGeometry*, man: physx.PxTriangleMeshGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxTriangleMeshGeometry* PxTriangleMeshGeometry_const_PxGeometryHolderPtr_triangleMeshPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::heightField L142-145
//RET nat: physx::PxHeightFieldGeometry*, man: physx.PxHeightFieldGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxHeightFieldGeometry* PxHeightFieldGeometry_PxGeometryHolderPtr_heightFieldPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::heightField L147-150
//RET nat: physx::PxHeightFieldGeometry*, man: physx.PxHeightFieldGeometry*, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxHeightFieldGeometry* PxHeightFieldGeometry_const_PxGeometryHolderPtr_heightFieldPtr(physx.PxGeometryHolderPtr pvk_this);

//DBG: MethodNode physx::PxGeometryHolder::storeAny L152-170
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
//PAR nat: physx::PxGeometry*, man: physx.PxGeometry*, kind: Value
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxGeometryHolderPtr_storeAnyPtr_PxGeometry_(physx.PxGeometryHolderPtr pvk_this, physx.PxGeometry* pvk_geometry);

//DBG: MethodNode physx::PxGeometryHolder::operator= L64
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxGeometryHolder::operator= L64

//DBG: MethodNode physx::PxGeometryHolder::operator= L64
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxGeometryHolder::operator= L64

//DBG: MethodNode physx::PxGeometryHolder::~PxGeometryHolder L64
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxGeometryHolder::~PxGeometryHolder L64, Destructor

//DBG: MethodNode physx::PxGeometryHolder::storeAny L152-170
//Value Converter storeAny
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
//PAR nat: physx::PxGeometry, man: physx.PxGeometry, kind: Blittable

//DBG: MethodNode physx::PxGeometryHolder::storeAny L152-170
//Value Converter storeAny
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxGeometryHolderPtr, man: physx.PxGeometryHolderPtr, kind: PtrStruct
//PAR nat: physx::PxGeometry, man: physx.PxGeometry, kind: Blittable

//Operators
}
