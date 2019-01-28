//Generated by MinBinder.
using System;
using System.Runtime.InteropServices;
using PxBaseFlags = System.UInt32;
using PxActorFlags = System.UInt32;

public partial struct PxMat33 { // blittable


    public PxVec3 column0;
    public PxVec3 column1;
    public PxVec3 column2;

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_PxMat33_PxMat33(PxVec3 col0,PxVec3 col1,PxVec3 col2);
    public unsafe PxMat33(PxVec3 col0,PxVec3 col1,PxVec3 col2){
        var _new = C_PxMat33_PxMat33(col0,col1,col2);        
        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_PxMat33_PxMat33_2(float r);
    public unsafe PxMat33(float r){
        var _new = C_PxMat33_PxMat33_2(r);        
        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_PxMat33_PxMat33_3(float[] values);
    public unsafe PxMat33(float[] values){
        var _new = C_PxMat33_PxMat33_3(values);        
        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_PxMat33_PxMat33_4(PxQuat q);
    public unsafe PxMat33(PxQuat q){
        var _new = C_PxMat33_PxMat33_4(q);        
        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_PxMat33_PxMat33_5(PxMat33 other);
    public unsafe PxMat33(PxMat33 other){
        var _new = C_PxMat33_PxMat33_5(other);        
        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_PxMat33_createDiagonal(PxMat33 cls,PxVec3 d);
    public PxMat33 createDiagonal(PxVec3 d){
        return C_PxMat33_createDiagonal(this,d);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool C_CONST_PxMat33_OP_EqualEqual(PxMat33 cls,PxMat33 m);
    public static bool operator==(PxMat33 cls,PxMat33 m){
        return C_CONST_PxMat33_OP_EqualEqual(cls,m);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_CONST_PxMat33_getTranspose(PxMat33 cls);
    public PxMat33 getTranspose(){
        return C_CONST_PxMat33_getTranspose(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_CONST_PxMat33_getInverse(PxMat33 cls);
    public PxMat33 getInverse(){
        return C_CONST_PxMat33_getInverse(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_CONST_PxMat33_getDeterminant(PxMat33 cls);
    public float getDeterminant(){
        return C_CONST_PxMat33_getDeterminant(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_CONST_PxMat33_OP_Minus(PxMat33 cls);
    public static PxMat33 Minus(PxMat33 cls){
        return C_CONST_PxMat33_OP_Minus(cls);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_CONST_PxMat33_OP_Plus(PxMat33 cls,PxMat33 other);
    public static PxMat33 operator+(PxMat33 cls,PxMat33 other){
        return C_CONST_PxMat33_OP_Plus(cls,other);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_CONST_PxMat33_OP_Minus_2(PxMat33 cls,PxMat33 other);
    public static PxMat33 operator-(PxMat33 cls,PxMat33 other){
        return C_CONST_PxMat33_OP_Minus_2(cls,other);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_CONST_PxMat33_OP_Star(PxMat33 cls,float scalar);
    public static PxMat33 Star(PxMat33 cls,float scalar){
        return C_CONST_PxMat33_OP_Star(cls,scalar);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 C_CONST_PxMat33_OP_Star_2(PxMat33 cls,PxVec3 vec);
    public static PxVec3 Star(PxMat33 cls,PxVec3 vec){
        return C_CONST_PxMat33_OP_Star_2(cls,vec);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 C_CONST_PxMat33_OP_Star_3(PxMat33 cls,PxMat33 other);
    public static PxMat33 operator*(PxMat33 cls,PxMat33 other){
        return C_CONST_PxMat33_OP_Star_3(cls,other);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 C_CONST_PxMat33_transform(PxMat33 cls,PxVec3 other);
    public PxVec3 transform(PxVec3 other){
        return C_CONST_PxMat33_transform(this,other);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 C_CONST_PxMat33_transformTranspose(PxMat33 cls,PxVec3 other);
    public PxVec3 transformTranspose(PxVec3 other){
        return C_CONST_PxMat33_transformTranspose(this,other);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float C_CONST_PxMat33_front(PxMat33 cls);
    public float front(){
        return C_CONST_PxMat33_front(this);    
    }


}
