#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxPlane {
    ///*No paramless ctor in C#*/ static PxPlane Default();
    // PxPlane(float nx, float ny, float nz, float distance);
    // PxPlane(PxVec3 normal, float distance);
    // PxPlane(PxVec3 point, PxVec3 normal);
    // PxPlane(PxVec3 p0, PxVec3 p1, PxVec3 p2);
    //static bool operator==(PxPlane lhs, PxPlane p);
     float distance(PxVec3 p);
     bool contains(PxVec3 p);
     PxVec3 project(PxVec3 p);
     PxVec3 pointInPlane();
     void normalize();
    // PxPlane(/*NULLPARS*/);
    // PxPlane(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxPlane lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxPlane(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxPlane lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxPlane : IPxPlane { // blittable
    public PxVec3 n;
    public float d;

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxPlanePOD{
    physx::PxVec3 n;
    float d;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxPlane
    #endif //hierarchy
    //================================================================================
    //#       PxPlane()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES PxPlanePOD W_PxPlane_R_PxPlane_C_PxPlane_ctor(){
        auto val = PxPlane();
        return *(PxPlanePOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_R_PxPlane_C_PxPlane_ctor();
    
    public /*No paramless ctor in C#*/ static PxPlane Default(){
        return (W_PxPlane_R_PxPlane_C_PxPlane_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxPlane(float nx, float ny, float nz, float distance)                  #
    //================================================================================
    #if NATIVE //function start
    ES PxPlanePOD W_PxPlane_R_PxPlane_P_float_P_float_P_float_P_float_C_PxPlane_ctor(float nx, float ny, float nz, float distance){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        auto nat_in_distance = (distance);
        auto val = PxPlane();
        return *(PxPlanePOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_R_PxPlane_P_float_P_float_P_float_P_float_C_PxPlane_ctor(float nx, float ny, float nz, float distance);
    
    public  PxPlane(float nx, float ny, float nz, float distance){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_distance = (distance);
        var _new = (W_PxPlane_R_PxPlane_P_float_P_float_P_float_P_float_C_PxPlane_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_distance));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxPlane(PxVec3Ptr normal, float distance)                              #
    //================================================================================
    #if NATIVE //function start
    ES PxPlanePOD W_PxPlane_R_PxPlane_P_PxVec3_P_float_C_PxPlane_ctor(physx::PxVec3 normal, float distance){
        auto nat_in_normal = (normal);
        auto nat_in_distance = (distance);
        auto val = PxPlane();
        return *(PxPlanePOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_R_PxPlane_P_PxVec3_P_float_C_PxPlane_ctor(PxVec3 normal, float distance);
    
    public  PxPlane(PxVec3 normal, float distance){
        PxVec3 pvk_in_normal = (normal);
        float pvk_in_distance = (distance);
        var _new = (W_PxPlane_R_PxPlane_P_PxVec3_P_float_C_PxPlane_ctor(pvk_in_normal, pvk_in_distance));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxPlane(PxVec3Ptr point, PxVec3Ptr normal)                             #
    //================================================================================
    #if NATIVE //function start
    ES PxPlanePOD W_PxPlane_R_PxPlane_P_PxVec3_P_PxVec3_C_PxPlane_ctor(physx::PxVec3 point, physx::PxVec3 normal){
        auto nat_in_point = (point);
        auto nat_in_normal = (normal);
        auto val = PxPlane();
        return *(PxPlanePOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_R_PxPlane_P_PxVec3_P_PxVec3_C_PxPlane_ctor(PxVec3 point, PxVec3 normal);
    
    public  PxPlane(PxVec3 point, PxVec3 normal){
        PxVec3 pvk_in_point = (point);
        PxVec3 pvk_in_normal = (normal);
        var _new = (W_PxPlane_R_PxPlane_P_PxVec3_P_PxVec3_C_PxPlane_ctor(pvk_in_point, pvk_in_normal));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxPlane(PxVec3Ptr p0, PxVec3Ptr p1, PxVec3Ptr p2)                      #
    //================================================================================
    #if NATIVE //function start
    ES PxPlanePOD W_PxPlane_R_PxPlane_P_PxVec3_P_PxVec3_P_PxVec3_C_PxPlane_ctor(physx::PxVec3 p0, physx::PxVec3 p1, physx::PxVec3 p2){
        auto nat_in_p0 = (p0);
        auto nat_in_p1 = (p1);
        auto nat_in_p2 = (p2);
        auto val = PxPlane();
        return *(PxPlanePOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_PxPlane_R_PxPlane_P_PxVec3_P_PxVec3_P_PxVec3_C_PxPlane_ctor(PxVec3 p0, PxVec3 p1, PxVec3 p2);
    
    public  PxPlane(PxVec3 p0, PxVec3 p1, PxVec3 p2){
        PxVec3 pvk_in_p0 = (p0);
        PxVec3 pvk_in_p1 = (p1);
        PxVec3 pvk_in_p2 = (p2);
        var _new = (W_PxPlane_R_PxPlane_P_PxVec3_P_PxVec3_P_PxVec3_C_PxPlane_ctor(pvk_in_p0, pvk_in_p1, pvk_in_p2));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator==(PxPlanePtr p)                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxPlane_C_PxPlane(physx::PxPlane self, physx::PxPlane p){
        auto nat_in_p = (p);
        auto retVal = self.operator==(nat_in_p);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxPlane_C_PxPlane(PxPlane selfBlt, PxPlane p);
    
    public static bool operator==(PxPlane lhs, PxPlane p){
        PxPlane pvk_in_p = (p);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxPlane_C_PxPlane(lhs, pvk_in_p);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       distance(PxVec3Ptr p)                                                  #
    //================================================================================
    #if NATIVE //function start
    ES float W_distance_R_float_P_PxVec3_C_PxPlane(physx::PxPlane self, physx::PxVec3 p){
        auto nat_in_p = (p);
        auto retVal = self.distance(nat_in_p);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_distance_R_float_P_PxVec3_C_PxPlane(PxPlane selfBlt, PxVec3 p);
    
    public  float distance(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        float retVal = W_distance_R_float_P_PxVec3_C_PxPlane(this, pvk_in_p);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       contains(PxVec3Ptr p)                                                  #
    //================================================================================
    #if NATIVE //function start
    ES bool W_contains_R_bool_P_PxVec3_C_PxPlane(physx::PxPlane self, physx::PxVec3 p){
        auto nat_in_p = (p);
        auto retVal = self.contains(nat_in_p);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_contains_R_bool_P_PxVec3_C_PxPlane(PxPlane selfBlt, PxVec3 p);
    
    public  bool contains(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        bool retVal = W_contains_R_bool_P_PxVec3_C_PxPlane(this, pvk_in_p);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       project(PxVec3Ptr p)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_project_R_PxVec3_P_PxVec3_C_PxPlane(physx::PxPlane self, physx::PxVec3 p){
        auto nat_in_p = (p);
        auto retVal = self.project;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_project_R_PxVec3_P_PxVec3_C_PxPlane(PxPlane selfBlt, PxVec3 p);
    
    public  PxVec3 project(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        PxVec3 retVal = W_project_R_PxVec3_P_PxVec3_C_PxPlane(this, pvk_in_p);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       pointInPlane()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_pointInPlane_R_PxVec3_C_PxPlane(physx::PxPlane self){
        auto retVal = self.pointInPlane;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_pointInPlane_R_PxVec3_C_PxPlane(PxPlane selfBlt);
    
    public  PxVec3 pointInPlane(){
        PxVec3 retVal = W_pointInPlane_R_PxVec3_C_PxPlane(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       normalize()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void W_normalize_R_void_C_PxPlane(physx::PxPlane self){
        self.normalize();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_normalize_R_void_C_PxPlane(PxPlane selfBlt);
    
    public  void normalize(){
        W_normalize_R_void_C_PxPlane(this);
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxPlane
    
    //Skipped generated implicit entry: PxPlane
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxPlane
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
