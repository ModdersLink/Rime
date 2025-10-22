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
public enum SoundWaveStreamingMode : int
{
	SoundWaveStreamingMode_Normal = 0,
	SoundWaveStreamingMode_ZeroLatency = 1,
	SoundWaveStreamingMode_LowLatency = 2,
}

