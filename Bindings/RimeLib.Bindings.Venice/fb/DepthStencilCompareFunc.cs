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
