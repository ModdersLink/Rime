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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class MatchmakingCreateGameParameters :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public MatchmakingNetworkTopology GameTopology { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public MatchmakingPeer2PeerMode PeerMode { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public MatchmakingNetworkTopology VoipTopology { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public MatchmakingGameSettings Settings { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public List<MatchmakingGameAttribute> Attributes { get; set; } = new();
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public uint QueueCapacity { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) GameTopology);
			p_Writer.Write((int) PeerMode);
			p_Writer.Write((int) VoipTopology);
			Settings.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Attributes = p_EbxWriter.GetArrayWriter(Attributes.GetType(), Attributes.Count);
			p_Writer.Write(s_Attributes.ArrayIndex);
			foreach (var s_Entry in Attributes)
			{
				s_Entry.Serialize(s_Attributes.Writer, p_EbxWriter);
			}
			p_Writer.Write(QueueCapacity);
		}
	}
}
