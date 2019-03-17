#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxPaddingPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxPadding<TNumBytes>                                                   #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxPadding
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxStridedDataPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxStridedData                                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxStridedData
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       at                                                                     #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: TDataType
    // NATIVE SIG: TDataType& at( PxU32 idx ) const
    #if NATIVE
    ES UNPARSED_TYPE W_at(physx::PxStridedData* self, physx::PxU32 idx){
        auto nat_in_idx = (idx);
        auto retVal = self->at(nat_in_idx);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_at(PxStridedDataPtr selfPtr, uint idx);
    
    public UNPARSED_TYPE at(uint idx){
        uint pvk_in_idx = (idx);
        UNPARSED_TYPE retVal = W_at(this, pvk_in_idx);
        return retVal;
    }
    #endif*/
    
    
    //Skipped generated implicit entry: PxStridedData
    
    //Skipped generated implicit entry: PxStridedData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxStridedData
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxTypedStridedDataPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxTypedStridedData<TDataType>                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxTypedStridedData
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxBoundedDataPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxBoundedData                                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxBoundedData
    Parameterless constructor not allowed
    */
    
    
    //Skipped generated implicit entry: PxBoundedData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxBoundedData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBoundedData
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxFixedSizeLookupTablePtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxFixedSizeLookupTable
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFixedSizeLookupTable
    Invalid parameter name (empty)
    // NATIVE SIG: PxFixedSizeLookupTable(const PxEMPTY)
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
    /* ERRORS OCCURED: unhandled return type: physx::PxFixedSizeLookupTable
    // NATIVE SIG: PxFixedSizeLookupTable(const PxReal* dataPairs, const PxU32 numDataPairs)
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
    /* ERRORS OCCURED: unhandled return type: physx::PxFixedSizeLookupTable
    fsdfasdf
    // NATIVE SIG: PxFixedSizeLookupTable(const PxFixedSizeLookupTable& src)
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
    #if NATIVE
    ES void W_~PxFixedSizeLookupTable<NB_ELEMENTS>(physx::PxFixedSizeLookupTable* self){
        self->~PxFixedSizeLookupTable<NB_ELEMENTS>();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxFixedSizeLookupTable<NB_ELEMENTS>(PxFixedSizeLookupTablePtr selfPtr);
    
    public void ~PxFixedSizeLookupTable<NB_ELEMENTS>(){
        W_~PxFixedSizeLookupTable<NB_ELEMENTS>(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       addPair                                                                #
    //================================================================================
    #if NATIVE
    ES void W_addPair(physx::PxFixedSizeLookupTable* self, physx::PxReal x, physx::PxReal y){
        auto nat_in_x = (x);
        auto nat_in_y = (y);
        self->addPair(nat_in_x, nat_in_y);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addPair(PxFixedSizeLookupTablePtr selfPtr, float x, float y);
    
    public void addPair(float x, float y){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        W_addPair(this, pvk_in_x, pvk_in_y);
    }
    #endif
    
    
    //================================================================================
    //#       getYVal                                                                #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getYVal(physx::PxFixedSizeLookupTable* self, physx::PxReal x){
        auto nat_in_x = (x);
        auto retVal = self->getYVal(nat_in_x);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getYVal(PxFixedSizeLookupTablePtr selfPtr, float x);
    
    public float getYVal(float x){
        float pvk_in_x = (x);
        float retVal = W_getYVal(this, pvk_in_x);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbDataPairs                                                         #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getNbDataPairs(physx::PxFixedSizeLookupTable* self){
        auto retVal = self->getNbDataPairs();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbDataPairs(PxFixedSizeLookupTablePtr selfPtr);
    
    public uint getNbDataPairs(){
        uint retVal = W_getNbDataPairs(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       clear                                                                  #
    //================================================================================
    #if NATIVE
    ES void W_clear(physx::PxFixedSizeLookupTable* self){
        self->clear();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clear(PxFixedSizeLookupTablePtr selfPtr);
    
    public void clear(){
        W_clear(this);
    }
    #endif
    
    
    //================================================================================
    //#       getX                                                                   #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getX(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        auto nat_in_i = (i);
        auto retVal = self->getX(nat_in_i);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getX(PxFixedSizeLookupTablePtr selfPtr, uint i);
    
    public float getX(uint i){
        uint pvk_in_i = (i);
        float retVal = W_getX(this, pvk_in_i);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getY                                                                   #
    //================================================================================
    #if NATIVE
    ES physx::PxReal W_getY(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        auto nat_in_i = (i);
        auto retVal = self->getY(nat_in_i);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getY(PxFixedSizeLookupTablePtr selfPtr, uint i);
    
    public float getY(uint i){
        uint pvk_in_i = (i);
        float retVal = W_getY(this, pvk_in_i);
        return retVal;
    }
    #endif
    
    

#if !NATIVE
}
#endif
