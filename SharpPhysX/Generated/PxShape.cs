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


#if !NATIVE
public unsafe partial struct PxShape { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L156~156
    #if NATIVE
    ES void release(physx::PxShape* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void release(PxShape selfPtr);
    
    public void release(){
        release(this);
    }
    #endif
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L166~166
    #if NATIVE
    ES physx::PxU32 getReferenceCount(physx::PxShape* self){
        physx::PxU32 retVal = self->getReferenceCount();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getReferenceCount(PxShape selfPtr);
    
    public uint getReferenceCount(){
        uint retVal = getReferenceCount(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L173~173
    #if NATIVE
    ES void acquireReference(physx::PxShape* self){
        self->acquireReference();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void acquireReference(PxShape selfPtr);
    
    public void acquireReference(){
        acquireReference(this);
    }
    #endif
    
    
    //================================================================================
    //#       getGeometryType                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L182~182
    #if NATIVE
    ES physx::PxGeometryType::Enum getGeometryType(physx::PxShape* self){
        physx::PxGeometryType::Enum retVal = self->getGeometryType();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType getGeometryType(PxShape selfPtr);
    
    public PxGeometryType getGeometryType(){
        PxGeometryType retVal = getGeometryType(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setGeometry                                                            #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L195~195
    #if NATIVE
    ES void setGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        self->setGeometry(nat_in_geometry);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setGeometry(PxShape selfPtr,  geometry);
    
    public void setGeometry( geometry){
         pvk_in_geometry = (geometry);
        setGeometry(this, pvk_in_geometry);
    }
    #endif*/
    
    
    //================================================================================
    //#       getGeometry                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L206~206
    #if NATIVE
    ES UNPARSED_TYPE getGeometry(physx::PxShape* self){
        UNPARSED_TYPE retVal = self->getGeometry();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getGeometry(PxShape selfPtr);
    
    public UNPARSED_TYPE getGeometry(){
        UNPARSED_TYPE retVal = getGeometry(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getBoxGeometry                                                         #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L220~220
    #if NATIVE
    ES bool getBoxGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        bool retVal = self->getBoxGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getBoxGeometry(PxShape selfPtr,  geometry);
    
    public bool getBoxGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = getBoxGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getSphereGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L233~233
    #if NATIVE
    ES bool getSphereGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        bool retVal = self->getSphereGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getSphereGeometry(PxShape selfPtr,  geometry);
    
    public bool getSphereGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = getSphereGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getCapsuleGeometry                                                     #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L246~246
    #if NATIVE
    ES bool getCapsuleGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        bool retVal = self->getCapsuleGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getCapsuleGeometry(PxShape selfPtr,  geometry);
    
    public bool getCapsuleGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = getCapsuleGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getPlaneGeometry                                                       #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L259~259
    #if NATIVE
    ES bool getPlaneGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        bool retVal = self->getPlaneGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getPlaneGeometry(PxShape selfPtr,  geometry);
    
    public bool getPlaneGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = getPlaneGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConvexMeshGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L272~272
    #if NATIVE
    ES bool getConvexMeshGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        bool retVal = self->getConvexMeshGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getConvexMeshGeometry(PxShape selfPtr,  geometry);
    
    public bool getConvexMeshGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = getConvexMeshGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTriangleMeshGeometry                                                #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L285~285
    #if NATIVE
    ES bool getTriangleMeshGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        bool retVal = self->getTriangleMeshGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getTriangleMeshGeometry(PxShape selfPtr,  geometry);
    
    public bool getTriangleMeshGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = getTriangleMeshGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getHeightFieldGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L299~299
    #if NATIVE
    ES bool getHeightFieldGeometry(physx::PxShape* self,  geometry){
         nat_in_geometry = (geometry);
        bool retVal = self->getHeightFieldGeometry(nat_in_geometry);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool getHeightFieldGeometry(PxShape selfPtr,  geometry);
    
    public bool getHeightFieldGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = getHeightFieldGeometry(this, pvk_in_geometry);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getActor                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L308~308
    #if NATIVE
    ES UNPARSED_TYPE getActor(physx::PxShape* self){
        UNPARSED_TYPE retVal = self->getActor();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getActor(PxShape selfPtr);
    
    public UNPARSED_TYPE getActor(){
        UNPARSED_TYPE retVal = getActor(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setLocalPose                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L335~335
    #if NATIVE
    ES void setLocalPose(physx::PxShape* self, physx::PxTransform pose){
        physx::PxTransform nat_in_pose = (pose);
        self->setLocalPose(nat_in_pose);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setLocalPose(PxShape selfPtr, PxTransform pose);
    
    public void setLocalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        setLocalPose(this, pvk_in_pose);
    }
    #endif
    
    
    //================================================================================
    //#       getLocalPose                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L346~346
    #if NATIVE
    ES physx::PxTransform getLocalPose(physx::PxShape* self){
        physx::PxTransform retVal = self->getLocalPose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform getLocalPose(PxShape selfPtr);
    
    public PxTransform getLocalPose(){
        PxTransform retVal = getLocalPose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setSimulationFilterData                                                #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L365~365
    #if NATIVE
    ES void setSimulationFilterData(physx::PxShape* self,  data){
         nat_in_data = (data);
        self->setSimulationFilterData(nat_in_data);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setSimulationFilterData(PxShape selfPtr,  data);
    
    public void setSimulationFilterData( data){
         pvk_in_data = (data);
        setSimulationFilterData(this, pvk_in_data);
    }
    #endif*/
    
    
    //================================================================================
    //#       getSimulationFilterData                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L372~372
    #if NATIVE
    ES UNPARSED_TYPE getSimulationFilterData(physx::PxShape* self){
        UNPARSED_TYPE retVal = self->getSimulationFilterData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getSimulationFilterData(PxShape selfPtr);
    
    public UNPARSED_TYPE getSimulationFilterData(){
        UNPARSED_TYPE retVal = getSimulationFilterData(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setQueryFilterData                                                     #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L381~381
    #if NATIVE
    ES void setQueryFilterData(physx::PxShape* self,  data){
         nat_in_data = (data);
        self->setQueryFilterData(nat_in_data);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setQueryFilterData(PxShape selfPtr,  data);
    
    public void setQueryFilterData( data){
         pvk_in_data = (data);
        setQueryFilterData(this, pvk_in_data);
    }
    #endif*/
    
    
    //================================================================================
    //#       getQueryFilterData                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L388~388
    #if NATIVE
    ES UNPARSED_TYPE getQueryFilterData(physx::PxShape* self){
        UNPARSED_TYPE retVal = self->getQueryFilterData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getQueryFilterData(PxShape selfPtr);
    
    public UNPARSED_TYPE getQueryFilterData(){
        UNPARSED_TYPE retVal = getQueryFilterData(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L403~403
    #if NATIVE
    ES void setMaterials(physx::PxShape* self,  materials, physx::PxU16 materialCount){
         nat_in_materials = (materials);
        physx::PxU16 nat_in_materialCount = (materialCount);
        self->setMaterials(nat_in_materials, nat_in_materialCount);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setMaterials(PxShape selfPtr,  materials, ushort materialCount);
    
    public void setMaterials( materials, ushort materialCount){
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        setMaterials(this, pvk_in_materials, pvk_in_materialCount);
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbMaterials                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L414~414
    #if NATIVE
    ES physx::PxU16 getNbMaterials(physx::PxShape* self){
        physx::PxU16 retVal = self->getNbMaterials();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort getNbMaterials(PxShape selfPtr);
    
    public ushort getNbMaterials(){
        ushort retVal = getNbMaterials(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L430~430
    #if NATIVE
    ES physx::PxU32 getMaterials(physx::PxShape* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getMaterials(PxShape selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getMaterials( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getMaterials(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getMaterialFromInternalFaceIndex                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L450~450
    #if NATIVE
    ES UNPARSED_TYPE getMaterialFromInternalFaceIndex(physx::PxShape* self, physx::PxU32 faceIndex){
        physx::PxU32 nat_in_faceIndex = (faceIndex);
        UNPARSED_TYPE retVal = self->getMaterialFromInternalFaceIndex(nat_in_faceIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getMaterialFromInternalFaceIndex(PxShape selfPtr, uint faceIndex);
    
    public UNPARSED_TYPE getMaterialFromInternalFaceIndex(uint faceIndex){
        uint pvk_in_faceIndex = (faceIndex);
        UNPARSED_TYPE retVal = getMaterialFromInternalFaceIndex(this, pvk_in_faceIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       setContactOffset                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L468~468
    #if NATIVE
    ES void setContactOffset(physx::PxShape* self, physx::PxReal contactOffset){
        physx::PxReal nat_in_contactOffset = (contactOffset);
        self->setContactOffset(nat_in_contactOffset);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setContactOffset(PxShape selfPtr, float contactOffset);
    
    public void setContactOffset(float contactOffset){
        float pvk_in_contactOffset = (contactOffset);
        setContactOffset(this, pvk_in_contactOffset);
    }
    #endif
    
    
    //================================================================================
    //#       getContactOffset                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L477~477
    #if NATIVE
    ES physx::PxReal getContactOffset(physx::PxShape* self){
        physx::PxReal retVal = self->getContactOffset();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getContactOffset(PxShape selfPtr);
    
    public float getContactOffset(){
        float retVal = getContactOffset(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setRestOffset                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L494~494
    #if NATIVE
    ES void setRestOffset(physx::PxShape* self, physx::PxReal restOffset){
        physx::PxReal nat_in_restOffset = (restOffset);
        self->setRestOffset(nat_in_restOffset);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setRestOffset(PxShape selfPtr, float restOffset);
    
    public void setRestOffset(float restOffset){
        float pvk_in_restOffset = (restOffset);
        setRestOffset(this, pvk_in_restOffset);
    }
    #endif
    
    
    //================================================================================
    //#       getRestOffset                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L503~503
    #if NATIVE
    ES physx::PxReal getRestOffset(physx::PxShape* self){
        physx::PxReal retVal = self->getRestOffset();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getRestOffset(PxShape selfPtr);
    
    public float getRestOffset(){
        float retVal = getRestOffset(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setTorsionalPatchRadius                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L517~517
    #if NATIVE
    ES void setTorsionalPatchRadius(physx::PxShape* self, physx::PxReal radius){
        physx::PxReal nat_in_radius = (radius);
        self->setTorsionalPatchRadius(nat_in_radius);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setTorsionalPatchRadius(PxShape selfPtr, float radius);
    
    public void setTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        setTorsionalPatchRadius(this, pvk_in_radius);
    }
    #endif
    
    
    //================================================================================
    //#       getTorsionalPatchRadius                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L529~529
    #if NATIVE
    ES physx::PxReal getTorsionalPatchRadius(physx::PxShape* self){
        physx::PxReal retVal = self->getTorsionalPatchRadius();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getTorsionalPatchRadius(PxShape selfPtr);
    
    public float getTorsionalPatchRadius(){
        float retVal = getTorsionalPatchRadius(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setMinTorsionalPatchRadius                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L542~542
    #if NATIVE
    ES void setMinTorsionalPatchRadius(physx::PxShape* self, physx::PxReal radius){
        physx::PxReal nat_in_radius = (radius);
        self->setMinTorsionalPatchRadius(nat_in_radius);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setMinTorsionalPatchRadius(PxShape selfPtr, float radius);
    
    public void setMinTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        setMinTorsionalPatchRadius(this, pvk_in_radius);
    }
    #endif
    
    
    //================================================================================
    //#       getMinTorsionalPatchRadius                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L554~554
    #if NATIVE
    ES physx::PxReal getMinTorsionalPatchRadius(physx::PxShape* self){
        physx::PxReal retVal = self->getMinTorsionalPatchRadius();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getMinTorsionalPatchRadius(PxShape selfPtr);
    
    public float getMinTorsionalPatchRadius(){
        float retVal = getMinTorsionalPatchRadius(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L571~571
    #if NATIVE
    ES void setFlag(physx::PxShape* self, physx::PxShapeFlag::Enum flag, bool value){
        physx::PxShapeFlag::Enum nat_in_flag = (flag);
        bool nat_in_value = (value);
        self->setFlag(nat_in_flag, nat_in_value);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setFlag(PxShape selfPtr, PxShapeFlag flag, bool value);
    
    public void setFlag(PxShapeFlag flag, bool value){
        PxShapeFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        setFlag(this, pvk_in_flag, pvk_in_value);
    }
    #endif
    
    
    //================================================================================
    //#       setFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxShape::setFlags::inFlags
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L578~578
    #if NATIVE
    ES void setFlags(physx::PxShape* self,  inFlags){
         nat_in_inFlags = (inFlags);
        self->setFlags(nat_in_inFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setFlags(PxShape selfPtr,  inFlags);
    
    public void setFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        setFlags(this, pvk_in_inFlags);
    }
    #endif*/
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L587~587
    #if NATIVE
    ES UNPARSED_TYPE getFlags(physx::PxShape* self){
        UNPARSED_TYPE retVal = self->getFlags();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getFlags(PxShape selfPtr);
    
    public UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = getFlags(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isExclusive                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L594~594
    #if NATIVE
    ES bool isExclusive(physx::PxShape* self){
        bool retVal = self->isExclusive();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isExclusive(PxShape selfPtr);
    
    public bool isExclusive(){
        bool retVal = isExclusive(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setName                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L608~608
    #if NATIVE
    ES void setName(physx::PxShape* self, char name){
        char nat_in_name = (name);
        self->setName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void setName(PxShape selfPtr, sbyte name);
    
    public void setName(sbyte name){
        sbyte pvk_in_name = (name);
        setName(this, pvk_in_name);
    }
    #endif
    
    
    //================================================================================
    //#       getName                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L617~617
    #if NATIVE
    ES UNPARSED_TYPE getName(physx::PxShape* self){
        UNPARSED_TYPE retVal = self->getName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getName(PxShape selfPtr);
    
    public UNPARSED_TYPE getName(){
        UNPARSED_TYPE retVal = getName(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L620~620
    #if NATIVE
    ES UNPARSED_TYPE getConcreteTypeName(physx::PxShape* self){
        UNPARSED_TYPE retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getConcreteTypeName(PxShape selfPtr);
    
    public UNPARSED_TYPE getConcreteTypeName(){
        UNPARSED_TYPE retVal = getConcreteTypeName(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxShape::PxShape::baseFlags
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L627~627
    #if NATIVE
    ES UNPARSED_TYPE PxShape_ctor( baseFlags){
         nat_in_baseFlags = (baseFlags);
        self->PxShape(nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxShape_ctor( baseFlags);
    
    public PxShape( baseFlags){
         pvk_in_baseFlags = (baseFlags);
        var _new = PxShape_ctor(pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Unresolved parameter type physx::PxShape::PxShape::baseFlags
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L628~628
    #if NATIVE
    ES UNPARSED_TYPE PxShape_ctor(physx::PxType concreteType,  baseFlags){
        physx::PxType nat_in_concreteType = (concreteType);
         nat_in_baseFlags = (baseFlags);
        self->PxShape(nat_in_concreteType, nat_in_baseFlags);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxShape_ctor(ushort concreteType,  baseFlags);
    
    public PxShape(ushort concreteType,  baseFlags){
        ushort pvk_in_concreteType = (concreteType);
         pvk_in_baseFlags = (baseFlags);
        var _new = PxShape_ctor(pvk_in_concreteType, pvk_in_baseFlags);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxShape                                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L629~629
    #if NATIVE
    ES void ~PxShape(physx::PxShape* self){
        self->~PxShape();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxShape(PxShape selfPtr);
    
    public void ~PxShape(){
        ~PxShape(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       isKindOf                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L630~630
    #if NATIVE
    ES bool isKindOf(physx::PxShape* self, char name){
        char nat_in_name = (name);
        bool retVal = self->isKindOf(nat_in_name);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isKindOf(PxShape selfPtr, sbyte name);
    
    public bool isKindOf(sbyte name){
        sbyte pvk_in_name = (name);
        bool retVal = isKindOf(this, pvk_in_name);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxShape                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L142~142
    #if NATIVE
    ES UNPARSED_TYPE PxShape_ctor( ){
         nat_in_ = ();
        self->PxShape(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxShape_ctor( );
    
    public PxShape( ){
         pvk_in_ = ();
        var _new = PxShape_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L142~142
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxShape* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxShape selfPtr);
    
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
public unsafe partial struct PxShapeFlag { // blittable

#endif

    //================================================================================
    //#       PxShapeFlag                                                            #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag PxShapeFlag_ctor(){
        self.PxShapeFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag PxShapeFlag_ctor();
    
    public PxShapeFlag(){
        var _new = PxShapeFlag_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShapeFlag                                                            #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag PxShapeFlag_ctor(physx::PxShapeFlag ){
        physx::PxShapeFlag nat_in_ = ();
        self.PxShapeFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag PxShapeFlag_ctor(PxShapeFlag );
    
    public PxShapeFlag(PxShapeFlag ){
        PxShapeFlag pvk_in_ = ();
        var _new = PxShapeFlag_ctor(pvk_in_);
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
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxShapeFlag self, physx::PxShapeFlag ){
        physx::PxShapeFlag nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxShapeFlag selfBlt, PxShapeFlag );
    
    public UNPARSED_TYPE operator=(PxShapeFlag ){
        PxShapeFlag pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxShapeFlag                                                            #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES physx::PxShapeFlag PxShapeFlag_ctor( ){
         nat_in_ = ();
        self.PxShapeFlag(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxShapeFlag PxShapeFlag_ctor( );
    
    public PxShapeFlag( ){
         pvk_in_ = ();
        var _new = PxShapeFlag_ctor(pvk_in_);
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
    Non const pointer/reference global::PhysX.physx.PxShapeFlag
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxShapeFlag self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxShapeFlag selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxShapeFlag                                                           #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\PxShape.h L63~63
    #if NATIVE
    ES void ~PxShapeFlag(physx::PxShapeFlag self){
        self.~PxShapeFlag();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxShapeFlag(PxShapeFlag selfBlt);
    
    public void ~PxShapeFlag(){
        ~PxShapeFlag(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif


