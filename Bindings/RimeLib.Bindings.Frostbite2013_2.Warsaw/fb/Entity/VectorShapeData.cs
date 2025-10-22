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

namespace fb.Entity;

[ContainerType(8, 40)]
public class VectorShapeData
	: fb.Entity.BaseShapeData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<Vec3> Points { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float Tension { get; set; } = 0.500f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool IsClosed { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool AllowRoll { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Points = p_EbxWriter.GetArrayWriter(Points.GetType(), Points.Count);
		p_Writer.Write(s_Points.ArrayIndex);
		foreach (var s_Entry in Points)
		{
			s_Entry.Serialize(s_Points.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Tension);
		p_Writer.Write(IsClosed);
		p_Writer.Write(AllowRoll);
		p_Writer.WriteNullBytes(2);
	}
}

