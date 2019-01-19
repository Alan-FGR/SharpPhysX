//Generated by MinBinder.

ES void C_PxShape_release(physx::PxShape cls){ // L156

    return cls.release();
}

ES physx::PxU32 C_CONST_PxShape_getReferenceCount(physx::PxShape cls){ // L166

    return cls.getReferenceCount();
}

ES void C_PxShape_acquireReference(physx::PxShape cls){ // L173

    return cls.acquireReference();
}

ES physx::PxGeometryType::Enum C_CONST_PxShape_getGeometryType(physx::PxShape cls){ // L182

    return cls.getGeometryType();
}

ES void C_PxShape_setGeometry(physx::PxShape cls,physx::PxGeometry* geometry){ // L195

    return cls.setGeometry(*geometry);
}

ES physx::PxGeometryHolder C_CONST_PxShape_getGeometry(physx::PxShape cls){ // L206

    return cls.getGeometry();
}

ES bool C_CONST_PxShape_getBoxGeometry(physx::PxShape cls,physx::PxBoxGeometry* geometry){ // L220

    return cls.getBoxGeometry(*geometry);
}

ES bool C_CONST_PxShape_getSphereGeometry(physx::PxShape cls,physx::PxSphereGeometry* geometry){ // L233

    return cls.getSphereGeometry(*geometry);
}

ES bool C_CONST_PxShape_getCapsuleGeometry(physx::PxShape cls,physx::PxCapsuleGeometry* geometry){ // L246

    return cls.getCapsuleGeometry(*geometry);
}

ES bool C_CONST_PxShape_getPlaneGeometry(physx::PxShape cls,physx::PxPlaneGeometry* geometry){ // L259

    return cls.getPlaneGeometry(*geometry);
}

ES bool C_CONST_PxShape_getConvexMeshGeometry(physx::PxShape cls,physx::PxConvexMeshGeometry* geometry){ // L272

    return cls.getConvexMeshGeometry(*geometry);
}

ES bool C_CONST_PxShape_getTriangleMeshGeometry(physx::PxShape cls,physx::PxTriangleMeshGeometry* geometry){ // L285

    return cls.getTriangleMeshGeometry(*geometry);
}

ES bool C_CONST_PxShape_getHeightFieldGeometry(physx::PxShape cls,physx::PxHeightFieldGeometry* geometry){ // L299

    return cls.getHeightFieldGeometry(*geometry);
}

ES physx::PxRigidActor C_CONST_PxShape_getActor(physx::PxShape cls){ // L308

    return cls.getActor();
}

ES void C_PxShape_setLocalPose(physx::PxShape cls,physx::PxTransform* pose){ // L335

    return cls.setLocalPose(*pose);
}

ES physx::PxTransform C_CONST_PxShape_getLocalPose(physx::PxShape cls){ // L346

    return cls.getLocalPose();
}

ES void C_PxShape_setSimulationFilterData(physx::PxShape cls,physx::PxFilterData data){ // L365

    return cls.setSimulationFilterData(data);
}

ES physx::PxFilterData C_CONST_PxShape_getSimulationFilterData(physx::PxShape cls){ // L372

    return cls.getSimulationFilterData();
}

ES void C_PxShape_setQueryFilterData(physx::PxShape cls,physx::PxFilterData data){ // L381

    return cls.setQueryFilterData(data);
}

ES physx::PxFilterData C_CONST_PxShape_getQueryFilterData(physx::PxShape cls){ // L388

    return cls.getQueryFilterData();
}

ES void C_PxShape_setMaterials(physx::PxShape cls,physx::PxMaterial* materials,physx::PxU16 materialCount){ // L403

    return cls.setMaterials(materials,materialCount);
}

ES physx::PxU16 C_CONST_PxShape_getNbMaterials(physx::PxShape cls){ // L414

    return cls.getNbMaterials();
}

ES physx::PxU32 C_CONST_PxShape_getMaterials(physx::PxShape cls,physx::PxMaterial* userBuffer,physx::PxU32 bufferSize,physx::PxU32 startIndex){ // L430

    return cls.getMaterials(userBuffer,bufferSize,startIndex);
}

ES physx::PxMaterial C_CONST_PxShape_getMaterialFromInternalFaceIndex(physx::PxShape cls,physx::PxU32 faceIndex){ // L450

    return cls.getMaterialFromInternalFaceIndex(faceIndex);
}

ES void C_PxShape_setContactOffset(physx::PxShape cls,physx::PxReal contactOffset){ // L468

    return cls.setContactOffset(contactOffset);
}

ES physx::PxReal C_CONST_PxShape_getContactOffset(physx::PxShape cls){ // L477

    return cls.getContactOffset();
}

ES void C_PxShape_setRestOffset(physx::PxShape cls,physx::PxReal restOffset){ // L494

    return cls.setRestOffset(restOffset);
}

ES physx::PxReal C_CONST_PxShape_getRestOffset(physx::PxShape cls){ // L503

    return cls.getRestOffset();
}

ES void C_PxShape_setTorsionalPatchRadius(physx::PxShape cls,physx::PxReal radius){ // L517

    return cls.setTorsionalPatchRadius(radius);
}

ES physx::PxReal C_CONST_PxShape_getTorsionalPatchRadius(physx::PxShape cls){ // L529

    return cls.getTorsionalPatchRadius();
}

ES void C_PxShape_setMinTorsionalPatchRadius(physx::PxShape cls,physx::PxReal radius){ // L542

    return cls.setMinTorsionalPatchRadius(radius);
}

ES physx::PxReal C_CONST_PxShape_getMinTorsionalPatchRadius(physx::PxShape cls){ // L554

    return cls.getMinTorsionalPatchRadius();
}

ES void C_PxShape_setFlag(physx::PxShape cls,physx::PxShapeFlag::Enum flag,bool value){ // L571

    return cls.setFlag(flag,value);
}

ES void C_PxShape_setFlags(physx::PxShape cls,physx::PxShapeFlags inFlags){ // L578

    return cls.setFlags(inFlags);
}

ES physx::PxShapeFlags C_CONST_PxShape_getFlags(physx::PxShape cls){ // L587

    return cls.getFlags();
}

ES bool C_CONST_PxShape_isExclusive(physx::PxShape cls){ // L594

    return cls.isExclusive();
}

ES void C_PxShape_setName(physx::PxShape cls,const char* name){ // L608

    return cls.setName(name);
}

ES const char* C_CONST_PxShape_getName(physx::PxShape cls){ // L617

    return cls.getName();
}

ES const char* C_CONST_PxShape_getConcreteTypeName(physx::PxShape cls){ // L620

    return cls.getConcreteTypeName();
}

ES physx::PxShape C_PxShape_PxShape(physx::PxBaseFlags baseFlags){ // L627

    return physx::PxShape::PxShape(baseFlags);
}

ES physx::PxShape C_PxShape_PxShape(physx::PxType concreteType,physx::PxBaseFlags baseFlags){ // L628

    return physx::PxShape::PxShape(concreteType,baseFlags);
}

ES bool C_CONST_PxShape_isKindOf(physx::PxShape cls,const char* name){ // L630

    return cls.isKindOf(name);
}

