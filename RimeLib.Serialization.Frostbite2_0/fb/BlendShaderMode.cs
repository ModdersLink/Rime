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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 4)]
	public enum BlendShaderMode : int
	{
		BsmLerp = 0,
		BsmAdd = 1,
		BsmSubtract = 2,
		BsmMultiply = 3,
		BsmMultiply2x = 4,
		BsmScreen = 5,
		BsmDifference = 6,
		BsmLighten = 7,
		BsmDarken = 8,
		BsmOverlay = 9
	}

}
