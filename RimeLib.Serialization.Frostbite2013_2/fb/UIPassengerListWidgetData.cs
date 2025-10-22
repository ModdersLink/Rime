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

[ContainerType(8, 200)]
public class UIPassengerListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string UseOpacitySettingProfileOption { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string ShowPlayerRanksProfileOption { get; set; } = string.Empty;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public string ShowPlayerClassProfileOption { get; set; } = string.Empty;
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIDataSource VehicleDataSource { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float RowHeight { get; set; } = 30.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float RoleIconOffsetX { get; set; } = 0.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float PlayerNameOffsetX { get; set; } = -30.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float RankOffsetX { get; set; } = -25.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ClassOffsetX { get; set; } = 0.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float ExtraIconOffsetX { get; set; } = 0.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float IconsScale { get; set; } = 1.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIElementFontStyle> PlayerFont { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool AlignLeft { get; set; } = false;
	
	[ContainerField(0xc1), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
	public bool AlignTop { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(UseOpacitySettingProfileOption));
		p_Writer.Write(p_EbxWriter.WriteString(ShowPlayerRanksProfileOption));
		p_Writer.Write(p_EbxWriter.WriteString(ShowPlayerClassProfileOption));
		VehicleDataSource.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RowHeight);
		p_Writer.Write(RoleIconOffsetX);
		p_Writer.Write(PlayerNameOffsetX);
		p_Writer.Write(RankOffsetX);
		p_Writer.Write(ClassOffsetX);
		p_Writer.Write(ExtraIconOffsetX);
		p_Writer.Write(IconsScale);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PlayerFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AlignLeft);
		p_Writer.Write(AlignTop);
		p_Writer.WriteNullBytes(6);
	}
}

