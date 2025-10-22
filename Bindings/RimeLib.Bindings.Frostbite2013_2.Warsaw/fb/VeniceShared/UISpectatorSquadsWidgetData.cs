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

[ContainerType(16, 192)]
public class UISpectatorSquadsWidgetData
	: fb.VeniceShared.UISpectatorWidgetData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIWidgetBlueprint> SquadTemplate { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIWidgetBlueprint> PlayerTemplate { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor DisabledKitIconColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIElementFontStyle> DisabledPlayerFontStyle { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float SquadNarrowWidth { get; set; } = 250.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float SquadSpacing { get; set; } = 10.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float SquadTeamSpacing { get; set; } = 10.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float PlayerSpacingY { get; set; } = 4.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float AnimTime { get; set; } = 0.150f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public bool SquadboxHeaderUsesTeamColor { get; set; } = true;
	
	[ContainerField(0xbd), LayoutImmutable, Blittable, JsonProperty(Order = 189)]
	public bool SquadboxExtensionUsesTeamColor { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SquadTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PlayerTemplate));
		p_Writer.WriteNullBytes(12);
		DisabledKitIconColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(DisabledPlayerFontStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SquadNarrowWidth);
		p_Writer.Write(SquadSpacing);
		p_Writer.Write(SquadTeamSpacing);
		p_Writer.Write(PlayerSpacingY);
		p_Writer.Write(AnimTime);
		p_Writer.Write(SquadboxHeaderUsesTeamColor);
		p_Writer.Write(SquadboxExtensionUsesTeamColor);
		p_Writer.WriteNullBytes(2);
	}
}

