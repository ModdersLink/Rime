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

using fb.Ant;

namespace fb.SoldierShared;

[ContainerType(4, 1440)]
public class AnimatedWeaponBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef Deploy { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef AltDeploy { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef Undeploy { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef QuickSwitch { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef Reload { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef ReloadStage { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef ReloadShotgun { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef Fire { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef FireSingle { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef FireHoldAndRelease { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef FireSimple { get; set; } = new();
	
	[ContainerField(0xdc), JsonProperty(Order = 220)]
	public AntRef FirstShotSpawned { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AntRef PreFiring { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public AntRef BoltAction { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public AntRef PumpAction { get; set; } = new();
	
	[ContainerField(0x12c), JsonProperty(Order = 300)]
	public AntRef MeleeAttack { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public AntRef QuickThrow { get; set; } = new();
	
	[ContainerField(0x154), JsonProperty(Order = 340)]
	public AntRef QuickThrowType { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public AntRef AimBody { get; set; } = new();
	
	[ContainerField(0x17c), JsonProperty(Order = 380)]
	public AntRef AlwaysAimHead { get; set; } = new();
	
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public AntRef OneHanded { get; set; } = new();
	
	[ContainerField(0x1a4), JsonProperty(Order = 420)]
	public AntRef OneHandedAiming { get; set; } = new();
	
	[ContainerField(0x1b8), JsonProperty(Order = 440)]
	public AntRef AimingEnabled { get; set; } = new();
	
	[ContainerField(0x1cc), JsonProperty(Order = 460)]
	public AntRef LowerGun { get; set; } = new();
	
	[ContainerField(0x1e0), JsonProperty(Order = 480)]
	public AntRef BreathControl { get; set; } = new();
	
	[ContainerField(0x1f4), JsonProperty(Order = 500)]
	public AntRef RflType { get; set; } = new();
	
	[ContainerField(0x208), JsonProperty(Order = 520)]
	public AntRef PstlType { get; set; } = new();
	
	[ContainerField(0x21c), JsonProperty(Order = 540)]
	public AntRef HgrType { get; set; } = new();
	
	[ContainerField(0x230), JsonProperty(Order = 560)]
	public AntRef ATType { get; set; } = new();
	
	[ContainerField(0x244), JsonProperty(Order = 580)]
	public AntRef ShgType { get; set; } = new();
	
	[ContainerField(0x258), JsonProperty(Order = 600)]
	public AntRef LMGType { get; set; } = new();
	
	[ContainerField(0x26c), JsonProperty(Order = 620)]
	public AntRef BagType { get; set; } = new();
	
	[ContainerField(0x280), JsonProperty(Order = 640)]
	public AntRef SnpType { get; set; } = new();
	
	[ContainerField(0x294), JsonProperty(Order = 660)]
	public AntRef Zoom { get; set; } = new();
	
	[ContainerField(0x2a8), JsonProperty(Order = 680)]
	public AntRef CantedZoom { get; set; } = new();
	
	[ContainerField(0x2bc), JsonProperty(Order = 700)]
	public AntRef MagnifierSightToggle { get; set; } = new();
	
	[ContainerField(0x2d0), JsonProperty(Order = 720)]
	public AntRef MagnifierSightIsUp { get; set; } = new();
	
	[ContainerField(0x2e4), JsonProperty(Order = 740)]
	public AntRef AimBodyWeight { get; set; } = new();
	
	[ContainerField(0x2f8), JsonProperty(Order = 760)]
	public AntRef DisableZoomToggleWeight { get; set; } = new();
	
	[ContainerField(0x30c), JsonProperty(Order = 780)]
	public AntRef ZoomParameter { get; set; } = new();
	
	[ContainerField(0x320), JsonProperty(Order = 800)]
	public AntRef ZoomScaleFactor { get; set; } = new();
	
	[ContainerField(0x334), JsonProperty(Order = 820)]
	public AntRef Dispersion { get; set; } = new();
	
	[ContainerField(0x348), JsonProperty(Order = 840)]
	public AntRef AimTargetPosBody { get; set; } = new();
	
	[ContainerField(0x35c), JsonProperty(Order = 860)]
	public AntRef ZoomOutSpeed { get; set; } = new();
	
	[ContainerField(0x370), JsonProperty(Order = 880)]
	public AntRef ZoomInSpeed { get; set; } = new();
	
	[ContainerField(0x384), JsonProperty(Order = 900)]
	public AntRef UnDeploySpeed { get; set; } = new();
	
	[ContainerField(0x398), JsonProperty(Order = 920)]
	public AntRef DeploySpeed { get; set; } = new();
	
	[ContainerField(0x3ac), JsonProperty(Order = 940)]
	public AntRef LightEnabled { get; set; } = new();
	
	[ContainerField(0x3c0), JsonProperty(Order = 960)]
	public AntRef FireModeChanged { get; set; } = new();
	
	[ContainerField(0x3d4), JsonProperty(Order = 980)]
	public AntRef AnimType { get; set; } = new();
	
	[ContainerField(0x3e8), JsonProperty(Order = 1000)]
	public AntRef GunDown { get; set; } = new();
	
	[ContainerField(0x3fc), JsonProperty(Order = 1020)]
	public AntRef AllowSwitchingToWeaponInWater { get; set; } = new();
	
	[ContainerField(0x410), JsonProperty(Order = 1040)]
	public AntRef NumberOfBulletsLeftInGun { get; set; } = new();
	
	[ContainerField(0x424), JsonProperty(Order = 1060)]
	public AntRef BulletsLeftInGun { get; set; } = new();
	
	[ContainerField(0x438), JsonProperty(Order = 1080)]
	public AntRef AbortVehicleDeploy { get; set; } = new();
	
	[ContainerField(0x44c), JsonProperty(Order = 1100)]
	public AntRef CustomizeWeapon { get; set; } = new();
	
	[ContainerField(0x460), JsonProperty(Order = 1120)]
	public AntRef CustomizeWeaponSwitch { get; set; } = new();
	
	[ContainerField(0x474), JsonProperty(Order = 1140)]
	public AntRef WeaponActionESIG { get; set; } = new();
	
	[ContainerField(0x488), JsonProperty(Order = 1160)]
	public AntRef IsSprinting { get; set; } = new();
	
	[ContainerField(0x49c), JsonProperty(Order = 1180)]
	public AntRef PreparingToBash { get; set; } = new();
	
	[ContainerField(0x4b0), JsonProperty(Order = 1200)]
	public AntRef JustStartedSprinting { get; set; } = new();
	
	[ContainerField(0x4c4), JsonProperty(Order = 1220)]
	public AntRef KickbackMagnitudeFactor { get; set; } = new();
	
	[ContainerField(0x4d8), JsonProperty(Order = 1240)]
	public AntRef KickbackSpeedFactor { get; set; } = new();
	
	[ContainerField(0x4ec), JsonProperty(Order = 1260)]
	public AntRef ZoomingTime { get; set; } = new();
	
	[ContainerField(0x500), JsonProperty(Order = 1280)]
	public AntRef TriggerZoomGunTwitch { get; set; } = new();
	
	[ContainerField(0x514), JsonProperty(Order = 1300)]
	public AntRef WeaponChooserSignal { get; set; } = new();
	
	[ContainerField(0x528), JsonProperty(Order = 1320)]
	public AntRef WeaponClassSignal { get; set; } = new();
	
	[ContainerField(0x53c), JsonProperty(Order = 1340)]
	public AntRef OffsetX { get; set; } = new();
	
	[ContainerField(0x550), JsonProperty(Order = 1360)]
	public AntRef OffsetY { get; set; } = new();
	
	[ContainerField(0x564), JsonProperty(Order = 1380)]
	public AntRef OffsetZ { get; set; } = new();
	
	[ContainerField(0x578), JsonProperty(Order = 1400)]
	public AntRef AIAllowFire { get; set; } = new();
	
	[ContainerField(0x58c), JsonProperty(Order = 1420)]
	public AntRef AIAltFireFromAnt { get; set; } = new();
	
}

