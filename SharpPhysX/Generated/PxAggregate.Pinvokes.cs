// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
public static unsafe partial class minBND_pinvokes {

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern void void_PxAggregatePtr_releasePtr(physx.PxAggregatePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxAggregatePtr_removeActorPtr_PxActorPtr_(physx.PxAggregatePtr pvk_this, physx.PxActorPtr pvk_actor);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxAggregatePtr_addArticulationPtr_PxArticulationBasePtr_(physx.PxAggregatePtr pvk_this, physx.PxArticulationBasePtr pvk_articulation);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxAggregatePtr_removeArticulationPtr_PxArticulationBasePtr_(physx.PxAggregatePtr pvk_this, physx.PxArticulationBasePtr pvk_articulation);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxAggregatePtr_getNbActorsPtr(physx.PxAggregatePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxAggregatePtr_getMaxNbActorsPtr(physx.PxAggregatePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxAggregatePtr_getActorsPtr_PxActorPtr_uint_uint_(physx.PxAggregatePtr pvk_this, physx.PxActorPtr* pvk_userBuffer, uint pvk_bufferSize, uint pvk_startIndex);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern physx.PxScenePtr PxScenePtr_PxAggregatePtr_getScenePtr(physx.PxAggregatePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_const_PxAggregatePtr_getSelfCollisionPtr(physx.PxAggregatePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern string string_const_PxAggregatePtr_getConcreteTypeNamePtr(physx.PxAggregatePtr pvk_this);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern bool bool_PxAggregatePtr_addActorPtr_PxActorPtr_(physx.PxAggregatePtr pvk_this, physx.PxActorPtr pvk_actor);

[DllImport(SharpPhysX.Lib, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
internal static extern uint uint_const_PxAggregatePtr_getActorsPtr_PxActorPtr_uint_(physx.PxAggregatePtr pvk_this, physx.PxActorPtr* pvk_userBuffer, uint pvk_bufferSize);
}