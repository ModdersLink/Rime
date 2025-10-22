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


namespace fb.Render;

[ContainerType(1, 4)]
public enum TonemapMethod : int
{
	TonemapMethod_None = 3,
	TonemapMethod_Linear = 0,
	TonemapMethod_Filmic = 1,
	TonemapMethod_FilmicNeutral = 2,
	TonemapMethodCount = 3,
}

