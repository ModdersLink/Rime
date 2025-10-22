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
public enum AntSpeedLevel : int
{
	AntSpeedLevel_Still = 0,
	AntSpeedLevel_Walk = 1,
	AntSpeedLevel_Jog = 2,
	AntSpeedLevel_Sneak = 3,
	AntSpeedLevel_Run = 4,
	AntSpeedLevel_Sprint = 5,
	AntSpeedLevel_Stairs_Walk_Up = 6,
	AntSpeedLevel_Stairs_Walk_Down = 7,
	AntSpeedLevel_Stairs_Run_Up = 8,
	AntSpeedLevel_Stairs_Run_Down = 9,
	AntSpeedLevel_Stairs_Sprint_Up = 10,
	AntSpeedLevel_Stairs_Sprint_Down = 11,
	AntSpeedLevel_AntEnumCount = 12,
	AntSpeedLevel_NoChange = 13,
	AntSpeedLevel_Count = 14,
}

