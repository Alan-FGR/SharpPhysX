// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxProcessPxBaseCallbackPtr {
        private System.IntPtr nativePtr_;

        public void process(physx.PxBasePtr _) {
            physx.PxProcessPxBaseCallbackPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in__ = _;
            void_PxProcessPxBaseCallbackPtr_processPtr_PxBasePtr_(pvk_in_this, pvk_in__);
        }

    }

    public unsafe partial struct PxSerializationContextPtr {
        private System.IntPtr nativePtr_;

        public void registerReference(physx.PxBasePtr base_, uint kind, ulong reference) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_base = base_;
            uint pvk_in_kind = kind;
            ulong pvk_in_reference = reference;
            void_PxSerializationContextPtr_registerReferencePtr_PxBasePtr_uint_ulong_(pvk_in_this, pvk_in_base, pvk_in_kind, pvk_in_reference);
        }

        public physx.PxCollectionPtr getCollection() {
            physx.PxSerializationContextPtr pvk_in_this = this;
            return PxCollectionPtr_const_PxSerializationContextPtr_getCollectionPtr(pvk_in_this);
        }

        public void writeData(IntPtr data, uint size) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            IntPtr pvk_in_data = data;
            uint pvk_in_size = size;
            void_PxSerializationContextPtr_writeDataPtr_IntPtr_uint_(pvk_in_this, pvk_in_data, pvk_in_size);
        }

        public void alignData(uint alignment=16) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            uint pvk_in_alignment = alignment;
            void_PxSerializationContextPtr_alignDataPtr_uint_(pvk_in_this, pvk_in_alignment);
        }

        public void writeName(string name) {
            physx.PxSerializationContextPtr pvk_in_this = this;
            string pvk_in_name = name;
            void_PxSerializationContextPtr_writeNamePtr_string_(pvk_in_this, pvk_in_name);
        }

        public void alignData() {
            physx.PxSerializationContextPtr pvk_in_this = this;
            void_PxSerializationContextPtr_alignDataPtr(pvk_in_this);
        }
    }

    public unsafe partial struct PxDeserializationContextPtr {
        private System.IntPtr nativePtr_;

        public physx.PxBasePtr resolveReference(uint kind, ulong reference) {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            uint pvk_in_kind = kind;
            ulong pvk_in_reference = reference;
            return PxBasePtr_const_PxDeserializationContextPtr_resolveReferencePtr_uint_ulong_(pvk_in_this, pvk_in_kind, pvk_in_reference);
        }

        public void readName(sbyte** name) {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            sbyte** pvk_in_name = name;
            void_PxDeserializationContextPtr_readNamePtr_sbyte_(pvk_in_this, pvk_in_name);
        }

        public void alignExtraData(uint alignment=16) {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            uint pvk_in_alignment = alignment;
            void_PxDeserializationContextPtr_alignExtraDataPtr_uint_(pvk_in_this, pvk_in_alignment);
        }

        public uint getPhysXVersion() {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            return uint_const_PxDeserializationContextPtr_getPhysXVersionPtr(pvk_in_this);
        }

        public void alignExtraData() {
            physx.PxDeserializationContextPtr pvk_in_this = this;
            void_PxDeserializationContextPtr_alignExtraDataPtr(pvk_in_this);
        }
    }

    public unsafe partial struct PxSerializationRegistryPtr {
        private System.IntPtr nativePtr_;

        public void registerBinaryMetaDataCallback(PxBinaryMetaDataCallback callback) {
            physx.PxSerializationRegistryPtr pvk_in_this = this;
            PxBinaryMetaDataCallback pvk_in_callback = callback;
            void_PxSerializationRegistryPtr_registerBinaryMetaDataCallbackPtr_PxBinaryMetaDataCallback_(pvk_in_this, pvk_in_callback);
        }

        public void release() {
            physx.PxSerializationRegistryPtr pvk_in_this = this;
            void_PxSerializationRegistryPtr_releasePtr(pvk_in_this);
        }

    }

}
