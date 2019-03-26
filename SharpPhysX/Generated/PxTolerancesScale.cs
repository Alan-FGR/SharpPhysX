#if !NATIVE //C# includes
using System;
using System.Runtime.InteropServices;
#endif //C# includes



#if !NATIVE //interface
public unsafe interface IPxTolerancesScale {
    ///*No paramless ctor in C#*/ static PxTolerancesScale Default();
     bool isValid();
    // PxTolerancesScale(/*NULLPARS*/);
    // PxTolerancesScale(/*NULLPARS*/);
    // UNPARSED_TYPE ~PxTolerancesScale(/*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxTolerancesScale lhs, /*NULLPARS*/);
    //static UNPARSED_TYPE operator=(PxTolerancesScale lhs, /*NULLPARS*/);
    
}
#endif //interface

#if !NATIVE //struct start POD:False
public unsafe partial struct PxTolerancesScale : IPxTolerancesScale { // blittable
    public float length;
    public float speed;

#else
//Class is not POD so we're creating one to safely return the data from native
struct PxTolerancesScalePOD{
    physx::PxReal length;
    physx::PxReal speed;
};
#endif //struct start

    #if !NATIVE //hierarchy
    // Hierarchy: PxTolerancesScale
    #endif //hierarchy
    //================================================================================
    //#       PxTolerancesScale()                                                    #
    //================================================================================
    #if NATIVE //function start
    ES PxTolerancesScalePOD W_PxTolerancesScale_R_PxTolerancesScale_C_PxTolerancesScale_ctor(){
        auto val = PxTolerancesScale();
        return *(PxTolerancesScalePOD*)&val;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxTolerancesScale W_PxTolerancesScale_R_PxTolerancesScale_C_PxTolerancesScale_ctor();
    
    public /*No paramless ctor in C#*/ static PxTolerancesScale Default(){
        return (W_PxTolerancesScale_R_PxTolerancesScale_C_PxTolerancesScale_ctor());
    }
    #endif //function end
    
    
    //================================================================================
    //#       isValid()                                                              #
    //================================================================================
    #if NATIVE //function start
    ES bool W_isValid_R_bool_C_PxTolerancesScale(physx::PxTolerancesScale self){
        auto retVal = self.isValid();
        return retVal;
    }
    #else //end C wrapper, start C#
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_isValid_R_bool_C_PxTolerancesScale(PxTolerancesScale selfBlt);
    
    public  bool isValid(){
        bool retVal = W_isValid_R_bool_C_PxTolerancesScale(this);
        return retVal;
    }
    #endif //function end
    
    
    //Skipped generated implicit entry: PxTolerancesScale
    
    //Skipped generated implicit entry: PxTolerancesScale
    
    //Skipped generated implicit entry: ~PxTolerancesScale
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    

#if !NATIVE //struct close
}
#endif //struct close
