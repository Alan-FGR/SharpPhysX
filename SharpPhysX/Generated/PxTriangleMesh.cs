#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxTriangleMeshFlag : int {
    e16_BIT_INDICES = 2, // e16_BIT_INDICES = (1<<1)
    eADJACENCY_INFO = 4, // eADJACENCY_INFO = (1<<2)
}
#endif

#if !NATIVE
public enum PxMeshMidPhase : int {
    eBVH33 = 0, // eBVH33 = 0
    eBVH34 = 1, // eBVH34 = 1
    eLAST = 2,  // eLAST
}
#endif

#if !NATIVE
public partial struct PxTriangleMesh {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxTriangleMeshFlag::Enum a, physx::PxTriangleMeshFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxTriangleMeshFlag a, PxTriangleMeshFlag b);

public static UNPARSED_TYPE operator|(PxTriangleMeshFlag a, PxTriangleMeshFlag b){
    PxTriangleMeshFlag pvk_in_a = (a);
    PxTriangleMeshFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxTriangleMeshFlag::Enum a, physx::PxTriangleMeshFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxTriangleMeshFlag a, PxTriangleMeshFlag b);

public static UNPARSED_TYPE operator&(PxTriangleMeshFlag a, PxTriangleMeshFlag b){
    PxTriangleMeshFlag pvk_in_a = (a);
    PxTriangleMeshFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxTriangleMeshFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxTriangleMeshFlag a);

