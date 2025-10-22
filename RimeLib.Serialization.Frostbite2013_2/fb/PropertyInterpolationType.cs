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
public enum PropertyInterpolationType : int
{
	PropertyInterpolationType_Linear = 0,
	PropertyInterpolationType_Quad = 1,
	PropertyInterpolationType_Cubic = 2,
	PropertyInterpolationType_Quart = 3,
	PropertyInterpolationType_Quint = 4,
	PropertyInterpolationType_Expo = 5,
	PropertyInterpolationType_Sine = 6,
	PropertyInterpolationType_Circ = 7,
	PropertyInterpolationType_Back = 8,
	PropertyInterpolationType_Elastic = 9,
	PropertyInterpolationType_Bounce = 10,
	PropertyInterpolationType_Count = 11,
}

