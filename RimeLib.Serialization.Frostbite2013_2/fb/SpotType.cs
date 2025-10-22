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
public enum SpotType : int
{
	SpotType_None = 0,
	SpotType_Active = 1,
	SpotType_Passive = 2,
	SpotType_Radar = 3,
	SpotType_Unspottable = 4,
	SpotType_Auto = 5,
	SpotType_Count = 6,
}

