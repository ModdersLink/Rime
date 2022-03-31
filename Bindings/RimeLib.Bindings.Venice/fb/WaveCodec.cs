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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum WaveCodec : int
	{
		WaveCodec_EaLayer3 = 0,
		WaveCodec_EaXma = 1,
		WaveCodec_Xas = 2,
		WaveCodec_EaSpeex = 3,
		WaveCodec_Pcm = 4,
		WaveCodec_Count = 5
	}

}
