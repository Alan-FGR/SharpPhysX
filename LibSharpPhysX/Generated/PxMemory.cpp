// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR

ES void* IntPtr_PxMemZeroPtr_IntPtr_uint_(void* wrp_dest, PxU32 wrp_count){
    return (void*) ::physx::PxMemZero(wrp_dest, wrp_count);
}

ES void* IntPtr_PxMemSetPtr_IntPtr_int_uint_(void* wrp_dest, PxI32 wrp_c, PxU32 wrp_count){
    return (void*) ::physx::PxMemSet(wrp_dest, wrp_c, wrp_count);
}

ES void* IntPtr_PxMemCopyPtr_IntPtr_IntPtr_uint_(void* wrp_dest, void* wrp_src, PxU32 wrp_count){
    return (void*) ::physx::PxMemCopy(wrp_dest, wrp_src, wrp_count);
}

ES void* IntPtr_PxMemMovePtr_IntPtr_IntPtr_uint_(void* wrp_dest, void* wrp_src, PxU32 wrp_count){
    return (void*) ::physx::PxMemMove(wrp_dest, wrp_src, wrp_count);
}
