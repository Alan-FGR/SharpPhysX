#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxMat33 {

//================================================================================
//#       operator*                                                              #
//================================================================================
/* ERRORS OCCURED: Invalid parameter name (empty)
Invalid parameter name (empty)
// NATIVE SIG: PxMat33 operator*(float, const PxMat33&)
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L259~259
#if NATIVE
ES physx::PxMat33 W_OP_Star(float , physx::PxMat33 ){
    auto nat_in_ = ();
    auto nat_in_ = ();
    auto retVal = physx::operator*(nat_in_, nat_in_);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxMat33 W_OP_Star(float , PxMat33 );

public static PxMat33 operator*(float , PxMat33 ){
    float pvk_in_ = ();
    PxMat33 pvk_in_ = ();
    PxMat33 retVal = W_OP_Star(pvk_in_, pvk_in_);
    return retVal;
}
#endif*/

} // End PxMat33


#if !NATIVE
public unsafe partial struct PxMat33 { // blittable
    public PxVec3 column0;
    public PxVec3 column1;
    public PxVec3 column2;

#endif

    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // NATIVE SIG: PX_FORCE_INLINE PxMat33()
    	{
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L94~96
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor(){
        self.PxMat33();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor();
    
    public PxMat33(){
        var _new = W_PxMat33_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L99~103
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        self.PxMat33(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor(PxIDENTITY r);
    
    public PxMat33(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = W_PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L106~109
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        self.PxMat33(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor(PxZERO r);
    
    public PxMat33(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = W_PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L112~115
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor(physx::PxVec3 col0, physx::PxVec3 col1, physx::PxVec3 col2){
        auto nat_in_col0 = (col0);
        auto nat_in_col1 = (col1);
        auto nat_in_col2 = (col2);
        self.PxMat33(nat_in_col0, nat_in_col1, nat_in_col2);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor(PxVec3 col0, PxVec3 col1, PxVec3 col2);
    
    public PxMat33(PxVec3 col0, PxVec3 col1, PxVec3 col2){
        PxVec3 pvk_in_col0 = (col0);
        PxVec3 pvk_in_col1 = (col1);
        PxVec3 pvk_in_col2 = (col2);
        var _new = W_PxMat33_ctor(pvk_in_col0, pvk_in_col1, pvk_in_col2);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L118~121
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor(float r){
        auto nat_in_r = (r);
        self.PxMat33(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor(float r);
    
    public PxMat33(float r){
        float pvk_in_r = (r);
        var _new = W_PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxMat33::PxMat33::values
    // NATIVE SIG: explicit PX_CUDA_CALLABLE PX_INLINE PxMat33(float values[])
    	: column0(values[0], values[1], values[2])
    	, column1(values[3], values[4], values[5])
    	, column2(values[6], values[7], values[8])
    	{
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L124~129
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor( values){
        auto nat_in_values = (values);
        self.PxMat33(nat_in_values);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor( values);
    
    public PxMat33( values){
         pvk_in_values = (values);
        var _new = W_PxMat33_ctor(pvk_in_values);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L132~158
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor(physx::PxQuat q){
        auto nat_in_q = (q);
        self.PxMat33(nat_in_q);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor(PxQuat q);
    
    public PxMat33(PxQuat q){
        PxQuat pvk_in_q = (q);
        var _new = W_PxMat33_ctor(pvk_in_q);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L161~164
    #if NATIVE
    ES physx::PxMat33 W_PxMat33_ctor(physx::PxMat33 other){
        auto nat_in_other = (other);
        self.PxMat33(nat_in_other);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_PxMat33_ctor(PxMat33 other);
    
    public PxMat33(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        var _new = W_PxMat33_ctor(pvk_in_other);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxMat33& operator=(const PxMat33& other)
    	{
    		column0 = other.column0;
    		column1 = other.column1;
    		column2 = other.column2;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L167~173
    #if NATIVE
    ES physx::PxMat33* W_operator=(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = &self.operator=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_operator=(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator=(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_operator=(lhs, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createDiagonal                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L176~179
    #if NATIVE
    ES physx::PxMat33 W_createDiagonal(physx::PxMat33 self, physx::PxVec3 d){
        auto nat_in_d = (d);
        auto retVal = self.createDiagonal(nat_in_d);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_createDiagonal(PxMat33 selfBlt, PxVec3 d);
    
    public PxMat33 createDiagonal(PxVec3 d){
        PxVec3 pvk_in_d = (d);
        PxMat33 retVal = W_createDiagonal(this, pvk_in_d);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L184~187
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxMat33 self, physx::PxMat33 m){
        auto nat_in_m = (m);
        auto retVal = self.operator==(nat_in_m);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxMat33 selfBlt, PxMat33 m);
    
    public static bool operator==(PxMat33 lhs, PxMat33 m){
        PxMat33 pvk_in_m = (m);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_m);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getTranspose                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L190~197
    #if NATIVE
    ES physx::PxMat33 W_getTranspose(physx::PxMat33 self){
        auto retVal = self.getTranspose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_getTranspose(PxMat33 selfBlt);
    
    public PxMat33 getTranspose(){
        PxMat33 retVal = W_getTranspose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInverse                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L200~227
    #if NATIVE
    ES physx::PxMat33 W_getInverse(physx::PxMat33 self){
        auto retVal = self.getInverse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_getInverse(PxMat33 selfBlt);
    
    public PxMat33 getInverse(){
        PxMat33 retVal = W_getInverse(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getDeterminant                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L230~233
    #if NATIVE
    ES float W_getDeterminant(physx::PxMat33 self){
        auto retVal = self.getDeterminant();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getDeterminant(PxMat33 selfBlt);
    
    public float getDeterminant(){
        float retVal = W_getDeterminant(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L236~239
    #if NATIVE
    ES physx::PxMat33 W_OP_Minus(physx::PxMat33 self){
        auto retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Minus(PxMat33 selfBlt);
    
    public static PxMat33 operator-(PxMat33 lhs){
        PxMat33 retVal = W_OP_Minus(lhs);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L242~245
    #if NATIVE
    ES physx::PxMat33 W_OP_Plus(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = self.operator+(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Plus(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator+(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_OP_Plus(lhs, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L248~251
    #if NATIVE
    ES physx::PxMat33 W_OP_Minus(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = self.operator-(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Minus(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator-(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_OP_Minus(lhs, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L254~257
    #if NATIVE
    ES physx::PxMat33 W_OP_Star(physx::PxMat33 self, float scalar){
        auto nat_in_scalar = (scalar);
        auto retVal = self.operator*(nat_in_scalar);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Star(PxMat33 selfBlt, float scalar);
    
    public static PxMat33 operator*(PxMat33 lhs, float scalar){
        float pvk_in_scalar = (scalar);
        PxMat33 retVal = W_OP_Star(lhs, pvk_in_scalar);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L262~265
    #if NATIVE
    ES physx::PxVec3 W_OP_Star(physx::PxMat33 self, physx::PxVec3 vec){
        auto nat_in_vec = (vec);
        auto retVal = self.operator*(nat_in_vec);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Star(PxMat33 selfBlt, PxVec3 vec);
    
    public static PxVec3 operator*(PxMat33 lhs, PxVec3 vec){
        PxVec3 pvk_in_vec = (vec);
        PxVec3 retVal = W_OP_Star(lhs, pvk_in_vec);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L270~275
    #if NATIVE
    ES physx::PxMat33 W_OP_Star(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = self.operator*(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_OP_Star(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator*(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_OP_Star(lhs, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator+=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxMat33& operator+=(const PxMat33& other)
    	{
    		column0 += other.column0;
    		column1 += other.column1;
    		column2 += other.column2;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L278~284
    #if NATIVE
    ES physx::PxMat33* W_operator+=(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = &self.operator+=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_operator+=(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator+=(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_operator+=(lhs, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxMat33& operator-=(const PxMat33& other)
    	{
    		column0 -= other.column0;
    		column1 -= other.column1;
    		column2 -= other.column2;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L287~293
    #if NATIVE
    ES physx::PxMat33* W_operator-=(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = &self.operator-=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_operator-=(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator-=(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_operator-=(lhs, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxMat33& operator*=(float scalar)
    	{
    		column0 *= scalar;
    		column1 *= scalar;
    		column2 *= scalar;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L296~302
    #if NATIVE
    ES physx::PxMat33* W_operator*=(physx::PxMat33 self, float scalar){
        auto nat_in_scalar = (scalar);
        auto retVal = &self.operator*=(nat_in_scalar);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_operator*=(PxMat33 selfBlt, float scalar);
    
    public static PxMat33 operator*=(PxMat33 lhs, float scalar){
        float pvk_in_scalar = (scalar);
        PxMat33 retVal = W_operator*=(lhs, pvk_in_scalar);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxMat33& operator*=(const PxMat33& other)
    	{
    		*this = *this * other;
    		return *this;
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L305~309
    #if NATIVE
    ES physx::PxMat33* W_operator*=(physx::PxMat33 self, physx::PxMat33 other){
        auto nat_in_other = (other);
        auto retVal = &self.operator*=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 W_operator*=(PxMat33 selfBlt, PxMat33 other);
    
    public static PxMat33 operator*=(PxMat33 lhs, PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = W_operator*=(lhs, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: float operator()(unsigned int row, unsigned int col) const
    	{
    		return (*this)[col][row];
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L312~315
    #if NATIVE
    ES float W_operator()(physx::PxMat33 self, unsigned int row, unsigned int col){
        auto nat_in_row = (row);
        auto nat_in_col = (col);
        auto retVal = self.operator()(nat_in_row, nat_in_col);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_operator()(PxMat33 selfBlt, uint row, uint col);
    
    public static float operator()(PxMat33 lhs, uint row, uint col){
        uint pvk_in_row = (row);
        uint pvk_in_col = (col);
        float retVal = W_operator()(lhs, pvk_in_row, pvk_in_col);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: float& operator()(unsigned int row, unsigned int col)
    	{
    		return (*this)[col][row];
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L318~321
    #if NATIVE
    ES float* W_operator()(physx::PxMat33 self, unsigned int row, unsigned int col){
        auto nat_in_row = (row);
        auto nat_in_col = (col);
        auto retVal = self.operator()(nat_in_row, nat_in_col);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_operator()(PxMat33 selfBlt, uint row, uint col);
    
    public static IntPtr operator()(PxMat33 lhs, uint row, uint col){
        uint pvk_in_row = (row);
        uint pvk_in_col = (col);
        IntPtr retVal = W_operator()(lhs, pvk_in_row, pvk_in_col);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L326~329
    #if NATIVE
    ES physx::PxVec3 W_transform(physx::PxMat33 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.transform(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform(PxMat33 selfBlt, PxVec3 other);
    
    public PxVec3 transform(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_transform(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformTranspose                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L332~335
    #if NATIVE
    ES physx::PxVec3 W_transformTranspose(physx::PxMat33 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.transformTranspose(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transformTranspose(PxMat33 selfBlt, PxVec3 other);
    
    public PxVec3 transformTranspose(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_transformTranspose(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       front                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L337~340
    #if NATIVE
    ES float* W_front(physx::PxMat33 self){
        auto retVal = self.front();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_front(PxMat33 selfBlt);
    
    public IntPtr front(){
        IntPtr retVal = W_front(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxVec3& operator[](unsigned int num)
    	{
    		return (&column0)[num];
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L342~345
    #if NATIVE
    ES physx::PxVec3* W_operator[](physx::PxMat33 self, unsigned int num){
        auto nat_in_num = (num);
        auto retVal = &self.operator[](nat_in_num);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_operator[](PxMat33 selfBlt, uint num);
    
    public static PxVec3 operator[](PxMat33 lhs, uint num){
        uint pvk_in_num = (num);
        PxVec3 retVal = W_operator[](lhs, pvk_in_num);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // NATIVE SIG: PxVec3& operator[](unsigned int num) const
    	{
    		return (&column0)[num];
    	}
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L346~349
    #if NATIVE
    ES physx::PxVec3* W_operator[](physx::PxMat33 self, unsigned int num){
        auto nat_in_num = (num);
        auto retVal = &self.operator[](nat_in_num);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_operator[](PxMat33 selfBlt, uint num);
    
    public static PxVec3 operator[](PxMat33 lhs, uint num){
        uint pvk_in_num = (num);
        PxVec3 retVal = W_operator[](lhs, pvk_in_num);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxMat33                                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxMat33
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L90~90
    #if NATIVE
    ES void W_~PxMat33(physx::PxMat33 self){
        self.~PxMat33();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxMat33(PxMat33 selfBlt);
    
    public void ~PxMat33(){
        W_~PxMat33(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
