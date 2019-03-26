#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



// Class physx::PxConvexMesh Manually Ignored
#if !NATIVE //interface
public unsafe interface IPxHullPolygon {
    // PxHullPolygon(/*NULLPARS*/);
    // PxHullPolygon(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxHullPolygon lhs, /*NULLPARS*/);
    // PxHullPolygon(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxHullPolygon lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxHullPolygon(/*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:True
public unsafe partial struct PxHullPolygon : IPxHullPolygon { // blittable
    public float[] mPlane;
    public ushort mNbVerts;
    public ushort mIndexBase;

#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxHullPolygon
    #endif //hierarchy
    //Skipped generated implicit entry: PxHullPolygon
    
    //Skipped generated implicit entry: PxHullPolygon
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxHullPolygon
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxHullPolygon
    

#if !NATIVE //struct close
}
#endif //struct close
