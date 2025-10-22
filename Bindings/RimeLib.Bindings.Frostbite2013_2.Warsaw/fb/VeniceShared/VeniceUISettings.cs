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

namespace fb.VeniceShared;

[ContainerType(8, 112)]
public class VeniceUISettings
	: fb.Core.SystemSettings
{
	public VeniceUISettings()
	{
		//SystemSettings
		Name = @"VeniceUI";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string MetaDataAssetPath { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string IMSettingsAssetPath { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string LoadingTransitionTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string SavingTransitionTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string ServerBannerTexturePath { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string GradientTexturePath { get; set; } = @"UI/Hud/gradient16x16";
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string PlatformOverride { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string TwinkleWidgetPath { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string TwinkleScreenPath { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool GetStatsInOnlineFlow { get; set; } = true;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool IsDemoMode { get; set; } = false;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool ShowConnectionHUDIcons { get; set; } = true;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool AllowNetworkGraphGen4b { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(MetaDataAssetPath));
		p_Writer.Write(p_EbxWriter.WriteString(IMSettingsAssetPath));
		p_Writer.Write(p_EbxWriter.WriteString(LoadingTransitionTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(SavingTransitionTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(ServerBannerTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(GradientTexturePath));
		p_Writer.Write(p_EbxWriter.WriteString(PlatformOverride));
		p_Writer.Write(p_EbxWriter.WriteString(TwinkleWidgetPath));
		p_Writer.Write(p_EbxWriter.WriteString(TwinkleScreenPath));
		p_Writer.Write(GetStatsInOnlineFlow);
		p_Writer.Write(IsDemoMode);
		p_Writer.Write(ShowConnectionHUDIcons);
		p_Writer.Write(AllowNetworkGraphGen4b);
		p_Writer.WriteNullBytes(4);
	}
}

