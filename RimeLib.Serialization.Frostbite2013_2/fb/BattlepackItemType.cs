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
public enum BattlepackItemType : int
{
	BattlepackItemType_Accessory = 0,
	BattlepackItemType_Boost = 1,
	BattlepackItemType_Camo = 2,
	BattlepackItemType_Dogtag = 3,
	BattlepackItemType_Emblem = 4,
	BattlepackItemType_Icon = 5,
	BattlepackItemType_Paint = 6,
	BattlepackItemType_Knife = 7,
	BattlepackItemType_Battlelog = 8,
	BattlepackItemType_Mixed = 9,
}

