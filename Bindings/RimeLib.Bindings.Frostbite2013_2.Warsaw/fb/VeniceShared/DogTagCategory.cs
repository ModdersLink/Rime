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
public enum DogTagCategory : int
{
	DTC_Invalid = 0,
	DTC_Ribbons = 1,
	DTC_Medals = 2,
	DTC_Ranks = 3,
	DTC_ServiceStars = 4,
	DTC_Weapons = 5,
	DTC_Misc = 6,
	DTC_Vehicles = 7,
	DTC_MPAssignments = 8,
	DTC_SPAssignments = 9,
	DTC_Premium = 10,
	DTC_Promotion = 11,
	DTC_Battlepacks = 12,
	DTC_Flags = 13,
	DTC_Kits = 14,
	DTC_Mission = 15,
	DTC_Excusive = 16,
}

