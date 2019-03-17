#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxSphereGeometry { // blittable
    // TODO extract fields from base classes reliably (if possible at all)
    // FIELDS COULDN'T BE RESOLVED AUTOMATICALLY. YOU MAY HANDLE THAT MANUALLY AS GETTERS BELOW:
    private object CHECK_radius => radius; // physx::PxReal

#endif

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
    
    public PxSphereGeometry(float ir){
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
    
    public bool isValid(){
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
