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
	public enum MatchmakingPlatform : int
	{
		MatchmakingPlatform_PC = 0,
		MatchmakingPlatform_Console = 1,
		MatchmakingPlatform_360 = 2,
		MatchmakingPlatform_PS3 = 3,
		MatchmakingPlatform_Any = 4
	}

}
