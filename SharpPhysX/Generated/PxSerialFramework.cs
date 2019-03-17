#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



#if !NATIVE
public unsafe partial struct PxSerializationContext { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       registerReference                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L124~124
    #if NATIVE
    ES void W_registerReference(physx::PxSerializationContext* self, physx::PxBase* base, physx::PxU32 kind, ::size_t reference){
        auto nat_in_base = (base);
        auto nat_in_kind = (kind);
        auto nat_in_reference = (reference);
        self->registerReference(*nat_in_base, nat_in_kind, nat_in_reference);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerReference(PxSerializationContext selfPtr, PxBase base, uint kind, ulong reference);
    
    public void registerReference(PxBase base, uint kind, ulong reference){
        PxBase pvk_in_base = (base);
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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L129~129
    #if NATIVE
    ES physx::PxCollection* W_getCollection(physx::PxSerializationContext* self){
        auto retVal = &self->getCollection();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCollection W_getCollection(PxSerializationContext selfPtr);
    
    public PxCollection getCollection(){
        PxCollection retVal = W_getCollection(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       writeData                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L138~138
    #if NATIVE
    ES void W_writeData(physx::PxSerializationContext* self, const void* data, physx::PxU32 size){
        auto nat_in_data = (data);
        auto nat_in_size = (size);
        self->writeData(nat_in_data, nat_in_size);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_writeData(PxSerializationContext selfPtr, global::System.IntPtr data, uint size);
    
    public void writeData(global::System.IntPtr data, uint size){
        global::System.IntPtr pvk_in_data = (data);
        uint pvk_in_size = (size);
        W_writeData(this, pvk_in_data, pvk_in_size);
    }
    #endif
    
    
    //================================================================================
    //#       alignData                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L147~147
    #if NATIVE
    ES void W_alignData(physx::PxSerializationContext* self, physx::PxU32 alignment){
        auto nat_in_alignment = (alignment);
        self->alignData(nat_in_alignment);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignData(PxSerializationContext selfPtr, uint alignment);
    
    public void alignData(uint alignment){
        uint pvk_in_alignment = (alignment);
        W_alignData(this, pvk_in_alignment);
    }
    #endif
    
    
    //================================================================================
    //#       writeName                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L156~156
    #if NATIVE
    ES void W_writeName(physx::PxSerializationContext* self, const char* name){
        auto nat_in_name = (name);
        self->writeName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_writeName(PxSerializationContext selfPtr, string name);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L161~161
    #if NATIVE
    ES void W_~PxSerializationContext(physx::PxSerializationContext* self){
        self->~PxSerializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxSerializationContext(PxSerializationContext selfPtr);
    
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
public unsafe partial struct PxProcessPxBaseCallback { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxProcessPxBaseCallback                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxProcessPxBaseCallback()  {}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L84~84
    #if NATIVE
    ES void W_~PxProcessPxBaseCallback(physx::PxProcessPxBaseCallback* self){
        self->~PxProcessPxBaseCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxProcessPxBaseCallback(PxProcessPxBaseCallback selfPtr);
    
    public void ~PxProcessPxBaseCallback(){
        W_~PxProcessPxBaseCallback(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       process                                                                #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name (empty)
    // NATIVE SIG: void process(PxBase&) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L85~85
    #if NATIVE
    ES void W_process(physx::PxProcessPxBaseCallback* self, physx::PxBase* ){
        auto nat_in_ = ();
        self->process(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_process(PxProcessPxBaseCallback selfPtr, PxBase );
    
    public void process(PxBase ){
        PxBase pvk_in_ = ();
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
public unsafe partial struct PxDeserializationContext { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       resolveReference                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L196~196
    #if NATIVE
    ES physx::PxBase* W_resolveReference(physx::PxDeserializationContext* self, physx::PxU32 kind, ::size_t reference){
        auto nat_in_kind = (kind);
        auto nat_in_reference = (reference);
        auto retVal = self->resolveReference(nat_in_kind, nat_in_reference);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBase W_resolveReference(PxDeserializationContext selfPtr, uint kind, ulong reference);
    
    public PxBase resolveReference(uint kind, ulong reference){
        uint pvk_in_kind = (kind);
        ulong pvk_in_reference = (reference);
        PxBase retVal = W_resolveReference(this, pvk_in_kind, pvk_in_reference);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       translatePxBase                                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee T*
    // NATIVE SIG: void			translatePxBase(T*& base)
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L204~204
    #if NATIVE
    ES void W_translatePxBase(physx::PxDeserializationContext* self,  base){
        auto nat_in_base = (base);
        self->translatePxBase(nat_in_base);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_translatePxBase(PxDeserializationContext selfPtr,  base);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L213~219
    #if NATIVE
    ES void W_readName(physx::PxDeserializationContext* self,  name){
        auto nat_in_name = (name);
        self->readName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_readName(PxDeserializationContext selfPtr,  name);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L229~229
    #if NATIVE
    ES UNPARSED_TYPE W_readExtraData(physx::PxDeserializationContext* self, physx::PxU32 count){
        auto nat_in_count = (count);
        auto retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData(PxDeserializationContext selfPtr, uint count);
    
    public UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = W_readExtraData(this, pvk_in_count);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       readExtraData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return reference type: T
    // NATIVE SIG: T*				readExtraData(PxU32 count=1)
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L244~244
    #if NATIVE
    ES UNPARSED_TYPE W_readExtraData(physx::PxDeserializationContext* self, physx::PxU32 count){
        auto nat_in_count = (count);
        auto retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_readExtraData(PxDeserializationContext selfPtr, uint count);
    
    public UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = W_readExtraData(this, pvk_in_count);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       alignExtraData                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L257~262
    #if NATIVE
    ES void W_alignExtraData(physx::PxDeserializationContext* self, physx::PxU32 alignment){
        auto nat_in_alignment = (alignment);
        self->alignExtraData(nat_in_alignment);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_alignExtraData(PxDeserializationContext selfPtr, uint alignment);
    
    public void alignExtraData(uint alignment){
        uint pvk_in_alignment = (alignment);
        W_alignExtraData(this, pvk_in_alignment);
    }
    #endif
    
    
    //================================================================================
    //#       getPhysXVersion                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L269~269
    #if NATIVE
    ES physx::PxU32 W_getPhysXVersion(physx::PxDeserializationContext* self){
        auto retVal = self->getPhysXVersion();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getPhysXVersion(PxDeserializationContext selfPtr);
    
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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L274~274
    #if NATIVE
    ES void W_~PxDeserializationContext(physx::PxDeserializationContext* self){
        self->~PxDeserializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxDeserializationContext(PxDeserializationContext selfPtr);
    
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
public unsafe partial struct PxSerializationRegistry { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       registerSerializer                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L314~314
    #if NATIVE
    ES void W_registerSerializer(physx::PxSerializationRegistry* self, physx::PxType type, physx::PxSerializer* serializer){
        auto nat_in_type = (type);
        auto nat_in_serializer = (serializer);
        self->registerSerializer(nat_in_type, *nat_in_serializer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerSerializer(PxSerializationRegistry selfPtr, ushort type, PxSerializer serializer);
    
    public void registerSerializer(ushort type, PxSerializer serializer){
        ushort pvk_in_type = (type);
        PxSerializer pvk_in_serializer = (serializer);
        W_registerSerializer(this, pvk_in_type, pvk_in_serializer);
    }
    #endif
    
    
    //================================================================================
    //#       unregisterSerializer                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L324~324
    #if NATIVE
    ES physx::PxSerializer* W_unregisterSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->unregisterSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSerializer W_unregisterSerializer(PxSerializationRegistry selfPtr, ushort type);
    
    public PxSerializer unregisterSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxSerializer retVal = W_unregisterSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       registerBinaryMetaDataCallback                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxBinaryMetaDataCallback
    // NATIVE SIG: void						registerBinaryMetaDataCallback(PxBinaryMetaDataCallback callback) = 0
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L335~335
    #if NATIVE
    ES void W_registerBinaryMetaDataCallback(physx::PxSerializationRegistry* self,  callback){
        auto nat_in_callback = (callback);
        self->registerBinaryMetaDataCallback(nat_in_callback);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerBinaryMetaDataCallback(PxSerializationRegistry selfPtr,  callback);
    
    public void registerBinaryMetaDataCallback( callback){
         pvk_in_callback = (callback);
        W_registerBinaryMetaDataCallback(this, pvk_in_callback);
    }
    #endif*/
    
    
    //================================================================================
    //#       getSerializer                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L345~345
    #if NATIVE
    ES physx::PxSerializer* W_getSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->getSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxSerializer W_getSerializer(PxSerializationRegistry selfPtr, ushort type);
    
    public PxSerializer getSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxSerializer retVal = W_getSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       registerRepXSerializer                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L362~362
    #if NATIVE
    ES void W_registerRepXSerializer(physx::PxSerializationRegistry* self, physx::PxType type, physx::PxRepXSerializer* serializer){
        auto nat_in_type = (type);
        auto nat_in_serializer = (serializer);
        self->registerRepXSerializer(nat_in_type, *nat_in_serializer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_registerRepXSerializer(PxSerializationRegistry selfPtr, ushort type, PxRepXSerializer serializer);
    
    public void registerRepXSerializer(ushort type, PxRepXSerializer serializer){
        ushort pvk_in_type = (type);
        PxRepXSerializer pvk_in_serializer = (serializer);
        W_registerRepXSerializer(this, pvk_in_type, pvk_in_serializer);
    }
    #endif
    
    
    //================================================================================
    //#       unregisterRepXSerializer                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L372~372
    #if NATIVE
    ES physx::PxRepXSerializer* W_unregisterRepXSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        auto nat_in_type = (type);
        auto retVal = self->unregisterRepXSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRepXSerializer W_unregisterRepXSerializer(PxSerializationRegistry selfPtr, ushort type);
    
    public PxRepXSerializer unregisterRepXSerializer(ushort type){
        ushort pvk_in_type = (type);
        PxRepXSerializer retVal = W_unregisterRepXSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getRepXSerializer                                                      #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L382~382
    #if NATIVE
    ES physx::PxRepXSerializer* W_getRepXSerializer(physx::PxSerializationRegistry* self, const char* typeName){
        auto nat_in_typeName = (typeName);
        auto retVal = self->getRepXSerializer(nat_in_typeName);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxRepXSerializer W_getRepXSerializer(PxSerializationRegistry selfPtr, string typeName);
    
    public PxRepXSerializer getRepXSerializer(string typeName){
        string pvk_in_typeName = (typeName);
        PxRepXSerializer retVal = W_getRepXSerializer(this, pvk_in_typeName);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L395~395
    #if NATIVE
    ES void W_release(physx::PxSerializationRegistry* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxSerializationRegistry selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       ~PxSerializationRegistry                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxSerializationRegistry(){}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L398~398
    #if NATIVE
    ES void W_~PxSerializationRegistry(physx::PxSerializationRegistry* self){
        self->~PxSerializationRegistry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxSerializationRegistry(PxSerializationRegistry selfPtr);
    
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
