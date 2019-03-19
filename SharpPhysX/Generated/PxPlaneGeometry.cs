#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxPlaneGeometry {
#endif

//================================================================================
//#       PxTransformFromPlaneEquation                                           #
//================================================================================
#if NATIVE //function start
ES physx::PxTransform W_PxTransformFromPlaneEquation_R_PxTransform_P_PxPlane(physx::PxPlane plane){
    auto nat_in_plane = (plane);
    auto retVal = physx::PxTransformFromPlaneEquation(nat_in_plane);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxTransform W_PxTransformFromPlaneEquation_R_PxTransform_P_PxPlane(PxPlane plane);

public static PxTransform PxTransformFromPlaneEquation(PxPlane plane){
    PxPlane pvk_in_plane = (plane);
    PxTransform retVal = W_PxTransformFromPlaneEquation_R_PxTransform_P_PxPlane(pvk_in_plane);
    return retVal;
}
#endif //function end


//================================================================================
//#       PxPlaneEquationFromTransform                                           #
//================================================================================
#if NATIVE //function start
ES physx::PxPlane W_PxPlaneEquationFromTransform_R_PxPlane_P_PxTransform(physx::PxTransform transform){
    auto nat_in_transform = (transform);
    auto retVal = physx::PxPlaneEquationFromTransform(nat_in_transform);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxPlane W_PxPlaneEquationFromTransform_R_PxPlane_P_PxTransform(PxTransform transform);

public static PxPlane PxPlaneEquationFromTransform(PxTransform transform){
    PxTransform pvk_in_transform = (transform);
    PxPlane retVal = W_PxPlaneEquationFromTransform_R_PxPlane_P_PxTransform(pvk_in_transform);
    return retVal;
}
#endif //function end

#if !NATIVE
} // End PxPlaneGeometry
#endif


#if !NATIVE //interface
public unsafe interface IPxPlaneGeometryPtr {
    // PxPlaneGeometry();
     bool isValid();
    //static UNPARSED_TYPE operator=(PxPlaneGeometryPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxPlaneGeometryPtr lhs, /*NULLPARS*/);
    // PxPlaneGeometry(/*NULLPARS*/);
    // PxPlaneGeometry(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxPlaneGeometry(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxPlaneGeometryPtr : IPxGeometryPtr, IPxPlaneGeometryPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxGeometryPtr, PxPlaneGeometryPtr
    public static implicit operator PxGeometryPtr(PxPlaneGeometryPtr obj){return *(PxGeometryPtr*)&obj;}
    public static explicit operator PxPlaneGeometryPtr(PxGeometryPtr obj){return *(PxPlaneGeometryPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxGeometryPtr
    public  PxGeometryType getType(){return ((PxGeometryPtr)this).getType();}
    //public  PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).~PxGeometry(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/){return ((PxGeometryPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/){return ((PxGeometryPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
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
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxPlaneGeometry(physx::PxPlaneGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxPlaneGeometry(PxPlaneGeometryPtr selfPtr);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxPlaneGeometry(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxPlaneGeometry
    
    //Skipped generated implicit entry: PxPlaneGeometry
    
    //Skipped generated implicit entry: ~PxPlaneGeometry
    

#if !NATIVE //struct close
}
#endif //struct close
