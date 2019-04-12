// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxBoxGeometry
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    public unsafe partial struct PxBoxGeometryPtr : physx.PxGeometryPtr.IPxGeometryPtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxBoxGeometryPtr(PxBoxGeometryPtr ptr);
        
        public static void Free(PxBoxGeometryPtr ptr){
            Freer_physx_PxBoxGeometryPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxBoxGeometryPtr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBoxGeometryPtr Ctor_physx_PxBoxGeometryPtr_();
        
        public static physx.PxBoxGeometryPtr New() {
            return Ctor_physx_PxBoxGeometryPtr_();
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBoxGeometryPtr Ctor_physx_PxBoxGeometryPtr_float_float_float(float pvk_hx, float pvk_hy, float pvk_hz);
        
        public static physx.PxBoxGeometryPtr New(float hx, float hy, float hz) {
            float pvk_in_hx = hx;
            float pvk_in_hy = hy;
            float pvk_in_hz = hz;
            return Ctor_physx_PxBoxGeometryPtr_float_float_float(pvk_in_hx, pvk_in_hy, pvk_in_hz);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBoxGeometryPtr Ctor_physx_PxBoxGeometryPtr_physx_PxVec3Ptr(physx.PxVec3Ptr pvk_halfExtents_);
        
        public static physx.PxBoxGeometryPtr New(physx.PxVec3Ptr halfExtents_) {
            physx.PxVec3Ptr pvk_in_halfExtents_ = halfExtents_;
            return Ctor_physx_PxBoxGeometryPtr_physx_PxVec3Ptr(pvk_in_halfExtents_);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxVec3Ptr PxBoxGeometry_GET_halfExtents(PxBoxGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxBoxGeometry_SET_halfExtents(PxBoxGeometryPtr cls, physx.PxVec3Ptr value);
        
        public physx.PxVec3Ptr halfExtents {
            get => PxBoxGeometry_GET_halfExtents(this);
            set => PxBoxGeometry_SET_halfExtents(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxBoxGeometry_isValid(physx.PxBoxGeometryPtr pvk_this);
        
        public bool isValid() {
            physx.PxBoxGeometryPtr pvk_in_this = this;
            return bool_const_physx_PxBoxGeometry_isValid(pvk_in_this);
        }
        public static implicit operator physx.PxGeometryPtr(PxBoxGeometryPtr obj) => *(physx.PxGeometryPtr*)&obj;
        public static explicit operator PxBoxGeometryPtr(physx.PxGeometryPtr obj) => *(PxBoxGeometryPtr*)&obj;
    
        // PIPING
        public physx.PxGeometryTypeEnum getType(){return((physx.PxGeometryPtr)this).getType();}
    }
    
}
