#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
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
#endif //enum


// Class physx::PxGeometryType is enum namespace
#if !NATIVE //interface
public unsafe interface IPxGeometryPtr {
     PxGeometryType getType();
    // PxGeometry(/*NULLPARS*/);
    // PxGeometry(/*NULLPARS*/);
    // PxGeometry(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxGeometry(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxGeometryPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxGeometryPtr : IPxGeometryPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields
    //Skipped protected field: mType

    #if !NATIVE //hierarchy
    // Hierarchy: PxGeometryPtr
    #endif //hierarchy
    //================================================================================
    //#       getType                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxGeometryType::Enum W_getType_R_PxGeometryType_C_PxGeometry(physx::PxGeometry* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getType_R_PxGeometryType_C_PxGeometry(PxGeometryPtr selfPtr);
    
    public  PxGeometryType getType(){
        PxGeometryType retVal = W_getType_R_PxGeometryType_C_PxGeometry(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxGeometry
    
    //Skipped generated implicit entry: PxGeometry
    
    //Skipped generated implicit entry: PxGeometry
    
    //Skipped generated implicit entry: ~PxGeometry
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
