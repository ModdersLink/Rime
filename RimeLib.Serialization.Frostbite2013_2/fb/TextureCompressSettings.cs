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

namespace fb.Render;

[ContainerType(8, 32)]
public class TextureCompressSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public TextureCompressQualityMode ViewMode { get; set; } = TextureCompressQualityMode.TextureCompressQualityMode_Default;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public uint TextureCompressJobPoolSize { get; set; } = 8;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float DebugDrawAlphaOverlayScale { get; set; } = 32.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public bool DebugDrawEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) ViewMode);
		p_Writer.Write(TextureCompressJobPoolSize);
		p_Writer.Write(DebugDrawAlphaOverlayScale);
		p_Writer.Write(DebugDrawEnable);
		p_Writer.WriteNullBytes(3);
	}
}

