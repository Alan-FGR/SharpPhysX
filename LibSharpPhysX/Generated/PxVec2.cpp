// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//DEBUG: NamespaceNode physx - 40-343
//DEBUG: FunctionNode physx::operator* - 337-340
//Internal Op

//DEBUG: ClassNode physx::PxVec2 - 49-335
//DEBUG: DefaulterNode physx::PxVec2::PxVec2 - 55-57
ES void Default_physx_PxVec2_(physx::PxVec2* RetRef){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    *RetRef = *RetRef = physx::PxVec2();
}

//DEBUG: BlittableCtorNode physx::PxVec2::PxVec2 - 62-65
ES void void_physx_PxVec2_PxVec2_Ctor_physx_PxZERO_(physx::PxVec2* wrp_this, physx::PxZERO wrp_r){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxZERO, man: physx.PxZERO, kind: Value
    *wrp_this = physx::PxVec2::PxVec2(wrp_r);
}

//DEBUG: BlittableCtorNode physx::PxVec2::PxVec2 - 74-76
ES void void_physx_PxVec2_PxVec2_Ctor_float_(physx::PxVec2* wrp_this, float wrp_a){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: float, man: float, kind: Value
    *wrp_this = physx::PxVec2::PxVec2(wrp_a);
}

//DEBUG: BlittableCtorNode physx::PxVec2::PxVec2 - 84-86
ES void void_physx_PxVec2_PxVec2_Ctor_float_float_(physx::PxVec2* wrp_this, float wrp_nx, float wrp_ny){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: float, man: float, kind: Value
    //PAR nat: float, man: float, kind: Value
    *wrp_this = physx::PxVec2::PxVec2(wrp_nx, wrp_ny);
}

