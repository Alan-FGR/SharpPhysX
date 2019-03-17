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

#if !NATIVE
} // End PxAssert
#endif


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
    //Skipped unsupported operator Call.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxAssertHandler
    
    //Skipped generated implicit entry: PxAssertHandler
    

#if !NATIVE
}
#endif
