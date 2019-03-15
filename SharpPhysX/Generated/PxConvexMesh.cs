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
    ES physx::PxU32 W_getNbVertices(physx::PxConvexMesh* self){
        auto retVal = self->getNbVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbVertices(PxConvexMesh selfPtr);
    
    public uint getNbVertices(){
        uint retVal = W_getNbVertices(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getVertices                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L100~100
    #if NATIVE
    ES physx::PxVec3* W_getVertices(physx::PxConvexMesh* self){
        auto retVal = self->getVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getVertices(PxConvexMesh selfPtr);
    
    public PxVec3 getVertices(){
        PxVec3 retVal = W_getVertices(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getIndexBuffer                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L107~107
    #if NATIVE
    ES byte* W_getIndexBuffer(physx::PxConvexMesh* self){
        auto retVal = self->getIndexBuffer();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getIndexBuffer(PxConvexMesh selfPtr);
    
    public IntPtr getIndexBuffer(){
        IntPtr retVal = W_getIndexBuffer(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbPolygons                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L114~114
    #if NATIVE
    ES physx::PxU32 W_getNbPolygons(physx::PxConvexMesh* self){
        auto retVal = self->getNbPolygons();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbPolygons(PxConvexMesh selfPtr);
    
    public uint getNbPolygons(){
        uint retVal = W_getNbPolygons(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getPolygonData                                                         #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxHullPolygon
    // NATIVE SIG: bool				getPolygonData(PxU32 index, PxHullPolygon& data)	const	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L123~123
    #if NATIVE
    ES bool W_getPolygonData(physx::PxConvexMesh* self, physx::PxU32 index,  data){
        auto nat_in_index = (index);
        auto nat_in_data = (data);
        auto retVal = self->getPolygonData(nat_in_index, nat_in_data);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getPolygonData(PxConvexMesh selfPtr, uint index,  data);
    
    public bool getPolygonData(uint index,  data){
        uint pvk_in_index = (index);
         pvk_in_data = (data);
        bool retVal = W_getPolygonData(this, pvk_in_index, pvk_in_data);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L130~130
    #if NATIVE
    ES void W_release(physx::PxConvexMesh* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxConvexMesh selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L140~140
    #if NATIVE
    ES physx::PxU32 W_getReferenceCount(physx::PxConvexMesh* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount(PxConvexMesh selfPtr);
    
    public uint getReferenceCount(){
        uint retVal = W_getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L147~147
    #if NATIVE
    ES void W_acquireReference(physx::PxConvexMesh* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference(PxConvexMesh selfPtr);
    
    public void acquireReference(){
        W_acquireReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getMassInformation                                                     #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxMat33
    Non const pointer/reference global::PhysX.physx.PxVec3
    // NATIVE SIG: void				getMassInformation(PxReal& mass, PxMat33& localInertia, PxVec3& localCenterOfMass)		const	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L165~165
    #if NATIVE
    ES void W_getMassInformation(physx::PxConvexMesh* self, physx::PxReal& mass,  localInertia,  localCenterOfMass){
        auto nat_in_mass = (mass);
        auto nat_in_localInertia = (localInertia);
        auto nat_in_localCenterOfMass = (localCenterOfMass);
        self->getMassInformation(nat_in_mass, nat_in_localInertia, nat_in_localCenterOfMass);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_getMassInformation(PxConvexMesh selfPtr, float* mass,  localInertia,  localCenterOfMass);
    
    public void getMassInformation(float* mass,  localInertia,  localCenterOfMass){
        float* pvk_in_mass = (mass);
         pvk_in_localInertia = (localInertia);
         pvk_in_localCenterOfMass = (localCenterOfMass);
        W_getMassInformation(this, pvk_in_mass, pvk_in_localInertia, pvk_in_localCenterOfMass);
    }
    #endif*/
    
    
    //================================================================================
    //#       getLocalBounds                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxBounds3			getLocalBounds()	const	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L172~172
    #if NATIVE
    ES UNPARSED_TYPE W_getLocalBounds(physx::PxConvexMesh* self){
        auto retVal = self->getLocalBounds();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getLocalBounds(PxConvexMesh selfPtr);
    
    public UNPARSED_TYPE getLocalBounds(){
        UNPARSED_TYPE retVal = W_getLocalBounds(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L174~174
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxConvexMesh* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxConvexMesh selfPtr);
    
    public IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isGpuCompatible                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L183~183
    #if NATIVE
    ES bool W_isGpuCompatible(physx::PxConvexMesh* self){
        auto retVal = self->isGpuCompatible();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isGpuCompatible(PxConvexMesh selfPtr);
    
    public bool isGpuCompatible(){
        bool retVal = W_isGpuCompatible(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxConvexMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxConvexMesh::PxConvexMesh::baseFlags
    // NATIVE SIG: PX_INLINE					PxConvexMesh(PxType concreteType, PxBaseFlags baseFlags) : PxBase(concreteType, baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L186~186
    #if NATIVE
    ES UNPARSED_TYPE W_PxConvexMesh_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxConvexMesh(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConvexMesh_ctor(ushort concreteType,  baseFlags);
    
    public PxConvexMesh(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxConvexMesh_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxConvexMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxConvexMesh::PxConvexMesh::baseFlags
    // NATIVE SIG: PX_INLINE					PxConvexMesh(PxBaseFlags baseFlags) : PxBase(baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L187~187
    #if NATIVE
    ES UNPARSED_TYPE W_PxConvexMesh_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxConvexMesh(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConvexMesh_ctor( baseFlags);
    
    public PxConvexMesh( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxConvexMesh_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxConvexMesh                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PX_PHYSX_COMMON_API virtual						~PxConvexMesh() {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L188~188
    #if NATIVE
    ES void W_~PxConvexMesh(physx::PxConvexMesh* self){
        self->~PxConvexMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConvexMesh(PxConvexMesh selfPtr);
    
    public void ~PxConvexMesh(){
        W_~PxConvexMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L189~189
    #if NATIVE
    ES bool W_isKindOf(physx::PxConvexMesh* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxConvexMesh selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxConvexMesh                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMesh
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L84~84
    #if NATIVE
    ES UNPARSED_TYPE W_PxConvexMesh_ctor(physx::PxConvexMesh* ){
        auto nat_in_ = ();
        self->PxConvexMesh(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConvexMesh_ctor(PxConvexMesh );
    
    public PxConvexMesh(PxConvexMesh ){
        PxConvexMesh pvk_in_ = ();
        var _new = W_PxConvexMesh_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxConvexMesh
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L84~84
    #if NATIVE
    ES physx::PxConvexMesh* W_operator=(physx::PxConvexMesh* self, physx::PxConvexMesh* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMesh W_operator=(PxConvexMesh selfPtr, PxConvexMesh );
    
    public static PxConvexMesh operator=(PxConvexMesh lhs, PxConvexMesh ){
        PxConvexMesh pvk_in_ = ();
        PxConvexMesh retVal = W_operator=(lhs, pvk_in_);
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
    // NATIVE SIG: PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon W_PxHullPolygon_ctor(){
        self.PxHullPolygon();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon W_PxHullPolygon_ctor();
    
    public PxHullPolygon(){
        var _new = W_PxHullPolygon_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHullPolygon                                                          #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon W_PxHullPolygon_ctor(physx::PxHullPolygon ){
        auto nat_in_ = ();
        self.PxHullPolygon(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon W_PxHullPolygon_ctor(PxHullPolygon );
    
    public PxHullPolygon(PxHullPolygon ){
        PxHullPolygon pvk_in_ = ();
        var _new = W_PxHullPolygon_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon* W_operator=(physx::PxHullPolygon self, physx::PxHullPolygon ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon W_operator=(PxHullPolygon selfBlt, PxHullPolygon );
    
    public static PxHullPolygon operator=(PxHullPolygon lhs, PxHullPolygon ){
        PxHullPolygon pvk_in_ = ();
        PxHullPolygon retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxHullPolygon                                                          #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxHullPolygon
    // NATIVE SIG: PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon W_PxHullPolygon_ctor( ){
        auto nat_in_ = ();
        self.PxHullPolygon(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon W_PxHullPolygon_ctor( );
    
    public PxHullPolygon( ){
         pvk_in_ = ();
        var _new = W_PxHullPolygon_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxHullPolygon
    // NATIVE SIG: PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES physx::PxHullPolygon* W_operator=(physx::PxHullPolygon self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon W_operator=(PxHullPolygon selfBlt);
    
    public static PxHullPolygon operator=(PxHullPolygon lhs,  ){
         pvk_in_ = ();
        PxHullPolygon retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxHullPolygon                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxHullPolygon
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxConvexMesh.h L51~51
    #if NATIVE
    ES void W_~PxHullPolygon(physx::PxHullPolygon self){
        self.~PxHullPolygon();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxHullPolygon(PxHullPolygon selfBlt);
    
    public void ~PxHullPolygon(){
        W_~PxHullPolygon(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
