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
public enum SoundGraphPluginConnectionType : int
{
	SoundGraphPluginConnectionType_Unconnected = 0,
	SoundGraphPluginConnectionType_Signal = 1,
	SoundGraphPluginConnectionType_Bus = 2,
}

