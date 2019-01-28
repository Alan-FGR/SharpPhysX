//Generated by MinBinder.
using System;
using System.Runtime.InteropServices;
using PxBaseFlags = System.UInt32;
using PxActorFlags = System.UInt32;

public enum PxGeometryType : int {
 eSPHERE,
 ePLANE,
 eCAPSULE,
 eBOX,
 eCONVEXMESH,
 eTRIANGLEMESH,
 eHEIGHTFIELD,
 eGEOMETRY_COUNT,
 eINVALID = -1,

}

public interface IPxGeometry {
    PxGeometryType getType();
}

public partial struct PxGeometry : IPxGeometry { // blittable


    public PxGeometryType mType;

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType C_CONST_PxGeometry_getType(PxGeometry cls);
    public PxGeometryType getType(){
        return C_CONST_PxGeometry_getType(this);    
    }


}
