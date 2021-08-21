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
	public enum AreaTriggerInclude : int
	{
		ATNone = 0,
		ATAll = 1,
		ATPlayers = 2,
		ATAI = 3,
		ATAI_Allies = 4,
		ATAI_Enemies = 5,
		ATPlayersNotInVehicle = 6
	}

}
