#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxTriangleMeshFlag : int {
    e16_BIT_INDICES = 2, // e16_BIT_INDICES = (1<<1)
    eADJACENCY_INFO = 4, // eADJACENCY_INFO = (1<<2)
}
#endif //enum

#if !NATIVE //enum
public enum PxMeshMidPhase : int {
    eBVH33 = 0, // eBVH33 = 0
    eBVH34 = 1, // eBVH34 = 1
    eLAST = 2,  // eLAST
}
#endif //enum

#if !NATIVE //functions holder
public partial struct PxTriangleMeshPtr {
#endif

//================================================================================
//#       operator|(PxTriangleMeshFlag a, PxTriangleMeshFlag b)                  #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char> -> PxFlags_PxTriangleMeshFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag_P_PxTriangleMeshFlag(physx::PxTriangleMeshFlag::Enum a, physx::PxTriangleMeshFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag_P_PxTriangleMeshFlag(PxTriangleMeshFlag a, PxTriangleMeshFlag b);

public static UNPARSED_TYPE operator|(PxTriangleMeshFlag a, PxTriangleMeshFlag b){
    PxTriangleMeshFlag pvk_in_a = (a);
    PxTriangleMeshFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag_P_PxTriangleMeshFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&(PxTriangleMeshFlag a, PxTriangleMeshFlag b)                  #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char> -> PxFlags_PxTriangleMeshFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag_P_PxTriangleMeshFlag(physx::PxTriangleMeshFlag::Enum a, physx::PxTriangleMeshFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag_P_PxTriangleMeshFlag(PxTriangleMeshFlag a, PxTriangleMeshFlag b);

public static UNPARSED_TYPE operator&(PxTriangleMeshFlag a, PxTriangleMeshFlag b){
    PxTriangleMeshFlag pvk_in_a = (a);
    PxTriangleMeshFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag_P_PxTriangleMeshFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~(PxTriangleMeshFlag a)                                        #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
unhandled return type: physx::PxFlags<physx::PxTriangleMeshFlag::Enum, unsigned char> -> PxFlags_PxTriangleMeshFlag_byte
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag(physx::PxTriangleMeshFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag(PxTriangleMeshFlag a);

public static UNPARSED_TYPE operator~(PxTriangleMeshFlag a){
    PxTriangleMeshFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxTriangleMeshFlag_byte_P_PxTriangleMeshFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxTriangleMeshPtr
#endif


#if !NATIVE //interface
public unsafe interface IPxTriangleMeshPtr {
     uint getNbVertices();
     PxVec3 getVertices();
     PxVec3 getVerticesForModification();
     PxBounds3 refitBVH();
     uint getNbTriangles();
     IntPtr getTriangles();
    // UNPARSED_TYPE getTriangleMeshFlags();
     IntPtr getTrianglesRemap();
     void release();
     ushort getTriangleMaterialIndex(uint triangleIndex);
     PxBounds3 getLocalBounds();
     uint getReferenceCount();
     void acquireReference();
    // static PxTriangleMeshPtr New(/*NULLPARS*/);
    // static PxTriangleMeshPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxTriangleMesh(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // static PxTriangleMeshPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxTriangleMeshPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxTriangleMeshPtr : IPxBasePtr, IPxTriangleMeshPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxTriangleMeshPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxTriangleMeshPtr
    public static implicit operator PxBasePtr(PxTriangleMeshPtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxTriangleMeshPtr(PxBasePtr obj){return *(PxTriangleMeshPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxBasePtr
    public  string getConcreteTypeName(){return ((PxBasePtr)this).getConcreteTypeName();}
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    public  ushort getConcreteType(){return ((PxBasePtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxBasePtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxBasePtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxBasePtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxBasePtr)this).isReleasable();}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxBase(/*NULLPARS*/){((PxBasePtr)this).~PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE typeMatch(/*NULLPARS*/){return ((PxBasePtr)this).typeMatch(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxBasePtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       getNbVertices()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbVertices_R_uint_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getNbVertices();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbVertices_R_uint_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  uint getNbVertices(){
        uint retVal = W_getNbVertices_R_uint_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getVertices()                                                          #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxVec3* W_getVertices_R_PxVec3Ptr_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getVertices();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getVertices_R_PxVec3Ptr_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  PxVec3 getVertices(){
        PxVec3 retVal = W_getVertices_R_PxVec3Ptr_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getVerticesForModification()                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3* W_getVerticesForModification_R_PxVec3Ptr_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getVerticesForModification();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getVerticesForModification_R_PxVec3Ptr_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  PxVec3 getVerticesForModification(){
        PxVec3 retVal = W_getVerticesForModification_R_PxVec3Ptr_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       refitBVH()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES PxBounds3POD W_refitBVH_R_PxBounds3_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->refitBVH;
        return *(PxBounds3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_refitBVH_R_PxBounds3_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  PxBounds3 refitBVH(){
        PxBounds3 retVal = W_refitBVH_R_PxBounds3_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNbTriangles()                                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbTriangles_R_uint_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getNbTriangles();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbTriangles_R_uint_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  uint getNbTriangles(){
        uint retVal = W_getNbTriangles_R_uint_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTriangles()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES const void* W_getTriangles_R_IntPtr_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getTriangles();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getTriangles_R_IntPtr_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  IntPtr getTriangles(){
        IntPtr retVal = W_getTriangles_R_IntPtr_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTriangleMeshFlags()                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxTriangleMeshFlags -> Enum, byte>
    // NATIVE SIG: PxTriangleMeshFlags		getTriangleMeshFlags()							const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getTriangleMeshFlags_R_Enum, byte>_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getTriangleMeshFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getTriangleMeshFlags_R_Enum, byte>_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  UNPARSED_TYPE getTriangleMeshFlags(){
        UNPARSED_TYPE retVal = W_getTriangleMeshFlags_R_Enum, byte>_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getTrianglesRemap()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxU32* W_getTrianglesRemap_R_uintPtr_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getTrianglesRemap();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getTrianglesRemap_R_uintPtr_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  IntPtr getTrianglesRemap(){
        IntPtr retVal = W_getTrianglesRemap_R_uintPtr_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       release()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxTriangleMesh(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTriangleMaterialIndex(uint triangleIndex)                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMaterialTableIndex W_getTriangleMaterialIndex_R_ushort_P_uint_C_PxTriangleMesh(physx::PxTriangleMesh* self, physx::PxTriangleID triangleIndex){
        auto nat_in_triangleIndex = (triangleIndex);
        auto retVal = self->getTriangleMaterialIndex(nat_in_triangleIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getTriangleMaterialIndex_R_ushort_P_uint_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr, uint triangleIndex);
    
    public  ushort getTriangleMaterialIndex(uint triangleIndex){
        uint pvk_in_triangleIndex = (triangleIndex);
        ushort retVal = W_getTriangleMaterialIndex_R_ushort_P_uint_C_PxTriangleMesh(this, pvk_in_triangleIndex);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getLocalBounds()                                                       #
    //================================================================================
    #if NATIVE //function start
    ES PxBounds3POD W_getLocalBounds_R_PxBounds3_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getLocalBounds;
        return *(PxBounds3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 W_getLocalBounds_R_PxBounds3_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  PxBounds3 getLocalBounds(){
        PxBounds3 retVal = W_getLocalBounds_R_PxBounds3_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getReferenceCount()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getReferenceCount_R_uint_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount_R_uint_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  uint getReferenceCount(){
        uint retVal = W_getReferenceCount_R_uint_C_PxTriangleMesh(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       acquireReference()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_acquireReference_R_void_C_PxTriangleMesh(physx::PxTriangleMesh* self){
        self->acquireReference();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference_R_void_C_PxTriangleMesh(PxTriangleMeshPtr selfPtr);
    
    public  void acquireReference(){
        W_acquireReference_R_void_C_PxTriangleMesh(this);
    }
    #endif //function end
    
    
    //Skipped protected: PxTriangleMesh
    
    //Skipped protected: PxTriangleMesh
    
    //Skipped protected: ~PxTriangleMesh
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxTriangleMesh
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxTriangleMeshFlag is enum namespace
#if !NATIVE //interface
public unsafe interface IPxBVH33TriangleMeshPtr {
    // static PxBVH33TriangleMeshPtr New(/*NULLPARS*/);
    // static PxBVH33TriangleMeshPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxBVH33TriangleMesh(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // static PxBVH33TriangleMeshPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBVH33TriangleMeshPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxBVH33TriangleMeshPtr : IPxBasePtr, IPxTriangleMeshPtr, IPxBVH33TriangleMeshPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxBVH33TriangleMeshPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxTriangleMeshPtr, PxBVH33TriangleMeshPtr
    public static implicit operator PxBasePtr(PxBVH33TriangleMeshPtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxBVH33TriangleMeshPtr(PxBasePtr obj){return *(PxBVH33TriangleMeshPtr*)&obj;}
    public static implicit operator PxTriangleMeshPtr(PxBVH33TriangleMeshPtr obj){return *(PxTriangleMeshPtr*)&obj;}
    public static explicit operator PxBVH33TriangleMeshPtr(PxTriangleMeshPtr obj){return *(PxBVH33TriangleMeshPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxTriangleMeshPtr
    public  uint getNbVertices(){return ((PxTriangleMeshPtr)this).getNbVertices();}
    public  PxVec3 getVertices(){return ((PxTriangleMeshPtr)this).getVertices();}
    public  PxVec3 getVerticesForModification(){return ((PxTriangleMeshPtr)this).getVerticesForModification();}
    public  PxBounds3 refitBVH(){return ((PxTriangleMeshPtr)this).refitBVH();}
    public  uint getNbTriangles(){return ((PxTriangleMeshPtr)this).getNbTriangles();}
    public  IntPtr getTriangles(){return ((PxTriangleMeshPtr)this).getTriangles();}
    //public  UNPARSED_TYPE getTriangleMeshFlags(){return ((PxTriangleMeshPtr)this).getTriangleMeshFlags();}
    public  IntPtr getTrianglesRemap(){return ((PxTriangleMeshPtr)this).getTrianglesRemap();}
    public  void release(){((PxTriangleMeshPtr)this).release();}
    public  ushort getTriangleMaterialIndex(uint triangleIndex){return ((PxTriangleMeshPtr)this).getTriangleMaterialIndex(triangleIndex);}
    public  PxBounds3 getLocalBounds(){return ((PxTriangleMeshPtr)this).getLocalBounds();}
    public  uint getReferenceCount(){return ((PxTriangleMeshPtr)this).getReferenceCount();}
    public  void acquireReference(){((PxTriangleMeshPtr)this).acquireReference();}
    //public  static PxTriangleMeshPtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxTriangleMesh(/*NULLARGS*/);}
    //public  static PxTriangleMeshPtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxTriangleMesh(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxTriangleMesh(/*NULLPARS*/){((PxTriangleMeshPtr)this).~PxTriangleMesh(/*NULLARGS*/);}
    //public  static PxTriangleMeshPtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxTriangleMesh(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxTriangleMeshPtr lhs, /*NULLPARS*/){return ((PxTriangleMeshPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxBasePtr
    public  string getConcreteTypeName(){return ((PxTriangleMeshPtr)this).getConcreteTypeName();}
    //public  UNPARSED_TYPE is(){return ((PxTriangleMeshPtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxTriangleMeshPtr)this).is();}
    public  ushort getConcreteType(){return ((PxTriangleMeshPtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxTriangleMeshPtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxTriangleMeshPtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxTriangleMeshPtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxTriangleMeshPtr)this).isReleasable();}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxBase(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxBase(/*NULLPARS*/){((PxTriangleMeshPtr)this).~PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE typeMatch(/*NULLPARS*/){return ((PxTriangleMeshPtr)this).typeMatch(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxTriangleMeshPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //Skipped protected: PxBVH33TriangleMesh
    
    //Skipped protected: PxBVH33TriangleMesh
    
    //Skipped protected: ~PxBVH33TriangleMesh
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxBVH33TriangleMesh
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxBVH34TriangleMeshPtr {
    // static PxBVH34TriangleMeshPtr New(/*NULLPARS*/);
    // static PxBVH34TriangleMeshPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxBVH34TriangleMesh(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // static PxBVH34TriangleMeshPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBVH34TriangleMeshPtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxBVH34TriangleMeshPtr : IPxBasePtr, IPxTriangleMeshPtr, IPxBVH34TriangleMeshPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxBVH34TriangleMeshPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxTriangleMeshPtr, PxBVH34TriangleMeshPtr
    public static implicit operator PxBasePtr(PxBVH34TriangleMeshPtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxBVH34TriangleMeshPtr(PxBasePtr obj){return *(PxBVH34TriangleMeshPtr*)&obj;}
    public static implicit operator PxTriangleMeshPtr(PxBVH34TriangleMeshPtr obj){return *(PxTriangleMeshPtr*)&obj;}
    public static explicit operator PxBVH34TriangleMeshPtr(PxTriangleMeshPtr obj){return *(PxBVH34TriangleMeshPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxTriangleMeshPtr
    public  uint getNbVertices(){return ((PxTriangleMeshPtr)this).getNbVertices();}
    public  PxVec3 getVertices(){return ((PxTriangleMeshPtr)this).getVertices();}
    public  PxVec3 getVerticesForModification(){return ((PxTriangleMeshPtr)this).getVerticesForModification();}
    public  PxBounds3 refitBVH(){return ((PxTriangleMeshPtr)this).refitBVH();}
    public  uint getNbTriangles(){return ((PxTriangleMeshPtr)this).getNbTriangles();}
    public  IntPtr getTriangles(){return ((PxTriangleMeshPtr)this).getTriangles();}
    //public  UNPARSED_TYPE getTriangleMeshFlags(){return ((PxTriangleMeshPtr)this).getTriangleMeshFlags();}
    public  IntPtr getTrianglesRemap(){return ((PxTriangleMeshPtr)this).getTrianglesRemap();}
    public  void release(){((PxTriangleMeshPtr)this).release();}
    public  ushort getTriangleMaterialIndex(uint triangleIndex){return ((PxTriangleMeshPtr)this).getTriangleMaterialIndex(triangleIndex);}
    public  PxBounds3 getLocalBounds(){return ((PxTriangleMeshPtr)this).getLocalBounds();}
    public  uint getReferenceCount(){return ((PxTriangleMeshPtr)this).getReferenceCount();}
    public  void acquireReference(){((PxTriangleMeshPtr)this).acquireReference();}
    //public  static PxTriangleMeshPtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxTriangleMesh(/*NULLARGS*/);}
    //public  static PxTriangleMeshPtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxTriangleMesh(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxTriangleMesh(/*NULLPARS*/){((PxTriangleMeshPtr)this).~PxTriangleMesh(/*NULLARGS*/);}
    //public  static PxTriangleMeshPtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxTriangleMesh(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxTriangleMeshPtr lhs, /*NULLPARS*/){return ((PxTriangleMeshPtr)this).operator=(/*NULLARGS*/);}
    
    // --- PxBasePtr
    public  string getConcreteTypeName(){return ((PxTriangleMeshPtr)this).getConcreteTypeName();}
    //public  UNPARSED_TYPE is(){return ((PxTriangleMeshPtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxTriangleMeshPtr)this).is();}
    public  ushort getConcreteType(){return ((PxTriangleMeshPtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxTriangleMeshPtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxTriangleMeshPtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxTriangleMeshPtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxTriangleMeshPtr)this).isReleasable();}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxBase(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxBase(/*NULLPARS*/){((PxTriangleMeshPtr)this).~PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE typeMatch(/*NULLPARS*/){return ((PxTriangleMeshPtr)this).typeMatch(/*NULLARGS*/);}
    //public  static PxBasePtr New(/*NULLPARS*/){((PxTriangleMeshPtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxTriangleMeshPtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //Skipped protected: PxBVH34TriangleMesh
    
    //Skipped protected: PxBVH34TriangleMesh
    
    //Skipped protected: ~PxBVH34TriangleMesh
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxBVH34TriangleMesh
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxMeshMidPhase is enum namespace