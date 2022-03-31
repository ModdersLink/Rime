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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 4)]
	public enum WeaponFiringEvent : int
	{
		WeaponFiringEvent_Push = 0,
		WeaponFiringEvent_Pop = 1,
		WeaponFiringEvent_PrimaryStartedFiringCallback = 2,
		WeaponFiringEvent_PrimaryFireCallback = 3,
		WeaponFiringEvent_PrimaryFireReleaseCallback = 4,
		WeaponFiringEvent_PrimaryFireShotSpawnedCallback = 5,
		WeaponFiringEvent_PrimaryFireAutomaticBeginCallback = 6,
		WeaponFiringEvent_PrimaryFireAutomaticEndCallback = 7,
		WeaponFiringEvent_PrimaryStoppedFiringCallback = 8,
		WeaponFiringEvent_ReloadPrimaryCallback = 9,
		WeaponFiringEvent_ReloadPrimaryEndCallback = 10,
		WeaponFiringEvent_BoltActionCallback = 11,
		WeaponFiringEvent_BoltActionEndCallback = 12,
		WeaponFiringEvent_DetonationSwitchCallback = 13,
		WeaponFiringEvent_HoldAndReleaseReleaseCallback = 14,
		WeaponFiringEvent_UpdateRequired = 15
	}

}
