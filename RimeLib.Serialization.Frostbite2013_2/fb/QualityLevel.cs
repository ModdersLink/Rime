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
public enum QualityLevel : int
{
	QualityLevel_Low = 0,
	QualityLevel_Medium = 1,
	QualityLevel_High = 2,
	QualityLevel_Ultra = 3,
	QualityLevel_All = 4,
	QualityLevel_Invalid = 5,
}

