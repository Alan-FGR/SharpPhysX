#if !NATIVE
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public partial struct PxDefaultAllocator { // pointer
#endif

    //================================================================================
    //#       allocate                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    , Invalid parameter name
    , Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L92~97
    #if NATIVE
    ES UNPARSED_TYPE allocate(physx::PxDefaultAllocator* self, ::size_t size, char , char , int ){
        ::size_t nat_in_size = (size);
        char nat_in_ = ();
        char nat_in_ = ();
        int nat_in_ = ();
        UNPARSED_TYPE retVal = self->allocate(nat_in_size, nat_in_, nat_in_, nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE allocate(PxDefaultAllocator selfPtr, ulong size, sbyte , sbyte , int );
    
    public UNPARSED_TYPE allocate(ulong size, sbyte , sbyte , int ){
        ulong pvk_in_size = (size);
        sbyte pvk_in_ = ();
        sbyte pvk_in_ = ();
        int pvk_in_ = ();
        UNPARSED_TYPE retVal = allocate(this, pvk_in_size, pvk_in_, pvk_in_, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       deallocate                                                             #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::System.IntPtr
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L99~102
    #if NATIVE
    ES void deallocate(physx::PxDefaultAllocator* self,  ptr){
         nat_in_ptr = (ptr);
        self->deallocate(nat_in_ptr);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void deallocate(PxDefaultAllocator selfPtr,  ptr);
    
    public void deallocate( ptr){
         pvk_in_ptr = (ptr);
        deallocate(this, pvk_in_ptr);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDefaultAllocator                                                     #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L89~89
    #if NATIVE
    ES void PxDefaultAllocator(physx::PxDefaultAllocator* self){
         nat_in_ = ();
        self->PxDefaultAllocator(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxDefaultAllocator(PxDefaultAllocator selfPtr);
    
    public void PxDefaultAllocator( ){
         pvk_in_ = ();
        PxDefaultAllocator(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDefaultAllocator                                                     #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L89~89
    #if NATIVE
    ES void PxDefaultAllocator(physx::PxDefaultAllocator* self){
         nat_in_ = ();
        self->PxDefaultAllocator(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxDefaultAllocator(PxDefaultAllocator selfPtr);
    
    public void PxDefaultAllocator( ){
         pvk_in_ = ();
        PxDefaultAllocator(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L89~89
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxDefaultAllocator* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxDefaultAllocator selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L89~89
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxDefaultAllocator* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxDefaultAllocator selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxDefaultAllocator                                                    #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L89~89
    #if NATIVE
    ES void ~PxDefaultAllocator(physx::PxDefaultAllocator* self){
        self->~PxDefaultAllocator();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxDefaultAllocator(PxDefaultAllocator selfPtr);
    
    public void ~PxDefaultAllocator(){
        ~PxDefaultAllocator(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDefaultAllocator                                                     #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L89~89
    #if NATIVE
    ES void PxDefaultAllocator(physx::PxDefaultAllocator* self){
        self->PxDefaultAllocator();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxDefaultAllocator(PxDefaultAllocator selfPtr);
    
    public void PxDefaultAllocator(){
        PxDefaultAllocator(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
