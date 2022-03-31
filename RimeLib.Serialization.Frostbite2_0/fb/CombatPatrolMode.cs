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
	public enum CombatPatrolMode : int
	{
		CombatPatrolMode_MustStayOnPath = 0,
		CombatPatrolMode_FreeToFight = 1,
		CombatPatrolMode_FreeToFightAtDestination = 2
	}

}
