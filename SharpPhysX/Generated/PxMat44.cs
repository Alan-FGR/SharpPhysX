#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxMat44 {
#endif

//================================================================================
//#       operator*                                                              #
//================================================================================
/* ERRORS OCCURED: Invalid parameter name (empty)
Invalid parameter name (empty)
// NATIVE SIG: PxMat44 operator*(float, const PxMat44&)
#if NATIVE
ES physx::PxMat44 W_OP_Star(float , physx::PxMat44 ){
    auto nat_in_ = ();
    auto nat_in_ = ();
    auto retVal = physx::operator*(nat_in_, nat_in_);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxMat44 W_OP_Star(float , PxMat44 );

public static PxMat44 operator*(float , PxMat44 ){
    float pvk_in_ = ();
    PxMat44 pvk_in_ = ();
    PxMat44 retVal = W_OP_Star(pvk_in_, pvk_in_);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxMat44
#endif


#if !NATIVE
public unsafe partial struct PxMat44 { // blittable
    public PxVec4 column0;
    public PxVec4 column1;
    public PxVec4 column2;
    public PxVec4 column3;

#endif

    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxIDENTITY r){
        auto nat_in_r = (r);
        self.PxMat44(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxIDENTITY r);
    
    public PxMat44(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = W_PxMat44_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        self.PxMat44(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxZERO r);
    
    public PxMat44(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = W_PxMat44_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxVec4 col0, physx::PxVec4 col1, physx::PxVec4 col2, physx::PxVec4 col3){
        auto nat_in_col0 = (col0);
        auto nat_in_col1 = (col1);
        auto nat_in_col2 = (col2);
        auto nat_in_col3 = (col3);
        self.PxMat44(nat_in_col0, nat_in_col1, nat_in_col2, nat_in_col3);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxVec4 col0, PxVec4 col1, PxVec4 col2, PxVec4 col3);
    
    public PxMat44(PxVec4 col0, PxVec4 col1, PxVec4 col2, PxVec4 col3){
        PxVec4 pvk_in_col0 = (col0);
        PxVec4 pvk_in_col1 = (col1);
        PxVec4 pvk_in_col2 = (col2);
        PxVec4 pvk_in_col3 = (col3);
        var _new = W_PxMat44_ctor(pvk_in_col0, pvk_in_col1, pvk_in_col2, pvk_in_col3);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(float r){
        auto nat_in_r = (r);
        self.PxMat44(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(float r);
    
    public PxMat44(float r){
        float pvk_in_r = (r);
        var _new = W_PxMat44_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxVec3 col0, physx::PxVec3 col1, physx::PxVec3 col2, physx::PxVec3 col3){
        auto nat_in_col0 = (col0);
        auto nat_in_col1 = (col1);
        auto nat_in_col2 = (col2);
        auto nat_in_col3 = (col3);
        self.PxMat44(nat_in_col0, nat_in_col1, nat_in_col2, nat_in_col3);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxVec3 col0, PxVec3 col1, PxVec3 col2, PxVec3 col3);
    
    public PxMat44(PxVec3 col0, PxVec3 col1, PxVec3 col2, PxVec3 col3){
        PxVec3 pvk_in_col0 = (col0);
        PxVec3 pvk_in_col1 = (col1);
        PxVec3 pvk_in_col2 = (col2);
        PxVec3 pvk_in_col3 = (col3);
        var _new = W_PxMat44_ctor(pvk_in_col0, pvk_in_col1, pvk_in_col2, pvk_in_col3);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type float[]
    // NATIVE SIG: explicit PX_CUDA_CALLABLE PX_INLINE PxMat44(float values[])
    	: column0(values[0], values[1], values[2], values[3])
    	, column1(values[4], values[5], values[6], values[7])
    	, column2(values[8], values[9], values[10], values[11])
    	, column3(values[12], values[13], values[14], values[15])
    	{
    	}
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor( values){
        auto nat_in_values = (values);
        self.PxMat44(nat_in_values);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor( values);
    
    public PxMat44( values){
         pvk_in_values = (values);
        var _new = W_PxMat44_ctor(pvk_in_values);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxQuat q){
        auto nat_in_q = (q);
        self.PxMat44(nat_in_q);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxQuat q);
    
    public PxMat44(PxQuat q){
        PxQuat pvk_in_q = (q);
        var _new = W_PxMat44_ctor(pvk_in_q);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxVec4 diagonal){
        auto nat_in_diagonal = (diagonal);
        self.PxMat44(nat_in_diagonal);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxVec4 diagonal);
    
    public PxMat44(PxVec4 diagonal){
        PxVec4 pvk_in_diagonal = (diagonal);
        var _new = W_PxMat44_ctor(pvk_in_diagonal);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxMat33 axes, physx::PxVec3 position){
        auto nat_in_axes = (axes);
        auto nat_in_position = (position);
        self.PxMat44(nat_in_axes, nat_in_position);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxMat33 axes, PxVec3 position);
    
    public PxMat44(PxMat33 axes, PxVec3 position){
        PxMat33 pvk_in_axes = (axes);
        PxVec3 pvk_in_position = (position);
        var _new = W_PxMat44_ctor(pvk_in_axes, pvk_in_position);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxTransform t){
        auto nat_in_t = (t);
        self.PxMat44(nat_in_t);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxTransform t);
    
    public PxMat44(PxTransform t){
        PxTransform pvk_in_t = (t);
        var _new = W_PxMat44_ctor(pvk_in_t);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxMat44 self, physx::PxMat44 m){
        auto nat_in_m = (m);
        auto retVal = self.operator==(nat_in_m);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxMat44 selfBlt, PxMat44 m);
    
    public static bool operator==(PxMat44 lhs, PxMat44 m){
        PxMat44 pvk_in_m = (m);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_m);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxMat44                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_PxMat44_ctor(physx::PxMat44 other){
        auto nat_in_other = (other);
        self.PxMat44(nat_in_other);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_PxMat44_ctor(PxMat44 other);
    
    public PxMat44(PxMat44 other){
        PxMat44 pvk_in_other = (other);
        var _new = W_PxMat44_ctor(pvk_in_other);
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
    //#       getTranspose                                                           #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_getTranspose(physx::PxMat44 self){
        auto retVal = self.getTranspose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_getTranspose(PxMat44 selfBlt);
    
    public PxMat44 getTranspose(){
        PxMat44 retVal = W_getTranspose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_OP_Minus(physx::PxMat44 self){
        auto retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Minus(PxMat44 selfBlt);
    
    public static PxMat44 operator-(PxMat44 lhs){
        PxMat44 retVal = W_OP_Minus(lhs);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_OP_Plus(physx::PxMat44 self, physx::PxMat44 other){
        auto nat_in_other = (other);
        auto retVal = self.operator+(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Plus(PxMat44 selfBlt, PxMat44 other);
    
    public static PxMat44 operator+(PxMat44 lhs, PxMat44 other){
        PxMat44 pvk_in_other = (other);
        PxMat44 retVal = W_OP_Plus(lhs, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_OP_Minus(physx::PxMat44 self, physx::PxMat44 other){
        auto nat_in_other = (other);
        auto retVal = self.operator-(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Minus(PxMat44 selfBlt, PxMat44 other);
    
    public static PxMat44 operator-(PxMat44 lhs, PxMat44 other){
        PxMat44 pvk_in_other = (other);
        PxMat44 retVal = W_OP_Minus(lhs, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_OP_Star(physx::PxMat44 self, float scalar){
        auto nat_in_scalar = (scalar);
        auto retVal = self.operator*(nat_in_scalar);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Star(PxMat44 selfBlt, float scalar);
    
    public static PxMat44 operator*(PxMat44 lhs, float scalar){
        float pvk_in_scalar = (scalar);
        PxMat44 retVal = W_OP_Star(lhs, pvk_in_scalar);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_OP_Star(physx::PxMat44 self, physx::PxMat44 other){
        auto nat_in_other = (other);
        auto retVal = self.operator*(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_OP_Star(PxMat44 selfBlt, PxMat44 other);
    
    public static PxMat44 operator*(PxMat44 lhs, PxMat44 other){
        PxMat44 pvk_in_other = (other);
        PxMat44 retVal = W_OP_Star(lhs, pvk_in_other);
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
    #if NATIVE
    ES physx::PxVec4 W_transform(physx::PxMat44 self, physx::PxVec4 other){
        auto nat_in_other = (other);
        auto retVal = self.transform(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_transform(PxMat44 selfBlt, PxVec4 other);
    
    public PxVec4 transform(PxVec4 other){
        PxVec4 pvk_in_other = (other);
        PxVec4 retVal = W_transform(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_transform(physx::PxMat44 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.transform(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_transform(PxMat44 selfBlt, PxVec3 other);
    
    public PxVec3 transform(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_transform(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotate                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_rotate(physx::PxMat44 self, physx::PxVec4 other){
        auto nat_in_other = (other);
        auto retVal = self.rotate(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_rotate(PxMat44 selfBlt, PxVec4 other);
    
    public PxVec4 rotate(PxVec4 other){
        PxVec4 pvk_in_other = (other);
        PxVec4 retVal = W_rotate(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotate                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_rotate(physx::PxMat44 self, physx::PxVec3 other){
        auto nat_in_other = (other);
        auto retVal = self.rotate(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_rotate(PxMat44 selfBlt, PxVec3 other);
    
    public PxVec3 rotate(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = W_rotate(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getBasis                                                               #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getBasis(physx::PxMat44 self, int num){
        auto nat_in_num = (num);
        auto retVal = self.getBasis(nat_in_num);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getBasis(PxMat44 selfBlt, int num);
    
    public PxVec3 getBasis(int num){
        int pvk_in_num = (num);
        PxVec3 retVal = W_getBasis(this, pvk_in_num);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getPosition                                                            #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getPosition(physx::PxMat44 self){
        auto retVal = self.getPosition();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getPosition(PxMat44 selfBlt);
    
    public PxVec3 getPosition(){
        PxVec3 retVal = W_getPosition(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setPosition                                                            #
    //================================================================================
    #if NATIVE
    ES void W_setPosition(physx::PxMat44 self, physx::PxVec3 position){
        auto nat_in_position = (position);
        self.setPosition(nat_in_position);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setPosition(PxMat44 selfBlt, PxVec3 position);
    
    public void setPosition(PxVec3 position){
        PxVec3 pvk_in_position = (position);
        W_setPosition(this, pvk_in_position);
    }
    #endif
    
    
    //================================================================================
    //#       front                                                                  #
    //================================================================================
    #if NATIVE
    ES float* W_front(physx::PxMat44 self){
        auto retVal = self.front();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_front(PxMat44 selfBlt);
    
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
    
    
    //================================================================================
    //#       scale                                                                  #
    //================================================================================
    #if NATIVE
    ES void W_scale(physx::PxMat44 self, physx::PxVec4 p){
        auto nat_in_p = (p);
        self.scale(nat_in_p);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_scale(PxMat44 selfBlt, PxVec4 p);
    
    public void scale(PxVec4 p){
        PxVec4 pvk_in_p = (p);
        W_scale(this, pvk_in_p);
    }
    #endif
    
    
    //================================================================================
    //#       inverseRT                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxMat44 W_inverseRT(physx::PxMat44 self){
        auto retVal = self.inverseRT();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat44 W_inverseRT(PxMat44 selfBlt);
    
    public PxMat44 inverseRT(){
        PxMat44 retVal = W_inverseRT(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isFinite(physx::PxMat44 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite(PxMat44 selfBlt);
    
    public bool isFinite(){
        bool retVal = W_isFinite(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: ~PxMat44
    

#if !NATIVE
}
#endif
