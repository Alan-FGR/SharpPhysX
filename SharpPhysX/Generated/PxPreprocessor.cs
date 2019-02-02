#if !NATIVE
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public partial struct PxPackValidation { // blittable
#endif

    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES void PxPackValidation(PxPackValidation self){
        self.PxPackValidation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxPackValidation(PxPackValidation selfBlt);
    
    public void PxPackValidation(){
        PxPackValidation(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES void PxPackValidation(PxPackValidation self, PxPackValidation ){
        PxPackValidation nat_in_ = ();
        self.PxPackValidation(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxPackValidation(PxPackValidation selfBlt, PxPackValidation );
    
    public void PxPackValidation(PxPackValidation ){
        PxPackValidation pvk_in_ = ();
        PxPackValidation(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES UNPARSED_TYPE operator=(PxPackValidation self, PxPackValidation ){
        PxPackValidation nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxPackValidation selfBlt, PxPackValidation );
    
    public UNPARSED_TYPE operator=(PxPackValidation ){
        PxPackValidation pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    Non const pointer/reference global::PhysX.PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES void PxPackValidation(PxPackValidation self){
         nat_in_ = ();
        self.PxPackValidation(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxPackValidation(PxPackValidation selfBlt);
    
    public void PxPackValidation( ){
         pvk_in_ = ();
        PxPackValidation(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    Non const pointer/reference global::PhysX.PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES UNPARSED_TYPE operator=(PxPackValidation self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxPackValidation selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxPackValidation                                                      #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES void ~PxPackValidation(PxPackValidation self){
        self.~PxPackValidation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxPackValidation(PxPackValidation selfBlt);
    
    public void ~PxPackValidation(){
        ~PxPackValidation(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
