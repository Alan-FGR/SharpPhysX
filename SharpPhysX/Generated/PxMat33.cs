#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes


#if !NATIVE
public partial struct PxMat33 {
#endif

//================================================================================
//#       operator*                                                              #
//================================================================================
/* ERRORS OCCURED: Invalid parameter name (empty)
Invalid parameter name (empty)
// NATIVE SIG: PxMat33 operator*(float, const PxMat33&)
#if NATIVE //function start
ES physx::PxMat33 W_OP_Star_R_PxMat33_P_float_P_PxMat33(float , physx::PxMat33 ){
    auto nat_in_ = ();
    auto nat_in_ = ();
    auto retVal = physx::operator*(nat_in_, nat_in_);
    return retVal;
}
#else //end C wrapper, start C#
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxMat33 W_OP_Star_R_PxMat33_P_float_P_PxMat33(float , PxMat33 );

public static PxMat33 operator*(float , PxMat33 ){
    float pvk_in_ = ();
    PxMat33 pvk_in_ = ();
    PxMat33 retVal = W_OP_Star_R_PxMat33_P_float_P_PxMat33(pvk_in_, pvk_in_);
    return retVal;
}
#endif //function end*/

#if !NATIVE
} // End PxMat33
#endif


#if !NATIVE //interface
public unsafe interface IPxMat33 {
    // PxMat33();
    // PxMat33(PxIDENTITY r);
    // PxMat33(PxZERO r);
    // PxMat33(PxVec3 col0, PxVec3 col1, PxVec3 col2);
    // PxMat33(float r);
    // PxMat33( values);
    // PxMat33(PxQuat q);
    // PxMat33(PxMat33 other);
    //static PxMat33 operator=(PxMat33 lhs, /*NULLPARS*/);
     PxMat33 createDiagonal(PxVec3 d);
    //static bool operator==(PxMat33 lhs, PxMat33 m);
     PxMat33 getTranspose();
     PxMat33 getInverse();
     float getDeterminant();
    //static PxMat33 operator-(PxMat33 lhs);
    //static PxMat33 operator+(PxMat33 lhs, PxMat33 other);
    //static PxMat33 operator-(PxMat33 lhs, PxMat33 other);
    //static PxMat33 operator*(PxMat33 lhs, float scalar);
    //static PxVec3 operator*(PxMat33 lhs, PxVec3 vec);
    //static PxMat33 operator*(PxMat33 lhs, PxMat33 other);
    //static PxMat33 operator+=(PxMat33 lhs, /*NULLPARS*/);
    //static PxMat33 operator-=(PxMat33 lhs, /*NULLPARS*/);
    //static PxMat33 operator*=(PxMat33 lhs, /*NULLPARS*/);
    //static PxMat33 operator*=(PxMat33 lhs, /*NULLPARS*/);
    //static float operator()(PxMat33 lhs, /*NULLPARS*/);
    //static IntPtr operator()(PxMat33 lhs, /*NULLPARS*/);
     PxVec3 transform(PxVec3 other);
     PxVec3 transformTranspose(PxVec3 other);
     IntPtr front();
    //static PxVec3 operator[](PxMat33 lhs, /*NULLPARS*/);
    //static PxVec3 operator[](PxMat33 lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxMat33(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxMat33 : IPxMat33 { // blittable
    public PxVec3 column0;
    public PxVec3 column1;
    public PxVec3 column2;

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxMat33
    #endif //hierarchy
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_PxMat33_R_PxMat33_P_PxIDENTITY_C_PxMat33_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        return PxMat33(nat_in_r);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_R_PxMat33_P_PxIDENTITY_C_PxMat33_ctor(PxIDENTITY r);
    
