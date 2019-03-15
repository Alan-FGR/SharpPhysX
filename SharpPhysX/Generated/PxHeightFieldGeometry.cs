#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif




#if !NATIVE
public unsafe partial struct PxHeightFieldGeometry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PX_INLINE PxHeightFieldGeometry() :		
    		PxGeometry		(PxGeometryType::eHEIGHTFIELD),
    		heightField		(NULL),
    		heightScale		(1.0f), 
    		rowScale		(1.0f), 
    		columnScale		(1.0f), 
    		heightFieldFlags(0)
    	{}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L59~66
    #if NATIVE
    ES UNPARSED_TYPE W_PxHeightFieldGeometry_ctor(){
        self->PxHeightFieldGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHeightFieldGeometry_ctor();
    
    public PxHeightFieldGeometry(){
        var _new = W_PxHeightFieldGeometry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxHeightFieldGeometry::PxHeightFieldGeometry::flags
    // NATIVE SIG: PX_INLINE PxHeightFieldGeometry(PxHeightField* hf,
    									PxMeshGeometryFlags flags, 
    									PxReal heightScale_,
    									PxReal rowScale_, 
    									PxReal columnScale_) :
    		PxGeometry			(PxGeometryType::eHEIGHTFIELD), 
    		heightField			(hf) ,
    		heightScale			(heightScale_), 
    		rowScale			(rowScale_), 
    		columnScale			(columnScale_), 
    		heightFieldFlags	(flags)
    		{
    		}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L68~80
    #if NATIVE
    ES UNPARSED_TYPE W_PxHeightFieldGeometry_ctor(physx::PxHeightField* hf,  flags, physx::PxReal heightScale_, physx::PxReal rowScale_, physx::PxReal columnScale_){
        auto nat_in_hf = (hf);
        auto nat_in_flags = (flags);
        auto nat_in_heightScale_ = (heightScale_);
        auto nat_in_rowScale_ = (rowScale_);
        auto nat_in_columnScale_ = (columnScale_);
        self->PxHeightFieldGeometry(nat_in_hf, nat_in_flags, nat_in_heightScale_, nat_in_rowScale_, nat_in_columnScale_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHeightFieldGeometry_ctor(PxHeightField hf,  flags, float heightScale_, float rowScale_, float columnScale_);
    
    public PxHeightFieldGeometry(PxHeightField hf,  flags, float heightScale_, float rowScale_, float columnScale_){
        PxHeightField pvk_in_hf = (hf);
         pvk_in_flags = (flags);
        float pvk_in_heightScale_ = (heightScale_);
        float pvk_in_rowScale_ = (rowScale_);
        float pvk_in_columnScale_ = (columnScale_);
        var _new = W_PxHeightFieldGeometry_ctor(pvk_in_hf, pvk_in_flags, pvk_in_heightScale_, pvk_in_rowScale_, pvk_in_columnScale_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L92~92
    #if NATIVE
    ES bool W_isValid(physx::PxHeightFieldGeometry* self){
        auto retVal = self->isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxHeightFieldGeometry selfPtr);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxHeightFieldGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE W_PxHeightFieldGeometry_ctor(physx::PxHeightFieldGeometry* ){
        auto nat_in_ = ();
        self->PxHeightFieldGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHeightFieldGeometry_ctor(PxHeightFieldGeometry );
    
    public PxHeightFieldGeometry(PxHeightFieldGeometry ){
        PxHeightFieldGeometry pvk_in_ = ();
        var _new = W_PxHeightFieldGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHeightFieldGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxHeightFieldGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE W_PxHeightFieldGeometry_ctor(physx::PxHeightFieldGeometry* ){
        auto nat_in_ = ();
        self->PxHeightFieldGeometry(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxHeightFieldGeometry_ctor(PxHeightFieldGeometry );
    
    public PxHeightFieldGeometry(PxHeightFieldGeometry ){
        PxHeightFieldGeometry pvk_in_ = ();
        var _new = W_PxHeightFieldGeometry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxHeightFieldGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES physx::PxHeightFieldGeometry* W_operator=(physx::PxHeightFieldGeometry* self, physx::PxHeightFieldGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometry W_operator=(PxHeightFieldGeometry selfPtr, PxHeightFieldGeometry );
    
    public static PxHeightFieldGeometry operator=(PxHeightFieldGeometry lhs, PxHeightFieldGeometry ){
        PxHeightFieldGeometry pvk_in_ = ();
        PxHeightFieldGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxHeightFieldGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES physx::PxHeightFieldGeometry* W_operator=(physx::PxHeightFieldGeometry* self, physx::PxHeightFieldGeometry* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHeightFieldGeometry W_operator=(PxHeightFieldGeometry selfPtr, PxHeightFieldGeometry );
    
    public static PxHeightFieldGeometry operator=(PxHeightFieldGeometry lhs, PxHeightFieldGeometry ){
        PxHeightFieldGeometry pvk_in_ = ();
        PxHeightFieldGeometry retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxHeightFieldGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxHeightFieldGeometry
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxHeightFieldGeometry.h L56~56
    #if NATIVE
    ES void W_~PxHeightFieldGeometry(physx::PxHeightFieldGeometry* self){
        self->~PxHeightFieldGeometry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxHeightFieldGeometry(PxHeightFieldGeometry selfPtr);
    
    public void ~PxHeightFieldGeometry(){
        W_~PxHeightFieldGeometry(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
