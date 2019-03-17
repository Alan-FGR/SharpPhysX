#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxMat33 {
#endif

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

#if !NATIVE
} // End PxMat33
#endif


#if !NATIVE
public unsafe partial struct PxMat33 { // blittable
    public PxVec3 column0;
    public PxVec3 column1;
    public PxVec3 column2;

#endif

    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
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
    /* ERRORS OCCURED: Unresolved parameter type float[]
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
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
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
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    //Skipped unsupported operator Subscript.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //Skipped generated implicit entry: ~PxMat33
    

#if !NATIVE
}
#endif
