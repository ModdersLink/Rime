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
	[ContainerType(16, 48)]
	public class BulletHitInfo
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec3 Direction { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 SpawnPosition { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public CtrRef<SoldierWeaponUnlockAsset> WeaponUnlockAsset { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntHitReactionWeaponType WeaponType { get; set; } = new();
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public int BoneType { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int ShooterPlayerId { get; set; }
		
	}
}
