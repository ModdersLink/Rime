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

[ContainerType(16, 240)]
public class UICommanderSquadStatusWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public int RowSpacing { get; set; } = 2;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public int SquadLeaderSpace { get; set; } = 30;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor UnavailabilityColor { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public int SquadMemberSpace { get; set; } = 30;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public int TextPadding { get; set; } = 4;
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public CtrRef<UIElementFillData> SquadInfoBackgroundData { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIElementFillData> SquadInfoMutinyBackgroundData { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIElementFillData> SquadIconBackgroundData { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<UIElementFillData> SquadIconMutinyBackgroundData { get; set; } = new();
	
	[ContainerField(0xb8), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public Vec2 SquadIconBackgroundSize { get; set; } = new()
	{
		y = 28.000f,
		x = 28.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec2 SquadInfoBackgroundSize { get; set; } = new()
	{
		y = 50.000f,
		x = 100.000f,
	};
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<UIElementStatbarStyle> SquadBarStyleSelected { get; set; } = new();
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<UIElementStatbarStyle> SquadBarStyleUnselected { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float SquadBarHeight { get; set; } = 2.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float SquadBarOffset { get; set; } = 3.000f;
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<UIElementFontStyle> PlayerFont { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RowSpacing);
		p_Writer.Write(SquadLeaderSpace);
		UnavailabilityColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SquadMemberSpace);
		p_Writer.Write(TextPadding);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadInfoBackgroundData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadInfoMutinyBackgroundData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadIconBackgroundData));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadIconMutinyBackgroundData));
		p_Writer.WriteNullBytes(4);
		SquadIconBackgroundSize.Serialize(p_Writer, p_EbxWriter);
		SquadInfoBackgroundSize.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadBarStyleSelected));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadBarStyleUnselected));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SquadBarHeight);
		p_Writer.Write(SquadBarOffset);
		p_Writer.Write(p_EbxWriter.WriteImport(PlayerFont));
		p_Writer.WriteNullBytes(12);
	}
}

