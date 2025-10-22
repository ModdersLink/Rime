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

namespace fb.WorldRender;

[ContainerType(8, 24)]
public class OcclusionSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x11), LayoutImmutable, Blittable, JsonProperty(Order = 17)]
	public bool CoverageEnable { get; set; } = false;
	
	[ContainerField(0x12), LayoutImmutable, Blittable, JsonProperty(Order = 18)]
	public bool DrawShadowZbuffer { get; set; } = false;
	
	[ContainerField(0x13), LayoutImmutable, Blittable, JsonProperty(Order = 19)]
	public bool DrawZbuffer { get; set; } = false;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public bool DrawSplitView { get; set; } = true;
	
	[ContainerField(0x15), LayoutImmutable, Blittable, JsonProperty(Order = 21)]
	public bool DrawBinaryBuffer { get; set; } = false;
	
	[ContainerField(0x16), LayoutImmutable, Blittable, JsonProperty(Order = 22)]
	public bool DrawCoverageBuffer { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Enable);
		p_Writer.Write(CoverageEnable);
		p_Writer.Write(DrawShadowZbuffer);
		p_Writer.Write(DrawZbuffer);
		p_Writer.Write(DrawSplitView);
		p_Writer.Write(DrawBinaryBuffer);
		p_Writer.Write(DrawCoverageBuffer);
		p_Writer.WriteNullBytes(1);
	}
}

