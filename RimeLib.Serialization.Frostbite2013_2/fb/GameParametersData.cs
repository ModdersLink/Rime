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

[ContainerType(8, 88)]
public class GameParametersData
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string ServerName { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public PersistenceGameType GameType { get; set; } = PersistenceGameType.PersistenceGameType_Singleplayer;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public uint QueueCapacity { get; set; } = 0;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public uint Mod { get; set; } = 0;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public uint MaxSpectators { get; set; } = 0;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public GameNetworkTopology GameTopology { get; set; } = GameNetworkTopology.GameNetworkTopology_Disabled;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public GamePeer2PeerMode PeerMode { get; set; } = GamePeer2PeerMode.GamePeer2PeerMode_FullMesh;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public GameNetworkTopology VoipTopology { get; set; } = GameNetworkTopology.GameNetworkTopology_Disabled;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<GameAttributeData> Attributes { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public RefArray<GameRoleInformation> RoleConfiguration { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool OpenToInvites { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool OpenToMatchmaking { get; set; } = false;
	
	[ContainerField(0x52), LayoutImmutable, Blittable, JsonProperty(Order = 82)]
	public bool OpenToJoinByPlayer { get; set; } = false;
	
	[ContainerField(0x53), LayoutImmutable, Blittable, JsonProperty(Order = 83)]
	public bool OpenToBrowsing { get; set; } = true;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool Ranked { get; set; } = false;
	
	[ContainerField(0x55), LayoutImmutable, Blittable, JsonProperty(Order = 85)]
	public bool JoinInProgressSupported { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ServerName));
		p_Writer.Write((int) GameType);
		p_Writer.Write(QueueCapacity);
		p_Writer.Write(Mod);
		p_Writer.Write(MaxSpectators);
		p_Writer.Write((int) GameTopology);
		p_Writer.Write((int) PeerMode);
		p_Writer.Write((int) VoipTopology);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Attributes = p_EbxWriter.GetArrayWriter(Attributes.GetType(), Attributes.Count);
		p_Writer.Write(s_Attributes.ArrayIndex);
		foreach (var s_Entry in Attributes)
		{
			s_Entry.Serialize(s_Attributes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_RoleConfiguration = p_EbxWriter.GetArrayWriter(RoleConfiguration.GetType(), RoleConfiguration.Count);
		p_Writer.Write(s_RoleConfiguration.ArrayIndex);
		foreach (var s_Entry in RoleConfiguration)
		{
			s_RoleConfiguration.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(OpenToInvites);
		p_Writer.Write(OpenToMatchmaking);
		p_Writer.Write(OpenToJoinByPlayer);
		p_Writer.Write(OpenToBrowsing);
		p_Writer.Write(Ranked);
		p_Writer.Write(JoinInProgressSupported);
		p_Writer.WriteNullBytes(2);
	}
}

