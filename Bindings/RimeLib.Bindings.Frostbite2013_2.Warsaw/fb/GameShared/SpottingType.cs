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
public enum SpottingType : int
{
	STGunner = 0,
	STSquadLeader = 1,
	STDefault = 2,
	STPersonal = 3,
	STSnapshot = 4,
	STSquadUav = 5,
	STTypesCount = 6,
}

