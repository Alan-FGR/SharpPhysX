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
    // NATIVE SIG: PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType W_PxGeometryType_ctor(){
        self.PxGeometryType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_PxGeometryType_ctor();
    
    public PxGeometryType(){
        var _new = W_PxGeometryType_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType W_PxGeometryType_ctor(physx::PxGeometryType ){
        auto nat_in_ = ();
        self.PxGeometryType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_PxGeometryType_ctor(PxGeometryType );
    
    public PxGeometryType(PxGeometryType ){
        PxGeometryType pvk_in_ = ();
        var _new = W_PxGeometryType_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType* W_operator=(physx::PxGeometryType self, physx::PxGeometryType ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_operator=(PxGeometryType selfBlt, PxGeometryType );
    
    public static PxGeometryType operator=(PxGeometryType lhs, PxGeometryType ){
        PxGeometryType pvk_in_ = ();
        PxGeometryType retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometryType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxGeometryType
    // NATIVE SIG: PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType W_PxGeometryType_ctor( ){
        auto nat_in_ = ();
        self.PxGeometryType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_PxGeometryType_ctor( );
    
    public PxGeometryType( ){
         pvk_in_ = ();
        var _new = W_PxGeometryType_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxGeometryType
    // NATIVE SIG: PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES physx::PxGeometryType* W_operator=(physx::PxGeometryType self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_operator=(PxGeometryType selfBlt);
    
    public static PxGeometryType operator=(PxGeometryType lhs,  ){
         pvk_in_ = ();
        PxGeometryType retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxGeometryType                                                        #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxGeometryType
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L51~51
    #if NATIVE
    ES void W_~PxGeometryType(physx::PxGeometryType self){
        self.~PxGeometryType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxGeometryType(PxGeometryType selfBlt);
    
    public void ~PxGeometryType(){
        W_~PxGeometryType(this);
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
    ES physx::PxGeometryType::Enum W_getType(physx::PxGeometry* self){
        auto retVal = self->getType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getType(PxGeometry selfPtr);
    
    public PxGeometryType getType(){
        PxGeometryType retVal = W_getType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxGeometry                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PX_FORCE_INLINE PxGeometry(PxGeometryType::Enum type) : mType(type) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L85~85
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometry_ctor(physx::PxGeometryType::Enum type){
        auto nat_in_type = (type);
        self->PxGeometry(nat_in_type);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometry_ctor(PxGeometryType type);
    
    public PxGeometry(PxGeometryType type){
        PxGeometryType pvk_in_type = (type);
        var _new = W_PxGeometry_ctor(pvk_in_type);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometry                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometry_ctor(physx::PxGeometry* ){
        auto nat_in_ = ();
        self->PxGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometry_ctor(PxGeometry );
    
    public PxGeometry(PxGeometry ){
        PxGeometry pvk_in_ = ();
        var _new = W_PxGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxGeometry                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE W_PxGeometry_ctor(physx::PxGeometry* ){
        auto nat_in_ = ();
        self->PxGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxGeometry_ctor(PxGeometry );
    
    public PxGeometry(PxGeometry ){
        PxGeometry pvk_in_ = ();
        var _new = W_PxGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxGeometry                                                            #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES void W_~PxGeometry(physx::PxGeometry* self){
        self->~PxGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxGeometry(PxGeometry selfPtr);
    
    public void ~PxGeometry(){
        W_~PxGeometry(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES physx::PxGeometry* W_operator=(physx::PxGeometry* self, physx::PxGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometry W_operator=(PxGeometry selfPtr, PxGeometry );
    
    public static PxGeometry operator=(PxGeometry lhs, PxGeometry ){
        PxGeometry pvk_in_ = ();
        PxGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxGeometry.h L75~75
    #if NATIVE
    ES physx::PxGeometry* W_operator=(physx::PxGeometry* self, physx::PxGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometry W_operator=(PxGeometry selfPtr, PxGeometry );
    
    public static PxGeometry operator=(PxGeometry lhs, PxGeometry ){
        PxGeometry pvk_in_ = ();
        PxGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
