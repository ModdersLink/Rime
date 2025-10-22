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
public enum TabletCommanderObjectiveType : int
{
	TabletCommanderObjectiveType_HomeBase = 0,
	TabletCommanderObjectiveType_BombSite = 1,
	TabletCommanderObjectiveType_RushCrate = 2,
	TabletCommanderObjectiveType_CapturePoint = 3,
	TabletCommanderObjectiveType_ForwardBase = 4,
	TabletCommanderObjectiveType_Count = 5,
}

