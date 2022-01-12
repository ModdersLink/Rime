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
		
	}
}
