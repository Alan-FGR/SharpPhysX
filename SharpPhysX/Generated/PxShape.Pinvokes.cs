// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxShapeFlagsPtr PxShapeFlagsPtr_operator_Ptr_Pipe_PxShapeFlag_PxShapeFlag_(physx.PxShapeFlag pvk_a, physx.PxShapeFlag pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxShapeFlagsPtr PxShapeFlagsPtr_operator_Ptr_Amp_PxShapeFlag_PxShapeFlag_(physx.PxShapeFlag pvk_a, physx.PxShapeFlag pvk_b);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxShapeFlagsPtr PxShapeFlagsPtr_operator_Ptr_Tilde_PxShapeFlag_(physx.PxShapeFlag pvk_a);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern IntPtr PxShapePtr_GET_userData(physx.PxShapePtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxShapePtr_SET_userData(physx.PxShapePtr cls, IntPtr value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_releasePtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxShapePtr_getReferenceCountPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_acquireReferencePtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGeometryType PxGeometryType_const_PxShapePtr_getGeometryTypePtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setGeometryPtr_PxGeometry_(physx.PxShapePtr pvk_this, physx.PxGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxGeometryHolderPtr PxGeometryHolderPtr_const_PxShapePtr_getGeometryPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_getBoxGeometryPtr_PxBoxGeometry_(physx.PxShapePtr pvk_this, physx.PxBoxGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_getSphereGeometryPtr_PxSphereGeometry_(physx.PxShapePtr pvk_this, physx.PxSphereGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_getCapsuleGeometryPtr_PxCapsuleGeometry_(physx.PxShapePtr pvk_this, physx.PxCapsuleGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_getPlaneGeometryPtr_PxPlaneGeometry_(physx.PxShapePtr pvk_this, physx.PxPlaneGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_getConvexMeshGeometryPtr_PxConvexMeshGeometry_(physx.PxShapePtr pvk_this, physx.PxConvexMeshGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_getTriangleMeshGeometryPtr_PxTriangleMeshGeometry_(physx.PxShapePtr pvk_this, physx.PxTriangleMeshGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_getHeightFieldGeometryPtr_PxHeightFieldGeometry_(physx.PxShapePtr pvk_this, physx.PxHeightFieldGeometry* pvk_geometry);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxRigidActorPtr PxRigidActorPtr_const_PxShapePtr_getActorPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setLocalPosePtr_PxTransform_(physx.PxShapePtr pvk_this, physx.PxTransform* pvk_pose);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxTransform_const_PxShapePtr_getLocalPosePtr(physx.PxTransform* pvk_RetRef, physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setSimulationFilterDataPtr_PxFilterDataPtr_(physx.PxShapePtr pvk_this, physx.PxFilterDataPtr pvk_data);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterDataPtr PxFilterDataPtr_const_PxShapePtr_getSimulationFilterDataPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setQueryFilterDataPtr_PxFilterDataPtr_(physx.PxShapePtr pvk_this, physx.PxFilterDataPtr pvk_data);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxFilterDataPtr PxFilterDataPtr_const_PxShapePtr_getQueryFilterDataPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setMaterialsPtr_PxMaterialPtr_ushort_(physx.PxShapePtr pvk_this, physx.PxMaterialPtr* pvk_materials, ushort pvk_materialCount);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort ushort_const_PxShapePtr_getNbMaterialsPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxShapePtr_getMaterialsPtr_PxMaterialPtr_uint_uint_(physx.PxShapePtr pvk_this, physx.PxMaterialPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMaterialPtr PxMaterialPtr_const_PxShapePtr_getMaterialFromInternalFaceIndexPtr_uint_(physx.PxShapePtr pvk_this, uint pvk_faceIndex);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setContactOffsetPtr_float_(physx.PxShapePtr pvk_this, float pvk_contactOffset);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxShapePtr_getContactOffsetPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setRestOffsetPtr_float_(physx.PxShapePtr pvk_this, float pvk_restOffset);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxShapePtr_getRestOffsetPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setTorsionalPatchRadiusPtr_float_(physx.PxShapePtr pvk_this, float pvk_radius);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxShapePtr_getTorsionalPatchRadiusPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setMinTorsionalPatchRadiusPtr_float_(physx.PxShapePtr pvk_this, float pvk_radius);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxShapePtr_getMinTorsionalPatchRadiusPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setFlagPtr_PxShapeFlag_bool_(physx.PxShapePtr pvk_this, physx.PxShapeFlag pvk_flag, bool pvk_value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setFlagsPtr_PxShapeFlagsPtr_(physx.PxShapePtr pvk_this, physx.PxShapeFlagsPtr pvk_inFlags);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxShapeFlagsPtr PxShapeFlagsPtr_const_PxShapePtr_getFlagsPtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxShapePtr_isExclusivePtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxShapePtr_setNamePtr_string_(physx.PxShapePtr pvk_this, string pvk_name);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern string string_const_PxShapePtr_getNamePtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern string string_const_PxShapePtr_getConcreteTypeNamePtr(physx.PxShapePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxShapePtr_getMaterialsPtr_PxMaterialPtr_uint_(physx.PxShapePtr pvk_this, physx.PxMaterialPtr* pvk_userBuffer, uint pvk_bufferSize);

}
