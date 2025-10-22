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


namespace fb.BFAI2Data;

[ContainerType(1, 4)]
public enum CombatEnvironment : int
{
	CombatEnvironment_Default = 0,
	CombatEnvironment_Indoor = 1,
	CombatEnvironment_Outdoor = 2,
}

