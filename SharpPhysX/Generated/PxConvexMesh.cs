#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif



// Class physx::PxConvexMesh Manually Ignored
#if !NATIVE
public unsafe interface IPxHullPolygon {
    // PxHullPolygon(/*NULLPARS*/);
    // PxHullPolygon(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxHullPolygon lhs, /*NULLPARS*/);
    // PxHullPolygon(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxHullPolygon lhs, /*NULLPARS*/);
    // UNPARSED_TYPE ~PxHullPolygon(/*NULLPARS*/);
    
}

public unsafe partial struct PxHullPolygon : IPxHullPolygon { // blittable
    public float[] mPlane;
    public ushort mNbVerts;
    public ushort mIndexBase;

#endif

    // Hierarchy: PxHullPolygon
    //Skipped generated implicit entry: PxHullPolygon
    
    //Skipped generated implicit entry: PxHullPolygon
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxHullPolygon
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxHullPolygon
    

#if !NATIVE
}
#endif
