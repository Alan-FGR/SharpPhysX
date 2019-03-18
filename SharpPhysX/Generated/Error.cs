#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe interface IShPxErrorCallbackWrapperPtr {
    // ShPxErrorCallbackWrapper( managedErrorCallback);
     void reportError(PxErrorCode code, string message, string file, int line);
    // ShPxErrorCallbackWrapper(/*NULLPARS*/);
    // ShPxErrorCallbackWrapper(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(ShPxErrorCallbackWrapperPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(ShPxErrorCallbackWrapperPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~ShPxErrorCallbackWrapper(/*NULLPARS*/);
    
}

public unsafe partial struct ShPxErrorCallbackWrapperPtr : IPxErrorCallbackPtr, IShPxErrorCallbackWrapperPtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxErrorCallbackPtr, ShPxErrorCallbackWrapperPtr
    public static implicit operator PxErrorCallbackPtr(ShPxErrorCallbackWrapperPtr obj){return *(PxErrorCallbackPtr*)&obj;}
    public static explicit operator ShPxErrorCallbackWrapperPtr(PxErrorCallbackPtr obj){return *(ShPxErrorCallbackWrapperPtr*)&obj;}
    
    // ### Piping
    
    // --- PxErrorCallbackPtr
    //public  void ~PxErrorCallback(){((PxErrorCallbackPtr)this).~PxErrorCallback();}
    //public static UNPARSED_TYPE operator=(PxErrorCallbackPtr lhs, /*NULLPARS*/){return ((PxErrorCallbackPtr)this).operator=(/*NULLARGS*/);}
    //public  PxErrorCallback(/*NULLPARS*/){((PxErrorCallbackPtr)this).PxErrorCallback(/*NULLARGS*/);}
    //public  PxErrorCallback(/*NULLPARS*/){((PxErrorCallbackPtr)this).PxErrorCallback(/*NULLARGS*/);}
    

    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: ShPxErrorCallbackWrapper
    Unresolved parameter type ::SharpPhysXError
    // NATIVE SIG: explicit ShPxErrorCallbackWrapper(SharpPhysXError managedErrorCallback)
            : managedErrorCallback_(managedErrorCallback)
        {}
    #if NATIVE
    ES UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor( managedErrorCallback){
        auto nat_in_managedErrorCallback = (managedErrorCallback);
        self->ShPxErrorCallbackWrapper(nat_in_managedErrorCallback);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor( managedErrorCallback);
    
    public  ShPxErrorCallbackWrapper( managedErrorCallback){
         pvk_in_managedErrorCallback = (managedErrorCallback);
        var _new = W_ShPxErrorCallbackWrapper_ctor(pvk_in_managedErrorCallback);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       reportError                                                            #
    //================================================================================
    #if NATIVE
    ES void W_reportError(ShPxErrorCallbackWrapper* self, physx::PxErrorCode::Enum code, const char* message, const char* file, int line){
        auto nat_in_code = (code);
        auto nat_in_message = (message);
        auto nat_in_file = (file);
        auto nat_in_line = (line);
        self->reportError(nat_in_code, nat_in_message, nat_in_file, nat_in_line);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_reportError(ShPxErrorCallbackWrapperPtr selfPtr, PxErrorCode code, string message, string file, int line);
    
    public  void reportError(PxErrorCode code, string message, string file, int line){
        PxErrorCode pvk_in_code = (code);
        string pvk_in_message = (message);
        string pvk_in_file = (file);
        int pvk_in_line = (line);
        W_reportError(this, pvk_in_code, pvk_in_message, pvk_in_file, pvk_in_line);
    }
    #endif
    
    
    //Skipped generated implicit entry: ShPxErrorCallbackWrapper
    
    //Skipped generated implicit entry: ShPxErrorCallbackWrapper
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~ShPxErrorCallbackWrapper
    

#if !NATIVE
}
#endif
