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


namespace fb.Physics;

[ContainerType(1, 4)]
public enum ForceCondition : int
{
	FCNever = 0,
	FCNotCriticalDamaged = 1,
	FCCriticalDamaged = 2,
	FCNotOccupied = 3,
	FCOccupied = 4,
	FCAlways = 5,
}

