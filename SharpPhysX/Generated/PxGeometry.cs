#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxGeometryType : int {
     eSPHERE,
     ePLANE,
     eCAPSULE,
     eBOX,
     eCONVEXMESH,
     eTRIANGLEMESH,
     eHEIGHTFIELD,
     eGEOMETRY_COUNT,
     eINVALID = -1,
}
#endif

#if !NATIVE
public unsafe partial struct PxGeometryType { // blittable

#endif

    //================================================================================
    //#       PxGeometryType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType PxGeometryType_ctor(){
        self.PxGeometryType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType PxGeometryType_ctor();
    
    public PxGeometryType(){
        var _new = PxGeometryType_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType PxGeometryType_ctor(physx::PxGeometryType ){
        physx::PxGeometryType nat_in_ = ();
        self.PxGeometryType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType PxGeometryType_ctor(PxGeometryType );
    
    public PxGeometryType(PxGeometryType ){
        PxGeometryType pvk_in_ = ();
        var _new = PxGeometryType_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometryType self, physx::PxGeometryType ){
        physx::PxGeometryType nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxGeometryType selfBlt, PxGeometryType );
    
    public UNPARSED_TYPE operator=(PxGeometryType ){
        PxGeometryType pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType PxGeometryType_ctor( ){
         nat_in_ = ();
        self.PxGeometryType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType PxGeometryType_ctor( );
    
    public PxGeometryType( ){
         pvk_in_ = ();
        var _new = PxGeometryType_ctor(pvk_in_);
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
    Non const pointer/reference global::PhysX.physx.PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometryType self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxGeometryType selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxGeometryType                                                        #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES void ~PxGeometryType(physx::PxGeometryType self){
        self.~PxGeometryType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxGeometryType(PxGeometryType selfBlt);
    
    public void ~PxGeometryType(){
        ~PxGeometryType(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       getType                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L82~82
    #if NATIVE
    ES physx::PxGeometryType::Enum getType(physx::PxGeometry* self){
        physx::PxGeometryType::Enum retVal = self->getType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType getType(PxGeometry selfPtr);
    
    public PxGeometryType getType(){
        PxGeometryType retVal = getType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxGeometry                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L85~85
    #if NATIVE
    ES UNPARSED_TYPE PxGeometry_ctor(physx::PxGeometryType::Enum type){
        physx::PxGeometryType::Enum nat_in_type = (type);
        self->PxGeometry(nat_in_type);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxGeometry_ctor(PxGeometryType type);
    
    public PxGeometry(PxGeometryType type){
        PxGeometryType pvk_in_type = (type);
        var _new = PxGeometry_ctor(pvk_in_type);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometry                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE PxGeometry_ctor( ){
         nat_in_ = ();
        self->PxGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxGeometry_ctor( );
    
    public PxGeometry( ){
         pvk_in_ = ();
        var _new = PxGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometry                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE PxGeometry_ctor( ){
         nat_in_ = ();
        self->PxGeometry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxGeometry_ctor( );
    
    public PxGeometry( ){
         pvk_in_ = ();
        var _new = PxGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxGeometry                                                            #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES void ~PxGeometry(physx::PxGeometry* self){
        self->~PxGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxGeometry(PxGeometry selfPtr);
    
    public void ~PxGeometry(){
        ~PxGeometry(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxGeometry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxGeometry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
