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
	public enum EventCompareGateType : int
	{
		EventCompareGate_Equals = 0,
		EventCompareGate_NotEquals = 1,
		EventCompareGate_Less = 2,
		EventCompareGate_LessEquals = 3,
		EventCompareGate_Greater = 4,
		EventCompareGate_GreaterEquals = 5
	}

}
