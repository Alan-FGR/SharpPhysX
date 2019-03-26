#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE //functions holder
public partial struct PxMat44 {
#endif

//================================================================================
//#       operator*(float , PxMat44Ptr )                                         #
//================================================================================
/* ERRORS OCCURED: Invalid parameter name (empty)
Invalid parameter name (empty)
// NATIVE SIG: PxMat44 operator*(float, const PxMat44&)
#if NATIVE //function start
ES PxMat44POD W_OP_Star_R_PxMat44_P_float_P_PxMat44(float , physx::PxMat44 ){
    auto nat_in_ = ();
    auto nat_in_ = ();
    auto retVal = physx::operator*;
    return *(PxMat44POD*)&retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxMat44 W_OP_Star_R_PxMat44_P_float_P_PxMat44(float , PxMat44 );

public static PxMat44 operator*(float , PxMat44 ){
    float pvk_in_ = ();
    PxMat44 pvk_in_ = ();
    PxMat44 retVal = W_OP_Star_R_PxMat44_P_float_P_PxMat44(pvk_in_, pvk_in_);
    return retVal;
}
#endif //function end*/

#if !NATIVE //end functions holder
} //end PxMat44
#endif


#if !NATIVE //interface
public unsafe interface IPxMat44 {
    ///*No paramless ctor in C#*/ static PxMat44 Default();
    // PxMat44(PxIDENTITY r);
    // PxMat44(PxZERO r);
    // PxMat44(PxVec4 col0, PxVec4 col1, PxVec4 col2, PxVec4 col3);
    // PxMat44(float r);
    // PxMat44(PxVec3 col0, PxVec3 col1, PxVec3 col2, PxVec3 col3);
    // PxMat44( values);
    // PxMat44(PxQuat q);
    // PxMat44(PxVec4 diagonal);
    // PxMat44(PxMat33 axes, PxVec3 position);
    // PxMat44(PxTransform t);
    //static bool operator==(PxMat44 lhs, PxMat44 m);
    // PxMat44(PxMat44 other);
    //static PxMat44 operator=(PxMat44 lhs, /*NULLPARS*/);
     PxMat44 getTranspose();
    //static PxMat44 operator-(PxMat44 lhs);
    //static PxMat44 operator+(PxMat44 lhs, PxMat44 other);
    //static PxMat44 operator-(PxMat44 lhs, PxMat44 other);
    //static PxMat44 operator*(PxMat44 lhs, float scalar);
    //static PxMat44 operator*(PxMat44 lhs, PxMat44 other);
    //static PxMat44 operator+=(PxMat44 lhs, /*NULLPARS*/);
    //static PxMat44 operator-=(PxMat44 lhs, /*NULLPARS*/);
    //static PxMat44 operator*=(PxMat44 lhs, /*NULLPARS*/);
    //static PxMat44 operator*=(PxMat44 lhs, /*NULLPARS*/);
    //static float operator()(PxMat44 lhs, /*NULLPARS*/);
    //static IntPtr operator()(PxMat44 lhs, /*NULLPARS*/);
     PxVec4 transform(PxVec4 other);
     PxVec3 transform(PxVec3 other);
     PxVec4 rotate(PxVec4 other);
     PxVec3 rotate(PxVec3 other);
     PxVec3 getBasis(int num);
     PxVec3 getPosition();
     void setPosition(PxVec3 position);
     IntPtr front();
    //static PxVec4 operator[](PxMat44 lhs, /*NULLPARS*/);
    //static PxVec4 operator[](PxMat44 lhs, /*NULLPARS*/);
     void scale(PxVec4 p);
     PxMat44 inverseRT();
     bool isFinite();
    // UNPARSED_TYPE ~PxMat44(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxMat44 : IPxMat44 { // blittable
    public PxVec4 column0;
    public PxVec4 column1;
    public PxVec4 column2;
    public PxVec4 column3;

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxMat44POD{
    physx::PxVec4 column0;
    physx::PxVec4 column1;
    physx::PxVec4 column2;
    physx::PxVec4 column3;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxMat44
    #endif //hierarchy
    //================================================================================
    //#       PxMat44()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_C_PxMat44_ctor(){
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_C_PxMat44_ctor();
    
    public /*No paramless ctor in C#*/ static PxMat44 Default(){
        return (W_PxMat44_R_PxMat44_C_PxMat44_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(physx r)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxIDENTITY_C_PxMat44_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxIDENTITY_C_PxMat44_ctor(PxIDENTITY r);
    
    public  PxMat44(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = (W_PxMat44_R_PxMat44_P_PxIDENTITY_C_PxMat44_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(physx r)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxZERO_C_PxMat44_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxZERO_C_PxMat44_ctor(PxZERO r);
    
    public  PxMat44(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = (W_PxMat44_R_PxMat44_P_PxZERO_C_PxMat44_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(PxVec4Ptr col0, PxVec4Ptr col1, PxVec4Ptr col2, PxVec4Ptr col3) #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxVec4_P_PxVec4_P_PxVec4_P_PxVec4_C_PxMat44_ctor(physx::PxVec4 col0, physx::PxVec4 col1, physx::PxVec4 col2, physx::PxVec4 col3){
        auto nat_in_col0 = (col0);
        auto nat_in_col1 = (col1);
        auto nat_in_col2 = (col2);
        auto nat_in_col3 = (col3);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxVec4_P_PxVec4_P_PxVec4_P_PxVec4_C_PxMat44_ctor(PxVec4 col0, PxVec4 col1, PxVec4 col2, PxVec4 col3);
    
    public  PxMat44(PxVec4 col0, PxVec4 col1, PxVec4 col2, PxVec4 col3){
        PxVec4 pvk_in_col0 = (col0);
        PxVec4 pvk_in_col1 = (col1);
        PxVec4 pvk_in_col2 = (col2);
        PxVec4 pvk_in_col3 = (col3);
        var _new = (W_PxMat44_R_PxMat44_P_PxVec4_P_PxVec4_P_PxVec4_P_PxVec4_C_PxMat44_ctor(pvk_in_col0, pvk_in_col1, pvk_in_col2, pvk_in_col3));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(float r)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_float_C_PxMat44_ctor(float r){
        auto nat_in_r = (r);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_float_C_PxMat44_ctor(float r);
    
    public  PxMat44(float r){
        float pvk_in_r = (r);
        var _new = (W_PxMat44_R_PxMat44_P_float_C_PxMat44_ctor(pvk_in_r));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(PxVec3Ptr col0, PxVec3Ptr col1, PxVec3Ptr col2, PxVec3Ptr col3) #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxVec3_P_PxVec3_P_PxVec3_P_PxVec3_C_PxMat44_ctor(physx::PxVec3 col0, physx::PxVec3 col1, physx::PxVec3 col2, physx::PxVec3 col3){
        auto nat_in_col0 = (col0);
        auto nat_in_col1 = (col1);
        auto nat_in_col2 = (col2);
        auto nat_in_col3 = (col3);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxVec3_P_PxVec3_P_PxVec3_P_PxVec3_C_PxMat44_ctor(PxVec3 col0, PxVec3 col1, PxVec3 col2, PxVec3 col3);
    
    public  PxMat44(PxVec3 col0, PxVec3 col1, PxVec3 col2, PxVec3 col3){
        PxVec3 pvk_in_col0 = (col0);
        PxVec3 pvk_in_col1 = (col1);
        PxVec3 pvk_in_col2 = (col2);
        PxVec3 pvk_in_col3 = (col3);
        var _new = (W_PxMat44_R_PxMat44_P_PxVec3_P_PxVec3_P_PxVec3_P_PxVec3_C_PxMat44_ctor(pvk_in_col0, pvk_in_col1, pvk_in_col2, pvk_in_col3));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(float[] values)                                                #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type float[]
    // NATIVE SIG: explicit PX_CUDA_CALLABLE PX_INLINE PxMat44(float values[])
    	: column0(values[0], values[1], values[2], values[3])
    	, column1(values[4], values[5], values[6], values[7])
    	, column2(values[8], values[9], values[10], values[11])
    	, column3(values[12], values[13], values[14], values[15])
    	{
    	}
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P__C_PxMat44_ctor( values){
        auto nat_in_values = (values);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P__C_PxMat44_ctor( values);
    
    public  PxMat44( values){
         pvk_in_values = (values);
        var _new = (W_PxMat44_R_PxMat44_P__C_PxMat44_ctor(pvk_in_values));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxMat44(PxQuatPtr q)                                                   #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxQuat_C_PxMat44_ctor(physx::PxQuat q){
        auto nat_in_q = (q);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxQuat_C_PxMat44_ctor(PxQuat q);
    
    public  PxMat44(PxQuat q){
        PxQuat pvk_in_q = (q);
        var _new = (W_PxMat44_R_PxMat44_P_PxQuat_C_PxMat44_ctor(pvk_in_q));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(PxVec4Ptr diagonal)                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxVec4_C_PxMat44_ctor(physx::PxVec4 diagonal){
        auto nat_in_diagonal = (diagonal);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxVec4_C_PxMat44_ctor(PxVec4 diagonal);
    
    public  PxMat44(PxVec4 diagonal){
        PxVec4 pvk_in_diagonal = (diagonal);
        var _new = (W_PxMat44_R_PxMat44_P_PxVec4_C_PxMat44_ctor(pvk_in_diagonal));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(PxMat33Ptr axes, PxVec3Ptr position)                           #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxMat33_P_PxVec3_C_PxMat44_ctor(physx::PxMat33 axes, physx::PxVec3 position){
        auto nat_in_axes = (axes);
        auto nat_in_position = (position);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxMat33_P_PxVec3_C_PxMat44_ctor(PxMat33 axes, PxVec3 position);
    
    public  PxMat44(PxMat33 axes, PxVec3 position){
        PxMat33 pvk_in_axes = (axes);
        PxVec3 pvk_in_position = (position);
        var _new = (W_PxMat44_R_PxMat44_P_PxMat33_P_PxVec3_C_PxMat44_ctor(pvk_in_axes, pvk_in_position));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(PxTransformPtr t)                                              #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxTransform_C_PxMat44_ctor(physx::PxTransform t){
        auto nat_in_t = (t);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxTransform_C_PxMat44_ctor(PxTransform t);
    
    public  PxMat44(PxTransform t){
        PxTransform pvk_in_t = (t);
        var _new = (W_PxMat44_R_PxMat44_P_PxTransform_C_PxMat44_ctor(pvk_in_t));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator==(PxMat44Ptr m)                                               #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxMat44_C_PxMat44(physx::PxMat44 self, physx::PxMat44 m){
        auto nat_in_m = (m);
        auto retVal = self.operator==(nat_in_m);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxMat44_C_PxMat44(PxMat44 selfBlt, PxMat44 m);
    
    public static bool operator==(PxMat44 lhs, PxMat44 m){
        PxMat44 pvk_in_m = (m);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxMat44_C_PxMat44(lhs, pvk_in_m);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat44(PxMat44Ptr other)                                              #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_PxMat44_R_PxMat44_P_PxMat44_C_PxMat44_ctor(physx::PxMat44 other){
        auto nat_in_other = (other);
        auto val = PxMat44();
        return *(PxMat44POD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_R_PxMat44_P_PxMat44_C_PxMat44_ctor(PxMat44 other);
    
    public  PxMat44(PxMat44 other){
        PxMat44 pvk_in_other = (other);
        var _new = (W_PxMat44_R_PxMat44_P_PxMat44_C_PxMat44_ctor(pvk_in_other));
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator=(PxMat44Ptr other)                                            #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       getTranspose()                                                         #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_getTranspose_R_PxMat44_C_PxMat44(physx::PxMat44 self){
        auto retVal = self.getTranspose;
        return *(PxMat44POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_getTranspose_R_PxMat44_C_PxMat44(PxMat44 selfBlt);
    
    public  PxMat44 getTranspose(){
        PxMat44 retVal = W_getTranspose_R_PxMat44_C_PxMat44(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_OP_Minus_R_PxMat44_C_PxMat44(physx::PxMat44 self){
        auto retVal = self.operator-;
        return *(PxMat44POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Minus_R_PxMat44_C_PxMat44(PxMat44 selfBlt);
    
    public static PxMat44 operator-(PxMat44 lhs){
        PxMat44 retVal = W_OP_Minus_R_PxMat44_C_PxMat44(lhs);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+(PxMat44Ptr other)                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_OP_Plus_R_PxMat44_P_PxMat44_C_PxMat44(physx::PxMat44 self, physx::PxMat44 other){
        auto nat_in_other = (other);
        auto retVal = self.operator+;
        return *(PxMat44POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Plus_R_PxMat44_P_PxMat44_C_PxMat44(PxMat44 selfBlt, PxMat44 other);
    
    public static PxMat44 operator+(PxMat44 lhs, PxMat44 other){
        PxMat44 pvk_in_other = (other);
        PxMat44 retVal = W_OP_Plus_R_PxMat44_P_PxMat44_C_PxMat44(lhs, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-(PxMat44Ptr other)                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_OP_Minus_R_PxMat44_P_PxMat44_C_PxMat44(physx::PxMat44 self, physx::PxMat44 other){
        auto nat_in_other = (other);
        auto retVal = self.operator-;
        return *(PxMat44POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Minus_R_PxMat44_P_PxMat44_C_PxMat44(PxMat44 selfBlt, PxMat44 other);
    
    public static PxMat44 operator-(PxMat44 lhs, PxMat44 other){
        PxMat44 pvk_in_other = (other);
        PxMat44 retVal = W_OP_Minus_R_PxMat44_P_PxMat44_C_PxMat44(lhs, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*(float scalar)                                                #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_OP_Star_R_PxMat44_P_float_C_PxMat44(physx::PxMat44 self, float scalar){
        auto nat_in_scalar = (scalar);
        auto retVal = self.operator*;
        return *(PxMat44POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Star_R_PxMat44_P_float_C_PxMat44(PxMat44 selfBlt, float scalar);
    
    public static PxMat44 operator*(PxMat44 lhs, float scalar){
        float pvk_in_scalar = (scalar);
        PxMat44 retVal = W_OP_Star_R_PxMat44_P_float_C_PxMat44(lhs, pvk_in_scalar);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*(PxMat44Ptr other)                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_OP_Star_R_PxMat44_P_PxMat44_C_PxMat44(physx::PxMat44 self, physx::PxMat44 other){
        auto nat_in_other = (other);
        auto retVal = self.operator*;
        return *(PxMat44POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Star_R_PxMat44_P_PxMat44_C_PxMat44(PxMat44 selfBlt, PxMat44 other);
    
    public static PxMat44 operator*(PxMat44 lhs, PxMat44 other){
        PxMat44 pvk_in_other = (other);
        PxMat44 retVal = W_OP_Star_R_PxMat44_P_PxMat44_C_PxMat44(lhs, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+=(PxMat44Ptr other)                                           #
    //================================================================================
    //Skipped unsupported operator PlusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator-=(PxMat44Ptr other)                                           #
    //================================================================================
    //Skipped unsupported operator MinusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=(float scalar)                                               #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=(PxMat44Ptr other)                                           #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator()(uint row, uint col)                                         #
    //================================================================================
    //Skipped unsupported operator Call.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator()(uint row, uint col)                                         #
    //================================================================================
    //Skipped unsupported operator Call.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       transform(PxVec4Ptr other)                                             #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_transform_R_PxVec4_P_PxVec4_C_PxMat44(physx::PxMat44 self, physx::PxVec4 other){
        auto nat_in_other = (other);
        auto retVal = self.transform;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_transform_R_PxVec4_P_PxVec4_C_PxMat44(PxMat44 selfBlt, PxVec4 other);
    
    public  PxVec4 transform(PxVec4 other){
        PxVec4 pvk_in_other = (other);
        PxVec4 retVal = W_transform_R_PxVec4_P_PxVec4_C_PxMat44(this, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transform(PxVec3Ptr other)                                             #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_transform_R_PxVec3_P_PxVec3_C_PxMat44(physx::PxMat44 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.transform;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform_R_PxVec3_P_PxVec3_C_PxMat44(PxMat44 selfBlt, PxVec3 other);
    
    public  PxVec3 transform(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_transform_R_PxVec3_P_PxVec3_C_PxMat44(this, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       rotate(PxVec4Ptr other)                                                #
    //================================================================================
    #if NATIVE //function start
    ES PxVec4POD W_rotate_R_PxVec4_P_PxVec4_C_PxMat44(physx::PxMat44 self, physx::PxVec4 other){
        auto nat_in_other = (other);
        auto retVal = self.rotate;
        return *(PxVec4POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_rotate_R_PxVec4_P_PxVec4_C_PxMat44(PxMat44 selfBlt, PxVec4 other);
    
    public  PxVec4 rotate(PxVec4 other){
        PxVec4 pvk_in_other = (other);
        PxVec4 retVal = W_rotate_R_PxVec4_P_PxVec4_C_PxMat44(this, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       rotate(PxVec3Ptr other)                                                #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_rotate_R_PxVec3_P_PxVec3_C_PxMat44(physx::PxMat44 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.rotate;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotate_R_PxVec3_P_PxVec3_C_PxMat44(PxMat44 selfBlt, PxVec3 other);
    
    public  PxVec3 rotate(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_rotate_R_PxVec3_P_PxVec3_C_PxMat44(this, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getBasis(int num)                                                      #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getBasis_R_PxVec3_P_int_C_PxMat44(physx::PxMat44 self, int num){
        auto nat_in_num = (num);
        auto retVal = self.getBasis;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasis_R_PxVec3_P_int_C_PxMat44(PxMat44 selfBlt, int num);
    
    public  PxVec3 getBasis(int num){
        int pvk_in_num = (num);
        PxVec3 retVal = W_getBasis_R_PxVec3_P_int_C_PxMat44(this, pvk_in_num);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getPosition()                                                          #
    //================================================================================
    #if NATIVE //function start
    ES PxVec3POD W_getPosition_R_PxVec3_C_PxMat44(physx::PxMat44 self){
        auto retVal = self.getPosition;
        return *(PxVec3POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getPosition_R_PxVec3_C_PxMat44(PxMat44 selfBlt);
    
    public  PxVec3 getPosition(){
        PxVec3 retVal = W_getPosition_R_PxVec3_C_PxMat44(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       setPosition(PxVec3Ptr position)                                        #
    //================================================================================
    #if NATIVE //function start
    ES void W_setPosition_R_void_P_PxVec3_C_PxMat44(physx::PxMat44 self, physx::PxVec3 position){
        auto nat_in_position = (position);
        self.setPosition(nat_in_position);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setPosition_R_void_P_PxVec3_C_PxMat44(PxMat44 selfBlt, PxVec3 position);
    
    public  void setPosition(PxVec3 position){
        PxVec3 pvk_in_position = (position);
        W_setPosition_R_void_P_PxVec3_C_PxMat44(this, pvk_in_position);
    }
    #endif //function end
    
    
    //================================================================================
    //#       front()                                                                #
    //================================================================================
    #if NATIVE //function start
    ES const float* W_front_R_floatPtr_C_PxMat44(physx::PxMat44 self){
        auto retVal = self.front();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_front_R_floatPtr_C_PxMat44(PxMat44 selfBlt);
    
    public  IntPtr front(){
        IntPtr retVal = W_front_R_floatPtr_C_PxMat44(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator[](uint num)                                                   #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator[](uint num)                                                   #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       scale(PxVec4Ptr p)                                                     #
    //================================================================================
    #if NATIVE //function start
    ES void W_scale_R_void_P_PxVec4_C_PxMat44(physx::PxMat44 self, physx::PxVec4 p){
        auto nat_in_p = (p);
        self.scale(nat_in_p);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_scale_R_void_P_PxVec4_C_PxMat44(PxMat44 selfBlt, PxVec4 p);
    
    public  void scale(PxVec4 p){
        PxVec4 pvk_in_p = (p);
        W_scale_R_void_P_PxVec4_C_PxMat44(this, pvk_in_p);
    }
    #endif //function end
    
    
    //================================================================================
    //#       inverseRT()                                                            #
    //================================================================================
    #if NATIVE //function start
    ES PxMat44POD W_inverseRT_R_PxMat44_C_PxMat44(physx::PxMat44 self){
        auto retVal = self.inverseRT;
        return *(PxMat44POD*)&retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_inverseRT_R_PxMat44_C_PxMat44(PxMat44 selfBlt);
    
    public  PxMat44 inverseRT(){
        PxMat44 retVal = W_inverseRT_R_PxMat44_C_PxMat44(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       isFinite()                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isFinite_R_bool_C_PxMat44(physx::PxMat44 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite_R_bool_C_PxMat44(PxMat44 selfBlt);
    
    public  bool isFinite(){
        bool retVal = W_isFinite_R_bool_C_PxMat44(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: ~PxMat44
    

#if !NATIVE //struct close
}
#endif //struct close
