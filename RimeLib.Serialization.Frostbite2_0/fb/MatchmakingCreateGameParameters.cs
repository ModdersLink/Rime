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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 32)]
	public partial class MatchmakingCreateGameParameters :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private MatchmakingNetworkTopology _GameTopology = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private MatchmakingPeer2PeerMode _PeerMode = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private MatchmakingNetworkTopology _VoipTopology = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private MatchmakingGameSettings _Settings = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<MatchmakingGameAttribute> _Attributes = new();
		
		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private uint _QueueCapacity;
		
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
