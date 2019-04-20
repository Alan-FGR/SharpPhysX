// Generated by minBND 5.1.90.51 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    //DBG: FunctionNode physx::getBinaryMetaData_PxBase L188
    //SKIPPING UNDECLARED FRIEND

    //DBG: FunctionNode physx::operator| L64
    //physx::operator| static physx.PxBaseFlagsPtr OpPipe_New(physx.PxBaseFlagEnum a, physx.PxBaseFlagEnum b) will also be bound as member operator
    //RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
    //PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
    //PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
    public static physx.PxBaseFlagsPtr OpPipe_New(physx.PxBaseFlagEnum a, physx.PxBaseFlagEnum b) {
        physx.PxBaseFlagEnum pvk_in_a = a;
        physx.PxBaseFlagEnum pvk_in_b = b;
        return PxBaseFlagsPtr_operator_Ptr_Pipe_PxBaseFlagEnum_PxBaseFlagEnum_(pvk_in_a, pvk_in_b);
    }

    //DBG: FunctionNode physx::operator& L64
    //physx::operator& static physx.PxBaseFlagsPtr OpAnd_New(physx.PxBaseFlagEnum a, physx.PxBaseFlagEnum b) will also be bound as member operator
    //RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
    //PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
    //PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
    public static physx.PxBaseFlagsPtr OpAnd_New(physx.PxBaseFlagEnum a, physx.PxBaseFlagEnum b) {
        physx.PxBaseFlagEnum pvk_in_a = a;
        physx.PxBaseFlagEnum pvk_in_b = b;
        return PxBaseFlagsPtr_operator_Ptr_Amp_PxBaseFlagEnum_PxBaseFlagEnum_(pvk_in_a, pvk_in_b);
    }

    //DBG: FunctionNode physx::operator~ L64
    //physx::operator~ static physx.PxBaseFlagsPtr OpTilde_New(physx.PxBaseFlagEnum a) will also be bound as member operator
    //RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
    //PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
    public static physx.PxBaseFlagsPtr OpTilde_New(physx.PxBaseFlagEnum a) {
        physx.PxBaseFlagEnum pvk_in_a = a;
        return PxBaseFlagsPtr_operator_Ptr_Tilde_PxBaseFlagEnum_(pvk_in_a);
    }

    //DBG: ClassNode PxBaseFlag physx::PxBaseFlag L54-61
    public enum PxBaseFlagEnum : int {
        eOWNS_MEMORY = 1,   // eOWNS_MEMORY = (1<<0)
        eIS_RELEASABLE = 2, // eIS_RELEASABLE = (1<<1)
    }
    //Subclasses using this: 20

    public unsafe partial struct PxBasePtr : physx.PxBasePtr.IPxBasePtr {
        private System.IntPtr nativePtr_;

        //DBG: ClassNode PxBase physx::PxBase L73-194

        //DBG: DeclNode is physx::PxBase::is L101

        //DBG: DeclNode is physx::PxBase::is L111

        //DBG: DeclNode typeMatch physx::PxBase::typeMatch L180

        //DBG: DeclNode  physx::PxBase L188

        //DBG: MethodNode physx::PxBase::release L85
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        public void release() {
            physx.PxBasePtr pvk_in_this = this;
            void_PxBasePtr_releasePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBase::getConcreteTypeName L91
        //RET nat: char*, man: string, ret: True, kind: Value
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        public string getConcreteTypeName() {
            physx.PxBasePtr pvk_in_this = this;
            return string_const_PxBasePtr_getConcreteTypeNamePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBase::is L101

        //DBG: MethodNode physx::PxBase::is L111

        //DBG: MethodNode physx::PxBase::getConcreteType L119
        //RET nat: PxType, man: ushort, ret: True, kind: Value
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        public ushort getConcreteType() {
            physx.PxBasePtr pvk_in_this = this;
            return ushort_const_PxBasePtr_getConcreteTypePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBase::setBaseFlag L127
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        //PAR nat: physx::PxBaseFlag::Enum, man: physx.PxBaseFlagEnum, kind: Value
        //PAR nat: bool, man: bool, kind: Value
        public void setBaseFlag(physx.PxBaseFlagEnum flag, bool value) {
            physx.PxBasePtr pvk_in_this = this;
            physx.PxBaseFlagEnum pvk_in_flag = flag;
            bool pvk_in_value = value;
            void_PxBasePtr_setBaseFlagPtr_PxBaseFlagEnum_bool_(pvk_in_this, pvk_in_flag, pvk_in_value);
        }

        //DBG: MethodNode physx::PxBase::setBaseFlags L136
        //RET nat: void, man: void, ret: True, kind: Value
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        //PAR nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, kind: PtrStruct
        public void setBaseFlags(physx.PxBaseFlagsPtr inFlags) {
            physx.PxBasePtr pvk_in_this = this;
            physx.PxBaseFlagsPtr pvk_in_inFlags = inFlags;
            void_PxBasePtr_setBaseFlagsPtr_PxBaseFlagsPtr_(pvk_in_this, pvk_in_inFlags);
        }

        //DBG: MethodNode physx::PxBase::getBaseFlags L145
        //RET nat: PxBaseFlagsPtr, man: physx.PxBaseFlagsPtr, ret: True, kind: PtrStruct
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        public physx.PxBaseFlagsPtr getBaseFlags_New() {
            physx.PxBasePtr pvk_in_this = this;
            return PxBaseFlagsPtr_const_PxBasePtr_getBaseFlagsPtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBase::isReleasable L156
        //RET nat: bool, man: bool, ret: True, kind: Value
        //PAR nat: PxBasePtr, man: physx.PxBasePtr, kind: PtrStruct
        public bool isReleasable() {
            physx.PxBasePtr pvk_in_this = this;
            return bool_const_PxBasePtr_isReleasablePtr(pvk_in_this);
        }

        //DBG: MethodNode physx::PxBase::operator= L73
        //ERRORS in MethodNode: Skipping Implicit MethodNode physx::PxBase::operator= L73

        //INTERFACES
        public unsafe interface IPxBasePtr {
            void release();
            string getConcreteTypeName();
            //Skipping UNPARSED* is(). Errors: 
            //Skipping UNPARSED* isConst(). Errors: 
            ushort getConcreteType();
            void setBaseFlag(physx.PxBaseFlagEnum flag, bool value);
            void setBaseFlags(physx.PxBaseFlagsPtr inFlags);
            physx.PxBaseFlagsPtr getBaseFlags_New();
            bool isReleasable();
        }

        //Operators
    }

    //DBG: DeclNode PxType physx::PxType L49

    //DBG: DeclNode PxBaseFlags physx::PxBaseFlags L63
}
