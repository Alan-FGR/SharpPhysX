#if !NATIVE
using System;
using System.Runtime.InteropServices;
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
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L94~96
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor(){
        self.PxMat33();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor();
    
    public PxMat33(){
        var _new = PxMat33_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L99~103
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor(physx::PxIDENTITY r){
        physx::PxIDENTITY nat_in_r = (r);
        self.PxMat33(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor(PxIDENTITY r);
    
    public PxMat33(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L106~109
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor(physx::PxZERO r){
        physx::PxZERO nat_in_r = (r);
        self.PxMat33(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor(PxZERO r);
    
    public PxMat33(PxZERO r){
        PxZERO pvk_in_r = (r);
        var _new = PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L112~115
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor(physx::PxVec3 col0, physx::PxVec3 col1, physx::PxVec3 col2){
        physx::PxVec3 nat_in_col0 = (col0);
        physx::PxVec3 nat_in_col1 = (col1);
        physx::PxVec3 nat_in_col2 = (col2);
        self.PxMat33(nat_in_col0, nat_in_col1, nat_in_col2);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor(PxVec3 col0, PxVec3 col1, PxVec3 col2);
    
    public PxMat33(PxVec3 col0, PxVec3 col1, PxVec3 col2){
        PxVec3 pvk_in_col0 = (col0);
        PxVec3 pvk_in_col1 = (col1);
        PxVec3 pvk_in_col2 = (col2);
        var _new = PxMat33_ctor(pvk_in_col0, pvk_in_col1, pvk_in_col2);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L118~121
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor(float r){
        float nat_in_r = (r);
        self.PxMat33(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor(float r);
    
    public PxMat33(float r){
        float pvk_in_r = (r);
        var _new = PxMat33_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxMat33::PxMat33::values
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L124~129
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor( values){
         nat_in_values = (values);
        self.PxMat33(nat_in_values);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor( values);
    
    public PxMat33( values){
         pvk_in_values = (values);
        var _new = PxMat33_ctor(pvk_in_values);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L132~158
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor(physx::PxQuat q){
        physx::PxQuat nat_in_q = (q);
        self.PxMat33(nat_in_q);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor(PxQuat q);
    
    public PxMat33(PxQuat q){
        PxQuat pvk_in_q = (q);
        var _new = PxMat33_ctor(pvk_in_q);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxMat33                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L161~164
    #if NATIVE
    ES physx::PxMat33 PxMat33_ctor(physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        self.PxMat33(nat_in_other);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 PxMat33_ctor(PxMat33 other);
    
    public PxMat33(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        var _new = PxMat33_ctor(pvk_in_other);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L167~173
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxMat33 self, physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        UNPARSED_TYPE retVal = self.operator=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxMat33 selfBlt, PxMat33 other);
    
    public UNPARSED_TYPE operator=(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        UNPARSED_TYPE retVal = operator=(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       createDiagonal                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L176~179
    #if NATIVE
    ES physx::PxMat33 createDiagonal(physx::PxMat33 self, physx::PxVec3 d){
        physx::PxVec3 nat_in_d = (d);
        physx::PxMat33 retVal = self.createDiagonal(nat_in_d);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 createDiagonal(PxMat33 selfBlt, PxVec3 d);
    
    public PxMat33 createDiagonal(PxVec3 d){
        PxVec3 pvk_in_d = (d);
        PxMat33 retVal = createDiagonal(this, pvk_in_d);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L184~187
    #if NATIVE
    ES bool operator==(physx::PxMat33 self, physx::PxMat33 m){
        physx::PxMat33 nat_in_m = (m);
        bool retVal = self.operator==(nat_in_m);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxMat33 selfBlt, PxMat33 m);
    
    public bool operator==(PxMat33 m){
        PxMat33 pvk_in_m = (m);
        bool retVal = operator==(this, pvk_in_m);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getTranspose                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L190~197
    #if NATIVE
    ES physx::PxMat33 getTranspose(physx::PxMat33 self){
        physx::PxMat33 retVal = self.getTranspose();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 getTranspose(PxMat33 selfBlt);
    
    public PxMat33 getTranspose(){
        PxMat33 retVal = getTranspose(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getInverse                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L200~227
    #if NATIVE
    ES physx::PxMat33 getInverse(physx::PxMat33 self){
        physx::PxMat33 retVal = self.getInverse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 getInverse(PxMat33 selfBlt);
    
    public PxMat33 getInverse(){
        PxMat33 retVal = getInverse(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getDeterminant                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L230~233
    #if NATIVE
    ES float getDeterminant(physx::PxMat33 self){
        float retVal = self.getDeterminant();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getDeterminant(PxMat33 selfBlt);
    
    public float getDeterminant(){
        float retVal = getDeterminant(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L236~239
    #if NATIVE
    ES physx::PxMat33 operator-(physx::PxMat33 self){
        physx::PxMat33 retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 operator-(PxMat33 selfBlt);
    
    public PxMat33 operator-(){
        PxMat33 retVal = operator-(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L242~245
    #if NATIVE
    ES physx::PxMat33 operator+(physx::PxMat33 self, physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        physx::PxMat33 retVal = self.operator+(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 operator+(PxMat33 selfBlt, PxMat33 other);
    
    public PxMat33 operator+(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = operator+(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L248~251
    #if NATIVE
    ES physx::PxMat33 operator-(physx::PxMat33 self, physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        physx::PxMat33 retVal = self.operator-(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 operator-(PxMat33 selfBlt, PxMat33 other);
    
    public PxMat33 operator-(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = operator-(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L254~257
    #if NATIVE
    ES physx::PxMat33 operator*(physx::PxMat33 self, float scalar){
        float nat_in_scalar = (scalar);
        physx::PxMat33 retVal = self.operator*(nat_in_scalar);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 operator*(PxMat33 selfBlt, float scalar);
    
    public PxMat33 operator*(float scalar){
        float pvk_in_scalar = (scalar);
        PxMat33 retVal = operator*(this, pvk_in_scalar);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L262~265
    #if NATIVE
    ES physx::PxVec3 operator*(physx::PxMat33 self, physx::PxVec3 vec){
        physx::PxVec3 nat_in_vec = (vec);
        physx::PxVec3 retVal = self.operator*(nat_in_vec);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 operator*(PxMat33 selfBlt, PxVec3 vec);
    
    public PxVec3 operator*(PxVec3 vec){
        PxVec3 pvk_in_vec = (vec);
        PxVec3 retVal = operator*(this, pvk_in_vec);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L270~275
    #if NATIVE
    ES physx::PxMat33 operator*(physx::PxMat33 self, physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        physx::PxMat33 retVal = self.operator*(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxMat33 operator*(PxMat33 selfBlt, PxMat33 other);
    
    public PxMat33 operator*(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        PxMat33 retVal = operator*(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator+=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L278~284
    #if NATIVE
    ES UNPARSED_TYPE operator+=(physx::PxMat33 self, physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        UNPARSED_TYPE retVal = self.operator+=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator+=(PxMat33 selfBlt, PxMat33 other);
    
    public UNPARSED_TYPE operator+=(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        UNPARSED_TYPE retVal = operator+=(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L287~293
    #if NATIVE
    ES UNPARSED_TYPE operator-=(physx::PxMat33 self, physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        UNPARSED_TYPE retVal = self.operator-=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator-=(PxMat33 selfBlt, PxMat33 other);
    
    public UNPARSED_TYPE operator-=(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        UNPARSED_TYPE retVal = operator-=(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L296~302
    #if NATIVE
    ES UNPARSED_TYPE operator*=(physx::PxMat33 self, float scalar){
        float nat_in_scalar = (scalar);
        UNPARSED_TYPE retVal = self.operator*=(nat_in_scalar);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator*=(PxMat33 selfBlt, float scalar);
    
    public UNPARSED_TYPE operator*=(float scalar){
        float pvk_in_scalar = (scalar);
        UNPARSED_TYPE retVal = operator*=(this, pvk_in_scalar);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L305~309
    #if NATIVE
    ES UNPARSED_TYPE operator*=(physx::PxMat33 self, physx::PxMat33 other){
        physx::PxMat33 nat_in_other = (other);
        UNPARSED_TYPE retVal = self.operator*=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator*=(PxMat33 selfBlt, PxMat33 other);
    
    public UNPARSED_TYPE operator*=(PxMat33 other){
        PxMat33 pvk_in_other = (other);
        UNPARSED_TYPE retVal = operator*=(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L312~315
    #if NATIVE
    ES float operator()(physx::PxMat33 self, unsigned int row, unsigned int col){
        unsigned int nat_in_row = (row);
        unsigned int nat_in_col = (col);
        float retVal = self.operator()(nat_in_row, nat_in_col);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float operator()(PxMat33 selfBlt, uint row, uint col);
    
    public float operator()(uint row, uint col){
        uint pvk_in_row = (row);
        uint pvk_in_col = (col);
        float retVal = operator()(this, pvk_in_row, pvk_in_col);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator()                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L318~321
    #if NATIVE
    ES UNPARSED_TYPE operator()(physx::PxMat33 self, unsigned int row, unsigned int col){
        unsigned int nat_in_row = (row);
        unsigned int nat_in_col = (col);
        UNPARSED_TYPE retVal = self.operator()(nat_in_row, nat_in_col);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator()(PxMat33 selfBlt, uint row, uint col);
    
    public UNPARSED_TYPE operator()(uint row, uint col){
        uint pvk_in_row = (row);
        uint pvk_in_col = (col);
        UNPARSED_TYPE retVal = operator()(this, pvk_in_row, pvk_in_col);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L326~329
    #if NATIVE
    ES physx::PxVec3 transform(physx::PxMat33 self, physx::PxVec3 other){
        physx::PxVec3 nat_in_other = (other);
        physx::PxVec3 retVal = self.transform(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 transform(PxMat33 selfBlt, PxVec3 other);
    
    public PxVec3 transform(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = transform(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformTranspose                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L332~335
    #if NATIVE
    ES physx::PxVec3 transformTranspose(physx::PxMat33 self, physx::PxVec3 other){
        physx::PxVec3 nat_in_other = (other);
        physx::PxVec3 retVal = self.transformTranspose(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 transformTranspose(PxMat33 selfBlt, PxVec3 other);
    
    public PxVec3 transformTranspose(PxVec3 other){
        PxVec3 pvk_in_other = (other);
        PxVec3 retVal = transformTranspose(this, pvk_in_other);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       front                                                                  #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L337~340
    #if NATIVE
    ES UNPARSED_TYPE front(physx::PxMat33 self){
        UNPARSED_TYPE retVal = self.front();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE front(PxMat33 selfBlt);
    
    public UNPARSED_TYPE front(){
        UNPARSED_TYPE retVal = front(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L342~345
    #if NATIVE
    ES UNPARSED_TYPE operator[](physx::PxMat33 self, unsigned int num){
        unsigned int nat_in_num = (num);
        UNPARSED_TYPE retVal = self.operator[](nat_in_num);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator[](PxMat33 selfBlt, uint num);
    
    public UNPARSED_TYPE operator[](uint num){
        uint pvk_in_num = (num);
        UNPARSED_TYPE retVal = operator[](this, pvk_in_num);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L346~349
    #if NATIVE
    ES UNPARSED_TYPE operator[](physx::PxMat33 self, unsigned int num){
        unsigned int nat_in_num = (num);
        UNPARSED_TYPE retVal = self.operator[](nat_in_num);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator[](PxMat33 selfBlt, uint num);
    
    public UNPARSED_TYPE operator[](uint num){
        uint pvk_in_num = (num);
        UNPARSED_TYPE retVal = operator[](this, pvk_in_num);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxMat33                                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxMat33.h L90~90
    #if NATIVE
    ES void ~PxMat33(physx::PxMat33 self){
        self.~PxMat33();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxMat33(PxMat33 selfBlt);
    
    public void ~PxMat33(){
        ~PxMat33(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