//DEBUG: BlittableCtorNode physx::PxVec2::PxVec2 - 91-93
ES void void_physx_PxVec2_PxVec2_Ctor_physx_PxVec2_(physx::PxVec2* wrp_this, physx::PxVec2* wrp_v){
    //RET nat: void, man: void, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    *wrp_this = physx::PxVec2::PxVec2(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::operator= - 100-105
//ERRORS OCCURED IN physx::PxVec2::operator=
//Unbindable Operator: Equal

//DEBUG: MethodNode physx::PxVec2::operator[] - 110-115
//ERRORS OCCURED IN physx::PxVec2::operator[]
//Unbindable Operator: Subscript

//DEBUG: MethodNode physx::PxVec2::operator[] - 120-125
//ERRORS OCCURED IN physx::PxVec2::operator[]
//Unbindable Operator: Subscript

//DEBUG: MethodNode physx::PxVec2::operator== - 130-133
ES bool bool_const_physx_PxVec2_operator_EqualEqual_physx_PxVec2_(physx::PxVec2* wrp_lhs, physx::PxVec2* wrp_v){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    return (bool) wrp_lhs->operator==(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::operator!= - 138-141
ES bool bool_const_physx_PxVec2_operator_ExclaimEqual_physx_PxVec2_(physx::PxVec2* wrp_lhs, physx::PxVec2* wrp_v){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    return (bool) wrp_lhs->operator!=(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::isZero - 146-149
ES bool bool_const_physx_PxVec2_isZero(physx::PxVec2* wrp_this){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (bool) wrp_this->isZero();
}

//DEBUG: MethodNode physx::PxVec2::isFinite - 154-157
ES bool bool_const_physx_PxVec2_isFinite(physx::PxVec2* wrp_this){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (bool) wrp_this->isFinite();
}

//DEBUG: MethodNode physx::PxVec2::isNormalized - 162-166
ES bool bool_const_physx_PxVec2_isNormalized(physx::PxVec2* wrp_this){
    //RET nat: bool, man: bool, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (bool) wrp_this->isNormalized();
}

//DEBUG: MethodNode physx::PxVec2::magnitudeSquared - 173-176
ES float float_const_physx_PxVec2_magnitudeSquared(physx::PxVec2* wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (float) wrp_this->magnitudeSquared();
}

//DEBUG: MethodNode physx::PxVec2::magnitude - 181-184
ES float float_const_physx_PxVec2_magnitude(physx::PxVec2* wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (float) wrp_this->magnitude();
}

//DEBUG: MethodNode physx::PxVec2::operator- - 189-192
ES void physx_PxVec2_const_physx_PxVec2_operator_Minus(physx::PxVec2* RetRef, physx::PxVec2* wrp_lhs){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    *RetRef = wrp_lhs->operator-();
}

//DEBUG: MethodNode physx::PxVec2::operator+ - 197-200
ES void physx_PxVec2_const_physx_PxVec2_operator_Plus_physx_PxVec2_(physx::PxVec2* RetRef, physx::PxVec2* wrp_lhs, physx::PxVec2* wrp_v){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    *RetRef = wrp_lhs->operator+(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::operator- - 205-208
ES void physx_PxVec2_const_physx_PxVec2_operator_Minus_physx_PxVec2_(physx::PxVec2* RetRef, physx::PxVec2* wrp_lhs, physx::PxVec2* wrp_v){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    *RetRef = wrp_lhs->operator-(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::operator* - 213-216
ES void physx_PxVec2_const_physx_PxVec2_operator_Star_float_(physx::PxVec2* RetRef, physx::PxVec2* wrp_lhs, float wrp_f){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: float, man: float, kind: Value
    *RetRef = wrp_lhs->operator*(wrp_f);
}

//DEBUG: MethodNode physx::PxVec2::operator/ - 221-225
ES void physx_PxVec2_const_physx_PxVec2_operator_Slash_float_(physx::PxVec2* RetRef, physx::PxVec2* wrp_lhs, float wrp_f){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: float, man: float, kind: Value
    *RetRef = wrp_lhs->operator/(wrp_f);
}

//DEBUG: MethodNode physx::PxVec2::operator+= - 230-235
//ERRORS OCCURED IN physx::PxVec2::operator+=
//Unbindable Operator: PlusEqual

//DEBUG: MethodNode physx::PxVec2::operator-= - 240-245
//ERRORS OCCURED IN physx::PxVec2::operator-=
//Unbindable Operator: MinusEqual

//DEBUG: MethodNode physx::PxVec2::operator*= - 250-255
//ERRORS OCCURED IN physx::PxVec2::operator*=
//Unbindable Operator: StarEqual

//DEBUG: MethodNode physx::PxVec2::operator/= - 259-265
//ERRORS OCCURED IN physx::PxVec2::operator/=
//Unbindable Operator: SlashEqual

//DEBUG: MethodNode physx::PxVec2::dot - 270-273
ES float float_const_physx_PxVec2_dot_physx_PxVec2_(physx::PxVec2* wrp_this, physx::PxVec2* wrp_v){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    return (float) wrp_this->dot(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::getNormalized - 277-281
ES void physx_PxVec2_const_physx_PxVec2_getNormalized(physx::PxVec2* RetRef, physx::PxVec2* wrp_this){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    *RetRef = wrp_this->getNormalized();
}

//DEBUG: MethodNode physx::PxVec2::normalize - 286-292
ES float float_physx_PxVec2_normalize(physx::PxVec2* wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (float) wrp_this->normalize();
}

//DEBUG: MethodNode physx::PxVec2::multiply - 297-300
ES void physx_PxVec2_const_physx_PxVec2_multiply_physx_PxVec2_(physx::PxVec2* RetRef, physx::PxVec2* wrp_this, physx::PxVec2* wrp_a){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    *RetRef = wrp_this->multiply(*wrp_a);
}

//DEBUG: MethodNode physx::PxVec2::minimum - 305-308
ES void physx_PxVec2_const_physx_PxVec2_minimum_physx_PxVec2_(physx::PxVec2* RetRef, physx::PxVec2* wrp_this, physx::PxVec2* wrp_v){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    *RetRef = wrp_this->minimum(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::minElement - 313-316
ES float float_const_physx_PxVec2_minElement(physx::PxVec2* wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (float) wrp_this->minElement();
}

//DEBUG: MethodNode physx::PxVec2::maximum - 321-324
ES void physx_PxVec2_const_physx_PxVec2_maximum_physx_PxVec2_(physx::PxVec2* RetRef, physx::PxVec2* wrp_this, physx::PxVec2* wrp_v){
    //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
    *RetRef = wrp_this->maximum(*wrp_v);
}

//DEBUG: MethodNode physx::PxVec2::maxElement - 329-332
ES float float_const_physx_PxVec2_maxElement(physx::PxVec2* wrp_this){
    //RET nat: float, man: float, ret: True, kind: Value
    //PAR nat: physx::PxVec2, man: physx.PxVec2, kind: Blittable
    return (float) wrp_this->maxElement();
}

//DEBUG: MethodNode physx::PxVec2::~PxVec2 - 49
//ERRORS OCCURED IN physx::PxVec2::~PxVec2
//Implicit Function/Method
//Destructor
    //DEBUG: ExternalOpNode physx::operator* - 337-340
    ES void physx_PxVec2_physx_operator_Star_float_physx_PxVec2_(physx::PxVec2* RetRef, float wrp_f, physx::PxVec2* wrp_v){
        //RET nat: physx::PxVec2, man: physx.PxVec2, ret: False, kind: Blittable
        //PAR nat: float, man: float, kind: Value
        //PAR nat: physx::PxVec2*, man: physx.PxVec2*, kind: Value
        *RetRef = operator*(wrp_f, *wrp_v);
    }
