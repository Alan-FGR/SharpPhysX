#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxMeshScalePtr {
    // static PxMeshScalePtr New();
    // static PxMeshScalePtr New(float r);
    // static PxMeshScalePtr New(PxVec3 s);
    // static PxMeshScalePtr New(PxVec3 s, PxQuat r);
     bool isIdentity();
    // PxMeshScalePtr getInverse();
     PxMat33 toMat33();
     bool hasNegativeDeterminant();
     PxVec3 transform(PxVec3 v);
     bool isValidForTriangleMesh();
     bool isValidForConvexMesh();
    // static PxMeshScalePtr New(/*NULLPARS*/);
    // static PxMeshScalePtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxMeshScalePtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxMeshScale(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxMeshScalePtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxMeshScalePtr : IPxMeshScalePtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxMeshScalePtrPOD{
    physx::PxVec3 scale;
    physx::PxQuat rotation;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### SCALE getter/setter
    #if NATIVE //getter
    ES physx::PxVec3 PxMeshScale_GET_scale(PxMeshScale* self) {return self->scale;}
    ES void PxMeshScale_SET_scale(PxMeshScale* self, physx::PxVec3 value) {self->scale = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 PxMeshScale_GET_scale(PxMeshScalePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxMeshScale_SET_scale(PxMeshScalePtr selfPtr, PxVec3 value);

    public PxVec3 scale {
        get => PxMeshScale_GET_scale(this);
        set => PxMeshScale_SET_scale(this, value);
    }
    #endif //getter

    // ### ROTATION getter/setter
    #if NATIVE //getter
    ES physx::PxQuat PxMeshScale_GET_rotation(PxMeshScale* self) {return self->rotation;}
    ES void PxMeshScale_SET_rotation(PxMeshScale* self, physx::PxQuat value) {self->rotation = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxQuat PxMeshScale_GET_rotation(PxMeshScalePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxMeshScale_SET_rotation(PxMeshScalePtr selfPtr, PxQuat value);

    public PxQuat rotation {
        get => PxMeshScale_GET_rotation(this);
        set => PxMeshScale_SET_rotation(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxMeshScalePtr
    #endif //hierarchy
    //================================================================================
    //#       PxMeshScale()                                                          #
    //================================================================================
    #if NATIVE //function start
    ES PxMeshScalePtrPOD W_PxMeshScale_R_PxMeshScalePtr_C_PxMeshScale_ctor(){
        auto val = new PxMeshScale();
        return *(PxMeshScalePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshScalePtr W_PxMeshScale_R_PxMeshScalePtr_C_PxMeshScale_ctor();
    
    public  static PxMeshScalePtr New(){
        var _new = W_PxMeshScale_R_PxMeshScalePtr_C_PxMeshScale_ctor();
        PxMeshScalePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMeshScale(float r)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxMeshScalePtrPOD W_PxMeshScale_R_PxMeshScalePtr_P_float_C_PxMeshScale_ctor(physx::PxReal r){
        auto nat_in_r = (r);
        auto val = new PxMeshScale();
        return *(PxMeshScalePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshScalePtr W_PxMeshScale_R_PxMeshScalePtr_P_float_C_PxMeshScale_ctor(float r);
    
    public  static PxMeshScalePtr New(float r){
        float pvk_in_r = (r);
        var _new = W_PxMeshScale_R_PxMeshScalePtr_P_float_C_PxMeshScale_ctor(pvk_in_r);
        PxMeshScalePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMeshScale(PxVec3Ptr s)                                               #
    //================================================================================
    #if NATIVE //function start
    ES PxMeshScalePtrPOD W_PxMeshScale_R_PxMeshScalePtr_P_PxVec3_C_PxMeshScale_ctor(physx::PxVec3 s){
        auto nat_in_s = (s);
        auto val = new PxMeshScale();
        return *(PxMeshScalePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshScalePtr W_PxMeshScale_R_PxMeshScalePtr_P_PxVec3_C_PxMeshScale_ctor(PxVec3 s);
    
    public  static PxMeshScalePtr New(PxVec3 s){
        PxVec3 pvk_in_s = (s);
        var _new = W_PxMeshScale_R_PxMeshScalePtr_P_PxVec3_C_PxMeshScale_ctor(pvk_in_s);
        PxMeshScalePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMeshScale(PxVec3Ptr s, PxQuatPtr r)                                  #
    //================================================================================
    #if NATIVE //function start
    ES PxMeshScalePtrPOD W_PxMeshScale_R_PxMeshScalePtr_P_PxVec3_P_PxQuat_C_PxMeshScale_ctor(physx::PxVec3 s, physx::PxQuat r){
        auto nat_in_s = (s);
        auto nat_in_r = (r);
        auto val = new PxMeshScale();
        return *(PxMeshScalePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshScalePtr W_PxMeshScale_R_PxMeshScalePtr_P_PxVec3_P_PxQuat_C_PxMeshScale_ctor(PxVec3 s, PxQuat r);
    
    public  static PxMeshScalePtr New(PxVec3 s, PxQuat r){
        PxVec3 pvk_in_s = (s);
        PxQuat pvk_in_r = (r);
        var _new = W_PxMeshScale_R_PxMeshScalePtr_P_PxVec3_P_PxQuat_C_PxMeshScale_ctor(pvk_in_s, pvk_in_r);
        PxMeshScalePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isIdentity()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isIdentity_R_bool_C_PxMeshScale(physx::PxMeshScale* self){
        auto retVal = self->isIdentity();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isIdentity_R_bool_C_PxMeshScale(PxMeshScalePtr selfPtr);
    
    public  bool isIdentity(){
        bool retVal = W_isIdentity_R_bool_C_PxMeshScale(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getInverse()                                                           #
    //================================================================================
    /* ERRORS OCCURED: returned native value can't be converted into ptr
    // NATIVE SIG: PxMeshScale getInverse() const 
    	{
    		return PxMeshScale(PxVec3(1.0f/scale.x, 1.0f/scale.y, 1.0f/scale.z), rotation);
    	}
    #if NATIVE //function start
    ES PxMeshScalePtrPOD W_getInverse_R_PxMeshScalePtr_C_PxMeshScale(physx::PxMeshScale* self){
        auto retVal = self->getInverse;
        return *(PxMeshScalePtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMeshScalePtr W_getInverse_R_PxMeshScalePtr_C_PxMeshScale(PxMeshScalePtr selfPtr);
    
    public  PxMeshScalePtr getInverse(){
        PxMeshScalePtr retVal = W_getInverse_R_PxMeshScalePtr_C_PxMeshScale(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       toMat33()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES PxMat33POD W_toMat33_R_PxMat33_C_PxMeshScale(physx::PxMeshScale* self){
        auto retVal = self->toMat33;
        return *(PxMat33POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_toMat33_R_PxMat33_C_PxMeshScale(PxMeshScalePtr selfPtr);
    
    public  PxMat33 toMat33(){
        PxMat33 retVal = W_toMat33_R_PxMat33_C_PxMeshScale(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       hasNegativeDeterminant()                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_hasNegativeDeterminant_R_bool_C_PxMeshScale(physx::PxMeshScale* self){
        auto retVal = self->hasNegativeDeterminant();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_hasNegativeDeterminant_R_bool_C_PxMeshScale(PxMeshScalePtr selfPtr);
    
    public  bool hasNegativeDeterminant(){
        bool retVal = W_hasNegativeDeterminant_R_bool_C_PxMeshScale(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transform(PxVec3Ptr v)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_transform_R_PxVec3_P_PxVec3_C_PxMeshScale(physx::PxMeshScale* self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self->transform;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform_R_PxVec3_P_PxVec3_C_PxMeshScale(PxMeshScalePtr selfPtr, PxVec3 v);
    
    public  PxVec3 transform(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_transform_R_PxVec3_P_PxVec3_C_PxMeshScale(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValidForTriangleMesh()                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValidForTriangleMesh_R_bool_C_PxMeshScale(physx::PxMeshScale* self){
        auto retVal = self->isValidForTriangleMesh();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValidForTriangleMesh_R_bool_C_PxMeshScale(PxMeshScalePtr selfPtr);
    
    public  bool isValidForTriangleMesh(){
        bool retVal = W_isValidForTriangleMesh_R_bool_C_PxMeshScale(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValidForConvexMesh()                                                 #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValidForConvexMesh_R_bool_C_PxMeshScale(physx::PxMeshScale* self){
        auto retVal = self->isValidForConvexMesh();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValidForConvexMesh_R_bool_C_PxMeshScale(PxMeshScalePtr selfPtr);
    
    public  bool isValidForConvexMesh(){
        bool retVal = W_isValidForConvexMesh_R_bool_C_PxMeshScale(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxMeshScale
    
    //Skipped generated implicit entry: PxMeshScale
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxMeshScale
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
