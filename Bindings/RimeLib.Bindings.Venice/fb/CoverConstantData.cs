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
	[ContainerType(4, 140)]
	public class CoverConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SlotSize { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float SlotSpacing { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float SlotEdgeDistance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float SlotBlockedEdgeDistance { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MinimumOpenCoverWidth { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ProneHeight { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float CrouchHeight { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MediumHeight { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float StandHeight { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public int MaxCoversInMemory { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float SearchRadius { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float ProneCoverModifier { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float CrouchCoverModifier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float MediumCoverModifier { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float StandCoverModifier { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float IntermediateCoverSlotModifier { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float DistanceEvaluationWeight { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float EnemiesEvaluationWeight { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float AttackPositionEvaluationWeight { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float OptimalWeaponDistanceEvaluationWeight { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float DislikePreviousCoverWeight { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxHeightDifference { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float SwitchCoverUrgencyThreshold { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ExtraCoverSize { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float ReevaluationTime { get; set; }

		[ContainerField(112)]
		public CoverSelectionMethod CoverSelectionMethod { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float ThreatRadius { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float InCoverDistance { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MinAttackableEnemyDistance { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float CoverFailIgnoreTime { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float StartMeleeFromCoverDistance { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float ContinueMeleeFromCoverDistance { get; set; }

	}
}
