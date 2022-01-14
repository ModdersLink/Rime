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

namespace fb
{
	[ContainerType(4, 4)]
	public enum MatchmakingPeer2PeerMode : int
	{
		MatchmakingPeer2PeerMode_FullMesh = 0,
		MatchmakingPeer2PeerMode_PartialMesh = 1,
		MatchmakingPeer2PeerMode_DirtyCastFailover = 2
	}

}
