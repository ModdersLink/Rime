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


namespace fb.SoldierShared;

[ContainerType(4, 188)]
public class GunSwayBaseMoveJumpData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public GunSwayDispersionData BaseValue { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public GunSwayDispersionData Moving { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public GunSwayDispersionData Jumping { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public GunSwayDispersionData Sprinting { get; set; } = new();
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public GunSwayDispersionData VaultingSmallObject { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public GunSwayDispersionData VaultingMediumObject { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public GunSwayRecoilData Recoil { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public GunSwayLagData GunSwayLag { get; set; } = new();
	
}

