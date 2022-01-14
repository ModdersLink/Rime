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
	public enum EntityCreatorType : int
	{
		EntityCreatorType_Unknown = 0,
		EntityCreatorType_Level = 1,
		EntityCreatorType_Spawner = 2,
		EntityCreatorType_Owner = 3,
		EntityCreatorType_Ghost = 4
	}

}
