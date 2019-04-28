// Generated by minBND 5.1.93.2 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static IntPtr platformAlignedAlloc(ulong size) {
        ulong pvk_in_size = size;
        return IntPtr_platformAlignedAllocPtr_ulong_(pvk_in_size);
    }

    public static void platformAlignedFree(IntPtr ptr) {
        IntPtr pvk_in_ptr = ptr;
        void_platformAlignedFreePtr_IntPtr_(pvk_in_ptr);
    }

    public unsafe partial struct PxDefaultAllocatorPtr {
        private System.IntPtr nativePtr_;

        public static implicit operator physx.PxAllocatorCallbackPtr(PxDefaultAllocatorPtr obj) => *(physx.PxAllocatorCallbackPtr*)&obj;
        public static explicit operator PxDefaultAllocatorPtr(physx.PxAllocatorCallbackPtr obj) => *(PxDefaultAllocatorPtr*)&obj;
    }
}
