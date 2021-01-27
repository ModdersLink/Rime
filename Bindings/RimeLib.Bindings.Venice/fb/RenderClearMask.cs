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
	[ContainerType(Flags: 137, Size: 4  )]
	public enum RenderClearMask : int
	{
		RenderClearMask_Color0 = 1,
		RenderClearMask_Color1 = 2,
		RenderClearMask_Color2 = 4,
		RenderClearMask_Color3 = 8,
		RenderClearMask_Color4 = 16,
		RenderClearMask_Color5 = 32,
		RenderClearMask_Color6 = 64,
		RenderClearMask_Color7 = 128,
		RenderClearMask_Color = 255,
		RenderClearMask_Depth = 256,
		RenderClearMask_Stencil = 512,
		RenderClearMask_All = 1023
	}

}
