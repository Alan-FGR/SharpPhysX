using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

public delegate void SharpPhysXError(
    PxErrorCode code,
    [MarshalAs(UnmanagedType.LPStr)] string message,
    [MarshalAs(UnmanagedType.LPStr)] string file,
    int line
);

public partial class PhysX
{
    public const string Lib = "LibSharpPhysX";

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFoundation MAN_PxCreateFoundation(SharpPhysXError managedErrorCallback);
    public static PxFoundation PxCreateFoundation(SharpPhysXError errorCallback){
        return MAN_PxCreateFoundation(errorCallback);
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPhysics MAN_PxCreatePhysics(PxFoundation foundation);
    public static PxPhysics PxCreatePhysics(PxFoundation foundation)
    {
        return MAN_PxCreatePhysics(foundation);
    }

}

public partial struct PxFoundation
{
    
}

public partial struct PxTransform
{
    public static bool operator!=(PxTransform lhs, PxTransform rhs){
        return !(lhs==rhs);
    }
}

public partial struct PxPlane
{
    public static bool operator!=(PxPlane lhs, PxPlane rhs){
        return !(lhs==rhs);
    }
}

public partial struct PxMat44
{
    public static bool operator !=(PxMat44 lhs, PxMat44 rhs)
    {
        return !(lhs==rhs);
    }
}

public partial struct PxMat33
{
    public static bool operator !=(PxMat33 lhs, PxMat33 rhs)
    {
        return !(lhs==rhs);
    }
}

public partial struct PxQuat
{
    public static bool operator !=(PxQuat lhs, PxQuat rhs)
    {
        return !(lhs==rhs);
    }
}