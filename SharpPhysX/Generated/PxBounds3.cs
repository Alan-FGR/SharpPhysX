#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxBounds3 { // blittable
    public PxVec3 minimum;
    public PxVec3 maximum;

#endif

    //================================================================================
    //#       PxBounds3                                                              #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxBounds3                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L72~72
    #if NATIVE
    ES physx::PxBounds3 W_PxBounds3_ctor(physx::PxVec3 minimum, physx::PxVec3 maximum){
        auto nat_in_minimum = (minimum);
        auto nat_in_maximum = (maximum);
        self.PxBounds3(nat_in_minimum, nat_in_maximum);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_PxBounds3_ctor(PxVec3 minimum, PxVec3 maximum);
    
    public PxBounds3(PxVec3 minimum, PxVec3 maximum){
        PxVec3 pvk_in_minimum = (minimum);
        PxVec3 pvk_in_maximum = (maximum);
        var _new = W_PxBounds3_ctor(pvk_in_minimum, pvk_in_maximum);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       empty                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L77~77
    #if NATIVE
    ES physx::PxBounds3 W_empty(physx::PxBounds3 self){
        auto retVal = self.empty();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_empty(PxBounds3 selfBlt);
    
    public PxBounds3 empty(){
        PxBounds3 retVal = W_empty(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       boundsOfPoints                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L84~84
    #if NATIVE
    ES physx::PxBounds3 W_boundsOfPoints(physx::PxBounds3 self, physx::PxVec3 v0, physx::PxVec3 v1){
        auto nat_in_v0 = (v0);
        auto nat_in_v1 = (v1);
        auto retVal = self.boundsOfPoints(nat_in_v0, nat_in_v1);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_boundsOfPoints(PxBounds3 selfBlt, PxVec3 v0, PxVec3 v1);
    
    public PxBounds3 boundsOfPoints(PxVec3 v0, PxVec3 v1){
        PxVec3 pvk_in_v0 = (v0);
        PxVec3 pvk_in_v1 = (v1);
        PxBounds3 retVal = W_boundsOfPoints(this, pvk_in_v0, pvk_in_v1);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       centerExtents                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L91~91
    #if NATIVE
    ES physx::PxBounds3 W_centerExtents(physx::PxBounds3 self, physx::PxVec3 center, physx::PxVec3 extent){
        auto nat_in_center = (center);
        auto nat_in_extent = (extent);
        auto retVal = self.centerExtents(nat_in_center, nat_in_extent);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_centerExtents(PxBounds3 selfBlt, PxVec3 center, PxVec3 extent);
    
    public PxBounds3 centerExtents(PxVec3 center, PxVec3 extent){
        PxVec3 pvk_in_center = (center);
        PxVec3 pvk_in_extent = (extent);
        PxBounds3 retVal = W_centerExtents(this, pvk_in_center, pvk_in_extent);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       basisExtent                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L96~97
    #if NATIVE
    ES physx::PxBounds3 W_basisExtent(physx::PxBounds3 self, physx::PxVec3 center, physx::PxMat33 basis, physx::PxVec3 extent){
        auto nat_in_center = (center);
        auto nat_in_basis = (basis);
        auto nat_in_extent = (extent);
        auto retVal = self.basisExtent(nat_in_center, nat_in_basis, nat_in_extent);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_basisExtent(PxBounds3 selfBlt, PxVec3 center, PxMat33 basis, PxVec3 extent);
    
    public PxBounds3 basisExtent(PxVec3 center, PxMat33 basis, PxVec3 extent){
        PxVec3 pvk_in_center = (center);
        PxMat33 pvk_in_basis = (basis);
        PxVec3 pvk_in_extent = (extent);
        PxBounds3 retVal = W_basisExtent(this, pvk_in_center, pvk_in_basis, pvk_in_extent);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       poseExtent                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L102~102
    #if NATIVE
    ES physx::PxBounds3 W_poseExtent(physx::PxBounds3 self, physx::PxTransform pose, physx::PxVec3 extent){
        auto nat_in_pose = (pose);
        auto nat_in_extent = (extent);
        auto retVal = self.poseExtent(nat_in_pose, nat_in_extent);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_poseExtent(PxBounds3 selfBlt, PxTransform pose, PxVec3 extent);
    
    public PxBounds3 poseExtent(PxTransform pose, PxVec3 extent){
        PxTransform pvk_in_pose = (pose);
        PxVec3 pvk_in_extent = (extent);
        PxBounds3 retVal = W_poseExtent(this, pvk_in_pose, pvk_in_extent);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformSafe                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L112~112
    #if NATIVE
    ES physx::PxBounds3 W_transformSafe(physx::PxBounds3 self, physx::PxMat33 matrix, physx::PxBounds3 bounds){
        auto nat_in_matrix = (matrix);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformSafe(nat_in_matrix, nat_in_bounds);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformSafe(PxBounds3 selfBlt, PxMat33 matrix, PxBounds3 bounds);
    
    public PxBounds3 transformSafe(PxMat33 matrix, PxBounds3 bounds){
        PxMat33 pvk_in_matrix = (matrix);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformSafe(this, pvk_in_matrix, pvk_in_bounds);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformFast                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L122~122
    #if NATIVE
    ES physx::PxBounds3 W_transformFast(physx::PxBounds3 self, physx::PxMat33 matrix, physx::PxBounds3 bounds){
        auto nat_in_matrix = (matrix);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformFast(nat_in_matrix, nat_in_bounds);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformFast(PxBounds3 selfBlt, PxMat33 matrix, PxBounds3 bounds);
    
    public PxBounds3 transformFast(PxMat33 matrix, PxBounds3 bounds){
        PxMat33 pvk_in_matrix = (matrix);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformFast(this, pvk_in_matrix, pvk_in_bounds);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformSafe                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L132~132
    #if NATIVE
    ES physx::PxBounds3 W_transformSafe(physx::PxBounds3 self, physx::PxTransform transform, physx::PxBounds3 bounds){
        auto nat_in_transform = (transform);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformSafe(nat_in_transform, nat_in_bounds);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformSafe(PxBounds3 selfBlt, PxTransform transform, PxBounds3 bounds);
    
    public PxBounds3 transformSafe(PxTransform transform, PxBounds3 bounds){
        PxTransform pvk_in_transform = (transform);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformSafe(this, pvk_in_transform, pvk_in_bounds);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformFast                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L142~142
    #if NATIVE
    ES physx::PxBounds3 W_transformFast(physx::PxBounds3 self, physx::PxTransform transform, physx::PxBounds3 bounds){
        auto nat_in_transform = (transform);
        auto nat_in_bounds = (bounds);
        auto retVal = self.transformFast(nat_in_transform, nat_in_bounds);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_transformFast(PxBounds3 selfBlt, PxTransform transform, PxBounds3 bounds);
    
    public PxBounds3 transformFast(PxTransform transform, PxBounds3 bounds){
        PxTransform pvk_in_transform = (transform);
        PxBounds3 pvk_in_bounds = (bounds);
        PxBounds3 retVal = W_transformFast(this, pvk_in_transform, pvk_in_bounds);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setEmpty                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L147~147
    #if NATIVE
    ES void W_setEmpty(physx::PxBounds3 self){
        self.setEmpty();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setEmpty(PxBounds3 selfBlt);
    
    public void setEmpty(){
        W_setEmpty(this);
    }
    #endif
    
    
    //================================================================================
    //#       setMaximal                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L152~152
    #if NATIVE
    ES void W_setMaximal(physx::PxBounds3 self){
        self.setMaximal();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaximal(PxBounds3 selfBlt);
    
    public void setMaximal(){
        W_setMaximal(this);
    }
    #endif
    
    
    //================================================================================
    //#       include                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L158~158
    #if NATIVE
    ES void W_include(physx::PxBounds3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        self.include(nat_in_v);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_include(PxBounds3 selfBlt, PxVec3 v);
    
    public void include(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        W_include(this, pvk_in_v);
    }
    #endif
    
    
    //================================================================================
    //#       include                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L164~164
    #if NATIVE
    ES void W_include(physx::PxBounds3 self, physx::PxBounds3 b){
        auto nat_in_b = (b);
        self.include(nat_in_b);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_include(PxBounds3 selfBlt, PxBounds3 b);
    
    public void include(PxBounds3 b){
        PxBounds3 pvk_in_b = (b);
        W_include(this, pvk_in_b);
    }
    #endif
    
    
    //================================================================================
    //#       isEmpty                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L166~166
    #if NATIVE
    ES bool W_isEmpty(physx::PxBounds3 self){
        auto retVal = self.isEmpty();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isEmpty(PxBounds3 selfBlt);
    
    public bool isEmpty(){
        bool retVal = W_isEmpty(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       intersects                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L172~172
    #if NATIVE
    ES bool W_intersects(physx::PxBounds3 self, physx::PxBounds3 b){
        auto nat_in_b = (b);
        auto retVal = self.intersects(nat_in_b);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_intersects(PxBounds3 selfBlt, PxBounds3 b);
    
    public bool intersects(PxBounds3 b){
        PxBounds3 pvk_in_b = (b);
        bool retVal = W_intersects(this, pvk_in_b);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       intersects1D                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L179~179
    #if NATIVE
    ES bool W_intersects1D(physx::PxBounds3 self, physx::PxBounds3 a, ::uint32_t axis){
        auto nat_in_a = (a);
        auto nat_in_axis = (axis);
        auto retVal = self.intersects1D(nat_in_a, nat_in_axis);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_intersects1D(PxBounds3 selfBlt, PxBounds3 a, uint axis);
    
    public bool intersects1D(PxBounds3 a, uint axis){
        PxBounds3 pvk_in_a = (a);
        uint pvk_in_axis = (axis);
        bool retVal = W_intersects1D(this, pvk_in_a, pvk_in_axis);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       contains                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L185~185
    #if NATIVE
    ES bool W_contains(physx::PxBounds3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.contains(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_contains(PxBounds3 selfBlt, PxVec3 v);
    
    public bool contains(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = W_contains(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isInside                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L191~191
    #if NATIVE
    ES bool W_isInside(physx::PxBounds3 self, physx::PxBounds3 box){
        auto nat_in_box = (box);
        auto retVal = self.isInside(nat_in_box);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isInside(PxBounds3 selfBlt, PxBounds3 box);
    
    public bool isInside(PxBounds3 box){
        PxBounds3 pvk_in_box = (box);
        bool retVal = W_isInside(this, pvk_in_box);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getCenter                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L196~196
    #if NATIVE
    ES physx::PxVec3 W_getCenter(physx::PxBounds3 self){
        auto retVal = self.getCenter();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getCenter(PxBounds3 selfBlt);
    
    public PxVec3 getCenter(){
        PxVec3 retVal = W_getCenter(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getCenter                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L201~201
    #if NATIVE
    ES float W_getCenter(physx::PxBounds3 self, ::uint32_t axis){
        auto nat_in_axis = (axis);
        auto retVal = self.getCenter(nat_in_axis);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getCenter(PxBounds3 selfBlt, uint axis);
    
    public float getCenter(uint axis){
        uint pvk_in_axis = (axis);
        float retVal = W_getCenter(this, pvk_in_axis);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getExtents                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L206~206
    #if NATIVE
    ES float W_getExtents(physx::PxBounds3 self, ::uint32_t axis){
        auto nat_in_axis = (axis);
        auto retVal = self.getExtents(nat_in_axis);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getExtents(PxBounds3 selfBlt, uint axis);
    
    public float getExtents(uint axis){
        uint pvk_in_axis = (axis);
        float retVal = W_getExtents(this, pvk_in_axis);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getDimensions                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L211~211
    #if NATIVE
    ES physx::PxVec3 W_getDimensions(physx::PxBounds3 self){
        auto retVal = self.getDimensions();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getDimensions(PxBounds3 selfBlt);
    
    public PxVec3 getDimensions(){
        PxVec3 retVal = W_getDimensions(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getExtents                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L216~216
    #if NATIVE
    ES physx::PxVec3 W_getExtents(physx::PxBounds3 self){
        auto retVal = self.getExtents();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getExtents(PxBounds3 selfBlt);
    
    public PxVec3 getExtents(){
        PxVec3 retVal = W_getExtents(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       scaleSafe                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L225~225
    #if NATIVE
    ES void W_scaleSafe(physx::PxBounds3 self, float scale){
        auto nat_in_scale = (scale);
        self.scaleSafe(nat_in_scale);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_scaleSafe(PxBounds3 selfBlt, float scale);
    
    public void scaleSafe(float scale){
        float pvk_in_scale = (scale);
        W_scaleSafe(this, pvk_in_scale);
    }
    #endif
    
    
    //================================================================================
    //#       scaleFast                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L234~234
    #if NATIVE
    ES void W_scaleFast(physx::PxBounds3 self, float scale){
        auto nat_in_scale = (scale);
        self.scaleFast(nat_in_scale);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_scaleFast(PxBounds3 selfBlt, float scale);
    
    public void scaleFast(float scale){
        float pvk_in_scale = (scale);
        W_scaleFast(this, pvk_in_scale);
    }
    #endif
    
    
    //================================================================================
    //#       fattenSafe                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L241~241
    #if NATIVE
    ES void W_fattenSafe(physx::PxBounds3 self, float distance){
        auto nat_in_distance = (distance);
        self.fattenSafe(nat_in_distance);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_fattenSafe(PxBounds3 selfBlt, float distance);
    
    public void fattenSafe(float distance){
        float pvk_in_distance = (distance);
        W_fattenSafe(this, pvk_in_distance);
    }
    #endif
    
    
    //================================================================================
    //#       fattenFast                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L248~248
    #if NATIVE
    ES void W_fattenFast(physx::PxBounds3 self, float distance){
        auto nat_in_distance = (distance);
        self.fattenFast(nat_in_distance);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_fattenFast(PxBounds3 selfBlt, float distance);
    
    public void fattenFast(float distance){
        float pvk_in_distance = (distance);
        W_fattenFast(this, pvk_in_distance);
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L253~253
    #if NATIVE
    ES bool W_isFinite(physx::PxBounds3 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite(PxBounds3 selfBlt);
    
    public bool isFinite(){
        bool retVal = W_isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxBounds3.h L258~258
    #if NATIVE
    ES bool W_isValid(physx::PxBounds3 self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxBounds3 selfBlt);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxBounds3
    
    //Skipped generated implicit entry: PxBounds3
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBounds3
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
