#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxBoxGeometry {
    // PxBoxGeometry();
    // PxBoxGeometry(float hx, float hy, float hz);
    // PxBoxGeometry(PxVec3 halfExtents_);
     bool isValid();
    // PxBoxGeometry(/*NULLPARS*/);
    // PxBoxGeometry(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBoxGeometry lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBoxGeometry lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxBoxGeometry(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxBoxGeometry : IPxGeometryPtr, IPxBoxGeometry { // blittable
    // TODO extract blittable fields from base classes reliably (if possible at all)
    // FIELDS COULDN'T BE RESOLVED AUTOMATICALLY. YOU MAY HANDLE THAT MANUALLY AS GETTERS BELOW:
    private object CHECK_halfExtents => halfExtents; // physx::PxVec3

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxGeometryPtr, PxBoxGeometry
    public static implicit operator PxGeometryPtr(PxBoxGeometry obj){return *(PxGeometryPtr*)&obj;}
    public static explicit operator PxBoxGeometry(PxGeometryPtr obj){return *(PxBoxGeometry*)&obj;}
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
    //#       PxBoxGeometry                                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBoxGeometry W_PxBoxGeometry_R_PxBoxGeometry_P_float_P_float_P_float_C_PxBoxGeometry_ctor(physx::PxReal hx, physx::PxReal hy, physx::PxReal hz){
        auto nat_in_hx = (hx);
        auto nat_in_hy = (hy);
        auto nat_in_hz = (hz);
        return PxBoxGeometry(nat_in_hx, nat_in_hy, nat_in_hz);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_PxBoxGeometry_R_PxBoxGeometry_P_float_P_float_P_float_C_PxBoxGeometry_ctor(float hx, float hy, float hz);
    
    public  PxBoxGeometry(float hx, float hy, float hz){
        float pvk_in_hx = (hx);
        float pvk_in_hy = (hy);
        float pvk_in_hz = (hz);
        var _new = W_PxBoxGeometry_R_PxBoxGeometry_P_float_P_float_P_float_C_PxBoxGeometry_ctor(pvk_in_hx, pvk_in_hy, pvk_in_hz);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBoxGeometry W_PxBoxGeometry_R_PxBoxGeometry_P_PxVec3_C_PxBoxGeometry_ctor(physx::PxVec3 halfExtents_){
        auto nat_in_halfExtents_ = (halfExtents_);
        return PxBoxGeometry(nat_in_halfExtents_);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_PxBoxGeometry_R_PxBoxGeometry_P_PxVec3_C_PxBoxGeometry_ctor(PxVec3 halfExtents_);
    
    public  PxBoxGeometry(PxVec3 halfExtents_){
        PxVec3 pvk_in_halfExtents_ = (halfExtents_);
        var _new = W_PxBoxGeometry_R_PxBoxGeometry_P_PxVec3_C_PxBoxGeometry_ctor(pvk_in_halfExtents_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxBoxGeometry(physx::PxBoxGeometry self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxBoxGeometry(PxBoxGeometry selfBlt);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxBoxGeometry(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxBoxGeometry
    
    //Skipped generated implicit entry: PxBoxGeometry
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBoxGeometry
    

#if !NATIVE //struct close
}
#endif //struct close
