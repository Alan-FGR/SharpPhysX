#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxVec3 {
#endif

//================================================================================
//#       operator*(float f, PxVec3Ptr v)                                        #
//================================================================================
#if NATIVE //function start
ES PxVec3POD W_OP_Star_R_PxVec3_P_float_P_PxVec3(float f, physx::PxVec3 v){
    auto nat_in_f = (f);
    auto nat_in_v = (v);
    auto retVal = physx::operator*;
    return *(PxVec3POD*)&retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxVec3 W_OP_Star_R_PxVec3_P_float_P_PxVec3(float f, PxVec3 v);

public static PxVec3 operator*(float f, PxVec3 v){
    float pvk_in_f = (f);
    PxVec3 pvk_in_v = (v);
    PxVec3 retVal = W_OP_Star_R_PxVec3_P_float_P_PxVec3(pvk_in_f, pvk_in_v);
    return retVal;
}
#endif //function end

#if !NATIVE //end functions holder
} //end PxVec3
#endif


#if !NATIVE //interface
public unsafe interface IPxVec3 {
    ///*No paramless ctor in C#*/ static PxVec3 Default();
    // PxVec3(PxZERO r);
    // PxVec3(float a);
    // PxVec3(float nx, float ny, float nz);
    // PxVec3(PxVec3 v);
    //static PxVec3 operator=(PxVec3 lhs, /*NULLPARS*/);
    //static IntPtr operator[](PxVec3 lhs, /*NULLPARS*/);
    //static IntPtr operator[](PxVec3 lhs, /*NULLPARS*/);
    //static bool operator==(PxVec3 lhs, PxVec3 v);
    //static bool operator!=(PxVec3 lhs, PxVec3 v);
     bool isZero();
     bool isFinite();
     bool isNormalized();
     float magnitudeSquared();
     float magnitude();
    //static PxVec3 operator-(PxVec3 lhs);
    //static PxVec3 operator+(PxVec3 lhs, PxVec3 v);
    //static PxVec3 operator-(PxVec3 lhs, PxVec3 v);
    //static PxVec3 operator*(PxVec3 lhs, float f);
    //static PxVec3 operator/(PxVec3 lhs, float f);
    //static PxVec3 operator+=(PxVec3 lhs, /*NULLPARS*/);
    //static PxVec3 operator-=(PxVec3 lhs, /*NULLPARS*/);
    //static PxVec3 operator*=(PxVec3 lhs, /*NULLPARS*/);
    //static PxVec3 operator/=(PxVec3 lhs, /*NULLPARS*/);
     float dot(PxVec3 v);
     PxVec3 cross(PxVec3 v);
     PxVec3 getNormalized();
     float normalize();
     float normalizeSafe();
     float normalizeFast();
     PxVec3 multiply(PxVec3 a);
     PxVec3 minimum(PxVec3 v);
     float minElement();
     PxVec3 maximum(PxVec3 v);
     float maxElement();
     PxVec3 abs();
    // UNPARSED_TYPE ~PxVec3(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxVec3 : IPxVec3 { // blittable
    public float x;
    public float y;
    public float z;

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxVec3POD{
    float x;
    float y;
    float z;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxVec3
    #endif //hierarchy
    //================================================================================
    //#       PxVec3()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_PxVec3_R_PxVec3_C_PxVec3_ctor(){
        auto val = PxVec3();
        return *(PxVec3POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_R_PxVec3_C_PxVec3_ctor();
    
    public /*No paramless ctor in C#*/ static PxVec3 Default(){
        return (W_PxVec3_R_PxVec3_C_PxVec3_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec3(physx r)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_PxVec3_R_PxVec3_P_PxZERO_C_PxVec3_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        auto val = PxVec3();
        return *(PxVec3POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_R_PxVec3_P_PxZERO_C_PxVec3_ctor(PxZERO r);
    
    public  PxVec3(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = (W_PxVec3_R_PxVec3_P_PxZERO_C_PxVec3_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec3(float a)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_PxVec3_R_PxVec3_P_float_C_PxVec3_ctor(float a){
        auto nat_in_a = (a);
        auto val = PxVec3();
        return *(PxVec3POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_R_PxVec3_P_float_C_PxVec3_ctor(float a);
    
    public  PxVec3(float a){
        float pvk_in_a = (a);
        var _new = (W_PxVec3_R_PxVec3_P_float_C_PxVec3_ctor(pvk_in_a));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec3(float nx, float ny, float nz)                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_PxVec3_R_PxVec3_P_float_P_float_P_float_C_PxVec3_ctor(float nx, float ny, float nz){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        auto val = PxVec3();
        return *(PxVec3POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_R_PxVec3_P_float_P_float_P_float_C_PxVec3_ctor(float nx, float ny, float nz);
    
    public  PxVec3(float nx, float ny, float nz){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        var _new = (W_PxVec3_R_PxVec3_P_float_P_float_P_float_C_PxVec3_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec3(PxVec3Ptr v)                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_PxVec3_R_PxVec3_P_PxVec3_C_PxVec3_ctor(physx::PxVec3 v){
        auto nat_in_v = (v);
        auto val = PxVec3();
        return *(PxVec3POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_R_PxVec3_P_PxVec3_C_PxVec3_ctor(PxVec3 v);
    
    public  PxVec3(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        var _new = (W_PxVec3_R_PxVec3_P_PxVec3_C_PxVec3_ctor(pvk_in_v));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator=(PxVec3Ptr p)                                                 #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator[](uint index)                                                 #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator[](uint index)                                                 #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator==(PxVec3Ptr v)                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator==(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public static bool operator==(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxVec3_C_PxVec3(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator!=(PxVec3Ptr v)                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_ExclaimEqual_R_bool_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator!=(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual_R_bool_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public static bool operator!=(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = W_OP_ExclaimEqual_R_bool_P_PxVec3_C_PxVec3(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isZero()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isZero_R_bool_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.isZero();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isZero_R_bool_C_PxVec3(PxVec3 selfBlt);
    
    public  bool isZero(){
        bool retVal = W_isZero_R_bool_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isFinite()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isFinite_R_bool_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite_R_bool_C_PxVec3(PxVec3 selfBlt);
    
    public  bool isFinite(){
        bool retVal = W_isFinite_R_bool_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isNormalized()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isNormalized_R_bool_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.isNormalized();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isNormalized_R_bool_C_PxVec3(PxVec3 selfBlt);
    
    public  bool isNormalized(){
        bool retVal = W_isNormalized_R_bool_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitudeSquared()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitudeSquared_R_float_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.magnitudeSquared();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitudeSquared_R_float_C_PxVec3(PxVec3 selfBlt);
    
    public  float magnitudeSquared(){
        float retVal = W_magnitudeSquared_R_float_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitude()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitude_R_float_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.magnitude();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitude_R_float_C_PxVec3(PxVec3 selfBlt);
    
    public  float magnitude(){
        float retVal = W_magnitude_R_float_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_OP_Minus_R_PxVec3_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.operator-;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Minus_R_PxVec3_C_PxVec3(PxVec3 selfBlt);
    
    public static PxVec3 operator-(PxVec3 lhs){
        PxVec3 retVal = W_OP_Minus_R_PxVec3_C_PxVec3(lhs);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+(PxVec3Ptr v)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_OP_Plus_R_PxVec3_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator+;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Plus_R_PxVec3_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public static PxVec3 operator+(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_OP_Plus_R_PxVec3_P_PxVec3_C_PxVec3(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-(PxVec3Ptr v)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_OP_Minus_R_PxVec3_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator-;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Minus_R_PxVec3_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public static PxVec3 operator-(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_OP_Minus_R_PxVec3_P_PxVec3_C_PxVec3(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*(float f)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_OP_Star_R_PxVec3_P_float_C_PxVec3(physx::PxVec3 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator*;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Star_R_PxVec3_P_float_C_PxVec3(PxVec3 selfBlt, float f);
    
    public static PxVec3 operator*(PxVec3 lhs, float f){
        float pvk_in_f = (f);
        PxVec3 retVal = W_OP_Star_R_PxVec3_P_float_C_PxVec3(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator/(float f)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_OP_Slash_R_PxVec3_P_float_C_PxVec3(physx::PxVec3 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator/;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Slash_R_PxVec3_P_float_C_PxVec3(PxVec3 selfBlt, float f);
    
    public static PxVec3 operator/(PxVec3 lhs, float f){
        float pvk_in_f = (f);
        PxVec3 retVal = W_OP_Slash_R_PxVec3_P_float_C_PxVec3(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+=(PxVec3Ptr v)                                                #
    //================================================================================
    //Skipped unsupported operator PlusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator-=(PxVec3Ptr v)                                                #
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
    //#       dot(PxVec3Ptr v)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES float W_dot_R_float_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_dot_R_float_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public  float dot(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        float retVal = W_dot_R_float_P_PxVec3_C_PxVec3(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       cross(PxVec3Ptr v)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_cross_R_PxVec3_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.cross;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_cross_R_PxVec3_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public  PxVec3 cross(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_cross_R_PxVec3_P_PxVec3_C_PxVec3(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNormalized()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getNormalized_R_PxVec3_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.getNormalized;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getNormalized_R_PxVec3_C_PxVec3(PxVec3 selfBlt);
    
    public  PxVec3 getNormalized(){
        PxVec3 retVal = W_getNormalized_R_PxVec3_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       normalize()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_normalize_R_float_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.normalize();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalize_R_float_C_PxVec3(PxVec3 selfBlt);
    
    public  float normalize(){
        float retVal = W_normalize_R_float_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       normalizeSafe()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES float W_normalizeSafe_R_float_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.normalizeSafe();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalizeSafe_R_float_C_PxVec3(PxVec3 selfBlt);
    
    public  float normalizeSafe(){
        float retVal = W_normalizeSafe_R_float_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       normalizeFast()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES float W_normalizeFast_R_float_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.normalizeFast();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalizeFast_R_float_C_PxVec3(PxVec3 selfBlt);
    
    public  float normalizeFast(){
        float retVal = W_normalizeFast_R_float_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       multiply(PxVec3Ptr a)                                                  #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_multiply_R_PxVec3_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 a){
        auto nat_in_a = (a);
        auto retVal = self.multiply;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_multiply_R_PxVec3_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 a);
    
    public  PxVec3 multiply(PxVec3 a){
        PxVec3 pvk_in_a = (a);
        PxVec3 retVal = W_multiply_R_PxVec3_P_PxVec3_C_PxVec3(this, pvk_in_a);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       minimum(PxVec3Ptr v)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_minimum_R_PxVec3_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.minimum;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_minimum_R_PxVec3_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public  PxVec3 minimum(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_minimum_R_PxVec3_P_PxVec3_C_PxVec3(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       minElement()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES float W_minElement_R_float_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.minElement();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_minElement_R_float_C_PxVec3(PxVec3 selfBlt);
    
    public  float minElement(){
        float retVal = W_minElement_R_float_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       maximum(PxVec3Ptr v)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_maximum_R_PxVec3_P_PxVec3_C_PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.maximum;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_maximum_R_PxVec3_P_PxVec3_C_PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public  PxVec3 maximum(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_maximum_R_PxVec3_P_PxVec3_C_PxVec3(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       maxElement()                                                           #
    //================================================================================
    #if NATIVE //function start
    ES float W_maxElement_R_float_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.maxElement();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_maxElement_R_float_C_PxVec3(PxVec3 selfBlt);
    
    public  float maxElement(){
        float retVal = W_maxElement_R_float_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       abs()                                                                  #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_abs_R_PxVec3_C_PxVec3(physx::PxVec3 self){
        auto retVal = self.abs;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_abs_R_PxVec3_C_PxVec3(PxVec3 selfBlt);
    
    public  PxVec3 abs(){
        PxVec3 retVal = W_abs_R_PxVec3_C_PxVec3(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: ~PxVec3
    

#if !NATIVE //struct close
}
#endif //struct close
