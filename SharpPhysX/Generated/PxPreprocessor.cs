// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public unsafe partial struct PxPackValidationPtr {
    private System.IntPtr nativePtr_;

    public static PxPackValidationPtr New(){
        return Newer_PxPackValidationPtr();
    }
    public static void Free(PxPackValidationPtr ptr){
        Freer_PxPackValidationPtr(ptr);
    }
    public void Free(){
        Freer_PxPackValidationPtr(this);
    }

    public sbyte _ {
        get => PxPackValidationPtr_GET__(this);
        set => PxPackValidationPtr_SET__(this, value);
    }

    public long a {
        get => PxPackValidationPtr_GET_a(this);
        set => PxPackValidationPtr_SET_a(this, value);
    }

}

