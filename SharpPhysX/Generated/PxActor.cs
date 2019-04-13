// Generated by minBND 5.1.81.43 - © github.com/Alan-FGR
//Unit PxActor
using System;
using System.Runtime.InteropServices;

public static unsafe partial class physx {
    // physx::operator| [static PxActorFlagsPtr Pipe_New(physx.PxActorFlagEnum a, physx.PxActorFlagEnum b)] will be bound as member operator
    
    // physx::operator& [static PxActorFlagsPtr Amp_New(physx.PxActorFlagEnum a, physx.PxActorFlagEnum b)] will be bound as member operator
    
    // physx::operator~ [static PxActorFlagsPtr Tilde_New(physx.PxActorFlagEnum a)] will be bound as member operator
    
    public enum PxActorFlagEnum : int {
        eVISUALIZATION = 1,       // eVISUALIZATION = (1<<0)
        eDISABLE_GRAVITY = 2,     // eDISABLE_GRAVITY = (1<<1)
        eSEND_SLEEP_NOTIFIES = 4, // eSEND_SLEEP_NOTIFIES = (1<<2)
        eDISABLE_SIMULATION = 8,  // eDISABLE_SIMULATION = (1<<3)
    }
    
    public enum PxActorTypeEnum : int {
        eRIGID_STATIC = 0,               // eRIGID_STATIC
        eRIGID_DYNAMIC = 1,              // eRIGID_DYNAMIC
        eARTICULATION_LINK = 2,          // eARTICULATION_LINK
        eACTOR_COUNT = 3,                // eACTOR_COUNT
        eACTOR_FORCE_DWORD = 2147483647, // eACTOR_FORCE_DWORD = 0x7fffffff
    }
    
    public unsafe partial struct PxActorPtr : physx.PxActorPtr.IPxActorPtr, physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;
        
