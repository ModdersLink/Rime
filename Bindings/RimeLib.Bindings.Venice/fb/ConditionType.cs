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
	public enum ConditionType : int
	{
		ConditionType_And = 0,
		ConditionType_Or = 1,
		ConditionType_XOr = 2,
		ConditionType_Equal = 3,
		ConditionType_Less = 4,
		ConditionType_Greater = 5,
		ConditionType_LessOrEqual = 6,
		ConditionType_GreaterOrEqual = 7
	}

}
