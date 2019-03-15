#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxShapeFlag : int {
     eSIMULATION_SHAPE				= (1<<0),
     eSCENE_QUERY_SHAPE				= (1<<1),
     eTRIGGER_SHAPE					= (1<<2),
     eVISUALIZATION					= (1<<3),
}
#endif

public partial struct PxShape {

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L123~123
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
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L123~123
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
/* ERRORS OCCURED: unhandled return type
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L123~123
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

} // End PxShape



#if !NATIVE
public unsafe partial struct PxShape { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L156~156
    #if NATIVE
    ES void W_release(physx::PxShape* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxShape selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L166~166
    #if NATIVE
    ES physx::PxU32 W_getReferenceCount(physx::PxShape* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount(PxShape selfPtr);
    
    public uint getReferenceCount(){
        uint retVal = W_getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L173~173
    #if NATIVE
    ES void W_acquireReference(physx::PxShape* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference(PxShape selfPtr);
    
    public void acquireReference(){
        W_acquireReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getGeometryType                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L182~182
    #if NATIVE
    ES physx::PxGeometryType::Enum W_getGeometryType(physx::PxShape* self){
        auto retVal = self->getGeometryType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getGeometryType(PxShape selfPtr);
    
    public PxGeometryType getGeometryType(){
        PxGeometryType retVal = W_getGeometryType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setGeometry                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L195~195
    #if NATIVE
    ES void W_setGeometry(physx::PxShape* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->setGeometry(*nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGeometry(PxShape selfPtr, PxGeometry geometry);
    
    public void setGeometry(PxGeometry geometry){
        PxGeometry pvk_in_geometry = (geometry);
        W_setGeometry(this, pvk_in_geometry);
    }
    #endif
    
    
    //================================================================================
    //#       getGeometry                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxGeometryHolder		getGeometry() const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L206~206
    #if NATIVE
    ES UNPARSED_TYPE W_getGeometry(physx::PxShape* self){
        auto retVal = self->getGeometry();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getGeometry(PxShape selfPtr);
    
    public UNPARSED_TYPE getGeometry(){
        UNPARSED_TYPE retVal = W_getGeometry(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getBoxGeometry                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L220~220
    #if NATIVE
    ES bool W_getBoxGeometry(physx::PxShape* self, physx::PxBoxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getBoxGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getBoxGeometry(PxShape selfPtr, PxBoxGeometry geometry);
    
    public bool getBoxGeometry(PxBoxGeometry geometry){
        PxBoxGeometry pvk_in_geometry = (geometry);
        bool retVal = W_getBoxGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getSphereGeometry                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L233~233
    #if NATIVE
    ES bool W_getSphereGeometry(physx::PxShape* self, physx::PxSphereGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getSphereGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getSphereGeometry(PxShape selfPtr, PxSphereGeometry geometry);
    
    public bool getSphereGeometry(PxSphereGeometry geometry){
        PxSphereGeometry pvk_in_geometry = (geometry);
        bool retVal = W_getSphereGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getCapsuleGeometry                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L246~246
    #if NATIVE
    ES bool W_getCapsuleGeometry(physx::PxShape* self, physx::PxCapsuleGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getCapsuleGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getCapsuleGeometry(PxShape selfPtr, PxCapsuleGeometry geometry);
    
    public bool getCapsuleGeometry(PxCapsuleGeometry geometry){
        PxCapsuleGeometry pvk_in_geometry = (geometry);
        bool retVal = W_getCapsuleGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getPlaneGeometry                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L259~259
    #if NATIVE
    ES bool W_getPlaneGeometry(physx::PxShape* self, physx::PxPlaneGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getPlaneGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getPlaneGeometry(PxShape selfPtr, PxPlaneGeometry geometry);
    
    public bool getPlaneGeometry(PxPlaneGeometry geometry){
        PxPlaneGeometry pvk_in_geometry = (geometry);
        bool retVal = W_getPlaneGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConvexMeshGeometry                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L272~272
    #if NATIVE
    ES bool W_getConvexMeshGeometry(physx::PxShape* self, physx::PxConvexMeshGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getConvexMeshGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getConvexMeshGeometry(PxShape selfPtr, PxConvexMeshGeometry geometry);
    
    public bool getConvexMeshGeometry(PxConvexMeshGeometry geometry){
        PxConvexMeshGeometry pvk_in_geometry = (geometry);
        bool retVal = W_getConvexMeshGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTriangleMeshGeometry                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L285~285
    #if NATIVE
    ES bool W_getTriangleMeshGeometry(physx::PxShape* self, physx::PxTriangleMeshGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getTriangleMeshGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getTriangleMeshGeometry(PxShape selfPtr, PxTriangleMeshGeometry geometry);
    
    public bool getTriangleMeshGeometry(PxTriangleMeshGeometry geometry){
        PxTriangleMeshGeometry pvk_in_geometry = (geometry);
        bool retVal = W_getTriangleMeshGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getHeightFieldGeometry                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L299~299
    #if NATIVE
    ES bool W_getHeightFieldGeometry(physx::PxShape* self, physx::PxHeightFieldGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getHeightFieldGeometry(*nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getHeightFieldGeometry(PxShape selfPtr, PxHeightFieldGeometry geometry);
    
    public bool getHeightFieldGeometry(PxHeightFieldGeometry geometry){
        PxHeightFieldGeometry pvk_in_geometry = (geometry);
        bool retVal = W_getHeightFieldGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getActor                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L308~308
    #if NATIVE
    ES physx::PxRigidActor* W_getActor(physx::PxShape* self){
        auto retVal = self->getActor();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidActor W_getActor(PxShape selfPtr);
    
    public PxRigidActor getActor(){
        PxRigidActor retVal = W_getActor(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setLocalPose                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L335~335
    #if NATIVE
    ES void W_setLocalPose(physx::PxShape* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setLocalPose(nat_in_pose);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLocalPose(PxShape selfPtr, PxTransform pose);
    
    public void setLocalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setLocalPose(this, pvk_in_pose);
    }
    #endif
    
    
    //================================================================================
    //#       getLocalPose                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L346~346
    #if NATIVE
    ES physx::PxTransform W_getLocalPose(physx::PxShape* self){
        auto retVal = self->getLocalPose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getLocalPose(PxShape selfPtr);
    
    public PxTransform getLocalPose(){
        PxTransform retVal = W_getLocalPose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setSimulationFilterData                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L365~365
    #if NATIVE
    ES void W_setSimulationFilterData(physx::PxShape* self, physx::PxFilterData* data){
        auto nat_in_data = (data);
        self->setSimulationFilterData(*nat_in_data);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSimulationFilterData(PxShape selfPtr, PxFilterData data);
    
    public void setSimulationFilterData(PxFilterData data){
        PxFilterData pvk_in_data = (data);
        W_setSimulationFilterData(this, pvk_in_data);
    }
    #endif
    
    
    //================================================================================
    //#       getSimulationFilterData                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxFilterData			getSimulationFilterData()					const	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L372~372
    #if NATIVE
    ES UNPARSED_TYPE W_getSimulationFilterData(physx::PxShape* self){
        auto retVal = self->getSimulationFilterData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getSimulationFilterData(PxShape selfPtr);
    
    public UNPARSED_TYPE getSimulationFilterData(){
        UNPARSED_TYPE retVal = W_getSimulationFilterData(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setQueryFilterData                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L381~381
    #if NATIVE
    ES void W_setQueryFilterData(physx::PxShape* self, physx::PxFilterData* data){
        auto nat_in_data = (data);
        self->setQueryFilterData(*nat_in_data);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setQueryFilterData(PxShape selfPtr, PxFilterData data);
    
    public void setQueryFilterData(PxFilterData data){
        PxFilterData pvk_in_data = (data);
        W_setQueryFilterData(this, pvk_in_data);
    }
    #endif
    
    
    //================================================================================
    //#       getQueryFilterData                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxFilterData			getQueryFilterData()					const	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L388~388
    #if NATIVE
    ES UNPARSED_TYPE W_getQueryFilterData(physx::PxShape* self){
        auto retVal = self->getQueryFilterData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getQueryFilterData(PxShape selfPtr);
    
    public UNPARSED_TYPE getQueryFilterData(){
        UNPARSED_TYPE retVal = W_getQueryFilterData(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: void					setMaterials(PxMaterial*const* materials, PxU16 materialCount)	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L403~403
    #if NATIVE
    ES void W_setMaterials(physx::PxShape* self,  materials, physx::PxU16 materialCount){
        auto nat_in_materials = (materials);
        auto nat_in_materialCount = (materialCount);
        self->setMaterials(nat_in_materials, nat_in_materialCount);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaterials(PxShape selfPtr,  materials, ushort materialCount);
    
    public void setMaterials( materials, ushort materialCount){
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        W_setMaterials(this, pvk_in_materials, pvk_in_materialCount);
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbMaterials                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L414~414
    #if NATIVE
    ES physx::PxU16 W_getNbMaterials(physx::PxShape* self){
        auto retVal = self->getNbMaterials();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getNbMaterials(PxShape selfPtr);
    
    public ushort getNbMaterials(){
        ushort retVal = W_getNbMaterials(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32					getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L430~430
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
    static extern uint W_getMaterials(PxShape selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getMaterials( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getMaterials(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getMaterialFromInternalFaceIndex                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L450~450
    #if NATIVE
    ES physx::PxMaterial* W_getMaterialFromInternalFaceIndex(physx::PxShape* self, physx::PxU32 faceIndex){
        auto nat_in_faceIndex = (faceIndex);
        auto retVal = self->getMaterialFromInternalFaceIndex(nat_in_faceIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMaterial W_getMaterialFromInternalFaceIndex(PxShape selfPtr, uint faceIndex);
    
    public PxMaterial getMaterialFromInternalFaceIndex(uint faceIndex){
        uint pvk_in_faceIndex = (faceIndex);
        PxMaterial retVal = W_getMaterialFromInternalFaceIndex(this, pvk_in_faceIndex);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setContactOffset                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L468~468
    #if NATIVE
    ES void W_setContactOffset(physx::PxShape* self, physx::PxReal contactOffset){
        auto nat_in_contactOffset = (contactOffset);
        self->setContactOffset(nat_in_contactOffset);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContactOffset(PxShape selfPtr, float contactOffset);
    
    public void setContactOffset(float contactOffset){
        float pvk_in_contactOffset = (contactOffset);
        W_setContactOffset(this, pvk_in_contactOffset);
    }
    #endif
    
    
    //================================================================================
    //#       getContactOffset                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L477~477
    #if NATIVE
    ES physx::PxReal W_getContactOffset(physx::PxShape* self){
        auto retVal = self->getContactOffset();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getContactOffset(PxShape selfPtr);
    
    public float getContactOffset(){
        float retVal = W_getContactOffset(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setRestOffset                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L494~494
    #if NATIVE
    ES void W_setRestOffset(physx::PxShape* self, physx::PxReal restOffset){
        auto nat_in_restOffset = (restOffset);
        self->setRestOffset(nat_in_restOffset);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRestOffset(PxShape selfPtr, float restOffset);
    
    public void setRestOffset(float restOffset){
        float pvk_in_restOffset = (restOffset);
        W_setRestOffset(this, pvk_in_restOffset);
    }
    #endif
    
    
    //================================================================================
    //#       getRestOffset                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L503~503
    #if NATIVE
    ES physx::PxReal W_getRestOffset(physx::PxShape* self){
        auto retVal = self->getRestOffset();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getRestOffset(PxShape selfPtr);
    
    public float getRestOffset(){
        float retVal = W_getRestOffset(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setTorsionalPatchRadius                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L517~517
    #if NATIVE
    ES void W_setTorsionalPatchRadius(physx::PxShape* self, physx::PxReal radius){
        auto nat_in_radius = (radius);
        self->setTorsionalPatchRadius(nat_in_radius);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setTorsionalPatchRadius(PxShape selfPtr, float radius);
    
    public void setTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        W_setTorsionalPatchRadius(this, pvk_in_radius);
    }
    #endif
    
    
    //================================================================================
    //#       getTorsionalPatchRadius                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L529~529
    #if NATIVE
    ES physx::PxReal W_getTorsionalPatchRadius(physx::PxShape* self){
        auto retVal = self->getTorsionalPatchRadius();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getTorsionalPatchRadius(PxShape selfPtr);
    
    public float getTorsionalPatchRadius(){
        float retVal = W_getTorsionalPatchRadius(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMinTorsionalPatchRadius                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L542~542
    #if NATIVE
    ES void W_setMinTorsionalPatchRadius(physx::PxShape* self, physx::PxReal radius){
        auto nat_in_radius = (radius);
        self->setMinTorsionalPatchRadius(nat_in_radius);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinTorsionalPatchRadius(PxShape selfPtr, float radius);
    
    public void setMinTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        W_setMinTorsionalPatchRadius(this, pvk_in_radius);
    }
    #endif
    
    
    //================================================================================
    //#       getMinTorsionalPatchRadius                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L554~554
    #if NATIVE
    ES physx::PxReal W_getMinTorsionalPatchRadius(physx::PxShape* self){
        auto retVal = self->getMinTorsionalPatchRadius();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinTorsionalPatchRadius(PxShape selfPtr);
    
    public float getMinTorsionalPatchRadius(){
        float retVal = W_getMinTorsionalPatchRadius(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L571~571
    #if NATIVE
    ES void W_setFlag(physx::PxShape* self, physx::PxShapeFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag(PxShape selfPtr, PxShapeFlag flag, bool value);
    
    public void setFlag(PxShapeFlag flag, bool value){
        PxShapeFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxShape::setFlags::inFlags
    // NATIVE SIG: void					setFlags(PxShapeFlags inFlags) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L578~578
    #if NATIVE
    ES void W_setFlags(physx::PxShape* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlags(PxShape selfPtr,  inFlags);
    
    public void setFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxShapeFlags			getFlags() const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L587~587
    #if NATIVE
    ES UNPARSED_TYPE W_getFlags(physx::PxShape* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags(PxShape selfPtr);
    
    public UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isExclusive                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L594~594
    #if NATIVE
    ES bool W_isExclusive(physx::PxShape* self){
        auto retVal = self->isExclusive();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isExclusive(PxShape selfPtr);
    
    public bool isExclusive(){
        bool retVal = W_isExclusive(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setName                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L608~608
    #if NATIVE
    ES void W_setName(physx::PxShape* self, const char* name){
        auto nat_in_name = (name);
        self->setName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setName(PxShape selfPtr, string name);
    
    public void setName(string name){
        string pvk_in_name = (name);
        W_setName(this, pvk_in_name);
    }
    #endif
    
    
    //================================================================================
    //#       getName                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L617~617
    #if NATIVE
    ES sbyte* W_getName(physx::PxShape* self){
        auto retVal = self->getName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getName(PxShape selfPtr);
    
    public IntPtr getName(){
        IntPtr retVal = W_getName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L620~620
    #if NATIVE
    ES sbyte* W_getConcreteTypeName(physx::PxShape* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConcreteTypeName(PxShape selfPtr);
    
    public IntPtr getConcreteTypeName(){
        IntPtr retVal = W_getConcreteTypeName(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxShape::PxShape::baseFlags
    // NATIVE SIG: PX_INLINE							PxShape(PxBaseFlags baseFlags) : PxBase(baseFlags) {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L627~627
    #if NATIVE
    ES UNPARSED_TYPE W_PxShape_ctor( baseFlags){
        auto nat_in_baseFlags = (baseFlags);
        self->PxShape(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxShape_ctor( baseFlags);
    
    public PxShape( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = W_PxShape_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxShape::PxShape::baseFlags
    // NATIVE SIG: PX_INLINE							PxShape(PxType concreteType, PxBaseFlags baseFlags) : PxBase(concreteType, baseFlags), userData(NULL) {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L628~628
    #if NATIVE
    ES UNPARSED_TYPE W_PxShape_ctor(physx::PxType concreteType,  baseFlags){
        auto nat_in_concreteType = (concreteType);
        auto nat_in_baseFlags = (baseFlags);
        self->PxShape(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxShape_ctor(ushort concreteType,  baseFlags);
    
    public PxShape(ushort concreteType,  baseFlags){
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L629~629
    #if NATIVE
    ES void W_~PxShape(physx::PxShape* self){
        self->~PxShape();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxShape(PxShape selfPtr);
    
    public void ~PxShape(){
        W_~PxShape(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L630~630
    #if NATIVE
    ES bool W_isKindOf(physx::PxShape* self, const char* name){
        auto nat_in_name = (name);
        auto retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isKindOf(PxShape selfPtr, string name);
    
    public bool isKindOf(string name){
        string pvk_in_name = (name);
        bool retVal = W_isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxShape
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L142~142
    #if NATIVE
    ES UNPARSED_TYPE W_PxShape_ctor(physx::PxShape* ){
        auto nat_in_ = ();
        self->PxShape(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxShape_ctor(PxShape );
    
    public PxShape(PxShape ){
        PxShape pvk_in_ = ();
        var _new = W_PxShape_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxShape
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L142~142
    #if NATIVE
    ES physx::PxShape* W_operator=(physx::PxShape* self, physx::PxShape* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShape W_operator=(PxShape selfPtr, PxShape );
    
    public static PxShape operator=(PxShape lhs, PxShape ){
        PxShape pvk_in_ = ();
        PxShape retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif


#if !NATIVE
public unsafe partial struct PxShapeFlag { // blittable

#endif

    //================================================================================
    //#       PxShapeFlag                                                            #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag W_PxShapeFlag_ctor(){
        self.PxShapeFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag W_PxShapeFlag_ctor();
    
    public PxShapeFlag(){
        var _new = W_PxShapeFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShapeFlag                                                            #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag W_PxShapeFlag_ctor(physx::PxShapeFlag ){
        auto nat_in_ = ();
        self.PxShapeFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag W_PxShapeFlag_ctor(PxShapeFlag );
    
    public PxShapeFlag(PxShapeFlag ){
        PxShapeFlag pvk_in_ = ();
        var _new = W_PxShapeFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag* W_operator=(physx::PxShapeFlag self, physx::PxShapeFlag ){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag W_operator=(PxShapeFlag selfBlt, PxShapeFlag );
    
    public static PxShapeFlag operator=(PxShapeFlag lhs, PxShapeFlag ){
        PxShapeFlag pvk_in_ = ();
        PxShapeFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShapeFlag                                                            #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxShapeFlag
    // NATIVE SIG: PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag W_PxShapeFlag_ctor( ){
        auto nat_in_ = ();
        self.PxShapeFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag W_PxShapeFlag_ctor( );
    
    public PxShapeFlag( ){
         pvk_in_ = ();
        var _new = W_PxShapeFlag_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    Non const pointer/reference global::PhysX.physx.PxShapeFlag
    // NATIVE SIG: PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag* W_operator=(physx::PxShapeFlag self){
        auto nat_in_ = ();
        auto retVal = &self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag W_operator=(PxShapeFlag selfBlt);
    
    public static PxShapeFlag operator=(PxShapeFlag lhs,  ){
         pvk_in_ = ();
        PxShapeFlag retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxShapeFlag                                                           #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES void W_~PxShapeFlag(physx::PxShapeFlag self){
        self.~PxShapeFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxShapeFlag(PxShapeFlag selfBlt);
    
    public void ~PxShapeFlag(){
        W_~PxShapeFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif


