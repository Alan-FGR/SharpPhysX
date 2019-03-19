#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxCapsuleGeometry {
#endif

//================================================================================
//#       PxTransformFromSegment                                                 #
//================================================================================
#if NATIVE //function start
ES physx::PxTransform W_PxTransformFromSegment_R_PxTransform_P_PxVec3_P_PxVec3_P_floatPtr(physx::PxVec3 p0, physx::PxVec3 p1, physx::PxReal* halfHeight){
    auto nat_in_p0 = (p0);
    auto nat_in_p1 = (p1);
    auto nat_in_halfHeight = (halfHeight);
    auto retVal = physx::PxTransformFromSegment(nat_in_p0, nat_in_p1, nat_in_halfHeight);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxTransform W_PxTransformFromSegment_R_PxTransform_P_PxVec3_P_PxVec3_P_floatPtr(PxVec3 p0, PxVec3 p1, float* halfHeight);

public static PxTransform PxTransformFromSegment(PxVec3 p0, PxVec3 p1, float* halfHeight){
    PxVec3 pvk_in_p0 = (p0);
    PxVec3 pvk_in_p1 = (p1);
    float* pvk_in_halfHeight = (halfHeight);
    PxTransform retVal = W_PxTransformFromSegment_R_PxTransform_P_PxVec3_P_PxVec3_P_floatPtr(pvk_in_p0, pvk_in_p1, pvk_in_halfHeight);
    return retVal;
}
#endif //function end


// ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
#if NATIVE //function start
ES physx::PxTransform W_PxTransformFromSegment_R_PxTransform_P_PxVec3_P_PxVec3_OL1(physx::PxVec3 p0, physx::PxVec3 p1){
    auto nat_in_p0 = (p0);
    auto nat_in_p1 = (p1);
    auto retVal = physx::PxTransformFromSegment(nat_in_p0, nat_in_p1);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxTransform W_PxTransformFromSegment_R_PxTransform_P_PxVec3_P_PxVec3_OL1(PxVec3 p0, PxVec3 p1);

public static PxTransform PxTransformFromSegment(PxVec3 p0, PxVec3 p1){
    PxVec3 pvk_in_p0 = (p0);
    PxVec3 pvk_in_p1 = (p1);
    PxTransform retVal = W_PxTransformFromSegment_R_PxTransform_P_PxVec3_P_PxVec3_OL1(pvk_in_p0, pvk_in_p1);
    return retVal;
}
#endif //function end


#if !NATIVE
} // End PxCapsuleGeometry
#endif


#if !NATIVE //interface
public unsafe interface IPxCapsuleGeometry {
    // PxCapsuleGeometry();
    // PxCapsuleGeometry(float radius_, float halfHeight_);
     bool isValid();
    //static UNPARSED_TYPE operator=(PxCapsuleGeometry lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxCapsuleGeometry lhs, /*NULLPARS*/);
    // PxCapsuleGeometry(/*NULLPARS*/);
    // PxCapsuleGeometry(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxCapsuleGeometry(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxCapsuleGeometry : IPxGeometryPtr, IPxCapsuleGeometry { // blittable
    // TODO extract blittable fields from base classes reliably (if possible at all)
    // FIELDS COULDN'T BE RESOLVED AUTOMATICALLY. YOU MAY HANDLE THAT MANUALLY AS GETTERS BELOW:
    private object CHECK_radius => radius; // physx::PxReal
    private object CHECK_halfHeight => halfHeight; // physx::PxReal

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxGeometryPtr, PxCapsuleGeometry
    public static implicit operator PxGeometryPtr(PxCapsuleGeometry obj){return *(PxGeometryPtr*)&obj;}
    public static explicit operator PxCapsuleGeometry(PxGeometryPtr obj){return *(PxCapsuleGeometry*)&obj;}
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
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxCapsuleGeometry                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxCapsuleGeometry W_PxCapsuleGeometry_R_PxCapsuleGeometry_P_float_P_float_C_PxCapsuleGeometry_ctor(physx::PxReal radius_, physx::PxReal halfHeight_){
        auto nat_in_radius_ = (radius_);
        auto nat_in_halfHeight_ = (halfHeight_);
        return PxCapsuleGeometry(nat_in_radius_, nat_in_halfHeight_);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCapsuleGeometry W_PxCapsuleGeometry_R_PxCapsuleGeometry_P_float_P_float_C_PxCapsuleGeometry_ctor(float radius_, float halfHeight_);
    
    public  PxCapsuleGeometry(float radius_, float halfHeight_){
        float pvk_in_radius_ = (radius_);
        float pvk_in_halfHeight_ = (halfHeight_);
        var _new = W_PxCapsuleGeometry_R_PxCapsuleGeometry_P_float_P_float_C_PxCapsuleGeometry_ctor(pvk_in_radius_, pvk_in_halfHeight_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxCapsuleGeometry(physx::PxCapsuleGeometry self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxCapsuleGeometry(PxCapsuleGeometry selfBlt);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxCapsuleGeometry(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxCapsuleGeometry
    
    //Skipped generated implicit entry: PxCapsuleGeometry
    
    //Skipped generated implicit entry: ~PxCapsuleGeometry
    

#if !NATIVE //struct close
}
#endif //struct close
