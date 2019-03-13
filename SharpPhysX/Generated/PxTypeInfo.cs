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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType PxConcreteType_ctor(){
        self.PxConcreteType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType PxConcreteType_ctor();
    
    public PxConcreteType(){
        var _new = PxConcreteType_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConcreteType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType PxConcreteType_ctor(physx::PxConcreteType ){
        physx::PxConcreteType nat_in_ = ();
        self.PxConcreteType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType PxConcreteType_ctor(PxConcreteType );
    
    public PxConcreteType(PxConcreteType ){
        PxConcreteType pvk_in_ = ();
        var _new = PxConcreteType_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxConcreteType self, physx::PxConcreteType ){
        physx::PxConcreteType nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxConcreteType selfBlt, PxConcreteType );
    
    public UNPARSED_TYPE operator=(PxConcreteType ){
        PxConcreteType pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConcreteType                                                         #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES physx::PxConcreteType PxConcreteType_ctor( ){
         nat_in_ = ();
        self.PxConcreteType(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConcreteType PxConcreteType_ctor( );
    
    public PxConcreteType( ){
         pvk_in_ = ();
        var _new = PxConcreteType_ctor(pvk_in_);
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
    Non const pointer/reference global::PhysX.physx.PxConcreteType
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxConcreteType self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxConcreteType selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConcreteType                                                        #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxTypeInfo.h L53~53
    #if NATIVE
    ES void ~PxConcreteType(physx::PxConcreteType self){
        self.~PxConcreteType();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxConcreteType(PxConcreteType selfBlt);
    
    public void ~PxConcreteType(){
        ~PxConcreteType(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif




