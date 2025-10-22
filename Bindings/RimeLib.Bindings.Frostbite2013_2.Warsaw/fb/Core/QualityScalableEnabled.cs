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
public enum QualityScalableEnabled : int
{
	QualityScalableEnabled_Low = 0,
	QualityScalableEnabled_Medium = 1,
	QualityScalableEnabled_High = 2,
	QualityScalableEnabled_Ultra = 3,
	QualityScalableEnabled_Disabled = 4,
}

