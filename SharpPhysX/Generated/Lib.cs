#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct Lib {
#endif

//================================================================================
//#       OVR_PxCreateFoundation                                                 #
//================================================================================
/* ERRORS OCCURED: Unresolved parameter pointee ::SharpPhysXError
// NATIVE SIG: physx::PxFoundation* OVR_PxCreateFoundation(SharpPhysXError* managedErrorCallback)
{
    return PxCreateFoundation(PX_PHYSICS_VERSION, allocator_, *new ShPxErrorCallbackWrapper(*managedErrorCallback));
	//PxCreatePhysics()
}
// SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Lib.cpp L88~92
#if NATIVE
ES physx::PxFoundation* W_OVR_PxCreateFoundation( managedErrorCallback){
    auto nat_in_managedErrorCallback = (managedErrorCallback);
    auto retVal = OVR_PxCreateFoundation(nat_in_managedErrorCallback);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundation W_OVR_PxCreateFoundation( managedErrorCallback);

public static PxFoundation OVR_PxCreateFoundation( managedErrorCallback){
     pvk_in_managedErrorCallback = (managedErrorCallback);
    PxFoundation retVal = W_OVR_PxCreateFoundation(pvk_in_managedErrorCallback);
    return retVal;
}
#endif*/

#if !NATIVE
} // End Lib
#endif


