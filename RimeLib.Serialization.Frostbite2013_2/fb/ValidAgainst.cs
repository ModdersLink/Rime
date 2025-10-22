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


namespace fb.BFAI2Data;

[ContainerType(1, 4)]
public enum ValidAgainst : int
{
	ValidAgainst_Nothing = 0,
	ValidAgainst_Soldiers = 1,
	ValidAgainst_SoldiersAndUnshieldedVehicles = 2,
	ValidAgainst_UnshieldedVehicles = 3,
	ValidAgainst_ShieldedVehicles = 4,
	ValidAgainst_AllVehicles = 5,
	ValidAgainst_All = 6,
}

