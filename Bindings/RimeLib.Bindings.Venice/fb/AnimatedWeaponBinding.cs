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
	[ContainerType(4, 256)]
	public class AnimatedWeaponBinding
	{
		[ContainerField(0)]
		public AntRef Deploy { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef AltDeploy { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef Undeploy { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef QuickSwitch { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef Reload { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef ReloadShotgun { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef Fire { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef FireSingle { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef FireHoldAndRelease { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef FireSimple { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef FirstShotSpawned { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef BoltAction { get; set; } = new();
		
		[ContainerField(48)]
		public AntRef PumpAction { get; set; } = new();
		
		[ContainerField(52)]
		public AntRef MeleeAttack { get; set; } = new();
		
		[ContainerField(56)]
		public AntRef QuickThrow { get; set; } = new();
		
		[ContainerField(60)]
		public AntRef QuickThrowType { get; set; } = new();
		
		[ContainerField(64)]
		public AntRef AimBody { get; set; } = new();
		
		[ContainerField(68)]
		public AntRef AlwaysAimHead { get; set; } = new();
		
		[ContainerField(72)]
		public AntRef OneHanded { get; set; } = new();
		
		[ContainerField(76)]
		public AntRef OneHandedAiming { get; set; } = new();
		
		[ContainerField(80)]
		public AntRef AimingEnabled { get; set; } = new();
		
		[ContainerField(84)]
		public AntRef LowerGun { get; set; } = new();
		
		[ContainerField(88)]
		public AntRef BreathControl { get; set; } = new();
		
		[ContainerField(92)]
		public AntRef RflType { get; set; } = new();
		
		[ContainerField(96)]
		public AntRef PstlType { get; set; } = new();
		
		[ContainerField(100)]
		public AntRef HgrType { get; set; } = new();
		
		[ContainerField(104)]
		public AntRef ATType { get; set; } = new();
		
		[ContainerField(108)]
		public AntRef ShgType { get; set; } = new();
		
		[ContainerField(112)]
		public AntRef LMGType { get; set; } = new();
		
		[ContainerField(116)]
		public AntRef BagType { get; set; } = new();
		
		[ContainerField(120)]
		public AntRef SnpType { get; set; } = new();
		
		[ContainerField(124)]
		public AntRef Zoom { get; set; } = new();
		
		[ContainerField(128)]
		public AntRef AimBodyWeight { get; set; } = new();
		
		[ContainerField(132)]
		public AntRef DisableZoomToggleWeight { get; set; } = new();
		
		[ContainerField(136)]
		public AntRef ZoomParameter { get; set; } = new();
		
		[ContainerField(140)]
		public AntRef ZoomScaleFactor { get; set; } = new();
		
		[ContainerField(144)]
		public AntRef Dispersion { get; set; } = new();
		
		[ContainerField(148)]
		public AntRef AimTargetPosBody { get; set; } = new();
		
		[ContainerField(152)]
		public AntRef ZoomOutSpeed { get; set; } = new();
		
		[ContainerField(156)]
		public AntRef ZoomInSpeed { get; set; } = new();
		
		[ContainerField(160)]
		public AntRef UnDeploySpeed { get; set; } = new();
		
		[ContainerField(164)]
		public AntRef DeploySpeed { get; set; } = new();
		
		[ContainerField(168)]
		public AntRef LightEnabled { get; set; } = new();
		
		[ContainerField(172)]
		public AntRef FireModeChanged { get; set; } = new();
		
		[ContainerField(176)]
		public AntRef AnimType { get; set; } = new();
		
		[ContainerField(180)]
		public AntRef GunDown { get; set; } = new();
		
		[ContainerField(184)]
		public AntRef NumberOfBulletsLeftInGun { get; set; } = new();
		
		[ContainerField(188)]
		public AntRef BulletsLeftInGun { get; set; } = new();
		
		[ContainerField(192)]
		public AntRef AbortVehicleDeploy { get; set; } = new();
		
		[ContainerField(196)]
		public AntRef CurrentProjectileIndex { get; set; } = new();
		
		[ContainerField(200)]
		public AntRef WeaponActionESIG { get; set; } = new();
		
		[ContainerField(204)]
		public AntRef IsSprinting { get; set; } = new();
		
		[ContainerField(208)]
		public AntRef PreparingToBash { get; set; } = new();
		
		[ContainerField(212)]
		public AntRef JustStartedSprinting { get; set; } = new();
		
		[ContainerField(216)]
		public AntRef KickBackInIronSight { get; set; } = new();
		
		[ContainerField(220)]
		public AntRef ZoomingTime { get; set; } = new();
		
		[ContainerField(224)]
		public AntRef TriggerZoomGunTwitch { get; set; } = new();
		
		[ContainerField(228)]
		public AntRef WeaponChooserSignal { get; set; } = new();
		
		[ContainerField(232)]
		public AntRef WeaponClassSignal { get; set; } = new();
		
		[ContainerField(236)]
		public AntRef OffsetX { get; set; } = new();
		
		[ContainerField(240)]
		public AntRef OffsetY { get; set; } = new();
		
		[ContainerField(244)]
		public AntRef OffsetZ { get; set; } = new();
		
		[ContainerField(248)]
		public AntRef AIAllowFire { get; set; } = new();
		
		[ContainerField(252)]
		public AntRef AIAltFireFromAnt { get; set; } = new();
		
	}
}
