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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 140)]
	public partial class CoverConstantData :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _SlotSize;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _SlotSpacing;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _SlotEdgeDistance;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _SlotBlockedEdgeDistance;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _MinimumOpenCoverWidth;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _ProneHeight;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _CrouchHeight;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _MediumHeight;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _StandHeight;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private int _MaxCoversInMemory;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _SearchRadius;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _ProneCoverModifier;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _CrouchCoverModifier;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _MediumCoverModifier;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _StandCoverModifier;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _IntermediateCoverSlotModifier;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _DistanceEvaluationWeight;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _EnemiesEvaluationWeight;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _AttackPositionEvaluationWeight;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _OptimalWeaponDistanceEvaluationWeight;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _DislikePreviousCoverWeight;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _MaxHeightDifference;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private float _SwitchCoverUrgencyThreshold;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _ExtraCoverSize;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _ReevaluationTime;

		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private CoverSelectionMethod _CoverSelectionMethod = new();

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _ThreatRadius;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _InCoverDistance;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _MinAttackableEnemyDistance;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _CoverFailIgnoreTime;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _StartMeleeFromCoverDistance;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _ContinueMeleeFromCoverDistance;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SlotSize);
			p_Writer.Write(SlotSpacing);
			p_Writer.Write(SlotEdgeDistance);
			p_Writer.Write(SlotBlockedEdgeDistance);
			p_Writer.Write(MinimumOpenCoverWidth);
			p_Writer.Write(ProneHeight);
			p_Writer.Write(CrouchHeight);
			p_Writer.Write(MediumHeight);
			p_Writer.Write(StandHeight);
			p_Writer.Write(MaxCoversInMemory);
			p_Writer.Write(SearchRadius);
			p_Writer.Write(ProneCoverModifier);
			p_Writer.Write(CrouchCoverModifier);
			p_Writer.Write(MediumCoverModifier);
			p_Writer.Write(StandCoverModifier);
			p_Writer.Write(IntermediateCoverSlotModifier);
			p_Writer.Write(DistanceEvaluationWeight);
			p_Writer.Write(EnemiesEvaluationWeight);
			p_Writer.Write(AttackPositionEvaluationWeight);
			p_Writer.Write(OptimalWeaponDistanceEvaluationWeight);
			p_Writer.Write(DislikePreviousCoverWeight);
			p_Writer.Write(MaxHeightDifference);
			p_Writer.Write(SwitchCoverUrgencyThreshold);
			p_Writer.Write(ExtraCoverSize);
			p_Writer.Write(ReevaluationTime);
			p_Writer.Write((int) CoverSelectionMethod);
			p_Writer.Write(ThreatRadius);
			p_Writer.Write(InCoverDistance);
			p_Writer.Write(MinAttackableEnemyDistance);
			p_Writer.Write(CoverFailIgnoreTime);
			p_Writer.Write(StartMeleeFromCoverDistance);
			p_Writer.Write(ContinueMeleeFromCoverDistance);
		}
	}
}
