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


namespace fb.Venice;

[ContainerType(1, 4)]
public enum PropertyInterpolationMode : int
{
	PropertyInterpolationMode_In = 0,
	PropertyInterpolationMode_Out = 1,
	PropertyInterpolationMode_InOut = 2,
	PropertyInterpolationMode_OutIn = 3,
	PropertyInterpolationMode_Count = 4,
}

