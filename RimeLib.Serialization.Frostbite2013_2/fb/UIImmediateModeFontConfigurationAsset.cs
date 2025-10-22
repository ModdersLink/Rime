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
public class UIImmediateModeFontConfigurationAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<UIImmediateModeFontBundle> FontBundles { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int FontDpi { get; set; } = 96;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public int GlyphCacheSize { get; set; } = 1024;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int GlyphCacheSizeLowEnd { get; set; } = 256;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public int GlyphCachePadding { get; set; } = 1;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float GlyphGeometryPadding { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool GlyphCachePremultipliedAlpha { get; set; } = true;
	
	[ContainerField(0x35), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
	public bool AutoHinting { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_FontBundles = p_EbxWriter.GetArrayWriter(FontBundles.GetType(), FontBundles.Count);
		p_Writer.Write(s_FontBundles.ArrayIndex);
		foreach (var s_Entry in FontBundles)
		{
			s_Entry.Serialize(s_FontBundles.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FontDpi);
		p_Writer.Write(GlyphCacheSize);
		p_Writer.Write(GlyphCacheSizeLowEnd);
		p_Writer.Write(GlyphCachePadding);
		p_Writer.Write(GlyphGeometryPadding);
		p_Writer.Write(GlyphCachePremultipliedAlpha);
		p_Writer.Write(AutoHinting);
		p_Writer.WriteNullBytes(2);
	}
}

