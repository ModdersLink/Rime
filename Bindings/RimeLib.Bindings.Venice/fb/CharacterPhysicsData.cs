///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
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
		[ContainerField(12)]
		public RefArray<CharacterPoseData> Poses { get; set; } = new();

		[ContainerField(16)]
		public RefArray<CharacterStateData> States { get; set; } = new();

		[ContainerField(20)]
		public CharacterStateType DefaultState { get; set; } = new();

		[ContainerField(24)]
		public CtrRef<CharacterSprintData> Sprint { get; set; } = new();

		[ContainerField(28)]
		public CtrRef<MaterialContainerPair> MaterialPair { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public int PushableObjectWeight { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float Mass { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxAscendAngle { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float PhysicalRadius { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float WaterDepthLimit { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float InputAcceleration { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float LadderAcceptAngle { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float LadderAcceptAnglePitch { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float JumpPenaltyTime { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float JumpPenaltyFactor { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float RadiusToPredictCollisionOnCharacters { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool AllowPoseChangeDuringTransition { get; set; }

	}
}
