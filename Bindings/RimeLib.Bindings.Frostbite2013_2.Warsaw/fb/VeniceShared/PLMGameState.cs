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
public enum PLMGameState : int
{
	PLMGameState_MenuMain = 0,
	PLMGameState_MenuOptions = 1,
	PLMGameState_MenuCredits = 2,
	PLMGameState_MenuPremium = 3,
	PLMGameState_MenuSoldier = 4,
	PLMGameState_MenuStore = 5,
	PLMGameState_MenuSingleplayer = 6,
	PLMGameState_MenuMultiplayer = 7,
	PLMGameState_IngameSingleplayer = 8,
	PLMGameState_Count = 9,
}

