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

[ContainerType(16, 288)]
public class UIElementTextFieldEntityData
	: fb.GameShared.UIElementEntityData
{
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementGenericStyle> Style { get; set; } = new();
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public UIElementText Text { get; set; } = new();
	
	[ContainerField(0xf8), JsonProperty(Order = 248)]
	public CtrRef<UIElementFontStyle> FontStyle { get; set; } = new();
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float TextOffset { get; set; } = 0.000f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float AutoAdjustLeftPadding { get; set; } = 5.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float AutoAdjustRightPadding { get; set; } = 5.000f;
	
	[ContainerField(0x110), JsonProperty(Order = 272)]
	public CtrRef<UIAutoScrollSettings> AutoScrollSettings { get; set; } = new();
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public bool AutoAdjustWidth { get; set; } = false;
	
	[ContainerField(0x119), LayoutImmutable, Blittable, JsonProperty(Order = 281)]
	public bool UseAutoScroll { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Style));
		p_Writer.WriteNullBytes(4);
		Text.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TextOffset);
		p_Writer.Write(AutoAdjustLeftPadding);
		p_Writer.Write(AutoAdjustRightPadding);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AutoScrollSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AutoAdjustWidth);
		p_Writer.Write(UseAutoScroll);
		p_Writer.WriteNullBytes(6);
	}
}

