#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxAssert {
#endif

//================================================================================
//#       PxGetAssertHandler()                                                   #
//================================================================================
#if NATIVE //function start
ES physx::PxAssertHandler* W_PxGetAssertHandler_R_PxAssertHandlerPtr(){
    auto retVal = &physx::PxGetAssertHandler();
//TODO check if it's returning addr of local
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxAssertHandlerPtr W_PxGetAssertHandler_R_PxAssertHandlerPtr();

public static PxAssertHandlerPtr PxGetAssertHandler(){
    PxAssertHandlerPtr retVal = W_PxGetAssertHandler_R_PxAssertHandlerPtr();
    return retVal;
}
#endif //function end


//================================================================================
//#       PxSetAssertHandler(PxAssertHandlerPtr handler)                         #
//================================================================================
#if NATIVE //function start
ES void W_PxSetAssertHandler_R_void_P_PxAssertHandlerPtr(physx::PxAssertHandler* handler){
    auto nat_in_handler = (handler);
    physx::PxSetAssertHandler(*nat_in_handler);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PxSetAssertHandler_R_void_P_PxAssertHandlerPtr(PxAssertHandlerPtr handler);

public static void PxSetAssertHandler(PxAssertHandlerPtr handler){
    PxAssertHandlerPtr pvk_in_handler = (handler);
    W_PxSetAssertHandler_R_void_P_PxAssertHandlerPtr(pvk_in_handler);
}
#endif //function end

#if !NATIVE //end functions holder
} //end PxAssert
#endif


#if !NATIVE //interface
public unsafe interface IPxAssertHandlerPtr {
    // void ~PxAssertHandler();
    //static void operator()(PxAssertHandlerPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxAssertHandlerPtr lhs, /*NULLPARS*/);
    // static PxAssertHandlerPtr New(/*NULLPARS*/);
    // static PxAssertHandlerPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxAssertHandlerPtr : IPxAssertHandlerPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxAssertHandlerPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxAssertHandlerPtr
    #endif //hierarchy
    //================================================================================
    //#       ~PxAssertHandler()                                                     #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxAssertHandler()
    	{
    	}
    #if NATIVE //function start
    ES void W_~PxAssertHandler_R_void_C_PxAssertHandler(physx::PxAssertHandler* self){
        self->~PxAssertHandler();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxAssertHandler_R_void_C_PxAssertHandler(PxAssertHandlerPtr selfPtr);
    
    public  void ~PxAssertHandler(){
        W_~PxAssertHandler_R_void_C_PxAssertHandler(this);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator()(string exp, string file, int line, bool* ignore)            #
    //================================================================================
    //Skipped unsupported operator Call.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxAssertHandler
    
    //Skipped generated implicit entry: PxAssertHandler
    

#if !NATIVE //struct close
}
#endif //struct close
