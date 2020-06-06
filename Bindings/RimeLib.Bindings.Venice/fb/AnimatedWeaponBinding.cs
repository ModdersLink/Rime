///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AnimatedWeaponBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef Deploy { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef AltDeploy { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef Undeploy { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef QuickSwitch { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef Reload { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef ReloadShotgun { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef Fire { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28)]
		public AntRef FireSingle { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32)]
		public AntRef FireHoldAndRelease { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(36)]
		public AntRef FireSimple { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(40)]
		public AntRef FirstShotSpawned { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(44)]
		public AntRef BoltAction { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(48)]
		public AntRef PumpAction { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(52)]
		public AntRef MeleeAttack { get; set; } = new AntRef(); // 0x34 (52)
		
		[ContainerField(56)]
		public AntRef QuickThrow { get; set; } = new AntRef(); // 0x38 (56)
		
		[ContainerField(60)]
		public AntRef QuickThrowType { get; set; } = new AntRef(); // 0x3C (60)
		
		[ContainerField(64)]
		public AntRef AimBody { get; set; } = new AntRef(); // 0x40 (64)
		
		[ContainerField(68)]
		public AntRef AlwaysAimHead { get; set; } = new AntRef(); // 0x44 (68)
		
		[ContainerField(72)]
		public AntRef OneHanded { get; set; } = new AntRef(); // 0x48 (72)
		
		[ContainerField(76)]
		public AntRef OneHandedAiming { get; set; } = new AntRef(); // 0x4C (76)
		
		[ContainerField(80)]
		public AntRef AimingEnabled { get; set; } = new AntRef(); // 0x50 (80)
		
		[ContainerField(84)]
		public AntRef LowerGun { get; set; } = new AntRef(); // 0x54 (84)
		
		[ContainerField(88)]
		public AntRef BreathControl { get; set; } = new AntRef(); // 0x58 (88)
		
		[ContainerField(92)]
		public AntRef RflType { get; set; } = new AntRef(); // 0x5C (92)
		
		[ContainerField(96)]
		public AntRef PstlType { get; set; } = new AntRef(); // 0x60 (96)
		
		[ContainerField(100)]
		public AntRef HgrType { get; set; } = new AntRef(); // 0x64 (100)
		
		[ContainerField(104)]
		public AntRef ATType { get; set; } = new AntRef(); // 0x68 (104)
		
		[ContainerField(108)]
		public AntRef ShgType { get; set; } = new AntRef(); // 0x6C (108)
		
		[ContainerField(112)]
		public AntRef LMGType { get; set; } = new AntRef(); // 0x70 (112)
		
		[ContainerField(116)]
		public AntRef BagType { get; set; } = new AntRef(); // 0x74 (116)
		
		[ContainerField(120)]
		public AntRef SnpType { get; set; } = new AntRef(); // 0x78 (120)
		
		[ContainerField(124)]
		public AntRef Zoom { get; set; } = new AntRef(); // 0x7C (124)
		
		[ContainerField(128)]
		public AntRef AimBodyWeight { get; set; } = new AntRef(); // 0x80 (128)
		
		[ContainerField(132)]
		public AntRef DisableZoomToggleWeight { get; set; } = new AntRef(); // 0x84 (132)
		
		[ContainerField(136)]
		public AntRef ZoomParameter { get; set; } = new AntRef(); // 0x88 (136)
		
		[ContainerField(140)]
		public AntRef ZoomScaleFactor { get; set; } = new AntRef(); // 0x8C (140)
		
		[ContainerField(144)]
		public AntRef Dispersion { get; set; } = new AntRef(); // 0x90 (144)
		
		[ContainerField(148)]
		public AntRef AimTargetPosBody { get; set; } = new AntRef(); // 0x94 (148)
		
		[ContainerField(152)]
		public AntRef ZoomOutSpeed { get; set; } = new AntRef(); // 0x98 (152)
		
		[ContainerField(156)]
		public AntRef ZoomInSpeed { get; set; } = new AntRef(); // 0x9C (156)
		
		[ContainerField(160)]
		public AntRef UnDeploySpeed { get; set; } = new AntRef(); // 0xA0 (160)
		
		[ContainerField(164)]
		public AntRef DeploySpeed { get; set; } = new AntRef(); // 0xA4 (164)
		
		[ContainerField(168)]
		public AntRef LightEnabled { get; set; } = new AntRef(); // 0xA8 (168)
		
		[ContainerField(172)]
		public AntRef FireModeChanged { get; set; } = new AntRef(); // 0xAC (172)
		
		[ContainerField(176)]
		public AntRef AnimType { get; set; } = new AntRef(); // 0xB0 (176)
		
		[ContainerField(180)]
		public AntRef GunDown { get; set; } = new AntRef(); // 0xB4 (180)
		
		[ContainerField(184)]
		public AntRef NumberOfBulletsLeftInGun { get; set; } = new AntRef(); // 0xB8 (184)
		
		[ContainerField(188)]
		public AntRef BulletsLeftInGun { get; set; } = new AntRef(); // 0xBC (188)
		
		[ContainerField(192)]
		public AntRef AbortVehicleDeploy { get; set; } = new AntRef(); // 0xC0 (192)
		
		[ContainerField(196)]
		public AntRef CurrentProjectileIndex { get; set; } = new AntRef(); // 0xC4 (196)
		
		[ContainerField(200)]
		public AntRef WeaponActionESIG { get; set; } = new AntRef(); // 0xC8 (200)
		
		[ContainerField(204)]
		public AntRef IsSprinting { get; set; } = new AntRef(); // 0xCC (204)
		
		[ContainerField(208)]
		public AntRef PreparingToBash { get; set; } = new AntRef(); // 0xD0 (208)
		
		[ContainerField(212)]
		public AntRef JustStartedSprinting { get; set; } = new AntRef(); // 0xD4 (212)
		
		[ContainerField(216)]
		public AntRef KickBackInIronSight { get; set; } = new AntRef(); // 0xD8 (216)
		
		[ContainerField(220)]
		public AntRef ZoomingTime { get; set; } = new AntRef(); // 0xDC (220)
		
		[ContainerField(224)]
		public AntRef TriggerZoomGunTwitch { get; set; } = new AntRef(); // 0xE0 (224)
		
		[ContainerField(228)]
		public AntRef WeaponChooserSignal { get; set; } = new AntRef(); // 0xE4 (228)
		
		[ContainerField(232)]
		public AntRef WeaponClassSignal { get; set; } = new AntRef(); // 0xE8 (232)
		
		[ContainerField(236)]
		public AntRef OffsetX { get; set; } = new AntRef(); // 0xEC (236)
		
		[ContainerField(240)]
		public AntRef OffsetY { get; set; } = new AntRef(); // 0xF0 (240)
		
		[ContainerField(244)]
		public AntRef OffsetZ { get; set; } = new AntRef(); // 0xF4 (244)
		
		[ContainerField(248)]
		public AntRef AIAllowFire { get; set; } = new AntRef(); // 0xF8 (248)
		
		[ContainerField(252)]
		public AntRef AIAltFireFromAnt { get; set; } = new AntRef(); // 0xFC (252)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2594816654:
					Deploy = (AntRef) p_Value;
					break;

				case 4198039607:
					AltDeploy = (AntRef) p_Value;
					break;

				case 2955773173:
					Undeploy = (AntRef) p_Value;
					break;

				case 1768907058:
					QuickSwitch = (AntRef) p_Value;
					break;

				case 3294210644:
					Reload = (AntRef) p_Value;
					break;

				case 2265667496:
					ReloadShotgun = (AntRef) p_Value;
					break;

				case 2088671869:
					Fire = (AntRef) p_Value;
					break;

				case 4198505383:
					FireSingle = (AntRef) p_Value;
					break;

				case 584417488:
					FireHoldAndRelease = (AntRef) p_Value;
					break;

				case 4198485907:
					FireSimple = (AntRef) p_Value;
					break;

				case 2531638821:
					FirstShotSpawned = (AntRef) p_Value;
					break;

				case 2541973070:
					BoltAction = (AntRef) p_Value;
					break;

				case 3655647587:
					PumpAction = (AntRef) p_Value;
					break;

				case 834934665:
					MeleeAttack = (AntRef) p_Value;
					break;

				case 704108118:
					QuickThrow = (AntRef) p_Value;
					break;

				case 1948331758:
					QuickThrowType = (AntRef) p_Value;
					break;

				case 731461168:
					AimBody = (AntRef) p_Value;
					break;

				case 3649734905:
					AlwaysAimHead = (AntRef) p_Value;
					break;

				case 1335628643:
					OneHanded = (AntRef) p_Value;
					break;

				case 1389814790:
					OneHandedAiming = (AntRef) p_Value;
					break;

				case 2456366725:
					AimingEnabled = (AntRef) p_Value;
					break;

				case 2449527962:
					LowerGun = (AntRef) p_Value;
					break;

				case 2325792682:
					BreathControl = (AntRef) p_Value;
					break;

				case 1370206533:
					RflType = (AntRef) p_Value;
					break;

				case 433138886:
					PstlType = (AntRef) p_Value;
					break;

				case 2250832352:
					HgrType = (AntRef) p_Value;
					break;

				case 2537709960:
					ATType = (AntRef) p_Value;
					break;

				case 3267688577:
					ShgType = (AntRef) p_Value;
					break;

				case 4213783803:
					LMGType = (AntRef) p_Value;
					break;

				case 2287261561:
					BagType = (AntRef) p_Value;
					break;

				case 2869149456:
					SnpType = (AntRef) p_Value;
					break;

				case 2089658322:
					Zoom = (AntRef) p_Value;
					break;

				case 1871842320:
					AimBodyWeight = (AntRef) p_Value;
					break;

				case 830962388:
					DisableZoomToggleWeight = (AntRef) p_Value;
					break;

				case 3375444059:
					ZoomParameter = (AntRef) p_Value;
					break;

				case 840793031:
					ZoomScaleFactor = (AntRef) p_Value;
					break;

				case 1858542823:
					Dispersion = (AntRef) p_Value;
					break;

				case 1779857261:
					AimTargetPosBody = (AntRef) p_Value;
					break;

				case 2275851931:
					ZoomOutSpeed = (AntRef) p_Value;
					break;

				case 638313682:
					ZoomInSpeed = (AntRef) p_Value;
					break;

				case 3170443666:
					UnDeploySpeed = (AntRef) p_Value;
					break;

				case 2095054953:
					DeploySpeed = (AntRef) p_Value;
					break;

				case 1653920350:
					LightEnabled = (AntRef) p_Value;
					break;

				case 3115352604:
					FireModeChanged = (AntRef) p_Value;
					break;

				case 1018050646:
					AnimType = (AntRef) p_Value;
					break;

				case 3645314635:
					GunDown = (AntRef) p_Value;
					break;

				case 3212631994:
					NumberOfBulletsLeftInGun = (AntRef) p_Value;
					break;

				case 1743038736:
					BulletsLeftInGun = (AntRef) p_Value;
					break;

				case 598085148:
					AbortVehicleDeploy = (AntRef) p_Value;
					break;

				case 4293122215:
					CurrentProjectileIndex = (AntRef) p_Value;
					break;

				case 724796257:
					WeaponActionESIG = (AntRef) p_Value;
					break;

				case 1831681117:
					IsSprinting = (AntRef) p_Value;
					break;

				case 3540902146:
					PreparingToBash = (AntRef) p_Value;
					break;

				case 2041640638:
					JustStartedSprinting = (AntRef) p_Value;
					break;

				case 2275349528:
					KickBackInIronSight = (AntRef) p_Value;
					break;

				case 858178599:
					ZoomingTime = (AntRef) p_Value;
					break;

				case 1979410083:
					TriggerZoomGunTwitch = (AntRef) p_Value;
					break;

				case 2927778678:
					WeaponChooserSignal = (AntRef) p_Value;
					break;

				case 1218349463:
					WeaponClassSignal = (AntRef) p_Value;
					break;

				case 267273584:
					OffsetX = (AntRef) p_Value;
					break;

				case 267273585:
					OffsetY = (AntRef) p_Value;
					break;

				case 267273586:
					OffsetZ = (AntRef) p_Value;
					break;

				case 1490975884:
					AIAllowFire = (AntRef) p_Value;
					break;

				case 2700636449:
					AIAltFireFromAnt = (AntRef) p_Value;
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
				case 2594816654:
					return Deploy;

				case 4198039607:
					return AltDeploy;

				case 2955773173:
					return Undeploy;

				case 1768907058:
					return QuickSwitch;

				case 3294210644:
					return Reload;

				case 2265667496:
					return ReloadShotgun;

				case 2088671869:
					return Fire;

				case 4198505383:
					return FireSingle;

				case 584417488:
					return FireHoldAndRelease;

				case 4198485907:
					return FireSimple;

				case 2531638821:
					return FirstShotSpawned;

				case 2541973070:
					return BoltAction;

				case 3655647587:
					return PumpAction;

				case 834934665:
					return MeleeAttack;

				case 704108118:
					return QuickThrow;

				case 1948331758:
					return QuickThrowType;

				case 731461168:
					return AimBody;

				case 3649734905:
					return AlwaysAimHead;

				case 1335628643:
					return OneHanded;

				case 1389814790:
					return OneHandedAiming;

				case 2456366725:
					return AimingEnabled;

				case 2449527962:
					return LowerGun;

				case 2325792682:
					return BreathControl;

				case 1370206533:
					return RflType;

				case 433138886:
					return PstlType;

				case 2250832352:
					return HgrType;

				case 2537709960:
					return ATType;

				case 3267688577:
					return ShgType;

				case 4213783803:
					return LMGType;

				case 2287261561:
					return BagType;

				case 2869149456:
					return SnpType;

				case 2089658322:
					return Zoom;

				case 1871842320:
					return AimBodyWeight;

				case 830962388:
					return DisableZoomToggleWeight;

				case 3375444059:
					return ZoomParameter;

				case 840793031:
					return ZoomScaleFactor;

				case 1858542823:
					return Dispersion;

				case 1779857261:
					return AimTargetPosBody;

				case 2275851931:
					return ZoomOutSpeed;

				case 638313682:
					return ZoomInSpeed;

				case 3170443666:
					return UnDeploySpeed;

				case 2095054953:
					return DeploySpeed;

				case 1653920350:
					return LightEnabled;

				case 3115352604:
					return FireModeChanged;

				case 1018050646:
					return AnimType;

				case 3645314635:
					return GunDown;

				case 3212631994:
					return NumberOfBulletsLeftInGun;

				case 1743038736:
					return BulletsLeftInGun;

				case 598085148:
					return AbortVehicleDeploy;

				case 4293122215:
					return CurrentProjectileIndex;

				case 724796257:
					return WeaponActionESIG;

				case 1831681117:
					return IsSprinting;

				case 3540902146:
					return PreparingToBash;

				case 2041640638:
					return JustStartedSprinting;

				case 2275349528:
					return KickBackInIronSight;

				case 858178599:
					return ZoomingTime;

				case 1979410083:
					return TriggerZoomGunTwitch;

				case 2927778678:
					return WeaponChooserSignal;

				case 1218349463:
					return WeaponClassSignal;

				case 267273584:
					return OffsetX;

				case 267273585:
					return OffsetY;

				case 267273586:
					return OffsetZ;

				case 1490975884:
					return AIAllowFire;

				case 2700636449:
					return AIAltFireFromAnt;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2594816654:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(Deploy));

				case 4198039607:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AltDeploy));

				case 2955773173:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(Undeploy));

				case 1768907058:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(QuickSwitch));

				case 3294210644:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(Reload));

				case 2265667496:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ReloadShotgun));

				case 2088671869:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(Fire));

				case 4198505383:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(FireSingle));

				case 584417488:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(FireHoldAndRelease));

				case 4198485907:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(FireSimple));

				case 2531638821:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(FirstShotSpawned));

				case 2541973070:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(BoltAction));

				case 3655647587:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(PumpAction));

				case 834934665:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(MeleeAttack));

				case 704108118:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(QuickThrow));

				case 1948331758:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(QuickThrowType));

				case 731461168:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AimBody));

				case 3649734905:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AlwaysAimHead));

				case 1335628643:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(OneHanded));

				case 1389814790:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(OneHandedAiming));

				case 2456366725:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AimingEnabled));

				case 2449527962:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(LowerGun));

				case 2325792682:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(BreathControl));

				case 1370206533:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(RflType));

				case 433138886:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(PstlType));

				case 2250832352:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(HgrType));

				case 2537709960:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ATType));

				case 3267688577:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ShgType));

				case 4213783803:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(LMGType));

				case 2287261561:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(BagType));

				case 2869149456:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(SnpType));

				case 2089658322:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(Zoom));

				case 1871842320:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AimBodyWeight));

				case 830962388:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(DisableZoomToggleWeight));

				case 3375444059:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ZoomParameter));

				case 840793031:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ZoomScaleFactor));

				case 1858542823:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(Dispersion));

				case 1779857261:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AimTargetPosBody));

				case 2275851931:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ZoomOutSpeed));

				case 638313682:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ZoomInSpeed));

				case 3170443666:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(UnDeploySpeed));

				case 2095054953:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(DeploySpeed));

				case 1653920350:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(LightEnabled));

				case 3115352604:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(FireModeChanged));

				case 1018050646:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AnimType));

				case 3645314635:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(GunDown));

				case 3212631994:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(NumberOfBulletsLeftInGun));

				case 1743038736:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(BulletsLeftInGun));

				case 598085148:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AbortVehicleDeploy));

				case 4293122215:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(CurrentProjectileIndex));

				case 724796257:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(WeaponActionESIG));

				case 1831681117:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(IsSprinting));

				case 3540902146:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(PreparingToBash));

				case 2041640638:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(JustStartedSprinting));

				case 2275349528:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(KickBackInIronSight));

				case 858178599:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(ZoomingTime));

				case 1979410083:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(TriggerZoomGunTwitch));

				case 2927778678:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(WeaponChooserSignal));

				case 1218349463:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(WeaponClassSignal));

				case 267273584:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(OffsetX));

				case 267273585:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(OffsetY));

				case 267273586:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(OffsetZ));

				case 1490975884:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AIAllowFire));

				case 2700636449:
					return typeof(AnimatedWeaponBinding).GetProperty(nameof(AIAltFireFromAnt));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
