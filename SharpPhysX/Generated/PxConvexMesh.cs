// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxHullPolygonPtr {
        private System.IntPtr nativePtr_;

        public static physx.PxHullPolygonPtr New(){
            return Newer_physx_PxHullPolygonPtr();
        }
        public static void Free(physx.PxHullPolygonPtr ptr){
            Freer_physx_PxHullPolygonPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxHullPolygonPtr(this);
        }

        public ushort mNbVerts {
            get => PxHullPolygonPtr_GET_mNbVerts(this);
            set => PxHullPolygonPtr_SET_mNbVerts(this, value);
        }

        public ushort mIndexBase {
            get => PxHullPolygonPtr_GET_mIndexBase(this);
            set => PxHullPolygonPtr_SET_mIndexBase(this, value);
        }

    }

    public unsafe partial struct PxConvexMeshPtr : physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public uint getNbVertices() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            return uint_const_PxConvexMeshPtr_getNbVerticesPtr(pvk_in_this);
        }

        public physx.PxVec3* getVertices() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            return PxVec3_const_PxConvexMeshPtr_getVerticesPtr(pvk_in_this);
        }

        public byte* getIndexBuffer() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            return byte_const_PxConvexMeshPtr_getIndexBufferPtr(pvk_in_this);
        }

        public uint getNbPolygons() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            return uint_const_PxConvexMeshPtr_getNbPolygonsPtr(pvk_in_this);
        }

        public bool getPolygonData(uint index, physx.PxHullPolygonPtr data) {
            physx.PxConvexMeshPtr pvk_in_this = this;
            uint pvk_in_index = index;
            physx.PxHullPolygonPtr pvk_in_data = data;
            return bool_const_PxConvexMeshPtr_getPolygonDataPtr_uint_PxHullPolygonPtr_(pvk_in_this, pvk_in_index, pvk_in_data);
        }

        public void release() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            void_PxConvexMeshPtr_releasePtr(pvk_in_this);
        }

        public uint getReferenceCount() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            return uint_const_PxConvexMeshPtr_getReferenceCountPtr(pvk_in_this);
        }

        public void acquireReference() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            void_PxConvexMeshPtr_acquireReferencePtr(pvk_in_this);
        }

        public void getMassInformation(float* mass, physx.PxMat33* localInertia, physx.PxVec3* localCenterOfMass) {
            physx.PxConvexMeshPtr pvk_in_this = this;
            float* pvk_in_mass = mass;
            physx.PxMat33* pvk_in_localInertia = localInertia;
            physx.PxVec3* pvk_in_localCenterOfMass = localCenterOfMass;
            void_const_PxConvexMeshPtr_getMassInformationPtr_float_PxMat33_PxVec3_(pvk_in_this, pvk_in_mass, pvk_in_localInertia, pvk_in_localCenterOfMass);
        }

        public physx.PxBounds3 getLocalBounds() {
            physx.PxBounds3 RetRef;
            physx.PxConvexMeshPtr pvk_in_this = this;
            PxBounds3_const_PxConvexMeshPtr_getLocalBoundsPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public string getConcreteTypeName() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            return string_const_PxConvexMeshPtr_getConcreteTypeNamePtr(pvk_in_this);
        }

        public bool isGpuCompatible() {
            physx.PxConvexMeshPtr pvk_in_this = this;
            return bool_const_PxConvexMeshPtr_isGpuCompatiblePtr(pvk_in_this);
        }

        public void getMassInformation(float* mass, physx.PxMat33 localInertia, physx.PxVec3 localCenterOfMass) {
            getMassInformation(mass, (physx.PxMat33*)&localInertia, (physx.PxVec3*)&localCenterOfMass);
        }

        public void getMassInformation(float* mass, physx.PxMat33.Ref localInertia, physx.PxVec3.Ref localCenterOfMass) {
            getMassInformation(mass, (physx.PxMat33*)(*((IntPtr*)(&localInertia))), (physx.PxVec3*)(*((IntPtr*)(&localCenterOfMass))));
        }
        public static implicit operator physx.PxBasePtr(PxConvexMeshPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxConvexMeshPtr(physx.PxBasePtr obj) => *(PxConvexMeshPtr*)&obj;

        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlag flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }
}
