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

[ContainerType(16, 112)]
public class OccluderVolumeEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float CoverageValue { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool OccluderHighPriority { get; set; } = false;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool OccluderIsConservative { get; set; } = true;
	
	[ContainerField(0x66), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
	public bool Visible { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CoverageValue);
		p_Writer.Write(OccluderHighPriority);
		p_Writer.Write(OccluderIsConservative);
		p_Writer.Write(Visible);
		p_Writer.WriteNullBytes(9);
	}
}

