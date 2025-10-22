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

namespace fb.Physics;

[ContainerType(8, 40)]
public class VehicleInputTweakData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public VehicleInputTweakType InputTweakType { get; set; } = VehicleInputTweakType.CombinedSpeedTweakType;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float MinSpeed { get; set; } = 11.111f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MaxSpeed { get; set; } = 33.333f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float MinSpeedScale { get; set; } = 0.250f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MaxSpeedScale { get; set; } = 0.250f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) InputTweakType);
		p_Writer.Write(MinSpeed);
		p_Writer.Write(MaxSpeed);
		p_Writer.Write(MinSpeedScale);
		p_Writer.Write(MaxSpeedScale);
		p_Writer.WriteNullBytes(4);
	}
}

