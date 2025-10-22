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

[ContainerType(4, 24)]
public class WeaponLagEffectSpringVector
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public WeaponLagEffectSpringData SpringX { get; set; } = new();
	
	[ContainerField(0x8), JsonProperty(Order = 8)]
	public WeaponLagEffectSpringData SpringY { get; set; } = new();
	
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public WeaponLagEffectSpringData SpringZ { get; set; } = new();
	
}

