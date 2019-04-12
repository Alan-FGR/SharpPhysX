// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxVec4
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    // physx::operator* [static physx.PxVec4Ptr Mult_New(float f, physx.PxVec4Ptr v)] will be bound as member operator
    
    public unsafe partial struct PxVec4Ptr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxVec4Ptr(PxVec4Ptr ptr);
        
        public static void Free(PxVec4Ptr ptr){
            Freer_physx_PxVec4Ptr(ptr);
        }
        public void Free(){
            Freer_physx_PxVec4Ptr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr Ctor_physx_PxVec4Ptr_();
        
        public static physx.PxVec4Ptr New() {
            return Ctor_physx_PxVec4Ptr_();
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr Ctor_physx_PxVec4Ptr_physx_PxZERO(physx.PxZERO pvk_r);
        
        public static physx.PxVec4Ptr New(physx.PxZERO r) {
            physx.PxZERO pvk_in_r = r;
            return Ctor_physx_PxVec4Ptr_physx_PxZERO(pvk_in_r);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr Ctor_physx_PxVec4Ptr_float(float pvk_a);
        
        public static physx.PxVec4Ptr New(float a) {
            float pvk_in_a = a;
            return Ctor_physx_PxVec4Ptr_float(pvk_in_a);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr Ctor_physx_PxVec4Ptr_float_float_float_float(float pvk_nx, float pvk_ny, float pvk_nz, float pvk_nw);
        
        public static physx.PxVec4Ptr New(float nx, float ny, float nz, float nw) {
            float pvk_in_nx = nx;
            float pvk_in_ny = ny;
            float pvk_in_nz = nz;
            float pvk_in_nw = nw;
            return Ctor_physx_PxVec4Ptr_float_float_float_float(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_nw);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr Ctor_physx_PxVec4Ptr_physx_PxVec3Ptr_float(physx.PxVec3Ptr pvk_v, float pvk_nw);
        
        public static physx.PxVec4Ptr New(physx.PxVec3Ptr v, float nw) {
            physx.PxVec3Ptr pvk_in_v = v;
            float pvk_in_nw = nw;
            return Ctor_physx_PxVec4Ptr_physx_PxVec3Ptr_float(pvk_in_v, pvk_in_nw);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr Ctor_physx_PxVec4Ptr_physx_PxVec4Ptr(physx.PxVec4Ptr pvk_v);
        
        public static physx.PxVec4Ptr New(physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_v = v;
            return Ctor_physx_PxVec4Ptr_physx_PxVec4Ptr(pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxVec4_GET_x(PxVec4Ptr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxVec4_SET_x(PxVec4Ptr cls, float value);
        
        public float x {
            get => PxVec4_GET_x(this);
            set => PxVec4_SET_x(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxVec4_GET_y(PxVec4Ptr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxVec4_SET_y(PxVec4Ptr cls, float value);
        
        public float y {
            get => PxVec4_GET_y(this);
            set => PxVec4_SET_y(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxVec4_GET_z(PxVec4Ptr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxVec4_SET_z(PxVec4Ptr cls, float value);
        
        public float z {
            get => PxVec4_GET_z(this);
            set => PxVec4_SET_z(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxVec4_GET_w(PxVec4Ptr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxVec4_SET_w(PxVec4Ptr cls, float value);
        
        public float w {
            get => PxVec4_GET_w(this);
            set => PxVec4_SET_w(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxVec4_operator_EqualEqual_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_lhs, physx.PxVec4Ptr pvk_v);
        
        public static bool operator==(physx.PxVec4Ptr lhs, physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_lhs = lhs;
            physx.PxVec4Ptr pvk_in_v = v;
            return bool_const_physx_PxVec4_operator_EqualEqual_physx_PxVec4Ptr_(pvk_in_lhs, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxVec4_operator_ExclaimEqual_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_lhs, physx.PxVec4Ptr pvk_v);
        
        public static bool operator!=(physx.PxVec4Ptr lhs, physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_lhs = lhs;
            physx.PxVec4Ptr pvk_in_v = v;
            return bool_const_physx_PxVec4_operator_ExclaimEqual_physx_PxVec4Ptr_(pvk_in_lhs, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxVec4_isZero(physx.PxVec4Ptr pvk_this);
        
        public bool isZero() {
            physx.PxVec4Ptr pvk_in_this = this;
            return bool_const_physx_PxVec4_isZero(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxVec4_isFinite(physx.PxVec4Ptr pvk_this);
        
        public bool isFinite() {
            physx.PxVec4Ptr pvk_in_this = this;
            return bool_const_physx_PxVec4_isFinite(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxVec4_isNormalized(physx.PxVec4Ptr pvk_this);
        
        public bool isNormalized() {
            physx.PxVec4Ptr pvk_in_this = this;
            return bool_const_physx_PxVec4_isNormalized(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxVec4_magnitudeSquared(physx.PxVec4Ptr pvk_this);
        
        public float magnitudeSquared() {
            physx.PxVec4Ptr pvk_in_this = this;
            return float_const_physx_PxVec4_magnitudeSquared(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxVec4_magnitude(physx.PxVec4Ptr pvk_this);
        
        public float magnitude() {
            physx.PxVec4Ptr pvk_in_this = this;
            return float_const_physx_PxVec4_magnitude(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_operator_Minus(physx.PxVec4Ptr pvk_lhs);
        
        public static physx.PxVec4Ptr operator-(physx.PxVec4Ptr lhs) {
            physx.PxVec4Ptr pvk_in_lhs = lhs;
            return physx_PxVec4Ptr_const_physx_PxVec4_operator_Minus(pvk_in_lhs);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_operator_Plus_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_lhs, physx.PxVec4Ptr pvk_v);
        
        public static physx.PxVec4Ptr operator+(physx.PxVec4Ptr lhs, physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_lhs = lhs;
            physx.PxVec4Ptr pvk_in_v = v;
            return physx_PxVec4Ptr_const_physx_PxVec4_operator_Plus_physx_PxVec4Ptr_(pvk_in_lhs, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_operator_Minus_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_lhs, physx.PxVec4Ptr pvk_v);
        
        public static physx.PxVec4Ptr operator-(physx.PxVec4Ptr lhs, physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_lhs = lhs;
            physx.PxVec4Ptr pvk_in_v = v;
            return physx_PxVec4Ptr_const_physx_PxVec4_operator_Minus_physx_PxVec4Ptr_(pvk_in_lhs, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_operator_Star_float_(physx.PxVec4Ptr pvk_lhs, float pvk_f);
        
        public static physx.PxVec4Ptr operator*(physx.PxVec4Ptr lhs, float f) {
            physx.PxVec4Ptr pvk_in_lhs = lhs;
            float pvk_in_f = f;
            return physx_PxVec4Ptr_const_physx_PxVec4_operator_Star_float_(pvk_in_lhs, pvk_in_f);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_operator_Slash_float_(physx.PxVec4Ptr pvk_lhs, float pvk_f);
        
        public static physx.PxVec4Ptr operator/(physx.PxVec4Ptr lhs, float f) {
            physx.PxVec4Ptr pvk_in_lhs = lhs;
            float pvk_in_f = f;
            return physx_PxVec4Ptr_const_physx_PxVec4_operator_Slash_float_(pvk_in_lhs, pvk_in_f);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxVec4_dot_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_this, physx.PxVec4Ptr pvk_v);
        
        public float dot(physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_this = this;
            physx.PxVec4Ptr pvk_in_v = v;
            return float_const_physx_PxVec4_dot_physx_PxVec4Ptr_(pvk_in_this, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_getNormalized(physx.PxVec4Ptr pvk_this);
        
        public physx.PxVec4Ptr getNormalized_New() {
            physx.PxVec4Ptr pvk_in_this = this;
            return physx_PxVec4Ptr_const_physx_PxVec4_getNormalized(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_physx_PxVec4_normalize(physx.PxVec4Ptr pvk_this);
        
        public float normalize() {
            physx.PxVec4Ptr pvk_in_this = this;
            return float_physx_PxVec4_normalize(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_multiply_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_this, physx.PxVec4Ptr pvk_a);
        
        public physx.PxVec4Ptr multiply_New(physx.PxVec4Ptr a) {
            physx.PxVec4Ptr pvk_in_this = this;
            physx.PxVec4Ptr pvk_in_a = a;
            return physx_PxVec4Ptr_const_physx_PxVec4_multiply_physx_PxVec4Ptr_(pvk_in_this, pvk_in_a);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_minimum_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_this, physx.PxVec4Ptr pvk_v);
        
        public physx.PxVec4Ptr minimum_New(physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_this = this;
            physx.PxVec4Ptr pvk_in_v = v;
            return physx_PxVec4Ptr_const_physx_PxVec4_minimum_physx_PxVec4Ptr_(pvk_in_this, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_const_physx_PxVec4_maximum_physx_PxVec4Ptr_(physx.PxVec4Ptr pvk_this, physx.PxVec4Ptr pvk_v);
        
        public physx.PxVec4Ptr maximum_New(physx.PxVec4Ptr v) {
            physx.PxVec4Ptr pvk_in_this = this;
            physx.PxVec4Ptr pvk_in_v = v;
            return physx_PxVec4Ptr_const_physx_PxVec4_maximum_physx_PxVec4Ptr_(pvk_in_this, pvk_in_v);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr physx_PxVec3Ptr_const_physx_PxVec4_getXYZ(physx.PxVec4Ptr pvk_this);
        
        public physx.PxVec3Ptr getXYZ_New() {
            physx.PxVec4Ptr pvk_in_this = this;
            return physx_PxVec3Ptr_const_physx_PxVec4_getXYZ(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxVec4_setZero(physx.PxVec4Ptr pvk_this);
        
        public void setZero() {
            physx.PxVec4Ptr pvk_in_this = this;
            void_physx_PxVec4_setZero(pvk_in_this);
        }
    
    
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec4Ptr physx_PxVec4Ptr_physx_operator_Star_float_physx_PxVec4Ptr_(float pvk_f, physx.PxVec4Ptr pvk_v);
        
        public static physx.PxVec4Ptr Mult_New(float f, physx.PxVec4Ptr v) {
            float pvk_in_f = f;
            physx.PxVec4Ptr pvk_in_v = v;
            return physx_PxVec4Ptr_physx_operator_Star_float_physx_PxVec4Ptr_(pvk_in_f, pvk_in_v);
        }
    }
    
}
