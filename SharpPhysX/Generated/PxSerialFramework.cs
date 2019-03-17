#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxSerializationContextPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       registerReference                                                      #
    //================================================================================
    #if NATIVE
    ES void W_registerReference(physx::PxSerializationContext* self, physx::PxBase* base, physx::PxU32 kind, ::size_t reference){
        auto nat_in_base = (base);
        auto nat_in_kind = (kind);
        auto nat_in_reference = (reference);
        self->registerReference(*nat_in_base, nat_in_kind, nat_in_reference);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerReference(PxSerializationContextPtr selfPtr, PxBasePtr base, uint kind, ulong reference);
    
    public void registerReference(PxBasePtr base, uint kind, ulong reference){
        PxBasePtr pvk_in_base = (base);
        uint pvk_in_kind = (kind);
        ulong pvk_in_reference = (reference);
        W_registerReference(this, pvk_in_base, pvk_in_kind, pvk_in_reference);
    }
    #endif
    
    
    //================================================================================
    //#       getCollection                                                          #
    //================================================================================
    /* ERRORS OCCURED: Forbidden return type
    // NATIVE SIG: PxCollection&	getCollection()	const												= 0
    #if NATIVE
    ES physx::PxCollection* W_getCollection(physx::PxSerializationContext* self){
        auto retVal = &self->getCollection();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCollectionPtr W_getCollection(PxSerializationContextPtr selfPtr);
    
    public PxCollectionPtr getCollection(){
        PxCollectionPtr retVal = W_getCollection(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       writeData                                                              #
    //================================================================================
    #if NATIVE
    ES void W_writeData(physx::PxSerializationContext* self, const void* data, physx::PxU32 size){
        auto nat_in_data = (data);
        auto nat_in_size = (size);
        self->writeData(nat_in_data, nat_in_size);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_writeData(PxSerializationContextPtr selfPtr, global::System.IntPtr data, uint size);
    
    public void writeData(global::System.IntPtr data, uint size){
        global::System.IntPtr pvk_in_data = (data);
        uint pvk_in_size = (size);
        W_writeData(this, pvk_in_data, pvk_in_size);
    }
    #endif
    
    
    //================================================================================
    //#       alignData                                                              #
    //================================================================================
    #if NATIVE
    ES void W_alignData(physx::PxSerializationContext* self, physx::PxU32 alignment){
        auto nat_in_alignment = (alignment);
        self->alignData(nat_in_alignment);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignData(PxSerializationContextPtr selfPtr, uint alignment);
    
    public void alignData(uint alignment){
        uint pvk_in_alignment = (alignment);
        W_alignData(this, pvk_in_alignment);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_alignData_OL1(physx::PxSerializationContext* self){
        self->alignData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignData_OL1(PxSerializationContextPtr selfPtr);
    
    public void alignData(){
        W_alignData_OL1(this);
    }
    #endif
    
    
    
    //================================================================================
    //#       writeName                                                              #
    //================================================================================
    #if NATIVE
    ES void W_writeName(physx::PxSerializationContext* self, const char* name){
        auto nat_in_name = (name);
        self->writeName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_writeName(PxSerializationContextPtr selfPtr, string name);
    
    public void writeName(string name){
        string pvk_in_name = (name);
        W_writeName(this, pvk_in_name);
    }
    #endif
    
    
    //================================================================================
    //#       PxSerializationContext                                                 #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxSerializationContext
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       ~PxSerializationContext                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual					~PxSerializationContext() {}
    #if NATIVE
    ES void W_~PxSerializationContext(physx::PxSerializationContext* self){
        self->~PxSerializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxSerializationContext(PxSerializationContextPtr selfPtr);
    
    public void ~PxSerializationContext(){
        W_~PxSerializationContext(this);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSerializationContext
    

#if !NATIVE
}
#endif



#if !NATIVE
public unsafe partial struct PxProcessPxBaseCallbackPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxProcessPxBaseCallback                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxProcessPxBaseCallback()  {}
    #if NATIVE
    ES void W_~PxProcessPxBaseCallback(physx::PxProcessPxBaseCallback* self){
        self->~PxProcessPxBaseCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxProcessPxBaseCallback(PxProcessPxBaseCallbackPtr selfPtr);
    
    public void ~PxProcessPxBaseCallback(){
        W_~PxProcessPxBaseCallback(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       process                                                                #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: void process(PxBase&) = 0
    #if NATIVE
    ES void W_process(physx::PxProcessPxBaseCallback* self, physx::PxBase* ){
        auto nat_in_ = ();
        self->process(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_process(PxProcessPxBaseCallbackPtr selfPtr, PxBasePtr );
    
    public void process(PxBasePtr ){
        PxBasePtr pvk_in_ = ();
        W_process(this, pvk_in_);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxProcessPxBaseCallback
    
    //Skipped generated implicit entry: PxProcessPxBaseCallback
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxDeserializationContextPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       resolveReference                                                       #
    //================================================================================
    #if NATIVE
    ES physx::PxBase* W_resolveReference(physx::PxDeserializationContext* self, physx::PxU32 kind, ::size_t reference){
        auto nat_in_kind = (kind);
        auto nat_in_reference = (reference);
        auto retVal = self->resolveReference(nat_in_kind, nat_in_reference);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBasePtr W_resolveReference(PxDeserializationContextPtr selfPtr, uint kind, ulong reference);
    
    public PxBasePtr resolveReference(uint kind, ulong reference){
        uint pvk_in_kind = (kind);
        ulong pvk_in_reference = (reference);
        PxBasePtr retVal = W_resolveReference(this, pvk_in_kind, pvk_in_reference);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       translatePxBase                                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee T*
    // NATIVE SIG: void			translatePxBase(T*& base)
    #if NATIVE
    ES void W_translatePxBase(physx::PxDeserializationContext* self,  base){
        auto nat_in_base = (base);
        self->translatePxBase(nat_in_base);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_translatePxBase(PxDeserializationContextPtr selfPtr,  base);
    
    public void translatePxBase( base){
         pvk_in_base = (base);
        W_translatePxBase(this, pvk_in_base);
    }
    #endif*/
    
    
    //================================================================================
    //#       readName                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee const char*
    // NATIVE SIG: void			readName(const char*& name)
    	{
    		PxU32 len = *reinterpret_cast<PxU32*>(mExtraDataAddress);
    		mExtraDataAddress += sizeof(len);
    		name = len ? reinterpret_cast<const char*>(mExtraDataAddress) : NULL;
    		mExtraDataAddress += len; 
    	}
    #if NATIVE
    ES void W_readName(physx::PxDeserializationContext* self,  name){
        auto nat_in_name = (name);
        self->readName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_readName(PxDeserializationContextPtr selfPtr,  name);
    
    public void readName( name){
         pvk_in_name = (name);
        W_readName(this, pvk_in_name);
    }
    #endif*/
    
    
    //================================================================================
    //#       readExtraData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE
    ES UNPARSED_TYPE W_readExtraData(physx::PxDeserializationContext* self, physx::PxU32 count){
        auto nat_in_count = (count);
        auto retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData(PxDeserializationContextPtr selfPtr, uint count);
    
    public UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = W_readExtraData(this, pvk_in_count);
        return retVal;
    }
    #endif*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE
    ES UNPARSED_TYPE W_readExtraData_OL1(physx::PxDeserializationContext* self){
        auto retVal = self->readExtraData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData_OL1(PxDeserializationContextPtr selfPtr);
    
    public UNPARSED_TYPE readExtraData(){
        UNPARSED_TYPE retVal = W_readExtraData_OL1(this);
        return retVal;
    }
    #endif*/
    
    
    
    
    //================================================================================
    //#       readExtraData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE
    ES UNPARSED_TYPE W_readExtraData(physx::PxDeserializationContext* self, physx::PxU32 count){
        auto nat_in_count = (count);
        auto retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData(PxDeserializationContextPtr selfPtr, uint count);
    
    public UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = W_readExtraData(this, pvk_in_count);
        return retVal;
    }
    #endif*/
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    #if NATIVE
    ES UNPARSED_TYPE W_readExtraData_OL1(physx::PxDeserializationContext* self){
        auto retVal = self->readExtraData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData_OL1(PxDeserializationContextPtr selfPtr);
    
    public UNPARSED_TYPE readExtraData(){
        UNPARSED_TYPE retVal = W_readExtraData_OL1(this);
        return retVal;
    }
    #endif*/
    
    
    
    
    //================================================================================
    //#       alignExtraData                                                         #
    //================================================================================
    #if NATIVE
    ES void W_alignExtraData(physx::PxDeserializationContext* self, physx::PxU32 alignment){
        auto nat_in_alignment = (alignment);
        self->alignExtraData(nat_in_alignment);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignExtraData(PxDeserializationContextPtr selfPtr, uint alignment);
    
    public void alignExtraData(uint alignment){
        uint pvk_in_alignment = (alignment);
        W_alignExtraData(this, pvk_in_alignment);
    }
    #endif
    
    
    // ### GENERATED OVERLOAD WITHOUT DEFAULTS --- 
    #if NATIVE
    ES void W_alignExtraData_OL1(physx::PxDeserializationContext* self){
        self->alignExtraData();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignExtraData_OL1(PxDeserializationContextPtr selfPtr);
    
    public void alignExtraData(){
        W_alignExtraData_OL1(this);
    }
    #endif
    
    
    
    //================================================================================
    //#       getPhysXVersion                                                        #
    //================================================================================
    #if NATIVE
    ES physx::PxU32 W_getPhysXVersion(physx::PxDeserializationContext* self){
        auto retVal = self->getPhysXVersion();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getPhysXVersion(PxDeserializationContextPtr selfPtr);
    
    public uint getPhysXVersion(){
        uint retVal = W_getPhysXVersion(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxDeserializationContext                                               #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxDeserializationContext
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       ~PxDeserializationContext                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual						~PxDeserializationContext() {}
    #if NATIVE
    ES void W_~PxDeserializationContext(physx::PxDeserializationContext* self){
        self->~PxDeserializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxDeserializationContext(PxDeserializationContextPtr selfPtr);
    
    public void ~PxDeserializationContext(){
        W_~PxDeserializationContext(this);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxDeserializationContext
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxSerializationRegistryPtr { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       registerSerializer                                                     #
    //================================================================================
    #if NATIVE
    ES void W_registerSerializer(physx::PxSerializationRegistry* self, physx::PxType type, physx::PxSerializer* serializer){
        auto nat_in_type = (type);
        auto nat_in_serializer = (serializer);
        self->registerSerializer(nat_in_type, *nat_in_serializer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerSerializer(PxSerializationRegistryPtr selfPtr, ushort type, PxSerializerPtr serializer);
    
    public void registerSerializer(ushort type, PxSerializerPtr serializer){
        ushort pvk_in_type = (type);
        PxSerializerPtr pvk_in_serializer = (serializer);
        W_registerSerializer(this, pvk_in_type, pvk_in_serializer);
    }
    #endif
    
    
    //================================================================================
    //#       unregisterSerializer                                                   #
    //================================================================================
    #if NATIVE
    ES physx::PxSerializer* W_unregisterSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->unregisterSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSerializerPtr W_unregisterSerializer(PxSerializationRegistryPtr selfPtr, ushort type);
    
    public PxSerializerPtr unregisterSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxSerializerPtr retVal = W_unregisterSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       registerBinaryMetaDataCallback                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxBinaryMetaDataCallback
    // NATIVE SIG: void						registerBinaryMetaDataCallback(PxBinaryMetaDataCallback callback) = 0
    #if NATIVE
    ES void W_registerBinaryMetaDataCallback(physx::PxSerializationRegistry* self,  callback){
        auto nat_in_callback = (callback);
        self->registerBinaryMetaDataCallback(nat_in_callback);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerBinaryMetaDataCallback(PxSerializationRegistryPtr selfPtr,  callback);
    
    public void registerBinaryMetaDataCallback( callback){
         pvk_in_callback = (callback);
        W_registerBinaryMetaDataCallback(this, pvk_in_callback);
    }
    #endif*/
    
    
    //================================================================================
    //#       getSerializer                                                          #
    //================================================================================
    #if NATIVE
    ES physx::PxSerializer* W_getSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->getSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSerializerPtr W_getSerializer(PxSerializationRegistryPtr selfPtr, ushort type);
    
    public PxSerializerPtr getSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxSerializerPtr retVal = W_getSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       registerRepXSerializer                                                 #
    //================================================================================
    #if NATIVE
    ES void W_registerRepXSerializer(physx::PxSerializationRegistry* self, physx::PxType type, physx::PxRepXSerializer* serializer){
        auto nat_in_type = (type);
        auto nat_in_serializer = (serializer);
        self->registerRepXSerializer(nat_in_type, *nat_in_serializer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerRepXSerializer(PxSerializationRegistryPtr selfPtr, ushort type, PxRepXSerializerPtr serializer);
    
    public void registerRepXSerializer(ushort type, PxRepXSerializerPtr serializer){
        ushort pvk_in_type = (type);
        PxRepXSerializerPtr pvk_in_serializer = (serializer);
        W_registerRepXSerializer(this, pvk_in_type, pvk_in_serializer);
    }
    #endif
    
    
    //================================================================================
    //#       unregisterRepXSerializer                                               #
    //================================================================================
    #if NATIVE
    ES physx::PxRepXSerializer* W_unregisterRepXSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->unregisterRepXSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRepXSerializerPtr W_unregisterRepXSerializer(PxSerializationRegistryPtr selfPtr, ushort type);
    
    public PxRepXSerializerPtr unregisterRepXSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxRepXSerializerPtr retVal = W_unregisterRepXSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getRepXSerializer                                                      #
    //================================================================================
    #if NATIVE
    ES physx::PxRepXSerializer* W_getRepXSerializer(physx::PxSerializationRegistry* self, const char* typeName){
        auto nat_in_typeName = (typeName);
        auto retVal = self->getRepXSerializer(nat_in_typeName);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRepXSerializerPtr W_getRepXSerializer(PxSerializationRegistryPtr selfPtr, string typeName);
    
    public PxRepXSerializerPtr getRepXSerializer(string typeName){
        string pvk_in_typeName = (typeName);
        PxRepXSerializerPtr retVal = W_getRepXSerializer(this, pvk_in_typeName);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    #if NATIVE
    ES void W_release(physx::PxSerializationRegistry* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxSerializationRegistryPtr selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       ~PxSerializationRegistry                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxSerializationRegistry(){}
    #if NATIVE
    ES void W_~PxSerializationRegistry(physx::PxSerializationRegistry* self){
        self->~PxSerializationRegistry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxSerializationRegistry(PxSerializationRegistryPtr selfPtr);
    
    public void ~PxSerializationRegistry(){
        W_~PxSerializationRegistry(this);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxSerializationRegistry
    
    //Skipped generated implicit entry: PxSerializationRegistry
    

#if !NATIVE
}
#endif
