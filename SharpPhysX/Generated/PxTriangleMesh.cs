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
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L95~95
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
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L95~95
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
// SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L95~95
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
public unsafe partial struct PxTriangleMesh { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       getNbVertices                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L134~134
    #if NATIVE
    ES physx::PxU32 W_getNbVertices(physx::PxTriangleMesh* self){
        auto retVal = self->getNbVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbVertices(PxTriangleMesh selfPtr);
    
    public uint getNbVertices(){
        uint retVal = W_getNbVertices(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getVertices                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L141~141
    #if NATIVE
    ES physx::PxVec3* W_getVertices(physx::PxTriangleMesh* self){
        auto retVal = self->getVertices();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getVertices(PxTriangleMesh selfPtr);
    
    public PxVec3 getVertices(){
        PxVec3 retVal = W_getVertices(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getVerticesForModification                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L163~163
    #if NATIVE
    ES physx::PxVec3* W_getVerticesForModification(physx::PxTriangleMesh* self){
        auto retVal = self->getVerticesForModification();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getVerticesForModification(PxTriangleMesh selfPtr);
    
    public PxVec3 getVerticesForModification(){
        PxVec3 retVal = W_getVerticesForModification(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       refitBVH                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L182~182
    #if NATIVE
    ES physx::PxBounds3 W_refitBVH(physx::PxTriangleMesh* self){
        auto retVal = self->refitBVH();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_refitBVH(PxTriangleMesh selfPtr);
    
    public PxBounds3 refitBVH(){
        PxBounds3 retVal = W_refitBVH(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbTriangles                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L190~190
    #if NATIVE
    ES physx::PxU32 W_getNbTriangles(physx::PxTriangleMesh* self){
        auto retVal = self->getNbTriangles();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbTriangles(PxTriangleMesh selfPtr);
    
    public uint getNbTriangles(){
        uint retVal = W_getNbTriangles(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTriangles                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L203~203
    #if NATIVE
    ES void* W_getTriangles(physx::PxTriangleMesh* self){
        auto retVal = self->getTriangles();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getTriangles(PxTriangleMesh selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L214~214
    #if NATIVE
    ES UNPARSED_TYPE W_getTriangleMeshFlags(physx::PxTriangleMesh* self){
        auto retVal = self->getTriangleMeshFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getTriangleMeshFlags(PxTriangleMesh selfPtr);
    
    public UNPARSED_TYPE getTriangleMeshFlags(){
        UNPARSED_TYPE retVal = W_getTriangleMeshFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTrianglesRemap                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L228~228
    #if NATIVE
    ES uint* W_getTrianglesRemap(physx::PxTriangleMesh* self){
        auto retVal = self->getTrianglesRemap();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getTrianglesRemap(PxTriangleMesh selfPtr);
    
    public IntPtr getTrianglesRemap(){
        IntPtr retVal = W_getTrianglesRemap(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L236~236
    #if NATIVE
    ES void W_release(physx::PxTriangleMesh* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxTriangleMesh selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getTriangleMaterialIndex                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L246~246
    #if NATIVE
    ES physx::PxMaterialTableIndex W_getTriangleMaterialIndex(physx::PxTriangleMesh* self, physx::PxTriangleID triangleIndex){
        auto nat_in_triangleIndex = (triangleIndex);
        auto retVal = self->getTriangleMaterialIndex(nat_in_triangleIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getTriangleMaterialIndex(PxTriangleMesh selfPtr, uint triangleIndex);
    
    public ushort getTriangleMaterialIndex(uint triangleIndex){
        uint pvk_in_triangleIndex = (triangleIndex);
        ushort retVal = W_getTriangleMaterialIndex(this, pvk_in_triangleIndex);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getLocalBounds                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L253~253
    #if NATIVE
    ES physx::PxBounds3 W_getLocalBounds(physx::PxTriangleMesh* self){
        auto retVal = self->getLocalBounds();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_getLocalBounds(PxTriangleMesh selfPtr);
    
    public PxBounds3 getLocalBounds(){
        PxBounds3 retVal = W_getLocalBounds(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L263~263
    #if NATIVE
    ES physx::PxU32 W_getReferenceCount(physx::PxTriangleMesh* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount(PxTriangleMesh selfPtr);
    
    public uint getReferenceCount(){
        uint retVal = W_getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L270~270
    #if NATIVE
    ES void W_acquireReference(physx::PxTriangleMesh* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference(PxTriangleMesh selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L273~273
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L274~274
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L275~275
    #if NATIVE
    ES void W_~PxTriangleMesh(physx::PxTriangleMesh* self){
        self->~PxTriangleMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxTriangleMesh(PxTriangleMesh selfPtr);
    
    public void ~PxTriangleMesh(){
        W_~PxTriangleMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L277~277
    #if NATIVE
    ES bool W_isKindOf(physx::PxTriangleMesh* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxTriangleMesh selfPtr, string name);
    
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
public unsafe partial struct PxBVH33TriangleMesh { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBVH33TriangleMesh                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBVH33TriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxBVH33TriangleMesh(PxType concreteType, PxBaseFlags baseFlags) : PxTriangleMesh(concreteType, baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L290~290
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L291~291
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L292~292
    #if NATIVE
    ES void W_~PxBVH33TriangleMesh(physx::PxBVH33TriangleMesh* self){
        self->~PxBVH33TriangleMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBVH33TriangleMesh(PxBVH33TriangleMesh selfPtr);
    
    public void ~PxBVH33TriangleMesh(){
        W_~PxBVH33TriangleMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L293~293
    #if NATIVE
    ES bool W_isKindOf(physx::PxBVH33TriangleMesh* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxBVH33TriangleMesh selfPtr, string name);
    
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
public unsafe partial struct PxBVH34TriangleMesh { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBVH34TriangleMesh                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxBVH34TriangleMesh
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE						PxBVH34TriangleMesh(PxType concreteType, PxBaseFlags baseFlags) : PxTriangleMesh(concreteType, baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L306~306
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L307~307
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
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L308~308
    #if NATIVE
    ES void W_~PxBVH34TriangleMesh(physx::PxBVH34TriangleMesh* self){
        self->~PxBVH34TriangleMesh();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBVH34TriangleMesh(PxBVH34TriangleMesh selfPtr);
    
    public void ~PxBVH34TriangleMesh(){
        W_~PxBVH34TriangleMesh(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\geometry\PxTriangleMesh.h L309~309
    #if NATIVE
    ES bool W_isKindOf(physx::PxBVH34TriangleMesh* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxBVH34TriangleMesh selfPtr, string name);
    
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