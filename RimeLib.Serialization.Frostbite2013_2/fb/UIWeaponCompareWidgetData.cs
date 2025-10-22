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

[ContainerType(16, 304)]
public class UIWeaponCompareWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFillData> BackgroundFillData { get; set; } = new();
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float Group1VerticalOffset { get; set; } = 0.000f;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor ProgressionColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor ComparisonNeutralColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor ComparisonIncreasingColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor ComparisonDecreasingColor { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UIElementColor DisabledFiremodeColor { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public CtrRef<BFUIElement3SliceStatbarStyle> StatbarStyle { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(BackgroundFillData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Group1VerticalOffset);
		p_Writer.WriteNullBytes(12);
		ProgressionColor.Serialize(p_Writer, p_EbxWriter);
		ComparisonNeutralColor.Serialize(p_Writer, p_EbxWriter);
		ComparisonIncreasingColor.Serialize(p_Writer, p_EbxWriter);
		ComparisonDecreasingColor.Serialize(p_Writer, p_EbxWriter);
		DisabledFiremodeColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(StatbarStyle));
		p_Writer.WriteNullBytes(12);
	}
}

