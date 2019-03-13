#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxTransform { // blittable
    public PxQuat q;
    public PxVec3 p;

#endif

    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    /* ERRORS OCCURED: Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L54~56
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(){
        self.PxTransform();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor();
    
    public PxTransform(){
        var _new = PxTransform_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L58~60
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(physx::PxVec3 position){
        physx::PxVec3 nat_in_position = (position);
        self.PxTransform(nat_in_position);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor(PxVec3 position);
    
    public PxTransform(PxVec3 position){
        PxVec3 pvk_in_position = (position);
        var _new = PxTransform_ctor(pvk_in_position);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L62~65
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(physx::PxIDENTITY r){
        physx::PxIDENTITY nat_in_r = (r);
        self.PxTransform(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor(PxIDENTITY r);
    
    public PxTransform(PxIDENTITY r){
        PxIDENTITY pvk_in_r = (r);
        var _new = PxTransform_ctor(pvk_in_r);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L67~70
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(physx::PxQuat orientation){
        physx::PxQuat nat_in_orientation = (orientation);
        self.PxTransform(nat_in_orientation);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor(PxQuat orientation);
    
    public PxTransform(PxQuat orientation){
        PxQuat pvk_in_orientation = (orientation);
        var _new = PxTransform_ctor(pvk_in_orientation);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L72~75
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(float x, float y, float z, physx::PxQuat aQ){
        float nat_in_x = (x);
        float nat_in_y = (y);
        float nat_in_z = (z);
        physx::PxQuat nat_in_aQ = (aQ);
        self.PxTransform(nat_in_x, nat_in_y, nat_in_z, nat_in_aQ);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor(float x, float y, float z, PxQuat aQ);
    
    public PxTransform(float x, float y, float z, PxQuat aQ){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        float pvk_in_z = (z);
        PxQuat pvk_in_aQ = (aQ);
        var _new = PxTransform_ctor(pvk_in_x, pvk_in_y, pvk_in_z, pvk_in_aQ);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L77~80
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(physx::PxVec3 p0, physx::PxQuat q0){
        physx::PxVec3 nat_in_p0 = (p0);
        physx::PxQuat nat_in_q0 = (q0);
        self.PxTransform(nat_in_p0, nat_in_q0);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor(PxVec3 p0, PxQuat q0);
    
    public PxTransform(PxVec3 p0, PxQuat q0){
        PxVec3 pvk_in_p0 = (p0);
        PxQuat pvk_in_q0 = (q0);
        var _new = PxTransform_ctor(pvk_in_p0, pvk_in_q0);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L82~82
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(physx::PxMat44 m){
        physx::PxMat44 nat_in_m = (m);
        self.PxTransform(nat_in_m);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor(PxMat44 m);
    
    public PxTransform(PxMat44 m){
        PxMat44 pvk_in_m = (m);
        var _new = PxTransform_ctor(pvk_in_m);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L87~90
    #if NATIVE
    ES bool operator==(physx::PxTransform self, physx::PxTransform t){
        physx::PxTransform nat_in_t = (t);
        bool retVal = self.operator==(nat_in_t);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxTransform selfBlt, PxTransform t);
    
    public bool operator==(PxTransform t){
        PxTransform pvk_in_t = (t);
        bool retVal = operator==(this, pvk_in_t);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L92~96
    #if NATIVE
    ES physx::PxTransform operator*(physx::PxTransform self, physx::PxTransform x){
        physx::PxTransform nat_in_x = (x);
        physx::PxTransform retVal = self.operator*(nat_in_x);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform operator*(PxTransform selfBlt, PxTransform x);
    
    public PxTransform operator*(PxTransform x){
        PxTransform pvk_in_x = (x);
        PxTransform retVal = operator*(this, pvk_in_x);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Non const pointer/reference global::PhysX.physx.PxTransform
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L99~103
    #if NATIVE
    ES UNPARSED_TYPE operator*=(physx::PxTransform self,  other){
         nat_in_other = (other);
        UNPARSED_TYPE retVal = self.operator*=(nat_in_other);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator*=(PxTransform selfBlt,  other);
    
    public UNPARSED_TYPE operator*=( other){
         pvk_in_other = (other);
        UNPARSED_TYPE retVal = operator*=(this, pvk_in_other);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getInverse                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L105~109
    #if NATIVE
    ES physx::PxTransform getInverse(physx::PxTransform self){
        physx::PxTransform retVal = self.getInverse();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform getInverse(PxTransform selfBlt);
    
    public PxTransform getInverse(){
        PxTransform retVal = getInverse(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L111~115
    #if NATIVE
    ES physx::PxVec3 transform(physx::PxTransform self, physx::PxVec3 input){
        physx::PxVec3 nat_in_input = (input);
        physx::PxVec3 retVal = self.transform(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 transform(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 transform(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = transform(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformInv                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L117~121
    #if NATIVE
    ES physx::PxVec3 transformInv(physx::PxTransform self, physx::PxVec3 input){
        physx::PxVec3 nat_in_input = (input);
        physx::PxVec3 retVal = self.transformInv(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 transformInv(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 transformInv(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = transformInv(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotate                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L123~127
    #if NATIVE
    ES physx::PxVec3 rotate(physx::PxTransform self, physx::PxVec3 input){
        physx::PxVec3 nat_in_input = (input);
        physx::PxVec3 retVal = self.rotate(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 rotate(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 rotate(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = rotate(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       rotateInv                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L129~133
    #if NATIVE
    ES physx::PxVec3 rotateInv(physx::PxTransform self, physx::PxVec3 input){
        physx::PxVec3 nat_in_input = (input);
        physx::PxVec3 retVal = self.rotateInv(nat_in_input);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 rotateInv(PxTransform selfBlt, PxVec3 input);
    
    public PxVec3 rotateInv(PxVec3 input){
        PxVec3 pvk_in_input = (input);
        PxVec3 retVal = rotateInv(this, pvk_in_input);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L136~142
    #if NATIVE
    ES physx::PxTransform transform(physx::PxTransform self, physx::PxTransform src){
        physx::PxTransform nat_in_src = (src);
        physx::PxTransform retVal = self.transform(nat_in_src);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform transform(PxTransform selfBlt, PxTransform src);
    
    public PxTransform transform(PxTransform src){
        PxTransform pvk_in_src = (src);
        PxTransform retVal = transform(this, pvk_in_src);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isValid                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L148~151
    #if NATIVE
    ES bool isValid(physx::PxTransform self){
        bool retVal = self.isValid();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isValid(PxTransform selfBlt);
    
    public bool isValid(){
        bool retVal = isValid(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isSane                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L158~161
    #if NATIVE
    ES bool isSane(physx::PxTransform self){
        bool retVal = self.isSane();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isSane(PxTransform selfBlt);
    
    public bool isSane(){
        bool retVal = isSane(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L166~169
    #if NATIVE
    ES bool isFinite(physx::PxTransform self){
        bool retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isFinite(PxTransform selfBlt);
    
    public bool isFinite(){
        bool retVal = isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transformInv                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L172~179
    #if NATIVE
    ES physx::PxTransform transformInv(physx::PxTransform self, physx::PxTransform src){
        physx::PxTransform nat_in_src = (src);
        physx::PxTransform retVal = self.transformInv(nat_in_src);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform transformInv(PxTransform selfBlt, PxTransform src);
    
    public PxTransform transformInv(PxTransform src){
        PxTransform pvk_in_src = (src);
        PxTransform retVal = transformInv(this, pvk_in_src);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       transform                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L185~189
    #if NATIVE
    ES UNPARSED_TYPE transform(physx::PxTransform self,  plane){
         nat_in_plane = (plane);
        UNPARSED_TYPE retVal = self.transform(nat_in_plane);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE transform(PxTransform selfBlt,  plane);
    
    public UNPARSED_TYPE transform( plane){
         pvk_in_plane = (plane);
        UNPARSED_TYPE retVal = transform(this, pvk_in_plane);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       inverseTransform                                                       #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L195~199
    #if NATIVE
    ES UNPARSED_TYPE inverseTransform(physx::PxTransform self,  plane){
         nat_in_plane = (plane);
        UNPARSED_TYPE retVal = self.inverseTransform(nat_in_plane);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE inverseTransform(PxTransform selfBlt,  plane);
    
    public UNPARSED_TYPE inverseTransform( plane){
         pvk_in_plane = (plane);
        UNPARSED_TYPE retVal = inverseTransform(this, pvk_in_plane);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNormalized                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L204~207
    #if NATIVE
    ES physx::PxTransform getNormalized(physx::PxTransform self){
        physx::PxTransform retVal = self.getNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform getNormalized(PxTransform selfBlt);
    
    public PxTransform getNormalized(){
        PxTransform retVal = getNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L48~48
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor(physx::PxTransform ){
        physx::PxTransform nat_in_ = ();
        self.PxTransform(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor(PxTransform );
    
    public PxTransform(PxTransform ){
        PxTransform pvk_in_ = ();
        var _new = PxTransform_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxTransform                                                            #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxTransform
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L48~48
    #if NATIVE
    ES physx::PxTransform PxTransform_ctor( ){
         nat_in_ = ();
        self.PxTransform(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTransform PxTransform_ctor( );
    
    public PxTransform( ){
         pvk_in_ = ();
        var _new = PxTransform_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    Non const pointer/reference global::PhysX.physx.PxTransform
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L48~48
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxTransform self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxTransform selfBlt);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxTransform                                                           #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L48~48
    #if NATIVE
    ES void ~PxTransform(physx::PxTransform self){
        self.~PxTransform();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxTransform(PxTransform selfBlt);
    
    public void ~PxTransform(){
        ~PxTransform(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxTransform.h L48~48
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxTransform self, physx::PxTransform ){
        physx::PxTransform nat_in_ = ();
        UNPARSED_TYPE retVal = self.operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxTransform selfBlt, PxTransform );
    
    public UNPARSED_TYPE operator=(PxTransform ){
        PxTransform pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
