//Generated by MinBinder.
using System;
using System.Runtime.InteropServices;

public static partial class physx{
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAssertHandler C_REF_PxGetAssertHandler();
    public static PxAssertHandler PxGetAssertHandler(){
        return C_REF_PxGetAssertHandler();    
    }


}

