#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxPadding { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxPadding<TNumBytes>                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L93~97
    #if NATIVE
    ES UNPARSED_TYPE PxPadding<TNumBytes>_ctor(){
        self->PxPadding<TNumBytes>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxPadding<TNumBytes>_ctor();
    
    public PxPadding<TNumBytes>(){
        var _new = PxPadding<TNumBytes>_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxStridedData { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxStridedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE PxStridedData_ctor(){
        self->PxStridedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxStridedData_ctor();
    
    public PxStridedData(){
        var _new = PxStridedData_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       at                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L59~59
    #if NATIVE
    ES UNPARSED_TYPE at(physx::PxStridedData* self, physx::PxU32 idx){
        physx::PxU32 nat_in_idx = (idx);
        UNPARSED_TYPE retVal = self->at(nat_in_idx);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE at(PxStridedData selfPtr, uint idx);
    
    public UNPARSED_TYPE at(uint idx){
        uint pvk_in_idx = (idx);
        UNPARSED_TYPE retVal = at(this, pvk_in_idx);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxStridedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES UNPARSED_TYPE PxStridedData_ctor( ){
         nat_in_ = ();
        self->PxStridedData(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxStridedData_ctor( );
    
    public PxStridedData( ){
         pvk_in_ = ();
        var _new = PxStridedData_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxStridedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES UNPARSED_TYPE PxStridedData_ctor( ){
         nat_in_ = ();
        self->PxStridedData(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxStridedData_ctor( );
    
    public PxStridedData( ){
         pvk_in_ = ();
        var _new = PxStridedData_ctor(pvk_in_);
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
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxStridedData* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxStridedData selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxStridedData* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxStridedData selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxStridedData                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES void ~PxStridedData(physx::PxStridedData* self){
        self->~PxStridedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxStridedData(PxStridedData selfPtr);
    
    public void ~PxStridedData(){
        ~PxStridedData(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxTypedStridedData { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxTypedStridedData<TDataType>                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE PxTypedStridedData<TDataType>_ctor(){
        self->PxTypedStridedData<TDataType>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxTypedStridedData<TDataType>_ctor();
    
    public PxTypedStridedData<TDataType>(){
        var _new = PxTypedStridedData<TDataType>_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxBoundedData { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBoundedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L86~86
    #if NATIVE
    ES UNPARSED_TYPE PxBoundedData_ctor(){
        self->PxBoundedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoundedData_ctor();
    
    public PxBoundedData(){
        var _new = PxBoundedData_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoundedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE PxBoundedData_ctor( ){
         nat_in_ = ();
        self->PxBoundedData(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoundedData_ctor( );
    
    public PxBoundedData( ){
         pvk_in_ = ();
        var _new = PxBoundedData_ctor(pvk_in_);
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
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxBoundedData* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxBoundedData selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoundedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE PxBoundedData_ctor( ){
         nat_in_ = ();
        self->PxBoundedData(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxBoundedData_ctor( );
    
    public PxBoundedData( ){
         pvk_in_ = ();
        var _new = PxBoundedData_ctor(pvk_in_);
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
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxBoundedData* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxBoundedData selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBoundedData                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES void ~PxBoundedData(physx::PxBoundedData* self){
        self->~PxBoundedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxBoundedData(PxBoundedData selfPtr);
    
    public void ~PxBoundedData(){
        ~PxBoundedData(this);
    }
    #endif*/
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxFixedSizeLookupTable { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L110~110
    #if NATIVE
    ES UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(){
        self->PxFixedSizeLookupTable<NB_ELEMENTS>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor();
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>(){
        var _new = PxFixedSizeLookupTable<NB_ELEMENTS>_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L115~115
    #if NATIVE
    ES UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(physx::PxEMPTY ){
        physx::PxEMPTY nat_in_ = ();
        self->PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(PxEMPTY );
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L117~117
    #if NATIVE
    ES UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(physx::PxReal dataPairs, physx::PxU32 numDataPairs){
        physx::PxReal nat_in_dataPairs = (dataPairs);
        physx::PxU32 nat_in_numDataPairs = (numDataPairs);
        self->PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_dataPairs, nat_in_numDataPairs);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(float dataPairs, uint numDataPairs);
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>(float dataPairs, uint numDataPairs){
        float pvk_in_dataPairs = (dataPairs);
        uint pvk_in_numDataPairs = (numDataPairs);
        var _new = PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(pvk_in_dataPairs, pvk_in_numDataPairs);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L123~123
    #if NATIVE
    ES UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor( src){
         nat_in_src = (src);
        self->PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_src);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxFixedSizeLookupTable<NB_ELEMENTS>_ctor( src);
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>( src){
         pvk_in_src = (src);
        var _new = PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(pvk_in_src);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxFixedSizeLookupTable<NB_ELEMENTS>                                   #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L129~129
    #if NATIVE
    ES void ~PxFixedSizeLookupTable<NB_ELEMENTS>(physx::PxFixedSizeLookupTable* self){
        self->~PxFixedSizeLookupTable<NB_ELEMENTS>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxFixedSizeLookupTable<NB_ELEMENTS>(PxFixedSizeLookupTable selfPtr);
    
    public void ~PxFixedSizeLookupTable<NB_ELEMENTS>(){
        ~PxFixedSizeLookupTable<NB_ELEMENTS>(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L133~133
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxFixedSizeLookupTable* self,  src){
         nat_in_src = (src);
        UNPARSED_TYPE retVal = self->operator=(nat_in_src);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxFixedSizeLookupTable selfPtr,  src);
    
    public UNPARSED_TYPE operator=( src){
         pvk_in_src = (src);
        UNPARSED_TYPE retVal = operator=(this, pvk_in_src);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       addPair                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L140~140
    #if NATIVE
    ES void addPair(physx::PxFixedSizeLookupTable* self, physx::PxReal x, physx::PxReal y){
        physx::PxReal nat_in_x = (x);
        physx::PxReal nat_in_y = (y);
        self->addPair(nat_in_x, nat_in_y);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void addPair(PxFixedSizeLookupTable selfPtr, float x, float y);
    
    public void addPair(float x, float y){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        addPair(this, pvk_in_x, pvk_in_y);
    }
    #endif
    
    
    //================================================================================
    //#       getYVal                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L148~148
    #if NATIVE
    ES physx::PxReal getYVal(physx::PxFixedSizeLookupTable* self, physx::PxReal x){
        physx::PxReal nat_in_x = (x);
        physx::PxReal retVal = self->getYVal(nat_in_x);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getYVal(PxFixedSizeLookupTable selfPtr, float x);
    
    public float getYVal(float x){
        float pvk_in_x = (x);
        float retVal = getYVal(this, pvk_in_x);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbDataPairs                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L182~182
    #if NATIVE
    ES physx::PxU32 getNbDataPairs(physx::PxFixedSizeLookupTable* self){
        physx::PxU32 retVal = self->getNbDataPairs();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbDataPairs(PxFixedSizeLookupTable selfPtr);
    
    public uint getNbDataPairs(){
        uint retVal = getNbDataPairs(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       clear                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L184~184
    #if NATIVE
    ES void clear(physx::PxFixedSizeLookupTable* self){
        self->clear();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void clear(PxFixedSizeLookupTable selfPtr);
    
    public void clear(){
        clear(this);
    }
    #endif
    
    
    //================================================================================
    //#       getX                                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L190~190
    #if NATIVE
    ES physx::PxReal getX(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        physx::PxU32 nat_in_i = (i);
        physx::PxReal retVal = self->getX(nat_in_i);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getX(PxFixedSizeLookupTable selfPtr, uint i);
    
    public float getX(uint i){
        uint pvk_in_i = (i);
        float retVal = getX(this, pvk_in_i);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getY                                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L194~194
    #if NATIVE
    ES physx::PxReal getY(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        physx::PxU32 nat_in_i = (i);
        physx::PxReal retVal = self->getY(nat_in_i);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float getY(PxFixedSizeLookupTable selfPtr, uint i);
    
    public float getY(uint i){
        uint pvk_in_i = (i);
        float retVal = getY(this, pvk_in_i);
        return retVal;
    }
    #endif
    
    

#if !NATIVE
}
#endif
