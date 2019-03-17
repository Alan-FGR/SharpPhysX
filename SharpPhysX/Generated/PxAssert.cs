#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxAssert {
#endif

//================================================================================
//#       PxGetAssertHandler                                                     #
//================================================================================
#if NATIVE
ES physx::PxAssertHandler* W_PxGetAssertHandler(){
    auto retVal = &physx::PxGetAssertHandler();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxAssertHandlerPtr W_PxGetAssertHandler();

public static PxAssertHandlerPtr PxGetAssertHandler(){
    PxAssertHandlerPtr retVal = W_PxGetAssertHandler();
    return retVal;
}
#endif


//================================================================================
//#       PxSetAssertHandler                                                     #
//================================================================================
#if NATIVE
ES void W_PxSetAssertHandler(physx::PxAssertHandler* handler){
    auto nat_in_handler = (handler);
    physx::PxSetAssertHandler(*nat_in_handler);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxSetAssertHandler(PxAssertHandlerPtr handler);

public static void PxSetAssertHandler(PxAssertHandlerPtr handler){
    PxAssertHandlerPtr pvk_in_handler = (handler);
    W_PxSetAssertHandler(pvk_in_handler);
}
#endif

#if !NATIVE
} // End PxAssert
#endif


#if !NATIVE
public unsafe partial struct PxAssertHandlerPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxAssertHandler                                                       #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxAssertHandler()
    	{
    	}
    #if NATIVE
    ES void W_~PxAssertHandler(physx::PxAssertHandler* self){
        self->~PxAssertHandler();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxAssertHandler(PxAssertHandlerPtr selfPtr);
    
    public void ~PxAssertHandler(){
        W_~PxAssertHandler(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    //Skipped unsupported operator Call.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxAssertHandler
    
    //Skipped generated implicit entry: PxAssertHandler
    

#if !NATIVE
}
#endif
