#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


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
#if NATIVE //function start
ES void W_PX_UNUSED_R_void_P_( ){
    auto nat_in_ = ();
    PX_UNUSED(nat_in_);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PX_UNUSED_R_void_P_( );

public static void PX_UNUSED( ){
     pvk_in_ = ();
    W_PX_UNUSED_R_void_P_(pvk_in_);
}
#endif //function end*/

#if !NATIVE
} // End PxPreprocessor
#endif


#if !NATIVE //interface
public unsafe interface IPxPackValidation {
    // PxPackValidation(/*NULLPARS*/);
    // PxPackValidation(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxPackValidation lhs, /*NULLPARS*/);
    // PxPackValidation(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxPackValidation lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxPackValidation(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxPackValidation : IPxPackValidation { // blittable
    public sbyte _;
    public long a;

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxPackValidation
    #endif //hierarchy
    //Skipped generated implicit entry: PxPackValidation
    
    //Skipped generated implicit entry: PxPackValidation
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxPackValidation
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxPackValidation
    

#if !NATIVE //struct close
}
#endif //struct close
