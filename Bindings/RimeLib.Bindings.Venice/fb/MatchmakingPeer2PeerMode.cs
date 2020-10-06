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
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
	public enum MatchmakingPeer2PeerMode : int
	{
		MatchmakingPeer2PeerMode_FullMesh = 0,
		MatchmakingPeer2PeerMode_PartialMesh = 1,
		MatchmakingPeer2PeerMode_DirtyCastFailover = 2
	}

}
