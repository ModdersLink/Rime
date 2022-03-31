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
	[ContainerType(4, 80)]
	public class CharacterPhysicsData : 
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<CharacterPoseData> Poses { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<CharacterStateData> States { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public CharacterStateType DefaultState { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<CharacterSprintData> Sprint { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int PushableObjectWeight { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float Mass { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float MaxAscendAngle { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float PhysicalRadius { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float WaterDepthLimit { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float InputAcceleration { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float LadderAcceptAngle { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float LadderAcceptAnglePitch { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float JumpPenaltyTime { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float JumpPenaltyFactor { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float RadiusToPredictCollisionOnCharacters { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public bool AllowPoseChangeDuringTransition { get; set; }

	}
}