    public  PxMat33(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = W_PxMat33_R_PxMat33_P_PxIDENTITY_C_PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_PxMat33_R_PxMat33_P_PxZERO_C_PxMat33_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        return PxMat33(nat_in_r);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_R_PxMat33_P_PxZERO_C_PxMat33_ctor(PxZERO r);
    
    public  PxMat33(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = W_PxMat33_R_PxMat33_P_PxZERO_C_PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_PxMat33_R_PxMat33_P_PxVec3_P_PxVec3_P_PxVec3_C_PxMat33_ctor(physx::PxVec3 col0, physx::PxVec3 col1, physx::PxVec3 col2){
        auto nat_in_col0 = (col0);
        auto nat_in_col1 = (col1);
        auto nat_in_col2 = (col2);
        return PxMat33(nat_in_col0, nat_in_col1, nat_in_col2);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_R_PxMat33_P_PxVec3_P_PxVec3_P_PxVec3_C_PxMat33_ctor(PxVec3 col0, PxVec3 col1, PxVec3 col2);
    
    public  PxMat33(PxVec3 col0, PxVec3 col1, PxVec3 col2){
        PxVec3 pvk_in_col0 = (col0);
        PxVec3 pvk_in_col1 = (col1);
        PxVec3 pvk_in_col2 = (col2);
        var _new = W_PxMat33_R_PxMat33_P_PxVec3_P_PxVec3_P_PxVec3_C_PxMat33_ctor(pvk_in_col0, pvk_in_col1, pvk_in_col2);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_PxMat33_R_PxMat33_P_float_C_PxMat33_ctor(float r){
        auto nat_in_r = (r);
        return PxMat33(nat_in_r);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_R_PxMat33_P_float_C_PxMat33_ctor(float r);
    
    public  PxMat33(float r){
        float pvk_in_r = (r);
        var _new = W_PxMat33_R_PxMat33_P_float_C_PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type float[]
    // NATIVE SIG: explicit PX_CUDA_CALLABLE PX_INLINE PxMat33(float values[])
    	: column0(values[0], values[1], values[2])
    	, column1(values[3], values[4], values[5])
    	, column2(values[6], values[7], values[8])
    	{
    	}
    #if NATIVE //function start
    ES physx::PxMat33 W_PxMat33_R_PxMat33_P__C_PxMat33_ctor( values){
        auto nat_in_values = (values);
        return PxMat33(nat_in_values);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_R_PxMat33_P__C_PxMat33_ctor( values);
    
    public  PxMat33( values){
         pvk_in_values = (values);
        var _new = W_PxMat33_R_PxMat33_P__C_PxMat33_ctor(pvk_in_values);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_PxMat33_R_PxMat33_P_PxQuat_C_PxMat33_ctor(physx::PxQuat q){
        auto nat_in_q = (q);
        return PxMat33(nat_in_q);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_R_PxMat33_P_PxQuat_C_PxMat33_ctor(PxQuat q);
    
    public  PxMat33(PxQuat q){
        PxQuat pvk_in_q = (q);
        var _new = W_PxMat33_R_PxMat33_P_PxQuat_C_PxMat33_ctor(pvk_in_q);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_PxMat33_R_PxMat33_P_PxMat33_C_PxMat33_ctor(physx::PxMat33 other){
        auto nat_in_other = (other);
        return PxMat33(nat_in_other);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_R_PxMat33_P_PxMat33_C_PxMat33_ctor(PxMat33 other);
    
    public  PxMat33(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        var _new = W_PxMat33_R_PxMat33_P_PxMat33_C_PxMat33_ctor(pvk_in_other);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       createDiagonal                                                         #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_createDiagonal_R_PxMat33_P_PxVec3_C_PxMat33(physx::PxMat33 self, physx::PxVec3 d){
        auto nat_in_d = (d);
        auto retVal = self.createDiagonal(nat_in_d);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_createDiagonal_R_PxMat33_P_PxVec3_C_PxMat33(PxMat33 selfBlt, PxVec3 d);
    
    public  PxMat33 createDiagonal(PxVec3 d){
        PxVec3 pvk_in_d = (d);
        PxMat33 retVal = W_createDiagonal_R_PxMat33_P_PxVec3_C_PxMat33(this, pvk_in_d);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    #if NATIVE //function start
    ES bool W_OP_EqualEqual_R_bool_P_PxMat33_C_PxMat33(physx::PxMat33 self, physx::PxMat33 m){
        auto nat_in_m = (m);
        auto retVal = self.operator==(nat_in_m);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual_R_bool_P_PxMat33_C_PxMat33(PxMat33 selfBlt, PxMat33 m);
    
    public static bool operator==(PxMat33 lhs, PxMat33 m){
        PxMat33 pvk_in_m = (m);
        bool retVal = W_OP_EqualEqual_R_bool_P_PxMat33_C_PxMat33(lhs, pvk_in_m);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getTranspose                                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_getTranspose_R_PxMat33_C_PxMat33(physx::PxMat33 self){
        auto retVal = self.getTranspose();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_getTranspose_R_PxMat33_C_PxMat33(PxMat33 selfBlt);
    
    public  PxMat33 getTranspose(){
        PxMat33 retVal = W_getTranspose_R_PxMat33_C_PxMat33(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getInverse                                                             #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_getInverse_R_PxMat33_C_PxMat33(physx::PxMat33 self){
        auto retVal = self.getInverse();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_getInverse_R_PxMat33_C_PxMat33(PxMat33 selfBlt);
    
    public  PxMat33 getInverse(){
        PxMat33 retVal = W_getInverse_R_PxMat33_C_PxMat33(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getDeterminant                                                         #
    //================================================================================
    #if NATIVE //function start
    ES float W_getDeterminant_R_float_C_PxMat33(physx::PxMat33 self){
        auto retVal = self.getDeterminant();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getDeterminant_R_float_C_PxMat33(PxMat33 selfBlt);
    
    public  float getDeterminant(){
        float retVal = W_getDeterminant_R_float_C_PxMat33(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_OP_Minus_R_PxMat33_C_PxMat33(physx::PxMat33 self){
        auto retVal = self.operator-();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Minus_R_PxMat33_C_PxMat33(PxMat33 selfBlt);
    
    public static PxMat33 operator-(PxMat33 lhs){
        PxMat33 retVal = W_OP_Minus_R_PxMat33_C_PxMat33(lhs);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_OP_Plus_R_PxMat33_P_PxMat33_C_PxMat33(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = self.operator+(nat_in_other);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Plus_R_PxMat33_P_PxMat33_C_PxMat33(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator+(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_OP_Plus_R_PxMat33_P_PxMat33_C_PxMat33(lhs, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_OP_Minus_R_PxMat33_P_PxMat33_C_PxMat33(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = self.operator-(nat_in_other);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Minus_R_PxMat33_P_PxMat33_C_PxMat33(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator-(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_OP_Minus_R_PxMat33_P_PxMat33_C_PxMat33(lhs, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_OP_Star_R_PxMat33_P_float_C_PxMat33(physx::PxMat33 self, float scalar){
        auto nat_in_scalar = (scalar);
        auto retVal = self.operator*(nat_in_scalar);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Star_R_PxMat33_P_float_C_PxMat33(PxMat33 selfBlt, float scalar);
    
    public static PxMat33 operator*(PxMat33 lhs, float scalar){
        float pvk_in_scalar = (scalar);
        PxMat33 retVal = W_OP_Star_R_PxMat33_P_float_C_PxMat33(lhs, pvk_in_scalar);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3 W_OP_Star_R_PxVec3_P_PxVec3_C_PxMat33(physx::PxMat33 self, physx::PxVec3 vec){
        auto nat_in_vec = (vec);
        auto retVal = self.operator*(nat_in_vec);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Star_R_PxVec3_P_PxVec3_C_PxMat33(PxMat33 selfBlt, PxVec3 vec);
    
    public static PxVec3 operator*(PxMat33 lhs, PxVec3 vec){
        PxVec3 pvk_in_vec = (vec);
        PxVec3 retVal = W_OP_Star_R_PxVec3_P_PxVec3_C_PxMat33(lhs, pvk_in_vec);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxMat33 W_OP_Star_R_PxMat33_P_PxMat33_C_PxMat33(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = self.operator*(nat_in_other);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Star_R_PxMat33_P_PxMat33_C_PxMat33(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator*(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_OP_Star_R_PxMat33_P_PxMat33_C_PxMat33(lhs, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator+=                                                             #
    //================================================================================
    //Skipped unsupported operator PlusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator-=                                                             #
    //================================================================================
    //Skipped unsupported operator MinusEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    //Skipped unsupported operator StarEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    //Skipped unsupported operator Call.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    //Skipped unsupported operator Call.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3 W_transform_R_PxVec3_P_PxVec3_C_PxMat33(physx::PxMat33 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.transform(nat_in_other);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform_R_PxVec3_P_PxVec3_C_PxMat33(PxMat33 selfBlt, PxVec3 other);
    
    public  PxVec3 transform(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_transform_R_PxVec3_P_PxVec3_C_PxMat33(this, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       transformTranspose                                                     #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxVec3 W_transformTranspose_R_PxVec3_P_PxVec3_C_PxMat33(physx::PxMat33 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.transformTranspose(nat_in_other);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transformTranspose_R_PxVec3_P_PxVec3_C_PxMat33(PxMat33 selfBlt, PxVec3 other);
    
    public  PxVec3 transformTranspose(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_transformTranspose_R_PxVec3_P_PxVec3_C_PxMat33(this, pvk_in_other);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       front                                                                  #
    //================================================================================
    #if NATIVE //function start
    ES const float* W_front_R_floatPtr_C_PxMat33(physx::PxMat33 self){
        auto retVal = self.front();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_front_R_floatPtr_C_PxMat33(PxMat33 selfBlt);
    
    public  IntPtr front(){
        IntPtr retVal = W_front_R_floatPtr_C_PxMat33(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //Skipped generated implicit entry: ~PxMat33
    

#if !NATIVE //struct close
}
#endif //struct close
