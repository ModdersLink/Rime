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

namespace fb.BFAI2Data;

[ContainerType(8, 32)]
public class FiringPatternData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public ulong Pattern { get; set; } = 0;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public int Id { get; set; } = 0;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public FiringWeaponClass WeaponClass { get; set; } = FiringWeaponClass.WeaponClass_AssaultRifle;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public IntensityClass Intensity { get; set; } = IntensityClass.IntensityClass_Low;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public int Delay { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public bool SingleShot { get; set; } = false;
	
}

