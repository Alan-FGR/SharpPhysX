#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxErrorCallback { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxErrorCallback                                                       #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrorCallback.h L54~56
    #if NATIVE
    ES void ~PxErrorCallback(physx::PxErrorCallback* self){
        self->~PxErrorCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxErrorCallback(PxErrorCallback selfPtr);
    
    public void ~PxErrorCallback(){
        ~PxErrorCallback(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       reportError                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrorCallback.h L65~65
    #if NATIVE
    ES void reportError(physx::PxErrorCallback* self, physx::PxErrorCode::Enum code, char message, char file, int line){
        physx::PxErrorCode::Enum nat_in_code = (code);
        char nat_in_message = (message);
        char nat_in_file = (file);
        int nat_in_line = (line);
        self->reportError(nat_in_code, nat_in_message, nat_in_file, nat_in_line);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void reportError(PxErrorCallback selfPtr, PxErrorCode code, sbyte message, sbyte file, int line);
    
    public void reportError(PxErrorCode code, sbyte message, sbyte file, int line){
        PxErrorCode pvk_in_code = (code);
        sbyte pvk_in_message = (message);
        sbyte pvk_in_file = (file);
        int pvk_in_line = (line);
        reportError(this, pvk_in_code, pvk_in_message, pvk_in_file, pvk_in_line);
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrorCallback.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxErrorCallback* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxErrorCallback selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxErrorCallback                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrorCallback.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE PxErrorCallback_ctor( ){
         nat_in_ = ();
        self->PxErrorCallback(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxErrorCallback_ctor( );
    
    public PxErrorCallback( ){
         pvk_in_ = ();
        var _new = PxErrorCallback_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxErrorCallback                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrorCallback.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE PxErrorCallback_ctor(){
        self->PxErrorCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxErrorCallback_ctor();
    
    public PxErrorCallback(){
        var _new = PxErrorCallback_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
