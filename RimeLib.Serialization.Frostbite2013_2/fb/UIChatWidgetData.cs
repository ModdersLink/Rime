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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 176)]
public class UIChatWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFontStyle> ChannelFont { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFontStyle> SenderFont { get; set; } = new();
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 AdminColor { get; set; } = new()
	{
		z = 0.000f,
		y = 0.590f,
		x = 0.900f,
	};
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIElementFontStyle> MessageFont { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float RowSpacing { get; set; } = 2.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float StartFadeOutTime { get; set; } = 2.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float EndFadeOutTime { get; set; } = 3.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float ModeStartFadeOutTime { get; set; } = 1.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ModeEndFadeOutTime { get; set; } = 2.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ChannelFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SenderFont));
		p_Writer.WriteNullBytes(12);
		AdminColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(MessageFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RowSpacing);
		p_Writer.Write(StartFadeOutTime);
		p_Writer.Write(EndFadeOutTime);
		p_Writer.Write(ModeStartFadeOutTime);
		p_Writer.Write(ModeEndFadeOutTime);
		p_Writer.WriteNullBytes(4);
	}
}

