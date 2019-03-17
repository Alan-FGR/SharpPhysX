#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxGeometryType : int {
    eSPHERE = 0,                     // eSPHERE
    ePLANE = 1,                      // ePLANE
    eCAPSULE = 2,                    // eCAPSULE
    eBOX = 3,                        // eBOX
    eCONVEXMESH = 4,                 // eCONVEXMESH
    eTRIANGLEMESH = 5,               // eTRIANGLEMESH
    eHEIGHTFIELD = 6,                // eHEIGHTFIELD
    eGEOMETRY_COUNT = 7,             // eGEOMETRY_COUNT
    eINVALID = -1,                   // eINVALID = -1
}
#endif


// Class physx::PxGeometryType is enum namespace
#if !NATIVE
public unsafe partial struct PxGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       getType                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L82~82
    #if NATIVE
    ES physx::PxGeometryType::Enum W_getType(physx::PxGeometry* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getType(PxGeometry selfPtr);
    
    public PxGeometryType getType(){
        PxGeometryType retVal = W_getType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxGeometry                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxGeometry
    // NATIVE SIG: PX_FORCE_INLINE PxGeometry(PxGeometryType::Enum type) : mType(type) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L85~85
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometry_ctor(physx::PxGeometryType::Enum type){
        auto nat_in_type = (type);
        self->PxGeometry(nat_in_type);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometry_ctor(PxGeometryType type);
    
    public PxGeometry(PxGeometryType type){
        PxGeometryType pvk_in_type = (type);
        var _new = W_PxGeometry_ctor(pvk_in_type);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //Skipped generated implicit entry: PxGeometry
    
    //Skipped generated implicit entry: PxGeometry
    
    //Skipped generated implicit entry: ~PxGeometry
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
