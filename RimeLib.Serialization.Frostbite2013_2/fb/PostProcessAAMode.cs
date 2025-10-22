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


namespace fb.WorldRender;

[ContainerType(1, 4)]
public enum PostProcessAAMode : int
{
	PostProcessAAMode_None = 0,
	PostProcessAAMode_FxaaLow = 1,
	PostProcessAAMode_FxaaMedium = 2,
	PostProcessAAMode_FxaaHigh = 3,
	PostProcessAAMode_Smaa1x = 4,
	PostProcessAAMode_SmaaT2x = 5,
}

