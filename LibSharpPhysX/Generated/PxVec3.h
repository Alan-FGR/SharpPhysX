//Generated by MinBinder.
ES physx::PxVec3 __Star(float f, physx::PxVec3* v) // L384
{
    return physx::operator*(f, *v);    
};

ES physx::PxVec3* __REF_PxVec3__Equal(physx::PxVec3* cls, physx::PxVec3* p) // L101
{
    return &cls->operator=(*p);    
};

ES float* __REF_PxVec3__Subscript(physx::PxVec3* cls, unsigned int index) // L112
{
    return &cls->operator[](index);    
};

ES float* __REF_PxVec3__Subscript(physx::PxVec3* cls, unsigned int index) // L122
{
    return &cls->operator[](index);    
};

ES bool PxVec3__EqualEqual(physx::PxVec3* cls, physx::PxVec3* v) // L132
{
    return cls->operator==(*v);    
};

ES bool PxVec3__ExclaimEqual(physx::PxVec3* cls, physx::PxVec3* v) // L140
{
    return cls->operator!=(*v);    
};

ES bool PxVec3__isZero(physx::PxVec3* cls) // L148
{
    return cls->isZero();    
};

ES bool PxVec3__isFinite(physx::PxVec3* cls) // L156
{
    return cls->isFinite();    
};

ES bool PxVec3__isNormalized(physx::PxVec3* cls) // L164
{
    return cls->isNormalized();    
};

ES float PxVec3__magnitudeSquared(physx::PxVec3* cls) // L175
{
    return cls->magnitudeSquared();    
};

ES float PxVec3__magnitude(physx::PxVec3* cls) // L183
{
    return cls->magnitude();    
};

ES physx::PxVec3 PxVec3__Minus(physx::PxVec3* cls) // L191
{
    return cls->operator-();    
};

ES physx::PxVec3 PxVec3__Plus(physx::PxVec3* cls, physx::PxVec3* v) // L199
{
    return cls->operator+(*v);    
};

ES physx::PxVec3 PxVec3__Minus(physx::PxVec3* cls, physx::PxVec3* v) // L207
{
    return cls->operator-(*v);    
};

ES physx::PxVec3 PxVec3__Star(physx::PxVec3* cls, float f) // L215
{
    return cls->operator*(f);    
};

ES physx::PxVec3 PxVec3__Slash(physx::PxVec3* cls, float f) // L223
{
    return cls->operator/(f);    
};

ES physx::PxVec3* __REF_PxVec3__PlusEqual(physx::PxVec3* cls, physx::PxVec3* v) // L232
{
    return &cls->operator+=(*v);    
};

ES physx::PxVec3* __REF_PxVec3__MinusEqual(physx::PxVec3* cls, physx::PxVec3* v) // L243
{
    return &cls->operator-=(*v);    
};

ES physx::PxVec3* __REF_PxVec3__StarEqual(physx::PxVec3* cls, float f) // L254
{
    return &cls->operator*=(f);    
};

ES physx::PxVec3* __REF_PxVec3__SlashEqual(physx::PxVec3* cls, float f) // L264
{
    return &cls->operator/=(f);    
};

ES float PxVec3__dot(physx::PxVec3* cls, physx::PxVec3* v) // L276
{
    return cls->dot(*v);    
};

ES physx::PxVec3 PxVec3__cross(physx::PxVec3* cls, physx::PxVec3* v) // L284
{
    return cls->cross(*v);    
};

ES physx::PxVec3 PxVec3__getNormalized(physx::PxVec3* cls) // L291
{
    return cls->getNormalized();    
};

ES float PxVec3__normalize(physx::PxVec3* cls) // L300
{
    return cls->normalize();    
};

ES float PxVec3__normalizeSafe(physx::PxVec3* cls) // L312
{
    return cls->normalizeSafe();    
};

ES float PxVec3__normalizeFast(physx::PxVec3* cls) // L325
{
    return cls->normalizeFast();    
};

ES physx::PxVec3 PxVec3__multiply(physx::PxVec3* cls, physx::PxVec3* a) // L336
{
    return cls->multiply(*a);    
};

ES physx::PxVec3 PxVec3__minimum(physx::PxVec3* cls, physx::PxVec3* v) // L344
{
    return cls->minimum(*v);    
};

ES float PxVec3__minElement(physx::PxVec3* cls) // L352
{
    return cls->minElement();    
};

ES physx::PxVec3 PxVec3__maximum(physx::PxVec3* cls, physx::PxVec3* v) // L360
{
    return cls->maximum(*v);    
};

ES float PxVec3__maxElement(physx::PxVec3* cls) // L368
{
    return cls->maxElement();    
};

ES physx::PxVec3 PxVec3__abs(physx::PxVec3* cls) // L376
{
    return cls->abs();    
};
