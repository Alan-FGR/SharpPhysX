#if !NATIVE
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public partial struct PxVec3 { // blittable
#endif

    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L55~57
    #if NATIVE
    ES void PxVec3(physx::PxVec3 self){
        self.PxVec3();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxVec3(PxVec3 selfBlt);
    
    public void PxVec3(){
        PxVec3(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L62~65
    #if NATIVE
    ES void PxVec3(physx::PxVec3 self, physx::PxZERO r){
        physx::PxZERO nat_in_r = (r);
        self.PxVec3(nat_in_r);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxVec3(PxVec3 selfBlt, PxZERO r);
    
    public void PxVec3(PxZERO r){
        PxZERO pvk_in_r = (r);
        PxVec3(this, pvk_in_r);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L74~76
    #if NATIVE
    ES void PxVec3(physx::PxVec3 self, float a){
        float nat_in_a = (a);
        self.PxVec3(nat_in_a);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxVec3(PxVec3 selfBlt, float a);
    
    public void PxVec3(float a){
        float pvk_in_a = (a);
        PxVec3(this, pvk_in_a);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L85~87
    #if NATIVE
    ES void PxVec3(physx::PxVec3 self, float nx, float ny, float nz){
        float nat_in_nx = (nx);
        float nat_in_ny = (ny);
        float nat_in_nz = (nz);
        self.PxVec3(nat_in_nx, nat_in_ny, nat_in_nz);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxVec3(PxVec3 selfBlt, float nx, float ny, float nz);
    
    public void PxVec3(float nx, float ny, float nz){
        float pvk_in_nx = (nx);
        float pvk_in_ny = (ny);
        float pvk_in_nz = (nz);
        PxVec3(this, pvk_in_nx, pvk_in_ny, pvk_in_nz);
    }
    #endif*/
    
    
    //================================================================================
    //#       PxVec3                                                                 #
    //================================================================================
    /* ERRORS OCCURED: Ctors TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L92~94
    #if NATIVE
    ES void PxVec3(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        self.PxVec3(nat_in_v);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxVec3(PxVec3 selfBlt, PxVec3 v);
    
    public void PxVec3(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3(this, pvk_in_v);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L101~107
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxVec3 self, physx::PxVec3 p){
        physx::PxVec3 nat_in_p = (p);
        UNPARSED_TYPE retVal = self.operator=(nat_in_p);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxVec3 selfBlt, PxVec3 p);
    
    public UNPARSED_TYPE operator=(PxVec3 p){
        PxVec3 pvk_in_p = (p);
        UNPARSED_TYPE retVal = operator=(this, pvk_in_p);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L112~117
    #if NATIVE
    ES UNPARSED_TYPE operator[](physx::PxVec3 self, unsigned int index){
        unsigned int nat_in_index = (index);
        UNPARSED_TYPE retVal = self.operator[](nat_in_index);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator[](PxVec3 selfBlt, uint index);
    
    public UNPARSED_TYPE operator[](uint index){
        uint pvk_in_index = (index);
        UNPARSED_TYPE retVal = operator[](this, pvk_in_index);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator[]                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L122~127
    #if NATIVE
    ES UNPARSED_TYPE operator[](physx::PxVec3 self, unsigned int index){
        unsigned int nat_in_index = (index);
        UNPARSED_TYPE retVal = self.operator[](nat_in_index);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator[](PxVec3 selfBlt, uint index);
    
    public UNPARSED_TYPE operator[](uint index){
        uint pvk_in_index = (index);
        UNPARSED_TYPE retVal = operator[](this, pvk_in_index);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator==                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L132~135
    #if NATIVE
    ES bool operator==(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        bool retVal = self.operator==(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator==(PxVec3 selfBlt, PxVec3 v);
    
    public bool operator==(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = operator==(this, pvk_in_v);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator!=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L140~143
    #if NATIVE
    ES bool operator!=(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        bool retVal = self.operator!=(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool operator!=(PxVec3 selfBlt, PxVec3 v);
    
    public bool operator!=(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        bool retVal = operator!=(this, pvk_in_v);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       isZero                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L148~151
    #if NATIVE
    ES bool isZero(physx::PxVec3 self){
        bool retVal = self.isZero();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isZero(PxVec3 selfBlt);
    
    public bool isZero(){
        bool retVal = isZero(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isFinite                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L156~159
    #if NATIVE
    ES bool isFinite(physx::PxVec3 self){
        bool retVal = self.isFinite();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isFinite(PxVec3 selfBlt);
    
    public bool isFinite(){
        bool retVal = isFinite(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       isNormalized                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L164~168
    #if NATIVE
    ES bool isNormalized(physx::PxVec3 self){
        bool retVal = self.isNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool isNormalized(PxVec3 selfBlt);
    
    public bool isNormalized(){
        bool retVal = isNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitudeSquared                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L175~178
    #if NATIVE
    ES float magnitudeSquared(physx::PxVec3 self){
        float retVal = self.magnitudeSquared();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float magnitudeSquared(PxVec3 selfBlt);
    
    public float magnitudeSquared(){
        float retVal = magnitudeSquared(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       magnitude                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L183~186
    #if NATIVE
    ES float magnitude(physx::PxVec3 self){
        float retVal = self.magnitude();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float magnitude(PxVec3 selfBlt);
    
    public float magnitude(){
        float retVal = magnitude(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L191~194
    #if NATIVE
    ES physx::PxVec3 operator-(physx::PxVec3 self){
        physx::PxVec3 retVal = self.operator-();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 operator-(PxVec3 selfBlt);
    
    public PxVec3 operator-(){
        PxVec3 retVal = operator-(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator+                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L199~202
    #if NATIVE
    ES physx::PxVec3 operator+(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self.operator+(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 operator+(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 operator+(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = operator+(this, pvk_in_v);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L207~210
    #if NATIVE
    ES physx::PxVec3 operator-(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self.operator-(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 operator-(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 operator-(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = operator-(this, pvk_in_v);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L215~218
    #if NATIVE
    ES physx::PxVec3 operator*(physx::PxVec3 self, float f){
        float nat_in_f = (f);
        physx::PxVec3 retVal = self.operator*(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 operator*(PxVec3 selfBlt, float f);
    
    public PxVec3 operator*(float f){
        float pvk_in_f = (f);
        PxVec3 retVal = operator*(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator/                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L223~227
    #if NATIVE
    ES physx::PxVec3 operator/(physx::PxVec3 self, float f){
        float nat_in_f = (f);
        physx::PxVec3 retVal = self.operator/(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 operator/(PxVec3 selfBlt, float f);
    
    public PxVec3 operator/(float f){
        float pvk_in_f = (f);
        PxVec3 retVal = operator/(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator+=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L232~238
    #if NATIVE
    ES UNPARSED_TYPE operator+=(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        UNPARSED_TYPE retVal = self.operator+=(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator+=(PxVec3 selfBlt, PxVec3 v);
    
    public UNPARSED_TYPE operator+=(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        UNPARSED_TYPE retVal = operator+=(this, pvk_in_v);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator-=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L243~249
    #if NATIVE
    ES UNPARSED_TYPE operator-=(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        UNPARSED_TYPE retVal = self.operator-=(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator-=(PxVec3 selfBlt, PxVec3 v);
    
    public UNPARSED_TYPE operator-=(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        UNPARSED_TYPE retVal = operator-=(this, pvk_in_v);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator*=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L254~260
    #if NATIVE
    ES UNPARSED_TYPE operator*=(physx::PxVec3 self, float f){
        float nat_in_f = (f);
        UNPARSED_TYPE retVal = self.operator*=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator*=(PxVec3 selfBlt, float f);
    
    public UNPARSED_TYPE operator*=(float f){
        float pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator*=(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator/=                                                             #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L264~271
    #if NATIVE
    ES UNPARSED_TYPE operator/=(physx::PxVec3 self, float f){
        float nat_in_f = (f);
        UNPARSED_TYPE retVal = self.operator/=(nat_in_f);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator/=(PxVec3 selfBlt, float f);
    
    public UNPARSED_TYPE operator/=(float f){
        float pvk_in_f = (f);
        UNPARSED_TYPE retVal = operator/=(this, pvk_in_f);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       dot                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L276~279
    #if NATIVE
    ES float dot(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        float retVal = self.dot(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float dot(PxVec3 selfBlt, PxVec3 v);
    
    public float dot(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        float retVal = dot(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       cross                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L284~287
    #if NATIVE
    ES physx::PxVec3 cross(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self.cross(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 cross(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 cross(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = cross(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNormalized                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L291~295
    #if NATIVE
    ES physx::PxVec3 getNormalized(physx::PxVec3 self){
        physx::PxVec3 retVal = self.getNormalized();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 getNormalized(PxVec3 selfBlt);
    
    public PxVec3 getNormalized(){
        PxVec3 retVal = getNormalized(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalize                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L300~306
    #if NATIVE
    ES float normalize(physx::PxVec3 self){
        float retVal = self.normalize();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float normalize(PxVec3 selfBlt);
    
    public float normalize(){
        float retVal = normalize(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalizeSafe                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L312~319
    #if NATIVE
    ES float normalizeSafe(physx::PxVec3 self){
        float retVal = self.normalizeSafe();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float normalizeSafe(PxVec3 selfBlt);
    
    public float normalizeSafe(){
        float retVal = normalizeSafe(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       normalizeFast                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L325~331
    #if NATIVE
    ES float normalizeFast(physx::PxVec3 self){
        float retVal = self.normalizeFast();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float normalizeFast(PxVec3 selfBlt);
    
    public float normalizeFast(){
        float retVal = normalizeFast(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       multiply                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L336~339
    #if NATIVE
    ES physx::PxVec3 multiply(physx::PxVec3 self, physx::PxVec3 a){
        physx::PxVec3 nat_in_a = (a);
        physx::PxVec3 retVal = self.multiply(nat_in_a);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 multiply(PxVec3 selfBlt, PxVec3 a);
    
    public PxVec3 multiply(PxVec3 a){
        PxVec3 pvk_in_a = (a);
        PxVec3 retVal = multiply(this, pvk_in_a);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       minimum                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L344~347
    #if NATIVE
    ES physx::PxVec3 minimum(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self.minimum(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 minimum(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 minimum(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = minimum(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       minElement                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L352~355
    #if NATIVE
    ES float minElement(physx::PxVec3 self){
        float retVal = self.minElement();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float minElement(PxVec3 selfBlt);
    
    public float minElement(){
        float retVal = minElement(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       maximum                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L360~363
    #if NATIVE
    ES physx::PxVec3 maximum(physx::PxVec3 self, physx::PxVec3 v){
        physx::PxVec3 nat_in_v = (v);
        physx::PxVec3 retVal = self.maximum(nat_in_v);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 maximum(PxVec3 selfBlt, PxVec3 v);
    
    public PxVec3 maximum(PxVec3 v){
        PxVec3 pvk_in_v = (v);
        PxVec3 retVal = maximum(this, pvk_in_v);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       maxElement                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L368~371
    #if NATIVE
    ES float maxElement(physx::PxVec3 self){
        float retVal = self.maxElement();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float maxElement(PxVec3 selfBlt);
    
    public float maxElement(){
        float retVal = maxElement(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       abs                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L376~379
    #if NATIVE
    ES physx::PxVec3 abs(physx::PxVec3 self){
        physx::PxVec3 retVal = self.abs();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 abs(PxVec3 selfBlt);
    
    public PxVec3 abs(){
        PxVec3 retVal = abs(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       ~PxVec3                                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\pxshared\include\foundation\PxVec3.h L49~49
    #if NATIVE
    ES void ~PxVec3(physx::PxVec3 self){
        self.~PxVec3();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxVec3(PxVec3 selfBlt);
    
    public void ~PxVec3(){
        ~PxVec3(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
