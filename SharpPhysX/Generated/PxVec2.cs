#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxVec2Ptr {
#endif

//================================================================================
//#       operator*(float f, PxVec2Ptr v)                                        #
//================================================================================
/* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
returned native value can't be converted into ptr
// NATIVE SIG: PxVec2 operator*(float f, const PxVec2& v)
{
	return PxVec2(f * v.x, f * v.y);
}
#if NATIVE //function start
ES PxVec2PtrPOD W_OP_Star_R_PxVec2Ptr_P_float_P_PxVec2Ptr(float f, physx::PxVec2* v){
    auto nat_in_f = (f);
    auto nat_in_v = (v);
    auto retVal = physx::operator*;
    return *(PxVec2PtrPOD*)&retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxVec2Ptr W_OP_Star_R_PxVec2Ptr_P_float_P_PxVec2Ptr(float f, PxVec2Ptr v);

public static PxVec2Ptr operator*(float f, PxVec2Ptr v){
    float pvk_in_f = (f);
    PxVec2Ptr pvk_in_v = (v);
    PxVec2Ptr retVal = W_OP_Star_R_PxVec2Ptr_P_float_P_PxVec2Ptr(pvk_in_f, pvk_in_v);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxVec2Ptr
#endif


#if !NATIVE //interface
public unsafe interface IPxVec2Ptr {
    // static PxVec2Ptr New();
    // static PxVec2Ptr New(PxZERO r);
    // static PxVec2Ptr New(float a);
    // static PxVec2Ptr New(float nx, float ny);
    // static PxVec2Ptr New(PxVec2Ptr v);
    //static PxVec2Ptr operator=(PxVec2Ptr lhs, /*NULLPARS*/);
    //static IntPtr operator[](PxVec2Ptr lhs, /*NULLPARS*/);
    //static IntPtr operator[](PxVec2Ptr lhs, /*NULLPARS*/);
    //static bool operator==(PxVec2Ptr lhs, PxVec2Ptr v);
    //static bool operator!=(PxVec2Ptr lhs, PxVec2Ptr v);
     bool isZero();
     bool isFinite();
     bool isNormalized();
     float magnitudeSquared();
     float magnitude();
    //static PxVec2Ptr operator-(PxVec2Ptr lhs);
    //static PxVec2Ptr operator+(PxVec2Ptr lhs, PxVec2Ptr v);
    //static PxVec2Ptr operator-(PxVec2Ptr lhs, PxVec2Ptr v);
    //static PxVec2Ptr operator*(PxVec2Ptr lhs, float f);
    //static PxVec2Ptr operator/(PxVec2Ptr lhs, float f);
    //static PxVec2Ptr operator+=(PxVec2Ptr lhs, /*NULLPARS*/);
    //static PxVec2Ptr operator-=(PxVec2Ptr lhs, /*NULLPARS*/);
    //static PxVec2Ptr operator*=(PxVec2Ptr lhs, /*NULLPARS*/);
    //static PxVec2Ptr operator/=(PxVec2Ptr lhs, /*NULLPARS*/);
     float dot(PxVec2Ptr v);
    // PxVec2Ptr getNormalized();
     float normalize();
    // PxVec2Ptr multiply(PxVec2Ptr a);
    // PxVec2Ptr minimum(PxVec2Ptr v);
     float minElement();
    // PxVec2Ptr maximum(PxVec2Ptr v);
     float maxElement();
    // UNPARSED_TYPE ~PxVec2(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxVec2Ptr : IPxVec2Ptr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxVec2PtrPOD{
    float x;
    float y;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### X getter/setter
    #if NATIVE //getter
    ES float PxVec2_GET_x(PxVec2* self) {return self->x;}
    ES void PxVec2_SET_x(PxVec2* self, float value) {self->x = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxVec2_GET_x(PxVec2Ptr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxVec2_SET_x(PxVec2Ptr selfPtr, float value);

    public float x {
        get => PxVec2_GET_x(this);
        set => PxVec2_SET_x(this, value);
    }
    #endif //getter

    // ### Y getter/setter
    #if NATIVE //getter
    ES float PxVec2_GET_y(PxVec2* self) {return self->y;}
    ES void PxVec2_SET_y(PxVec2* self, float value) {self->y = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float PxVec2_GET_y(PxVec2Ptr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxVec2_SET_y(PxVec2Ptr selfPtr, float value);

    public float y {
        get => PxVec2_GET_y(this);
        set => PxVec2_SET_y(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxVec2Ptr
    #endif //hierarchy
    //================================================================================
    //#       PxVec2()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES PxVec2PtrPOD W_PxVec2_R_PxVec2Ptr_C_PxVec2_ctor(){
        auto val = new PxVec2();
        return *(PxVec2PtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_PxVec2_R_PxVec2Ptr_C_PxVec2_ctor();
    
    public  static PxVec2Ptr New(){
        var _new = W_PxVec2_R_PxVec2Ptr_C_PxVec2_ctor();
        PxVec2Ptr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec2(physx r)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec2PtrPOD W_PxVec2_R_PxVec2Ptr_P_PxZERO_C_PxVec2_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        auto val = new PxVec2();
        return *(PxVec2PtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_PxVec2_R_PxVec2Ptr_P_PxZERO_C_PxVec2_ctor(PxZERO r);
    
    public  static PxVec2Ptr New(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = W_PxVec2_R_PxVec2Ptr_P_PxZERO_C_PxVec2_ctor(pvk_in_r);
        PxVec2Ptr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec2(float a)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec2PtrPOD W_PxVec2_R_PxVec2Ptr_P_float_C_PxVec2_ctor(float a){
        auto nat_in_a = (a);
        auto val = new PxVec2();
        return *(PxVec2PtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_PxVec2_R_PxVec2Ptr_P_float_C_PxVec2_ctor(float a);
    
    public  static PxVec2Ptr New(float a){
        float pvk_in_a = (a);
        var _new = W_PxVec2_R_PxVec2Ptr_P_float_C_PxVec2_ctor(pvk_in_a);
        PxVec2Ptr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec2(float nx, float ny)                                             #
    //================================================================================
    #if NATIVE //function start
    ES PxVec2PtrPOD W_PxVec2_R_PxVec2Ptr_P_float_P_float_C_PxVec2_ctor(float nx, float ny){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto val = new PxVec2();
        return *(PxVec2PtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_PxVec2_R_PxVec2Ptr_P_float_P_float_C_PxVec2_ctor(float nx, float ny);
    
    public  static PxVec2Ptr New(float nx, float ny){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        var _new = W_PxVec2_R_PxVec2Ptr_P_float_P_float_C_PxVec2_ctor(pvk_in_nx, pvk_in_ny);
        PxVec2Ptr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec2(PxVec2Ptr v)                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxVec2PtrPOD W_PxVec2_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2_ctor(physx::PxVec2* v){
        auto nat_in_v = (v);
        auto val = new PxVec2();
        return *(PxVec2PtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_PxVec2_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2_ctor(PxVec2Ptr v);
    
    public  static PxVec2Ptr New(PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        var _new = W_PxVec2_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2_ctor(pvk_in_v);
        PxVec2Ptr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator=(PxVec2Ptr p)                                                 #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator[](int index)                                                  #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator[](int index)                                                  #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator==(PxVec2Ptr v)                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* v){
        auto nat_in_v = (v);
        auto retVal = self->operator==(*nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr v);
    
    public static bool operator==(PxVec2Ptr lhs, PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxVec2Ptr_C_PxVec2(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator!=(PxVec2Ptr v)                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_ExclaimEqual_R_bool_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* v){
        auto nat_in_v = (v);
        auto retVal = self->operator!=(*nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual_R_bool_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr v);
    
    public static bool operator!=(PxVec2Ptr lhs, PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        bool retVal = W_OP_ExclaimEqual_R_bool_P_PxVec2Ptr_C_PxVec2(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isZero()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isZero_R_bool_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->isZero();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isZero_R_bool_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  bool isZero(){
        bool retVal = W_isZero_R_bool_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isFinite()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isFinite_R_bool_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->isFinite();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite_R_bool_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  bool isFinite(){
        bool retVal = W_isFinite_R_bool_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isNormalized()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isNormalized_R_bool_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->isNormalized();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isNormalized_R_bool_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  bool isNormalized(){
        bool retVal = W_isNormalized_R_bool_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitudeSquared()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitudeSquared_R_float_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->magnitudeSquared();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitudeSquared_R_float_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  float magnitudeSquared(){
        float retVal = W_magnitudeSquared_R_float_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitude()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitude_R_float_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->magnitude();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitude_R_float_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  float magnitude(){
        float retVal = W_magnitude_R_float_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-()                                                            #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 operator-() const
    	{
    		return PxVec2(-x, -y);
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_OP_Minus_R_PxVec2Ptr_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->operator-;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_OP_Minus_R_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr);
    
    public static PxVec2Ptr operator-(PxVec2Ptr lhs){
        PxVec2Ptr retVal = W_OP_Minus_R_PxVec2Ptr_C_PxVec2(lhs);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator+(PxVec2Ptr v)                                                 #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 operator+(const PxVec2& v) const
    	{
    		return PxVec2(x + v.x, y + v.y);
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_OP_Plus_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* v){
        auto nat_in_v = (v);
        auto retVal = self->operator+;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_OP_Plus_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr v);
    
    public static PxVec2Ptr operator+(PxVec2Ptr lhs, PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        PxVec2Ptr retVal = W_OP_Plus_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator-(PxVec2Ptr v)                                                 #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 operator-(const PxVec2& v) const
    	{
    		return PxVec2(x - v.x, y - v.y);
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_OP_Minus_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* v){
        auto nat_in_v = (v);
        auto retVal = self->operator-;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_OP_Minus_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr v);
    
    public static PxVec2Ptr operator-(PxVec2Ptr lhs, PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        PxVec2Ptr retVal = W_OP_Minus_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator*(float f)                                                     #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 operator*(float f) const
    	{
    		return PxVec2(x * f, y * f);
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_OP_Star_R_PxVec2Ptr_P_float_C_PxVec2(physx::PxVec2* self, float f){
        auto nat_in_f = (f);
        auto retVal = self->operator*;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_OP_Star_R_PxVec2Ptr_P_float_C_PxVec2(PxVec2Ptr selfPtr, float f);
    
    public static PxVec2Ptr operator*(PxVec2Ptr lhs, float f){
        float pvk_in_f = (f);
        PxVec2Ptr retVal = W_OP_Star_R_PxVec2Ptr_P_float_C_PxVec2(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator/(float f)                                                     #
    //================================================================================
    /* ERRORS OCCURED: Operator shouldn't allocate (op return ptr), TODO provide alternative func
    returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 operator/(float f) const
    	{
    		f = 1.0f / f; // PT: inconsistent notation with operator /=
    		return PxVec2(x * f, y * f);
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_OP_Slash_R_PxVec2Ptr_P_float_C_PxVec2(physx::PxVec2* self, float f){
        auto nat_in_f = (f);
        auto retVal = self->operator/;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_OP_Slash_R_PxVec2Ptr_P_float_C_PxVec2(PxVec2Ptr selfPtr, float f);
    
    public static PxVec2Ptr operator/(PxVec2Ptr lhs, float f){
        float pvk_in_f = (f);
        PxVec2Ptr retVal = W_OP_Slash_R_PxVec2Ptr_P_float_C_PxVec2(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator+=(PxVec2Ptr v)                                                #
    //================================================================================
    //Skipped unsupported operator PlusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator-=(PxVec2Ptr v)                                                #
    //================================================================================
    //Skipped unsupported operator MinusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=(float f)                                                    #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator/=(float f)                                                    #
    //================================================================================
    //Skipped unsupported operator SlashEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       dot(PxVec2Ptr v)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES float W_dot_R_float_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* v){
        auto nat_in_v = (v);
        auto retVal = self->dot(*nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_dot_R_float_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr v);
    
    public  float dot(PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        float retVal = W_dot_R_float_P_PxVec2Ptr_C_PxVec2(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNormalized()                                                        #
    //================================================================================
    /* ERRORS OCCURED: returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 getNormalized() const
    	{
    		const float m = magnitudeSquared();
    		return m > 0.0f ? *this * PxRecipSqrt(m) : PxVec2(0, 0);
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_getNormalized_R_PxVec2Ptr_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->getNormalized;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_getNormalized_R_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  PxVec2Ptr getNormalized(){
        PxVec2Ptr retVal = W_getNormalized_R_PxVec2Ptr_C_PxVec2(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       normalize()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_normalize_R_float_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->normalize();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalize_R_float_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  float normalize(){
        float retVal = W_normalize_R_float_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       multiply(PxVec2Ptr a)                                                  #
    //================================================================================
    /* ERRORS OCCURED: returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 multiply(const PxVec2& a) const
    	{
    		return PxVec2(x * a.x, y * a.y);
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_multiply_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* a){
        auto nat_in_a = (a);
        auto retVal = self->multiply;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_multiply_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr a);
    
    public  PxVec2Ptr multiply(PxVec2Ptr a){
        PxVec2Ptr pvk_in_a = (a);
        PxVec2Ptr retVal = W_multiply_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(this, pvk_in_a);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       minimum(PxVec2Ptr v)                                                   #
    //================================================================================
    /* ERRORS OCCURED: returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 minimum(const PxVec2& v) const
    	{
    		return PxVec2(PxMin(x, v.x), PxMin(y, v.y));
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_minimum_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* v){
        auto nat_in_v = (v);
        auto retVal = self->minimum;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_minimum_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr v);
    
    public  PxVec2Ptr minimum(PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        PxVec2Ptr retVal = W_minimum_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(this, pvk_in_v);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       minElement()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES float W_minElement_R_float_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->minElement();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_minElement_R_float_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  float minElement(){
        float retVal = W_minElement_R_float_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       maximum(PxVec2Ptr v)                                                   #
    //================================================================================
    /* ERRORS OCCURED: returned native value can't be converted into ptr
    // NATIVE SIG: PxVec2 maximum(const PxVec2& v) const
    	{
    		return PxVec2(PxMax(x, v.x), PxMax(y, v.y));
    	}
    #if NATIVE //function start
    ES PxVec2PtrPOD W_maximum_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(physx::PxVec2* self, physx::PxVec2* v){
        auto nat_in_v = (v);
        auto retVal = self->maximum;
        return *(PxVec2PtrPOD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec2Ptr W_maximum_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(PxVec2Ptr selfPtr, PxVec2Ptr v);
    
    public  PxVec2Ptr maximum(PxVec2Ptr v){
        PxVec2Ptr pvk_in_v = (v);
        PxVec2Ptr retVal = W_maximum_R_PxVec2Ptr_P_PxVec2Ptr_C_PxVec2(this, pvk_in_v);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       maxElement()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES float W_maxElement_R_float_C_PxVec2(physx::PxVec2* self){
        auto retVal = self->maxElement();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_maxElement_R_float_C_PxVec2(PxVec2Ptr selfPtr);
    
    public  float maxElement(){
        float retVal = W_maxElement_R_float_C_PxVec2(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: ~PxVec2
    

#if !NATIVE //struct close
}
#endif //struct close
