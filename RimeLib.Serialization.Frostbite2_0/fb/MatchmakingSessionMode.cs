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
	[ContainerType(4, 4)]
	public enum MatchmakingSessionMode : int
	{
		MatchmakingSessionMode_FindDedicatedServer = 0,
		MatchmakingSessionMode_ResetDedicatedServer = 1,
		MatchmakingSessionMode_FindPeerGame = 2,
		MatchmakingSessionMode_CreatePeerGame = 3,
		MatchmakingSessionMode_Invalid = 4
	}

}
