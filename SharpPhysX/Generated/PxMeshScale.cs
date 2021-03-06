// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxMeshScalePtr {
        private System.IntPtr nativePtr_;

        public static void Free(physx.PxMeshScalePtr ptr){
            Freer_physx_PxMeshScalePtr(ptr);
        }
        public void Free(){
            Freer_physx_PxMeshScalePtr(this);
        }

        public static physx.PxMeshScalePtr New() {
            return Ctor_PxMeshScalePtr_();
        }

        public static physx.PxMeshScalePtr New(float r) {
            float pvk_in_r = r;
            return Ctor_PxMeshScalePtr_float(pvk_in_r);
        }

        public static physx.PxMeshScalePtr New(physx.PxVec3* s) {
            physx.PxVec3* pvk_in_s = s;
            return Ctor_PxMeshScalePtr_PxVec3_(pvk_in_s);
        }

        public static physx.PxMeshScalePtr New(physx.PxVec3* s, physx.PxQuat* r) {
            physx.PxVec3* pvk_in_s = s;
            physx.PxQuat* pvk_in_r = r;
            return Ctor_PxMeshScalePtr_PxVec3_PxQuat_(pvk_in_s, pvk_in_r);
        }

        public static physx.PxMeshScalePtr New(physx.PxVec3 s) {
            return New((physx.PxVec3*)&s);
        }

        public static physx.PxMeshScalePtr New(physx.PxVec3.Ref s) {
            return New((physx.PxVec3*)(*((IntPtr*)(&s))));
        }

        public static physx.PxMeshScalePtr New(physx.PxVec3 s, physx.PxQuat r) {
            return New((physx.PxVec3*)&s, (physx.PxQuat*)&r);
        }

        public static physx.PxMeshScalePtr New(physx.PxVec3.Ref s, physx.PxQuat.Ref r) {
            return New((physx.PxVec3*)(*((IntPtr*)(&s))), (physx.PxQuat*)(*((IntPtr*)(&r))));
        }

        public physx.PxVec3 scale {
            get { physx.PxVec3 GetRetRef; PxMeshScalePtr_GET_scale(this, &GetRetRef); return GetRetRef; }
            set => PxMeshScalePtr_SET_scale(this, value);
        }

        public physx.PxQuat rotation {
            get { physx.PxQuat GetRetRef; PxMeshScalePtr_GET_rotation(this, &GetRetRef); return GetRetRef; }
            set => PxMeshScalePtr_SET_rotation(this, value);
        }

        public bool isIdentity() {
            physx.PxMeshScalePtr pvk_in_this = this;
            return bool_const_PxMeshScalePtr_isIdentityPtr(pvk_in_this);
        }

        public physx.PxMeshScalePtr getInverse_New() {
            physx.PxMeshScalePtr pvk_in_this = this;
            return PxMeshScalePtr_const_PxMeshScalePtr_getInversePtr(pvk_in_this);
        }

        public physx.PxMat33 toMat33() {
            physx.PxMat33 RetRef;
            physx.PxMeshScalePtr pvk_in_this = this;
            PxMat33_const_PxMeshScalePtr_toMat33Ptr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public bool hasNegativeDeterminant() {
            physx.PxMeshScalePtr pvk_in_this = this;
            return bool_const_PxMeshScalePtr_hasNegativeDeterminantPtr(pvk_in_this);
        }

        public physx.PxVec3 transform(physx.PxVec3* v) {
            physx.PxVec3 RetRef;
            physx.PxMeshScalePtr pvk_in_this = this;
            physx.PxVec3* pvk_in_v = v;
            PxVec3_const_PxMeshScalePtr_transformPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_v);
            return RetRef;
        }

        public bool isValidForTriangleMesh() {
            physx.PxMeshScalePtr pvk_in_this = this;
            return bool_const_PxMeshScalePtr_isValidForTriangleMeshPtr(pvk_in_this);
        }

        public bool isValidForConvexMesh() {
            physx.PxMeshScalePtr pvk_in_this = this;
            return bool_const_PxMeshScalePtr_isValidForConvexMeshPtr(pvk_in_this);
        }

        public physx.PxVec3 transform(physx.PxVec3 v) {
            return transform((physx.PxVec3*)&v);
        }

        public physx.PxVec3 transform(physx.PxVec3.Ref v) {
            return transform((physx.PxVec3*)(*((IntPtr*)(&v))));
        }
    }
}
