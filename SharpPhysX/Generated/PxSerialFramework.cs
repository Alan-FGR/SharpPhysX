#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxSerializationContextPtr {
     void registerReference(PxBasePtr base, uint kind, ulong reference);
    // PxCollectionPtr getCollection();
     void writeData(IntPtr data, uint size);
     void alignData();
     void alignData(uint alignment);
     void writeName(string name);
    // static PxSerializationContextPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxSerializationContext(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSerializationContextPtr lhs, /*NULLPARS*/);
    // static PxSerializationContextPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSerializationContextPtr : IPxSerializationContextPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSerializationContextPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxSerializationContextPtr
    #endif //hierarchy
    //================================================================================
    //#       registerReference(PxBasePtr base, uint kind, ulong reference)          #
    //================================================================================
    #if NATIVE //function start
    ES void W_registerReference_R_void_P_PxBasePtr_P_uint_P_ulong_C_PxSerializationContext(physx::PxSerializationContext* self, physx::PxBase* base, physx::PxU32 kind, ::size_t reference){
        auto nat_in_base = (base);
        auto nat_in_kind = (kind);
        auto nat_in_reference = (reference);
        self->registerReference(*nat_in_base, nat_in_kind, nat_in_reference);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerReference_R_void_P_PxBasePtr_P_uint_P_ulong_C_PxSerializationContext(PxSerializationContextPtr selfPtr, PxBasePtr base, uint kind, ulong reference);
    
    public  void registerReference(PxBasePtr base, uint kind, ulong reference){
        PxBasePtr pvk_in_base = (base);
        uint pvk_in_kind = (kind);
        ulong pvk_in_reference = (reference);
        W_registerReference_R_void_P_PxBasePtr_P_uint_P_ulong_C_PxSerializationContext(this, pvk_in_base, pvk_in_kind, pvk_in_reference);
    }
    #endif //function end
    
    
    //================================================================================
    //#       getCollection()                                                        #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxCollection&	getCollection()	const												= 0
    #if NATIVE //function start
    ES const physx::PxCollection* W_getCollection_R_PxCollectionPtr_C_PxSerializationContext(physx::PxSerializationContext* self){
        auto retVal = &self->getCollection();
    //TODO check if it's returning addr of local
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCollectionPtr W_getCollection_R_PxCollectionPtr_C_PxSerializationContext(PxSerializationContextPtr selfPtr);
    
    public  PxCollectionPtr getCollection(){
        PxCollectionPtr retVal = W_getCollection_R_PxCollectionPtr_C_PxSerializationContext(this);
        return retVal;
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       writeData(IntPtr data, uint size)                                      #
    //================================================================================
    #if NATIVE //function start
    ES void W_writeData_R_void_P_IntPtr_P_uint_C_PxSerializationContext(physx::PxSerializationContext* self, const void* data, physx::PxU32 size){
        auto nat_in_data = (data);
        auto nat_in_size = (size);
        self->writeData(nat_in_data, nat_in_size);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_writeData_R_void_P_IntPtr_P_uint_C_PxSerializationContext(PxSerializationContextPtr selfPtr, IntPtr data, uint size);
    
    public  void writeData(IntPtr data, uint size){
        IntPtr pvk_in_data = (data);
        uint pvk_in_size = (size);
        W_writeData_R_void_P_IntPtr_P_uint_C_PxSerializationContext(this, pvk_in_data, pvk_in_size);
    }
    #endif //function end
    
    
    //================================================================================
    //#       alignData(uint alignment)                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_alignData_R_void_P_uint_C_PxSerializationContext(physx::PxSerializationContext* self, physx::PxU32 alignment){
        auto nat_in_alignment = (alignment);
        self->alignData(nat_in_alignment);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignData_R_void_P_uint_C_PxSerializationContext(PxSerializationContextPtr selfPtr, uint alignment);
    
    public  void alignData(uint alignment){
        uint pvk_in_alignment = (alignment);
        W_alignData_R_void_P_uint_C_PxSerializationContext(this, pvk_in_alignment);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_alignData_R_void_OL1_C_PxSerializationContext(physx::PxSerializationContext* self){
        self->alignData();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignData_R_void_OL1_C_PxSerializationContext(PxSerializationContextPtr selfPtr);
    
    public  void alignData(){
        W_alignData_R_void_OL1_C_PxSerializationContext(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       writeName(string name)                                                 #
    //================================================================================
    #if NATIVE //function start
    ES void W_writeName_R_void_P_string_C_PxSerializationContext(physx::PxSerializationContext* self, const char* name){
        auto nat_in_name = (name);
        self->writeName(nat_in_name);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_writeName_R_void_P_string_C_PxSerializationContext(PxSerializationContextPtr selfPtr, string name);
    
    public  void writeName(string name){
        string pvk_in_name = (name);
        W_writeName_R_void_P_string_C_PxSerializationContext(this, pvk_in_name);
    }
    #endif //function end
    
    
    //Skipped protected: PxSerializationContext
    
    //Skipped protected: ~PxSerializationContext
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSerializationContext
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxRepXSerializerPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxRepXSerializerPtr : IPxRepXSerializerPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxRepXSerializerPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxRepXSerializerPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxSerializerPtr {
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSerializerPtr : IPxSerializerPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSerializerPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxSerializerPtr
    #endif //hierarchy

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxProcessPxBaseCallbackPtr {
    // void ~PxProcessPxBaseCallback();
    // void process(PxBasePtr );
    //static UNPARSED_TYPE operator=(PxProcessPxBaseCallbackPtr lhs, /*NULLPARS*/);
    // static PxProcessPxBaseCallbackPtr New(/*NULLPARS*/);
    // static PxProcessPxBaseCallbackPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxProcessPxBaseCallbackPtr : IPxProcessPxBaseCallbackPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxProcessPxBaseCallbackPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxProcessPxBaseCallbackPtr
    #endif //hierarchy
    //================================================================================
    //#       ~PxProcessPxBaseCallback()                                             #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxProcessPxBaseCallback()  {}
    #if NATIVE //function start
    ES void W_~PxProcessPxBaseCallback_R_void_C_PxProcessPxBaseCallback(physx::PxProcessPxBaseCallback* self){
        self->~PxProcessPxBaseCallback();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxProcessPxBaseCallback_R_void_C_PxProcessPxBaseCallback(PxProcessPxBaseCallbackPtr selfPtr);
    
    public  void ~PxProcessPxBaseCallback(){
        W_~PxProcessPxBaseCallback_R_void_C_PxProcessPxBaseCallback(this);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       process(PxBasePtr )                                                    #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: void process(PxBase&) = 0
    #if NATIVE //function start
    ES void W_process_R_void_P_PxBasePtr_C_PxProcessPxBaseCallback(physx::PxProcessPxBaseCallback* self, physx::PxBase* ){
        auto nat_in_ = ();
        self->process(*nat_in_);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_process_R_void_P_PxBasePtr_C_PxProcessPxBaseCallback(PxProcessPxBaseCallbackPtr selfPtr, PxBasePtr );
    
    public  void process(PxBasePtr ){
        PxBasePtr pvk_in_ = ();
        W_process_R_void_P_PxBasePtr_C_PxProcessPxBaseCallback(this, pvk_in_);
    }
    #endif //function end*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxProcessPxBaseCallback
    
    //Skipped generated implicit entry: PxProcessPxBaseCallback
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxDeserializationContextPtr {
     PxBasePtr resolveReference(uint kind, ulong reference);
    // void translatePxBase( base);
    // void readName( name);
    // UNPARSED_TYPE readExtraData();
    // UNPARSED_TYPE readExtraData(uint count);
    // UNPARSED_TYPE readExtraData();
    // UNPARSED_TYPE readExtraData(uint count);
     void alignExtraData();
     void alignExtraData(uint alignment);
     uint getPhysXVersion();
    // static PxDeserializationContextPtr New(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxDeserializationContext(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxDeserializationContextPtr lhs, /*NULLPARS*/);
    // static PxDeserializationContextPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxDeserializationContextPtr : IPxDeserializationContextPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxDeserializationContextPtrPOD{
    physx::PxU8* mExtraDataAddress;
};
#endif //struct start


    // ### Auto generated getters for fields
    //Skipped non-public field: mExtraDataAddress

    #if !NATIVE //hierarchy
    // Hierarchy: PxDeserializationContextPtr
    #endif //hierarchy
    //================================================================================
    //#       resolveReference(uint kind, ulong reference)                           #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxBase* W_resolveReference_R_PxBasePtr_P_uint_P_ulong_C_PxDeserializationContext(physx::PxDeserializationContext* self, physx::PxU32 kind, ::size_t reference){
        auto nat_in_kind = (kind);
        auto nat_in_reference = (reference);
        auto retVal = self->resolveReference(nat_in_kind, nat_in_reference);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBasePtr W_resolveReference_R_PxBasePtr_P_uint_P_ulong_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr, uint kind, ulong reference);
    
    public  PxBasePtr resolveReference(uint kind, ulong reference){
        uint pvk_in_kind = (kind);
        ulong pvk_in_reference = (reference);
        PxBasePtr retVal = W_resolveReference_R_PxBasePtr_P_uint_P_ulong_C_PxDeserializationContext(this, pvk_in_kind, pvk_in_reference);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       translatePxBase(T base)                                                #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee T*
    // NATIVE SIG: void			translatePxBase(T*& base)
    #if NATIVE //function start
    ES void W_translatePxBase_R_void_P__C_PxDeserializationContext(physx::PxDeserializationContext* self,  base){
        auto nat_in_base = (base);
        self->translatePxBase(nat_in_base);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_translatePxBase_R_void_P__C_PxDeserializationContext(PxDeserializationContextPtr selfPtr,  base);
    
    public  void translatePxBase( base){
         pvk_in_base = (base);
        W_translatePxBase_R_void_P__C_PxDeserializationContext(this, pvk_in_base);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       readName(string name)                                                  #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee const char*
    // NATIVE SIG: void			readName(const char*& name)
    	{
    		PxU32 len = *reinterpret_cast<PxU32*>(mExtraDataAddress);
    		mExtraDataAddress += sizeof(len);
    		name = len ? reinterpret_cast<const char*>(mExtraDataAddress) : NULL;
    		mExtraDataAddress += len; 
    	}
    #if NATIVE //function start
    ES void W_readName_R_void_P__C_PxDeserializationContext(physx::PxDeserializationContext* self,  name){
        auto nat_in_name = (name);
        self->readName(nat_in_name);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_readName_R_void_P__C_PxDeserializationContext(PxDeserializationContextPtr selfPtr,  name);
    
    public  void readName( name){
         pvk_in_name = (name);
        W_readName_R_void_P__C_PxDeserializationContext(this, pvk_in_name);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       readExtraData(uint count)                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_readExtraData_R_T_P_uint_C_PxDeserializationContext(physx::PxDeserializationContext* self, physx::PxU32 count){
        auto nat_in_count = (count);
        auto retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData_R_T_P_uint_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr, uint count);
    
    public  UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = W_readExtraData_R_T_P_uint_C_PxDeserializationContext(this, pvk_in_count);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_readExtraData_R_T_OL1_C_PxDeserializationContext(physx::PxDeserializationContext* self){
        auto retVal = self->readExtraData();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData_R_T_OL1_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr);
    
    public  UNPARSED_TYPE readExtraData(){
        UNPARSED_TYPE retVal = W_readExtraData_R_T_OL1_C_PxDeserializationContext(this);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       readExtraData(uint count)                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_readExtraData_R_T_P_uint_C_PxDeserializationContext(physx::PxDeserializationContext* self, physx::PxU32 count){
        auto nat_in_count = (count);
        auto retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData_R_T_P_uint_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr, uint count);
    
    public  UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = W_readExtraData_R_T_P_uint_C_PxDeserializationContext(this, pvk_in_count);
        return retVal;
    }
    #endif //function end*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE //function start
    ES UNPARSED_TYPE W_readExtraData_R_T_OL1_C_PxDeserializationContext(physx::PxDeserializationContext* self){
        auto retVal = self->readExtraData();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData_R_T_OL1_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr);
    
    public  UNPARSED_TYPE readExtraData(){
        UNPARSED_TYPE retVal = W_readExtraData_R_T_OL1_C_PxDeserializationContext(this);
        return retVal;
    }
    #endif //function end*/
    
    
    
    
    //================================================================================
    //#       alignExtraData(uint alignment)                                         #
    //================================================================================
    #if NATIVE //function start
    ES void W_alignExtraData_R_void_P_uint_C_PxDeserializationContext(physx::PxDeserializationContext* self, physx::PxU32 alignment){
        auto nat_in_alignment = (alignment);
        self->alignExtraData(nat_in_alignment);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignExtraData_R_void_P_uint_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr, uint alignment);
    
    public  void alignExtraData(uint alignment){
        uint pvk_in_alignment = (alignment);
        W_alignExtraData_R_void_P_uint_C_PxDeserializationContext(this, pvk_in_alignment);
    }
    #endif //function end
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE //function start
    ES void W_alignExtraData_R_void_OL1_C_PxDeserializationContext(physx::PxDeserializationContext* self){
        self->alignExtraData();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignExtraData_R_void_OL1_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr);
    
    public  void alignExtraData(){
        W_alignExtraData_R_void_OL1_C_PxDeserializationContext(this);
    }
    #endif //function end
    
    
    
    //================================================================================
    //#       getPhysXVersion()                                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxU32 W_getPhysXVersion_R_uint_C_PxDeserializationContext(physx::PxDeserializationContext* self){
        auto retVal = self->getPhysXVersion();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getPhysXVersion_R_uint_C_PxDeserializationContext(PxDeserializationContextPtr selfPtr);
    
    public  uint getPhysXVersion(){
        uint retVal = W_getPhysXVersion_R_uint_C_PxDeserializationContext(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped protected: PxDeserializationContext
    
    //Skipped protected: ~PxDeserializationContext
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxDeserializationContext
    

#if !NATIVE //struct close
}
#endif //struct close

#if !NATIVE //interface
public unsafe interface IPxSerializationRegistryPtr {
     void registerSerializer(ushort type, PxSerializerPtr serializer);
     PxSerializerPtr unregisterSerializer(ushort type);
    // void registerBinaryMetaDataCallback( callback);
     PxSerializerPtr getSerializer(ushort type);
     void registerRepXSerializer(ushort type, PxRepXSerializerPtr serializer);
     PxRepXSerializerPtr unregisterRepXSerializer(ushort type);
     PxRepXSerializerPtr getRepXSerializer(string typeName);
     void release();
    // UNPARSED_TYPE ~PxSerializationRegistry(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxSerializationRegistryPtr lhs, /*NULLPARS*/);
    // static PxSerializationRegistryPtr New(/*NULLPARS*/);
    // static PxSerializationRegistryPtr New(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxSerializationRegistryPtr : IPxSerializationRegistryPtr { // pointer
    private IntPtr nativePtr_;
#else
//Class is not POD so we're creating one to safely return the data from native
struct PxSerializationRegistryPtrPOD{
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxSerializationRegistryPtr
    #endif //hierarchy
    //================================================================================
    //#       registerSerializer(ushort type, PxSerializerPtr serializer)            #
    //================================================================================
    #if NATIVE //function start
    ES void W_registerSerializer_R_void_P_ushort_P_PxSerializerPtr_C_PxSerializationRegistry(physx::PxSerializationRegistry* self, physx::PxType type, physx::PxSerializer* serializer){
        auto nat_in_type = (type);
        auto nat_in_serializer = (serializer);
        self->registerSerializer(nat_in_type, *nat_in_serializer);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerSerializer_R_void_P_ushort_P_PxSerializerPtr_C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr, ushort type, PxSerializerPtr serializer);
    
    public  void registerSerializer(ushort type, PxSerializerPtr serializer){
        ushort pvk_in_type = (type);
        PxSerializerPtr pvk_in_serializer = (serializer);
        W_registerSerializer_R_void_P_ushort_P_PxSerializerPtr_C_PxSerializationRegistry(this, pvk_in_type, pvk_in_serializer);
    }
    #endif //function end
    
    
    //================================================================================
    //#       unregisterSerializer(ushort type)                                      #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxSerializer* W_unregisterSerializer_R_PxSerializerPtr_P_ushort_C_PxSerializationRegistry(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->unregisterSerializer(nat_in_type);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSerializerPtr W_unregisterSerializer_R_PxSerializerPtr_P_ushort_C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr, ushort type);
    
    public  PxSerializerPtr unregisterSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxSerializerPtr retVal = W_unregisterSerializer_R_PxSerializerPtr_P_ushort_C_PxSerializationRegistry(this, pvk_in_type);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       registerBinaryMetaDataCallback(PxBinaryMetaDataCallback callback)      #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxBinaryMetaDataCallback
    // NATIVE SIG: void						registerBinaryMetaDataCallback(PxBinaryMetaDataCallback callback) = 0
    #if NATIVE //function start
    ES void W_registerBinaryMetaDataCallback_R_void_P__C_PxSerializationRegistry(physx::PxSerializationRegistry* self,  callback){
        auto nat_in_callback = (callback);
        self->registerBinaryMetaDataCallback(nat_in_callback);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerBinaryMetaDataCallback_R_void_P__C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr,  callback);
    
    public  void registerBinaryMetaDataCallback( callback){
         pvk_in_callback = (callback);
        W_registerBinaryMetaDataCallback_R_void_P__C_PxSerializationRegistry(this, pvk_in_callback);
    }
    #endif //function end*/
    
    
    //================================================================================
    //#       getSerializer(ushort type)                                             #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxSerializer* W_getSerializer_R_PxSerializerPtr_P_ushort_C_PxSerializationRegistry(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->getSerializer(nat_in_type);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSerializerPtr W_getSerializer_R_PxSerializerPtr_P_ushort_C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr, ushort type);
    
    public  PxSerializerPtr getSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxSerializerPtr retVal = W_getSerializer_R_PxSerializerPtr_P_ushort_C_PxSerializationRegistry(this, pvk_in_type);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       registerRepXSerializer(ushort type, PxRepXSerializerPtr serializer)    #
    //================================================================================
    #if NATIVE //function start
    ES void W_registerRepXSerializer_R_void_P_ushort_P_PxRepXSerializerPtr_C_PxSerializationRegistry(physx::PxSerializationRegistry* self, physx::PxType type, physx::PxRepXSerializer* serializer){
        auto nat_in_type = (type);
        auto nat_in_serializer = (serializer);
        self->registerRepXSerializer(nat_in_type, *nat_in_serializer);
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerRepXSerializer_R_void_P_ushort_P_PxRepXSerializerPtr_C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr, ushort type, PxRepXSerializerPtr serializer);
    
    public  void registerRepXSerializer(ushort type, PxRepXSerializerPtr serializer){
        ushort pvk_in_type = (type);
        PxRepXSerializerPtr pvk_in_serializer = (serializer);
        W_registerRepXSerializer_R_void_P_ushort_P_PxRepXSerializerPtr_C_PxSerializationRegistry(this, pvk_in_type, pvk_in_serializer);
    }
    #endif //function end
    
    
    //================================================================================
    //#       unregisterRepXSerializer(ushort type)                                  #
    //================================================================================
    #if NATIVE //function start
    ES physx::PxRepXSerializer* W_unregisterRepXSerializer_R_PxRepXSerializerPtr_P_ushort_C_PxSerializationRegistry(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->unregisterRepXSerializer(nat_in_type);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRepXSerializerPtr W_unregisterRepXSerializer_R_PxRepXSerializerPtr_P_ushort_C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr, ushort type);
    
    public  PxRepXSerializerPtr unregisterRepXSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxRepXSerializerPtr retVal = W_unregisterRepXSerializer_R_PxRepXSerializerPtr_P_ushort_C_PxSerializationRegistry(this, pvk_in_type);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       getRepXSerializer(string typeName)                                     #
    //================================================================================
    #if NATIVE //function start
    ES const physx::PxRepXSerializer* W_getRepXSerializer_R_PxRepXSerializerPtr_P_string_C_PxSerializationRegistry(physx::PxSerializationRegistry* self, const char* typeName){
        auto nat_in_typeName = (typeName);
        auto retVal = self->getRepXSerializer(nat_in_typeName);
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRepXSerializerPtr W_getRepXSerializer_R_PxRepXSerializerPtr_P_string_C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr, string typeName);
    
    public  PxRepXSerializerPtr getRepXSerializer(string typeName){
        string pvk_in_typeName = (typeName);
        PxRepXSerializerPtr retVal = W_getRepXSerializer_R_PxRepXSerializerPtr_P_string_C_PxSerializationRegistry(this, pvk_in_typeName);
        return retVal;
    }
    #endif //function end
    
    
    //================================================================================
    //#       release()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES void W_release_R_void_C_PxSerializationRegistry(physx::PxSerializationRegistry* self){
        self->release();
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release_R_void_C_PxSerializationRegistry(PxSerializationRegistryPtr selfPtr);
    
    public  void release(){
        W_release_R_void_C_PxSerializationRegistry(this);
    }
    #endif //function end
    
    
    //Skipped protected: ~PxSerializationRegistry
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSerializationRegistry
    
    //Skipped generated implicit entry: PxSerializationRegistry
    

#if !NATIVE //struct close
}
#endif //struct close
