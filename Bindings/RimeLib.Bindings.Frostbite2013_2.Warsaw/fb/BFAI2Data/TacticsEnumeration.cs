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
public enum TacticsEnumeration : int
{
	TacticsEnumeration_None = 0,
	TacticsEnumeration_Vehicle = 1,
	TacticsEnumeration_Charge = 2,
	TacticsEnumeration_Attack = 3,
	TacticsEnumeration_Hide = 4,
	TacticsEnumeration_Flee = 5,
	TacticsEnumeration_CloseCombat = 6,
	TacticsEnumeration_SquadMovement = 7,
	TacticsEnumeration_SquadEngage = 8,
}

