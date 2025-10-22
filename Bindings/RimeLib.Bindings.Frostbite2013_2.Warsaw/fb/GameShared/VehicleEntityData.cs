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
using fb.Audio;
using fb.Entity;
using fb.Render;
using fb.Physics;

namespace fb.GameShared;

[ContainerType(16, 768)]
public class VehicleEntityData
	: fb.GameShared.ControllableEntityData
{
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec3 CriticallyDamagedEffectPosition { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec3 PreExplosionEffectPosition { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public VehicleHudData HudData { get; set; } = new();
	
	[ContainerField(0x110), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public Vec3 FLIRKeyColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x120), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public Vec3 InteractionOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public string ControllableType { get; set; } = string.Empty;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float DisabledDamageThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x13c), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
	public float ClearDisabledDamageThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public float PreDestructionDamageThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public VehicleHealthZoneData FrontHealthZone { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public VehicleHealthZoneData RearHealthZone { get; set; } = new();
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public VehicleHealthZoneData LeftHealthZone { get; set; } = new();
	
	[ContainerField(0x1a8), JsonProperty(Order = 424)]
	public VehicleHealthZoneData RightHealthZone { get; set; } = new();
	
	[ContainerField(0x1c8), JsonProperty(Order = 456)]
	public VehicleHealthZoneData TopHealthZone { get; set; } = new();
	
	[ContainerField(0x1e8), LayoutImmutable, Blittable, JsonProperty(Order = 488)]
	public float TopHitHeight { get; set; } = 0.750f;
	
	[ContainerField(0x1ec), LayoutImmutable, Blittable, JsonProperty(Order = 492)]
	public float TopHitAngle { get; set; } = 45.000f;
	
	[ContainerField(0x1f0), LayoutImmutable, Blittable, JsonProperty(Order = 496)]
	public float RegenerationDelay { get; set; } = 5.000f;
	
	[ContainerField(0x1f4), LayoutImmutable, Blittable, JsonProperty(Order = 500)]
	public float RegenerationRate { get; set; } = 0.000f;
	
	[ContainerField(0x1f8), LayoutImmutable, Blittable, JsonProperty(Order = 504)]
	public float ArmorMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x1fc), LayoutImmutable, Blittable, JsonProperty(Order = 508)]
	public float RegenerationDelayMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x200), LayoutImmutable, Blittable, JsonProperty(Order = 512)]
	public float RegenerationRateMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x204), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
	public float EmergencyRepairHealth { get; set; } = 30.000f;
	
	[ContainerField(0x208), LayoutImmutable, Blittable, JsonProperty(Order = 520)]
	public float DecayDelay { get; set; } = 5.000f;
	
	[ContainerField(0x20c), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
	public float DecayRate { get; set; } = 0.000f;
	
	[ContainerField(0x210), JsonProperty(Order = 528)]
	public CtrRef<EffectBlueprint> CriticallyDamagedEffect { get; set; } = new();
	
	[ContainerField(0x218), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
	public float CriticalDamageTime { get; set; } = 5.000f;
	
	[ContainerField(0x220), JsonProperty(Order = 544)]
	public CtrRef<EffectBlueprint> PreExplosionEffect { get; set; } = new();
	
	[ContainerField(0x228), LayoutImmutable, Blittable, JsonProperty(Order = 552)]
	public float PreExplosionTime { get; set; } = 0.500f;
	
	[ContainerField(0x230), JsonProperty(Order = 560)]
	public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();
	
	[ContainerField(0x238), JsonProperty(Order = 568)]
	public CtrRef<CompositeMeshAsset> Mesh { get; set; } = new();
	
	[ContainerField(0x240), JsonProperty(Order = 576)]
	public CtrRef<ObjectBlueprint> CockpitMesh { get; set; } = new();
	
	[ContainerField(0x248), LayoutImmutable, Blittable, JsonProperty(Order = 584)]
	public string NameSid { get; set; } = string.Empty;
	
	[ContainerField(0x250), LayoutImmutable, Blittable, JsonProperty(Order = 592)]
	public int MaxPlayersInVehicle { get; set; } = -1;
	
	[ContainerField(0x254), LayoutImmutable, Blittable, JsonProperty(Order = 596)]
	public float MinSpeedForMineActivation { get; set; } = 0.100f;
	
	[ContainerField(0x258), LayoutImmutable, Blittable, JsonProperty(Order = 600)]
	public float UpsideDownDamage { get; set; } = 50.000f;
	
	[ContainerField(0x25c), LayoutImmutable, Blittable, JsonProperty(Order = 604)]
	public float UpsideDownDamageDelay { get; set; } = 1.000f;
	
	[ContainerField(0x260), LayoutImmutable, Blittable, JsonProperty(Order = 608)]
	public float UpsideDownAngle { get; set; } = 120.000f;
	
	[ContainerField(0x264), LayoutImmutable, Blittable, JsonProperty(Order = 612)]
	public float WaterDamage { get; set; } = 30.000f;
	
	[ContainerField(0x268), LayoutImmutable, Blittable, JsonProperty(Order = 616)]
	public float BelowWaterDamageDelay { get; set; } = 2.000f;
	
	[ContainerField(0x26c), LayoutImmutable, Blittable, JsonProperty(Order = 620)]
	public float WaterDamageOffset { get; set; } = 0.000f;
	
	[ContainerField(0x270), LayoutImmutable, Blittable, JsonProperty(Order = 624)]
	public float VelocityDamageThreshold { get; set; } = 75.000f;
	
	[ContainerField(0x274), LayoutImmutable, Blittable, JsonProperty(Order = 628)]
	public float VelocityDamageMagnifier { get; set; } = 5.000f;
	
	[ContainerField(0x278), LayoutImmutable, Blittable, JsonProperty(Order = 632)]
	public float RepairRateModifier { get; set; } = 1.000f;
	
	[ContainerField(0x27c), LayoutImmutable, Blittable, JsonProperty(Order = 636)]
	public float RepairRatePassengerModifier { get; set; } = 1.000f;
	
	[ContainerField(0x280), LayoutImmutable, Blittable, JsonProperty(Order = 640)]
	public float KillSoldierCollisionSpeedThreshold { get; set; } = 5.000f;
	
	[ContainerField(0x284), LayoutImmutable, Blittable, JsonProperty(Order = 644)]
	public float ExitSpeedThreshold { get; set; } = 0.000f;
	
	[ContainerField(0x288), LayoutImmutable, Blittable, JsonProperty(Order = 648)]
	public float ExitDirectionSpeedThreshold { get; set; } = 1.000f;
	
	[ContainerField(0x28c), LayoutImmutable, Blittable, JsonProperty(Order = 652)]
	public float FLIRValue { get; set; } = 1.000f;
	
	[ContainerField(0x290), JsonProperty(Order = 656)]
	public MPModeData MPMode { get; set; } = new();
	
	[ContainerField(0x294), LayoutImmutable, Blittable, JsonProperty(Order = 660)]
	public float ExitCameraSwitchDelay { get; set; } = 0.000f;
	
	[ContainerField(0x298), JsonProperty(Order = 664)]
	public AngleOfImpactData AngleOfImpact { get; set; } = new();
	
	[ContainerField(0x2b0), LayoutImmutable, Blittable, JsonProperty(Order = 688)]
	public float LockingTimeMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x2b4), JsonProperty(Order = 692)]
	public VehicleLockableInfoData VehicleLockableInfo { get; set; } = new();
	
	[ContainerField(0x2c4), LayoutImmutable, Blittable, JsonProperty(Order = 708)]
	public float HighAltitudeLockHeight { get; set; } = 0.000f;
	
	[ContainerField(0x2c8), JsonProperty(Order = 712)]
	public CtrRef<VehicleSoundData> Sound { get; set; } = new();
	
	[ContainerField(0x2d0), JsonProperty(Order = 720)]
	public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();
	
	[ContainerField(0x2d8), LayoutImmutable, Blittable, JsonProperty(Order = 728)]
	public float NametagHeightScale { get; set; } = 0.750f;
	
	[ContainerField(0x2dc), LayoutImmutable, Blittable, JsonProperty(Order = 732)]
	public float SpottingFovScale { get; set; } = 1.000f;
	
	[ContainerField(0x2e0), LayoutImmutable, Blittable, JsonProperty(Order = 736)]
	public bool AllowVehicleOutsideCombatAreas { get; set; } = true;
	
	[ContainerField(0x2e1), LayoutImmutable, Blittable, JsonProperty(Order = 737)]
	public bool UseTopZone { get; set; } = false;
	
	[ContainerField(0x2e2), LayoutImmutable, Blittable, JsonProperty(Order = 738)]
	public bool HealthZonesShareDamage { get; set; } = true;
	
	[ContainerField(0x2e3), LayoutImmutable, Blittable, JsonProperty(Order = 739)]
	public bool UseProtectedShields { get; set; } = false;
	
	[ContainerField(0x2e4), LayoutImmutable, Blittable, JsonProperty(Order = 740)]
	public bool ShowPlayerHealth { get; set; } = false;
	
	[ContainerField(0x2e5), LayoutImmutable, Blittable, JsonProperty(Order = 741)]
	public bool ForegroundRenderCockpitMesh { get; set; } = true;
	
	[ContainerField(0x2e6), LayoutImmutable, Blittable, JsonProperty(Order = 742)]
	public bool MotionBlurMask { get; set; } = false;
	
	[ContainerField(0x2e7), LayoutImmutable, Blittable, JsonProperty(Order = 743)]
	public bool SuppressDamageByPassengers { get; set; } = false;
	
	[ContainerField(0x2e8), LayoutImmutable, Blittable, JsonProperty(Order = 744)]
	public bool IsAffectedByEMP { get; set; } = true;
	
	[ContainerField(0x2e9), LayoutImmutable, Blittable, JsonProperty(Order = 745)]
	public bool CanTakeDynamicFireDamage { get; set; } = false;
	
	[ContainerField(0x2ea), LayoutImmutable, Blittable, JsonProperty(Order = 746)]
	public bool ThrowOutSoldierInsideOnWaterDamage { get; set; } = true;
	
	[ContainerField(0x2eb), LayoutImmutable, Blittable, JsonProperty(Order = 747)]
	public bool IgnoreSoldierCollisionNormal { get; set; } = false;
	
	[ContainerField(0x2ec), LayoutImmutable, Blittable, JsonProperty(Order = 748)]
	public bool ChoseExitPointByDirection { get; set; } = true;
	
	[ContainerField(0x2ed), LayoutImmutable, Blittable, JsonProperty(Order = 749)]
	public bool ExitAllowed { get; set; } = true;
	
	[ContainerField(0x2ee), LayoutImmutable, Blittable, JsonProperty(Order = 750)]
	public bool EnableGroundmapLighting { get; set; } = false;
	
	[ContainerField(0x2ef), LayoutImmutable, Blittable, JsonProperty(Order = 751)]
	public bool UseAsTeamSpawner { get; set; } = true;
	
	[ContainerField(0x2f0), LayoutImmutable, Blittable, JsonProperty(Order = 752)]
	public bool IsLockable { get; set; } = true;
	
	[ContainerField(0x2f1), LayoutImmutable, Blittable, JsonProperty(Order = 753)]
	public bool NeverReportVehicleAsEmpty { get; set; } = false;
	
	[ContainerField(0x2f2), LayoutImmutable, Blittable, JsonProperty(Order = 754)]
	public bool UseLowAltitudeHeatSignature { get; set; } = false;
	
	[ContainerField(0x2f3), LayoutImmutable, Blittable, JsonProperty(Order = 755)]
	public bool UseSpottingTargetComponentForRaycast { get; set; } = false;
	
	[ContainerField(0x2f4), LayoutImmutable, Blittable, JsonProperty(Order = 756)]
	public bool EquipmentFakeVehicle { get; set; } = false;
	
	[ContainerField(0x2f5), LayoutImmutable, Blittable, JsonProperty(Order = 757)]
	public bool ExplosionPacksAttachable { get; set; } = true;
	
	[ContainerField(0x2f6), LayoutImmutable, Blittable, JsonProperty(Order = 758)]
	public bool DamageGiverOverrideOwnerVehicle { get; set; } = false;
	
	[ContainerField(0x2f7), LayoutImmutable, Blittable, JsonProperty(Order = 759)]
	public bool VehicleLightingEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		CriticallyDamagedEffectPosition.Serialize(p_Writer, p_EbxWriter);
		PreExplosionEffectPosition.Serialize(p_Writer, p_EbxWriter);
		HudData.Serialize(p_Writer, p_EbxWriter);
		FLIRKeyColor.Serialize(p_Writer, p_EbxWriter);
		InteractionOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ControllableType));
		p_Writer.Write(DisabledDamageThreshold);
		p_Writer.Write(ClearDisabledDamageThreshold);
		p_Writer.Write(PreDestructionDamageThreshold);
		p_Writer.WriteNullBytes(4);
		FrontHealthZone.Serialize(p_Writer, p_EbxWriter);
		RearHealthZone.Serialize(p_Writer, p_EbxWriter);
		LeftHealthZone.Serialize(p_Writer, p_EbxWriter);
		RightHealthZone.Serialize(p_Writer, p_EbxWriter);
		TopHealthZone.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TopHitHeight);
		p_Writer.Write(TopHitAngle);
		p_Writer.Write(RegenerationDelay);
		p_Writer.Write(RegenerationRate);
		p_Writer.Write(ArmorMultiplier);
		p_Writer.Write(RegenerationDelayMultiplier);
		p_Writer.Write(RegenerationRateMultiplier);
		p_Writer.Write(EmergencyRepairHealth);
		p_Writer.Write(DecayDelay);
		p_Writer.Write(DecayRate);
		p_Writer.Write(p_EbxWriter.WriteImport(CriticallyDamagedEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CriticalDamageTime);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PreExplosionEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PreExplosionTime);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CockpitMesh));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(NameSid));
		p_Writer.Write(MaxPlayersInVehicle);
		p_Writer.Write(MinSpeedForMineActivation);
		p_Writer.Write(UpsideDownDamage);
		p_Writer.Write(UpsideDownDamageDelay);
		p_Writer.Write(UpsideDownAngle);
		p_Writer.Write(WaterDamage);
		p_Writer.Write(BelowWaterDamageDelay);
		p_Writer.Write(WaterDamageOffset);
		p_Writer.Write(VelocityDamageThreshold);
		p_Writer.Write(VelocityDamageMagnifier);
		p_Writer.Write(RepairRateModifier);
		p_Writer.Write(RepairRatePassengerModifier);
		p_Writer.Write(KillSoldierCollisionSpeedThreshold);
		p_Writer.Write(ExitSpeedThreshold);
		p_Writer.Write(ExitDirectionSpeedThreshold);
		p_Writer.Write(FLIRValue);
		MPMode.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ExitCameraSwitchDelay);
		AngleOfImpact.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LockingTimeMultiplier);
		VehicleLockableInfo.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(HighAltitudeLockHeight);
		p_Writer.Write(p_EbxWriter.WriteImport(Sound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverInfo));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(NametagHeightScale);
		p_Writer.Write(SpottingFovScale);
		p_Writer.Write(AllowVehicleOutsideCombatAreas);
		p_Writer.Write(UseTopZone);
		p_Writer.Write(HealthZonesShareDamage);
		p_Writer.Write(UseProtectedShields);
		p_Writer.Write(ShowPlayerHealth);
		p_Writer.Write(ForegroundRenderCockpitMesh);
		p_Writer.Write(MotionBlurMask);
		p_Writer.Write(SuppressDamageByPassengers);
		p_Writer.Write(IsAffectedByEMP);
		p_Writer.Write(CanTakeDynamicFireDamage);
		p_Writer.Write(ThrowOutSoldierInsideOnWaterDamage);
		p_Writer.Write(IgnoreSoldierCollisionNormal);
		p_Writer.Write(ChoseExitPointByDirection);
		p_Writer.Write(ExitAllowed);
		p_Writer.Write(EnableGroundmapLighting);
		p_Writer.Write(UseAsTeamSpawner);
		p_Writer.Write(IsLockable);
		p_Writer.Write(NeverReportVehicleAsEmpty);
		p_Writer.Write(UseLowAltitudeHeatSignature);
		p_Writer.Write(UseSpottingTargetComponentForRaycast);
		p_Writer.Write(EquipmentFakeVehicle);
		p_Writer.Write(ExplosionPacksAttachable);
		p_Writer.Write(DamageGiverOverrideOwnerVehicle);
		p_Writer.Write(VehicleLightingEnable);
		p_Writer.WriteNullBytes(8);
	}
}

