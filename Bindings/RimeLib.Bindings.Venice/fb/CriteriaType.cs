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
	public enum CriteriaType : int
	{
		CriteriaType_IAR_InARound = 0,
		CriteriaType_IAR_InARoundResetIfValueNotChanged = 1,
		CriteriaType_IAS_InASpawn = 2,
		CriteriaType_IAS_InASpawnNotResetable = 3,
		CriteriaType_IAS_InASpawnWithoutTakingDamage = 4,
		CriteriaType_GLOBAL_AllTimeTotal = 5,
		CriteriaType_GLOBAL_HighestValue = 6,
		CriteriaType_GLOBAL_HighestValueAlways = 7,
		CriteriaType_GLOBAL_HighestValueInASpawn = 8,
		CriteriaType_GLOBAL_LowestValueAlways = 9,
		CriteriaType_IfNotTrue = 10,
		CriteriaType_IAD_InADeathStreak = 11,
		CriteriaType_GLOBAL_HighestValuePersistent = 12,
		CriteriaType_LAST_ITEM = 13
	}

}
