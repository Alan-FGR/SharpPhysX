#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxBounds3 {
    // PxBounds3();
    // PxBounds3(PxVec3 minimum, PxVec3 maximum);
     PxBounds3 empty();
     PxBounds3 boundsOfPoints(PxVec3 v0, PxVec3 v1);
     PxBounds3 centerExtents(PxVec3 center, PxVec3 extent);
     PxBounds3 basisExtent(PxVec3 center, PxMat33 basis, PxVec3 extent);
     PxBounds3 poseExtent(PxTransform pose, PxVec3 extent);
     PxBounds3 transformSafe(PxMat33 matrix, PxBounds3 bounds);
     PxBounds3 transformFast(PxMat33 matrix, PxBounds3 bounds);
     PxBounds3 transformSafe(PxTransform transform, PxBounds3 bounds);
     PxBounds3 transformFast(PxTransform transform, PxBounds3 bounds);
     void setEmpty();
     void setMaximal();
     void include(PxVec3 v);
     void include(PxBounds3 b);
     bool isEmpty();
     bool intersects(PxBounds3 b);
     bool intersects1D(PxBounds3 a, uint axis);
     bool contains(PxVec3 v);
     bool isInside(PxBounds3 box);
     PxVec3 getCenter();
     float getCenter(uint axis);
     float getExtents(uint axis);
     PxVec3 getDimensions();
     PxVec3 getExtents();
     void scaleSafe(float scale);
     void scaleFast(float scale);
     void fattenSafe(float distance);
     void fattenFast(float distance);
     bool isFinite();
     bool isValid();
    // PxBounds3(/*NULLPARS*/);
    // PxBounds3(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBounds3 lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxBounds3(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBounds3 lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxBounds3 : IPxBounds3 { // blittable
    public PxVec3 minimum;
    public PxVec3 maximum;

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBounds3
    #endif //hierarchy
    //================================================================================
    //#       PxBounds3                                                              #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxBounds3                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_PxBounds3_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3_ctor(physx::PxVec3 minimum, physx::PxVec3 maximum){
        auto nat_in_minimum = (minimum);
        auto nat_in_maximum = (maximum);
        return PxBounds3(nat_in_minimum, nat_in_maximum);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_PxBounds3_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3_ctor(PxVec3 minimum, PxVec3 maximum);
    
    public  PxBounds3(PxVec3 minimum, PxVec3 maximum){
        PxVec3 pvk_in_minimum = (minimum);
        PxVec3 pvk_in_maximum = (maximum);
        var _new = W_PxBounds3_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3_ctor(pvk_in_minimum, pvk_in_maximum);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       empty                                                                  #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_empty_R_PxBounds3_C_PxBounds3(physx::PxBounds3 self){
        auto retVal = self.empty();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_empty_R_PxBounds3_C_PxBounds3(PxBounds3 selfBlt);
    
    public  PxBounds3 empty(){
        PxBounds3 retVal = W_empty_R_PxBounds3_C_PxBounds3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       boundsOfPoints                                                         #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_boundsOfPoints_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3(physx::PxBounds3 self, physx::PxVec3 v0, physx::PxVec3 v1){
        auto nat_in_v0 = (v0);
        auto nat_in_v1 = (v1);
        auto retVal = self.boundsOfPoints(nat_in_v0, nat_in_v1);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_boundsOfPoints_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3(PxBounds3 selfBlt, PxVec3 v0, PxVec3 v1);
    
    public  PxBounds3 boundsOfPoints(PxVec3 v0, PxVec3 v1){
        PxVec3 pvk_in_v0 = (v0);
        PxVec3 pvk_in_v1 = (v1);
        PxBounds3 retVal = W_boundsOfPoints_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3(this, pvk_in_v0, pvk_in_v1);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       centerExtents                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_centerExtents_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3(physx::PxBounds3 self, physx::PxVec3 center, physx::PxVec3 extent){
        auto nat_in_center = (center);
        auto nat_in_extent = (extent);
        auto retVal = self.centerExtents(nat_in_center, nat_in_extent);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_centerExtents_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3(PxBounds3 selfBlt, PxVec3 center, PxVec3 extent);
    
    public  PxBounds3 centerExtents(PxVec3 center, PxVec3 extent){
        PxVec3 pvk_in_center = (center);
        PxVec3 pvk_in_extent = (extent);
        PxBounds3 retVal = W_centerExtents_R_PxBounds3_P_PxVec3_P_PxVec3_C_PxBounds3(this, pvk_in_center, pvk_in_extent);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       basisExtent                                                            #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_basisExtent_R_PxBounds3_P_PxVec3_P_PxMat33_P_PxVec3_C_PxBounds3(physx::PxBounds3 self, physx::PxVec3 center, physx::PxMat33 basis, physx::PxVec3 extent){
        auto nat_in_center = (center);
        auto nat_in_basis = (basis);
        auto nat_in_extent = (extent);
        auto retVal = self.basisExtent(nat_in_center, nat_in_basis, nat_in_extent);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_basisExtent_R_PxBounds3_P_PxVec3_P_PxMat33_P_PxVec3_C_PxBounds3(PxBounds3 selfBlt, PxVec3 center, PxMat33 basis, PxVec3 extent);
    
    public  PxBounds3 basisExtent(PxVec3 center, PxMat33 basis, PxVec3 extent){
        PxVec3 pvk_in_center = (center);
        PxMat33 pvk_in_basis = (basis);
        PxVec3 pvk_in_extent = (extent);
        PxBounds3 retVal = W_basisExtent_R_PxBounds3_P_PxVec3_P_PxMat33_P_PxVec3_C_PxBounds3(this, pvk_in_center, pvk_in_basis, pvk_in_extent);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       poseExtent                                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_poseExtent_R_PxBounds3_P_PxTransform_P_PxVec3_C_PxBounds3(physx::PxBounds3 self, physx::PxTransform pose, physx::PxVec3 extent){
        auto nat_in_pose = (pose);
        auto nat_in_extent = (extent);
        auto retVal = self.poseExtent(nat_in_pose, nat_in_extent);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_poseExtent_R_PxBounds3_P_PxTransform_P_PxVec3_C_PxBounds3(PxBounds3 selfBlt, PxTransform pose, PxVec3 extent);
    
    public  PxBounds3 poseExtent(PxTransform pose, PxVec3 extent){
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_extent = (extent);
        PxBounds3 retVal = W_poseExtent_R_PxBounds3_P_PxTransform_P_PxVec3_C_PxBounds3(this, pvk_in_pose, pvk_in_extent);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transformSafe                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_transformSafe_R_PxBounds3_P_PxMat33_P_PxBounds3_C_PxBounds3(physx::PxBounds3 self, physx::PxMat33 matrix, physx::PxBounds3 bounds){
        auto nat_in_matrix = (matrix);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformSafe(nat_in_matrix, nat_in_bounds);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformSafe_R_PxBounds3_P_PxMat33_P_PxBounds3_C_PxBounds3(PxBounds3 selfBlt, PxMat33 matrix, PxBounds3 bounds);
    
    public  PxBounds3 transformSafe(PxMat33 matrix, PxBounds3 bounds){
        PxMat33 pvk_in_matrix = (matrix);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformSafe_R_PxBounds3_P_PxMat33_P_PxBounds3_C_PxBounds3(this, pvk_in_matrix, pvk_in_bounds);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transformFast                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_transformFast_R_PxBounds3_P_PxMat33_P_PxBounds3_C_PxBounds3(physx::PxBounds3 self, physx::PxMat33 matrix, physx::PxBounds3 bounds){
        auto nat_in_matrix = (matrix);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformFast(nat_in_matrix, nat_in_bounds);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformFast_R_PxBounds3_P_PxMat33_P_PxBounds3_C_PxBounds3(PxBounds3 selfBlt, PxMat33 matrix, PxBounds3 bounds);
    
    public  PxBounds3 transformFast(PxMat33 matrix, PxBounds3 bounds){
        PxMat33 pvk_in_matrix = (matrix);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformFast_R_PxBounds3_P_PxMat33_P_PxBounds3_C_PxBounds3(this, pvk_in_matrix, pvk_in_bounds);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transformSafe                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_transformSafe_R_PxBounds3_P_PxTransform_P_PxBounds3_C_PxBounds3(physx::PxBounds3 self, physx::PxTransform transform, physx::PxBounds3 bounds){
        auto nat_in_transform = (transform);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformSafe(nat_in_transform, nat_in_bounds);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformSafe_R_PxBounds3_P_PxTransform_P_PxBounds3_C_PxBounds3(PxBounds3 selfBlt, PxTransform transform, PxBounds3 bounds);
    
    public  PxBounds3 transformSafe(PxTransform transform, PxBounds3 bounds){
        PxTransform pvk_in_transform = (transform);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformSafe_R_PxBounds3_P_PxTransform_P_PxBounds3_C_PxBounds3(this, pvk_in_transform, pvk_in_bounds);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transformFast                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxBounds3 W_transformFast_R_PxBounds3_P_PxTransform_P_PxBounds3_C_PxBounds3(physx::PxBounds3 self, physx::PxTransform transform, physx::PxBounds3 bounds){
        auto nat_in_transform = (transform);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformFast(nat_in_transform, nat_in_bounds);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformFast_R_PxBounds3_P_PxTransform_P_PxBounds3_C_PxBounds3(PxBounds3 selfBlt, PxTransform transform, PxBounds3 bounds);
    
    public  PxBounds3 transformFast(PxTransform transform, PxBounds3 bounds){
        PxTransform pvk_in_transform = (transform);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformFast_R_PxBounds3_P_PxTransform_P_PxBounds3_C_PxBounds3(this, pvk_in_transform, pvk_in_bounds);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setEmpty                                                               #
    //================================================================================
    #if NATIVE //function start
    ES void W_setEmpty_R_void_C_PxBounds3(physx::PxBounds3 self){
        self.setEmpty();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setEmpty_R_void_C_PxBounds3(PxBounds3 selfBlt);
    
    public  void setEmpty(){
        W_setEmpty_R_void_C_PxBounds3(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMaximal                                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMaximal_R_void_C_PxBounds3(physx::PxBounds3 self){
        self.setMaximal();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaximal_R_void_C_PxBounds3(PxBounds3 selfBlt);
    
    public  void setMaximal(){
        W_setMaximal_R_void_C_PxBounds3(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       include                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_include_R_void_P_PxVec3_C_PxBounds3(physx::PxBounds3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        self.include(nat_in_v);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_include_R_void_P_PxVec3_C_PxBounds3(PxBounds3 selfBlt, PxVec3 v);
    
    public  void include(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        W_include_R_void_P_PxVec3_C_PxBounds3(this, pvk_in_v);
    }
    #endif //function end
    
    
    //================================================================================
    //#       include                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_include_R_void_P_PxBounds3_C_PxBounds3(physx::PxBounds3 self, physx::PxBounds3 b){
        auto nat_in_b = (b);
        self.include(nat_in_b);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_include_R_void_P_PxBounds3_C_PxBounds3(PxBounds3 selfBlt, PxBounds3 b);
    
    public  void include(PxBounds3 b){
        PxBounds3 pvk_in_b = (b);
        W_include_R_void_P_PxBounds3_C_PxBounds3(this, pvk_in_b);
    }
    #endif //function end
    
    
    //================================================================================
    //#       isEmpty                                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isEmpty_R_bool_C_PxBounds3(physx::PxBounds3 self){
        auto retVal = self.isEmpty();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isEmpty_R_bool_C_PxBounds3(PxBounds3 selfBlt);
    
    public  bool isEmpty(){
        bool retVal = W_isEmpty_R_bool_C_PxBounds3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       intersects                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_intersects_R_bool_P_PxBounds3_C_PxBounds3(physx::PxBounds3 self, physx::PxBounds3 b){
        auto nat_in_b = (b);
        auto retVal = self.intersects(nat_in_b);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_intersects_R_bool_P_PxBounds3_C_PxBounds3(PxBounds3 selfBlt, PxBounds3 b);
    
    public  bool intersects(PxBounds3 b){
        PxBounds3 pvk_in_b = (b);
        bool retVal = W_intersects_R_bool_P_PxBounds3_C_PxBounds3(this, pvk_in_b);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       intersects1D                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_intersects1D_R_bool_P_PxBounds3_P_uint_C_PxBounds3(physx::PxBounds3 self, physx::PxBounds3 a, ::uint32_t axis){
        auto nat_in_a = (a);
        auto nat_in_axis = (axis);
        auto retVal = self.intersects1D(nat_in_a, nat_in_axis);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_intersects1D_R_bool_P_PxBounds3_P_uint_C_PxBounds3(PxBounds3 selfBlt, PxBounds3 a, uint axis);
    
    public  bool intersects1D(PxBounds3 a, uint axis){
        PxBounds3 pvk_in_a = (a);
        uint pvk_in_axis = (axis);
        bool retVal = W_intersects1D_R_bool_P_PxBounds3_P_uint_C_PxBounds3(this, pvk_in_a, pvk_in_axis);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       contains                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_contains_R_bool_P_PxVec3_C_PxBounds3(physx::PxBounds3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.contains(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_contains_R_bool_P_PxVec3_C_PxBounds3(PxBounds3 selfBlt, PxVec3 v);
    
    public  bool contains(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = W_contains_R_bool_P_PxVec3_C_PxBounds3(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isInside                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isInside_R_bool_P_PxBounds3_C_PxBounds3(physx::PxBounds3 self, physx::PxBounds3 box){
        auto nat_in_box = (box);
        auto retVal = self.isInside(nat_in_box);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isInside_R_bool_P_PxBounds3_C_PxBounds3(PxBounds3 selfBlt, PxBounds3 box);
    
    public  bool isInside(PxBounds3 box){
        PxBounds3 pvk_in_box = (box);
        bool retVal = W_isInside_R_bool_P_PxBounds3_C_PxBounds3(this, pvk_in_box);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getCenter                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3 W_getCenter_R_PxVec3_C_PxBounds3(physx::PxBounds3 self){
        auto retVal = self.getCenter();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getCenter_R_PxVec3_C_PxBounds3(PxBounds3 selfBlt);
    
    public  PxVec3 getCenter(){
        PxVec3 retVal = W_getCenter_R_PxVec3_C_PxBounds3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getCenter                                                              #
    //================================================================================
    #if NATIVE //function start
    ES float W_getCenter_R_float_P_uint_C_PxBounds3(physx::PxBounds3 self, ::uint32_t axis){
        auto nat_in_axis = (axis);
        auto retVal = self.getCenter(nat_in_axis);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getCenter_R_float_P_uint_C_PxBounds3(PxBounds3 selfBlt, uint axis);
    
    public  float getCenter(uint axis){
        uint pvk_in_axis = (axis);
        float retVal = W_getCenter_R_float_P_uint_C_PxBounds3(this, pvk_in_axis);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getExtents                                                             #
    //================================================================================
    #if NATIVE //function start
    ES float W_getExtents_R_float_P_uint_C_PxBounds3(physx::PxBounds3 self, ::uint32_t axis){
        auto nat_in_axis = (axis);
        auto retVal = self.getExtents(nat_in_axis);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getExtents_R_float_P_uint_C_PxBounds3(PxBounds3 selfBlt, uint axis);
    
    public  float getExtents(uint axis){
        uint pvk_in_axis = (axis);
        float retVal = W_getExtents_R_float_P_uint_C_PxBounds3(this, pvk_in_axis);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getDimensions                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3 W_getDimensions_R_PxVec3_C_PxBounds3(physx::PxBounds3 self){
        auto retVal = self.getDimensions();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getDimensions_R_PxVec3_C_PxBounds3(PxBounds3 selfBlt);
    
    public  PxVec3 getDimensions(){
        PxVec3 retVal = W_getDimensions_R_PxVec3_C_PxBounds3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getExtents                                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3 W_getExtents_R_PxVec3_C_PxBounds3(physx::PxBounds3 self){
        auto retVal = self.getExtents();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getExtents_R_PxVec3_C_PxBounds3(PxBounds3 selfBlt);
    
    public  PxVec3 getExtents(){
        PxVec3 retVal = W_getExtents_R_PxVec3_C_PxBounds3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       scaleSafe                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_scaleSafe_R_void_P_float_C_PxBounds3(physx::PxBounds3 self, float scale){
        auto nat_in_scale = (scale);
        self.scaleSafe(nat_in_scale);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_scaleSafe_R_void_P_float_C_PxBounds3(PxBounds3 selfBlt, float scale);
    
    public  void scaleSafe(float scale){
        float pvk_in_scale = (scale);
        W_scaleSafe_R_void_P_float_C_PxBounds3(this, pvk_in_scale);
    }
    #endif //function end
    
    
    //================================================================================
    //#       scaleFast                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_scaleFast_R_void_P_float_C_PxBounds3(physx::PxBounds3 self, float scale){
        auto nat_in_scale = (scale);
        self.scaleFast(nat_in_scale);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_scaleFast_R_void_P_float_C_PxBounds3(PxBounds3 selfBlt, float scale);
    
    public  void scaleFast(float scale){
        float pvk_in_scale = (scale);
        W_scaleFast_R_void_P_float_C_PxBounds3(this, pvk_in_scale);
    }
    #endif //function end
    
    
    //================================================================================
    //#       fattenSafe                                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_fattenSafe_R_void_P_float_C_PxBounds3(physx::PxBounds3 self, float distance){
        auto nat_in_distance = (distance);
        self.fattenSafe(nat_in_distance);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_fattenSafe_R_void_P_float_C_PxBounds3(PxBounds3 selfBlt, float distance);
    
    public  void fattenSafe(float distance){
        float pvk_in_distance = (distance);
        W_fattenSafe_R_void_P_float_C_PxBounds3(this, pvk_in_distance);
    }
    #endif //function end
    
    
    //================================================================================
    //#       fattenFast                                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_fattenFast_R_void_P_float_C_PxBounds3(physx::PxBounds3 self, float distance){
        auto nat_in_distance = (distance);
        self.fattenFast(nat_in_distance);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_fattenFast_R_void_P_float_C_PxBounds3(PxBounds3 selfBlt, float distance);
    
    public  void fattenFast(float distance){
        float pvk_in_distance = (distance);
        W_fattenFast_R_void_P_float_C_PxBounds3(this, pvk_in_distance);
    }
    #endif //function end
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isFinite_R_bool_C_PxBounds3(physx::PxBounds3 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite_R_bool_C_PxBounds3(PxBounds3 selfBlt);
    
    public  bool isFinite(){
        bool retVal = W_isFinite_R_bool_C_PxBounds3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxBounds3(physx::PxBounds3 self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxBounds3(PxBounds3 selfBlt);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxBounds3(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxBounds3
    
    //Skipped generated implicit entry: PxBounds3
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBounds3
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
