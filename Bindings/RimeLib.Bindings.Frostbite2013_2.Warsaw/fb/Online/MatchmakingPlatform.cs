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


namespace fb.Online;

[ContainerType(1, 4)]
public enum MatchmakingPlatform : int
{
	MatchmakingPlatform_PC = 0,
	MatchmakingPlatform_PCGen4 = 1,
	MatchmakingPlatform_Gen4 = 2,
	MatchmakingPlatform_Gen3 = 3,
	MatchmakingPlatform_Console = 4,
	MatchmakingPlatform_360 = 5,
	MatchmakingPlatform_PS3 = 6,
	MatchmakingPlatform_Durango = 7,
	MatchmakingPlatform_Kettle = 8,
	MatchmakingPlatform_Any = 9,
}

