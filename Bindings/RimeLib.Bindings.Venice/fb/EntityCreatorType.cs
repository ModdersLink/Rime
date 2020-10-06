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
	public enum EntityCreatorType : int
	{
		EntityCreatorType_Unknown = 0,
		EntityCreatorType_Level = 1,
		EntityCreatorType_Spawner = 2,
		EntityCreatorType_Owner = 3,
		EntityCreatorType_Ghost = 4
	}

}
