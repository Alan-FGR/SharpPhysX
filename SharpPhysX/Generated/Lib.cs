#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct Lib {
#endif

//================================================================================
//#       MAN_PxCreateFoundation(SharpPhysXError managedErrorCallback)           #
//================================================================================
/* ERRORS OCCURED: Unresolved parameter pointee ::SharpPhysXError
// NATIVE SIG: PxFoundation* MAN_PxCreateFoundation(SharpPhysXError* managedErrorCallback)
{
	return PxCreateFoundation(PX_PHYSICS_VERSION, allocator_, *new ShPxErrorCallbackWrapper(*managedErrorCallback));
}
#if NATIVE //function start
ES physx::PxFoundation* W_MAN_PxCreateFoundation_R_PxFoundationPtr_P_( managedErrorCallback){
    auto nat_in_managedErrorCallback = (managedErrorCallback);
    auto retVal = MAN_PxCreateFoundation(nat_in_managedErrorCallback);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxFoundationPtr W_MAN_PxCreateFoundation_R_PxFoundationPtr_P_( managedErrorCallback);

public static PxFoundationPtr MAN_PxCreateFoundation( managedErrorCallback){
     pvk_in_managedErrorCallback = (managedErrorCallback);
    PxFoundationPtr retVal = W_MAN_PxCreateFoundation_R_PxFoundationPtr_P_(pvk_in_managedErrorCallback);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       MAN_PxCreatePhysics(PxFoundationPtr foundation)                        #
//================================================================================
#if NATIVE //function start
ES physx::PxPhysics* W_MAN_PxCreatePhysics_R_PxPhysicsPtr_P_PxFoundationPtr(physx::PxFoundation* foundation){
    auto nat_in_foundation = (foundation);
    auto retVal = MAN_PxCreatePhysics(nat_in_foundation);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPhysicsPtr W_MAN_PxCreatePhysics_R_PxPhysicsPtr_P_PxFoundationPtr(PxFoundationPtr foundation);

public static PxPhysicsPtr MAN_PxCreatePhysics(PxFoundationPtr foundation){
    PxFoundationPtr pvk_in_foundation = (foundation);
    PxPhysicsPtr retVal = W_MAN_PxCreatePhysics_R_PxPhysicsPtr_P_PxFoundationPtr(pvk_in_foundation);
    return retVal;
}
#endif //function end


//================================================================================
//#       MAN_PxCreateSceneDesc()                                                #
//================================================================================
#if NATIVE //function start
ES physx::PxSceneDesc* W_MAN_PxCreateSceneDesc_R_PxSceneDescPtr(){
    auto retVal = MAN_PxCreateSceneDesc();
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxSceneDescPtr W_MAN_PxCreateSceneDesc_R_PxSceneDescPtr();

public static PxSceneDescPtr MAN_PxCreateSceneDesc(){
    PxSceneDescPtr retVal = W_MAN_PxCreateSceneDesc_R_PxSceneDescPtr();
    return retVal;
}
#endif //function end

#if !NATIVE //end functions holder
} //end Lib
#endif


#if !NATIVE //interface
public unsafe interface ITypeList {
    
}
#endif //interface

#if !NATIVE //struct start POD:True
public unsafe partial struct TypeList : ITypeList { // blittable

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: TypeList
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close
