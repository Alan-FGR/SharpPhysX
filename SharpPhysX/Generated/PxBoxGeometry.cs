#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxBoxGeometry { // blittable
    // TODO extract fields from base classes reliably (if possible at all)
    // FIELDS COULDN'T BE RESOLVED AUTOMATICALLY. YOU MAY HANDLE THAT MANUALLY AS GETTERS BELOW:
    private object CHECK_halfExtents => halfExtents; // physx::PxVec3

#endif

    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxBoxGeometry W_PxBoxGeometry_ctor(physx::PxReal hx, physx::PxReal hy, physx::PxReal hz){
        auto nat_in_hx = (hx);
        auto nat_in_hy = (hy);
        auto nat_in_hz = (hz);
        self.PxBoxGeometry(nat_in_hx, nat_in_hy, nat_in_hz);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_PxBoxGeometry_ctor(float hx, float hy, float hz);
    
    public PxBoxGeometry(float hx, float hy, float hz){
        float pvk_in_hx = (hx);
        float pvk_in_hy = (hy);
        float pvk_in_hz = (hz);
        var _new = W_PxBoxGeometry_ctor(pvk_in_hx, pvk_in_hy, pvk_in_hz);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxBoxGeometry                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxBoxGeometry W_PxBoxGeometry_ctor(physx::PxVec3 halfExtents_){
        auto nat_in_halfExtents_ = (halfExtents_);
        self.PxBoxGeometry(nat_in_halfExtents_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoxGeometry W_PxBoxGeometry_ctor(PxVec3 halfExtents_);
    
    public PxBoxGeometry(PxVec3 halfExtents_){
        PxVec3 pvk_in_halfExtents_ = (halfExtents_);
        var _new = W_PxBoxGeometry_ctor(pvk_in_halfExtents_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE
    ES bool W_isValid(physx::PxBoxGeometry self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxBoxGeometry selfBlt);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxBoxGeometry
    
    //Skipped generated implicit entry: PxBoxGeometry
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBoxGeometry
    

#if !NATIVE
}
#endif
