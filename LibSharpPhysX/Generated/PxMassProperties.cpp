// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
//Subclasses using this: 0

//DBG: ClassNode PxMassProperties physx::PxMassProperties L63-327

//DBG: NewerFreerNode PxMassProperties physx::PxMassProperties L63-327
ES void Freer_physx_PxMassPropertiesPtr(PxMassPropertiesPtr ptr){
    delete ptr;
}

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L69
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
ES PxMassPropertiesPtr Ctor_PxMassPropertiesPtr_(){
    auto ret = *(new std::remove_pointer<PxMassPropertiesPtr>::type());
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L74
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: PxReal, man: float, kind: Value
//PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
//PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
ES PxMassPropertiesPtr Ctor_PxMassPropertiesPtr_float_PxMat33_PxVec3_(PxReal wrp_m, physx::PxMat33* wrp_inertiaT, physx::PxVec3* wrp_com){
    auto ret = *(new std::remove_pointer<PxMassPropertiesPtr>::type(wrp_m, *wrp_inertiaT, *wrp_com));
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L83-157
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxGeometry*, man: physx.PxGeometry*, kind: Value
ES PxMassPropertiesPtr Ctor_PxMassPropertiesPtr_PxGeometry_(physx::PxGeometry* wrp_geometry){
    auto ret = *(new std::remove_pointer<PxMassPropertiesPtr>::type(*wrp_geometry));
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L63
//ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L63

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L63
//ERRORS in PtrWrapperCtorNode: Skipping Implicit PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L63

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L74
//Value Converter New
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: PxReal, man: float, kind: Value
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L74
//Value Converter New
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: PxReal, man: float, kind: Value
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L83-157
//Value Converter New
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxGeometry, man: physx.PxGeometry, kind: Blittable

//DBG: PtrWrapperCtorNode physx::PxMassProperties::PxMassProperties L83-157
//Value Converter New
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: physx::PxGeometry, man: physx.PxGeometry, kind: Blittable

//DBG: Field: inertiaTensor - 324-324
ES void PxMassPropertiesPtr_GET_inertiaTensor(PxMassPropertiesPtr cls, physx::PxMat33* GetRetRef) {*GetRetRef = cls->inertiaTensor;}
ES void PxMassPropertiesPtr_SET_inertiaTensor(PxMassPropertiesPtr cls, physx::PxMat33 value) {cls->inertiaTensor = value;}

//DBG: Field: centerOfMass - 325-325
ES void PxMassPropertiesPtr_GET_centerOfMass(PxMassPropertiesPtr cls, physx::PxVec3* GetRetRef) {*GetRetRef = cls->centerOfMass;}
ES void PxMassPropertiesPtr_SET_centerOfMass(PxMassPropertiesPtr cls, physx::PxVec3 value) {cls->centerOfMass = value;}

//DBG: Field: mass - 326-326
ES PxReal PxMassPropertiesPtr_GET_mass(PxMassPropertiesPtr cls) {return (PxReal)cls->mass;}
ES void PxMassPropertiesPtr_SET_mass(PxMassPropertiesPtr cls, PxReal value) {cls->mass = value;}

//DBG: MethodNode physx::PxMassProperties::operator* L165-170
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
//PAR nat: PxReal, man: float, kind: Value
ES PxMassPropertiesPtr PxMassPropertiesPtr_const_PxMassPropertiesPtr_operator_Ptr_Star_floatC(PxMassPropertiesPtr wrp_lhs, PxReal wrp_scale){
    auto ret = wrp_lhs->::physx::PxMassProperties::operator*(wrp_scale);
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

//DBG: MethodNode physx::PxMassProperties::translate L177-186
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
//PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
ES void void_PxMassPropertiesPtr_translatePtr_PxVec3_(PxMassPropertiesPtr wrp_this, physx::PxVec3* wrp_t){
    wrp_this->translate(*wrp_t);
}

//DBG: MethodNode physx::PxMassProperties::operator= L63
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxMassProperties::operator= L63

//DBG: MethodNode physx::PxMassProperties::~PxMassProperties L63
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxMassProperties::~PxMassProperties L63, Destructor

//DBG: MethodNode physx::PxMassProperties::operator= L63
//ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxMassProperties::operator= L63

//DBG: MethodNode physx::PxMassProperties::translate L177-186
//Value Converter translate
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//DBG: MethodNode physx::PxMassProperties::translate L177-186
//Value Converter translate
//RET nat: void, man: void, ret: True, kind: Value
//PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::getMassSpaceInertia L195-203
//RET nat: physx::PxVec3, man: physx.PxVec3, ret: False, kind: Blittable
//PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
//PAR nat: physx::PxQuat*, man: physx.PxQuat*, kind: Value
ES void PxVec3_PxMassPropertiesPtr_getMassSpaceInertiaPtr_PxMat33_PxQuat_(physx::PxVec3* nRetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_massFrame){
    *nRetRef = ::physx::PxMassProperties::getMassSpaceInertia(*wrp_inertia, *wrp_massFrame);
}

//DBG: FunctionNode physx::PxMassProperties::translateInertia L213-226
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
//PAR nat: PxReal, man: float, kind: Value
//PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
ES void PxMat33_PxMassPropertiesPtr_translateInertiaPtr_PxMat33_float_PxVec3_C_(physx::PxMat33* nRetRef, physx::PxMat33* wrp_inertia, PxReal wrp_mass, physx::PxVec3* wrp_t){
    *nRetRef = ::physx::PxMassProperties::translateInertia(*wrp_inertia, wrp_mass, *wrp_t);
}

//DBG: FunctionNode physx::PxMassProperties::rotateInertia L235-244
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
//PAR nat: physx::PxQuat*, man: physx.PxQuat*, kind: Value
ES void PxMat33_PxMassPropertiesPtr_rotateInertiaPtr_PxMat33_PxQuat_(physx::PxMat33* nRetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_q){
    *nRetRef = ::physx::PxMassProperties::rotateInertia(*wrp_inertia, *wrp_q);
}

//DBG: FunctionNode physx::PxMassProperties::scaleInertia L254-281
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33*, man: physx.PxMat33*, kind: Value
//PAR nat: physx::PxQuat*, man: physx.PxQuat*, kind: Value
//PAR nat: physx::PxVec3*, man: physx.PxVec3*, kind: Value
ES void PxMat33_PxMassPropertiesPtr_scaleInertiaPtr_PxMat33_PxQuat_PxVec3_(physx::PxMat33* nRetRef, physx::PxMat33* wrp_inertia, physx::PxQuat* wrp_scaleRotation, physx::PxVec3* wrp_scale){
    *nRetRef = ::physx::PxMassProperties::scaleInertia(*wrp_inertia, *wrp_scaleRotation, *wrp_scale);
}

//DBG: FunctionNode physx::PxMassProperties::sum L291-321
//RET nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, ret: True, kind: PtrStruct
//PAR nat: PxMassPropertiesPtr, man: physx.PxMassPropertiesPtr, kind: PtrStruct
//PAR nat: physx::PxTransform*, man: physx.PxTransform*, kind: Value
//PAR nat: PxU32, man: uint, kind: Value
ES PxMassPropertiesPtr PxMassPropertiesPtr_PxMassPropertiesPtr_sumPtr_PxMassPropertiesPtr_PxTransform_uint_C(PxMassPropertiesPtr wrp_props, physx::PxTransform* wrp_transforms, PxU32 wrp_count){
    auto ret = ::physx::PxMassProperties::sum(wrp_props, wrp_transforms, wrp_count);
    auto heap = new char[sizeof PxMassProperties];
    std::memcpy(heap, &ret, sizeof PxMassProperties);
    return (PxMassPropertiesPtr) heap;
}

//DBG: FunctionNode physx::PxMassProperties::getMassSpaceInertia L195-203
//Value Converter getMassSpaceInertia
//RET nat: physx::PxVec3, man: physx.PxVec3, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxQuat, man: physx.PxQuat, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::getMassSpaceInertia L195-203
//Value Converter getMassSpaceInertia
//RET nat: physx::PxVec3, man: physx.PxVec3, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxQuat, man: physx.PxQuat, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::translateInertia L213-226
//Value Converter translateInertia
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: PxReal, man: float, kind: Value
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::translateInertia L213-226
//Value Converter translateInertia
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: PxReal, man: float, kind: Value
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::rotateInertia L235-244
//Value Converter rotateInertia
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxQuat, man: physx.PxQuat, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::rotateInertia L235-244
//Value Converter rotateInertia
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxQuat, man: physx.PxQuat, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::scaleInertia L254-281
//Value Converter scaleInertia
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxQuat, man: physx.PxQuat, kind: Blittable
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//DBG: FunctionNode physx::PxMassProperties::scaleInertia L254-281
//Value Converter scaleInertia
//RET nat: physx::PxMat33, man: physx.PxMat33, ret: False, kind: Blittable
//PAR nat: physx::PxMat33, man: physx.PxMat33, kind: Blittable
//PAR nat: physx::PxQuat, man: physx.PxQuat, kind: Blittable
//PAR nat: physx::PxVec3, man: physx.PxVec3, kind: Blittable

//Operators