    [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr PxActor_GET_userData(PxActorPtr cls);
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void PxActor_SET_userData(PxActorPtr cls, IntPtr value);
        
        public IntPtr userData {
            get => PxActor_GET_userData(this);
            set => PxActor_SET_userData(this, value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxActor_release(physx.PxActorPtr pvk_this);
        
        public void release() {
            physx.PxActorPtr pvk_in_this = this;
            void_physx_PxActor_release(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxActorTypeEnum physx_PxActorTypeEnum_const_physx_PxActor_getType(physx.PxActorPtr pvk_this);
        
        public physx.PxActorTypeEnum getType() {
            physx.PxActorPtr pvk_in_this = this;
            return physx_PxActorTypeEnum_const_physx_PxActor_getType(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxScenePtr physx_PxScenePtr_const_physx_PxActor_getScene(physx.PxActorPtr pvk_this);
        
        public physx.PxScenePtr getScene() {
            physx.PxActorPtr pvk_in_this = this;
            return physx_PxScenePtr_const_physx_PxActor_getScene(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxActor_setName_string_(physx.PxActorPtr pvk_this, string pvk_name);
        
        public void setName(string name) {
            physx.PxActorPtr pvk_in_this = this;
            string pvk_in_name = name;
            void_physx_PxActor_setName_string_(pvk_in_this, pvk_in_name);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern string string_const_physx_PxActor_getName(physx.PxActorPtr pvk_this);
        
        public string getName() {
            physx.PxActorPtr pvk_in_this = this;
            return string_const_physx_PxActor_getName(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void physx_PxBounds3_const_physx_PxActor_getWorldBounds_float_(physx.PxBounds3* RetRef, physx.PxActorPtr pvk_this, float pvk_inflation);
        
        public physx.PxBounds3 getWorldBounds(float inflation=1.01f) {
            physx.PxBounds3 RetRef;
            physx.PxActorPtr pvk_in_this = this;
            float pvk_in_inflation = inflation;
            physx_PxBounds3_const_physx_PxActor_getWorldBounds_float_(&RetRef, pvk_in_this, pvk_in_inflation);
            return RetRef;
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxActor_setActorFlag_physx_PxActorFlagEnum_bool_(physx.PxActorPtr pvk_this, physx.PxActorFlagEnum pvk_flag, bool pvk_value);
        
        public void setActorFlag(physx.PxActorFlagEnum flag, bool value) {
            physx.PxActorPtr pvk_in_this = this;
            physx.PxActorFlagEnum pvk_in_flag = flag;
            bool pvk_in_value = value;
            void_physx_PxActor_setActorFlag_physx_PxActorFlagEnum_bool_(pvk_in_this, pvk_in_flag, pvk_in_value);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxActor_setActorFlags_PxActorFlagsPtr_(physx.PxActorPtr pvk_this, PxActorFlagsPtr pvk_inFlags);
        
        public void setActorFlags(PxActorFlagsPtr inFlags) {
            physx.PxActorPtr pvk_in_this = this;
            PxActorFlagsPtr pvk_in_inFlags = inFlags;
            void_physx_PxActor_setActorFlags_PxActorFlagsPtr_(pvk_in_this, pvk_in_inFlags);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern PxActorFlagsPtr PxActorFlagsPtr_const_physx_PxActor_getActorFlags(physx.PxActorPtr pvk_this);
        
        public PxActorFlagsPtr getActorFlags_New() {
            physx.PxActorPtr pvk_in_this = this;
            return PxActorFlagsPtr_const_physx_PxActor_getActorFlags(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxActor_setDominanceGroup_byte_(physx.PxActorPtr pvk_this, byte pvk_dominanceGroup);
        
        public void setDominanceGroup(byte dominanceGroup) {
            physx.PxActorPtr pvk_in_this = this;
            byte pvk_in_dominanceGroup = dominanceGroup;
            void_physx_PxActor_setDominanceGroup_byte_(pvk_in_this, pvk_in_dominanceGroup);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern byte byte_const_physx_PxActor_getDominanceGroup(physx.PxActorPtr pvk_this);
        
        public byte getDominanceGroup() {
            physx.PxActorPtr pvk_in_this = this;
            return byte_const_physx_PxActor_getDominanceGroup(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxActor_setOwnerClient_byte_(physx.PxActorPtr pvk_this, byte pvk_inClient);
        
        public void setOwnerClient(byte inClient) {
            physx.PxActorPtr pvk_in_this = this;
            byte pvk_in_inClient = inClient;
            void_physx_PxActor_setOwnerClient_byte_(pvk_in_this, pvk_in_inClient);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern byte byte_const_physx_PxActor_getOwnerClient(physx.PxActorPtr pvk_this);
        
        public byte getOwnerClient() {
            physx.PxActorPtr pvk_in_this = this;
            return byte_const_physx_PxActor_getOwnerClient(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern physx.PxAggregatePtr physx_PxAggregatePtr_const_physx_PxActor_getAggregate(physx.PxActorPtr pvk_this);
        
        public physx.PxAggregatePtr getAggregate() {
            physx.PxActorPtr pvk_in_this = this;
            return physx_PxAggregatePtr_const_physx_PxActor_getAggregate(pvk_in_this);
        }
        
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void physx_PxBounds3_const_physx_PxActor_getWorldBounds(physx.PxBounds3* RetRef, physx.PxActorPtr pvk_this);
        
        public physx.PxBounds3 getWorldBounds() {
            physx.PxBounds3 RetRef;
            physx.PxActorPtr pvk_in_this = this;
            physx_PxBounds3_const_physx_PxActor_getWorldBounds(&RetRef, pvk_in_this);
            return RetRef;
        }
        public static implicit operator physx.PxBasePtr(PxActorPtr obj) => *(physx.PxBasePtr*)&obj;
        public static explicit operator PxActorPtr(physx.PxBasePtr obj) => *(PxActorPtr*)&obj;
    
        // PIPING
        public string getConcreteTypeName(){return((physx.PxBasePtr)this).getConcreteTypeName();}
        public ushort getConcreteType(){return((physx.PxBasePtr)this).getConcreteType();}
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value){((physx.PxBasePtr)this).setBaseFlag(flag, value);}
        public void setBaseFlags(PxBaseFlagsPtr inFlags){((physx.PxBasePtr)this).setBaseFlags(inFlags);}
        public PxBaseFlagsPtr getBaseFlags_New(){return((physx.PxBasePtr)this).getBaseFlags_New();}
        public bool isReleasable(){return((physx.PxBasePtr)this).isReleasable();}
    
        public unsafe interface IPxActorPtr {
            void release();
            physx.PxActorTypeEnum getType();
            physx.PxScenePtr getScene();
            void setName(string name);
            string getName();
            physx.PxBounds3 getWorldBounds(float inflation=1.01f);
            void setActorFlag(physx.PxActorFlagEnum flag, bool value);
            void setActorFlags(PxActorFlagsPtr inFlags);
            PxActorFlagsPtr getActorFlags_New();
            void setDominanceGroup(byte dominanceGroup);
            byte getDominanceGroup();
            void setOwnerClient(byte inClient);
            byte getOwnerClient();
            physx.PxAggregatePtr getAggregate();
            physx.PxBounds3 getWorldBounds();
        }
    }
    
}
