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
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 144)]
public class DriverStaticObjectComponentData
	: fb.GameShared.DriverComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float Acceleration { get; set; } = 5.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float Deceleration { get; set; } = 10.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float TurningRadius { get; set; } = 7.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool TurnWhileStill { get; set; } = false;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool AlignWithGroundNormal { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Acceleration);
		p_Writer.Write(Deceleration);
		p_Writer.Write(TurningRadius);
		p_Writer.Write(TurnWhileStill);
		p_Writer.Write(AlignWithGroundNormal);
		p_Writer.WriteNullBytes(2);
	}
}

