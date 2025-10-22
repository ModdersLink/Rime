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

using fb.GameShared;
using fb.Core;

namespace fb.BFAI2Data;

[ContainerType(8, 184)]
public class BFAIWeaponData
	: fb.GameShared.GameAIWeaponData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public FiringWeaponClass FiringWeaponClass { get; set; } = fb.BFAI2Data.FiringWeaponClass.WeaponClass_AssaultRifle;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public VoPrimaryFireType VoPrimaryFireType { get; set; } = fb.BFAI2Data.VoPrimaryFireType.VoPrimaryFireType_AssaultRifle;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float WeaponRange { get; set; } = -1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float MinimumUsageDistance { get; set; } = -1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float MaximumUsageDistance { get; set; } = -1.000f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<PreferredRange> PreferredRange { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<PreferredRange> IndoorPreferredRange { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public CtrRef<PreferredRange> OutdoorPreferredRange { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<FiringIntervalPattern> FiringIntervalPattern { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<BurstIntervalPattern> BurstIntervalPattern { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<SprayPattern> SprayPattern { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<VehicleAimerSettings> VehicleAimerSettings { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<VisionModifier> VisionModifier { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<HearingModifier> HearingModifier { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<TargetModifier> TargetModifier { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<VehicleInaccuracySettings> VehicleInaccuracySettings { get; set; } = new();
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<SuppressedBehavior> SuppressedBehavior { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<DamageModifier> DamageModifier { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<WeaponRestrictions> FriendlyWeaponRestrictions { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<SpecialBehavior> SpecialBehavior { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<WeaponHitProbability> HumanTargetHitProbability { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public ValidAgainst ValidAgainst { get; set; } = fb.BFAI2Data.ValidAgainst.ValidAgainst_All;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) FiringWeaponClass);
		p_Writer.Write((int) VoPrimaryFireType);
		p_Writer.Write(WeaponRange);
		p_Writer.Write(MinimumUsageDistance);
		p_Writer.Write(MaximumUsageDistance);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PreferredRange));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(IndoorPreferredRange));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(OutdoorPreferredRange));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FiringIntervalPattern));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(BurstIntervalPattern));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SprayPattern));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VehicleAimerSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VisionModifier));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HearingModifier));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TargetModifier));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VehicleInaccuracySettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SuppressedBehavior));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DamageModifier));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FriendlyWeaponRestrictions));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SpecialBehavior));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HumanTargetHitProbability));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) ValidAgainst);
		p_Writer.WriteNullBytes(4);
	}
}

