#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif


public partial struct PxCollection {

//================================================================================
//#       PxCreateCollection                                                     #
//================================================================================
// SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L275~275
#if NATIVE
ES physx::PxCollection* W_PxCreateCollection(){
    auto retVal = PxCreateCollection();
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern PxCollection W_PxCreateCollection();

public static PxCollection PxCreateCollection(){
    PxCollection retVal = W_PxCreateCollection();
    return retVal;
}
#endif

} // End PxCollection


#if !NATIVE
public unsafe partial struct PxCollection { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       add                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L122~122
    #if NATIVE
    ES void W_add(physx::PxCollection* self, physx::PxBase* object, physx::PxSerialObjectId id){
        auto nat_in_object = (object);
        auto nat_in_id = (id);
        self->add(*nat_in_object, nat_in_id);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_add(PxCollection selfPtr, PxBase object, ulong id);
    
    public void add(PxBase object, ulong id){
        PxBase pvk_in_object = (object);
        ulong pvk_in_id = (id);
        W_add(this, pvk_in_object, pvk_in_id);
    }
    #endif
    
    
    //================================================================================
    //#       remove                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L131~131
    #if NATIVE
    ES void W_remove(physx::PxCollection* self, physx::PxBase* object){
        auto nat_in_object = (object);
        self->remove(*nat_in_object);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_remove(PxCollection selfPtr, PxBase object);
    
    public void remove(PxBase object){
        PxBase pvk_in_object = (object);
        W_remove(this, pvk_in_object);
    }
    #endif
    
    
    //================================================================================
    //#       contains                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L139~139
    #if NATIVE
    ES bool W_contains(physx::PxCollection* self, physx::PxBase* object){
        auto nat_in_object = (object);
        auto retVal = self->contains(*nat_in_object);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_contains(PxCollection selfPtr, PxBase object);
    
    public bool contains(PxBase object){
        PxBase pvk_in_object = (object);
        bool retVal = W_contains(this, pvk_in_object);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       addId                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L151~151
    #if NATIVE
    ES void W_addId(physx::PxCollection* self, physx::PxBase* object, physx::PxSerialObjectId id){
        auto nat_in_object = (object);
        auto nat_in_id = (id);
        self->addId(*nat_in_object, nat_in_id);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_addId(PxCollection selfPtr, PxBase object, ulong id);
    
    public void addId(PxBase object, ulong id){
        PxBase pvk_in_object = (object);
        ulong pvk_in_id = (id);
        W_addId(this, pvk_in_object, pvk_in_id);
    }
    #endif
    
    
    //================================================================================
    //#       removeId                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L160~160
    #if NATIVE
    ES void W_removeId(physx::PxCollection* self, physx::PxSerialObjectId id){
        auto nat_in_id = (id);
        self->removeId(nat_in_id);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_removeId(PxCollection selfPtr, ulong id);
    
    public void removeId(ulong id){
        ulong pvk_in_id = (id);
        W_removeId(this, pvk_in_id);
    }
    #endif
    
    
    //================================================================================
    //#       add                                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L170~170
    #if NATIVE
    ES void W_add(physx::PxCollection* self, physx::PxCollection* collection){
        auto nat_in_collection = (collection);
        self->add(*nat_in_collection);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_add(PxCollection selfPtr, PxCollection collection);
    
    public void add(PxCollection collection){
        PxCollection pvk_in_collection = (collection);
        W_add(this, pvk_in_collection);
    }
    #endif
    
    
    //================================================================================
    //#       remove                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L180~180
    #if NATIVE
    ES void W_remove(physx::PxCollection* self, physx::PxCollection* collection){
        auto nat_in_collection = (collection);
        self->remove(*nat_in_collection);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_remove(PxCollection selfPtr, PxCollection collection);
    
    public void remove(PxCollection collection){
        PxCollection pvk_in_collection = (collection);
        W_remove(this, pvk_in_collection);
    }
    #endif
    
    
    //================================================================================
    //#       getNbObjects                                                           #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L187~187
    #if NATIVE
    ES physx::PxU32 W_getNbObjects(physx::PxCollection* self){
        auto retVal = self->getNbObjects();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbObjects(PxCollection selfPtr);
    
    public uint getNbObjects(){
        uint retVal = W_getNbObjects(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getObject                                                              #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L195~195
    #if NATIVE
    ES physx::PxBase* W_getObject(physx::PxCollection* self, physx::PxU32 index){
        auto nat_in_index = (index);
        auto retVal = &self->getObject(nat_in_index);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBase W_getObject(PxCollection selfPtr, uint index);
    
    public PxBase getObject(uint index){
        uint pvk_in_index = (index);
        PxBase retVal = W_getObject(this, pvk_in_index);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getObjects                                                             #
    //================================================================================
    /* ERRORS OCCURED: Unresolved parameter pointee physx::PxBase*
    // NATIVE SIG: PxU32						getObjects(PxBase** userBuffer, PxU32 bufferSize, PxU32 startIndex=0) const = 0
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L205~205
    #if NATIVE
    ES physx::PxU32 W_getObjects(physx::PxCollection* self,  userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getObjects(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getObjects(PxCollection selfPtr,  userBuffer, uint bufferSize, uint startIndex);
    
    public uint getObjects( userBuffer, uint bufferSize, uint startIndex){
         pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getObjects(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       find                                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L215~215
    #if NATIVE
    ES physx::PxBase* W_find(physx::PxCollection* self, physx::PxSerialObjectId id){
        auto nat_in_id = (id);
        auto retVal = self->find(nat_in_id);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBase W_find(PxCollection selfPtr, ulong id);
    
    public PxBase find(ulong id){
        ulong pvk_in_id = (id);
        PxBase retVal = W_find(this, pvk_in_id);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getNbIds                                                               #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L222~222
    #if NATIVE
    ES physx::PxU32 W_getNbIds(physx::PxCollection* self){
        auto retVal = self->getNbIds();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getNbIds(PxCollection selfPtr);
    
    public uint getNbIds(){
        uint retVal = W_getNbIds(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getIds                                                                 #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L232~232
    #if NATIVE
    ES physx::PxU32 W_getIds(physx::PxCollection* self, physx::PxSerialObjectId* userBuffer, physx::PxU32 bufferSize, physx::PxU32 startIndex){
        auto nat_in_userBuffer = (userBuffer);
        auto nat_in_bufferSize = (bufferSize);
        auto nat_in_startIndex = (startIndex);
        auto retVal = self->getIds(nat_in_userBuffer, nat_in_bufferSize, nat_in_startIndex);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern uint W_getIds(PxCollection selfPtr, ulong* userBuffer, uint bufferSize, uint startIndex);
    
    public uint getIds(ulong* userBuffer, uint bufferSize, uint startIndex){
        ulong* pvk_in_userBuffer = (userBuffer);
        uint pvk_in_bufferSize = (bufferSize);
        uint pvk_in_startIndex = (startIndex);
        uint retVal = W_getIds(this, pvk_in_userBuffer, pvk_in_bufferSize, pvk_in_startIndex);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getId                                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L242~242
    #if NATIVE
    ES physx::PxSerialObjectId W_getId(physx::PxCollection* self, physx::PxBase* object){
        auto nat_in_object = (object);
        auto retVal = self->getId(*nat_in_object);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern ulong W_getId(PxCollection selfPtr, PxBase object);
    
    public ulong getId(PxBase object){
        PxBase pvk_in_object = (object);
        ulong retVal = W_getId(this, pvk_in_object);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       release                                                                #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L253~253
    #if NATIVE
    ES void W_release(physx::PxCollection* self){
        self->release();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_release(PxCollection selfPtr);
    
    public void release(){
        W_release(this);
    }
    #endif
    
    
    //================================================================================
    //#       PxCollection                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Parameterless constructor not allowed
    // NATIVE SIG: PxCollection()	{}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L256~256
    #if NATIVE
    ES UNPARSED_TYPE W_PxCollection_ctor(){
        self->PxCollection();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxCollection_ctor();
    
    public PxCollection(){
        var _new = W_PxCollection_ctor();
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //================================================================================
    //#       ~PxCollection                                                          #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual								~PxCollection()	{}
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L257~257
    #if NATIVE
    ES void W_~PxCollection(physx::PxCollection* self){
        self->~PxCollection();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxCollection(PxCollection selfPtr);
    
    public void ~PxCollection(){
        W_~PxCollection(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       operator=                                                              #
    //================================================================================
    /* ERRORS OCCURED: Ops TODO
    Invalid parameter name (empty)
    // NATIVE SIG: PxCollection
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L105~105
    #if NATIVE
    ES physx::PxCollection* W_operator=(physx::PxCollection* self, physx::PxCollection* ){
        auto nat_in_ = ();
        auto retVal = &self->operator=(*nat_in_);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxCollection W_operator=(PxCollection selfPtr, PxCollection );
    
    public static PxCollection operator=(PxCollection lhs, PxCollection ){
        PxCollection pvk_in_ = ();
        PxCollection retVal = W_operator=(lhs, pvk_in_);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       PxCollection                                                           #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type
    Invalid parameter name (empty)
    // NATIVE SIG: PxCollection
    // SOURCE: C:\Projects\PhysX\physx\include\common\PxCollection.h L105~105
    #if NATIVE
    ES UNPARSED_TYPE W_PxCollection_ctor(physx::PxCollection* ){
        auto nat_in_ = ();
        self->PxCollection(*nat_in_);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxCollection_ctor(PxCollection );
    
    public PxCollection(PxCollection ){
        PxCollection pvk_in_ = ();
        var _new = W_PxCollection_ctor(pvk_in_);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    

#if !NATIVE
}
#endif
