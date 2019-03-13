#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


#if !NATIVE
public unsafe partial struct PxCollection { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       add                                                                    #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L122~122
    #if NATIVE
    ES void add(physx::PxCollection* self,  object, physx::PxSerialObjectId id){
         nat_in_object = (object);
        physx::PxSerialObjectId nat_in_id = (id);
        self->add(nat_in_object, nat_in_id);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void add(PxCollection selfPtr,  object, ulong id);
    
    public void add( object, ulong id){
         pvk_in_object = (object);
        ulong pvk_in_id = (id);
        add(this, pvk_in_object, pvk_in_id);
    }
    #endif*/
    
    
    //================================================================================
    //#       remove                                                                 #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L131~131
    #if NATIVE
    ES void remove(physx::PxCollection* self,  object){
         nat_in_object = (object);
        self->remove(nat_in_object);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void remove(PxCollection selfPtr,  object);
    
    public void remove( object){
         pvk_in_object = (object);
        remove(this, pvk_in_object);
    }
    #endif*/
    
    
    //================================================================================
    //#       contains                                                               #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L139~139
    #if NATIVE
    ES bool contains(physx::PxCollection* self,  object){
         nat_in_object = (object);
        bool retVal = self->contains(nat_in_object);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool contains(PxCollection selfPtr,  object);
    
    public bool contains( object){
         pvk_in_object = (object);
        bool retVal = contains(this, pvk_in_object);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       addId                                                                  #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L151~151
    #if NATIVE
    ES void addId(physx::PxCollection* self,  object, physx::PxSerialObjectId id){
         nat_in_object = (object);
        physx::PxSerialObjectId nat_in_id = (id);
        self->addId(nat_in_object, nat_in_id);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void addId(PxCollection selfPtr,  object, ulong id);
    
    public void addId( object, ulong id){
         pvk_in_object = (object);
        ulong pvk_in_id = (id);
        addId(this, pvk_in_object, pvk_in_id);
    }
    #endif*/
    
    
    //================================================================================
    //#       removeId                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L160~160
    #if NATIVE
    ES void removeId(physx::PxCollection* self, physx::PxSerialObjectId id){
        physx::PxSerialObjectId nat_in_id = (id);
        self->removeId(nat_in_id);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void removeId(PxCollection selfPtr, ulong id);
    
    public void removeId(ulong id){
        ulong pvk_in_id = (id);
        removeId(this, pvk_in_id);
    }
    #endif
    
    
    //================================================================================
    //#       add                                                                    #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L170~170
    #if NATIVE
    ES void add(physx::PxCollection* self,  collection){
         nat_in_collection = (collection);
        self->add(nat_in_collection);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void add(PxCollection selfPtr,  collection);
    
    public void add( collection){
         pvk_in_collection = (collection);
        add(this, pvk_in_collection);
    }
    #endif*/
    
    
    //================================================================================
    //#       remove                                                                 #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L180~180
    #if NATIVE
    ES void remove(physx::PxCollection* self,  collection){
         nat_in_collection = (collection);
        self->remove(nat_in_collection);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void remove(PxCollection selfPtr,  collection);
    
    public void remove( collection){
         pvk_in_collection = (collection);
        remove(this, pvk_in_collection);
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbObjects                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L187~187
    #if NATIVE
    ES physx::PxU32 getNbObjects(physx::PxCollection* self){
        physx::PxU32 retVal = self->getNbObjects();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbObjects(PxCollection selfPtr);
    
    public uint getNbObjects(){
        uint retVal = getNbObjects(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getObject                                                              #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L195~195
    #if NATIVE
    ES UNPARSED_TYPE getObject(physx::PxCollection* self, physx::PxU32 index){
        physx::PxU32 nat_in_index = (index);
        UNPARSED_TYPE retVal = self->getObject(nat_in_index);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE getObject(PxCollection selfPtr, uint index);
    
    public UNPARSED_TYPE getObject(uint index){
        uint pvk_in_index = (index);
        UNPARSED_TYPE retVal = getObject(this, pvk_in_index);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getObjects                                                             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxBase*
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L205~205
    #if NATIVE
    ES physx::PxU32 getObjects(physx::PxCollection* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getObjects(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getObjects(PxCollection selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getObjects( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getObjects(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       find                                                                   #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L215~215
    #if NATIVE
    ES UNPARSED_TYPE find(physx::PxCollection* self, physx::PxSerialObjectId id){
        physx::PxSerialObjectId nat_in_id = (id);
        UNPARSED_TYPE retVal = self->find(nat_in_id);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE find(PxCollection selfPtr, ulong id);
    
    public UNPARSED_TYPE find(ulong id){
        ulong pvk_in_id = (id);
        UNPARSED_TYPE retVal = find(this, pvk_in_id);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getNbIds                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L222~222
    #if NATIVE
    ES physx::PxU32 getNbIds(physx::PxCollection* self){
        physx::PxU32 retVal = self->getNbIds();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getNbIds(PxCollection selfPtr);
    
    public uint getNbIds(){
        uint retVal = getNbIds(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getIds                                                                 #
    //================================================================================
    /* ERRORS OCCURED: Non const pointer/reference ulong*
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L232~232
    #if NATIVE
    ES physx::PxU32 getIds(physx::PxCollection* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
         nat_in_userBuffer = (userBuffer);
        physx::PxU32 nat_in_bufferSize = (bufferSize);
        physx::PxU32 nat_in_startIndex = (startIndex);
        physx::PxU32 retVal = self->getIds(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint getIds(PxCollection selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getIds( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = getIds(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getId                                                                  #
    //================================================================================
    /* ERRORS OCCURED: fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L242~242
    #if NATIVE
    ES physx::PxSerialObjectId getId(physx::PxCollection* self,  object){
         nat_in_object = (object);
        physx::PxSerialObjectId retVal = self->getId(nat_in_object);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ulong getId(PxCollection selfPtr,  object);
    
    public ulong getId( object){
         pvk_in_object = (object);
        ulong retVal = getId(this, pvk_in_object);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L253~253
    #if NATIVE
    ES void release(physx::PxCollection* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void release(PxCollection selfPtr);
    
    public void release(){
        release(this);
    }
    #endif
    
    
    //================================================================================
    //#       PxCollection                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L256~256
    #if NATIVE
    ES UNPARSED_TYPE PxCollection_ctor(){
        self->PxCollection();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxCollection_ctor();
    
    public PxCollection(){
        var _new = PxCollection_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxCollection                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L257~257
    #if NATIVE
    ES void ~PxCollection(physx::PxCollection* self){
        self->~PxCollection();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void ~PxCollection(PxCollection selfPtr);
    
    public void ~PxCollection(){
        ~PxCollection(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L105~105
    #if NATIVE
    ES UNPARSED_TYPE operator=(physx::PxCollection* self){
         nat_in_ = ();
        UNPARSED_TYPE retVal = self->operator=(nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE operator=(PxCollection selfPtr);
    
    public UNPARSED_TYPE operator=( ){
         pvk_in_ = ();
        UNPARSED_TYPE retVal = operator=(this, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCollection                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name
    fsdfasdf
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L105~105
    #if NATIVE
    ES UNPARSED_TYPE PxCollection_ctor( ){
         nat_in_ = ();
        self->PxCollection(nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE PxCollection_ctor( );
    
    public PxCollection( ){
         pvk_in_ = ();
        var _new = PxCollection_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
