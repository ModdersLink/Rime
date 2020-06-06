///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class VehicleEntityData : 
		ControllableEntityData
	{
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CriticallyDamagedEffectPosition { get; set; } = new Vec3(); // 0x90 (144)
		
		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FLIRKeyColor { get; set; } = new Vec3(); // 0xA0 (160)
		
		[ContainerField(176), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 PreExplosionEffectPosition { get; set; } = new Vec3(); // 0xB0 (176)
		
		[ContainerField(192), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 InteractionOffset { get; set; } = new Vec3(); // 0xC0 (192)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float DisabledDamageThreshold { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable]
		public string ControllableType { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float PreDestructionDamageThreshold { get; set; } // 0xD8 (216)
		
		[ContainerField(220)]
		public VehicleHealthZoneData RearHealthZone { get; set; } = new VehicleHealthZoneData(); // 0xDC (220)
		
		[ContainerField(240)]
		public VehicleHealthZoneData LeftHealthZone { get; set; } = new VehicleHealthZoneData(); // 0xF0 (240)
		
		[ContainerField(260)]
		public VehicleHealthZoneData RightHealthZone { get; set; } = new VehicleHealthZoneData(); // 0x104 (260)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public float MinSpeedForMineActivation { get; set; } // 0x118 (280)
		
		[ContainerField(284)]
		public VehicleHealthZoneData FrontHealthZone { get; set; } = new VehicleHealthZoneData(); // 0x11C (284)
		
		[ContainerField(304), LayoutImmutable, Blittable]
		public float UpsideDownDamage { get; set; } // 0x130 (304)
		
		[ContainerField(308), LayoutImmutable, Blittable]
		public float WaterDamageOffset { get; set; } // 0x134 (308)
		
		[ContainerField(312), LayoutImmutable, Blittable]
		public float ArmorMultiplier { get; set; } // 0x138 (312)
		
		[ContainerField(316), LayoutImmutable, Blittable]
		public float RegenerationDelayMultiplier { get; set; } // 0x13C (316)
		
		[ContainerField(320), LayoutImmutable, Blittable]
		public float RegenerationRateMultiplier { get; set; } // 0x140 (320)
		
		[ContainerField(324), LayoutImmutable, Blittable]
		public float EmergencyRepairHealth { get; set; } // 0x144 (324)
		
		[ContainerField(328), LayoutImmutable, Blittable]
		public float DecayDelay { get; set; } // 0x148 (328)
		
		[ContainerField(332), LayoutImmutable, Blittable]
		public float DecayRate { get; set; } // 0x14C (332)
		
		[ContainerField(336), LayoutImmutable, Blittable]
		public float BelowWaterDamageDelay { get; set; } // 0x150 (336)
		
		[ContainerField(340)]
		public CtrRef<EffectBlueprint> CriticallyDamagedEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x154 (340)
		
		[ContainerField(344), LayoutImmutable, Blittable]
		public float RegenerationRate { get; set; } // 0x158 (344)
		
		[ContainerField(348), LayoutImmutable, Blittable]
		public float CriticalDamageTime { get; set; } // 0x15C (348)
		
		[ContainerField(352)]
		public CtrRef<EffectBlueprint> PreExplosionEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x160 (352)
		
		[ContainerField(356), LayoutImmutable, Blittable]
		public float RegenerationDelay { get; set; } // 0x164 (356)
		
		[ContainerField(360), LayoutImmutable, Blittable]
		public float PreExplosionTime { get; set; } // 0x168 (360)
		
		[ContainerField(364)]
		public CtrRef<ExplosionEntityData> Explosion { get; set; } = new CtrRef<ExplosionEntityData>(); // 0x16C (364)
		
		[ContainerField(368)]
		public CtrRef<CompositeMeshAsset> Mesh { get; set; } = new CtrRef<CompositeMeshAsset>(); // 0x170 (368)
		
		[ContainerField(372)]
		public CtrRef<ObjectBlueprint> CockpitMesh { get; set; } = new CtrRef<ObjectBlueprint>(); // 0x174 (372)
		
		[ContainerField(376), LayoutImmutable, Blittable]
		public float VelocityDamageMagnifier { get; set; } // 0x178 (376)
		
		[ContainerField(380), LayoutImmutable, Blittable]
		public float ExitSpeedThreshold { get; set; } // 0x17C (380)
		
		[ContainerField(384)]
		public VehicleHudData HudData { get; set; } = new VehicleHudData(); // 0x180 (384)
		
		[ContainerField(416), LayoutImmutable]
		public string NameSid { get; set; } // 0x1A0 (416)
		
		[ContainerField(420), LayoutImmutable, Blittable]
		public int MaxPlayersInVehicle { get; set; } // 0x1A4 (420)
		
		[ContainerField(424), LayoutImmutable, Blittable]
		public float NametagHeightScale { get; set; } // 0x1A8 (424)
		
		[ContainerField(428)]
		public CtrRef<VehicleSoundData> Sound { get; set; } = new CtrRef<VehicleSoundData>(); // 0x1AC (428)
		
		[ContainerField(432), LayoutImmutable, Blittable]
		public float UpsideDownDamageDelay { get; set; } // 0x1B0 (432)
		
		[ContainerField(436), LayoutImmutable, Blittable]
		public float UpsideDownAngle { get; set; } // 0x1B4 (436)
		
		[ContainerField(440), LayoutImmutable, Blittable]
		public float WaterDamage { get; set; } // 0x1B8 (440)
		
		[ContainerField(444), LayoutImmutable, Blittable]
		public float LockingTimeMultiplier { get; set; } // 0x1BC (444)
		
		[ContainerField(448), LayoutImmutable, Blittable]
		public float NametagHeightOffset { get; set; } // 0x1C0 (448)
		
		[ContainerField(452), LayoutImmutable, Blittable]
		public float HighAltitudeLockHeight { get; set; } // 0x1C4 (452)
		
		[ContainerField(456), LayoutImmutable, Blittable]
		public float VelocityDamageThreshold { get; set; } // 0x1C8 (456)
		
		[ContainerField(460)]
		public CtrRef<EntityVoiceOverInfo> VoiceOverInfo { get; set; } = new CtrRef<EntityVoiceOverInfo>(); // 0x1CC (460)
		
		[ContainerField(464), LayoutImmutable, Blittable]
		public float ExitCameraSwitchDelay { get; set; } // 0x1D0 (464)
		
		[ContainerField(468), LayoutImmutable, Blittable]
		public float KillSoldierCollisionSpeedThreshold { get; set; } // 0x1D4 (468)
		
		[ContainerField(472), LayoutImmutable, Blittable]
		public float ExitDirectionSpeedThreshold { get; set; } // 0x1D8 (472)
		
		[ContainerField(476)]
		public AngleOfImpactData AngleOfImpact { get; set; } = new AngleOfImpactData(); // 0x1DC (476)
		
		[ContainerField(500)]
		public VehicleLockableInfoData VehicleLockableInfo { get; set; } = new VehicleLockableInfoData(); // 0x1F4 (500)
		
		[ContainerField(516), LayoutImmutable, Blittable]
		public float FLIRValue { get; set; } // 0x204 (516)
		
		[ContainerField(520)]
		public MPModeData MPMode { get; set; } = new MPModeData(); // 0x208 (520)
		
		[ContainerField(524), LayoutImmutable, Blittable]
		public bool IgnoreSoldierCollisionNormal { get; set; } // 0x20C (524)
		
		[ContainerField(525), LayoutImmutable, Blittable]
		public bool ShowPlayerHealth { get; set; } // 0x20D (525)
		
		[ContainerField(526), LayoutImmutable, Blittable]
		public bool ForegroundRenderCockpitMesh { get; set; } // 0x20E (526)
		
		[ContainerField(527), LayoutImmutable, Blittable]
		public bool RenderVehicleMesh { get; set; } // 0x20F (527)
		
		[ContainerField(528), LayoutImmutable, Blittable]
		public bool IsAffectedByEMP { get; set; } // 0x210 (528)
		
		[ContainerField(529), LayoutImmutable, Blittable]
		public bool ThrowOutSoldierInsideOnWaterDamage { get; set; } // 0x211 (529)
		
		[ContainerField(530), LayoutImmutable, Blittable]
		public bool UseAsTeamSpawner { get; set; } // 0x212 (530)
		
		[ContainerField(531), LayoutImmutable, Blittable]
		public bool IsLockable { get; set; } // 0x213 (531)
		
		[ContainerField(532), LayoutImmutable, Blittable]
		public bool ChoseExitPointByDirection { get; set; } // 0x214 (532)
		
		[ContainerField(533), LayoutImmutable, Blittable]
		public bool HealthZonesShareDamage { get; set; } // 0x215 (533)
		
		[ContainerField(534), LayoutImmutable, Blittable]
		public bool NeverReportVehicleAsEmpty { get; set; } // 0x216 (534)
		
		[ContainerField(535), LayoutImmutable, Blittable]
		public bool ExitAllowed { get; set; } // 0x217 (535)
		
		[ContainerField(536), LayoutImmutable, Blittable]
		public bool UseLowAltitudeHeatSignature { get; set; } // 0x218 (536)
		
		[ContainerField(537), LayoutImmutable, Blittable]
		public bool AllowVehicleOutsideCombatAreas { get; set; } // 0x219 (537)
		
		[ContainerField(538), LayoutImmutable, Blittable]
		public bool EnableGroundmapLighting { get; set; } // 0x21A (538)
		
		[ContainerField(539), LayoutImmutable, Blittable]
		public bool MotionBlurMask { get; set; } // 0x21B (539)
		
		[ContainerField(540), LayoutImmutable, Blittable]
		public bool UseProtectedShields { get; set; } // 0x21C (540)
		
		[ContainerField(541), LayoutImmutable, Blittable]
		public bool UseDriverEyePosForNametagPos { get; set; } // 0x21D (541)
		
		[ContainerField(542), LayoutImmutable, Blittable]
		public bool EquipmentFakeVehicle { get; set; } // 0x21E (542)
		
		[ContainerField(543), LayoutImmutable, Blittable]
		public bool ExplosionPacksAttachable { get; set; } // 0x21F (543)
		
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
