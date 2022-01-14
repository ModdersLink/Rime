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
	public enum BlurFilter : int
	{
		BfNone = 0,
		BfGaussian3Pixels = 1,
		BfGaussian5Pixels = 2,
		BfGaussian7Pixels = 3,
		BfGaussian9Pixels = 4,
		BfGaussian15Pixels = 5,
		BfGaussian31Pixels = 6
	}

}
