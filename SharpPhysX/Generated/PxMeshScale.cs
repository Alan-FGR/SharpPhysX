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
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L80~82
    #if NATIVE
    ES UNPARSED_TYPE PxMeshScale_ctor(){
        self->PxMeshScale();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxMeshScale_ctor();
    
    public PxMeshScale(){
        var _new = PxMeshScale_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L87~89
    #if NATIVE
    ES UNPARSED_TYPE PxMeshScale_ctor(physx::PxReal r){
        physx::PxReal nat_in_r = (r);
        self->PxMeshScale(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxMeshScale_ctor(float r);
    
    public PxMeshScale(float r){
        float pvk_in_r = (r);
        var _new = PxMeshScale_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L94~98
    #if NATIVE
    ES UNPARSED_TYPE PxMeshScale_ctor(physx::PxVec3 s){
        physx::PxVec3 nat_in_s = (s);
        self->PxMeshScale(nat_in_s);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxMeshScale_ctor(PxVec3 s);
    
    public PxMeshScale(PxVec3 s){
        PxVec3 pvk_in_s = (s);
        var _new = PxMeshScale_ctor(pvk_in_s);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L103~108
    #if NATIVE
    ES UNPARSED_TYPE PxMeshScale_ctor(physx::PxVec3 s, physx::PxQuat r){
        physx::PxVec3 nat_in_s = (s);
        physx::PxQuat nat_in_r = (r);
        self->PxMeshScale(nat_in_s, nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxMeshScale_ctor(PxVec3 s, PxQuat r);
    
    public PxMeshScale(PxVec3 s, PxQuat r){
        PxVec3 pvk_in_s = (s);
        PxQuat pvk_in_r = (r);
        var _new = PxMeshScale_ctor(pvk_in_s, pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       isIdentity                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L114~117
    #if NATIVE
    ES bool isIdentity(physx::PxMeshScale* self){
        bool retVal = self->isIdentity();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isIdentity(PxMeshScale selfPtr);
    
    public bool isIdentity(){
        bool retVal = isIdentity(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInverse                                                             #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L122~125
    #if NATIVE
    ES UNPARSED_TYPE getInverse(physx::PxMeshScale* self){
        UNPARSED_TYPE retVal = self->getInverse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getInverse(PxMeshScale selfPtr);
    
    public UNPARSED_TYPE getInverse(){
        UNPARSED_TYPE retVal = getInverse(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       toMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L130~138
    #if NATIVE
    ES physx::PxMat33 toMat33(physx::PxMeshScale* self){
        physx::PxMat33 retVal = self->toMat33();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 toMat33(PxMeshScale selfPtr);
    
    public PxMat33 toMat33(){
        PxMat33 retVal = toMat33(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       hasNegativeDeterminant                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L143~146
    #if NATIVE
    ES bool hasNegativeDeterminant(physx::PxMeshScale* self){
        bool retVal = self->hasNegativeDeterminant();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool hasNegativeDeterminant(PxMeshScale selfPtr);
    
    public bool hasNegativeDeterminant(){
        bool retVal = hasNegativeDeterminant(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L148~151
    #if NATIVE
    ES physx::PxVec3 transform(physx::PxMeshScale* self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self->transform(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 transform(PxMeshScale selfPtr, PxVec3 v);
    
    public PxVec3 transform(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = transform(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isValidForTriangleMesh                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L153~157
    #if NATIVE
    ES bool isValidForTriangleMesh(physx::PxMeshScale* self){
        bool retVal = self->isValidForTriangleMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValidForTriangleMesh(PxMeshScale selfPtr);
    
    public bool isValidForTriangleMesh(){
        bool retVal = isValidForTriangleMesh(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isValidForConvexMesh                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L159~162
    #if NATIVE
    ES bool isValidForConvexMesh(physx::PxMeshScale* self){
        bool retVal = self->isValidForConvexMesh();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValidForConvexMesh(PxMeshScale selfPtr);
    
    public bool isValidForConvexMesh(){
        bool retVal = isValidForConvexMesh(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L68~68
    #if NATIVE
    ES UNPARSED_TYPE PxMeshScale_ctor( ){
         nat_in_ = ();
        self->PxMeshScale(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxMeshScale_ctor( );
    
    public PxMeshScale( ){
         pvk_in_ = ();
        var _new = PxMeshScale_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMeshScale                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L68~68
    #if NATIVE
    ES UNPARSED_TYPE PxMeshScale_ctor( ){
         nat_in_ = ();
        self->PxMeshScale(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxMeshScale_ctor( );
    
    public PxMeshScale( ){
         pvk_in_ = ();
        var _new = PxMeshScale_ctor(pvk_in_);
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
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L68~68
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxMeshScale* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxMeshScale selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxMeshScale                                                           #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L68~68
    #if NATIVE
    ES void ~PxMeshScale(physx::PxMeshScale* self){
        self->~PxMeshScale();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxMeshScale(PxMeshScale selfPtr);
    
    public void ~PxMeshScale(){
        ~PxMeshScale(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxMeshScale.h L68~68
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxMeshScale* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxMeshScale selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
