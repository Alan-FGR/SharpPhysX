#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxConvexMesh { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       getNbVertices                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L93~93
    #if NATIVE
    ES physx::PxU32 getNbVertices(physx::PxConvexMesh* self){
        physx::PxU32 retVal = self->getNbVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbVertices(PxConvexMesh selfPtr);
    
    public uint getNbVertices(){
        uint retVal = getNbVertices(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getVertices                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L100~100
    #if NATIVE
    ES UNPARSED_TYPE getVertices(physx::PxConvexMesh* self){
        UNPARSED_TYPE retVal = self->getVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getVertices(PxConvexMesh selfPtr);
    
    public UNPARSED_TYPE getVertices(){
        UNPARSED_TYPE retVal = getVertices(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getIndexBuffer                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L107~107
    #if NATIVE
    ES UNPARSED_TYPE getIndexBuffer(physx::PxConvexMesh* self){
        UNPARSED_TYPE retVal = self->getIndexBuffer();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getIndexBuffer(PxConvexMesh selfPtr);
    
    public UNPARSED_TYPE getIndexBuffer(){
        UNPARSED_TYPE retVal = getIndexBuffer(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbPolygons                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L114~114
    #if NATIVE
    ES physx::PxU32 getNbPolygons(physx::PxConvexMesh* self){
        physx::PxU32 retVal = self->getNbPolygons();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbPolygons(PxConvexMesh selfPtr);
    
    public uint getNbPolygons(){
        uint retVal = getNbPolygons(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getPolygonData                                                         #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L123~123
    #if NATIVE
    ES bool getPolygonData(physx::PxConvexMesh* self, physx::PxU32 index,  data){
        physx::PxU32 nat_in_index = (index);
         nat_in_data = (data);
        bool retVal = self->getPolygonData(nat_in_index, nat_in_data);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getPolygonData(PxConvexMesh selfPtr, uint index,  data);
    
    public bool getPolygonData(uint index,  data){
        uint pvk_in_index = (index);
         pvk_in_data = (data);
        bool retVal = getPolygonData(this, pvk_in_index, pvk_in_data);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L130~130
    #if NATIVE
    ES void release(physx::PxConvexMesh* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void release(PxConvexMesh selfPtr);
    
    public void release(){
        release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L140~140
    #if NATIVE
    ES physx::PxU32 getReferenceCount(physx::PxConvexMesh* self){
        physx::PxU32 retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getReferenceCount(PxConvexMesh selfPtr);
    
    public uint getReferenceCount(){
        uint retVal = getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L147~147
    #if NATIVE
    ES void acquireReference(physx::PxConvexMesh* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void acquireReference(PxConvexMesh selfPtr);
    
    public void acquireReference(){
        acquireReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getMassInformation                                                     #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference float*
    , Non const pointer/reference global::PhysX.physx.PxMat33
    , Non const pointer/reference global::PhysX.physx.PxVec3
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L165~165
    #if NATIVE
    ES void getMassInformation(physx::PxConvexMesh* self,  mass,  localInertia,  localCenterOfMass){
         nat_in_mass = (mass);
         nat_in_localInertia = (localInertia);
         nat_in_localCenterOfMass = (localCenterOfMass);
        self->getMassInformation(nat_in_mass, nat_in_localInertia, nat_in_localCenterOfMass);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void getMassInformation(PxConvexMesh selfPtr,  mass,  localInertia,  localCenterOfMass);
    
    public void getMassInformation( mass,  localInertia,  localCenterOfMass){
         pvk_in_mass = (mass);
         pvk_in_localInertia = (localInertia);
         pvk_in_localCenterOfMass = (localCenterOfMass);
        getMassInformation(this, pvk_in_mass, pvk_in_localInertia, pvk_in_localCenterOfMass);
    }
    #endif*/
    
    
    //================================================================================
    //#       getLocalBounds                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L172~172
    #if NATIVE
    ES UNPARSED_TYPE getLocalBounds(physx::PxConvexMesh* self){
        UNPARSED_TYPE retVal = self->getLocalBounds();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getLocalBounds(PxConvexMesh selfPtr);
    
    public UNPARSED_TYPE getLocalBounds(){
        UNPARSED_TYPE retVal = getLocalBounds(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L174~174
    #if NATIVE
    ES UNPARSED_TYPE getConcreteTypeName(physx::PxConvexMesh* self){
        UNPARSED_TYPE retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getConcreteTypeName(PxConvexMesh selfPtr);
    
    public UNPARSED_TYPE getConcreteTypeName(){
        UNPARSED_TYPE retVal = getConcreteTypeName(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isGpuCompatible                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L183~183
    #if NATIVE
    ES bool isGpuCompatible(physx::PxConvexMesh* self){
        bool retVal = self->isGpuCompatible();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isGpuCompatible(PxConvexMesh selfPtr);
    
    public bool isGpuCompatible(){
        bool retVal = isGpuCompatible(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxConvexMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxConvexMesh::PxConvexMesh::baseFlags
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L186~186
    #if NATIVE
    ES UNPARSED_TYPE PxConvexMesh_ctor(physx::PxType concreteType,  baseFlags){
        physx::PxType nat_in_concreteType = (concreteType);
         nat_in_baseFlags = (baseFlags);
        self->PxConvexMesh(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxConvexMesh_ctor(ushort concreteType,  baseFlags);
    
    public PxConvexMesh(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = PxConvexMesh_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxConvexMesh::PxConvexMesh::baseFlags
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L187~187
    #if NATIVE
    ES UNPARSED_TYPE PxConvexMesh_ctor( baseFlags){
         nat_in_baseFlags = (baseFlags);
        self->PxConvexMesh(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxConvexMesh_ctor( baseFlags);
    
    public PxConvexMesh( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = PxConvexMesh_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConvexMesh                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L188~188
    #if NATIVE
    ES void ~PxConvexMesh(physx::PxConvexMesh* self){
        self->~PxConvexMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxConvexMesh(PxConvexMesh selfPtr);
    
    public void ~PxConvexMesh(){
        ~PxConvexMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L189~189
    #if NATIVE
    ES bool isKindOf(physx::PxConvexMesh* self, char name){
        char nat_in_name = (name);
        bool retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isKindOf(PxConvexMesh selfPtr, sbyte name);
    
    public bool isKindOf(sbyte name){
        sbyte pvk_in_name = (name);
        bool retVal = isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxConvexMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L84~84
    #if NATIVE
    ES UNPARSED_TYPE PxConvexMesh_ctor( ){
         nat_in_ = ();
        self->PxConvexMesh(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxConvexMesh_ctor( );
    
    public PxConvexMesh( ){
         pvk_in_ = ();
        var _new = PxConvexMesh_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L84~84
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxConvexMesh* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxConvexMesh selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxHullPolygon { // blittable
    public float[] mPlane;
    public ushort mNbVerts;
    public ushort mIndexBase;

#endif

    //================================================================================
    //#       PxHullPolygon                                                          #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon PxHullPolygon_ctor(){
        self.PxHullPolygon();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon PxHullPolygon_ctor();
    
    public PxHullPolygon(){
        var _new = PxHullPolygon_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHullPolygon                                                          #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon PxHullPolygon_ctor(physx::PxHullPolygon ){
        physx::PxHullPolygon nat_in_ = ();
        self.PxHullPolygon(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon PxHullPolygon_ctor(PxHullPolygon );
    
    public PxHullPolygon(PxHullPolygon ){
        PxHullPolygon pvk_in_ = ();
        var _new = PxHullPolygon_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxHullPolygon self, physx::PxHullPolygon ){
        physx::PxHullPolygon nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxHullPolygon selfBlt, PxHullPolygon );
    
    public UNPARSED_TYPE operator=(PxHullPolygon ){
        PxHullPolygon pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHullPolygon                                                          #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon PxHullPolygon_ctor( ){
         nat_in_ = ();
        self.PxHullPolygon(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon PxHullPolygon_ctor( );
    
    public PxHullPolygon( ){
         pvk_in_ = ();
        var _new = PxHullPolygon_ctor(pvk_in_);
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
    Non const pointer/reference global::PhysX.physx.PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxHullPolygon self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxHullPolygon selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxHullPolygon                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES void ~PxHullPolygon(physx::PxHullPolygon self){
        self.~PxHullPolygon();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxHullPolygon(PxHullPolygon selfBlt);
    
    public void ~PxHullPolygon(){
        ~PxHullPolygon(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
