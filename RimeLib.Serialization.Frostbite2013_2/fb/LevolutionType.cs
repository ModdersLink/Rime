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
public enum LevolutionType : int
{
	LevolutionType_Setpiece = 0,
	LevolutionType_TacticalDestruction = 1,
	LevolutionType_Interaction = 2,
	LevolutionType_Environmental = 3,
	LevolutionType_Backdrop = 4,
}

