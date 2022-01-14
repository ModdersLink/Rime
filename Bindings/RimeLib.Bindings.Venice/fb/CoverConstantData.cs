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
	[ContainerType(4, 140)]
	public class CoverConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float SlotSize { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float SlotSpacing { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float SlotEdgeDistance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float SlotBlockedEdgeDistance { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MinimumOpenCoverWidth { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float ProneHeight { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float CrouchHeight { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float MediumHeight { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float StandHeight { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public int MaxCoversInMemory { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float SearchRadius { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float ProneCoverModifier { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float CrouchCoverModifier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float MediumCoverModifier { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float StandCoverModifier { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float IntermediateCoverSlotModifier { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float DistanceEvaluationWeight { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float EnemiesEvaluationWeight { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float AttackPositionEvaluationWeight { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float OptimalWeaponDistanceEvaluationWeight { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float DislikePreviousCoverWeight { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float MaxHeightDifference { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public float SwitchCoverUrgencyThreshold { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float ExtraCoverSize { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float ReevaluationTime { get; set; }

		[ContainerField(112), JsonProperty(Order = 112)]
		public CoverSelectionMethod CoverSelectionMethod { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float ThreatRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float InCoverDistance { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float MinAttackableEnemyDistance { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float CoverFailIgnoreTime { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float StartMeleeFromCoverDistance { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float ContinueMeleeFromCoverDistance { get; set; }

	}
}
