// Generated by minBND 5.1.94.90 - © github.com/Alan-FGR

ES void void_PxRigidActorPtr_releasePtr(PxRigidActorPtr wrp_this){
    wrp_this->release();
}

ES void PxTransform_const_PxRigidActorPtr_getGlobalPosePtr(physx::PxTransform* nRetRef, PxRigidActorPtr wrp_this){
    *nRetRef = wrp_this->getGlobalPose();
}

ES void void_PxRigidActorPtr_setGlobalPosePtr_PxTransform_bool_(PxRigidActorPtr wrp_this, physx::PxTransform* wrp_pose, bool wrp_autowake){
    wrp_this->setGlobalPose(*wrp_pose, wrp_autowake);
}

ES bool bool_PxRigidActorPtr_attachShapePtr_PxShapePtr_(PxRigidActorPtr wrp_this, PxShapePtr wrp_shape){
    return (bool) wrp_this->attachShape(*wrp_shape);
}

ES void void_PxRigidActorPtr_detachShapePtr_PxShapePtr_bool_(PxRigidActorPtr wrp_this, PxShapePtr wrp_shape, bool wrp_wakeOnLostTouch){
    wrp_this->detachShape(*wrp_shape, wrp_wakeOnLostTouch);
}

ES PxU32 uint_const_PxRigidActorPtr_getNbShapesPtr(PxRigidActorPtr wrp_this){
    return (PxU32) wrp_this->getNbShapes();
}

ES PxU32 uint_const_PxRigidActorPtr_getShapesPtr_PxShapePtr_uint_uint_(PxRigidActorPtr wrp_this, PxShapePtr* wrp_userBuffer, PxU32 wrp_bufferSize, PxU32 wrp_startIndex){
    return (PxU32) wrp_this->getShapes(wrp_userBuffer, wrp_bufferSize, wrp_startIndex);
}

ES PxU32 uint_const_PxRigidActorPtr_getNbConstraintsPtr(PxRigidActorPtr wrp_this){
    return (PxU32) wrp_this->getNbConstraints();
}

ES PxU32 uint_const_PxRigidActorPtr_getConstraintsPtr_PxConstraintPtr_uint_uint_(PxRigidActorPtr wrp_this, PxConstraintPtr* wrp_userBuffer, PxU32 wrp_bufferSize, PxU32 wrp_startIndex){
    return (PxU32) wrp_this->getConstraints(wrp_userBuffer, wrp_bufferSize, wrp_startIndex);
}

ES void void_PxRigidActorPtr_setGlobalPosePtr_PxTransform_(PxRigidActorPtr wrp_this, physx::PxTransform* wrp_pose){
    wrp_this->setGlobalPose(*wrp_pose);
}

ES void void_PxRigidActorPtr_detachShapePtr_PxShapePtr_(PxRigidActorPtr wrp_this, PxShapePtr wrp_shape){
    wrp_this->detachShape(*wrp_shape);
}

ES PxU32 uint_const_PxRigidActorPtr_getShapesPtr_PxShapePtr_uint_(PxRigidActorPtr wrp_this, PxShapePtr* wrp_userBuffer, PxU32 wrp_bufferSize){
    return (PxU32) wrp_this->getShapes(wrp_userBuffer, wrp_bufferSize);
}

ES PxU32 uint_const_PxRigidActorPtr_getConstraintsPtr_PxConstraintPtr_uint_(PxRigidActorPtr wrp_this, PxConstraintPtr* wrp_userBuffer, PxU32 wrp_bufferSize){
    return (PxU32) wrp_this->getConstraints(wrp_userBuffer, wrp_bufferSize);
}

