// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {
    //Subclasses using this: 0

    public unsafe partial struct PxHeightFieldDescPtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxHeightFieldDesc physx::PxHeightFieldDesc L54-149

        //DBG: NewerFreerNode PxHeightFieldDesc physx::PxHeightFieldDesc L54-149
        public static void Free(physx.PxHeightFieldDescPtr ptr){
            Freer_physx_PxHeightFieldDescPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxHeightFieldDescPtr(this);
        }

        //DBG: PtrWrapperCtorNode physx::PxHeightFieldDesc::PxHeightFieldDesc L137
        //RET nat: PxHeightFieldDescPtr, man: physx.PxHeightFieldDescPtr, ret: True, kind: PtrStruct
        public static physx.PxHeightFieldDescPtr New() {
            return Ctor_PxHeightFieldDescPtr_();
        }

        //DBG: PtrWrapperCtorNode physx::PxHeightFieldDesc::PxHeightFieldDesc L54
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxHeightFieldDesc::PxHeightFieldDesc L54

        //DBG: PtrWrapperCtorNode physx::PxHeightFieldDesc::PxHeightFieldDesc L54
        //ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxHeightFieldDesc::PxHeightFieldDesc L54

        //DBG: Field: nbRows - 66-66
        public uint nbRows {
            get => PxHeightFieldDescPtr_GET_nbRows(this);
            set => PxHeightFieldDescPtr_SET_nbRows(this, value);
        }

        //DBG: Field: nbColumns - 76-76
        public uint nbColumns {
            get => PxHeightFieldDescPtr_GET_nbColumns(this);
            set => PxHeightFieldDescPtr_SET_nbColumns(this, value);
        }

        //DBG: Field: format - 87-87
        public physx.PxHeightFieldFormatEnum format {
            get => PxHeightFieldDescPtr_GET_format(this);
            set => PxHeightFieldDescPtr_SET_format(this, value);
        }

        //DBG: Field: samples - 107-107
        public physx.PxStridedDataPtr samples {
            get => PxHeightFieldDescPtr_GET_samples(this);
            set => PxHeightFieldDescPtr_SET_samples(this, value);
        }

        //DBG: Field: convexEdgeThreshold - 123-123
        public float convexEdgeThreshold {
            get => PxHeightFieldDescPtr_GET_convexEdgeThreshold(this);
            set => PxHeightFieldDescPtr_SET_convexEdgeThreshold(this, value);
        }

        //DBG: Field: flags - 132-132
        public physx.PxHeightFieldFlagsPtr flags {
            get => PxHeightFieldDescPtr_GET_flags(this);
            set => PxHeightFieldDescPtr_SET_flags(this, value);
        }

        //DBG: MethodNode physx::PxHeightFieldDesc::setToDefault L142
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxHeightFieldDescPtr, man: physx.PxHeightFieldDescPtr, kind: PtrStruct
        public void setToDefault() {
            physx.PxHeightFieldDescPtr pvk_in_this = this;
            void_PxHeightFieldDescPtr_setToDefaultPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxHeightFieldDesc::isValid L148
        //RET nat: bool, man: bool, ret: True, kind: Value
        //PAR nat: PxHeightFieldDescPtr, man: physx.PxHeightFieldDescPtr, kind: PtrStruct
        public bool isValid() {
            physx.PxHeightFieldDescPtr pvk_in_this = this;
            return bool_const_PxHeightFieldDescPtr_isValidPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxHeightFieldDesc::operator= L54
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxHeightFieldDesc::operator= L54

        //DBG: MethodNode physx::PxHeightFieldDesc::~PxHeightFieldDesc L54
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxHeightFieldDesc::~PxHeightFieldDesc L54, Destructor

        //DBG: MethodNode physx::PxHeightFieldDesc::operator= L54
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxHeightFieldDesc::operator= L54

        //Operators
    }
}
