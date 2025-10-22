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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 184)]
public class FireLogicData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public HoldAndReleaseData HoldAndRelease { get; set; } = new();
	
	[ContainerField(0x1c), JsonProperty(Order = 28)]
	public BoltActionData BoltAction { get; set; } = new();
	
	[ContainerField(0x2c), JsonProperty(Order = 44)]
	public RecoilData Recoil { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public int FireInputAction { get; set; } = 1018135856;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public int ReloadInputAction { get; set; } = 1131457753;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public int CycleFireModeInputAction { get; set; } = -1145593149;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float TriggerPullWeight { get; set; } = 0.100f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float RateOfFire { get; set; } = 550.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float RateOfFireForBurst { get; set; } = 550.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float DelayBetweenBursts { get; set; } = -1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float ClientFireRateMultiplier { get; set; } = 0.670f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ReloadDelay { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float ReloadTime { get; set; } = 3.600f;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public List<float> ReloadTimerArray { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float ReloadTimeBulletsLeft { get; set; } = -1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float ReloadThreshold { get; set; } = 0.750f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float PreFireDelay { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float PreFireDelayZoomed { get; set; } = -1.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float PreFireRequireHold { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float AutomaticDelay { get; set; } = 0.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public ReloadLogic ReloadLogic { get; set; } = fb.GameShared.ReloadLogic.rlWeaponSwitchCancelsUnfinishedReload;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public ReloadType ReloadType { get; set; } = fb.GameShared.ReloadType.rtMagazine;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public FireLogicType FireLogicType { get; set; } = fb.GameShared.FireLogicType.fltAutomaticFire;
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public List<FireLogicType> FireLogicTypeArray { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public bool HoldOffReloadUntilFireRelease { get; set; } = false;
	
	[ContainerField(0xb1), LayoutImmutable, Blittable, JsonProperty(Order = 177)]
	public bool HoldOffReloadUntilZoomRelease { get; set; } = false;
	
	[ContainerField(0xb2), LayoutImmutable, Blittable, JsonProperty(Order = 178)]
	public bool ForceReloadActionOnFireTrigger { get; set; } = false;
	
	[ContainerField(0xb3), LayoutImmutable, Blittable, JsonProperty(Order = 179)]
	public bool AlwaysAutoReload { get; set; } = true;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public bool ZoomTransitionDisableFire { get; set; } = false;
	
}

