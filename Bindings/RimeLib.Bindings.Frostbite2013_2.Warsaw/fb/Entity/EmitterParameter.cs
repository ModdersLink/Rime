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


namespace fb.Entity;

[ContainerType(1, 4)]
public enum EmitterParameter : int
{
	EmitterParameterNone = 0,
	EmitterParameter1 = 1,
	EmitterParameter2 = 2,
	EmitterParameter3 = 3,
	EmitterParameterVec = 5,
	EmitterParameterVecAverage = 7,
	EmitterParameterDistance = 6,
	EmitterParameterCount = 8,
	EmitterParameter4 = 4,
}

