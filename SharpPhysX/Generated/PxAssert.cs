#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxAssert {

//================================================================================
//#       PxGetAssertHandler                                                     #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L53~53
#if NATIVE
ES physx::PxAssertHandler* W_PxGetAssertHandler(){
    auto retVal = &physx::PxGetAssertHandler();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxAssertHandler W_PxGetAssertHandler();

public static PxAssertHandler PxGetAssertHandler(){
    PxAssertHandler retVal = W_PxGetAssertHandler();
    return retVal;
}
#endif


//================================================================================
//#       PxSetAssertHandler                                                     #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L54~54
#if NATIVE
ES void W_PxSetAssertHandler(physx::PxAssertHandler* handler){
    auto nat_in_handler = (handler);
    physx::PxSetAssertHandler(*nat_in_handler);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxSetAssertHandler(PxAssertHandler handler);

public static void PxSetAssertHandler(PxAssertHandler handler){
    PxAssertHandler pvk_in_handler = (handler);
    W_PxSetAssertHandler(pvk_in_handler);
}
#endif

} // End PxAssert


#if !NATIVE
public unsafe partial struct PxAssertHandler { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxAssertHandler                                                       #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxAssertHandler()
    	{
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L47~49
    #if NATIVE
    ES void W_~PxAssertHandler(physx::PxAssertHandler* self){
        self->~PxAssertHandler();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxAssertHandler(PxAssertHandler selfPtr);
    
    public void ~PxAssertHandler(){
        W_~PxAssertHandler(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: void operator()(const char* exp, const char* file, int line, bool& ignore) = 0
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L50~50
    #if NATIVE
    ES void W_operator()(physx::PxAssertHandler* self, const char* exp, const char* file, int line, bool& ignore){
        auto nat_in_exp = (exp);
        auto nat_in_file = (file);
        auto nat_in_line = (line);
        auto nat_in_ignore = (ignore);
        self->operator()(nat_in_exp, nat_in_file, nat_in_line, nat_in_ignore);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_operator()(PxAssertHandler selfPtr, string exp, string file, int line, bool* ignore);
    
    public static void operator()(PxAssertHandler lhs, string exp, string file, int line, bool* ignore){
        string pvk_in_exp = (exp);
        string pvk_in_file = (file);
        int pvk_in_line = (line);
        bool* pvk_in_ignore = (ignore);
        W_operator()(lhs, pvk_in_exp, pvk_in_file, pvk_in_line, pvk_in_ignore);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxAssertHandler
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L44~44
    #if NATIVE
    ES physx::PxAssertHandler* W_operator=(physx::PxAssertHandler* self, physx::PxAssertHandler* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxAssertHandler W_operator=(PxAssertHandler selfPtr, PxAssertHandler );
    
    public static PxAssertHandler operator=(PxAssertHandler lhs, PxAssertHandler ){
        PxAssertHandler pvk_in_ = ();
        PxAssertHandler retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxAssertHandler                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PxAssertHandler
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L44~44
    #if NATIVE
    ES UNPARSED_TYPE W_PxAssertHandler_ctor(){
        self->PxAssertHandler();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxAssertHandler_ctor();
    
    public PxAssertHandler(){
        var _new = W_PxAssertHandler_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxAssertHandler                                                        #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxAssertHandler
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAssert.h L44~44
    #if NATIVE
    ES UNPARSED_TYPE W_PxAssertHandler_ctor(physx::PxAssertHandler* ){
        auto nat_in_ = ();
        self->PxAssertHandler(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxAssertHandler_ctor(PxAssertHandler );
    
    public PxAssertHandler(PxAssertHandler ){
        PxAssertHandler pvk_in_ = ();
        var _new = W_PxAssertHandler_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
