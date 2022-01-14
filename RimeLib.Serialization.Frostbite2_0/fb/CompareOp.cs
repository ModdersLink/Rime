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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
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
