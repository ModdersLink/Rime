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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum ProfileOptionsType : int
	{
		GstAudio = 0,
		GstRender = 1,
		GstInput = 2,
		GstAI = 3,
		GstGameplay = 4,
		GstPlayerProfile = 5,
		GstPersistence = 6,
		GstBinary = 7,
		GstKeyBinding = 8,
		GstCount = 9
	}

}
