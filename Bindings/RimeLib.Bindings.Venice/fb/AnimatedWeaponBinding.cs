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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 256)]
	public class AnimatedWeaponBinding : FrostbiteContainer
	{
		[ContainerField(Name: "Deploy", Offset: 0, NameHash: 2594816654, Flags: 41)]
		public AntRef Deploy { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "AltDeploy", Offset: 4, NameHash: 4198039607, Flags: 41)]
		public AntRef AltDeploy { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "Undeploy", Offset: 8, NameHash: 2955773173, Flags: 41)]
		public AntRef Undeploy { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "QuickSwitch", Offset: 12, NameHash: 1768907058, Flags: 41)]
		public AntRef QuickSwitch { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "Reload", Offset: 16, NameHash: 3294210644, Flags: 41)]
		public AntRef Reload { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "ReloadShotgun", Offset: 20, NameHash: 2265667496, Flags: 41)]
		public AntRef ReloadShotgun { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "Fire", Offset: 24, NameHash: 2088671869, Flags: 41)]
		public AntRef Fire { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "FireSingle", Offset: 28, NameHash: 4198505383, Flags: 41)]
		public AntRef FireSingle { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(Name: "FireHoldAndRelease", Offset: 32, NameHash: 584417488, Flags: 41)]
		public AntRef FireHoldAndRelease { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(Name: "FireSimple", Offset: 36, NameHash: 4198485907, Flags: 41)]
		public AntRef FireSimple { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(Name: "FirstShotSpawned", Offset: 40, NameHash: 2531638821, Flags: 41)]
		public AntRef FirstShotSpawned { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(Name: "BoltAction", Offset: 44, NameHash: 2541973070, Flags: 41)]
		public AntRef BoltAction { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(Name: "PumpAction", Offset: 48, NameHash: 3655647587, Flags: 41)]
		public AntRef PumpAction { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(Name: "MeleeAttack", Offset: 52, NameHash: 834934665, Flags: 41)]
		public AntRef MeleeAttack { get; set; } = new AntRef(); // 0x34 (52)
		
		[ContainerField(Name: "QuickThrow", Offset: 56, NameHash: 704108118, Flags: 41)]
		public AntRef QuickThrow { get; set; } = new AntRef(); // 0x38 (56)
		
		[ContainerField(Name: "QuickThrowType", Offset: 60, NameHash: 1948331758, Flags: 41)]
		public AntRef QuickThrowType { get; set; } = new AntRef(); // 0x3C (60)
		
		[ContainerField(Name: "AimBody", Offset: 64, NameHash: 731461168, Flags: 41)]
		public AntRef AimBody { get; set; } = new AntRef(); // 0x40 (64)
		
		[ContainerField(Name: "AlwaysAimHead", Offset: 68, NameHash: 3649734905, Flags: 41)]
		public AntRef AlwaysAimHead { get; set; } = new AntRef(); // 0x44 (68)
		
		[ContainerField(Name: "OneHanded", Offset: 72, NameHash: 1335628643, Flags: 41)]
		public AntRef OneHanded { get; set; } = new AntRef(); // 0x48 (72)
		
		[ContainerField(Name: "OneHandedAiming", Offset: 76, NameHash: 1389814790, Flags: 41)]
		public AntRef OneHandedAiming { get; set; } = new AntRef(); // 0x4C (76)
		
		[ContainerField(Name: "AimingEnabled", Offset: 80, NameHash: 2456366725, Flags: 41)]
		public AntRef AimingEnabled { get; set; } = new AntRef(); // 0x50 (80)
		
		[ContainerField(Name: "LowerGun", Offset: 84, NameHash: 2449527962, Flags: 41)]
		public AntRef LowerGun { get; set; } = new AntRef(); // 0x54 (84)
		
		[ContainerField(Name: "BreathControl", Offset: 88, NameHash: 2325792682, Flags: 41)]
		public AntRef BreathControl { get; set; } = new AntRef(); // 0x58 (88)
		
		[ContainerField(Name: "RflType", Offset: 92, NameHash: 1370206533, Flags: 41)]
		public AntRef RflType { get; set; } = new AntRef(); // 0x5C (92)
		
		[ContainerField(Name: "PstlType", Offset: 96, NameHash: 433138886, Flags: 41)]
		public AntRef PstlType { get; set; } = new AntRef(); // 0x60 (96)
		
		[ContainerField(Name: "HgrType", Offset: 100, NameHash: 2250832352, Flags: 41)]
		public AntRef HgrType { get; set; } = new AntRef(); // 0x64 (100)
		
		[ContainerField(Name: "ATType", Offset: 104, NameHash: 2537709960, Flags: 41)]
		public AntRef ATType { get; set; } = new AntRef(); // 0x68 (104)
		
		[ContainerField(Name: "ShgType", Offset: 108, NameHash: 3267688577, Flags: 41)]
		public AntRef ShgType { get; set; } = new AntRef(); // 0x6C (108)
		
		[ContainerField(Name: "LMGType", Offset: 112, NameHash: 4213783803, Flags: 41)]
		public AntRef LMGType { get; set; } = new AntRef(); // 0x70 (112)
		
		[ContainerField(Name: "BagType", Offset: 116, NameHash: 2287261561, Flags: 41)]
		public AntRef BagType { get; set; } = new AntRef(); // 0x74 (116)
		
		[ContainerField(Name: "SnpType", Offset: 120, NameHash: 2869149456, Flags: 41)]
		public AntRef SnpType { get; set; } = new AntRef(); // 0x78 (120)
		
		[ContainerField(Name: "Zoom", Offset: 124, NameHash: 2089658322, Flags: 41)]
		public AntRef Zoom { get; set; } = new AntRef(); // 0x7C (124)
		
		[ContainerField(Name: "AimBodyWeight", Offset: 128, NameHash: 1871842320, Flags: 41)]
		public AntRef AimBodyWeight { get; set; } = new AntRef(); // 0x80 (128)
		
		[ContainerField(Name: "DisableZoomToggleWeight", Offset: 132, NameHash: 830962388, Flags: 41)]
		public AntRef DisableZoomToggleWeight { get; set; } = new AntRef(); // 0x84 (132)
		
		[ContainerField(Name: "ZoomParameter", Offset: 136, NameHash: 3375444059, Flags: 41)]
		public AntRef ZoomParameter { get; set; } = new AntRef(); // 0x88 (136)
		
		[ContainerField(Name: "ZoomScaleFactor", Offset: 140, NameHash: 840793031, Flags: 41)]
		public AntRef ZoomScaleFactor { get; set; } = new AntRef(); // 0x8C (140)
		
		[ContainerField(Name: "Dispersion", Offset: 144, NameHash: 1858542823, Flags: 41)]
		public AntRef Dispersion { get; set; } = new AntRef(); // 0x90 (144)
		
		[ContainerField(Name: "AimTargetPosBody", Offset: 148, NameHash: 1779857261, Flags: 41)]
		public AntRef AimTargetPosBody { get; set; } = new AntRef(); // 0x94 (148)
		
		[ContainerField(Name: "ZoomOutSpeed", Offset: 152, NameHash: 2275851931, Flags: 41)]
		public AntRef ZoomOutSpeed { get; set; } = new AntRef(); // 0x98 (152)
		
		[ContainerField(Name: "ZoomInSpeed", Offset: 156, NameHash: 638313682, Flags: 41)]
		public AntRef ZoomInSpeed { get; set; } = new AntRef(); // 0x9C (156)
		
		[ContainerField(Name: "UnDeploySpeed", Offset: 160, NameHash: 3170443666, Flags: 41)]
		public AntRef UnDeploySpeed { get; set; } = new AntRef(); // 0xA0 (160)
		
		[ContainerField(Name: "DeploySpeed", Offset: 164, NameHash: 2095054953, Flags: 41)]
		public AntRef DeploySpeed { get; set; } = new AntRef(); // 0xA4 (164)
		
		[ContainerField(Name: "LightEnabled", Offset: 168, NameHash: 1653920350, Flags: 41)]
		public AntRef LightEnabled { get; set; } = new AntRef(); // 0xA8 (168)
		
		[ContainerField(Name: "FireModeChanged", Offset: 172, NameHash: 3115352604, Flags: 41)]
		public AntRef FireModeChanged { get; set; } = new AntRef(); // 0xAC (172)
		
		[ContainerField(Name: "AnimType", Offset: 176, NameHash: 1018050646, Flags: 41)]
		public AntRef AnimType { get; set; } = new AntRef(); // 0xB0 (176)
		
		[ContainerField(Name: "GunDown", Offset: 180, NameHash: 3645314635, Flags: 41)]
		public AntRef GunDown { get; set; } = new AntRef(); // 0xB4 (180)
		
		[ContainerField(Name: "NumberOfBulletsLeftInGun", Offset: 184, NameHash: 3212631994, Flags: 41)]
		public AntRef NumberOfBulletsLeftInGun { get; set; } = new AntRef(); // 0xB8 (184)
		
		[ContainerField(Name: "BulletsLeftInGun", Offset: 188, NameHash: 1743038736, Flags: 41)]
		public AntRef BulletsLeftInGun { get; set; } = new AntRef(); // 0xBC (188)
		
		[ContainerField(Name: "AbortVehicleDeploy", Offset: 192, NameHash: 598085148, Flags: 41)]
		public AntRef AbortVehicleDeploy { get; set; } = new AntRef(); // 0xC0 (192)
		
		[ContainerField(Name: "CurrentProjectileIndex", Offset: 196, NameHash: 4293122215, Flags: 41)]
		public AntRef CurrentProjectileIndex { get; set; } = new AntRef(); // 0xC4 (196)
		
		[ContainerField(Name: "WeaponActionESIG", Offset: 200, NameHash: 724796257, Flags: 41)]
		public AntRef WeaponActionESIG { get; set; } = new AntRef(); // 0xC8 (200)
		
		[ContainerField(Name: "IsSprinting", Offset: 204, NameHash: 1831681117, Flags: 41)]
		public AntRef IsSprinting { get; set; } = new AntRef(); // 0xCC (204)
		
		[ContainerField(Name: "PreparingToBash", Offset: 208, NameHash: 3540902146, Flags: 41)]
		public AntRef PreparingToBash { get; set; } = new AntRef(); // 0xD0 (208)
		
		[ContainerField(Name: "JustStartedSprinting", Offset: 212, NameHash: 2041640638, Flags: 41)]
		public AntRef JustStartedSprinting { get; set; } = new AntRef(); // 0xD4 (212)
		
		[ContainerField(Name: "KickBackInIronSight", Offset: 216, NameHash: 2275349528, Flags: 41)]
		public AntRef KickBackInIronSight { get; set; } = new AntRef(); // 0xD8 (216)
		
		[ContainerField(Name: "ZoomingTime", Offset: 220, NameHash: 858178599, Flags: 41)]
		public AntRef ZoomingTime { get; set; } = new AntRef(); // 0xDC (220)
		
		[ContainerField(Name: "TriggerZoomGunTwitch", Offset: 224, NameHash: 1979410083, Flags: 41)]
		public AntRef TriggerZoomGunTwitch { get; set; } = new AntRef(); // 0xE0 (224)
		
		[ContainerField(Name: "WeaponChooserSignal", Offset: 228, NameHash: 2927778678, Flags: 41)]
		public AntRef WeaponChooserSignal { get; set; } = new AntRef(); // 0xE4 (228)
		
		[ContainerField(Name: "WeaponClassSignal", Offset: 232, NameHash: 1218349463, Flags: 41)]
		public AntRef WeaponClassSignal { get; set; } = new AntRef(); // 0xE8 (232)
		
		[ContainerField(Name: "OffsetX", Offset: 236, NameHash: 267273584, Flags: 41)]
		public AntRef OffsetX { get; set; } = new AntRef(); // 0xEC (236)
		
		[ContainerField(Name: "OffsetY", Offset: 240, NameHash: 267273585, Flags: 41)]
		public AntRef OffsetY { get; set; } = new AntRef(); // 0xF0 (240)
		
		[ContainerField(Name: "OffsetZ", Offset: 244, NameHash: 267273586, Flags: 41)]
		public AntRef OffsetZ { get; set; } = new AntRef(); // 0xF4 (244)
		
		[ContainerField(Name: "AIAllowFire", Offset: 248, NameHash: 1490975884, Flags: 41)]
		public AntRef AIAllowFire { get; set; } = new AntRef(); // 0xF8 (248)
		
		[ContainerField(Name: "AIAltFireFromAnt", Offset: 252, NameHash: 2700636449, Flags: 41)]
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
