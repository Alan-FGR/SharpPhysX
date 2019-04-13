// Generated by minBND 5.1.78.26 - © github.com/Alan-FGR
//DEBUG: UnitNode  - 0
//Unit PxDeletionListener
using System;
using System.Runtime.InteropServices;

//DEBUG: NamespaceNode physx - 41-102
public static unsafe partial class physx {
    //DEBUG: FunctionNode physx::operator| - 66
    // physx::operator| [static PxDeletionEventFlagsPtr Pipe_New(physx.PxDeletionEventFlagEnum a, physx.PxDeletionEventFlagEnum b)] will be bound as member operator
    
    //DEBUG: FunctionNode physx::operator& - 66
    // physx::operator& [static PxDeletionEventFlagsPtr Amp_New(physx.PxDeletionEventFlagEnum a, physx.PxDeletionEventFlagEnum b)] will be bound as member operator
    
    //DEBUG: FunctionNode physx::operator~ - 66
    // physx::operator~ [static PxDeletionEventFlagsPtr Tilde_New(physx.PxDeletionEventFlagEnum a)] will be bound as member operator
    
    //DEBUG: ClassNode physx::PxDeletionEventFlag - 51-58
    //DEBUG: EnumNode physx::PxDeletionEventFlag::Enum - 53-57
    public enum PxDeletionEventFlagEnum : int {
        eUSER_RELEASE = 1,   // eUSER_RELEASE = (1<<0)
        eMEMORY_RELEASE = 2, // eMEMORY_RELEASE = (1<<1)
    }
    
    //DEBUG: ClassNode physx::PxDeletionListener - 73-98
    //Interface use count: 0
    public unsafe partial struct PxDeletionListenerPtr{
        private System.IntPtr nativePtr_;
        
    //DEBUG: MethodNode physx::PxDeletionListener::onRelease - 93
        [DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        static extern void void_physx_PxDeletionListener_onRelease_physx_PxBasePtr_IntPtr_physx_PxDeletionEventFlagEnum_(physx.PxDeletionListenerPtr pvk_this, physx.PxBasePtr pvk_observed, IntPtr pvk_userData, physx.PxDeletionEventFlagEnum pvk_deletionEvent);
        
        public void onRelease(physx.PxBasePtr observed, IntPtr userData, physx.PxDeletionEventFlagEnum deletionEvent) {
            //RET nat: void, man: void, stg: Value, ret: True
            //PAR nat: PxDeletionListenerPtr, man: physx.PxDeletionListenerPtr, stg: PtrStruct
            physx.PxDeletionListenerPtr pvk_in_this = this;
            //PAR nat: PxBasePtr, man: physx.PxBasePtr, stg: PtrStruct
            physx.PxBasePtr pvk_in_observed = observed;
            //PAR nat: void*, man: IntPtr, stg: Value
            IntPtr pvk_in_userData = userData;
            //PAR nat: physx::PxDeletionEventFlag::Enum, man: physx.PxDeletionEventFlagEnum, stg: Value
            physx.PxDeletionEventFlagEnum pvk_in_deletionEvent = deletionEvent;
            void_physx_PxDeletionListener_onRelease_physx_PxBasePtr_IntPtr_physx_PxDeletionEventFlagEnum_(pvk_in_this, pvk_in_observed, pvk_in_userData, pvk_in_deletionEvent);
        }
        
        //DEBUG: MethodNode physx::PxDeletionListener::operator= - 73
        //ERRORS OCCURED IN physx::PxDeletionListener::operator=
        //Implicit Function/Method
        //Unbindable Operator: Equal
    }
    
    //DEBUG: DeclNode physx::PxDeletionEventFlags - 65
    // TODO DeclNode.GenBinding()
    
}
