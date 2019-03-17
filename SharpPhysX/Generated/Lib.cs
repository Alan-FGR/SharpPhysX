#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct Lib {
#endif

//================================================================================
//#       MAN_PxCreateFoundation                                                 #
//================================================================================
/* ERRORS OCCURED: Unresolved parameter pointee ::SharpPhysXError
// NATIVE SIG: PxFoundation* MAN_PxCreateFoundation(SharpPhysXError* managedErrorCallback)
{
    return PxCreateFoundation(PX_PHYSICS_VERSION, allocator_, *new ShPxErrorCallbackWrapper(*managedErrorCallback));
}
#if NATIVE
ES physx::PxFoundation* W_MAN_PxCreateFoundation( managedErrorCallback){
    auto nat_in_managedErrorCallback = (managedErrorCallback);
    auto retVal = MAN_PxCreateFoundation(nat_in_managedErrorCallback);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundationPtr W_MAN_PxCreateFoundation( managedErrorCallback);

public static PxFoundationPtr MAN_PxCreateFoundation( managedErrorCallback){
     pvk_in_managedErrorCallback = (managedErrorCallback);
    PxFoundationPtr retVal = W_MAN_PxCreateFoundation(pvk_in_managedErrorCallback);
    return retVal;
}
#endif*/


//================================================================================
//#       MAN_PxCreatePhysics                                                    #
//================================================================================
#if NATIVE
ES physx::PxPhysics* W_MAN_PxCreatePhysics(physx::PxFoundation* foundation){
    auto nat_in_foundation = (foundation);
    auto retVal = MAN_PxCreatePhysics(nat_in_foundation);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_MAN_PxCreatePhysics(PxFoundationPtr foundation);

public static PxPhysicsPtr MAN_PxCreatePhysics(PxFoundationPtr foundation){
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxPhysicsPtr retVal = W_MAN_PxCreatePhysics(pvk_in_foundation);
    return retVal;
}
#endif

#if !NATIVE
} // End Lib
#endif


