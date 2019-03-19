#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IShPxErrorCallbackWrapperPtr {
    // ShPxErrorCallbackWrapper( managedErrorCallback);
     void reportError(PxErrorCode code, string message, string file, int line);
    // ShPxErrorCallbackWrapper(/*NULLPARS*/);
    // ShPxErrorCallbackWrapper(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(ShPxErrorCallbackWrapperPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(ShPxErrorCallbackWrapperPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~ShPxErrorCallbackWrapper(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct ShPxErrorCallbackWrapperPtr : IPxErrorCallbackPtr, IShPxErrorCallbackWrapperPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type ::SharpPhysXError
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxErrorCallbackPtr, ShPxErrorCallbackWrapperPtr
    public static implicit operator PxErrorCallbackPtr(ShPxErrorCallbackWrapperPtr obj){return *(PxErrorCallbackPtr*)&obj;}
    public static explicit operator ShPxErrorCallbackWrapperPtr(PxErrorCallbackPtr obj){return *(ShPxErrorCallbackWrapperPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxErrorCallbackPtr
    //public  void ~PxErrorCallback(){((PxErrorCallbackPtr)this).~PxErrorCallback();}
    //public static UNPARSED_TYPE operator=(PxErrorCallbackPtr lhs, /*NULLPARS*/){return ((PxErrorCallbackPtr)this).operator=(/*NULLARGS*/);}
    //public  PxErrorCallback(/*NULLPARS*/){((PxErrorCallbackPtr)this).PxErrorCallback(/*NULLARGS*/);}
    //public  PxErrorCallback(/*NULLPARS*/){((PxErrorCallbackPtr)this).PxErrorCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: ShPxErrorCallbackWrapper
    Unresolved parameter type ::SharpPhysXError
    // NATIVE SIG: explicit ShPxErrorCallbackWrapper(SharpPhysXError managedErrorCallback)
            : managedErrorCallback_(managedErrorCallback)
        {}
    #if NATIVE //function start
    ES UNPARSED_TYPE W_ShPxErrorCallbackWrapper_R_ShPxErrorCallbackWrapperPtr_P__C_ShPxErrorCallbackWrapper_ctor( managedErrorCallback){
        auto nat_in_managedErrorCallback = (managedErrorCallback);
        return ShPxErrorCallbackWrapper(nat_in_managedErrorCallback);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_ShPxErrorCallbackWrapper_R_ShPxErrorCallbackWrapperPtr_P__C_ShPxErrorCallbackWrapper_ctor( managedErrorCallback);
    
    public  ShPxErrorCallbackWrapper( managedErrorCallback){
         pvk_in_managedErrorCallback = (managedErrorCallback);
        var _new = W_ShPxErrorCallbackWrapper_R_ShPxErrorCallbackWrapperPtr_P__C_ShPxErrorCallbackWrapper_ctor(pvk_in_managedErrorCallback);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       reportError                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void W_reportError_R_void_P_PxErrorCode_P_string_P_string_P_int_C_ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper* self, physx::PxErrorCode::Enum code, const char* message, const char* file, int line){
        auto nat_in_code = (code);
        auto nat_in_message = (message);
        auto nat_in_file = (file);
        auto nat_in_line = (line);
        self->reportError(nat_in_code, nat_in_message, nat_in_file, nat_in_line);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_reportError_R_void_P_PxErrorCode_P_string_P_string_P_int_C_ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapperPtr selfPtr, PxErrorCode code, string message, string file, int line);
    
    public  void reportError(PxErrorCode code, string message, string file, int line){
        PxErrorCode pvk_in_code = (code);
        string pvk_in_message = (message);
        string pvk_in_file = (file);
        int pvk_in_line = (line);
        W_reportError_R_void_P_PxErrorCode_P_string_P_string_P_int_C_ShPxErrorCallbackWrapper(this, pvk_in_code, pvk_in_message, pvk_in_file, pvk_in_line);
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: ShPxErrorCallbackWrapper
    
    //Skipped generated implicit entry: ShPxErrorCallbackWrapper
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~ShPxErrorCallbackWrapper
    

#if !NATIVE //struct close
}
#endif //struct close
