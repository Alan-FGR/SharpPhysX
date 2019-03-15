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
    // NATIVE SIG: PxPadding()
    	{
    		for ( PxU8 idx =0; idx < TNumBytes; ++idx )
    			mPadding[idx] = 0;
    	}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L93~97
    #if NATIVE
    ES UNPARSED_TYPE W_PxPadding<TNumBytes>_ctor(){
        self->PxPadding<TNumBytes>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxPadding<TNumBytes>_ctor();
    
    public PxPadding<TNumBytes>(){
        var _new = W_PxPadding<TNumBytes>_ctor();
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
    // NATIVE SIG: PxStridedData() : stride( 0 ), data( NULL ) {}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L56~56
    #if NATIVE
    ES UNPARSED_TYPE W_PxStridedData_ctor(){
        self->PxStridedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxStridedData_ctor();
    
    public PxStridedData(){
        var _new = W_PxStridedData_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       at                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    // NATIVE SIG: TDataType& at( PxU32 idx ) const
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L59~59
    #if NATIVE
    ES UNPARSED_TYPE W_at(physx::PxStridedData* self, physx::PxU32 idx){
        auto nat_in_idx = (idx);
        auto retVal = self->at(nat_in_idx);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_at(PxStridedData selfPtr, uint idx);
    
    public UNPARSED_TYPE at(uint idx){
        uint pvk_in_idx = (idx);
        UNPARSED_TYPE retVal = W_at(this, pvk_in_idx);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxStridedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxStridedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES UNPARSED_TYPE W_PxStridedData_ctor(physx::PxStridedData* ){
        auto nat_in_ = ();
        self->PxStridedData(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxStridedData_ctor(PxStridedData );
    
    public PxStridedData(PxStridedData ){
        PxStridedData pvk_in_ = ();
        var _new = W_PxStridedData_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxStridedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxStridedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES UNPARSED_TYPE W_PxStridedData_ctor(physx::PxStridedData* ){
        auto nat_in_ = ();
        self->PxStridedData(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxStridedData_ctor(PxStridedData );
    
    public PxStridedData(PxStridedData ){
        PxStridedData pvk_in_ = ();
        var _new = W_PxStridedData_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxStridedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES physx::PxStridedData* W_operator=(physx::PxStridedData* self, physx::PxStridedData* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxStridedData W_operator=(PxStridedData selfPtr, PxStridedData );
    
    public static PxStridedData operator=(PxStridedData lhs, PxStridedData ){
        PxStridedData pvk_in_ = ();
        PxStridedData retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxStridedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES physx::PxStridedData* W_operator=(physx::PxStridedData* self, physx::PxStridedData* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxStridedData W_operator=(PxStridedData selfPtr, PxStridedData );
    
    public static PxStridedData operator=(PxStridedData lhs, PxStridedData ){
        PxStridedData pvk_in_ = ();
        PxStridedData retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxStridedData                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxStridedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L46~46
    #if NATIVE
    ES void W_~PxStridedData(physx::PxStridedData* self){
        self->~PxStridedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxStridedData(PxStridedData selfPtr);
    
    public void ~PxStridedData(){
        W_~PxStridedData(this);
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
    // NATIVE SIG: PxTypedStridedData()
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L75~75
    #if NATIVE
    ES UNPARSED_TYPE W_PxTypedStridedData<TDataType>_ctor(){
        self->PxTypedStridedData<TDataType>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxTypedStridedData<TDataType>_ctor();
    
    public PxTypedStridedData<TDataType>(){
        var _new = W_PxTypedStridedData<TDataType>_ctor();
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
    // NATIVE SIG: PxBoundedData() : count( 0 ) {}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L86~86
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoundedData_ctor(){
        self->PxBoundedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoundedData_ctor();
    
    public PxBoundedData(){
        var _new = W_PxBoundedData_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoundedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoundedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoundedData_ctor(physx::PxBoundedData* ){
        auto nat_in_ = ();
        self->PxBoundedData(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoundedData_ctor(PxBoundedData );
    
    public PxBoundedData(PxBoundedData ){
        PxBoundedData pvk_in_ = ();
        var _new = W_PxBoundedData_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoundedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES physx::PxBoundedData* W_operator=(physx::PxBoundedData* self, physx::PxBoundedData* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoundedData W_operator=(PxBoundedData selfPtr, PxBoundedData );
    
    public static PxBoundedData operator=(PxBoundedData lhs, PxBoundedData ){
        PxBoundedData pvk_in_ = ();
        PxBoundedData retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxBoundedData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoundedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES UNPARSED_TYPE W_PxBoundedData_ctor(physx::PxBoundedData* ){
        auto nat_in_ = ();
        self->PxBoundedData(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxBoundedData_ctor(PxBoundedData );
    
    public PxBoundedData(PxBoundedData ){
        PxBoundedData pvk_in_ = ();
        var _new = W_PxBoundedData_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxBoundedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES physx::PxBoundedData* W_operator=(physx::PxBoundedData* self, physx::PxBoundedData* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoundedData W_operator=(PxBoundedData selfPtr, PxBoundedData );
    
    public static PxBoundedData operator=(PxBoundedData lhs, PxBoundedData ){
        PxBoundedData pvk_in_ = ();
        PxBoundedData retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxBoundedData                                                         #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: PxBoundedData
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L83~83
    #if NATIVE
    ES void W_~PxBoundedData(physx::PxBoundedData* self){
        self->~PxBoundedData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxBoundedData(PxBoundedData selfPtr);
    
    public void ~PxBoundedData(){
        W_~PxBoundedData(this);
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
    // NATIVE SIG: PxFixedSizeLookupTable()
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L110~110
    #if NATIVE
    ES UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(){
        self->PxFixedSizeLookupTable<NB_ELEMENTS>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor();
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>(){
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxFixedSizeLookupTable(const PxEMPTY)
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L115~115
    #if NATIVE
    ES UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        self->PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(PxEMPTY );
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // NATIVE SIG: PxFixedSizeLookupTable(const PxReal* dataPairs, const PxU32 numDataPairs)
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L117~117
    #if NATIVE
    ES UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(const physx::PxReal* dataPairs, physx::PxU32 numDataPairs){
        auto nat_in_dataPairs = (dataPairs);
        auto nat_in_numDataPairs = (numDataPairs);
        self->PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_dataPairs, nat_in_numDataPairs);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(float* dataPairs, uint numDataPairs);
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>(float* dataPairs, uint numDataPairs){
        float* pvk_in_dataPairs = (dataPairs);
        uint pvk_in_numDataPairs = (numDataPairs);
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(pvk_in_dataPairs, pvk_in_numDataPairs);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    fsdfasdf
    // NATIVE SIG: PxFixedSizeLookupTable(const PxFixedSizeLookupTable& src)
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L123~123
    #if NATIVE
    ES UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor( src){
        auto nat_in_src = (src);
        self->PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_src);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor( src);
    
    public PxFixedSizeLookupTable<NB_ELEMENTS>( src){
         pvk_in_src = (src);
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_ctor(pvk_in_src);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxFixedSizeLookupTable<NB_ELEMENTS>                                   #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: ~PxFixedSizeLookupTable()
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L129~129
    #if NATIVE
    ES void W_~PxFixedSizeLookupTable<NB_ELEMENTS>(physx::PxFixedSizeLookupTable* self){
        self->~PxFixedSizeLookupTable<NB_ELEMENTS>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxFixedSizeLookupTable<NB_ELEMENTS>(PxFixedSizeLookupTable selfPtr);
    
    public void ~PxFixedSizeLookupTable<NB_ELEMENTS>(){
        W_~PxFixedSizeLookupTable<NB_ELEMENTS>(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type
    Ops TODO
    fsdfasdf
    // NATIVE SIG: PxFixedSizeLookupTable& operator=(const PxFixedSizeLookupTable& src)
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L133~133
    #if NATIVE
    ES UNPARSED_TYPE W_operator=(physx::PxFixedSizeLookupTable* self,  src){
        auto nat_in_src = (src);
        auto retVal = self->operator=(nat_in_src);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_operator=(PxFixedSizeLookupTable selfPtr,  src);
    
    public static UNPARSED_TYPE operator=(PxFixedSizeLookupTable lhs,  src){
         pvk_in_src = (src);
        UNPARSED_TYPE retVal = W_operator=(lhs, pvk_in_src);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       addPair                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L140~140
    #if NATIVE
    ES void W_addPair(physx::PxFixedSizeLookupTable* self, physx::PxReal x, physx::PxReal y){
        auto nat_in_x = (x);
        auto nat_in_y = (y);
        self->addPair(nat_in_x, nat_in_y);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addPair(PxFixedSizeLookupTable selfPtr, float x, float y);
    
    public void addPair(float x, float y){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        W_addPair(this, pvk_in_x, pvk_in_y);
    }
    #endif
    
    
    //================================================================================
    //#       getYVal                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L148~148
    #if NATIVE
    ES physx::PxReal W_getYVal(physx::PxFixedSizeLookupTable* self, physx::PxReal x){
        auto nat_in_x = (x);
        auto retVal = self->getYVal(nat_in_x);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getYVal(PxFixedSizeLookupTable selfPtr, float x);
    
    public float getYVal(float x){
        float pvk_in_x = (x);
        float retVal = W_getYVal(this, pvk_in_x);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbDataPairs                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L182~182
    #if NATIVE
    ES physx::PxU32 W_getNbDataPairs(physx::PxFixedSizeLookupTable* self){
        auto retVal = self->getNbDataPairs();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbDataPairs(PxFixedSizeLookupTable selfPtr);
    
    public uint getNbDataPairs(){
        uint retVal = W_getNbDataPairs(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       clear                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L184~184
    #if NATIVE
    ES void W_clear(physx::PxFixedSizeLookupTable* self){
        self->clear();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clear(PxFixedSizeLookupTable selfPtr);
    
    public void clear(){
        W_clear(this);
    }
    #endif
    
    
    //================================================================================
    //#       getX                                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L190~190
    #if NATIVE
    ES physx::PxReal W_getX(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        auto nat_in_i = (i);
        auto retVal = self->getX(nat_in_i);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getX(PxFixedSizeLookupTable selfPtr, uint i);
    
    public float getX(uint i){
        uint pvk_in_i = (i);
        float retVal = W_getX(this, pvk_in_i);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getY                                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCoreUtilityTypes.h L194~194
    #if NATIVE
    ES physx::PxReal W_getY(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        auto nat_in_i = (i);
        auto retVal = self->getY(nat_in_i);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getY(PxFixedSizeLookupTable selfPtr, uint i);
    
    public float getY(uint i){
        uint pvk_in_i = (i);
        float retVal = W_getY(this, pvk_in_i);
        return retVal;
    }
    #endif
    
    

#if !NATIVE
}
#endif
