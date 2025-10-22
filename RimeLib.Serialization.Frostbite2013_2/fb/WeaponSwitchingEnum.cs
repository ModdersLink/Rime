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


namespace fb.SoldierShared;

[ContainerType(1, 4)]
public enum WeaponSwitchingEnum : int
{
	wsSlot0 = 0,
	wsSlot1 = 1,
	wsSlot2 = 2,
	wsSlot3 = 3,
	wsSlot4 = 4,
	wsSlot5 = 5,
	wsSlot6 = 6,
	wsSlot7 = 7,
	wsSlot8 = 8,
	wsSlot9 = 9,
	wsMaxSlots = 10,
	wsLastPrimary = 11,
	wsOtherPrimary = 12,
	wsNotUsed = 13,
	wsMeleeWeapon = 7,
}

