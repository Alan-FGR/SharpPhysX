#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public partial struct PxVec3 {
#endif

//================================================================================
//#       operator*                                                              #
//================================================================================
// SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L384~387
#if NATIVE
ES physx::PxVec3 W_OP_Star(float f, physx::PxVec3 v){
    auto nat_in_f = (f);
    auto nat_in_v = (v);
    auto retVal = physx::operator*(nat_in_f, nat_in_v);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxVec3 W_OP_Star(float f, PxVec3 v);

public static PxVec3 operator*(float f, PxVec3 v){
    float pvk_in_f = (f);
    PxVec3 pvk_in_v = (v);
    PxVec3 retVal = W_OP_Star(pvk_in_f, pvk_in_v);
    return retVal;
}
#endif

#if !NATIVE
} // End PxVec3
#endif


#if !NATIVE
public unsafe partial struct PxVec3 { // blittable
    public float x;
    public float y;
    public float z;

#endif

    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    //Skipped invalid managed declaration:
    /*Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L62~65
    #if NATIVE
    ES physx::PxVec3 W_PxVec3_ctor(physx::PxZERO r){
        auto nat_in_r = (r);
        self.PxVec3(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_ctor(PxZERO r);
    
    public PxVec3(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = W_PxVec3_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L74~76
    #if NATIVE
    ES physx::PxVec3 W_PxVec3_ctor(float a){
        auto nat_in_a = (a);
        self.PxVec3(nat_in_a);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_ctor(float a);
    
    public PxVec3(float a){
        float pvk_in_a = (a);
        var _new = W_PxVec3_ctor(pvk_in_a);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L85~87
    #if NATIVE
    ES physx::PxVec3 W_PxVec3_ctor(float nx, float ny, float nz){
        auto nat_in_nx = (nx);
        auto nat_in_ny = (ny);
        auto nat_in_nz = (nz);
        self.PxVec3(nat_in_nx, nat_in_ny, nat_in_nz);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_ctor(float nx, float ny, float nz);
    
    public PxVec3(float nx, float ny, float nz){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        var _new = W_PxVec3_ctor(pvk_in_nx, pvk_in_ny, pvk_in_nz);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L92~94
    #if NATIVE
    ES physx::PxVec3 W_PxVec3_ctor(physx::PxVec3 v){
        auto nat_in_v = (v);
        self.PxVec3(nat_in_v);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_PxVec3_ctor(PxVec3 v);
    
    public PxVec3(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        var _new = W_PxVec3_ctor(pvk_in_v);
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L132~135
    #if NATIVE
    ES bool W_OP_EqualEqual(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator==(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_EqualEqual(PxVec3 selfBlt, PxVec3 v);
    
    public static bool operator==(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = W_OP_EqualEqual(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L140~143
    #if NATIVE
    ES bool W_OP_ExclaimEqual(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator!=(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_OP_ExclaimEqual(PxVec3 selfBlt, PxVec3 v);
    
    public static bool operator!=(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = W_OP_ExclaimEqual(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isZero                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L148~151
    #if NATIVE
    ES bool W_isZero(physx::PxVec3 self){
        auto retVal = self.isZero();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isZero(PxVec3 selfBlt);
    
    public bool isZero(){
        bool retVal = W_isZero(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L156~159
    #if NATIVE
    ES bool W_isFinite(physx::PxVec3 self){
        auto retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isFinite(PxVec3 selfBlt);
    
    public bool isFinite(){
        bool retVal = W_isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isNormalized                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L164~168
    #if NATIVE
    ES bool W_isNormalized(physx::PxVec3 self){
        auto retVal = self.isNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isNormalized(PxVec3 selfBlt);
    
    public bool isNormalized(){
        bool retVal = W_isNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitudeSquared                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L175~178
    #if NATIVE
    ES float W_magnitudeSquared(physx::PxVec3 self){
        auto retVal = self.magnitudeSquared();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitudeSquared(PxVec3 selfBlt);
    
    public float magnitudeSquared(){
        float retVal = W_magnitudeSquared(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitude                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L183~186
    #if NATIVE
    ES float W_magnitude(physx::PxVec3 self){
        auto retVal = self.magnitude();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_magnitude(PxVec3 selfBlt);
    
    public float magnitude(){
        float retVal = W_magnitude(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L191~194
    #if NATIVE
    ES physx::PxVec3 W_OP_Minus(physx::PxVec3 self){
        auto retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Minus(PxVec3 selfBlt);
    
    public static PxVec3 operator-(PxVec3 lhs){
        PxVec3 retVal = W_OP_Minus(lhs);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L199~202
    #if NATIVE
    ES physx::PxVec3 W_OP_Plus(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator+(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Plus(PxVec3 selfBlt, PxVec3 v);
    
    public static PxVec3 operator+(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_OP_Plus(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L207~210
    #if NATIVE
    ES physx::PxVec3 W_OP_Minus(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.operator-(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Minus(PxVec3 selfBlt, PxVec3 v);
    
    public static PxVec3 operator-(PxVec3 lhs, PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_OP_Minus(lhs, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L215~218
    #if NATIVE
    ES physx::PxVec3 W_OP_Star(physx::PxVec3 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator*(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Star(PxVec3 selfBlt, float f);
    
    public static PxVec3 operator*(PxVec3 lhs, float f){
        float pvk_in_f = (f);
        PxVec3 retVal = W_OP_Star(lhs, pvk_in_f);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator/                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L223~227
    #if NATIVE
    ES physx::PxVec3 W_OP_Slash(physx::PxVec3 self, float f){
        auto nat_in_f = (f);
        auto retVal = self.operator/(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_OP_Slash(PxVec3 selfBlt, float f);
    
    public static PxVec3 operator/(PxVec3 lhs, float f){
        float pvk_in_f = (f);
        PxVec3 retVal = W_OP_Slash(lhs, pvk_in_f);
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
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L276~279
    #if NATIVE
    ES float W_dot(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_dot(PxVec3 selfBlt, PxVec3 v);
    
    public float dot(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        float retVal = W_dot(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       cross                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L284~287
    #if NATIVE
    ES physx::PxVec3 W_cross(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.cross(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_cross(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 cross(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_cross(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNormalized                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L291~295
    #if NATIVE
    ES physx::PxVec3 W_getNormalized(physx::PxVec3 self){
        auto retVal = self.getNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_getNormalized(PxVec3 selfBlt);
    
    public PxVec3 getNormalized(){
        PxVec3 retVal = W_getNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalize                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L300~306
    #if NATIVE
    ES float W_normalize(physx::PxVec3 self){
        auto retVal = self.normalize();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalize(PxVec3 selfBlt);
    
    public float normalize(){
        float retVal = W_normalize(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalizeSafe                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L312~319
    #if NATIVE
    ES float W_normalizeSafe(physx::PxVec3 self){
        auto retVal = self.normalizeSafe();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalizeSafe(PxVec3 selfBlt);
    
    public float normalizeSafe(){
        float retVal = W_normalizeSafe(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalizeFast                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L325~331
    #if NATIVE
    ES float W_normalizeFast(physx::PxVec3 self){
        auto retVal = self.normalizeFast();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_normalizeFast(PxVec3 selfBlt);
    
    public float normalizeFast(){
        float retVal = W_normalizeFast(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       multiply                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L336~339
    #if NATIVE
    ES physx::PxVec3 W_multiply(physx::PxVec3 self, physx::PxVec3 a){
        auto nat_in_a = (a);
        auto retVal = self.multiply(nat_in_a);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_multiply(PxVec3 selfBlt, PxVec3 a);
    
    public PxVec3 multiply(PxVec3 a){
        PxVec3 pvk_in_a = (a);
        PxVec3 retVal = W_multiply(this, pvk_in_a);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       minimum                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L344~347
    #if NATIVE
    ES physx::PxVec3 W_minimum(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.minimum(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_minimum(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 minimum(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_minimum(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       minElement                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L352~355
    #if NATIVE
    ES float W_minElement(physx::PxVec3 self){
        auto retVal = self.minElement();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_minElement(PxVec3 selfBlt);
    
    public float minElement(){
        float retVal = W_minElement(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       maximum                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L360~363
    #if NATIVE
    ES physx::PxVec3 W_maximum(physx::PxVec3 self, physx::PxVec3 v){
        auto nat_in_v = (v);
        auto retVal = self.maximum(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_maximum(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 maximum(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = W_maximum(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       maxElement                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L368~371
    #if NATIVE
    ES float W_maxElement(physx::PxVec3 self){
        auto retVal = self.maxElement();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_maxElement(PxVec3 selfBlt);
    
    public float maxElement(){
        float retVal = W_maxElement(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       abs                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L376~379
    #if NATIVE
    ES physx::PxVec3 W_abs(physx::PxVec3 self){
        auto retVal = self.abs();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 W_abs(PxVec3 selfBlt);
    
    public PxVec3 abs(){
        PxVec3 retVal = W_abs(this);
        return retVal;
    }
    #endif
    
    
    //Skipped generated implicit entry: ~PxVec3
    

#if !NATIVE
}
#endif
