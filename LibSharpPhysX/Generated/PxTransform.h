//Generated by MinBinder.

ES physx::PxTransform C_PxTransform_PxTransform(physx::PxVec3 position){ // L58

    return physx::PxTransform::PxTransform(position);
};

ES physx::PxTransform C_PxTransform_PxTransform(physx::PxIDENTITY r){ // L62

    return physx::PxTransform::PxTransform(r);
};

ES physx::PxTransform C_PxTransform_PxTransform(physx::PxQuat orientation){ // L67

    return physx::PxTransform::PxTransform(orientation);
};

ES physx::PxTransform C_PxTransform_PxTransform(float x,float y,float z,physx::PxQuat aQ){ // L72

    return physx::PxTransform::PxTransform(x,y,z,aQ);
};

ES physx::PxTransform C_PxTransform_PxTransform(physx::PxVec3 p0,physx::PxQuat q0){ // L77

    return physx::PxTransform::PxTransform(p0,q0);
};

ES physx::PxTransform C_PxTransform_PxTransform(physx::PxMat44 m){ // L82

    return physx::PxTransform::PxTransform(m);
};

ES bool C_CONST_PxTransform_OP_EqualEqual(physx::PxTransform cls,physx::PxTransform t){ // L87

    return cls.operator==(t);
};

ES physx::PxTransform C_CONST_PxTransform_OP_Star(physx::PxTransform cls,physx::PxTransform x){ // L92

    return cls.operator*(x);
};

ES physx::PxTransform C_CONST_PxTransform_getInverse(physx::PxTransform cls){ // L105

    return cls.getInverse();
};

ES physx::PxVec3 C_CONST_PxTransform_transform(physx::PxTransform cls,physx::PxVec3 input){ // L111

    return cls.transform(input);
};

ES physx::PxVec3 C_CONST_PxTransform_transformInv(physx::PxTransform cls,physx::PxVec3 input){ // L117

    return cls.transformInv(input);
};

ES physx::PxVec3 C_CONST_PxTransform_rotate(physx::PxTransform cls,physx::PxVec3 input){ // L123

    return cls.rotate(input);
};

ES physx::PxVec3 C_CONST_PxTransform_rotateInv(physx::PxTransform cls,physx::PxVec3 input){ // L129

    return cls.rotateInv(input);
};

ES physx::PxTransform C_CONST_PxTransform_transform(physx::PxTransform cls,physx::PxTransform src){ // L136

    return cls.transform(src);
};

ES bool C_CONST_PxTransform_isValid(physx::PxTransform cls){ // L148

    return cls.isValid();
};

ES bool C_CONST_PxTransform_isSane(physx::PxTransform cls){ // L158

    return cls.isSane();
};

ES bool C_CONST_PxTransform_isFinite(physx::PxTransform cls){ // L166

    return cls.isFinite();
};

ES physx::PxTransform C_CONST_PxTransform_transformInv(physx::PxTransform cls,physx::PxTransform src){ // L172

    return cls.transformInv(src);
};

ES physx::PxPlane C_CONST_PxTransform_transform(physx::PxTransform cls,physx::PxPlane plane){ // L185

    return cls.transform(plane);
};

ES physx::PxPlane C_CONST_PxTransform_inverseTransform(physx::PxTransform cls,physx::PxPlane plane){ // L195

    return cls.inverseTransform(plane);
};

ES physx::PxTransform C_CONST_PxTransform_getNormalized(physx::PxTransform cls){ // L204

    return cls.getNormalized();
};

