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
    static extern PxFoundation OVR_PxCreateFoundation(SharpPhysXError managedErrorCallback);
    public static PxFoundation PxCreateFoundation(SharpPhysXError errorCallback){
        return OVR_PxCreateFoundation(errorCallback);
    }
}

public partial struct PxFoundation
{
    
}

public partial struct PxTransform
{
    public static bool operator!=(PxTransform lhs, PxTransform t){
        return !(lhs==t);
    }
}

public partial struct PxPlane
{
    public static bool operator!=(PxPlane lhs, PxPlane p){
        return !(lhs==p);
    }
}