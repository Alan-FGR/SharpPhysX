using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

#if NATIVE
    var x = 1;
#else
    //meh
#endif

public delegate void SharpPhysXError(
    PxErrorCode code,
    [MarshalAs(UnmanagedType.LPStr)] string message,
    [MarshalAs(UnmanagedType.LPStr)] string file,
    int line
);

public partial class PhysX
{
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFoundation OVR_PxCreateFoundation(SharpPhysXError managedErrorCallback);
    public static PxFoundation PxCreateFoundation(SharpPhysXError errorCallback){
        return OVR_PxCreateFoundation(errorCallback);
    }
}

public partial struct PxFoundation
{
    
}