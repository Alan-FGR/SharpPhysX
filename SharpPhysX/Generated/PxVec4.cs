#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxVec4 {
#endif

//================================================================================
//#       operator*(float f, PxVec4Ptr v)                                        #
//================================================================================
#if NATIVE //function start
ES PxVec4POD W_OP_Star_R_PxVec4_P_float_P_PxVec4(float f, physx::PxVec4 v){
    auto nat_in_f = (f);
    auto nat_in_v = (v);
    auto retVal = physx::operator*;
    return *(PxVec4POD*)&retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxVec4 W_OP_Star_R_PxVec4_P_float_P_PxVec4(float f, PxVec4 v);

public static PxVec4 operator*(float f, PxVec4 v){
    float pvk_in_f = (f);
    PxVec4 pvk_in_v = (v);
    PxVec4 retVal = W_OP_Star_R_PxVec4_P_float_P_PxVec4(pvk_in_f, pvk_in_v);
    return retVal;
}
#endif //function end

#if !NATIVE //end functions holder
} //end PxVec4
#endif


#if !NATIVE //interface
public unsafe interface IPxVec4 {
    ///*No paramless ctor in C#*/ static PxVec4 Default();
    // PxVec4(PxZERO r);
    // PxVec4(float a);
    // PxVec4(float nx, float ny, float nz, float nw);
    // PxVec4(PxVec3 v, float nw);
    // PxVec4( v);
    // PxVec4(PxVec4 v);
    //static PxVec4 operator=(PxVec4 lhs, /*NULLPARS*/);
    //static IntPtr operator[](PxVec4 lhs, /*NULLPARS*/);
    //static IntPtr operator[](PxVec4 lhs, /*NULLPARS*/);
    //static bool operator==(PxVec4 lhs, PxVec4 v);
    //static bool operator!=(PxVec4 lhs, PxVec4 v);
     bool isZero();
     bool isFinite();
     bool isNormalized();
     float magnitudeSquared();
     float magnitude();
    //static PxVec4 operator-(PxVec4 lhs);
    //static PxVec4 operator+(PxVec4 lhs, PxVec4 v);
    //static PxVec4 operator-(PxVec4 lhs, PxVec4 v);
    //static PxVec4 operator*(PxVec4 lhs, float f);
    //static PxVec4 operator/(PxVec4 lhs, float f);
    //static PxVec4 operator+=(PxVec4 lhs, /*NULLPARS*/);
    //static PxVec4 operator-=(PxVec4 lhs, /*NULLPARS*/);
    //static PxVec4 operator*=(PxVec4 lhs, /*NULLPARS*/);
    //static PxVec4 operator/=(PxVec4 lhs, /*NULLPARS*/);
     float dot(PxVec4 v);
     PxVec4 getNormalized();
     float normalize();
     PxVec4 multiply(PxVec4 a);
     PxVec4 minimum(PxVec4 v);
     PxVec4 maximum(PxVec4 v);
     PxVec3 getXYZ();
     void setZero();
    // UNPARSED_TYPE ~PxVec4(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxVec4 : IPxVec4 { // blittable
    public float x;
    public float y;
    public float z;
    public float w;

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxVec4POD{
    float x;
    float y;
    float z;
    float w;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxVec4
    #endif //hierarchy
    //================================================================================
    //#       PxVec4()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_PxVec4_R_PxVec4_C_PxVec4_ctor(){
        auto val = PxVec4();
        return *(PxVec4POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_R_PxVec4_C_PxVec4_ctor();
    
    public /*No paramless ctor in C#*/ static PxVec4 Default(){
        return (W_PxVec4_R_PxVec4_C_PxVec4_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec4(physx r)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_PxVec4_R_PxVec4_P_PxZERO_C_PxVec4_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        auto val = PxVec4();
        return *(PxVec4POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_R_PxVec4_P_PxZERO_C_PxVec4_ctor(PxZERO r);
    
    public  PxVec4(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = (W_PxVec4_R_PxVec4_P_PxZERO_C_PxVec4_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec4(float a)                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_PxVec4_R_PxVec4_P_float_C_PxVec4_ctor(float a){
        auto nat_in_a = (a);
        auto val = PxVec4();
        return *(PxVec4POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_R_PxVec4_P_float_C_PxVec4_ctor(float a);
    
    public  PxVec4(float a){
        float pvk_in_a = (a);
        var _new = (W_PxVec4_R_PxVec4_P_float_C_PxVec4_ctor(pvk_in_a));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec4(float nx, float ny, float nz, float nw)                         #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_PxVec4_R_PxVec4_P_float_P_float_P_float_P_float_C_PxVec4_ctor(float nx, float ny, float nz, float nw){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        auto nat_in_nw = (nw);
        auto val = PxVec4();
        return *(PxVec4POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_R_PxVec4_P_float_P_float_P_float_P_float_C_PxVec4_ctor(float nx, float ny, float nz, float nw);
    
    public  PxVec4(float nx, float ny, float nz, float nw){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_nw = (nw);
        var _new = (W_PxVec4_R_PxVec4_P_float_P_float_P_float_P_float_C_PxVec4_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_nw));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec4(PxVec3Ptr v, float nw)                                          #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_PxVec4_R_PxVec4_P_PxVec3_P_float_C_PxVec4_ctor(physx::PxVec3 v, float nw){
        auto nat_in_v = (v);
        auto nat_in_nw = (nw);
        auto val = PxVec4();
        return *(PxVec4POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_R_PxVec4_P_PxVec3_P_float_C_PxVec4_ctor(PxVec3 v, float nw);
    
    public  PxVec4(PxVec3 v, float nw){
        PxVec3 pvk_in_v = (v);
        float pvk_in_nw = (nw);
        var _new = (W_PxVec4_R_PxVec4_P_PxVec3_P_float_C_PxVec4_ctor(pvk_in_v, pvk_in_nw));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxVec4(float[] v)                                                      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type float[]
    // NATIVE SIG: explicit PX_CUDA_CALLABLE PX_INLINE PxVec4(const float v[]) : x(v[0]), y(v[1]), z(v[2]), w(v[3])
    	{
    	}
    #if NATIVE //function start
    ES PxVec4POD W_PxVec4_R_PxVec4_P__C_PxVec4_ctor( v){
        auto nat_in_v = (v);
        auto val = PxVec4();
        return *(PxVec4POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_R_PxVec4_P__C_PxVec4_ctor( v);
    
    public  PxVec4( v){
         pvk_in_v = (v);
        var _new = (W_PxVec4_R_PxVec4_P__C_PxVec4_ctor(pvk_in_v));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxVec4(PxVec4Ptr v)                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_PxVec4_R_PxVec4_P_PxVec4_C_PxVec4_ctor(physx::PxVec4 v){
        auto nat_in_v = (v);
        auto val = PxVec4();
        return *(PxVec4POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_R_PxVec4_P_PxVec4_C_PxVec4_ctor(PxVec4 v);
    
    public  PxVec4(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        var _new = (W_PxVec4_R_PxVec4_P_PxVec4_C_PxVec4_ctor(pvk_in_v));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator=(PxVec4Ptr p)                                                 #
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
    //#       operator==(PxVec4Ptr v)                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator==(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 v);
    
    public static bool operator==(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxVec4_C_PxVec4(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator!=(PxVec4Ptr v)                                                #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_ExclaimEqual_R_bool_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator!=(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual_R_bool_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 v);
    
    public static bool operator!=(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        bool retVal = W_OP_ExclaimEqual_R_bool_P_PxVec4_C_PxVec4(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isZero()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isZero_R_bool_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.isZero();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isZero_R_bool_C_PxVec4(PxVec4 selfBlt);
    
    public  bool isZero(){
        bool retVal = W_isZero_R_bool_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isFinite()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isFinite_R_bool_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite_R_bool_C_PxVec4(PxVec4 selfBlt);
    
    public  bool isFinite(){
        bool retVal = W_isFinite_R_bool_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isNormalized()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isNormalized_R_bool_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.isNormalized();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isNormalized_R_bool_C_PxVec4(PxVec4 selfBlt);
    
    public  bool isNormalized(){
        bool retVal = W_isNormalized_R_bool_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitudeSquared()                                                     #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitudeSquared_R_float_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.magnitudeSquared();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitudeSquared_R_float_C_PxVec4(PxVec4 selfBlt);
    
    public  float magnitudeSquared(){
        float retVal = W_magnitudeSquared_R_float_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       magnitude()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_magnitude_R_float_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.magnitude();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitude_R_float_C_PxVec4(PxVec4 selfBlt);
    
    public  float magnitude(){
        float retVal = W_magnitude_R_float_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_OP_Minus_R_PxVec4_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.operator-;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Minus_R_PxVec4_C_PxVec4(PxVec4 selfBlt);
    
    public static PxVec4 operator-(PxVec4 lhs){
        PxVec4 retVal = W_OP_Minus_R_PxVec4_C_PxVec4(lhs);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+(PxVec4Ptr v)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_OP_Plus_R_PxVec4_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator+;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Plus_R_PxVec4_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 v);
    
    public static PxVec4 operator+(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_OP_Plus_R_PxVec4_P_PxVec4_C_PxVec4(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-(PxVec4Ptr v)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_OP_Minus_R_PxVec4_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator-;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Minus_R_PxVec4_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 v);
    
    public static PxVec4 operator-(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_OP_Minus_R_PxVec4_P_PxVec4_C_PxVec4(lhs, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*(float f)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_OP_Star_R_PxVec4_P_float_C_PxVec4(physx::PxVec4 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator*;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Star_R_PxVec4_P_float_C_PxVec4(PxVec4 selfBlt, float f);
    
    public static PxVec4 operator*(PxVec4 lhs, float f){
        float pvk_in_f = (f);
        PxVec4 retVal = W_OP_Star_R_PxVec4_P_float_C_PxVec4(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator/(float f)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_OP_Slash_R_PxVec4_P_float_C_PxVec4(physx::PxVec4 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator/;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Slash_R_PxVec4_P_float_C_PxVec4(PxVec4 selfBlt, float f);
    
    public static PxVec4 operator/(PxVec4 lhs, float f){
        float pvk_in_f = (f);
        PxVec4 retVal = W_OP_Slash_R_PxVec4_P_float_C_PxVec4(lhs, pvk_in_f);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+=(PxVec4Ptr v)                                                #
    //================================================================================
    //Skipped unsupported operator PlusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator-=(PxVec4Ptr v)                                                #
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
    //#       dot(PxVec4Ptr v)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES float W_dot_R_float_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_dot_R_float_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 v);
    
    public  float dot(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        float retVal = W_dot_R_float_P_PxVec4_C_PxVec4(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNormalized()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_getNormalized_R_PxVec4_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.getNormalized;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_getNormalized_R_PxVec4_C_PxVec4(PxVec4 selfBlt);
    
    public  PxVec4 getNormalized(){
        PxVec4 retVal = W_getNormalized_R_PxVec4_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       normalize()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES float W_normalize_R_float_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.normalize();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalize_R_float_C_PxVec4(PxVec4 selfBlt);
    
    public  float normalize(){
        float retVal = W_normalize_R_float_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       multiply(PxVec4Ptr a)                                                  #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_multiply_R_PxVec4_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 a){
        auto nat_in_a = (a);
        auto retVal = self.multiply;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_multiply_R_PxVec4_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 a);
    
    public  PxVec4 multiply(PxVec4 a){
        PxVec4 pvk_in_a = (a);
        PxVec4 retVal = W_multiply_R_PxVec4_P_PxVec4_C_PxVec4(this, pvk_in_a);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       minimum(PxVec4Ptr v)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_minimum_R_PxVec4_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.minimum;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_minimum_R_PxVec4_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 v);
    
    public  PxVec4 minimum(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_minimum_R_PxVec4_P_PxVec4_C_PxVec4(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       maximum(PxVec4Ptr v)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_maximum_R_PxVec4_P_PxVec4_C_PxVec4(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.maximum;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_maximum_R_PxVec4_P_PxVec4_C_PxVec4(PxVec4 selfBlt, PxVec4 v);
    
    public  PxVec4 maximum(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_maximum_R_PxVec4_P_PxVec4_C_PxVec4(this, pvk_in_v);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getXYZ()                                                               #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getXYZ_R_PxVec3_C_PxVec4(physx::PxVec4 self){
        auto retVal = self.getXYZ;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getXYZ_R_PxVec3_C_PxVec4(PxVec4 selfBlt);
    
    public  PxVec3 getXYZ(){
        PxVec3 retVal = W_getXYZ_R_PxVec3_C_PxVec4(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setZero()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_setZero_R_void_C_PxVec4(physx::PxVec4 self){
        self.setZero();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setZero_R_void_C_PxVec4(PxVec4 selfBlt);
    
    public  void setZero(){
        W_setZero_R_void_C_PxVec4(this);
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: ~PxVec4
    

#if !NATIVE //struct close
}
#endif //struct close
