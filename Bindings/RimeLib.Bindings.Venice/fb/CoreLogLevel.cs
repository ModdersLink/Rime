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
	public enum CoreLogLevel : int
	{
		CllNone = 0,
		CllEventRecord = 1,
		CllCrash = 2,
		CllError = 3,
		CllAssert = 4,
		CllFatalAssert = 5,
		CllValidate = 6,
		CllWarning = 7,
		CllInfo = 8,
		CllOutput = 9,
		CllDebug = 10
	}

}
