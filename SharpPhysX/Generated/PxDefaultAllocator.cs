#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxDefaultAllocator {
#endif

//================================================================================
//#       platformAlignedAlloc                                                   #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L54~57
#if NATIVE
ES void* W_platformAlignedAlloc(::size_t size){
    auto nat_in_size = (size);
    auto retVal = physx::platformAlignedAlloc(nat_in_size);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_platformAlignedAlloc(ulong size);

public static IntPtr platformAlignedAlloc(ulong size){
    ulong pvk_in_size = (size);
    IntPtr retVal = W_platformAlignedAlloc(pvk_in_size);
    return retVal;
}
#endif


//================================================================================
//#       platformAlignedFree                                                    #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L59~62
#if NATIVE
ES void W_platformAlignedFree(void* ptr){
    auto nat_in_ptr = (ptr);
    physx::platformAlignedFree(nat_in_ptr);
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_platformAlignedFree(global::System.IntPtr ptr);

public static void platformAlignedFree(global::System.IntPtr ptr){
    global::System.IntPtr pvk_in_ptr = (ptr);
    W_platformAlignedFree(pvk_in_ptr);
}
#endif

#if !NATIVE
} // End PxDefaultAllocator
#endif


#if !NATIVE
public unsafe partial struct PxDefaultAllocator { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       allocate                                                               #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Invalid parameter name (empty)
    Invalid parameter name (empty)
    // NATIVE SIG: void* allocate(size_t size, const char*, const char*, int)
    	{
    		void* ptr = platformAlignedAlloc(size);
    		PX_ASSERT((reinterpret_cast<size_t>(ptr) & 15)==0);
    		return ptr;
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L92~97
    #if NATIVE
    ES void* W_allocate(physx::PxDefaultAllocator* self, ::size_t size, const char* , const char* , int ){
        auto nat_in_size = (size);
        auto nat_in_ = ();
        auto nat_in_ = ();
        auto nat_in_ = ();
        auto retVal = self->allocate(nat_in_size, nat_in_, nat_in_, nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_allocate(PxDefaultAllocator selfPtr, ulong size, string , string , int );
    
    public IntPtr allocate(ulong size, string , string , int ){
        ulong pvk_in_size = (size);
        string pvk_in_ = ();
        string pvk_in_ = ();
        int pvk_in_ = ();
        IntPtr retVal = W_allocate(this, pvk_in_size, pvk_in_, pvk_in_, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       deallocate                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\extensions\PxDefaultAllocator.h L99~102
    #if NATIVE
    ES void W_deallocate(physx::PxDefaultAllocator* self, void* ptr){
        auto nat_in_ptr = (ptr);
        self->deallocate(nat_in_ptr);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_deallocate(PxDefaultAllocator selfPtr, global::System.IntPtr ptr);
    
    public void deallocate(global::System.IntPtr ptr){
        global::System.IntPtr pvk_in_ptr = (ptr);
        W_deallocate(this, pvk_in_ptr);
    }
    #endif
    
    
    //Skipped generated implicit entry: PxDefaultAllocator
    
    //Skipped generated implicit entry: PxDefaultAllocator
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxDefaultAllocator
    
    //Skipped generated implicit entry: PxDefaultAllocator
    

#if !NATIVE
}
#endif
