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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum StatsMultiplicity : int
{
	StatsMultiplicity_Invalid = 0,
	StatsMultiplicity_Solo = 1,
	StatsMultiplicity_Club = 2,
	StatsMultiplicity_LAST_ITEM = 3,
}

