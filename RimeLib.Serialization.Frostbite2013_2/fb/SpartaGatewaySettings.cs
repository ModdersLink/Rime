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

[ContainerType(8, 64)]
public class SpartaGatewaySettings
	: fb.Core.SystemSettings
{
	public SpartaGatewaySettings()
	{
		//SystemSettings
		Name = @"SpartaGateway";
	}
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<SpartaGatewayToOnlineEnvironmentMapping> ManifestSettings { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint ManifestDownloadNumRetries { get; set; } = 3;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public string GatewayHostOverride { get; set; } = string.Empty;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool RemoteManifestFeatureEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ManifestSettings = p_EbxWriter.GetArrayWriter(ManifestSettings.GetType(), ManifestSettings.Count);
		p_Writer.Write(s_ManifestSettings.ArrayIndex);
		foreach (var s_Entry in ManifestSettings)
		{
			s_Entry.Serialize(s_ManifestSettings.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ManifestDownloadNumRetries);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(GatewayHostOverride));
		p_Writer.Write(RemoteManifestFeatureEnabled);
		p_Writer.WriteNullBytes(7);
	}
}