public static UNPARSED_TYPE operator~(PxTriangleMeshFlag a){
    PxTriangleMeshFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxTriangleMesh
#endif


#if !NATIVE
public unsafe partial struct PxTriangleMeshPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       getNbVertices                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getNbVertices(physx::PxTriangleMesh* self){
        auto retVal = self->getNbVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbVertices(PxTriangleMeshPtr selfPtr);
    
    public uint getNbVertices(){
        uint retVal = W_getNbVertices(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getVertices                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3* W_getVertices(physx::PxTriangleMesh* self){
        auto retVal = self->getVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getVertices(PxTriangleMeshPtr selfPtr);
    
    public PxVec3 getVertices(){
        PxVec3 retVal = W_getVertices(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getVerticesForModification                                             #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3* W_getVerticesForModification(physx::PxTriangleMesh* self){
        auto retVal = self->getVerticesForModification();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getVerticesForModification(PxTriangleMeshPtr selfPtr);
    
    public PxVec3 getVerticesForModification(){
        PxVec3 retVal = W_getVerticesForModification(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       refitBVH                                                               #
    //================================================================================
    #if NATIVE
    ES physx::PxBounds3 W_refitBVH(physx::PxTriangleMesh* self){
        auto retVal = self->refitBVH();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_refitBVH(PxTriangleMeshPtr selfPtr);
    
    public PxBounds3 refitBVH(){
        PxBounds3 retVal = W_refitBVH(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbTriangles                                                         #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getNbTriangles(physx::PxTriangleMesh* self){
        auto retVal = self->getNbTriangles();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbTriangles(PxTriangleMeshPtr selfPtr);
    
    public uint getNbTriangles(){
        uint retVal = W_getNbTriangles(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTriangles                                                           #
    //================================================================================
    #if NATIVE
    ES void* W_getTriangles(physx::PxTriangleMesh* self){
        auto retVal = self->getTriangles();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getTriangles(PxTriangleMeshPtr selfPtr);
    
    public IntPtr getTriangles(){
        IntPtr retVal = W_getTriangles(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTriangleMeshFlags                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxTriangleMeshFlags
    // NATIVE SIG: PxTriangleMeshFlags		getTriangleMeshFlags()							const = 0
    #if NATIVE
    ES UNPARSED_TYPE W_getTriangleMeshFlags(physx::PxTriangleMesh* self){
        auto retVal = self->getTriangleMeshFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getTriangleMeshFlags(PxTriangleMeshPtr selfPtr);
    
    public UNPARSED_TYPE getTriangleMeshFlags(){
        UNPARSED_TYPE retVal = W_getTriangleMeshFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTrianglesRemap                                                      #
    //================================================================================
    #if NATIVE
    ES uint* W_getTrianglesRemap(physx::PxTriangleMesh* self){
        auto retVal = self->getTrianglesRemap();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getTrianglesRemap(PxTriangleMeshPtr selfPtr);
    
    public IntPtr getTrianglesRemap(){
        IntPtr retVal = W_getTrianglesRemap(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxTriangleMesh* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxTriangleMeshPtr selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getTriangleMaterialIndex                                               #
    //================================================================================
    #if NATIVE
    ES physx::PxMaterialTableIndex W_getTriangleMaterialIndex(physx::PxTriangleMesh* self, physx::PxTriangleID triangleIndex){
        auto nat_in_triangleIndex = (triangleIndex);
        auto retVal = self->getTriangleMaterialIndex(nat_in_triangleIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getTriangleMaterialIndex(PxTriangleMeshPtr selfPtr, uint triangleIndex);
    
    public ushort getTriangleMaterialIndex(uint triangleIndex){
        uint pvk_in_triangleIndex = (triangleIndex);
        ushort retVal = W_getTriangleMaterialIndex(this, pvk_in_triangleIndex);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getLocalBounds                                                         #
    //================================================================================
    #if NATIVE
    ES physx::PxBounds3 W_getLocalBounds(physx::PxTriangleMesh* self){
        auto retVal = self->getLocalBounds();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_getLocalBounds(PxTriangleMeshPtr selfPtr);
    
    public PxBounds3 getLocalBounds(){
        PxBounds3 retVal = W_getLocalBounds(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getReferenceCount(physx::PxTriangleMesh* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount(PxTriangleMeshPtr selfPtr);
    
    public uint getReferenceCount(){
        uint retVal = W_getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    #if NATIVE
    ES void W_acquireReference(physx::PxTriangleMesh* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference(PxTriangleMeshPtr selfPtr);
    
    public void acquireReference(){
        W_acquireReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       PxTriangleMesh                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxTriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxTriangleMesh(PxType concreteType, PxBaseFlags baseFlags) : PxBase(concreteType, baseFlags)	{}
    #if NATIVE
    ES UNPARSED_TYPE W_PxTriangleMesh_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxTriangleMesh(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxTriangleMesh_ctor(ushort concreteType,  baseFlags);
    
    public PxTriangleMesh(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxTriangleMesh_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxTriangleMesh                                                         #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxTriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxTriangleMesh(PxBaseFlags baseFlags) : PxBase(baseFlags)										{}
    #if NATIVE
    ES UNPARSED_TYPE W_PxTriangleMesh_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxTriangleMesh(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxTriangleMesh_ctor( baseFlags);
    
    public PxTriangleMesh( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxTriangleMesh_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxTriangleMesh                                                        #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual							~PxTriangleMesh() {}
    #if NATIVE
    ES void W_~PxTriangleMesh(physx::PxTriangleMesh* self){
        self->~PxTriangleMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public void ~PxTriangleMesh(){
        W_~PxTriangleMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxTriangleMesh* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxTriangleMeshPtr selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxTriangleMesh
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxTriangleMeshFlag is enum namespace
#if !NATIVE
public unsafe partial struct PxBVH33TriangleMeshPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBVH33TriangleMesh                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBVH33TriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxBVH33TriangleMesh(PxType concreteType, PxBaseFlags baseFlags) : PxTriangleMesh(concreteType, baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxBVH33TriangleMesh_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxBVH33TriangleMesh(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBVH33TriangleMesh_ctor(ushort concreteType,  baseFlags);
    
    public PxBVH33TriangleMesh(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxBVH33TriangleMesh_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBVH33TriangleMesh                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBVH33TriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxBVH33TriangleMesh(PxBaseFlags baseFlags) : PxTriangleMesh(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxBVH33TriangleMesh_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxBVH33TriangleMesh(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBVH33TriangleMesh_ctor( baseFlags);
    
    public PxBVH33TriangleMesh( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxBVH33TriangleMesh_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBVH33TriangleMesh                                                   #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual							~PxBVH33TriangleMesh() {}
    #if NATIVE
    ES void W_~PxBVH33TriangleMesh(physx::PxBVH33TriangleMesh* self){
        self->~PxBVH33TriangleMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBVH33TriangleMesh(PxBVH33TriangleMeshPtr selfPtr);
    
    public void ~PxBVH33TriangleMesh(){
        W_~PxBVH33TriangleMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxBVH33TriangleMesh* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxBVH33TriangleMeshPtr selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxBVH33TriangleMesh
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxBVH34TriangleMeshPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBVH34TriangleMesh                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBVH34TriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxBVH34TriangleMesh(PxType concreteType, PxBaseFlags baseFlags) : PxTriangleMesh(concreteType, baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxBVH34TriangleMesh_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxBVH34TriangleMesh(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBVH34TriangleMesh_ctor(ushort concreteType,  baseFlags);
    
    public PxBVH34TriangleMesh(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxBVH34TriangleMesh_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBVH34TriangleMesh                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBVH34TriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxBVH34TriangleMesh(PxBaseFlags baseFlags) : PxTriangleMesh(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxBVH34TriangleMesh_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxBVH34TriangleMesh(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBVH34TriangleMesh_ctor( baseFlags);
    
    public PxBVH34TriangleMesh( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxBVH34TriangleMesh_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBVH34TriangleMesh                                                   #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual							~PxBVH34TriangleMesh() {}
    #if NATIVE
    ES void W_~PxBVH34TriangleMesh(physx::PxBVH34TriangleMesh* self){
        self->~PxBVH34TriangleMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBVH34TriangleMesh(PxBVH34TriangleMeshPtr selfPtr);
    
    public void ~PxBVH34TriangleMesh(){
        W_~PxBVH34TriangleMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxBVH34TriangleMesh* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxBVH34TriangleMeshPtr selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxBVH34TriangleMesh
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxMeshMidPhase is enum namespace