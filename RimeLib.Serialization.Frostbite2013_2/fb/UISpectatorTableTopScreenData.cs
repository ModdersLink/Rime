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

namespace fb.VeniceShared;

[ContainerType(16, 144)]
public class UISpectatorTableTopScreenData
	: fb.VeniceShared.BFUICppScreenData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public UIMapWidgetHelperData MapWidgetHelperData { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public UIElementColor SelectedObjectBackgroundColor { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFontStyle> SelectedObjectFont { get; set; } = new();
	
	[ContainerField(0x78), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public Vec2 SelectedObjectTextPadding { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec2 SelectedObjectTextOffset { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		MapWidgetHelperData.Serialize(p_Writer, p_EbxWriter);
		SelectedObjectBackgroundColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedObjectFont));
		p_Writer.WriteNullBytes(4);
		SelectedObjectTextPadding.Serialize(p_Writer, p_EbxWriter);
		SelectedObjectTextOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(8);
	}
}

