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

[ContainerType(8, 120)]
public class LiveServerProxySettings
	: fb.Core.SystemSettings
{
	public LiveServerProxySettings()
	{
		//SystemSettings
		Name = @"LiveServerProxy";
	}
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string Host { get; set; } = @" receive.keeper.battlelog.com";
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int Port { get; set; } = 26800;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float DnsRefreshFrequency { get; set; } = 300.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float ServerQueryProviderSnapshotRefreshFrequency { get; set; } = 3.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public int ServerQueryProviderMaxQueriesPerSecond { get; set; } = 1000;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float LiveScoreboardProviderSnapshotRefreshFrequency { get; set; } = 3.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public string LiveScoreboardProviderUrl { get; set; } = @"https://keeper.test.battlelog.com";
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public int LiveScoreboardProviderRolloutModulo { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float MetricsProviderSnapshotRefreshFrequency { get; set; } = 10.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string MetricsProviderUrl { get; set; } = @"https://contact.test.battlelog.com";
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float DistroDataProviderSnapshotRefreshFrequency { get; set; } = 10.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string DistroDataProviderUrl { get; set; } = @"http://127.0.0.1:8183/api/gameserver/";
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool EditorialConfigEnabled { get; set; } = true;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool ServerQueryProviderEnabled { get; set; } = true;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool LiveScoreboardProviderEnabled { get; set; } = true;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool LiveScoreboardProviderUseUDP { get; set; } = false;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool MetricsProviderEnabled { get; set; } = true;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool MetricsProviderKeyConflictDetectionEnabled { get; set; } = true;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool MetricsProviderGzipCompressionEnabled { get; set; } = true;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool DistroDataProviderEnabled { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool DistroDataProviderGzipCompressionEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Host));
		p_Writer.Write(Port);
		p_Writer.Write(DnsRefreshFrequency);
		p_Writer.Write(ServerQueryProviderSnapshotRefreshFrequency);
		p_Writer.Write(ServerQueryProviderMaxQueriesPerSecond);
		p_Writer.Write(LiveScoreboardProviderSnapshotRefreshFrequency);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(LiveScoreboardProviderUrl));
		p_Writer.Write(LiveScoreboardProviderRolloutModulo);
		p_Writer.Write(MetricsProviderSnapshotRefreshFrequency);
		p_Writer.Write(p_EbxWriter.WriteString(MetricsProviderUrl));
		p_Writer.Write(DistroDataProviderSnapshotRefreshFrequency);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DistroDataProviderUrl));
		p_Writer.Write(EditorialConfigEnabled);
		p_Writer.Write(Enabled);
		p_Writer.Write(ServerQueryProviderEnabled);
		p_Writer.Write(LiveScoreboardProviderEnabled);
		p_Writer.Write(LiveScoreboardProviderUseUDP);
		p_Writer.Write(MetricsProviderEnabled);
		p_Writer.Write(MetricsProviderKeyConflictDetectionEnabled);
		p_Writer.Write(MetricsProviderGzipCompressionEnabled);
		p_Writer.Write(DistroDataProviderEnabled);
		p_Writer.Write(DistroDataProviderGzipCompressionEnabled);
		p_Writer.WriteNullBytes(6);
	}
}

