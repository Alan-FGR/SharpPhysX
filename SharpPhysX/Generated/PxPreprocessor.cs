#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxPreprocessor {
#endif

//================================================================================
//#       PX_UNUSED                                                              #
//================================================================================
/* ERRORS OCCURED: Invalid parameter name (empty)
Unresolved parameter pointee T
// NATIVE SIG: void PX_UNUSED(T const&)
{
}
#if NATIVE
ES void W_PX_UNUSED( ){
    auto nat_in_ = ();
    PX_UNUSED(nat_in_);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PX_UNUSED( );

public static void PX_UNUSED( ){
     pvk_in_ = ();
    W_PX_UNUSED(pvk_in_);
}
#endif*/

#if !NATIVE
} // End PxPreprocessor
#endif


#if !NATIVE
public unsafe partial struct PxPackValidation { // blittable
    public sbyte _;
    public long a;

#endif

    //Skipped generated implicit entry: PxPackValidation
    
    //Skipped generated implicit entry: PxPackValidation
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxPackValidation
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxPackValidation
    

#if !NATIVE
}
#endif
