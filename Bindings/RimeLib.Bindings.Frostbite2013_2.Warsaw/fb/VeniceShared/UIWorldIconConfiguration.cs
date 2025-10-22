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

using fb.GameShared;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(16, 608)]
public class UIWorldIconConfiguration
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public UILockingConfiguration LockingCfg { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIColorConfiguration StdColors { get; set; } = new();
	
	[ContainerField(0x1d0), JsonProperty(Order = 464)]
	public CtrRef<UINametagConfiguration> NametagCfg { get; set; } = new();
	
	[ContainerField(0x1d8), JsonProperty(Order = 472)]
	public CtrRef<UINametagConfiguration> SPNametagCfg { get; set; } = new();
	
	[ContainerField(0x1e0), JsonProperty(Order = 480)]
	public CtrRef<UINametagConfiguration> HardcoreNametagCfg { get; set; } = new();
	
	[ContainerField(0x1e8), JsonProperty(Order = 488)]
	public UIShieldIconConfiguration ShieldIconCfg { get; set; } = new();
	
	[ContainerField(0x208), JsonProperty(Order = 520)]
	public List<UIColorConfiguration> ColorBlindModes { get; set; } = new();
	
	[ContainerField(0x210), JsonProperty(Order = 528)]
	public UIWorldZoneDistanceConfiguration ZoneDistanceCfg { get; set; } = new();
	
	[ContainerField(0x218), LayoutImmutable, Blittable, JsonProperty(Order = 536)]
	public float RequestIconBlinkRate { get; set; } = 0.250f;
	
	[ContainerField(0x21c), JsonProperty(Order = 540)]
	public UIGrenadeConfiguration GrenadeCfg { get; set; } = new();
	
	[ContainerField(0x250), JsonProperty(Order = 592)]
	public CtrRef<UIElementFontStyle> MapFont { get; set; } = new();
	
	[ContainerField(0x258), JsonProperty(Order = 600)]
	public CtrRef<UIElementFontStyle> HudFont { get; set; } = new();
	
}

