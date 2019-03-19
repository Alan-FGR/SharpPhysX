#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxCollection {
#endif

//================================================================================
//#       PxCreateCollection                                                     #
//================================================================================
/* ERRORS OCCURED: Forbidden return type
// NATIVE SIG: physx::PxCollection* PX_CALL_CONV PxCreateCollection()
#if NATIVE //function start
ES physx::PxCollection* W_PxCreateCollection_R_PxCollectionPtr(){
    auto retVal = PxCreateCollection();
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxCollectionPtr W_PxCreateCollection_R_PxCollectionPtr();

public static PxCollectionPtr PxCreateCollection(){
    PxCollectionPtr retVal = W_PxCreateCollection_R_PxCollectionPtr();
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxCollection
#endif


// Class physx::PxCollection Manually Ignored