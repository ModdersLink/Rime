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
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[MemberInfoFlag(137), ContainerEnum]
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
