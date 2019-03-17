#if !NATIVE
using System;
using System.Runtime.InteropServices;
#endif

#if !NATIVE
public enum PxPvdUpdateType : int {
    CREATE_INSTANCE = 0,       // CREATE_INSTANCE
    RELEASE_INSTANCE = 1,      // RELEASE_INSTANCE
    UPDATE_ALL_PROPERTIES = 2, // UPDATE_ALL_PROPERTIES
    UPDATE_SIM_PROPERTIES = 3, // UPDATE_SIM_PROPERTIES
}
#endif

#if !NATIVE
public enum Type : int {
    eSPRING = 1,              // eSPRING = 1<<0
    eACCELERATION_SPRING = 2, // eACCELERATION_SPRING = 1<<1
    eRESTITUTION = 4,         // eRESTITUTION = 1<<2
    eKEEPBIAS = 8,            // eKEEPBIAS = 1<<3
    eOUTPUT_FORCE = 16,       // eOUTPUT_FORCE = 1<<4
    eHAS_DRIVE_LIMIT = 32,    // eHAS_DRIVE_LIMIT = 1<<5
    eANGULAR_CONSTRAINT = 64, // eANGULAR_CONSTRAINT = 1 << 6
    eDRIVE_ROW = 128,         // eDRIVE_ROW = 1 << 7
}
#endif

#if !NATIVE
public enum PxConstraintSolveHint : int {
    eNONE = 0,                     // eNONE = 0
    eACCELERATION1 = 256,          // eACCELERATION1 = 256
    eSLERP_SPRING = 258,           // eSLERP_SPRING = 258
    eACCELERATION2 = 512,          // eACCELERATION2 = 512
    eACCELERATION3 = 768,          // eACCELERATION3 = 768
    eROTATIONAL_EQUALITY = 1024,   // eROTATIONAL_EQUALITY = 1024
    eROTATIONAL_INEQUALITY = 1025, // eROTATIONAL_INEQUALITY = 1025
    eEQUALITY = 2048,              // eEQUALITY = 2048
    eINEQUALITY = 2049,            // eINEQUALITY = 2049
}
#endif

#if !NATIVE
public enum PxConstraintVisualizationFlag : int {
    eLOCAL_FRAMES = 1, // eLOCAL_FRAMES = 1
    eLIMITS = 2,       // eLIMITS = 2
}
#endif

