#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxPlaneGeometry {
#endif

//================================================================================
//#       PxTransformFromPlaneEquation                                           #
//================================================================================
#if NATIVE
ES physx::PxTransform W_PxTransformFromPlaneEquation(physx::PxPlane plane){
    auto nat_in_plane = (plane);
    auto retVal = physx::PxTransformFromPlaneEquation(nat_in_plane);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxTransform W_PxTransformFromPlaneEquation(PxPlane plane);

public static PxTransform PxTransformFromPlaneEquation(PxPlane plane){
    PxPlane pvk_in_plane = (plane);
    PxTransform retVal = W_PxTransformFromPlaneEquation(pvk_in_plane);
    return retVal;
}
#endif


//================================================================================
//#       PxPlaneEquationFromTransform                                           #
//================================================================================
#if NATIVE
ES physx::PxPlane W_PxPlaneEquationFromTransform(physx::PxTransform transform){
    auto nat_in_transform = (transform);
    auto retVal = physx::PxPlaneEquationFromTransform(nat_in_transform);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPlane W_PxPlaneEquationFromTransform(PxTransform transform);

public static PxPlane PxPlaneEquationFromTransform(PxTransform transform){
    PxTransform pvk_in_transform = (transform);
    PxPlane retVal = W_PxPlaneEquationFromTransform(pvk_in_transform);
    return retVal;
}
#endif

#if !NATIVE
} // End PxPlaneGeometry
#endif


#if !NATIVE
public unsafe partial struct PxPlaneGeometryPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxPlaneGeometry                                                        #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxPlaneGeometry
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE
    ES bool W_isValid(physx::PxPlaneGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxPlaneGeometryPtr selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxPlaneGeometry
    
    //Skipped generated implicit entry: PxPlaneGeometry
    
    //Skipped generated implicit entry: ~PxPlaneGeometry
    

#if !NATIVE
}
#endif
