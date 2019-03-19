#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxMemory {
#endif

//================================================================================
//#       PxMemZero                                                              #
//================================================================================
#if NATIVE //function start
ES void* W_PxMemZero_R_IntPtr_P_IntPtr_P_uint(void* dest, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemZero(nat_in_dest, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemZero_R_IntPtr_P_IntPtr_P_uint(IntPtr dest, uint count);

public static IntPtr PxMemZero(IntPtr dest, uint count){
    IntPtr pvk_in_dest = (dest);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemZero_R_IntPtr_P_IntPtr_P_uint(pvk_in_dest, pvk_in_count);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxMemSet                                                               #
//================================================================================
#if NATIVE //function start
ES void* W_PxMemSet_R_IntPtr_P_IntPtr_P_int_P_uint(void* dest, physx::PxI32 c, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_c = (c);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemSet(nat_in_dest, nat_in_c, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemSet_R_IntPtr_P_IntPtr_P_int_P_uint(IntPtr dest, int c, uint count);

public static IntPtr PxMemSet(IntPtr dest, int c, uint count){
    IntPtr pvk_in_dest = (dest);
    int pvk_in_c = (c);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemSet_R_IntPtr_P_IntPtr_P_int_P_uint(pvk_in_dest, pvk_in_c, pvk_in_count);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxMemCopy                                                              #
//================================================================================
#if NATIVE //function start
ES void* W_PxMemCopy_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(void* dest, const void* src, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemCopy(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemCopy_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(IntPtr dest, IntPtr src, uint count);

public static IntPtr PxMemCopy(IntPtr dest, IntPtr src, uint count){
    IntPtr pvk_in_dest = (dest);
    IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemCopy_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxMemMove                                                              #
//================================================================================
#if NATIVE //function start
ES void* W_PxMemMove_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(void* dest, const void* src, physx::PxU32 count){
    auto nat_in_dest = (dest);
    auto nat_in_src = (src);
    auto nat_in_count = (count);
    auto retVal = physx::PxMemMove(nat_in_dest, nat_in_src, nat_in_count);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_PxMemMove_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(IntPtr dest, IntPtr src, uint count);

public static IntPtr PxMemMove(IntPtr dest, IntPtr src, uint count){
    IntPtr pvk_in_dest = (dest);
    IntPtr pvk_in_src = (src);
    uint pvk_in_count = (count);
    IntPtr retVal = W_PxMemMove_R_IntPtr_P_IntPtr_P_IntPtr_P_uint(pvk_in_dest, pvk_in_src, pvk_in_count);
    return retVal;
}
#endif //function end

#if !NATIVE
} // End PxMemory
#endif


