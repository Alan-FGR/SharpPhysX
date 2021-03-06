// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class PxCollection{

    public static physx.PxCollectionPtr PxCreateCollection() {
        return PxCollectionPtr_PxCreateCollectionPtr();
    }
}
public static unsafe partial class physx {

    public unsafe partial struct PxCollectionPtr {
        private System.IntPtr nativePtr_;

        public void add(physx.PxBasePtr object_, ulong id=0) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_object = object_;
            ulong pvk_in_id = id;
            void_PxCollectionPtr_addPtr_PxBasePtr_ulong_(pvk_in_this, pvk_in_object, pvk_in_id);
        }

        public void remove(physx.PxBasePtr object_) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_object = object_;
            void_PxCollectionPtr_removePtr_PxBasePtr_(pvk_in_this, pvk_in_object);
        }

        public bool contains(physx.PxBasePtr object_) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_object = object_;
            return bool_const_PxCollectionPtr_containsPtr_PxBasePtr_(pvk_in_this, pvk_in_object);
        }

        public void addId(physx.PxBasePtr object_, ulong id) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_object = object_;
            ulong pvk_in_id = id;
            void_PxCollectionPtr_addIdPtr_PxBasePtr_ulong_(pvk_in_this, pvk_in_object, pvk_in_id);
        }

        public void removeId(ulong id) {
            physx.PxCollectionPtr pvk_in_this = this;
            ulong pvk_in_id = id;
            void_PxCollectionPtr_removeIdPtr_ulong_(pvk_in_this, pvk_in_id);
        }

        public void add(physx.PxCollectionPtr collection) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxCollectionPtr pvk_in_collection = collection;
            void_PxCollectionPtr_addPtr_PxCollectionPtr_(pvk_in_this, pvk_in_collection);
        }

        public void remove(physx.PxCollectionPtr collection) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxCollectionPtr pvk_in_collection = collection;
            void_PxCollectionPtr_removePtr_PxCollectionPtr_(pvk_in_this, pvk_in_collection);
        }

        public uint getNbObjects() {
            physx.PxCollectionPtr pvk_in_this = this;
            return uint_const_PxCollectionPtr_getNbObjectsPtr(pvk_in_this);
        }

        public physx.PxBasePtr getObject(uint index) {
            physx.PxCollectionPtr pvk_in_this = this;
            uint pvk_in_index = index;
            return PxBasePtr_const_PxCollectionPtr_getObjectPtr_uint_(pvk_in_this, pvk_in_index);
        }

        public uint getObjects(physx.PxBasePtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_PxCollectionPtr_getObjectsPtr_PxBasePtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }

        public physx.PxBasePtr find(ulong id) {
            physx.PxCollectionPtr pvk_in_this = this;
            ulong pvk_in_id = id;
            return PxBasePtr_const_PxCollectionPtr_findPtr_ulong_(pvk_in_this, pvk_in_id);
        }

        public uint getNbIds() {
            physx.PxCollectionPtr pvk_in_this = this;
            return uint_const_PxCollectionPtr_getNbIdsPtr(pvk_in_this);
        }

        public uint getIds(ulong* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxCollectionPtr pvk_in_this = this;
            ulong* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_PxCollectionPtr_getIdsPtr_ulong_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }

        public ulong getId(physx.PxBasePtr object_) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_object = object_;
            return ulong_const_PxCollectionPtr_getIdPtr_PxBasePtr_(pvk_in_this, pvk_in_object);
        }

        public void release() {
            physx.PxCollectionPtr pvk_in_this = this;
            void_PxCollectionPtr_releasePtr(pvk_in_this);
        }

        public void add(physx.PxBasePtr object_) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr pvk_in_object = object_;
            void_PxCollectionPtr_addPtr_PxBasePtr_(pvk_in_this, pvk_in_object);
        }

        public uint getObjects(physx.PxBasePtr* userBuffer, uint bufferSize) {
            physx.PxCollectionPtr pvk_in_this = this;
            physx.PxBasePtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_PxCollectionPtr_getObjectsPtr_PxBasePtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }

        public uint getIds(ulong* userBuffer, uint bufferSize) {
            physx.PxCollectionPtr pvk_in_this = this;
            ulong* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_PxCollectionPtr_getIdsPtr_ulong_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
    }
}
