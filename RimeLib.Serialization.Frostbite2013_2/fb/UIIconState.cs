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
public enum UIIconState : int
{
	UIIconState_Default = 0,
	UIIconState_Enemy = 1,
	UIIconState_Friendly = 2,
	UIIconState_Neutral = 3,
	UIIconState_Squad = 4,
	UIIconState_Self = 5,
	UIIconState_Team1 = 6,
	UIIconState_Team2 = 7,
	UIIconState_Team3 = 8,
	UIIconState_Team4 = 9,
	UIIconState_Commander = 10,
	UIIconState_Spectator = 11,
	UIIconState_Count = 12,
}

