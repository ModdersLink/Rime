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
	public enum StencilOperation : int
	{
		StencilOperation_Keep = 0,
		StencilOperation_Zero = 1,
		StencilOperation_Replace = 2,
		StencilOperation_IncrementSaturate = 3,
		StencilOperation_DecrementSaturate = 4,
		StencilOperation_Invert = 5,
		StencilOperation_IncrementWrap = 6,
		StencilOperation_DecrementWrap = 7
	}

}
