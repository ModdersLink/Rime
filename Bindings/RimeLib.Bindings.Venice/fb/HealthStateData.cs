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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 36)]
	public class HealthStateData : 
		DataContainer
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public RefArray<GameObjectData> Objects { get; set; } = new();

		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<NetworkableLoosePartPhysicsData> LoosePartPhysics { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public CtrRef<ObjectBlueprint> SpawnedBangerBlueprint { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CtrRef<BangerSpawnImpulseParams> SpawnedBangerImpulseParams { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float Health { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint PartIndex { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool PhysicsEnabled { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable, JsonProperty(Order = 33)]
		public bool CopyDamageToBanger { get; set; }

		[ContainerField(34), LayoutImmutable, Blittable, JsonProperty(Order = 34)]
		public bool CanSupportOtherParts { get; set; }

	}
}
