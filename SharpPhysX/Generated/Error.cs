#if !NATIVE
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public partial struct ShPxErrorCallbackWrapper { // pointer
#endif

    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Unresolved parameter type ShPxErrorCallbackWrapper::ShPxErrorCallbackWrapper::managedErrorCallback
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L11~13
    #if NATIVE
    ES void ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper* self,  managedErrorCallback){
         nat_in_managedErrorCallback = (managedErrorCallback);
        self->ShPxErrorCallbackWrapper(nat_in_managedErrorCallback);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper selfPtr,  managedErrorCallback);
    
    public void ShPxErrorCallbackWrapper( managedErrorCallback){
         pvk_in_managedErrorCallback = (managedErrorCallback);
        ShPxErrorCallbackWrapper(this, pvk_in_managedErrorCallback);
    }
    #endif*/
    
    
    //================================================================================
    //#       reportError                                                            #
    //================================================================================
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L15~18
    #if NATIVE
    ES void reportError(ShPxErrorCallbackWrapper* self, physx::PxErrorCode::Enum code, char message, char file, int line){
        physx::PxErrorCode::Enum nat_in_code = (code);
        char nat_in_message = (message);
        char nat_in_file = (file);
        int nat_in_line = (line);
        self->reportError(nat_in_code, nat_in_message, nat_in_file, nat_in_line);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void reportError(ShPxErrorCallbackWrapper selfPtr, PxErrorCode code, sbyte message, sbyte file, int line);
    
    public void reportError(PxErrorCode code, sbyte message, sbyte file, int line){
        PxErrorCode pvk_in_code = (code);
        sbyte pvk_in_message = (message);
        sbyte pvk_in_file = (file);
        int pvk_in_line = (line);
        reportError(this, pvk_in_code, pvk_in_message, pvk_in_file, pvk_in_line);
    }
    #endif
    
    
    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES void ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper* self){
         nat_in_ = ();
        self->ShPxErrorCallbackWrapper(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper selfPtr);
    
    public void ShPxErrorCallbackWrapper( ){
         pvk_in_ = ();
        ShPxErrorCallbackWrapper(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       ShPxErrorCallbackWrapper                                               #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES void ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper* self){
         nat_in_ = ();
        self->ShPxErrorCallbackWrapper(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper selfPtr);
    
    public void ShPxErrorCallbackWrapper( ){
         pvk_in_ = ();
        ShPxErrorCallbackWrapper(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES UNPARSED_TYPE operator=(ShPxErrorCallbackWrapper* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(ShPxErrorCallbackWrapper selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES UNPARSED_TYPE operator=(ShPxErrorCallbackWrapper* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(ShPxErrorCallbackWrapper selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~ShPxErrorCallbackWrapper                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\SharpPhysX\LibSharpPhysX\Error.h L7~7
    #if NATIVE
    ES void ~ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper* self){
        self->~ShPxErrorCallbackWrapper();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~ShPxErrorCallbackWrapper(ShPxErrorCallbackWrapper selfPtr);
    
    public void ~ShPxErrorCallbackWrapper(){
        ~ShPxErrorCallbackWrapper(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif