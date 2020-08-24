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
	[MemberInfoFlag(137), ContainerEnum]
	public enum MatchmakingSessionMode : int
	{
		MatchmakingSessionMode_FindDedicatedServer = 0,
		MatchmakingSessionMode_ResetDedicatedServer = 1,
		MatchmakingSessionMode_FindPeerGame = 2,
		MatchmakingSessionMode_CreatePeerGame = 3,
		MatchmakingSessionMode_Invalid = 4
	}

}
