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

[ContainerType(16, 336)]
public class UISquadListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float RowHeight { get; set; } = 30.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float VoipIconOffsetX { get; set; } = 5.000f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public UIElementColor DeadColor { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public UIElementColor UnavailabilityColor { get; set; } = new();
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public UIElementLineStyle DecorationLineStyle { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementLineStyle SelectionCrossLineStyle { get; set; } = new();
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float KitIconOffsetX { get; set; } = 20.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float PlayerNameOffsetX { get; set; } = 35.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float SquadLeaderIconOffsetX { get; set; } = 60.000f;
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public CtrRef<UIElementFontStyle> PlayerFont { get; set; } = new();
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public float DecorationLineLength { get; set; } = 15.000f;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public float SquadBarOffsetX { get; set; } = 0.000f;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public float SquadBarOffsetY { get; set; } = 0.000f;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public float CommanderStatusOffsetX { get; set; } = 0.000f;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public float CommanderStatusOffsetY { get; set; } = 0.000f;
	
	[ContainerField(0x140), LayoutImmutable, Blittable, JsonProperty(Order = 320)]
	public string ShowPlayerRanksProfileOption { get; set; } = string.Empty;
	
	[ContainerField(0x148), LayoutImmutable, Blittable, JsonProperty(Order = 328)]
	public string ShowSquadMateRequestsProfileOption { get; set; } = string.Empty;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RowHeight);
		p_Writer.Write(VoipIconOffsetX);
		DeadColor.Serialize(p_Writer, p_EbxWriter);
		UnavailabilityColor.Serialize(p_Writer, p_EbxWriter);
		DecorationLineStyle.Serialize(p_Writer, p_EbxWriter);
		SelectionCrossLineStyle.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(KitIconOffsetX);
		p_Writer.Write(PlayerNameOffsetX);
		p_Writer.Write(SquadLeaderIconOffsetX);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PlayerFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DecorationLineLength);
		p_Writer.Write(SquadBarOffsetX);
		p_Writer.Write(SquadBarOffsetY);
		p_Writer.Write(CommanderStatusOffsetX);
		p_Writer.Write(CommanderStatusOffsetY);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ShowPlayerRanksProfileOption));
		p_Writer.Write(p_EbxWriter.WriteString(ShowSquadMateRequestsProfileOption));
	}
}

