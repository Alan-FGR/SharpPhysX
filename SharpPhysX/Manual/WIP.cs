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
    static extern PxFoundationPtr MAN_PxCreateFoundation(SharpPhysXError managedErrorCallback);
    public static PxFoundationPtr PxCreateFoundation(SharpPhysXError errorCallback){
        return MAN_PxCreateFoundation(errorCallback);
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPhysicsPtr MAN_PxCreatePhysics(PxFoundationPtr foundation);
    public static PxPhysicsPtr PxCreatePhysics(PxFoundationPtr foundation)
    {
        return MAN_PxCreatePhysics(foundation);
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSceneDescPtr MAN_PxCreateSceneDesc();
    public static PxSceneDescPtr PxCreateSceneDesc()
    {
        return MAN_PxCreateSceneDesc();
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