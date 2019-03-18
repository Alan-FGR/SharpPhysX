#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe interface IPxSphereGeometry {
    // PxSphereGeometry();
    // PxSphereGeometry(float ir);
     bool isValid();
    //static UNPARSED_TYPE operator=(PxSphereGeometry lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSphereGeometry lhs, /*NULLPARS*/);
    // PxSphereGeometry(/*NULLPARS*/);
    // PxSphereGeometry(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxSphereGeometry(/*NULLPARS*/);
    
}

public unsafe partial struct PxSphereGeometry : IPxGeometryPtr, IPxSphereGeometry { // blittable
    // TODO extract fields from base classes reliably (if possible at all)
    // FIELDS COULDN'T BE RESOLVED AUTOMATICALLY. YOU MAY HANDLE THAT MANUALLY AS GETTERS BELOW:
    private object CHECK_radius => radius; // physx::PxReal

#endif

    // Hierarchy: PxGeometryPtr, PxSphereGeometry
    public static implicit operator PxGeometryPtr(PxSphereGeometry obj){return *(PxGeometryPtr*)&obj;}
    public static explicit operator PxSphereGeometry(PxGeometryPtr obj){return *(PxSphereGeometry*)&obj;}
    
    // ### Piping
    
    // --- PxGeometryPtr
    public  PxGeometryType getType(){return ((PxGeometryPtr)this).getType();}
    //public  PxGeometry(PxGeometryType type){((PxGeometryPtr)this).PxGeometry(type);}
    //public  PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).PxGeometry(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxGeometry(/*NULLPARS*/){((PxGeometryPtr)this).~PxGeometry(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/){return ((PxGeometryPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/){return ((PxGeometryPtr)this).operator=(/*NULLARGS*/);}
    

    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxSphereGeometry                                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxSphereGeometry W_PxSphereGeometry_ctor(physx::PxReal ir){
        auto nat_in_ir = (ir);
        self.PxSphereGeometry(nat_in_ir);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSphereGeometry W_PxSphereGeometry_ctor(float ir);
    
    public  PxSphereGeometry(float ir){
        float pvk_in_ir = (ir);
        var _new = W_PxSphereGeometry_ctor(pvk_in_ir);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE
    ES bool W_isValid(physx::PxSphereGeometry self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxSphereGeometry selfBlt);
    
    public  bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSphereGeometry
    
    //Skipped generated implicit entry: PxSphereGeometry
    
    //Skipped generated implicit entry: ~PxSphereGeometry
    

#if !NATIVE
}
#endif
