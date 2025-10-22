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


namespace fb.Audio;

[ContainerType(1, 4)]
public enum TimeStretchEfficiency : int
{
	TimeStretchEfficiency_1 = 1,
	TimeStretchEfficiency_2 = 2,
	TimeStretchEfficiency_3 = 4,
	TimeStretchEfficiency_4 = 8,
	TimeStretchEfficiency_5 = 12,
	TimeStretchEfficiency_6 = 16,
	TimeStretchEfficiency_7 = 20,
	TimeStretchEfficiency_8 = 24,
	TimeStretchEfficiency_9 = 28,
	TimeStretchEfficiency_10 = 32,
}

