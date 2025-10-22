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


namespace fb.PathfindingShared;

[ContainerType(1, 4)]
public enum PathfindingChoice : int
{
	PathfindingChoice_Off = 0,
	PathfindingChoice_OnlyToStartPoint = 1,
	PathfindingChoice_On = 2,
}

