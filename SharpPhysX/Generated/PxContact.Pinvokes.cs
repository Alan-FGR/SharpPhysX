// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMassModificationPropsPtr Newer_physx_PxMassModificationPropsPtr();
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxMassModificationPropsPtr(physx.PxMassModificationPropsPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxMassModificationPropsPtr_GET_mInvMassScale0(physx.PxMassModificationPropsPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMassModificationPropsPtr_SET_mInvMassScale0(physx.PxMassModificationPropsPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxMassModificationPropsPtr_GET_mInvInertiaScale0(physx.PxMassModificationPropsPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMassModificationPropsPtr_SET_mInvInertiaScale0(physx.PxMassModificationPropsPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxMassModificationPropsPtr_GET_mInvMassScale1(physx.PxMassModificationPropsPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMassModificationPropsPtr_SET_mInvMassScale1(physx.PxMassModificationPropsPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxMassModificationPropsPtr_GET_mInvInertiaScale1(physx.PxMassModificationPropsPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxMassModificationPropsPtr_SET_mInvInertiaScale1(physx.PxMassModificationPropsPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxContactPatchPtr Newer_physx_PxContactPatchPtr();
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxContactPatchPtr(physx.PxContactPatchPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxMassModificationPropsPtr PxContactPatchPtr_GET_mMassModification(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_mMassModification(physx.PxContactPatchPtr cls, physx.PxMassModificationPropsPtr value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_GET_normal(physx.PxContactPatchPtr cls, physx.PxVec3* GetRetRef);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_normal(physx.PxContactPatchPtr cls, physx.PxVec3 value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxContactPatchPtr_GET_restitution(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_restitution(physx.PxContactPatchPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxContactPatchPtr_GET_dynamicFriction(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_dynamicFriction(physx.PxContactPatchPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxContactPatchPtr_GET_staticFriction(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_staticFriction(physx.PxContactPatchPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern byte PxContactPatchPtr_GET_startContactIndex(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_startContactIndex(physx.PxContactPatchPtr cls, byte value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern byte PxContactPatchPtr_GET_nbContacts(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_nbContacts(physx.PxContactPatchPtr cls, byte value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern byte PxContactPatchPtr_GET_materialFlags(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_materialFlags(physx.PxContactPatchPtr cls, byte value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern byte PxContactPatchPtr_GET_internalFlags(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_internalFlags(physx.PxContactPatchPtr cls, byte value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxContactPatchPtr_GET_materialIndex0(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_materialIndex0(physx.PxContactPatchPtr cls, ushort value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxContactPatchPtr_GET_materialIndex1(physx.PxContactPatchPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPatchPtr_SET_materialIndex1(physx.PxContactPatchPtr cls, ushort value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxContactPtr Newer_physx_PxContactPtr();
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxContactPtr(physx.PxContactPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPtr_GET_contact(physx.PxContactPtr cls, physx.PxVec3* GetRetRef);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPtr_SET_contact(physx.PxContactPtr cls, physx.PxVec3 value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxContactPtr_GET_separation(physx.PxContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactPtr_SET_separation(physx.PxContactPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxExtendedContactPtr Newer_physx_PxExtendedContactPtr();
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxExtendedContactPtr(physx.PxExtendedContactPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxExtendedContactPtr_GET_targetVelocity(physx.PxExtendedContactPtr cls, physx.PxVec3* GetRetRef);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxExtendedContactPtr_SET_targetVelocity(physx.PxExtendedContactPtr cls, physx.PxVec3 value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxExtendedContactPtr_GET_maxImpulse(physx.PxExtendedContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxExtendedContactPtr_SET_maxImpulse(physx.PxExtendedContactPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxModifiableContactPtr Newer_physx_PxModifiableContactPtr();
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxModifiableContactPtr(physx.PxModifiableContactPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_GET_normal(physx.PxModifiableContactPtr cls, physx.PxVec3* GetRetRef);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_SET_normal(physx.PxModifiableContactPtr cls, physx.PxVec3 value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxModifiableContactPtr_GET_restitution(physx.PxModifiableContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_SET_restitution(physx.PxModifiableContactPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxModifiableContactPtr_GET_materialFlags(physx.PxModifiableContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_SET_materialFlags(physx.PxModifiableContactPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxModifiableContactPtr_GET_materialIndex0(physx.PxModifiableContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_SET_materialIndex0(physx.PxModifiableContactPtr cls, ushort value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort PxModifiableContactPtr_GET_materialIndex1(physx.PxModifiableContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_SET_materialIndex1(physx.PxModifiableContactPtr cls, ushort value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxModifiableContactPtr_GET_staticFriction(physx.PxModifiableContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_SET_staticFriction(physx.PxModifiableContactPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float PxModifiableContactPtr_GET_dynamicFriction(physx.PxModifiableContactPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxModifiableContactPtr_SET_dynamicFriction(physx.PxModifiableContactPtr cls, float value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void Freer_physx_PxContactStreamIteratorPtr(physx.PxContactStreamIteratorPtr ptr);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxContactStreamIteratorPtr Ctor_PxContactStreamIteratorPtr_byte_byte_uint_uint_uint(byte* pvk_contactPatches, byte* pvk_contactPoints, uint* pvk_contactFaceIndices, uint pvk_nbPatches, uint pvk_nbContacts);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_GET_zero(physx.PxContactStreamIteratorPtr cls, physx.PxVec3* GetRetRef);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_zero(physx.PxContactStreamIteratorPtr cls, physx.PxVec3 value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxContactPatchPtr PxContactStreamIteratorPtr_GET_patch(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_patch(physx.PxContactStreamIteratorPtr cls, physx.PxContactPatchPtr value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxContactPtr PxContactStreamIteratorPtr_GET_contact(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_contact(physx.PxContactStreamIteratorPtr cls, physx.PxContactPtr value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint* PxContactStreamIteratorPtr_GET_faceIndice(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_faceIndice(physx.PxContactStreamIteratorPtr cls, uint* value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_totalPatches(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_totalPatches(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_totalContacts(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_totalContacts(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_nextContactIndex(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_nextContactIndex(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_nextPatchIndex(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_nextPatchIndex(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_contactPatchHeaderSize(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_contactPatchHeaderSize(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_contactPointSize(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_contactPointSize(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxContactStreamIteratorPtr.StreamFormat PxContactStreamIteratorPtr_GET_mStreamFormat(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_mStreamFormat(physx.PxContactStreamIteratorPtr cls, physx.PxContactStreamIteratorPtr.StreamFormat value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_forceNoResponse(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_forceNoResponse(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool PxContactStreamIteratorPtr_GET_pointStepped(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_pointStepped(physx.PxContactStreamIteratorPtr cls, bool value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint PxContactStreamIteratorPtr_GET_hasFaceIndices(physx.PxContactStreamIteratorPtr cls);
[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void PxContactStreamIteratorPtr_SET_hasFaceIndices(physx.PxContactStreamIteratorPtr cls, uint value);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxContactStreamIteratorPtr_hasNextPatchPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxContactStreamIteratorPtr_getTotalContactCountPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxContactStreamIteratorPtr_getTotalPatchCountPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxContactStreamIteratorPtr_nextPatchPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxContactStreamIteratorPtr_hasNextContactPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxContactStreamIteratorPtr_nextContactPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec3* PxVec3_const_PxContactStreamIteratorPtr_getContactNormalPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getInvMassScale0Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getInvMassScale1Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getInvInertiaScale0Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getInvInertiaScale1Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getMaxImpulsePtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec3* PxVec3_const_PxContactStreamIteratorPtr_getTargetVelPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxVec3* PxVec3_const_PxContactStreamIteratorPtr_getContactPointPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getSeparationPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxContactStreamIteratorPtr_getFaceIndex0Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxContactStreamIteratorPtr_getFaceIndex1Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getStaticFrictionPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getDynamicFrictionPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern float float_const_PxContactStreamIteratorPtr_getRestitutionPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxContactStreamIteratorPtr_getMaterialFlagsPtr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort ushort_const_PxContactStreamIteratorPtr_getMaterialIndex0Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern ushort ushort_const_PxContactStreamIteratorPtr_getMaterialIndex1Ptr(physx.PxContactStreamIteratorPtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxContactStreamIteratorPtr_advanceToIndexPtr_uintC(physx.PxContactStreamIteratorPtr pvk_this, uint pvk_initialIndex);

}
