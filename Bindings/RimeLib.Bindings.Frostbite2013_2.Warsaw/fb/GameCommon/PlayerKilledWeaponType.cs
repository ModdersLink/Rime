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


namespace fb.GameCommon;

[ContainerType(1, 4)]
public enum PlayerKilledWeaponType : int
{
	PlayerKilledWeaponType_Unknown = 0,
	PlayerKilledWeaponType_HandheldWeapon = 1,
	PlayerKilledWeaponType_Vehicle = 2,
	PlayerKilledWeaponType_Count = 3,
}

