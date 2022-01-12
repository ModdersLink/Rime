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
	[ContainerType(16, 544)]
	public class VehicleEntityData : 
		ControllableEntityData
	{
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CriticallyDamagedEffectPosition { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FLIRKeyColor { get; set; } = new();

		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PreExplosionEffectPosition { get; set; } = new();

		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InteractionOffset { get; set; } = new();

		[ContainerField(208), LayoutImmutable, Blittable]
		public float DisabledDamageThreshold { get; set; }

		[ContainerField(212), LayoutImmutable]
		public string ControllableType { get; set; } = string.Empty;

		[ContainerField(216), LayoutImmutable, Blittable]
		public float PreDestructionDamageThreshold { get; set; }

		[ContainerField(220)]
		public VehicleHealthZoneData RearHealthZone { get; set; } = new();

		[ContainerField(240)]
		public VehicleHealthZoneData LeftHealthZone { get; set; } = new();

		[ContainerField(260)]
		public VehicleHealthZoneData RightHealthZone { get; set; } = new();

		[ContainerField(280), LayoutImmutable, Blittable]
		public float MinSpeedForMineActivation { get; set; }

		[ContainerField(284)]
		public VehicleHealthZoneData FrontHealthZone { get; set; } = new();

		[ContainerField(304), LayoutImmutable, Blittable]
		public float UpsideDownDamage { get; set; }

		[ContainerField(308), LayoutImmutable, Blittable]
		public float WaterDamageOffset { get; set; }

		[ContainerField(312), LayoutImmutable, Blittable]
		public float ArmorMultiplier { get; set; }

		[ContainerField(316), LayoutImmutable, Blittable]
		public float RegenerationDelayMultiplier { get; set; }

		[ContainerField(320), LayoutImmutable, Blittable]
		public float RegenerationRateMultiplier { get; set; }

		[ContainerField(324), LayoutImmutable, Blittable]
		public float EmergencyRepairHealth { get; set; }

		[ContainerField(328), LayoutImmutable, Blittable]
		public float DecayDelay { get; set; }

		[ContainerField(332), LayoutImmutable, Blittable]
		public float DecayRate { get; set; }

		[ContainerField(336), LayoutImmutable, Blittable]
		public float BelowWaterDamageDelay { get; set; }

		[ContainerField(340)]
		public CtrRef<EffectBlueprint> CriticallyDamagedEffect { get; set; } = new();

		[ContainerField(344), LayoutImmutable, Blittable]
		public float RegenerationRate { get; set; }

		[ContainerField(348), LayoutImmutable, Blittable]
		public float CriticalDamageTime { get; set; }

		[ContainerField(352)]
		public CtrRef<EffectBlueprint> PreExplosionEffect { get; set; } = new();

		[ContainerField(356), LayoutImmutable, Blittable]
		public float RegenerationDelay { get; set; }

		[ContainerField(360), LayoutImmutable, Blittable]
		public float PreExplosionTime { get; set; }

		[ContainerField(364)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new();

		[ContainerField(368)]
		public CtrRef<CompositeMeshAsset> Mesh { get; set; } = new();

		[ContainerField(372)]
		public CtrRef<ObjectBlueprint> CockpitMesh { get; set; } = new();

		[ContainerField(376), LayoutImmutable, Blittable]
		public float VelocityDamageMagnifier { get; set; }

		[ContainerField(380), LayoutImmutable, Blittable]
		public float ExitSpeedThreshold { get; set; }

		[ContainerField(384)]
		public VehicleHudData HudData { get; set; } = new();

		[ContainerField(416), LayoutImmutable]
		public string NameSid { get; set; } = string.Empty;

		[ContainerField(420), LayoutImmutable, Blittable]
		public int MaxPlayersInVehicle { get; set; }

		[ContainerField(424), LayoutImmutable, Blittable]
		public float NametagHeightScale { get; set; }

		[ContainerField(428)]
		public CtrRef<VehicleSoundData> Sound { get; set; } = new();

		[ContainerField(432), LayoutImmutable, Blittable]
		public float UpsideDownDamageDelay { get; set; }

		[ContainerField(436), LayoutImmutable, Blittable]
		public float UpsideDownAngle { get; set; }

		[ContainerField(440), LayoutImmutable, Blittable]
		public float WaterDamage { get; set; }

		[ContainerField(444), LayoutImmutable, Blittable]
		public float LockingTimeMultiplier { get; set; }

		[ContainerField(448), LayoutImmutable, Blittable]
		public float NametagHeightOffset { get; set; }

		[ContainerField(452), LayoutImmutable, Blittable]
		public float HighAltitudeLockHeight { get; set; }

		[ContainerField(456), LayoutImmutable, Blittable]
		public float VelocityDamageThreshold { get; set; }

		[ContainerField(460)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new();

		[ContainerField(464), LayoutImmutable, Blittable]
		public float ExitCameraSwitchDelay { get; set; }

		[ContainerField(468), LayoutImmutable, Blittable]
		public float KillSoldierCollisionSpeedThreshold { get; set; }

		[ContainerField(472), LayoutImmutable, Blittable]
		public float ExitDirectionSpeedThreshold { get; set; }

		[ContainerField(476)]
		public AngleOfImpactData AngleOfImpact { get; set; } = new();

		[ContainerField(500)]
		public VehicleLockableInfoData VehicleLockableInfo { get; set; } = new();

		[ContainerField(516), LayoutImmutable, Blittable]
		public float FLIRValue { get; set; }

		[ContainerField(520)]
		public MPModeData MPMode { get; set; } = new();

		[ContainerField(524), LayoutImmutable, Blittable]
		public bool IgnoreSoldierCollisionNormal { get; set; }

		[ContainerField(525), LayoutImmutable, Blittable]
		public bool ShowPlayerHealth { get; set; }

		[ContainerField(526), LayoutImmutable, Blittable]
		public bool ForegroundRenderCockpitMesh { get; set; }

		[ContainerField(527), LayoutImmutable, Blittable]
		public bool RenderVehicleMesh { get; set; }

		[ContainerField(528), LayoutImmutable, Blittable]
		public bool IsAffectedByEMP { get; set; }

		[ContainerField(529), LayoutImmutable, Blittable]
		public bool ThrowOutSoldierInsideOnWaterDamage { get; set; }

		[ContainerField(530), LayoutImmutable, Blittable]
		public bool UseAsTeamSpawner { get; set; }

		[ContainerField(531), LayoutImmutable, Blittable]
		public bool IsLockable { get; set; }

		[ContainerField(532), LayoutImmutable, Blittable]
		public bool ChoseExitPointByDirection { get; set; }

		[ContainerField(533), LayoutImmutable, Blittable]
		public bool HealthZonesShareDamage { get; set; }

		[ContainerField(534), LayoutImmutable, Blittable]
		public bool NeverReportVehicleAsEmpty { get; set; }

		[ContainerField(535), LayoutImmutable, Blittable]
		public bool ExitAllowed { get; set; }

		[ContainerField(536), LayoutImmutable, Blittable]
		public bool UseLowAltitudeHeatSignature { get; set; }

		[ContainerField(537), LayoutImmutable, Blittable]
		public bool AllowVehicleOutsideCombatAreas { get; set; }

		[ContainerField(538), LayoutImmutable, Blittable]
		public bool EnableGroundmapLighting { get; set; }

		[ContainerField(539), LayoutImmutable, Blittable]
		public bool MotionBlurMask { get; set; }

		[ContainerField(540), LayoutImmutable, Blittable]
		public bool UseProtectedShields { get; set; }

		[ContainerField(541), LayoutImmutable, Blittable]
		public bool UseDriverEyePosForNametagPos { get; set; }

		[ContainerField(542), LayoutImmutable, Blittable]
		public bool EquipmentFakeVehicle { get; set; }

		[ContainerField(543), LayoutImmutable, Blittable]
		public bool ExplosionPacksAttachable { get; set; }

	}
}
