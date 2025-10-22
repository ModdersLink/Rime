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


namespace fb.Core;

[ContainerType(1, 4)]
public enum AudioCurveType : int
{
	AudioCurveType_Spline = 0,
	AudioCurveType_Smooth = 1,
	AudioCurveType_Linear = 2,
	AudioCurveType_NearestValue = 3,
}

