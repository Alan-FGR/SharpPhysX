// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//DEBUG: NamespaceNode physx - 41-193
//DEBUG: ClassNode physx::PxHullPolygon - 51-56
//DEBUG: NewerFreerNode physx::PxHullPolygon - 51-56
ES PxHullPolygonPtr Newer_physx_PxHullPolygonPtr(){
    return new std::remove_pointer<PxHullPolygonPtr>::type();
}

ES void Freer_physx_PxHullPolygonPtr(PxHullPolygonPtr ptr){
    delete ptr;
}

//DEBUG: PtrStructCtorNode physx::PxHullPolygon::PxHullPolygon - 51
//ERRORS OCCURED IN physx::PxHullPolygon::PxHullPolygon
//Implicit Function/Method

//DEBUG: PtrStructCtorNode physx::PxHullPolygon::PxHullPolygon - 51
//ERRORS OCCURED IN physx::PxHullPolygon::PxHullPolygon
//Implicit Function/Method

//DEBUG: PtrStructCtorNode physx::PxHullPolygon::PxHullPolygon - 51
//ERRORS OCCURED IN physx::PxHullPolygon::PxHullPolygon
//Implicit Function/Method

//DEBUG: GetterSetterNode physx::PxHullPolygon - 51-56
//Field: mPlane - 53-53
//ERRORS OCCURED IN physx::PxHullPolygon
////################################################################## FIXME
//Unparsed type ( TODO ): ::physx::PxReal[4]

//DEBUG: GetterSetterNode physx::PxHullPolygon - 51-56
//Field: mNbVerts - 54-54
ES unsigned short PxHullPolygon_GET_mNbVerts(PxHullPolygonPtr cls) {return (unsigned short)cls->mNbVerts;}
ES void PxHullPolygon_SET_mNbVerts(PxHullPolygonPtr cls, unsigned short value) {cls->mNbVerts = value;}

//DEBUG: GetterSetterNode physx::PxHullPolygon - 51-56
//Field: mIndexBase - 55-55
ES unsigned short PxHullPolygon_GET_mIndexBase(PxHullPolygonPtr cls) {return (unsigned short)cls->mIndexBase;}
ES void PxHullPolygon_SET_mIndexBase(PxHullPolygonPtr cls, unsigned short value) {cls->mIndexBase = value;}

//DEBUG: MethodNode physx::PxHullPolygon::operator= - 51
//ERRORS OCCURED IN physx::PxHullPolygon::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxHullPolygon::operator= - 51
//ERRORS OCCURED IN physx::PxHullPolygon::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxHullPolygon::~PxHullPolygon - 51
//ERRORS OCCURED IN physx::PxHullPolygon::~PxHullPolygon
//Implicit Function/Method
//Destructor

//DEBUG: ClassNode physx::PxConvexMesh - 84-190
//Bases: PxBasePtr
//DEBUG: MethodNode physx::PxConvexMesh::getNbVertices - 93
ES unsigned int uint_const_physx_PxConvexMesh_getNbVertices(PxConvexMeshPtr wrp_this){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    return (unsigned int) wrp_this->getNbVertices();
}

//DEBUG: MethodNode physx::PxConvexMesh::getVertices - 100
ES physx::PxVec3* physx_PxVec3_const_physx_PxConvexMesh_getVertices(PxConvexMeshPtr wrp_this){
    //RET nat: physx::PxVec3*, man: physx.PxVec3*, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    return (physx::PxVec3*) wrp_this->getVertices();
}

//DEBUG: MethodNode physx::PxConvexMesh::getIndexBuffer - 107
ES unsigned char* byte_const_physx_PxConvexMesh_getIndexBuffer(PxConvexMeshPtr wrp_this){
    //RET nat: unsigned char*, man: byte*, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    return (unsigned char*) wrp_this->getIndexBuffer();
}

//DEBUG: MethodNode physx::PxConvexMesh::getNbPolygons - 114
ES unsigned int uint_const_physx_PxConvexMesh_getNbPolygons(PxConvexMeshPtr wrp_this){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    return (unsigned int) wrp_this->getNbPolygons();
}

//DEBUG: MethodNode physx::PxConvexMesh::getPolygonData - 123
ES bool bool_const_physx_PxConvexMesh_getPolygonData_uint_physx_PxHullPolygonPtr_(PxConvexMeshPtr wrp_this, unsigned int wrp_index, PxHullPolygonPtr wrp_data){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    //PAR nat: unsigned int, man: uint, kind: Value
    //PAR nat: PxHullPolygonPtr, man: physx.PxHullPolygonPtr, kind: PtrStruct
    return (bool) wrp_this->getPolygonData(wrp_index, *wrp_data);
}

//DEBUG: MethodNode physx::PxConvexMesh::release - 130
ES void void_physx_PxConvexMesh_release(PxConvexMeshPtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    wrp_this->release();
}

//DEBUG: MethodNode physx::PxConvexMesh::getReferenceCount - 140
ES unsigned int uint_const_physx_PxConvexMesh_getReferenceCount(PxConvexMeshPtr wrp_this){
    //RET nat: unsigned int, man: uint, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    return (unsigned int) wrp_this->getReferenceCount();
}

//DEBUG: MethodNode physx::PxConvexMesh::acquireReference - 147
ES void void_physx_PxConvexMesh_acquireReference(PxConvexMeshPtr wrp_this){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    wrp_this->acquireReference();
}

//DEBUG: MethodNode physx::PxConvexMesh::getMassInformation - 165
ES void void_const_physx_PxConvexMesh_getMassInformation_float_physx_PxMat33_physx_PxVec3_(PxConvexMeshPtr wrp_this, float* wrp_mass, physx::PxMat33* wrp_localInertia, physx::PxVec3* wrp_localCenterOfMass){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    //PAR nat: float*, man: float*, kind: Value
    //PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
    //PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
    wrp_this->getMassInformation(*wrp_mass, *wrp_localInertia, *wrp_localCenterOfMass);
}

//DEBUG: MethodNode physx::PxConvexMesh::getLocalBounds - 172
ES void physx_PxBounds3_const_physx_PxConvexMesh_getLocalBounds(physx::PxBounds3* RetRef, PxConvexMeshPtr wrp_this){
    //RET nat: physx::PxBounds3, man: physx.PxBounds3, ret: False, kind: Blittable
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    *RetRef = wrp_this->getLocalBounds();
}

//DEBUG: MethodNode physx::PxConvexMesh::getConcreteTypeName - 174
ES char* string_const_physx_PxConvexMesh_getConcreteTypeName(PxConvexMeshPtr wrp_this){
    //RET nat: char*, man: string, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    return (char*) wrp_this->getConcreteTypeName();
}

//DEBUG: MethodNode physx::PxConvexMesh::isGpuCompatible - 183
ES bool bool_const_physx_PxConvexMesh_isGpuCompatible(PxConvexMeshPtr wrp_this){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxConvexMeshPtr, man: physx.PxConvexMeshPtr, kind: PtrStruct
    return (bool) wrp_this->isGpuCompatible();
}

//DEBUG: MethodNode physx::PxConvexMesh::operator= - 84
//ERRORS OCCURED IN physx::PxConvexMesh::operator=
//Implicit Function/Method
//Unbindable Operator: Equal
