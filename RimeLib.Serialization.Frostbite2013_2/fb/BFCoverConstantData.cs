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

using fb.Core;

namespace fb.BFAI2Data;

[ContainerType(8, 272)]
public class BFCoverConstantData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float SlotSize { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float SlotSpacing { get; set; } = 1.500f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float SlotEdgeDistance { get; set; } = 0.300f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float SlotBlockedEdgeDistance { get; set; } = 0.300f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float MinimumOpenCoverWidth { get; set; } = 0.700f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float ProneAllowFireHeight { get; set; } = 0.200f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float OpenAllowFireHeight { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float CrouchHeight { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float CrouchAllowFireHeight { get; set; } = 1.100f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MediumHeight { get; set; } = 1.100f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float MediumAllowFireHeight { get; set; } = 1.240f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float StandHeight { get; set; } = 1.750f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float FireHeightProne { get; set; } = 0.300f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float FireHeightOpen { get; set; } = 0.600f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float FireHeightCrouch { get; set; } = 0.600f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float FireHeightMedium { get; set; } = 1.300f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float FireHeightStanding { get; set; } = 1.700f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float MinFreeShootDist { get; set; } = 3.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public int MaxCoversInMemory { get; set; } = 1000;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float SearchRadius { get; set; } = 15.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float ProneCoverModifier { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float CrouchCoverModifier { get; set; } = 1.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float MediumCoverModifier { get; set; } = 1.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float StandCoverModifier { get; set; } = 1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float IntermediateCoverSlotModifier { get; set; } = 1.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float DistanceEvaluationWeight { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float EnemiesEvaluationWeight { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float AttackPositionEvaluationWeight { get; set; } = 1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float OptimalWeaponDistanceEvaluationWeight { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float DislikePreviousCoverWeight { get; set; } = 0.990f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float MaxHeightDifference { get; set; } = 2.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float SwitchCoverUrgencyThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float ExtraCoverSize { get; set; } = 0.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float ReevaluationTime { get; set; } = 1.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public BFCoverSelectionMethod BFCoverSelectionMethod { get; set; } = fb.BFAI2Data.BFCoverSelectionMethod.CSMAgainstThreatPosition;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float ThreatRadius { get; set; } = 50.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float InCoverDistance { get; set; } = 0.500f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float MinAttackableEnemyDistance { get; set; } = 5.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float CoverFailIgnoreTime { get; set; } = 10.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float StartMeleeFromCoverDistance { get; set; } = 3.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float ContinueMeleeFromCoverDistance { get; set; } = 6.000f;
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public BFCoverZones EnemyCoverZones { get; set; } = new();
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public BFCoverZones FriendlyCoverZones { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SlotSize);
		p_Writer.Write(SlotSpacing);
		p_Writer.Write(SlotEdgeDistance);
		p_Writer.Write(SlotBlockedEdgeDistance);
		p_Writer.Write(MinimumOpenCoverWidth);
		p_Writer.Write(ProneAllowFireHeight);
		p_Writer.Write(OpenAllowFireHeight);
		p_Writer.Write(CrouchHeight);
		p_Writer.Write(CrouchAllowFireHeight);
		p_Writer.Write(MediumHeight);
		p_Writer.Write(MediumAllowFireHeight);
		p_Writer.Write(StandHeight);
		p_Writer.Write(FireHeightProne);
		p_Writer.Write(FireHeightOpen);
		p_Writer.Write(FireHeightCrouch);
		p_Writer.Write(FireHeightMedium);
		p_Writer.Write(FireHeightStanding);
		p_Writer.Write(MinFreeShootDist);
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
		p_Writer.Write((int) BFCoverSelectionMethod);
		p_Writer.Write(ThreatRadius);
		p_Writer.Write(InCoverDistance);
		p_Writer.Write(MinAttackableEnemyDistance);
		p_Writer.Write(CoverFailIgnoreTime);
		p_Writer.Write(StartMeleeFromCoverDistance);
		p_Writer.Write(ContinueMeleeFromCoverDistance);
		p_Writer.WriteNullBytes(4);
		EnemyCoverZones.Serialize(p_Writer, p_EbxWriter);
		FriendlyCoverZones.Serialize(p_Writer, p_EbxWriter);
	}
}

