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
