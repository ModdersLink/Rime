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
	[ContainerType(4, 256)]
	public partial class AnimatedWeaponBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _Deploy = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _AltDeploy = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _Undeploy = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _QuickSwitch = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _Reload = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _ReloadShotgun = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _Fire = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _FireSingle = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _FireHoldAndRelease = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _FireSimple = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _FirstShotSpawned = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _BoltAction = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AntRef _PumpAction = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntRef _MeleeAttack = new();
		
		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private AntRef _QuickThrow = new();
		
		[ObservableProperty]
		[property: ContainerField(60), JsonProperty(Order = 60)]
		private AntRef _QuickThrowType = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private AntRef _AimBody = new();
		
		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private AntRef _AlwaysAimHead = new();
		
		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private AntRef _OneHanded = new();
		
		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private AntRef _OneHandedAiming = new();
		
		[ObservableProperty]
		[property: ContainerField(80), JsonProperty(Order = 80)]
		private AntRef _AimingEnabled = new();
		
		[ObservableProperty]
		[property: ContainerField(84), JsonProperty(Order = 84)]
		private AntRef _LowerGun = new();
		
		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private AntRef _BreathControl = new();
		
		[ObservableProperty]
		[property: ContainerField(92), JsonProperty(Order = 92)]
		private AntRef _RflType = new();
		
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private AntRef _PstlType = new();
		
		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private AntRef _HgrType = new();
		
		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private AntRef _ATType = new();
		
		[ObservableProperty]
		[property: ContainerField(108), JsonProperty(Order = 108)]
		private AntRef _ShgType = new();
		
		[ObservableProperty]
		[property: ContainerField(112), JsonProperty(Order = 112)]
		private AntRef _LMGType = new();
		
		[ObservableProperty]
		[property: ContainerField(116), JsonProperty(Order = 116)]
		private AntRef _BagType = new();
		
		[ObservableProperty]
		[property: ContainerField(120), JsonProperty(Order = 120)]
		private AntRef _SnpType = new();
		
		[ObservableProperty]
		[property: ContainerField(124), JsonProperty(Order = 124)]
		private AntRef _Zoom = new();
		
		[ObservableProperty]
		[property: ContainerField(128), JsonProperty(Order = 128)]
		private AntRef _AimBodyWeight = new();
		
		[ObservableProperty]
		[property: ContainerField(132), JsonProperty(Order = 132)]
		private AntRef _DisableZoomToggleWeight = new();
		
		[ObservableProperty]
		[property: ContainerField(136), JsonProperty(Order = 136)]
		private AntRef _ZoomParameter = new();
		
		[ObservableProperty]
		[property: ContainerField(140), JsonProperty(Order = 140)]
		private AntRef _ZoomScaleFactor = new();
		
		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private AntRef _Dispersion = new();
		
		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private AntRef _AimTargetPosBody = new();
		
		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private AntRef _ZoomOutSpeed = new();
		
		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private AntRef _ZoomInSpeed = new();
		
		[ObservableProperty]
		[property: ContainerField(160), JsonProperty(Order = 160)]
		private AntRef _UnDeploySpeed = new();
		
		[ObservableProperty]
		[property: ContainerField(164), JsonProperty(Order = 164)]
		private AntRef _DeploySpeed = new();
		
		[ObservableProperty]
		[property: ContainerField(168), JsonProperty(Order = 168)]
		private AntRef _LightEnabled = new();
		
		[ObservableProperty]
		[property: ContainerField(172), JsonProperty(Order = 172)]
		private AntRef _FireModeChanged = new();
		
		[ObservableProperty]
		[property: ContainerField(176), JsonProperty(Order = 176)]
		private AntRef _AnimType = new();
		
		[ObservableProperty]
		[property: ContainerField(180), JsonProperty(Order = 180)]
		private AntRef _GunDown = new();
		
		[ObservableProperty]
		[property: ContainerField(184), JsonProperty(Order = 184)]
		private AntRef _NumberOfBulletsLeftInGun = new();
		
		[ObservableProperty]
		[property: ContainerField(188), JsonProperty(Order = 188)]
		private AntRef _BulletsLeftInGun = new();
		
		[ObservableProperty]
		[property: ContainerField(192), JsonProperty(Order = 192)]
		private AntRef _AbortVehicleDeploy = new();
		
		[ObservableProperty]
		[property: ContainerField(196), JsonProperty(Order = 196)]
		private AntRef _CurrentProjectileIndex = new();
		
		[ObservableProperty]
		[property: ContainerField(200), JsonProperty(Order = 200)]
		private AntRef _WeaponActionESIG = new();
		
		[ObservableProperty]
		[property: ContainerField(204), JsonProperty(Order = 204)]
		private AntRef _IsSprinting = new();
		
		[ObservableProperty]
		[property: ContainerField(208), JsonProperty(Order = 208)]
		private AntRef _PreparingToBash = new();
		
		[ObservableProperty]
		[property: ContainerField(212), JsonProperty(Order = 212)]
		private AntRef _JustStartedSprinting = new();
		
		[ObservableProperty]
		[property: ContainerField(216), JsonProperty(Order = 216)]
		private AntRef _KickBackInIronSight = new();
		
		[ObservableProperty]
		[property: ContainerField(220), JsonProperty(Order = 220)]
		private AntRef _ZoomingTime = new();
		
		[ObservableProperty]
		[property: ContainerField(224), JsonProperty(Order = 224)]
		private AntRef _TriggerZoomGunTwitch = new();
		
		[ObservableProperty]
		[property: ContainerField(228), JsonProperty(Order = 228)]
		private AntRef _WeaponChooserSignal = new();
		
		[ObservableProperty]
		[property: ContainerField(232), JsonProperty(Order = 232)]
		private AntRef _WeaponClassSignal = new();
		
		[ObservableProperty]
		[property: ContainerField(236), JsonProperty(Order = 236)]
		private AntRef _OffsetX = new();
		
		[ObservableProperty]
		[property: ContainerField(240), JsonProperty(Order = 240)]
		private AntRef _OffsetY = new();
		
		[ObservableProperty]
		[property: ContainerField(244), JsonProperty(Order = 244)]
		private AntRef _OffsetZ = new();
		
		[ObservableProperty]
		[property: ContainerField(248), JsonProperty(Order = 248)]
		private AntRef _AIAllowFire = new();
		
		[ObservableProperty]
		[property: ContainerField(252), JsonProperty(Order = 252)]
		private AntRef _AIAltFireFromAnt = new();
		
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
