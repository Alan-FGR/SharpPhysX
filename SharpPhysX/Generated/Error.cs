#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct ShPxErrorCallbackWrapper { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type ShPxErrorCallbackWrapper::ShPxErrorCallbackWrapper::managedErrorCallback
    // NATIVE SIG: explicit ShPxErrorCallbackWrapper(SharpPhysXError managedErrorCallback)
            : managedErrorCallback_(managedErrorCallback)
        {}
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L11~13
    #if NATIVE
    ES UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor( managedErrorCallback){
        auto nat_in_managedErrorCallback = (managedErrorCallback);
        self->ShPxErrorCallbackWrapper(nat_in_managedErrorCallback);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor( managedErrorCallback);
    
    public ShPxErrorCallbackWrapper( managedErrorCallback){
         pvk_in_managedErrorCallback = (managedErrorCallback);
        var _new = W_ShPxErrorCallbackWrapper_ctor(pvk_in_managedErrorCallback);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       reportError                                                            #
    //================================================================================
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L15~18
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
    static extern void W_reportError(ShPxErrorCallbackWrapper selfPtr, PxErrorCode code, string message, string file, int line);
    
    public void reportError(PxErrorCode code, string message, string file, int line){
        PxErrorCode pvk_in_code = (code);
        string pvk_in_message = (message);
        string pvk_in_file = (file);
        int pvk_in_line = (line);
        W_reportError(this, pvk_in_code, pvk_in_message, pvk_in_file, pvk_in_line);
    }
    #endif
    
    
    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: ShPxErrorCallbackWrapper
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor(ShPxErrorCallbackWrapper* ){
        auto nat_in_ = ();
        self->ShPxErrorCallbackWrapper(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor(ShPxErrorCallbackWrapper );
    
    public ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper ){
        ShPxErrorCallbackWrapper pvk_in_ = ();
        var _new = W_ShPxErrorCallbackWrapper_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: ShPxErrorCallbackWrapper
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor(ShPxErrorCallbackWrapper* ){
        auto nat_in_ = ();
        self->ShPxErrorCallbackWrapper(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_ShPxErrorCallbackWrapper_ctor(ShPxErrorCallbackWrapper );
    
    public ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper ){
        ShPxErrorCallbackWrapper pvk_in_ = ();
        var _new = W_ShPxErrorCallbackWrapper_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: ShPxErrorCallbackWrapper
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES ShPxErrorCallbackWrapper* W_operator=(ShPxErrorCallbackWrapper* self, ShPxErrorCallbackWrapper* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ShPxErrorCallbackWrapper W_operator=(ShPxErrorCallbackWrapper selfPtr, ShPxErrorCallbackWrapper );
    
    public static ShPxErrorCallbackWrapper operator=(ShPxErrorCallbackWrapper lhs, ShPxErrorCallbackWrapper ){
        ShPxErrorCallbackWrapper pvk_in_ = ();
        ShPxErrorCallbackWrapper retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: ShPxErrorCallbackWrapper
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES ShPxErrorCallbackWrapper* W_operator=(ShPxErrorCallbackWrapper* self, ShPxErrorCallbackWrapper* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ShPxErrorCallbackWrapper W_operator=(ShPxErrorCallbackWrapper selfPtr, ShPxErrorCallbackWrapper );
    
    public static ShPxErrorCallbackWrapper operator=(ShPxErrorCallbackWrapper lhs, ShPxErrorCallbackWrapper ){
        ShPxErrorCallbackWrapper pvk_in_ = ();
        ShPxErrorCallbackWrapper retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~ShPxErrorCallbackWrapper                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: ShPxErrorCallbackWrapper
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES void W_~ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper* self){
        self->~ShPxErrorCallbackWrapper();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper selfPtr);
    
    public void ~ShPxErrorCallbackWrapper(){
        W_~ShPxErrorCallbackWrapper(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
