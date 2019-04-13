// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//Unit PxHeightFieldGeometry
using System;
using System.Runtime.InteropServices;

//DEBUG: NamespaceNode physx - 40-139
public static unsafe partial class physx {
    //DEBUG: ClassNode physx::PxHeightFieldGeometry - 56-121
    //Bases: PxGeometryPtr
    //Interface use count: 0
    public unsafe partial struct PxHeightFieldGeometryPtr : physx.PxGeometryPtr.IPxGeometryPtr{
        private System.IntPtr nativePtr_;
        
    //DEBUG: NewerFreerNode physx::PxHeightFieldGeometry - 56-121
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxHeightFieldGeometryPtr(PxHeightFieldGeometryPtr ptr);
        
        public static void Free(PxHeightFieldGeometryPtr ptr){
            Freer_physx_PxHeightFieldGeometryPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxHeightFieldGeometryPtr(this);
        }
        
        //DEBUG: PtrStructCtorNode physx::PxHeightFieldGeometry::PxHeightFieldGeometry - 59-66
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxHeightFieldGeometryPtr Ctor_physx_PxHeightFieldGeometryPtr_();
        
        public static physx.PxHeightFieldGeometryPtr New() {
            //RET nat: physx.PxHeightFieldGeometryPtr, man: physx.PxHeightFieldGeometryPtr, stg: PtrStruct, ret: True
            return Ctor_physx_PxHeightFieldGeometryPtr_();
        }
        
        //DEBUG: PtrStructCtorNode physx::PxHeightFieldGeometry::PxHeightFieldGeometry - 68-80
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxHeightFieldGeometryPtr Ctor_physx_PxHeightFieldGeometryPtr_physx_PxHeightFieldPtr_PxMeshGeometryFlagsPtr_float_float_float(physx.PxHeightFieldPtr pvk_hf, PxMeshGeometryFlagsPtr pvk_flags, float pvk_heightScale_, float pvk_rowScale_, float pvk_columnScale_);
        
        public static physx.PxHeightFieldGeometryPtr New(physx.PxHeightFieldPtr hf, PxMeshGeometryFlagsPtr flags, float heightScale_, float rowScale_, float columnScale_) {
            //RET nat: physx.PxHeightFieldGeometryPtr, man: physx.PxHeightFieldGeometryPtr, stg: PtrStruct, ret: True
            //PAR nat: PxHeightFieldPtr, man: physx.PxHeightFieldPtr, stg: PtrStruct
            physx.PxHeightFieldPtr pvk_in_hf = hf;
            //PAR nat: PxMeshGeometryFlagsPtr, man: PxMeshGeometryFlagsPtr, stg: PtrStruct
            PxMeshGeometryFlagsPtr pvk_in_flags = flags;
            //PAR nat: float, man: float, stg: Value
            float pvk_in_heightScale_ = heightScale_;
            //PAR nat: float, man: float, stg: Value
            float pvk_in_rowScale_ = rowScale_;
            //PAR nat: float, man: float, stg: Value
            float pvk_in_columnScale_ = columnScale_;
            return Ctor_physx_PxHeightFieldGeometryPtr_physx_PxHeightFieldPtr_PxMeshGeometryFlagsPtr_float_float_float(pvk_in_hf, pvk_in_flags, pvk_in_heightScale_, pvk_in_rowScale_, pvk_in_columnScale_);
        }
        
        //DEBUG: PtrStructCtorNode physx::PxHeightFieldGeometry::PxHeightFieldGeometry - 56
        //ERRORS OCCURED IN physx::PxHeightFieldGeometry::PxHeightFieldGeometry
        //Implicit Function/Method
        
        //DEBUG: PtrStructCtorNode physx::PxHeightFieldGeometry::PxHeightFieldGeometry - 56
        //ERRORS OCCURED IN physx::PxHeightFieldGeometry::PxHeightFieldGeometry
        //Implicit Function/Method
        
