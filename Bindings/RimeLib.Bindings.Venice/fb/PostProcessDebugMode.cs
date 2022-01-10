///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum PostProcessDebugMode : int
	{
		PpdmDefault = 0,
		PpdmBloom = 1,
		PpdmBloomStep = 2,
		PpdmDofBlur = 3,
		PpdmBlur = 4,
		PpdmBlurStep = 5,
		PpdmDepth = 6
	}

}
