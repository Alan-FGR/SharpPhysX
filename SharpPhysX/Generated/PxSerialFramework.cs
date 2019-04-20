// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    //DBG: DeclTree PxRepXSerializer physx::PxRepXSerializer L48
    //Skipping DeclTree PxRepXSerializer physx::PxRepXSerializer L48...

    //DBG: DeclTree PxSerializer physx::PxSerializer L49
    //Skipping DeclTree PxSerializer physx::PxSerializer L49...
    //Subclasses using this: 0

    public unsafe partial struct PxProcessPxBaseCallbackPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxProcessPxBaseCallback physx::PxProcessPxBaseCallback L81-86

        //DBG: MethodNode physx::PxProcessPxBaseCallback::~PxProcessPxBaseCallback L84
        //ERRORS in MethodNode: Destructor

        //DBG: MethodNode physx::PxProcessPxBaseCallback::process L85
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxProcessPxBaseCallbackPtr, man: physx.PxProcessPxBaseCallbackPtr, kind: PtrStruct
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        public void process(physx.PxBasePtr _) {
            physx.PxProcessPxBaseCallbackPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in__ = _;
            void_PxProcessPxBaseCallbackPtr_processPtr_PxBasePtr_(pvk_in_this, pvk_in__);
        }

        //DBG: MethodNode physx::PxProcessPxBaseCallback::operator= L81
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxProcessPxBaseCallback::operator= L81

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxSerializationContextPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxSerializationContext physx::PxSerializationContext L99-162

        //DBG: MethodNode physx::PxSerializationContext::registerReference L124
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxSerializationContextPtr, man: physx.PxSerializationContextPtr, kind: PtrStruct
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        //PAR nat: PxU32, man: uint, kind: Value
        //PAR nat: size_t, man: ulong, kind: Value
        public void registerReference(physx.PxBasePtr base_, uint kind, ulong reference) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_base = base_;
            uint pvk_in_kind = kind;
            ulong pvk_in_reference = reference;
            void_PxSerializationContextPtr_registerReferencePtr_PxBasePtr_uint_ulong_(pvk_in_this, pvk_in_base, pvk_in_kind, pvk_in_reference);
        }

        //DBG: MethodNode physx::PxSerializationContext::getCollection L129
        //RET nat: PxCollectionPtr, man: physx.PxCollectionPtr, ret: True, kind: PtrStruct
        //PAR nat: PxSerializationContextPtr, man: physx.PxSerializationContextPtr, kind: PtrStruct
        public physx.PxCollectionPtr getCollection() {
            physx.PxSerializationContextPtr pvk_in_this = this;
            return PxCollectionPtr_const_PxSerializationContextPtr_getCollectionPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxSerializationContext::writeData L138
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxSerializationContextPtr, man: physx.PxSerializationContextPtr, kind: PtrStruct
        //PAR nat: void*, man: IntPtr, kind: Value
        //PAR nat: PxU32, man: uint, kind: Value
        public void writeData(IntPtr data, uint size) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            IntPtr pvk_in_data = data;
            uint pvk_in_size = size;
            void_PxSerializationContextPtr_writeDataPtr_IntPtr_uint_(pvk_in_this, pvk_in_data, pvk_in_size);
        }

        //DBG: MethodNode physx::PxSerializationContext::alignData L147
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxSerializationContextPtr, man: physx.PxSerializationContextPtr, kind: PtrStruct
        //PAR nat: PxU32, man: uint, kind: Value
        public void alignData(uint alignment=16) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            uint pvk_in_alignment = alignment;
            void_PxSerializationContextPtr_alignDataPtr_uint_(pvk_in_this, pvk_in_alignment);
        }

        //DBG: MethodNode physx::PxSerializationContext::writeName L156
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxSerializationContextPtr, man: physx.PxSerializationContextPtr, kind: PtrStruct
        //PAR nat: char*, man: string, kind: Value
        public void writeName(string name) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            string pvk_in_name = name;
            void_PxSerializationContextPtr_writeNamePtr_string_(pvk_in_this, pvk_in_name);
        }

        //DBG: MethodNode physx::PxSerializationContext::operator= L99
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxSerializationContext::operator= L99

        //DBG: MethodNode physx::PxSerializationContext::alignData L147
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxSerializationContextPtr, man: physx.PxSerializationContextPtr, kind: PtrStruct
        public void alignData() {
            physx.PxSerializationContextPtr pvk_in_this = this;
            void_PxSerializationContextPtr_alignDataPtr(pvk_in_this);
        }

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxDeserializationContextPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxDeserializationContext physx::PxDeserializationContext L174-277

        //DBG: DeclNode translatePxBase physx::PxDeserializationContext::translatePxBase L203-204

        //DBG: DeclNode readExtraData physx::PxDeserializationContext::readExtraData L228-229

        //DBG: DeclNode readExtraData physx::PxDeserializationContext::readExtraData L243-244

        //DBG: MethodNode physx::PxDeserializationContext::resolveReference L196
        //RET nat: PxBasePtr, man: physx.PxBasePtr, ret: True, kind: PtrStruct
        //PAR nat: PxDeserializationContextPtr, man: physx.PxDeserializationContextPtr, kind: PtrStruct
        //PAR nat: PxU32, man: uint, kind: Value
        //PAR nat: size_t, man: ulong, kind: Value
        public physx.PxBasePtr resolveReference(uint kind, ulong reference) {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            uint pvk_in_kind = kind;
            ulong pvk_in_reference = reference;
            return PxBasePtr_const_PxDeserializationContextPtr_resolveReferencePtr_uint_ulong_(pvk_in_this, pvk_in_kind, pvk_in_reference);
        }

        //DBG: MethodNode physx::PxDeserializationContext::translatePxBase L204

        //DBG: MethodNode physx::PxDeserializationContext::readName L213-219
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxDeserializationContextPtr, man: physx.PxDeserializationContextPtr, kind: PtrStruct
        //PAR nat: char**, man: sbyte**, kind: Value
        public void readName(sbyte** name) {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            sbyte** pvk_in_name = name;
            void_PxDeserializationContextPtr_readNamePtr_sbyte_(pvk_in_this, pvk_in_name);
        }

        //DBG: MethodNode physx::PxDeserializationContext::readExtraData L229

        //DBG: MethodNode physx::PxDeserializationContext::readExtraData L244

        //DBG: MethodNode physx::PxDeserializationContext::alignExtraData L257-262
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxDeserializationContextPtr, man: physx.PxDeserializationContextPtr, kind: PtrStruct
        //PAR nat: PxU32, man: uint, kind: Value
        public void alignExtraData(uint alignment=16) {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            uint pvk_in_alignment = alignment;
            void_PxDeserializationContextPtr_alignExtraDataPtr_uint_(pvk_in_this, pvk_in_alignment);
        }

        //DBG: MethodNode physx::PxDeserializationContext::getPhysXVersion L269
        //RET nat: PxU32, man: uint, ret: True, kind: Value
        //PAR nat: PxDeserializationContextPtr, man: physx.PxDeserializationContextPtr, kind: PtrStruct
        public uint getPhysXVersion() {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            return uint_const_PxDeserializationContextPtr_getPhysXVersionPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxDeserializationContext::operator= L174
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxDeserializationContext::operator= L174

        //DBG: MethodNode physx::PxDeserializationContext::readExtraData L229

        //DBG: MethodNode physx::PxDeserializationContext::readExtraData L244

        //DBG: MethodNode physx::PxDeserializationContext::alignExtraData L257-262
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxDeserializationContextPtr, man: physx.PxDeserializationContextPtr, kind: PtrStruct
        public void alignExtraData() {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            void_PxDeserializationContextPtr_alignExtraDataPtr(pvk_in_this);
        }

        //Operators
    }
    //Subclasses using this: 0

    public unsafe partial struct PxSerializationRegistryPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxSerializationRegistry physx::PxSerializationRegistry L297-399

        //DBG: MethodNode physx::PxSerializationRegistry::registerSerializer L314

        //DBG: MethodNode physx::PxSerializationRegistry::unregisterSerializer L324

        //DBG: MethodNode physx::PxSerializationRegistry::registerBinaryMetaDataCallback L335
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxSerializationRegistryPtr, man: physx.PxSerializationRegistryPtr, kind: PtrStruct
        //PAR nat: PxBinaryMetaDataCallback, man: PxBinaryMetaDataCallback, kind: Value
        public void registerBinaryMetaDataCallback(PxBinaryMetaDataCallback callback) {
            physx.PxSerializationRegistryPtr pvk_in_this = this;
            PxBinaryMetaDataCallback pvk_in_callback = callback;
            void_PxSerializationRegistryPtr_registerBinaryMetaDataCallbackPtr_PxBinaryMetaDataCallback_(pvk_in_this, pvk_in_callback);
        }

        //DBG: MethodNode physx::PxSerializationRegistry::getSerializer L345

        //DBG: MethodNode physx::PxSerializationRegistry::registerRepXSerializer L362

        //DBG: MethodNode physx::PxSerializationRegistry::unregisterRepXSerializer L372

        //DBG: MethodNode physx::PxSerializationRegistry::getRepXSerializer L382

        //DBG: MethodNode physx::PxSerializationRegistry::release L395
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxSerializationRegistryPtr, man: physx.PxSerializationRegistryPtr, kind: PtrStruct
        public void release() {
            physx.PxSerializationRegistryPtr pvk_in_this = this;
            void_PxSerializationRegistryPtr_releasePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxSerializationRegistry::operator= L297
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxSerializationRegistry::operator= L297

        //Operators
    }

    //DBG: DeclNode PxSerialObjectId physx::PxSerialObjectId L62

    //DBG: DeclNode PxType physx::PxType L45

    //DBG: DeclNode PxBinaryMetaDataCallback physx::PxBinaryMetaDataCallback L285
}
