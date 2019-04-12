// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxShape
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    // physx::operator| [static PxShapeFlagsPtr Pipe_New(physx.PxShapeFlagEnum a, physx.PxShapeFlagEnum b)] will be bound as member operator
    
    // physx::operator& [static PxShapeFlagsPtr Amp_New(physx.PxShapeFlagEnum a, physx.PxShapeFlagEnum b)] will be bound as member operator
    
    // physx::operator~ [static PxShapeFlagsPtr Tilde_New(physx.PxShapeFlagEnum a)] will be bound as member operator
    
    public enum PxShapeFlagEnum : int {
        eSIMULATION_SHAPE = 1,  // eSIMULATION_SHAPE = (1<<0)
        eSCENE_QUERY_SHAPE = 2, // eSCENE_QUERY_SHAPE = (1<<1)
        eTRIGGER_SHAPE = 4,     // eTRIGGER_SHAPE = (1<<2)
        eVISUALIZATION = 8,     // eVISUALIZATION = (1<<3)
    }
    
    public unsafe partial struct PxShapePtr : physx.PxBasePtr.IPxBasePtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr PxShape_GET_userData(PxShapePtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxShape_SET_userData(PxShapePtr cls, IntPtr value);
        
        public IntPtr userData {
            get => PxShape_GET_userData(this);
            set => PxShape_SET_userData(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_release(physx.PxShapePtr pvk_this);
        
        public void release() {
            physx.PxShapePtr pvk_in_this = this;
            void_physx_PxShape_release(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxShape_getReferenceCount(physx.PxShapePtr pvk_this);
        
        public uint getReferenceCount() {
            physx.PxShapePtr pvk_in_this = this;
            return uint_const_physx_PxShape_getReferenceCount(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_acquireReference(physx.PxShapePtr pvk_this);
        
        public void acquireReference() {
            physx.PxShapePtr pvk_in_this = this;
            void_physx_PxShape_acquireReference(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxGeometryTypeEnum physx_PxGeometryTypeEnum_const_physx_PxShape_getGeometryType(physx.PxShapePtr pvk_this);
        
        public physx.PxGeometryTypeEnum getGeometryType() {
            physx.PxShapePtr pvk_in_this = this;
            return physx_PxGeometryTypeEnum_const_physx_PxShape_getGeometryType(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setGeometry_physx_PxGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxGeometryPtr pvk_geometry);
        
        public void setGeometry(physx.PxGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxGeometryPtr pvk_in_geometry = geometry;
            void_physx_PxShape_setGeometry_physx_PxGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxGeometryHolderPtr physx_PxGeometryHolderPtr_const_physx_PxShape_getGeometry(physx.PxShapePtr pvk_this);
        
        public physx.PxGeometryHolderPtr getGeometry_New() {
            physx.PxShapePtr pvk_in_this = this;
            return physx_PxGeometryHolderPtr_const_physx_PxShape_getGeometry(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_getBoxGeometry_physx_PxBoxGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxBoxGeometryPtr pvk_geometry);
        
        public bool getBoxGeometry(physx.PxBoxGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxBoxGeometryPtr pvk_in_geometry = geometry;
            return bool_const_physx_PxShape_getBoxGeometry_physx_PxBoxGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_getSphereGeometry_physx_PxSphereGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxSphereGeometryPtr pvk_geometry);
        
        public bool getSphereGeometry(physx.PxSphereGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxSphereGeometryPtr pvk_in_geometry = geometry;
            return bool_const_physx_PxShape_getSphereGeometry_physx_PxSphereGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_getCapsuleGeometry_physx_PxCapsuleGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxCapsuleGeometryPtr pvk_geometry);
        
        public bool getCapsuleGeometry(physx.PxCapsuleGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxCapsuleGeometryPtr pvk_in_geometry = geometry;
            return bool_const_physx_PxShape_getCapsuleGeometry_physx_PxCapsuleGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_getPlaneGeometry_physx_PxPlaneGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxPlaneGeometryPtr pvk_geometry);
        
        public bool getPlaneGeometry(physx.PxPlaneGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxPlaneGeometryPtr pvk_in_geometry = geometry;
            return bool_const_physx_PxShape_getPlaneGeometry_physx_PxPlaneGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_getConvexMeshGeometry_physx_PxConvexMeshGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxConvexMeshGeometryPtr pvk_geometry);
        
        public bool getConvexMeshGeometry(physx.PxConvexMeshGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxConvexMeshGeometryPtr pvk_in_geometry = geometry;
            return bool_const_physx_PxShape_getConvexMeshGeometry_physx_PxConvexMeshGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_getTriangleMeshGeometry_physx_PxTriangleMeshGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxTriangleMeshGeometryPtr pvk_geometry);
        
        public bool getTriangleMeshGeometry(physx.PxTriangleMeshGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxTriangleMeshGeometryPtr pvk_in_geometry = geometry;
            return bool_const_physx_PxShape_getTriangleMeshGeometry_physx_PxTriangleMeshGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_getHeightFieldGeometry_physx_PxHeightFieldGeometryPtr_(physx.PxShapePtr pvk_this, physx.PxHeightFieldGeometryPtr pvk_geometry);
        
        public bool getHeightFieldGeometry(physx.PxHeightFieldGeometryPtr geometry) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxHeightFieldGeometryPtr pvk_in_geometry = geometry;
            return bool_const_physx_PxShape_getHeightFieldGeometry_physx_PxHeightFieldGeometryPtr_(pvk_in_this, pvk_in_geometry);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxRigidActorPtr physx_PxRigidActorPtr_const_physx_PxShape_getActor(physx.PxShapePtr pvk_this);
        
        public physx.PxRigidActorPtr getActor() {
            physx.PxShapePtr pvk_in_this = this;
            return physx_PxRigidActorPtr_const_physx_PxShape_getActor(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setLocalPose_physx_PxTransformPtr_(physx.PxShapePtr pvk_this, physx.PxTransformPtr pvk_pose);
        
        public void setLocalPose(physx.PxTransformPtr pose) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxTransformPtr pvk_in_pose = pose;
            void_physx_PxShape_setLocalPose_physx_PxTransformPtr_(pvk_in_this, pvk_in_pose);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxTransformPtr physx_PxTransformPtr_const_physx_PxShape_getLocalPose(physx.PxShapePtr pvk_this);
        
        public physx.PxTransformPtr getLocalPose_New() {
            physx.PxShapePtr pvk_in_this = this;
            return physx_PxTransformPtr_const_physx_PxShape_getLocalPose(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setSimulationFilterData_physx_PxFilterDataPtr_(physx.PxShapePtr pvk_this, physx.PxFilterDataPtr pvk_data);
        
        public void setSimulationFilterData(physx.PxFilterDataPtr data) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxFilterDataPtr pvk_in_data = data;
            void_physx_PxShape_setSimulationFilterData_physx_PxFilterDataPtr_(pvk_in_this, pvk_in_data);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxFilterDataPtr physx_PxFilterDataPtr_const_physx_PxShape_getSimulationFilterData(physx.PxShapePtr pvk_this);
        
        public physx.PxFilterDataPtr getSimulationFilterData_New() {
            physx.PxShapePtr pvk_in_this = this;
            return physx_PxFilterDataPtr_const_physx_PxShape_getSimulationFilterData(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setQueryFilterData_physx_PxFilterDataPtr_(physx.PxShapePtr pvk_this, physx.PxFilterDataPtr pvk_data);
        
        public void setQueryFilterData(physx.PxFilterDataPtr data) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxFilterDataPtr pvk_in_data = data;
            void_physx_PxShape_setQueryFilterData_physx_PxFilterDataPtr_(pvk_in_this, pvk_in_data);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxFilterDataPtr physx_PxFilterDataPtr_const_physx_PxShape_getQueryFilterData(physx.PxShapePtr pvk_this);
        
        public physx.PxFilterDataPtr getQueryFilterData_New() {
            physx.PxShapePtr pvk_in_this = this;
            return physx_PxFilterDataPtr_const_physx_PxShape_getQueryFilterData(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setMaterials_physx_PxMaterialPtr_ushort_(physx.PxShapePtr pvk_this, physx.PxMaterialPtr* pvk_materials, ushort pvk_materialCount);
        
        public void setMaterials(physx.PxMaterialPtr* materials, ushort materialCount) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxMaterialPtr* pvk_in_materials = materials;
            ushort pvk_in_materialCount = materialCount;
            void_physx_PxShape_setMaterials_physx_PxMaterialPtr_ushort_(pvk_in_this, pvk_in_materials, pvk_in_materialCount);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern ushort ushort_const_physx_PxShape_getNbMaterials(physx.PxShapePtr pvk_this);
        
        public ushort getNbMaterials() {
            physx.PxShapePtr pvk_in_this = this;
            return ushort_const_physx_PxShape_getNbMaterials(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxShape_getMaterials_physx_PxMaterialPtr_uint_uint_(physx.PxShapePtr pvk_this, physx.PxMaterialPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);
        
        public uint getMaterials(physx.PxMaterialPtr* userBuffer, uint bufferSize, uint startIndex=0) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxMaterialPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            uint pvk_in_startIndex = startIndex;
            return uint_const_physx_PxShape_getMaterials_physx_PxMaterialPtr_uint_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxShape_getMaterials_physx_PxMaterialPtr_uint_(physx.PxShapePtr pvk_this, physx.PxMaterialPtr* pvk_userBuffer, uint pvk_bufferSize);
        
        public uint getMaterials(physx.PxMaterialPtr* userBuffer, uint bufferSize) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxMaterialPtr* pvk_in_userBuffer = userBuffer;
            uint pvk_in_bufferSize = bufferSize;
            return uint_const_physx_PxShape_getMaterials_physx_PxMaterialPtr_uint_(pvk_in_this, pvk_in_userBuffer, pvk_in_bufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxMaterialPtr physx_PxMaterialPtr_const_physx_PxShape_getMaterialFromInternalFaceIndex_uint_(physx.PxShapePtr pvk_this, uint pvk_faceIndex);
        
        public physx.PxMaterialPtr getMaterialFromInternalFaceIndex(uint faceIndex) {
            physx.PxShapePtr pvk_in_this = this;
            uint pvk_in_faceIndex = faceIndex;
            return physx_PxMaterialPtr_const_physx_PxShape_getMaterialFromInternalFaceIndex_uint_(pvk_in_this, pvk_in_faceIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setContactOffset_float_(physx.PxShapePtr pvk_this, float pvk_contactOffset);
        
        public void setContactOffset(float contactOffset) {
            physx.PxShapePtr pvk_in_this = this;
            float pvk_in_contactOffset = contactOffset;
            void_physx_PxShape_setContactOffset_float_(pvk_in_this, pvk_in_contactOffset);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxShape_getContactOffset(physx.PxShapePtr pvk_this);
        
        public float getContactOffset() {
            physx.PxShapePtr pvk_in_this = this;
            return float_const_physx_PxShape_getContactOffset(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setRestOffset_float_(physx.PxShapePtr pvk_this, float pvk_restOffset);
        
        public void setRestOffset(float restOffset) {
            physx.PxShapePtr pvk_in_this = this;
            float pvk_in_restOffset = restOffset;
            void_physx_PxShape_setRestOffset_float_(pvk_in_this, pvk_in_restOffset);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxShape_getRestOffset(physx.PxShapePtr pvk_this);
        
        public float getRestOffset() {
            physx.PxShapePtr pvk_in_this = this;
            return float_const_physx_PxShape_getRestOffset(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setTorsionalPatchRadius_float_(physx.PxShapePtr pvk_this, float pvk_radius);
        
        public void setTorsionalPatchRadius(float radius) {
            physx.PxShapePtr pvk_in_this = this;
            float pvk_in_radius = radius;
            void_physx_PxShape_setTorsionalPatchRadius_float_(pvk_in_this, pvk_in_radius);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxShape_getTorsionalPatchRadius(physx.PxShapePtr pvk_this);
        
        public float getTorsionalPatchRadius() {
            physx.PxShapePtr pvk_in_this = this;
            return float_const_physx_PxShape_getTorsionalPatchRadius(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setMinTorsionalPatchRadius_float_(physx.PxShapePtr pvk_this, float pvk_radius);
        
        public void setMinTorsionalPatchRadius(float radius) {
            physx.PxShapePtr pvk_in_this = this;
            float pvk_in_radius = radius;
            void_physx_PxShape_setMinTorsionalPatchRadius_float_(pvk_in_this, pvk_in_radius);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxShape_getMinTorsionalPatchRadius(physx.PxShapePtr pvk_this);
        
        public float getMinTorsionalPatchRadius() {
            physx.PxShapePtr pvk_in_this = this;
            return float_const_physx_PxShape_getMinTorsionalPatchRadius(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setFlag_physx_PxShapeFlagEnum_bool_(physx.PxShapePtr pvk_this, physx.PxShapeFlagEnum pvk_flag, bool pvk_value);
        
        public void setFlag(physx.PxShapeFlagEnum flag, bool value) {
            physx.PxShapePtr pvk_in_this = this;
            physx.PxShapeFlagEnum pvk_in_flag = flag;
            bool pvk_in_value = value;
            void_physx_PxShape_setFlag_physx_PxShapeFlagEnum_bool_(pvk_in_this, pvk_in_flag, pvk_in_value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setFlags_PxShapeFlagsPtr_(physx.PxShapePtr pvk_this, PxShapeFlagsPtr pvk_inFlags);
        
        public void setFlags(PxShapeFlagsPtr inFlags) {
            physx.PxShapePtr pvk_in_this = this;
            PxShapeFlagsPtr pvk_in_inFlags = inFlags;
            void_physx_PxShape_setFlags_PxShapeFlagsPtr_(pvk_in_this, pvk_in_inFlags);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern PxShapeFlagsPtr PxShapeFlagsPtr_const_physx_PxShape_getFlags(physx.PxShapePtr pvk_this);
        
        public PxShapeFlagsPtr getFlags_New() {
            physx.PxShapePtr pvk_in_this = this;
            return PxShapeFlagsPtr_const_physx_PxShape_getFlags(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxShape_isExclusive(physx.PxShapePtr pvk_this);
        
        public bool isExclusive() {
            physx.PxShapePtr pvk_in_this = this;
            return bool_const_physx_PxShape_isExclusive(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxShape_setName_string_(physx.PxShapePtr pvk_this, string pvk_name);
        
        public void setName(string name) {
            physx.PxShapePtr pvk_in_this = this;
            string pvk_in_name = name;
            void_physx_PxShape_setName_string_(pvk_in_this, pvk_in_name);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern string string_const_physx_PxShape_getName(physx.PxShapePtr pvk_this);
        
        public string getName() {
            physx.PxShapePtr pvk_in_this = this;
            return string_const_physx_PxShape_getName(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern string string_const_physx_PxShape_getConcreteTypeName(physx.PxShapePtr pvk_this);
        
        public string getConcreteTypeName() {
            physx.PxShapePtr pvk_in_this = this;
            return string_const_physx_PxShape_getConcreteTypeName(pvk_in_this);
        }
        public static implicit operator physx.PxBasePtr(PxShapePtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxShapePtr(physx.PxBasePtr obj) => *(PxShapePtr*)&obj;
    
        // PIPING
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }
    
}