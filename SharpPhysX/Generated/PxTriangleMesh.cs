// Generated by minBND 5.1.91.1 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public static physx.PxTriangleMeshFlagsPtr OpPipe_New(physx.PxTriangleMeshFlagEnum a, physx.PxTriangleMeshFlagEnum b) {
        physx.PxTriangleMeshFlagEnum pvk_in_a = a;
        physx.PxTriangleMeshFlagEnum pvk_in_b = b;
        return PxTriangleMeshFlagsPtr_operator_Ptr_Pipe_PxTriangleMeshFlagEnum_PxTriangleMeshFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxTriangleMeshFlagsPtr OpAnd_New(physx.PxTriangleMeshFlagEnum a, physx.PxTriangleMeshFlagEnum b) {
        physx.PxTriangleMeshFlagEnum pvk_in_a = a;
        physx.PxTriangleMeshFlagEnum pvk_in_b = b;
        return PxTriangleMeshFlagsPtr_operator_Ptr_Amp_PxTriangleMeshFlagEnum_PxTriangleMeshFlagEnum_(pvk_in_a, pvk_in_b);
    }

    public static physx.PxTriangleMeshFlagsPtr OpTilde_New(physx.PxTriangleMeshFlagEnum a) {
        physx.PxTriangleMeshFlagEnum pvk_in_a = a;
        return PxTriangleMeshFlagsPtr_operator_Ptr_Tilde_PxTriangleMeshFlagEnum_(pvk_in_a);
    }

    public enum PxMeshMidPhaseEnum : int {
        eBVH33 = 0, // eBVH33 = 0
        eBVH34 = 1, // eBVH34 = 1
        eLAST = 2,  // eLAST
    }

    public enum PxTriangleMeshFlagEnum : int {
        e16_BIT_INDICES = 2, // e16_BIT_INDICES = (1<<1)
        eADJACENCY_INFO = 4, // eADJACENCY_INFO = (1<<2)
    }

    public unsafe partial struct PxTriangleMeshPtr : physx.PxTriangleMeshPtr.IPxTriangleMeshPtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public uint getNbVertices() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return uint_const_PxTriangleMeshPtr_getNbVerticesPtr(pvk_in_this);
        }

        public physx.PxVec3* getVertices() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return PxVec3_const_PxTriangleMeshPtr_getVerticesPtr(pvk_in_this);
        }

        public physx.PxVec3* getVerticesForModification() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return PxVec3_PxTriangleMeshPtr_getVerticesForModificationPtr(pvk_in_this);
        }

        public physx.PxBounds3 refitBVH() {
            physx.PxBounds3 RetRef;
            physx.PxTriangleMeshPtr pvk_in_this = this;
            PxBounds3_PxTriangleMeshPtr_refitBVHPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public uint getNbTriangles() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return uint_const_PxTriangleMeshPtr_getNbTrianglesPtr(pvk_in_this);
        }

        public IntPtr getTriangles() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return IntPtr_const_PxTriangleMeshPtr_getTrianglesPtr(pvk_in_this);
        }

        public physx.PxTriangleMeshFlagsPtr getTriangleMeshFlags_New() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return PxTriangleMeshFlagsPtr_const_PxTriangleMeshPtr_getTriangleMeshFlagsPtr(pvk_in_this);
        }

        public uint* getTrianglesRemap() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return uint_const_PxTriangleMeshPtr_getTrianglesRemapPtr(pvk_in_this);
        }

        public void release() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            void_PxTriangleMeshPtr_releasePtr(pvk_in_this);
        }

        public ushort getTriangleMaterialIndex(uint triangleIndex) {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            uint pvk_in_triangleIndex = triangleIndex;
            return ushort_const_PxTriangleMeshPtr_getTriangleMaterialIndexPtr_uint_(pvk_in_this, pvk_in_triangleIndex);
        }

        public physx.PxBounds3 getLocalBounds() {
            physx.PxBounds3 RetRef;
            physx.PxTriangleMeshPtr pvk_in_this = this;
            PxBounds3_const_PxTriangleMeshPtr_getLocalBoundsPtr(&RetRef, pvk_in_this);
            return RetRef;
        }

        public uint getReferenceCount() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            return uint_const_PxTriangleMeshPtr_getReferenceCountPtr(pvk_in_this);
        }

        public void acquireReference() {
            physx.PxTriangleMeshPtr pvk_in_this = this;
            void_PxTriangleMeshPtr_acquireReferencePtr(pvk_in_this);
        }

        public static implicit operator physx.PxBasePtr(PxTriangleMeshPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxTriangleMeshPtr(physx.PxBasePtr obj) => *(PxTriangleMeshPtr*)&obj;

        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}

        public unsafe interface IPxTriangleMeshPtr {
            uint getNbVertices();
            physx.PxVec3* getVertices();
            physx.PxVec3* getVerticesForModification();
            physx.PxBounds3 refitBVH();
            uint getNbTriangles();
            IntPtr getTriangles();
            physx.PxTriangleMeshFlagsPtr getTriangleMeshFlags_New();
            uint* getTrianglesRemap();
            void release();
            ushort getTriangleMaterialIndex(uint triangleIndex);
            physx.PxBounds3 getLocalBounds();
            uint getReferenceCount();
            void acquireReference();
        }
    }

    public unsafe partial struct PxBVH33TriangleMeshPtr : physx.PxTriangleMeshPtr.IPxTriangleMeshPtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public static implicit operator physx.PxTriangleMeshPtr(PxBVH33TriangleMeshPtr obj) => *(physx.PxTriangleMeshPtr*)&obj;
        public static explicit operator PxBVH33TriangleMeshPtr(physx.PxTriangleMeshPtr obj) => *(PxBVH33TriangleMeshPtr*)&obj;
        public static implicit operator physx.PxBasePtr(PxBVH33TriangleMeshPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxBVH33TriangleMeshPtr(physx.PxBasePtr obj) => *(PxBVH33TriangleMeshPtr*)&obj;

        public uint getNbVertices(){return((physx.PxTriangleMeshPtr)this).getNbVertices();}
        public physx.PxVec3* getVertices(){return((physx.PxTriangleMeshPtr)this).getVertices();}
        public physx.PxVec3* getVerticesForModification(){return((physx.PxTriangleMeshPtr)this).getVerticesForModification();}
        public physx.PxBounds3 refitBVH(){return((physx.PxTriangleMeshPtr)this).refitBVH();}
        public uint getNbTriangles(){return((physx.PxTriangleMeshPtr)this).getNbTriangles();}
        public IntPtr getTriangles(){return((physx.PxTriangleMeshPtr)this).getTriangles();}
        public physx.PxTriangleMeshFlagsPtr getTriangleMeshFlags_New(){return((physx.PxTriangleMeshPtr)this).getTriangleMeshFlags_New();}
        public uint* getTrianglesRemap(){return((physx.PxTriangleMeshPtr)this).getTrianglesRemap();}
        public void release(){((physx.PxTriangleMeshPtr)this).release();}
        public ushort getTriangleMaterialIndex(uint triangleIndex){return((physx.PxTriangleMeshPtr)this).getTriangleMaterialIndex(triangleIndex);}
        public physx.PxBounds3 getLocalBounds(){return((physx.PxTriangleMeshPtr)this).getLocalBounds();}
        public uint getReferenceCount(){return((physx.PxTriangleMeshPtr)this).getReferenceCount();}
        public void acquireReference(){((physx.PxTriangleMeshPtr)this).acquireReference();}
        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }

    public unsafe partial struct PxBVH34TriangleMeshPtr : physx.PxTriangleMeshPtr.IPxTriangleMeshPtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        public static implicit operator physx.PxTriangleMeshPtr(PxBVH34TriangleMeshPtr obj) => *(physx.PxTriangleMeshPtr*)&obj;
        public static explicit operator PxBVH34TriangleMeshPtr(physx.PxTriangleMeshPtr obj) => *(PxBVH34TriangleMeshPtr*)&obj;
        public static implicit operator physx.PxBasePtr(PxBVH34TriangleMeshPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxBVH34TriangleMeshPtr(physx.PxBasePtr obj) => *(PxBVH34TriangleMeshPtr*)&obj;

        public uint getNbVertices(){return((physx.PxTriangleMeshPtr)this).getNbVertices();}
        public physx.PxVec3* getVertices(){return((physx.PxTriangleMeshPtr)this).getVertices();}
        public physx.PxVec3* getVerticesForModification(){return((physx.PxTriangleMeshPtr)this).getVerticesForModification();}
        public physx.PxBounds3 refitBVH(){return((physx.PxTriangleMeshPtr)this).refitBVH();}
        public uint getNbTriangles(){return((physx.PxTriangleMeshPtr)this).getNbTriangles();}
        public IntPtr getTriangles(){return((physx.PxTriangleMeshPtr)this).getTriangles();}
        public physx.PxTriangleMeshFlagsPtr getTriangleMeshFlags_New(){return((physx.PxTriangleMeshPtr)this).getTriangleMeshFlags_New();}
        public uint* getTrianglesRemap(){return((physx.PxTriangleMeshPtr)this).getTrianglesRemap();}
        public void release(){((physx.PxTriangleMeshPtr)this).release();}
        public ushort getTriangleMaterialIndex(uint triangleIndex){return((physx.PxTriangleMeshPtr)this).getTriangleMaterialIndex(triangleIndex);}
        public physx.PxBounds3 getLocalBounds(){return((physx.PxTriangleMeshPtr)this).getLocalBounds();}
        public uint getReferenceCount(){return((physx.PxTriangleMeshPtr)this).getReferenceCount();}
        public void acquireReference(){((physx.PxTriangleMeshPtr)this).acquireReference();}
        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public physx.PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    }

}
