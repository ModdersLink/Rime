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
	public enum DepthStencilCompareFunc : int
	{
		DepthStencilCompareFunc_Never = 0,
		DepthStencilCompareFunc_Less = 1,
		DepthStencilCompareFunc_Equal = 2,
		DepthStencilCompareFunc_LessEqual = 3,
		DepthStencilCompareFunc_Greater = 4,
		DepthStencilCompareFunc_NotEqual = 5,
		DepthStencilCompareFunc_GreaterEqual = 6,
		DepthStencilCompareFunc_Always = 7
	}

}
