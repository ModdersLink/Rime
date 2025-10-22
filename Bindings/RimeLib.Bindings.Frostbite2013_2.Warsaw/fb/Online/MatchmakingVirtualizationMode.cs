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
public enum MatchmakingVirtualizationMode : int
{
	MatchmakingVirtualizationMode_Virtualized = 0,
	MatchmakingVirtualizationMode_Standard = 1,
	MatchmakingVirtualizationMode_Any = 2,
}

