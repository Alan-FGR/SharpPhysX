#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxUnionCast {

//================================================================================
//#       PxUnionCast                                                            #
//================================================================================
/* ERRORS OCCURED: unhandled return type
Unresolved parameter type physx::PxUnionCast::b
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
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxUnionCast.h L45~61
#if NATIVE
ES UNPARSED_TYPE W_PxUnionCast( b){
    auto nat_in_b = (b);
    auto retVal = physx::PxUnionCast(nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_PxUnionCast( b);

public static UNPARSED_TYPE PxUnionCast( b){
     pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_PxUnionCast(pvk_in_b);
    return retVal;
}
#endif*/

} // End PxUnionCast


