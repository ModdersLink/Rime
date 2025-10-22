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


namespace fb.VeniceShared;

[ContainerType(1, 4)]
public enum CriteriaType : int
{
	CriteriaType_IAR_InARound = 0,
	CriteriaType_IAR_InARoundResetIfValueNotChanged = 1,
	CriteriaType_IAS_InASpawn = 2,
	CriteriaType_IAS_InASpawnNotResetable = 3,
	CriteriaType_IAS_InASpawnWithoutTakingDamage = 4,
	CriteriaType_LEVEL_HighestValue = 5,
	CriteriaType_GLOBAL_AllTimeTotal = 6,
	CriteriaType_GLOBAL_HighestValue = 7,
	CriteriaType_GLOBAL_HighestValueAlways = 8,
	CriteriaType_GLOBAL_HighestValueInASpawn = 9,
	CriteriaType_GLOBAL_LowestValueAlways = 10,
	CriteriaType_IfNotTrue = 11,
	CriteriaType_IAD_InADeathStreak = 12,
	CriteriaType_LAST_ITEM = 13,
}

