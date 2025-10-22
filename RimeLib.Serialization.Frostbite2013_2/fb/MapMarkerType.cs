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


namespace fb.GameShared;

[ContainerType(1, 4)]
public enum MapMarkerType : int
{
	MMTMissionObjective = 0,
	MMTSecondaryMissionObjective = 1,
	MMTSoldier = 2,
	MMTVehicle = 3,
	MMTAmmoCrate = 4,
	MMTGeneric = 5,
	MMTFlag = 6,
	MMTTactical = 7,
	MMTWarning = 8,
}

