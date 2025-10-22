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


namespace fb.Terrain;

[ContainerType(1, 4)]
public enum UndergrowthRotationMode : int
{
	UndergrowthRotationMode_Random = 0,
	UndergrowthRotationMode_TowardsSlope = 1,
	UndergrowthRotationMode_Fixed = 2,
}

