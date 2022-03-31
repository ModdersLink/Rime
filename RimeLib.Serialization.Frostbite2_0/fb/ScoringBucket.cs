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
	public enum ScoringBucket : int
	{
		ScoringBucket_General = 0,
		ScoringBucket_Teamwork = 1,
		ScoringBucket_Bonus = 2,
		ScoringBucket_Squad = 3,
		ScoringBucket_Objective = 4,
		ScoringBucket_Award = 5,
		ScoringBucket_VehicleMBT = 6,
		ScoringBucket_VehicleIFV = 7,
		ScoringBucket_VehicleAA = 8,
		ScoringBucket_VehicleAttackHeli = 9,
		ScoringBucket_VehicleScoutHeli = 10,
		ScoringBucket_VehicleJet = 11,
		ScoringBucket_KitAssault = 12,
		ScoringBucket_KitEngineer = 13,
		ScoringBucket_KitRecon = 14,
		ScoringBucket_KitSupport = 15,
		ScoringBucket_SinglePlayer = 16,
		ScoringBucket_Cooperation = 17,
		ScoringBucket_CoopIndivid = 18,
		ScoringBucket_Unlock = 19,
		ScoringBucket_SpecialKit = 20,
		ScoringBucket_VehicleLBT = 21,
		ScoringBucket_VehicleArtillery = 22,
		ScoringBucket_LastScoringBucketItem = 23
	}

}
