#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxAssertHandler { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxAssertHandler                                                       #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L47~49
    #if NATIVE
    ES void ~PxAssertHandler(physx::PxAssertHandler* self){
        self->~PxAssertHandler();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxAssertHandler(PxAssertHandler selfPtr);
    
    public void ~PxAssertHandler(){
        ~PxAssertHandler(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Non const pointer/reference bool*
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L50~50
    #if NATIVE
    ES void operator()(physx::PxAssertHandler* self, char exp, char file, int line,  ignore){
        char nat_in_exp = (exp);
        char nat_in_file = (file);
        int nat_in_line = (line);
         nat_in_ignore = (ignore);
        self->operator()(nat_in_exp, nat_in_file, nat_in_line, nat_in_ignore);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void operator()(PxAssertHandler selfPtr, sbyte exp, sbyte file, int line,  ignore);
    
    public void operator()(sbyte exp, sbyte file, int line,  ignore){
        sbyte pvk_in_exp = (exp);
        sbyte pvk_in_file = (file);
        int pvk_in_line = (line);
         pvk_in_ignore = (ignore);
        operator()(this, pvk_in_exp, pvk_in_file, pvk_in_line, pvk_in_ignore);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L44~44
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxAssertHandler* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxAssertHandler selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxAssertHandler                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L44~44
    #if NATIVE
    ES UNPARSED_TYPE PxAssertHandler_ctor(){
        self->PxAssertHandler();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxAssertHandler_ctor();
    
    public PxAssertHandler(){
        var _new = PxAssertHandler_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxAssertHandler                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L44~44
    #if NATIVE
    ES UNPARSED_TYPE PxAssertHandler_ctor( ){
         nat_in_ = ();
        self->PxAssertHandler(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxAssertHandler_ctor( );
    
    public PxAssertHandler( ){
         pvk_in_ = ();
        var _new = PxAssertHandler_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
