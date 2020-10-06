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
	[MemberInfoFlag(137), ContainerSize(4), ContainerEnum]
	public enum CompareOp : int
	{
		CompareOp_Equal = 0,
		CompareOp_NotEqual = 1,
		CompareOp_Greater = 2,
		CompareOp_Less = 3,
		CompareOp_GreaterOrEqual = 4,
		CompareOp_LessOrEqual = 5
	}

}
