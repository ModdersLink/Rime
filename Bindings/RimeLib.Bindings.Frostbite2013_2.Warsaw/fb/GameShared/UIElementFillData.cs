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

[ContainerType(16, 400)]
public class UIElementFillData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float BackgroundAntiAliasingWidth { get; set; } = 1.000f;
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public UIElementColor BackgroundColor { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public UIElementGradient BackgroundGradient { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor OutlineColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementGradient OutlineGradient { get; set; } = new();
	
	[ContainerField(0x160), LayoutImmutable, Blittable, JsonProperty(Order = 352)]
	public float OutlineAntiAliasingWidth { get; set; } = 1.000f;
	
	[ContainerField(0x164), LayoutImmutable, Blittable, JsonProperty(Order = 356)]
	public UIElementBlendType BackgroundBlend { get; set; } = UIElementBlendType.UIElementBlendType_AlphaBlend;
	
	[ContainerField(0x168), LayoutImmutable, Blittable, JsonProperty(Order = 360)]
	public UIElementBlendType OutlineBlend { get; set; } = UIElementBlendType.UIElementBlendType_AlphaBlend;
	
	[ContainerField(0x170), LayoutImmutable, Blittable, JsonProperty(Order = 368)]
	public string TextureId { get; set; } = string.Empty;
	
	[ContainerField(0x178), JsonProperty(Order = 376)]
	public CtrRef<UIElementSlice9FillData> Slice9Fill { get; set; } = new();
	
	[ContainerField(0x180), LayoutImmutable, Blittable, JsonProperty(Order = 384)]
	public bool DrawBackground { get; set; } = true;
	
	[ContainerField(0x181), LayoutImmutable, Blittable, JsonProperty(Order = 385)]
	public bool UseBackgroundGradient { get; set; } = false;
	
	[ContainerField(0x182), LayoutImmutable, Blittable, JsonProperty(Order = 386)]
	public bool UseBackgroundAntiAliasing { get; set; } = false;
	
	[ContainerField(0x183), LayoutImmutable, Blittable, JsonProperty(Order = 387)]
	public bool DrawOutline { get; set; } = true;
	
	[ContainerField(0x184), LayoutImmutable, Blittable, JsonProperty(Order = 388)]
	public bool UseOutlineGradient { get; set; } = false;
	
	[ContainerField(0x185), LayoutImmutable, Blittable, JsonProperty(Order = 389)]
	public bool UseOutlineAntiAliasing { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(BackgroundAntiAliasingWidth);
		p_Writer.WriteNullBytes(4);
		BackgroundColor.Serialize(p_Writer, p_EbxWriter);
		BackgroundGradient.Serialize(p_Writer, p_EbxWriter);
		OutlineColor.Serialize(p_Writer, p_EbxWriter);
		OutlineGradient.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(OutlineAntiAliasingWidth);
		p_Writer.Write((int) BackgroundBlend);
		p_Writer.Write((int) OutlineBlend);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TextureId));
		p_Writer.Write(p_EbxWriter.WriteImport(Slice9Fill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DrawBackground);
		p_Writer.Write(UseBackgroundGradient);
		p_Writer.Write(UseBackgroundAntiAliasing);
		p_Writer.Write(DrawOutline);
		p_Writer.Write(UseOutlineGradient);
		p_Writer.Write(UseOutlineAntiAliasing);
		p_Writer.WriteNullBytes(10);
	}
}

