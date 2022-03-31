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
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
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
