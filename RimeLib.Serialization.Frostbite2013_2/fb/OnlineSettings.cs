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

namespace fb.Online;

[ContainerType(8, 208)]
public class OnlineSettings
	: fb.Core.SystemSettings
{
	public OnlineSettings()
	{
		//SystemSettings
		Name = @"Online";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public BackendType Backend { get; set; } = BackendType.Backend_Lan;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public BackendType PeerBackend { get; set; } = BackendType.Backend_Peer;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public OnlineEnvironment Environment { get; set; } = OnlineEnvironment.OnlineEnvironment_Development;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public OnlineEnvironment ResolvedEnvironment { get; set; } = OnlineEnvironment.OnlineEnvironment_Production;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<OnlineProviderAsset> Provider { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<OnlinePlatformConfiguration> Platforms { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string ServiceNameOverride { get; set; } = string.Empty;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public int BlazeLogLevel { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public int DirtySockLogLevel { get; set; } = 3;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public CtrRef<RichPresenceData> RichPresence { get; set; } = new();
	
	[ContainerField(0x58), JsonProperty(Order = 88)]
	public CtrRef<LicenseConfiguration> LicenseConfig { get; set; } = new();
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string MatchmakingOptions { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public string MatchmakingMode { get; set; } = string.Empty;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string Region { get; set; } = @"AC";
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public string Country { get; set; } = @"AQ";
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public string PingSite { get; set; } = string.Empty;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public string MatchmakingToken { get; set; } = string.Empty;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public uint NegativeUserCacheRefreshPeriod { get; set; } = 3600;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string ServerLoginEmail { get; set; } = string.Empty;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public string ServerLoginPassword { get; set; } = string.Empty;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string ServerLoginPersonaName { get; set; } = string.Empty;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public int BlazeServerConnectionTimeout { get; set; } = 10000;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public int BlazeServerTimeout { get; set; } = 10000;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public int BlazeClientConnectionTimeout { get; set; } = 13000;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public int BlazeClientTimeout { get; set; } = 13000;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public int DirtySockServerPacketQueueCapacity { get; set; } = 128;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public bool ClientIsPresenceEnabled { get; set; } = true;
	
	[ContainerField(0xc5), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
	public bool ServerIsPresenceEnabled { get; set; } = true;
	
	[ContainerField(0xc6), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
	public bool UseExternalLoginFlow { get; set; } = false;
	
	[ContainerField(0xc7), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
	public bool IsSecure { get; set; } = true;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public bool EnableQoS { get; set; } = true;
	
	[ContainerField(0xc9), LayoutImmutable, Blittable, JsonProperty(Order = 201)]
	public bool MatchmakeImmediately { get; set; } = false;
	
	[ContainerField(0xca), LayoutImmutable, Blittable, JsonProperty(Order = 202)]
	public bool ServerIsReconfigurable { get; set; } = false;
	
	[ContainerField(0xcb), LayoutImmutable, Blittable, JsonProperty(Order = 203)]
	public bool SupportHostMigration { get; set; } = false;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public bool ServerAllowAnyReputation { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Backend);
		p_Writer.Write((int) PeerBackend);
		p_Writer.Write((int) Environment);
		p_Writer.Write((int) ResolvedEnvironment);
		p_Writer.Write(p_EbxWriter.WriteImport(Provider));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Platforms = p_EbxWriter.GetArrayWriter(Platforms.GetType(), Platforms.Count);
		p_Writer.Write(s_Platforms.ArrayIndex);
		foreach (var s_Entry in Platforms)
		{
			s_Entry.Serialize(s_Platforms.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ServiceNameOverride));
		p_Writer.Write(BlazeLogLevel);
		p_Writer.Write(DirtySockLogLevel);
		p_Writer.Write(p_EbxWriter.WriteImport(RichPresence));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(LicenseConfig));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(MatchmakingOptions));
		p_Writer.Write(p_EbxWriter.WriteString(MatchmakingMode));
		p_Writer.Write(p_EbxWriter.WriteString(Region));
		p_Writer.Write(p_EbxWriter.WriteString(Country));
		p_Writer.Write(p_EbxWriter.WriteString(PingSite));
		p_Writer.Write(p_EbxWriter.WriteString(MatchmakingToken));
		p_Writer.Write(NegativeUserCacheRefreshPeriod);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(ServerLoginEmail));
		p_Writer.Write(p_EbxWriter.WriteString(ServerLoginPassword));
		p_Writer.Write(p_EbxWriter.WriteString(ServerLoginPersonaName));
		p_Writer.Write(BlazeServerConnectionTimeout);
		p_Writer.Write(BlazeServerTimeout);
		p_Writer.Write(BlazeClientConnectionTimeout);
		p_Writer.Write(BlazeClientTimeout);
		p_Writer.Write(DirtySockServerPacketQueueCapacity);
		p_Writer.Write(ClientIsPresenceEnabled);
		p_Writer.Write(ServerIsPresenceEnabled);
		p_Writer.Write(UseExternalLoginFlow);
		p_Writer.Write(IsSecure);
		p_Writer.Write(EnableQoS);
		p_Writer.Write(MatchmakeImmediately);
		p_Writer.Write(ServerIsReconfigurable);
		p_Writer.Write(SupportHostMigration);
		p_Writer.Write(ServerAllowAnyReputation);
		p_Writer.WriteNullBytes(3);
	}
}

