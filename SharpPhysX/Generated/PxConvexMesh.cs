//Generated by MinBinder.
using System;
using System.Runtime.InteropServices;

public partial class PxConvexMesh {
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxU32 C_CONST_PxConvexMesh_getNbVertices(PxConvexMesh cls);
    public PxU32 getNbVertices(){
        return C_CONST_PxConvexMesh_getNbVertices(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxVec3 C_CONST_PxConvexMesh_getVertices(PxConvexMesh cls);
    public PxVec3 getVertices(){
        return C_CONST_PxConvexMesh_getVertices(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern byte C_CONST_PxConvexMesh_getIndexBuffer(PxConvexMesh cls);
    public byte getIndexBuffer(){
        return C_CONST_PxConvexMesh_getIndexBuffer(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxU32 C_CONST_PxConvexMesh_getNbPolygons(PxConvexMesh cls);
    public PxU32 getNbPolygons(){
        return C_CONST_PxConvexMesh_getNbPolygons(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool C_CONST_PxConvexMesh_getPolygonData(PxConvexMesh cls,PxU32 index,PxHullPolygonPtr data);
    public bool getPolygonData(PxU32 index,PxHullPolygonPtr data){
        return C_CONST_PxConvexMesh_getPolygonData(this,index,data);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_PxConvexMesh_release(PxConvexMesh cls);
    public void release(){
        return C_PxConvexMesh_release(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxU32 C_CONST_PxConvexMesh_getReferenceCount(PxConvexMesh cls);
    public PxU32 getReferenceCount(){
        return C_CONST_PxConvexMesh_getReferenceCount(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_PxConvexMesh_acquireReference(PxConvexMesh cls);
    public void acquireReference(){
        return C_PxConvexMesh_acquireReference(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void C_CONST_PxConvexMesh_getMassInformation(PxConvexMesh cls,float mass,PxMat33Ptr localInertia,PxVec3 localCenterOfMass);
    public void getMassInformation(float mass,PxMat33Ptr localInertia,PxVec3 localCenterOfMass){
        return C_CONST_PxConvexMesh_getMassInformation(this,mass,localInertia,localCenterOfMass);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBounds3 C_CONST_PxConvexMesh_getLocalBounds(PxConvexMesh cls);
    public PxBounds3 getLocalBounds(){
        return C_CONST_PxConvexMesh_getLocalBounds(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern string C_CONST_PxConvexMesh_getConcreteTypeName(PxConvexMesh cls);
    public string getConcreteTypeName(){
        return C_CONST_PxConvexMesh_getConcreteTypeName(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool C_CONST_PxConvexMesh_isGpuCompatible(PxConvexMesh cls);
    public bool isGpuCompatible(){
        return C_CONST_PxConvexMesh_isGpuCompatible(this);    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMesh C_PxConvexMesh_PxConvexMesh(PxType concreteType,PxBaseFlags baseFlags);
    public unsafe PxConvexMesh(PxType concreteType,PxBaseFlags baseFlags){
        var _new = C_PxConvexMesh_PxConvexMesh(concreteType,baseFlags);        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxConvexMesh C_PxConvexMesh_PxConvexMesh(PxBaseFlags baseFlags);
    public unsafe PxConvexMesh(PxBaseFlags baseFlags){
        var _new = C_PxConvexMesh_PxConvexMesh(baseFlags);        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }

    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool C_CONST_PxConvexMesh_isKindOf(PxConvexMesh cls,string name);
    public bool isKindOf(string name){
        return C_CONST_PxConvexMesh_isKindOf(this,name);    
    }


}
public partial class PxHullPolygon {
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxHullPolygon C_PxHullPolygon_PxHullPolygon();
    public unsafe PxHullPolygon(){
        var _new = C_PxHullPolygon_PxHullPolygon();        fixed (void* ptr = &this)
          Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));    
    }


}
