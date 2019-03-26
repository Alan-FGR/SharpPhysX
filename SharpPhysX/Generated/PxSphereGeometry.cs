#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxSphereGeometry {
    ///*No paramless ctor in C#*/ static PxSphereGeometry Default();
    // PxSphereGeometry(float ir);
     bool isValid();
    //static UNPARSED_TYPE operator=(PxSphereGeometry lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSphereGeometry lhs, /*NULLPARS*/);
    // PxSphereGeometry(/*NULLPARS*/);
    // PxSphereGeometry(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxSphereGeometry(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSphereGeometry : IPxGeometryPtr, IPxSphereGeometry { // blittable
    // TODO extract blittable fields from base classes reliably (if possible at all)
    // FIELDS COULDN'T BE RESOLVED AUTOMATICALLY. YOU MAY HANDLE THAT MANUALLY AS GETTERS BELOW:
    private object CHECK_radius => radius; // physx::PxReal

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSphereGeometryPOD{
    physx::PxReal radius;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxGeometryPtr, PxSphereGeometry
    public static implicit operator PxGeometryPtr(PxSphereGeometry obj){return *(PxGeometryPtr*)&obj;}
    public static explicit operator PxSphereGeometry(PxGeometryPtr obj){return *(PxSphereGeometry*)&obj;}
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
    //#       PxSphereGeometry()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxSphereGeometryPOD W_PxSphereGeometry_R_PxSphereGeometry_C_PxSphereGeometry_ctor(){
        auto val = PxSphereGeometry();
        return *(PxSphereGeometryPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_PxSphereGeometry_R_PxSphereGeometry_C_PxSphereGeometry_ctor();
    
    public /*No paramless ctor in C#*/ static PxSphereGeometry Default(){
        return (W_PxSphereGeometry_R_PxSphereGeometry_C_PxSphereGeometry_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxSphereGeometry(float ir)                                             #
    //================================================================================
    #if NATIVE //function start
    ES PxSphereGeometryPOD W_PxSphereGeometry_R_PxSphereGeometry_P_float_C_PxSphereGeometry_ctor(physx::PxReal ir){
        auto nat_in_ir = (ir);
        auto val = PxSphereGeometry();
        return *(PxSphereGeometryPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_PxSphereGeometry_R_PxSphereGeometry_P_float_C_PxSphereGeometry_ctor(float ir);
    
    public  PxSphereGeometry(float ir){
        float pvk_in_ir = (ir);
        var _new = (W_PxSphereGeometry_R_PxSphereGeometry_P_float_C_PxSphereGeometry_ctor(pvk_in_ir));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxSphereGeometry(physx::PxSphereGeometry self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxSphereGeometry(PxSphereGeometry selfBlt);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxSphereGeometry(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSphereGeometry
    
    //Skipped generated implicit entry: PxSphereGeometry
    
    //Skipped generated implicit entry: ~PxSphereGeometry
    

#if !NATIVE //struct close
}
#endif //struct close
