#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxMeshScale { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxMeshScale
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMeshScale
    // NATIVE SIG: explicit PX_CUDA_CALLABLE PX_FORCE_INLINE PxMeshScale(PxReal r): scale(r), rotation(PxIdentity) 
    	{
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L87~89
    #if NATIVE
    ES UNPARSED_TYPE W_PxMeshScale_ctor(physx::PxReal r){
        auto nat_in_r = (r);
        self->PxMeshScale(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxMeshScale_ctor(float r);
    
    public PxMeshScale(float r){
        float pvk_in_r = (r);
        var _new = W_PxMeshScale_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMeshScale
    // NATIVE SIG: PX_FORCE_INLINE PxMeshScale(const PxVec3& s)
    	{
    		scale = s;
    		rotation = PxQuat(PxIdentity);
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L94~98
    #if NATIVE
    ES UNPARSED_TYPE W_PxMeshScale_ctor(physx::PxVec3 s){
        auto nat_in_s = (s);
        self->PxMeshScale(nat_in_s);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxMeshScale_ctor(PxVec3 s);
    
    public PxMeshScale(PxVec3 s){
        PxVec3 pvk_in_s = (s);
        var _new = W_PxMeshScale_ctor(pvk_in_s);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMeshScale
    // NATIVE SIG: PX_FORCE_INLINE PxMeshScale(const PxVec3& s, const PxQuat& r)
    	{
    		PX_ASSERT(r.isUnit());
    		scale = s;
    		rotation = r;
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L103~108
    #if NATIVE
    ES UNPARSED_TYPE W_PxMeshScale_ctor(physx::PxVec3 s, physx::PxQuat r){
        auto nat_in_s = (s);
        auto nat_in_r = (r);
        self->PxMeshScale(nat_in_s, nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxMeshScale_ctor(PxVec3 s, PxQuat r);
    
    public PxMeshScale(PxVec3 s, PxQuat r){
        PxVec3 pvk_in_s = (s);
        PxQuat pvk_in_r = (r);
        var _new = W_PxMeshScale_ctor(pvk_in_s, pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isIdentity                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L114~117
    #if NATIVE
    ES bool W_isIdentity(physx::PxMeshScale* self){
        auto retVal = self->isIdentity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isIdentity(PxMeshScale selfPtr);
    
    public bool isIdentity(){
        bool retVal = W_isIdentity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInverse                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxMeshScale
    // NATIVE SIG: PxMeshScale getInverse() const 
    	{
    		return PxMeshScale(PxVec3(1.0f/scale.x, 1.0f/scale.y, 1.0f/scale.z), rotation);
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L122~125
    #if NATIVE
    ES UNPARSED_TYPE W_getInverse(physx::PxMeshScale* self){
        auto retVal = self->getInverse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getInverse(PxMeshScale selfPtr);
    
    public UNPARSED_TYPE getInverse(){
        UNPARSED_TYPE retVal = W_getInverse(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       toMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L130~138
    #if NATIVE
    ES physx::PxMat33 W_toMat33(physx::PxMeshScale* self){
        auto retVal = self->toMat33();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_toMat33(PxMeshScale selfPtr);
    
    public PxMat33 toMat33(){
        PxMat33 retVal = W_toMat33(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       hasNegativeDeterminant                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L143~146
    #if NATIVE
    ES bool W_hasNegativeDeterminant(physx::PxMeshScale* self){
        auto retVal = self->hasNegativeDeterminant();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_hasNegativeDeterminant(PxMeshScale selfPtr);
    
    public bool hasNegativeDeterminant(){
        bool retVal = W_hasNegativeDeterminant(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L148~151
    #if NATIVE
    ES physx::PxVec3 W_transform(physx::PxMeshScale* self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self->transform(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform(PxMeshScale selfPtr, PxVec3 v);
    
    public PxVec3 transform(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_transform(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isValidForTriangleMesh                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L153~157
    #if NATIVE
    ES bool W_isValidForTriangleMesh(physx::PxMeshScale* self){
        auto retVal = self->isValidForTriangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValidForTriangleMesh(PxMeshScale selfPtr);
    
    public bool isValidForTriangleMesh(){
        bool retVal = W_isValidForTriangleMesh(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isValidForConvexMesh                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L159~162
    #if NATIVE
    ES bool W_isValidForConvexMesh(physx::PxMeshScale* self){
        auto retVal = self->isValidForConvexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValidForConvexMesh(PxMeshScale selfPtr);
    
    public bool isValidForConvexMesh(){
        bool retVal = W_isValidForConvexMesh(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxMeshScale
    
    //Skipped generated implicit entry: PxMeshScale
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxMeshScale
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif
