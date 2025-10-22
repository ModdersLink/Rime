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
using fb.Online;

namespace fb.VeniceShared;

[ContainerType(8, 320)]
public class VeniceOnlineSettings
	: fb.Online.OnlineSettings
{
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public string ClientGameConfigurationOverride { get; set; } = string.Empty;
	
	[ContainerField(0xd8), JsonProperty(Order = 216)]
	public RefArray<EntitlementQuery> EntitlementQueries { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public CtrRef<GameModData> ModInfo { get; set; } = new();
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public string SonarVoipAddress { get; set; } = string.Empty;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public int QueueCapacityOverride { get; set; } = -1;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public DTagUploadPolicy DogTagUploadPolicy { get; set; } = DTagUploadPolicy.DTUP_FirstTimeSeenAndEndOfRound;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public uint PingPeriod { get; set; } = 10;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public string BattlelogReportURL { get; set; } = string.Empty;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public string BattlelogApiUrl { get; set; } = string.Empty;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public string InGamePartyAllowedLicenseList { get; set; } = string.Empty;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public uint MinCommanderRank { get; set; } = 10;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public string LogTransmitterUrl { get; set; } = @"https://contact.battlelog.com";
	
	[ContainerField(0x128), LayoutImmutable, Blittable, JsonProperty(Order = 296)]
	public uint MaxNoobRank { get; set; } = 10;
	
	[ContainerField(0x12c), LayoutImmutable, Blittable, JsonProperty(Order = 300)]
	public bool EnableSnowroller { get; set; } = false;
	
	[ContainerField(0x12d), LayoutImmutable, Blittable, JsonProperty(Order = 301)]
	public bool PunkBusterActivateClient { get; set; } = false;
	
	[ContainerField(0x12e), LayoutImmutable, Blittable, JsonProperty(Order = 302)]
	public bool PunkBusterActivateServer { get; set; } = false;
	
	[ContainerField(0x12f), LayoutImmutable, Blittable, JsonProperty(Order = 303)]
	public bool PunkBusterKillSwitchActivated { get; set; } = false;
	
	[ContainerField(0x130), LayoutImmutable, Blittable, JsonProperty(Order = 304)]
	public bool FairFightEnabled { get; set; } = false;
	
	[ContainerField(0x131), LayoutImmutable, Blittable, JsonProperty(Order = 305)]
	public bool BattlelogMidGameReportActive { get; set; } = true;
	
	[ContainerField(0x132), LayoutImmutable, Blittable, JsonProperty(Order = 306)]
	public bool IsCommander { get; set; } = false;
	
	[ContainerField(0x133), LayoutImmutable, Blittable, JsonProperty(Order = 307)]
	public bool EnableProgressionUpload { get; set; } = false;
	
	[ContainerField(0x134), LayoutImmutable, Blittable, JsonProperty(Order = 308)]
	public bool BlazeDisableDownloadFriendsStats { get; set; } = true;
	
	[ContainerField(0x135), LayoutImmutable, Blittable, JsonProperty(Order = 309)]
	public bool BlazeDisableAssociationLists { get; set; } = true;
	
	[ContainerField(0x136), LayoutImmutable, Blittable, JsonProperty(Order = 310)]
	public bool BlazeDisableAllStatsDownloading { get; set; } = true;
	
	[ContainerField(0x137), LayoutImmutable, Blittable, JsonProperty(Order = 311)]
	public bool DisableMiniGameBrowserAutoUpdate { get; set; } = true;
	
	[ContainerField(0x138), LayoutImmutable, Blittable, JsonProperty(Order = 312)]
	public bool DisableDurangoVoip { get; set; } = true;
	
	[ContainerField(0x139), LayoutImmutable, Blittable, JsonProperty(Order = 313)]
	public bool DisableInGameParty { get; set; } = false;
	
	[ContainerField(0x13a), LayoutImmutable, Blittable, JsonProperty(Order = 314)]
	public bool LogTransmitterEnabled { get; set; } = true;
	
	[ContainerField(0x13b), LayoutImmutable, Blittable, JsonProperty(Order = 315)]
	public bool isNoobOnly { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ClientGameConfigurationOverride));
		(RimeWriter Writer, uint ArrayIndex) s_EntitlementQueries = p_EbxWriter.GetArrayWriter(EntitlementQueries.GetType(), EntitlementQueries.Count);
		p_Writer.Write(s_EntitlementQueries.ArrayIndex);
		foreach (var s_Entry in EntitlementQueries)
		{
			s_EntitlementQueries.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ModInfo));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(SonarVoipAddress));
		p_Writer.Write(QueueCapacityOverride);
		p_Writer.Write((int) DogTagUploadPolicy);
		p_Writer.Write(PingPeriod);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(BattlelogReportURL));
		p_Writer.Write(p_EbxWriter.WriteString(BattlelogApiUrl));
		p_Writer.Write(p_EbxWriter.WriteString(InGamePartyAllowedLicenseList));
		p_Writer.Write(MinCommanderRank);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(LogTransmitterUrl));
		p_Writer.Write(MaxNoobRank);
		p_Writer.Write(EnableSnowroller);
		p_Writer.Write(PunkBusterActivateClient);
		p_Writer.Write(PunkBusterActivateServer);
		p_Writer.Write(PunkBusterKillSwitchActivated);
		p_Writer.Write(FairFightEnabled);
		p_Writer.Write(BattlelogMidGameReportActive);
		p_Writer.Write(IsCommander);
		p_Writer.Write(EnableProgressionUpload);
		p_Writer.Write(BlazeDisableDownloadFriendsStats);
		p_Writer.Write(BlazeDisableAssociationLists);
		p_Writer.Write(BlazeDisableAllStatsDownloading);
		p_Writer.Write(DisableMiniGameBrowserAutoUpdate);
		p_Writer.Write(DisableDurangoVoip);
		p_Writer.Write(DisableInGameParty);
		p_Writer.Write(LogTransmitterEnabled);
		p_Writer.Write(isNoobOnly);
		p_Writer.WriteNullBytes(4);
	}
}

