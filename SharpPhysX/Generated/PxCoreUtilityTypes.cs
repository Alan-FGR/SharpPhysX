#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxPaddingPtr {
    // PxPadding<TNumBytes>();
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxPaddingPtr : IPxPaddingPtr { // pointer
    private IntPtr nativePtr_;
#endif //struct start


    // ### Auto generated getters for fields
    
    /*Error generating getter/setter: Unresolved parameter type physx::PxU8[]
    */

    #if !NATIVE //hierarchy
    // Hierarchy: PxPaddingPtr
    #endif //hierarchy
    //================================================================================
    //#       PxPadding<TNumBytes>                                                   #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxPadding
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxStridedDataPtr {
    // PxStridedData();
    // UNPARSED_TYPE at(uint idx);
    // PxStridedData(/*NULLPARS*/);
    // PxStridedData(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxStridedData(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxStridedDataPtr : IPxStridedDataPtr { // pointer
    private IntPtr nativePtr_;
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
    // PxTypedStridedData<TDataType>();
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxTypedStridedDataPtr : IPxTypedStridedDataPtr { // pointer
    private IntPtr nativePtr_;
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
    //#       PxTypedStridedData<TDataType>                                          #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxTypedStridedData
    Parameterless constructor not allowed
    */
    
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxBoundedDataPtr {
    // PxBoundedData();
    // PxBoundedData(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBoundedDataPtr lhs, /*NULLPARS*/);
    // PxBoundedData(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxBoundedDataPtr lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxBoundedData(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start
public unsafe partial struct PxBoundedDataPtr : IPxStridedDataPtr, IPxBoundedDataPtr { // pointer
    private IntPtr nativePtr_;
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
    //public  PxStridedData(){((PxStridedDataPtr)this).PxStridedData();}
    //public  UNPARSED_TYPE at(uint idx){return ((PxStridedDataPtr)this).at(idx);}
    //public  PxStridedData(/*NULLPARS*/){((PxStridedDataPtr)this).PxStridedData(/*NULLARGS*/);}
    //public  PxStridedData(/*NULLPARS*/){((PxStridedDataPtr)this).PxStridedData(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/){return ((PxStridedDataPtr)this).operator=(/*NULLARGS*/);}
    //public static UNPARSED_TYPE operator=(PxStridedDataPtr lhs, /*NULLPARS*/){return ((PxStridedDataPtr)this).operator=(/*NULLARGS*/);}
    //public  UNPARSED_TYPE ~PxStridedData(/*NULLPARS*/){((PxStridedDataPtr)this).~PxStridedData(/*NULLARGS*/);}
    
    #endif //piping
    
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
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxFixedSizeLookupTablePtr {
    // PxFixedSizeLookupTable<NB_ELEMENTS>();
    // PxFixedSizeLookupTable<NB_ELEMENTS>(PxEMPTY );
    // PxFixedSizeLookupTable<NB_ELEMENTS>(float* dataPairs, uint numDataPairs);
    // PxFixedSizeLookupTable<NB_ELEMENTS>( src);
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

#if !NATIVE //struct start
public unsafe partial struct PxFixedSizeLookupTablePtr : IPxFixedSizeLookupTablePtr { // pointer
    private IntPtr nativePtr_;
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
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_PxEMPTY_C_PxFixedSizeLookupTable_ctor(physx::PxEMPTY ){
        auto nat_in_ = ();
        return PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_PxEMPTY_C_PxFixedSizeLookupTable_ctor(PxEMPTY );
    
    public  PxFixedSizeLookupTable<NB_ELEMENTS>(PxEMPTY ){
        PxEMPTY pvk_in_ = ();
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_PxEMPTY_C_PxFixedSizeLookupTable_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFixedSizeLookupTable
    // NATIVE SIG: PxFixedSizeLookupTable(const PxReal* dataPairs, const PxU32 numDataPairs)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_floatPtr_P_uint_C_PxFixedSizeLookupTable_ctor(const physx::PxReal* dataPairs, physx::PxU32 numDataPairs){
        auto nat_in_dataPairs = (dataPairs);
        auto nat_in_numDataPairs = (numDataPairs);
        return PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_dataPairs, nat_in_numDataPairs);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_floatPtr_P_uint_C_PxFixedSizeLookupTable_ctor(float* dataPairs, uint numDataPairs);
    
    public  PxFixedSizeLookupTable<NB_ELEMENTS>(float* dataPairs, uint numDataPairs){
        float* pvk_in_dataPairs = (dataPairs);
        uint pvk_in_numDataPairs = (numDataPairs);
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P_floatPtr_P_uint_C_PxFixedSizeLookupTable_ctor(pvk_in_dataPairs, pvk_in_numDataPairs);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       PxFixedSizeLookupTable<NB_ELEMENTS>                                    #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxFixedSizeLookupTable
    fsdfasdf
    // NATIVE SIG: PxFixedSizeLookupTable(const PxFixedSizeLookupTable& src)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P__C_PxFixedSizeLookupTable_ctor( src){
        auto nat_in_src = (src);
        return PxFixedSizeLookupTable<NB_ELEMENTS>(nat_in_src);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P__C_PxFixedSizeLookupTable_ctor( src);
    
    public  PxFixedSizeLookupTable<NB_ELEMENTS>( src){
         pvk_in_src = (src);
        var _new = W_PxFixedSizeLookupTable<NB_ELEMENTS>_R_PxFixedSizeLookupTablePtr_P__C_PxFixedSizeLookupTable_ctor(pvk_in_src);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       ~PxFixedSizeLookupTable<NB_ELEMENTS>                                   #
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
    //#       operator=                                                              #
    //================================================================================
    //Skipped unsupported operator Equal.
    //Note that operators like +=, *=, /=, etc are available in C# on traditional overloads.
    
    
    //================================================================================
    //#       addPair                                                                #
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
    //#       getYVal                                                                #
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
    //#       getNbDataPairs                                                         #
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
    //#       clear                                                                  #
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
    //#       getX                                                                   #
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
    //#       getY                                                                   #
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
