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
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L124~124
    #if NATIVE
    ES void registerReference(physx::PxSerializationContext* self,  base, physx::PxU32 kind, ::size_t reference){
         nat_in_base = (base);
        physx::PxU32 nat_in_kind = (kind);
        ::size_t nat_in_reference = (reference);
        self->registerReference(nat_in_base, nat_in_kind, nat_in_reference);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void registerReference(PxSerializationContext selfPtr,  base, uint kind, ulong reference);
    
    public void registerReference( base, uint kind, ulong reference){
         pvk_in_base = (base);
        uint pvk_in_kind = (kind);
        ulong pvk_in_reference = (reference);
        registerReference(this, pvk_in_base, pvk_in_kind, pvk_in_reference);
    }
    #endif*/
    
    
    //================================================================================
    //#       getCollection                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L129~129
    #if NATIVE
    ES UNPARSED_TYPE getCollection(physx::PxSerializationContext* self){
        UNPARSED_TYPE retVal = self->getCollection();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getCollection(PxSerializationContext selfPtr);
    
    public UNPARSED_TYPE getCollection(){
        UNPARSED_TYPE retVal = getCollection(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       writeData                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L138~138
    #if NATIVE
    ES void writeData(physx::PxSerializationContext* self, void data, physx::PxU32 size){
        void nat_in_data = (data);
        physx::PxU32 nat_in_size = (size);
        self->writeData(nat_in_data, nat_in_size);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void writeData(PxSerializationContext selfPtr, void data, uint size);
    
    public void writeData(void data, uint size){
        void pvk_in_data = (data);
        uint pvk_in_size = (size);
        writeData(this, pvk_in_data, pvk_in_size);
    }
    #endif
    
    
    //================================================================================
    //#       alignData                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L147~147
    #if NATIVE
    ES void alignData(physx::PxSerializationContext* self, physx::PxU32 alignment){
        physx::PxU32 nat_in_alignment = (alignment);
        self->alignData(nat_in_alignment);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void alignData(PxSerializationContext selfPtr, uint alignment);
    
    public void alignData(uint alignment){
        uint pvk_in_alignment = (alignment);
        alignData(this, pvk_in_alignment);
    }
    #endif
    
    
    //================================================================================
    //#       writeName                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L156~156
    #if NATIVE
    ES void writeName(physx::PxSerializationContext* self, char name){
        char nat_in_name = (name);
        self->writeName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void writeName(PxSerializationContext selfPtr, sbyte name);
    
    public void writeName(sbyte name){
        sbyte pvk_in_name = (name);
        writeName(this, pvk_in_name);
    }
    #endif
    
    
    //================================================================================
    //#       PxSerializationContext                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L160~160
    #if NATIVE
    ES UNPARSED_TYPE PxSerializationContext_ctor(){
        self->PxSerializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSerializationContext_ctor();
    
    public PxSerializationContext(){
        var _new = PxSerializationContext_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxSerializationContext                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L161~161
    #if NATIVE
    ES void ~PxSerializationContext(physx::PxSerializationContext* self){
        self->~PxSerializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxSerializationContext(PxSerializationContext selfPtr);
    
    public void ~PxSerializationContext(){
        ~PxSerializationContext(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L99~99
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxSerializationContext* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxSerializationContext selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSerializationContext                                                 #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L99~99
    #if NATIVE
    ES UNPARSED_TYPE PxSerializationContext_ctor( ){
         nat_in_ = ();
        self->PxSerializationContext(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSerializationContext_ctor( );
    
    public PxSerializationContext( ){
         pvk_in_ = ();
        var _new = PxSerializationContext_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

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
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L84~84
    #if NATIVE
    ES void ~PxProcessPxBaseCallback(physx::PxProcessPxBaseCallback* self){
        self->~PxProcessPxBaseCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxProcessPxBaseCallback(PxProcessPxBaseCallback selfPtr);
    
    public void ~PxProcessPxBaseCallback(){
        ~PxProcessPxBaseCallback(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       process                                                                #
    //================================================================================
    /* ERRORS OCCURED: Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L85~85
    #if NATIVE
    ES void process(physx::PxProcessPxBaseCallback* self){
         nat_in_ = ();
        self->process(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void process(PxProcessPxBaseCallback selfPtr);
    
    public void process( ){
         pvk_in_ = ();
        process(this, pvk_in_);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L81~81
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxProcessPxBaseCallback* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxProcessPxBaseCallback selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxProcessPxBaseCallback                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L81~81
    #if NATIVE
    ES UNPARSED_TYPE PxProcessPxBaseCallback_ctor(){
        self->PxProcessPxBaseCallback();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxProcessPxBaseCallback_ctor();
    
    public PxProcessPxBaseCallback(){
        var _new = PxProcessPxBaseCallback_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxProcessPxBaseCallback                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L81~81
    #if NATIVE
    ES UNPARSED_TYPE PxProcessPxBaseCallback_ctor( ){
         nat_in_ = ();
        self->PxProcessPxBaseCallback(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxProcessPxBaseCallback_ctor( );
    
    public PxProcessPxBaseCallback( ){
         pvk_in_ = ();
        var _new = PxProcessPxBaseCallback_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

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
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L196~196
    #if NATIVE
    ES UNPARSED_TYPE resolveReference(physx::PxDeserializationContext* self, physx::PxU32 kind, ::size_t reference){
        physx::PxU32 nat_in_kind = (kind);
        ::size_t nat_in_reference = (reference);
        UNPARSED_TYPE retVal = self->resolveReference(nat_in_kind, nat_in_reference);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE resolveReference(PxDeserializationContext selfPtr, uint kind, ulong reference);
    
    public UNPARSED_TYPE resolveReference(uint kind, ulong reference){
        uint pvk_in_kind = (kind);
        ulong pvk_in_reference = (reference);
        UNPARSED_TYPE retVal = resolveReference(this, pvk_in_kind, pvk_in_reference);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       translatePxBase                                                        #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee T*
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L204~204
    #if NATIVE
    ES void translatePxBase(physx::PxDeserializationContext* self,  base){
         nat_in_base = (base);
        self->translatePxBase(nat_in_base);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void translatePxBase(PxDeserializationContext selfPtr,  base);
    
    public void translatePxBase( base){
         pvk_in_base = (base);
        translatePxBase(this, pvk_in_base);
    }
    #endif*/
    
    
    //================================================================================
    //#       readName                                                               #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee const char*
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L213~219
    #if NATIVE
    ES void readName(physx::PxDeserializationContext* self,  name){
         nat_in_name = (name);
        self->readName(nat_in_name);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void readName(PxDeserializationContext selfPtr,  name);
    
    public void readName( name){
         pvk_in_name = (name);
        readName(this, pvk_in_name);
    }
    #endif*/
    
    
    //================================================================================
    //#       readExtraData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L229~229
    #if NATIVE
    ES UNPARSED_TYPE readExtraData(physx::PxDeserializationContext* self, physx::PxU32 count){
        physx::PxU32 nat_in_count = (count);
        UNPARSED_TYPE retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE readExtraData(PxDeserializationContext selfPtr, uint count);
    
    public UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = readExtraData(this, pvk_in_count);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       readExtraData                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L244~244
    #if NATIVE
    ES UNPARSED_TYPE readExtraData(physx::PxDeserializationContext* self, physx::PxU32 count){
        physx::PxU32 nat_in_count = (count);
        UNPARSED_TYPE retVal = self->readExtraData(nat_in_count);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE readExtraData(PxDeserializationContext selfPtr, uint count);
    
    public UNPARSED_TYPE readExtraData(uint count){
        uint pvk_in_count = (count);
        UNPARSED_TYPE retVal = readExtraData(this, pvk_in_count);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       alignExtraData                                                         #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L257~262
    #if NATIVE
    ES void alignExtraData(physx::PxDeserializationContext* self, physx::PxU32 alignment){
        physx::PxU32 nat_in_alignment = (alignment);
        self->alignExtraData(nat_in_alignment);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void alignExtraData(PxDeserializationContext selfPtr, uint alignment);
    
    public void alignExtraData(uint alignment){
        uint pvk_in_alignment = (alignment);
        alignExtraData(this, pvk_in_alignment);
    }
    #endif
    
    
    //================================================================================
    //#       getPhysXVersion                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L269~269
    #if NATIVE
    ES physx::PxU32 getPhysXVersion(physx::PxDeserializationContext* self){
        physx::PxU32 retVal = self->getPhysXVersion();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getPhysXVersion(PxDeserializationContext selfPtr);
    
    public uint getPhysXVersion(){
        uint retVal = getPhysXVersion(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       PxDeserializationContext                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L273~273
    #if NATIVE
    ES UNPARSED_TYPE PxDeserializationContext_ctor(){
        self->PxDeserializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxDeserializationContext_ctor();
    
    public PxDeserializationContext(){
        var _new = PxDeserializationContext_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxDeserializationContext                                              #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L274~274
    #if NATIVE
    ES void ~PxDeserializationContext(physx::PxDeserializationContext* self){
        self->~PxDeserializationContext();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxDeserializationContext(PxDeserializationContext selfPtr);
    
    public void ~PxDeserializationContext(){
        ~PxDeserializationContext(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L174~174
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxDeserializationContext* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxDeserializationContext selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxDeserializationContext                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L174~174
    #if NATIVE
    ES UNPARSED_TYPE PxDeserializationContext_ctor( ){
         nat_in_ = ();
        self->PxDeserializationContext(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxDeserializationContext_ctor( );
    
    public PxDeserializationContext( ){
         pvk_in_ = ();
        var _new = PxDeserializationContext_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

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
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L314~314
    #if NATIVE
    ES void registerSerializer(physx::PxSerializationRegistry* self, physx::PxType type,  serializer){
        physx::PxType nat_in_type = (type);
         nat_in_serializer = (serializer);
        self->registerSerializer(nat_in_type, nat_in_serializer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void registerSerializer(PxSerializationRegistry selfPtr, ushort type,  serializer);
    
    public void registerSerializer(ushort type,  serializer){
        ushort pvk_in_type = (type);
         pvk_in_serializer = (serializer);
        registerSerializer(this, pvk_in_type, pvk_in_serializer);
    }
    #endif*/
    
    
    //================================================================================
    //#       unregisterSerializer                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L324~324
    #if NATIVE
    ES UNPARSED_TYPE unregisterSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        physx::PxType nat_in_type = (type);
        UNPARSED_TYPE retVal = self->unregisterSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE unregisterSerializer(PxSerializationRegistry selfPtr, ushort type);
    
    public UNPARSED_TYPE unregisterSerializer(ushort type){
        ushort pvk_in_type = (type);
        UNPARSED_TYPE retVal = unregisterSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       registerBinaryMetaDataCallback                                         #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter type physx::PxSerializationRegistry::registerBinaryMetaDataCallback::callback
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L335~335
    #if NATIVE
    ES void registerBinaryMetaDataCallback(physx::PxSerializationRegistry* self,  callback){
         nat_in_callback = (callback);
        self->registerBinaryMetaDataCallback(nat_in_callback);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void registerBinaryMetaDataCallback(PxSerializationRegistry selfPtr,  callback);
    
    public void registerBinaryMetaDataCallback( callback){
         pvk_in_callback = (callback);
        registerBinaryMetaDataCallback(this, pvk_in_callback);
    }
    #endif*/
    
    
    //================================================================================
    //#       getSerializer                                                          #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L345~345
    #if NATIVE
    ES UNPARSED_TYPE getSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        physx::PxType nat_in_type = (type);
        UNPARSED_TYPE retVal = self->getSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getSerializer(PxSerializationRegistry selfPtr, ushort type);
    
    public UNPARSED_TYPE getSerializer(ushort type){
        ushort pvk_in_type = (type);
        UNPARSED_TYPE retVal = getSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       registerRepXSerializer                                                 #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L362~362
    #if NATIVE
    ES void registerRepXSerializer(physx::PxSerializationRegistry* self, physx::PxType type,  serializer){
        physx::PxType nat_in_type = (type);
         nat_in_serializer = (serializer);
        self->registerRepXSerializer(nat_in_type, nat_in_serializer);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void registerRepXSerializer(PxSerializationRegistry selfPtr, ushort type,  serializer);
    
    public void registerRepXSerializer(ushort type,  serializer){
        ushort pvk_in_type = (type);
         pvk_in_serializer = (serializer);
        registerRepXSerializer(this, pvk_in_type, pvk_in_serializer);
    }
    #endif*/
    
    
    //================================================================================
    //#       unregisterRepXSerializer                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L372~372
    #if NATIVE
    ES UNPARSED_TYPE unregisterRepXSerializer(physx::PxSerializationRegistry* self, physx::PxType type){
        physx::PxType nat_in_type = (type);
        UNPARSED_TYPE retVal = self->unregisterRepXSerializer(nat_in_type);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE unregisterRepXSerializer(PxSerializationRegistry selfPtr, ushort type);
    
    public UNPARSED_TYPE unregisterRepXSerializer(ushort type){
        ushort pvk_in_type = (type);
        UNPARSED_TYPE retVal = unregisterRepXSerializer(this, pvk_in_type);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getRepXSerializer                                                      #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L382~382
    #if NATIVE
    ES UNPARSED_TYPE getRepXSerializer(physx::PxSerializationRegistry* self, char typeName){
        char nat_in_typeName = (typeName);
        UNPARSED_TYPE retVal = self->getRepXSerializer(nat_in_typeName);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getRepXSerializer(PxSerializationRegistry selfPtr, sbyte typeName);
    
    public UNPARSED_TYPE getRepXSerializer(sbyte typeName){
        sbyte pvk_in_typeName = (typeName);
        UNPARSED_TYPE retVal = getRepXSerializer(this, pvk_in_typeName);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L395~395
    #if NATIVE
    ES void release(physx::PxSerializationRegistry* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void release(PxSerializationRegistry selfPtr);
    
    public void release(){
        release(this);
    }
    #endif
    
    
    //================================================================================
    //#       ~PxSerializationRegistry                                               #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L398~398
    #if NATIVE
    ES void ~PxSerializationRegistry(physx::PxSerializationRegistry* self){
        self->~PxSerializationRegistry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxSerializationRegistry(PxSerializationRegistry selfPtr);
    
    public void ~PxSerializationRegistry(){
        ~PxSerializationRegistry(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L297~297
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxSerializationRegistry* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxSerializationRegistry selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSerializationRegistry                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L297~297
    #if NATIVE
    ES UNPARSED_TYPE PxSerializationRegistry_ctor(){
        self->PxSerializationRegistry();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSerializationRegistry_ctor();
    
    public PxSerializationRegistry(){
        var _new = PxSerializationRegistry_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       PxSerializationRegistry                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxSerialFramework.h L297~297
    #if NATIVE
    ES UNPARSED_TYPE PxSerializationRegistry_ctor( ){
         nat_in_ = ();
        self->PxSerializationRegistry(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxSerializationRegistry_ctor( );
    
    public PxSerializationRegistry( ){
         pvk_in_ = ();
        var _new = PxSerializationRegistry_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
