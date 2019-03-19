#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxPvdSceneFlag : int {
    eTRANSMIT_CONTACTS = 1,     // eTRANSMIT_CONTACTS = (1 << 0)
    eTRANSMIT_SCENEQUERIES = 2, // eTRANSMIT_SCENEQUERIES = (1 << 1)
    eTRANSMIT_CONSTRAINTS = 4,  // eTRANSMIT_CONSTRAINTS = (1 << 2)
}
#endif //enum

#if !NATIVE
public partial struct PxPvdSceneClient {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag_P_PxPvdSceneFlag(physx::PxPvdSceneFlag::Enum a, physx::PxPvdSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag_P_PxPvdSceneFlag(PxPvdSceneFlag a, PxPvdSceneFlag b);

public static UNPARSED_TYPE operator|(PxPvdSceneFlag a, PxPvdSceneFlag b){
    PxPvdSceneFlag pvk_in_a = (a);
    PxPvdSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag_P_PxPvdSceneFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag_P_PxPvdSceneFlag(physx::PxPvdSceneFlag::Enum a, physx::PxPvdSceneFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag_P_PxPvdSceneFlag(PxPvdSceneFlag a, PxPvdSceneFlag b);

public static UNPARSED_TYPE operator&(PxPvdSceneFlag a, PxPvdSceneFlag b){
    PxPvdSceneFlag pvk_in_a = (a);
    PxPvdSceneFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag_P_PxPvdSceneFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxPvdSceneFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag(physx::PxPvdSceneFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag(PxPvdSceneFlag a);

public static UNPARSED_TYPE operator~(PxPvdSceneFlag a){
    PxPvdSceneFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxPvdSceneFlag_byte_P_PxPvdSceneFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxPvdSceneClient
#endif


#if !NATIVE //interface
public unsafe interface IPvdDebugPointPtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PvdDebugPointPtr : IPvdDebugPointPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PvdDebugPointPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPvdDebugLinePtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PvdDebugLinePtr : IPvdDebugLinePtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PvdDebugLinePtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPvdDebugTrianglePtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PvdDebugTrianglePtr : IPvdDebugTrianglePtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PvdDebugTrianglePtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPvdDebugTextPtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PvdDebugTextPtr : IPvdDebugTextPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PvdDebugTextPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPvdClientPtr {
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PvdClientPtr : IPvdClientPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PvdClientPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxPvdSceneClient Manually Ignored
// Class physx::PxPvdSceneFlag is enum namespace