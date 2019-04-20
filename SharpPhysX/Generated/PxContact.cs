// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {
    //Subclasses using this: 0

    public unsafe partial struct PxMassModificationPropsPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxMassModificationProps physx::PxMassModificationProps L50-56

        //DBG: NewerFreerNode PxMassModificationProps physx::PxMassModificationProps L50-56
        public static physx.PxMassModificationPropsPtr New(){
            return Newer_physx_PxMassModificationPropsPtr();
        }
        public static void Free(physx.PxMassModificationPropsPtr ptr){
            Freer_physx_PxMassModificationPropsPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxMassModificationPropsPtr(this);
        }

        //DBG: PtrWrapperCtorNode physx::PxMassModificationProps::PxMassModificationProps L50
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxMassModificationProps::PxMassModificationProps L50

        //DBG: PtrWrapperCtorNode physx::PxMassModificationProps::PxMassModificationProps L50
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxMassModificationProps::PxMassModificationProps L50

        //DBG: PtrWrapperCtorNode physx::PxMassModificationProps::PxMassModificationProps L50
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxMassModificationProps::PxMassModificationProps L50

        //DBG: Field: mInvMassScale0 - 52-52
        public float mInvMassScale0 {
            get => PxMassModificationPropsPtr_GET_mInvMassScale0(this);
            set => PxMassModificationPropsPtr_SET_mInvMassScale0(this, value);
        }

        //DBG: Field: mInvInertiaScale0 - 53-53
        public float mInvInertiaScale0 {
            get => PxMassModificationPropsPtr_GET_mInvInertiaScale0(this);
            set => PxMassModificationPropsPtr_SET_mInvInertiaScale0(this, value);
        }

        //DBG: Field: mInvMassScale1 - 54-54
        public float mInvMassScale1 {
            get => PxMassModificationPropsPtr_GET_mInvMassScale1(this);
            set => PxMassModificationPropsPtr_SET_mInvMassScale1(this, value);
        }

        //DBG: Field: mInvInertiaScale1 - 55-55
        public float mInvInertiaScale1 {
            get => PxMassModificationPropsPtr_GET_mInvInertiaScale1(this);
            set => PxMassModificationPropsPtr_SET_mInvInertiaScale1(this, value);
        }

        //DBG: MethodNode physx::PxMassModificationProps::~PxMassModificationProps L50
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxMassModificationProps::~PxMassModificationProps L50, Destructor

        //DBG: MethodNode physx::PxMassModificationProps::operator= L50
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxMassModificationProps::operator= L50

        //DBG: MethodNode physx::PxMassModificationProps::operator= L50
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxMassModificationProps::operator= L50

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxContactPatchPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxContactPatch physx::PxContactPatch L64-100
        public enum PxContactPatchFlags : int {
            eHAS_FACE_INDICES = 1,              // eHAS_FACE_INDICES = 1
            eMODIFIABLE = 2,                    // eMODIFIABLE = 2
            eFORCE_NO_RESPONSE = 4,             // eFORCE_NO_RESPONSE = 4
            eHAS_MODIFIED_MASS_RATIOS = 8,      // eHAS_MODIFIED_MASS_RATIOS = 8
            eHAS_TARGET_VELOCITY = 16,          // eHAS_TARGET_VELOCITY = 16
            eHAS_MAX_IMPULSE = 32,              // eHAS_MAX_IMPULSE = 32
            eREGENERATE_PATCHES = 64,           // eREGENERATE_PATCHES = 64
            eCOMPRESSED_MODIFIED_CONTACT = 128, // eCOMPRESSED_MODIFIED_CONTACT = 128
        }

        //DBG: NewerFreerNode PxContactPatch physx::PxContactPatch L64-100
        public static physx.PxContactPatchPtr New(){
            return Newer_physx_PxContactPatchPtr();
        }
        public static void Free(physx.PxContactPatchPtr ptr){
            Freer_physx_PxContactPatchPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxContactPatchPtr(this);
        }

        //DBG: PtrWrapperCtorNode physx::PxContactPatch::PxContactPatch L64
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContactPatch::PxContactPatch L64

        //DBG: PtrWrapperCtorNode physx::PxContactPatch::PxContactPatch L64
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContactPatch::PxContactPatch L64

        //DBG: PtrWrapperCtorNode physx::PxContactPatch::PxContactPatch L64
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContactPatch::PxContactPatch L64

        //DBG: Field: mMassModification - 79-79
        public physx.PxMassModificationPropsPtr mMassModification {
            get => PxContactPatchPtr_GET_mMassModification(this);
            set => PxContactPatchPtr_SET_mMassModification(this, value);
        }

        //DBG: Field: normal - 83-83
        public physx.PxVec3 normal {
            get { physx.PxVec3 GetRetRef; PxContactPatchPtr_GET_normal(this, &GetRetRef); return GetRetRef; }
            set => PxContactPatchPtr_SET_normal(this, value);
        }

        //DBG: Field: restitution - 87-87
        public float restitution {
            get => PxContactPatchPtr_GET_restitution(this);
            set => PxContactPatchPtr_SET_restitution(this, value);
        }

        //DBG: Field: dynamicFriction - 89-89
        public float dynamicFriction {
            get => PxContactPatchPtr_GET_dynamicFriction(this);
            set => PxContactPatchPtr_SET_dynamicFriction(this, value);
        }

        //DBG: Field: staticFriction - 90-90
        public float staticFriction {
            get => PxContactPatchPtr_GET_staticFriction(this);
            set => PxContactPatchPtr_SET_staticFriction(this, value);
        }

        //DBG: Field: startContactIndex - 91-91
        public byte startContactIndex {
            get => PxContactPatchPtr_GET_startContactIndex(this);
            set => PxContactPatchPtr_SET_startContactIndex(this, value);
        }

        //DBG: Field: nbContacts - 92-92
        public byte nbContacts {
            get => PxContactPatchPtr_GET_nbContacts(this);
            set => PxContactPatchPtr_SET_nbContacts(this, value);
        }

        //DBG: Field: materialFlags - 94-94
        public byte materialFlags {
            get => PxContactPatchPtr_GET_materialFlags(this);
            set => PxContactPatchPtr_SET_materialFlags(this, value);
        }

        //DBG: Field: internalFlags - 95-95
        public byte internalFlags {
            get => PxContactPatchPtr_GET_internalFlags(this);
            set => PxContactPatchPtr_SET_internalFlags(this, value);
        }

        //DBG: Field: materialIndex0 - 96-96
        public ushort materialIndex0 {
            get => PxContactPatchPtr_GET_materialIndex0(this);
            set => PxContactPatchPtr_SET_materialIndex0(this, value);
        }

        //DBG: Field: materialIndex1 - 97-97
        public ushort materialIndex1 {
            get => PxContactPatchPtr_GET_materialIndex1(this);
            set => PxContactPatchPtr_SET_materialIndex1(this, value);
        }

        //DBG: MethodNode physx::PxContactPatch::operator= L64
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContactPatch::operator= L64

        //DBG: MethodNode physx::PxContactPatch::operator= L64
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContactPatch::operator= L64

        //DBG: MethodNode physx::PxContactPatch::~PxContactPatch L64
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContactPatch::~PxContactPatch L64, Destructor

        //Operators
    }
    //Subclasses using this: 2

    public unsafe partial struct PxContactPtr : physx.PxContactPtr.IPxContactPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxContact physx::PxContact L108-118

        //DBG: NewerFreerNode PxContact physx::PxContact L108-118
        public static physx.PxContactPtr New(){
            return Newer_physx_PxContactPtr();
        }
        public static void Free(physx.PxContactPtr ptr){
            Freer_physx_PxContactPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxContactPtr(this);
        }

        //DBG: PtrWrapperCtorNode physx::PxContact::PxContact L108
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContact::PxContact L108

        //DBG: PtrWrapperCtorNode physx::PxContact::PxContact L108
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContact::PxContact L108

        //DBG: PtrWrapperCtorNode physx::PxContact::PxContact L108
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContact::PxContact L108

        //DBG: Field: contact - 113-113
        public physx.PxVec3 contact {
            get { physx.PxVec3 GetRetRef; PxContactPtr_GET_contact(this, &GetRetRef); return GetRetRef; }
            set => PxContactPtr_SET_contact(this, value);
        }

        //DBG: Field: separation - 117-117
        public float separation {
            get => PxContactPtr_GET_separation(this);
            set => PxContactPtr_SET_separation(this, value);
        }

        //DBG: MethodNode physx::PxContact::operator= L108
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContact::operator= L108

        //DBG: MethodNode physx::PxContact::~PxContact L108
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContact::~PxContact L108, Destructor

        //DBG: MethodNode physx::PxContact::operator= L108
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContact::operator= L108

        //INTERFACES
        public unsafe interface IPxContactPtr {
            physx.PxVec3 contact {get;set;}
            float separation {get;set;}
        }

        //Operators
    }
    //Subclasses using this: 1

    public unsafe partial struct PxExtendedContactPtr : physx.PxExtendedContactPtr.IPxExtendedContactPtr, physx.PxContactPtr.IPxContactPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxExtendedContact physx::PxExtendedContact L122-132Bases: PxContactPtr

        //DBG: NewerFreerNode PxExtendedContact physx::PxExtendedContact L122-132
        public static physx.PxExtendedContactPtr New(){
            return Newer_physx_PxExtendedContactPtr();
        }
        public static void Free(physx.PxExtendedContactPtr ptr){
            Freer_physx_PxExtendedContactPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxExtendedContactPtr(this);
        }

        //DBG: PtrWrapperCtorNode physx::PxExtendedContact::PxExtendedContact L122
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxExtendedContact::PxExtendedContact L122

        //DBG: PtrWrapperCtorNode physx::PxExtendedContact::PxExtendedContact L122
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxExtendedContact::PxExtendedContact L122

        //DBG: PtrWrapperCtorNode physx::PxExtendedContact::PxExtendedContact L122
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxExtendedContact::PxExtendedContact L122

        //DBG: Field: targetVelocity - 127-127
        public physx.PxVec3 targetVelocity {
            get { physx.PxVec3 GetRetRef; PxExtendedContactPtr_GET_targetVelocity(this, &GetRetRef); return GetRetRef; }
            set => PxExtendedContactPtr_SET_targetVelocity(this, value);
        }

        //DBG: Field: maxImpulse - 131-131
        public float maxImpulse {
            get => PxExtendedContactPtr_GET_maxImpulse(this);
            set => PxExtendedContactPtr_SET_maxImpulse(this, value);
        }

        //DBG: MethodNode physx::PxExtendedContact::operator= L122
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxExtendedContact::operator= L122

        //DBG: MethodNode physx::PxExtendedContact::~PxExtendedContact L122
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxExtendedContact::~PxExtendedContact L122, Destructor

        //DBG: MethodNode physx::PxExtendedContact::operator= L122
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxExtendedContact::operator= L122
        public static implicit operator physx.PxContactPtr(PxExtendedContactPtr obj) => *(physx.PxContactPtr*)&obj;
        public static explicit operator PxExtendedContactPtr(physx.PxContactPtr obj) => *(PxExtendedContactPtr*)&obj;

        //DBG: Field: contact - 113-113
        public physx.PxVec3 contact {
            get { physx.PxVec3 GetRetRef; PxContactPtr_GET_contact(this, &GetRetRef); return GetRetRef; }
            set => PxContactPtr_SET_contact(this, value);
        }

        //DBG: Field: separation - 117-117
        public float separation {
            get => PxContactPtr_GET_separation(this);
            set => PxContactPtr_SET_separation(this, value);
        }

        //INTERFACES
        public unsafe interface IPxExtendedContactPtr {
            physx.PxVec3 targetVelocity {get;set;}
            float maxImpulse {get;set;}
        }

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxModifiableContactPtr : physx.PxExtendedContactPtr.IPxExtendedContactPtr, physx.PxContactPtr.IPxContactPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxModifiableContact physx::PxModifiableContact L140-172Bases: PxExtendedContactPtr|PxContactPtr

        //DBG: NewerFreerNode PxModifiableContact physx::PxModifiableContact L140-172
        public static physx.PxModifiableContactPtr New(){
            return Newer_physx_PxModifiableContactPtr();
        }
        public static void Free(physx.PxModifiableContactPtr ptr){
            Freer_physx_PxModifiableContactPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxModifiableContactPtr(this);
        }

        //DBG: PtrWrapperCtorNode physx::PxModifiableContact::PxModifiableContact L140
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxModifiableContact::PxModifiableContact L140

        //DBG: PtrWrapperCtorNode physx::PxModifiableContact::PxModifiableContact L140
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxModifiableContact::PxModifiableContact L140

        //DBG: PtrWrapperCtorNode physx::PxModifiableContact::PxModifiableContact L140
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxModifiableContact::PxModifiableContact L140

        //DBG: Field: normal - 145-145
        public physx.PxVec3 normal {
            get { physx.PxVec3 GetRetRef; PxModifiableContactPtr_GET_normal(this, &GetRetRef); return GetRetRef; }
            set => PxModifiableContactPtr_SET_normal(this, value);
        }

        //DBG: Field: restitution - 149-149
        public float restitution {
            get => PxModifiableContactPtr_GET_restitution(this);
            set => PxModifiableContactPtr_SET_restitution(this, value);
        }

        //DBG: Field: materialFlags - 154-154
        public uint materialFlags {
            get => PxModifiableContactPtr_GET_materialFlags(this);
            set => PxModifiableContactPtr_SET_materialFlags(this, value);
        }

        //DBG: Field: materialIndex0 - 159-159
        public ushort materialIndex0 {
            get => PxModifiableContactPtr_GET_materialIndex0(this);
            set => PxModifiableContactPtr_SET_materialIndex0(this, value);
        }

        //DBG: Field: materialIndex1 - 163-163
        public ushort materialIndex1 {
            get => PxModifiableContactPtr_GET_materialIndex1(this);
            set => PxModifiableContactPtr_SET_materialIndex1(this, value);
        }

        //DBG: Field: staticFriction - 167-167
        public float staticFriction {
            get => PxModifiableContactPtr_GET_staticFriction(this);
            set => PxModifiableContactPtr_SET_staticFriction(this, value);
        }

        //DBG: Field: dynamicFriction - 171-171
        public float dynamicFriction {
            get => PxModifiableContactPtr_GET_dynamicFriction(this);
            set => PxModifiableContactPtr_SET_dynamicFriction(this, value);
        }

        //DBG: MethodNode physx::PxModifiableContact::operator= L140
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxModifiableContact::operator= L140

        //DBG: MethodNode physx::PxModifiableContact::operator= L140
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxModifiableContact::operator= L140

        //DBG: MethodNode physx::PxModifiableContact::~PxModifiableContact L140
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxModifiableContact::~PxModifiableContact L140, Destructor
        public static implicit operator physx.PxExtendedContactPtr(PxModifiableContactPtr obj) => *(physx.PxExtendedContactPtr*)&obj;
        public static explicit operator PxModifiableContactPtr(physx.PxExtendedContactPtr obj) => *(PxModifiableContactPtr*)&obj;
        public static implicit operator physx.PxContactPtr(PxModifiableContactPtr obj) => *(physx.PxContactPtr*)&obj;
        public static explicit operator PxModifiableContactPtr(physx.PxContactPtr obj) => *(PxModifiableContactPtr*)&obj;

        //DBG: Field: targetVelocity - 127-127
        public physx.PxVec3 targetVelocity {
            get { physx.PxVec3 GetRetRef; PxExtendedContactPtr_GET_targetVelocity(this, &GetRetRef); return GetRetRef; }
            set => PxExtendedContactPtr_SET_targetVelocity(this, value);
        }

        //DBG: Field: maxImpulse - 131-131
        public float maxImpulse {
            get => PxExtendedContactPtr_GET_maxImpulse(this);
            set => PxExtendedContactPtr_SET_maxImpulse(this, value);
        }

        //DBG: Field: contact - 113-113
        public physx.PxVec3 contact {
            get { physx.PxVec3 GetRetRef; PxContactPtr_GET_contact(this, &GetRetRef); return GetRetRef; }
            set => PxContactPtr_SET_contact(this, value);
        }

        //DBG: Field: separation - 117-117
        public float separation {
            get => PxContactPtr_GET_separation(this);
            set => PxContactPtr_SET_separation(this, value);
        }

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxContactStreamIteratorPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxContactStreamIterator physx::PxContactStreamIterator L178-572
        public enum StreamFormat : int {
            eSIMPLE_STREAM = 0,                // eSIMPLE_STREAM
            eMODIFIABLE_STREAM = 1,            // eMODIFIABLE_STREAM
            eCOMPRESSED_MODIFIABLE_STREAM = 2, // eCOMPRESSED_MODIFIABLE_STREAM
        }

        //DBG: NewerFreerNode PxContactStreamIterator physx::PxContactStreamIterator L178-572
        public static void Free(physx.PxContactStreamIteratorPtr ptr){
            Freer_physx_PxContactStreamIteratorPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxContactStreamIteratorPtr(this);
        }

        //DBG: PtrWrapperCtorNode physx::PxContactStreamIterator::PxContactStreamIterator L254-297
        //RET nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, ret: True, kind: PtrStruct
        //PAR nat: PxU8*, man: byte*, kind: Value
        //PAR nat: PxU8*, man: byte*, kind: Value
        //PAR nat: PxU32*, man: uint*, kind: Value
        //PAR nat: PxU32, man: uint, kind: Value
        //PAR nat: PxU32, man: uint, kind: Value
        public static physx.PxContactStreamIteratorPtr New(byte* contactPatches, byte* contactPoints, uint* contactFaceIndices, uint nbPatches, uint nbContacts) {
            byte* pvk_in_contactPatches = contactPatches;
            byte* pvk_in_contactPoints = contactPoints;
            uint* pvk_in_contactFaceIndices = contactFaceIndices;
            uint pvk_in_nbPatches = nbPatches;
            uint pvk_in_nbContacts = nbContacts;
            return Ctor_PxContactStreamIteratorPtr_byte_byte_uint_uint_uint(pvk_in_contactPatches, pvk_in_contactPoints, pvk_in_contactFaceIndices, pvk_in_nbPatches, pvk_in_nbContacts);
        }

        //DBG: PtrWrapperCtorNode physx::PxContactStreamIterator::PxContactStreamIterator L178
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContactStreamIterator::PxContactStreamIterator L178

        //DBG: PtrWrapperCtorNode physx::PxContactStreamIterator::PxContactStreamIterator L178
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxContactStreamIterator::PxContactStreamIterator L178

        //DBG: Field: zero - 191-191
        public physx.PxVec3 zero {
            get { physx.PxVec3 GetRetRef; PxContactStreamIteratorPtr_GET_zero(this, &GetRetRef); return GetRetRef; }
            set => PxContactStreamIteratorPtr_SET_zero(this, value);
        }

        //DBG: Field: patch - 195-195
        public physx.PxContactPatchPtr patch {
            get => PxContactStreamIteratorPtr_GET_patch(this);
            set => PxContactStreamIteratorPtr_SET_patch(this, value);
        }

        //DBG: Field: contact - 200-200
        public physx.PxContactPtr contact {
            get => PxContactStreamIteratorPtr_GET_contact(this);
            set => PxContactStreamIteratorPtr_SET_contact(this, value);
        }

        //DBG: Field: faceIndice - 205-205
        public uint* faceIndice {
            get => PxContactStreamIteratorPtr_GET_faceIndice(this);
            set => PxContactStreamIteratorPtr_SET_faceIndice(this, value);
        }

        //DBG: Field: totalPatches - 211-211
        public uint totalPatches {
            get => PxContactStreamIteratorPtr_GET_totalPatches(this);
            set => PxContactStreamIteratorPtr_SET_totalPatches(this, value);
        }

        //DBG: Field: totalContacts - 216-216
        public uint totalContacts {
            get => PxContactStreamIteratorPtr_GET_totalContacts(this);
            set => PxContactStreamIteratorPtr_SET_totalContacts(this, value);
        }

        //DBG: Field: nextContactIndex - 221-221
        public uint nextContactIndex {
            get => PxContactStreamIteratorPtr_GET_nextContactIndex(this);
            set => PxContactStreamIteratorPtr_SET_nextContactIndex(this, value);
        }

        //DBG: Field: nextPatchIndex - 226-226
        public uint nextPatchIndex {
            get => PxContactStreamIteratorPtr_GET_nextPatchIndex(this);
            set => PxContactStreamIteratorPtr_SET_nextPatchIndex(this, value);
        }

        //DBG: Field: contactPatchHeaderSize - 232-232
        public uint contactPatchHeaderSize {
            get => PxContactStreamIteratorPtr_GET_contactPatchHeaderSize(this);
            set => PxContactStreamIteratorPtr_SET_contactPatchHeaderSize(this, value);
        }

        //DBG: Field: contactPointSize - 237-237
        public uint contactPointSize {
            get => PxContactStreamIteratorPtr_GET_contactPointSize(this);
            set => PxContactStreamIteratorPtr_SET_contactPointSize(this, value);
        }

        //DBG: Field: mStreamFormat - 241-241
        public physx.PxContactStreamIteratorPtr.StreamFormat mStreamFormat {
            get => PxContactStreamIteratorPtr_GET_mStreamFormat(this);
            set => PxContactStreamIteratorPtr_SET_mStreamFormat(this, value);
        }

        //DBG: Field: forceNoResponse - 245-245
        public uint forceNoResponse {
            get => PxContactStreamIteratorPtr_GET_forceNoResponse(this);
            set => PxContactStreamIteratorPtr_SET_forceNoResponse(this, value);
        }

        //DBG: Field: pointStepped - 247-247
        public bool pointStepped {
            get => PxContactStreamIteratorPtr_GET_pointStepped(this);
            set => PxContactStreamIteratorPtr_SET_pointStepped(this, value);
        }

        //DBG: Field: hasFaceIndices - 249-249
        public uint hasFaceIndices {
            get => PxContactStreamIteratorPtr_GET_hasFaceIndices(this);
            set => PxContactStreamIteratorPtr_SET_hasFaceIndices(this, value);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::hasNextPatch L303-306
        //RET nat: bool, man: bool, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public bool hasNextPatch() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return bool_const_PxContactStreamIteratorPtr_hasNextPatchPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getTotalContactCount L312-315
        //RET nat: PxU32, man: uint, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public uint getTotalContactCount() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return uint_const_PxContactStreamIteratorPtr_getTotalContactCountPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getTotalPatchCount L317-320
        //RET nat: PxU32, man: uint, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public uint getTotalPatchCount() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return uint_const_PxContactStreamIteratorPtr_getTotalPatchCountPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::nextPatch L325-339
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public void nextPatch() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            void_PxContactStreamIteratorPtr_nextPatchPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::hasNextContact L345-348
        //RET nat: bool, man: bool, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public bool hasNextContact() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return bool_const_PxContactStreamIteratorPtr_hasNextContactPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::nextContact L353-363
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public void nextContact() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            void_PxContactStreamIteratorPtr_nextContactPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getContactNormal L370-373
        //RET nat: physx::PxVec3*, man: physx.PxVec3*, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public physx.PxVec3* getContactNormal() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return PxVec3_const_PxContactStreamIteratorPtr_getContactNormalPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getInvMassScale0 L379-382
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getInvMassScale0() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getInvMassScale0Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getInvMassScale1 L388-391
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getInvMassScale1() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getInvMassScale1Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getInvInertiaScale0 L397-400
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getInvInertiaScale0() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getInvInertiaScale0Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getInvInertiaScale1 L406-409
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getInvInertiaScale1() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getInvInertiaScale1Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getMaxImpulse L415-418
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getMaxImpulse() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getMaxImpulsePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getTargetVel L424-427
        //RET nat: physx::PxVec3*, man: physx.PxVec3*, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public physx.PxVec3* getTargetVel() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return PxVec3_const_PxContactStreamIteratorPtr_getTargetVelPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getContactPoint L433-436
        //RET nat: physx::PxVec3*, man: physx.PxVec3*, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public physx.PxVec3* getContactPoint() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return PxVec3_const_PxContactStreamIteratorPtr_getContactPointPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getSeparation L442-445
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getSeparation() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getSeparationPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getFaceIndex0 L451-454
        //RET nat: PxU32, man: uint, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public uint getFaceIndex0() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return uint_const_PxContactStreamIteratorPtr_getFaceIndex0Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getFaceIndex1 L460-463
        //RET nat: PxU32, man: uint, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public uint getFaceIndex1() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return uint_const_PxContactStreamIteratorPtr_getFaceIndex1Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getStaticFriction L469-472
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getStaticFriction() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getStaticFrictionPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getDynamicFriction L478-481
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getDynamicFriction() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getDynamicFrictionPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getRestitution L487-490
        //RET nat: PxReal, man: float, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public float getRestitution() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return float_const_PxContactStreamIteratorPtr_getRestitutionPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getMaterialFlags L496-499
        //RET nat: PxU32, man: uint, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public uint getMaterialFlags() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return uint_const_PxContactStreamIteratorPtr_getMaterialFlagsPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getMaterialIndex0 L505-508
        //RET nat: PxU16, man: ushort, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public ushort getMaterialIndex0() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return ushort_const_PxContactStreamIteratorPtr_getMaterialIndex0Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::getMaterialIndex1 L514-517
        //RET nat: PxU16, man: ushort, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        public ushort getMaterialIndex1() {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            return ushort_const_PxContactStreamIteratorPtr_getMaterialIndex1Ptr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::advanceToIndex L522-554
        //RET nat: bool, man: bool, ret: True, kind: Value
        //PAR nat: PxContactStreamIteratorPtr, man: physx.PxContactStreamIteratorPtr, kind: PtrStruct
        //PAR nat: PxU32, man: uint, kind: Value
        public bool advanceToIndex(uint initialIndex) {
            physx.PxContactStreamIteratorPtr pvk_in_this = this;
            uint pvk_in_initialIndex = initialIndex;
            return bool_PxContactStreamIteratorPtr_advanceToIndexPtr_uintC(pvk_in_this, pvk_in_initialIndex);
        }

        //DBG: MethodNode physx::PxContactStreamIterator::operator= L178
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContactStreamIterator::operator= L178

        //DBG: MethodNode physx::PxContactStreamIterator::operator= L178
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContactStreamIterator::operator= L178

        //DBG: MethodNode physx::PxContactStreamIterator::~PxContactStreamIterator L178
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxContactStreamIterator::~PxContactStreamIterator L178, Destructor

        //Operators
    }
}
