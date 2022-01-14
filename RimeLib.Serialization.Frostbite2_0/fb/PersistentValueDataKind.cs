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
	public enum PersistentValueDataKind : int
	{
		PersistentValueDataKind_Raw = 0,
		PersistentValueDataKind_Seconds = 1,
		PersistentValueDataKind_Minutes = 2,
		PersistentValueDataKind_Hours = 3,
		PersistentValueDataKind_Percent = 4
	}

}
