// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxPhysics
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    public unsafe partial struct PxPhysicsPtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxPhysics_release(physx.PxPhysicsPtr pvk_this);
        
        public void release() {
            physx.PxPhysicsPtr pvk_in_this = this;
            void_physx_PxPhysics_release(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxFoundationPtr physx_PxFoundationPtr_physx_PxPhysics_getFoundation(physx.PxPhysicsPtr pvk_this);
        
        public physx.PxFoundationPtr getFoundation() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return physx_PxFoundationPtr_physx_PxPhysics_getFoundation(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxAggregatePtr physx_PxAggregatePtr_physx_PxPhysics_createAggregate_uint_bool_(physx.PxPhysicsPtr pvk_this, uint pvk_maxSize, bool pvk_enableSelfCollision);
        
        public physx.PxAggregatePtr createAggregate(uint maxSize, bool enableSelfCollision) {
            physx.PxPhysicsPtr pvk_in_this = this;
            uint pvk_in_maxSize = maxSize;
            bool pvk_in_enableSelfCollision = enableSelfCollision;
            return physx_PxAggregatePtr_physx_PxPhysics_createAggregate_uint_bool_(pvk_in_this, pvk_in_maxSize, pvk_in_enableSelfCollision);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxTolerancesScalePtr physx_PxTolerancesScalePtr_const_physx_PxPhysics_getTolerancesScale(physx.PxPhysicsPtr pvk_this);
        
        public physx.PxTolerancesScalePtr getTolerancesScale() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return physx_PxTolerancesScalePtr_const_physx_PxPhysics_getTolerancesScale(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getNbTriangleMeshes(physx.PxPhysicsPtr pvk_this);
        
        public uint getNbTriangleMeshes() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return uint_const_physx_PxPhysics_getNbTriangleMeshes(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getTriangleMeshes_physx_PxTriangleMeshPtr_uint_uint_(physx.PxPhysicsPtr pvk_this, physx.PxTriangleMeshPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getTriangleMeshes(physx.PxTriangleMeshPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxTriangleMeshPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxPhysics_getTriangleMeshes_physx_PxTriangleMeshPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getTriangleMeshes_physx_PxTriangleMeshPtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxTriangleMeshPtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getTriangleMeshes(physx.PxTriangleMeshPtr* userBuffer, uint bufferSize) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxTriangleMeshPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxPhysics_getTriangleMeshes_physx_PxTriangleMeshPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getNbHeightFields(physx.PxPhysicsPtr pvk_this);
        
        public uint getNbHeightFields() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return uint_const_physx_PxPhysics_getNbHeightFields(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getHeightFields_physx_PxHeightFieldPtr_uint_uint_(physx.PxPhysicsPtr pvk_this, physx.PxHeightFieldPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getHeightFields(physx.PxHeightFieldPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxHeightFieldPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxPhysics_getHeightFields_physx_PxHeightFieldPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getHeightFields_physx_PxHeightFieldPtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxHeightFieldPtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getHeightFields(physx.PxHeightFieldPtr* userBuffer, uint bufferSize) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxHeightFieldPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxPhysics_getHeightFields_physx_PxHeightFieldPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getNbConvexMeshes(physx.PxPhysicsPtr pvk_this);
        
        public uint getNbConvexMeshes() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return uint_const_physx_PxPhysics_getNbConvexMeshes(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getConvexMeshes_physx_PxConvexMeshPtr_uint_uint_(physx.PxPhysicsPtr pvk_this, physx.PxConvexMeshPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getConvexMeshes(physx.PxConvexMeshPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxConvexMeshPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxPhysics_getConvexMeshes_physx_PxConvexMeshPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getConvexMeshes_physx_PxConvexMeshPtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxConvexMeshPtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getConvexMeshes(physx.PxConvexMeshPtr* userBuffer, uint bufferSize) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxConvexMeshPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxPhysics_getConvexMeshes_physx_PxConvexMeshPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getNbBVHStructures(physx.PxPhysicsPtr pvk_this);
        
        public uint getNbBVHStructures() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return uint_const_physx_PxPhysics_getNbBVHStructures(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxScenePtr physx_PxScenePtr_physx_PxPhysics_createScene_physx_PxSceneDescPtr_(physx.PxPhysicsPtr pvk_this, physx.PxSceneDescPtr pvk_sceneDesc);
        
        public physx.PxScenePtr createScene(physx.PxSceneDescPtr sceneDesc) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxSceneDescPtr pvk_in_sceneDesc = sceneDesc;
            return physx_PxScenePtr_physx_PxPhysics_createScene_physx_PxSceneDescPtr_(pvk_in_this, pvk_in_sceneDesc);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getNbScenes(physx.PxPhysicsPtr pvk_this);
        
        public uint getNbScenes() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return uint_const_physx_PxPhysics_getNbScenes(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getScenes_physx_PxScenePtr_uint_uint_(physx.PxPhysicsPtr pvk_this, physx.PxScenePtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getScenes(physx.PxScenePtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxScenePtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxPhysics_getScenes_physx_PxScenePtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getScenes_physx_PxScenePtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxScenePtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getScenes(physx.PxScenePtr* userBuffer, uint bufferSize) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxScenePtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxPhysics_getScenes_physx_PxScenePtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxRigidStaticPtr physx_PxRigidStaticPtr_physx_PxPhysics_createRigidStatic_physx_PxTransformPtr_(physx.PxPhysicsPtr pvk_this, physx.PxTransformPtr pvk_pose);
        
        public physx.PxRigidStaticPtr createRigidStatic(physx.PxTransformPtr pose) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxTransformPtr pvk_in_pose = pose;
            return physx_PxRigidStaticPtr_physx_PxPhysics_createRigidStatic_physx_PxTransformPtr_(pvk_in_this, pvk_in_pose);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxRigidDynamicPtr physx_PxRigidDynamicPtr_physx_PxPhysics_createRigidDynamic_physx_PxTransformPtr_(physx.PxPhysicsPtr pvk_this, physx.PxTransformPtr pvk_pose);
        
        public physx.PxRigidDynamicPtr createRigidDynamic(physx.PxTransformPtr pose) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxTransformPtr pvk_in_pose = pose;
            return physx_PxRigidDynamicPtr_physx_PxPhysics_createRigidDynamic_physx_PxTransformPtr_(pvk_in_this, pvk_in_pose);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxShapePtr physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_bool_PxShapeFlagsPtr_(physx.PxPhysicsPtr pvk_this, physx.PxGeometryPtr pvk_geometry, physx.PxMaterialPtr pvk_material, bool pvk_isExclusive, PxShapeFlagsPtr pvk_shapeFlags);
        
        public physx.PxShapePtr createShape(physx.PxGeometryPtr geometry, physx.PxMaterialPtr material, bool isExclusive, PxShapeFlagsPtr shapeFlags) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxGeometryPtr pvk_in_geometry = geometry;
            physx.PxMaterialPtr pvk_in_material = material;
            bool pvk_in_isExclusive = isExclusive;
            PxShapeFlagsPtr pvk_in_shapeFlags = shapeFlags;
            return physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_bool_PxShapeFlagsPtr_(pvk_in_this, pvk_in_geometry, pvk_in_material, pvk_in_isExclusive, pvk_in_shapeFlags);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxShapePtr physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_bool_(physx.PxPhysicsPtr pvk_this, physx.PxGeometryPtr pvk_geometry, physx.PxMaterialPtr pvk_material, bool pvk_isExclusive);
        
        public physx.PxShapePtr createShape(physx.PxGeometryPtr geometry, physx.PxMaterialPtr material, bool isExclusive=false) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxGeometryPtr pvk_in_geometry = geometry;
            physx.PxMaterialPtr pvk_in_material = material;
            bool pvk_in_isExclusive = isExclusive;
            return physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_bool_(pvk_in_this, pvk_in_geometry, pvk_in_material, pvk_in_isExclusive);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxShapePtr physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_(physx.PxPhysicsPtr pvk_this, physx.PxGeometryPtr pvk_geometry, physx.PxMaterialPtr pvk_material);
        
        public physx.PxShapePtr createShape(physx.PxGeometryPtr geometry, physx.PxMaterialPtr material) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxGeometryPtr pvk_in_geometry = geometry;
            physx.PxMaterialPtr pvk_in_material = material;
            return physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_(pvk_in_this, pvk_in_geometry, pvk_in_material);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxShapePtr physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_ushort_bool_PxShapeFlagsPtr_(physx.PxPhysicsPtr pvk_this, physx.PxGeometryPtr pvk_geometry, physx.PxMaterialPtr* pvk_materials, ushort pvk_materialCount, bool pvk_isExclusive, PxShapeFlagsPtr pvk_shapeFlags);
        
        public physx.PxShapePtr createShape(physx.PxGeometryPtr geometry, physx.PxMaterialPtr* materials, ushort materialCount, bool isExclusive, PxShapeFlagsPtr shapeFlags) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxGeometryPtr pvk_in_geometry = geometry;
            physx.PxMaterialPtr* pvk_in_materials = materials;
            ushort pvk_in_materialCount = materialCount;
            bool pvk_in_isExclusive = isExclusive;
            PxShapeFlagsPtr pvk_in_shapeFlags = shapeFlags;
            return physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_ushort_bool_PxShapeFlagsPtr_(pvk_in_this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount, pvk_in_isExclusive, pvk_in_shapeFlags);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxShapePtr physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_ushort_bool_(physx.PxPhysicsPtr pvk_this, physx.PxGeometryPtr pvk_geometry, physx.PxMaterialPtr* pvk_materials, ushort pvk_materialCount, bool pvk_isExclusive);
        
        public physx.PxShapePtr createShape(physx.PxGeometryPtr geometry, physx.PxMaterialPtr* materials, ushort materialCount, bool isExclusive=false) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxGeometryPtr pvk_in_geometry = geometry;
            physx.PxMaterialPtr* pvk_in_materials = materials;
            ushort pvk_in_materialCount = materialCount;
            bool pvk_in_isExclusive = isExclusive;
            return physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_ushort_bool_(pvk_in_this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount, pvk_in_isExclusive);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxShapePtr physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_ushort_(physx.PxPhysicsPtr pvk_this, physx.PxGeometryPtr pvk_geometry, physx.PxMaterialPtr* pvk_materials, ushort pvk_materialCount);
        
        public physx.PxShapePtr createShape(physx.PxGeometryPtr geometry, physx.PxMaterialPtr* materials, ushort materialCount) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxGeometryPtr pvk_in_geometry = geometry;
            physx.PxMaterialPtr* pvk_in_materials = materials;
            ushort pvk_in_materialCount = materialCount;
            return physx_PxShapePtr_physx_PxPhysics_createShape_physx_PxGeometryPtr_physx_PxMaterialPtr_ushort_(pvk_in_this, pvk_in_geometry, pvk_in_materials, pvk_in_materialCount);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getNbShapes(physx.PxPhysicsPtr pvk_this);
        
        public uint getNbShapes() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return uint_const_physx_PxPhysics_getNbShapes(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getShapes_physx_PxShapePtr_uint_uint_(physx.PxPhysicsPtr pvk_this, physx.PxShapePtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getShapes(physx.PxShapePtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxShapePtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxPhysics_getShapes_physx_PxShapePtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getShapes_physx_PxShapePtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxShapePtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getShapes(physx.PxShapePtr* userBuffer, uint bufferSize) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxShapePtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxPhysics_getShapes_physx_PxShapePtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxConstraintPtr physx_PxConstraintPtr_physx_PxPhysics_createConstraint_physx_PxRigidActorPtr_physx_PxRigidActorPtr_physx_PxConstraintConnectorPtr_physx_PxConstraintShaderTablePtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxRigidActorPtr pvk_actor0, physx.PxRigidActorPtr pvk_actor1, physx.PxConstraintConnectorPtr pvk_connector, physx.PxConstraintShaderTablePtr pvk_shaders, uint pvk_dataSize);
        
        public physx.PxConstraintPtr createConstraint(physx.PxRigidActorPtr actor0, physx.PxRigidActorPtr actor1, physx.PxConstraintConnectorPtr connector, physx.PxConstraintShaderTablePtr shaders, uint dataSize) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxRigidActorPtr pvk_in_actor0 = actor0;
            physx.PxRigidActorPtr pvk_in_actor1 = actor1;
            physx.PxConstraintConnectorPtr pvk_in_connector = connector;
            physx.PxConstraintShaderTablePtr pvk_in_shaders = shaders;
            uint pvk_in_dataSize = dataSize;
            return physx_PxConstraintPtr_physx_PxPhysics_createConstraint_physx_PxRigidActorPtr_physx_PxRigidActorPtr_physx_PxConstraintConnectorPtr_physx_PxConstraintShaderTablePtr_uint_(pvk_in_this, pvk_in_actor0, pvk_in_actor1, pvk_in_connector, pvk_in_shaders, pvk_in_dataSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxArticulationPtr physx_PxArticulationPtr_physx_PxPhysics_createArticulation(physx.PxPhysicsPtr pvk_this);
        
        public physx.PxArticulationPtr createArticulation() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return physx_PxArticulationPtr_physx_PxPhysics_createArticulation(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxArticulationReducedCoordinatePtr physx_PxArticulationReducedCoordinatePtr_physx_PxPhysics_createArticulationReducedCoordinate(physx.PxPhysicsPtr pvk_this);
        
        public physx.PxArticulationReducedCoordinatePtr createArticulationReducedCoordinate() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return physx_PxArticulationReducedCoordinatePtr_physx_PxPhysics_createArticulationReducedCoordinate(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxMaterialPtr physx_PxMaterialPtr_physx_PxPhysics_createMaterial_float_float_float_(physx.PxPhysicsPtr pvk_this, float pvk_staticFriction, float pvk_dynamicFriction, float pvk_restitution);
        
        public physx.PxMaterialPtr createMaterial(float staticFriction, float dynamicFriction, float restitution) {
            physx.PxPhysicsPtr pvk_in_this = this;
            float pvk_in_staticFriction = staticFriction;
            float pvk_in_dynamicFriction = dynamicFriction;
            float pvk_in_restitution = restitution;
            return physx_PxMaterialPtr_physx_PxPhysics_createMaterial_float_float_float_(pvk_in_this, pvk_in_staticFriction, pvk_in_dynamicFriction, pvk_in_restitution);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getNbMaterials(physx.PxPhysicsPtr pvk_this);
        
        public uint getNbMaterials() {
            physx.PxPhysicsPtr pvk_in_this = this;
            return uint_const_physx_PxPhysics_getNbMaterials(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getMaterials_physx_PxMaterialPtr_uint_uint_(physx.PxPhysicsPtr pvk_this, physx.PxMaterialPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getMaterials(physx.PxMaterialPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxMaterialPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxPhysics_getMaterials_physx_PxMaterialPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxPhysics_getMaterials_physx_PxMaterialPtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxMaterialPtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getMaterials(physx.PxMaterialPtr* userBuffer, uint bufferSize) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxMaterialPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxPhysics_getMaterials_physx_PxMaterialPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxPhysics_registerDeletionListener_physx_PxDeletionListenerPtr_PxDeletionEventFlagsPtr_bool_(physx.PxPhysicsPtr pvk_this, physx.PxDeletionListenerPtr pvk_observer, PxDeletionEventFlagsPtr pvk_deletionEvents, bool pvk_restrictedObjectSet);
        
        public void registerDeletionListener(physx.PxDeletionListenerPtr observer, PxDeletionEventFlagsPtr deletionEvents, bool restrictedObjectSet=false) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxDeletionListenerPtr pvk_in_observer = observer;
            PxDeletionEventFlagsPtr pvk_in_deletionEvents = deletionEvents;
            bool pvk_in_restrictedObjectSet = restrictedObjectSet;
            void_physx_PxPhysics_registerDeletionListener_physx_PxDeletionListenerPtr_PxDeletionEventFlagsPtr_bool_(pvk_in_this, pvk_in_observer, pvk_in_deletionEvents, pvk_in_restrictedObjectSet);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxPhysics_registerDeletionListener_physx_PxDeletionListenerPtr_PxDeletionEventFlagsPtr_(physx.PxPhysicsPtr pvk_this, physx.PxDeletionListenerPtr pvk_observer, PxDeletionEventFlagsPtr pvk_deletionEvents);
        
        public void registerDeletionListener(physx.PxDeletionListenerPtr observer, PxDeletionEventFlagsPtr deletionEvents) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxDeletionListenerPtr pvk_in_observer = observer;
            PxDeletionEventFlagsPtr pvk_in_deletionEvents = deletionEvents;
            void_physx_PxPhysics_registerDeletionListener_physx_PxDeletionListenerPtr_PxDeletionEventFlagsPtr_(pvk_in_this, pvk_in_observer, pvk_in_deletionEvents);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxPhysics_unregisterDeletionListener_physx_PxDeletionListenerPtr_(physx.PxPhysicsPtr pvk_this, physx.PxDeletionListenerPtr pvk_observer);
        
        public void unregisterDeletionListener(physx.PxDeletionListenerPtr observer) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxDeletionListenerPtr pvk_in_observer = observer;
            void_physx_PxPhysics_unregisterDeletionListener_physx_PxDeletionListenerPtr_(pvk_in_this, pvk_in_observer);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxPhysics_registerDeletionListenerObjects_physx_PxDeletionListenerPtr_physx_PxBasePtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxDeletionListenerPtr pvk_observer, physx.PxBasePtr* pvk_observables, uint pvk_observableCount);
        
        public void registerDeletionListenerObjects(physx.PxDeletionListenerPtr observer, physx.PxBasePtr* observables, uint observableCount) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxDeletionListenerPtr pvk_in_observer = observer;
            physx.PxBasePtr* pvk_in_observables = observables;
            uint pvk_in_observableCount = observableCount;
            void_physx_PxPhysics_registerDeletionListenerObjects_physx_PxDeletionListenerPtr_physx_PxBasePtr_uint_(pvk_in_this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxPhysics_unregisterDeletionListenerObjects_physx_PxDeletionListenerPtr_physx_PxBasePtr_uint_(physx.PxPhysicsPtr pvk_this, physx.PxDeletionListenerPtr pvk_observer, physx.PxBasePtr* pvk_observables, uint pvk_observableCount);
        
        public void unregisterDeletionListenerObjects(physx.PxDeletionListenerPtr observer, physx.PxBasePtr* observables, uint observableCount) {
            physx.PxPhysicsPtr pvk_in_this = this;
            physx.PxDeletionListenerPtr pvk_in_observer = observer;
            physx.PxBasePtr* pvk_in_observables = observables;
            uint pvk_in_observableCount = observableCount;
            void_physx_PxPhysics_unregisterDeletionListenerObjects_physx_PxDeletionListenerPtr_physx_PxBasePtr_uint_(pvk_in_this, pvk_in_observer, pvk_in_observables, pvk_in_observableCount);
        }
    }
    
}

public static unsafe partial class PxPhysics{    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void void_PxRegisterArticulations_physx_PxPhysicsPtr_(physx.PxPhysicsPtr pvk_physics);
    
    public static void PxRegisterArticulations(physx.PxPhysicsPtr physics) {
        physx.PxPhysicsPtr pvk_in_physics = physics;
        void_PxRegisterArticulations_physx_PxPhysicsPtr_(pvk_in_physics);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void void_PxRegisterArticulationsReducedCoordinate_physx_PxPhysicsPtr_(physx.PxPhysicsPtr pvk_physics);
    
    public static void PxRegisterArticulationsReducedCoordinate(physx.PxPhysicsPtr physics) {
        physx.PxPhysicsPtr pvk_in_physics = physics;
        void_PxRegisterArticulationsReducedCoordinate_physx_PxPhysicsPtr_(pvk_in_physics);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void void_PxRegisterHeightFields_physx_PxPhysicsPtr_(physx.PxPhysicsPtr pvk_physics);
    
    public static void PxRegisterHeightFields(physx.PxPhysicsPtr physics) {
        physx.PxPhysicsPtr pvk_in_physics = physics;
        void_PxRegisterHeightFields_physx_PxPhysicsPtr_(pvk_in_physics);
    }
    
    //////Type PxPvdPtr explicitly forbidden by user configuration
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxPhysicsPtr physx_PxPhysicsPtr_PxCreateBasePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_bool_(uint pvk_version, physx.PxFoundationPtr pvk_foundation, physx.PxTolerancesScalePtr pvk_scale, bool pvk_trackOutstandingAllocations);
    
    public static physx.PxPhysicsPtr PxCreateBasePhysics(uint version, physx.PxFoundationPtr foundation, physx.PxTolerancesScalePtr scale, bool trackOutstandingAllocations=false) {
        uint pvk_in_version = version;
        physx.PxFoundationPtr pvk_in_foundation = foundation;
        physx.PxTolerancesScalePtr pvk_in_scale = scale;
        bool pvk_in_trackOutstandingAllocations = trackOutstandingAllocations;
        return physx_PxPhysicsPtr_PxCreateBasePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_bool_(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxPhysicsPtr physx_PxPhysicsPtr_PxCreateBasePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_(uint pvk_version, physx.PxFoundationPtr pvk_foundation, physx.PxTolerancesScalePtr pvk_scale);
    
    public static physx.PxPhysicsPtr PxCreateBasePhysics(uint version, physx.PxFoundationPtr foundation, physx.PxTolerancesScalePtr scale) {
        uint pvk_in_version = version;
        physx.PxFoundationPtr pvk_in_foundation = foundation;
        physx.PxTolerancesScalePtr pvk_in_scale = scale;
        return physx_PxPhysicsPtr_PxCreateBasePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_(pvk_in_version, pvk_in_foundation, pvk_in_scale);
    }
    
    //////Type PxPvdPtr explicitly forbidden by user configuration
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxPhysicsPtr physx_PxPhysicsPtr_PxCreatePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_bool_(uint pvk_version, physx.PxFoundationPtr pvk_foundation, physx.PxTolerancesScalePtr pvk_scale, bool pvk_trackOutstandingAllocations);
    
    public static physx.PxPhysicsPtr PxCreatePhysics(uint version, physx.PxFoundationPtr foundation, physx.PxTolerancesScalePtr scale, bool trackOutstandingAllocations=false) {
        uint pvk_in_version = version;
        physx.PxFoundationPtr pvk_in_foundation = foundation;
        physx.PxTolerancesScalePtr pvk_in_scale = scale;
        bool pvk_in_trackOutstandingAllocations = trackOutstandingAllocations;
        return physx_PxPhysicsPtr_PxCreatePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_bool_(pvk_in_version, pvk_in_foundation, pvk_in_scale, pvk_in_trackOutstandingAllocations);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxPhysicsPtr physx_PxPhysicsPtr_PxCreatePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_(uint pvk_version, physx.PxFoundationPtr pvk_foundation, physx.PxTolerancesScalePtr pvk_scale);
    
    public static physx.PxPhysicsPtr PxCreatePhysics(uint version, physx.PxFoundationPtr foundation, physx.PxTolerancesScalePtr scale) {
        uint pvk_in_version = version;
        physx.PxFoundationPtr pvk_in_foundation = foundation;
        physx.PxTolerancesScalePtr pvk_in_scale = scale;
        return physx_PxPhysicsPtr_PxCreatePhysics_uint_physx_PxFoundationPtr_physx_PxTolerancesScalePtr_(pvk_in_version, pvk_in_foundation, pvk_in_scale);
    }
    
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern physx.PxPhysicsPtr physx_PxPhysicsPtr_PxGetPhysics();
    
    public static physx.PxPhysicsPtr PxGetPhysics() {
        return physx_PxPhysicsPtr_PxGetPhysics();
    }
    
}
