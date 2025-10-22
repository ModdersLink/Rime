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

namespace fb.GameShared;

[ContainerType(8, 128)]
public class NetworkSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public uint ProtocolVersion { get; set; } = 0;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string TitleId { get; set; } = @"0x00000000";
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint ClientPort { get; set; } = 25100;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint ServerPort { get; set; } = 25200;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint MaxGhostCount { get; set; } = 8192;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint GhostReserveAfterDeleteCount { get; set; } = 1024;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public uint MaxClientToServerGhostCount { get; set; } = 8;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public uint ClientToServerGhostReserveAfterDeleteCount { get; set; } = 2;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public uint MaxClientCount { get; set; } = 68;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public uint MaxClientFrameSize { get; set; } = 2048;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public uint MaxServerFrameSize { get; set; } = 65536;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public string XlspAddress { get; set; } = string.Empty;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public string ServerAddress { get; set; } = string.Empty;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public string ClientConnectionDebugFilePrefix { get; set; } = string.Empty;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public string ServerConnectionDebugFilePrefix { get; set; } = string.Empty;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float TimeNudgeGhostFrequencyFactor { get; set; } = 1.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float TimeNudgeBias { get; set; } = 0.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ConnectTimeout { get; set; } = 15.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float PacketLossLogInterval { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float DefaultHighFrequency { get; set; } = 30.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool IncrementServerPortOnFail { get; set; } = true;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool UseFrameManager { get; set; } = false;
	
	[ContainerField(0x7e), LayoutImmutable, Blittable, JsonProperty(Order = 126)]
	public bool TimeSyncEnabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ProtocolVersion);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(TitleId));
		p_Writer.Write(ClientPort);
		p_Writer.Write(ServerPort);
		p_Writer.Write(MaxGhostCount);
		p_Writer.Write(GhostReserveAfterDeleteCount);
		p_Writer.Write(MaxClientToServerGhostCount);
		p_Writer.Write(ClientToServerGhostReserveAfterDeleteCount);
		p_Writer.Write(MaxClientCount);
		p_Writer.Write(MaxClientFrameSize);
		p_Writer.Write(MaxServerFrameSize);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(XlspAddress));
		p_Writer.Write(p_EbxWriter.WriteString(ServerAddress));
		p_Writer.Write(p_EbxWriter.WriteString(ClientConnectionDebugFilePrefix));
		p_Writer.Write(p_EbxWriter.WriteString(ServerConnectionDebugFilePrefix));
		p_Writer.Write(TimeNudgeGhostFrequencyFactor);
		p_Writer.Write(TimeNudgeBias);
		p_Writer.Write(ConnectTimeout);
		p_Writer.Write(PacketLossLogInterval);
		p_Writer.Write(DefaultHighFrequency);
		p_Writer.Write(IncrementServerPortOnFail);
		p_Writer.Write(UseFrameManager);
		p_Writer.Write(TimeSyncEnabled);
		p_Writer.WriteNullBytes(1);
	}
}

