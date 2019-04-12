// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxQuat
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    public unsafe partial struct PxQuatPtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxQuatPtr(PxQuatPtr ptr);
        
        public static void Free(PxQuatPtr ptr){
            Freer_physx_PxQuatPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxQuatPtr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr Ctor_physx_PxQuatPtr_();
        
        public static physx.PxQuatPtr New() {
            return Ctor_physx_PxQuatPtr_();
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr Ctor_physx_PxQuatPtr_physx_PxIDENTITY(physx.PxIDENTITY pvk_r);
        
        public static physx.PxQuatPtr New(physx.PxIDENTITY r) {
            physx.PxIDENTITY pvk_in_r = r;
            return Ctor_physx_PxQuatPtr_physx_PxIDENTITY(pvk_in_r);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr Ctor_physx_PxQuatPtr_float(float pvk_r);
        
        public static physx.PxQuatPtr New(float r) {
            float pvk_in_r = r;
            return Ctor_physx_PxQuatPtr_float(pvk_in_r);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr Ctor_physx_PxQuatPtr_float_float_float_float(float pvk_nx, float pvk_ny, float pvk_nz, float pvk_nw);
        
        public static physx.PxQuatPtr New(float nx, float ny, float nz, float nw) {
            float pvk_in_nx = nx;
            float pvk_in_ny = ny;
            float pvk_in_nz = nz;
            float pvk_in_nw = nw;
            return Ctor_physx_PxQuatPtr_float_float_float_float(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_nw);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr Ctor_physx_PxQuatPtr_float_physx_PxVec3Ptr(float pvk_angleRadians, physx.PxVec3Ptr pvk_unitAxis);
        
        public static physx.PxQuatPtr New(float angleRadians, physx.PxVec3Ptr unitAxis) {
            float pvk_in_angleRadians = angleRadians;
            physx.PxVec3Ptr pvk_in_unitAxis = unitAxis;
            return Ctor_physx_PxQuatPtr_float_physx_PxVec3Ptr(pvk_in_angleRadians, pvk_in_unitAxis);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr Ctor_physx_PxQuatPtr_physx_PxQuatPtr(physx.PxQuatPtr pvk_v);
        
        public static physx.PxQuatPtr New(physx.PxQuatPtr v) {
            physx.PxQuatPtr pvk_in_v = v;
            return Ctor_physx_PxQuatPtr_physx_PxQuatPtr(pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr Ctor_physx_PxQuatPtr_physx_PxMat33Ptr(physx.PxMat33Ptr pvk_m);
        
        public static physx.PxQuatPtr New(physx.PxMat33Ptr m) {
            physx.PxMat33Ptr pvk_in_m = m;
            return Ctor_physx_PxQuatPtr_physx_PxMat33Ptr(pvk_in_m);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxQuat_GET_x(PxQuatPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxQuat_SET_x(PxQuatPtr cls, float value);
        
        public float x {
            get => PxQuat_GET_x(this);
            set => PxQuat_SET_x(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxQuat_GET_y(PxQuatPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxQuat_SET_y(PxQuatPtr cls, float value);
        
        public float y {
            get => PxQuat_GET_y(this);
            set => PxQuat_SET_y(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxQuat_GET_z(PxQuatPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxQuat_SET_z(PxQuatPtr cls, float value);
        
        public float z {
            get => PxQuat_GET_z(this);
            set => PxQuat_SET_z(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxQuat_GET_w(PxQuatPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxQuat_SET_w(PxQuatPtr cls, float value);
        
        public float w {
            get => PxQuat_GET_w(this);
            set => PxQuat_SET_w(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxQuat_isIdentity(physx.PxQuatPtr pvk_this);
        
        public bool isIdentity() {
            physx.PxQuatPtr pvk_in_this = this;
            return bool_const_physx_PxQuat_isIdentity(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxQuat_isFinite(physx.PxQuatPtr pvk_this);
        
        public bool isFinite() {
            physx.PxQuatPtr pvk_in_this = this;
            return bool_const_physx_PxQuat_isFinite(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxQuat_isUnit(physx.PxQuatPtr pvk_this);
        
        public bool isUnit() {
            physx.PxQuatPtr pvk_in_this = this;
            return bool_const_physx_PxQuat_isUnit(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxQuat_isSane(physx.PxQuatPtr pvk_this);
        
        public bool isSane() {
            physx.PxQuatPtr pvk_in_this = this;
            return bool_const_physx_PxQuat_isSane(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxQuat_operator_EqualEqual_physx_PxQuatPtr_(physx.PxQuatPtr pvk_lhs, physx.PxQuatPtr pvk_q);
        
        public static bool operator==(physx.PxQuatPtr lhs, physx.PxQuatPtr q) {
            physx.PxQuatPtr pvk_in_lhs = lhs;
            physx.PxQuatPtr pvk_in_q = q;
            return bool_const_physx_PxQuat_operator_EqualEqual_physx_PxQuatPtr_(pvk_in_lhs, pvk_in_q);
        }
        public static bool operator!=(physx.PxQuatPtr lhs, physx.PxQuatPtr q){return !(lhs==q);} // Generated Matching Operator
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_const_physx_PxQuat_toRadiansAndUnitAxis_float_physx_PxVec3Ptr_(physx.PxQuatPtr pvk_this, float* pvk_angle, physx.PxVec3Ptr pvk_axis);
        
        public void toRadiansAndUnitAxis(float* angle, physx.PxVec3Ptr axis) {
            physx.PxQuatPtr pvk_in_this = this;
            float* pvk_in_angle = angle;
            physx.PxVec3Ptr pvk_in_axis = axis;
            void_const_physx_PxQuat_toRadiansAndUnitAxis_float_physx_PxVec3Ptr_(pvk_in_this, pvk_in_angle, pvk_in_axis);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxQuat_getAngle(physx.PxQuatPtr pvk_this);
        
        public float getAngle() {
            physx.PxQuatPtr pvk_in_this = this;
            return float_const_physx_PxQuat_getAngle(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxQuat_getAngle_physx_PxQuatPtr_(physx.PxQuatPtr pvk_this, physx.PxQuatPtr pvk_q);
        
        public float getAngle(physx.PxQuatPtr q) {
            physx.PxQuatPtr pvk_in_this = this;
            physx.PxQuatPtr pvk_in_q = q;
            return float_const_physx_PxQuat_getAngle_physx_PxQuatPtr_(pvk_in_this, pvk_in_q);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxQuat_magnitudeSquared(physx.PxQuatPtr pvk_this);
        
        public float magnitudeSquared() {
            physx.PxQuatPtr pvk_in_this = this;
            return float_const_physx_PxQuat_magnitudeSquared(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxQuat_dot_physx_PxQuatPtr_(physx.PxQuatPtr pvk_this, physx.PxQuatPtr pvk_v);
        
        public float dot(physx.PxQuatPtr v) {
            physx.PxQuatPtr pvk_in_this = this;
            physx.PxQuatPtr pvk_in_v = v;
            return float_const_physx_PxQuat_dot_physx_PxQuatPtr_(pvk_in_this, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr physx_PxQuatPtr_const_physx_PxQuat_getNormalized(physx.PxQuatPtr pvk_this);
        
        public physx.PxQuatPtr getNormalized_New() {
            physx.PxQuatPtr pvk_in_this = this;
            return physx_PxQuatPtr_const_physx_PxQuat_getNormalized(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxQuat_magnitude(physx.PxQuatPtr pvk_this);
        
        public float magnitude() {
            physx.PxQuatPtr pvk_in_this = this;
            return float_const_physx_PxQuat_magnitude(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_physx_PxQuat_normalize(physx.PxQuatPtr pvk_this);
        
        public float normalize() {
            physx.PxQuatPtr pvk_in_this = this;
            return float_physx_PxQuat_normalize(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr physx_PxQuatPtr_const_physx_PxQuat_getConjugate(physx.PxQuatPtr pvk_this);
        
        public physx.PxQuatPtr getConjugate_New() {
            physx.PxQuatPtr pvk_in_this = this;
            return physx_PxQuatPtr_const_physx_PxQuat_getConjugate(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr physx_PxVec3Ptr_const_physx_PxQuat_getImaginaryPart(physx.PxQuatPtr pvk_this);
        
        public physx.PxVec3Ptr getImaginaryPart_New() {
            physx.PxQuatPtr pvk_in_this = this;
            return physx_PxVec3Ptr_const_physx_PxQuat_getImaginaryPart(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr physx_PxVec3Ptr_const_physx_PxQuat_getBasisVector0(physx.PxQuatPtr pvk_this);
        
        public physx.PxVec3Ptr getBasisVector0_New() {
            physx.PxQuatPtr pvk_in_this = this;
            return physx_PxVec3Ptr_const_physx_PxQuat_getBasisVector0(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr physx_PxVec3Ptr_const_physx_PxQuat_getBasisVector1(physx.PxQuatPtr pvk_this);
        
        public physx.PxVec3Ptr getBasisVector1_New() {
            physx.PxQuatPtr pvk_in_this = this;
            return physx_PxVec3Ptr_const_physx_PxQuat_getBasisVector1(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr physx_PxVec3Ptr_const_physx_PxQuat_getBasisVector2(physx.PxQuatPtr pvk_this);
        
        public physx.PxVec3Ptr getBasisVector2_New() {
            physx.PxQuatPtr pvk_in_this = this;
            return physx_PxVec3Ptr_const_physx_PxQuat_getBasisVector2(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr physx_PxVec3Ptr_const_physx_PxQuat_rotate_physx_PxVec3Ptr_(physx.PxQuatPtr pvk_this, physx.PxVec3Ptr pvk_v);
        
        public physx.PxVec3Ptr rotate_New(physx.PxVec3Ptr v) {
            physx.PxQuatPtr pvk_in_this = this;
            physx.PxVec3Ptr pvk_in_v = v;
            return physx_PxVec3Ptr_const_physx_PxQuat_rotate_physx_PxVec3Ptr_(pvk_in_this, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr physx_PxVec3Ptr_const_physx_PxQuat_rotateInv_physx_PxVec3Ptr_(physx.PxQuatPtr pvk_this, physx.PxVec3Ptr pvk_v);
        
        public physx.PxVec3Ptr rotateInv_New(physx.PxVec3Ptr v) {
            physx.PxQuatPtr pvk_in_this = this;
            physx.PxVec3Ptr pvk_in_v = v;
            return physx_PxVec3Ptr_const_physx_PxQuat_rotateInv_physx_PxVec3Ptr_(pvk_in_this, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr physx_PxQuatPtr_const_physx_PxQuat_operator_Star_physx_PxQuatPtr_(physx.PxQuatPtr pvk_lhs, physx.PxQuatPtr pvk_q);
        
        public static physx.PxQuatPtr operator*(physx.PxQuatPtr lhs, physx.PxQuatPtr q) {
            physx.PxQuatPtr pvk_in_lhs = lhs;
            physx.PxQuatPtr pvk_in_q = q;
            return physx_PxQuatPtr_const_physx_PxQuat_operator_Star_physx_PxQuatPtr_(pvk_in_lhs, pvk_in_q);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr physx_PxQuatPtr_const_physx_PxQuat_operator_Plus_physx_PxQuatPtr_(physx.PxQuatPtr pvk_lhs, physx.PxQuatPtr pvk_q);
        
        public static physx.PxQuatPtr operator+(physx.PxQuatPtr lhs, physx.PxQuatPtr q) {
            physx.PxQuatPtr pvk_in_lhs = lhs;
            physx.PxQuatPtr pvk_in_q = q;
            return physx_PxQuatPtr_const_physx_PxQuat_operator_Plus_physx_PxQuatPtr_(pvk_in_lhs, pvk_in_q);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr physx_PxQuatPtr_const_physx_PxQuat_operator_Minus(physx.PxQuatPtr pvk_lhs);
        
        public static physx.PxQuatPtr operator-(physx.PxQuatPtr lhs) {
            physx.PxQuatPtr pvk_in_lhs = lhs;
            return physx_PxQuatPtr_const_physx_PxQuat_operator_Minus(pvk_in_lhs);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr physx_PxQuatPtr_const_physx_PxQuat_operator_Minus_physx_PxQuatPtr_(physx.PxQuatPtr pvk_lhs, physx.PxQuatPtr pvk_q);
        
        public static physx.PxQuatPtr operator-(physx.PxQuatPtr lhs, physx.PxQuatPtr q) {
            physx.PxQuatPtr pvk_in_lhs = lhs;
            physx.PxQuatPtr pvk_in_q = q;
            return physx_PxQuatPtr_const_physx_PxQuat_operator_Minus_physx_PxQuatPtr_(pvk_in_lhs, pvk_in_q);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxQuatPtr physx_PxQuatPtr_const_physx_PxQuat_operator_Star_float_(physx.PxQuatPtr pvk_lhs, float pvk_r);
        
        public static physx.PxQuatPtr operator*(physx.PxQuatPtr lhs, float r) {
            physx.PxQuatPtr pvk_in_lhs = lhs;
            float pvk_in_r = r;
            return physx_PxQuatPtr_const_physx_PxQuat_operator_Star_float_(pvk_in_lhs, pvk_in_r);
        }
    }
    
}