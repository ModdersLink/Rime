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
public enum MatchmakingRankedMode : int
{
	MatchmakingRankedMode_Ranked = 0,
	MatchmakingRankedMode_Unranked = 1,
	MatchmakingRankedMode_Any = 2,
}

