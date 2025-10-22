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

[ContainerType(16, 320)]
public class UIElementBitmapEntityData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Vec4 UVRect { get; set; } = new()
	{
		w = 1.000f,
		z = 1.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementBitmapDistanceFieldParams DistanceFieldParams { get; set; } = new();
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public CtrRef<UIElementGenericStyle> Style { get; set; } = new();
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public string TextureId { get; set; } = string.Empty;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public string TextureIdPropertyName { get; set; } = string.Empty;
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public string SizeScalePropertyName { get; set; } = string.Empty;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool DistanceField { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		UVRect.Serialize(p_Writer, p_EbxWriter);
		DistanceFieldParams.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TextureId));
		p_Writer.Write(p_EbxWriter.WriteString(TextureIdPropertyName));
		p_Writer.Write(p_EbxWriter.WriteString(SizeScalePropertyName));
		p_Writer.Write(DistanceField);
		p_Writer.WriteNullBytes(15);
	}
}

