// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//DEBUG: NamespaceNode physx - 41-146
//DEBUG: FunctionNode physx::operator| - 69
//Internal Op

//DEBUG: FunctionNode physx::operator& - 69
//Internal Op

//DEBUG: FunctionNode physx::operator~ - 69
//Internal Op

//DEBUG: ClassNode physx::PxMeshGeometryFlag - 53-61
//DEBUG: EnumNode physx::PxMeshGeometryFlag::Enum - 55-60
// TODO EnumNode.GenWrapper()

//DEBUG: ClassNode physx::PxTriangleMeshGeometry - 82-128
//Bases: PxGeometryPtr
//DEBUG: NewerFreerNode physx::PxTriangleMeshGeometry - 82-128
ES void Freer_physx_PxTriangleMeshGeometryPtr(PxTriangleMeshGeometryPtr ptr){
    delete ptr;
}

//DEBUG: PtrStructCtorNode physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry - 90-93
ES PxTriangleMeshGeometryPtr Ctor_physx_PxTriangleMeshGeometryPtr_(){
    //RET nat: PxTriangleMeshGeometryPtr, man: physx.PxTriangleMeshGeometryPtr, ret: True, kind: PtrStruct
    return (PxTriangleMeshGeometryPtr) new std::remove_pointer<PxTriangleMeshGeometryPtr>::type();
}

//DEBUG: PtrStructCtorNode physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry - 102-109
ES PxTriangleMeshGeometryPtr Ctor_physx_PxTriangleMeshGeometryPtr_physx_PxTriangleMeshPtr_physx_PxMeshScalePtr_PxMeshGeometryFlagsPtr(PxTriangleMeshPtr wrp_mesh, PxMeshScalePtr wrp_scaling, PxMeshGeometryFlagsPtr wrp_flags){
    //RET nat: PxTriangleMeshGeometryPtr, man: physx.PxTriangleMeshGeometryPtr, ret: True, kind: PtrStruct
    //PAR nat: PxTriangleMeshPtr, man: physx.PxTriangleMeshPtr, kind: PtrStruct
    //PAR nat: PxMeshScalePtr, man: physx.PxMeshScalePtr, kind: PtrStruct
    //PAR nat: PxMeshGeometryFlagsPtr, man: PxMeshGeometryFlagsPtr, kind: PtrStruct
    return (PxTriangleMeshGeometryPtr) new std::remove_pointer<PxTriangleMeshGeometryPtr>::type(wrp_mesh, *wrp_scaling, *wrp_flags);
}

//DEBUG: PtrStructCtorNode physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry - 102-109
ES PxTriangleMeshGeometryPtr Ctor_physx_PxTriangleMeshGeometryPtr_physx_PxTriangleMeshPtr_physx_PxMeshScalePtr(PxTriangleMeshPtr wrp_mesh, PxMeshScalePtr wrp_scaling){
    //RET nat: PxTriangleMeshGeometryPtr, man: physx.PxTriangleMeshGeometryPtr, ret: True, kind: PtrStruct
    //PAR nat: PxTriangleMeshPtr, man: physx.PxTriangleMeshPtr, kind: PtrStruct
    //PAR nat: PxMeshScalePtr, man: physx.PxMeshScalePtr, kind: PtrStruct
    return (PxTriangleMeshGeometryPtr) new std::remove_pointer<PxTriangleMeshGeometryPtr>::type(wrp_mesh, *wrp_scaling);
}

//DEBUG: PtrStructCtorNode physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry - 102-109
ES PxTriangleMeshGeometryPtr Ctor_physx_PxTriangleMeshGeometryPtr_physx_PxTriangleMeshPtr(PxTriangleMeshPtr wrp_mesh){
    //RET nat: PxTriangleMeshGeometryPtr, man: physx.PxTriangleMeshGeometryPtr, ret: True, kind: PtrStruct
    //PAR nat: PxTriangleMeshPtr, man: physx.PxTriangleMeshPtr, kind: PtrStruct
    return (PxTriangleMeshGeometryPtr) new std::remove_pointer<PxTriangleMeshGeometryPtr>::type(wrp_mesh);
}

//DEBUG: PtrStructCtorNode physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry - 82
//ERRORS OCCURED IN physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry
//Implicit Function/Method

//DEBUG: PtrStructCtorNode physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry - 82
//ERRORS OCCURED IN physx::PxTriangleMeshGeometry::PxTriangleMeshGeometry
//Implicit Function/Method

//DEBUG: GetterSetterNode physx::PxTriangleMeshGeometry - 82-128
//Field: scale - 124-124
ES PxMeshScalePtr PxTriangleMeshGeometry_GET_scale(PxTriangleMeshGeometryPtr cls) {return (PxMeshScalePtr)&cls->scale;}
ES void PxTriangleMeshGeometry_SET_scale(PxTriangleMeshGeometryPtr cls, PxMeshScalePtr value) {cls->scale = *value;}

//DEBUG: GetterSetterNode physx::PxTriangleMeshGeometry - 82-128
//Field: meshFlags - 125-125
ES PxMeshGeometryFlagsPtr PxTriangleMeshGeometry_GET_meshFlags(PxTriangleMeshGeometryPtr cls) {return (PxMeshGeometryFlagsPtr)&cls->meshFlags;}
ES void PxTriangleMeshGeometry_SET_meshFlags(PxTriangleMeshGeometryPtr cls, PxMeshGeometryFlagsPtr value) {cls->meshFlags = *value;}

//DEBUG: GetterSetterNode physx::PxTriangleMeshGeometry - 82-128
//Field: paddingFromFlags - 126-126
ES PxPadding_intVal3Ptr PxTriangleMeshGeometry_GET_paddingFromFlags(PxTriangleMeshGeometryPtr cls) {return (PxPadding_intVal3Ptr)&cls->paddingFromFlags;}
ES void PxTriangleMeshGeometry_SET_paddingFromFlags(PxTriangleMeshGeometryPtr cls, PxPadding_intVal3Ptr value) {cls->paddingFromFlags = *value;}

//DEBUG: GetterSetterNode physx::PxTriangleMeshGeometry - 82-128
//Field: triangleMesh - 127-127
ES PxTriangleMeshPtr PxTriangleMeshGeometry_GET_triangleMesh(PxTriangleMeshGeometryPtr cls) {return (PxTriangleMeshPtr)cls->triangleMesh;}
ES void PxTriangleMeshGeometry_SET_triangleMesh(PxTriangleMeshGeometryPtr cls, PxTriangleMeshPtr value) {cls->triangleMesh = value;}

//DEBUG: MethodNode physx::PxTriangleMeshGeometry::isValid - 121
ES bool bool_const_physx_PxTriangleMeshGeometry_isValid(PxTriangleMeshGeometryPtr wrp_this){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: PxTriangleMeshGeometryPtr, man: physx.PxTriangleMeshGeometryPtr, kind: PtrStruct
    return (bool) wrp_this->isValid();
}

//DEBUG: MethodNode physx::PxTriangleMeshGeometry::operator= - 82
//ERRORS OCCURED IN physx::PxTriangleMeshGeometry::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxTriangleMeshGeometry::operator= - 82
//ERRORS OCCURED IN physx::PxTriangleMeshGeometry::operator=
//Implicit Function/Method
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxTriangleMeshGeometry::~PxTriangleMeshGeometry - 82
//ERRORS OCCURED IN physx::PxTriangleMeshGeometry::~PxTriangleMeshGeometry
//Implicit Function/Method
//Destructor

//DEBUG: DeclNode physx::PxMeshGeometryFlags - 68
// TODO DeclNode.GenWrapper()
