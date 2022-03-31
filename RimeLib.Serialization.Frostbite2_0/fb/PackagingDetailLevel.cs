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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum PackagingDetailLevel : int
	{
		PackagingDetailLevel_Low = 0,
		PackagingDetailLevel_Medium = 1,
		PackagingDetailLevel_High = 2,
		PackagingDetailLevel_Base = 3,
		PackagingDetailLevel_Count = 4
	}

}
