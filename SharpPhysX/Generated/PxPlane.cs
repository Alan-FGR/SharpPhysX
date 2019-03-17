#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxPlane { // blittable
    public PxVec3 n;
    public float d;

#endif

    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L63~65
    #if NATIVE
    ES physx::PxPlane W_PxPlane_ctor(float nx, float ny, float nz, float distance){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        auto nat_in_distance = (distance);
        self.PxPlane(nat_in_nx, nat_in_ny, nat_in_nz, nat_in_distance);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_ctor(float nx, float ny, float nz, float distance);
    
    public PxPlane(float nx, float ny, float nz, float distance){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_distance = (distance);
        var _new = W_PxPlane_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_distance);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L70~72
    #if NATIVE
    ES physx::PxPlane W_PxPlane_ctor(physx::PxVec3 normal, float distance){
        auto nat_in_normal = (normal);
        auto nat_in_distance = (distance);
        self.PxPlane(nat_in_normal, nat_in_distance);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_ctor(PxVec3 normal, float distance);
    
    public PxPlane(PxVec3 normal, float distance){
        PxVec3 pvk_in_normal = (normal);
        float pvk_in_distance = (distance);
        var _new = W_PxPlane_ctor(pvk_in_normal, pvk_in_distance);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L77~80
    #if NATIVE
    ES physx::PxPlane W_PxPlane_ctor(physx::PxVec3 point, physx::PxVec3 normal){
        auto nat_in_point = (point);
        auto nat_in_normal = (normal);
        self.PxPlane(nat_in_point, nat_in_normal);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_ctor(PxVec3 point, PxVec3 normal);
    
    public PxPlane(PxVec3 point, PxVec3 normal){
        PxVec3 pvk_in_point = (point);
        PxVec3 pvk_in_normal = (normal);
        var _new = W_PxPlane_ctor(pvk_in_point, pvk_in_normal);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxPlane                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L85~89
    #if NATIVE
    ES physx::PxPlane W_PxPlane_ctor(physx::PxVec3 p0, physx::PxVec3 p1, physx::PxVec3 p2){
        auto nat_in_p0 = (p0);
        auto nat_in_p1 = (p1);
        auto nat_in_p2 = (p2);
        self.PxPlane(nat_in_p0, nat_in_p1, nat_in_p2);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_ctor(PxVec3 p0, PxVec3 p1, PxVec3 p2);
    
    public PxPlane(PxVec3 p0, PxVec3 p1, PxVec3 p2){
        PxVec3 pvk_in_p0 = (p0);
        PxVec3 pvk_in_p1 = (p1);
        PxVec3 pvk_in_p2 = (p2);
        var _new = W_PxPlane_ctor(pvk_in_p0, pvk_in_p1, pvk_in_p2);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L94~97
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxPlane self, physx::PxPlane p){
        auto nat_in_p = (p);
        auto retVal = self.operator==(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxPlane selfBlt, PxPlane p);
    
    public static bool operator==(PxPlane lhs, PxPlane p){
        PxPlane pvk_in_p = (p);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_p);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       distance                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L99~102
    #if NATIVE
    ES float W_distance(physx::PxPlane self, physx::PxVec3 p){
        auto nat_in_p = (p);
        auto retVal = self.distance(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_distance(PxPlane selfBlt, PxVec3 p);
    
    public float distance(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        float retVal = W_distance(this, pvk_in_p);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       contains                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L104~107
    #if NATIVE
    ES bool W_contains(physx::PxPlane self, physx::PxVec3 p){
        auto nat_in_p = (p);
        auto retVal = self.contains(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_contains(PxPlane selfBlt, PxVec3 p);
    
    public bool contains(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        bool retVal = W_contains(this, pvk_in_p);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       project                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L112~115
    #if NATIVE
    ES physx::PxVec3 W_project(physx::PxPlane self, physx::PxVec3 p){
        auto nat_in_p = (p);
        auto retVal = self.project(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_project(PxPlane selfBlt, PxVec3 p);
    
    public PxVec3 project(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        PxVec3 retVal = W_project(this, pvk_in_p);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       pointInPlane                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L120~123
    #if NATIVE
    ES physx::PxVec3 W_pointInPlane(physx::PxPlane self){
        auto retVal = self.pointInPlane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_pointInPlane(PxPlane selfBlt);
    
    public PxVec3 pointInPlane(){
        PxVec3 retVal = W_pointInPlane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalize                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxPlane.h L129~134
    #if NATIVE
    ES void W_normalize(physx::PxPlane self){
        self.normalize();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_normalize(PxPlane selfBlt);
    
    public void normalize(){
        W_normalize(this);
    }
    #endif
    
    
    //Skipped generated implicit entry: PxPlane
    
    //Skipped generated implicit entry: PxPlane
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxPlane
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
