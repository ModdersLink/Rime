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


namespace fb.Venice;

[ContainerType(1, 4)]
public enum UnlockEntityPlayerQueryType : int
{
	UnlockEntityPlayerQueryType_ActiveWeaponUnlocks = 0,
	UnlockEntityPlayerQueryType_AllWeaponUnlocks = 1,
	UnlockEntityPlayerQueryType_PlayerUnlocks = 2,
	UnlockEntityPlayerQueryType_EquippedDogtagUnlocks = 3,
	UnlockEntityPlayerQueryType_VisualUnlocks = 4,
}

