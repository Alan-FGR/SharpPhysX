#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxPreprocessor {

//================================================================================
//#       PX_UNUSED                                                              #
//================================================================================
/* ERRORS OCCURED: Invalid parameter name (empty)
Unresolved parameter pointee T
// NATIVE SIG: void PX_UNUSED(T const&)
{
}
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L479~481
#if NATIVE
ES void W_PX_UNUSED( ){
    auto nat_in_ = ();
    PX_UNUSED(nat_in_);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_PX_UNUSED( );

public static void PX_UNUSED( ){
     pvk_in_ = ();
    W_PX_UNUSED(pvk_in_);
}
#endif*/

} // End PxPreprocessor


#if !NATIVE
public unsafe partial struct PxPackValidation { // blittable
    public sbyte _;
    public long a;

#endif

    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation W_PxPackValidation_ctor(){
        self.PxPackValidation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation W_PxPackValidation_ctor();
    
    public PxPackValidation(){
        var _new = W_PxPackValidation_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation W_PxPackValidation_ctor(PxPackValidation ){
        auto nat_in_ = ();
        self.PxPackValidation(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation W_PxPackValidation_ctor(PxPackValidation );
    
    public PxPackValidation(PxPackValidation ){
        PxPackValidation pvk_in_ = ();
        var _new = W_PxPackValidation_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation* W_operator=(PxPackValidation self, PxPackValidation ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation W_operator=(PxPackValidation selfBlt, PxPackValidation );
    
    public static PxPackValidation operator=(PxPackValidation lhs, PxPackValidation ){
        PxPackValidation pvk_in_ = ();
        PxPackValidation retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.PxPackValidation
    // NATIVE SIG: PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation W_PxPackValidation_ctor( ){
        auto nat_in_ = ();
        self.PxPackValidation(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation W_PxPackValidation_ctor( );
    
    public PxPackValidation( ){
         pvk_in_ = ();
        var _new = W_PxPackValidation_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.PxPackValidation
    // NATIVE SIG: PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation* W_operator=(PxPackValidation self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation W_operator=(PxPackValidation selfBlt);
    
    public static PxPackValidation operator=(PxPackValidation lhs,  ){
         pvk_in_ = ();
        PxPackValidation retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxPackValidation                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES void W_~PxPackValidation(PxPackValidation self){
        self.~PxPackValidation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxPackValidation(PxPackValidation selfBlt);
    
    public void ~PxPackValidation(){
        W_~PxPackValidation(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
