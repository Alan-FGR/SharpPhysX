#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxShapeFlag : int {
    eSIMULATION_SHAPE = 1,  // eSIMULATION_SHAPE = (1<<0)
    eSCENE_QUERY_SHAPE = 2, // eSCENE_QUERY_SHAPE = (1<<1)
    eTRIGGER_SHAPE = 4,     // eTRIGGER_SHAPE = (1<<2)
    eVISUALIZATION = 8,     // eVISUALIZATION = (1<<3)
}
#endif

#if !NATIVE
public partial struct PxShape {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::PxShapeFlag::Enum a, physx::PxShapeFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(PxShapeFlag a, PxShapeFlag b);

public static UNPARSED_TYPE operator|(PxShapeFlag a, PxShapeFlag b){
    PxShapeFlag pvk_in_a = (a);
    PxShapeFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::PxShapeFlag::Enum a, physx::PxShapeFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(PxShapeFlag a, PxShapeFlag b);

public static UNPARSED_TYPE operator&(PxShapeFlag a, PxShapeFlag b){
    PxShapeFlag pvk_in_a = (a);
    PxShapeFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::PxShapeFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(PxShapeFlag a);

public static UNPARSED_TYPE operator~(PxShapeFlag a){
    PxShapeFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxShape
#endif


#if !NATIVE
public unsafe interface IPxShapePtr {
     void release();
     uint getReferenceCount();
     void acquireReference();
     PxGeometryType getGeometryType();
     void setGeometry(PxGeometryPtr geometry);
    // UNPARSED_TYPE getGeometry();
    // bool getBoxGeometry( geometry);
    // bool getSphereGeometry( geometry);
    // bool getCapsuleGeometry( geometry);
     bool getPlaneGeometry(PxPlaneGeometryPtr geometry);
    // bool getConvexMeshGeometry(PxConvexMeshGeometryPtr geometry);
    // bool getTriangleMeshGeometry(PxTriangleMeshGeometryPtr geometry);
    // bool getHeightFieldGeometry(PxHeightFieldGeometryPtr geometry);
     PxRigidActorPtr getActor();
     void setLocalPose(PxTransform pose);
     PxTransform getLocalPose();
     void setSimulationFilterData(PxFilterDataPtr data);
    // UNPARSED_TYPE getSimulationFilterData();
     void setQueryFilterData(PxFilterDataPtr data);
    // UNPARSED_TYPE getQueryFilterData();
    // void setMaterials( materials, ushort materialCount);
     ushort getNbMaterials();
    // uint getMaterials( userBuffer, uint bufferSize);
    // uint getMaterials( userBuffer, uint bufferSize, uint startIndex);
     PxMaterialPtr getMaterialFromInternalFaceIndex(uint faceIndex);
     void setContactOffset(float contactOffset);
     float getContactOffset();
     void setRestOffset(float restOffset);
     float getRestOffset();
     void setTorsionalPatchRadius(float radius);
     float getTorsionalPatchRadius();
     void setMinTorsionalPatchRadius(float radius);
     float getMinTorsionalPatchRadius();
     void setFlag(PxShapeFlag flag, bool value);
    // void setFlags( inFlags);
    // UNPARSED_TYPE getFlags();
     bool isExclusive();
     void setName(string name);
     IntPtr getName();
     IntPtr getConcreteTypeName();
    // PxShape( baseFlags);
    // PxShape(ushort concreteType,  baseFlags);
    // void ~PxShape();
     bool isKindOf(string name);
    // PxShape(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxShapePtr lhs, /*NULLPARS*/);
    
}

public unsafe partial struct PxShapePtr : IPxBasePtr, IPxShapePtr { // pointer
    private IntPtr nativePtr_;
#endif

    // Hierarchy: PxBasePtr, PxShapePtr
    public static implicit operator PxBasePtr(PxShapePtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxShapePtr(PxBasePtr obj){return *(PxShapePtr*)&obj;}
    
    // ### Piping
    
    // --- PxBasePtr
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    public  ushort getConcreteType(){return ((PxBasePtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxBasePtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxBasePtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxBasePtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxBasePtr)this).isReleasable();}
    //public  PxBase(ushort concreteType,  baseFlags){((PxBasePtr)this).PxBase(concreteType, baseFlags);}
    //public  PxBase( baseFlags){((PxBasePtr)this).PxBase(baseFlags);}
    //public  void ~PxBase(){((PxBasePtr)this).~PxBase();}
    public  bool typeMatch(){return ((PxBasePtr)this).typeMatch();}
    //public  PxBase(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxBasePtr)this).operator=(/*NULLARGS*/);}
    

    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxShape* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxShapePtr selfPtr);
    
    public  void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getReferenceCount(physx::PxShape* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount(PxShapePtr selfPtr);
    
    public  uint getReferenceCount(){
        uint retVal = W_getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    #if NATIVE
    ES void W_acquireReference(physx::PxShape* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference(PxShapePtr selfPtr);
    
    public  void acquireReference(){
        W_acquireReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getGeometryType                                                        #
    //================================================================================
    #if NATIVE
    ES physx::PxGeometryType::Enum W_getGeometryType(physx::PxShape* self){
        auto retVal = self->getGeometryType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getGeometryType(PxShapePtr selfPtr);
    
    public  PxGeometryType getGeometryType(){
        PxGeometryType retVal = W_getGeometryType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setGeometry                                                            #
    //================================================================================
    #if NATIVE
    ES void W_setGeometry(physx::PxShape* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->setGeometry(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGeometry(PxShapePtr selfPtr, PxGeometryPtr geometry);
    
    public  void setGeometry(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        W_setGeometry(this, pvk_in_geometry);
    }
    #endif
    
    
    //================================================================================
    //#       getGeometry                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxGeometryHolder
    // NATIVE SIG: PxGeometryHolder		getGeometry() const = 0
    #if NATIVE
    ES UNPARSED_TYPE W_getGeometry(physx::PxShape* self){
        auto retVal = self->getGeometry();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getGeometry(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getGeometry(){
        UNPARSED_TYPE retVal = W_getGeometry(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getBoxGeometry                                                         #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxBoxGeometry
    // NATIVE SIG: bool					getBoxGeometry(PxBoxGeometry& geometry) const = 0
    #if NATIVE
    ES bool W_getBoxGeometry(physx::PxShape* self,  geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getBoxGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getBoxGeometry(PxShapePtr selfPtr,  geometry);
    
    public  bool getBoxGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = W_getBoxGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getSphereGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxSphereGeometry
    // NATIVE SIG: bool					getSphereGeometry(PxSphereGeometry& geometry) const = 0
    #if NATIVE
    ES bool W_getSphereGeometry(physx::PxShape* self,  geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getSphereGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getSphereGeometry(PxShapePtr selfPtr,  geometry);
    
    public  bool getSphereGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = W_getSphereGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getCapsuleGeometry                                                     #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxCapsuleGeometry
    // NATIVE SIG: bool					getCapsuleGeometry(PxCapsuleGeometry& geometry) const = 0
    #if NATIVE
    ES bool W_getCapsuleGeometry(physx::PxShape* self,  geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getCapsuleGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getCapsuleGeometry(PxShapePtr selfPtr,  geometry);
    
    public  bool getCapsuleGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = W_getCapsuleGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getPlaneGeometry                                                       #
    //================================================================================
    #if NATIVE
    ES bool W_getPlaneGeometry(physx::PxShape* self, physx::PxPlaneGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getPlaneGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getPlaneGeometry(PxShapePtr selfPtr, PxPlaneGeometryPtr geometry);
    
    public  bool getPlaneGeometry(PxPlaneGeometryPtr geometry){
        PxPlaneGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getPlaneGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConvexMeshGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxConvexMeshGeometryPtr
    // NATIVE SIG: bool					getConvexMeshGeometry(PxConvexMeshGeometry& geometry) const = 0
    #if NATIVE
    ES bool W_getConvexMeshGeometry(physx::PxShape* self, physx::PxConvexMeshGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getConvexMeshGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getConvexMeshGeometry(PxShapePtr selfPtr, PxConvexMeshGeometryPtr geometry);
    
    public  bool getConvexMeshGeometry(PxConvexMeshGeometryPtr geometry){
        PxConvexMeshGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getConvexMeshGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTriangleMeshGeometry                                                #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxTriangleMeshGeometryPtr
    // NATIVE SIG: bool					getTriangleMeshGeometry(PxTriangleMeshGeometry& geometry) const = 0
    #if NATIVE
    ES bool W_getTriangleMeshGeometry(physx::PxShape* self, physx::PxTriangleMeshGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getTriangleMeshGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getTriangleMeshGeometry(PxShapePtr selfPtr, PxTriangleMeshGeometryPtr geometry);
    
    public  bool getTriangleMeshGeometry(PxTriangleMeshGeometryPtr geometry){
        PxTriangleMeshGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getTriangleMeshGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getHeightFieldGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxHeightFieldGeometryPtr
    // NATIVE SIG: bool					getHeightFieldGeometry(PxHeightFieldGeometry& geometry) const = 0
    #if NATIVE
    ES bool W_getHeightFieldGeometry(physx::PxShape* self, physx::PxHeightFieldGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getHeightFieldGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getHeightFieldGeometry(PxShapePtr selfPtr, PxHeightFieldGeometryPtr geometry);
    
    public  bool getHeightFieldGeometry(PxHeightFieldGeometryPtr geometry){
        PxHeightFieldGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getHeightFieldGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getActor                                                               #
    //================================================================================
    #if NATIVE
    ES physx::PxRigidActor* W_getActor(physx::PxShape* self){
        auto retVal = self->getActor();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidActorPtr W_getActor(PxShapePtr selfPtr);
    
    public  PxRigidActorPtr getActor(){
        PxRigidActorPtr retVal = W_getActor(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setLocalPose                                                           #
    //================================================================================
    #if NATIVE
    ES void W_setLocalPose(physx::PxShape* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setLocalPose(nat_in_pose);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLocalPose(PxShapePtr selfPtr, PxTransform pose);
    
    public  void setLocalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setLocalPose(this, pvk_in_pose);
    }
    #endif
    
    
    //================================================================================
    //#       getLocalPose                                                           #
    //================================================================================
    #if NATIVE
    ES physx::PxTransform W_getLocalPose(physx::PxShape* self){
        auto retVal = self->getLocalPose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getLocalPose(PxShapePtr selfPtr);
    
    public  PxTransform getLocalPose(){
        PxTransform retVal = W_getLocalPose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setSimulationFilterData                                                #
    //================================================================================
    #if NATIVE
    ES void W_setSimulationFilterData(physx::PxShape* self, physx::PxFilterData* data){
        auto nat_in_data = (data);
        self->setSimulationFilterData(*nat_in_data);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSimulationFilterData(PxShapePtr selfPtr, PxFilterDataPtr data);
    
    public  void setSimulationFilterData(PxFilterDataPtr data){
        PxFilterDataPtr pvk_in_data = (data);
        W_setSimulationFilterData(this, pvk_in_data);
    }
    #endif
    
    
    //================================================================================
    //#       getSimulationFilterData                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    // NATIVE SIG: PxFilterData			getSimulationFilterData()					const	= 0
    #if NATIVE
    ES UNPARSED_TYPE W_getSimulationFilterData(physx::PxShape* self){
        auto retVal = self->getSimulationFilterData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getSimulationFilterData(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getSimulationFilterData(){
        UNPARSED_TYPE retVal = W_getSimulationFilterData(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setQueryFilterData                                                     #
    //================================================================================
    #if NATIVE
    ES void W_setQueryFilterData(physx::PxShape* self, physx::PxFilterData* data){
        auto nat_in_data = (data);
        self->setQueryFilterData(*nat_in_data);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setQueryFilterData(PxShapePtr selfPtr, PxFilterDataPtr data);
    
    public  void setQueryFilterData(PxFilterDataPtr data){
        PxFilterDataPtr pvk_in_data = (data);
        W_setQueryFilterData(this, pvk_in_data);
    }
    #endif
    
    
    //================================================================================
    //#       getQueryFilterData                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    // NATIVE SIG: PxFilterData			getQueryFilterData()					const	= 0
    #if NATIVE
    ES UNPARSED_TYPE W_getQueryFilterData(physx::PxShape* self){
        auto retVal = self->getQueryFilterData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getQueryFilterData(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getQueryFilterData(){
        UNPARSED_TYPE retVal = W_getQueryFilterData(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: void					setMaterials(PxMaterial*const* materials, PxU16 materialCount)	= 0
    #if NATIVE
    ES void W_setMaterials(physx::PxShape* self,  materials, physx::PxU16 materialCount){
        auto nat_in_materials = (materials);
        auto nat_in_materialCount = (materialCount);
        self->setMaterials(nat_in_materials, nat_in_materialCount);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaterials(PxShapePtr selfPtr,  materials, ushort materialCount);
    
    public  void setMaterials( materials, ushort materialCount){
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        W_setMaterials(this, pvk_in_materials, pvk_in_materialCount);
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbMaterials                                                         #
    //================================================================================
    #if NATIVE
    ES physx::PxU16 W_getNbMaterials(physx::PxShape* self){
        auto retVal = self->getNbMaterials();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getNbMaterials(PxShapePtr selfPtr);
    
    public  ushort getNbMaterials(){
        ushort retVal = W_getNbMaterials(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32					getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE
    ES physx::PxU32 W_getMaterials(physx::PxShape* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaterials(PxShapePtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getMaterials( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getMaterials(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32					getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE
    ES physx::PxU32 W_getMaterials(physx::PxShape* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaterials(PxShapePtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getMaterials( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getMaterials(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif*/
    
    
    
    
    //================================================================================
    //#       getMaterialFromInternalFaceIndex                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxMaterial* W_getMaterialFromInternalFaceIndex(physx::PxShape* self, physx::PxU32 faceIndex){
        auto nat_in_faceIndex = (faceIndex);
        auto retVal = self->getMaterialFromInternalFaceIndex(nat_in_faceIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMaterialPtr W_getMaterialFromInternalFaceIndex(PxShapePtr selfPtr, uint faceIndex);
    
    public  PxMaterialPtr getMaterialFromInternalFaceIndex(uint faceIndex){
        uint pvk_in_faceIndex = (faceIndex);
        PxMaterialPtr retVal = W_getMaterialFromInternalFaceIndex(this, pvk_in_faceIndex);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setContactOffset                                                       #
    //================================================================================
    #if NATIVE
    ES void W_setContactOffset(physx::PxShape* self, physx::PxReal contactOffset){
        auto nat_in_contactOffset = (contactOffset);
        self->setContactOffset(nat_in_contactOffset);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContactOffset(PxShapePtr selfPtr, float contactOffset);
    
    public  void setContactOffset(float contactOffset){
        float pvk_in_contactOffset = (contactOffset);
        W_setContactOffset(this, pvk_in_contactOffset);
    }
    #endif
    
    
    //================================================================================
    //#       getContactOffset                                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getContactOffset(physx::PxShape* self){
        auto retVal = self->getContactOffset();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getContactOffset(PxShapePtr selfPtr);
    
    public  float getContactOffset(){
        float retVal = W_getContactOffset(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setRestOffset                                                          #
    //================================================================================
    #if NATIVE
    ES void W_setRestOffset(physx::PxShape* self, physx::PxReal restOffset){
        auto nat_in_restOffset = (restOffset);
        self->setRestOffset(nat_in_restOffset);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRestOffset(PxShapePtr selfPtr, float restOffset);
    
    public  void setRestOffset(float restOffset){
        float pvk_in_restOffset = (restOffset);
        W_setRestOffset(this, pvk_in_restOffset);
    }
    #endif
    
    
    //================================================================================
    //#       getRestOffset                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getRestOffset(physx::PxShape* self){
        auto retVal = self->getRestOffset();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getRestOffset(PxShapePtr selfPtr);
    
    public  float getRestOffset(){
        float retVal = W_getRestOffset(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setTorsionalPatchRadius                                                #
    //================================================================================
    #if NATIVE
    ES void W_setTorsionalPatchRadius(physx::PxShape* self, physx::PxReal radius){
        auto nat_in_radius = (radius);
        self->setTorsionalPatchRadius(nat_in_radius);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setTorsionalPatchRadius(PxShapePtr selfPtr, float radius);
    
    public  void setTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        W_setTorsionalPatchRadius(this, pvk_in_radius);
    }
    #endif
    
    
    //================================================================================
    //#       getTorsionalPatchRadius                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getTorsionalPatchRadius(physx::PxShape* self){
        auto retVal = self->getTorsionalPatchRadius();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getTorsionalPatchRadius(PxShapePtr selfPtr);
    
    public  float getTorsionalPatchRadius(){
        float retVal = W_getTorsionalPatchRadius(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMinTorsionalPatchRadius                                             #
    //================================================================================
    #if NATIVE
    ES void W_setMinTorsionalPatchRadius(physx::PxShape* self, physx::PxReal radius){
        auto nat_in_radius = (radius);
        self->setMinTorsionalPatchRadius(nat_in_radius);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinTorsionalPatchRadius(PxShapePtr selfPtr, float radius);
    
    public  void setMinTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        W_setMinTorsionalPatchRadius(this, pvk_in_radius);
    }
    #endif
    
    
    //================================================================================
    //#       getMinTorsionalPatchRadius                                             #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getMinTorsionalPatchRadius(physx::PxShape* self){
        auto retVal = self->getMinTorsionalPatchRadius();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinTorsionalPatchRadius(PxShapePtr selfPtr);
    
    public  float getMinTorsionalPatchRadius(){
        float retVal = W_getMinTorsionalPatchRadius(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    #if NATIVE
    ES void W_setFlag(physx::PxShape* self, physx::PxShapeFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag(PxShapePtr selfPtr, PxShapeFlag flag, bool value);
    
    public  void setFlag(PxShapeFlag flag, bool value){
        PxShapeFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxShapeFlags
    // NATIVE SIG: void					setFlags(PxShapeFlags inFlags) = 0
    #if NATIVE
    ES void W_setFlags(physx::PxShape* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlags(PxShapePtr selfPtr,  inFlags);
    
    public  void setFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxShapeFlags
    // NATIVE SIG: PxShapeFlags			getFlags() const = 0
    #if NATIVE
    ES UNPARSED_TYPE W_getFlags(physx::PxShape* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isExclusive                                                            #
    //================================================================================
    #if NATIVE
    ES bool W_isExclusive(physx::PxShape* self){
        auto retVal = self->isExclusive();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isExclusive(PxShapePtr selfPtr);
    
    public  bool isExclusive(){
        bool retVal = W_isExclusive(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setName                                                                #
    //================================================================================
    #if NATIVE
    ES void W_setName(physx::PxShape* self, const char* name){
        auto nat_in_name = (name);
        self->setName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setName(PxShapePtr selfPtr, string name);
    
    public  void setName(string name){
        string pvk_in_name = (name);
        W_setName(this, pvk_in_name);
    }
    #endif
    
    
    //================================================================================
    //#       getName                                                                #
    //================================================================================
    #if NATIVE
    ES sbyte* W_getName(physx::PxShape* self){
        auto retVal = self->getName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getName(PxShapePtr selfPtr);
    
    public  IntPtr getName(){
        IntPtr retVal = W_getName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxShape* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxShapePtr selfPtr);
    
    public  IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxShape
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE							PxShape(PxBaseFlags baseFlags) : PxBase(baseFlags) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxShape_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxShape(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxShape_ctor( baseFlags);
    
    public  PxShape( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxShape_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxShape
    Unresolved parameter type physx::PxBaseFlags
    // NATIVE SIG: PX_INLINE							PxShape(PxType concreteType, PxBaseFlags baseFlags) : PxBase(concreteType, baseFlags), userData(NULL) {}
    #if NATIVE
    ES UNPARSED_TYPE W_PxShape_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxShape(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxShape_ctor(ushort concreteType,  baseFlags);
    
    public  PxShape(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxShape_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxShape                                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual								~PxShape() {}
    #if NATIVE
    ES void W_~PxShape(physx::PxShape* self){
        self->~PxShape();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxShape(PxShapePtr selfPtr);
    
    public  void ~PxShape(){
        W_~PxShape(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isKindOf(physx::PxShape* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxShapePtr selfPtr, string name);
    
    public  bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: PxShape
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE
}
#endif

// Class physx::PxShapeFlag is enum namespace