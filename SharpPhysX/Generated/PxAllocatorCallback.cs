#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxAllocatorCallback { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxAllocatorCallback                                                   #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAllocatorCallback.h L58~60
    #if NATIVE
    ES void ~PxAllocatorCallback(physx::PxAllocatorCallback* self){
        self->~PxAllocatorCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxAllocatorCallback(PxAllocatorCallback selfPtr);
    
    public void ~PxAllocatorCallback(){
        ~PxAllocatorCallback(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       allocate                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAllocatorCallback.h L77~77
    #if NATIVE
    ES UNPARSED_TYPE allocate(physx::PxAllocatorCallback* self, ::size_t size, char typeName, char filename, int line){
        ::size_t nat_in_size = (size);
        char nat_in_typeName = (typeName);
        char nat_in_filename = (filename);
        int nat_in_line = (line);
        UNPARSED_TYPE retVal = self->allocate(nat_in_size, nat_in_typeName, nat_in_filename, nat_in_line);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE allocate(PxAllocatorCallback selfPtr, ulong size, sbyte typeName, sbyte filename, int line);
    
    public UNPARSED_TYPE allocate(ulong size, sbyte typeName, sbyte filename, int line){
        ulong pvk_in_size = (size);
        sbyte pvk_in_typeName = (typeName);
        sbyte pvk_in_filename = (filename);
        int pvk_in_line = (line);
        UNPARSED_TYPE retVal = allocate(this, pvk_in_size, pvk_in_typeName, pvk_in_filename, pvk_in_line);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       deallocate                                                             #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::System.IntPtr
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAllocatorCallback.h L87~87
    #if NATIVE
    ES void deallocate(physx::PxAllocatorCallback* self,  ptr){
         nat_in_ptr = (ptr);
        self->deallocate(nat_in_ptr);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void deallocate(PxAllocatorCallback selfPtr,  ptr);
    
    public void deallocate( ptr){
         pvk_in_ptr = (ptr);
        deallocate(this, pvk_in_ptr);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAllocatorCallback.h L52~52
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxAllocatorCallback* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxAllocatorCallback selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxAllocatorCallback                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAllocatorCallback.h L52~52
    #if NATIVE
    ES UNPARSED_TYPE PxAllocatorCallback_ctor( ){
         nat_in_ = ();
        self->PxAllocatorCallback(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxAllocatorCallback_ctor( );
    
    public PxAllocatorCallback( ){
         pvk_in_ = ();
        var _new = PxAllocatorCallback_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxAllocatorCallback                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxAllocatorCallback.h L52~52
    #if NATIVE
    ES UNPARSED_TYPE PxAllocatorCallback_ctor(){
        self->PxAllocatorCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxAllocatorCallback_ctor();
    
    public PxAllocatorCallback(){
        var _new = PxAllocatorCallback_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
