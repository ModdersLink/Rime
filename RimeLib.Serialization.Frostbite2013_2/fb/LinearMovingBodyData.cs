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

[ContainerType(16, 96)]
public class LinearMovingBodyData
	: fb.Physics.MovingBodyData
{
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 Axis { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public EndPointData Start { get; set; } = new();
	
	[ContainerField(0x44), JsonProperty(Order = 68)]
	public EndPointData End { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
		Axis.Serialize(p_Writer, p_EbxWriter);
		Start.Serialize(p_Writer, p_EbxWriter);
		End.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
	}
}

