#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxMemory {
#endif

//================================================================================
//#       PxMemZero                                                              #
//================================================================================
#if NATIVE
ES void* W_PxMemZero(void* dest, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemZero(nat_in_dest, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemZero(global::System.IntPtr dest, uint count);

public static IntPtr PxMemZero(global::System.IntPtr dest, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemZero(pvk_in_dest, pvk_in_count);
    return retVal;
}
#endif


//================================================================================
//#       PxMemSet                                                               #
//================================================================================
#if NATIVE
ES void* W_PxMemSet(void* dest, physx::PxI32 c, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_c = (c);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemSet(nat_in_dest, nat_in_c, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemSet(global::System.IntPtr dest, int c, uint count);

public static IntPtr PxMemSet(global::System.IntPtr dest, int c, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    int pvk_in_c = (c);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemSet(pvk_in_dest, pvk_in_c, pvk_in_count);
    return retVal;
}
#endif


//================================================================================
//#       PxMemCopy                                                              #
//================================================================================
#if NATIVE
ES void* W_PxMemCopy(void* dest, const void* src, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemCopy(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemCopy(global::System.IntPtr dest, global::System.IntPtr src, uint count);

public static IntPtr PxMemCopy(global::System.IntPtr dest, global::System.IntPtr src, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    global::System.IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemCopy(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif


//================================================================================
//#       PxMemMove                                                              #
//================================================================================
#if NATIVE
ES void* W_PxMemMove(void* dest, const void* src, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemMove(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemMove(global::System.IntPtr dest, global::System.IntPtr src, uint count);

public static IntPtr PxMemMove(global::System.IntPtr dest, global::System.IntPtr src, uint count){
    global::System.IntPtr pvk_in_dest = (dest);
    global::System.IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemMove(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif

#if !NATIVE
} // End PxMemory
#endif


