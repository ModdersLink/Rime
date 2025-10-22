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

[ContainerType(8, 136)]
public class UIIngameMenuWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public uint VerticalSpacing { get; set; } = 0;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public uint HorizontalPadding { get; set; } = 0;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public UIElementAlignment VerticalAlignment { get; set; } = UIElementAlignment.UIElementAlignment_Center;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public UIElementAlignment HorizonalAlignment { get; set; } = UIElementAlignment.UIElementAlignment_Center;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float TextRightSpacing { get; set; } = 10.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float TextAnimationWidth { get; set; } = 30.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float TextAnimationSpeed { get; set; } = 2.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(VerticalSpacing);
		p_Writer.Write(HorizontalPadding);
		p_Writer.Write((int) VerticalAlignment);
		p_Writer.Write((int) HorizonalAlignment);
		p_Writer.Write(TextRightSpacing);
		p_Writer.Write(TextAnimationWidth);
		p_Writer.Write(TextAnimationSpeed);
		p_Writer.WriteNullBytes(4);
	}
}

