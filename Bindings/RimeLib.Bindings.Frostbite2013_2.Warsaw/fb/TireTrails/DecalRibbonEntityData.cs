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
using fb.WorldRender;
using fb.Render;
using fb.Entity;

namespace fb.TireTrails;

[ContainerType(16, 192)]
public class DecalRibbonEntityData
	: fb.WorldRender.RenderVolumeEntityData
{
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float RibbonWidth { get; set; } = 0.300f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float RibbonHeight { get; set; } = 0.060f;
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public List<Vec3> Points { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float RibbonOffset { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RibbonWidth);
		p_Writer.Write(RibbonHeight);
		(RimeWriter Writer, uint ArrayIndex) s_Points = p_EbxWriter.GetArrayWriter(Points.GetType(), Points.Count);
		p_Writer.Write(s_Points.ArrayIndex);
		foreach (var s_Entry in Points)
		{
			s_Entry.Serialize(s_Points.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RibbonOffset);
		p_Writer.WriteNullBytes(12);
	}
}

