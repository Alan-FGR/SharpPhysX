//Generated by MinBinder.
using System;
using System.Runtime.InteropServices;

public enum PxGeometryType {
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
public partial struct PxGeometryType {


}
public partial class PxGeometry {
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern Enum C_CONST_PxGeometry_getType(PxGeometry cls);
    public Enum getType(){
        return C_CONST_PxGeometry_getType(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometry C_PxGeometry_PxGeometry(Enum type);
    public unsafe PxGeometry(Enum type){
        var _new = C_PxGeometry_PxGeometry(type);        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }


}
