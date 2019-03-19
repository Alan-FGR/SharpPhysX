#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxUnionCast {
#endif

//================================================================================
//#       PxUnionCast                                                            #
//================================================================================
/* ERRORS OCCURED: unhandled return type: A
Unresolved parameter type B
// NATIVE SIG: A PxUnionCast(B b)
{
	union AB
	{
		AB(B bb) : _b(bb)
		{
		}
		 B _b;
		 A _a;
// needed for clang 7
#if PX_LINUX && PX_CLANG 
	} volatile u(b);
#else
	} u(b);
#endif
	return u._a;
}
#if NATIVE //function start
ES UNPARSED_TYPE W_PxUnionCast_R_A_P_( b){
    auto nat_in_b = (b);
    auto retVal = physx::PxUnionCast(nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxUnionCast_R_A_P_( b);

public static UNPARSED_TYPE PxUnionCast( b){
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_PxUnionCast_R_A_P_(pvk_in_b);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxUnionCast
#endif


