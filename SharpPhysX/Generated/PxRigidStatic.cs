#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxRigidStatic { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidStatic.h L62~62
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxRigidStatic* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxRigidStatic selfPtr);
    
    public IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxRigidStatic                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidStatic
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidStatic(PxType concreteType, PxBaseFlags baseFlags) : PxRigidActor(concreteType, baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidStatic.h L65~65
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidStatic_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidStatic(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidStatic_ctor(ushort concreteType,  baseFlags);
    
    public PxRigidStatic(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidStatic_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxRigidStatic                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxRigidStatic
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE					PxRigidStatic(PxBaseFlags baseFlags) : PxRigidActor(baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidStatic.h L66~66
    #if NATIVE
    ES UNPARSED_TYPE W_PxRigidStatic_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxRigidStatic(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxRigidStatic_ctor( baseFlags);
    
    public PxRigidStatic( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxRigidStatic_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxRigidStatic                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxRigidStatic() {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidStatic.h L67~67
    #if NATIVE
    ES void W_~PxRigidStatic(physx::PxRigidStatic* self){
        self->~PxRigidStatic();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxRigidStatic(PxRigidStatic selfPtr);
    
    public void ~PxRigidStatic(){
        W_~PxRigidStatic(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxRigidStatic.h L68~68
    #if NATIVE
    ES bool W_isKindOf(physx::PxRigidStatic* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxRigidStatic selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxRigidStatic
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif