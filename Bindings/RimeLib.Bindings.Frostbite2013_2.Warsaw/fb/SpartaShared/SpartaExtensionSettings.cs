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

namespace fb.SpartaShared;

[ContainerType(8, 80)]
public class SpartaExtensionSettings
	: fb.Core.SystemSettings
{
	public SpartaExtensionSettings()
	{
		//SystemSettings
		Name = @"Sparta";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string GatewayHost { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string GatewayProtocol { get; set; } = @"https";
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string ServiceOverride { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string SpartaSuperBundleAssetPath { get; set; } = string.Empty;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string SpartaBundleAssePath { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public bool OnlineDebugEnabled { get; set; } = false;
	
	[ContainerField(0x49), LayoutImmutable, Blittable, JsonProperty(Order = 73)]
	public bool OriginAccountAssocWorkaroundsEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(GatewayHost));
		p_Writer.Write(p_EbxWriter.WriteString(GatewayProtocol));
		p_Writer.Write(p_EbxWriter.WriteString(ServiceOverride));
		p_Writer.Write(p_EbxWriter.WriteString(SpartaSuperBundleAssetPath));
		p_Writer.Write(p_EbxWriter.WriteString(SpartaBundleAssePath));
		p_Writer.Write(OnlineDebugEnabled);
		p_Writer.Write(OriginAccountAssocWorkaroundsEnabled);
		p_Writer.WriteNullBytes(6);
	}
}

