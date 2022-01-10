///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class MatchmakingCreateGameParameters
	{
		[ContainerField(0)]
		public MatchmakingNetworkTopology GameTopology { get; set; } = new();
		
		[ContainerField(4)]
		public MatchmakingPeer2PeerMode PeerMode { get; set; } = new();
		
		[ContainerField(8)]
		public MatchmakingNetworkTopology VoipTopology { get; set; } = new();
		
		[ContainerField(12)]
		public MatchmakingGameSettings Settings { get; set; } = new();
		
		[ContainerField(24)]
		public List<MatchmakingGameAttribute> Attributes { get; set; } = new();
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint QueueCapacity { get; set; }
		
		public static void Deserialize(MatchmakingCreateGameParameters p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.GameTopology = (MatchmakingNetworkTopology) p_Reader.ReadInt32();
			p_Instance.PeerMode = (MatchmakingPeer2PeerMode) p_Reader.ReadInt32();
			p_Instance.VoipTopology = (MatchmakingNetworkTopology) p_Reader.ReadInt32();
			fb.MatchmakingGameSettings.Deserialize(p_Instance.Settings, p_Reader, p_Parser);
			p_Instance.Attributes.Clear();
			(RimeReader Reader, uint Count) s_Attributes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Attributes.Count; ++i)
			{
				var s_Value = new MatchmakingGameAttribute();
				fb.MatchmakingGameAttribute.Deserialize(s_Value, s_Attributes.Reader, p_Parser);
				p_Instance.Attributes.Add(s_Value);
			}
			
			s_Attributes.Reader.Dispose();
			p_Instance.QueueCapacity = p_Reader.ReadUInt32();
		}
	}
}
