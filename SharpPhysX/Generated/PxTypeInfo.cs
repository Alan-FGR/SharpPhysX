#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxConcreteType : int {
     eUNDEFINED,
     eHEIGHTFIELD,
     eCONVEX_MESH,
     eTRIANGLE_MESH_BVH33,
     eTRIANGLE_MESH_BVH34,
     eRIGID_DYNAMIC,
     eRIGID_STATIC,
     eSHAPE,
     eMATERIAL,
     eCONSTRAINT,
     eAGGREGATE,
     eARTICULATION,
     eARTICULATION_LINK,
     eARTICULATION_JOINT,
     ePRUNING_STRUCTURE,
     eBVH_STRUCTURE,
     ePHYSX_CORE_COUNT,
     eFIRST_PHYSX_EXTENSION = 256,
     eFIRST_VEHICLE_EXTENSION = 512,
     eFIRST_USER_EXTENSION = 1024,
}
#endif















#if !NATIVE
public unsafe partial struct PxConcreteType { // blittable

#endif

    //================================================================================
    //#       PxConcreteType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType W_PxConcreteType_ctor(){
        self.PxConcreteType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType W_PxConcreteType_ctor();
    
    public PxConcreteType(){
        var _new = W_PxConcreteType_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConcreteType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType W_PxConcreteType_ctor(physx::PxConcreteType ){
        auto nat_in_ = ();
        self.PxConcreteType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType W_PxConcreteType_ctor(PxConcreteType );
    
    public PxConcreteType(PxConcreteType ){
        PxConcreteType pvk_in_ = ();
        var _new = W_PxConcreteType_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType* W_operator=(physx::PxConcreteType self, physx::PxConcreteType ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType W_operator=(PxConcreteType selfBlt, PxConcreteType );
    
    public static PxConcreteType operator=(PxConcreteType lhs, PxConcreteType ){
        PxConcreteType pvk_in_ = ();
        PxConcreteType retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConcreteType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxConcreteType
    // NATIVE SIG: PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType W_PxConcreteType_ctor( ){
        auto nat_in_ = ();
        self.PxConcreteType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType W_PxConcreteType_ctor( );
    
    public PxConcreteType( ){
         pvk_in_ = ();
        var _new = W_PxConcreteType_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxConcreteType
    // NATIVE SIG: PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType* W_operator=(physx::PxConcreteType self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType W_operator=(PxConcreteType selfBlt);
    
    public static PxConcreteType operator=(PxConcreteType lhs,  ){
         pvk_in_ = ();
        PxConcreteType retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConcreteType                                                        #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES void W_~PxConcreteType(physx::PxConcreteType self){
        self.~PxConcreteType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConcreteType(PxConcreteType selfBlt);
    
    public void ~PxConcreteType(){
        W_~PxConcreteType(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif




