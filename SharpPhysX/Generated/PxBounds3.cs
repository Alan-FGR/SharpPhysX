// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct PxBounds3 {
        [FieldOffset( 0)] public physx.PxVec3 minimum;
        [FieldOffset(12)] public physx.PxVec3 maximum;

        public static PxBounds3 Default() {

            PxBounds3 toInit;
            var pvk_in_this = &toInit;
            void_PxBounds3_PxBounds3Ptr_Ctor(pvk_in_this);
            return toInit;
        }

        public PxBounds3(physx.PxVec3 minimum, physx.PxVec3 maximum) : this((physx.PxVec3*)&minimum, (physx.PxVec3*)&maximum) {
            //ctor piping;
        }

        public PxBounds3(physx.PxVec3.Ref minimum, physx.PxVec3.Ref maximum) : this((physx.PxVec3*)(*((IntPtr*)(&minimum))), (physx.PxVec3*)(*((IntPtr*)(&maximum)))) {
            //ctor piping;
        }

        public PxBounds3(physx.PxVec3* minimum, physx.PxVec3* maximum) {

            physx.PxVec3* pvk_in_minimum = minimum;
            physx.PxVec3* pvk_in_maximum = maximum;
            PxBounds3 toInit;
            var pvk_in_this = &toInit;
            void_PxBounds3_PxBounds3Ptr_Ctor_PxVec3_PxVec3_(pvk_in_this, pvk_in_minimum, pvk_in_maximum);
            this = toInit;
        }

        public physx.PxBounds3 empty() {
            physx.PxBounds3 RetRef;

            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_emptyPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public physx.PxBounds3 boundsOfPoints(physx.PxVec3 v0, physx.PxVec3 v1) {
            return boundsOfPoints((physx.PxVec3*)&v0, (physx.PxVec3*)&v1);
        }

        public physx.PxBounds3 boundsOfPoints(physx.PxVec3.Ref v0, physx.PxVec3.Ref v1) {
            return boundsOfPoints((physx.PxVec3*)(*((IntPtr*)(&v0))), (physx.PxVec3*)(*((IntPtr*)(&v1))));
        }

        public physx.PxBounds3 boundsOfPoints(physx.PxVec3* v0, physx.PxVec3* v1) {
            physx.PxBounds3 RetRef;

            physx.PxVec3* pvk_in_v0 = v0;
            physx.PxVec3* pvk_in_v1 = v1;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_boundsOfPointsPtr_PxVec3_PxVec3_(&RetRef, pvk_in_this, pvk_in_v0, pvk_in_v1);
            }
            return RetRef;
        }

        public physx.PxBounds3 centerExtents(physx.PxVec3 center, physx.PxVec3 extent) {
            return centerExtents((physx.PxVec3*)&center, (physx.PxVec3*)&extent);
        }

        public physx.PxBounds3 centerExtents(physx.PxVec3.Ref center, physx.PxVec3.Ref extent) {
            return centerExtents((physx.PxVec3*)(*((IntPtr*)(&center))), (physx.PxVec3*)(*((IntPtr*)(&extent))));
        }

        public physx.PxBounds3 centerExtents(physx.PxVec3* center, physx.PxVec3* extent) {
            physx.PxBounds3 RetRef;

            physx.PxVec3* pvk_in_center = center;
            physx.PxVec3* pvk_in_extent = extent;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_centerExtentsPtr_PxVec3_PxVec3_(&RetRef, pvk_in_this, pvk_in_center, pvk_in_extent);
            }
            return RetRef;
        }

        public physx.PxBounds3 basisExtent(physx.PxVec3 center, physx.PxMat33 basis, physx.PxVec3 extent) {
            return basisExtent((physx.PxVec3*)&center, (physx.PxMat33*)&basis, (physx.PxVec3*)&extent);
        }

        public physx.PxBounds3 basisExtent(physx.PxVec3.Ref center, physx.PxMat33.Ref basis, physx.PxVec3.Ref extent) {
            return basisExtent((physx.PxVec3*)(*((IntPtr*)(&center))), (physx.PxMat33*)(*((IntPtr*)(&basis))), (physx.PxVec3*)(*((IntPtr*)(&extent))));
        }

        public physx.PxBounds3 basisExtent(physx.PxVec3* center, physx.PxMat33* basis, physx.PxVec3* extent) {
            physx.PxBounds3 RetRef;

            physx.PxVec3* pvk_in_center = center;
            physx.PxMat33* pvk_in_basis = basis;
            physx.PxVec3* pvk_in_extent = extent;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_basisExtentPtr_PxVec3_PxMat33_PxVec3_(&RetRef, pvk_in_this, pvk_in_center, pvk_in_basis, pvk_in_extent);
            }
            return RetRef;
        }

        public physx.PxBounds3 poseExtent(physx.PxTransform pose, physx.PxVec3 extent) {
            return poseExtent((physx.PxTransform*)&pose, (physx.PxVec3*)&extent);
        }

        public physx.PxBounds3 poseExtent(physx.PxTransform.Ref pose, physx.PxVec3.Ref extent) {
            return poseExtent((physx.PxTransform*)(*((IntPtr*)(&pose))), (physx.PxVec3*)(*((IntPtr*)(&extent))));
        }

        public physx.PxBounds3 poseExtent(physx.PxTransform* pose, physx.PxVec3* extent) {
            physx.PxBounds3 RetRef;

            physx.PxTransform* pvk_in_pose = pose;
            physx.PxVec3* pvk_in_extent = extent;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_poseExtentPtr_PxTransform_PxVec3_(&RetRef, pvk_in_this, pvk_in_pose, pvk_in_extent);
            }
            return RetRef;
        }

        public physx.PxBounds3 transformSafe(physx.PxMat33 matrix, physx.PxBounds3 bounds) {
            return transformSafe((physx.PxMat33*)&matrix, (physx.PxBounds3*)&bounds);
        }

        public physx.PxBounds3 transformSafe(physx.PxMat33.Ref matrix, physx.PxBounds3.Ref bounds) {
            return transformSafe((physx.PxMat33*)(*((IntPtr*)(&matrix))), (physx.PxBounds3*)(*((IntPtr*)(&bounds))));
        }

        public physx.PxBounds3 transformSafe(physx.PxMat33* matrix, physx.PxBounds3* bounds) {
            physx.PxBounds3 RetRef;

            physx.PxMat33* pvk_in_matrix = matrix;
            physx.PxBounds3* pvk_in_bounds = bounds;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_transformSafePtr_PxMat33_PxBounds3_(&RetRef, pvk_in_this, pvk_in_matrix, pvk_in_bounds);
            }
            return RetRef;
        }

        public physx.PxBounds3 transformFast(physx.PxMat33 matrix, physx.PxBounds3 bounds) {
            return transformFast((physx.PxMat33*)&matrix, (physx.PxBounds3*)&bounds);
        }

        public physx.PxBounds3 transformFast(physx.PxMat33.Ref matrix, physx.PxBounds3.Ref bounds) {
            return transformFast((physx.PxMat33*)(*((IntPtr*)(&matrix))), (physx.PxBounds3*)(*((IntPtr*)(&bounds))));
        }

        public physx.PxBounds3 transformFast(physx.PxMat33* matrix, physx.PxBounds3* bounds) {
            physx.PxBounds3 RetRef;

            physx.PxMat33* pvk_in_matrix = matrix;
            physx.PxBounds3* pvk_in_bounds = bounds;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_transformFastPtr_PxMat33_PxBounds3_(&RetRef, pvk_in_this, pvk_in_matrix, pvk_in_bounds);
            }
            return RetRef;
        }

        public physx.PxBounds3 transformSafe(physx.PxTransform transform, physx.PxBounds3 bounds) {
            return transformSafe((physx.PxTransform*)&transform, (physx.PxBounds3*)&bounds);
        }

        public physx.PxBounds3 transformSafe(physx.PxTransform.Ref transform, physx.PxBounds3.Ref bounds) {
            return transformSafe((physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxBounds3*)(*((IntPtr*)(&bounds))));
        }

        public physx.PxBounds3 transformSafe(physx.PxTransform* transform, physx.PxBounds3* bounds) {
            physx.PxBounds3 RetRef;

            physx.PxTransform* pvk_in_transform = transform;
            physx.PxBounds3* pvk_in_bounds = bounds;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_transformSafePtr_PxTransform_PxBounds3_(&RetRef, pvk_in_this, pvk_in_transform, pvk_in_bounds);
            }
            return RetRef;
        }

        public physx.PxBounds3 transformFast(physx.PxTransform transform, physx.PxBounds3 bounds) {
            return transformFast((physx.PxTransform*)&transform, (physx.PxBounds3*)&bounds);
        }

        public physx.PxBounds3 transformFast(physx.PxTransform.Ref transform, physx.PxBounds3.Ref bounds) {
            return transformFast((physx.PxTransform*)(*((IntPtr*)(&transform))), (physx.PxBounds3*)(*((IntPtr*)(&bounds))));
        }

        public physx.PxBounds3 transformFast(physx.PxTransform* transform, physx.PxBounds3* bounds) {
            physx.PxBounds3 RetRef;

            physx.PxTransform* pvk_in_transform = transform;
            physx.PxBounds3* pvk_in_bounds = bounds;
            fixed (PxBounds3* pvk_in_this = &this){
              PxBounds3_PxBounds3_transformFastPtr_PxTransform_PxBounds3_(&RetRef, pvk_in_this, pvk_in_transform, pvk_in_bounds);
            }
            return RetRef;
        }

        public void setEmpty() {

            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_setEmptyPtr(pvk_in_this);
            }
        }

        public void setMaximal() {

            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_setMaximalPtr(pvk_in_this);
            }
        }

        public void include(physx.PxVec3 v) {
            include((physx.PxVec3*)&v);
        }

        public void include(physx.PxVec3.Ref v) {
            include((physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public void include(physx.PxVec3* v) {

            physx.PxVec3* pvk_in_v = v;
            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_includePtr_PxVec3_(pvk_in_this, pvk_in_v);
            }
        }

        public void include(physx.PxBounds3 b) {
            include((physx.PxBounds3*)&b);
        }

        public void include(physx.PxBounds3.Ref b) {
            include((physx.PxBounds3*)(*((IntPtr*)(&b))));
        }

        public void include(physx.PxBounds3* b) {

            physx.PxBounds3* pvk_in_b = b;
            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_includePtr_PxBounds3_(pvk_in_this, pvk_in_b);
            }
        }

        public bool isEmpty() {

            fixed (PxBounds3* pvk_in_this = &this){
              return bool_const_PxBounds3_isEmptyPtr(pvk_in_this);
            }
        }

        public bool intersects(physx.PxBounds3 b) {
            return intersects((physx.PxBounds3*)&b);
        }

        public bool intersects(physx.PxBounds3.Ref b) {
            return intersects((physx.PxBounds3*)(*((IntPtr*)(&b))));
        }

        public bool intersects(physx.PxBounds3* b) {

            physx.PxBounds3* pvk_in_b = b;
            fixed (PxBounds3* pvk_in_this = &this){
              return bool_const_PxBounds3_intersectsPtr_PxBounds3_(pvk_in_this, pvk_in_b);
            }
        }

        public bool intersects1D(physx.PxBounds3 a, uint axis) {
            return intersects1D((physx.PxBounds3*)&a, axis);
        }

        public bool intersects1D(physx.PxBounds3.Ref a, uint axis) {
            return intersects1D((physx.PxBounds3*)(*((IntPtr*)(&a))), axis);
        }

        public bool intersects1D(physx.PxBounds3* a, uint axis) {

            physx.PxBounds3* pvk_in_a = a;
            uint pvk_in_axis = axis;
            fixed (PxBounds3* pvk_in_this = &this){
              return bool_const_PxBounds3_intersects1DPtr_PxBounds3_uint_(pvk_in_this, pvk_in_a, pvk_in_axis);
            }
        }

        public bool contains(physx.PxVec3 v) {
            return contains((physx.PxVec3*)&v);
        }

        public bool contains(physx.PxVec3.Ref v) {
            return contains((physx.PxVec3*)(*((IntPtr*)(&v))));
        }

        public bool contains(physx.PxVec3* v) {

            physx.PxVec3* pvk_in_v = v;
            fixed (PxBounds3* pvk_in_this = &this){
              return bool_const_PxBounds3_containsPtr_PxVec3_(pvk_in_this, pvk_in_v);
            }
        }

        public bool isInside(physx.PxBounds3 box) {
            return isInside((physx.PxBounds3*)&box);
        }

        public bool isInside(physx.PxBounds3.Ref box) {
            return isInside((physx.PxBounds3*)(*((IntPtr*)(&box))));
        }

        public bool isInside(physx.PxBounds3* box) {

            physx.PxBounds3* pvk_in_box = box;
            fixed (PxBounds3* pvk_in_this = &this){
              return bool_const_PxBounds3_isInsidePtr_PxBounds3_(pvk_in_this, pvk_in_box);
            }
        }

        public physx.PxVec3 getCenter() {
            physx.PxVec3 RetRef;

            fixed (PxBounds3* pvk_in_this = &this){
              PxVec3_const_PxBounds3_getCenterPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public float getCenter(uint axis) {

            uint pvk_in_axis = axis;
            fixed (PxBounds3* pvk_in_this = &this){
              return float_const_PxBounds3_getCenterPtr_uint_(pvk_in_this, pvk_in_axis);
            }
        }

        public float getExtents(uint axis) {

            uint pvk_in_axis = axis;
            fixed (PxBounds3* pvk_in_this = &this){
              return float_const_PxBounds3_getExtentsPtr_uint_(pvk_in_this, pvk_in_axis);
            }
        }

        public physx.PxVec3 getDimensions() {
            physx.PxVec3 RetRef;

            fixed (PxBounds3* pvk_in_this = &this){
              PxVec3_const_PxBounds3_getDimensionsPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public physx.PxVec3 getExtents() {
            physx.PxVec3 RetRef;

            fixed (PxBounds3* pvk_in_this = &this){
              PxVec3_const_PxBounds3_getExtentsPtr(&RetRef, pvk_in_this);
            }
            return RetRef;
        }

        public void scaleSafe(float scale) {

            float pvk_in_scale = scale;
            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_scaleSafePtr_float_(pvk_in_this, pvk_in_scale);
            }
        }

        public void scaleFast(float scale) {

            float pvk_in_scale = scale;
            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_scaleFastPtr_float_(pvk_in_this, pvk_in_scale);
            }
        }

        public void fattenSafe(float distance) {

            float pvk_in_distance = distance;
            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_fattenSafePtr_float_(pvk_in_this, pvk_in_distance);
            }
        }

        public void fattenFast(float distance) {

            float pvk_in_distance = distance;
            fixed (PxBounds3* pvk_in_this = &this){
              void_PxBounds3_fattenFastPtr_float_(pvk_in_this, pvk_in_distance);
            }
        }

        public bool isFinite() {

            fixed (PxBounds3* pvk_in_this = &this){
              return bool_const_PxBounds3_isFinitePtr(pvk_in_this);
            }
        }

        public bool isValid() {

            fixed (PxBounds3* pvk_in_this = &this){
              return bool_const_PxBounds3_isValidPtr(pvk_in_this);
            }
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxBounds3 obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
    }
}
