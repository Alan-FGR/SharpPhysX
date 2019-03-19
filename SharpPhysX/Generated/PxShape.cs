#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes

#if !NATIVE //enum
public enum PxShapeFlag : int {
    eSIMULATION_SHAPE = 1,  // eSIMULATION_SHAPE = (1<<0)
    eSCENE_QUERY_SHAPE = 2, // eSCENE_QUERY_SHAPE = (1<<1)
    eTRIGGER_SHAPE = 4,     // eTRIGGER_SHAPE = (1<<2)
    eVISUALIZATION = 8,     // eVISUALIZATION = (1<<3)
}
#endif //enum

#if !NATIVE
public partial struct PxShape {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag_P_PxShapeFlag(physx::PxShapeFlag::Enum a, physx::PxShapeFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag_P_PxShapeFlag(PxShapeFlag a, PxShapeFlag b);

public static UNPARSED_TYPE operator|(PxShapeFlag a, PxShapeFlag b){
    PxShapeFlag pvk_in_a = (a);
    PxShapeFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag_P_PxShapeFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag_P_PxShapeFlag(physx::PxShapeFlag::Enum a, physx::PxShapeFlag::Enum b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag_P_PxShapeFlag(PxShapeFlag a, PxShapeFlag b);

public static UNPARSED_TYPE operator&(PxShapeFlag a, PxShapeFlag b){
    PxShapeFlag pvk_in_a = (a);
    PxShapeFlag pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag_P_PxShapeFlag(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif //function end*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::PxShapeFlag::Enum, unsigned char>
// NATIVE SIG: 
#if NATIVE //function start
ES UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag(physx::PxShapeFlag::Enum a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag(PxShapeFlag a);

public static UNPARSED_TYPE operator~(PxShapeFlag a){
    PxShapeFlag pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde_R_PxFlags_PxShapeFlag_byte_P_PxShapeFlag(pvk_in_a);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxShape
#endif


#if !NATIVE //interface
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
     string getName();
     string getConcreteTypeName();
    // PxShape(/*NULLPARS*/);
    // PxShape(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxShape(/*NULLPARS*/);
    // UNPARSED_TYPE isKindOf(/*NULLPARS*/);
    // PxShape(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxShapePtr lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxShapePtr : IPxBasePtr, IPxShapePtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields

    // ### USERDATA getter/setter
    #if NATIVE //getter
    ES void* PxShape_GET_userData(PxShape* self) {return self->userData;}
    ES void PxShape_SET_userData(PxShape* self, void* value) {self->userData = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr PxShape_GET_userData(PxShapePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxShape_SET_userData(PxShapePtr selfPtr, IntPtr value);

    public IntPtr userData {
        get => PxShape_GET_userData(this);
        set => PxShape_SET_userData(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxBasePtr, PxShapePtr
    public static implicit operator PxBasePtr(PxShapePtr obj){return *(PxBasePtr*)&obj;}
    public static explicit operator PxShapePtr(PxBasePtr obj){return *(PxShapePtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxBasePtr
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    //public  UNPARSED_TYPE is(){return ((PxBasePtr)this).is();}
    public  ushort getConcreteType(){return ((PxBasePtr)this).getConcreteType();}
    public  void setBaseFlag(PxBaseFlag flag, bool value){((PxBasePtr)this).setBaseFlag(flag, value);}
    //public  void setBaseFlags( inFlags){((PxBasePtr)this).setBaseFlags(inFlags);}
    //public  UNPARSED_TYPE getBaseFlags(){return ((PxBasePtr)this).getBaseFlags();}
    public  bool isReleasable(){return ((PxBasePtr)this).isReleasable();}
    //public  PxBase(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  PxBase(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxBase(/*NULLPARS*/){((PxBasePtr)this).~PxBase(/*NULLARGS*/);}
    //public  UNPARSED_TYPE typeMatch(/*NULLPARS*/){return ((PxBasePtr)this).typeMatch(/*NULLARGS*/);}
    //public  PxBase(/*NULLPARS*/){((PxBasePtr)this).PxBase(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxBasePtr lhs, /*NULLPARS*/){return ((PxBasePtr)this).operator=(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxShape(physx::PxShape* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxShape(PxShapePtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxShape(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getReferenceCount                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getReferenceCount_R_uint_C_PxShape(physx::PxShape* self){
        auto retVal = self->getReferenceCount();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getReferenceCount_R_uint_C_PxShape(PxShapePtr selfPtr);
    
    public  uint getReferenceCount(){
        uint retVal = W_getReferenceCount_R_uint_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       acquireReference                                                       #
    //================================================================================
    #if NATIVE //function start
    ES void W_acquireReference_R_void_C_PxShape(physx::PxShape* self){
        self->acquireReference();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_acquireReference_R_void_C_PxShape(PxShapePtr selfPtr);
    
    public  void acquireReference(){
        W_acquireReference_R_void_C_PxShape(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getGeometryType                                                        #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxGeometryType::Enum W_getGeometryType_R_PxGeometryType_C_PxShape(physx::PxShape* self){
        auto retVal = self->getGeometryType();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxGeometryType W_getGeometryType_R_PxGeometryType_C_PxShape(PxShapePtr selfPtr);
    
    public  PxGeometryType getGeometryType(){
        PxGeometryType retVal = W_getGeometryType_R_PxGeometryType_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setGeometry                                                            #
    //================================================================================
    #if NATIVE //function start
    ES void W_setGeometry_R_void_P_PxGeometryPtr_C_PxShape(physx::PxShape* self, physx::PxGeometry* geometry){
        auto nat_in_geometry = (geometry);
        self->setGeometry(*nat_in_geometry);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setGeometry_R_void_P_PxGeometryPtr_C_PxShape(PxShapePtr selfPtr, PxGeometryPtr geometry);
    
    public  void setGeometry(PxGeometryPtr geometry){
        PxGeometryPtr pvk_in_geometry = (geometry);
        W_setGeometry_R_void_P_PxGeometryPtr_C_PxShape(this, pvk_in_geometry);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getGeometry                                                            #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxGeometryHolder
    // NATIVE SIG: PxGeometryHolder		getGeometry() const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getGeometry_R_PxGeometryHolderPtr_C_PxShape(physx::PxShape* self){
        auto retVal = self->getGeometry();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getGeometry_R_PxGeometryHolderPtr_C_PxShape(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getGeometry(){
        UNPARSED_TYPE retVal = W_getGeometry_R_PxGeometryHolderPtr_C_PxShape(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getBoxGeometry                                                         #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxBoxGeometry
    // NATIVE SIG: bool					getBoxGeometry(PxBoxGeometry& geometry) const = 0
    #if NATIVE //function start
    ES bool W_getBoxGeometry_R_bool_P__C_PxShape(physx::PxShape* self,  geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getBoxGeometry(nat_in_geometry);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getBoxGeometry_R_bool_P__C_PxShape(PxShapePtr selfPtr,  geometry);
    
    public  bool getBoxGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = W_getBoxGeometry_R_bool_P__C_PxShape(this, pvk_in_geometry);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getSphereGeometry                                                      #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxSphereGeometry
    // NATIVE SIG: bool					getSphereGeometry(PxSphereGeometry& geometry) const = 0
    #if NATIVE //function start
    ES bool W_getSphereGeometry_R_bool_P__C_PxShape(physx::PxShape* self,  geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getSphereGeometry(nat_in_geometry);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getSphereGeometry_R_bool_P__C_PxShape(PxShapePtr selfPtr,  geometry);
    
    public  bool getSphereGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = W_getSphereGeometry_R_bool_P__C_PxShape(this, pvk_in_geometry);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getCapsuleGeometry                                                     #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference global::PhysX.physx.PxCapsuleGeometry
    // NATIVE SIG: bool					getCapsuleGeometry(PxCapsuleGeometry& geometry) const = 0
    #if NATIVE //function start
    ES bool W_getCapsuleGeometry_R_bool_P__C_PxShape(physx::PxShape* self,  geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getCapsuleGeometry(nat_in_geometry);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getCapsuleGeometry_R_bool_P__C_PxShape(PxShapePtr selfPtr,  geometry);
    
    public  bool getCapsuleGeometry( geometry){
         pvk_in_geometry = (geometry);
        bool retVal = W_getCapsuleGeometry_R_bool_P__C_PxShape(this, pvk_in_geometry);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getPlaneGeometry                                                       #
    //================================================================================
    #if NATIVE //function start
    ES bool W_getPlaneGeometry_R_bool_P_PxPlaneGeometryPtr_C_PxShape(physx::PxShape* self, physx::PxPlaneGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getPlaneGeometry(*nat_in_geometry);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getPlaneGeometry_R_bool_P_PxPlaneGeometryPtr_C_PxShape(PxShapePtr selfPtr, PxPlaneGeometryPtr geometry);
    
    public  bool getPlaneGeometry(PxPlaneGeometryPtr geometry){
        PxPlaneGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getPlaneGeometry_R_bool_P_PxPlaneGeometryPtr_C_PxShape(this, pvk_in_geometry);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConvexMeshGeometry                                                  #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxConvexMeshGeometryPtr
    // NATIVE SIG: bool					getConvexMeshGeometry(PxConvexMeshGeometry& geometry) const = 0
    #if NATIVE //function start
    ES bool W_getConvexMeshGeometry_R_bool_P_PxConvexMeshGeometryPtr_C_PxShape(physx::PxShape* self, physx::PxConvexMeshGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getConvexMeshGeometry(*nat_in_geometry);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getConvexMeshGeometry_R_bool_P_PxConvexMeshGeometryPtr_C_PxShape(PxShapePtr selfPtr, PxConvexMeshGeometryPtr geometry);
    
    public  bool getConvexMeshGeometry(PxConvexMeshGeometryPtr geometry){
        PxConvexMeshGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getConvexMeshGeometry_R_bool_P_PxConvexMeshGeometryPtr_C_PxShape(this, pvk_in_geometry);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getTriangleMeshGeometry                                                #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxTriangleMeshGeometryPtr
    // NATIVE SIG: bool					getTriangleMeshGeometry(PxTriangleMeshGeometry& geometry) const = 0
    #if NATIVE //function start
    ES bool W_getTriangleMeshGeometry_R_bool_P_PxTriangleMeshGeometryPtr_C_PxShape(physx::PxShape* self, physx::PxTriangleMeshGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getTriangleMeshGeometry(*nat_in_geometry);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getTriangleMeshGeometry_R_bool_P_PxTriangleMeshGeometryPtr_C_PxShape(PxShapePtr selfPtr, PxTriangleMeshGeometryPtr geometry);
    
    public  bool getTriangleMeshGeometry(PxTriangleMeshGeometryPtr geometry){
        PxTriangleMeshGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getTriangleMeshGeometry_R_bool_P_PxTriangleMeshGeometryPtr_C_PxShape(this, pvk_in_geometry);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getHeightFieldGeometry                                                 #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PxHeightFieldGeometryPtr
    // NATIVE SIG: bool					getHeightFieldGeometry(PxHeightFieldGeometry& geometry) const = 0
    #if NATIVE //function start
    ES bool W_getHeightFieldGeometry_R_bool_P_PxHeightFieldGeometryPtr_C_PxShape(physx::PxShape* self, physx::PxHeightFieldGeometry* geometry){
        auto nat_in_geometry = (geometry);
        auto retVal = self->getHeightFieldGeometry(*nat_in_geometry);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_getHeightFieldGeometry_R_bool_P_PxHeightFieldGeometryPtr_C_PxShape(PxShapePtr selfPtr, PxHeightFieldGeometryPtr geometry);
    
    public  bool getHeightFieldGeometry(PxHeightFieldGeometryPtr geometry){
        PxHeightFieldGeometryPtr pvk_in_geometry = (geometry);
        bool retVal = W_getHeightFieldGeometry_R_bool_P_PxHeightFieldGeometryPtr_C_PxShape(this, pvk_in_geometry);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getActor                                                               #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxRigidActor* W_getActor_R_PxRigidActorPtr_C_PxShape(physx::PxShape* self){
        auto retVal = self->getActor();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRigidActorPtr W_getActor_R_PxRigidActorPtr_C_PxShape(PxShapePtr selfPtr);
    
    public  PxRigidActorPtr getActor(){
        PxRigidActorPtr retVal = W_getActor_R_PxRigidActorPtr_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setLocalPose                                                           #
    //================================================================================
    #if NATIVE //function start
    ES void W_setLocalPose_R_void_P_PxTransform_C_PxShape(physx::PxShape* self, physx::PxTransform pose){
        auto nat_in_pose = (pose);
        self->setLocalPose(nat_in_pose);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setLocalPose_R_void_P_PxTransform_C_PxShape(PxShapePtr selfPtr, PxTransform pose);
    
    public  void setLocalPose(PxTransform pose){
        PxTransform pvk_in_pose = (pose);
        W_setLocalPose_R_void_P_PxTransform_C_PxShape(this, pvk_in_pose);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getLocalPose                                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxTransform W_getLocalPose_R_PxTransform_C_PxShape(physx::PxShape* self){
        auto retVal = self->getLocalPose();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform W_getLocalPose_R_PxTransform_C_PxShape(PxShapePtr selfPtr);
    
    public  PxTransform getLocalPose(){
        PxTransform retVal = W_getLocalPose_R_PxTransform_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setSimulationFilterData                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setSimulationFilterData_R_void_P_PxFilterDataPtr_C_PxShape(physx::PxShape* self, physx::PxFilterData* data){
        auto nat_in_data = (data);
        self->setSimulationFilterData(*nat_in_data);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setSimulationFilterData_R_void_P_PxFilterDataPtr_C_PxShape(PxShapePtr selfPtr, PxFilterDataPtr data);
    
    public  void setSimulationFilterData(PxFilterDataPtr data){
        PxFilterDataPtr pvk_in_data = (data);
        W_setSimulationFilterData_R_void_P_PxFilterDataPtr_C_PxShape(this, pvk_in_data);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getSimulationFilterData                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    // NATIVE SIG: PxFilterData			getSimulationFilterData()					const	= 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getSimulationFilterData_R_PxFilterDataPtr_C_PxShape(physx::PxShape* self){
        auto retVal = self->getSimulationFilterData();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getSimulationFilterData_R_PxFilterDataPtr_C_PxShape(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getSimulationFilterData(){
        UNPARSED_TYPE retVal = W_getSimulationFilterData_R_PxFilterDataPtr_C_PxShape(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setQueryFilterData                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_setQueryFilterData_R_void_P_PxFilterDataPtr_C_PxShape(physx::PxShape* self, physx::PxFilterData* data){
        auto nat_in_data = (data);
        self->setQueryFilterData(*nat_in_data);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setQueryFilterData_R_void_P_PxFilterDataPtr_C_PxShape(PxShapePtr selfPtr, PxFilterDataPtr data);
    
    public  void setQueryFilterData(PxFilterDataPtr data){
        PxFilterDataPtr pvk_in_data = (data);
        W_setQueryFilterData_R_void_P_PxFilterDataPtr_C_PxShape(this, pvk_in_data);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getQueryFilterData                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFilterData
    // NATIVE SIG: PxFilterData			getQueryFilterData()					const	= 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getQueryFilterData_R_PxFilterDataPtr_C_PxShape(physx::PxShape* self){
        auto retVal = self->getQueryFilterData();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getQueryFilterData_R_PxFilterDataPtr_C_PxShape(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getQueryFilterData(){
        UNPARSED_TYPE retVal = W_getQueryFilterData_R_PxFilterDataPtr_C_PxShape(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       setMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: void					setMaterials(PxMaterial*const* materials, PxU16 materialCount)	= 0
    #if NATIVE //function start
    ES void W_setMaterials_R_void_P__P_ushort_C_PxShape(physx::PxShape* self,  materials, physx::PxU16 materialCount){
        auto nat_in_materials = (materials);
        auto nat_in_materialCount = (materialCount);
        self->setMaterials(nat_in_materials, nat_in_materialCount);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMaterials_R_void_P__P_ushort_C_PxShape(PxShapePtr selfPtr,  materials, ushort materialCount);
    
    public  void setMaterials( materials, ushort materialCount){
         pvk_in_materials = (materials);
        ushort pvk_in_materialCount = (materialCount);
        W_setMaterials_R_void_P__P_ushort_C_PxShape(this, pvk_in_materials, pvk_in_materialCount);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getNbMaterials                                                         #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU16 W_getNbMaterials_R_ushort_C_PxShape(physx::PxShape* self){
        auto retVal = self->getNbMaterials();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ushort W_getNbMaterials_R_ushort_C_PxShape(PxShapePtr selfPtr);
    
    public  ushort getNbMaterials(){
        ushort retVal = W_getNbMaterials_R_ushort_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMaterials                                                           #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32					getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getMaterials_R_uint_P__P_uint_P_uint_C_PxShape(physx::PxShape* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaterials_R_uint_P__P_uint_P_uint_C_PxShape(PxShapePtr selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public  uint getMaterials( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getMaterials_R_uint_P__P_uint_P_uint_C_PxShape(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxMaterial*
    // NATIVE SIG: PxU32					getMaterials(PxMaterial** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const	= 0
    #if NATIVE //function start
    ES physx::PxU32 W_getMaterials_R_uint_P__P_uint_OL1_C_PxShape(physx::PxShape* self,  userBuffer, physx::PxU32 bufferSize){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto retVal = self->getMaterials(nat_in_userBuffer, nat_in_bufferSize);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getMaterials_R_uint_P__P_uint_OL1_C_PxShape(PxShapePtr selfPtr,  userBuffer, uint bufferSize);
    
    public  uint getMaterials( userBuffer, uint bufferSize){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint retVal = W_getMaterials_R_uint_P__P_uint_OL1_C_PxShape(this, pvk_in_userBuffer, pvk_in_bufferSize);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       getMaterialFromInternalFaceIndex                                       #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxMaterial* W_getMaterialFromInternalFaceIndex_R_PxMaterialPtr_P_uint_C_PxShape(physx::PxShape* self, physx::PxU32 faceIndex){
        auto nat_in_faceIndex = (faceIndex);
        auto retVal = self->getMaterialFromInternalFaceIndex(nat_in_faceIndex);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMaterialPtr W_getMaterialFromInternalFaceIndex_R_PxMaterialPtr_P_uint_C_PxShape(PxShapePtr selfPtr, uint faceIndex);
    
    public  PxMaterialPtr getMaterialFromInternalFaceIndex(uint faceIndex){
        uint pvk_in_faceIndex = (faceIndex);
        PxMaterialPtr retVal = W_getMaterialFromInternalFaceIndex_R_PxMaterialPtr_P_uint_C_PxShape(this, pvk_in_faceIndex);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setContactOffset                                                       #
    //================================================================================
    #if NATIVE //function start
    ES void W_setContactOffset_R_void_P_float_C_PxShape(physx::PxShape* self, physx::PxReal contactOffset){
        auto nat_in_contactOffset = (contactOffset);
        self->setContactOffset(nat_in_contactOffset);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setContactOffset_R_void_P_float_C_PxShape(PxShapePtr selfPtr, float contactOffset);
    
    public  void setContactOffset(float contactOffset){
        float pvk_in_contactOffset = (contactOffset);
        W_setContactOffset_R_void_P_float_C_PxShape(this, pvk_in_contactOffset);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getContactOffset                                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getContactOffset_R_float_C_PxShape(physx::PxShape* self){
        auto retVal = self->getContactOffset();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getContactOffset_R_float_C_PxShape(PxShapePtr selfPtr);
    
    public  float getContactOffset(){
        float retVal = W_getContactOffset_R_float_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setRestOffset                                                          #
    //================================================================================
    #if NATIVE //function start
    ES void W_setRestOffset_R_void_P_float_C_PxShape(physx::PxShape* self, physx::PxReal restOffset){
        auto nat_in_restOffset = (restOffset);
        self->setRestOffset(nat_in_restOffset);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setRestOffset_R_void_P_float_C_PxShape(PxShapePtr selfPtr, float restOffset);
    
    public  void setRestOffset(float restOffset){
        float pvk_in_restOffset = (restOffset);
        W_setRestOffset_R_void_P_float_C_PxShape(this, pvk_in_restOffset);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getRestOffset                                                          #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getRestOffset_R_float_C_PxShape(physx::PxShape* self){
        auto retVal = self->getRestOffset();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getRestOffset_R_float_C_PxShape(PxShapePtr selfPtr);
    
    public  float getRestOffset(){
        float retVal = W_getRestOffset_R_float_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setTorsionalPatchRadius                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setTorsionalPatchRadius_R_void_P_float_C_PxShape(physx::PxShape* self, physx::PxReal radius){
        auto nat_in_radius = (radius);
        self->setTorsionalPatchRadius(nat_in_radius);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setTorsionalPatchRadius_R_void_P_float_C_PxShape(PxShapePtr selfPtr, float radius);
    
    public  void setTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        W_setTorsionalPatchRadius_R_void_P_float_C_PxShape(this, pvk_in_radius);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTorsionalPatchRadius                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getTorsionalPatchRadius_R_float_C_PxShape(physx::PxShape* self){
        auto retVal = self->getTorsionalPatchRadius();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getTorsionalPatchRadius_R_float_C_PxShape(PxShapePtr selfPtr);
    
    public  float getTorsionalPatchRadius(){
        float retVal = W_getTorsionalPatchRadius_R_float_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setMinTorsionalPatchRadius                                             #
    //================================================================================
    #if NATIVE //function start
    ES void W_setMinTorsionalPatchRadius_R_void_P_float_C_PxShape(physx::PxShape* self, physx::PxReal radius){
        auto nat_in_radius = (radius);
        self->setMinTorsionalPatchRadius(nat_in_radius);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setMinTorsionalPatchRadius_R_void_P_float_C_PxShape(PxShapePtr selfPtr, float radius);
    
    public  void setMinTorsionalPatchRadius(float radius){
        float pvk_in_radius = (radius);
        W_setMinTorsionalPatchRadius_R_void_P_float_C_PxShape(this, pvk_in_radius);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getMinTorsionalPatchRadius                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getMinTorsionalPatchRadius_R_float_C_PxShape(physx::PxShape* self){
        auto retVal = self->getMinTorsionalPatchRadius();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getMinTorsionalPatchRadius_R_float_C_PxShape(PxShapePtr selfPtr);
    
    public  float getMinTorsionalPatchRadius(){
        float retVal = W_getMinTorsionalPatchRadius_R_float_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setFlag                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setFlag_R_void_P_PxShapeFlag_P_bool_C_PxShape(physx::PxShape* self, physx::PxShapeFlag::Enum flag, bool value){
        auto nat_in_flag = (flag);
        auto nat_in_value = (value);
        self->setFlag(nat_in_flag, nat_in_value);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlag_R_void_P_PxShapeFlag_P_bool_C_PxShape(PxShapePtr selfPtr, PxShapeFlag flag, bool value);
    
    public  void setFlag(PxShapeFlag flag, bool value){
        PxShapeFlag pvk_in_flag = (flag);
        bool pvk_in_value = (value);
        W_setFlag_R_void_P_PxShapeFlag_P_bool_C_PxShape(this, pvk_in_flag, pvk_in_value);
    }
    #endif //function end
    
    
    //================================================================================
    //#       setFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxShapeFlags
    // NATIVE SIG: void					setFlags(PxShapeFlags inFlags) = 0
    #if NATIVE //function start
    ES void W_setFlags_R_void_P__C_PxShape(physx::PxShape* self,  inFlags){
        auto nat_in_inFlags = (inFlags);
        self->setFlags(nat_in_inFlags);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setFlags_R_void_P__C_PxShape(PxShapePtr selfPtr,  inFlags);
    
    public  void setFlags( inFlags){
         pvk_in_inFlags = (inFlags);
        W_setFlags_R_void_P__C_PxShape(this, pvk_in_inFlags);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getFlags                                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxShapeFlags
    // NATIVE SIG: PxShapeFlags			getFlags() const = 0
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_getFlags_R_Enum, byte>_C_PxShape(physx::PxShape* self){
        auto retVal = self->getFlags();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getFlags_R_Enum, byte>_C_PxShape(PxShapePtr selfPtr);
    
    public  UNPARSED_TYPE getFlags(){
        UNPARSED_TYPE retVal = W_getFlags_R_Enum, byte>_C_PxShape(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       isExclusive                                                            #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isExclusive_R_bool_C_PxShape(physx::PxShape* self){
        auto retVal = self->isExclusive();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isExclusive_R_bool_C_PxShape(PxShapePtr selfPtr);
    
    public  bool isExclusive(){
        bool retVal = W_isExclusive_R_bool_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setName                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_setName_R_void_P_string_C_PxShape(physx::PxShape* self, const char* name){
        auto nat_in_name = (name);
        self->setName(nat_in_name);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setName_R_void_P_string_C_PxShape(PxShapePtr selfPtr, string name);
    
    public  void setName(string name){
        string pvk_in_name = (name);
        W_setName_R_void_P_string_C_PxShape(this, pvk_in_name);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getName                                                                #
    //================================================================================
    #if NATIVE //function start
    ES const char* W_getName_R_string_C_PxShape(physx::PxShape* self){
        auto retVal = self->getName();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string W_getName_R_string_C_PxShape(PxShapePtr selfPtr);
    
    public  string getName(){
        string retVal = W_getName_R_string_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getConcreteTypeName                                                    #
    //================================================================================
    #if NATIVE //function start
    ES const char* W_getConcreteTypeName_R_string_C_PxShape(physx::PxShape* self){
        auto retVal = self->getConcreteTypeName();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string W_getConcreteTypeName_R_string_C_PxShape(PxShapePtr selfPtr);
    
    public  string getConcreteTypeName(){
        string retVal = W_getConcreteTypeName_R_string_C_PxShape(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxShape
    
    //Skipped protected: PxShape
    
    //Skipped protected: ~PxShape
    
    //Skipped protected: isKindOf
    
    //Skipped generated implicit entry: PxShape
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close

// Class physx::PxShapeFlag is enum namespace