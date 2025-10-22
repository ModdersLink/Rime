///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;


namespace fb.Physics;

[ContainerType(1, 4)]
public enum RigidBodyCollisionLayer : int
{
	RigidBodyCollisionLayer_Invalid = 0,
	RigidBodyCollisionLayer_StaticLayer = 1,
	RigidBodyCollisionLayer_DynamicLayer = 2,
	RigidBodyCollisionLayer_KeyframeLayer = 3,
	RigidBodyCollisionLayer_DebrisLayer = 4,
	RigidBodyCollisionLayer_FastDebrisLayer = 5,
	RigidBodyCollisionLayer_OnlyStaticCollisionLayer = 6,
	RigidBodyCollisionLayer_RagdollLayer = 7,
	RigidBodyCollisionLayer_NoCollisionLayer = 8,
	RigidBodyCollisionLayer_WaterLayer = 9,
	RigidBodyCollisionLayer_TerrainLayer = 10,
	RigidBodyCollisionLayer_OnlyTerrainCollionLayer = 11,
	RigidBodyCollisionLayer_CharacterCollisionGeometryLayer = 12,
	RigidBodyCollisionLayer_AiCollisionBodyLayer = 13,
	RigidBodyCollisionLayer_KeyframedCollisionBodyLayer = 14,
	RigidBodyCollisionLayer_CameraCollisionLayer = 15,
	RigidBodyCollisionLayer_VehicleLayer = 16,
	RigidBodyCollisionLayer_VehicleAndCharacterCollisionLayer = 17,
	RigidBodyCollisionLayer_Size = 18,
}

