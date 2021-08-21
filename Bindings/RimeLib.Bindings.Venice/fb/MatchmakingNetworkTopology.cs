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
	[ContainerType(Flags: 137, Size: 4  )]
	public enum MatchmakingNetworkTopology : int
	{
		MatchmakingNetworkTopology_Disabled = 0,
		MatchmakingNetworkTopology_Peer2Peer = 1,
		MatchmakingNetworkTopology_PeerHosted = 2,
		MatchmakingNetworkTopology_DedicatedServer = 3
	}

}
