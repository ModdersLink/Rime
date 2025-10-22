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


namespace fb.Audio;

[ContainerType(1, 4)]
public enum MixGroupPropertyType : int
{
	MixGroupPropertyType_Gain = 0,
	MixGroupPropertyType_Pitch = 1,
	MixGroupPropertyType_Lfe = 2,
	MixGroupPropertyType_Reverb = 3,
	MixGroupPropertyType_Lpf = 4,
	MixGroupPropertyTypeCount = 5,
}

