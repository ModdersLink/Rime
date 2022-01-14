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
	public enum PersistentValueHistoryType : int
	{
		PersistentValueHistoryType_None = 0,
		PersistentValueHistoryType_Delta = 1,
		PersistentValueHistoryType_DeltaAndAbsolute = 2,
		PersistentValueHistoryType_HistoryOnly = 3
	}

}
