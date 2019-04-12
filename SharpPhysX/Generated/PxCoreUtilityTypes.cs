// Generated by minBND 5.1.78.10 - © github.com/Alan-FGR
//Unit PxCoreUtilityTypes
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    public unsafe partial struct PxPadding_intVal3Ptr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_PxPadding_intVal3Ptr(PxPadding_intVal3Ptr ptr);
        
        public static void Free(PxPadding_intVal3Ptr ptr){
            Freer_PxPadding_intVal3Ptr(ptr);
        }
        public void Free(){
            Freer_PxPadding_intVal3Ptr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern PxPadding_intVal3Ptr Ctor_PxPadding_intVal3Ptr_();
        
        public static PxPadding_intVal3Ptr New() {
            return Ctor_PxPadding_intVal3Ptr_();
        }
    }
    
    public unsafe partial struct PxStridedDataPtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxStridedDataPtr(PxStridedDataPtr ptr);
        
        public static void Free(PxStridedDataPtr ptr){
            Freer_physx_PxStridedDataPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxStridedDataPtr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxStridedDataPtr Ctor_physx_PxStridedDataPtr_();
        
        public static physx.PxStridedDataPtr New() {
            return Ctor_physx_PxStridedDataPtr_();
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint PxStridedData_GET_stride(PxStridedDataPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxStridedData_SET_stride(PxStridedDataPtr cls, uint value);
        
        public uint stride {
            get => PxStridedData_GET_stride(this);
            set => PxStridedData_SET_stride(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr PxStridedData_GET_data(PxStridedDataPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxStridedData_SET_data(PxStridedDataPtr cls, IntPtr value);
        
        public IntPtr data {
            get => PxStridedData_GET_data(this);
            set => PxStridedData_SET_data(this, value);
        }
    
    
    
        public unsafe interface IPxStridedDataPtr {
            //////################################################################## FIXME
            //Unparsed type ( TODO ): TDataType& | UNPARSED* at(uint idx);
        }
    }
    
    public unsafe partial struct PxBoundedDataPtr : physx.PxStridedDataPtr.IPxStridedDataPtr{
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void Freer_physx_PxBoundedDataPtr(PxBoundedDataPtr ptr);
        
        public static void Free(PxBoundedDataPtr ptr){
            Freer_physx_PxBoundedDataPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxBoundedDataPtr(this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxBoundedDataPtr Ctor_physx_PxBoundedDataPtr_();
        
        public static physx.PxBoundedDataPtr New() {
            return Ctor_physx_PxBoundedDataPtr_();
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern uint PxBoundedData_GET_count(PxBoundedDataPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxBoundedData_SET_count(PxBoundedDataPtr cls, uint value);
        
        public uint count {
            get => PxBoundedData_GET_count(this);
            set => PxBoundedData_SET_count(this, value);
        }
        public static implicit operator physx.PxStridedDataPtr(PxBoundedDataPtr obj) => *(physx.PxStridedDataPtr*)&obj;
        public static explicit operator PxBoundedDataPtr(physx.PxStridedDataPtr obj) => *(PxBoundedDataPtr*)&obj;
    
        // PIPING
    }
    
}