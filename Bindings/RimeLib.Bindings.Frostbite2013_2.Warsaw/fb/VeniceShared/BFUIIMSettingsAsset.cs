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

[ContainerType(16, 768)]
public class BFUIIMSettingsAsset
	: fb.GameShared.UIIMSettingsAsset
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public UIWorldIconConfiguration WorldIconCfg { get; set; } = new();
	
	[ContainerField(0x290), JsonProperty(Order = 656)]
	public UIMinimapIconConfiguration MapIconCfg { get; set; } = new();
	
	[ContainerField(0x2c0), JsonProperty(Order = 704)]
	public CtrRef<UIMinimapIconTextureAtlasAsset> IconAtlas { get; set; } = new();
	
	[ContainerField(0x2c8), JsonProperty(Order = 712)]
	public CtrRef<UIButtonsTextureAtlasAsset> ButtonsTextureAtlas { get; set; } = new();
	
	[ContainerField(0x2d0), JsonProperty(Order = 720)]
	public UIDeployConfiguration DeployCfg { get; set; } = new();
	
	[ContainerField(0x2d8), JsonProperty(Order = 728)]
	public UIChatConfiguration ChatConfig { get; set; } = new();
	
	[ContainerField(0x2e0), JsonProperty(Order = 736)]
	public UIAirRadarConfiguration AirRadarConfig { get; set; } = new();
	
	[ContainerField(0x2f0), JsonProperty(Order = 752)]
	public CtrRef<UIElementFontStyle> KeyboardKeyFont { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		WorldIconCfg.Serialize(p_Writer, p_EbxWriter);
		MapIconCfg.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(IconAtlas));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ButtonsTextureAtlas));
		p_Writer.WriteNullBytes(4);
		DeployCfg.Serialize(p_Writer, p_EbxWriter);
		ChatConfig.Serialize(p_Writer, p_EbxWriter);
		AirRadarConfig.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(KeyboardKeyFont));
		p_Writer.WriteNullBytes(12);
	}
}

