// Generated by minBND 5.1.81.43 - © github.com/Alan-FGR
//Unit PxPlaneGeometry
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    public static physx.PxTransform PxTransformFromPlaneEquation(physx.PxPlane plane) {
        return PxTransformFromPlaneEquation(&plane);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void physx_PxTransform_physx_PxTransformFromPlaneEquation_physx_PxPlane_(physx.PxTransform* RetRef, physx.PxPlane* pvk_plane);
    
    public static physx.PxTransform PxTransformFromPlaneEquation(physx.PxPlane* plane) {
        physx.PxTransform RetRef;
        physx.PxPlane* pvk_in_plane = plane;
        physx_PxTransform_physx_PxTransformFromPlaneEquation_physx_PxPlane_(&RetRef, pvk_in_plane);
        return RetRef;
    }
    
    public static physx.PxPlane PxPlaneEquationFromTransform(physx.PxTransform transform) {
        return PxPlaneEquationFromTransform(&transform);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void physx_PxPlane_physx_PxPlaneEquationFromTransform_physx_PxTransform_(physx.PxPlane* RetRef, physx.PxTransform* pvk_transform);
    
    public static physx.PxPlane PxPlaneEquationFromTransform(physx.PxTransform* transform) {
        physx.PxPlane RetRef;
        physx.PxTransform* pvk_in_transform = transform;
        physx_PxPlane_physx_PxPlaneEquationFromTransform_physx_PxTransform_(&RetRef, pvk_in_transform);
        return RetRef;
    }
    
    public unsafe partial struct PxPlaneGeometryPtr : physx.PxGeometryPtr.IPxGeometryPtr {
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxPlaneGeometryPtr(PxPlaneGeometryPtr ptr);
        
        public static void Free(PxPlaneGeometryPtr ptr){
            Freer_physx_PxPlaneGeometryPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxPlaneGeometryPtr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxPlaneGeometryPtr Ctor_physx_PxPlaneGeometryPtr_();
        
        public static physx.PxPlaneGeometryPtr New() {
            return Ctor_physx_PxPlaneGeometryPtr_();
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxPlaneGeometry_isValid(physx.PxPlaneGeometryPtr pvk_this);
        
        public bool isValid() {
            physx.PxPlaneGeometryPtr pvk_in_this = this;
            return bool_const_physx_PxPlaneGeometry_isValid(pvk_in_this);
        }
        public static implicit operator physx.PxGeometryPtr(PxPlaneGeometryPtr obj) => *(physx.PxGeometryPtr*)&obj;
        public static explicit operator PxPlaneGeometryPtr(physx.PxGeometryPtr obj) => *(PxPlaneGeometryPtr*)&obj;
    
        // PIPING
        public physx.PxGeometryTypeEnum getType(){return((physx.PxGeometryPtr)this).getType();}
    }
    
}