        //DEBUG: GetterSetterNode physx::PxHeightFieldGeometry - 56-121
        //Field: heightField - 98-98
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxHeightFieldPtr PxHeightFieldGeometry_GET_heightField(PxHeightFieldGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxHeightFieldGeometry_SET_heightField(PxHeightFieldGeometryPtr cls, physx.PxHeightFieldPtr value);
        
        public physx.PxHeightFieldPtr heightField {
            get => PxHeightFieldGeometry_GET_heightField(this);
            set => PxHeightFieldGeometry_SET_heightField(this, value);
        }
        
        //DEBUG: GetterSetterNode physx::PxHeightFieldGeometry - 56-121
        //Field: heightScale - 103-103
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxHeightFieldGeometry_GET_heightScale(PxHeightFieldGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxHeightFieldGeometry_SET_heightScale(PxHeightFieldGeometryPtr cls, float value);
        
        public float heightScale {
            get => PxHeightFieldGeometry_GET_heightScale(this);
            set => PxHeightFieldGeometry_SET_heightScale(this, value);
        }
        
        //DEBUG: GetterSetterNode physx::PxHeightFieldGeometry - 56-121
        //Field: rowScale - 108-108
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxHeightFieldGeometry_GET_rowScale(PxHeightFieldGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxHeightFieldGeometry_SET_rowScale(PxHeightFieldGeometryPtr cls, float value);
        
        public float rowScale {
            get => PxHeightFieldGeometry_GET_rowScale(this);
            set => PxHeightFieldGeometry_SET_rowScale(this, value);
        }
        
        //DEBUG: GetterSetterNode physx::PxHeightFieldGeometry - 56-121
        //Field: columnScale - 113-113
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern float PxHeightFieldGeometry_GET_columnScale(PxHeightFieldGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxHeightFieldGeometry_SET_columnScale(PxHeightFieldGeometryPtr cls, float value);
        
        public float columnScale {
            get => PxHeightFieldGeometry_GET_columnScale(this);
            set => PxHeightFieldGeometry_SET_columnScale(this, value);
        }
        
        //DEBUG: GetterSetterNode physx::PxHeightFieldGeometry - 56-121
        //Field: heightFieldFlags - 118-118
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern PxMeshGeometryFlagsPtr PxHeightFieldGeometry_GET_heightFieldFlags(PxHeightFieldGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxHeightFieldGeometry_SET_heightFieldFlags(PxHeightFieldGeometryPtr cls, PxMeshGeometryFlagsPtr value);
        
        public PxMeshGeometryFlagsPtr heightFieldFlags {
            get => PxHeightFieldGeometry_GET_heightFieldFlags(this);
            set => PxHeightFieldGeometry_SET_heightFieldFlags(this, value);
        }
        
        //DEBUG: GetterSetterNode physx::PxHeightFieldGeometry - 56-121
        //Field: paddingFromFlags - 120-120
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern PxPadding_intVal3Ptr PxHeightFieldGeometry_GET_paddingFromFlags(PxHeightFieldGeometryPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxHeightFieldGeometry_SET_paddingFromFlags(PxHeightFieldGeometryPtr cls, PxPadding_intVal3Ptr value);
        
        public PxPadding_intVal3Ptr paddingFromFlags {
            get => PxHeightFieldGeometry_GET_paddingFromFlags(this);
            set => PxHeightFieldGeometry_SET_paddingFromFlags(this, value);
        }
        
        //DEBUG: MethodNode physx::PxHeightFieldGeometry::isValid - 92
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern bool bool_const_physx_PxHeightFieldGeometry_isValid(physx.PxHeightFieldGeometryPtr pvk_this);
        
        public bool isValid() {
            //RET nat: bool, man: bool, stg: Value, ret: True
            //PAR nat: PxHeightFieldGeometryPtr, man: physx.PxHeightFieldGeometryPtr, stg: PtrStruct
            physx.PxHeightFieldGeometryPtr pvk_in_this = this;
            return bool_const_physx_PxHeightFieldGeometry_isValid(pvk_in_this);
        }
        
        //DEBUG: MethodNode physx::PxHeightFieldGeometry::operator= - 56
        //ERRORS OCCURED IN physx::PxHeightFieldGeometry::operator=
        //Implicit Function/Method
        //Unbindable Operator: Equal
        
        //DEBUG: MethodNode physx::PxHeightFieldGeometry::operator= - 56
        //ERRORS OCCURED IN physx::PxHeightFieldGeometry::operator=
        //Implicit Function/Method
        //Unbindable Operator: Equal
        
        //DEBUG: MethodNode physx::PxHeightFieldGeometry::~PxHeightFieldGeometry - 56
        //ERRORS OCCURED IN physx::PxHeightFieldGeometry::~PxHeightFieldGeometry
        //Implicit Function/Method
        //Destructor
        public static implicit operator physx.PxGeometryPtr(PxHeightFieldGeometryPtr obj) => *(physx.PxGeometryPtr*)&obj;
        public static explicit operator PxHeightFieldGeometryPtr(physx.PxGeometryPtr obj) => *(PxHeightFieldGeometryPtr*)&obj;
    
        // PIPING
        public physx.PxGeometryTypeEnum getType(){return((physx.PxGeometryPtr)this).getType();}
    }
    
}
