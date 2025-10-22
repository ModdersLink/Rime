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

[ContainerType(8, 56)]
public class BangerSpawnImpulseParams
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float MinHorizontalAngle { get; set; } = -90.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float MaxHorizontalAngle { get; set; } = 90.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MinVerticalAngle { get; set; } = 45.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float MaxVerticalAngle { get; set; } = 85.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MinStrength { get; set; } = 15000.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float MaxStrength { get; set; } = 15000.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float WaterStrengthModifier { get; set; } = 0.007f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float LinearDamping { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float AngularDamping { get; set; } = 0.050f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MinHorizontalAngle);
		p_Writer.Write(MaxHorizontalAngle);
		p_Writer.Write(MinVerticalAngle);
		p_Writer.Write(MaxVerticalAngle);
		p_Writer.Write(MinStrength);
		p_Writer.Write(MaxStrength);
		p_Writer.Write(WaterStrengthModifier);
		p_Writer.Write(LinearDamping);
		p_Writer.Write(AngularDamping);
		p_Writer.WriteNullBytes(4);
	}
}

