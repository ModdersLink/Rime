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
	public enum StatPeriod : int
	{
		StatPeriod_AllTime = 0,
		StatPeriod_Monthly = 1,
		StatPeriod_Weekly = 2,
		StatPeriod_Daily = 3,
		StatPeriod_Size = 4,
		StatPeriod_Error = 5
	}

}
