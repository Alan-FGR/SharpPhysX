#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxTransform { // blittable
    public PxQuat q;
    public PxVec3 p;

#endif

    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_PxTransform_ctor(physx::PxVec3 position){
        auto nat_in_position = (position);
        self.PxTransform(nat_in_position);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_ctor(PxVec3 position);
    
    public PxTransform(PxVec3 position){
        PxVec3 pvk_in_position = (position);
        var _new = W_PxTransform_ctor(pvk_in_position);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_PxTransform_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        self.PxTransform(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_ctor(PxIDENTITY r);
    
    public PxTransform(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = W_PxTransform_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_PxTransform_ctor(physx::PxQuat orientation){
        auto nat_in_orientation = (orientation);
        self.PxTransform(nat_in_orientation);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_ctor(PxQuat orientation);
    
    public PxTransform(PxQuat orientation){
        PxQuat pvk_in_orientation = (orientation);
        var _new = W_PxTransform_ctor(pvk_in_orientation);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_PxTransform_ctor(float x, float y, float z, physx::PxQuat aQ){
        auto nat_in_x = (x);
        auto nat_in_y = (y);
        auto nat_in_z = (z);
        auto nat_in_aQ = (aQ);
        self.PxTransform(nat_in_x, nat_in_y, nat_in_z, nat_in_aQ);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_ctor(float x, float y, float z, PxQuat aQ);
    
    public PxTransform(float x, float y, float z, PxQuat aQ){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        float pvk_in_z = (z);
        PxQuat pvk_in_aQ = (aQ);
        var _new = W_PxTransform_ctor(pvk_in_x, pvk_in_y, pvk_in_z, pvk_in_aQ);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES physx::PxTransform W_PxTransform_ctor_OL1(float x, float y, float z){
        auto nat_in_x = (x);
        auto nat_in_y = (y);
        auto nat_in_z = (z);
        self.PxTransform(nat_in_x, nat_in_y, nat_in_z);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_ctor_OL1(float x, float y, float z);
    
    public PxTransform(float x, float y, float z){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        float pvk_in_z = (z);
        var _new = W_PxTransform_ctor_OL1(pvk_in_x, pvk_in_y, pvk_in_z);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_PxTransform_ctor(physx::PxVec3 p0, physx::PxQuat q0){
        auto nat_in_p0 = (p0);
        auto nat_in_q0 = (q0);
        self.PxTransform(nat_in_p0, nat_in_q0);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_ctor(PxVec3 p0, PxQuat q0);
    
    public PxTransform(PxVec3 p0, PxQuat q0){
        PxVec3 pvk_in_p0 = (p0);
        PxQuat pvk_in_q0 = (q0);
        var _new = W_PxTransform_ctor(pvk_in_p0, pvk_in_q0);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_PxTransform_ctor(physx::PxMat44 m){
        auto nat_in_m = (m);
        self.PxTransform(nat_in_m);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_ctor(PxMat44 m);
    
    public PxTransform(PxMat44 m){
        PxMat44 pvk_in_m = (m);
        var _new = W_PxTransform_ctor(pvk_in_m);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxTransform self, physx::PxTransform t){
        auto nat_in_t = (t);
        auto retVal = self.operator==(nat_in_t);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxTransform selfBlt, PxTransform t);
    
    public static bool operator==(PxTransform lhs, PxTransform t){
        PxTransform pvk_in_t = (t);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_t);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_OP_Star(physx::PxTransform self, physx::PxTransform x){
        auto nat_in_x = (x);
        auto retVal = self.operator*(nat_in_x);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_OP_Star(PxTransform selfBlt, PxTransform x);
    
    public static PxTransform operator*(PxTransform lhs, PxTransform x){
        PxTransform pvk_in_x = (x);
        PxTransform retVal = W_OP_Star(lhs, pvk_in_x);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       getInverse                                                             #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_getInverse(physx::PxTransform self){
        auto retVal = self.getInverse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getInverse(PxTransform selfBlt);
    
    public PxTransform getInverse(){
        PxTransform retVal = W_getInverse(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_transform(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.transform(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 transform(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_transform(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformInv                                                           #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_transformInv(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.transformInv(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transformInv(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 transformInv(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_transformInv(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotate                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_rotate(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.rotate(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotate(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 rotate(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_rotate(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotateInv                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_rotateInv(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.rotateInv(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotateInv(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 rotateInv(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_rotateInv(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_transform(physx::PxTransform self, physx::PxTransform src){
        auto nat_in_src = (src);
        auto retVal = self.transform(nat_in_src);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_transform(PxTransform selfBlt, PxTransform src);
    
    public PxTransform transform(PxTransform src){
        PxTransform pvk_in_src = (src);
        PxTransform retVal = W_transform(this, pvk_in_src);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    #if NATIVE
    ES bool W_isValid(physx::PxTransform self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid(PxTransform selfBlt);
    
    public bool isValid(){
        bool retVal = W_isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isSane                                                                 #
    //================================================================================
    #if NATIVE
    ES bool W_isSane(physx::PxTransform self){
        auto retVal = self.isSane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSane(PxTransform selfBlt);
    
    public bool isSane(){
        bool retVal = W_isSane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isFinite(physx::PxTransform self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite(PxTransform selfBlt);
    
    public bool isFinite(){
        bool retVal = W_isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformInv                                                           #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_transformInv(physx::PxTransform self, physx::PxTransform src){
        auto nat_in_src = (src);
        auto retVal = self.transformInv(nat_in_src);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_transformInv(PxTransform selfBlt, PxTransform src);
    
    public PxTransform transformInv(PxTransform src){
        PxTransform pvk_in_src = (src);
        PxTransform retVal = W_transformInv(this, pvk_in_src);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxPlane W_transform(physx::PxTransform self, physx::PxPlane plane){
        auto nat_in_plane = (plane);
        auto retVal = self.transform(nat_in_plane);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_transform(PxTransform selfBlt, PxPlane plane);
    
    public PxPlane transform(PxPlane plane){
        PxPlane pvk_in_plane = (plane);
        PxPlane retVal = W_transform(this, pvk_in_plane);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       inverseTransform                                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxPlane W_inverseTransform(physx::PxTransform self, physx::PxPlane plane){
        auto nat_in_plane = (plane);
        auto retVal = self.inverseTransform(nat_in_plane);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_inverseTransform(PxTransform selfBlt, PxPlane plane);
    
    public PxPlane inverseTransform(PxPlane plane){
        PxPlane pvk_in_plane = (plane);
        PxPlane retVal = W_inverseTransform(this, pvk_in_plane);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNormalized                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_getNormalized(physx::PxTransform self){
        auto retVal = self.getNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getNormalized(PxTransform selfBlt);
    
    public PxTransform getNormalized(){
        PxTransform retVal = W_getNormalized(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxTransform
    
    //Skipped generated implicit entry: PxTransform
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxTransform
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
