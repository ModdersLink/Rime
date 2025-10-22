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


namespace fb.Emitter;

[ContainerType(1, 4)]
public enum TurbulenceNoiseType : int
{
	TurbulenceNoiseType_Random = 0,
	TurbulenceNoiseType_Perlin = 1,
	TurbulenceNoiseType_PerlinSimplex = 2,
	TurbulenceNoiseType_PerlinCurl = 3,
}

