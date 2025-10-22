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

namespace fb.VeniceShared;

[ContainerType(16, 96)]
public class UIDeployScreenData
	: fb.VeniceShared.BFUICppScreenData
{
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec4 MapFocusMargins { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public UIVisualWidgetType VisualWidgetType { get; set; } = UIVisualWidgetType.UIVisualWidgetType_Default;
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public CtrRef<UIElementFontStyle> VehicleNameFontStyle { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public double ShowDamagedPlayerWarningDuring { get; set; } = 5.000;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		MapFocusMargins.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) VisualWidgetType);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(VehicleNameFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ShowDamagedPlayerWarningDuring);
		p_Writer.WriteNullBytes(8);
	}
}

