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
public enum AnimTangentType : int
{
	kTangentFixed = 0,
	kTangentLinear = 1,
	kTangentFlat = 2,
	kTangentStep = 3,
	kTangentStepNext = 4,
	kTangentSlow = 5,
	kTangentFast = 6,
	kTangentSmooth = 7,
	kTangentClamped = 8,
}

