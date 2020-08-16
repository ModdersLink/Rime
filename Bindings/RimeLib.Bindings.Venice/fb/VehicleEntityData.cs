///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16)]
	public class VehicleEntityData : 
		ControllableEntityData
	{
		protected Vec3 m_CriticallyDamagedEffectPosition = new Vec3();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1856265210)]
		public Vec3 CriticallyDamagedEffectPosition { get { return m_CriticallyDamagedEffectPosition; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(CriticallyDamagedEffectPosition), this, m_CriticallyDamagedEffectPosition, value)) m_CriticallyDamagedEffectPosition = value; } } // 0x90 (144)
		
		protected Vec3 m_FLIRKeyColor = new Vec3();
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(844334526)]
		public Vec3 FLIRKeyColor { get { return m_FLIRKeyColor; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(FLIRKeyColor), this, m_FLIRKeyColor, value)) m_FLIRKeyColor = value; } } // 0xA0 (160)
		
		protected Vec3 m_PreExplosionEffectPosition = new Vec3();
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2935241977)]
		public Vec3 PreExplosionEffectPosition { get { return m_PreExplosionEffectPosition; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(PreExplosionEffectPosition), this, m_PreExplosionEffectPosition, value)) m_PreExplosionEffectPosition = value; } } // 0xB0 (176)
		
		protected Vec3 m_InteractionOffset = new Vec3();
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(696984818)]
		public Vec3 InteractionOffset { get { return m_InteractionOffset; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(InteractionOffset), this, m_InteractionOffset, value)) m_InteractionOffset = value; } } // 0xC0 (192)
		
		protected float m_DisabledDamageThreshold = new float();
		[ContainerField(208), LayoutImmutable, Blittable, ContainerFieldNameHash(3318533033)]
		public float DisabledDamageThreshold { get { return m_DisabledDamageThreshold; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(DisabledDamageThreshold), this, m_DisabledDamageThreshold, value)) m_DisabledDamageThreshold = value; } } // 0xD0 (208)
		
		protected string m_ControllableType = string.Empty;
		[ContainerField(212), LayoutImmutable, ContainerFieldNameHash(1363023004)]
		public string ControllableType { get { return m_ControllableType; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ControllableType), this, m_ControllableType, value)) m_ControllableType = value; } } // 0xD4 (212)
		
		protected float m_PreDestructionDamageThreshold = new float();
		[ContainerField(216), LayoutImmutable, Blittable, ContainerFieldNameHash(2383353120)]
		public float PreDestructionDamageThreshold { get { return m_PreDestructionDamageThreshold; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(PreDestructionDamageThreshold), this, m_PreDestructionDamageThreshold, value)) m_PreDestructionDamageThreshold = value; } } // 0xD8 (216)
		
		protected VehicleHealthZoneData m_RearHealthZone = new VehicleHealthZoneData();
		[ContainerField(220), ContainerFieldNameHash(3627622819)]
		public VehicleHealthZoneData RearHealthZone { get { return m_RearHealthZone; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(RearHealthZone), this, m_RearHealthZone, value)) m_RearHealthZone = value; } } // 0xDC (220)
		
		protected VehicleHealthZoneData m_LeftHealthZone = new VehicleHealthZoneData();
		[ContainerField(240), ContainerFieldNameHash(3030125852)]
		public VehicleHealthZoneData LeftHealthZone { get { return m_LeftHealthZone; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(LeftHealthZone), this, m_LeftHealthZone, value)) m_LeftHealthZone = value; } } // 0xF0 (240)
		
		protected VehicleHealthZoneData m_RightHealthZone = new VehicleHealthZoneData();
		[ContainerField(260), ContainerFieldNameHash(2832264487)]
		public VehicleHealthZoneData RightHealthZone { get { return m_RightHealthZone; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(RightHealthZone), this, m_RightHealthZone, value)) m_RightHealthZone = value; } } // 0x104 (260)
		
		protected float m_MinSpeedForMineActivation = new float();
		[ContainerField(280), LayoutImmutable, Blittable, ContainerFieldNameHash(339948744)]
		public float MinSpeedForMineActivation { get { return m_MinSpeedForMineActivation; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(MinSpeedForMineActivation), this, m_MinSpeedForMineActivation, value)) m_MinSpeedForMineActivation = value; } } // 0x118 (280)
		
		protected VehicleHealthZoneData m_FrontHealthZone = new VehicleHealthZoneData();
		[ContainerField(284), ContainerFieldNameHash(2276895046)]
		public VehicleHealthZoneData FrontHealthZone { get { return m_FrontHealthZone; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(FrontHealthZone), this, m_FrontHealthZone, value)) m_FrontHealthZone = value; } } // 0x11C (284)
		
		protected float m_UpsideDownDamage = new float();
		[ContainerField(304), LayoutImmutable, Blittable, ContainerFieldNameHash(4107473026)]
		public float UpsideDownDamage { get { return m_UpsideDownDamage; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(UpsideDownDamage), this, m_UpsideDownDamage, value)) m_UpsideDownDamage = value; } } // 0x130 (304)
		
		protected float m_WaterDamageOffset = new float();
		[ContainerField(308), LayoutImmutable, Blittable, ContainerFieldNameHash(559085046)]
		public float WaterDamageOffset { get { return m_WaterDamageOffset; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(WaterDamageOffset), this, m_WaterDamageOffset, value)) m_WaterDamageOffset = value; } } // 0x134 (308)
		
		protected float m_ArmorMultiplier = new float();
		[ContainerField(312), LayoutImmutable, Blittable, ContainerFieldNameHash(3612687949)]
		public float ArmorMultiplier { get { return m_ArmorMultiplier; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ArmorMultiplier), this, m_ArmorMultiplier, value)) m_ArmorMultiplier = value; } } // 0x138 (312)
		
		protected float m_RegenerationDelayMultiplier = new float();
		[ContainerField(316), LayoutImmutable, Blittable, ContainerFieldNameHash(2331689578)]
		public float RegenerationDelayMultiplier { get { return m_RegenerationDelayMultiplier; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(RegenerationDelayMultiplier), this, m_RegenerationDelayMultiplier, value)) m_RegenerationDelayMultiplier = value; } } // 0x13C (316)
		
		protected float m_RegenerationRateMultiplier = new float();
		[ContainerField(320), LayoutImmutable, Blittable, ContainerFieldNameHash(2044311709)]
		public float RegenerationRateMultiplier { get { return m_RegenerationRateMultiplier; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(RegenerationRateMultiplier), this, m_RegenerationRateMultiplier, value)) m_RegenerationRateMultiplier = value; } } // 0x140 (320)
		
		protected float m_EmergencyRepairHealth = new float();
		[ContainerField(324), LayoutImmutable, Blittable, ContainerFieldNameHash(2646266061)]
		public float EmergencyRepairHealth { get { return m_EmergencyRepairHealth; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(EmergencyRepairHealth), this, m_EmergencyRepairHealth, value)) m_EmergencyRepairHealth = value; } } // 0x144 (324)
		
		protected float m_DecayDelay = new float();
		[ContainerField(328), LayoutImmutable, Blittable, ContainerFieldNameHash(696940618)]
		public float DecayDelay { get { return m_DecayDelay; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(DecayDelay), this, m_DecayDelay, value)) m_DecayDelay = value; } } // 0x148 (328)
		
		protected float m_DecayRate = new float();
		[ContainerField(332), LayoutImmutable, Blittable, ContainerFieldNameHash(3274236317)]
		public float DecayRate { get { return m_DecayRate; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(DecayRate), this, m_DecayRate, value)) m_DecayRate = value; } } // 0x14C (332)
		
		protected float m_BelowWaterDamageDelay = new float();
		[ContainerField(336), LayoutImmutable, Blittable, ContainerFieldNameHash(2319914781)]
		public float BelowWaterDamageDelay { get { return m_BelowWaterDamageDelay; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(BelowWaterDamageDelay), this, m_BelowWaterDamageDelay, value)) m_BelowWaterDamageDelay = value; } } // 0x150 (336)
		
		protected CtrRef<EffectBlueprint> m_CriticallyDamagedEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(340), ContainerFieldNameHash(3947288579)]
		public CtrRef<EffectBlueprint> CriticallyDamagedEffect { get { return m_CriticallyDamagedEffect; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(CriticallyDamagedEffect), this, m_CriticallyDamagedEffect, value)) m_CriticallyDamagedEffect = value; } } // 0x154 (340)
		
		protected float m_RegenerationRate = new float();
		[ContainerField(344), LayoutImmutable, Blittable, ContainerFieldNameHash(3407288278)]
		public float RegenerationRate { get { return m_RegenerationRate; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(RegenerationRate), this, m_RegenerationRate, value)) m_RegenerationRate = value; } } // 0x158 (344)
		
		protected float m_CriticalDamageTime = new float();
		[ContainerField(348), LayoutImmutable, Blittable, ContainerFieldNameHash(859585936)]
		public float CriticalDamageTime { get { return m_CriticalDamageTime; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(CriticalDamageTime), this, m_CriticalDamageTime, value)) m_CriticalDamageTime = value; } } // 0x15C (348)
		
		protected CtrRef<EffectBlueprint> m_PreExplosionEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(352), ContainerFieldNameHash(2795974848)]
		public CtrRef<EffectBlueprint> PreExplosionEffect { get { return m_PreExplosionEffect; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(PreExplosionEffect), this, m_PreExplosionEffect, value)) m_PreExplosionEffect = value; } } // 0x160 (352)
		
		protected float m_RegenerationDelay = new float();
		[ContainerField(356), LayoutImmutable, Blittable, ContainerFieldNameHash(778753505)]
		public float RegenerationDelay { get { return m_RegenerationDelay; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(RegenerationDelay), this, m_RegenerationDelay, value)) m_RegenerationDelay = value; } } // 0x164 (356)
		
		protected float m_PreExplosionTime = new float();
		[ContainerField(360), LayoutImmutable, Blittable, ContainerFieldNameHash(3054583394)]
		public float PreExplosionTime { get { return m_PreExplosionTime; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(PreExplosionTime), this, m_PreExplosionTime, value)) m_PreExplosionTime = value; } } // 0x168 (360)
		
		protected CtrRef<ExplosionEntityData> m_Explosion = new CtrRef<ExplosionEntityData>();
		[ContainerField(364), ContainerFieldNameHash(2222171184)]
		public CtrRef<ExplosionEntityData> Explosion { get { return m_Explosion; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(Explosion), this, m_Explosion, value)) m_Explosion = value; } } // 0x16C (364)
		
		protected CtrRef<CompositeMeshAsset> m_Mesh = new CtrRef<CompositeMeshAsset>();
		[ContainerField(368), ContainerFieldNameHash(2088783990)]
		public CtrRef<CompositeMeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x170 (368)
		
		protected CtrRef<ObjectBlueprint> m_CockpitMesh = new CtrRef<ObjectBlueprint>();
		[ContainerField(372), ContainerFieldNameHash(1006188287)]
		public CtrRef<ObjectBlueprint> CockpitMesh { get { return m_CockpitMesh; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(CockpitMesh), this, m_CockpitMesh, value)) m_CockpitMesh = value; } } // 0x174 (372)
		
		protected float m_VelocityDamageMagnifier = new float();
		[ContainerField(376), LayoutImmutable, Blittable, ContainerFieldNameHash(489897037)]
		public float VelocityDamageMagnifier { get { return m_VelocityDamageMagnifier; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(VelocityDamageMagnifier), this, m_VelocityDamageMagnifier, value)) m_VelocityDamageMagnifier = value; } } // 0x178 (376)
		
		protected float m_ExitSpeedThreshold = new float();
		[ContainerField(380), LayoutImmutable, Blittable, ContainerFieldNameHash(1049184085)]
		public float ExitSpeedThreshold { get { return m_ExitSpeedThreshold; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ExitSpeedThreshold), this, m_ExitSpeedThreshold, value)) m_ExitSpeedThreshold = value; } } // 0x17C (380)
		
		protected VehicleHudData m_HudData = new VehicleHudData();
		[ContainerField(384), ContainerFieldNameHash(2639805868)]
		public VehicleHudData HudData { get { return m_HudData; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(HudData), this, m_HudData, value)) m_HudData = value; } } // 0x180 (384)
		
		protected string m_NameSid = string.Empty;
		[ContainerField(416), LayoutImmutable, ContainerFieldNameHash(3153745340)]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0x1A0 (416)
		
		protected int m_MaxPlayersInVehicle = new int();
		[ContainerField(420), LayoutImmutable, Blittable, ContainerFieldNameHash(3678083790)]
		public int MaxPlayersInVehicle { get { return m_MaxPlayersInVehicle; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(MaxPlayersInVehicle), this, m_MaxPlayersInVehicle, value)) m_MaxPlayersInVehicle = value; } } // 0x1A4 (420)
		
		protected float m_NametagHeightScale = new float();
		[ContainerField(424), LayoutImmutable, Blittable, ContainerFieldNameHash(3182332183)]
		public float NametagHeightScale { get { return m_NametagHeightScale; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(NametagHeightScale), this, m_NametagHeightScale, value)) m_NametagHeightScale = value; } } // 0x1A8 (424)
		
		protected CtrRef<VehicleSoundData> m_Sound = new CtrRef<VehicleSoundData>();
		[ContainerField(428), ContainerFieldNameHash(231353798)]
		public CtrRef<VehicleSoundData> Sound { get { return m_Sound; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(Sound), this, m_Sound, value)) m_Sound = value; } } // 0x1AC (428)
		
		protected float m_UpsideDownDamageDelay = new float();
		[ContainerField(432), LayoutImmutable, Blittable, ContainerFieldNameHash(1848412439)]
		public float UpsideDownDamageDelay { get { return m_UpsideDownDamageDelay; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(UpsideDownDamageDelay), this, m_UpsideDownDamageDelay, value)) m_UpsideDownDamageDelay = value; } } // 0x1B0 (432)
		
		protected float m_UpsideDownAngle = new float();
		[ContainerField(436), LayoutImmutable, Blittable, ContainerFieldNameHash(511050632)]
		public float UpsideDownAngle { get { return m_UpsideDownAngle; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(UpsideDownAngle), this, m_UpsideDownAngle, value)) m_UpsideDownAngle = value; } } // 0x1B4 (436)
		
		protected float m_WaterDamage = new float();
		[ContainerField(440), LayoutImmutable, Blittable, ContainerFieldNameHash(470266331)]
		public float WaterDamage { get { return m_WaterDamage; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(WaterDamage), this, m_WaterDamage, value)) m_WaterDamage = value; } } // 0x1B8 (440)
		
		protected float m_LockingTimeMultiplier = new float();
		[ContainerField(444), LayoutImmutable, Blittable, ContainerFieldNameHash(1983394672)]
		public float LockingTimeMultiplier { get { return m_LockingTimeMultiplier; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(LockingTimeMultiplier), this, m_LockingTimeMultiplier, value)) m_LockingTimeMultiplier = value; } } // 0x1BC (444)
		
		protected float m_NametagHeightOffset = new float();
		[ContainerField(448), LayoutImmutable, Blittable, ContainerFieldNameHash(847741666)]
		public float NametagHeightOffset { get { return m_NametagHeightOffset; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(NametagHeightOffset), this, m_NametagHeightOffset, value)) m_NametagHeightOffset = value; } } // 0x1C0 (448)
		
		protected float m_HighAltitudeLockHeight = new float();
		[ContainerField(452), LayoutImmutable, Blittable, ContainerFieldNameHash(562612431)]
		public float HighAltitudeLockHeight { get { return m_HighAltitudeLockHeight; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(HighAltitudeLockHeight), this, m_HighAltitudeLockHeight, value)) m_HighAltitudeLockHeight = value; } } // 0x1C4 (452)
		
		protected float m_VelocityDamageThreshold = new float();
		[ContainerField(456), LayoutImmutable, Blittable, ContainerFieldNameHash(3583792430)]
		public float VelocityDamageThreshold { get { return m_VelocityDamageThreshold; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(VelocityDamageThreshold), this, m_VelocityDamageThreshold, value)) m_VelocityDamageThreshold = value; } } // 0x1C8 (456)
		
		protected CtrRef<EntityVoiceOverInfo> m_VoiceOverInfo = new CtrRef<EntityVoiceOverInfo>();
		[ContainerField(460), ContainerFieldNameHash(1260547539)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get { return m_VoiceOverInfo; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(VoiceOverInfo), this, m_VoiceOverInfo, value)) m_VoiceOverInfo = value; } } // 0x1CC (460)
		
		protected float m_ExitCameraSwitchDelay = new float();
		[ContainerField(464), LayoutImmutable, Blittable, ContainerFieldNameHash(774785883)]
		public float ExitCameraSwitchDelay { get { return m_ExitCameraSwitchDelay; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ExitCameraSwitchDelay), this, m_ExitCameraSwitchDelay, value)) m_ExitCameraSwitchDelay = value; } } // 0x1D0 (464)
		
		protected float m_KillSoldierCollisionSpeedThreshold = new float();
		[ContainerField(468), LayoutImmutable, Blittable, ContainerFieldNameHash(3028123395)]
		public float KillSoldierCollisionSpeedThreshold { get { return m_KillSoldierCollisionSpeedThreshold; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(KillSoldierCollisionSpeedThreshold), this, m_KillSoldierCollisionSpeedThreshold, value)) m_KillSoldierCollisionSpeedThreshold = value; } } // 0x1D4 (468)
		
		protected float m_ExitDirectionSpeedThreshold = new float();
		[ContainerField(472), LayoutImmutable, Blittable, ContainerFieldNameHash(1613225104)]
		public float ExitDirectionSpeedThreshold { get { return m_ExitDirectionSpeedThreshold; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ExitDirectionSpeedThreshold), this, m_ExitDirectionSpeedThreshold, value)) m_ExitDirectionSpeedThreshold = value; } } // 0x1D8 (472)
		
		protected AngleOfImpactData m_AngleOfImpact = new AngleOfImpactData();
		[ContainerField(476), ContainerFieldNameHash(2658042767)]
		public AngleOfImpactData AngleOfImpact { get { return m_AngleOfImpact; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(AngleOfImpact), this, m_AngleOfImpact, value)) m_AngleOfImpact = value; } } // 0x1DC (476)
		
		protected VehicleLockableInfoData m_VehicleLockableInfo = new VehicleLockableInfoData();
		[ContainerField(500), ContainerFieldNameHash(3058902738)]
		public VehicleLockableInfoData VehicleLockableInfo { get { return m_VehicleLockableInfo; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(VehicleLockableInfo), this, m_VehicleLockableInfo, value)) m_VehicleLockableInfo = value; } } // 0x1F4 (500)
		
		protected float m_FLIRValue = new float();
		[ContainerField(516), LayoutImmutable, Blittable, ContainerFieldNameHash(3325471103)]
		public float FLIRValue { get { return m_FLIRValue; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(FLIRValue), this, m_FLIRValue, value)) m_FLIRValue = value; } } // 0x204 (516)
		
		protected MPModeData m_MPMode = new MPModeData();
		[ContainerField(520), ContainerFieldNameHash(2699506811)]
		public MPModeData MPMode { get { return m_MPMode; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(MPMode), this, m_MPMode, value)) m_MPMode = value; } } // 0x208 (520)
		
		protected bool m_IgnoreSoldierCollisionNormal = new bool();
		[ContainerField(524), LayoutImmutable, Blittable, ContainerFieldNameHash(1916568890)]
		public bool IgnoreSoldierCollisionNormal { get { return m_IgnoreSoldierCollisionNormal; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(IgnoreSoldierCollisionNormal), this, m_IgnoreSoldierCollisionNormal, value)) m_IgnoreSoldierCollisionNormal = value; } } // 0x20C (524)
		
		protected bool m_ShowPlayerHealth = new bool();
		[ContainerField(525), LayoutImmutable, Blittable, ContainerFieldNameHash(1579764169)]
		public bool ShowPlayerHealth { get { return m_ShowPlayerHealth; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ShowPlayerHealth), this, m_ShowPlayerHealth, value)) m_ShowPlayerHealth = value; } } // 0x20D (525)
		
		protected bool m_ForegroundRenderCockpitMesh = new bool();
		[ContainerField(526), LayoutImmutable, Blittable, ContainerFieldNameHash(1107408366)]
		public bool ForegroundRenderCockpitMesh { get { return m_ForegroundRenderCockpitMesh; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ForegroundRenderCockpitMesh), this, m_ForegroundRenderCockpitMesh, value)) m_ForegroundRenderCockpitMesh = value; } } // 0x20E (526)
		
		protected bool m_RenderVehicleMesh = new bool();
		[ContainerField(527), LayoutImmutable, Blittable, ContainerFieldNameHash(2056273412)]
		public bool RenderVehicleMesh { get { return m_RenderVehicleMesh; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(RenderVehicleMesh), this, m_RenderVehicleMesh, value)) m_RenderVehicleMesh = value; } } // 0x20F (527)
		
		protected bool m_IsAffectedByEMP = new bool();
		[ContainerField(528), LayoutImmutable, Blittable, ContainerFieldNameHash(2093965006)]
		public bool IsAffectedByEMP { get { return m_IsAffectedByEMP; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(IsAffectedByEMP), this, m_IsAffectedByEMP, value)) m_IsAffectedByEMP = value; } } // 0x210 (528)
		
		protected bool m_ThrowOutSoldierInsideOnWaterDamage = new bool();
		[ContainerField(529), LayoutImmutable, Blittable, ContainerFieldNameHash(1661389364)]
		public bool ThrowOutSoldierInsideOnWaterDamage { get { return m_ThrowOutSoldierInsideOnWaterDamage; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ThrowOutSoldierInsideOnWaterDamage), this, m_ThrowOutSoldierInsideOnWaterDamage, value)) m_ThrowOutSoldierInsideOnWaterDamage = value; } } // 0x211 (529)
		
		protected bool m_UseAsTeamSpawner = new bool();
		[ContainerField(530), LayoutImmutable, Blittable, ContainerFieldNameHash(1433904997)]
		public bool UseAsTeamSpawner { get { return m_UseAsTeamSpawner; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(UseAsTeamSpawner), this, m_UseAsTeamSpawner, value)) m_UseAsTeamSpawner = value; } } // 0x212 (530)
		
		protected bool m_IsLockable = new bool();
		[ContainerField(531), LayoutImmutable, Blittable, ContainerFieldNameHash(3657214078)]
		public bool IsLockable { get { return m_IsLockable; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(IsLockable), this, m_IsLockable, value)) m_IsLockable = value; } } // 0x213 (531)
		
		protected bool m_ChoseExitPointByDirection = new bool();
		[ContainerField(532), LayoutImmutable, Blittable, ContainerFieldNameHash(775582885)]
		public bool ChoseExitPointByDirection { get { return m_ChoseExitPointByDirection; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ChoseExitPointByDirection), this, m_ChoseExitPointByDirection, value)) m_ChoseExitPointByDirection = value; } } // 0x214 (532)
		
		protected bool m_HealthZonesShareDamage = new bool();
		[ContainerField(533), LayoutImmutable, Blittable, ContainerFieldNameHash(4208633362)]
		public bool HealthZonesShareDamage { get { return m_HealthZonesShareDamage; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(HealthZonesShareDamage), this, m_HealthZonesShareDamage, value)) m_HealthZonesShareDamage = value; } } // 0x215 (533)
		
		protected bool m_NeverReportVehicleAsEmpty = new bool();
		[ContainerField(534), LayoutImmutable, Blittable, ContainerFieldNameHash(1610705598)]
		public bool NeverReportVehicleAsEmpty { get { return m_NeverReportVehicleAsEmpty; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(NeverReportVehicleAsEmpty), this, m_NeverReportVehicleAsEmpty, value)) m_NeverReportVehicleAsEmpty = value; } } // 0x216 (534)
		
		protected bool m_ExitAllowed = new bool();
		[ContainerField(535), LayoutImmutable, Blittable, ContainerFieldNameHash(1004482141)]
		public bool ExitAllowed { get { return m_ExitAllowed; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ExitAllowed), this, m_ExitAllowed, value)) m_ExitAllowed = value; } } // 0x217 (535)
		
		protected bool m_UseLowAltitudeHeatSignature = new bool();
		[ContainerField(536), LayoutImmutable, Blittable, ContainerFieldNameHash(3071375774)]
		public bool UseLowAltitudeHeatSignature { get { return m_UseLowAltitudeHeatSignature; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(UseLowAltitudeHeatSignature), this, m_UseLowAltitudeHeatSignature, value)) m_UseLowAltitudeHeatSignature = value; } } // 0x218 (536)
		
		protected bool m_AllowVehicleOutsideCombatAreas = new bool();
		[ContainerField(537), LayoutImmutable, Blittable, ContainerFieldNameHash(4259780355)]
		public bool AllowVehicleOutsideCombatAreas { get { return m_AllowVehicleOutsideCombatAreas; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(AllowVehicleOutsideCombatAreas), this, m_AllowVehicleOutsideCombatAreas, value)) m_AllowVehicleOutsideCombatAreas = value; } } // 0x219 (537)
		
		protected bool m_EnableGroundmapLighting = new bool();
		[ContainerField(538), LayoutImmutable, Blittable, ContainerFieldNameHash(1278245411)]
		public bool EnableGroundmapLighting { get { return m_EnableGroundmapLighting; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(EnableGroundmapLighting), this, m_EnableGroundmapLighting, value)) m_EnableGroundmapLighting = value; } } // 0x21A (538)
		
		protected bool m_MotionBlurMask = new bool();
		[ContainerField(539), LayoutImmutable, Blittable, ContainerFieldNameHash(3803525894)]
		public bool MotionBlurMask { get { return m_MotionBlurMask; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(MotionBlurMask), this, m_MotionBlurMask, value)) m_MotionBlurMask = value; } } // 0x21B (539)
		
		protected bool m_UseProtectedShields = new bool();
		[ContainerField(540), LayoutImmutable, Blittable, ContainerFieldNameHash(3998576672)]
		public bool UseProtectedShields { get { return m_UseProtectedShields; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(UseProtectedShields), this, m_UseProtectedShields, value)) m_UseProtectedShields = value; } } // 0x21C (540)
		
		protected bool m_UseDriverEyePosForNametagPos = new bool();
		[ContainerField(541), LayoutImmutable, Blittable, ContainerFieldNameHash(2055300591)]
		public bool UseDriverEyePosForNametagPos { get { return m_UseDriverEyePosForNametagPos; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(UseDriverEyePosForNametagPos), this, m_UseDriverEyePosForNametagPos, value)) m_UseDriverEyePosForNametagPos = value; } } // 0x21D (541)
		
		protected bool m_EquipmentFakeVehicle = new bool();
		[ContainerField(542), LayoutImmutable, Blittable, ContainerFieldNameHash(3184500446)]
		public bool EquipmentFakeVehicle { get { return m_EquipmentFakeVehicle; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(EquipmentFakeVehicle), this, m_EquipmentFakeVehicle, value)) m_EquipmentFakeVehicle = value; } } // 0x21E (542)
		
		protected bool m_ExplosionPacksAttachable = new bool();
		[ContainerField(543), LayoutImmutable, Blittable, ContainerFieldNameHash(2851996027)]
		public bool ExplosionPacksAttachable { get { return m_ExplosionPacksAttachable; } set { if (OnPropertyChanging("VehicleEntityData." + nameof(ExplosionPacksAttachable), this, m_ExplosionPacksAttachable, value)) m_ExplosionPacksAttachable = value; } } // 0x21F (543)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1856265210:
					CriticallyDamagedEffectPosition = (Vec3) p_Value;
					break;

				case 844334526:
					FLIRKeyColor = (Vec3) p_Value;
					break;

				case 2935241977:
					PreExplosionEffectPosition = (Vec3) p_Value;
					break;

				case 696984818:
					InteractionOffset = (Vec3) p_Value;
					break;

				case 3318533033:
					DisabledDamageThreshold = (float) p_Value;
					break;

				case 1363023004:
					ControllableType = (string) p_Value;
					break;

				case 2383353120:
					PreDestructionDamageThreshold = (float) p_Value;
					break;

				case 3627622819:
					RearHealthZone = (VehicleHealthZoneData) p_Value;
					break;

				case 3030125852:
					LeftHealthZone = (VehicleHealthZoneData) p_Value;
					break;

				case 2832264487:
					RightHealthZone = (VehicleHealthZoneData) p_Value;
					break;

				case 339948744:
					MinSpeedForMineActivation = (float) p_Value;
					break;

				case 2276895046:
					FrontHealthZone = (VehicleHealthZoneData) p_Value;
					break;

				case 4107473026:
					UpsideDownDamage = (float) p_Value;
					break;

				case 559085046:
					WaterDamageOffset = (float) p_Value;
					break;

				case 3612687949:
					ArmorMultiplier = (float) p_Value;
					break;

				case 2331689578:
					RegenerationDelayMultiplier = (float) p_Value;
					break;

				case 2044311709:
					RegenerationRateMultiplier = (float) p_Value;
					break;

				case 2646266061:
					EmergencyRepairHealth = (float) p_Value;
					break;

				case 696940618:
					DecayDelay = (float) p_Value;
					break;

				case 3274236317:
					DecayRate = (float) p_Value;
					break;

				case 2319914781:
					BelowWaterDamageDelay = (float) p_Value;
					break;

				case 3947288579:
					CriticallyDamagedEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 3407288278:
					RegenerationRate = (float) p_Value;
					break;

				case 859585936:
					CriticalDamageTime = (float) p_Value;
					break;

				case 2795974848:
					PreExplosionEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 778753505:
					RegenerationDelay = (float) p_Value;
					break;

				case 3054583394:
					PreExplosionTime = (float) p_Value;
					break;

				case 2222171184:
					Explosion = (CtrRef<ExplosionEntityData>) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<CompositeMeshAsset>) p_Value;
					break;

				case 1006188287:
					CockpitMesh = (CtrRef<ObjectBlueprint>) p_Value;
					break;

				case 489897037:
					VelocityDamageMagnifier = (float) p_Value;
					break;

				case 1049184085:
					ExitSpeedThreshold = (float) p_Value;
					break;

				case 2639805868:
					HudData = (VehicleHudData) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 3678083790:
					MaxPlayersInVehicle = (int) p_Value;
					break;

				case 3182332183:
					NametagHeightScale = (float) p_Value;
					break;

				case 231353798:
					Sound = (CtrRef<VehicleSoundData>) p_Value;
					break;

				case 1848412439:
					UpsideDownDamageDelay = (float) p_Value;
					break;

				case 511050632:
					UpsideDownAngle = (float) p_Value;
					break;

				case 470266331:
					WaterDamage = (float) p_Value;
					break;

				case 1983394672:
					LockingTimeMultiplier = (float) p_Value;
					break;

				case 847741666:
					NametagHeightOffset = (float) p_Value;
					break;

				case 562612431:
					HighAltitudeLockHeight = (float) p_Value;
					break;

				case 3583792430:
					VelocityDamageThreshold = (float) p_Value;
					break;

				case 1260547539:
					VoiceOverInfo = (CtrRef<EntityVoiceOverInfo>) p_Value;
					break;

				case 774785883:
					ExitCameraSwitchDelay = (float) p_Value;
					break;

				case 3028123395:
					KillSoldierCollisionSpeedThreshold = (float) p_Value;
					break;

				case 1613225104:
					ExitDirectionSpeedThreshold = (float) p_Value;
					break;

				case 2658042767:
					AngleOfImpact = (AngleOfImpactData) p_Value;
					break;

				case 3058902738:
					VehicleLockableInfo = (VehicleLockableInfoData) p_Value;
					break;

				case 3325471103:
					FLIRValue = (float) p_Value;
					break;

				case 2699506811:
					MPMode = (MPModeData) p_Value;
					break;

				case 1916568890:
					IgnoreSoldierCollisionNormal = (bool) p_Value;
					break;

				case 1579764169:
					ShowPlayerHealth = (bool) p_Value;
					break;

				case 1107408366:
					ForegroundRenderCockpitMesh = (bool) p_Value;
					break;

				case 2056273412:
					RenderVehicleMesh = (bool) p_Value;
					break;

				case 2093965006:
					IsAffectedByEMP = (bool) p_Value;
					break;

				case 1661389364:
					ThrowOutSoldierInsideOnWaterDamage = (bool) p_Value;
					break;

				case 1433904997:
					UseAsTeamSpawner = (bool) p_Value;
					break;

				case 3657214078:
					IsLockable = (bool) p_Value;
					break;

				case 775582885:
					ChoseExitPointByDirection = (bool) p_Value;
					break;

				case 4208633362:
					HealthZonesShareDamage = (bool) p_Value;
					break;

				case 1610705598:
					NeverReportVehicleAsEmpty = (bool) p_Value;
					break;

				case 1004482141:
					ExitAllowed = (bool) p_Value;
					break;

				case 3071375774:
					UseLowAltitudeHeatSignature = (bool) p_Value;
					break;

				case 4259780355:
					AllowVehicleOutsideCombatAreas = (bool) p_Value;
					break;

				case 1278245411:
					EnableGroundmapLighting = (bool) p_Value;
					break;

				case 3803525894:
					MotionBlurMask = (bool) p_Value;
					break;

				case 3998576672:
					UseProtectedShields = (bool) p_Value;
					break;

				case 2055300591:
					UseDriverEyePosForNametagPos = (bool) p_Value;
					break;

				case 3184500446:
					EquipmentFakeVehicle = (bool) p_Value;
					break;

				case 2851996027:
					ExplosionPacksAttachable = (bool) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1856265210:
					return CriticallyDamagedEffectPosition;

				case 844334526:
					return FLIRKeyColor;

				case 2935241977:
					return PreExplosionEffectPosition;

				case 696984818:
					return InteractionOffset;

				case 3318533033:
					return DisabledDamageThreshold;

				case 1363023004:
					return ControllableType;

				case 2383353120:
					return PreDestructionDamageThreshold;

				case 3627622819:
					return RearHealthZone;

				case 3030125852:
					return LeftHealthZone;

				case 2832264487:
					return RightHealthZone;

				case 339948744:
					return MinSpeedForMineActivation;

				case 2276895046:
					return FrontHealthZone;

				case 4107473026:
					return UpsideDownDamage;

				case 559085046:
					return WaterDamageOffset;

				case 3612687949:
					return ArmorMultiplier;

				case 2331689578:
					return RegenerationDelayMultiplier;

				case 2044311709:
					return RegenerationRateMultiplier;

				case 2646266061:
					return EmergencyRepairHealth;

				case 696940618:
					return DecayDelay;

				case 3274236317:
					return DecayRate;

				case 2319914781:
					return BelowWaterDamageDelay;

				case 3947288579:
					return CriticallyDamagedEffect;

				case 3407288278:
					return RegenerationRate;

				case 859585936:
					return CriticalDamageTime;

				case 2795974848:
					return PreExplosionEffect;

				case 778753505:
					return RegenerationDelay;

				case 3054583394:
					return PreExplosionTime;

				case 2222171184:
					return Explosion;

				case 2088783990:
					return Mesh;

				case 1006188287:
					return CockpitMesh;

				case 489897037:
					return VelocityDamageMagnifier;

				case 1049184085:
					return ExitSpeedThreshold;

				case 2639805868:
					return HudData;

				case 3153745340:
					return NameSid;

				case 3678083790:
					return MaxPlayersInVehicle;

				case 3182332183:
					return NametagHeightScale;

				case 231353798:
					return Sound;

				case 1848412439:
					return UpsideDownDamageDelay;

				case 511050632:
					return UpsideDownAngle;

				case 470266331:
					return WaterDamage;

				case 1983394672:
					return LockingTimeMultiplier;

				case 847741666:
					return NametagHeightOffset;

				case 562612431:
					return HighAltitudeLockHeight;

				case 3583792430:
					return VelocityDamageThreshold;

				case 1260547539:
					return VoiceOverInfo;

				case 774785883:
					return ExitCameraSwitchDelay;

				case 3028123395:
					return KillSoldierCollisionSpeedThreshold;

				case 1613225104:
					return ExitDirectionSpeedThreshold;

				case 2658042767:
					return AngleOfImpact;

				case 3058902738:
					return VehicleLockableInfo;

				case 3325471103:
					return FLIRValue;

				case 2699506811:
					return MPMode;

				case 1916568890:
					return IgnoreSoldierCollisionNormal;

				case 1579764169:
					return ShowPlayerHealth;

				case 1107408366:
					return ForegroundRenderCockpitMesh;

				case 2056273412:
					return RenderVehicleMesh;

				case 2093965006:
					return IsAffectedByEMP;

				case 1661389364:
					return ThrowOutSoldierInsideOnWaterDamage;

				case 1433904997:
					return UseAsTeamSpawner;

				case 3657214078:
					return IsLockable;

				case 775582885:
					return ChoseExitPointByDirection;

				case 4208633362:
					return HealthZonesShareDamage;

				case 1610705598:
					return NeverReportVehicleAsEmpty;

				case 1004482141:
					return ExitAllowed;

				case 3071375774:
					return UseLowAltitudeHeatSignature;

				case 4259780355:
					return AllowVehicleOutsideCombatAreas;

				case 1278245411:
					return EnableGroundmapLighting;

				case 3803525894:
					return MotionBlurMask;

				case 3998576672:
					return UseProtectedShields;

				case 2055300591:
					return UseDriverEyePosForNametagPos;

				case 3184500446:
					return EquipmentFakeVehicle;

				case 2851996027:
					return ExplosionPacksAttachable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1856265210:
					return typeof(VehicleEntityData).GetProperty(nameof(CriticallyDamagedEffectPosition));

				case 844334526:
					return typeof(VehicleEntityData).GetProperty(nameof(FLIRKeyColor));

				case 2935241977:
					return typeof(VehicleEntityData).GetProperty(nameof(PreExplosionEffectPosition));

				case 696984818:
					return typeof(VehicleEntityData).GetProperty(nameof(InteractionOffset));

				case 3318533033:
					return typeof(VehicleEntityData).GetProperty(nameof(DisabledDamageThreshold));

				case 1363023004:
					return typeof(VehicleEntityData).GetProperty(nameof(ControllableType));

				case 2383353120:
					return typeof(VehicleEntityData).GetProperty(nameof(PreDestructionDamageThreshold));

				case 3627622819:
					return typeof(VehicleEntityData).GetProperty(nameof(RearHealthZone));

				case 3030125852:
					return typeof(VehicleEntityData).GetProperty(nameof(LeftHealthZone));

				case 2832264487:
					return typeof(VehicleEntityData).GetProperty(nameof(RightHealthZone));

				case 339948744:
					return typeof(VehicleEntityData).GetProperty(nameof(MinSpeedForMineActivation));

				case 2276895046:
					return typeof(VehicleEntityData).GetProperty(nameof(FrontHealthZone));

				case 4107473026:
					return typeof(VehicleEntityData).GetProperty(nameof(UpsideDownDamage));

				case 559085046:
					return typeof(VehicleEntityData).GetProperty(nameof(WaterDamageOffset));

				case 3612687949:
					return typeof(VehicleEntityData).GetProperty(nameof(ArmorMultiplier));

				case 2331689578:
					return typeof(VehicleEntityData).GetProperty(nameof(RegenerationDelayMultiplier));

				case 2044311709:
					return typeof(VehicleEntityData).GetProperty(nameof(RegenerationRateMultiplier));

				case 2646266061:
					return typeof(VehicleEntityData).GetProperty(nameof(EmergencyRepairHealth));

				case 696940618:
					return typeof(VehicleEntityData).GetProperty(nameof(DecayDelay));

				case 3274236317:
					return typeof(VehicleEntityData).GetProperty(nameof(DecayRate));

				case 2319914781:
					return typeof(VehicleEntityData).GetProperty(nameof(BelowWaterDamageDelay));

				case 3947288579:
					return typeof(VehicleEntityData).GetProperty(nameof(CriticallyDamagedEffect));

				case 3407288278:
					return typeof(VehicleEntityData).GetProperty(nameof(RegenerationRate));

				case 859585936:
					return typeof(VehicleEntityData).GetProperty(nameof(CriticalDamageTime));

				case 2795974848:
					return typeof(VehicleEntityData).GetProperty(nameof(PreExplosionEffect));

				case 778753505:
					return typeof(VehicleEntityData).GetProperty(nameof(RegenerationDelay));

				case 3054583394:
					return typeof(VehicleEntityData).GetProperty(nameof(PreExplosionTime));

				case 2222171184:
					return typeof(VehicleEntityData).GetProperty(nameof(Explosion));

				case 2088783990:
					return typeof(VehicleEntityData).GetProperty(nameof(Mesh));

				case 1006188287:
					return typeof(VehicleEntityData).GetProperty(nameof(CockpitMesh));

				case 489897037:
					return typeof(VehicleEntityData).GetProperty(nameof(VelocityDamageMagnifier));

				case 1049184085:
					return typeof(VehicleEntityData).GetProperty(nameof(ExitSpeedThreshold));

				case 2639805868:
					return typeof(VehicleEntityData).GetProperty(nameof(HudData));

				case 3153745340:
					return typeof(VehicleEntityData).GetProperty(nameof(NameSid));

				case 3678083790:
					return typeof(VehicleEntityData).GetProperty(nameof(MaxPlayersInVehicle));

				case 3182332183:
					return typeof(VehicleEntityData).GetProperty(nameof(NametagHeightScale));

				case 231353798:
					return typeof(VehicleEntityData).GetProperty(nameof(Sound));

				case 1848412439:
					return typeof(VehicleEntityData).GetProperty(nameof(UpsideDownDamageDelay));

				case 511050632:
					return typeof(VehicleEntityData).GetProperty(nameof(UpsideDownAngle));

				case 470266331:
					return typeof(VehicleEntityData).GetProperty(nameof(WaterDamage));

				case 1983394672:
					return typeof(VehicleEntityData).GetProperty(nameof(LockingTimeMultiplier));

				case 847741666:
					return typeof(VehicleEntityData).GetProperty(nameof(NametagHeightOffset));

				case 562612431:
					return typeof(VehicleEntityData).GetProperty(nameof(HighAltitudeLockHeight));

				case 3583792430:
					return typeof(VehicleEntityData).GetProperty(nameof(VelocityDamageThreshold));

				case 1260547539:
					return typeof(VehicleEntityData).GetProperty(nameof(VoiceOverInfo));

				case 774785883:
					return typeof(VehicleEntityData).GetProperty(nameof(ExitCameraSwitchDelay));

				case 3028123395:
					return typeof(VehicleEntityData).GetProperty(nameof(KillSoldierCollisionSpeedThreshold));

				case 1613225104:
					return typeof(VehicleEntityData).GetProperty(nameof(ExitDirectionSpeedThreshold));

				case 2658042767:
					return typeof(VehicleEntityData).GetProperty(nameof(AngleOfImpact));

				case 3058902738:
					return typeof(VehicleEntityData).GetProperty(nameof(VehicleLockableInfo));

				case 3325471103:
					return typeof(VehicleEntityData).GetProperty(nameof(FLIRValue));

				case 2699506811:
					return typeof(VehicleEntityData).GetProperty(nameof(MPMode));

				case 1916568890:
					return typeof(VehicleEntityData).GetProperty(nameof(IgnoreSoldierCollisionNormal));

				case 1579764169:
					return typeof(VehicleEntityData).GetProperty(nameof(ShowPlayerHealth));

				case 1107408366:
					return typeof(VehicleEntityData).GetProperty(nameof(ForegroundRenderCockpitMesh));

				case 2056273412:
					return typeof(VehicleEntityData).GetProperty(nameof(RenderVehicleMesh));

				case 2093965006:
					return typeof(VehicleEntityData).GetProperty(nameof(IsAffectedByEMP));

				case 1661389364:
					return typeof(VehicleEntityData).GetProperty(nameof(ThrowOutSoldierInsideOnWaterDamage));

				case 1433904997:
					return typeof(VehicleEntityData).GetProperty(nameof(UseAsTeamSpawner));

				case 3657214078:
					return typeof(VehicleEntityData).GetProperty(nameof(IsLockable));

				case 775582885:
					return typeof(VehicleEntityData).GetProperty(nameof(ChoseExitPointByDirection));

				case 4208633362:
					return typeof(VehicleEntityData).GetProperty(nameof(HealthZonesShareDamage));

				case 1610705598:
					return typeof(VehicleEntityData).GetProperty(nameof(NeverReportVehicleAsEmpty));

				case 1004482141:
					return typeof(VehicleEntityData).GetProperty(nameof(ExitAllowed));

				case 3071375774:
					return typeof(VehicleEntityData).GetProperty(nameof(UseLowAltitudeHeatSignature));

				case 4259780355:
					return typeof(VehicleEntityData).GetProperty(nameof(AllowVehicleOutsideCombatAreas));

				case 1278245411:
					return typeof(VehicleEntityData).GetProperty(nameof(EnableGroundmapLighting));

				case 3803525894:
					return typeof(VehicleEntityData).GetProperty(nameof(MotionBlurMask));

				case 3998576672:
					return typeof(VehicleEntityData).GetProperty(nameof(UseProtectedShields));

				case 2055300591:
					return typeof(VehicleEntityData).GetProperty(nameof(UseDriverEyePosForNametagPos));

				case 3184500446:
					return typeof(VehicleEntityData).GetProperty(nameof(EquipmentFakeVehicle));

				case 2851996027:
					return typeof(VehicleEntityData).GetProperty(nameof(ExplosionPacksAttachable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
