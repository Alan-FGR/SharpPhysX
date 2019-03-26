#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxTransform {
    ///*No paramless ctor in C#*/ static PxTransform Default();
    // PxTransform(PxVec3 position);
    // PxTransform(PxIDENTITY r);
    // PxTransform(PxQuat orientation);
    // PxTransform(float x, float y, float z);
    // PxTransform(float x, float y, float z, PxQuat aQ);
    // PxTransform(PxVec3 p0, PxQuat q0);
    // PxTransform(PxMat44 m);
    //static bool operator==(PxTransform lhs, PxTransform t);
    //static PxTransform operator*(PxTransform lhs, PxTransform x);
    //static PxTransform operator*=(PxTransform lhs, /*NULLPARS*/);
     PxTransform getInverse();
     PxVec3 transform(PxVec3 input);
     PxVec3 transformInv(PxVec3 input);
     PxVec3 rotate(PxVec3 input);
     PxVec3 rotateInv(PxVec3 input);
     PxTransform transform(PxTransform src);
     bool isValid();
     bool isSane();
     bool isFinite();
     PxTransform transformInv(PxTransform src);
     PxPlane transform(PxPlane plane);
     PxPlane inverseTransform(PxPlane plane);
     PxTransform getNormalized();
    // PxTransform(/*NULLPARS*/);
    // PxTransform(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxTransform lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxTransform(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxTransform lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxTransform : IPxTransform { // blittable
    public PxQuat q;
    public PxVec3 p;

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxTransformPOD{
    physx::PxQuat q;
    physx::PxVec3 p;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxTransform
    #endif //hierarchy
    //================================================================================
    //#       PxTransform()                                                          #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_C_PxTransform_ctor(){
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_C_PxTransform_ctor();
    
    public /*No paramless ctor in C#*/ static PxTransform Default(){
        return (W_PxTransform_R_PxTransform_C_PxTransform_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxTransform(PxVec3Ptr position)                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_P_PxVec3_C_PxTransform_ctor(physx::PxVec3 position){
        auto nat_in_position = (position);
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_P_PxVec3_C_PxTransform_ctor(PxVec3 position);
    
    public  PxTransform(PxVec3 position){
        PxVec3 pvk_in_position = (position);
        var _new = (W_PxTransform_R_PxTransform_P_PxVec3_C_PxTransform_ctor(pvk_in_position));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxTransform(physx r)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_P_PxIDENTITY_C_PxTransform_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_P_PxIDENTITY_C_PxTransform_ctor(PxIDENTITY r);
    
    public  PxTransform(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = (W_PxTransform_R_PxTransform_P_PxIDENTITY_C_PxTransform_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxTransform(PxQuatPtr orientation)                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_P_PxQuat_C_PxTransform_ctor(physx::PxQuat orientation){
        auto nat_in_orientation = (orientation);
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_P_PxQuat_C_PxTransform_ctor(PxQuat orientation);
    
    public  PxTransform(PxQuat orientation){
        PxQuat pvk_in_orientation = (orientation);
        var _new = (W_PxTransform_R_PxTransform_P_PxQuat_C_PxTransform_ctor(pvk_in_orientation));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxTransform(float x, float y, float z, PxQuat aQ)                      #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_P_float_P_float_P_float_P_PxQuat_C_PxTransform_ctor(float x, float y, float z, physx::PxQuat aQ){
        auto nat_in_x = (x);
        auto nat_in_y = (y);
        auto nat_in_z = (z);
        auto nat_in_aQ = (aQ);
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_P_float_P_float_P_float_P_PxQuat_C_PxTransform_ctor(float x, float y, float z, PxQuat aQ);
    
    public  PxTransform(float x, float y, float z, PxQuat aQ){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        float pvk_in_z = (z);
        PxQuat pvk_in_aQ = (aQ);
        var _new = (W_PxTransform_R_PxTransform_P_float_P_float_P_float_P_PxQuat_C_PxTransform_ctor(pvk_in_x, pvk_in_y, pvk_in_z, pvk_in_aQ));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_P_float_P_float_P_float_OL1_C_PxTransform_ctor(float x, float y, float z){
        auto nat_in_x = (x);
        auto nat_in_y = (y);
        auto nat_in_z = (z);
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_P_float_P_float_P_float_OL1_C_PxTransform_ctor(float x, float y, float z);
    
    public  PxTransform(float x, float y, float z){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        float pvk_in_z = (z);
        var _new = (W_PxTransform_R_PxTransform_P_float_P_float_P_float_OL1_C_PxTransform_ctor(pvk_in_x, pvk_in_y, pvk_in_z));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       PxTransform(PxVec3Ptr p0, PxQuatPtr q0)                                #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_P_PxVec3_P_PxQuat_C_PxTransform_ctor(physx::PxVec3 p0, physx::PxQuat q0){
        auto nat_in_p0 = (p0);
        auto nat_in_q0 = (q0);
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_P_PxVec3_P_PxQuat_C_PxTransform_ctor(PxVec3 p0, PxQuat q0);
    
    public  PxTransform(PxVec3 p0, PxQuat q0){
        PxVec3 pvk_in_p0 = (p0);
        PxQuat pvk_in_q0 = (q0);
        var _new = (W_PxTransform_R_PxTransform_P_PxVec3_P_PxQuat_C_PxTransform_ctor(pvk_in_p0, pvk_in_q0));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxTransform(PxMat44Ptr m)                                              #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_PxTransform_R_PxTransform_P_PxMat44_C_PxTransform_ctor(physx::PxMat44 m){
        auto nat_in_m = (m);
        auto val = PxTransform();
        return *(PxTransformPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_PxTransform_R_PxTransform_P_PxMat44_C_PxTransform_ctor(PxMat44 m);
    
    public  PxTransform(PxMat44 m){
        PxMat44 pvk_in_m = (m);
        var _new = (W_PxTransform_R_PxTransform_P_PxMat44_C_PxTransform_ctor(pvk_in_m));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator==(PxTransformPtr t)                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxTransform_C_PxTransform(physx::PxTransform self, physx::PxTransform t){
        auto nat_in_t = (t);
        auto retVal = self.operator==(nat_in_t);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxTransform_C_PxTransform(PxTransform selfBlt, PxTransform t);
    
    public static bool operator==(PxTransform lhs, PxTransform t){
        PxTransform pvk_in_t = (t);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxTransform_C_PxTransform(lhs, pvk_in_t);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*(PxTransformPtr x)                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_OP_Star_R_PxTransform_P_PxTransform_C_PxTransform(physx::PxTransform self, physx::PxTransform x){
        auto nat_in_x = (x);
        auto retVal = self.operator*;
        return *(PxTransformPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_OP_Star_R_PxTransform_P_PxTransform_C_PxTransform(PxTransform selfBlt, PxTransform x);
    
    public static PxTransform operator*(PxTransform lhs, PxTransform x){
        PxTransform pvk_in_x = (x);
        PxTransform retVal = W_OP_Star_R_PxTransform_P_PxTransform_C_PxTransform(lhs, pvk_in_x);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*=(PxTransformPtr other)                                       #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       getInverse()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_getInverse_R_PxTransform_C_PxTransform(physx::PxTransform self){
        auto retVal = self.getInverse;
        return *(PxTransformPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getInverse_R_PxTransform_C_PxTransform(PxTransform selfBlt);
    
    public  PxTransform getInverse(){
        PxTransform retVal = W_getInverse_R_PxTransform_C_PxTransform(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transform(PxVec3Ptr input)                                             #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_transform_R_PxVec3_P_PxVec3_C_PxTransform(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.transform;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform_R_PxVec3_P_PxVec3_C_PxTransform(PxTransform selfBlt, PxVec3 input);
    
    public  PxVec3 transform(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_transform_R_PxVec3_P_PxVec3_C_PxTransform(this, pvk_in_input);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transformInv(PxVec3Ptr input)                                          #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_transformInv_R_PxVec3_P_PxVec3_C_PxTransform(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.transformInv;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transformInv_R_PxVec3_P_PxVec3_C_PxTransform(PxTransform selfBlt, PxVec3 input);
    
    public  PxVec3 transformInv(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_transformInv_R_PxVec3_P_PxVec3_C_PxTransform(this, pvk_in_input);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       rotate(PxVec3Ptr input)                                                #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_rotate_R_PxVec3_P_PxVec3_C_PxTransform(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.rotate;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotate_R_PxVec3_P_PxVec3_C_PxTransform(PxTransform selfBlt, PxVec3 input);
    
    public  PxVec3 rotate(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_rotate_R_PxVec3_P_PxVec3_C_PxTransform(this, pvk_in_input);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       rotateInv(PxVec3Ptr input)                                             #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_rotateInv_R_PxVec3_P_PxVec3_C_PxTransform(physx::PxTransform self, physx::PxVec3 input){
        auto nat_in_input = (input);
        auto retVal = self.rotateInv;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotateInv_R_PxVec3_P_PxVec3_C_PxTransform(PxTransform selfBlt, PxVec3 input);
    
    public  PxVec3 rotateInv(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = W_rotateInv_R_PxVec3_P_PxVec3_C_PxTransform(this, pvk_in_input);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transform(PxTransformPtr src)                                          #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_transform_R_PxTransform_P_PxTransform_C_PxTransform(physx::PxTransform self, physx::PxTransform src){
        auto nat_in_src = (src);
        auto retVal = self.transform;
        return *(PxTransformPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_transform_R_PxTransform_P_PxTransform_C_PxTransform(PxTransform selfBlt, PxTransform src);
    
    public  PxTransform transform(PxTransform src){
        PxTransform pvk_in_src = (src);
        PxTransform retVal = W_transform_R_PxTransform_P_PxTransform_C_PxTransform(this, pvk_in_src);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxTransform(physx::PxTransform self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxTransform(PxTransform selfBlt);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxTransform(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isSane()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isSane_R_bool_C_PxTransform(physx::PxTransform self){
        auto retVal = self.isSane();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isSane_R_bool_C_PxTransform(PxTransform selfBlt);
    
    public  bool isSane(){
        bool retVal = W_isSane_R_bool_C_PxTransform(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isFinite()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isFinite_R_bool_C_PxTransform(physx::PxTransform self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite_R_bool_C_PxTransform(PxTransform selfBlt);
    
    public  bool isFinite(){
        bool retVal = W_isFinite_R_bool_C_PxTransform(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transformInv(PxTransformPtr src)                                       #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_transformInv_R_PxTransform_P_PxTransform_C_PxTransform(physx::PxTransform self, physx::PxTransform src){
        auto nat_in_src = (src);
        auto retVal = self.transformInv;
        return *(PxTransformPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_transformInv_R_PxTransform_P_PxTransform_C_PxTransform(PxTransform selfBlt, PxTransform src);
    
    public  PxTransform transformInv(PxTransform src){
        PxTransform pvk_in_src = (src);
        PxTransform retVal = W_transformInv_R_PxTransform_P_PxTransform_C_PxTransform(this, pvk_in_src);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transform(PxPlanePtr plane)                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxPlanePOD W_transform_R_PxPlane_P_PxPlane_C_PxTransform(physx::PxTransform self, physx::PxPlane plane){
        auto nat_in_plane = (plane);
        auto retVal = self.transform;
        return *(PxPlanePOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_transform_R_PxPlane_P_PxPlane_C_PxTransform(PxTransform selfBlt, PxPlane plane);
    
    public  PxPlane transform(PxPlane plane){
        PxPlane pvk_in_plane = (plane);
        PxPlane retVal = W_transform_R_PxPlane_P_PxPlane_C_PxTransform(this, pvk_in_plane);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       inverseTransform(PxPlanePtr plane)                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxPlanePOD W_inverseTransform_R_PxPlane_P_PxPlane_C_PxTransform(physx::PxTransform self, physx::PxPlane plane){
        auto nat_in_plane = (plane);
        auto retVal = self.inverseTransform;
        return *(PxPlanePOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPlane W_inverseTransform_R_PxPlane_P_PxPlane_C_PxTransform(PxTransform selfBlt, PxPlane plane);
    
    public  PxPlane inverseTransform(PxPlane plane){
        PxPlane pvk_in_plane = (plane);
        PxPlane retVal = W_inverseTransform_R_PxPlane_P_PxPlane_C_PxTransform(this, pvk_in_plane);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNormalized()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxTransformPOD W_getNormalized_R_PxTransform_C_PxTransform(physx::PxTransform self){
        auto retVal = self.getNormalized;
        return *(PxTransformPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getNormalized_R_PxTransform_C_PxTransform(PxTransform selfBlt);
    
    public  PxTransform getNormalized(){
        PxTransform retVal = W_getNormalized_R_PxTransform_C_PxTransform(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxTransform
    
    //Skipped generated implicit entry: PxTransform
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxTransform
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
