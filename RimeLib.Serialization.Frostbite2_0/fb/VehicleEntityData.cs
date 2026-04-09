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
	[ContainerType(16, 544)]
	public partial class VehicleEntityData :
		ControllableEntityData
	{
		[ObservableProperty]
		[property: ContainerField(144), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private Vec3 _CriticallyDamagedEffectPosition = new();

		[ObservableProperty]
		[property: ContainerField(160), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private Vec3 _FLIRKeyColor = new();

		[ObservableProperty]
		[property: ContainerField(176), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private Vec3 _PreExplosionEffectPosition = new();

		[ObservableProperty]
		[property: ContainerField(192), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private Vec3 _InteractionOffset = new();

		[ObservableProperty]
		[property: ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		private float _DisabledDamageThreshold;

		[ObservableProperty]
		[property: ContainerField(212), LayoutImmutable, JsonProperty(Order = 212)]
		private string _ControllableType = string.Empty;

		[ObservableProperty]
		[property: ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		private float _PreDestructionDamageThreshold;

		[ObservableProperty]
		[property: ContainerField(220), JsonProperty(Order = 220)]
		private VehicleHealthZoneData _RearHealthZone = new();

		[ObservableProperty]
		[property: ContainerField(240), JsonProperty(Order = 240)]
		private VehicleHealthZoneData _LeftHealthZone = new();

		[ObservableProperty]
		[property: ContainerField(260), JsonProperty(Order = 260)]
		private VehicleHealthZoneData _RightHealthZone = new();

		[ObservableProperty]
		[property: ContainerField(280), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
		private float _MinSpeedForMineActivation;

		[ObservableProperty]
		[property: ContainerField(284), JsonProperty(Order = 284)]
		private VehicleHealthZoneData _FrontHealthZone = new();

		[ObservableProperty]
		[property: ContainerField(304), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
		private float _UpsideDownDamage;

		[ObservableProperty]
		[property: ContainerField(308), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
		private float _WaterDamageOffset;

		[ObservableProperty]
		[property: ContainerField(312), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
		private float _ArmorMultiplier;

		[ObservableProperty]
		[property: ContainerField(316), LayoutImmutable, Blittable, JsonProperty(Order = 316)]
		private float _RegenerationDelayMultiplier;

		[ObservableProperty]
		[property: ContainerField(320), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
		private float _RegenerationRateMultiplier;

		[ObservableProperty]
		[property: ContainerField(324), LayoutImmutable, Blittable, JsonProperty(Order = 324)]
		private float _EmergencyRepairHealth;

		[ObservableProperty]
		[property: ContainerField(328), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
		private float _DecayDelay;

		[ObservableProperty]
		[property: ContainerField(332), LayoutImmutable, Blittable, JsonProperty(Order = 332)]
		private float _DecayRate;

		[ObservableProperty]
		[property: ContainerField(336), LayoutImmutable, Blittable, JsonProperty(Order = 336)]
		private float _BelowWaterDamageDelay;

		[ObservableProperty]
		[property: ContainerField(340), JsonProperty(Order = 340)]
		private CtrRef<EffectBlueprint> _CriticallyDamagedEffect = new();

		[ObservableProperty]
		[property: ContainerField(344), LayoutImmutable, Blittable, JsonProperty(Order = 344)]
		private float _RegenerationRate;

		[ObservableProperty]
		[property: ContainerField(348), LayoutImmutable, Blittable, JsonProperty(Order = 348)]
		private float _CriticalDamageTime;

		[ObservableProperty]
		[property: ContainerField(352), JsonProperty(Order = 352)]
		private CtrRef<EffectBlueprint> _PreExplosionEffect = new();

		[ObservableProperty]
		[property: ContainerField(356), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
		private float _RegenerationDelay;

		[ObservableProperty]
		[property: ContainerField(360), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
		private float _PreExplosionTime;

		[ObservableProperty]
		[property: ContainerField(364), JsonProperty(Order = 364)]
		private CtrRef<ExplosionEntityData> _Explosion = new();

		[ObservableProperty]
		[property: ContainerField(368), JsonProperty(Order = 368)]
		private CtrRef<CompositeMeshAsset> _Mesh = new();

		[ObservableProperty]
		[property: ContainerField(372), JsonProperty(Order = 372)]
		private CtrRef<ObjectBlueprint> _CockpitMesh = new();

		[ObservableProperty]
		[property: ContainerField(376), LayoutImmutable, Blittable, JsonProperty(Order = 376)]
		private float _VelocityDamageMagnifier;

		[ObservableProperty]
		[property: ContainerField(380), LayoutImmutable, Blittable, JsonProperty(Order = 380)]
		private float _ExitSpeedThreshold;

		[ObservableProperty]
		[property: ContainerField(384), JsonProperty(Order = 384)]
		private VehicleHudData _HudData = new();

		[ObservableProperty]
		[property: ContainerField(416), LayoutImmutable, JsonProperty(Order = 416)]
		private string _NameSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(420), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
		private int _MaxPlayersInVehicle;

		[ObservableProperty]
		[property: ContainerField(424), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
		private float _NametagHeightScale;

		[ObservableProperty]
		[property: ContainerField(428), JsonProperty(Order = 428)]
		private CtrRef<VehicleSoundData> _Sound = new();

		[ObservableProperty]
		[property: ContainerField(432), LayoutImmutable, Blittable, JsonProperty(Order = 432)]
		private float _UpsideDownDamageDelay;

		[ObservableProperty]
		[property: ContainerField(436), LayoutImmutable, Blittable, JsonProperty(Order = 436)]
		private float _UpsideDownAngle;

		[ObservableProperty]
		[property: ContainerField(440), LayoutImmutable, Blittable, JsonProperty(Order = 440)]
		private float _WaterDamage;

		[ObservableProperty]
		[property: ContainerField(444), LayoutImmutable, Blittable, JsonProperty(Order = 444)]
		private float _LockingTimeMultiplier;

		[ObservableProperty]
		[property: ContainerField(448), LayoutImmutable, Blittable, JsonProperty(Order = 448)]
		private float _NametagHeightOffset;

		[ObservableProperty]
		[property: ContainerField(452), LayoutImmutable, Blittable, JsonProperty(Order = 452)]
		private float _HighAltitudeLockHeight;

		[ObservableProperty]
		[property: ContainerField(456), LayoutImmutable, Blittable, JsonProperty(Order = 456)]
		private float _VelocityDamageThreshold;

		[ObservableProperty]
		[property: ContainerField(460), JsonProperty(Order = 460)]
		private CtrRef<EntityVoiceOverInfo> _VoiceOverInfo = new();

		[ObservableProperty]
		[property: ContainerField(464), LayoutImmutable, Blittable, JsonProperty(Order = 464)]
		private float _ExitCameraSwitchDelay;

		[ObservableProperty]
		[property: ContainerField(468), LayoutImmutable, Blittable, JsonProperty(Order = 468)]
		private float _KillSoldierCollisionSpeedThreshold;

		[ObservableProperty]
		[property: ContainerField(472), LayoutImmutable, Blittable, JsonProperty(Order = 472)]
		private float _ExitDirectionSpeedThreshold;

		[ObservableProperty]
		[property: ContainerField(476), JsonProperty(Order = 476)]
		private AngleOfImpactData _AngleOfImpact = new();

		[ObservableProperty]
		[property: ContainerField(500), JsonProperty(Order = 500)]
		private VehicleLockableInfoData _VehicleLockableInfo = new();

		[ObservableProperty]
		[property: ContainerField(516), LayoutImmutable, Blittable, JsonProperty(Order = 516)]
		private float _FLIRValue;

		[ObservableProperty]
		[property: ContainerField(520), JsonProperty(Order = 520)]
		private MPModeData _MPMode = new();

		[ObservableProperty]
		[property: ContainerField(524), LayoutImmutable, Blittable, JsonProperty(Order = 524)]
		private bool _IgnoreSoldierCollisionNormal;

		[ObservableProperty]
		[property: ContainerField(525), LayoutImmutable, Blittable, JsonProperty(Order = 525)]
		private bool _ShowPlayerHealth;

		[ObservableProperty]
		[property: ContainerField(526), LayoutImmutable, Blittable, JsonProperty(Order = 526)]
		private bool _ForegroundRenderCockpitMesh;

		[ObservableProperty]
		[property: ContainerField(527), LayoutImmutable, Blittable, JsonProperty(Order = 527)]
		private bool _RenderVehicleMesh;

		[ObservableProperty]
		[property: ContainerField(528), LayoutImmutable, Blittable, JsonProperty(Order = 528)]
		private bool _IsAffectedByEMP;

		[ObservableProperty]
		[property: ContainerField(529), LayoutImmutable, Blittable, JsonProperty(Order = 529)]
		private bool _ThrowOutSoldierInsideOnWaterDamage;

		[ObservableProperty]
		[property: ContainerField(530), LayoutImmutable, Blittable, JsonProperty(Order = 530)]
		private bool _UseAsTeamSpawner;

		[ObservableProperty]
		[property: ContainerField(531), LayoutImmutable, Blittable, JsonProperty(Order = 531)]
		private bool _IsLockable;

		[ObservableProperty]
		[property: ContainerField(532), LayoutImmutable, Blittable, JsonProperty(Order = 532)]
		private bool _ChoseExitPointByDirection;

		[ObservableProperty]
		[property: ContainerField(533), LayoutImmutable, Blittable, JsonProperty(Order = 533)]
		private bool _HealthZonesShareDamage;

		[ObservableProperty]
		[property: ContainerField(534), LayoutImmutable, Blittable, JsonProperty(Order = 534)]
		private bool _NeverReportVehicleAsEmpty;

		[ObservableProperty]
		[property: ContainerField(535), LayoutImmutable, Blittable, JsonProperty(Order = 535)]
		private bool _ExitAllowed;

		[ObservableProperty]
		[property: ContainerField(536), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
		private bool _UseLowAltitudeHeatSignature;

		[ObservableProperty]
		[property: ContainerField(537), LayoutImmutable, Blittable, JsonProperty(Order = 537)]
		private bool _AllowVehicleOutsideCombatAreas;

		[ObservableProperty]
		[property: ContainerField(538), LayoutImmutable, Blittable, JsonProperty(Order = 538)]
		private bool _EnableGroundmapLighting;

		[ObservableProperty]
		[property: ContainerField(539), LayoutImmutable, Blittable, JsonProperty(Order = 539)]
		private bool _MotionBlurMask;

		[ObservableProperty]
		[property: ContainerField(540), LayoutImmutable, Blittable, JsonProperty(Order = 540)]
		private bool _UseProtectedShields;

		[ObservableProperty]
		[property: ContainerField(541), LayoutImmutable, Blittable, JsonProperty(Order = 541)]
		private bool _UseDriverEyePosForNametagPos;

		[ObservableProperty]
		[property: ContainerField(542), LayoutImmutable, Blittable, JsonProperty(Order = 542)]
		private bool _EquipmentFakeVehicle;

		[ObservableProperty]
		[property: ContainerField(543), LayoutImmutable, Blittable, JsonProperty(Order = 543)]
		private bool _ExplosionPacksAttachable;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			CriticallyDamagedEffectPosition.Serialize(p_Writer, p_EbxWriter);
			FLIRKeyColor.Serialize(p_Writer, p_EbxWriter);
			PreExplosionEffectPosition.Serialize(p_Writer, p_EbxWriter);
			InteractionOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(DisabledDamageThreshold);
			p_Writer.Write(p_EbxWriter.WriteString(ControllableType));
			p_Writer.Write(PreDestructionDamageThreshold);
			RearHealthZone.Serialize(p_Writer, p_EbxWriter);
			LeftHealthZone.Serialize(p_Writer, p_EbxWriter);
			RightHealthZone.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(MinSpeedForMineActivation);
			FrontHealthZone.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(UpsideDownDamage);
			p_Writer.Write(WaterDamageOffset);
			p_Writer.Write(ArmorMultiplier);
			p_Writer.Write(RegenerationDelayMultiplier);
			p_Writer.Write(RegenerationRateMultiplier);
			p_Writer.Write(EmergencyRepairHealth);
			p_Writer.Write(DecayDelay);
			p_Writer.Write(DecayRate);
			p_Writer.Write(BelowWaterDamageDelay);
			p_Writer.Write(p_EbxWriter.WriteImport(CriticallyDamagedEffect));
			p_Writer.Write(RegenerationRate);
			p_Writer.Write(CriticalDamageTime);
			p_Writer.Write(p_EbxWriter.WriteImport(PreExplosionEffect));
			p_Writer.Write(RegenerationDelay);
			p_Writer.Write(PreExplosionTime);
			p_Writer.Write(p_EbxWriter.WriteImport(Explosion));
			p_Writer.Write(p_EbxWriter.WriteImport(Mesh));
			p_Writer.Write(p_EbxWriter.WriteImport(CockpitMesh));
			p_Writer.Write(VelocityDamageMagnifier);
			p_Writer.Write(ExitSpeedThreshold);
			HudData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(NameSid));
			p_Writer.Write(MaxPlayersInVehicle);
			p_Writer.Write(NametagHeightScale);
			p_Writer.Write(p_EbxWriter.WriteImport(Sound));
			p_Writer.Write(UpsideDownDamageDelay);
			p_Writer.Write(UpsideDownAngle);
			p_Writer.Write(WaterDamage);
			p_Writer.Write(LockingTimeMultiplier);
			p_Writer.Write(NametagHeightOffset);
			p_Writer.Write(HighAltitudeLockHeight);
			p_Writer.Write(VelocityDamageThreshold);
			p_Writer.Write(p_EbxWriter.WriteImport(VoiceOverInfo));
			p_Writer.Write(ExitCameraSwitchDelay);
			p_Writer.Write(KillSoldierCollisionSpeedThreshold);
			p_Writer.Write(ExitDirectionSpeedThreshold);
			AngleOfImpact.Serialize(p_Writer, p_EbxWriter);
			VehicleLockableInfo.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(FLIRValue);
			MPMode.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(IgnoreSoldierCollisionNormal);
			p_Writer.Write(ShowPlayerHealth);
			p_Writer.Write(ForegroundRenderCockpitMesh);
			p_Writer.Write(RenderVehicleMesh);
			p_Writer.Write(IsAffectedByEMP);
			p_Writer.Write(ThrowOutSoldierInsideOnWaterDamage);
			p_Writer.Write(UseAsTeamSpawner);
			p_Writer.Write(IsLockable);
			p_Writer.Write(ChoseExitPointByDirection);
			p_Writer.Write(HealthZonesShareDamage);
			p_Writer.Write(NeverReportVehicleAsEmpty);
			p_Writer.Write(ExitAllowed);
			p_Writer.Write(UseLowAltitudeHeatSignature);
			p_Writer.Write(AllowVehicleOutsideCombatAreas);
			p_Writer.Write(EnableGroundmapLighting);
			p_Writer.Write(MotionBlurMask);
			p_Writer.Write(UseProtectedShields);
			p_Writer.Write(UseDriverEyePosForNametagPos);
			p_Writer.Write(EquipmentFakeVehicle);
			p_Writer.Write(ExplosionPacksAttachable);
		}
	}
}
