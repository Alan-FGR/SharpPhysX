// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    [StructLayout(LayoutKind.Sequential, Size = 36)]
    public unsafe partial struct PxMat33 {
        public physx.PxVec3 column0;
        public physx.PxVec3 column1;
        public physx.PxVec3 column2;

        public static physx.PxMat33 Default() {
            physx.PxMat33 RetRef;
            Default_PxMat33_(&RetRef);
            return RetRef;
        }

        public PxMat33(physx.PxIDENTITY r) {

            physx.PxIDENTITY pvk_in_r = r;
            PxMat33 toInit;
            var pvk_in_this = &toInit;
            void_PxMat33_PxMat33Ptr_Ctor_PxIDENTITY_(pvk_in_this, pvk_in_r);
            this = toInit;
        }

        public PxMat33(physx.PxZERO r) {

            physx.PxZERO pvk_in_r = r;
            PxMat33 toInit;
            var pvk_in_this = &toInit;
            void_PxMat33_PxMat33Ptr_Ctor_PxZERO_(pvk_in_this, pvk_in_r);
            this = toInit;
        }

        public PxMat33(physx.PxVec3 col0, physx.PxVec3 col1, physx.PxVec3 col2) : this((physx.PxVec3*)&col0, (physx.PxVec3*)&col1, (physx.PxVec3*)&col2) {
            //ctor piping;
        }

        public PxMat33(physx.PxVec3.Ref col0, physx.PxVec3.Ref col1, physx.PxVec3.Ref col2) : this((physx.PxVec3*)(*((IntPtr*)(&col0))), (physx.PxVec3*)(*((IntPtr*)(&col1))), (physx.PxVec3*)(*((IntPtr*)(&col2)))) {
            //ctor piping;
        }

        public PxMat33(physx.PxVec3* col0, physx.PxVec3* col1, physx.PxVec3* col2) {

            physx.PxVec3* pvk_in_col0 = col0;
            physx.PxVec3* pvk_in_col1 = col1;
            physx.PxVec3* pvk_in_col2 = col2;
            PxMat33 toInit;
            var pvk_in_this = &toInit;
            void_PxMat33_PxMat33Ptr_Ctor_PxVec3_PxVec3_PxVec3_(pvk_in_this, pvk_in_col0, pvk_in_col1, pvk_in_col2);
            this = toInit;
        }

        public PxMat33(float r) {

            float pvk_in_r = r;
            PxMat33 toInit;
            var pvk_in_this = &toInit;
            void_PxMat33_PxMat33Ptr_Ctor_float_(pvk_in_this, pvk_in_r);
            this = toInit;
        }

        public PxMat33(physx.PxQuat q) : this((physx.PxQuat*)&q) {
            //ctor piping;
        }

        public PxMat33(physx.PxQuat.Ref q) : this((physx.PxQuat*)(*((IntPtr*)(&q)))) {
            //ctor piping;
        }

        public PxMat33(physx.PxQuat* q) {

            physx.PxQuat* pvk_in_q = q;
            PxMat33 toInit;
            var pvk_in_this = &toInit;
            void_PxMat33_PxMat33Ptr_Ctor_PxQuat_(pvk_in_this, pvk_in_q);
            this = toInit;
        }

        public PxMat33(physx.PxMat33 other) : this((physx.PxMat33*)&other) {
            //ctor piping;
        }

        public PxMat33(physx.PxMat33.Ref other) : this((physx.PxMat33*)(*((IntPtr*)(&other)))) {
            //ctor piping;
        }

        public PxMat33(physx.PxMat33* other) {

            physx.PxMat33* pvk_in_other = other;
            PxMat33 toInit;
            var pvk_in_this = &toInit;
            void_PxMat33_PxMat33Ptr_Ctor_PxMat33_(pvk_in_this, pvk_in_other);
            this = toInit;
        }

        public static physx.PxMat33* OpEqual(physx.PxMat33 lhs, physx.PxMat33 other) {
            return OpEqual(lhs, (physx.PxMat33*)&other);
        }

        public static physx.PxMat33* OpEqual(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return OpEqual(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }

        public static physx.PxMat33* OpEqual(physx.PxMat33 lhs, physx.PxMat33* other) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_other = other;
            return PxMat33_PxMat33_operator_Ptr_Equal_PxMat33_(pvk_in_lhs, pvk_in_other);
        }

        public physx.PxMat33 createDiagonal(physx.PxVec3 d) {
            return createDiagonal((physx.PxVec3*)&d);
        }

        public physx.PxMat33 createDiagonal(physx.PxVec3.Ref d) {
            return createDiagonal((physx.PxVec3*)(*((IntPtr*)(&d))));
        }

        public physx.PxMat33 createDiagonal(physx.PxVec3* d) {
            physx.PxMat33 RetRef;

            physx.PxVec3* pvk_in_d = d;
            fixed (PxMat33* pvk_in_this = &this){
              PxMat33_PxMat33_createDiagonalPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_d);
            }
            return RetRef;
        }

        public static bool OpEquals(physx.PxMat33 lhs, physx.PxMat33 m) {
            return OpEquals(lhs, (physx.PxMat33*)&m);
        }

        public static bool OpEquals(physx.PxMat33 lhs, physx.PxMat33.Ref m) {
            return OpEquals(lhs, (physx.PxMat33*)(*((IntPtr*)(&m))));
        }

        public static bool OpEquals(physx.PxMat33 lhs, physx.PxMat33* m) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_m = m;
            return bool_const_PxMat33_operator_Ptr_EqualEqual_PxMat33_(pvk_in_lhs, pvk_in_m);
        }

        public physx.PxMat33 getTranspose() {
            physx.PxMat33 RetRef;

            fixed (PxMat33* pvk_in_this = &this){
              PxMat33_const_PxMat33_getTransposePtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public physx.PxMat33 getInverse() {
            physx.PxMat33 RetRef;

            fixed (PxMat33* pvk_in_this = &this){
              PxMat33_const_PxMat33_getInversePtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public float getDeterminant() {

            fixed (PxMat33* pvk_in_this = &this){
              return float_const_PxMat33_getDeterminantPtr(pvk_in_this);
            }
        }

        public static physx.PxMat33 OpMinus(physx.PxMat33 lhs) {
            physx.PxMat33 RetRef;
            physx.PxMat33* pvk_in_lhs = &lhs;
            PxMat33_const_PxMat33_operator_Ptr_Minus(&RetRef, pvk_in_lhs);
            return RetRef;
        }

        public static physx.PxMat33 OpPlus(physx.PxMat33 lhs, physx.PxMat33 other) {
            return OpPlus(lhs, (physx.PxMat33*)&other);
        }

        public static physx.PxMat33 OpPlus(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return OpPlus(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }

        public static physx.PxMat33 OpPlus(physx.PxMat33 lhs, physx.PxMat33* other) {
            physx.PxMat33 RetRef;
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_other = other;
            PxMat33_const_PxMat33_operator_Ptr_Plus_PxMat33_(&RetRef, pvk_in_lhs, pvk_in_other);
            return RetRef;
        }

        public static physx.PxMat33 OpMinus(physx.PxMat33 lhs, physx.PxMat33 other) {
            return OpMinus(lhs, (physx.PxMat33*)&other);
        }

        public static physx.PxMat33 OpMinus(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return OpMinus(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }

        public static physx.PxMat33 OpMinus(physx.PxMat33 lhs, physx.PxMat33* other) {
            physx.PxMat33 RetRef;
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_other = other;
            PxMat33_const_PxMat33_operator_Ptr_Minus_PxMat33_(&RetRef, pvk_in_lhs, pvk_in_other);
            return RetRef;
        }

        public static physx.PxMat33 OpMultiply(physx.PxMat33 lhs, float scalar) {
            physx.PxMat33 RetRef;
            physx.PxMat33* pvk_in_lhs = &lhs;
            float pvk_in_scalar = scalar;
            PxMat33_const_PxMat33_operator_Ptr_Star_float_(&RetRef, pvk_in_lhs, pvk_in_scalar);
            return RetRef;
        }

        public static physx.PxVec3 OpMultiply(physx.PxMat33 lhs, physx.PxVec3 vec) {
            return OpMultiply(lhs, (physx.PxVec3*)&vec);
        }

        public static physx.PxVec3 OpMultiply(physx.PxMat33 lhs, physx.PxVec3.Ref vec) {
            return OpMultiply(lhs, (physx.PxVec3*)(*((IntPtr*)(&vec))));
        }

        public static physx.PxVec3 OpMultiply(physx.PxMat33 lhs, physx.PxVec3* vec) {
            physx.PxVec3 RetRef;
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxVec3* pvk_in_vec = vec;
            PxVec3_const_PxMat33_operator_Ptr_Star_PxVec3_(&RetRef, pvk_in_lhs, pvk_in_vec);
            return RetRef;
        }

        public static physx.PxMat33 OpMultiply(physx.PxMat33 lhs, physx.PxMat33 other) {
            return OpMultiply(lhs, (physx.PxMat33*)&other);
        }

        public static physx.PxMat33 OpMultiply(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return OpMultiply(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }

        public static physx.PxMat33 OpMultiply(physx.PxMat33 lhs, physx.PxMat33* other) {
            physx.PxMat33 RetRef;
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_other = other;
            PxMat33_const_PxMat33_operator_Ptr_Star_PxMat33_(&RetRef, pvk_in_lhs, pvk_in_other);
            return RetRef;
        }

        public static physx.PxMat33* OpPlusEqual(physx.PxMat33 lhs, physx.PxMat33 other) {
            return OpPlusEqual(lhs, (physx.PxMat33*)&other);
        }

        public static physx.PxMat33* OpPlusEqual(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return OpPlusEqual(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }

        public static physx.PxMat33* OpPlusEqual(physx.PxMat33 lhs, physx.PxMat33* other) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_other = other;
            return PxMat33_PxMat33_operator_Ptr_PlusEqual_PxMat33_(pvk_in_lhs, pvk_in_other);
        }

        public static physx.PxMat33* OpMinusEqual(physx.PxMat33 lhs, physx.PxMat33 other) {
            return OpMinusEqual(lhs, (physx.PxMat33*)&other);
        }

        public static physx.PxMat33* OpMinusEqual(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return OpMinusEqual(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }

        public static physx.PxMat33* OpMinusEqual(physx.PxMat33 lhs, physx.PxMat33* other) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_other = other;
            return PxMat33_PxMat33_operator_Ptr_MinusEqual_PxMat33_(pvk_in_lhs, pvk_in_other);
        }

        public static physx.PxMat33* OpStarEqual(physx.PxMat33 lhs, float scalar) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            float pvk_in_scalar = scalar;
            return PxMat33_PxMat33_operator_Ptr_StarEqual_float_(pvk_in_lhs, pvk_in_scalar);
        }

        public static physx.PxMat33* OpStarEqual(physx.PxMat33 lhs, physx.PxMat33 other) {
            return OpStarEqual(lhs, (physx.PxMat33*)&other);
        }

        public static physx.PxMat33* OpStarEqual(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return OpStarEqual(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }

        public static physx.PxMat33* OpStarEqual(physx.PxMat33 lhs, physx.PxMat33* other) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            physx.PxMat33* pvk_in_other = other;
            return PxMat33_PxMat33_operator_Ptr_StarEqual_PxMat33_(pvk_in_lhs, pvk_in_other);
        }

        public static float OpCallConst(physx.PxMat33 lhs, uint row, uint col) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            uint pvk_in_row = row;
            uint pvk_in_col = col;
            return float_const_PxMat33_operator_Ptr_Call_uint_uint_(pvk_in_lhs, pvk_in_row, pvk_in_col);
        }

        public static float* OpCall(physx.PxMat33 lhs, uint row, uint col) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            uint pvk_in_row = row;
            uint pvk_in_col = col;
            return float_PxMat33_operator_Ptr_Call_uint_uint_(pvk_in_lhs, pvk_in_row, pvk_in_col);
        }

        public physx.PxVec3 transform(physx.PxVec3 other) {
            return transform((physx.PxVec3*)&other);
        }

        public physx.PxVec3 transform(physx.PxVec3.Ref other) {
            return transform((physx.PxVec3*)(*((IntPtr*)(&other))));
        }

        public physx.PxVec3 transform(physx.PxVec3* other) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_other = other;
            fixed (PxMat33* pvk_in_this = &this){
              PxVec3_const_PxMat33_transformPtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_other);
            }
            return RetRef;
        }

        public physx.PxVec3 transformTranspose(physx.PxVec3 other) {
            return transformTranspose((physx.PxVec3*)&other);
        }

        public physx.PxVec3 transformTranspose(physx.PxVec3.Ref other) {
            return transformTranspose((physx.PxVec3*)(*((IntPtr*)(&other))));
        }

        public physx.PxVec3 transformTranspose(physx.PxVec3* other) {
            physx.PxVec3 RetRef;

            physx.PxVec3* pvk_in_other = other;
            fixed (PxMat33* pvk_in_this = &this){
              PxVec3_const_PxMat33_transformTransposePtr_PxVec3_(&RetRef, pvk_in_this, pvk_in_other);
            }
            return RetRef;
        }

        public float* front() {

            fixed (PxMat33* pvk_in_this = &this){
              return float_const_PxMat33_frontPtr(pvk_in_this);
            }
        }

        public static physx.PxVec3* OpSubscript(physx.PxMat33 lhs, uint num) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            uint pvk_in_num = num;
            return PxVec3_PxMat33_operator_Ptr_Subscript_uint_(pvk_in_lhs, pvk_in_num);
        }

        public static physx.PxVec3* OpSubscriptConst(physx.PxMat33 lhs, uint num) {
            physx.PxMat33* pvk_in_lhs = &lhs;
            uint pvk_in_num = num;
            return PxVec3_const_PxMat33_operator_Ptr_Subscript_uint_(pvk_in_lhs, pvk_in_num);
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxMat33 obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
        public static bool operator==(physx.PxMat33 lhs, physx.PxMat33 m) {
            return physx.PxMat33.OpEquals(lhs, (physx.PxMat33*)&m);
        }
        public static bool operator!=(physx.PxMat33 lhs, physx.PxMat33 m) {
            return !(physx.PxMat33.OpEquals(lhs, (physx.PxMat33*)&m)); // Matching Operator
        }
        public static bool operator==(physx.PxMat33 lhs, physx.PxMat33.Ref m) {
            return physx.PxMat33.OpEquals(lhs, (physx.PxMat33*)(*((IntPtr*)(&m))));
        }
        public static bool operator!=(physx.PxMat33 lhs, physx.PxMat33.Ref m) {
            return !(physx.PxMat33.OpEquals(lhs, (physx.PxMat33*)(*((IntPtr*)(&m))))); // Matching Operator
        }
        public static bool operator==(physx.PxMat33 lhs, physx.PxMat33* m) {
            return physx.PxMat33.OpEquals(lhs, m);
        }
        public static bool operator!=(physx.PxMat33 lhs, physx.PxMat33* m) {
            return !(physx.PxMat33.OpEquals(lhs, m)); // Matching Operator
        }
        public static physx.PxMat33 operator-(physx.PxMat33 lhs) {
            return physx.PxMat33.OpMinus(lhs);
        }
        public static physx.PxMat33 operator+(physx.PxMat33 lhs, physx.PxMat33 other) {
            return physx.PxMat33.OpPlus(lhs, (physx.PxMat33*)&other);
        }
        public static physx.PxMat33 operator+(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return physx.PxMat33.OpPlus(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }
        public static physx.PxMat33 operator+(physx.PxMat33 lhs, physx.PxMat33* other) {
            return physx.PxMat33.OpPlus(lhs, other);
        }
        public static physx.PxMat33 operator-(physx.PxMat33 lhs, physx.PxMat33 other) {
            return physx.PxMat33.OpMinus(lhs, (physx.PxMat33*)&other);
        }
        public static physx.PxMat33 operator-(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return physx.PxMat33.OpMinus(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }
        public static physx.PxMat33 operator-(physx.PxMat33 lhs, physx.PxMat33* other) {
            return physx.PxMat33.OpMinus(lhs, other);
        }
        public static physx.PxMat33 operator*(physx.PxMat33 lhs, float scalar) {
            return physx.PxMat33.OpMultiply(lhs, scalar);
        }
        public static physx.PxVec3 operator*(physx.PxMat33 lhs, physx.PxVec3 vec) {
            return physx.PxMat33.OpMultiply(lhs, (physx.PxVec3*)&vec);
        }
        public static physx.PxVec3 operator*(physx.PxMat33 lhs, physx.PxVec3.Ref vec) {
            return physx.PxMat33.OpMultiply(lhs, (physx.PxVec3*)(*((IntPtr*)(&vec))));
        }
        public static physx.PxVec3 operator*(physx.PxMat33 lhs, physx.PxVec3* vec) {
            return physx.PxMat33.OpMultiply(lhs, vec);
        }
        public static physx.PxMat33 operator*(physx.PxMat33 lhs, physx.PxMat33 other) {
            return physx.PxMat33.OpMultiply(lhs, (physx.PxMat33*)&other);
        }
        public static physx.PxMat33 operator*(physx.PxMat33 lhs, physx.PxMat33.Ref other) {
            return physx.PxMat33.OpMultiply(lhs, (physx.PxMat33*)(*((IntPtr*)(&other))));
        }
        public static physx.PxMat33 operator*(physx.PxMat33 lhs, physx.PxMat33* other) {
            return physx.PxMat33.OpMultiply(lhs, other);
        }
    }
}
