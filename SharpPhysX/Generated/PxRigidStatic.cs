// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public unsafe partial struct PxRigidStaticPtr : physx.PxRigidActorPtr.IPxRigidActorPtr, physx.PxActorPtr.IPxActorPtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public string getConcreteTypeName() {
            physx.PxRigidStaticPtr pvk_in_this = this;
            return string_const_PxRigidStaticPtr_getConcreteTypeNamePtr(pvk_in_this);
        }

        public static implicit operator physx.PxRigidActorPtr(PxRigidStaticPtr obj) => *(physx.PxRigidActorPtr*)&obj;
        public static explicit operator PxRigidStaticPtr(physx.PxRigidActorPtr obj) => *(PxRigidStaticPtr*)&obj;
        public static implicit operator physx.PxActorPtr(PxRigidStaticPtr obj) => *(physx.PxActorPtr*)&obj;
        public static explicit operator PxRigidStaticPtr(physx.PxActorPtr obj) => *(PxRigidStaticPtr*)&obj;
        public static implicit operator physx.PxBasePtr(PxRigidStaticPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxRigidStaticPtr(physx.PxBasePtr obj) => *(PxRigidStaticPtr*)&obj;

        public IntPtr userData {
            get => PxActorPtr_GET_userData(this);
            set => PxActorPtr_SET_userData(this, value);
        }

        public void release(){((physx.PxRigidActorPtr)this).release();}
        public physx.PxTransform getGlobalPose(){return((physx.PxRigidActorPtr)this).getGlobalPose();}
        public void setGlobalPose(physx.PxTransform* pose, bool autowake=true){((physx.PxRigidActorPtr)this).setGlobalPose(pose, autowake);}
        public bool attachShape(physx.PxShapePtr shape){return((physx.PxRigidActorPtr)this).attachShape(shape);}
        public void detachShape(physx.PxShapePtr shape, bool wakeOnLostTouch=true){((physx.PxRigidActorPtr)this).detachShape(shape, wakeOnLostTouch);}
        public uint getNbShapes(){return((physx.PxRigidActorPtr)this).getNbShapes();}
        public uint getShapes(physx.PxShapePtr* userBuffer, uint bufferSize, uint startIndex=0){return((physx.PxRigidActorPtr)this).getShapes(userBuffer, bufferSize, startIndex);}
        public uint getNbConstraints(){return((physx.PxRigidActorPtr)this).getNbConstraints();}
        public uint getConstraints(physx.PxConstraintPtr* userBuffer, uint bufferSize, uint startIndex=0){return((physx.PxRigidActorPtr)this).getConstraints(userBuffer, bufferSize, startIndex);}
        public void setGlobalPose(physx.PxTransform pose){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)&pose);}
        public void setGlobalPose(physx.PxTransform.Ref pose){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)(*((IntPtr*)(&pose))));}
        public void setGlobalPose(physx.PxTransform* pose){((physx.PxRigidActorPtr)this).setGlobalPose(pose);}
        public void setGlobalPose(physx.PxTransform pose, bool autowake=true){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)&pose, autowake);}
        public void setGlobalPose(physx.PxTransform.Ref pose, bool autowake=true){((physx.PxRigidActorPtr)this).setGlobalPose((physx.PxTransform*)(*((IntPtr*)(&pose))), autowake);}
        public void detachShape(physx.PxShapePtr shape){((physx.PxRigidActorPtr)this).detachShape(shape);}
        public uint getShapes(physx.PxShapePtr* userBuffer, uint bufferSize){return((physx.PxRigidActorPtr)this).getShapes(userBuffer, bufferSize);}
        public uint getConstraints(physx.PxConstraintPtr* userBuffer, uint bufferSize){return((physx.PxRigidActorPtr)this).getConstraints(userBuffer, bufferSize);}
        public physx.PxActorTypeEnum getType(){return((physx.PxActorPtr)this).getType();}
        public physx.PxScenePtr getScene(){return((physx.PxActorPtr)this).getScene();}
        public void setName(string name){((physx.PxActorPtr)this).setName(name);}
        public string getName(){return((physx.PxActorPtr)this).getName();}
        public physx.PxBounds3 getWorldBounds(float inflation=1.01f){return((physx.PxActorPtr)this).getWorldBounds(inflation);}
        public void setActorFlag(physx.PxActorFlagEnum flag, bool value){((physx.PxActorPtr)this).setActorFlag(flag, value);}
        public void setActorFlags(physx.PxActorFlagsPtr inFlags){((physx.PxActorPtr)this).setActorFlags(inFlags);}
        public physx.PxActorFlagsPtr getActorFlags_New(){return((physx.PxActorPtr)this).getActorFlags_New();}
        public void setDominanceGroup(byte dominanceGroup){((physx.PxActorPtr)this).setDominanceGroup(dominanceGroup);}
        public byte getDominanceGroup(){return((physx.PxActorPtr)this).getDominanceGroup();}
        public void setOwnerClient(byte inClient){((physx.PxActorPtr)this).setOwnerClient(inClient);}
        public byte getOwnerClient(){return((physx.PxActorPtr)this).getOwnerClient();}
        public physx.PxAggregatePtr getAggregate(){return((physx.PxActorPtr)this).getAggregate();}
        public physx.PxBounds3 getWorldBounds(){return((physx.PxActorPtr)this).getWorldBounds();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }
}
