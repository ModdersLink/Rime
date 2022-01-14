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
	[ContainerType(16, 144)]
	public class BoneCollisionData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec4 DebugDrawColor { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 CapsuleOffset { get; set; } = new();
		
		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string BoneName { get; set; } = string.Empty;
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public HitReactionType AnimationHitReactionType { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int BoneAxis { get; set; }
		
		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float CapsuleLength { get; set; }
		
		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float CapsuleRadius { get; set; }
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public PitchModifier MinPitch { get; set; } = new();
		
		[ContainerField(96), JsonProperty(Order = 96)]
		public PitchModifier MaxPitch { get; set; } = new();
		
		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool ValidInHiLod { get; set; }
		
		[ContainerField(129), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
		public bool ValidInLowLod { get; set; }
		
		[ContainerField(130), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
		public bool UsePhysicsRotation { get; set; }
		
		[ContainerField(131), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
		public bool DeactivateIfBehindWall { get; set; }
		
	}
}
