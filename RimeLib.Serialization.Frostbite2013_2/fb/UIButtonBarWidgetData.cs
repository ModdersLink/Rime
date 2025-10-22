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

using fb.GameShared;
using fb.Core;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 192)]
public class UIButtonBarWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float ButtonAndTextSeparation { get; set; } = 10.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float EntrySeparation { get; set; } = 10.000f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor EnabledColor { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIElementColor DisabledColor { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float TextYOffset { get; set; } = 0.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIElementFontStyle> FontStyle { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ButtonAndTextSeparation);
		p_Writer.Write(EntrySeparation);
		EnabledColor.Serialize(p_Writer, p_EbxWriter);
		DisabledColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(TextYOffset);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(FontStyle));
		p_Writer.WriteNullBytes(4);
	}
}

