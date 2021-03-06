// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxVec2 OpMultiply(float f, physx.PxVec2 v) {
        return OpMultiply(f, (physx.PxVec2*)&v);
    }

    public static physx.PxVec2 OpMultiply(float f, physx.PxVec2.Ref v) {
        return OpMultiply(f, (physx.PxVec2*)(*((IntPtr*)(&v))));
    }

    public static physx.PxVec2 OpMultiply(float f, physx.PxVec2* v) {
        physx.PxVec2 RetRef;
        float pvk_in_f = f;
        physx.PxVec2* pvk_in_v = v;
        PxVec2_operator_Ptr_Star_float_PxVec2_(&RetRef, pvk_in_f, pvk_in_v);
        return RetRef;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public unsafe partial struct PxVec2 {
        [FieldOffset(0)] public float x;
        [FieldOffset(4)] public float y;

        public static PxVec2 Default() {

            PxVec2 toInit;
            var pvk_in_this = &toInit;
            void_PxVec2_PxVec2Ptr_Ctor(pvk_in_this);
            return toInit;
        }

        public PxVec2(physx.PxZERO r) {

            physx.PxZERO pvk_in_r = r;
            PxVec2 toInit;
            var pvk_in_this = &toInit;
            void_PxVec2_PxVec2Ptr_Ctor_PxZERO_(pvk_in_this, pvk_in_r);
            this = toInit;
        }

        public PxVec2(float a) {

            float pvk_in_a = a;
            PxVec2 toInit;
            var pvk_in_this = &toInit;
            void_PxVec2_PxVec2Ptr_Ctor_float_(pvk_in_this, pvk_in_a);
            this = toInit;
        }

        public PxVec2(float nx, float ny) {

            float pvk_in_nx = nx;
            float pvk_in_ny = ny;
            PxVec2 toInit;
            var pvk_in_this = &toInit;
            void_PxVec2_PxVec2Ptr_Ctor_float_float_(pvk_in_this, pvk_in_nx, pvk_in_ny);
            this = toInit;
        }

        public PxVec2(physx.PxVec2 v) : this((physx.PxVec2*)&v) {
            //ctor piping;
        }

        public PxVec2(physx.PxVec2.Ref v) : this((physx.PxVec2*)(*((IntPtr*)(&v)))) {
            //ctor piping;
        }

        public PxVec2(physx.PxVec2* v) {

            physx.PxVec2* pvk_in_v = v;
            PxVec2 toInit;
            var pvk_in_this = &toInit;
            void_PxVec2_PxVec2Ptr_Ctor_PxVec2_(pvk_in_this, pvk_in_v);
            this = toInit;
        }

        public static physx.PxVec2* OpEqual(physx.PxVec2 lhs, physx.PxVec2 p) {
            return OpEqual(lhs, (physx.PxVec2*)&p);
        }

        public static physx.PxVec2* OpEqual(physx.PxVec2 lhs, physx.PxVec2.Ref p) {
            return OpEqual(lhs, (physx.PxVec2*)(*((IntPtr*)(&p))));
        }

        public static physx.PxVec2* OpEqual(physx.PxVec2 lhs, physx.PxVec2* p) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            physx.PxVec2* pvk_in_p = p;
            return PxVec2_PxVec2_operator_Ptr_Equal_PxVec2_(pvk_in_lhs, pvk_in_p);
        }

        public static float* OpSubscript(physx.PxVec2 lhs, int index) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            int pvk_in_index = index;
            return float_PxVec2_operator_Ptr_Subscript_int_(pvk_in_lhs, pvk_in_index);
        }

        public static float* OpSubscriptConst(physx.PxVec2 lhs, int index) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            int pvk_in_index = index;
            return float_const_PxVec2_operator_Ptr_Subscript_int_(pvk_in_lhs, pvk_in_index);
        }

        public static bool OpEquals(physx.PxVec2 lhs, physx.PxVec2 v) {
            return OpEquals(lhs, (physx.PxVec2*)&v);
        }

        public static bool OpEquals(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return OpEquals(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public static bool OpEquals(physx.PxVec2 lhs, physx.PxVec2* v) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            physx.PxVec2* pvk_in_v = v;
            return bool_const_PxVec2_operator_Ptr_EqualEqual_PxVec2_(pvk_in_lhs, pvk_in_v);
        }

        public static bool OpExclaimEqual(physx.PxVec2 lhs, physx.PxVec2 v) {
            return OpExclaimEqual(lhs, (physx.PxVec2*)&v);
        }

        public static bool OpExclaimEqual(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return OpExclaimEqual(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public static bool OpExclaimEqual(physx.PxVec2 lhs, physx.PxVec2* v) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            physx.PxVec2* pvk_in_v = v;
            return bool_const_PxVec2_operator_Ptr_ExclaimEqual_PxVec2_(pvk_in_lhs, pvk_in_v);
        }

        public bool isZero() {

            fixed (PxVec2* pvk_in_this = &this){
              return bool_const_PxVec2_isZeroPtr(pvk_in_this);
            }
        }

        public bool isFinite() {

            fixed (PxVec2* pvk_in_this = &this){
              return bool_const_PxVec2_isFinitePtr(pvk_in_this);
            }
        }

        public bool isNormalized() {

            fixed (PxVec2* pvk_in_this = &this){
              return bool_const_PxVec2_isNormalizedPtr(pvk_in_this);
            }
        }

        public float magnitudeSquared() {

            fixed (PxVec2* pvk_in_this = &this){
              return float_const_PxVec2_magnitudeSquaredPtr(pvk_in_this);
            }
        }

        public float magnitude() {

            fixed (PxVec2* pvk_in_this = &this){
              return float_const_PxVec2_magnitudePtr(pvk_in_this);
            }
        }

        public static physx.PxVec2 OpMinus(physx.PxVec2 lhs) {
            physx.PxVec2 RetRef;
            physx.PxVec2* pvk_in_lhs = &lhs;
            PxVec2_const_PxVec2_operator_Ptr_Minus(&RetRef, pvk_in_lhs);
            return RetRef;
        }

        public static physx.PxVec2 OpPlus(physx.PxVec2 lhs, physx.PxVec2 v) {
            return OpPlus(lhs, (physx.PxVec2*)&v);
        }

        public static physx.PxVec2 OpPlus(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return OpPlus(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec2 OpPlus(physx.PxVec2 lhs, physx.PxVec2* v) {
            physx.PxVec2 RetRef;
            physx.PxVec2* pvk_in_lhs = &lhs;
            physx.PxVec2* pvk_in_v = v;
            PxVec2_const_PxVec2_operator_Ptr_Plus_PxVec2_(&RetRef, pvk_in_lhs, pvk_in_v);
            return RetRef;
        }

        public static physx.PxVec2 OpMinus(physx.PxVec2 lhs, physx.PxVec2 v) {
            return OpMinus(lhs, (physx.PxVec2*)&v);
        }

        public static physx.PxVec2 OpMinus(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return OpMinus(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec2 OpMinus(physx.PxVec2 lhs, physx.PxVec2* v) {
            physx.PxVec2 RetRef;
            physx.PxVec2* pvk_in_lhs = &lhs;
            physx.PxVec2* pvk_in_v = v;
            PxVec2_const_PxVec2_operator_Ptr_Minus_PxVec2_(&RetRef, pvk_in_lhs, pvk_in_v);
            return RetRef;
        }

        public static physx.PxVec2 OpMultiply(physx.PxVec2 lhs, float f) {
            physx.PxVec2 RetRef;
            physx.PxVec2* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            PxVec2_const_PxVec2_operator_Ptr_Star_float_(&RetRef, pvk_in_lhs, pvk_in_f);
            return RetRef;
        }

        public static physx.PxVec2 OpSlash(physx.PxVec2 lhs, float f) {
            physx.PxVec2 RetRef;
            physx.PxVec2* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            PxVec2_const_PxVec2_operator_Ptr_Slash_float_(&RetRef, pvk_in_lhs, pvk_in_f);
            return RetRef;
        }

        public static physx.PxVec2* OpPlusEqual(physx.PxVec2 lhs, physx.PxVec2 v) {
            return OpPlusEqual(lhs, (physx.PxVec2*)&v);
        }

        public static physx.PxVec2* OpPlusEqual(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return OpPlusEqual(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec2* OpPlusEqual(physx.PxVec2 lhs, physx.PxVec2* v) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            physx.PxVec2* pvk_in_v = v;
            return PxVec2_PxVec2_operator_Ptr_PlusEqual_PxVec2_(pvk_in_lhs, pvk_in_v);
        }

        public static physx.PxVec2* OpMinusEqual(physx.PxVec2 lhs, physx.PxVec2 v) {
            return OpMinusEqual(lhs, (physx.PxVec2*)&v);
        }

        public static physx.PxVec2* OpMinusEqual(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return OpMinusEqual(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public static physx.PxVec2* OpMinusEqual(physx.PxVec2 lhs, physx.PxVec2* v) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            physx.PxVec2* pvk_in_v = v;
            return PxVec2_PxVec2_operator_Ptr_MinusEqual_PxVec2_(pvk_in_lhs, pvk_in_v);
        }

        public static physx.PxVec2* OpStarEqual(physx.PxVec2 lhs, float f) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            return PxVec2_PxVec2_operator_Ptr_StarEqual_float_(pvk_in_lhs, pvk_in_f);
        }

        public static physx.PxVec2* OpSlashEqual(physx.PxVec2 lhs, float f) {
            physx.PxVec2* pvk_in_lhs = &lhs;
            float pvk_in_f = f;
            return PxVec2_PxVec2_operator_Ptr_SlashEqual_float_(pvk_in_lhs, pvk_in_f);
        }

        public float dot(physx.PxVec2 v) {
            return dot((physx.PxVec2*)&v);
        }

        public float dot(physx.PxVec2.Ref v) {
            return dot((physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public float dot(physx.PxVec2* v) {

            physx.PxVec2* pvk_in_v = v;
            fixed (PxVec2* pvk_in_this = &this){
              return float_const_PxVec2_dotPtr_PxVec2_(pvk_in_this, pvk_in_v);
            }
        }

        public physx.PxVec2 getNormalized() {
            physx.PxVec2 RetRef;

            fixed (PxVec2* pvk_in_this = &this){
              PxVec2_const_PxVec2_getNormalizedPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public float normalize() {

            fixed (PxVec2* pvk_in_this = &this){
              return float_PxVec2_normalizePtr(pvk_in_this);
            }
        }

        public physx.PxVec2 multiply(physx.PxVec2 a) {
            return multiply((physx.PxVec2*)&a);
        }

        public physx.PxVec2 multiply(physx.PxVec2.Ref a) {
            return multiply((physx.PxVec2*)(*((IntPtr*)(&a))));
        }

        public physx.PxVec2 multiply(physx.PxVec2* a) {
            physx.PxVec2 RetRef;

            physx.PxVec2* pvk_in_a = a;
            fixed (PxVec2* pvk_in_this = &this){
              PxVec2_const_PxVec2_multiplyPtr_PxVec2_(&RetRef, pvk_in_this, pvk_in_a);
            }
            return RetRef;
        }

        public physx.PxVec2 minimum(physx.PxVec2 v) {
            return minimum((physx.PxVec2*)&v);
        }

        public physx.PxVec2 minimum(physx.PxVec2.Ref v) {
            return minimum((physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public physx.PxVec2 minimum(physx.PxVec2* v) {
            physx.PxVec2 RetRef;

            physx.PxVec2* pvk_in_v = v;
            fixed (PxVec2* pvk_in_this = &this){
              PxVec2_const_PxVec2_minimumPtr_PxVec2_(&RetRef, pvk_in_this, pvk_in_v);
            }
            return RetRef;
        }

        public float minElement() {

            fixed (PxVec2* pvk_in_this = &this){
              return float_const_PxVec2_minElementPtr(pvk_in_this);
            }
        }

        public physx.PxVec2 maximum(physx.PxVec2 v) {
            return maximum((physx.PxVec2*)&v);
        }

        public physx.PxVec2 maximum(physx.PxVec2.Ref v) {
            return maximum((physx.PxVec2*)(*((IntPtr*)(&v))));
        }

        public physx.PxVec2 maximum(physx.PxVec2* v) {
            physx.PxVec2 RetRef;

            physx.PxVec2* pvk_in_v = v;
            fixed (PxVec2* pvk_in_this = &this){
              PxVec2_const_PxVec2_maximumPtr_PxVec2_(&RetRef, pvk_in_this, pvk_in_v);
            }
            return RetRef;
        }

        public float maxElement() {

            fixed (PxVec2* pvk_in_this = &this){
              return float_const_PxVec2_maxElementPtr(pvk_in_this);
            }
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxVec2 obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
        public static bool operator==(physx.PxVec2 lhs, physx.PxVec2 v) {
            return physx.PxVec2.OpEquals(lhs, (physx.PxVec2*)&v);
        }
        public static bool operator==(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return physx.PxVec2.OpEquals(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }
        public static bool operator==(physx.PxVec2 lhs, physx.PxVec2* v) {
            return physx.PxVec2.OpEquals(lhs, v);
        }
        public static bool operator!=(physx.PxVec2 lhs, physx.PxVec2 v) {
            return physx.PxVec2.OpExclaimEqual(lhs, (physx.PxVec2*)&v);
        }
        public static bool operator!=(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return physx.PxVec2.OpExclaimEqual(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }
        public static bool operator!=(physx.PxVec2 lhs, physx.PxVec2* v) {
            return physx.PxVec2.OpExclaimEqual(lhs, v);
        }
        public static physx.PxVec2 operator-(physx.PxVec2 lhs) {
            return physx.PxVec2.OpMinus(lhs);
        }
        public static physx.PxVec2 operator+(physx.PxVec2 lhs, physx.PxVec2 v) {
            return physx.PxVec2.OpPlus(lhs, (physx.PxVec2*)&v);
        }
        public static physx.PxVec2 operator+(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return physx.PxVec2.OpPlus(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }
        public static physx.PxVec2 operator+(physx.PxVec2 lhs, physx.PxVec2* v) {
            return physx.PxVec2.OpPlus(lhs, v);
        }
        public static physx.PxVec2 operator-(physx.PxVec2 lhs, physx.PxVec2 v) {
            return physx.PxVec2.OpMinus(lhs, (physx.PxVec2*)&v);
        }
        public static physx.PxVec2 operator-(physx.PxVec2 lhs, physx.PxVec2.Ref v) {
            return physx.PxVec2.OpMinus(lhs, (physx.PxVec2*)(*((IntPtr*)(&v))));
        }
        public static physx.PxVec2 operator-(physx.PxVec2 lhs, physx.PxVec2* v) {
            return physx.PxVec2.OpMinus(lhs, v);
        }
        public static physx.PxVec2 operator*(physx.PxVec2 lhs, float f) {
            return physx.PxVec2.OpMultiply(lhs, f);
        }
        public static physx.PxVec2 operator/(physx.PxVec2 lhs, float f) {
            return physx.PxVec2.OpSlash(lhs, f);
        }
        public static physx.PxVec2 operator*(float f, physx.PxVec2 v) {
            return physx.OpMultiply(f, (physx.PxVec2*)&v);
        }
    }
}
