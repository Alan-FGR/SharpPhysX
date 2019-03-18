#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxVec4 {
#endif

//================================================================================
//#       operator*                                                              #
//================================================================================
#if NATIVE
ES physx::PxVec4 W_OP_Star(float f, physx::PxVec4 v){
    auto nat_in_f = (f);
    auto nat_in_v = (v);
    auto retVal = physx::operator*(nat_in_f, nat_in_v);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxVec4 W_OP_Star(float f, PxVec4 v);

public static PxVec4 operator*(float f, PxVec4 v){
    float pvk_in_f = (f);
    PxVec4 pvk_in_v = (v);
    PxVec4 retVal = W_OP_Star(pvk_in_f, pvk_in_v);
    return retVal;
}
#endif

#if !NATIVE
} // End PxVec4
#endif


#if !NATIVE
public unsafe interface IPxVec4 {
    // PxVec4();
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

public unsafe partial struct PxVec4 : IPxVec4 { // blittable
    public float x;
    public float y;
    public float z;
    public float w;

#endif

    // Hierarchy: PxVec4
    //================================================================================
    //#       PxVec4                                                                 #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxVec4                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_PxVec4_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        self.PxVec4(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_ctor(PxZERO r);
    
    public  PxVec4(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = W_PxVec4_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxVec4                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_PxVec4_ctor(float a){
        auto nat_in_a = (a);
        self.PxVec4(nat_in_a);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_ctor(float a);
    
    public  PxVec4(float a){
        float pvk_in_a = (a);
        var _new = W_PxVec4_ctor(pvk_in_a);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxVec4                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_PxVec4_ctor(float nx, float ny, float nz, float nw){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        auto nat_in_nw = (nw);
        self.PxVec4(nat_in_nx, nat_in_ny, nat_in_nz, nat_in_nw);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_ctor(float nx, float ny, float nz, float nw);
    
    public  PxVec4(float nx, float ny, float nz, float nw){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        float pvk_in_nw = (nw);
        var _new = W_PxVec4_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz, pvk_in_nw);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxVec4                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_PxVec4_ctor(physx::PxVec3 v, float nw){
        auto nat_in_v = (v);
        auto nat_in_nw = (nw);
        self.PxVec4(nat_in_v, nat_in_nw);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_ctor(PxVec3 v, float nw);
    
    public  PxVec4(PxVec3 v, float nw){
        PxVec3 pvk_in_v = (v);
        float pvk_in_nw = (nw);
        var _new = W_PxVec4_ctor(pvk_in_v, pvk_in_nw);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxVec4                                                                 #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type float[]
    // NATIVE SIG: explicit PX_CUDA_CALLABLE PX_INLINE PxVec4(const float v[]) : x(v[0]), y(v[1]), z(v[2]), w(v[3])
    	{
    	}
    #if NATIVE
    ES physx::PxVec4 W_PxVec4_ctor( v){
        auto nat_in_v = (v);
        self.PxVec4(nat_in_v);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_ctor( v);
    
    public  PxVec4( v){
         pvk_in_v = (v);
        var _new = W_PxVec4_ctor(pvk_in_v);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxVec4                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_PxVec4_ctor(physx::PxVec4 v){
        auto nat_in_v = (v);
        self.PxVec4(nat_in_v);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_PxVec4_ctor(PxVec4 v);
    
    public  PxVec4(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        var _new = W_PxVec4_ctor(pvk_in_v);
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
    //#       operator==                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator==(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxVec4 selfBlt, PxVec4 v);
    
    public static bool operator==(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    #if NATIVE
    ES bool W_OP_ExclaimEqual(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator!=(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual(PxVec4 selfBlt, PxVec4 v);
    
    public static bool operator!=(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        bool retVal = W_OP_ExclaimEqual(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isZero                                                                 #
    //================================================================================
    #if NATIVE
    ES bool W_isZero(physx::PxVec4 self){
        auto retVal = self.isZero();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isZero(PxVec4 selfBlt);
    
    public  bool isZero(){
        bool retVal = W_isZero(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    #if NATIVE
    ES bool W_isFinite(physx::PxVec4 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite(PxVec4 selfBlt);
    
    public  bool isFinite(){
        bool retVal = W_isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isNormalized                                                           #
    //================================================================================
    #if NATIVE
    ES bool W_isNormalized(physx::PxVec4 self){
        auto retVal = self.isNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isNormalized(PxVec4 selfBlt);
    
    public  bool isNormalized(){
        bool retVal = W_isNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitudeSquared                                                       #
    //================================================================================
    #if NATIVE
    ES float W_magnitudeSquared(physx::PxVec4 self){
        auto retVal = self.magnitudeSquared();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitudeSquared(PxVec4 selfBlt);
    
    public  float magnitudeSquared(){
        float retVal = W_magnitudeSquared(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitude                                                              #
    //================================================================================
    #if NATIVE
    ES float W_magnitude(physx::PxVec4 self){
        auto retVal = self.magnitude();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitude(PxVec4 selfBlt);
    
    public  float magnitude(){
        float retVal = W_magnitude(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_OP_Minus(physx::PxVec4 self){
        auto retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Minus(PxVec4 selfBlt);
    
    public static PxVec4 operator-(PxVec4 lhs){
        PxVec4 retVal = W_OP_Minus(lhs);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_OP_Plus(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator+(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Plus(PxVec4 selfBlt, PxVec4 v);
    
    public static PxVec4 operator+(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_OP_Plus(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_OP_Minus(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.operator-(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Minus(PxVec4 selfBlt, PxVec4 v);
    
    public static PxVec4 operator-(PxVec4 lhs, PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_OP_Minus(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_OP_Star(physx::PxVec4 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator*(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Star(PxVec4 selfBlt, float f);
    
    public static PxVec4 operator*(PxVec4 lhs, float f){
        float pvk_in_f = (f);
        PxVec4 retVal = W_OP_Star(lhs, pvk_in_f);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator/                                                              #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_OP_Slash(physx::PxVec4 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator/(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_OP_Slash(PxVec4 selfBlt, float f);
    
    public static PxVec4 operator/(PxVec4 lhs, float f){
        float pvk_in_f = (f);
        PxVec4 retVal = W_OP_Slash(lhs, pvk_in_f);
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
    //#       operator/=                                                             #
    //================================================================================
    //Skipped unsupported operator SlashEqual.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       dot                                                                    #
    //================================================================================
    #if NATIVE
    ES float W_dot(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_dot(PxVec4 selfBlt, PxVec4 v);
    
    public  float dot(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        float retVal = W_dot(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNormalized                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_getNormalized(physx::PxVec4 self){
        auto retVal = self.getNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_getNormalized(PxVec4 selfBlt);
    
    public  PxVec4 getNormalized(){
        PxVec4 retVal = W_getNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalize                                                              #
    //================================================================================
    #if NATIVE
    ES float W_normalize(physx::PxVec4 self){
        auto retVal = self.normalize();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalize(PxVec4 selfBlt);
    
    public  float normalize(){
        float retVal = W_normalize(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       multiply                                                               #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_multiply(physx::PxVec4 self, physx::PxVec4 a){
        auto nat_in_a = (a);
        auto retVal = self.multiply(nat_in_a);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_multiply(PxVec4 selfBlt, PxVec4 a);
    
    public  PxVec4 multiply(PxVec4 a){
        PxVec4 pvk_in_a = (a);
        PxVec4 retVal = W_multiply(this, pvk_in_a);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       minimum                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_minimum(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.minimum(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_minimum(PxVec4 selfBlt, PxVec4 v);
    
    public  PxVec4 minimum(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_minimum(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       maximum                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxVec4 W_maximum(physx::PxVec4 self, physx::PxVec4 v){
        auto nat_in_v = (v);
        auto retVal = self.maximum(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec4 W_maximum(PxVec4 selfBlt, PxVec4 v);
    
    public  PxVec4 maximum(PxVec4 v){
        PxVec4 pvk_in_v = (v);
        PxVec4 retVal = W_maximum(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getXYZ                                                                 #
    //================================================================================
    #if NATIVE
    ES physx::PxVec3 W_getXYZ(physx::PxVec4 self){
        auto retVal = self.getXYZ();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getXYZ(PxVec4 selfBlt);
    
    public  PxVec3 getXYZ(){
        PxVec3 retVal = W_getXYZ(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       setZero                                                                #
    //================================================================================
    #if NATIVE
    ES void W_setZero(physx::PxVec4 self){
        self.setZero();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_setZero(PxVec4 selfBlt);
    
    public  void setZero(){
        W_setZero(this);
    }
    #endif
    
    
    //Skipped generated implicit entry: ~PxVec4
    

#if !NATIVE
}
#endif
