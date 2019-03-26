#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxPlaneGeometryPtr {
#endif

//================================================================================
//#       PxTransformFromPlaneEquation(PxPlanePtr plane)                         #
//================================================================================
#if NATIVE //function start
ES PxTransformPOD W_PxTransformFromPlaneEquation_R_PxTransform_P_PxPlane(physx::PxPlane plane){
    auto nat_in_plane = (plane);
    auto retVal = physx::PxTransformFromPlaneEquation;
    return *(PxTransformPOD*)&retVal;
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
//#       PxPlaneEquationFromTransform(PxTransformPtr transform)                 #
//================================================================================
#if NATIVE //function start
ES PxPlanePOD W_PxPlaneEquationFromTransform_R_PxPlane_P_PxTransform(physx::PxTransform transform){
    auto nat_in_transform = (transform);
    auto retVal = physx::PxPlaneEquationFromTransform;
    return *(PxPlanePOD*)&retVal;
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

#if !NATIVE //end functions holder
} //end PxPlaneGeometryPtr
#endif


#if !NATIVE //interface
public unsafe interface IPxPlaneGeometryPtr {
    // static PxPlaneGeometryPtr New();
     bool isValid();
    //static UNPARSED_TYPE operator=(PxPlaneGeometryPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxPlaneGeometryPtr lhs, /*NULLPARS*/);
    // static PxPlaneGeometryPtr New(/*NULLPARS*/);
    // static PxPlaneGeometryPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxPlaneGeometry(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxPlaneGeometryPtr : IPxGeometryPtr, IPxPlaneGeometryPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxPlaneGeometryPtrPOD{
};
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
    //public  static PxGeometryPtr New(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  static PxGeometryPtr New(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  static PxGeometryPtr New(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).~PxGeometry(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/){return ((PxGeometryPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/){return ((PxGeometryPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxPlaneGeometry()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES PxPlaneGeometryPtrPOD W_PxPlaneGeometry_R_PxPlaneGeometryPtr_C_PxPlaneGeometry_ctor(){
        auto val = new PxPlaneGeometry();
        return *(PxPlaneGeometryPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlaneGeometryPtr W_PxPlaneGeometry_R_PxPlaneGeometryPtr_C_PxPlaneGeometry_ctor();
    
    public  static PxPlaneGeometryPtr New(){
        var _new = W_PxPlaneGeometry_R_PxPlaneGeometryPtr_C_PxPlaneGeometry_ctor();
        PxPlaneGeometryPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid()                                                              #
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
