// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    [StructLayout(LayoutKind.Sequential, Size = 28)]
    public unsafe partial struct PxTransform {
        public physx.PxQuat q;
        public physx.PxVec3 p;

        public static physx.PxTransform Default() {
            physx.PxTransform RetRef;
            Default_PxTransform_(&RetRef);
            return RetRef;
        }

        public PxTransform(physx.PxVec3 position) : this((physx.PxVec3*)&position) {
            //ctor piping;
        }

        public PxTransform(physx.PxVec3.Ref position) : this((physx.PxVec3*)(*((IntPtr*)(&position)))) {
            //ctor piping;
        }

        public PxTransform(physx.PxVec3* position) {

            physx.PxVec3* pvk_in_position = position;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_PxVec3_(pvk_in_this, pvk_in_position);
            this = toInit;
        }

        public PxTransform(physx.PxIDENTITY r) {

            physx.PxIDENTITY pvk_in_r = r;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_PxIDENTITY_(pvk_in_this, pvk_in_r);
            this = toInit;
        }

        public PxTransform(physx.PxQuat orientation) : this((physx.PxQuat*)&orientation) {
            //ctor piping;
        }

        public PxTransform(physx.PxQuat.Ref orientation) : this((physx.PxQuat*)(*((IntPtr*)(&orientation)))) {
            //ctor piping;
        }

        public PxTransform(physx.PxQuat* orientation) {

            physx.PxQuat* pvk_in_orientation = orientation;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_PxQuat_(pvk_in_this, pvk_in_orientation);
            this = toInit;
        }

        public PxTransform(float x, float y, float z) {

            float pvk_in_x = x;
            float pvk_in_y = y;
            float pvk_in_z = z;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_float_float_float_(pvk_in_this, pvk_in_x, pvk_in_y, pvk_in_z);
            this = toInit;
        }

        public PxTransform(float x, float y, float z, physx.PxQuat aQ) {

            float pvk_in_x = x;
            float pvk_in_y = y;
            float pvk_in_z = z;
            physx.PxQuat pvk_in_aQ = aQ;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_float_float_float_PxQuat_(pvk_in_this, pvk_in_x, pvk_in_y, pvk_in_z, pvk_in_aQ);
            this = toInit;
        }

        public PxTransform(physx.PxVec3 p0, physx.PxQuat q0) : this((physx.PxVec3*)&p0, (physx.PxQuat*)&q0) {
            //ctor piping;
        }

        public PxTransform(physx.PxVec3.Ref p0, physx.PxQuat.Ref q0) : this((physx.PxVec3*)(*((IntPtr*)(&p0))), (physx.PxQuat*)(*((IntPtr*)(&q0)))) {
            //ctor piping;
        }

        public PxTransform(physx.PxVec3* p0, physx.PxQuat* q0) {

            physx.PxVec3* pvk_in_p0 = p0;
            physx.PxQuat* pvk_in_q0 = q0;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_PxVec3_PxQuat_(pvk_in_this, pvk_in_p0, pvk_in_q0);
            this = toInit;
        }

        public PxTransform(physx.PxMat44 m) : this((physx.PxMat44*)&m) {
            //ctor piping;
        }

        public PxTransform(physx.PxMat44.Ref m) : this((physx.PxMat44*)(*((IntPtr*)(&m)))) {
            //ctor piping;
        }

        public PxTransform(physx.PxMat44* m) {

            physx.PxMat44* pvk_in_m = m;
            PxTransform toInit;
            var pvk_in_this = &toInit;
            void_PxTransform_PxTransformPtr_Ctor_PxMat44_(pvk_in_this, pvk_in_m);
            this = toInit;
        }

        public static bool OpEquals(physx.PxTransform lhs, physx.PxTransform t) {
            return OpEquals(lhs, (physx.PxTransform*)&t);
        }

        public static bool OpEquals(physx.PxTransform lhs, physx.PxTransform.Ref t) {
            return OpEquals(lhs, (physx.PxTransform*)(*((IntPtr*)(&t))));
        }

        public static bool OpEquals(physx.PxTransform lhs, physx.PxTransform* t) {
            physx.PxTransform* pvk_in_lhs = &lhs;
            physx.PxTransform* pvk_in_t = t;
            return bool_const_PxTransform_operator_Ptr_EqualEqual_PxTransform_(pvk_in_lhs, pvk_in_t);
        }

        public static physx.PxTransform OpMultiply(physx.PxTransform lhs, physx.PxTransform x) {
            return OpMultiply(lhs, (physx.PxTransform*)&x);
        }

        public static physx.PxTransform OpMultiply(physx.PxTransform lhs, physx.PxTransform.Ref x) {
            return OpMultiply(lhs, (physx.PxTransform*)(*((IntPtr*)(&x))));
        }

        public static physx.PxTransform OpMultiply(physx.PxTransform lhs, physx.PxTransform* x) {
            physx.PxTransform RetRef;
            physx.PxTransform* pvk_in_lhs = &lhs;
            physx.PxTransform* pvk_in_x = x;
            PxTransform_const_PxTransform_operator_Ptr_Star_PxTransform_(&RetRef, pvk_in_lhs, pvk_in_x);
            return RetRef;
        }

        public static physx.PxTransform* OpStarEqual(physx.PxTransform lhs, physx.PxTransform other) {
            return OpStarEqual(lhs, (physx.PxTransform*)&other);
        }

        public static physx.PxTransform* OpStarEqual(physx.PxTransform lhs, physx.PxTransform.Ref other) {
            return OpStarEqual(lhs, (physx.PxTransform*)(*((IntPtr*)(&other))));
        }

        public static physx.PxTransform* OpStarEqual(physx.PxTransform lhs, physx.PxTransform* other) {
            physx.PxTransform* pvk_in_lhs = &lhs;
            physx.PxTransform* pvk_in_other = other;
            return PxTransform_PxTransform_operator_Ptr_StarEqual_PxTransform_(pvk_in_lhs, pvk_in_other);
        }

        public physx.PxTransform getInverse() {
            physx.PxTransform RetRef;

            fixed (PxTransform* pvk_in_this = &this){
              PxTransform_const_PxTransform_getInversePtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public physx.PxVec3 transform(physx.PxVec3 input) {
            return transform((physx.PxVec3*)&input);
        }

        public physx.PxVec3 transform(physx.PxVec3.Ref input) {
            return transform((physx.PxVec3*)(*((IntPtr*)(&input))));
        }

        public physx.PxVec3 transform(physx.PxVec3* input) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_input = input;
            fixed (PxTransform* pvk_in_this = &this){
              PxVec3_const_PxTransform_transformPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_input);
            }
            return RetRef;
        }

        public physx.PxVec3 transformInv(physx.PxVec3 input) {
            return transformInv((physx.PxVec3*)&input);
        }

        public physx.PxVec3 transformInv(physx.PxVec3.Ref input) {
            return transformInv((physx.PxVec3*)(*((IntPtr*)(&input))));
        }

        public physx.PxVec3 transformInv(physx.PxVec3* input) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_input = input;
            fixed (PxTransform* pvk_in_this = &this){
              PxVec3_const_PxTransform_transformInvPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_input);
            }
            return RetRef;
        }

        public physx.PxVec3 rotate(physx.PxVec3 input) {
            return rotate((physx.PxVec3*)&input);
        }

        public physx.PxVec3 rotate(physx.PxVec3.Ref input) {
            return rotate((physx.PxVec3*)(*((IntPtr*)(&input))));
        }

        public physx.PxVec3 rotate(physx.PxVec3* input) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_input = input;
            fixed (PxTransform* pvk_in_this = &this){
              PxVec3_const_PxTransform_rotatePtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_input);
            }
            return RetRef;
        }

        public physx.PxVec3 rotateInv(physx.PxVec3 input) {
            return rotateInv((physx.PxVec3*)&input);
        }

        public physx.PxVec3 rotateInv(physx.PxVec3.Ref input) {
            return rotateInv((physx.PxVec3*)(*((IntPtr*)(&input))));
        }

        public physx.PxVec3 rotateInv(physx.PxVec3* input) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_input = input;
            fixed (PxTransform* pvk_in_this = &this){
              PxVec3_const_PxTransform_rotateInvPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_input);
            }
            return RetRef;
        }

        public physx.PxTransform transform(physx.PxTransform src) {
            return transform((physx.PxTransform*)&src);
        }

        public physx.PxTransform transform(physx.PxTransform.Ref src) {
            return transform((physx.PxTransform*)(*((IntPtr*)(&src))));
        }

        public physx.PxTransform transform(physx.PxTransform* src) {
            physx.PxTransform RetRef;

            physx.PxTransform* pvk_in_src = src;
            fixed (PxTransform* pvk_in_this = &this){
              PxTransform_const_PxTransform_transformPtr_PxTransform_(&RetRef, pvk_in_this, pvk_in_src);
            }
            return RetRef;
        }

        public bool isValid() {

            fixed (PxTransform* pvk_in_this = &this){
              return bool_const_PxTransform_isValidPtr(pvk_in_this);
            }
        }

        public bool isSane() {

            fixed (PxTransform* pvk_in_this = &this){
              return bool_const_PxTransform_isSanePtr(pvk_in_this);
            }
        }

        public bool isFinite() {

            fixed (PxTransform* pvk_in_this = &this){
              return bool_const_PxTransform_isFinitePtr(pvk_in_this);
            }
        }

        public physx.PxTransform transformInv(physx.PxTransform src) {
            return transformInv((physx.PxTransform*)&src);
        }

        public physx.PxTransform transformInv(physx.PxTransform.Ref src) {
            return transformInv((physx.PxTransform*)(*((IntPtr*)(&src))));
        }

        public physx.PxTransform transformInv(physx.PxTransform* src) {
            physx.PxTransform RetRef;

            physx.PxTransform* pvk_in_src = src;
            fixed (PxTransform* pvk_in_this = &this){
              PxTransform_const_PxTransform_transformInvPtr_PxTransform_(&RetRef, pvk_in_this, pvk_in_src);
            }
            return RetRef;
        }

        public physx.PxPlane transform(physx.PxPlane plane) {
            return transform((physx.PxPlane*)&plane);
        }

        public physx.PxPlane transform(physx.PxPlane.Ref plane) {
            return transform((physx.PxPlane*)(*((IntPtr*)(&plane))));
        }

        public physx.PxPlane transform(physx.PxPlane* plane) {
            physx.PxPlane RetRef;

            physx.PxPlane* pvk_in_plane = plane;
            fixed (PxTransform* pvk_in_this = &this){
              PxPlane_const_PxTransform_transformPtr_PxPlane_(&RetRef, pvk_in_this, pvk_in_plane);
            }
            return RetRef;
        }

        public physx.PxPlane inverseTransform(physx.PxPlane plane) {
            return inverseTransform((physx.PxPlane*)&plane);
        }

        public physx.PxPlane inverseTransform(physx.PxPlane.Ref plane) {
            return inverseTransform((physx.PxPlane*)(*((IntPtr*)(&plane))));
        }

        public physx.PxPlane inverseTransform(physx.PxPlane* plane) {
            physx.PxPlane RetRef;

            physx.PxPlane* pvk_in_plane = plane;
            fixed (PxTransform* pvk_in_this = &this){
              PxPlane_const_PxTransform_inverseTransformPtr_PxPlane_(&RetRef, pvk_in_this, pvk_in_plane);
            }
            return RetRef;
        }

        public physx.PxTransform getNormalized() {
            physx.PxTransform RetRef;

            fixed (PxTransform* pvk_in_this = &this){
              PxTransform_const_PxTransform_getNormalizedPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxTransform obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
        public static bool operator==(physx.PxTransform lhs, physx.PxTransform t) {
            return physx.PxTransform.OpEquals(lhs, (physx.PxTransform*)&t);
        }
        public static bool operator!=(physx.PxTransform lhs, physx.PxTransform t) {
            return !(physx.PxTransform.OpEquals(lhs, (physx.PxTransform*)&t)); // Matching Operator
        }
        public static bool operator==(physx.PxTransform lhs, physx.PxTransform.Ref t) {
            return physx.PxTransform.OpEquals(lhs, (physx.PxTransform*)(*((IntPtr*)(&t))));
        }
        public static bool operator!=(physx.PxTransform lhs, physx.PxTransform.Ref t) {
            return !(physx.PxTransform.OpEquals(lhs, (physx.PxTransform*)(*((IntPtr*)(&t))))); // Matching Operator
        }
        public static bool operator==(physx.PxTransform lhs, physx.PxTransform* t) {
            return physx.PxTransform.OpEquals(lhs, t);
        }
        public static bool operator!=(physx.PxTransform lhs, physx.PxTransform* t) {
            return !(physx.PxTransform.OpEquals(lhs, t)); // Matching Operator
        }
        public static physx.PxTransform operator*(physx.PxTransform lhs, physx.PxTransform x) {
            return physx.PxTransform.OpMultiply(lhs, (physx.PxTransform*)&x);
        }
        public static physx.PxTransform operator*(physx.PxTransform lhs, physx.PxTransform.Ref x) {
            return physx.PxTransform.OpMultiply(lhs, (physx.PxTransform*)(*((IntPtr*)(&x))));
        }
        public static physx.PxTransform operator*(physx.PxTransform lhs, physx.PxTransform* x) {
            return physx.PxTransform.OpMultiply(lhs, x);
        }
    }
}
