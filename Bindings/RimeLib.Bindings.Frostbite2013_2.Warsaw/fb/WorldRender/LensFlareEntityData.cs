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

namespace fb.WorldRender;

[ContainerType(16, 128)]
public class LensFlareEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float OccluderSize { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float DepthBias { get; set; } = 0.000f;
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<LensFlareElement> Elements { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool DebugDrawOccluder { get; set; } = false;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool HalfRes { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OccluderSize);
		p_Writer.Write(DepthBias);
		(RimeWriter Writer, uint ArrayIndex) s_Elements = p_EbxWriter.GetArrayWriter(Elements.GetType(), Elements.Count);
		p_Writer.Write(s_Elements.ArrayIndex);
		foreach (var s_Entry in Elements)
		{
			s_Entry.Serialize(s_Elements.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Visible);
		p_Writer.Write(DebugDrawOccluder);
		p_Writer.Write(HalfRes);
		p_Writer.WriteNullBytes(13);
	}
}

