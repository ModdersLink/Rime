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

namespace fb
{
	[ContainerType(4, 4)]
	public enum RenderWriteMask : int
	{
		RenderWriteMask_None = 0,
		RenderWriteMask_Red = 1,
		RenderWriteMask_Green = 2,
		RenderWriteMask_Blue = 4,
		RenderWriteMask_Color = 7,
		RenderWriteMask_Alpha = 8,
		RenderWriteMask_All = 15
	}

}
