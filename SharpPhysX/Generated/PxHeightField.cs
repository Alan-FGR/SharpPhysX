// Generated by minBND 5.1.81.43 - © github.com/Alan-FGR
//Unit PxHeightField
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    public unsafe partial struct PxHeightFieldPtr : physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxHeightField_release(physx.PxHeightFieldPtr pvk_this);
        
        public void release() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            void_physx_PxHeightField_release(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxHeightField_saveCells_IntPtr_uint_(physx.PxHeightFieldPtr pvk_this, IntPtr pvk_destBuffer, uint pvk_destBufferSize);
        
        public uint saveCells(IntPtr destBuffer, uint destBufferSize) {
            physx.PxHeightFieldPtr pvk_in_this = this;
            IntPtr pvk_in_destBuffer = destBuffer;
            uint pvk_in_destBufferSize = destBufferSize;
            return uint_const_physx_PxHeightField_saveCells_IntPtr_uint_(pvk_in_this, pvk_in_destBuffer, pvk_in_destBufferSize);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_physx_PxHeightField_modifySamples_int_int_physx_PxHeightFieldDescPtr_bool_(physx.PxHeightFieldPtr pvk_this, int pvk_startCol, int pvk_startRow, physx.PxHeightFieldDescPtr pvk_subfieldDesc, bool pvk_shrinkBounds);
        
        public bool modifySamples(int startCol, int startRow, physx.PxHeightFieldDescPtr subfieldDesc, bool shrinkBounds=false) {
            physx.PxHeightFieldPtr pvk_in_this = this;
            int pvk_in_startCol = startCol;
            int pvk_in_startRow = startRow;
            physx.PxHeightFieldDescPtr pvk_in_subfieldDesc = subfieldDesc;
            bool pvk_in_shrinkBounds = shrinkBounds;
            return bool_physx_PxHeightField_modifySamples_int_int_physx_PxHeightFieldDescPtr_bool_(pvk_in_this, pvk_in_startCol, pvk_in_startRow, pvk_in_subfieldDesc, pvk_in_shrinkBounds);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxHeightField_getNbRows(physx.PxHeightFieldPtr pvk_this);
        
        public uint getNbRows() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return uint_const_physx_PxHeightField_getNbRows(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxHeightField_getNbColumns(physx.PxHeightFieldPtr pvk_this);
        
        public uint getNbColumns() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return uint_const_physx_PxHeightField_getNbColumns(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxHeightFieldFormatEnum physx_PxHeightFieldFormatEnum_const_physx_PxHeightField_getFormat(physx.PxHeightFieldPtr pvk_this);
        
        public physx.PxHeightFieldFormatEnum getFormat() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return physx_PxHeightFieldFormatEnum_const_physx_PxHeightField_getFormat(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxHeightField_getSampleStride(physx.PxHeightFieldPtr pvk_this);
        
        public uint getSampleStride() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return uint_const_physx_PxHeightField_getSampleStride(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxHeightField_getConvexEdgeThreshold(physx.PxHeightFieldPtr pvk_this);
        
        public float getConvexEdgeThreshold() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return float_const_physx_PxHeightField_getConvexEdgeThreshold(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern PxHeightFieldFlagsPtr PxHeightFieldFlagsPtr_const_physx_PxHeightField_getFlags(physx.PxHeightFieldPtr pvk_this);
        
        public PxHeightFieldFlagsPtr getFlags_New() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return PxHeightFieldFlagsPtr_const_physx_PxHeightField_getFlags(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float float_const_physx_PxHeightField_getHeight_float_float_(physx.PxHeightFieldPtr pvk_this, float pvk_x, float pvk_z);
        
        public float getHeight(float x, float z) {
            physx.PxHeightFieldPtr pvk_in_this = this;
            float pvk_in_x = x;
            float pvk_in_z = z;
            return float_const_physx_PxHeightField_getHeight_float_float_(pvk_in_this, pvk_in_x, pvk_in_z);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxHeightField_getReferenceCount(physx.PxHeightFieldPtr pvk_this);
        
        public uint getReferenceCount() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return uint_const_physx_PxHeightField_getReferenceCount(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxHeightField_acquireReference(physx.PxHeightFieldPtr pvk_this);
        
        public void acquireReference() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            void_physx_PxHeightField_acquireReference(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern ushort ushort_const_physx_PxHeightField_getTriangleMaterialIndex_uint_(physx.PxHeightFieldPtr pvk_this, uint pvk_triangleIndex);
        
        public ushort getTriangleMaterialIndex(uint triangleIndex) {
            physx.PxHeightFieldPtr pvk_in_this = this;
            uint pvk_in_triangleIndex = triangleIndex;
            return ushort_const_physx_PxHeightField_getTriangleMaterialIndex_uint_(pvk_in_this, pvk_in_triangleIndex);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void physx_PxVec3_const_physx_PxHeightField_getTriangleNormal_uint_(physx.PxVec3* RetRef, physx.PxHeightFieldPtr pvk_this, uint pvk_triangleIndex);
        
        public physx.PxVec3 getTriangleNormal(uint triangleIndex) {
            physx.PxVec3 RetRef;
            physx.PxHeightFieldPtr pvk_in_this = this;
            uint pvk_in_triangleIndex = triangleIndex;
            physx_PxVec3_const_physx_PxHeightField_getTriangleNormal_uint_(&RetRef, pvk_in_this, pvk_in_triangleIndex);
            return RetRef;
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxHeightFieldSamplePtr physx_PxHeightFieldSamplePtr_const_physx_PxHeightField_getSample_uint_uint_(physx.PxHeightFieldPtr pvk_this, uint pvk_row, uint pvk_column);
        
        public physx.PxHeightFieldSamplePtr getSample(uint row, uint column) {
            physx.PxHeightFieldPtr pvk_in_this = this;
            uint pvk_in_row = row;
            uint pvk_in_column = column;
            return physx_PxHeightFieldSamplePtr_const_physx_PxHeightField_getSample_uint_uint_(pvk_in_this, pvk_in_row, pvk_in_column);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint uint_const_physx_PxHeightField_getTimestamp(physx.PxHeightFieldPtr pvk_this);
        
        public uint getTimestamp() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return uint_const_physx_PxHeightField_getTimestamp(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern string string_const_physx_PxHeightField_getConcreteTypeName(physx.PxHeightFieldPtr pvk_this);
        
        public string getConcreteTypeName() {
            physx.PxHeightFieldPtr pvk_in_this = this;
            return string_const_physx_PxHeightField_getConcreteTypeName(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_physx_PxHeightField_modifySamples_int_int_physx_PxHeightFieldDescPtr_(physx.PxHeightFieldPtr pvk_this, int pvk_startCol, int pvk_startRow, physx.PxHeightFieldDescPtr pvk_subfieldDesc);
        
        public bool modifySamples(int startCol, int startRow, physx.PxHeightFieldDescPtr subfieldDesc) {
            physx.PxHeightFieldPtr pvk_in_this = this;
            int pvk_in_startCol = startCol;
            int pvk_in_startRow = startRow;
            physx.PxHeightFieldDescPtr pvk_in_subfieldDesc = subfieldDesc;
            return bool_physx_PxHeightField_modifySamples_int_int_physx_PxHeightFieldDescPtr_(pvk_in_this, pvk_in_startCol, pvk_in_startRow, pvk_in_subfieldDesc);
        }
        public static implicit operator physx.PxBasePtr(PxHeightFieldPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxHeightFieldPtr(physx.PxBasePtr obj) => *(PxHeightFieldPtr*)&obj;
    
        // PIPING
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }
    
}
