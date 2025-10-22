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


namespace fb.Venice;

[ContainerType(1, 4)]
public enum TabletCommanderGameMode : int
{
	TabletCommanderGameMode_None = -1,
	TabletCommanderGameMode_Conquest = 0,
	TabletCommanderGameMode_Obliteration = 1,
	TabletCommanderGameMode_Rush = 2,
	TabletCommanderGameMode_Titan = 3,
}