#if !NATIVE
public partial struct PxConstraintDesc {
#endif

//================================================================================
//#       operator|                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L85~85
#if NATIVE
ES UNPARSED_TYPE W_OP_Pipe(physx::Px1DConstraintFlag::Type a, physx::Px1DConstraintFlag::Type b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator|(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Pipe(Type a, Type b);

public static UNPARSED_TYPE operator|(Type a, Type b){
    Type pvk_in_a = (a);
    Type pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Pipe(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator&                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L85~85
#if NATIVE
ES UNPARSED_TYPE W_OP_Amp(physx::Px1DConstraintFlag::Type a, physx::Px1DConstraintFlag::Type b){
    auto nat_in_a = (a);
    auto nat_in_b = (b);
    auto retVal = physx::operator&(nat_in_a, nat_in_b);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Amp(Type a, Type b);

public static UNPARSED_TYPE operator&(Type a, Type b){
    Type pvk_in_a = (a);
    Type pvk_in_b = (b);
    UNPARSED_TYPE retVal = W_OP_Amp(pvk_in_a, pvk_in_b);
    return retVal;
}
#endif*/


//================================================================================
//#       operator~                                                              #
//================================================================================
/* ERRORS OCCURED: unhandled return type: physx::PxFlags<physx::Px1DConstraintFlag::Type, unsigned short>
// NATIVE SIG: 
// SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L85~85
#if NATIVE
ES UNPARSED_TYPE W_OP_Tilde(physx::Px1DConstraintFlag::Type a){
    auto nat_in_a = (a);
    auto retVal = physx::operator~(nat_in_a);
    return retVal;
}
#else
[DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
static extern UNPARSED_TYPE W_OP_Tilde(Type a);

public static UNPARSED_TYPE operator~(Type a){
    Type pvk_in_a = (a);
    UNPARSED_TYPE retVal = W_OP_Tilde(pvk_in_a);
    return retVal;
}
#endif*/

#if !NATIVE
} // End PxConstraintDesc
#endif


// Class physx::pvdsdk::PvdDataStream Manually Ignored
#if !NATIVE
public unsafe partial struct PxConstraintConnector { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       prepareData                                                            #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L359~359
    #if NATIVE
    ES void* W_prepareData(physx::PxConstraintConnector* self){
        auto retVal = self->prepareData();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_prepareData(PxConstraintConnector selfPtr);
    
    public IntPtr prepareData(){
        IntPtr retVal = W_prepareData(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       updatePvdProperties                                                    #
    //================================================================================
    /* ERRORS OCCURED: Forbidden parameter type: PvdDataStream
    // NATIVE SIG: bool					updatePvdProperties(physx::pvdsdk::PvdDataStream& pvdConnection,
    												const PxConstraint* c,
    												PxPvdUpdateType::Enum updateType) const		= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L364~366
    #if NATIVE
    ES bool W_updatePvdProperties(physx::PxConstraintConnector* self, physx::pvdsdk::PvdDataStream* pvdConnection, physx::PxConstraint* c, physx::PxPvdUpdateType::Enum updateType){
        auto nat_in_pvdConnection = (pvdConnection);
        auto nat_in_c = (c);
        auto nat_in_updateType = (updateType);
        auto retVal = self->updatePvdProperties(*nat_in_pvdConnection, nat_in_c, nat_in_updateType);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern bool W_updatePvdProperties(PxConstraintConnector selfPtr, PvdDataStream pvdConnection, PxConstraint c, PxPvdUpdateType updateType);
    
    public bool updatePvdProperties(PvdDataStream pvdConnection, PxConstraint c, PxPvdUpdateType updateType){
        PvdDataStream pvk_in_pvdConnection = (pvdConnection);
        PxConstraint pvk_in_c = (c);
        PxPvdUpdateType pvk_in_updateType = (updateType);
        bool retVal = W_updatePvdProperties(this, pvk_in_pvdConnection, pvk_in_c, pvk_in_updateType);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       onConstraintRelease                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L378~378
    #if NATIVE
    ES void W_onConstraintRelease(physx::PxConstraintConnector* self){
        self->onConstraintRelease();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_onConstraintRelease(PxConstraintConnector selfPtr);
    
    public void onConstraintRelease(){
        W_onConstraintRelease(this);
    }
    #endif
    
    
    //================================================================================
    //#       onComShift                                                             #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L386~386
    #if NATIVE
    ES void W_onComShift(physx::PxConstraintConnector* self, physx::PxU32 actor){
        auto nat_in_actor = (actor);
        self->onComShift(nat_in_actor);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_onComShift(PxConstraintConnector selfPtr, uint actor);
    
    public void onComShift(uint actor){
        uint pvk_in_actor = (actor);
        W_onComShift(this, pvk_in_actor);
    }
    #endif
    
    
    //================================================================================
    //#       onOriginShift                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L399~399
    #if NATIVE
    ES void W_onOriginShift(physx::PxConstraintConnector* self, physx::PxVec3 shift){
        auto nat_in_shift = (shift);
        self->onOriginShift(nat_in_shift);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_onOriginShift(PxConstraintConnector selfPtr, PxVec3 shift);
    
    public void onOriginShift(PxVec3 shift){
        PxVec3 pvk_in_shift = (shift);
        W_onOriginShift(this, pvk_in_shift);
    }
    #endif
    
    
    //================================================================================
    //#       getExternalReference                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L413~413
    #if NATIVE
    ES void* W_getExternalReference(physx::PxConstraintConnector* self, physx::PxU32& typeID){
        auto nat_in_typeID = (typeID);
        auto retVal = self->getExternalReference(nat_in_typeID);
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getExternalReference(PxConstraintConnector selfPtr, uint* typeID);
    
    public IntPtr getExternalReference(uint* typeID){
        uint* pvk_in_typeID = (typeID);
        IntPtr retVal = W_getExternalReference(this, pvk_in_typeID);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getSerializable                                                        #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L420~420
    #if NATIVE
    ES physx::PxBase* W_getSerializable(physx::PxConstraintConnector* self){
        auto retVal = self->getSerializable();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern PxBase W_getSerializable(PxConstraintConnector selfPtr);
    
    public PxBase getSerializable(){
        PxBase retVal = W_getSerializable(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       getPrep                                                                #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraintSolverPrep
    // NATIVE SIG: PxConstraintSolverPrep getPrep()	const										= 0
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L425~425
    #if NATIVE
    ES UNPARSED_TYPE W_getPrep(physx::PxConstraintConnector* self){
        auto retVal = self->getPrep();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_getPrep(PxConstraintConnector selfPtr);
    
    public UNPARSED_TYPE getPrep(){
        UNPARSED_TYPE retVal = W_getPrep(this);
        return retVal;
    }
    #endif*/
    
    
    //================================================================================
    //#       getConstantBlock                                                       #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L430~430
    #if NATIVE
    ES void* W_getConstantBlock(physx::PxConstraintConnector* self){
        auto retVal = self->getConstantBlock();
        return retVal;
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern IntPtr W_getConstantBlock(PxConstraintConnector selfPtr);
    
    public IntPtr getConstantBlock(){
        IntPtr retVal = W_getConstantBlock(this);
        return retVal;
    }
    #endif
    
    
    //================================================================================
    //#       ~PxConstraintConnector                                                 #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual							~PxConstraintConnector() {}
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L435~435
    #if NATIVE
    ES void W_~PxConstraintConnector(physx::PxConstraintConnector* self){
        self->~PxConstraintConnector();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConstraintConnector(PxConstraintConnector selfPtr);
    
    public void ~PxConstraintConnector(){
        W_~PxConstraintConnector(this);
    }
    #endif*/
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxConstraintConnector
    
    //Skipped generated implicit entry: PxConstraintConnector
    

#if !NATIVE
}
#endif

// Class physx::PxPvdUpdateType is enum namespace
// Class physx::Px1DConstraint Manually Ignored
// Union physx::Px1DConstraint TODO
#if !NATIVE
public unsafe partial struct SpringModifiers { // blittable
    public float stiffness;
    public float damping;

#endif

    //Skipped generated implicit entry: SpringModifiers
    
    //Skipped generated implicit entry: SpringModifiers
    
    //Skipped generated implicit entry: ~SpringModifiers
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: SpringModifiers
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct RestitutionModifiers { // blittable
    public float restitution;
    public float velocityThreshold;

#endif

    //Skipped generated implicit entry: RestitutionModifiers
    
    //Skipped generated implicit entry: RestitutionModifiers
    
    //Skipped generated implicit entry: ~RestitutionModifiers
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: RestitutionModifiers
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxConstraintInvMassScale { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       PxConstraintInvMassScale                                               #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::PxConstraintInvMassScale
    Parameterless constructor not allowed
    */
    
    
    //================================================================================
    //#       PxConstraintInvMassScale                                               #
    //================================================================================
    /* ERRORS OCCURED: unhandled return type: physx::PxConstraintInvMassScale
    // NATIVE SIG: PX_FORCE_INLINE PxConstraintInvMassScale(PxReal lin0, PxReal ang0, PxReal lin1, PxReal ang1) : linear0(lin0), angular0(ang0), linear1(lin1), angular1(ang1){}
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L204~204
    #if NATIVE
    ES UNPARSED_TYPE W_PxConstraintInvMassScale_ctor(physx::PxReal lin0, physx::PxReal ang0, physx::PxReal lin1, physx::PxReal ang1){
        auto nat_in_lin0 = (lin0);
        auto nat_in_ang0 = (ang0);
        auto nat_in_lin1 = (lin1);
        auto nat_in_ang1 = (ang1);
        self->PxConstraintInvMassScale(nat_in_lin0, nat_in_ang0, nat_in_lin1, nat_in_ang1);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern UNPARSED_TYPE W_PxConstraintInvMassScale_ctor(float lin0, float ang0, float lin1, float ang1);
    
    public PxConstraintInvMassScale(float lin0, float ang0, float lin1, float ang1){
        float pvk_in_lin0 = (lin0);
        float pvk_in_ang0 = (ang0);
        float pvk_in_lin1 = (lin1);
        float pvk_in_ang1 = (ang1);
        var _new = W_PxConstraintInvMassScale_ctor(pvk_in_lin0, pvk_in_ang0, pvk_in_lin1, pvk_in_ang1);
        fixed (void* ptr = &this)
            System.Buffer.MemoryCopy(&_new, ptr, Marshal.SizeOf(this), Marshal.SizeOf(this));
    }
    #endif*/
    
    
    //Skipped generated implicit entry: PxConstraintInvMassScale
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxConstraintInvMassScale
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~PxConstraintInvMassScale
    

#if !NATIVE
}
#endif

#if !NATIVE
public unsafe partial struct PxConstraintVisualizer { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       ~PxConstraintVisualizer                                                #
    //================================================================================
    /* ERRORS OCCURED: Destructor TODO
    // NATIVE SIG: virtual ~PxConstraintVisualizer(){}
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L260~260
    #if NATIVE
    ES void W_~PxConstraintVisualizer(physx::PxConstraintVisualizer* self){
        self->~PxConstraintVisualizer();
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_~PxConstraintVisualizer(PxConstraintVisualizer selfPtr);
    
    public void ~PxConstraintVisualizer(){
        W_~PxConstraintVisualizer(this);
    }
    #endif*/
    
    
    //================================================================================
    //#       visualizeJointFrames                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L267~267
    #if NATIVE
    ES void W_visualizeJointFrames(physx::PxConstraintVisualizer* self, physx::PxTransform parent, physx::PxTransform child){
        auto nat_in_parent = (parent);
        auto nat_in_child = (child);
        self->visualizeJointFrames(nat_in_parent, nat_in_child);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeJointFrames(PxConstraintVisualizer selfPtr, PxTransform parent, PxTransform child);
    
    public void visualizeJointFrames(PxTransform parent, PxTransform child){
        PxTransform pvk_in_parent = (parent);
        PxTransform pvk_in_child = (child);
        W_visualizeJointFrames(this, pvk_in_parent, pvk_in_child);
    }
    #endif
    
    
    //================================================================================
    //#       visualizeLinearLimit                                                   #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L276~276
    #if NATIVE
    ES void W_visualizeLinearLimit(physx::PxConstraintVisualizer* self, physx::PxTransform t0, physx::PxTransform t1, physx::PxReal value, bool active){
        auto nat_in_t0 = (t0);
        auto nat_in_t1 = (t1);
        auto nat_in_value = (value);
        auto nat_in_active = (active);
        self->visualizeLinearLimit(nat_in_t0, nat_in_t1, nat_in_value, nat_in_active);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeLinearLimit(PxConstraintVisualizer selfPtr, PxTransform t0, PxTransform t1, float value, bool active);
    
    public void visualizeLinearLimit(PxTransform t0, PxTransform t1, float value, bool active){
        PxTransform pvk_in_t0 = (t0);
        PxTransform pvk_in_t1 = (t1);
        float pvk_in_value = (value);
        bool pvk_in_active = (active);
        W_visualizeLinearLimit(this, pvk_in_t0, pvk_in_t1, pvk_in_value, pvk_in_active);
    }
    #endif
    
    
    //================================================================================
    //#       visualizeAngularLimit                                                  #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L285~285
    #if NATIVE
    ES void W_visualizeAngularLimit(physx::PxConstraintVisualizer* self, physx::PxTransform t0, physx::PxReal lower, physx::PxReal upper, bool active){
        auto nat_in_t0 = (t0);
        auto nat_in_lower = (lower);
        auto nat_in_upper = (upper);
        auto nat_in_active = (active);
        self->visualizeAngularLimit(nat_in_t0, nat_in_lower, nat_in_upper, nat_in_active);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeAngularLimit(PxConstraintVisualizer selfPtr, PxTransform t0, float lower, float upper, bool active);
    
    public void visualizeAngularLimit(PxTransform t0, float lower, float upper, bool active){
        PxTransform pvk_in_t0 = (t0);
        float pvk_in_lower = (lower);
        float pvk_in_upper = (upper);
        bool pvk_in_active = (active);
        W_visualizeAngularLimit(this, pvk_in_t0, pvk_in_lower, pvk_in_upper, pvk_in_active);
    }
    #endif
    
    
    //================================================================================
    //#       visualizeLimitCone                                                     #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L294~294
    #if NATIVE
    ES void W_visualizeLimitCone(physx::PxConstraintVisualizer* self, physx::PxTransform t, physx::PxReal tanQSwingY, physx::PxReal tanQSwingZ, bool active){
        auto nat_in_t = (t);
        auto nat_in_tanQSwingY = (tanQSwingY);
        auto nat_in_tanQSwingZ = (tanQSwingZ);
        auto nat_in_active = (active);
        self->visualizeLimitCone(nat_in_t, nat_in_tanQSwingY, nat_in_tanQSwingZ, nat_in_active);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeLimitCone(PxConstraintVisualizer selfPtr, PxTransform t, float tanQSwingY, float tanQSwingZ, bool active);
    
    public void visualizeLimitCone(PxTransform t, float tanQSwingY, float tanQSwingZ, bool active){
        PxTransform pvk_in_t = (t);
        float pvk_in_tanQSwingY = (tanQSwingY);
        float pvk_in_tanQSwingZ = (tanQSwingZ);
        bool pvk_in_active = (active);
        W_visualizeLimitCone(this, pvk_in_t, pvk_in_tanQSwingY, pvk_in_tanQSwingZ, pvk_in_active);
    }
    #endif
    
    
    //================================================================================
    //#       visualizeDoubleCone                                                    #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L302~302
    #if NATIVE
    ES void W_visualizeDoubleCone(physx::PxConstraintVisualizer* self, physx::PxTransform t, physx::PxReal angle, bool active){
        auto nat_in_t = (t);
        auto nat_in_angle = (angle);
        auto nat_in_active = (active);
        self->visualizeDoubleCone(nat_in_t, nat_in_angle, nat_in_active);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeDoubleCone(PxConstraintVisualizer selfPtr, PxTransform t, float angle, bool active);
    
    public void visualizeDoubleCone(PxTransform t, float angle, bool active){
        PxTransform pvk_in_t = (t);
        float pvk_in_angle = (angle);
        bool pvk_in_active = (active);
        W_visualizeDoubleCone(this, pvk_in_t, pvk_in_angle, pvk_in_active);
    }
    #endif
    
    
    //================================================================================
    //#       visualizeLine                                                          #
    //================================================================================
    // SOURCE: C:\Projects\PhysX\physx\include\PxConstraintDesc.h L310~310
    #if NATIVE
    ES void W_visualizeLine(physx::PxConstraintVisualizer* self, physx::PxVec3 p0, physx::PxVec3 p1, physx::PxU32 color){
        auto nat_in_p0 = (p0);
        auto nat_in_p1 = (p1);
        auto nat_in_color = (color);
        self->visualizeLine(nat_in_p0, nat_in_p1, nat_in_color);
    }
    #else
    [DllImport(PhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    static extern void W_visualizeLine(PxConstraintVisualizer selfPtr, PxVec3 p0, PxVec3 p1, uint color);
    
    public void visualizeLine(PxVec3 p0, PxVec3 p1, uint color){
        PxVec3 pvk_in_p0 = (p0);
        PxVec3 pvk_in_p1 = (p1);
        uint pvk_in_color = (color);
        W_visualizeLine(this, pvk_in_p0, pvk_in_p1, pvk_in_color);
    }
    #endif
    
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: PxConstraintVisualizer
    
    //Skipped generated implicit entry: PxConstraintVisualizer
    

#if !NATIVE
}
#endif

// Class physx::PxRenderBuffer Manually Ignored
#if !NATIVE
public unsafe partial struct Px1DConstraintFlag { // pointer
    private IntPtr nativePtr_;
#endif

    //================================================================================
    //#       Px1DConstraintFlag                                                     #
    //================================================================================
    //Skipped invalid managed declaration:
    /*unhandled return type: physx::Px1DConstraintFlag
    Parameterless constructor not allowed
    */
    
    
    //Skipped generated implicit entry: Px1DConstraintFlag
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: Px1DConstraintFlag
    
    //Skipped generated implicit entry: operator=
    
    //Skipped generated implicit entry: ~Px1DConstraintFlag
    

#if !NATIVE
}
#endif

// Class physx::PxConstraintSolveHint is enum namespace
// Class physx::PxConstraintVisualizationFlag is enum namespace