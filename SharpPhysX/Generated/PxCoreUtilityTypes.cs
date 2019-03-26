#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxPaddingPtr {
    // static PxPaddingPtr New();
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxPaddingPtr : IPxPaddingPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxPaddingPtrPOD{
    physx::PxU8[] mPadding;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxU8[]
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxPaddingPtr
    #endif //hierarchy
    //================================================================================
    //#       PxPadding<TNumBytes>()                                                 #
    //================================================================================
    #if NATIVE //function start
    ES PxPaddingPtrPOD W_PxPadding<TNumBytes>_R_PxPaddingPtr_C_PxPadding_ctor(){
        auto val = new PxPadding<TNumBytes>();
        return *(PxPaddingPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxPaddingPtr W_PxPadding<TNumBytes>_R_PxPaddingPtr_C_PxPadding_ctor();
    
    public  static PxPaddingPtr New(){
        var _new = W_PxPadding<TNumBytes>_R_PxPaddingPtr_C_PxPadding_ctor();
        PxPaddingPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxStridedDataPtr {
    // static PxStridedDataPtr New();
    // UNPARSED_TYPE at(uint idx);
    // static PxStridedDataPtr New(/*NULLPARS*/);
    // static PxStridedDataPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxStridedData(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxStridedDataPtr : IPxStridedDataPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxStridedDataPtrPOD{
    physx::PxU32 stride;
    const void* data;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### STRIDE getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxStridedData_GET_stride(PxStridedData* self) {return self->stride;}
    ES void PxStridedData_SET_stride(PxStridedData* self, physx::PxU32 value) {self->stride = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxStridedData_GET_stride(PxStridedDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxStridedData_SET_stride(PxStridedDataPtr selfPtr, uint value);

    public uint stride {
        get => PxStridedData_GET_stride(this);
        set => PxStridedData_SET_stride(this, value);
    }
    #endif //getter

    // ### DATA getter/setter
    #if NATIVE //getter
    ES const void* PxStridedData_GET_data(PxStridedData* self) {return self->data;}
    ES void PxStridedData_SET_data(PxStridedData* self, const void* value) {self->data = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr PxStridedData_GET_data(PxStridedDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxStridedData_SET_data(PxStridedDataPtr selfPtr, IntPtr value);

    public IntPtr data {
        get => PxStridedData_GET_data(this);
        set => PxStridedData_SET_data(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxStridedDataPtr
    #endif //hierarchy
    //================================================================================
    //#       PxStridedData()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxStridedDataPtrPOD W_PxStridedData_R_PxStridedDataPtr_C_PxStridedData_ctor(){
        auto val = new PxStridedData();
        return *(PxStridedDataPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxStridedDataPtr W_PxStridedData_R_PxStridedDataPtr_C_PxStridedData_ctor();
    
    public  static PxStridedDataPtr New(){
        var _new = W_PxStridedData_R_PxStridedDataPtr_C_PxStridedData_ctor();
        PxStridedDataPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       at(uint idx)                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: TDataType
    // NATIVE SIG: TDataType& at( PxU32 idx ) const
    #if NATIVE //function start
    ES const UNPARSED_TYPE W_at_R_TDataType_P_uint_C_PxStridedData(physx::PxStridedData* self, physx::PxU32 idx){
        auto nat_in_idx = (idx);
        auto retVal = self->at(nat_in_idx);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_at_R_TDataType_P_uint_C_PxStridedData(PxStridedDataPtr selfPtr, uint idx);
    
    public  UNPARSED_TYPE at(uint idx){
        uint pvk_in_idx = (idx);
        UNPARSED_TYPE retVal = W_at_R_TDataType_P_uint_C_PxStridedData(this, pvk_in_idx);
        return retVal;
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: PxStridedData
    
    //Skipped generated implicit entry: PxStridedData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxStridedData
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxTypedStridedDataPtr {
    // static PxTypedStridedDataPtr New();
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxTypedStridedDataPtr : IPxTypedStridedDataPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxTypedStridedDataPtrPOD{
    physx::PxU32 stride;
    TDataType* data;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### STRIDE getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxTypedStridedData_GET_stride(PxTypedStridedData* self) {return self->stride;}
    ES void PxTypedStridedData_SET_stride(PxTypedStridedData* self, physx::PxU32 value) {self->stride = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxTypedStridedData_GET_stride(PxTypedStridedDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxTypedStridedData_SET_stride(PxTypedStridedDataPtr selfPtr, uint value);

    public uint stride {
        get => PxTypedStridedData_GET_stride(this);
        set => PxTypedStridedData_SET_stride(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Unresolved parameter pointee TDataType
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxTypedStridedDataPtr
    #endif //hierarchy
    //================================================================================
    //#       PxTypedStridedData<TDataType>()                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxTypedStridedDataPtrPOD W_PxTypedStridedData<TDataType>_R_PxTypedStridedDataPtr_C_PxTypedStridedData_ctor(){
        auto val = new PxTypedStridedData<TDataType>();
        return *(PxTypedStridedDataPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTypedStridedDataPtr W_PxTypedStridedData<TDataType>_R_PxTypedStridedDataPtr_C_PxTypedStridedData_ctor();
    
    public  static PxTypedStridedDataPtr New(){
        var _new = W_PxTypedStridedData<TDataType>_R_PxTypedStridedDataPtr_C_PxTypedStridedData_ctor();
        PxTypedStridedDataPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxBoundedDataPtr {
    // static PxBoundedDataPtr New();
    // static PxBoundedDataPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBoundedDataPtr lhs, /*NULLPARS*/);
    // static PxBoundedDataPtr New(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBoundedDataPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxBoundedData(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxBoundedDataPtr : IPxStridedDataPtr, IPxBoundedDataPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxBoundedDataPtrPOD{
    physx::PxU32 count;
};
#endif //struct start


    // ### Auto generated getters for fields

    // ### COUNT getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxBoundedData_GET_count(PxBoundedData* self) {return self->count;}
    ES void PxBoundedData_SET_count(PxBoundedData* self, physx::PxU32 value) {self->count = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxBoundedData_GET_count(PxBoundedDataPtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxBoundedData_SET_count(PxBoundedDataPtr selfPtr, uint value);

    public uint count {
        get => PxBoundedData_GET_count(this);
        set => PxBoundedData_SET_count(this, value);
    }
    #endif //getter

    #if !NATIVE //hierarchy
    // Hierarchy: PxStridedDataPtr, PxBoundedDataPtr
    public static implicit operator PxStridedDataPtr(PxBoundedDataPtr obj){return *(PxStridedDataPtr*)&obj;}
    public static explicit operator PxBoundedDataPtr(PxStridedDataPtr obj){return *(PxBoundedDataPtr*)&obj;}
    #endif //hierarchy
    
    #if !NATIVE //piping
    // ### Piping
    
    // --- PxStridedDataPtr
    public  static PxStridedDataPtr New(){((PxStridedDataPtr)this).PxStridedData();}
    //public  UNPARSED_TYPE at(uint idx){return ((PxStridedDataPtr)this).at(idx);}
    //public  static PxStridedDataPtr New(/*NULLPARS*/){((PxStridedDataPtr)this).PxStridedData(/*NULLARGS*/);}
    //public  static PxStridedDataPtr New(/*NULLPARS*/){((PxStridedDataPtr)this).PxStridedData(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/){return ((PxStridedDataPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/){return ((PxStridedDataPtr)this).operator=(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxStridedData(/*NULLPARS*/){((PxStridedDataPtr)this).~PxStridedData(/*NULLARGS*/);}
    
    #endif //piping
    
    //================================================================================
    //#       PxBoundedData()                                                        #
    //================================================================================
    #if NATIVE //function start
    ES PxBoundedDataPtrPOD W_PxBoundedData_R_PxBoundedDataPtr_C_PxBoundedData_ctor(){
        auto val = new PxBoundedData();
        return *(PxBoundedDataPtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBoundedDataPtr W_PxBoundedData_R_PxBoundedDataPtr_C_PxBoundedData_ctor();
    
    public  static PxBoundedDataPtr New(){
        var _new = W_PxBoundedData_R_PxBoundedDataPtr_C_PxBoundedData_ctor();
        PxBoundedDataPtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxBoundedData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxBoundedData
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxBoundedData
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxFixedSizeLookupTablePtr {
    // static PxFixedSizeLookupTablePtr New();
    // static PxFixedSizeLookupTablePtr New(PxEMPTY );
    // static PxFixedSizeLookupTablePtr New(float* dataPairs, uint numDataPairs);
    // static PxFixedSizeLookupTablePtr New( src);
    // void ~PxFixedSizeLookupTable<NB_ELEMENTS>();
    //static UNPARSED_TYPE operator=(PxFixedSizeLookupTablePtr lhs, /*NULLPARS*/);
     void addPair(float x, float y);
     float getYVal(float x);
     uint getNbDataPairs();
     void clear();
     float getX(uint i);
     float getY(uint i);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxFixedSizeLookupTablePtr : IPxFixedSizeLookupTablePtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxFixedSizeLookupTablePtrPOD{
    physx::PxReal[] mDataPairs;
    physx::PxU32 mNbDataPairs;
    physx::PxU32[3] mPad;
};
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxReal[]
    */

    // ### MNBDATAPAIRS getter/setter
    #if NATIVE //getter
    ES physx::PxU32 PxFixedSizeLookupTable_GET_mNbDataPairs(PxFixedSizeLookupTable* self) {return self->mNbDataPairs;}
    ES void PxFixedSizeLookupTable_SET_mNbDataPairs(PxFixedSizeLookupTable* self, physx::PxU32 value) {self->mNbDataPairs = value;}
    #else //getter
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint PxFixedSizeLookupTable_GET_mNbDataPairs(PxFixedSizeLookupTablePtr selfPtr);
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void PxFixedSizeLookupTable_SET_mNbDataPairs(PxFixedSizeLookupTablePtr selfPtr, uint value);

    public uint mNbDataPairs {
        get => PxFixedSizeLookupTable_GET_mNbDataPairs(this);
        set => PxFixedSizeLookupTable_SET_mNbDataPairs(this, value);
    }
    #endif //getter
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxU32[3]
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxFixedSizeLookupTablePtr
    #endif //hierarchy
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>()                                  #
    //================================================================================
    #if NATIVE //function start
    ES PxFixedSizeLookupTablePtrPOD W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_C_PxFixedSizeLookupTable_ctor(){
        auto val = new PxFixedSizeLookupTable<NB_ELEMENTS>();
        return *(PxFixedSizeLookupTablePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFixedSizeLookupTablePtr W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_C_PxFixedSizeLookupTable_ctor();
    
    public  static PxFixedSizeLookupTablePtr New(){
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_C_PxFixedSizeLookupTable_ctor();
        PxFixedSizeLookupTablePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>(physx )                            #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: PxFixedSizeLookupTable(const PxEMPTY)
    #if NATIVE //function start
    ES PxFixedSizeLookupTablePtrPOD W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_PxEMPTY_C_PxFixedSizeLookupTable_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        auto val = new PxFixedSizeLookupTable<NB_ELEMENTS>();
        return *(PxFixedSizeLookupTablePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFixedSizeLookupTablePtr W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_PxEMPTY_C_PxFixedSizeLookupTable_ctor(PxEMPTY );
    
    public  static PxFixedSizeLookupTablePtr New(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_PxEMPTY_C_PxFixedSizeLookupTable_ctor(pvk_in_);
        PxFixedSizeLookupTablePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>(float* dataPairs, uint numDataPairs) #
    //================================================================================
    #if NATIVE //function start
    ES PxFixedSizeLookupTablePtrPOD W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_floatPtr_P_uint_C_PxFixedSizeLookupTable_ctor(const physx::PxReal* dataPairs, physx::PxU32 numDataPairs){
        auto nat_in_dataPairs = (dataPairs);
        auto nat_in_numDataPairs = (numDataPairs);
        auto val = new PxFixedSizeLookupTable<NB_ELEMENTS>();
        return *(PxFixedSizeLookupTablePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFixedSizeLookupTablePtr W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_floatPtr_P_uint_C_PxFixedSizeLookupTable_ctor(float* dataPairs, uint numDataPairs);
    
    public  static PxFixedSizeLookupTablePtr New(float* dataPairs, uint numDataPairs){
        float* pvk_in_dataPairs = (dataPairs);
        uint pvk_in_numDataPairs = (numDataPairs);
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_floatPtr_P_uint_C_PxFixedSizeLookupTable_ctor(pvk_in_dataPairs, pvk_in_numDataPairs);
        PxFixedSizeLookupTablePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>(PxFixedSizeLookupTablePtr src)     #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // NATIVE SIG: PxFixedSizeLookupTable(const PxFixedSizeLookupTable& src)
    #if NATIVE //function start
    ES PxFixedSizeLookupTablePtrPOD W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P__C_PxFixedSizeLookupTable_ctor( src){
        auto nat_in_src = (src);
        auto val = new PxFixedSizeLookupTable<NB_ELEMENTS>();
        return *(PxFixedSizeLookupTablePtrPOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxFixedSizeLookupTablePtr W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P__C_PxFixedSizeLookupTable_ctor( src);
    
    public  static PxFixedSizeLookupTablePtr New( src){
         pvk_in_src = (src);
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P__C_PxFixedSizeLookupTable_ctor(pvk_in_src);
        PxFixedSizeLookupTablePtr _ret;
        _ret.nativePtr_ = *(IntPtr*)(&_new);
        return _ret;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       ~PxFixedSizeLookupTable<NB_ELEMENTS>()                                 #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: ~PxFixedSizeLookupTable()
    #if NATIVE //function start
    ES void W_~PxFixedSizeLookupTable<NB_ELEMENTS>_R_void_C_PxFixedSizeLookupTable(physx::PxFixedSizeLookupTable* self){
        self->~PxFixedSizeLookupTable<NB_ELEMENTS>();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxFixedSizeLookupTable<NB_ELEMENTS>_R_void_C_PxFixedSizeLookupTable(PxFixedSizeLookupTablePtr selfPtr);
    
    public  void ~PxFixedSizeLookupTable<NB_ELEMENTS>(){
        W_~PxFixedSizeLookupTable<NB_ELEMENTS>_R_void_C_PxFixedSizeLookupTable(this);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       operator=(PxFixedSizeLookupTablePtr src)                               #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       addPair(float x, float y)                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_addPair_R_void_P_float_P_float_C_PxFixedSizeLookupTable(physx::PxFixedSizeLookupTable* self, physx::PxReal x, physx::PxReal y){
        auto nat_in_x = (x);
        auto nat_in_y = (y);
        self->addPair(nat_in_x, nat_in_y);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addPair_R_void_P_float_P_float_C_PxFixedSizeLookupTable(PxFixedSizeLookupTablePtr selfPtr, float x, float y);
    
    public  void addPair(float x, float y){
        float pvk_in_x = (x);
        float pvk_in_y = (y);
        W_addPair_R_void_P_float_P_float_C_PxFixedSizeLookupTable(this, pvk_in_x, pvk_in_y);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getYVal(float x)                                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getYVal_R_float_P_float_C_PxFixedSizeLookupTable(physx::PxFixedSizeLookupTable* self, physx::PxReal x){
        auto nat_in_x = (x);
        auto retVal = self->getYVal(nat_in_x);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getYVal_R_float_P_float_C_PxFixedSizeLookupTable(PxFixedSizeLookupTablePtr selfPtr, float x);
    
    public  float getYVal(float x){
        float pvk_in_x = (x);
        float retVal = W_getYVal_R_float_P_float_C_PxFixedSizeLookupTable(this, pvk_in_x);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getNbDataPairs()                                                       #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getNbDataPairs_R_uint_C_PxFixedSizeLookupTable(physx::PxFixedSizeLookupTable* self){
        auto retVal = self->getNbDataPairs();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbDataPairs_R_uint_C_PxFixedSizeLookupTable(PxFixedSizeLookupTablePtr selfPtr);
    
    public  uint getNbDataPairs(){
        uint retVal = W_getNbDataPairs_R_uint_C_PxFixedSizeLookupTable(this);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       clear()                                                                #
    //================================================================================
    #if NATIVE //function start
    ES void W_clear_R_void_C_PxFixedSizeLookupTable(physx::PxFixedSizeLookupTable* self){
        self->clear();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_clear_R_void_C_PxFixedSizeLookupTable(PxFixedSizeLookupTablePtr selfPtr);
    
    public  void clear(){
        W_clear_R_void_C_PxFixedSizeLookupTable(this);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getX(uint i)                                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getX_R_float_P_uint_C_PxFixedSizeLookupTable(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        auto nat_in_i = (i);
        auto retVal = self->getX(nat_in_i);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getX_R_float_P_uint_C_PxFixedSizeLookupTable(PxFixedSizeLookupTablePtr selfPtr, uint i);
    
    public  float getX(uint i){
        uint pvk_in_i = (i);
        float retVal = W_getX_R_float_P_uint_C_PxFixedSizeLookupTable(this, pvk_in_i);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getY(uint i)                                                           #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxReal W_getY_R_float_P_uint_C_PxFixedSizeLookupTable(physx::PxFixedSizeLookupTable* self, physx::PxU32 i){
        auto nat_in_i = (i);
        auto retVal = self->getY(nat_in_i);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern float W_getY_R_float_P_uint_C_PxFixedSizeLookupTable(PxFixedSizeLookupTablePtr selfPtr, uint i);
    
    public  float getY(uint i){
        uint pvk_in_i = (i);
        float retVal = W_getY_R_float_P_uint_C_PxFixedSizeLookupTable(this, pvk_in_i);
        return retVal;
    }
    #endif //function end
    
    

#if !NATIVE //struct close
}
#endif //struct close
