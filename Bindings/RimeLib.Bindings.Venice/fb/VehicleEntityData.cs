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
	[ContainerType(16, 544)]
	public class VehicleEntityData : 
		ControllableEntityData
	{
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public Vec3 CriticallyDamagedEffectPosition { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public Vec3 FLIRKeyColor { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public Vec3 PreExplosionEffectPosition { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public Vec3 InteractionOffset { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float DisabledDamageThreshold { get; set; }

		[ContainerField(212), LayoutImmutable, JsonProperty(Order = 212)]
		public string ControllableType { get; set; } = string.Empty;

		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float PreDestructionDamageThreshold { get; set; }

		[ContainerField(220), JsonProperty(Order = 220)]
		public VehicleHealthZoneData RearHealthZone { get; set; } = new();

		[ContainerField(240), JsonProperty(Order = 240)]
		public VehicleHealthZoneData LeftHealthZone { get; set; } = new();

		[ContainerField(260), JsonProperty(Order = 260)]
		public VehicleHealthZoneData RightHealthZone { get; set; } = new();

		[ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		public float MinSpeedForMineActivation { get; set; }

		[ContainerField(284), JsonProperty(Order = 284)]
		public VehicleHealthZoneData FrontHealthZone { get; set; } = new();

		[ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		public float UpsideDownDamage { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		public float WaterDamageOffset { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		public float ArmorMultiplier { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		public float RegenerationDelayMultiplier { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		public float RegenerationRateMultiplier { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		public float EmergencyRepairHealth { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		public float DecayDelay { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		public float DecayRate { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		public float BelowWaterDamageDelay { get; set; }

		[ContainerField(340), JsonProperty(Order = 340)]
		public CtrRef<EffectBlueprint> CriticallyDamagedEffect { get; set; } = new();

		[ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		public float RegenerationRate { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		public float CriticalDamageTime { get; set; }

		[ContainerField(352), JsonProperty(Order = 352)]
		public CtrRef<EffectBlueprint> PreExplosionEffect { get; set; } = new();

		[ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		public float RegenerationDelay { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		public float PreExplosionTime { get; set; }

		[ContainerField(364), JsonProperty(Order = 364)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();

		[ContainerField(368), JsonProperty(Order = 368)]
		public CtrRef<CompositeMeshAsset> Mesh { get; set; } = new();

		[ContainerField(372), JsonProperty(Order = 372)]
		public CtrRef<ObjectBlueprint> CockpitMesh { get; set; } = new();

		[ContainerField(376), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
		public float VelocityDamageMagnifier { get; set; }

		[ContainerField(380), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
		public float ExitSpeedThreshold { get; set; }

		[ContainerField(384), JsonProperty(Order = 384)]
		public VehicleHudData HudData { get; set; } = new();

		[ContainerField(416), LayoutImmutable, JsonProperty(Order = 416)]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(420), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
		public int MaxPlayersInVehicle { get; set; }

		[ContainerField(424), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
		public float NametagHeightScale { get; set; }

		[ContainerField(428), JsonProperty(Order = 428)]
		public CtrRef<VehicleSoundData> Sound { get; set; } = new();

		[ContainerField(432), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		public float UpsideDownDamageDelay { get; set; }

		[ContainerField(436), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
		public float UpsideDownAngle { get; set; }

		[ContainerField(440), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
		public float WaterDamage { get; set; }

		[ContainerField(444), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
		public float LockingTimeMultiplier { get; set; }

		[ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		public float NametagHeightOffset { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		public float HighAltitudeLockHeight { get; set; }

		[ContainerField(456), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
		public float VelocityDamageThreshold { get; set; }

		[ContainerField(460), JsonProperty(Order = 460)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();

		[ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		public float ExitCameraSwitchDelay { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		public float KillSoldierCollisionSpeedThreshold { get; set; }

		[ContainerField(472), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
		public float ExitDirectionSpeedThreshold { get; set; }

		[ContainerField(476), JsonProperty(Order = 476)]
		public AngleOfImpactData AngleOfImpact { get; set; } = new();

		[ContainerField(500), JsonProperty(Order = 500)]
		public VehicleLockableInfoData VehicleLockableInfo { get; set; } = new();

		[ContainerField(516), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
		public float FLIRValue { get; set; }

		[ContainerField(520), JsonProperty(Order = 520)]
		public MPModeData MPMode { get; set; } = new();

		[ContainerField(524), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
		public bool IgnoreSoldierCollisionNormal { get; set; }

		[ContainerField(525), LayoutImmutable, Blittable, JsonProperty(Order = 525)]
		public bool ShowPlayerHealth { get; set; }

		[ContainerField(526), LayoutImmutable, Blittable, JsonProperty(Order = 526)]
		public bool ForegroundRenderCockpitMesh { get; set; }

		[ContainerField(527), LayoutImmutable, Blittable, JsonProperty(Order = 527)]
		public bool RenderVehicleMesh { get; set; }

		[ContainerField(528), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
		public bool IsAffectedByEMP { get; set; }

		[ContainerField(529), LayoutImmutable, Blittable, JsonProperty(Order = 529)]
		public bool ThrowOutSoldierInsideOnWaterDamage { get; set; }

		[ContainerField(530), LayoutImmutable, Blittable, JsonProperty(Order = 530)]
		public bool UseAsTeamSpawner { get; set; }

		[ContainerField(531), LayoutImmutable, Blittable, JsonProperty(Order = 531)]
		public bool IsLockable { get; set; }

		[ContainerField(532), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
		public bool ChoseExitPointByDirection { get; set; }

		[ContainerField(533), LayoutImmutable, Blittable, JsonProperty(Order = 533)]
		public bool HealthZonesShareDamage { get; set; }

		[ContainerField(534), LayoutImmutable, Blittable, JsonProperty(Order = 534)]
		public bool NeverReportVehicleAsEmpty { get; set; }

		[ContainerField(535), LayoutImmutable, Blittable, JsonProperty(Order = 535)]
		public bool ExitAllowed { get; set; }

		[ContainerField(536), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
		public bool UseLowAltitudeHeatSignature { get; set; }

		[ContainerField(537), LayoutImmutable, Blittable, JsonProperty(Order = 537)]
		public bool AllowVehicleOutsideCombatAreas { get; set; }

		[ContainerField(538), LayoutImmutable, Blittable, JsonProperty(Order = 538)]
		public bool EnableGroundmapLighting { get; set; }

		[ContainerField(539), LayoutImmutable, Blittable, JsonProperty(Order = 539)]
		public bool MotionBlurMask { get; set; }

		[ContainerField(540), LayoutImmutable, Blittable, JsonProperty(Order = 540)]
		public bool UseProtectedShields { get; set; }

		[ContainerField(541), LayoutImmutable, Blittable, JsonProperty(Order = 541)]
		public bool UseDriverEyePosForNametagPos { get; set; }

		[ContainerField(542), LayoutImmutable, Blittable, JsonProperty(Order = 542)]
		public bool EquipmentFakeVehicle { get; set; }

		[ContainerField(543), LayoutImmutable, Blittable, JsonProperty(Order = 543)]
		public bool ExplosionPacksAttachable { get; set; }

	}
}
