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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 256)]
	public class AnimatedWeaponBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef Deploy { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef AltDeploy { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef Undeploy { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef QuickSwitch { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef Reload { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef ReloadShotgun { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef Fire { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef FireSingle { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef FireHoldAndRelease { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef FireSimple { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public AntRef FirstShotSpawned { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public AntRef BoltAction { get; set; } = new();
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AntRef PumpAction { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntRef MeleeAttack { get; set; } = new();
		
		[ContainerField(56), JsonProperty(Order = 56)]
		public AntRef QuickThrow { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public AntRef QuickThrowType { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AntRef AimBody { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public AntRef AlwaysAimHead { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public AntRef OneHanded { get; set; } = new();
		
		[ContainerField(76), JsonProperty(Order = 76)]
		public AntRef OneHandedAiming { get; set; } = new();
		
		[ContainerField(80), JsonProperty(Order = 80)]
		public AntRef AimingEnabled { get; set; } = new();
		
		[ContainerField(84), JsonProperty(Order = 84)]
		public AntRef LowerGun { get; set; } = new();
		
		[ContainerField(88), JsonProperty(Order = 88)]
		public AntRef BreathControl { get; set; } = new();
		
		[ContainerField(92), JsonProperty(Order = 92)]
		public AntRef RflType { get; set; } = new();
		
		[ContainerField(96), JsonProperty(Order = 96)]
		public AntRef PstlType { get; set; } = new();
		
		[ContainerField(100), JsonProperty(Order = 100)]
		public AntRef HgrType { get; set; } = new();
		
		[ContainerField(104), JsonProperty(Order = 104)]
		public AntRef ATType { get; set; } = new();
		
		[ContainerField(108), JsonProperty(Order = 108)]
		public AntRef ShgType { get; set; } = new();
		
		[ContainerField(112), JsonProperty(Order = 112)]
		public AntRef LMGType { get; set; } = new();
		
		[ContainerField(116), JsonProperty(Order = 116)]
		public AntRef BagType { get; set; } = new();
		
		[ContainerField(120), JsonProperty(Order = 120)]
		public AntRef SnpType { get; set; } = new();
		
		[ContainerField(124), JsonProperty(Order = 124)]
		public AntRef Zoom { get; set; } = new();
		
		[ContainerField(128), JsonProperty(Order = 128)]
		public AntRef AimBodyWeight { get; set; } = new();
		
		[ContainerField(132), JsonProperty(Order = 132)]
		public AntRef DisableZoomToggleWeight { get; set; } = new();
		
		[ContainerField(136), JsonProperty(Order = 136)]
		public AntRef ZoomParameter { get; set; } = new();
		
		[ContainerField(140), JsonProperty(Order = 140)]
		public AntRef ZoomScaleFactor { get; set; } = new();
		
		[ContainerField(144), JsonProperty(Order = 144)]
		public AntRef Dispersion { get; set; } = new();
		
		[ContainerField(148), JsonProperty(Order = 148)]
		public AntRef AimTargetPosBody { get; set; } = new();
		
		[ContainerField(152), JsonProperty(Order = 152)]
		public AntRef ZoomOutSpeed { get; set; } = new();
		
		[ContainerField(156), JsonProperty(Order = 156)]
		public AntRef ZoomInSpeed { get; set; } = new();
		
		[ContainerField(160), JsonProperty(Order = 160)]
		public AntRef UnDeploySpeed { get; set; } = new();
		
		[ContainerField(164), JsonProperty(Order = 164)]
		public AntRef DeploySpeed { get; set; } = new();
		
		[ContainerField(168), JsonProperty(Order = 168)]
		public AntRef LightEnabled { get; set; } = new();
		
		[ContainerField(172), JsonProperty(Order = 172)]
		public AntRef FireModeChanged { get; set; } = new();
		
		[ContainerField(176), JsonProperty(Order = 176)]
		public AntRef AnimType { get; set; } = new();
		
		[ContainerField(180), JsonProperty(Order = 180)]
		public AntRef GunDown { get; set; } = new();
		
		[ContainerField(184), JsonProperty(Order = 184)]
		public AntRef NumberOfBulletsLeftInGun { get; set; } = new();
		
		[ContainerField(188), JsonProperty(Order = 188)]
		public AntRef BulletsLeftInGun { get; set; } = new();
		
		[ContainerField(192), JsonProperty(Order = 192)]
		public AntRef AbortVehicleDeploy { get; set; } = new();
		
		[ContainerField(196), JsonProperty(Order = 196)]
		public AntRef CurrentProjectileIndex { get; set; } = new();
		
		[ContainerField(200), JsonProperty(Order = 200)]
		public AntRef WeaponActionESIG { get; set; } = new();
		
		[ContainerField(204), JsonProperty(Order = 204)]
		public AntRef IsSprinting { get; set; } = new();
		
		[ContainerField(208), JsonProperty(Order = 208)]
		public AntRef PreparingToBash { get; set; } = new();
		
		[ContainerField(212), JsonProperty(Order = 212)]
		public AntRef JustStartedSprinting { get; set; } = new();
		
		[ContainerField(216), JsonProperty(Order = 216)]
		public AntRef KickBackInIronSight { get; set; } = new();
		
		[ContainerField(220), JsonProperty(Order = 220)]
		public AntRef ZoomingTime { get; set; } = new();
		
		[ContainerField(224), JsonProperty(Order = 224)]
		public AntRef TriggerZoomGunTwitch { get; set; } = new();
		
		[ContainerField(228), JsonProperty(Order = 228)]
		public AntRef WeaponChooserSignal { get; set; } = new();
		
		[ContainerField(232), JsonProperty(Order = 232)]
		public AntRef WeaponClassSignal { get; set; } = new();
		
		[ContainerField(236), JsonProperty(Order = 236)]
		public AntRef OffsetX { get; set; } = new();
		
		[ContainerField(240), JsonProperty(Order = 240)]
		public AntRef OffsetY { get; set; } = new();
		
		[ContainerField(244), JsonProperty(Order = 244)]
		public AntRef OffsetZ { get; set; } = new();
		
		[ContainerField(248), JsonProperty(Order = 248)]
		public AntRef AIAllowFire { get; set; } = new();
		
		[ContainerField(252), JsonProperty(Order = 252)]
		public AntRef AIAltFireFromAnt { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Deploy.Serialize(p_Writer, p_EbxWriter);
			AltDeploy.Serialize(p_Writer, p_EbxWriter);
			Undeploy.Serialize(p_Writer, p_EbxWriter);
			QuickSwitch.Serialize(p_Writer, p_EbxWriter);
			Reload.Serialize(p_Writer, p_EbxWriter);
			ReloadShotgun.Serialize(p_Writer, p_EbxWriter);
			Fire.Serialize(p_Writer, p_EbxWriter);
			FireSingle.Serialize(p_Writer, p_EbxWriter);
			FireHoldAndRelease.Serialize(p_Writer, p_EbxWriter);
			FireSimple.Serialize(p_Writer, p_EbxWriter);
			FirstShotSpawned.Serialize(p_Writer, p_EbxWriter);
			BoltAction.Serialize(p_Writer, p_EbxWriter);
			PumpAction.Serialize(p_Writer, p_EbxWriter);
			MeleeAttack.Serialize(p_Writer, p_EbxWriter);
			QuickThrow.Serialize(p_Writer, p_EbxWriter);
			QuickThrowType.Serialize(p_Writer, p_EbxWriter);
			AimBody.Serialize(p_Writer, p_EbxWriter);
			AlwaysAimHead.Serialize(p_Writer, p_EbxWriter);
			OneHanded.Serialize(p_Writer, p_EbxWriter);
			OneHandedAiming.Serialize(p_Writer, p_EbxWriter);
			AimingEnabled.Serialize(p_Writer, p_EbxWriter);
			LowerGun.Serialize(p_Writer, p_EbxWriter);
			BreathControl.Serialize(p_Writer, p_EbxWriter);
			RflType.Serialize(p_Writer, p_EbxWriter);
			PstlType.Serialize(p_Writer, p_EbxWriter);
			HgrType.Serialize(p_Writer, p_EbxWriter);
			ATType.Serialize(p_Writer, p_EbxWriter);
			ShgType.Serialize(p_Writer, p_EbxWriter);
			LMGType.Serialize(p_Writer, p_EbxWriter);
			BagType.Serialize(p_Writer, p_EbxWriter);
			SnpType.Serialize(p_Writer, p_EbxWriter);
			Zoom.Serialize(p_Writer, p_EbxWriter);
			AimBodyWeight.Serialize(p_Writer, p_EbxWriter);
			DisableZoomToggleWeight.Serialize(p_Writer, p_EbxWriter);
			ZoomParameter.Serialize(p_Writer, p_EbxWriter);
			ZoomScaleFactor.Serialize(p_Writer, p_EbxWriter);
			Dispersion.Serialize(p_Writer, p_EbxWriter);
			AimTargetPosBody.Serialize(p_Writer, p_EbxWriter);
			ZoomOutSpeed.Serialize(p_Writer, p_EbxWriter);
			ZoomInSpeed.Serialize(p_Writer, p_EbxWriter);
			UnDeploySpeed.Serialize(p_Writer, p_EbxWriter);
			DeploySpeed.Serialize(p_Writer, p_EbxWriter);
			LightEnabled.Serialize(p_Writer, p_EbxWriter);
			FireModeChanged.Serialize(p_Writer, p_EbxWriter);
			AnimType.Serialize(p_Writer, p_EbxWriter);
			GunDown.Serialize(p_Writer, p_EbxWriter);
			NumberOfBulletsLeftInGun.Serialize(p_Writer, p_EbxWriter);
			BulletsLeftInGun.Serialize(p_Writer, p_EbxWriter);
			AbortVehicleDeploy.Serialize(p_Writer, p_EbxWriter);
			CurrentProjectileIndex.Serialize(p_Writer, p_EbxWriter);
			WeaponActionESIG.Serialize(p_Writer, p_EbxWriter);
			IsSprinting.Serialize(p_Writer, p_EbxWriter);
			PreparingToBash.Serialize(p_Writer, p_EbxWriter);
			JustStartedSprinting.Serialize(p_Writer, p_EbxWriter);
			KickBackInIronSight.Serialize(p_Writer, p_EbxWriter);
			ZoomingTime.Serialize(p_Writer, p_EbxWriter);
			TriggerZoomGunTwitch.Serialize(p_Writer, p_EbxWriter);
			WeaponChooserSignal.Serialize(p_Writer, p_EbxWriter);
			WeaponClassSignal.Serialize(p_Writer, p_EbxWriter);
			OffsetX.Serialize(p_Writer, p_EbxWriter);
			OffsetY.Serialize(p_Writer, p_EbxWriter);
			OffsetZ.Serialize(p_Writer, p_EbxWriter);
			AIAllowFire.Serialize(p_Writer, p_EbxWriter);
			AIAltFireFromAnt.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
