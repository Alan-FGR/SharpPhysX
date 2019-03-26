#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxDefaultAllocatorPtr {
#endif

//================================================================================
//#       platformAlignedAlloc(ulong size)                                       #
//================================================================================
#if NATIVE //function start
ES void* W_platformAlignedAlloc_R_IntPtr_P_ulong(::size_t size){
    auto nat_in_size = (size);
    auto retVal = physx::platformAlignedAlloc(nat_in_size);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern IntPtr W_platformAlignedAlloc_R_IntPtr_P_ulong(ulong size);

public static IntPtr platformAlignedAlloc(ulong size){
    ulong pvk_in_size = (size);
    IntPtr retVal = W_platformAlignedAlloc_R_IntPtr_P_ulong(pvk_in_size);
    return retVal;
}
#endif //function end


//================================================================================
//#       platformAlignedFree(IntPtr ptr)                                        #
//================================================================================
#if NATIVE //function start
ES void W_platformAlignedFree_R_void_P_IntPtr(void* ptr){
    auto nat_in_ptr = (ptr);
    physx::platformAlignedFree(nat_in_ptr);
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern void W_platformAlignedFree_R_void_P_IntPtr(IntPtr ptr);

public static void platformAlignedFree(IntPtr ptr){
    IntPtr pvk_in_ptr = (ptr);
    W_platformAlignedFree_R_void_P_IntPtr(pvk_in_ptr);
}
#endif //function end

#if !NATIVE //end functions holder
} //end PxDefaultAllocatorPtr
#endif


#if !NATIVE //interface
public unsafe interface IPxDefaultAllocatorPtr {
    // IntPtr allocate(ulong size, string , string , int );
     void deallocate(IntPtr ptr);
    // static PxDefaultAllocatorPtr New(/*NULLPARS*/);
    // static PxDefaultAllocatorPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxDefaultAllocatorPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxDefaultAllocatorPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxDefaultAllocator(/*NULLPARS*/);
    // static PxDefaultAllocatorPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxDefaultAllocatorPtr : IPxAllocatorCallbackPtr, IPxDefaultAllocatorPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxDefaultAllocatorPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxAllocatorCallbackPtr, PxDefaultAllocatorPtr
    public static implicit operator PxAllocatorCallbackPtr(PxDefaultAllocatorPtr obj){return *(PxAllocatorCallbackPtr*)&obj;}
    public static explicit operator PxDefaultAllocatorPtr(PxAllocatorCallbackPtr obj){return *(PxDefaultAllocatorPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxAllocatorCallbackPtr
    //public  void ~PxAllocatorCallback(){((PxAllocatorCallbackPtr)this).~PxAllocatorCallback();}
    //public static UNPARSED_TYPE operator=(PxAllocatorCallbackPtr lhs, /*NULLPARS*/){return ((PxAllocatorCallbackPtr)this).operator=(/*NULLARGS*/);}
    //public  static PxAllocatorCallbackPtr New(/*NULLPARS*/){((PxAllocatorCallbackPtr)this).PxAllocatorCallback(/*NULLARGS*/);}
    //public  static PxAllocatorCallbackPtr New(/*NULLPARS*/){((PxAllocatorCallbackPtr)this).PxAllocatorCallback(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       allocate(ulong size, string , string , int )                           #
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
    #if NATIVE //function start
    ES void* W_allocate_R_IntPtr_P_ulong_P_string_P_string_P_int_C_PxDefaultAllocator(physx::PxDefaultAllocator* self, ::size_t size, const char* , const char* , int ){
        auto nat_in_size = (size);
        auto nat_in_ = ();
        auto nat_in_ = ();
        auto nat_in_ = ();
        auto retVal = self->allocate(nat_in_size, nat_in_, nat_in_, nat_in_);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_allocate_R_IntPtr_P_ulong_P_string_P_string_P_int_C_PxDefaultAllocator(PxDefaultAllocatorPtr selfPtr, ulong size, string , string , int );
    
    public  IntPtr allocate(ulong size, string , string , int ){
        ulong pvk_in_size = (size);
        string pvk_in_ = ();
        string pvk_in_ = ();
        int pvk_in_ = ();
        IntPtr retVal = W_allocate_R_IntPtr_P_ulong_P_string_P_string_P_int_C_PxDefaultAllocator(this, pvk_in_size, pvk_in_, pvk_in_, pvk_in_);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       deallocate(IntPtr ptr)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_deallocate_R_void_P_IntPtr_C_PxDefaultAllocator(physx::PxDefaultAllocator* self, void* ptr){
        auto nat_in_ptr = (ptr);
        self->deallocate(nat_in_ptr);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_deallocate_R_void_P_IntPtr_C_PxDefaultAllocator(PxDefaultAllocatorPtr selfPtr, IntPtr ptr);
    
    public  void deallocate(IntPtr ptr){
        IntPtr pvk_in_ptr = (ptr);
        W_deallocate_R_void_P_IntPtr_C_PxDefaultAllocator(this, pvk_in_ptr);
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxDefaultAllocator
    
    //Skipped generated implicit entry: PxDefaultAllocator
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxDefaultAllocator
    
    //Skipped generated implicit entry: PxDefaultAllocator
    

#if !NATIVE //struct close
}
#endif //struct close
