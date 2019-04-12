// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxCapsuleGeometry
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxTransformPtr physx_PxTransformPtr_physx_PxTransformFromSegment_physx_PxVec3Ptr_physx_PxVec3Ptr_float_(physx.PxVec3Ptr pvk_p0, physx.PxVec3Ptr pvk_p1, float* pvk_halfHeight);
    
    public static physx.PxTransformPtr PxTransformFromSegment_New(physx.PxVec3Ptr p0, physx.PxVec3Ptr p1, float* halfHeight=default(float*)) {
        physx.PxVec3Ptr pvk_in_p0 = p0;
        physx.PxVec3Ptr pvk_in_p1 = p1;
        float* pvk_in_halfHeight = halfHeight;
        return physx_PxTransformPtr_physx_PxTransformFromSegment_physx_PxVec3Ptr_physx_PxVec3Ptr_float_(pvk_in_p0, pvk_in_p1, pvk_in_halfHeight);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxTransformPtr physx_PxTransformPtr_physx_PxTransformFromSegment_physx_PxVec3Ptr_physx_PxVec3Ptr_(physx.PxVec3Ptr pvk_p0, physx.PxVec3Ptr pvk_p1);
    
    public static physx.PxTransformPtr PxTransformFromSegment_New(physx.PxVec3Ptr p0, physx.PxVec3Ptr p1) {
        physx.PxVec3Ptr pvk_in_p0 = p0;
        physx.PxVec3Ptr pvk_in_p1 = p1;
        return physx_PxTransformPtr_physx_PxTransformFromSegment_physx_PxVec3Ptr_physx_PxVec3Ptr_(pvk_in_p0, pvk_in_p1);
    }
    
    public unsafe partial struct PxCapsuleGeometryPtr : physx.PxGeometryPtr.IPxGeometryPtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxCapsuleGeometryPtr(PxCapsuleGeometryPtr ptr);
        
        public static void Free(PxCapsuleGeometryPtr ptr){
            Freer_physx_PxCapsuleGeometryPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxCapsuleGeometryPtr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxCapsuleGeometryPtr Ctor_physx_PxCapsuleGeometryPtr_();
        
        public static physx.PxCapsuleGeometryPtr New() {
            return Ctor_physx_PxCapsuleGeometryPtr_();
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxCapsuleGeometryPtr Ctor_physx_PxCapsuleGeometryPtr_float_float(float pvk_radius_, float pvk_halfHeight_);
        
        public static physx.PxCapsuleGeometryPtr New(float radius_, float halfHeight_) {
            float pvk_in_radius_ = radius_;
            float pvk_in_halfHeight_ = halfHeight_;
            return Ctor_physx_PxCapsuleGeometryPtr_float_float(pvk_in_radius_, pvk_in_halfHeight_);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxCapsuleGeometry_GET_radius(PxCapsuleGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxCapsuleGeometry_SET_radius(PxCapsuleGeometryPtr cls, float value);
        
        public float radius {
            get => PxCapsuleGeometry_GET_radius(this);
            set => PxCapsuleGeometry_SET_radius(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxCapsuleGeometry_GET_halfHeight(PxCapsuleGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxCapsuleGeometry_SET_halfHeight(PxCapsuleGeometryPtr cls, float value);
        
        public float halfHeight {
            get => PxCapsuleGeometry_GET_halfHeight(this);
            set => PxCapsuleGeometry_SET_halfHeight(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxCapsuleGeometry_isValid(physx.PxCapsuleGeometryPtr pvk_this);
        
        public bool isValid() {
            physx.PxCapsuleGeometryPtr pvk_in_this = this;
            return bool_const_physx_PxCapsuleGeometry_isValid(pvk_in_this);
        }
        public static implicit operator physx.PxGeometryPtr(PxCapsuleGeometryPtr obj) => *(physx.PxGeometryPtr*)&obj;
        public static explicit operator PxCapsuleGeometryPtr(physx.PxGeometryPtr obj) => *(PxCapsuleGeometryPtr*)&obj;
    
        // PIPING
        public physx.PxGeometryTypeEnum getType(){return((physx.PxGeometryPtr)this).getType();}
    }
    
}