///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4)]
	public class MatchmakingCreateGameParameters : FrostbiteContainer
	{
		[ContainerField(0)]
		public MatchmakingNetworkTopology GameTopology { get; set; } = new MatchmakingNetworkTopology(); // 0x0 (0)
		
		[ContainerField(4)]
		public MatchmakingPeer2PeerMode PeerMode { get; set; } = new MatchmakingPeer2PeerMode(); // 0x4 (4)
		
		[ContainerField(8)]
		public MatchmakingNetworkTopology VoipTopology { get; set; } = new MatchmakingNetworkTopology(); // 0x8 (8)
		
		[ContainerField(12)]
		public MatchmakingGameSettings Settings { get; set; } = new MatchmakingGameSettings(); // 0xC (12)
		
		[ContainerField(24)]
		public List<MatchmakingGameAttribute> Attributes { get; set; } = new List<MatchmakingGameAttribute>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public uint QueueCapacity { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3949212722:
						GameTopology = (MatchmakingNetworkTopology) Enum.ToObject(typeof(MatchmakingNetworkTopology), p_Value);
					break;

				case 3663647812:
						PeerMode = (MatchmakingPeer2PeerMode) Enum.ToObject(typeof(MatchmakingPeer2PeerMode), p_Value);
					break;

				case 3415203484:
						VoipTopology = (MatchmakingNetworkTopology) Enum.ToObject(typeof(MatchmakingNetworkTopology), p_Value);
					break;

				case 649772672:
					Settings = (MatchmakingGameSettings) p_Value;
					break;

				case 3723762538:
					Attributes = (List<MatchmakingGameAttribute>) p_Value;
					break;

				case 2357148928:
					QueueCapacity = (uint) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3949212722:
					return GameTopology;

				case 3663647812:
					return PeerMode;

				case 3415203484:
					return VoipTopology;

				case 649772672:
					return Settings;

				case 3723762538:
					return Attributes;

				case 2357148928:
					return QueueCapacity;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3949212722:
					return typeof(MatchmakingCreateGameParameters).GetProperty(nameof(GameTopology));

				case 3663647812:
					return typeof(MatchmakingCreateGameParameters).GetProperty(nameof(PeerMode));

				case 3415203484:
					return typeof(MatchmakingCreateGameParameters).GetProperty(nameof(VoipTopology));

				case 649772672:
					return typeof(MatchmakingCreateGameParameters).GetProperty(nameof(Settings));

				case 3723762538:
					return typeof(MatchmakingCreateGameParameters).GetProperty(nameof(Attributes));

				case 2357148928:
					return typeof(MatchmakingCreateGameParameters).GetProperty(nameof(QueueCapacity));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
