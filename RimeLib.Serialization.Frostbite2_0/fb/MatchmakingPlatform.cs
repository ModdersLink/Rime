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

namespace fb
{
	[ContainerType(4, 4)]
	public enum MatchmakingPlatform : int
	{
		MatchmakingPlatform_PC = 0,
		MatchmakingPlatform_Console = 1,
		MatchmakingPlatform_360 = 2,
		MatchmakingPlatform_PS3 = 3,
		MatchmakingPlatform_Any = 4
	}

}
