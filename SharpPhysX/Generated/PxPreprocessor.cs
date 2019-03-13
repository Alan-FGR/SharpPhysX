#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxPackValidation { // blittable
    public sbyte _;
    public long a;

#endif

    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation PxPackValidation_ctor(){
        self.PxPackValidation();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation PxPackValidation_ctor();
    
    public PxPackValidation(){
        var _new = PxPackValidation_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxPackValidation                                                       #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation PxPackValidation_ctor(PxPackValidation ){
        PxPackValidation nat_in_ = ();
        self.PxPackValidation(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation PxPackValidation_ctor(PxPackValidation );
    
    public PxPackValidation(PxPackValidation ){
        PxPackValidation pvk_in_ = ();
        var _new = PxPackValidation_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
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
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.PxPackValidation
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPreprocessor.h L501~501
    #if NATIVE
    ES PxPackValidation PxPackValidation_ctor( ){
         nat_in_ = ();
        self.PxPackValidation(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPackValidation PxPackValidation_ctor( );
    
    public PxPackValidation( ){
         pvk_in_ = ();
        var _new = PxPackValidation_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
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
