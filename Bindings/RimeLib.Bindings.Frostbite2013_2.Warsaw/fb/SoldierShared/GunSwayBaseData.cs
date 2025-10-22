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

[ContainerType(4, 68)]
public class GunSwayBaseData
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public GunSwayDispersionData BaseValue { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public GunSwayRecoilData Recoil { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public GunSwayLagData GunSwayLag { get; set; } = new();
	
}

