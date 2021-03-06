// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxVec3 OpMultiply(float f, physx.PxVec3 v) {
        return OpMultiply(f, (physx.PxVec3*)&v);
    }

    public static physx.PxVec3 OpMultiply(float f, physx.PxVec3.Ref v) {
        return OpMultiply(f, (physx.PxVec3*)(*((IntPtr*)(&v))));
    }

    public static physx.PxVec3 OpMultiply(float f, physx.PxVec3* v) {
        physx.PxVec3 RetRef;
        float pvk_in_f = f;
        physx.PxVec3* pvk_in_v = v;
        PxVec3_operator_Ptr_Star_float_PxVec3_(&RetRef, pvk_in_f, pvk_in_v);
        return RetRef;
    }

    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public unsafe partial struct PxVec3 {
        [FieldOffset(0)] public float x;
        [FieldOffset(4)] public float y;
        [FieldOffset(8)] public float z;

        public static PxVec3 Default() {

            PxVec3 toInit;
            var pvk_in_this = &toInit;
            void_PxVec3_PxVec3Ptr_Ctor(pvk_in_this);
            return toInit;
        }

        public PxVec3(physx.PxZERO r) {

            physx.PxZERO pvk_in_r = r;
            PxVec3 toInit;
            var pvk_in_this = &toInit;
            void_PxVec3_PxVec3Ptr_Ctor_PxZERO_(pvk_in_this, pvk_in_r);
            this = toInit;
        }

        public PxVec3(float a) {

            float pvk_in_a = a;
            PxVec3 toInit;
            var pvk_in_this = &toInit;
            void_PxVec3_PxVec3Ptr_Ctor_float_(pvk_in_this, pvk_in_a);
            this = toInit;
        }

        public PxVec3(float nx, float ny, float nz) {

            float pvk_in_nx = nx;
            float pvk_in_ny = ny;
            float pvk_in_nz = nz;
            PxVec3 toInit;
            var pvk_in_this = &toInit;
            void_PxVec3_PxVec3Ptr_Ctor_float_float_float_(pvk_in_this, pvk_in_nx, pvk_in_ny, pvk_in_nz);
            this = toInit;
        }

        public PxVec3(physx.PxVec3 v) : this((physx.PxVec3*)&v) {
            //ctor piping;
        }

        public PxVec3(physx.PxVec3.Ref v) : this((physx.PxVec3*)(*((IntPtr*)(&v)))) {
            //ctor piping;
        }

        public PxVec3(physx.PxVec3* v) {

            physx.PxVec3* pvk_in_v = v;
            PxVec3 toInit;
            var pvk_in_this = &toInit;
            void_PxVec3_PxVec3Ptr_Ctor_PxVec3_(pvk_in_this, pvk_in_v);
            this = toInit;
        }

        public static physx.PxVec3* OpEqual(physx.PxVec3 lhs, physx.PxVec3 p) {
            return OpEqual(lhs, (physx.PxVec3*)&p);
        }

        public static physx.PxVec3* OpEqual(physx.PxVec3 lhs, physx.PxVec3.Ref p) {
            return OpEqual(lhs, (physx.PxVec3*)(*((IntPtr*)(&p))));
        }

        public static physx.PxVec3* OpEqual(physx.PxVec3 lhs, physx.PxVec3* p) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_p = p;
            return PxVec3_PxVec3_operator_Ptr_Equal_PxVec3_(pvk_in_lhs, pvk_in_p);
        }

        public static float* OpSubscript(physx.PxVec3 lhs, uint index) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            uint pvk_in_index = index;
            return float_PxVec3_operator_Ptr_Subscript_uint_(pvk_in_lhs, pvk_in_index);
        }

        public static float* OpSubscriptConst(physx.PxVec3 lhs, uint index) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            uint pvk_in_index = index;
            return float_const_PxVec3_operator_Ptr_Subscript_uint_(pvk_in_lhs, pvk_in_index);
        }

        public static bool OpEquals(physx.PxVec3 lhs, physx.PxVec3 v) {
            return OpEquals(lhs, (physx.PxVec3*)&v);
        }

        public static bool OpEquals(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return OpEquals(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public static bool OpEquals(physx.PxVec3 lhs, physx.PxVec3* v) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_v = v;
            return bool_const_PxVec3_operator_Ptr_EqualEqual_PxVec3_(pvk_in_lhs, pvk_in_v);
        }

        public static bool OpExclaimEqual(physx.PxVec3 lhs, physx.PxVec3 v) {
            return OpExclaimEqual(lhs, (physx.PxVec3*)&v);
        }

        public static bool OpExclaimEqual(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return OpExclaimEqual(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public static bool OpExclaimEqual(physx.PxVec3 lhs, physx.PxVec3* v) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_v = v;
            return bool_const_PxVec3_operator_Ptr_ExclaimEqual_PxVec3_(pvk_in_lhs, pvk_in_v);
        }

        public bool isZero() {

            fixed (PxVec3* pvk_in_this = &this){
              return bool_const_PxVec3_isZeroPtr(pvk_in_this);
            }
        }

        public bool isFinite() {

            fixed (PxVec3* pvk_in_this = &this){
              return bool_const_PxVec3_isFinitePtr(pvk_in_this);
            }
        }

        public bool isNormalized() {

            fixed (PxVec3* pvk_in_this = &this){
              return bool_const_PxVec3_isNormalizedPtr(pvk_in_this);
            }
        }

        public float magnitudeSquared() {

            fixed (PxVec3* pvk_in_this = &this){
              return float_const_PxVec3_magnitudeSquaredPtr(pvk_in_this);
            }
        }

        public float magnitude() {

            fixed (PxVec3* pvk_in_this = &this){
              return float_const_PxVec3_magnitudePtr(pvk_in_this);
            }
        }

        public static physx.PxVec3 OpMinus(physx.PxVec3 lhs) {
            physx.PxVec3 RetRef;
            physx.PxVec3* pvk_in_lhs = &lhs;
            PxVec3_const_PxVec3_operator_Ptr_Minus(&RetRef, pvk_in_lhs);
            return RetRef;
        }

        public static physx.PxVec3 OpPlus(physx.PxVec3 lhs, physx.PxVec3 v) {
            return OpPlus(lhs, (physx.PxVec3*)&v);
        }

        public static physx.PxVec3 OpPlus(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return OpPlus(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec3 OpPlus(physx.PxVec3 lhs, physx.PxVec3* v) {
            physx.PxVec3 RetRef;
            physx.PxVec3* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_v = v;
            PxVec3_const_PxVec3_operator_Ptr_Plus_PxVec3_(&RetRef, pvk_in_lhs, pvk_in_v);
            return RetRef;
        }

        public static physx.PxVec3 OpMinus(physx.PxVec3 lhs, physx.PxVec3 v) {
            return OpMinus(lhs, (physx.PxVec3*)&v);
        }

        public static physx.PxVec3 OpMinus(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return OpMinus(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec3 OpMinus(physx.PxVec3 lhs, physx.PxVec3* v) {
            physx.PxVec3 RetRef;
            physx.PxVec3* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_v = v;
            PxVec3_const_PxVec3_operator_Ptr_Minus_PxVec3_(&RetRef, pvk_in_lhs, pvk_in_v);
            return RetRef;
        }

        public static physx.PxVec3 OpMultiply(physx.PxVec3 lhs, float f) {
            physx.PxVec3 RetRef;
            physx.PxVec3* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            PxVec3_const_PxVec3_operator_Ptr_Star_float_(&RetRef, pvk_in_lhs, pvk_in_f);
            return RetRef;
        }

        public static physx.PxVec3 OpSlash(physx.PxVec3 lhs, float f) {
            physx.PxVec3 RetRef;
            physx.PxVec3* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            PxVec3_const_PxVec3_operator_Ptr_Slash_float_(&RetRef, pvk_in_lhs, pvk_in_f);
            return RetRef;
        }

        public static physx.PxVec3* OpPlusEqual(physx.PxVec3 lhs, physx.PxVec3 v) {
            return OpPlusEqual(lhs, (physx.PxVec3*)&v);
        }

        public static physx.PxVec3* OpPlusEqual(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return OpPlusEqual(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec3* OpPlusEqual(physx.PxVec3 lhs, physx.PxVec3* v) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_v = v;
            return PxVec3_PxVec3_operator_Ptr_PlusEqual_PxVec3_(pvk_in_lhs, pvk_in_v);
        }

        public static physx.PxVec3* OpMinusEqual(physx.PxVec3 lhs, physx.PxVec3 v) {
            return OpMinusEqual(lhs, (physx.PxVec3*)&v);
        }

        public static physx.PxVec3* OpMinusEqual(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return OpMinusEqual(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec3* OpMinusEqual(physx.PxVec3 lhs, physx.PxVec3* v) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_v = v;
            return PxVec3_PxVec3_operator_Ptr_MinusEqual_PxVec3_(pvk_in_lhs, pvk_in_v);
        }

        public static physx.PxVec3* OpStarEqual(physx.PxVec3 lhs, float f) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            return PxVec3_PxVec3_operator_Ptr_StarEqual_float_(pvk_in_lhs, pvk_in_f);
        }

        public static physx.PxVec3* OpSlashEqual(physx.PxVec3 lhs, float f) {
            physx.PxVec3* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            return PxVec3_PxVec3_operator_Ptr_SlashEqual_float_(pvk_in_lhs, pvk_in_f);
        }

        public float dot(physx.PxVec3 v) {
            return dot((physx.PxVec3*)&v);
        }

        public float dot(physx.PxVec3.Ref v) {
            return dot((physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public float dot(physx.PxVec3* v) {

            physx.PxVec3* pvk_in_v = v;
            fixed (PxVec3* pvk_in_this = &this){
              return float_const_PxVec3_dotPtr_PxVec3_(pvk_in_this, pvk_in_v);
            }
        }

        public physx.PxVec3 cross(physx.PxVec3 v) {
            return cross((physx.PxVec3*)&v);
        }

        public physx.PxVec3 cross(physx.PxVec3.Ref v) {
            return cross((physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public physx.PxVec3 cross(physx.PxVec3* v) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_v = v;
            fixed (PxVec3* pvk_in_this = &this){
              PxVec3_const_PxVec3_crossPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_v);
            }
            return RetRef;
        }

        public physx.PxVec3 getNormalized() {
            physx.PxVec3 RetRef;

            fixed (PxVec3* pvk_in_this = &this){
              PxVec3_const_PxVec3_getNormalizedPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public float normalize() {

            fixed (PxVec3* pvk_in_this = &this){
              return float_PxVec3_normalizePtr(pvk_in_this);
            }
        }

        public float normalizeSafe() {

            fixed (PxVec3* pvk_in_this = &this){
              return float_PxVec3_normalizeSafePtr(pvk_in_this);
            }
        }

        public float normalizeFast() {

            fixed (PxVec3* pvk_in_this = &this){
              return float_PxVec3_normalizeFastPtr(pvk_in_this);
            }
        }

        public physx.PxVec3 multiply(physx.PxVec3 a) {
            return multiply((physx.PxVec3*)&a);
        }

        public physx.PxVec3 multiply(physx.PxVec3.Ref a) {
            return multiply((physx.PxVec3*)(*((IntPtr*)(&a))));
        }

        public physx.PxVec3 multiply(physx.PxVec3* a) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_a = a;
            fixed (PxVec3* pvk_in_this = &this){
              PxVec3_const_PxVec3_multiplyPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_a);
            }
            return RetRef;
        }

        public physx.PxVec3 minimum(physx.PxVec3 v) {
            return minimum((physx.PxVec3*)&v);
        }

        public physx.PxVec3 minimum(physx.PxVec3.Ref v) {
            return minimum((physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public physx.PxVec3 minimum(physx.PxVec3* v) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_v = v;
            fixed (PxVec3* pvk_in_this = &this){
              PxVec3_const_PxVec3_minimumPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_v);
            }
            return RetRef;
        }

        public float minElement() {

            fixed (PxVec3* pvk_in_this = &this){
              return float_const_PxVec3_minElementPtr(pvk_in_this);
            }
        }

        public physx.PxVec3 maximum(physx.PxVec3 v) {
            return maximum((physx.PxVec3*)&v);
        }

        public physx.PxVec3 maximum(physx.PxVec3.Ref v) {
            return maximum((physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public physx.PxVec3 maximum(physx.PxVec3* v) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_v = v;
            fixed (PxVec3* pvk_in_this = &this){
              PxVec3_const_PxVec3_maximumPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_v);
            }
            return RetRef;
        }

        public float maxElement() {

            fixed (PxVec3* pvk_in_this = &this){
              return float_const_PxVec3_maxElementPtr(pvk_in_this);
            }
        }

        public physx.PxVec3 abs() {
            physx.PxVec3 RetRef;

            fixed (PxVec3* pvk_in_this = &this){
              PxVec3_const_PxVec3_absPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxVec3 obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
        public static bool operator==(physx.PxVec3 lhs, physx.PxVec3 v) {
            return physx.PxVec3.OpEquals(lhs, (physx.PxVec3*)&v);
        }
        public static bool operator==(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return physx.PxVec3.OpEquals(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }
        public static bool operator==(physx.PxVec3 lhs, physx.PxVec3* v) {
            return physx.PxVec3.OpEquals(lhs, v);
        }
        public static bool operator!=(physx.PxVec3 lhs, physx.PxVec3 v) {
            return physx.PxVec3.OpExclaimEqual(lhs, (physx.PxVec3*)&v);
        }
        public static bool operator!=(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return physx.PxVec3.OpExclaimEqual(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }
        public static bool operator!=(physx.PxVec3 lhs, physx.PxVec3* v) {
            return physx.PxVec3.OpExclaimEqual(lhs, v);
        }
        public static physx.PxVec3 operator-(physx.PxVec3 lhs) {
            return physx.PxVec3.OpMinus(lhs);
        }
        public static physx.PxVec3 operator+(physx.PxVec3 lhs, physx.PxVec3 v) {
            return physx.PxVec3.OpPlus(lhs, (physx.PxVec3*)&v);
        }
        public static physx.PxVec3 operator+(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return physx.PxVec3.OpPlus(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }
        public static physx.PxVec3 operator+(physx.PxVec3 lhs, physx.PxVec3* v) {
            return physx.PxVec3.OpPlus(lhs, v);
        }
        public static physx.PxVec3 operator-(physx.PxVec3 lhs, physx.PxVec3 v) {
            return physx.PxVec3.OpMinus(lhs, (physx.PxVec3*)&v);
        }
        public static physx.PxVec3 operator-(physx.PxVec3 lhs, physx.PxVec3.Ref v) {
            return physx.PxVec3.OpMinus(lhs, (physx.PxVec3*)(*((IntPtr*)(&v))));
        }
        public static physx.PxVec3 operator-(physx.PxVec3 lhs, physx.PxVec3* v) {
            return physx.PxVec3.OpMinus(lhs, v);
        }
        public static physx.PxVec3 operator*(physx.PxVec3 lhs, float f) {
            return physx.PxVec3.OpMultiply(lhs, f);
        }
        public static physx.PxVec3 operator/(physx.PxVec3 lhs, float f) {
            return physx.PxVec3.OpSlash(lhs, f);
        }
        public static physx.PxVec3 operator*(float f, physx.PxVec3 v) {
            return physx.OpMultiply(f, (physx.PxVec3*)&v);
        }
    }
}
