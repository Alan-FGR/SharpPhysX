#if !NATIVE
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public partial struct PxErrorCode { // blittable
#endif

    //================================================================================
    //#       PxErrorCode                                                            #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrors.h L51~51
    #if NATIVE
    ES void PxErrorCode(physx::PxErrorCode self){
        self.PxErrorCode();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxErrorCode(PxErrorCode selfBlt);
    
    public void PxErrorCode(){
        PxErrorCode(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxErrorCode                                                            #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrors.h L51~51
    #if NATIVE
    ES void PxErrorCode(physx::PxErrorCode self, physx::PxErrorCode ){
        physx::PxErrorCode nat_in_ = ();
        self.PxErrorCode(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxErrorCode(PxErrorCode selfBlt, PxErrorCode );
    
    public void PxErrorCode(PxErrorCode ){
        PxErrorCode pvk_in_ = ();
        PxErrorCode(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrors.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxErrorCode self, physx::PxErrorCode ){
        physx::PxErrorCode nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxErrorCode selfBlt, PxErrorCode );
    
    public UNPARSED_TYPE operator=(PxErrorCode ){
        PxErrorCode pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxErrorCode                                                            #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxErrorCode
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrors.h L51~51
    #if NATIVE
    ES void PxErrorCode(physx::PxErrorCode self){
         nat_in_ = ();
        self.PxErrorCode(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxErrorCode(PxErrorCode selfBlt);
    
    public void PxErrorCode( ){
         pvk_in_ = ();
        PxErrorCode(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxErrorCode
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrors.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxErrorCode self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxErrorCode selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxErrorCode                                                           #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxErrors.h L51~51
    #if NATIVE
    ES void ~PxErrorCode(physx::PxErrorCode self){
        self.~PxErrorCode();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxErrorCode(PxErrorCode selfBlt);
    
    public void ~PxErrorCode(){
        ~PxErrorCode(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
