///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Flags: 137, Size: 4  )]
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
