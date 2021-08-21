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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 32)]
	public class MatchmakingCreateGameParameters : FrostbiteContainer
	{
		[ContainerField(Name: "GameTopology", Offset: 0, NameHash: 3949212722, Flags: 137)]
		public MatchmakingNetworkTopology GameTopology { get; set; } = new MatchmakingNetworkTopology(); // 0x0 (0)
		
		[ContainerField(Name: "PeerMode", Offset: 4, NameHash: 3663647812, Flags: 137)]
		public MatchmakingPeer2PeerMode PeerMode { get; set; } = new MatchmakingPeer2PeerMode(); // 0x4 (4)
		
		[ContainerField(Name: "VoipTopology", Offset: 8, NameHash: 3415203484, Flags: 137)]
		public MatchmakingNetworkTopology VoipTopology { get; set; } = new MatchmakingNetworkTopology(); // 0x8 (8)
		
		[ContainerField(Name: "Settings", Offset: 12, NameHash: 649772672, Flags: 41)]
		public MatchmakingGameSettings Settings { get; set; } = new MatchmakingGameSettings(); // 0xC (12)
		
		[ContainerField(Name: "Attributes", Offset: 24, NameHash: 3723762538, Flags: 65)]
		public List<MatchmakingGameAttribute> Attributes { get; set; } = new List<MatchmakingGameAttribute>(); // 0x18 (24)
		
		[ContainerField(Name: "QueueCapacity", Offset: 28, NameHash: 2357148928, Flags: 49421), LayoutImmutable, Blittable]
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
