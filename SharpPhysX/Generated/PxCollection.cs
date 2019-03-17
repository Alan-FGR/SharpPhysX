#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxCollection {
#endif

//================================================================================
//#       PxCreateCollection                                                     #
//================================================================================
/* ERRORS OCCURED: Forbidden return type
// NATIVE SIG: physx::PxCollection* PX_CALL_CONV PxCreateCollection()
#if NATIVE
ES physx::PxCollection* W_PxCreateCollection(){
    auto retVal = PxCreateCollection();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxCollectionPtr W_PxCreateCollection();

public static PxCollectionPtr PxCreateCollection(){
    PxCollectionPtr retVal = W_PxCreateCollection();
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxCollection
#endif


// Class physx::PxCollection Manually Ignored