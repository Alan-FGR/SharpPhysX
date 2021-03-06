// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxPadding_intVal3Ptr {
        private System.IntPtr nativePtr_;

        public static void Free(physx.PxPadding_intVal3Ptr ptr){
            Freer_physx_PxPadding_intVal3Ptr(ptr);
        }
        public void Free(){
            Freer_physx_PxPadding_intVal3Ptr(this);
        }

        public static physx.PxPadding_intVal3Ptr New() {
            return Ctor_PxPadding_intVal3Ptr_();
        }

    }

    public unsafe partial struct PxStridedDataPtr : physx.PxStridedDataPtr.IPxStridedDataPtr {
        private System.IntPtr nativePtr_;

        public static void Free(physx.PxStridedDataPtr ptr){
            Freer_physx_PxStridedDataPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxStridedDataPtr(this);
        }

        public static physx.PxStridedDataPtr New() {
            return Ctor_PxStridedDataPtr_();
        }

        public uint stride {
            get => PxStridedDataPtr_GET_stride(this);
            set => PxStridedDataPtr_SET_stride(this, value);
        }

        public IntPtr data {
            get => PxStridedDataPtr_GET_data(this);
            set => PxStridedDataPtr_SET_data(this, value);
        }

        public unsafe interface IPxStridedDataPtr {
            uint stride {get;set;}
            IntPtr data {get;set;}
        }
    }

    public unsafe partial struct PxBoundedDataPtr : physx.PxStridedDataPtr.IPxStridedDataPtr {
        private System.IntPtr nativePtr_;

        public static void Free(physx.PxBoundedDataPtr ptr){
            Freer_physx_PxBoundedDataPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxBoundedDataPtr(this);
        }

        public static physx.PxBoundedDataPtr New() {
            return Ctor_PxBoundedDataPtr_();
        }

        public uint count {
            get => PxBoundedDataPtr_GET_count(this);
            set => PxBoundedDataPtr_SET_count(this, value);
        }

        public static implicit operator physx.PxStridedDataPtr(PxBoundedDataPtr obj) => *(physx.PxStridedDataPtr*)&obj;
        public static explicit operator PxBoundedDataPtr(physx.PxStridedDataPtr obj) => *(PxBoundedDataPtr*)&obj;

        public uint stride {
            get => PxStridedDataPtr_GET_stride(this);
            set => PxStridedDataPtr_SET_stride(this, value);
        }

        public IntPtr data {
            get => PxStridedDataPtr_GET_data(this);
            set => PxStridedDataPtr_SET_data(this, value);
        }

    }

}
