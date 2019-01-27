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

}

public partial struct PxFoundation
{
    
}